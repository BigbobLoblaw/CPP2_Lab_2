using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public enum CollectibleType
    {
        PINKCOIN,
        GOLDCOIN,
        SILVERCOIN,
        KEY
    }

    public CollectibleType currentCollectible;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (currentCollectible)
            {
                case CollectibleType.PINKCOIN:
                    Debug.Log("PinkCoin");
                    Destroy(gameObject);
                    break;
                case CollectibleType.GOLDCOIN:
                    Debug.Log("GoldCoin");
                    Destroy(gameObject);
                    break;
                case CollectibleType.SILVERCOIN:
                    Debug.Log("SilverCoin");
                    Destroy(gameObject);
                    break;
            }

        }
    }

}
