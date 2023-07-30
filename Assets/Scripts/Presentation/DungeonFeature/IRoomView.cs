using System.Collections.Generic;

namespace Presentation.DungeonFeature
{
    public interface IRoomView
    {
        public void ShowContent(List<Room> rooms);
        public void ShowBattleScene();
    }
}