using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP.Models
{
    public class Workout //Skeleton for each Workout
    {
        [PrimaryKey, AutoIncrement] //Auto increments the ID for each new entry
        public int Id { get; set; }
        public float   Squat { get; set; }
        public float Bench { get; set; }
        public float Deadlift { get; set; }
        public float OverHead { get; set; }
        public float Bicep { get; set; }
        public float Tricep { get; set; }
      
    }//Workout
}//Lp.Models
