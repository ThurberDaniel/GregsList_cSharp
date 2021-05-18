using System;
using System.Collections.Generic;
using GregsList.DB;
using GregsList.Models;


namespace GregsList.Services

{
    public class JobsService
    {

        // GetAll (POST)
        internal IEnumerable<Job> GetAll()
        {
            return FakeDB.Jobs;
        }

        //GetById (POST)
        internal Job GetById(string id)
        {
            Job found = FakeDB.Jobs.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }


        //CREATE (POST)
        internal Job Create(Job newJob)
        {
            FakeDB.Jobs.Add(newJob);
            return newJob;
        }


        //EDIT (PUT)
        internal Job Edit(Job editJob)
        {
            Job oldJob = GetById(editJob.Id);
            oldJob.JobTitle = editJob.JobTitle;
            oldJob.Wage = editJob.Wage;
            oldJob.Location = editJob.Location;
            return oldJob;
        }

        internal void DeleteJob(string id)
        {
            Job found = GetById(id);
            FakeDB.Jobs.Remove(found);
        }
    }
}
