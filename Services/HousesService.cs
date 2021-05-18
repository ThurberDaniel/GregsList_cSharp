using System;
using System.Collections.Generic;
using GregsList.DB;
using GregsList.Models;
namespace GregsList.Services
{
    public class HousesService
    {
        //GetAll
        internal IEnumerable<House> GetAll()
        {
            return FakeDB.Houses;
        }
        //GetById
        internal House GetById(string id)
        {
            House found = FakeDB.Houses.Find(h => h.Id == id);
            if (found == null)
            {
                throw new Exception("Error - Invalid ID");
            }
            return found;
        }

        //Create (POST)
        internal House CreateHouse(House newHouse)
        {
            FakeDB.Houses.Add(newHouse);
            return newHouse;
        }

        //EDIT (PUT)
        internal House EditHome(House editHouse)
        {
            House oldHouse = GetById(editHouse.Id);
            oldHouse.Address = editHouse.Address;
            oldHouse.Price = editHouse.Price;
            oldHouse.Bedrooms = editHouse.Bathrooms;
            return oldHouse;
        }

        //Delete
        internal void DeleteHouse(string id)
        {
            House found = GetById(id);
            FakeDB.Houses.Remove(found);
        }
    }
}