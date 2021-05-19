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
    public class HousesController : ControllerBase
    {
        private readonly HousesService _service;

        public HousesController(HousesService service)
        {
            _service = service;
        }

        //GetAll
        [HttpGet]

        public ActionResult<IEnumerable<House>> GetAll()
        {
            try
            {
                return OK(FakeDB.Houses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GetById
        [HttpGet("{id}")]
        public ActionResult<House> GetById(string id)
        {
            try
            {
                House found = _service.GetById(id);
                return OK(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //POST - Create
        [HttpPost]
        public ActionResult<House> CreateHouse([FromBody] House newHouse)
        {
            try
            {
                House house = _service.CreateHouse(newHouse);
                return OK(house);
            }
            catch
            {
                return BadRequest(e.Message);
            }
        }
        //PUT (EDIT)
        [HttpPut("{id}")]
        public ActionResult<House> EditHome([FromBody] House editHouse, string id)
        {
            try
            {
                editHouse = id;
                House house = _service.EditHome(editHouse);
                return OK(house);
            }
            catch (Exception e)
            {
                returnBadRequest(e.Message);
            }
        }

        //DELETE
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteHouse(string id)
        {
            try
            {
                _service.DeleteHouse(id);
                return OK("Deleted Successfully");
            }
            catch (Expection e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}