// See https://aka.ms/new-console-template for more information
for (int i = 1; i <= 50; i++)
{
    if (i % 2 != 0)
    {
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine(i);
    Console.WriteLine("----------------------------------------------------------------");
    };
    Thread.Sleep(2000);
}
;