Console.Clear();
double salario, bonificacao=0, auxilio=0;

for (int i = 1; i <= 25; i++)
{
    Console.Write("Informe o seu salário: ");
    salario = Convert.ToDouble(Console.ReadLine());

    if(salario <= 500){
        bonificacao = salario * 0.05;
    }else if(salario >= 500.01 && salario <= 1200.00){
        bonificacao = salario * 0.12;
    }else{
        bonificacao = 0;
    }

    if(salario <= 600){
        auxilio = 150;
    }else{
        auxilio = 100;
    }

    Console.WriteLine($"O sua bonifiação é de: {bonificacao:0.00}" );
    Console.WriteLine($"O seu auxílio é de: {auxilio:0.00}");
}


