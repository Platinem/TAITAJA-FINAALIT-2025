using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private CardManager cardManager;
    private GameManager gameManager;
    public bool hasBeenUsed;

    private void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
    }
    public void UseCard() 
    {
        if (!hasBeenUsed) 
        {
            hasBeenUsed = true;

            cardManager.finalDish.Add(this);
            if (cardManager.finalDish.Count == 2)
            {
                gameManager.AddSeasoning();
            }

            else if (cardManager.finalDish.Count == 1)
            {
                gameManager.AddDish();
            }

            for (int i = 0; i < cardManager.discardPile.Count; i++)
            {
                if (cardManager.discardPile[i].isActiveAndEnabled)
                {
                    cardManager.discardPile[i].gameObject.SetActive(false);
                }
            }

            cardManager.discardPile.Clear();
        }
    }
}
