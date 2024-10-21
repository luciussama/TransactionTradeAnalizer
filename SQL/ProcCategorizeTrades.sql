CREATE PROCEDURE CategorizeTrades
AS
BEGIN
    -- Clear existing categories
    DELETE FROM TradeCategories;

    -- Insert LowRisk trades
    INSERT INTO TradeCategories (TradeId, Category)
    SELECT TradeId, 'LOWRISK'
    FROM Trades
    WHERE Value < 1000000 AND ClientSector = 'Public';

    -- Insert MediumRisk trades
    INSERT INTO TradeCategories (TradeId, Category)
    SELECT TradeId, 'MEDIUMRISK'
    FROM Trades
    WHERE Value > 1000000 AND ClientSector = 'Public';

    -- Insert HighRisk trades
    INSERT INTO TradeCategories (TradeId, Category)
    SELECT TradeId, 'HIGHRISK'
    FROM Trades
    WHERE Value > 1000000 AND ClientSector = 'Private';
END;
