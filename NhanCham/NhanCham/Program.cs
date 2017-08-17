using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanCham
{
    public class Program
    {
        public static int[,] DienVongTrong(int[,] a, int[,] b)
        {

            var u = b.GetLength(0);
            var k = b.GetLength(1);
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            //if (k * u != (n - 2) * (m - 2)||u<3||k<3||m<3||n<3)
            //    return a;
            int[,] c = new int[m - 2, n - 2];
            for (int i = 0; i < m - 2; i++)
            {

                for (int j = 0; j < n - 2; j++)
                {
                    int z = 0;
                    var Tong = 0;
                    for (int x = i; x < i + u; x++)
                    {
                        int t = 0;
                        for (int y = j; y < j + k; y++)
                        {

                            Tong = Tong + a[i, y] * b[z, t];
                            t++;
                        }
                        z++;
                    }
                    c[i, j] = Tong;
                }
            }
            int p = 0, q;
            for (int i = 1; i < m - 1; i++)
            {
                q = 0;
                for (int j = 1; j < n - 1; j++)
                {

                    a[i, j] = c[p, q];
                    q++;
                }
                p++;
            }

            return a;
        }
        static void Main(string[] args)
        {
        }
    }
}
