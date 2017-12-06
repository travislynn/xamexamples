using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Model;

namespace Examples.Data
{
    //public class PersonDatabase
    //{
    //    public readonly SQLiteAsyncConnection database;

    //    public PersonDatabase(string dbPath)
    //    {
    //        database = new SQLiteAsyncConnection(dbPath);
    //        database.CreateTableAsync<Person>().Wait();

    //    }

    //    public Task<List<Person>> GetPeopleAsync()
    //    {
    //        return database.Table<Person>().ToListAsync();
    //    }

    //    public Task<Person> GetPersonAsync(int id)
    //    {
    //        return database.Table<Person>().Where(p => p.Id == id).FirstOrDefaultAsync();
    //    }

    //    public Task<int> SavePersonAsync(Person person)
    //    {
    //        if (person.Id == 0)
    //        {
    //            return database.InsertAsync(person);
    //        }
    //        else
    //        {
    //            return database.UpdateAsync(person);
    //        }
    //    }

    //    public Task<int> DeletePersonAsync(Person person)
    //    {
    //        return database.DeleteAsync(person);
    //    }
    //}
}
