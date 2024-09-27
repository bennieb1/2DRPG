using System;
using UnityEngine;

namespace Game.Scripts
{
    public class DmgManager : MonoBehaviour
    {
        public static DmgManager instance;
        [SerializeField] private DmgText _dmgTextPrefab;

        private void Awake()
        {
            instance = this;
        }


        public void ShowDamageText(float dmgAmount, Transform parent)
        {

           DmgText text = Instantiate(_dmgTextPrefab, parent);
           text.transform.position += Vector3.right * .5f;
           text.SetDamgeText(dmgAmount);
        }

    }
}