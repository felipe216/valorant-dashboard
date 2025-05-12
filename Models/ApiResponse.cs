﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantStatsAPP.Models
{
    public class ApiResponse<T>
    {
        public int Status { get; set; }
        public List<T> Data { get; set; } = new();
    }
}
