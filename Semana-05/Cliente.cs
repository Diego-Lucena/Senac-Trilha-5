
public class Cliente
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
    public string Profissao {get;set;} = String.Empty;
    public string Telefone {get;set;} = String.Empty;
    public Endereco Endereco {get;set;}
}
