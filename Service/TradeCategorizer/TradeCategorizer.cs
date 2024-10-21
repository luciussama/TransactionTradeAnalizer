using Domain.Enums;
using Domain.Interfaces;
using Service.RiskStrategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TradeCategorizer
{
    public class TradeCategorizer
    {
        private readonly List<ITradeCategoryStrategy> _strategies;

        public TradeCategorizer()
        {
            _strategies = new List<ITradeCategoryStrategy>
        {
            new LowRiskStrategy(),
            new MediumRiskStrategy(),
            new HighRiskStrategy()
        };
        }

        public List<Risk> Categorize(List<ITrade> trades)
        {
            var tradeCategories = new List<Risk>();

            foreach (var trade in trades)
            {
                foreach (var strategy in _strategies)
                {
                    var category = strategy.GetCategory(trade);
                    if (category != null)
                    {
                        tradeCategories.Add((Risk)category);
                        break;
                    }
                }
            }

            return tradeCategories;
        }
    }
}
