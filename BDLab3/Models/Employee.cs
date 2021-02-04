using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDLab3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int EducationId { get; set; }
        public virtual Education Education { get; set; }

        public int SpecialtyId { get; set; }
        public virtual Specialty Specialty { get; set; }

        public int? PenaltiesId { get; set; }
        public virtual Penaltie Penalties { get; set; }

    }
}