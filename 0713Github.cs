using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0713p1
{
    class Program
    {
        static void Main(string[] args)
        {
            //编写一个程序接受用户输入的字符。如果输入的字符是0-9数字中的一个，则显示“您输入了一个数字”，否则显示这不是一个数字”
            Console.WriteLine("Please give me a char");
            char i = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int a = i;
            if (a >= 48 || a <= 57)
                Console.WriteLine("you give me a single number");
            else
                Console.WriteLine("you don't give me a single number");
            Console.ReadKey();
            //在查询console.ReadKey()返回的类型时，我先上网搜索了一下，但发现没有结果。
            //通过老师的指导，其实可以通过查看这个函数的定义。一步步地深入，最终找到如何通过这个函数返回一个char类型的数值。
            //也就是通过在IDE内，深入了解某个函数，也是解决问题的方法之一。因为有时候可能会找不到网上有人遇到和我一样的问题，特别是我解决问题思路比较特异的时候。






        }

    }


    
}
