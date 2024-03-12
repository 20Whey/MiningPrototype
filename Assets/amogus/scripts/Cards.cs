using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DwarfPunk
{
	[CreateAssetMenu(fileName = "Create Card", menuName = "Card")]
	public class card : ScriptableObject
	{
		public List<CardClass> cardType;
		public string cardName;
		public int durability;
		public int damage;

		public enum CardClass
		{
			Attack,
			Mining,
		}
	}
}