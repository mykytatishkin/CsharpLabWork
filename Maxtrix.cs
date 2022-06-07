using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHome
{
    class Maxtrix
    {
        protected int[,] maxtrix;

        public Maxtrix()
        {
            maxtrix = new int[5, 5];
            System.Random random = new System.Random();
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    maxtrix[i, j] = random.Next(0,23);
                }
            }
        }
        public void Multyply_Matrix(int num)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    maxtrix[i, j] = maxtrix[i, j] * num;
                }
            }
        }
        public int Sum_Matrix()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sum = sum + maxtrix[i, j];
                }
            }
            return sum;
        }
        public int MultOf_Matrix()
        {
            int mult = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mult = mult * maxtrix[i, j];
                }
            }
            return mult;
        }
        public void Print()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(maxtrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }   
}
