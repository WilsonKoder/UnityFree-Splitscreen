using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(gameObject.tag == "player01")
		{
			if(Input.GetKey (KeyCode.A))
			{
				rigidbody.velocity = new Vector3(-5, rigidbody.velocity.y, 0);
			}
			if(Input.GetKey (KeyCode.D))
			{
				rigidbody.velocity = new Vector3(5, rigidbody.velocity.y, 0);
			}
			if(Input.GetKeyDown (KeyCode.W))
			{
				rigidbody.velocity = new Vector3(rigidbody.velocity.x, 5, 0);
			}
		}
		else if(gameObject.tag == "player02")
		{
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				rigidbody.velocity = new Vector3(-5, rigidbody.velocity.y, 0);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				rigidbody.velocity = new Vector3(5, rigidbody.velocity.y, 0);
			}
			if(Input.GetKey(KeyCode.UpArrow))
			{
				rigidbody.velocity = new Vector3(rigidbody.velocity.x, 5, 0);
			}
		}
	}
}
