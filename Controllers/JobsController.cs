using System;
using System.Collections.Generic;
using GregsList.DB;
using GregsList.Models;
using GregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsList.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private readonly JobsService _service;

        public JobsController(JobsService service)
        {
            _service = service;
        }

        //GetAll
        [HttpGet]

        public ActionResult<IEnumerable<Job>> GetAll()
        {
            try
            {
                return Ok(FakeDB.Jobs);
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
                return Ok(found);
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
                Job job = _service.Create(newJob);
                return Ok(job);
            }
            catch (Exception e)
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
                Job job = _service.Edit(editJob);
                return Ok(job);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //DELETE
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteJob(string id)
        {
            try
            {
                _service.DeleteJob(id);
                return Ok("Deleted Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}