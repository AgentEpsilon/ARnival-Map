using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

	private FocusHandler s1;
	private FocusHandler s2;
	private FocusHandler s3;

	private Slider slider;

	void Start () {
		s1 = GameObject.Find("Ship1").GetComponent<FocusHandler>();
		s2 = GameObject.Find("Ship2").GetComponent<FocusHandler>();
		s3 = GameObject.Find("Ship3").GetComponent<FocusHandler>();
		slider = GameObject.Find("LevelSlider").GetComponent<Slider>();
	}
	
	public void HandleChange() {
		s1.SetFocus(slider.value == 0);
		s2.SetFocus(slider.value == 1);
		s3.SetFocus(slider.value == 2);
	}
}
