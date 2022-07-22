using System;
using System.Collections.Generic;

namespace MutlakKareAlma
{
    public struct MutlakKare
    {
        public void KareAlma(int x)
        {
            int number;
            int sums=0;
            int value;
            int sqrt=0;
            for (int i = 1; i <=x; i++)
            {
                Console.Write(i+". Sayıyı Giriniz..:");
                number=int.Parse(Console.ReadLine());
                if (number>67)
                {
                    value=number-67;
                    sqrt+=value*value;
                    
                }
                else
                {
                    value=67-number;
                    sums+=value;
                }
            }
            Console.WriteLine(sums.ToString().Remove(0,0)+" "+sqrt);
        }
    }
}