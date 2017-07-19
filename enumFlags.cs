using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumflags
{
    class Program
    {
        //《C#图解教程》P208
        //这个特性可以用于多状态管理
        [Flags]
        enum CardDeckSetting:uint
        {
            SingleDeck      =0x01,      //位0
            LargePictures   =0x02,      //位1
            FancyNumbers    =0x04,      //位2
            Animation       =0x08       //位3
        }
        //每个位表示一种状态
        static void Main(string[] args)
        {
            //枚举类型       标志字    位标志被“或”在一起
            CardDeckSetting ops =     CardDeckSetting.SingleDeck
                                    | CardDeckSetting.FancyNumbers
                                    | CardDeckSetting.Animation;

            //判断是否处于FancyNumbers这个状态
            bool useFancyNumbers = ops.HasFlag(CardDeckSetting.FancyNumbers);

            //也可以同时判断是否处于多个状态
            CardDeckSetting testFlags = CardDeckSetting.Animation | CardDeckSetting.FancyNumbers;
            bool useAnimationAndFancyNumbers = ops.HasFlag(testFlags);
            //                                标志字          测试字

            //另一种判断方法
            useFancyNumbers = (ops & CardDeckSetting.FancyNumbers) == CardDeckSetting.FancyNumbers;
        }
    }
}
