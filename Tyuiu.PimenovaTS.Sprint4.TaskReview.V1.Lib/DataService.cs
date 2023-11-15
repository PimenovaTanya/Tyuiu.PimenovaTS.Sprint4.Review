using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PimenovaTS.Sprint4.TaskReview.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] zombi = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    zombi[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int con = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (zombi[i, j] % 2 == 0)
                    {
                        con++;
                    }
                }
            }

            return con;
        }
    }
}
