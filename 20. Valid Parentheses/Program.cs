using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из скобок (){}[]");

            string str = Console.ReadLine();

            Console.WriteLine(IsValid(str));

            Console.Read();


            bool IsValid(string s)
            {

                Stack stack = new Stack();          //Создаем стек

                foreach (char c in s)               //перебираем 
                {

                    switch (c)                      //Принимаем первый символ (и открывающие скобки)
                    {
                        case '(':
                            stack.Push(c);          //Пихаем в стек
                            break;
                        case '{':
                            stack.Push(c);
                            break;
                        case '[':
                            stack.Push(c);
                            break;
                    }

                    if (stack.Count == 0) return false;     //Если в первом символе нет открывающихся скобок - возвращаем falce

                    switch (c)
                    {
                        case ')':
                            if (stack.Peek().ToString() == "(") stack.Pop();    //Если пришла закрывающаяся скабка, проверяем её в стеке, если подходит, удаляем
                            else return false;                                  //Если нет, возвращаем falce
                            break;
                        case '}':
                            if (stack.Peek().ToString() == "{") stack.Pop();
                            else return false;
                            break;
                        case ']':
                            if (stack.Peek().ToString() == "[") stack.Pop();
                            else return false;
                            break;
                    }

                }
                if (stack.Count == 0) return true;                         //Если после всего цикла стек пустой, значит все скобки закрылись возвращаем true
                else return false;                                          // Если нет - Falce

            }

        }
    }
}
