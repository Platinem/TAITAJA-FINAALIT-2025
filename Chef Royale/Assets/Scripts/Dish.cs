using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum FoodType
{
    rice,
    pasta,
    meat,
    fish,
    dessert,
}

public class Dish : MonoBehaviour
{
    public FoodType type;
    public TMP_Text foodQualityText;
    public TMP_Text staminaText;

    public float foodQuality;
    public float staminaUsage;

    private void OnEnable()
    {
        staminaText.text = staminaUsage.ToString("f0");
        foodQualityText.text = foodQuality.ToString("f0");
    }
}
