using UnityEngine;
using System.Collections;

public class MoveNaname : MonoBehaviour {

	bool muki = true;		
	void  Update (){
		
		if (muki) 
		{
			transform.position = new Vector3(transform.position.x + 0.05F, transform.position.y,transform.position.z);
			transform.eulerAngles = new Vector3(0, 0, -45);
			//transform.eulerAngles.z = 45.0f;
			//transform.Translate(0.05f, 0, 0);
			//transform.Rotate(45, 90, 180);
			//transform.position.x += 0.05f;
			//transform.rotation.z = -0.45f;
		}
		else
		{
			transform.position = new Vector3(transform.position.x - 0.05F, transform.position.y,transform.position.z);
			//transform.eulerAngles.z = -45.0f;
			transform.eulerAngles = new Vector3(0, 0, 45);

		}
		
		if (transform.position.x > 7.75f)
		{
			muki = false;
		}
		if (transform.position.x < -7.75f)
		{
			muki = true;
		}
	}

}
