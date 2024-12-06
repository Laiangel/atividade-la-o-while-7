using System;

class Program
{
    static void Main(string[] args)
    {
        // Define o número secreto
        int numeroSecreto = new Random().Next(1, 101); // Número aleatório entre 1 e 100
        int tentativa;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto (entre 1 e 100):");

        while (true)
        {
            // Solicita um número ao usuário
            Console.Write("Digite sua tentativa: ");
            if (int.TryParse(Console.ReadLine(), out tentativa))
            {
                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você adivinhou o número secreto!");
                    break;
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }
    }
}
