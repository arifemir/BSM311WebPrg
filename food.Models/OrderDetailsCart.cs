﻿using System;
using System.Collections.Generic;
using System.Text;

namespace food.Models
{
    public class OrderDetailsCart
    {
        public List<ShoppingCart> listCart { get; set; }
        public OrderHeader OrderHeader { get; set; }

    }
}
