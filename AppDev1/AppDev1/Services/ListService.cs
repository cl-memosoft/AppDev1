using AppDev1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AppDev1.Services
{
    public class ListService
    {
        static SQLiteAsyncConnection db;

        static async Task Init()
        {
            if (db != null)
                return;

            //Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<HomeModel>();
        }

        public static async Task AddList(string lname)
        {
            await Init();

            var list = new HomeModel
            {
                ListName = lname
            };

            var id = await db.InsertAsync(list);
        }

        public static async Task RemoveList(int id)
        {
            await Init();

            await db.DeleteAsync<HomeModel>(id);
        }

        public static async Task<IEnumerable<HomeModel>> GetList()
        {
            await Init();

            var list = await db.Table<HomeModel>().ToListAsync();
            return list;
        }

        public static async Task<HomeModel> GetList(int id)
        {
            await Init();

            var list = await db.Table<HomeModel>()
                .FirstOrDefaultAsync(c => c.Id == id);

            return list;
        }
    }
}
