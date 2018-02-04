using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoUI : MonoBehaviour {

	private FocusHandler s1;
	private FocusHandler s2;
	private FocusHandler s3;
	
	private int level = 0;

	void Start () {
		s1 = GameObject.Find("Ship1").GetComponent<FocusHandler>();
		s2 = GameObject.Find("Ship2").GetComponent<FocusHandler>();
		s3 = GameObject.Find("Ship3").GetComponent<FocusHandler>();
	}

	void OnGUI() {
		GUIStyle bs = new GUIStyle(GUI.skin.button);
		bs.fontSize = 48;
		if (GUI.Button(new Rect(10, 10, 240, 120), "Up", bs)) {
			level = Mathf.Min(2, level+1);
		}
		if (GUI.Button(new Rect(10, 150, 240, 120), "Down", bs)) {
			level = Mathf.Max(0, level-1);
		}
		s1.SetFocus(level == 0);
		s2.SetFocus(level == 1);
		s3.SetFocus(level == 2);
	}
}
