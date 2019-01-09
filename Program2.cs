using System;
using System.Diagnostics;

namespace Part2_Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] Mat = new int[3,3];
            Mat[0, 0] = 1;
            Mat[0, 1] = 1;
            Mat[0, 2] = 1;
            Mat[1, 0] = 1;
            Mat[1, 1] = 1;
            Mat[1, 2] = 0;
            Mat[2, 0] = 1;
            Mat[2, 1] = 1;
            Mat[2, 2] = 0;
            int FIN= MatrixCheck(Mat);
            //if (FIN == 1) Console.WriteLine("X IS WIN!");
            switch(FIN )

            {
                case 1:
                    Console.WriteLine("X IS WIN!");
                    break;
                case 2:
                    Console.WriteLine("0 IS WIN!");
                    break;
                case 0:
                    Console.WriteLine("ITS A TIE!");
                    break;
                default:
                    break;
            }
        }

        static public int MatrixCheck(int [,]Mat)// ONE=X, ZERO=0
        {
            if (Mat.Length != 9)
                return -1;
            for(int i =0;i<Mat.Length/2;i++)
            {
                if (i == 3) break;
                for(int j=0;j<Mat.Length/2;j++)
                {
                    if (j == 3) break;
                    if(Mat[i,j]<0|| Mat[i, j] > 1)
                    {
                        return -2; 
                    }
                }
            }
            int h = 0, k = 0,Res1=0,Res2=0,Res3=0;
            //------------------------- Checking about 1 -------------------------//
            for (k=0;k<Mat.Length/2;k++)
            {
                if(Mat[k,h]==1)
                {
                    Res1 += 1; // Check if There 3 x/0 in a row.
                }
                if (Res1 == 3) return 1;

                for(h=0;h<Mat.Length/2;h++)
                {
                    if(Mat[k,h]==1)
                    {
                        Res2 += 1; // Cehck if there 3 x/0 in a column.
                    }
                    if (Res2 == 3) return 2;
                    if (h==k)
                        {
                        if(Mat[k,h]==1)
                           Res3 += 1;  // Check if there 3 x/0 in a diagonal.
                        }
                    if (Res3 == 3) return 1;
                }
                Res1 = Res2 = Res3 = 0;
            }
            //------------------------- Checking about 0 -------------------------//
            Res1 = Res2 = Res3 = 0;
            int a = 0, b = 0;
            for (a = 0; a < Mat.Length / 2; a++)
            {
                if (Mat[a, b] == 1)
                {
                    Res1 += 1; // Check if There 3 x/0 in a row.
                }
                if (Res1 == 3) return 2;

                for (a = 0; b < Mat.Length / 2; b++)
                {
                    if (Mat[a, b] == 1)
                    {
                        Res2 += 1; // Cehck if there 3 x/0 in a column.
                    }
                    if (Res2 == 3) return 2;
                    if (a == b)
                    {
                        if (Mat[a, b] == 1)
                            Res3 += 1;  // Check if there 3 x/0 in a diagonal.
                    }
                    if (Res3 == 3) return 2;
                }
                Res1 = Res2 = Res3 = 0;
            }
            return 0;
        }


    }
}
