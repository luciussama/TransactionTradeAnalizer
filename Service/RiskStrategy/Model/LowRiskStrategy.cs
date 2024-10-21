using Domain.Enums;
using Domain.Interfaces;
using Domain.Models.Trade;

namespace Service.RiskStrategy.Model
{
    public class LowRiskStrategy : ITradeCategoryStrategy
    {
          public Risk? GetCategory(ITrade trade)
        {
            return trade.Value < 1000000 && trade.ClientSector == ClientSector.Public ? Risk.LowRisk : (Risk?)null;
        }
    }
}
