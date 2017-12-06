using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examples.ViewModel
{
    public class MessagesPageViewModel
    {
        public string Title { get; set; }
        public ICommand ButtonClickCommand { get; set; }

        public MessagesPageViewModel()
        {
            Title = "Messages Demo";
            ButtonClickCommand = new Command(HandleButtonClick);
        }

        protected void HandleButtonClick()
        {
            MessagingCenter.Send<MessagesPageViewModel>(this, "ButtonClicked");
        }
    }
}
