using System;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int value = 1; // The value of the coin
    
    public static event Action<int> OnItemCollected;
    
    public void Collect()
    {
        OnItemCollected?.Invoke(value);
        Destroy(gameObject); // Destroy the coin object after collection
    }
}
