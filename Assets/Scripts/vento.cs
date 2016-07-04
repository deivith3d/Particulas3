using UnityEngine;
using System.Collections;

public class vento : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)) {
			GetComponent<Rigidbody>().AddForce(new Vector3(-20,0,0));
			
		}
	}
}
