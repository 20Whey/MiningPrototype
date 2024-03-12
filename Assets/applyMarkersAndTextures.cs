using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class applyMarkersAndTextures : MonoBehaviour
{



    public Sprite[] sprt;
    private GameObject grdSetup;
    public List<Transform> markList;
    // Start is called before the first frame update
    void Start()
    {
        grdSetup = gameObject;
        var comp = grdSetup.GetComponent<gridScotchCreation>();
        markList = comp.listOfPoints;
    }

    // Update is called once per frame




   void Update(){
if (Input.GetKeyDown(KeyCode.R)){
            foreach (var item in markList)
            {
            item.gameObject.AddComponent<SpriteRenderer>();
            SpriteRenderer cna = item.gameObject.GetComponent<SpriteRenderer>();
            int tmp = Random.Range(0, sprt.Length);
            cna.sprite = sprt[Random.Range(0, sprt.Length)];
            cna.size = new Vector2(0.25f, 0.25f);

            switch(tmp){
            default:
            //set hardness of object: multiplier on damage
            //set Amount range to drop on hit
            break;
            }


            }

        }

   }



}
