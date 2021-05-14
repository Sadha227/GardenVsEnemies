using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 5f;
    [SerializeField] Enemy[] enemyPrefabArray;
    bool spawn = true;


    IEnumerator Start() 
    {
        while(spawn) { yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime)); SpawnAttackers(); }
    }

    private void SpawnAttackers()
    {
        int enemuIndex = Random.Range(0, enemyPrefabArray.Length);
        Spawn(enemyPrefabArray[enemuIndex]);
    }

    private void Spawn(Enemy enemy) { Enemy newEnemy = Instantiate(enemy, transform.position, Quaternion.identity); }
    public void StopSpawn() { spawn = false; }
}
