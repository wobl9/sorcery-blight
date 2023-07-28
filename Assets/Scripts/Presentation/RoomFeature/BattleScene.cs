using Character;
using TMPro;
using UnityEngine;
using Zenject;

namespace Presentation.DungeonFeature
{
    public class BattleScene: MonoBehaviour
    {
        private BattlePresenter _presenter;

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

        public void ShowText(string text)
        {
            textView.text = text;
        }

        private void Start()
        {
            _presenter = new BattlePresenter(this, _dungeon.currentRoom, _player);
        }
    }
}