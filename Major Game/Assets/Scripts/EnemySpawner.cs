using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab; //Links the enemy prefab to the script

    [SerializeField]
    private float enemyInterval = 3.5f; //The enemy spawn rate
    // Start is called before the first frame update
    void Start()
    {
        //Spawns an enemy prefab every 3.5 seconds
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Code that states to spawn a new prefab of the enemy every 3.5 seconds
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
