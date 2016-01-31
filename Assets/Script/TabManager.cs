using UnityEngine;
using System.Collections;

public class TabManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (this.tag.Equals ("RankTab")) {
			Application.LoadLevel (1);
		} else if (this.tag.Equals ("ProfileTab")) {
			Application.LoadLevel (0);
		}else if(this.tag.Equals("SorfTab")){
			Application.LoadLevel (2);
		}
	}
}
