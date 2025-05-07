using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    private CardManager cardManager;
    private GameManager gameManager;
    private DeckManager deckManager;
    private EventTrigger eventTrigger;
    private CanvasGroup cg;
    public bool hasBeenUsed;
    public bool isSelected;

    public Transform originalTransform;

    private void Start()
    {
        cg = GetComponent<CanvasGroup>();
        eventTrigger = GetComponent<EventTrigger>();
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
        deckManager = FindObjectOfType<DeckManager>();

    }
    private void OnEnable()
    {
        cg = GetComponent<CanvasGroup>();
        eventTrigger = GetComponent<EventTrigger>();
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
        deckManager = FindObjectOfType<DeckManager>();
    }

    public void UseCard() 
    {
        if (!hasBeenUsed && isSelected && gameManager.gameStarted) 
        {
            cardManager.StartStage();
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
            //deckManager.PlaceCardInDeck(this);

            if (this.GetComponent<Dish>() != null && deckManager.maxDishCards > cardManager.dishDeck.Count)
            {
                isSelected = true;
                cardManager.dishDeck.Add(this);
                cg.alpha = 0.4f;
            }

            else if (this.GetComponent<Seasoning>() != null && deckManager.maxSeasoningCards > cardManager.seasoningDeck.Count)
            {
                isSelected = true;
                cardManager.seasoningDeck.Add(this);
                cg.alpha = 0.4f;
            }

            else if (this.GetComponent<Equipment>() != null && deckManager.maxEquipmentCards > cardManager.equipmentDeck.Count)
            {
                isSelected = true;
                cardManager.equipmentDeck.Add(this);
                cg.alpha = 0.4f;
            }

            else if (this.GetComponent<Technique>() != null && deckManager.maxTechniqueCards > cardManager.techniquesDeck.Count)
            {
                isSelected = true;
                cardManager.techniquesDeck.Add(this);
                cg.alpha = 0.4f;
            }

        }

        else
        {
            //deckManager.RemoveCardFromDeck(this);
            
            if (this.GetComponent<Dish>() != null)
            {
                isSelected = false;
                cardManager.dishDeck.Remove(this);
                cg.alpha = 1f;
            }

            else if (this.GetComponent<Seasoning>() != null)
            {
                isSelected = false;
                cardManager.seasoningDeck.Remove(this);
                cg.alpha = 1f;
            }

            else if (this.GetComponent<Equipment>() != null)
            {
                isSelected = false;
                cardManager.equipmentDeck.Remove(this);
                cg.alpha = 1f;
            }

            else if (this.GetComponent<Technique>() != null)
            {
                isSelected = false;
                cardManager.techniquesDeck.Remove(this);
                cg.alpha = 1f;
            } 
        }
    }
}
