using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridScotchCreation : MonoBehaviour
{
    // Start is called before the first frame update


    public int len, wid;
    public float magicX, magicZ;
    public List<Transform> listOfPoints;
    public Vector3[,] matrix;
    public GameObject blnk;

void Start(){
    nDGrid();
}
     
    void nDGrid()
    {
          matrix = new Vector3[len, wid];
               
       
            for (int i = 0; i < wid; i++){
                GameObject curr = Instantiate(blnk, transform.position + new Vector3(0, 0, (i*5) +magicZ), transform.rotation, this.transform);
                listOfPoints.Add(curr.transform);
                }
            for (int j = 0; j < wid; j++){
                GameObject curr = Instantiate(blnk, transform.position + new Vector3(1,0 ,(j*5) + magicX), transform.rotation, this.transform);
                listOfPoints.Add(curr.transform);
            }
            
        }
    }
