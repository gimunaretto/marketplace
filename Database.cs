using System.Collections.Generic;

namespace ProjetoLetsCode2
{
    public static class Database
    {

        public static List<User> Users { get; set; }


        static Database()
        {
            Users = new List<User>();
        }
    }

}