using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sorteador = new Random(); 
            int numero;
            int sorteio = sorteador.Next(1, 11);
            Console.WriteLine("Bem vindo a BLAZE Jogos\n");
            Console.WriteLine("Advinhe o numero de 1 até 10");
            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());
             
            Console.WriteLine("Parabéns, você digitou corretamente");

            if (numero > 10 || numero <1)
            {
                Console.WriteLine("Digite um valor valido");
                
                
            }
            if(numero == sorteio)
            {
              Console.WriteLine("Parabés,VOCE ACERTOU");
            }
            else
            {
                Console.WriteLine("Que pena, tente novamente");
                Main(null);
                return;
            }
            Console.ReadKey();
        }
        void atividade04pg87()
        {
            Console.WriteLine("digite a sua nota do ano retrasado");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a sua nota do ano passado");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a sua nota do ano atual");
            double nota3 = double.Parse(Console.ReadLine());
            double notafinal;
            if (nota > nota2)
            {
                notafinal = nota;
                Console.WriteLine($"o numero maior é {nota}");
                return;



            }
            if (nota > nota3)
            {
                notafinal = nota;
                Console.WriteLine($"o numero maior é {nota}");
                return;
            }
            if (nota2 > nota)
            {
                notafinal = nota2;
                Console.WriteLine($"o numero maior é {nota2}");
                return;
            }
            if (nota2 > nota3)
            {
                notafinal = nota2;
                Console.WriteLine($"o numero maior é {nota2}");
                return;
            }
            if (nota3 > nota)
            {
                notafinal = nota3;
                Console.WriteLine($"o numero maior é {nota3}");
                return;
            }
            if (nota3 > nota2)
            {
                notafinal = nota3;
                Console.WriteLine($"o numero maior é {nota3}");
                return;
            }
        }
        void atividade03pg84()
        {
            double nota1, nota2;

            Console.WriteLine("Digite sua média do bimestre passado");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua média atual");
            nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            if (media > 6.0)
            {
                Console.WriteLine($"sua nota é {media}, é superior a média esperada (6.0)");

            }
            if (media == 6.0)
            {
                Console.WriteLine($"sua nota é {media},nota igual a média minima (6.0)");

            }
            if (media < 6.0)
            {
                Console.WriteLine($"sua nota é {media}, nota inferior a média mínima (6.0)");

            }
            Console.ReadKey();

        }
        void atividade02pg81()
        {
            double nota;
            string nome;

            Console.WriteLine("informe seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Agora informe sua média atual");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 6.0)
            {
                Console.WriteLine($"Parabens {nome} você passou com media azul de {nota} !!");
            }
            else
            {
                Console.WriteLine($"Tu danço {nome} vai ter que reptir o ano letivo ta com {nota} de média");
            }
            Console.ReadKey();
        }
        void atividade01pg77()
        {
            int numero;
            Console.WriteLine("digite um numero que seja maior que 100 para somar com 150");
            numero = int.Parse(Console.ReadLine());

            if (numero > 100)
            {
                numero = numero + 150;
            }
            Console.WriteLine("o valor da sua conta é " + numero);
            Console.ReadKey();
        }
        void atividade02()
        {
            // double e float são idênticos
            // porém o float guarda mais números nas casas decimais
            double numero;

            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                numero = numero * 0.1;
            }
            Console.ReadKey();

        }
        void atividade01()
        {
            //NOME:literal
            string nome;
            //leia PESSOA
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("olá seja bem vindo" + nome);
            Console.ReadKey();
        }

    }   
    
}