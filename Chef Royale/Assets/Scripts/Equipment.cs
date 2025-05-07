using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    cookbook,
    electricMixer,
    highQualityCookware,
    nonStickPan,
    sabotage,
    sharpKnife
}

public class Equipment : MonoBehaviour
{
    public EquipmentType type;
}
