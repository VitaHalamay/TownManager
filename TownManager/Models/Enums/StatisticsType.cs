using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Models.Enums
{
    public enum StatisticsType
    {
        MoneyCount,
        CitizensCount,
        WorkplacesCount,

        CultureLevel,
        ProvisionLevel,
        SecurityLevel,
        PrestigeLevel,
        HealthLevel,

        MedicinesCount,
        DevicesCount,
        SparePartsCount,
        ClothesCount


    }
    public static class StatisticsTypeExtentions
    {
        public static string GetName(this StatisticsType statisticsType)
        {
            switch (statisticsType)
            {
                case StatisticsType.CitizensCount:
                    return "Citizens";
                case StatisticsType.WorkplacesCount:
                    return "Workplaces";
                case StatisticsType.MoneyCount:
                    return "Money";
                case StatisticsType.CultureLevel:
                    return "Culture level";
                case StatisticsType.ProvisionLevel:
                    return "Provision level";
                case StatisticsType.SecurityLevel:
                    return "Security level";
                case StatisticsType.PrestigeLevel:
                    return "Prestige level";
                case StatisticsType.HealthLevel:
                    return "Health level";
                case StatisticsType.MedicinesCount:
                    return "Medicines";
                case StatisticsType.DevicesCount:
                    return "Devices";
                case StatisticsType.SparePartsCount:
                    return "Spare parts";
                case StatisticsType.ClothesCount:
                    return "Clothes";
            }

            return "";
        }
    }
}
