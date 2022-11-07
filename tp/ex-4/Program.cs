Console.Clear();

double tp, tinto=0,branco=0,rose=0;

for (int i = 0; i < 50; i++)
{
    Console.WriteLine("1 - Tinto");
    Console.WriteLine("2 - Branco");
    Console.WriteLine("3 - Rose");

    Console.Write("\n\rEscolha o tipo de vinho:");
    tp = Convert.ToDouble(Console.ReadLine());

    switch (tp)
    {
        case 1:
            tinto = tinto+1;
        break;  

        case 2:
            branco = branco+1;
        break;  

        case 3:
            rose = rose +1;
        break;  


        
    }
}
Console.WriteLine($"Vinha Tinto: {(tinto / 10 * 100)}%");
Console.WriteLine($"Vinha Branco:{(branco / 10 * 100)}%");
Console.WriteLine($"Vinha Rose: {(rose / 10 * 100)}%" );





