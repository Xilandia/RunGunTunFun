using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public List<GameObject> aliveEnemies;

    public int numToSpawn = 5;

    public bool onlyOnce = true;

    // Start is called before the first frame update
    void Start()
    {
        aliveEnemies = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onlyOnce) { // Input.GetMouseButtonDown(0)
            onlyOnce = false;
            
            StartCoroutine(loopDelay());

        }

        RemoveDeadEnemy();

        if (aliveEnemies.Count == 0) { // > 5
            //RemoveEnemy();  
            onlyOnce = true;
        }
        
    }

    void AddEnemy() {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawn = Random.Range(0, spawnPoints.Length);

        GameObject go = Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawn].position, transform.rotation);
        aliveEnemies.Add(go);
    }

    void RemoveEnemy() {
        for (int enemyNum = 0; enemyNum < numToSpawn; enemyNum ++) {
            Destroy(aliveEnemies[0]);
            aliveEnemies.Remove(aliveEnemies[0]);
        }
    }

    void RemoveDeadEnemy() {
        foreach  (GameObject enemyC in aliveEnemies) {
            if (enemyC == null) {
                aliveEnemies.Remove(enemyC);
            }
        }
    }

    IEnumerator loopDelay() {
        for (int enemyNum = 0; enemyNum < numToSpawn; enemyNum ++) {
            AddEnemy();

            yield return new WaitForSeconds(0.5f);
        }
    }
}
