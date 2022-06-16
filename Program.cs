Solution(3);

void Solution(int task)
{
    switch(task)
    {
        case 1:
            IndexOperatorOverloading.Magazin mg = new IndexOperatorOverloading.Magazin(3);
            mg = mg + 1;
            Console.WriteLine(mg);
            mg = mg - 4;
            Console.WriteLine(mg);
            break;
        case 2:
            IndexOperatorOverloading.Magazin market_1 = new IndexOperatorOverloading.Magazin(6);
            IndexOperatorOverloading.Magazin market_2 = new IndexOperatorOverloading.Magazin(6);

            if(market_1 == market_2)
            {
                market_1 = market_2 + 4;
            }
            else
            {
                market_2 = market_1 - 3;
            }

            Console.WriteLine(market_1);
            Console.WriteLine(market_2);
            break;
        case 3:
            IndexOperatorOverloading.BooksForReading shelf = new IndexOperatorOverloading.BooksForReading();

            shelf.AddBook("FALLOUT");
            shelf.AddBook("ALBION");
            shelf.AddBook("MINE");

            shelf.FindBook("FALLOUT");

            shelf.RemoveBook("MINE");
            shelf.FindBook("MINE");

            break;
    }
}