using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        interface Itest
        {
            Int32 Add(Int32 num);
            Int32 Sub(Int32 num);
            Int32 Mul(Int32 num);
            Int32 Div(Int32 num);

        }

        interface Itest2<T>
        {
            T Add(T num);
            T Sub(T num);
            T Mul(T num);
            T Div(T num);

        }

        Itest2<Int32> aaa;
        
        

        static void Main(string[] args)
        {
        }
    }
}
