using Comex.Semana06.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_05.Modelos
{
    public class ItemPedido
    {
        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = produto.Preco_unitario;
            Subtotal = quantidade * produto.Preco_unitario;
        }

        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public double PrecoUnitario { get; private set; }
        public double Subtotal { get; private set; }

        public override string ToString()
        {
            return $"Produto: {Produto.Nome}, Quantidade: {Quantidade}, " +
                $"Preço Unitário: {PrecoUnitario:f2}, SubTotal: {Subtotal:f2}";
        }
    }
}
