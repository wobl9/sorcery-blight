using Character;
using Character.Enemies;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Presentation.DungeonFeature
{
    public class BattleScene: MonoBehaviour, IBattleScene
    {
        private BattlePresenter _presenter;
        public Image EnemyImage;
        public Image PlayerImage;

        [SerializeField] private TMP_Text textView;
        
        private Dungeon _dungeon;
        private Room _currentRoom;
        private Player _player;
    
        [Inject]
        public void Construct(
            Dungeon dungeon,
            Player player
        )
        {
            _player = player;
            _dungeon = dungeon;
        }

        private void Start()
        {
            _presenter = new BattlePresenter(this, _dungeon.currentRoom, _player);
        }

        public void RenderScene(Enemy enemy, Player player)
        {
            EnemyImage.sprite = Resources.Load<Sprite>(enemy.SpritePath);
            PlayerImage.sprite = Resources.Load<Sprite>(player.SpritePath);
        }
    }
}