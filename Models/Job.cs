using System;
using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
    public class Job
    {
        public string Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Range(0, int.MaxValue)]
        public int Wage { get; set; }
        public string Location { get; set; }
        public Job(string jobTitle, int wage, string location)
        {
            Id = Guid.NewGuid().ToString();
            JobTitle = jobTitle;
            Wage = wage;
            Location = location;
        }
    }
}