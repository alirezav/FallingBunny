using UnityEngine;
using System.Collections;

public class PrefabSpawnerScript : MonoBehaviour {

    private float nextSpawn = 0;
    public Transform prefabToSapwn;
    public float spawnRate = 2;
    public float randomLocation = 4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Time.time > nextSpawn)
        {
            Instantiate(prefabToSapwn, transform.position + new Vector3(Random.Range(-4, randomLocation), 0, 0), Quaternion.identity);
            nextSpawn = Time.time + spawnRate;
        }
	}
}
