using UnityEngine;
using System.Collections;

public class saraBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float x = Random.Range(1.0f, 5.0f);
		Debug.Log("Force:" + x.ToString());
		float z = 0.0f;
		//Vector3 dir = Vector3.right;
		Vector3 v3 = new Vector3(x, 0, z);
		rigidbody.AddForce(v3, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
