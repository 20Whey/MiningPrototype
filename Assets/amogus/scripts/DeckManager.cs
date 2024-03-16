using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DwarfPunk;

public class DeckManager : MonoBehaviour
{
	public List<card> allCards = new List<card>();

	private int currentIndex = 0;

	void Start()
	{
		card[] cardLibrary = Resources.LoadAll<card>("Cards");

		allCards.AddRange(cardLibrary);

		HandManager hand = FindObjectOfType<HandManager>();
		for (int i = 0; i < 6; i++)
		{
			DrawCard(hand);
		}
	}
	public void DrawCard(HandManager handManager)
	{
		if(allCards.Count == 0)
		{
			return;		
		}

		card nextCard = allCards[currentIndex];
		handManager.AddCard(nextCard);
		currentIndex = (currentIndex + 1) % allCards.Count;
	}
}
