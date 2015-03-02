using UnityEngine;
using System.Collections;

public class Furiko : MonoBehaviour {

	// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
	// Do test the code! You usually need to change a few small bits.
	
	bool muki= true;
	
	void  Update (){
		//Debug.Log(transform.rotation.z);
		
		if (-0.4f < transform.rotation.z && transform.rotation.z < 0.4f)
		{
		}
		//
		else if (0.4f >= transform.rotation.z)
		{
			muki = false;
			//yield return new WaitForSeconds(1);
		}
		else if (transform.rotation.z >= -0.4f)
		{
			muki = true;
			//yield return new WaitForSeconds(1);
		}
		
		if (muki)
		{
			transform.Rotate(0,0,-1);
		}
		else
		{
			transform.Rotate(0,0,1);
		}
	}

}
