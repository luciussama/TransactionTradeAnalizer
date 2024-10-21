﻿using Domain.Enums;
using Domain.Interfaces;

namespace Service.RiskStrategy.Model
{
    public class HighRiskStrategy : ITradeCategoryStrategy
    {
   
        public Risk? GetCategory(ITrade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector == ClientSector.Private ? Risk.HighRisk : (Risk?)null;
        }
    }
}
