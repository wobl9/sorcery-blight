namespace Presentation.DungeonFeature
{
    public class RoomViewPresenter
    {
        private IRoomView _view;
        private Dungeon _dungeon;

        public RoomViewPresenter(IRoomView view, Dungeon dungeon)
        {
            _view = view;
            _dungeon = dungeon;
            view.ShowContent(_dungeon.rooms);
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