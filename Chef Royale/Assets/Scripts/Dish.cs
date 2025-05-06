using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public float foodQuality;
}
