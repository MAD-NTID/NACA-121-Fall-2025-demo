Node<string> data1 = new Node<string>("1");
Node<string> data2 = new Node<string>("2", data1);

Console.WriteLine(data2);
// Console.WriteLine(data1);

Console.WriteLine("Stack Magics\n");
Stack<string> myStack = new Stack<string>();
myStack.Push( "The" );
myStack.Push( "quick" );
myStack.Push( "brown" );
myStack.Push("fox");

Console.WriteLine(myStack);
Console.WriteLine("Contain The?" + myStack.Contains("The"));
Console.WriteLine(myStack);
Console.WriteLine("Popping the stack:" + myStack.Pop());
Console.WriteLine("The top of the stack is " + myStack.Peek());
Console.WriteLine("Nuking the stack.....3..2..1");
myStack.Clear();
Console.WriteLine("Explode!");
Console.WriteLine("Contain fox?" + myStack.Contains("fox"));
Console.WriteLine(myStack);

