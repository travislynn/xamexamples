using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Model;
using static System.Math;

namespace Examples.ViewModel
{
    public class CustomTemplatePageViewModel
    {
        public CustomTemplatePageViewModel()
        {
            Random rand = new Random();

            Title = "Custom Template Demos";
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
        }

        public string Title { get; set; }

        public ObservableCollection<Person> People { get; set; }

    }
}
