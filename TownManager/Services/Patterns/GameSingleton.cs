using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;

namespace TownManager.Services.Patterns
{
    public class GameSingleton
    {
        private static GameSingleton _gameSingletonInstance;

        private static object syncRoot = new Object();

        public GameModel Model { get; set; }

        private GameSingleton()
        {
            Model = new GameModel();
        }

        public static GameSingleton GetInstance()
        {
            //додаткова перевірка на те чи створений екземпляр, яка запобігає зайвому блокуванню, яке впливає на перформенс
            if (_gameSingletonInstance == null)
            {
                lock (syncRoot) //інші потоки мають чекати поки поточний потік створить instance 
                {
                   // якщо екземпляр не створений, і два потоки хочуть його створити, то після того
                   // як перший потік його створить, а другий потік дочекається цього моменту
                   //перевірка не дасть створити другому потоку ще один екземпляр
                    if (_gameSingletonInstance == null) 
                    {
                        _gameSingletonInstance = new GameSingleton();
                    }
                }

            }
            return _gameSingletonInstance;
        }

    }
}
