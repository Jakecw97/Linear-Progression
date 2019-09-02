using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LP.Views;
using LP.Services;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LP
{
    public partial class App : Application
    {
        static Storage database;

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }
        public static Storage Database //Initialises database for the application
        {
            get
            {
                if (database == null) //If database is null create new database
                {
                    database = new Storage(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Workout.db3"));
                }
                return database;
            }
        }

        public int ResumeWorkoutId { get; set; }

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
