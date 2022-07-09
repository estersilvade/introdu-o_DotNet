// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); 
using System;

namespace Instrucoes
{
  class Program
  {
    static void Declaracoes() // Podemos declarar variaveis e costantes bno nosso codigo / elas podem ser locais dentro de um metodo 
    {// A variavel tambem é mutavel  como no js
      int a;//inteiro bom a ideia aqui é mostrar que se pode criar variavel sem passar um valor 
      int b = 2, c = 3; // inteiro 
      const int d = 4; // constante  de inteiro 
      a = 1;
      Console.WriteLine(a + b + c + d);// assim ele  vai imprimir o valor 10 
    }

    // -- Istrução if  condicional 
    static void InstrucaoIf(string[] args) //recebendo um array de string 
    {
      if (args.Length == 0) // si meu arg .lef é = a 0 vai imprimir nada 
      {
        Console.WriteLine("Nenhum argumento");
      }
      else if (args.Length == 1)
      {
        Console.WriteLine("Um argumento");
      }
      else
      {
        Console.WriteLine($"{args.Length} argumentos"); // comcatenção parecida com a do js 
      }
    }

    static void InstrucaoSwitch(string[] args)// switch é mais simples na interpletação de codigo 
    {
      int numeroDeArgumentos = args.Length;// estou pegando o valor de  length com args e estou atribuindo para uma variavel minha  a mesmas  condiçoes que tem no if 
      switch (numeroDeArgumentos)
      {
        case 0:
          Console.WriteLine("Nenhum argumento");
          break;
        case 1:
          Console.WriteLine("Um argumento");
          break;
        default:
          Console.WriteLine($"{numeroDeArgumentos} argumentos");
          break; // a diferença aqui é o break 
      }
    }

    static void InstrucaoWhile(string[] args)// interar entre algus ites 
    {
      int i = 0; 
      while (i < args.Length) //  enquanto o i for menor que o numero de argumentos  vai imprimir o argumento de i 
      {
        Console.WriteLine(args[i]);
        i++;
      }
    }

    static void InstrucaoDo(string[] args) //  diferente  do Wile o Do  vai fazer a verificação no final 
    {
      string texto;  
      do
      {
        texto = Console.ReadLine(); // assim ele  vai ler o valo digitado na tela 
        Console.WriteLine(texto); //assim ele vai imprimir o valor da variavel text 
      } while (!string.IsNullOrEmpty(texto));// em quanto text não for nulo vai esecutando o ! é a negativa 
    }

    static void InstrucaoFor(string[] args)// o for  é a mesma regra 
      {
    {// declara o indic == enquanto o i for menor que o meu numero de argumento  vai somar 1 
      for (int i = 0; i < args.Length; i++) 
        Console.WriteLine(args[i]);
      }
    }

    static void InstrucaoForeach(string[] args) // foreach é mais simples que for 
    {
      foreach (string s in args) // pra cada string do meu array   eu vou dar um  write line
      {
        Console.WriteLine(s);
      }
    }

    static void InstrucaoBreak(string[] args)// while
    {
      while (true) // enquanto for verdadeiro ele executa a operação 
      {
        string s = Console.ReadLine();

        if (string.IsNullOrEmpty(s))
        {
          break;
        }

        Console.WriteLine(s);
      }
    }

    static void InstrucaoContinue(string[] args)
    {
      for (int i = 0; i < args.Length; i++)
      {
        if (args[i].StartsWith("/")) // se o valor começar com / ele vai para o prox
        {
          continue;// se não ele vai ar o valor da condição dentro do array 
        }

        Console.WriteLine(args[i]);
      }
    }

    static void InstrucaoReturn(string[] args)//  retorno 
    {
      int Somar(int a, int b)
      {
        return a + b;
      }

      Console.WriteLine(Somar(1, 2));
      Console.WriteLine(Somar(3, 4));
      Console.WriteLine(Somar(5, 6));
      return;
    }

    static void InstrucoesTryCatchFinallyThrow(string[] args)//try catch
    {
      double Dividir(double x, double y)
      {
        if (y == 0)
          throw new DivideByZeroException();

        return x / y;
      }

      try
      {
        if (args.Length != 2)
        {
          throw new InvalidOperationException("Informe 2 números");
        }

        double x = double.Parse(args[0]);
        double y = double.Parse(args[1]);
        Console.WriteLine(Dividir(x, y));
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine($"Erro genérico: {e.Message}");
      }
      finally
      {
        Console.WriteLine("Até breve!");
      }
    }

    static void InstrucaoUsing(string[] args)
    {
      using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
      {
        w.WriteLine("Line 1");
        w.WriteLine("Line 2");
        w.WriteLine("Line 3");
      }
    }
  }
}