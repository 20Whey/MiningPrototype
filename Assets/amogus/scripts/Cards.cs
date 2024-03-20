using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DwarfPunk
{
	[CreateAssetMenu(fileName = "Create Card", menuName = "Card")]
	public class card : ScriptableObject
	{

		
		public List<CardClass> cardType;
		public string[] attributes;
		public string material;
		public int supplyAmount;
		public int repairAmount;
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