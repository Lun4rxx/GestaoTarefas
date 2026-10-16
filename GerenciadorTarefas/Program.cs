namespace GerenciadorTarefas;

class Program
{
    private static List<string> tarefas = [];
    
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();
            string opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                    
                case "2":
                    ListarTarefa();
                    break;
                    
                case "3":
                    BuscarTarefaPorPalavraChave();
                    break;
                    
                case "4":
                    Sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
               
            }
            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadLine();
            Console.Clear();
        } 
        
    }

    private static void Sair()
    {
        Console.WriteLine("Saindo do programa...");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }

    private static void BuscarTarefaPorPalavraChave()
    {
       Console.Write("Digite o termo a ser buscado:");
       var palavraChave = Console.ReadLine();
       bool encontrado = false;
       Console.WriteLine("----- Resultado da Busca -----");
       foreach (var tarefa in tarefas)
       {
           if (tarefa.Contains(palavraChave, StringComparison.CurrentCultureIgnoreCase))
           {
               Console.WriteLine($"- {tarefa}");
               encontrado = true;
           }
       }

       if (!encontrado)
       {
           Console.WriteLine("Termo não encontrado!");
       }
    }

    private static void ListarTarefa()
    {
        if (tarefas.Count < 1)
        {
            Console.Write("Não há tarefas cadastradas!");
        }
        else
        {
            Console.WriteLine("--- Suas Tarefas ---");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($" - {tarefa}");
            }
        }
    }

    private static void AdicionarTarefa()
    {
      Console.Write("Digite a descrição da tarefa:");
      var descricaoNovaTarefa = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(descricaoNovaTarefa))
      {
          Console.WriteLine("A tarefa não foi adicionanda pois está vazia!");
      }
      else
      {
          tarefas.Add(descricaoNovaTarefa);
          Console.WriteLine("Tarefa Adicionada com sucesso!");
      }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");
        Console.WriteLine("""
                          1 - Adicionar nova tarefa
                          2 - Listar todas as tarefas
                          3 - Buscar tarefa por palavra - chave
                          4 - Sair
                          """);
        
        Console.Write("Escolha uma opção: ");
    }
}