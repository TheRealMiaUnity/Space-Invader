using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
    public int speed = 5;
    public int damage;
    public string target;
    public GameObject explosion;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }
	
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == target)
        {
            if (other.tag == "Player")
            {
                GameManager.playerDead();
            }
            else
            {
                Score.updateScore();
            }

            Destroy(other.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, 
                other.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 1.0f);
            Score.updateScore();
            Destroy(gameObject);
        }
	
	}
}
