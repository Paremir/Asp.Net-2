using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDLab3.Models
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Specialty()
        {
            Employees = new List<Employee>();
        }
    }
}