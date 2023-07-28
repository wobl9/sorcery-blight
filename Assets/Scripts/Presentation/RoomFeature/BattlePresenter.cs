using Character;

namespace Presentation.DungeonFeature
{
    public class BattlePresenter
    {
        private Player _player;
        private Room _room;
        private BattleScene _view;

        public BattlePresenter(
            BattleScene view,
            Room room,
            Player player
        )
        {
            _view = view;
            _room = room;
            _player = player;
            _view.ShowText(_room.id.ToString());
        }
    }
}