namespace Presentation.DungeonFeature
{
    public class RoomViewPresenter
    {
        private RoomView _view;
        private Dungeon _dungeon;

        public RoomViewPresenter(RoomView view, Dungeon dungeon)
        {
            _view = view;
            _dungeon = dungeon;
        }
        
        public void OnRoomClicked(int id)
        {
            _dungeon.currentRoom = _dungeon.rooms[id];
            _view.ShowBattleScene();
        }

        public void OnEncounterClicked()
        {
            
        }
    }
}