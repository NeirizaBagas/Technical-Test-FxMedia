using System;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public enum ItemTypes { Coin, BonusCoin, TrapCoin }

    [Header("Item Type")]
    [SerializeField] private ItemTypes itemType;

    [SerializeField] private int basicValue = 1; // The value of the coin
    [SerializeField] private int bonusValue = 5; // The value of the bonus coin
    [SerializeField] private int trapValue = -1; // The value of the trap coin


    [Header("Sfx & Vfx")]
    [SerializeField] private AudioClip collectSfx;
    [SerializeField] private ParticleSystem collectVfx;

    public static event Action<int> OnItemCollected;
    
    public void Collect()
    {
        int score = 0;

        switch (itemType)
        {
            case ItemTypes.Coin:
                score = basicValue;
                break;
            case ItemTypes.BonusCoin:
                score = bonusValue;
                break;
            case ItemTypes.TrapCoin:
                score = trapValue;
                break;
        }

        if (collectSfx != null)
        {
            AudioSource.PlayClipAtPoint(collectSfx, transform.position);
        }

        if (collectVfx != null)
        {
            ParticleSystem effect = Instantiate(collectVfx, transform.position, Quaternion.identity);
            Destroy(effect.gameObject, effect.main.duration); // Destroy the particle system after its duration
        }

        OnItemCollected?.Invoke(score);
        Destroy(gameObject); // Destroy the coin object after collection
    }
}
