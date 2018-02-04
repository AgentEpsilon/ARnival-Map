using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinAnimator : MonoBehaviour {

	private Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
	}

	public void SetFocus(bool value) {
		anim["PinFade"].speed = value ? -1 : 1;
		anim["PinFade"].time = value ? anim["PinFade"].length : 0;
		anim.Play("PinFade");
	}
}
