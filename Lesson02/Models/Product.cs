﻿namespace Lesson02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

    }
}
