﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presento.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<CardCategory> CardCategories { get; set; }
    }
}
