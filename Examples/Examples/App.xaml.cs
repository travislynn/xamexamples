using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Examples.Data;
using Xamarin.Forms;

namespace Examples
{
    public partial class App : Application
    {
        //private static PersonDatabase database;

        //public static PersonDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new PersonDatabase(
        //                DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.db3")
        //            );
        //        }
        //        return database;
        //    }
        //    set { database = value; }
        //}

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.MainPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
