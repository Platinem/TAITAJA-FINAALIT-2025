using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool hasBeenUsed;

    public void UseCard() 
    {
        if (!hasBeenUsed) 
        {
            hasBeenUsed = true;
            Debug.Log("Card Used");
        }
    }
}
