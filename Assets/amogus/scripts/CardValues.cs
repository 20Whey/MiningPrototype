using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DwarfPunk;

public class CardValues : MonoBehaviour
{

    public card cardData;

    public Image cardImage;
    public Image cardType;
    public TMP_Text nameText;
    public TMP_Text damageText;
    public TMP_Text durabilityText;

    private Sprite[] typeSprites =
    {
        
    };
    void Start()
    {
        UpdateCard(); 
    }

    public void UpdateCard()
	{
        cardImage.sprite = typeSprites[(int)cardData.cardType[0]];

        nameText.text = cardData.cardName;
        damageText.text = $"deal {cardData.damage} damage";
        durabilityText.text = cardData.durability.ToString();
    }
}
