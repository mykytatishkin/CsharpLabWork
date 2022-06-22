using Inheritance.Products;

Solution(2);

void Solution(int task)
{
    switch(task)
    {
        case 1:
            Money mon = new Inheritance.Products.Money(100, 104);
            mon.print();

            mon.Cents = 205;
            mon.print();

            Product pr = new Inheritance.Products.Product(199, 123);
            pr.print();

            pr.MakePriceLess(4, 5);
            pr.print();

            break;

        case 2:
            Inheritance.Devices.Microwave mcr = new Inheritance.Devices.Microwave("T1");
            Inheritance.Devices.Chaynik cha = new Inheritance.Devices.Chaynik("C1");

            mcr.Sound();
            mcr.Show();

            cha.Sound();
            cha.Show();
            
            break;
    }
}