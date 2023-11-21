using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bt04
            //int x = 1;
            //bool isRun = false;

            //Thread timer1 = new Thread(() =>
            //{
            //    do
            //    {
            //        Console.Write("x: ");
            //        x = Convert.ToInt32(Console.ReadLine());
            //        isRun = true;

            //        Thread.Sleep(5);


            //    } while (x > 0 && x <= 20);

            //    Console.WriteLine("End task 1");
            //});

            //Thread timer2 = new Thread(() =>
            //{
            //    do
            //    {
            //        if (isRun)
            //        {
            //            isRun = false;
            //            Console.WriteLine($"x! = {TinhGiaiThua(x)}");

            //            Thread.Sleep(10);
            //        }

            //    } while (x > 0 && x <= 20);

            //    Console.WriteLine("End task 2");
            //});

            //timer1.Start();
            //timer2.Start();

            //timer1.Join();
            //timer2.Join();
            #endregion

            #region Bt01

            //int c = 1;
            //bool isRun1 = false;

            //Thread timer11 = new Thread(() =>
            //{
            //    do
            //    {
            //        Console.Write("c: ");
            //        c = Convert.ToInt32(Console.ReadLine());
            //        isRun1 = true;

            //        Thread.Sleep(5);


            //    } while (c != 0);

            //    Console.WriteLine("End task 1");
            //});

            //Thread timer22 = new Thread(() =>
            //{
            //    do
            //    {
            //        if (isRun1)
            //        {
            //            isRun1 = false;
            //            Console.WriteLine($"c la so nguyen to ? {isPrimeNumber(c)}");

            //            Thread.Sleep(10);
            //        }

            //    } while (c != 0);

            //    Console.WriteLine("End task 2");
            //});

            //timer11.Start();
            //timer22.Start();

            //timer11.Join();
            //timer22.Join();
            #endregion

            #region BT02
            //string s = "";
            //bool isRun1 = false;

            //Thread timer11 = new Thread(() =>
            //{
            //    do
            //    {
            //        Console.Write("s: ");
            //        s = Convert.ToString(Console.ReadLine());
            //        isRun1 = true;

            //        Thread.Sleep(5);


            //    } while (s != "thoat");

            //    Console.WriteLine("End task 1");
            //});

            //Thread timer22 = new Thread(() =>
            //{
            //    do
            //    {
            //        if (isRun1)
            //        {
            //            isRun1 = false;
            //            Console.WriteLine($"Chuoi dao la: {ReverseString(s)}");

            //            Thread.Sleep(10);
            //        }

            //    } while (s != "thoat");

            //    Console.WriteLine("End task 2");
            //});

            //timer11.Start();
            //timer22.Start();

            //timer11.Join();
            //timer22.Join();
            #endregion

            #region BT03
            //string c = "";
            //bool isRun1 = false;

            //Thread timer11 = new Thread(() =>
            //{
            //    do
            //    {
            //        Console.Write("c: ");
            //        c = Convert.ToString(Console.ReadLine());
            //        isRun1 = true;

            //        Thread.Sleep(5);


            //    } while (c != "thoat");

            //    Console.WriteLine("End task 1");
            //});

            //Thread timer22 = new Thread(() =>
            //{
            //    do
            //    {
            //        if (isRun1)
            //        {
            //            isRun1 = false;
            //            Console.WriteLine($"dem la: {CountWords(c)}");

            //            Thread.Sleep(10);
            //        }

            //    } while (c != "thoat");

            //    Console.WriteLine("End task 2");
            //});

            //timer11.Start();
            //timer22.Start();

            //timer11.Join();
            //timer22.Join();
            #endregion

            #region Bt05
            bool isRun1 = false;


            Thread timer11 = new Thread(() =>
            {
                string s = "";
                do
                {
                    try
                    {
                        if (!isRun1)
                        {
                            if (s != "thoat")
                            {
                                StreamWriter sw = new StreamWriter("D:\\Test.txt", false);
                                Console.Write("s: ");
                                s = Console.ReadLine();
                                sw.WriteLine(s);
                                isRun1 = true;
                                sw.Close();
                                Thread.Sleep(5);
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }

                } while (s != "thoat");
                Console.WriteLine("end time 1");
            });

            Thread timer22 = new Thread(() =>
            {
                String line = "";
                do
                {
                    try
                    {
                        if (isRun1)
                        {
                            if (line != "thoat")
                            {
                                Thread.Sleep(10);

                                StreamReader sr = new StreamReader("D:\\Test.txt");
                                line = sr.ReadLine();
                                Console.WriteLine(line);
                                Console.WriteLine("read file:" + ReverseString(line));
                                isRun1 = false;
                                sr.Close();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }

                } while (line != "thoat");
                Console.WriteLine("end time 2");

            });



            timer11.Start();
            timer22.Start();

            timer11.Join();
            timer22.Join();
            #endregion

            #region Bai1

            #endregion

            Console.ReadKey();
        }

        static double TinhGiaiThua(int x)
        {
            double rs = 1;

            for (int i = 1; i <= x; i++)
            {
                rs *= i;
            }

            return rs;
        }

        static Boolean isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static int CountWords(string input)
        {
            // Sử dụng phương thức Split() để tách chuỗi thành các từ bằng dấu cách
            // Sau đó, loại bỏ các chuỗi rỗng (nếu có) do các khoảng trắng thừa
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Đếm số lượng từ trong mảng
            return words.Length;
        }


    }
}
