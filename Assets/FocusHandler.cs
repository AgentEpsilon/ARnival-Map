using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusHandler : MonoBehaviour {

	public bool focus = false;
	public bool prev = false;
	public Material[] focusedMats = {};
	public Material[] unfocusedMats = {};

	private Renderer r;
	private Animation slide;
	public string clipname;

	public PinAnimator pin;

	void Start() {
		r = GetComponent<Renderer>();
		slide = GetComponent<Animation>();
		SetFocus(focus);
	}

	public void ToggleFocus() {
		SetFocus(!focus);
	}

	public void SetFocus(bool value) {
		if (value != prev) {
			focus = value;
			slide[clipname].speed = focus ? 1 : -1;
			slide[clipname].time = focus ? 0 : slide[clipname].length;
			slide.Play(clipname);
			if (pin != null) pin.SetFocus(focus);
			prev = focus;
		}
		r.materials = focus ? focusedMats : unfocusedMats;
	}
}
