﻿using Backend.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
    public class Log: BaseEntityExtended
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public TypeLog Type { get; set; }
    }
}
