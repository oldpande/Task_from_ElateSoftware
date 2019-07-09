using System;

namespace Task_from_ElateSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack stack = new GenericStack(3);
            stack.Push(2);
            stack.Info();
            stack.Push("Hello!");
            stack.Info();
            Console.WriteLine(stack.ToString());
            Console.WriteLine(stack.GetOut());
            Console.WriteLine(stack.GetOut());
            Console.WriteLine(stack.GetOut());
            Console.WriteLine(stack.GetOut());
        }
    }
}
