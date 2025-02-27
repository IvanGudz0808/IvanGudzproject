using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] BoxCollider2D grid;
    void Start()
    {
        RandomizePosition();
    }

    void RandomizePosition()
    {
        Bounds bounds = grid.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f); 
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            RandomizePosition();
    }
}
