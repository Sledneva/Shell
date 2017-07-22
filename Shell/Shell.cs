using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
    class Shell
    {
        public static int[] Parse(string input)
        {
            string[] arr = input.Split(' ', ',', '.');
            int[] num = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                num[i] = int.Parse(arr[i]);
            return num;
        }
        public int[] Sort(int[] num, ref int count )
        {
            int j;
            int step = num.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (num.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (num[j] > num[j + step]))
                    {
                        count++;
                        int tmp = num[j];
                        num[j] = num[j + step];
                        num[j + step] = tmp;
                        j -= step;
                    }
                    count++;
                }
                step = step / 2;
            }
            
            return num;
        }

            public int[] Sort2(int[] num)
        {
            int j;
            int step = num.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (num.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (num[j] > num[j + step]))
                    {
                        int tmp = num[j];
                        num[j] = num[j + step];
                        num[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
            return num;
        }
    }
}
