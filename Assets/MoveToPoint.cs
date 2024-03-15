using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    private RoomManager roomManager;

    // Start is called before the first frame update
    void Start()
    {
        roomManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomManager>();
        roomManager.movePoints.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
