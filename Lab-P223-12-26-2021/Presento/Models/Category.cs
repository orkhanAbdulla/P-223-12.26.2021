using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presento.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CardCategory> CardCategories { get; set; }
    }
}
