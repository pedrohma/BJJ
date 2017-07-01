using System;
namespace BJJ.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public Country Country { get; set; }
        public Address()
        {
        }
    }
}
