using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using ProiectXamarin.Models;

namespace ProiectXamarin.Data
{
    public class MovieListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public MovieListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<MovieList>().Wait();
        }
        public Task<List<MovieList>> GetMovieListsAsync()
        {
            return _database.Table<MovieList>().ToListAsync();
        }
        public Task<MovieList> GetMovieListAsync(int id)
        {
            return _database.Table<MovieList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveMovieListAsync(MovieList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteMovieListAsync(MovieList slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
 

