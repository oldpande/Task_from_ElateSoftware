using System;
using System.Text;

namespace Task_from_ElateSoftware
{
    public class GenericStack
    {
        private object[] Array { get; set; }
        private int higherCell = -1;

        public GenericStack(int inputSize)
        {
            Array = new object[inputSize];
        }

        public void Push(object element)
        {
            for (int idCell = 0; idCell < Array.Length; idCell++)
            {
                if (Array[idCell] == null)
                {
                    Array[idCell] = element;      //put element on the array
                    higherCell++;                 //remember height of the array
                    break;
                }
            }
        }

        public object GetOut()
        {
            if(higherCell == -1)
            {
                Console.WriteLine("Stack is null!!!");
                return null;
            }
            object element = Array[higherCell];
            Array[higherCell] = null;
            higherCell--;
            return element;
        }

        public void Info()
        {
            Console.WriteLine("The last element is: " + Array[higherCell]);
        }

        public override string ToString()
        {
            string answer = "";
            foreach(var cell in Array)
            {
                answer = answer + " " + cell;
            }
            return answer;
        }
    }
}
