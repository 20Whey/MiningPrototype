using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawnScript : MonoBehaviour
{
    public RoomManager roomManager;
    public GameObject spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        roomManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomManager>();
        if (roomManager != null)
        {
            if(roomManager.roomCount != roomManager.maxRooms)
            {
                AddRoom();
                roomManager.roomCount += 1;
            }
            else
            {
                Instantiate(roomManager.RecieveObject(), spawnTransform.transform.position, spawnTransform.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject SelectRoom()
    {
        int random = Random.Range(0, roomManager.room.Length);
        return roomManager.room[random];
    }

    void AddRoom()
    {
        Instantiate(roomManager.RecieveObject(), spawnTransform.transform.position, spawnTransform.transform.rotation);
    }
}
