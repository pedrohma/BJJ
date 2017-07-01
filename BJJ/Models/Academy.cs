using System;
namespace BJJ.Models
{
    public class Academy
    {
        public int AcademyId { get; set; }
        public string AcademyName { get; set; }
        public string AcademyEmail { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public Academy()
        {
        }
    }
}
