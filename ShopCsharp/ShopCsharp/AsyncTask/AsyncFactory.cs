using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.AsyncTask
{
    public class AsyncFactory
    {
        public async void TestIt()
        {
            /*await CountTo10000();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("UI Thread i is "+i);
            }*/
            Int32 result = await CountTo10000WithReturn();
        }

        private Task CountTo10000()
        {
            Action count = new Action(() => 
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine("Async task i is " + i);
                }
            });
            return Task.Run(count);
        }

        private Task<Int32> CountTo10000WithReturn()
        {
            Func<Int32> count = new Func<int>(() =>
            {
                int i = 0;
                for (; i < 10000; i++)
                {
                    Console.WriteLine("Async task i is " + i);
                }

                return i;
            });
            return Task.Run(count);
        }
    }
}
