using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private int score = 0;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            score++;
            Debug.Log("Score: " + score);
            Destroy(transform.gameObject);
        }
    }
}
