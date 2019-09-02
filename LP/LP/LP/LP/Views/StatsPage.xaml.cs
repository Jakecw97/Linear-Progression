using LP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LP.Views
{
	
	public partial class StatsPage : ContentPage
	{
        public StatsPage()
        {
            InitializeComponent();
        }//StatsPage

        protected override async void OnAppearing() //When the page appears
        {
            base.OnAppearing();
            ((App)App.Current).ResumeWorkoutId = -1;
            ItemsListView.ItemsSource = await App.Database.GetWorkoutAsync(); //Fetches the workouts stored in the database, and adds them to the list view. Waits for the workouts to be loaded from DB first.
        }//OnAppearing

        async void AddWorkout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutPage //waits for new workout page to be displayed
            {
                BindingContext = new Workout()// Saves the new workout to db
            });//await
        }//AddWorkout

        async void OnWorkoutSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)//If the selectied item is not null then pushes to a new workoutpage
            {
                await Navigation.PushAsync(new WorkoutPage
                {
                    BindingContext = e.SelectedItem as Workout //Displays the selected workouts data
                });//await
            }//if
        }//OnWorkoutSelected
    }//StatsPage
}//LP.Views
