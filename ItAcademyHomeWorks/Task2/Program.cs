using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyte1 = 1;
            SByte sbyte2 = 2;
            Console.WriteLine("sbyte: {0} , {1}" , sbyte1.GetType(), sbyte2.GetType());
            short short1 = 3;
            Int16 short2 = 4;
            Console.WriteLine("short: {0} , {1}", short1.GetType(), short2.GetType());
            int int1 = 5;
            Int32 int2 = 6;
            Console.WriteLine("int: {0} , {1}", int1.GetType(), int2.GetType());
            long long1 = 7;
            Int64 long2 = 8;
            Console.WriteLine("long: {0} , {1}", long1.GetType(), long2.GetType());
            byte byte1 = 9;
            Byte byte2 = 10;
            Console.WriteLine("byte: {0} , {1}", byte1.GetType(), byte2.GetType());
            ushort ushort1 = 11;
            UInt16 ushort2 = 12;
            Console.WriteLine("ushort: {0} , {1}", ushort1.GetType(), ushort2.GetType());
            char char1 = '1';
            Char char2 = 'b';
            Console.WriteLine("char: {0} , {1}", char1.GetType(), char2.GetType());
            uint uint1 = 15;
            UInt32 uint2 = 16;
            Console.WriteLine("uint: {0} , {1}", uint1.GetType(), uint2.GetType());
            ulong ulong1 = 17;
            UInt64 ulong2 = 18;
            Console.WriteLine("ulong: {0} , {1}", ulong1.GetType(), ulong2.GetType());
            float float1 = 19;
            Single float2 = 20;
            Console.WriteLine("float: {0} , {1}", float1.GetType(), float2.GetType());
            double double1 = 21;
            Double double2 = 22;
            Console.WriteLine("double: {0} , {1}", double1.GetType(), double2.GetType());
            decimal decimal1 = 23;
            Decimal decimal2 = 24;
            Console.WriteLine("decimal: {0} , {1}", decimal1.GetType(), decimal2.GetType());
            object object1="12 dsf";
            Object object2 =  true;
            /*For object type, when output to the console,
             * returns the data type, that was assigned to it,
             * because reference type.
             */
            Console.WriteLine("object: {0} , {1}", object1.GetType(), object2.GetType());
            string string1 = "abc";
            String string2 = "cba";
            Console.WriteLine("string: {0} , {1}", string1.GetType(), string2.GetType());
        }
    }
}
