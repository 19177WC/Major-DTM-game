using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Code so that when the bullet collides with an object it doesnt stay in the game and is instead destroyed
        Destroy(gameObject);
    }
}
