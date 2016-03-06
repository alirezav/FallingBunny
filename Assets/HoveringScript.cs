using UnityEngine;
using System.Collections;

public class HoveringScript : MonoBehaviour {

    public float speed = 1;
    public int direction = 1;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * direction * speed;

        //var size = GetComponentInChildren<Renderer>().bounds.size.x / 2;
        var vertExtent = Camera.main.orthographicSize;
        var horzExtent = vertExtent * Screen.width / Screen.height;
        var size = horzExtent;

        var dist = (transform.position - Camera.main.transform.position).z;

        var leftBorder = Camera.main.ViewportToWorldPoint(
          new Vector3(0, 0, dist)
        ).x - size;

        var rightBorder = Camera.main.ViewportToWorldPoint(
          new Vector3(1, 0, dist)
        ).x + size;

        if (transform.position.x < leftBorder)
        {
            direction = -1;
        }

        if (transform.position.x > rightBorder)
        {
            direction = 1;
        }

    }
}
