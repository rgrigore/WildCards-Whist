using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour {

	public bool acceptCard = false;
	public int cardCapacity;
	private int cardCount;

	private bool oldAcceptCard = true;

	void Start() {

	}

	private bool CheckCardCount() {
		return cardCount < cardCapacity;
	}

	void Update() {
		if (acceptCard != oldAcceptCard) {
			DropZone dropZone = transform.GetComponent<DropZone>();
			if (dropZone) {
				dropZone.enabled = acceptCard;
			}

			oldAcceptCard = acceptCard;
		}
	}
}
