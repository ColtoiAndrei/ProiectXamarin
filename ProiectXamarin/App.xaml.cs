using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectXamarin.Data;
using System.IO;

namespace ProiectXamarin
{
    public partial class App : Application
    {
        static MovieListDatabase database;
        public static MovieListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MovieListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MovieList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
