using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int life = 5;
	public GameObject diyingParticles;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		checkDeath ();
	}

	void checkDeath()
	{
		if (life == 0) 
		{
			Destroy (gameObject);
			GameObject instance =  Instantiate(diyingParticles,transform.position, diyingParticles.transform.rotation);
			Destroy(instance, 1);
		}
	}
}
