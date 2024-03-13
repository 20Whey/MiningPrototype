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
    public Dictionary<int?, ScriptableObject> Deck = new Dictionary<int? , ScriptableObject>();
    void Awake()
    {
       for(int i = 0; i < startingHand.Length; i++)
        {
            Deck.Add(i, startingHand[i]);
        }

           Deck = shuffleDeck(Deck);
          KeyValuePair<int?, ScriptableObject>[] tmp = drawCards(Deck, 5);
            for(var i = 0; i < 4; i++){
                Debug.Log(tmp[i]);
            }
        

    }


 public static KeyValuePair<int?, ScriptableObject>[] drawCards(Dictionary<int?, ScriptableObject> gamer, int amount)
            {
        KeyValuePair<int?, ScriptableObject>[] drawnCards = new KeyValuePair<int?, ScriptableObject>[amount];
        for (int i = 0; i < gamer.Count; i++)
        {
            var drawnCard = gamer.ElementAt(0);
            drawnCards[i] = drawnCard;
            gamer.Remove(gamer.ElementAt(0).Key);
        }
      return drawnCards;
 }

 
    public Dictionary<int?, ScriptableObject> groupCardsByType(Dictionary<int?, ScriptableObject> deck, int? groupType)
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



    private Dictionary<int?, ScriptableObject> shuffleDeck(Dictionary<int?, ScriptableObject> deck)
    {
        deck = deck.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
        return deck;
    }



    // Update is called once per frame

}
