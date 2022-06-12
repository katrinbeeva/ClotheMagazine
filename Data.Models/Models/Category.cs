﻿using Data.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models
{
    public class Category:BaseModels
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
