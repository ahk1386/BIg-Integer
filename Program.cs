using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jam_Adad_Bozorg
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Numerics.BigInteger a = System.Numerics.BigInteger.Parse(Console.ReadLine());

            //System.Numerics.BigInteger b = System.Numerics.BigInteger.Parse(Console.ReadLine());

            //var t = System.Numerics.BigInteger.Add(a, b);

            //Console.WriteLine(t);

            //Console.ReadKey();

            int carry = 0, n = 0, m = 0;

            string str1 = Console.ReadLine();

            string str2 = Console.ReadLine();

            string[] s1 = new string[str1.Length];

            string[] s2 = new string[str2.Length];

            int[] array1 = new int[str1.Length];

            int[] array2 = new int[str2.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                s1[i] = str1.Substring(i, 1);
            }

            for (int j = 0; j < str2.Length; j++)
            {
                s2[j] = str2.Substring(j, 1);
            }

            for (int i = 0; i < str1.Length; i++)
            {
                array1[i] = Convert.ToInt32(s1[i]);
            }

            for (int i = 0; i < str2.Length; i++)
            {
                array2[i] = Convert.ToInt32(s2[i]);
            }

            if (str1.Length > str2.Length)
            {
                n = str1.Length;
            }

            else
            {
                n = str2.Length;
            }

            int[] sum = new int[n];

            for (int p = 0; p < n; p++)
            {
                if (str1.Length - p - 1 >= 0 && str2.Length - p - 1 >= 0)
                {
                    sum[n - p - 1] = array1[str1.Length - p - 1] + array2[str2.Length - p - 1] + carry;

                    carry = 0;

                    if (sum[n - p - 1] >= 10)
                    {
                        sum[n - p - 1] %= 10;

                        carry = 1;
                    }
                }
                else
                {
                    if (str1.Length - p - 1 >= 0)
                    {
                        sum[n - p - 1] = array1[str1.Length - p - 1] + carry;

                        carry = 0;

                        if (sum[n - p - 1] >= 10)
                        {
                            sum[n - p - 1] %= 10;

                            carry = 1;
                        }
                    }
                    else
                    {
                        if (str2.Length - p - 1 >= 0)
                        {
                            sum[n - p - 1] = array2[str2.Length - p - 1] + carry;

                            carry = 0;

                            if (sum[n - p - 1] >= 10)
                            {
                                sum[n - p - 1] %= 10;

                                carry = 1;
                            }
                        }
                    }
                }

            }

            if (carry == 1)
            {
                Console.Write("1");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(sum[i]);
            }

            Console.ReadKey();
        }
    }
}
