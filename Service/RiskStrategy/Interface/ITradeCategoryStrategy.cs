using Domain.Enums;

namespace Domain.Interfaces
{
    public interface ITradeCategoryStrategy
    {
        Risk? GetCategory(ITrade trade);
    }
}