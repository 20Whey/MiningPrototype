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

    private Color[] typeColors =
    {
        new Color(1f, 0f, 0f, 0.4f), //attack
        new Color(1f, 0.92f, 0.016f, 0.4f), //mining
    };
    void Start()
    {
        UpdateCard(); 
    }

    public void UpdateCard()
	{
        cardType.color = typeColors[(int)cardData.cardType[0]];

        nameText.text = cardData.cardName;
        damageText.text = $"deal {cardData.damage} damage";
        durabilityText.text = cardData.durability.ToString();
    }
}
