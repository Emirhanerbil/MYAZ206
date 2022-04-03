string msg = "Selam";


var stack = new DataStructures.Stack.Stack<char>();

for (int i = 0; i < msg.Length; i++)
{
    stack.Push(msg[i]);
}

var n = stack.Count();
for (int i = 0; i < n; i++)
{
    Console.WriteLine(stack.Pop());
}

