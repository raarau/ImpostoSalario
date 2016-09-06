using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSalarioLiquido
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, porcentagem, calcImposto;
            
            Console.WriteLine("Bem vindo ao calculo do imposto de salário.");
            
            Console.WriteLine("\nDigite o seu salário: ");
            salario = float.Parse (Console.ReadLine());
           
            Console.WriteLine("\nDigite a porcentagem do imposto que será descontado.");
            porcentagem = float.Parse(Console.ReadLine());
            
            if ((porcentagem < 0) || (porcentagem > 100))
            {
                Console.WriteLine("\nValor inválido, por favor digite valores de 0 a 100.");
            }
            else
            {
                calcImposto = (porcentagem * salario) / 100;
                calcImposto = salario - calcImposto;
                Console.WriteLine("\nO seu salário liquido com desconto de "+porcentagem+"%"+" é: {0:C}",calcImposto);
                Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            }
            

            Console.ReadKey();


            



        }
    }
}
