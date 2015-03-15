using UnityEngine;
using System.Collections;

/// <summary>
/// Ana3 in.
/// </summary>
public class Ana3In : MonoBehaviour {

	public int InOrOut ;
	private bool m_flgCollition = false;
	private int time = 0;
	
	void Update(){

		if (m_flgCollition)
		{
			time++;
			if (time > 120)
			{
				Application.LoadLevel("Result");
				m_flgCollition = false;
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(collision.gameObject);
		if (InOrOut == 0)
		{
			//lose
			PlayerPrefs.SetInt("saraKekka", 2);
		}
		else
		{
			//win
			PlayerPrefs.SetInt("saraKekka", 1);
		}
		m_flgCollition = true;
	}	

}
