// See https://aka.ms/new-console-template for more information

using Generics1;

MyStack<int> stack = new MyStack<int>();
for (int i = 0; i < 10;i++)
{
    stack.Push(i);
}

while (stack.Count() != 0)
{
    Console.WriteLine(stack.Pop());
}