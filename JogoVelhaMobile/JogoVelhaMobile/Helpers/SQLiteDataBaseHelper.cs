using JogoDaVelhaXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelhaMobile.Helpers
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _db;

        public SQLiteDataBaseHelper(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Partida>().Wait();
        }

        public Task<int> Insert(Partida model)
        {
            return _db.InsertAsync(model);
        }

        public Task<List<Partida>> Search()
        {
            string sql = "SELECT * FROM Partida";

            return _db.QueryAsync<Partida>(sql);
        }
    }
}
