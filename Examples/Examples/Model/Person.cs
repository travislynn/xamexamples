using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Address { get; set; }
        public string ImageSource { get; set; }
        public decimal Age { get; set; }
        public string PhoneNumber { get; set; }

        // static in memory storage
        public static List<Person> People = new List<Person>();
    }
}
