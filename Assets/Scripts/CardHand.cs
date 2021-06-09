using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHand : MonoBehaviour {

	public CardSprites cardSprites;
	public Card cardPrefab;

	[Space(20)]
	[Tooltip("Testing purposes only.")]
	public CardCode cardToAdd;
	public bool hidden;

	public void AddCard(CardCode code, bool hidden) {
		Card newCard = Instantiate<Card>(cardPrefab, this.transform);
		newCard.Value = code;
		newCard.Face = cardSprites.GetSprite(code);
		newCard.Back = cardSprites.cardBack;
		newCard.SetHidden(hidden);
	}

	public void AddCard_test() {
		AddCard(cardToAdd, hidden);
	}
}
