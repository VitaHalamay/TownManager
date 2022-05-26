using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

namespace TownManager.Services.Patterns
{
    public class Flyweight
    {
        private Dictionary<BuildingType, string> Images = new Dictionary<BuildingType, string>();

        public string GetImage(BuildingType type)
        {
            if (!Images.ContainsKey(type))
            {
                var path = $"wwwroot/Images/{type}.png";
                byte[] content = File.ReadAllBytes(path);
                Images.Add(type, Convert.ToBase64String(content));
            }

            return Images[type];
        }
    }
}
