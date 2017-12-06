using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ViewModel
{
    public class GridPageViewModel
    {
        public string Prompt { get; set; }
        public string Name { get; set; }

        public GridPageViewModel()
        {
            Prompt = "Full Name:";
            Name = "Joe Schmoe";
        }
    }
}
