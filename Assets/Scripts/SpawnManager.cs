using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject fan;
    public GameObject spawner;
    public GameObject whiteboard;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        SpawnSequence();
    }

    void SpawnSequence()
    {
        float spawnMeter = Random.Range(1, 20);
        GameObject newFan = Instantiate(fan, spawner.transform.position, spawner.transform.rotation);
        EnemyController enemyController = newFan.GetComponent<EnemyController>();
        enemyController.SetWhiteboard(whiteboard);
        enemyController.setPlayer(player);
        Invoke("SpawnSequence", spawnMeter);
    }
}
