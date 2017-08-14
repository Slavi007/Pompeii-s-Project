namespace VehicleShop.Interfaces.ModEquipment
{
    using System.Collections.Generic;

    public interface IExtras
    {
        IDictionary<string, decimal> Extras {get; }

        void ApplyExtras(IDictionary<string, decimal> extras);
    }
}