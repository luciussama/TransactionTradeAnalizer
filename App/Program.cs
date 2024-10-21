using Domain.Enums;
using Domain.Interfaces;
using Domain.Models.Trade;
using Service.TradeCategorizer;

List<ITrade> portfolio = new List<ITrade>
{
    new Trade { Value = 2000000, ClientSector = ClientSector.Private },
    new Trade { Value = 400000, ClientSector = ClientSector.Public },
    new Trade { Value = 500000, ClientSector = ClientSector.Public },
    new Trade { Value = 3000000, ClientSector = ClientSector.Public }
};

TradeCategorizer categorizer = new TradeCategorizer();
List<Risk> tradeCategories = categorizer.Categorize(portfolio);

foreach (var category in tradeCategories)
{
    Console.WriteLine(category);
}

