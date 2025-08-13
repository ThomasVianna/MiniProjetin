using System;

internal class Program
{
    private static void Main(string[] args)
    {
        PetShop petShop = new PetShop();

        // Objetos iniciais para teste
        petShop.AdicionarAnimal(new Cachorro("Rex", 3, 20.5));
        petShop.AdicionarAnimal(new Gato("Mia", 2, 5.3));

        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n=== MENU PETSHOP ===");
            Console.WriteLine("1 – Adicionar Animal");
            Console.WriteLine("2 – Remover Animal");
            Console.WriteLine("3 – Buscar Animal");
            Console.WriteLine("4 – Listar Animais");
            Console.WriteLine("5 – Salvar no Arquivo");
            Console.WriteLine("6 – Carregar do Arquivo");
            Console.WriteLine("0 – Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            try
            {
                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do animal: ");
                        string nome = Console.ReadLine();

                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Peso: ");
                        double peso = double.Parse(Console.ReadLine());

                        Console.Write("Tipo (1 - Cachorro, 2 - Gato, 3 - Passaro): ");
                        string tipo = Console.ReadLine();

                        if (tipo == "1")
                            petShop.AdicionarAnimal(new Cachorro(nome, idade, peso));
                        else if (tipo == "2")
                            petShop.AdicionarAnimal(new Gato(nome, idade, peso));
                        else if (tipo == "3")
                            petShop.AdicionarAnimal(new Passaro(nome, idade, peso));
                        else
                            Console.WriteLine("Tipo inválido!");
                        break;

                    case "2":
                        Console.Write("Digite o ID do animal para remover: ");
                        Guid idRemover = Guid.Parse(Console.ReadLine());
                        petShop.RemoverAnimalPorID(idRemover);
                        Console.WriteLine("Animal removido com sucesso!");
                        break;

                    case "3":
                        Console.Write("Digite o nome do animal para buscar: ");
                        string nomeBusca = Console.ReadLine();
                        petShop.BuscarPorNome(nomeBusca);
                        break;

                    case "4":
                        petShop.ListarAnimais();
                        break;

                    case "5":
                        Console.Write("Digite o caminho do arquivo: ");
                        string caminhoSalvar = Console.ReadLine();
                        petShop.SalvarEmArquivo(caminhoSalvar);
                        Console.WriteLine("Animais salvos com sucesso!");
                        break;

                    case "6":
                        Console.Write("Digite o caminho do arquivo: ");
                        string caminhoCarregar = Console.ReadLine();
                        petShop.CarregarDeArquivo(caminhoCarregar);
                        Console.WriteLine("Animais carregados com sucesso!");
                        break;

                    case "0":
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            catch (AnimalNaoEncontradoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
