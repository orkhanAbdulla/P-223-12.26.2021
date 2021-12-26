using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presento.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public List<Social> Socials { get; set;}
    }
}
