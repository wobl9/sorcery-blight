using System;
using System.Collections.Generic;
using System.Linq;
using Character;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace Presentation.DungeonFeature
{
    public class RoomView : MonoBehaviour, IRoomView
    {
        public int id;
        [SerializeField] private Image imageTopLeft;
        [SerializeField] private Image imageTopRight;
        [SerializeField] private Image imageBottomLeft;
        [SerializeField] private Image imageBottomRight;
        private Dungeon _dungeon;
        private Player _player;
        private RoomViewPresenter _presenter;

        [Inject]
        public void Construct(
            Player player,
            Dungeon dungeon
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

        public void ShowContent(List<Room> rooms)
        {
            Room room = rooms.Find(room => room.id == id);
            int totalEncounters = room.Encounters.Count;
            if (totalEncounters == 0) return;
            var encounters = room.Encounters;
            SetupImageForEncounter(imageTopLeft, encounters, 0);
            SetupImageForEncounter(imageTopRight, encounters, 1);
            SetupImageForEncounter(imageBottomLeft, encounters, 2);
            if (totalEncounters > 3)
            {
                imageBottomRight.sprite = Resources.Load<Sprite>(RoomEncounter.UnknownNumberOfEncounterPath);
                imageBottomRight.enabled = true;
            }
            else if (totalEncounters == 3)
            {
                SetupImageForEncounter(imageBottomRight, encounters, 3);
                imageBottomRight.enabled = true;
            }
        }

        private void SetupImageForEncounter(Image imageView, List<RoomEncounter> rooms, int encounterIndex)
        {
            if (rooms.Count <= encounterIndex) return;
            imageView.sprite = Resources.Load<Sprite>(rooms[encounterIndex].ImagePath);
            imageView.enabled = true;
            
        }
    }
}