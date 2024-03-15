using System.Threading;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBake : MonoBehaviour
{
    public NavMeshSurface navMeshSurface; // Reference to the NavMeshSurface component
    public RoomManager roomManager;
    public bool temp = false;
    void Start()
    {
        roomManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomManager>();

        // Find the NavMeshSurface component if not assigned
        if (navMeshSurface == null)
        {
            navMeshSurface = GetComponent<NavMeshSurface>();
        }

        // Ensure the NavMeshSurface component is found
        if (navMeshSurface != null)
        {
            // Start the NavMesh baking process
            BakeNavMesh();
        }
        else
        {
            Debug.LogError("where the bombclart nav mesh");
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            navMeshSurface.BuildNavMesh();

        }

        if (roomManager.hasPicked == true && temp == false)
        {
            BakeNavMesh();
            temp = true;
        }
    }
    public void BakeNavMesh()
    {
        navMeshSurface.BuildNavMesh();
    }
}
