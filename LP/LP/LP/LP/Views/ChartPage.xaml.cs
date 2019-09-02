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
    public partial class ChartPage : ContentPage
    {
        public ChartPage()
        {
            InitializeComponent();
        }
        /*  protected override  void OnAppearing()
          {
              base.OnAppearing();
              var entries = new[]
         {
           new Entry(212)
           {
               Label = "UWP",
               ValueLabel = "212",
               Color = "Blue"
           },
           new Entry(248)
           {
               Label = "Android",
               ValueLabel = "248",
               Color ="Red"
           },
           new Entry(128)
           {
               Label = "iOS",
               ValueLabel = "128",
               Color = "Pink"
           },
           new Entry(514)
           {
               Label = "Shared",
               ValueLabel = "514",
               Color = "Yellow"
          } };
           var chart = new LineChart() { Entries = entries };

          }
      */   //Could not get micro charts to incorporate properly. The above is merely test data
    }//ChartPage
}//ChartPage :ContentPage