using System.Collections;
using System.Collections.Generic;
using BayatGames.SaveGameFree;
using Game.Scripts.Player;
using UnityEngine;

public class Player : MonoBehaviour
{  [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;

    public PlayerMana mana { get; set; }
    
    private PlayerAnimations animations;

    public PlayerHealth playerHealth { get; private set; }

    public PlayerAttack playerAttack { get; private set; }

    private void Awake()
    {
        animations = GetComponent<PlayerAnimations>();
        playerHealth = GetComponent<PlayerHealth>();
        mana = GetComponent<PlayerMana>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    public void ResetPlayer()
    {
        stats.ResetPlayer();
        animations.ResetPlayer();
        mana.ResetMana();
        SaveGame.Delete(Inventory.Instance.INVENTORY_KEY_DATA);
    }
}
