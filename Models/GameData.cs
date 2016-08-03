using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    // Singleton class containing static gamedata like faiths, gods and the like that is used during the game.
    public sealed class GameData
    {
        private static GameData instance = null;
        private static readonly object padlock = new object();

        Dictionary<string, Faith> faiths;
        Dictionary<string, God> gods;

        GameData()
        {
            faiths = new Dictionary<string, Faith>();
            gods = new Dictionary<string, God>();
        }

        public static GameData Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null )
                    {
                        instance = new GameData();
                    }
                    return instance;
                }
            }
        }

        public Faith getFaith(string name)
        {
            return faiths[name];
        }

        public void  addFaith(string name, Faith faith)
        {
            faiths[name] = faith;
        }

        public God getGod(string name)
        {
            return gods[name];
        }

        public void addGod(string name, God god)
        {
            gods[name] = god;
        }
    }
}
    
