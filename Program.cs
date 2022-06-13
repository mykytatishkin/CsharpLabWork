using static System.Console;

Random rnd = new Random();
Solution(3);

void Solution(int task)
{
    switch (task)
    {
        case 1:
            char ? symbol = null;
            int ? side = null;
            int ? size = null;

            Console.Write("Enter symdol: "); symbol = char.Parse(Console.ReadLine());
            Console.Write("Enter size: "); side = int.Parse(Console.ReadLine());

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Write(symbol);

                }
                Console.WriteLine();
            }
            break;
        case 2:
            String num;
            Write("Enter num: "); num = ReadLine();

            String num1 = num.ToCharArray().Reverse().ToString();
            if (num == num1)
            {
                Console.WriteLine("PALINDROM");
            }
            else
            {
                Console.WriteLine("NOOOOOOOOOOOOOOOOOOO");
            }

            break;
        case 3:
            HashSet<int> filteredNumbers = new HashSet<int>();
            int[] firstNumbers = new int[5];
            int[] secondNumbers = new int[5];

            arrayFill(firstNumbers, 5);
            arrayFill(secondNumbers, 5);

            for(int i = 0; i < 5; i++)
            {
                filteredNumbers.Add(firstNumbers[i]);
                filteredNumbers.Add(secondNumbers[i]);
            }
            
            foreach(int element in filteredNumbers)
            {
                Write(element + " ");
            }
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;

    }
}

void arrayFill(int[] arr, int size)
{
    for(int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 25);
        Write(arr[i] + " ");
    }
    WriteLine();
}