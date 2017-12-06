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
    public partial class CustomTemplatePage : ContentPage
    {
        public CustomTemplatePage()
        {
            InitializeComponent();
            BindingContext = new CustomTemplatePageViewModel();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; // this is a deselect event
            }

            Person person = e.SelectedItem as Person;
            DisplayAlert("Selected", person.FirstName, "OK");

        }
    }
}