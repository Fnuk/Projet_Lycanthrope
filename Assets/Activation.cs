using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activation : MonoBehaviour {

    public Text debug;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.isActiveAndEnabled)
            debug.text = "Wolf : I am here";
        else
            debug.text = "Wolf : Nope";

    }
}
