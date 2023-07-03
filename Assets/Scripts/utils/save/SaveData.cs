using System;

namespace utils.save
{
    [Serializable]
    public class SaveData
    {
        private Player _player;

        public SaveData(Player player)
        {
            _player = player;
        }
    }
}