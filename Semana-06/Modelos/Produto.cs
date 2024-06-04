namespace Semana06.Modelos;
public class Produto
{
        public Produto(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }

    public string Nome {get;}
    public string Descricao {get;}
    public float Preco_unitario {get; set;}
    public int Quantidade {get; set;}
    public string InformacaoResumida => $"Nome do produto {Nome}, sestá é a descrição {Descricao}, preço unitario {Preco_unitario}, quantidade {Quantidade}.";

}
