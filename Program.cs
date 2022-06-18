Console.ForegroundColor = ConsoleColor.Blue;
Solution(1);

void Solution(int task)
{
    switch(task)
    {
        case 1:
            OperatorOverloadingLabo.Worker work1 = new OperatorOverloadingLabo.Worker(100);
            OperatorOverloadingLabo.Worker work2 = new OperatorOverloadingLabo.Worker();

            Console.WriteLine(work1.Salary);
            Console.WriteLine(work2.Salary);

            work2 = work2 + 500;
            work1 = work2 - 300;

            Console.WriteLine(work1.Salary);
            Console.WriteLine(work2.Salary);

            Console.WriteLine(work1 == work2);

            break;
        case 2:
            // Все последующие задания аналогичные и зачем их писать?
            break;
    }
}