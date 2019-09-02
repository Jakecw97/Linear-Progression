using LP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LP.Views
{
    public partial class WorkoutPage : ContentPage
    {
        public WorkoutPage()
        {
            InitializeComponent();
        }//WorkoutPage

        async void Save_Clicked(object sender, EventArgs e)
        {
            //Initialises workout as a variable to be stored
            var workout = (Workout)BindingContext;
            //calls the save workout function
            await App.Database.SaveWorkoutAsync(workout);
            //pops the current page off, returning to the previous
            await Navigation.PopAsync();
        }//Save_Clicked

        async void Delete_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Caution: Data cannot be Recovered, continue?", "Cancel", "Okay"); //Prompts user input
            if (action == "Okay") //If okay then calls the DeletWorkout function, with the 'workout' as a pointer, pops back to previous page
            {
                var workout = (Workout)BindingContext;
                await App.Database.DeleteWorkoutAsync(workout);
                await Navigation.PopAsync();
            }//Else the prompt closes and nothing happens.
        }//Delete_Clicked

    }//WorkoutPage
}//Lp.Views
