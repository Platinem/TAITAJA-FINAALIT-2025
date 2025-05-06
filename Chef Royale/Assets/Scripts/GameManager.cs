using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    CardManager cardManager;
    public float dishScore;
    void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
    }

    // Calculates how much score your dish will have after you choose your seasoning
    public void AddSeasoning()
    {
        Dish dish = cardManager.finalDish[0].gameObject.GetComponent<Dish>();
        Seasoning seasoning = cardManager.finalDish[1].gameObject.GetComponent<Seasoning>();

        dishScore += dish.foodQuality; 

        switch (dish.type)
        {
            case FoodType.rice:
                if (seasoning.type == SeasoningType.salty)
                {
                    dishScore *= 1.4f;
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    dishScore *= 1.5f;
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    dishScore *= 0.8f;
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    dishScore *= 1.1f;
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    dishScore *= 1.7f;
                }
                return;

            case FoodType.pasta:
                if (seasoning.type == SeasoningType.salty)
                {
                    dishScore *= 1.4f;
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    dishScore *= 1.1f;
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    dishScore *= 0.6f;
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    dishScore *= 1.5f;
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    dishScore *= 1.6f;
                }
                return;
            case FoodType.meat:
                if (seasoning.type == SeasoningType.salty)
                {
                    dishScore *= 1.5f;
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    dishScore *= 0.9f;
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    dishScore *= 0.5f;
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    dishScore *= 1.3f;
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    dishScore *= 1.7f;
                }
                return;
            case FoodType.fish:
                if (seasoning.type == SeasoningType.salty)
                {
                    dishScore *= 1.7f;
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    dishScore *= 0.9f;
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    dishScore *= 0.7f;
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    dishScore *= 1.1f;
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    dishScore *= 0.8f;
                }
                return;
            case FoodType.dessert:
                if (seasoning.type == SeasoningType.salty)
                {
                    dishScore *= 1.3f;
                }
                else if (seasoning.type == SeasoningType.bitter)
                {
                    dishScore *= 1.2f;
                }
                else if (seasoning.type == SeasoningType.sour)
                {
                    dishScore *= 1.7f;
                }
                else if (seasoning.type == SeasoningType.sweet)
                {
                    dishScore *= 2f;
                }
                else if (seasoning.type == SeasoningType.spicy)
                {
                    dishScore *= 0.5f;
                }
                return;
        }
    }
}
