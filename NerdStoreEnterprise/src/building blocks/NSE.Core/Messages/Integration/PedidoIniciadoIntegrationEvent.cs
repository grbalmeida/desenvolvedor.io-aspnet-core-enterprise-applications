using System;

namespace NSE.Core.Messages.Integration
{
    public class PedidoIniciadoIntegrationEvent : IntegrationEvent
    {
        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public int TipoPagamento { get; private set; }
        public decimal Valor { get; private set; }
        
        public string NomeCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string MesAnoVencimento { get; private set; }
        public string CVV { get; private set; }
    }
}
