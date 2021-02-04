using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDLab3.Models
{
    public class Penaltie
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Penaltie()
        {
            Employees = new List<Employee>();
        }
    }
}