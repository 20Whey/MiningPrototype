using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AI;

public class CameraMovement : MonoBehaviour
{
    public RoomManager roomManager;
    public float minSpeed = 1f;
    public float maxSpeed = 5f;

    public int currentIndex = 0;
    private bool temp = false;

    public NavMeshAgent agent;

    private void Start()
    {
        roomManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomManager>();
        agent.speed = 0;
    }

    private void Update()
    {
        if (roomManager.hasPicked == true && temp == false)
        {
            agent.speed = 10;
            temp = true;
        }

        if (roomManager.movePoints != null && roomManager.movePoints.Count > 0)
        {
            if (!agent.pathPending && !agent.hasPath && currentIndex < roomManager.movePoints.Count)
            {
                agent.SetDestination(roomManager.movePoints[currentIndex].transform.position);
            }

            if (!agent.pathPending && !agent.hasPath && agent.remainingDistance < 0.1f && currentIndex != roomManager.movePoints.Count)
            {
                currentIndex++;
            }
        }
    }
}
