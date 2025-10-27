// Stack<int> stack = new Stack<int>(2);
// stack.Push(1);
// stack.Push(3);
// Console.WriteLine(stack.Peek());
// stack.Pop();
// Console.WriteLine(stack.Peek());
// stack.Pop();
// Queue<int> queue = new Queue<int>(3);
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// Console.WriteLine(queue.Peek());

string filename = "movies.txt";
IPlayListMedia<Video> playListQueue = new PlayListMediaQueue<Video>();
IPlayListMedia<Video> playListStack = new PlayListMediaStack<Video>();


//read in the movies
Console.WriteLine($"Loading the file {filename}");
StreamReader reader = new StreamReader(filename);
//skip the header
reader.ReadLine();
while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    string[] tokens = line.Split(",");
    Video video = new Video(tokens[0], tokens[1], tokens[2]);
    Console.WriteLine($"Adding {line} to the stack");
    playListStack.Add(video);
    Console.WriteLine($"Adding {line} to the queue");
    playListQueue.Add(video);
}

reader.Close();
Console.WriteLine($"All files are loaded from {filename}");

//show stack playlist

//show queue playlist

//write to file