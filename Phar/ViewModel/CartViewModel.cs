﻿
using Microsoft.EntityFrameworkCore;
using Phar.Models;

namespace Phar.ViewModel
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }


        
    }
}
