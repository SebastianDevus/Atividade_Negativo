int numeroDigitado;

Console.WriteLine();

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado < 0)
{
    Console.WriteLine("O número é negativo");
}

Console.WriteLine();