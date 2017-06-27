using System;
namespace BJJ.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public Country Country { get; set; }
        public Address()
        {
        }
    }
}
