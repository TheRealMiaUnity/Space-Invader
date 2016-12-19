using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {
    public GameObject shot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 10, Input.GetAxis("Vertical") * 10);

        if (Input.GetButtonDown ("Fire1"))
        {
            Instantiate(shot, transform.position, Quaternion.identity);
        }
	
	}
}
