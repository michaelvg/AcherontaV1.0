using UnityEngine;
using System.Collections;

public class Transparency : MonoBehaviour {
		// Use this for initialization
	void Start () {
		gameObject.renderer.material.ChangeAlpha( 0.25f );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

