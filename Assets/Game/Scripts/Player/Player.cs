using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{  [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;

    public PlayerMana mana { get; set; }
    
    private PlayerAnimations animations;

    public PlayerHealth playerHealth { get; private set; }

    private void Awake()
    {
        animations = GetComponent<PlayerAnimations>();
        playerHealth = GetComponent<PlayerHealth>();
        mana = GetComponent<PlayerMana>();
    }

    public void ResetPlayer()
    {
        stats.ResetPlayer();
        animations.ResetPlayer();
        mana.ResetMana();
    }
}
