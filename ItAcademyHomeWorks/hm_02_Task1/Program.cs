using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit conversation
            byte a = 25;
            long ByteToLong = a;
            int ByteToInt = a;
            ushort ByteToUshort = a;
            Console.WriteLine("Explicit conversation : long = {0}, int = {1}, ushort = {2}", ByteToLong, ByteToInt, ByteToUshort);
            //implicit conversation
            long b = 10;
            short LongToShort = (short)b;
            byte LongToByte = (byte)b;
            sbyte LongToSbyte = (sbyte)b;
            Console.WriteLine("Iplicit conversation : short = {0}, byte = {1}, sbyte = {2}", LongToShort, LongToByte, LongToSbyte);
            //boxing
            byte boxing = 20;
            object Boxing = boxing;
            Console.WriteLine("Boxing: {0}", Boxing);
            //unboxing
            int unboxing = (byte)Boxing;
            Console.WriteLine("Unboxing: {0}", unboxing);
        }
    }
}
