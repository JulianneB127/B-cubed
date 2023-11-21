using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollecter : MonoBehaviour
{
    private int watermelons = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("watermelon"))
        {
            Destroy(collision.gameObject);
            watermelons++;
            Debug.Log("watermelons: " +  watermelons);
        }
    }
}
