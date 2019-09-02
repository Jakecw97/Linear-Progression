using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LP.Models;
using LP.Views;
using LP.Views.Exercises;

namespace LP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();
        }//HelpPage
        async void Squat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SquatWiki()));
        }//Pushes to Squat wiki page
        async void Bench_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BenchWiki()));
        }//Pushes to Bench wiki page
        async void OverHead_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OverheadWiki()));
        }//Pushes to Overhead press wiki page
        async void Deadlift_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new DeadLiftWiki()));
        }//Pushes to Deadlift wiki page
        async void Bicep_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BicepWiki()));
        }//Pushes to Bicep wiki page
        async void Tricep_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new TricepWiki()));
        }//Pushes to Tricep wiki page
        async void Reset_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Caution: Data cannot be Recovered, continue?", "Cancel", "Okay");//Prompts the user for inpute
            if (action == "Okay")
            {
                App.Database.ResetTableAsync();
            }//if okay calls the reset table function. Elso does nothing and closes prompt
        }//Reset_Clicked
    }//HelpPage
}//LP:Views