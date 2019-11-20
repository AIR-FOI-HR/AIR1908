using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using database;
using System.IO;

namespace DiscountLocator19
{
    public partial class App : Application
    {
        static MyDatabase database;

        public static database.MyDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MyDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
