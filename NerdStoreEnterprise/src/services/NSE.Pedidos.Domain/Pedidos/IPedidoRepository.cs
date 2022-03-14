using NSE.Core.Data;
using NSE.Core.Models;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace NSE.Pedidos.Domain
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<Pedido> ObterPorId(Guid id);
        Task<PagedResult<Pedido>> ObterListaPorClienteId(Guid clienteId, int pageIndex, int pageSize);
        void Adicionar(Pedido pedido);
        void Atualizar(Pedido pedido);

        DbConnection ObterConexao();

        /* Pedido Item */
        Task<PedidoItem> ObterItemPorId(Guid id);
        Task<PedidoItem> ObterItemPorPedido(Guid pedidoId, Guid produtoId);
    }
}
