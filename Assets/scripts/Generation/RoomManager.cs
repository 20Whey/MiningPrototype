using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public int maxRooms;
    public int roomCount;
    public int untilBendy;
    public GameObject[] room;
    public GameObject finalRoom;
    public List<GameObject> bendyRooms = new List<GameObject>();
    public bool hasLeft;
    public bool hasRight;

    // Start is called before the first frame update
    void Start()
    {
        untilBendy = 2;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public GameObject RecieveObject()
    {
        if (roomCount == maxRooms)
        {
            return finalRoom;
        }
        else if (untilBendy == 0 && bendyRooms.Count != 0)
        {
            untilBendy = Random.Range(1, 3);
            int randomIndex = Random.Range(0, bendyRooms.Count);
            GameObject selectedRoom = bendyRooms[randomIndex];
            bendyRooms.RemoveAt(randomIndex);
            return selectedRoom;
        }
        else if (roomCount != maxRooms)
        {
            untilBendy -= 1;
            int randomIndex = Random.Range(0, room.Length);
            return room[randomIndex];
        }
        else
        {
            return room[0];
        }

    }
}
