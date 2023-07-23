using System;
using Character;

namespace utils.save
{
    [Serializable]
    public class SaveData
    {
        public Player player;

        public SaveData(Player player)
        {
            this.player = player;
        }
    }
}