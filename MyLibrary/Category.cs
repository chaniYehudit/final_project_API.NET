﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
       
       
    }
}
