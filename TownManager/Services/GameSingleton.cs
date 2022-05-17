using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;

namespace TownManager.Services
{
    public class GameSingleton
    {
        private static GameSingleton _gameSingletonInstance = null;

        public GameModel Model { get; set; }

        private GameSingleton()
        {
            Model = new GameModel();
        }

        public static GameSingleton GetInstance()
        {
            if (_gameSingletonInstance == null)
            {
                _gameSingletonInstance = new GameSingleton();
            }
            return _gameSingletonInstance;
        }

    }
}
