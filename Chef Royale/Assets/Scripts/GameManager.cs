using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    CardManager cardManager;
    public float dishScore;
    public float stamina;
    public bool gameStarted;
    void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
    }

    // Calculates how much score your dish will have after you choose your seasoning

    public void AddDish()
    {
        Dish dish = cardManager.finalDish[0].gameObject.GetComponent<Dish>();
        dishScore += dish.foodQuality;
    }
    public void AddSeasoning()
    {
        Dish dish = cardManager.finalDish[0].gameObject.GetComponent<Dish>();
        Seasoning seasoning = cardManager.finalDish[3].gameObject.GetComponent<Seasoning>();
        Technique technique = cardManager.finalDish[2].gameObject.GetComponent<Technique>();
        Equipment equipment = cardManager.finalDish[1].gameObject.GetComponent<Equipment>();

        switch (dish.type)
        {
            case FoodType.rice:
                if (seasoning.type == SeasoningType.salty)
                {
                    dishScore *= 1.4f;
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        if (equipment.type == EquipmentType.cookbook)
                        {
                            dishScore *= (1.4f * 2);
                        }
                        else
                        {
                            dishScore *= 1.4f;
                        }
                    }
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.5f * 2);
                    }
                    else
                    {
                        dishScore *= 1.5f;
                    }
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (0.8f / 2);
                    }
                    else
                    {
                        dishScore *= 0.8f;
                    }
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.1f * 2);
                    }
                    else
                    {
                        dishScore *= 1.1f;
                    }
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.7f * 2);
                    }
                    else
                    {
                        dishScore *= 1.7f;
                    }
                }
                return;

            case FoodType.pasta:
                if (seasoning.type == SeasoningType.salty)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.4f * 2);
                    }
                    else
                    {
                        dishScore *= 1.4f;
                    }
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.1f * 2);
                    }
                    else
                    {
                        dishScore *= 1.1f;
                    }
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (0.6f / 2);
                    }
                    else
                    {
                        dishScore *= 0.6f;
                    }
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.5f * 2);
                    }
                    else
                    {
                        dishScore *= 1.5f;
                    }
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.6f * 2);
                    }
                    else
                    {
                        dishScore *= 1.6f;
                    }
                }
                return;
            case FoodType.meat:
                if (seasoning.type == SeasoningType.salty)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.5f * 2);
                    }
                    else
                    {
                        dishScore *= 1.5f;
                    }
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (0.9f / 2);
                    }
                    else
                    {
                        dishScore *= 0.9f;
                    }
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (0.5f / 2);
                    }
                    else
                    {
                        dishScore *= 0.5f;
                    }
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.3f * 2);
                    }
                    else
                    {
                        dishScore *= 1.3f;
                    }
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.7f * 2);
                    }
                    else
                    {
                        dishScore *= 1.7f;
                    }
                }
                return;
            case FoodType.fish:
                if (seasoning.type == SeasoningType.salty)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.7f * 2);
                    }
                    else
                    {
                        dishScore *= 1.7f;
                    }
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (0.9f / 2);
                    }
                    else
                    {
                        dishScore *= 0.9f;
                    }
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    if (equipment.type == EquipmentType.cookbook)
                        {
                            dishScore *= (0.7f / 2);
                        }
                        else
                        {
                            dishScore *= 0.7f;
                        }
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.1f * 2);
                    }
                    else
                    {
                        dishScore *= 1.1f;
                    }
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    if (equipment.type == EquipmentType.cookbook)
                        {
                            dishScore *= (0.8f / 2);
                        }
                        else
                        {
                            dishScore *= 0.8f;
                        }
                }
                return;
            case FoodType.dessert:
                if (seasoning.type == SeasoningType.salty)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.3f * 2);
                    }
                    else
                    {
                        dishScore *= 1.3f;
                    }
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.2f * 2);
                    }
                    else
                    {
                        dishScore *= 1.2f;
                    }
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (1.7f * 2);
                    }
                    else
                    {
                        dishScore *= 1.7f;
                    }
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (2f * 2);
                    }
                    else
                    {
                        dishScore *= 2f;
                    }
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    if (equipment.type == EquipmentType.cookbook)
                    {
                        dishScore *= (0.5f / 2);
                    }
                    else
                    {
                        dishScore *= 0.5f;
                    }
                }
                return;
        }
    }
    public void AddEquipment()
    {
        Dish dish = cardManager.finalDish[0].gameObject.GetComponent<Dish>();
        Seasoning seasoning = cardManager.finalDish[3].gameObject.GetComponent<Seasoning>();
        Technique technique = cardManager.finalDish[2].gameObject.GetComponent<Technique>();
        Equipment equipment = cardManager.finalDish[1].gameObject.GetComponent<Equipment>();

        dishScore = dish.foodQuality;

        switch(equipment.type)
        {
            case EquipmentType.sharpKnife:
                stamina += dish.staminaUsage / 2;
                return;
            case EquipmentType.nonStickPan:
                if (technique.type == TechniqueType.frying)
                {
                    dishScore += 20;
                }
                return;
            case EquipmentType.electricMixer:
                if (technique.type == TechniqueType.baking)
                {
                    dishScore += 20;
                }
                return;
            case EquipmentType.highQualityCookware:
                if (dish.type == FoodType.fish)
                {
                    dishScore += 10;
                }
                return;
            case EquipmentType.sabotage:
                // add thing here
                return;      
        }
    }

    public void AddTechnique()
    {
        Dish dish = cardManager.finalDish[0].gameObject.GetComponent<Dish>();
        Seasoning seasoning = cardManager.finalDish[3].gameObject.GetComponent<Seasoning>();
        Technique technique = cardManager.finalDish[2].gameObject.GetComponent<Technique>();
        Equipment equipment = cardManager.finalDish[1].gameObject.GetComponent<Equipment>();

        dishScore -= dish.foodQuality;

        switch (technique.type)
        {
            case TechniqueType.frying:
                if (dish.type == FoodType.fish)
                {
                    dishScore += dish.foodQuality *= 1.5f;
                }
                else if (dish.type == FoodType.meat)
                {
                    dishScore += dish.foodQuality *= 1.5f;
                }
                else if (dish.type == FoodType.rice)
                {
                    dishScore += dish.foodQuality *= 1.3f;
                }
                else if (dish.type == FoodType.pasta)
                {
                    dishScore += dish.foodQuality *= 0.8f;
                }
                else if (dish.type == FoodType.dessert)
                {
                    dishScore += dish.foodQuality *= 0.8f;
                }
                return;

            case TechniqueType.grilling:
                if (dish.type == FoodType.fish)
                {
                    dishScore += dish.foodQuality *= 1.7f;
                }
                else if (dish.type == FoodType.meat)
                {
                    dishScore += dish.foodQuality *= 1.6f;
                }
                else if (dish.type == FoodType.rice)
                {
                    dishScore += dish.foodQuality *= 0.8f;
                }
                else if (dish.type == FoodType.pasta)
                {
                    dishScore += dish.foodQuality *= 0.7f;
                }
                else if (dish.type == FoodType.dessert)
                {
                    dishScore += dish.foodQuality *= 0.6f;
                }
                return;

            case TechniqueType.smoking:
                if (dish.type == FoodType.fish)
                {
                    dishScore += dish.foodQuality *= 1.7f;
                }
                else if (dish.type == FoodType.meat)
                {
                    dishScore += dish.foodQuality *= 1.6f;
                }
                else if (dish.type == FoodType.rice)
                {
                    dishScore += dish.foodQuality *= 1.2f;
                }
                else if (dish.type == FoodType.pasta)
                {
                    dishScore += dish.foodQuality *= 0.9f;
                }
                else if (dish.type == FoodType.dessert)
                {
                    dishScore += dish.foodQuality *= 0.7f;
                }
                return;

            case TechniqueType.boiling:
                if (dish.type == FoodType.fish)
                {
                    dishScore += dish.foodQuality *= 0.9f;
                }
                else if (dish.type == FoodType.meat)
                {
                    dishScore += dish.foodQuality *= 0.8f;
                }
                else if (dish.type == FoodType.rice)
                {
                    dishScore += dish.foodQuality *= 1.2f;
                }
                else if (dish.type == FoodType.pasta)
                {
                    dishScore += dish.foodQuality *= 1.5f;
                }
                else if (dish.type == FoodType.dessert)
                {
                    dishScore += dish.foodQuality *= 0.8f;
                }
                return;
            case TechniqueType.baking:
                if (dish.type == FoodType.fish)
                {
                    dishScore += dish.foodQuality *= 1.5f;
                }
                else if (dish.type == FoodType.meat)
                {
                    dishScore += dish.foodQuality *= 1.3f;
                }
                else if (dish.type == FoodType.rice)
                {
                    dishScore += dish.foodQuality *= 0.9f;
                }
                else if (dish.type == FoodType.pasta)
                {
                    dishScore += dish.foodQuality *= 1.1f;
                }
                else if (dish.type == FoodType.dessert)
                {
                    dishScore += dish.foodQuality *= 1.9f;
                }
                return;
        }
    }
}
