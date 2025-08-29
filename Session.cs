using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery_System
{
    internal static class Session
    {
        public static SessionUser CurrentUser { get; private set; }
        public static bool IsLoggedIn => CurrentUser != null;

        public static void SignIn(SessionUser u) => CurrentUser = u;
        public static void SignOut() => CurrentUser = null;
    }
}