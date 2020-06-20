using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Course
    {
        [DisplayName("Course ID")]
        public int Id { get; set; }
        [DisplayName("Course Name")]
        public string Name { get; set; }
        [DisplayName("Course Code")]
        public string Code { get; set; }
        [DisplayName("Course Credit")]
        public float Credit { get; set; }
        [DisplayName("Descriptions")]
        public string Descriptions { get; set; }
    }
}
