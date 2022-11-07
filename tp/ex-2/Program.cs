int valor, divisoes=0;
Console.Write("Informe um valor: ");
valor = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i<=valor; i++){
    if(valor % i == 0 && valor > 1){
        divisoes = divisoes+1;
    }
}

if(divisoes > 2 || valor == 1){
    Console.WriteLine("Não é um número primo.");
}else{
    Console.WriteLine("É um número primo.");
}