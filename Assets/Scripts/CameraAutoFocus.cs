using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraAutoFocus : MonoBehaviour {

    #region PRIVATE_MEMBER_VARIABLES
    bool focusModeSet;
    #endregion

    // Use this for initialization
    void Start () {
        focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!focusModeSet)
        {
            Debug.Log("Failed to set focus mode to continuousauto (unsupported mode).");
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && !focusModeSet )
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
	}
}
