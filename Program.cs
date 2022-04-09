double n1, n2;

Console.Write("Digite o primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2){
    Console.WriteLine($"O maior número é {n1}");
}
else{
    Console.WriteLine($"O maior numero é {n2}");
}


