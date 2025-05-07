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
    public Transform trash;
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
        for (i = 0; i < amount; i++)
        {
            DrawCard(deck);
        }

        i = 0;
    }

    // Draws a card from a specified list and removes it from the list
    public void DrawCard(List<Card> deck)
    {
        if (deck.Count != 0)
        {
            Card randomCard = deck[Random.Range(0, deck.Count)];
            Debug.Log(randomCard);

            if (cardSlots[i] && i < availableCardSlots.Length)
            {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                Card spawnedCard = Instantiate(randomCard, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Game").transform);
                discardPile.Add(spawnedCard);
                spawnedCard.gameObject.SetActive(true);
                spawnedCard.transform.position = cardSlots[i].position;
                spawnedCard.transform.localScale *= 1.6f;
=======
=======
>>>>>>> Stashed changes
                Instantiate(randomCard, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Game").transform);
                randomCard.gameObject.SetActive(true);
                randomCard.transform.position = cardSlots[i].position;
>>>>>>> Stashed changes
                availableCardSlots[i] = false;
                deck.Remove(randomCard);
            }
        }
    }

    // Which types of cards to let the player choose from (dish, seasoning, equipment, technique)
    public void StartStage()
    {
        switch (stage)
        {
            case 0:
                gameManager.dish.SetActive(true);
                ClearDiscardPile();
                Shuffle(dishDeck, 3);
                stage += 1;
                return;
            case 1:
                gameManager.dish.SetActive(false);
                gameManager.technique.SetActive(true);
                ClearDiscardPile();
                Shuffle(techniquesDeck, 2);
                stage += 1;
                return;
            case 2:
                gameManager.equipment.SetActive(true);
                gameManager.technique.SetActive(false);
                ClearDiscardPile();
                Shuffle(equipmentDeck, 2);
               
                stage += 1;
                return;
            case 3:
                gameManager.seasoning.SetActive(true);
                gameManager.equipment.SetActive(false);

                ClearDiscardPile();
                Shuffle(seasoningDeck, 2);
                
                stage += 1;
                return;
            case 4:
                ClearDiscardPile();
                gameManager.seasoning.SetActive(false);
                gameManager.EndGame();

                return;

        }
    }

    public void ClearDiscardPile()
    {
        for (int i = 0; i < discardPile.Count; i++)
        {
            if (discardPile[i].isActiveAndEnabled)
            {
                discardPile[i].gameObject.GetComponent<CanvasGroup>().alpha = 0f;
                discardPile[i].gameObject.transform.position = trash.position;
            }
        }

        discardPile.Clear();
    }
}
