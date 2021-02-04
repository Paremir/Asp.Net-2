using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDLab3.Models
{
    public class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SalaryId { get; set; }
        public virtual Salarie Salary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Position()
        {
            Employees = new List<Employee>();
        }
    }
}