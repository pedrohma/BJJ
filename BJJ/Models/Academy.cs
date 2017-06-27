using System;
namespace BJJ.Models
{
    public class Academy
    {
        public int AcademyId { get; set; }
        public string AcademyName { get; set; }
        public Address Address { get; set; }
        public Academy()
        {
        }
    }
}
