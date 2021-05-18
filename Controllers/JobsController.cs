using System;
using System.Collections.Generic;
using cats.DB;
using cats.Models;
using cats.Services;
using Microsoft.AspNetCore.Mvc;



namespace GregsList.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _service;

        public JobsController(JobsService service)
        {
            _service = service;
        }

        //GetAll
        [HttpGet]

        public ActionResults<IEnumerable<Job>> GetAll()
        {
            try
            {
                return OK(FakeDB.Jobs);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GetById
        [HttpGet("{id}")]
        public ActionResult<Job> GetById(string id)
        {
            try
            {
                Job found = _service.GetById(id);
                return OK(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //POST
        [HttpPost]
        public ActionResult<Job> CreateJob([FromBody] Job newJob)
        {
            try
            {
                Job job = _service.CreateJob(newJob);
                return OK(job);
            }
            catch
            {
                return BadRequest(e.Message);
            }
        }
        //PUT
        [HttpPut("{id}")]
        public ActionResult<Job> EditWork([FromBody] Job editJob, string id)
        {
            try
            {
                editJob = id;
                Job job = _service.EditWork(editJob);
                return OK(job);
            }
            catch (Exception e)
            {
                returnBadRequest(e.Message);
            }
        }

        //DELETE
        [HttpDelete("{id}")]
        public ACtionResult<string> DeleteJob(string id)
        {
            try
            {
                _service.DeleteJob(id);
                return OK("Deleted Successfully");
            }
            catch (Expection e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}