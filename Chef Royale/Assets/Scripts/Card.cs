using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private CardManager cardManager;
    public bool hasBeenUsed;

    private void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
    }
    public void UseCard() 
    {
        if (!hasBeenUsed) 
        {
            hasBeenUsed = true;

            cardManager.finalDish.Add(this);
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
