using Character;

namespace Presentation.DungeonFeature
{
    public class BattlePresenter
    {
        private Player _player;
        private Room _room;
        private IBattleScene _view;

        public BattlePresenter(
            IBattleScene view,
            Room room,
            Player player
        )
        {
            _view = view;
            _room = room;
            _player = player;
            _view.RenderScene(room.Enemy, player);
        }
    }
}