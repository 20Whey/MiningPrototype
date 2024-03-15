using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NashRun : MonoBehaviour
{
    public NavMeshBake agent;
    public applyMarkersAndTextures apply;
    // Start is called before the first frame update
    void Start()
    {
        agent = GameObject.FindGameObjectWithTag("Nav").GetComponent<NavMeshBake>();
        apply = GameObject.FindGameObjectWithTag("GameController").GetComponent<applyMarkersAndTextures>();
        apply.addOres();
        agent.BakeNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
