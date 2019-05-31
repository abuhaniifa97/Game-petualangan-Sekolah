using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour {
	public Transform player;

	// Use this for initialization
	void LateUpdate()
	{
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
