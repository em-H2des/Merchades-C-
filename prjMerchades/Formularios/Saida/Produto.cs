using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchad
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public string UnidadeMedida { get; set; }
        public string Categoria { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCusto { get; set; }
        public int EstoqueAtual { get; set; }
        public int EstoqueMinimo { get; set; }
        public bool Status { get; set; }
        public string Fornecedor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string UsuarioCadastro { get; set; }

        public Produto()
        {
            DataCadastro = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            Status = true;
            EstoqueMinimo = 5;
        }

        public bool EstoqueBaixo()
        {
            return EstoqueAtual <= EstoqueMinimo;
        }

        public bool Validar()
        {
            return !string.IsNullOrEmpty(Nome) && PrecoVenda > 0;
        }
    }

    public class ItemVenda
    {
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Total => Quantidade * PrecoUnitario;

        public ItemVenda() { }

        public ItemVenda(int codigoProduto, string descricao, int quantidade, decimal precoUnitario)
        {
            CodigoProduto = codigoProduto;
            Descricao = descricao;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public void AumentarQuantidade(int quantidade = 1)
        {
            Quantidade += quantidade;
        }

        public void DiminuirQuantidade(int quantidade = 1)
        {
            Quantidade = Math.Max(0, Quantidade - quantidade);
        }

        public bool Validar()
        {
            return CodigoProduto > 0 &&
                   !string.IsNullOrEmpty(Descricao) &&
                   Quantidade > 0 &&
                   PrecoUnitario >= 0;
        }
    }

    public class Venda
    {
        public int NumeroVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public List<ItemVenda> Itens { get; set; }
        public decimal Subtotal => Itens.Sum(i => i.Total);
        public decimal Desconto { get; set; }
        public decimal Total => Subtotal - Desconto;
        public string FormaPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco => ValorPago - Total;
        public string Status { get; set; }

        public Venda()
        {
            DataVenda = DateTime.Now;
            Itens = new List<ItemVenda>();
            Status = "Em Andamento";
            Desconto = 0;
        }

        public void AdicionarItem(ItemVenda novoItem)
        {
            var itemExistente = Itens.FirstOrDefault(i => i.CodigoProduto == novoItem.CodigoProduto);

            if (itemExistente != null)
            {
                itemExistente.AumentarQuantidade(novoItem.Quantidade);
            }
            else
            {
                Itens.Add(novoItem);
            }
        }

        public void RemoverItem(int codigoProduto)
        {
            var item = Itens.FirstOrDefault(i => i.CodigoProduto == codigoProduto);
            if (item != null)
                Itens.Remove(item);
        }

        public bool AlterarQuantidade(int codigoProduto, int novaQuantidade)
        {
            var item = Itens.FirstOrDefault(i => i.CodigoProduto == codigoProduto);
            if (item != null && novaQuantidade > 0)
            {
                item.Quantidade = novaQuantidade;
                return true;
            }
            return false;
        }

        public void AplicarDesconto(decimal valorDesconto)
        {
            Desconto = Math.Min(valorDesconto, Subtotal);
        }

        public int TotalItens()
        {
            return Itens.Sum(i => i.Quantidade);
        }

        public void FinalizarVenda(string formaPagamento, decimal valorPago)
        {
            FormaPagamento = formaPagamento;
            ValorPago = valorPago;
            Status = "Finalizada";
        }

        public void CancelarVenda()
        {
            Status = "Cancelada";
        }

        public bool PodeSerFinalizada()
        {
            return Itens.Any() && Total >= 0 && Status == "Em Andamento";
        }

        public void LimparItens()
        {
            Itens.Clear();
            Desconto = 0;
        }
    }
}