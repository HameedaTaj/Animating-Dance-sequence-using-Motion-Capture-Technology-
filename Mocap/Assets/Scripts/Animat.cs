using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animat : MonoBehaviour {

	public Animator ani1;
	public Animator ani2;
	public Animator ani3;

	public void start()
	{
		ani1.speed=1;
		ani2.speed=1;
		ani3.speed=1;
	}

	public void stop()
	{
		ani1.speed=0;
		ani2.speed=0;
		ani3.speed=0;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
