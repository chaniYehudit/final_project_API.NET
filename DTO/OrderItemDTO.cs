﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        //public int OrderId { get; set; }
        public int? Quantity { get; set; }
        
    }
}
