using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Examples.Model;
using Xamarin.Forms;

namespace Examples.ViewModel
{
    public class StoringDataPageViewModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public StoringDataPageViewModel()
        {
            Title = "Storing Data Demos";

            Person person = new Person();
            person.FirstName = "George";
            person.LastName = "Washington";
            person.PhoneNumber = "1777";
            People.Add(person);

            //PopulatePeople();


        }

        //private async void PopulatePeople()
        //{
        //    //var peopleDb = await App.Database.GetPeopleAsync();

        //    //foreach (Person p in peopleDb)
        //    //{
        //    //    People.Add(p);
        //    //}
        //}


        public void AddToPeople()
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.PhoneNumber = PhoneNumber;

            //Person.People.Add(person);
            //App.Database.SavePersonAsync(person);
        }
    }
}
