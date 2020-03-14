using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SQLite;
using XamarinPractice.models;
using XamarinPractice.ProfileMVVM.Model;

namespace XamarinPractice.database
{
    public class UserInfoDataBase
    {
        readonly SQLiteAsyncConnection _database;
        public UserInfoDataBase(String DBPath)
        {
            _database = new SQLiteAsyncConnection(DBPath,Constants.Flags);
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Profile>().Wait();
        }

        public Task<int> SaveUser(User user)
        {

            //DeleteUsers(users);
            return _database.InsertOrReplaceAsync(user);
        }

        public Task<List<User>> getUserInfoFromTable()
        {
            return _database.Table<User>().ToListAsync();

        }

        public Task<int> SaveProfile(Profile pc)
        {

           
            return _database.InsertOrReplaceAsync(pc);
        }

        public bool LoginValidate(string userName, string pwd)
        {
            var data = _database.Table<User>();
             var whereQuery  = data.Where(x => x.UserName == userName && x.Password == pwd).FirstOrDefaultAsync();
             Console.Write("WhereQuery" + whereQuery);
             if (whereQuery!=null)
             {
                 return true;
             }
             else
             {
                 return false;
             }

            

        }


        public  User Validatelogin(string userName,string passWord)
        {
            return _database.Table<User>().FirstOrDefaultAsync(x => x.UserName == userName && x.Password == passWord).Result;

        }

    }
}
