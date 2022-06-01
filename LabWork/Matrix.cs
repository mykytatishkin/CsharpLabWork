using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    internal class Maxtrix
    {
        private int[,] maxtrix;
        private int min = 101;
        private int max = -1;

        public Maxtrix(int[,] maxtrix)
        {
            this.maxtrix = maxtrix;
        }

        public int Min()
        {
            for(int i = 0; i < maxtrix.Length; i++)
            {
                for(int j = 0; j < maxtrix.Length; j++)
                {
                    if (maxtrix[i,j] <= 100 && maxtrix[i,j] >= 0) 
                    {
                        if (min < maxtrix[i, j])
                        {
                            min = maxtrix[i, j];
                        }
                    }
                }
            }
            return min;
        }

        public int Max()
        {
            for (int i = 0; i < maxtrix.Length; i++)
            {
                for (int j = 0; j < maxtrix.Length; j++)
                {
                    if (maxtrix[i, j] <= 100 && maxtrix[i, j] >= 0)
                    {
                        if (max > maxtrix[i, j])
                        {
                            max = maxtrix[i, j];
                        }
                    }
                }
            }
            return max;
        }
    }
}
