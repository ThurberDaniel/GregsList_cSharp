using System.Collections.Generic;
using GregsList.Models;


namespace GregsList.DB
{
    public static class FakeDB
    {
        public static List<Job> Jobs { get; set; } = new List<Job>(){
            new Job("CodeWorks TA", 100, "Boise, Idaho")
        };

        public static List<House> Houses { get; set; } = new List<House>(){
            new House("987 Garth Rd - Boise Idaho", 100900, 6, 3)
        };
    }
}