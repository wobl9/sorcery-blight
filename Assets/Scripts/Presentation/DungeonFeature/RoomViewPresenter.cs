namespace Presentation.DungeonFeature
{
    public class RoomViewPresenter
    {
        private RoomView _view;
        private Dungeon.Dungeon _dungeon;

        public RoomViewPresenter(RoomView view, Dungeon.Dungeon dungeon)
        {
            _view = view;
            _dungeon = dungeon;
        }
        
        public void OnRoomClicked(int id)
        {
            _dungeon.SetCurrentRoom(_dungeon.Rooms[id]);
            _view.ShowBattleScene();
        }

        public void OnEncounterClicked()
        {
            
        }
    }
}