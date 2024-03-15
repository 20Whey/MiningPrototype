using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToList : MonoBehaviour
{
    public applyMarkersAndTextures applyMarkersAndTextures;
    // Start is called before the first frame update
    void Start()
    {
        applyMarkersAndTextures = GameObject.FindGameObjectWithTag("GameController").GetComponent<applyMarkersAndTextures>();
        applyMarkersAndTextures.markList.Add(this.gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
