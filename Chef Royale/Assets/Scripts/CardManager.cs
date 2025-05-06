using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> dishDeck = new List<Card>();
    public List<Card> seasoningDeck = new List<Card>();
    public List<Card> equipmentDeck = new List<Card>();
    public List<Card> techniquesDeck = new List<Card>();

    public List<Card> discardPile = new List<Card>();
    public List<Card> finalDish = new List<Card>();

    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    private int i;
    private int stage;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Shuffle(dishDeck, 3);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Shuffle(seasoningDeck, 2);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartStage();
        }
    }

    // Randomize and select 3 cards in your specified deck
    public void Shuffle(List<Card> deck, int amount)
    {
        for (i = 0; i < amount;)
        {
            DrawCard(deck);
        }

        i = 0;
    }

    // Draws a card from a specified list and removes it from the list
    public void DrawCard(List<Card> deck)
    {
        if (deck != null)
        {
            Card randomCard = deck[Random.Range(0, deck.Count)];

            if (cardSlots[i] && i <= availableCardSlots.Length)
            {
                randomCard.gameObject.SetActive(true);
                randomCard.transform.position = cardSlots[i].position;
                availableCardSlots[i] = false;
                discardPile.Add(randomCard);
                dishDeck.Remove(randomCard);
                
                i++;
            }
        }
    }

    // Which types of cards to let the player choose from (dish, seasoning, equipment, technique)
    public void StartStage()
    {
        switch (stage)
        {
            case 0:
                Shuffle(dishDeck, 3);
                stage += 1;
                return;
            case 1:
                Shuffle(seasoningDeck, 2);
                stage += 1;
                gameManager.AddSeasoning();
                return;
            case 2:
                Shuffle(equipmentDeck, 2);
                stage += 1;
                return;
            case 3:
                Shuffle(techniquesDeck, 2);
                stage += 1;
                return;
        }
    }
}
