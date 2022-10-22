using System;

namespace Exam.Shop.ProductBase
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public DateTime Create { get; set; }
        public DateTime Change { get; set; }
    }
}
