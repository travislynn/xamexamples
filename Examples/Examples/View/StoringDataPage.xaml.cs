using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Model;
using Examples.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examples.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoringDataPage : ContentPage
    {
        public StoringDataPageViewModel vm;

        public StoringDataPage()
        {
            InitializeComponent();
            vm = new StoringDataPageViewModel();
            BindingContext = vm;
        }

        //private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //    {
        //        return; // this is a deselect event
        //    }

        //    Person person = e.SelectedItem as Person;
        //    DisplayAlert("Selected", person.FirstName, "OK");

        //}

        private void AddButton_OnClicked(object sender, EventArgs e)
        {
            vm.AddToPeople();
            Navigation.PushAsync(new MainPage());
        }
    }
}