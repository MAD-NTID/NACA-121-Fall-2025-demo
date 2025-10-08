Printer printer = new Printer(10);



for (int i = 0; i < 10; i++)
{
    int doc = i + 1;
    bool added = printer.Add(doc);
    Console.WriteLine($"Adding {doc} to the printer status:{added}");
}

for (int i = 0; i < 9; i++)
{
    int doc = printer.Print();
    Console.WriteLine($"Printing the document:{doc}");
}

Console.WriteLine("Cancelling the last job");
int document = 10;
bool status = printer.Cancel(document);
Console.WriteLine($"Canceling document:{document} -->status:{status}");

//try a different type
PrinterGeneric<string> stringPrinter = new PrinterGeneric<string>(10);
PrinterGeneric<int> intPrinter = new PrinterGeneric<int>(10);


stringPrinter.Add("Hello Nai");
stringPrinter.Add("Hello Amber");

intPrinter.Add(1);
intPrinter.Add(2);
