using System;
using Examples.ViewModel;
using Xamarin.Forms;

namespace Examples.View
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = new MainPageViewModel();
            BindingContext = vm;
        }

        private void CustomTemplateButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomTemplatePage());
        }

        private void SliderButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SliderPage());
        }

        private void GridButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void DataBindingButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBindingPage());
        }

        private void BehaviorButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BehaviorPage());
        }

        private void EventToCommandButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventToCommandPage());
        }

        private void StoringDataButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StoringDataPage());
        }
    }
}
