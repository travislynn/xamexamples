using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Examples.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examples.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagesPage : ContentPage
    {
        

        public MessagesPage()
        {
            InitializeComponent();
            BindingContext = new MessagesPageViewModel();
            MessagingCenter.Subscribe<MessagesPageViewModel>(new MessagesPageViewModel(), "ButtonClicked",
                (sender) =>
                {
                    DisplayAlert("Heyooo", "The button was clicked", "OK", "Nay");
                });
        }

        
    }
}