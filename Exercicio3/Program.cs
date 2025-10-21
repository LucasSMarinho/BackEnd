// See https://aka.ms/new-console-template for more information
int medida1;
int medida2;
int medida3;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("A medida do primeiro lado é?"); 
medida1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("A medida do primeiro lado é?"); 
medida2 = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("A medida do primeiro lado é?"); 
medida3 = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");

if (medida1 + medida2 + medida3 == 180)
{
    if (medida1 == medida2 && medida1 == medida3)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("O triângulo é equilátero");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else if (medida1 == medida2 || medida2 == medida3 || medida3 == medida1)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("O triângulo é isósceles");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else if (medida1 != medida2 && medida2 != medida3 && medida3 != medida1)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("O triângulo é escaleno");
        Console.WriteLine("----------------------------------------------------------------");
    }
}
else
{
    
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("ISSAS NÃO SÃO MEDIDAS DE TRIANGULOS!!!");
        Console.WriteLine("----------------------------------------------------------------");

}