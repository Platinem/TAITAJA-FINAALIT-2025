using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> dishDeck = new List<Card>();
    public List<Card> seasoningDeck = new List<Card>();
    public List<Card> equipmentDeck = new List<Card>();
    public List<Card> techniquesDeck = new List <Card>();

    public List<Card> shuffledDishCards = new List <Card>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Randomize and select 3 cards in your dish deck
    public void ShuffleAndChooseDish() 
    {
        for (i = 0; i < 3; i++) 
        {
            dishDeck.Card randomCard = dishDeck[Random.Range(0, dishDeck.Length)];
            randomCard.SetActive(true);
        }
    }
}
