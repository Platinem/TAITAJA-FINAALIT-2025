using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Card : MonoBehaviour
{
    private CardManager cardManager;
    private GameManager gameManager;
    private DeckManager deckManager;
    private CanvasGroup cg;
    public bool hasBeenUsed;
    public bool isSelected;

    public Transform originalTransform;

    private void Start()
    {
        cg = GetComponent<CanvasGroup>();
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
        deckManager = FindObjectOfType<DeckManager>();
    }
    private void OnEnable()
    {
        cg = GetComponent<CanvasGroup>();
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
        deckManager = FindObjectOfType<DeckManager>();
    }

    public void UseCard() 
    {
        if (!hasBeenUsed && isSelected && gameManager.gameStarted) 
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

    public void SelectCard()
    {
        if (!isSelected && !gameManager.gameStarted)
        {
            deckManager.PlaceCardInDeck(this);

            if (this.GetComponent<Dish>() != null)
            {
                cardManager.dishDeck.Add(this);
            }

            else if (this.GetComponent<Seasoning>() != null)
            {
                cardManager.seasoningDeck.Add(this);
            }

            else if (this.GetComponent<Equipment>() != null)
            {
                cardManager.equipmentDeck.Add(this);
            }

            else if (this.GetComponent<Technique>() != null)
            {
                cardManager.techniquesDeck.Add(this);
            }

            cg.alpha = 0.4f;
        }

        else
        {
            deckManager.RemoveCardFromDeck(this);

            if (this.GetComponent<Dish>() != null)
            {
                cardManager.dishDeck.Remove(this);
            }

            else if (this.GetComponent<Seasoning>() != null)
            {
                cardManager.seasoningDeck.Remove(this);
            }

            else if (this.GetComponent<Equipment>() != null)
            {
                cardManager.equipmentDeck.Remove(this);
            }

            else if (this.GetComponent<Technique>() != null)
            {
                cardManager.techniquesDeck.Remove(this);
            }

            cg.alpha = 1f;
        }
    }
}
