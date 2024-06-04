namespace Semana06.Modelos;
internal class Cliente
{
        public Cliente (string nome, string cpf, string email)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
    }

    public string Nome {get;}
    public string Cpf {get;}
    public string Email {get;}
    public string Profissao {get;set;}
    public string Telefone {get;set;}
    public Endereco Endereco {get;set;}

    public void DadosDoCliente()
    {
        Console.WriteLine($"O cliente {Nome} reside na cidade de {Endereco.Cidade}, localizado na rua {Endereco.Rua}");
    }

}
