using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeBar.ModuloProduto;

namespace ControleDeBar.ModuloConta
{
    public class Pedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeSolicitada { get; set; }

        private static int contadorIds = 0;

        public Pedido(Produto produto, int quantidadeEscolhida)
        {
            Id = ++contadorIds;
            Produto = produto;
            QuantidadeSolicitada = quantidadeEscolhida;
        }

        public decimal CalcularTotalParcial()
        {
            return Produto.Valor * QuantidadeSolicitada;
        }

        public override string ToString()
        {
            return $"{QuantidadeSolicitada} x {Produto.Nome}";
        }
    }
}
