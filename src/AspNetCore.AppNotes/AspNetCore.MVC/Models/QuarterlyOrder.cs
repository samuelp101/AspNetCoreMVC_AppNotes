﻿using System;
using System.Collections.Generic;

namespace AspNetCore.MVC.Models
{
    public partial class QuarterlyOrder
    {
        public int? CustomerId { get; set; }
        public string? CompanyName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
