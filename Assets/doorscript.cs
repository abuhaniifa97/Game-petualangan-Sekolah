using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim =GetComponent<Animator>();

		
	}
	void OnTriggerEnter(Collider other)
{
anim.SetTrigger("opendoor");
}
void OnTriggerExit(Collider other)
{

}
	
	// Update is called once per frame
	void Update () {
		
	}
}
