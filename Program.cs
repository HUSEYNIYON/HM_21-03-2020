using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise_1
            Console.WriteLine("Exercise_1");
            float a=16.80f;
            Console.WriteLine("a="+a);
            float b=12.40f;
            Console.WriteLine("b="+b);
            double result=Math.Sqrt(a*b);
            Console.WriteLine("Result="+result);
            Console.WriteLine();
            
            //Exercise_2
            Console.WriteLine("Exercise_2");
            float A=1.40f;
            Console.WriteLine("A="+A);
            float B=-5.50f;
            Console.WriteLine("B="+B);
            float C=0.60f;
            Console.WriteLine("C="+C);
            float AC = Math.Abs(C - A);
            float BC = Math.Abs(C - B);
            float SUM=AC+BC;
            Console.WriteLine("AC="+AC);
            Console.WriteLine("BC="+BC);
            Console.WriteLine("SUM="+SUM);
            Console.WriteLine();

            //Exercise_3
            Console.WriteLine("Exercise_3");
            float x1=-6.20f;
            float y1=5.20f;
            float x2=2.10f;
            float y2=9.80f;
            double Result=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            Console.WriteLine("Result="+Result);
            Console.WriteLine();

            //Exercise_4
            Console.WriteLine("Exercise_4");
            int digit=41;
            Console.WriteLine("Default digit= "+digit);
            int firstDigit=digit/10;
            int secondDigit=digit%10;
            int inverseDigit=secondDigit*10+firstDigit;
            Console.WriteLine("Inverse digit= "+inverseDigit);
            Console.WriteLine();

            //Exercise_5
            Console.WriteLine("Exercise_5");
            int N=10985;
            Console.WriteLine("N="+N);
            int Res=N/60;
            Console.WriteLine("Res= "+Res);
            Console.WriteLine();

            //Exercise_6
            Console.WriteLine("Exercise_6");
            int K=202;
            Console.WriteLine("K="+K);
            int P=K%7;
            Console.WriteLine("P= "+P);
            Console.WriteLine();        }
    }
}
