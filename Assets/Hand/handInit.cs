using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class handInit : MonoBehaviour
{
    // Start is called before the first frame update
    public ScriptableObject[] startingHand;
    public Dictionary<int, ScriptableObject> Deck = new Dictionary<int, ScriptableObject>();
    void Awake()
    {
       for(int i = 0; i < startingHand.Length; i++)
        {
            Deck.Add(i, startingHand[i]);
        }
      

    }







    // Update is called once per frame

}
