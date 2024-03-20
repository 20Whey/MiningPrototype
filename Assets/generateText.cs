using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DwarfPunk;    

public class generateText : MonoBehaviour
{
    // Start is called before the first frame update
    public card currentCard;
    public string newSentence;
    public string[] attributes;
    void Start()
    {
        string returnSentence = " ";
        foreach(var item in attributes) {  
        switch(item){
        case "deal":
        returnSentence += $" Deals {currentCard.damage} to the target. (currentCard.modifierOre/currentCard.modifierEnemy)";
        break;

        case "deal-self":
        returnSentence += $" Deals {currentCard.damage} to self.";
        break;

        case "break":
        returnSentence += $" Breaks: (currentCard.breakAttributeStuff).";
        break;

        case "salvage":
        returnSentence += $" Returns (currentCard.) when salvaged.";
        break;
        
        case "supply":
        returnSentence += $" Returns {currentCard.supplyAmount} of {currentCard.material} to inventory.";
        break;

        case "repair":
        returnSentence += $"When discarded, repair self by {currentCard.repairAmount} durability.";
        break;

        case "valuable":
        returnSentence += $"Maybe this might sell well?";
        break;
        }


        }

        newSentence = returnSentence;
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}

