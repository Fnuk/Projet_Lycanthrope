using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DistanceScript : MonoBehaviour {

    #region PUBLIC_MEMBER_VARIABLES
    public GameObject markerBoris, markerLycanName, markerMoon, markerBlackBoard;
    public GameObject model3D;
    public Text distanceBoris, distanceMoon, distanceName, distanceBlackBoard;
    #endregion

    #region PRIVATE_MEMBER_VARIABLES
    private DefaultTrackableEventHandler borisScript, lycanScript, moonScript, blackBoardScript;
    private Vector3 modelInitialPos;
    #endregion

    #region UNITY_MONOBEHAVIOUR_FUNCTIONS
    // Use this for initialization
    void Start () {
        borisScript = markerBoris.GetComponent<DefaultTrackableEventHandler>();
        lycanScript = markerLycanName.GetComponent<DefaultTrackableEventHandler>();
        moonScript = markerMoon.GetComponent<DefaultTrackableEventHandler>();
        blackBoardScript = markerBlackBoard.GetComponent<DefaultTrackableEventHandler>();
        
    }
    
    // Update is called once per frame
    void Update () {
        float distance = 0.0f;

        if (borisScript.IsTracked)
        {
            distance = Vector3.Distance(this.transform.position, markerBoris.transform.position);
            Debug.Log("Distance Boris: " + distance);
            distanceBoris.text = "Distance Boris: " + distance;
            //model3D.transform.position = new Vector3(markerBoris.transform.position.x + 2.5f, markerBoris.transform.position.z + 3.5f, markerBoris.transform.position.y);

        }
        if (lycanScript.IsTracked)
        {
            distance = Vector3.Distance(this.transform.position, markerLycanName.transform.position);
            Debug.Log("Distance Lycan: " + distance);
            distanceMoon.text = "Distance Lycan: " + distance;
            //model3D.transform.position = new Vector3(markerLycanName.transform.position.x, markerLycanName.transform.position.z + 3.5f, markerLycanName.transform.position.y);
            modelInitialPos = new Vector3(markerLycanName.transform.position.x, markerLycanName.transform.position.z, -markerLycanName.transform.position.y);
        }
        if (moonScript.IsTracked)
        {
            distance = Vector3.Distance(this.transform.position, markerMoon.transform.position);
            Debug.Log("Distance Moon: " + distance);
            distanceName.text = "Distance Moon: " + distance;
            //model3D.transform.position = new Vector3(markerMoon.transform.position.x, markerMoon.transform.position.z + 3.5f, markerMoon.transform.position.y + 2.0f);
        }
        if (blackBoardScript.IsTracked)
        {
            distance = Vector3.Distance(this.transform.position, markerBlackBoard.transform.position);
            Debug.Log("Distance blackBoard: " + distance);
            distanceBlackBoard.text = "Distance blackBoard: " + distance;
            //model3D.transform.position = new Vector3(markerBoris.transform.position.x, markerBoris.transform.position.z + 3.5f, markerBoris.transform.position.y);
        }

        model3D.transform.position = modelInitialPos;

        if (borisScript.IsTracked || lycanScript.IsTracked || moonScript.IsTracked || blackBoardScript.IsTracked)
            model3D.SetActive(true);
        else
            model3D.SetActive(false);
    }
    #endregion
}
