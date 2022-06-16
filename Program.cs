Solution(1);

void Solution(int task)
{
    switch (task)
    {
        case 1:
            int changeNum;
            String newNum;

            Console.Write("Enter a number to chgange it to 01010: "); changeNum = int.Parse(Console.ReadLine());

            if(changeNum >= 0 && changeNum <= 16)
            {
                switch (changeNum)
                {
                    case 0:
                        newNum = "0000";
                        Console.WriteLine(newNum);
                        break;
                    case 1:
                        newNum = "0001";
                        Console.WriteLine(newNum);
                        break;
                    case 2:
                        newNum = "0010";
                        Console.WriteLine(newNum);
                        break;
                    case 3:
                        newNum = "0011";
                        Console.WriteLine(newNum);
                        break;
                    case 4:
                        newNum = "0100";
                        Console.WriteLine(newNum);
                        break;
                    case 5:
                        newNum = "0101";
                        Console.WriteLine(newNum);
                        break;
                    case 6:
                        newNum = "0110";
                        Console.WriteLine(newNum);
                        break;
                    case 7:
                        newNum = "0111";
                        Console.WriteLine(newNum);
                        break;
                    case 8:
                        newNum = "1000";
                        Console.WriteLine(newNum);
                        break;
                    case 9:
                        newNum = "1001";
                        Console.WriteLine(newNum);
                        break;
                    case 10:
                        newNum = "00010000";
                        Console.WriteLine(newNum);
                        break;
                    case 11:
                        newNum = "00010001";
                        Console.WriteLine(newNum);
                        break;
                    case 12:
                        newNum = "00010010";
                        Console.WriteLine(newNum);
                        break;
                    case 13:
                        newNum = "00010011";
                        Console.WriteLine(newNum);
                        break;
                    case 14:
                        newNum = "00010100";
                        Console.WriteLine(newNum);
                        break;
                    case 15:
                        newNum = "00010101";
                        Console.WriteLine(newNum);
                        break;
                    case 16:
                        newNum = "00010110";
                        Console.WriteLine(newNum);
                        break;

                }
            }
            break;
        case 2:
            int urNum;
            String litNum;

            Console.Write("Enter a number to chgange it to 01010: "); urNum = int.Parse(Console.ReadLine());

            if (urNum >= 0 && urNum <= 9)
            {
                switch (urNum)
                {
                    case 0:
                        litNum = "zero";
                        Console.WriteLine(litNum);
                        break;
                    case 1:
                        litNum = "one";
                        Console.WriteLine(litNum);
                        break;
                    case 2:
                        litNum = "two";
                        Console.WriteLine(litNum);
                        break;
                    case 3:
                        litNum = "three";
                        Console.WriteLine(litNum);
                        break;
                    case 4:
                        litNum = "four";
                        Console.WriteLine(litNum);
                        break;
                    case 5:
                        litNum = "five";
                        Console.WriteLine(litNum);
                        break;
                    case 6:
                        litNum = "six";
                        Console.WriteLine(litNum);
                        break;
                    case 7:
                        litNum = "seven";
                        Console.WriteLine(litNum);
                        break;
                    case 8:
                        litNum = "eight";
                        Console.WriteLine(litNum);
                        break;
                    case 9:
                        litNum = "nine";
                        Console.WriteLine(litNum);
                        break;

                }
            }
            break;
        case 3:
            LevelStatement.itnernationalPassport iPs = new LevelStatement.itnernationalPassport("Mykyta", "23.05.2019");
            iPs.EndDate = "4.5.2024";

            break;
        case 4:
            String lineForInput;
            lineForInput = Console.ReadLine();
            int? s1 = null; 
            char ? s2 = null; 
            int ? s3 = null;

            try { 
                for (int i = 0; i < lineForInput.Length; i++)
                {
                    s1 = (int)lineForInput[0];
                    s2 = lineForInput[1];
                    s3 = (int)lineForInput[2];
                }

                Console.WriteLine("S1: {0}\nS2: {1}\nS3: {2}", s1, s2, s3);

            } catch(Exception e)
            {
                Console.WriteLine("ERROR: " + e);
            }
            finally
            {
                Console.WriteLine("S1: {0}\nS2: {1}\nS3: {2}", s1, s2, s3);
            }
            break;
    }
}