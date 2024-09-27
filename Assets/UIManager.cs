using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [Header("stats")]
   [SerializeField] private PlayerStats _stats;
   
   [Header("Bars")]
   [SerializeField] private Image Healthbar;
   [SerializeField] private Image manaBar;
   [SerializeField] private Image expbar;

   [Header("Text")] [SerializeField] private TextMeshProUGUI levelTMP;
   [Header("Text")] [SerializeField] private TextMeshProUGUI healthTMP;
   [Header("Text")] [SerializeField] private TextMeshProUGUI manaTMP;
   [Header("Text")] [SerializeField] private TextMeshProUGUI expTMP;

   private void Update()
   {
      UpdatePlayerUI();
   }

   private void UpdatePlayerUI()
   {
      Healthbar.fillAmount = Mathf.Lerp(Healthbar.fillAmount, _stats.Health / _stats.MaxHealth, 10f * Time.deltaTime);
      manaBar.fillAmount = Mathf.Lerp(manaBar.fillAmount, _stats.Mana / _stats.MaxMana, 10f * Time.deltaTime);
      expbar.fillAmount = Mathf.Lerp(expbar.fillAmount, _stats.CurrentExp / _stats.NextLevelExp, 10f * Time.deltaTime);
      
      
      levelTMP.text = $"level {_stats.Level}";
      healthTMP.text = $" {_stats.Health} / {_stats.MaxHealth}";
      manaTMP.text = $" {_stats.Mana} / {_stats.MaxMana}";
      expTMP.text = $" {_stats.CurrentExp} / {_stats.NextLevelExp}";

   }
}
