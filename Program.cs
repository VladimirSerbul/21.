using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {

        static void Main()
        {
            int n, m;
            try
            {
                Console.WriteLine("введите кол-во строк ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 1)
                {
                    throw new Exception("не корректно введены данные должна быть матрица ");
                }
                Console.WriteLine("введите кол-во столбцов ");
                m = Convert.ToInt32(Console.ReadLine());
                if (m <= 1)
                {
                    throw new Exception("не корректно введены данные должна быть матрица ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            int[,] array = new int[n, m];//а если 2*2
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = -1;
                }
            }

            int brightstr = 0;
            int brightcolumns = 0;
            int a = 0;
            int bleftstr = n - 1;
            int bleftcolumns = m - 2;
            int bupstr = n - 2;
            int bupcolumns = 0;
            int bdownstr = 1;
            int bdowncolumns = m - 1;
            bool flag = true;
            while (flag)
            {
                Right(brightstr, brightcolumns, ref a);

                Down(bdownstr, bdowncolumns, ref a);
                Left(bleftstr, bleftcolumns, ref a);
                Up(bupstr, bupcolumns, ref a);

                brightstr += 1;
                brightcolumns += 1;

                bleftstr += -1;
                bleftcolumns += -1;

                bupstr += -1;
                bupcolumns += 1;

                bdownstr += 1;
                bdowncolumns += -1;
                flag = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        if (array[i, j] == -1)
                            flag = true;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5}", array[i, j]);
                }
                Console.WriteLine();
            }
            void Right(int bi1, int bj1, ref int a1)
            {
                flag = true;
                while (flag)
                {
                    if ((bj1) < m)
                    {
                        if (array[bi1, bj1] == -1)
                        {
                            array[bi1, bj1] = a;
                            a1++;
                            bj1++;
                        }
                        else
                            flag = false;
                    }
                    else
                        flag = false;
                }
            }
            void Left(int bi1, int bj1, ref int a2)
            {
                flag = true;
                while (flag)
                {
                    if (bj1 >= 0)
                    {
                        if (array[bi1, bj1] == -1)
                        {
                            array[bi1, bj1] = a2;
                            a2++;
                            bj1--;
                        }
                        else
                            flag = false;
                    }
                    else
                        flag = false;
                }
            }
            void Up(int bi1, int bj1, ref int a3)
            {
                flag = true;
                while (flag)
                {
                    if ((bi1) >= 0)
                    {
                        if (array[bi1, bj1] == -1)
                        {
                            array[bi1, bj1] = a3;
                            a3++;
                            bi1--;
                        }
                        else
                            flag = false;
                    }
                    else
                        flag = false;
                }
            }
            void Down(int bi1, int bj1, ref int a4)
            {
                flag = true;
                while (flag)
                {
                    if ((bi1) < n)
                    {
                        if (array[bi1, bj1] == -1)
                        {
                            array[bi1, bj1] = a4;
                            a4++;
                            bi1++;
                        }
                        else
                            flag = false;
                    }
                    else
                        flag = false;
                }
            }

            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }


    }
}

