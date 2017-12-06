using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examples.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventToCommandPage : ContentPage
    {
        public EventToCommandPage()
        {
            InitializeComponent();
            BindingContext = new EventToCommandPageViewModel();
        }
    }
}