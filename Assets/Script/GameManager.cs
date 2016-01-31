using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	static public bool isTouch = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			isTouch = true;
		}
	}
}
