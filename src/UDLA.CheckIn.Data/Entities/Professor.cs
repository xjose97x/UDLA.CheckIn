using UDLA.CheckIn.Data.Models;
using System.Collections.Generic;

namespace UDLA.CheckIn.Data.Entities
{
    public class Professor: Entity
    {
        public Name Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<EntryRecord> EntryRecords { get; set; }

        public Professor(int id, Name name, string email, string phoneNumber, int facultyId)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            FacultyId = facultyId;
        }

        //https://github.com/aspnet/EntityFrameworkCore/issues/12004#issuecomment-389715911
        public Professor(int id, string email, string phoneNumber, int facultyId)
        {
            Id = id;
            Email = email;
            PhoneNumber = phoneNumber;
            FacultyId = facultyId;
        }

        private Professor()
        {
            
        }
    }
}
