using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Playables;

public class Enemy : MonoBehaviour
{
    private GameManager gameManager;
    private CardManager cardManager;
    public SeasoningType seasoningType;
    public TechniqueType techniqueType;

    public TMP_Text dishText;
    public TMP_Text ratingText;

    public float dishRating;
    public string dishName;
    public string seasoningName;
    public string techniqueName;

    public float maxStamina;
    public float stamina;
    private float h;

    public float staminaUsage;

    void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    public void CreateOpponent()
    {
        stamina = maxStamina;
    }

    public void MakeDish()
    {
        h = 20;
        float i = stamina;
        i -= Random.Range(h, staminaUsage);
        dishRating = i;
        staminaUsage -= i;
        if (i <= 30)
        {
            h = 40;
        }

        CreateDishName();
        CreateSeasoning();
        CreateTechnique();

        dishText.text = "OPPONENT'S DISH: " + techniqueName + " " + seasoningName + " " + dishName;
        ratingText.text = "OPPONENT'S RATING:";
    }

    public void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.B))
        {
            CreateOpponent();
        }
    }

    public void CreateSeasoning()
    {
        var u = Random.Range(1, 5);
        switch (u)
        {
            case 1:
                seasoningName = "Salty";
                return;
            case 2:
                seasoningName = "Sweet";
                return;
            case 3:
                seasoningName = "Sour";
                return;
            case 4:
                seasoningName = "Bitter";
                return;
            case 5:
                seasoningName = "Spicy";
                return;
        }
    }

    public void CreateTechnique()
    {
        var y = Random.Range(1, 5);
        switch (y)
        {
            case 1:
                techniqueName = "Fried";
                return;
            case 2:
                techniqueName = "Baked";
                return;
            case 3:
                techniqueName = "Boiled";
                return;
            case 4:
                techniqueName = "Grilled";
                return;
            case 5:
                techniqueName = "Smoked";
                return;
        }
    }

    public void CreateDishName()
    {
        var i = Random.Range(1, 12);
        switch (i)
        {
            case 1:
                dishName = "Apple pie";
                return;
            case 2:
                dishName = "Beef wellington";
                return;
            case 3:
                dishName = "Cheese cake";
                return;
            case 4:
                dishName = "Cookies";
                return;
            case 5:
                dishName = "Egg fried rice";
                return;
            case 6:
                dishName = "Lasagna";
                return;
            case 7:
                dishName = "Macarons";
                return;
            case 8:
                dishName = "Pizza";
                return;
            case 9:
                dishName = "Red velvet cake";
                return;
            case 10:
                dishName = "Salmon";
                return;
            case 11:
                dishName = "Spaghetti";
                return;
            case 12:
                dishName = "Wok";
                return;
        }
    }
}
