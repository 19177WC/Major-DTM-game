using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject Spawner; // Links spawner with game manager script
    public GameObject Player; // Links player with game manager script

    // Update is called once per frame
    void Update()
    {

    
        // If the player is no longer alive all enemies and the spawner will be destroyed so as not to create any more enemies after character death
        if (Player == null)
        {
            Destroy(Spawner);
            Destroy(GameObject.FindWithTag("Enemy"));
        }
    }
}
