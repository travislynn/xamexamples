using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Examples.Model;
using Xamarin.Forms;

namespace Examples.ViewModel
{
    public class DataBindingPageViewModel : INotifyPropertyChanged
    {
        public DataBindingPageViewModel()
        {
            Title = "Data Binding Demos";
            People = new ObservableCollection<Person>();
            for (int i = 0; i < 5; i++)
            {
                People.Add(new Person()
                {
                    Id = i,
                    FirstName = "Travis",
                    Address = "10" + i.ToString() + " Main St",
                    ImageSource = "icon.png"

                });
            }
        }

        public string Title { get; set; }
        private string labelText = "2 Way Binding (ish) example";
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                RaisePropertyChanged();
            }
        }

        private Command changeTextCommand;
        public Command ChangeTextCommand
        {
            get
            {
                return changeTextCommand ?? (changeTextCommand = new Command(
                    () =>
                    {
                       
                        if (LabelText.IndexOf("Whatevers") > -1)
                        {
                            LabelText = LabelText + "!";
                        }
                        else if (LabelText.IndexOf("Whatever") > -1)
                        {
                            LabelText += "s";
                        }
                        else
                        {
                            LabelText = "Whatevers";
                        }
                    }));
            }
        }

        public ObservableCollection<Person> People { get; set; }

    }
}
