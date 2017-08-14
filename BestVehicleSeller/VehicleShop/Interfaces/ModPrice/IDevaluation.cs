﻿namespace VehicleShop.Interfaces.ModPrice
{
    public interface IDevaluation
    {
        // Reduces the price by 2% for each month from the date of manufacture
        void ApplyDevaluation();
        void DetachDevaluation();

    }
}