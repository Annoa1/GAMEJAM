using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {
	
	public GameObject playerSprite;

	public GameObject projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Fire")) 
		{
			GameObject obj = Instantiate (projectile);

			obj.transform.position = transform.position;
		}
	}

	public void Move(Vector2 movementVec)
	{
		//playerSprite.transform.position += new Vector3(movementVec.x, movementVec.y, 0);
		GetComponent<Rigidbody2D> ().AddForce (movementVec);
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		
	}

}
