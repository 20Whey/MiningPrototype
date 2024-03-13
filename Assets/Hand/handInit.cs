using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using static UnityEngine.UI.Image;
using UnityEngine.XR;

public class handInit : MonoBehaviour
{  
    System.Random rand = new System.Random();
    // Start is called before the first frame update
    public ScriptableObject[] startingHand;
    public Dictionary<string, ScriptableObject> Deck = new Dictionary<string , ScriptableObject>();
    void Awake()
    {
       for(int i = 0; i < startingHand.Length; i++)
        {
            Deck.Add(startingHand[i].name, startingHand[i]);
        }
      

    }


 public static KeyValuePair<string, ScriptableObject>[] drawCards(Dictionary<string, ScriptableObject> gamer, int amount)
            {
        KeyValuePair<string, ScriptableObject>[] drawnCards = new KeyValuePair<string, ScriptableObject>[amount];
        for (int i = 0; i < gamer.Count; i++)
        {
            var drawnCard = gamer.ElementAt(0);
            drawnCards[i] = drawnCard;
            gamer.Remove(gamer.ElementAt(0).Key);
        }
      return drawnCards;
 }

 
    public Dictionary<string, ScriptableObject> groupCardsByType(Dictionary<string, ScriptableObject> deck, int? groupType)
    {
        switch(groupType)
        {
            default:
                //WHO CAAAAAAAAAAAAREEEEEEEES
              shuffleDeck(deck);
                break;
        }
        return deck;
    }



    private Dictionary<string, ScriptableObject> shuffleDeck(Dictionary<string, ScriptableObject> deck)
    {
        deck = deck.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
        return deck;
    }



    // Update is called once per frame

}
