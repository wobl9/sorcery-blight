using System;
using System.Net.Mime;
using Character;
using Dungeon;
using TMPro;
using UnityEngine;
using Zenject;

namespace Presentation.DungeonFeature
{
    public class BattleScene: MonoBehaviour
    {
        private BattlePresenter _presenter;

        [SerializeField] private TextMeshPro _textView;
        
        private Dungeon.Dungeon _dungeon;
        private Room _currentRoom;
        private Player _player;
    
        [Inject]
        public void Construct(
            Player player,
            Dungeon.Dungeon dungeon
        )
        {
            _player = player;
            _dungeon = dungeon;
        }

        public void ShowText(string text)
        {
            _textView.text = text;
        }

        private void Start()
        {
            _presenter = new BattlePresenter(this, _dungeon.CurrentRoom, _player);
        }
    }
}