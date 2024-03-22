Console.Clear(); 

Console.WriteLine("---- Soletrando ----\n");
Console.Write("Dígite um texto a ser soletrado: ");

string texto = Console.ReadLine()!;
Console.WriteLine("\nSoletrando fica....\n");

Console.WriteLine(
 String.Join("-",texto.ToUpper().ToCharArray())
);

Console.WriteLine();