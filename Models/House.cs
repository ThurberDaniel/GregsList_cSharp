using System;
using System.ComponentModel.DataAnnotations;


namespace GregsList.Models
{
    public class House
    {
        public string Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Bedrooms { get; set; }

        [Range(0, int.MaxValue)]
        public int Bathrooms { get; set; }
        public House(string address, int price, int bedrooms, int bathrooms)
        {
            Id = Guid.NewGuid().ToString();
            Address = address;
            Price = price;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
        }
    }
}