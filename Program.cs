using System;

namespace editor_texto_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que você deseja fazer ?");
      Console.WriteLine("1 - Abrir um arquivo");
      Console.WriteLine("2 - Criar um novo arquivo");
      Console.WriteLine("0 - Sair");

      short option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0: Sair(); break;
        case 1: Abrir(); break;
        case 2: Novo(); break;
        default: Menu(); break;
      }
    }
    static void Abrir()
    {

    }
    static void Novo()
    {

    }
    static void Sair()
    {
      System.Environment.Exit(0);
    }

  }
}
