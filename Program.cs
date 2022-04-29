using System;

namespace treino2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            int tentativa = 3;
            while (resp == "s" && tentativa >0)
            {
                int input = new Random().Next(1, 5);
                Console.WriteLine("Tente acertar o numero de 1 a 5");
                Console.WriteLine("Digite um numero: ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == input)
                {
                    Console.WriteLine("Parabéns voce acertou!");

                }
                else
                {
                    Console.WriteLine("Voce errrrrrooou" );
                    
                }
                Console.WriteLine("Quer tentar novamente? (s/n)");
                resp = Console.ReadLine();
                tentativa--;
                
                Console.WriteLine($"Restam: {tentativa} tentativas");

                if (tentativa == 0) {
                    Console.WriteLine("Voce atingiu o numero de tentativas, tchau! ");
                }

            }
        }
    }
}
