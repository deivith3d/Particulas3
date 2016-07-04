using UnityEngine;
using System.Collections;

public class destroiParticula : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Destroy(gameObject,GetComponent<ParticleSystem>().duration+GetComponent<ParticleSystem>().startLifetime);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
