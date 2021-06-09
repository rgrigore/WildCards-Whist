using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class CardSprites : ScriptableObject {

	public enum CardSuite {
		Hearts, Spades, Diamonds, Clubs
	};

	public enum CardValue {
		Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
	};

	[Serializable]
	public class ValueEntry {
		public CardValue value;
		public Sprite sprite;
	}

	[Serializable]
	public class SuiteEntry {
		public CardSuite code;
		public List<ValueEntry> values;
	}

	public Sprite cardBack;
	public List<SuiteEntry> cards;

	public Sprite GetSprite(CardCode code) {
		return cards[(int) code / 13].values[(int) code % 13].sprite;
	}
}
