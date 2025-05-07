using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum TechniqueType
{
    frying,
    baking,
    boiling,
    grilling,
    smoking
}

public class Technique : MonoBehaviour
{
    public TechniqueType type;
    public float staminaUsage;

    public TMP_Text staminaText;

    private void OnEnable()
    {
        staminaText.text = staminaUsage.ToString("f0");
    }
}
