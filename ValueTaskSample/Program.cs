using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin();
            Console.ReadLine();
        }

        async private static void Begin()
        {
            int x = await Execute();
            Console.WriteLine(x);
        }
        async private static ValueTask<int> Execute()
        {
            await Task.Delay(5000);
            return 300;
        }       
    }
}
