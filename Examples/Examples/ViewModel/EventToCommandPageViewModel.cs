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
    public class EventToCommandPageViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public ObservableCollection<Person> People { get; set; }
        public ICommand ItemSelectedCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private string selectedItemText;
        public string SelectedItemText
        {
            get { return selectedItemText; }
            set
            {
                selectedItemText = value;
                RaisePropertyChanged();
            }
        }


        public EventToCommandPageViewModel()
        {
            Random rand = new Random();

            Title = "Event to Command Demo";

            People = new ObservableCollection<Person>();

            for (int i = 0; i < 7; i++)
            {
                People.Add(new Person()
                {
                    Id = i,
                    FirstName = "Travis",
                    LastName = (i * 2).ToString(),
                    Address = "10" + i.ToString() + " Main St",
                    ImageSource = "icon.png",
                    Age = (decimal)(31 + (rand.NextDouble() * 2.5))
                });
            }

            ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        }

        protected void HandleItemSelected(Person person)
        {
            SelectedItemText = $"{person.FirstName} {person.LastName}";
        }

        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
