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
    public partial class GridPage : ContentPage
    {
        private GridPageViewModel vm;
        public GridPage()
        {
            InitializeComponent();
            vm = new GridPageViewModel();
            BindingContext = vm;
        }
    }
}