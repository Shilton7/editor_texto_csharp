using System;
using System.IO;

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
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
      Console.WriteLine("-----------------------------");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }

      while (Console.ReadKey().Key != ConsoleKey.Escape);
      {
        Console.Write(text);
        Salvar(text);
      }

    }

    static void Salvar(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual o caminho que deseja salvar o arquivo ?");

      string path = Console.ReadLine();

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }

    }

    static void Sair()
    {
      System.Environment.Exit(0);
    }

  }
}
