using UnityEngine;
using System.Collections;

public class reacao : MonoBehaviour {
	public GameObject PS;
	public long vibra;

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("esfera"))
		{
			Instantiate(PS, other.transform.localPosition+new Vector3(0,-0.5f,0), Quaternion.identity);
			other.GetComponent<Rigidbody>().AddForce(new Vector3(0,150,0));
			Vibration.Vibrate(vibra);
		}
	}


}
