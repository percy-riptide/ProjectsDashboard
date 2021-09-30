using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsDashboard.Models
{
    public class Projects
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }
        public string Team { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }

        public Projects()
        {

        }
    }
}
