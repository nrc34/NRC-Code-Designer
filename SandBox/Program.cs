using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Enum.GetName(typeof(MyEnum), MyEnum.@public);

            Console.WriteLine(name);
            Console.ReadKey();
        }
    }

    enum MyEnum
    {
        @public,
        @internal,
        @default
    }
}
