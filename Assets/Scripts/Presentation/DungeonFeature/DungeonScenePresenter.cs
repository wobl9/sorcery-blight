using Character;

namespace Presentation.DungeonFeature
{
    public class DungeonScenePresenter
    {
        private IDungeonScene _view;
        private Player _player;

        public DungeonScenePresenter(IDungeonScene view, Player player)
        {
            _view = view;
            _view.RenderPlayerImage(player.SpritePath);
        }
    }
}