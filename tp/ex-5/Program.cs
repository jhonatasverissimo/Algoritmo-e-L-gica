Console.Clear();
int valor = 0;

Console.WriteLine("Informe o número que deseja saber o fatorial: ");
valor = Convert.ToInt32(Console.ReadLine());


for(int i = valor-1; i > 0; i--){
    valor = valor * i;
}

Console.WriteLine("O fatorial é: " + valor);

