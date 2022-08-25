using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            a = b;
            b = 65;
            Console.WriteLine(a);//30

            int[] aa=new int[] {10,20,30}; 
            int[] bb=new int[] {100,200,300};
            aa = bb;
            bb[0] = 999;
            Console.WriteLine(aa[0]);//999

            //int, decimal, double, float, bool=değer tip
            //array,class, interface=referans tip

            //stack - a=10x->30 b=30x->65
            //heap - 

            //stack -    aa/101x->102                                        bb/102
            //heap -  [10,20,30]/101xmove to garbage collector         [100->999,200,300]/102
        }
    }
}