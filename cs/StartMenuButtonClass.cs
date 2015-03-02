using UnityEngine;
using System.Collections;

public class StartMenuButtonClass : MonoBehaviour {
	const int PLAY_COIN = 9;

	void Start () {
		int started = PlayerPrefs.GetInt("started");
		Debug.Log(started.ToString());
		if (started == 0)
		{
			PlayerPrefs.SetInt("started",1);
			PlayerPrefs.SetInt("coins",50);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickStart ()
	{
		int coin = PlayerPrefs.GetInt("coins");
		PlayerPrefs.SetInt("coins",coin - PLAY_COIN);
		Application.LoadLevel("Furiko");
	}
	
	public void clickHelp ()
	{
		Application.LoadLevel("Help");
	}
}
