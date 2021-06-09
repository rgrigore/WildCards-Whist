using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
	public CardCode Value { get; set; }
	public Sprite Face { get; set; }
	public Sprite Back { get; set; }

	[Space(20)]
	[Tooltip("Testing purposes only.")]
	public bool hidden;
	private bool oldHidden = true;

	private void Update() {
		if (oldHidden != hidden) {
			SetSprite(hidden ? Back : Face);
			oldHidden = hidden;
		}
	}

	public void SetHidden(bool state) {
		hidden = state;
		oldHidden = !state;
	}

	private void SetSprite(Sprite sprite) {
		this.GetComponent<Image>().sprite = sprite;
	}
}
