using System;

namespace ParenthesesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String expression;
            Console.WriteLine("Enter an expression :");
            expression = Console.ReadLine();

            if (IsValid(expression))
                Console.WriteLine("valid expression");
            else
                Console.WriteLine("invalid expression");
        }
        static bool IsValid(String expression)
        {
            StackA st = new StackA();

            char ch;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' || expression[i] == '{' || expression[i] == ']')
                {
                    st.Push(expression[i]);
                }
                if (expression[i] == ')' || expression[i] == '}' || expression[i] == ']')

                    if (st.IsEmpty())
                    {
                        Console.WriteLine("right paranthesis are more than left paranthasis");
                        return false;
                    }
                    else
                    {
                        ch = st.Pop();
                        if (!MathParanthesis(ch, expression[i]))
                        {
                            Console.WriteLine("Mismatched paranthesis are :");
                            Console.WriteLine(ch + "    " + expression[i]);
                            return false;
                        }
                    }
            }
                
                if (st.IsEmpty())
                {
                    Console.WriteLine("balenced paranthesis");
                    return true;
                }
                else
                {
                    Console.WriteLine("left paranthesis are more than right parantheses");
                    return false;
                }
            
        }
        static bool MathParanthesis(char leftpar,char rightpar)
        {
            if (leftpar == '[' && rightpar == ']')
                return true;
            if (leftpar == '{' && rightpar == '}')
                return true;
            if (leftpar == '(' && rightpar == ')')
                return true;
            return false;
        }
    }
}
