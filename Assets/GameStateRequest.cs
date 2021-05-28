using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GameStateRequest : MonoBehaviour {

	public Text textField;
	

	private void SetTextResult(string message) {
		textField.text = message;
	}

	public void GetRandomMessage() {
		StartCoroutine(getMessage());
	}

	private IEnumerator getMessage() {
		UnityWebRequest uwr = UnityWebRequest.Get("http://localhost:8092/whist/random");

		//uwr.SetRequestHeader("name", "value");

		yield return uwr.SendWebRequest();

		if (uwr.result == UnityWebRequest.Result.ConnectionError || uwr.result == UnityWebRequest.Result.ProtocolError) {
			Debug.Log(uwr.error);
			yield break;
		}

		Debug.Log(uwr.downloadHandler.text);

		SetTextResult(uwr.downloadHandler.text);
	}
}
