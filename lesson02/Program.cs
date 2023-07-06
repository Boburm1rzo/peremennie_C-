namespace lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 2;
            int b = a - 3;
            int c = b+4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            /*
            long a = 5;
            long b = a * 2;
            b = a / 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            */

            byte maxByte=byte.MaxValue;
            byte minByte=byte.MinValue;
            Console.WriteLine("Byte max:"+maxByte);
            Console.WriteLine("Byte min:"+minByte);

            short shortMax=short.MaxValue;
            short shortMin=short.MinValue;
            Console.WriteLine("Short max:" + shortMax);
            Console.WriteLine("Short min:"+shortMin);

            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine("Int max:" + intMax);
            Console.WriteLine("Int min:" + intMin);

            long longMax =long.MaxValue;
            long longMin=long.MinValue;
            Console.WriteLine("Long max:"+longMax);
            Console.WriteLine("Long min:" + longMin);

            float floatMax=float.MaxValue;
            float floatMin=float.MinValue;
            Console.WriteLine("Float max:" + floatMax);
            Console.WriteLine("Float min:" + floatMin);


            double doubleMax = double.MaxValue;
            double doubleMin = double.MinValue;
            Console.WriteLine("Double max:" + doubleMax);
            Console.WriteLine("Double min:" + doubleMin);


        }
    }
}