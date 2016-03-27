using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    class PropChange : INotifyPropertyChanged
    {
        public int MyProperty { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
