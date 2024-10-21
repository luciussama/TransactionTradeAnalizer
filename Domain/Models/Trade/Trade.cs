using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Models.Trade
{
    public class Trade : ITrade
    {
        public double Value { get; set; }
        public ClientSector ClientSector { get; set; }
    }
}
