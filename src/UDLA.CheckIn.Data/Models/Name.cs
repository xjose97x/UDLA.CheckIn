using Microsoft.EntityFrameworkCore;

namespace UDLA.CheckIn.Data.Models
{
    [Owned]
    public class Name
    {
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{GivenName} {LastName}";

        public Name(string givenName, string lastName)
        {
            GivenName = givenName;
            LastName = lastName;
        }
    }
}
