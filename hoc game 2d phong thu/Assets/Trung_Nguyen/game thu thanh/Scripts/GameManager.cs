using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Enemy[] enemyPrefabs;
    public float spawnTime;
    bool isGameOver;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (!isGameOver)
        {
            int randomEnemy = Random.Range(0, enemyPrefabs.Length);
            Enemy enemy = enemyPrefabs[randomEnemy];
            Instantiate(enemy, new Vector2 (8,0.2f), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
