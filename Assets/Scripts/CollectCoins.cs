using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Coins coin = other.GetComponent<Coins>();

        if (coin != null)
        {
            coin.Collect();
        }
    }
}
