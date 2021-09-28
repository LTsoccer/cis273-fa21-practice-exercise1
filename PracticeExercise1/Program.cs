using System;

namespace PracticeExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Append(1);
            al.Append(2);
            al.Append(3);
            al.Append(5);
            al.Append(8);

            Console.WriteLine(al);

            Console.ReadKey();
        }
    }
}
