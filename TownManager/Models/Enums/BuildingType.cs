namespace TownManager.Models.Enums
{
    public enum BuildingType
    {
        ElectronicsCompany,
        FireStation,
        Hospital,
        Hotel,
        House,
        MetallurgyCompany,
        Museum,
        PharmaceuticalCompany,
        PoliceStation,
        ProvisionCompany,
        Store,
        TextileCompany
    }

    public static class BuildingTypeExtentions
    {
        public static string GetName(this BuildingType buildingType)
        {
            switch (buildingType)
            {
                case BuildingType.ElectronicsCompany: 
                    return "Electronics";
                case BuildingType.FireStation:
                    return "Fire station";
                case BuildingType.Hospital:
                    return "Hospital";
                case BuildingType.Hotel:
                    return "Hotel";
                case BuildingType.House:
                    return "House";
                case BuildingType.MetallurgyCompany:
                    return "Metallurgy";
                case BuildingType.Museum:
                    return "Museum";
                case BuildingType.PharmaceuticalCompany:
                    return "Pharmaceutics";
                case BuildingType.PoliceStation:
                    return "Police station";
                case BuildingType.ProvisionCompany:
                    return "Provision";
                case BuildingType.Store:
                    return "Store";
                case BuildingType.TextileCompany:
                    return "Textile";
            }

            return "";
        }
    }
}
