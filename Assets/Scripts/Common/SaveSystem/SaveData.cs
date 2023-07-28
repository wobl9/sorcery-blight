using System;

namespace utils.save
{
    [Serializable]
    public class SaveData
    {
        public GameState GameState;

        public SaveData(GameState gameState)
        {
            GameState = gameState;
        }
    }
}