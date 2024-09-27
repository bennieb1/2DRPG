using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{

    [SerializeField] private PlayerStats _stats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            useMana(5f);
        }
    }
    public void useMana(float amount)
    {
        if (_stats.Mana >= amount)
        {
            _stats.Mana = Mathf.Max(_stats.Mana -= amount, 0f);

        }
    }
  
  
}
