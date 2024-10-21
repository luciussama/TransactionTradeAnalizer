using Domain.Enums;
namespace Domain.Interfaces
{
    public interface ITrade
    {
        double Value { get; }
        ClientSector ClientSector { get; }

    }
}
