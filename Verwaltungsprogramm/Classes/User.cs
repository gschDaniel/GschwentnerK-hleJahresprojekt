using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verwaltungsprogramm.Classes
{
    public static class User
    {
        public static string UserName;
        public static Role UserRole;
    }

    public enum Role
    {
        DefaultUser,
        Admin
    }
}
