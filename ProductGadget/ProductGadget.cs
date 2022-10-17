namespace Exam.Shop.ProductBase
{
    public class ProductGadget : Product
    {
        public int Weigth { get; set; }
        public string CPU { get; set; }
        public string DDR { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Name:{Name} | Create:{Create:dd-MM-yyyy HH:mm} | Change:{Change:dd-MM-yyyy HH:mm} | Weigth:{Weigth} | CPU:{CPU} | DDR:{DDR}";
        }
    }
}
