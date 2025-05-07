using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    private CardManager cardManager;
    private GameManager gameManager;

    public Transform[] deckSlots;
    public bool[] availableDeckSlots;

    private int i;
    void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    public void PlaceCardInDeck(Card card)
    {
        card.originalTransform.position = card.transform.position;

        if (deckSlots[i] && i <= availableDeckSlots.Length)
        {
            card.transform.position = deckSlots[i].position;
            availableDeckSlots[i] = false;
            i++;
        }
    }

    public void RemoveCardFromDeck(Card card)
    {
        if (deckSlots[i] == null)
        {
            card.transform.position = card.originalTransform.position;
            availableDeckSlots[i] = true;
            i--;
        }
    }
}
