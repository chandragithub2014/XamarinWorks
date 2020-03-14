using System;
using SQLite;

namespace XamarinPractice.models
{
    public class User
    {
       
        [PrimaryKey]
        public String UserName { get; set; }
       
        public String Password { get; set; }

        public String Name { get; set; }

        public String Place { get; set; }

        public override string ToString()
        {
            return UserName;
        }

    }
    
}
