using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task1
            //try
            //{
            //    Console.WriteLine("Ededleri daxil edin: ");
            //    string numstr1 = Console.ReadLine();
            //    int num1 = int.Parse(numstr1);
            //    string numstr2 = Console.ReadLine();
            //    int num2 = int.Parse(numstr2);
            //    string numstr3 = Console.ReadLine();
            //    int num3 = int.Parse(numstr3);
            //    string numstr4 = Console.ReadLine();
            //    int num4 = int.Parse(numstr4);
            //    string numstr5 = Console.ReadLine();
            //    int num5 = int.Parse(numstr5);


            //    int result = Bignum(num1, num2, num3);
            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Herf daxil edile bilmez");
            //}
            #endregion


            #region task2


            //try
            //{
            //    Console.WriteLine("Bir eded daxil edin: ");
            //    string numstr = Console.ReadLine();
            //    int num = int.Parse(numstr);
            //    Sum(num);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Herf daxil etmek olmaz..");
            //}
            #endregion

            #region task3
            //try
            //{
            //    Console.WriteLine("Qiymetleri daxil edin: ");
            //    string numstr1 = Console.ReadLine();
            //    double num1 = double.Parse(numstr1);
            //    string numstr2 = Console.ReadLine();
            //    double num2 = double.Parse(numstr2);
            //    string numstr3 = Console.ReadLine();
            //    double num3 = double.Parse(numstr3);

            //    Expensive(num1, num2, num3);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}
            #endregion

            #region task4-
            //try
            //{
            //    int[] arr = { };
            //    while (true)
            //    {
            //        Console.WriteLine("Elave et: y/n");
            //        string result = Console.ReadLine();
            //        if (result == "y")
            //        {
            //            Console.WriteLine("Deyer elave et: ");
            //            string numstr = Console.ReadLine();
            //            int num = int.Parse(numstr);
            //            Array.Resize(ref arr, arr.Length + 1);
            //            arr[arr.Length - 1] = num;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    foreach (int i in arr)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    CustomSort(arr);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Herf daxil etmek olmaz..");
            //}

            #endregion

             
                Console.WriteLine("String elave et");
                string str=Console.ReadLine();

                Console.WriteLine("Char elave et: ");
                 string  ch1=Console.ReadLine();
                 char[] ch2 = ch1.ToCharArray();
                
                FindIndex(str,ch2);


        }

        #region task1

            //static int Bignum(int a,int b,int c)
            //{
            //    int result=0;
            //    if(a>b && a > c)
            //    {
            //        Console.WriteLine("A en boyuk");
            //        result += a;
            //    }
            //    else if(b>a && b > c)
            //    {
            //        Console.WriteLine("B en boyuk");
            //        result += b;
            //    }
            //    else if(c>a && c > b)
            //    {
            //        Console.WriteLine("C en boyuk");
            //        result += c;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Beraberlik var");
            //    }
            //    return result;
            //}
            //static int Bignum(int a,int b,int c,int d)
            //{
            //    int result = 0;
            //    if(a>b && a>c && a > d)
            //    {
            //        Console.WriteLine("A en boyuk");
            //        result += a;
            //    }
            //    else if(b>a && b>c && b > d)
            //    {
            //        Console.WriteLine("B en boyuk");
            //        result += b;
            //    }
            //    else if(c>a && c>b && c > d)
            //    {
            //        Console.WriteLine("C en boyuk");
            //        result += c;
            //    }
            //    else if(d>a && d>b && d > c)
            //    {
            //        Console.WriteLine("D en boyuk");
            //        result += d;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Beraberlik var..");
            //    }
            //    return result;
            //}
            //static int Bignum(int a,int b,int c,int d,int e)
            //{
            //    int result = 0;
            //    if(a>b && a>c && a>d && a > e)
            //    {
            //        Console.WriteLine("A en boyuk");
            //        result += a;
            //    }
            //    else if(b>a && b>c && b>d && b>e)
            //    {
            //        Console.WriteLine("B en boyuk");
            //        result += a;
            //    } 
            //    else if(c>a && c>b && c>d && c > d)
            //    {
            //        Console.WriteLine("C en boyuk");
            //        result += c;
            //    }
            //    else if(d>a && d>b && d>c && d > e)
            //    {
            //        Console.WriteLine("D en boyuk");
            //        result += d;
            //    }
            //    else if(e>a && e>b && e>c && e > d)
            //    {
            //        Console.WriteLine("E en boyuk");
            //        result += e;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Beraberlik var");
            //    }
            //    return result;
            //}
            #endregion

            #region task2
            //static int Sum(int a)
            //{
            //    int sum = 0;
            //    int mod = 0;
            //    while (a>1)
            //    {
            //        mod=a % 10;
            //        a = (a - mod) / 10;
            //        sum += mod;
            //    }
            //    Console.WriteLine(sum);
            //    return sum;
            //}
            #endregion


            #region task3
            //static double Expensive(double a,double b,double c)
            //{
            //    double result = 0;
            //    if( a>b || a > c && b > a || b > c)
            //    {
            //        Console.WriteLine("Odenilecek mal");
            //        result=a+b;
            //    }
            //    else if( a > b || a > c && c > a || c > b)
            //    {
            //        Console.WriteLine("Odenilecek mal");
            //        result=a+c;
            //    }
            //    else if( b > a || b > c && c >a || c > b)
            //    {
            //        Console.WriteLine("Odenilcek mal");
            //        result=b+c;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Qiymetler beraberdir..");
            //    }
            //    Console.WriteLine(result);
            //    return result;
            //}
            #endregion

            #region task4-

            //--------------- DÜZGÜN İŞLƏMİR AMMA MƏNTİQİ BELƏ OLA BİLƏR ---------------
            //static void CustomSort(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] > arr[j])
            //            {
            //                arr[i] = arr[j];
            //            }
            //        }
            //    }
            //}
            #endregion

            static void FindIndex(string str, char[] ch2)
            {
               
               Console.WriteLine(str.IndexOfAny(ch2)); 
            }
             

        }
}
