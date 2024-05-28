class Menu
{
    List<Produto> listaDeProdutos = new List<Produto>();

    public void Opcoes()
    {
        Console.Clear();
        Console.WriteLine("\nDigite 1 para cadastrar Produto");
        Console.WriteLine("\nDigite 2 para listar os produtos");        
        Console.WriteLine("\nDigite 3 para sair");
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
                Console.WriteLine($"Precione 'Enter' para confirmar");
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
    }


    private void CadastrarProduto()
    {
        Console.Clear();
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
    

    private void ListarProdutos()
    {
        Console.Clear();
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

    private void CadastrarListaDeProdutos(Produto produto)
    {
        listaDeProdutos.Add(produto);
    }
}