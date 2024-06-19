namespace Comex.Semana06.Menu;
using Comex.Semana06.Produto;
using Semana_05.Modelos;
using Semana_06.API;
using System.Text.Json;

internal class Menu
{
    List<Produto> listaDeProdutos = new();
    //var listaPedidos = new List<Pedido>();

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
        Console.WriteLine("Digite 3 para lista de produtos externo");
        Console.WriteLine("Digite 4 criar pedido");
        Console.WriteLine("Digite -1 para sair");
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
                BuscaProdutoExterna();
                break;
            case 4:
                CriarPedido();
                break;
            case -1:
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

    public void BuscaProdutoExterna()
    {
        Console.Clear();
        ExibirTitulo("Lista de Produtos Externo:");
        ClienteApi requisicao = new ClienteApi();
        var resultado = requisicao.conexao().Result;
        var listaDeProdutos = JsonSerializer.Deserialize<List<Produto>>(resultado)!;
        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine($"Produto: {produto.Nome}\n" +
            $"Descrição: {produto.Descricao}\n" +
            $"Preço: {produto.Preco_unitario}\n");
        }
        Console.ReadKey();
        Opcoes();
    }

    public void CriarPedido() {

        Console.Clear();
        ExibirTitulo("Criar pedido");
        Console.WriteLine("Digite o nome do Cliente: ");
        string nomeCliente = Console.ReadLine();
        var cliente = new Cliente(nomeCliente);

        var pedido = new Pedido(cliente);

        var listaProdutos = new List<Produto>
{
    new Produto("Notebook")
    {
        Descricao = "Notebook Dell Inspiron",
        Preco_unitario = 3500.00,
        Quantidade = 10
    },
    new Produto("Smartphone")
    {
        Descricao = "Smartphone Samsung Galaxy",
        Preco_unitario = 1200.00,
        Quantidade = 25
    },
    new Produto("Monitor")
    {
        Descricao = "Monitor LG Ultrawide",
        Preco_unitario = 800.00,
        Quantidade = 15
    },
    new Produto("Teclado")
    {
        Descricao = "Teclado Mecânico RGB",
        Preco_unitario = 250.00,
        Quantidade = 50
    }
};

        while (true)
        {
            Console.WriteLine("\nProdutos Disponiveis: ");
            for (int i = 0; i < listaProdutos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {listaProdutos[i].Nome}");
            }

            Console.WriteLine("Digite o número do produto que deseja adicionar (0 para sair): ");
            int numeroProduto = int.Parse(Console.ReadLine());
            if (numeroProduto == 0)
            {
                break;
            }

            var produto = listaProdutos[numeroProduto - 1];

            Console.WriteLine("Digite a quntidade desejada: ");
            var quantidade = int.Parse(Console.ReadLine());

            var itemDePedido = new ItemPedido(produto, quantidade);
            pedido.AdicionarItem(itemDePedido);
            Console.WriteLine($"{itemDePedido} - adicionado com sucesso!\n");

        }
        var listaPedidos = new List<Pedido>();
        listaPedidos.Add(pedido);
        Console.WriteLine($"{pedido} - criado com sucesso!\n");
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
        Opcoes();
    }
}