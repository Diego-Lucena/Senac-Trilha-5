namespace Semana06.Modelos;

internal class Menu
{
    List<Produto> listaDeProdutos = new List<Produto>();

    void ExibirLogo()
    {
        Console.WriteLine(@"
    
────────────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██░░██████████─██░░██████░░██─██░░░░░░░░░░░░░░░░░░██─██░░██████████─████░░██──██░░████─
─██░░██─────────██░░██──██░░██─██░░██████░░██████░░██─██░░██───────────██░░░░██░░░░██───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░░░░░░░░░██─────██░░░░░░██─────
─██░░██─────────██░░██──██░░██─██░░██──██████──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──────────██░░██─██░░██───────────██░░░░██░░░░██───
─██░░██████████─██░░██████░░██─██░░██──────────██░░██─██░░██████████─████░░██──██░░████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
────────────────────────────────────────────────────────────────────────────────────────
    
    ");
        Console.WriteLine("Bem vindo ao projeto Comex!");
    }

    void ExibirTitulo(string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine($"{asteriscos}\n{titulo}\n{asteriscos}");

    }

    public void Opcoes()
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para cadastrar Produto");
        Console.WriteLine("Digite 2 para listar os produtos");        
        Console.WriteLine("Digite 3 para sair");
        Console.Write("\nDigite a sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        switch (opcaoEscolhida)
        {
            case 1:
                CadastrarProduto();
                break;
            case 2:
                ListarProdutos();
                break;           
            case 3:
                Console.WriteLine($"Precione 'Enter' para encerrar");
                break;
            default:
                Console.WriteLine("Opção invalida");
                Console.WriteLine("Digite 'Enter' para retornar ao menu");
                Console.ReadKey();
                Opcoes();
                break;
        }
    }

    private void CadastrarProduto()
    {
        Console.Clear();
        ExibirTitulo("Cadastro de Produto:");
        Console.Write("\nDigite o nome do produto: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite a descrição: ");
        string descricao = Console.ReadLine()!;
        Console.Write("Digite o preço: R$ ");
        float preco = float.Parse(Console.ReadLine()!);
        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Produto produto = new Produto (nome,descricao)
        {
            Preco_unitario = preco,
            Quantidade = quantidade
        };

        CadastrarListaDeProdutos(produto);
        Opcoes();
    }
    private void CadastrarListaDeProdutos(Produto produto)
    {
        listaDeProdutos.Add(produto);
    }

    private void ListarProdutos()
    {
        Console.Clear();
        ExibirTitulo("Exibindo os Produtos cadastrados:");
        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine(
            $"Nome: {produto.Nome}\n" +
            $"Descrição: {produto.Descricao}\n" +
            $"Preço: R$ {produto.Preco_unitario}\n" +
            $"Quantidade: {produto.Quantidade}\n"
            );
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
        Opcoes();
    }
}