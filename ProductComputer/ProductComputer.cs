namespace Exam.Shop.ProductBase
{
    public class ProductComputer : Product
    {
        public string Motherboard { get; set; }
        public string CPU { get; set; }
        public string DDR { get; set; }
        public string SSD { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Name:{Name} | Create:{Create:dd-MM-yyyy HH:mm} | Change:{Change:dd-MM-yyyy HH:mm} | CPU:{CPU} | DDR:{DDR}";
        }
    }
}
