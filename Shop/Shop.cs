namespace Exam.Shop
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Shop()
        {

        }

        public Shop(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
