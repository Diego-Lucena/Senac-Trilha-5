using Comex.Modelos;
using Microsoft.Data.SqlClient;

namespace Comex.Data
{
    public class ProdutoDAL
    {
        public IEnumerable<Produto> Listar()
        {
            var lista = new List<Produto>();
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "SELECT * FROM PRODUTOS";
            using SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader dataReader = command.ExecuteReader();


            while (dataReader.Read()) 
            {
                string nomeProduto = Convert.ToString(dataReader["Nome"]);
                string descricaoProduto = Convert.ToString(dataReader["Descricao"]);
                double precoUnitario = Convert.ToDouble(dataReader["PrecoUnitario"]);
                int quantidadeProduto = Convert.ToInt32(dataReader["Quantidade"]);

                Produto produto = new Produto(nomeProduto)
                {
                    Descricao = descricaoProduto,
                    Quantidade = quantidadeProduto,
                    PrecoUnitario = precoUnitario,
                };

                lista.Add(produto);
            }
            return lista;
        }

        public void Adcionar(Produto produto)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "INSERT INTO PRODUTOS (Nome, Descricao, PrecoUnitario, Quantidade)" +
                "VELUES (@nomeProduto, @descricaoProduto, @precoUnitario, @quantidadeProduto)";

            using SqlCommand command = new SqlCommand (sql, connection);

            command.Parameters.AddWithValue("@nomeProduto", produto.Nome);
            command.Parameters.AddWithValue("@descricaoProduto", produto.Descricao);
            command.Parameters.AddWithValue("@precoUnitario", produto.PrecoUnitario);
            command.Parameters.AddWithValue("@quantidadeProduto", produto.Quantidade);

            int linhasAfetadas = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afestadas: {linhasAfetadas}");
        }
    }
}
