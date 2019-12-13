using SavingWater.Models;
using SQLite;
using System;
using System.IO;
using System.Threading.Tasks;
using Water.Models;

namespace SavingWater.Services
{
    public class UserDatabase : IUserDatabase
    {
        private SQLiteAsyncConnection _database;
        public UserDatabase()
        {
            string dbPath = GetDbPath();
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();

        }

        public async Task<int> DeleteUser(User user)
        {
            return await _database.DeleteAsync(user);
        }

        public async Task<User> GetUser()
        {
            return await _database.Table<User>().FirstOrDefaultAsync();
        }

        public async Task<int> InsertUser(User user)
        {
            return await _database.InsertAsync(user);
        }

        public async Task<int> UpdateUser(User user)
        {
            return await _database.UpdateAsync(user);
        }

        private string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDetail.db3");
        }

       
    }
}
