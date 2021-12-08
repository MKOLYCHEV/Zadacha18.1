using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string line = Console.ReadLine();
            Console.WriteLine();

            Stack<char> stack = new Stack<char>();

            stack.Push('0'); // В стек изначально добавляется элемент для того, чтобы в строке 40 не возникало исключения.

            bool f = true;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                {
                    stack.Push(')');
                    f = false;
                }
                else if (line[i] == '{')
                {
                    stack.Push('}');
                    f = false;
                }
                else if (line[i] == '[')
                {
                    stack.Push(']');
                    f = false;
                }
                if (line[i] == stack.Peek())
                {
                    stack.Pop();
                }
            }

            stack.Pop(); // В стеке становится на один элемент меньше для компенсации действия из строки 19.

            if (stack.Count() == 0 && !f)
            {
                Console.WriteLine("В веденном предложении все скобки расставлены корректно.");
            }
            else if (stack.Count() != 0)
            {
                Console.WriteLine("В веденном предложении скобки расставлены некорректно.");
            }
            else if (f)
            {
                Console.WriteLine("В веденном предложении отсутствуют скобки.");
            }
            Console.ReadKey();
        }
    }
}
