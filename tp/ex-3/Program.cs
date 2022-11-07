Console.Clear();

int termo1 = 1,termo2 = 1, auxiliar,qt;
Console.Write("Informe quantos termos do Fibonacci você precisa: ");
qt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"termo: 1 = 1");
Console.WriteLine($"termo: 2 = 1");

for (int i = 3; i <= qt; i++)

{
    auxiliar = termo1 + termo2;
    termo1 = termo2;
    termo2 = auxiliar;
    Console.WriteLine($"termo: {i} = {auxiliar}");
}



