﻿using System.ComponentModel.DataAnnotations;

namespace DesafioBelezaNaWeb.Models
{
    public class Warehouses
    {
        public string Locality { get; set; }
        
        public int Quantity { get; set; }
        
        public string Type { get; set; }
    }
}