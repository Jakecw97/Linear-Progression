using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LP.Models;
using SQLite;

namespace LP.Services
{
    public class Storage
    {
        readonly SQLiteAsyncConnection database; //establishes a way to connect to DB

        public Storage(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath); //sets the databases path and connects
            database.CreateTableAsync<Workout>().Wait(); //creates a new table for 'Workout's
        }//Storage

        public Task<List<Workout>> GetWorkoutAsync() //Retrieves Workouts from the database
        {
            return database.Table<Workout>().ToListAsync(); //Sends to a asyncronous list
        }//GetWorkoutAsync

        public Task<Workout> GetWorkoutAsync(int id) //Gets a workout based on it's primar key
        {
            return database.Table<Workout>().Where(i => i.Id == id).FirstOrDefaultAsync(); //returns the selected workout
        }//GetWorkoutAsync(id)

        public Task<int> SaveWorkoutAsync(Workout wOut) //Saves the workout
        {
            if (wOut.Id != 0) //If ID is not 0 then update the workout
            {
                return database.UpdateAsync(wOut);
            }//if 
            else //else insert it to the database
            {
                return database.InsertAsync(wOut);
            }//else
        }//SaveWorkoutAsync

        public Task<int> DeleteWorkoutAsync(Workout item) //Deletes the entire workout
        {
            return database.DeleteAsync(item);
        }//DeleteWorkoutAsync

        public void ResetTableAsync() //Deletes and Recreates an empty table, helpful to quickly erase obselete data and also to reset the auto increment
        {
           database.DropTableAsync<Workout>().Wait();
           database.CreateTableAsync<Workout>().Wait();
        }//ResetTableAsync
    }//Storage
}//LP.services
