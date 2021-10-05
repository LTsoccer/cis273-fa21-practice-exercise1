using System;

namespace PracticeExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Append(i);
            }

            var reversed = list.Reverse();
        }
    }
}
