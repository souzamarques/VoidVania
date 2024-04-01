using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;

    bool wasCollected = false;

    [SerializeField] int pointsForCoin = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if((other.tag == "Player") && (!wasCollected))
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoin);
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
