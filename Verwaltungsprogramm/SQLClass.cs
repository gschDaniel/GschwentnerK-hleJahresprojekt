using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using Verwaltungsprogramm.Classes;

namespace Verwaltungsprogramm
{
    public static class SQLClass
    {
        private static string format = "yyyy-MM-dd HH:mm:ss";
        //private static MySqlConnection connection;
        public static void Initialize()
        {
            SQL.SetConnectionString("Data Source = (localdb)\\MSSQLLocalDB; TrustServerCertificate = True; Integrated Security = False;");

            if (SQL.ConWorks())
            {
                SQL.CreateDatabase("4ITK_GschwentnerKoehle_Books");
                SQL.SetConnectionString(SQL.connection.ConnectionString + " Database = 4ITK_GschwentnerKoehle_Books");

                SQL.Execute("Create Database if not exists 4ITK_GschwentnerKoehle_Books");
                //Books(add, delete, show)
                SQL.Execute("IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type in (N'U')) " +
                   "BEGIN " +
                   "CREATE TABLE Books(" +
                   "[Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                   "[Barcode] VARCHAR(50) NULL," +
                   "[Titel] VARCHAR(50) NULL," +
                   "[Autor] VARCHAR(50) NULL," +
                   "[Beschreibung] VARCHAR(MAX) NULL," +
                   "[Genre] VARCHAR(50) NULL," +
                   "[BücherÜbrig] INT NULL," +
                   "[Veröffentlichung] DATE NULL);" +
                   "END");

                // UserTable
                SQL.Execute("IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U')) " +
                  "BEGIN " +
                  "CREATE TABLE Users(" +
                  "[Id] INT NOT NULL PRIMARY KEY IDENTITY," +
                  "[Vorname] VARCHAR(50) NULL," +
                  "[Nachname] VARCHAR(50) NULL," +
                  "[Username] VARCHAR(50) NULL," +
                  "[Password] VARCHAR(MAX) NULL," +
                  "[Role] VARCHAR(MAX) NULL);" +
                  "END");

                DataTable dt = SQL.GetData("Select * from Users where Username='aa';");

                if (dt.Rows.Count == 0)
                    SQL.Execute("Insert into Users (Username, Password, Vorname, Nachname, Role) values ('aa','$2a$11$kucOADvM.hVS2HEQ2Q./HOM1n59EIedIHHbsS81rKkHxnfE/KxbzK','Daniel','Gschwentner', '"+ Role.Admin +"');");

                //// Book rental maybe add ForeignKeyConstraint to Book
                SQL.Execute("IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentedTo]') AND type in (N'U')) " +
                   "BEGIN " +
                   "CREATE TABLE RentedTo(" +
                   "[Id] INT NOT NULL PRIMARY KEY IDENTITY," +
                   "[AusgeliehenAm] DATE NULL," +
                   "[AusgeliehenBis] DATE NULL," +
                   "[UserId] INT NULL," +
                   "[BuchId] INT NOT NULL);" +
                   "END");   
            }
        }

        public static bool Login(string username, string password)
        {
            DataTable dt = SQL.GetData("Select * from Users where username='" + username + "';");
            if (dt.Rows.Count > 0)
            {
                DataRow dataRow = dt.Rows[0];
                string hashedPW = dataRow["Password"].ToString();

                return BC.Verify(password, hashedPW);
            }

            return false;
        }


        public static bool Register(string username, string password, string prename, string surname)
        {
            DataTable dt = SQL.GetData("Select * from Users where username='" + username + "';");

            if (dt.Rows.Count <= 0)
            {
                SQL.Execute("Insert into Users (Username, Password, Vorname, Nachname, Role) values ('" + username + "','" + BC.HashPassword(password) + "','" + prename + "','" + surname + "', '" + Role.DefaultUser + "');");
                return true;
            }

            return false;
        }

        public static DataTable LoadBooks()
        {
            return SQL.GetData("Select * from Books;");
        }

        public static DataTable LoadUsersWOPW()
        {
            DataTable dt = SQL.GetData("Select * from Users;");
            dt.Columns.Remove("Password");
            dt.Columns.Remove("Role");
            return dt;
        }

        public static DataTable RentedBooksAndUser()
        {
            DataTable dt = SQL.GetData("Select * from RentedTo;");
            dt.Columns.Add("Username");
            dt.Columns.Add("BuchTitel");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int rentalId = (int)dt.Rows[i]["Id"];
                int bookId = GetBookIdFromRental(rentalId);
                int userId = GetUserIdFromRental(rentalId);
                DataTable book = SQL.GetData("Select Titel from Books where Id ='" + bookId + "';");
                DataTable user = SQL.GetData("Select Username from Users where Id ='" + userId + "';");

                dt.Rows[i]["Username"] = user.Rows[0]["Username"].ToString();
                dt.Rows[i]["BuchTitel"] = book.Rows[0]["Titel"].ToString();
            }

            return dt;
        }

        public static Book GetBookByBarcode(string barcode)
        {
            DataTable dt = SQL.GetData("Select * from Books where Barcode = '" + barcode + "';");

            if (dt.Rows.Count > 0)
            {
                DataRow dataRow = dt.Rows[0];
                Book temp = DataRowToBook(dataRow);
              
                return temp;
            }

            return null;
        }

        public static Book DataRowToBook(DataRow dataRow)
        {
            Book temp = new Book();
            temp.Id = (int)dataRow["Id"];
            temp.Barcode = dataRow["Barcode"].ToString();
            temp.Title = dataRow["Titel"].ToString();
            temp.Author = dataRow["Autor"].ToString();
            temp.Description = dataRow["Beschreibung"].ToString();
            temp.Genre = dataRow["Genre"].ToString();
            temp.ReleaseDate = DateTime.Parse(dataRow["Veröffentlichung"].ToString());
            temp.BooksLeft = (int)dataRow["BücherÜbrig"];

            return temp;
        }

        public static bool AddBook(Book book)
        {
            DataTable dataTable = SQL.GetData("Select * from Books where titel='" + book.Title + "';");

            if (dataTable.Rows.Count == 0)
            {
                
                SQL.Execute("Insert into Books (Barcode, Titel, Autor, Beschreibung, Genre, Veröffentlichung, BücherÜbrig) values ('" + book.Barcode + "','" + book.Title + "','" + book.Author + "','" + book.Description + "'," +
                    "'" + book.Genre + "','" + book.ReleaseDate.Date.ToString(format) + "','" + book.BooksLeft + "');");
                //SQL.Execute("Insert into Books (Titel, Autor, Beschreibung, Genre, Veröffentlichung, BücherÜbrig) values " +
                //  "('" + book.Title + "','" + book.Author + "','" + book.Description + "'," +
                //    "'" + book.Genre
                // SQL.Execute("Insert into Books (Titel, Autor, Beschreibung) values ('" + book.Title + "','" + book.Author + "');");
                return true;
            }

            return false;
        }

        //change this to bool
        public static bool RentBook(int userId, int bookId, DateTime rentedAt, DateTime rentedTill)
        {
            SQL.Execute("Insert into RentedTo (AusgeliehenAm, AusgeliehenBis, UserId, BuchId) values  ('" + rentedAt.Date.ToString(format) + "','" + rentedTill.Date.ToString(format) + "','" + userId + "','" + bookId+"')");
            if (AddBookAmount(bookId, +1) == -1)
            {
                return false;
            }
            return true;
        }

        private static bool RentBook(Book book, DateTime rentedAt, DateTime rentedTill, int userId)
        {
            int bookId = GetBookId(book);
            return RentBook(userId, bookId, rentedAt, rentedTill);
        }

        //change this to bool
        public static bool ReturnBook(int rentalId)
        {
            // ToDo: Update RentedTo
            int bookId = GetBookIdFromRental(rentalId);
    
            SQL.Execute("Delete from RentedTo where Id ='" + rentalId + "';");

            AddBookAmount(bookId, +1);
            return true;
        }

        //public static T GetField<T>(string tableName, string whereField, string whereValue, string field)
        //{
        //    DataTable dt = SQL.GetData("Select * from " + tableName + " where " + whereField + "='" + whereValue + "';");

        //    if (dt.Rows.Count > 0)
        //    {
        //        DataRow dataRow = dt.Rows[0];

        //        T bookId = (T)dataRow[field];
        //        return bookId;
        //    }
        //    return -1;
        //}

        public static int GetIntFromTable(string tableName, string whereConditinon, string field)
        {
            DataTable dt = SQL.GetData("Select * from " + tableName + " where " + whereConditinon + ";");

            if (dt.Rows.Count > 0)
            {
                DataRow dataRow = dt.Rows[0];

                int bookId = (int)dataRow[field];
                return bookId;
            }
            return -1;
        }

        public static int GetBookIdFromRental(int rentalId)
        {
           return GetIntFromTable("RentedTo", "Id = '" + rentalId + "'", "BuchId");
        }

        public static int GetUserIdFromRental(int rentalId)
        {
            return GetIntFromTable("RentedTo", "Id = '" + rentalId + "'", "UserId");
        }

        public static int GetBookId(Book book)
        {
            DataTable dt = SQL.GetData("Select * from books where titel='" + book.Title + "';");

            if (dt.Rows.Count > 0)
            {
                DataRow dataRow = dt.Rows[0];

                int bookId = (int)dataRow["Id"];
                return bookId;
            }
            return -1;
        }

        public static int AddBookAmount(int bookId, int numberToAdd)
        {
            DataTable dt = SQL.GetData("Select * from books where Id='" + bookId + "';");

            if (dt.Rows.Count > 0)
            {
                DataRow dataRow = dt.Rows[0];

                int booksLeft = (int)dataRow["BücherÜbrig"];

                booksLeft += numberToAdd;
                if (booksLeft >= 0)
                {
                    SQL.Execute("Update Books set BücherÜbrig='" + booksLeft + "' where Id='" + bookId + "';");
                    return booksLeft;
                }           
            }
            return -1;
        }

        public static void RemoveBook(int bookId)
        {
            SQL.Execute("Delete from Books where Id='" + bookId + "';");
        }
    }
}
