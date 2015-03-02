using UnityEngine;
using System.Collections;


public class Ana3In : MonoBehaviour {

	public int InOrOut ;
	bool flgCollition = false;
	int time = 0;
	
	void Update(){

		if (flgCollition)
		{
			time++;
			if (time > 120)
			{
				Application.LoadLevel("Result");
				flgCollition = false;
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
		flgCollition = true;
	}	

}
