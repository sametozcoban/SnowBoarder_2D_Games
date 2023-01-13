using System;
using SnowBoarder.Characters;
using Unity.VisualScripting.FullSerializer.Internal.Converters;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


namespace SnowBoarder.Characters
{
    public class LevelControl : MonoBehaviour
    {
        
       
        public int level = 1;
        public int currentLevelxp;

        private bool hasColletable;
        public Progression _levelxp;

        //private PlayerData PlayerData;
        private void Start()
        {
        }

        private void Update()
        {
            if (hasColletable)
            {
                LevelUptade();
            }
        }
        
        public void LevelUptade()
        {
            foreach (var lxp in _levelxp.nextLevelXp)
            {
                if (currentLevelxp == lxp)
                {
                    level += 1;
                    hasColletable = false;
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Collectable")
            {
                hasColletable = true;
                currentLevelxp += 1;
                
                col.gameObject.SetActive(false);
            }
        }
        
        //public void SaveLevel()
        //{
        //    SaveSystem.SavePlayer(this);
        //}

        //public void LoadPlayer()
        //{
        //    PlayerData data = SaveSystem.LoadPlayer();

        //    level = data.playerLevel;
        //    experiencePoint = data.experience;
        //}
    }
}