using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    Transform player;
    GameObject whiteBoard;

    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        agent.SetDestination(player.transform.position);
    }

    public void SetWhiteboard(GameObject _whiteboard)
    {
        whiteBoard = _whiteboard;
    }

    public void setPlayer(GameObject _player)
    {
        player = _player.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Action"))
        {
            whiteBoard.SetActive(true);
            Destroy(gameObject);
        }
    }
}
