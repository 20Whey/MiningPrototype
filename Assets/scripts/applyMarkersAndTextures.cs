using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class applyMarkersAndTextures : MonoBehaviour
{

    public Sprite[] sprt;
    public List<Transform> markList;
    // Start is called before the first frame update

    // Update is called once per frame




   //void Update(){
   //     if (Input.GetKeyDown(KeyCode.S)){
   //         foreach (var item in markList)
   //         {
   //         item.gameObject.AddComponent<SpriteRenderer>();
   //         SpriteRenderer cna = item.gameObject.GetComponent<SpriteRenderer>();
   //         int tmp = Random.Range(0, sprt.Length);
   //         cna.sprite = sprt[Random.Range(0, sprt.Length)];
   //         cna.size = new Vector2(0.05f, 0.05f);

   //         switch(tmp){
   //         default:
   //         //set hardness of object: multiplier on damage
   //         //set Amount range to drop on hit
   //         break;
   //         }


   //         }

   //     }

    public void addOres()
    {
        foreach (var item in markList)
        {
            item.gameObject.AddComponent<SpriteRenderer>();
            SpriteRenderer cna = item.gameObject.GetComponent<SpriteRenderer>();
            int tmp = Random.Range(0, sprt.Length);
            cna.sprite = sprt[Random.Range(0, sprt.Length)];
            cna.drawMode = SpriteDrawMode.Sliced;
            cna.size = new Vector2(2.2f, 2.5f);

            switch (tmp)
            {
                default:
                    //set hardness of object: multiplier on damage
                    //set Amount range to drop on hit
                    break;
            }


        }
    }



}
