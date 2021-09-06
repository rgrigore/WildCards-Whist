using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour {

	private GameObject canvas;

	private bool dragged;
	private GameObject startParent;

	private bool droppable;
	private GameObject dropParent;

	private void Awake() {
		canvas = GameObject.FindGameObjectWithTag("Canvas");
	}

	void Update() {
		if (dragged) {
			transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		}
	}

	public void DragStart() {
		startParent = transform.parent.gameObject;
		transform.SetParent(canvas.transform, true);
		dragged = true;
	}

	public void DragEnd() {
		dragged = false;

		if (droppable) {
			transform.SetParent(dropParent.transform, false);
		} else {
			transform.SetParent(startParent.transform, false);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		droppable = true;
		dropParent = collision.gameObject;
	}

	private void OnCollisionExit2D(Collision2D collision) {
		droppable = false;
		dropParent = null;
	}
}
