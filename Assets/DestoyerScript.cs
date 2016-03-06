using UnityEngine;
using System.Collections;

public class DestoyerScript : MonoBehaviour {

    public Transform effectToShow = null;
    public bool isEnemy = true;

    void Start()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if (!isEnemy)
        {
            Destroy(other.gameObject);
        }
        else
        {
            other.GetComponent<Animator>().SetBool("isDead", true);
            var rigid = other.GetComponent<Rigidbody2D>();
            var tran = other.GetComponent<Transform>();
            other.GetComponent<Transform>().position.Set(tran.position.x, transform.position.y + 5, tran.position.z);
            rigid.gravityScale = 0;
            rigid.velocity = new Vector2(0, 1);
            rigid.AddForce(new Vector2(0, 50f));
            Destroy(other.gameObject, .4f);
            //Instantiate(effectToShow, transform.position, Quaternion.identity);
        }
    }
}
