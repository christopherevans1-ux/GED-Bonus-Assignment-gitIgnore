using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        randomPosition();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        randomPosition();
    }

    void randomPosition()
    {
        int x = Random.Range(-4, 4);
        int y = Random.Range(-4, 3);
        transform.position = new Vector2(x, y);
    }
}
