using Character;
using Character.Enemies;

namespace Presentation.DungeonFeature
{
    public interface IBattleScene
    {
        public void RenderScene(Enemy enemy, Player player);
    }
}