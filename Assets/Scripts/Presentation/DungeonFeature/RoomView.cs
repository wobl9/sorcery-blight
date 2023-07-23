using System;
using Character;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Presentation.DungeonFeature
{
    public class RoomView: MonoBehaviour
    {
        public int id;
        private Dungeon.Dungeon _dungeon;
        private Player _player;
        private RoomViewPresenter _presenter;
        
        [Inject]
        public void Construct(
            Player player,
            Dungeon.Dungeon dungeon
        )
        {
            _player = player;
            _dungeon = dungeon;
        }

        private void Start()
        {
            _presenter = new RoomViewPresenter(this, _dungeon);
        }

        public void OnRoomClicked(int id)
        {
            _presenter.OnRoomClicked(id);
        }

        public void ShowBattleScene()
        {
            SceneManager.LoadScene("BattleScene");
        }
    }
}