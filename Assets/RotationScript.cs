using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

    public float rotation_speed = 5;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, rotation_speed);
	}
}
