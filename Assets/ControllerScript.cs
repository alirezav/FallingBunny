using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<HoveringScript>().direction *= -1;
        }
	}
}
