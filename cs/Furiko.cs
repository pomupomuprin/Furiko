using UnityEngine;
using System.Collections;

public class Furiko : MonoBehaviour {

	private bool m_flgDirection= true;
	
	void  Update (){
		if (-0.4f < transform.rotation.z && transform.rotation.z < 0.4f)
		{
		}
		//
		else if (0.4f >= transform.rotation.z)
		{
			m_flgDirection = false;
		}
		else if (transform.rotation.z >= -0.4f)
		{
			m_flgDirection = true;
		}
		
		if (m_flgDirection)
		{
			transform.Rotate(0,0,-1);
		}
		else
		{
			transform.Rotate(0,0,1);
		}
	}

}
