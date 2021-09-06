using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour {

	public delegate bool CardValidator(Card card);
	public CardValidator cardValidator;

	public bool ValidateCard(Card card) {
		return cardValidator(card);
	}

	public void CardDropEvent(Card card) {

	}
}
