Console.WriteLine("Zadejte prvního numbera");
string cislo = Console.ReadLine();
int a = Convert.ToInt32(cislo);
Console.WriteLine("Zadejte druhého numbera");
string cislo2 = Console.ReadLine();
int b = Convert.ToInt32(cislo2);

if (a == b)
{
    Console.WriteLine("čísla se schodují");
}
else


if (a > b)
{
    
    Console.WriteLine(cislo);
    Console.WriteLine(cislo2);
    Console.WriteLine("První číslo je větší než druhé");
}
else
{
    Console.WriteLine(cislo2);
    Console.WriteLine(cislo);
    Console.WriteLine("druhé číslo je větší než první");
}