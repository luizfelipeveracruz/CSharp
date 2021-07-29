using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //aula de variavel e condições
            //fazendo string com nome
            Console.WriteLine("Digite o nome do Aluno:");//o console le a linha com a variavel
            string nomeCompleto = Console.ReadLine(); //definindo uma variavel com a condicional string 
            
            
            //int - variável de numero inteiro   
            //int valorUm; //colocando variavel com uma condicional para adicionar um primeiro numero, qualquer valor
            //int valorDois; //Segunda variavel para definir o valor no codigo

            //Declarar Variaveis
            float nota1, nota2, nota3, media;

            //Entrada de dados
            Console.WriteLine("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine()); //aqui o console le a linha e ultiliza o Parse para converter numeros
            
            Console.WriteLine("----------------------");
           
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine()); //
           
            Console.WriteLine("----------------------");
            
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine()); //
           
            Console.WriteLine("----------------------");

            //processamento
                //int soma = valorUm + valorDois; //a variavel soma é igual ao valor colocado na variavel um mais a variavel dois
            media = (nota1+nota2+nota3)/3;

            //exibir

            if(media>5){
                //Valor verdadeiro
                Console.WriteLine("O aluno " +nomeCompleto+ " está APROVADO com a média: " +media);
                Console.WriteLine("----------------------");
            }else{
                //Valor Falso
                Console.WriteLine("O aluno " +nomeCompleto+ " está REPROVADO com a média: " +media);
                Console.WriteLine("----------------------");
            }

        }
    }
}
