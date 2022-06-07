System.Random random = new System.Random();
Solution(2);

void Solution(int tasks)
{
    switch(tasks)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            int[] arr1 = new int[5];
            double[,] arr2 = new double[3, 4];

            int max1; double max2 = -1; double maxMax;
            int min1; double min2 = 59; double minMin;
            int sum1 = 0; double sum2 = 0; double sumSum;
            int mult1 = 1; double mult2 = 1; double multMunlt;
            int chet1 = 0; double chet2 = 0; double chetChet;
            int neChet1 = 0; double neChet2 = 0; double neChetNeChet;

            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0; j < 3; j++)
            {
                for(int p = 0; p < 4; p++)
                {
                    arr2[j,p] = random.Next(0, 58);
                    Console.Write(arr2[j,p] + " ");
                }
                Console.WriteLine();
            }

            Array.Sort(arr1);

            for(int y = 0; y < 3; y++)
            {
                for(int h = 0; h < 4; h++)
                {
                    if (arr2[y,h] < min2)
                    {
                        min2 = arr2[y, h];
                    }
                    if (arr2[y, h] > max2)
                    {
                        max2 = arr2[y, h];
                    }
                }
            }


            min1 = arr1[0];
            if(min1 < min2)
            {
                minMin = min1;
            }
            else
            {
                minMin = min2;
            }

            max1 = arr1[4];
            if (max1 < max2)
            {
                maxMax = max2;
            }
            else
            {
                maxMax = max1;
            }

            for(int x = 0; x < arr1.Length; x++)
            {
                sum1 = sum1 + arr1[x];
                mult1 = mult1 + arr1[x];
                if (arr1[x] % 2 == 0)
                {
                    chet1 = chet1 + arr1[x];
                }
                if (arr1[x] % 2 != 0)
                {
                    neChet1 = neChet1 + arr1[x];
                }
            }

            Console.WriteLine("\nMIN_1: {0}\nMAX_1: {1}\nSUM_1: {2}\nMULTYPLY_1: {3}\nCHET_SUM_1: {4}\nNE_CHET_SUM_1: {5}",
                min1, max1, sum1, mult1, chet1, neChet1);

            for (int y = 0; y < 3; y++)
            {
                for (int h = 0; h < 4; h++)
                {
                    sum2 = sum2 + arr2[y, h];
                    mult2 = mult2 * arr2[y, h];
                    if (arr2[y,h] % 2 == 0)
                    {
                        chet2 = chet2 + arr2[y, h];
                    }
                    if (arr2[y, h] % 2 != 0)
                    {
                        neChet2 = neChet2 + arr2[y, h];
                    }
                }
            }

            Console.WriteLine("MIN_2: {0}\nMAX_2: {1}\nSUM_2: {2}\nMULTYPLY_2: {3}\nCHET_SUM_2: {4}\nNE_CHET_SUM_2: {5}",
                min2, max2, sum2, mult2, chet2, neChet2);

            sumSum = sum1 + sum2;
            multMunlt = mult1 * mult2;
            chetChet = chet1 * chet2;
            neChetNeChet = neChet1 + neChet2;

            Console.WriteLine("\nSUM_SUM: {0}\nMULT_MULT: {1}\nCHET_CHET: {2}\nNECHET_NECHET: {3}",
                sumSum, multMunlt, chetChet, neChetNeChet);
            Console.ResetColor();
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Blue;

            int[,] nums = new int[5, 5];
            int max = -101; int min = 101; int sum = 0;
            
            
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    nums[i, j] = random.Next(-100, 100);
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (nums[i, j] > max)
                    {
                        max = nums[i, j];
                    }

                    if (nums[i, j] < min)
                    {
                        min = nums[i, j];
                    }
                }
            }

            while(min < max)
            {
                sum = sum + min;
                min++;
            }

            Console.WriteLine("\nMIN: {0}\nMAX: {1}\nSUM: {2}", min, max, sum);
            Console.ResetColor();
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ResetColor();
            break;
    }
}