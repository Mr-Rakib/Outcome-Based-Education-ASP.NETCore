using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class RegistrationInformation
    {
        [DisplayName("Registration Information ID")]
        public int Id { get; set; }
        [DisplayName("Semester ID")]
        public int SemesterId { get; set; }
        public Course Course { get; set; }
        [DisplayName("Faculty ID")]
        public int FacultyId { get; set; }
        [DisplayName("Class Day")]
        public string ClassDay { get; set; }
        [DisplayName("Time Start")]
        public TimeSpan ClassTimeStart { get; set; }
        [DisplayName("Time End")]
        public TimeSpan ClassTimeEnd { get; set; }
        [DisplayName("Room Number")]
        public string RoomNumber { get; set; }
        [DisplayName("Seat Limit")]
        public int Limit { get; set; }
    }
}
