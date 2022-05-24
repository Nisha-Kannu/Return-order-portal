﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnOrder.Models
{
    public class ProcessRequestDTO
    {
        
        public string Name { get; set; }

        
        public string ConactNumber { get; set; }

        
        public string CreditCardNumber { get; set; }

        
        public string ComponentType { get; set; }
       
        public string ComponentName { get; set; }
        public int Qunatity { get; set; }
        
    }
}
