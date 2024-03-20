using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SearchForObjects : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ore")
        {
            
            Debug.Log("yup" + other.gameObject.name);
            agent.speed = 0;
        }
    }


}
