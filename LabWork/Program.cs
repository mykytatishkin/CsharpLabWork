Solution(1);

void Solution(int task)
{
    switch (task)
    {
        case 1:
            int startOfDiapason;
            int endOfDiapason;
            int result = 1;

            Console.Write("Start: ");
            startOfDiapason = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            endOfDiapason = int.Parse(Console.ReadLine());

            for (int i = startOfDiapason; i < endOfDiapason; i++)
            {
                result = result * i;
                Console.WriteLine(result);
            }
            break;

        case 2:
            bool resultFibonachi = true;

            int urNum;
            Console.Write("Enter num: "); urNum = int.Parse(Console.ReadLine());

            int fibonachiElement = 0;
            int fibonachiElementFirst = 0;
            int fibonachiElementSecond = 1;


            while (resultFibonachi)
            {

                fibonachiElement = fibonachiElementFirst + fibonachiElementSecond;
                fibonachiElementFirst = fibonachiElementSecond;
                fibonachiElementSecond = fibonachiElement;
                Console.WriteLine(fibonachiElement);

                if (urNum > fibonachiElement)
                {
                    resultFibonachi = false;
                }
            }
            Console.WriteLine("RESULT: {0}", resultFibonachi);
            break;
        case 3:
            int[] arr = { 0, 54, 432, 2, 3, 6, 43, 76 };
            bool choose;

            Console.Write("Choose sort method(true - up/false - down): "); choose = bool.Parse(Console.ReadLine());
            if (choose)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Array.Sort(arr);
                Console.WriteLine();

                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine();

                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
            }
            break;
        case 4:
            String[] rayons = {"Dniprovskiy", "Osokorki", "Darnitsa","Pozniaki" };
            LabWork.City city = new LabWork.City("Kyiv", "Ukraine",1000000, 50, rayons);

            /*
             * Другие методы тоже работают, не вижу смысла их дублировать
             */
            
            city.CCity = "Lviv";
            Console.WriteLine(city.CityPhoneCode);

            break;
        case 5:
            /*
             * 5-ое задание такое же как и 4-ое, надеюсь можно же его не делать, если я то сделал?
             */
            break;
        case 6:
            /*
             * 6-ое задание такое же как и 4-ое, надеюсь можно же его не делать, если я то сделал?
             */
            break;
        case 7:
            int[,] nums = null;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    System.Random random = new System.Random();
                    nums[i,j] = random.Next(0, 100);
                }
            }

            LabWork.Maxtrix mtrx = new LabWork.Maxtrix(nums);
            Console.WriteLine(mtrx.Max);
            Console.WriteLine(mtrx.Min);
            break;
    }
}