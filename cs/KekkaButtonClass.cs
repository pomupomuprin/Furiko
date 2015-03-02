using UnityEngine;
using System.Collections;

public class KekkaButtonClass : MonoBehaviour {

	public GameObject objRetryButton;
	public GameObject objExitButton;

	const int PLAY_COIN = 3;
	public IEnumerator clickRetry ()
	{
		int coin = PlayerPrefs.GetInt("coins");
		PlayerPrefs.SetInt("coins",coin - 3);

		UILabel objlCoinsuu = GameObject.Find("lCoinsuu").GetComponent<UILabel>();

		yield return new WaitForSeconds(0.1f);

		for (int i = 0; i < PLAY_COIN; i++) {
			coin--;
			objlCoinsuu.text = (coin).ToString();
			yield return new WaitForSeconds(0.1f);

		}

		Application.LoadLevel("Furiko");
	}

	public void clickCollect()
	{
		int winCoin = PlayerPrefs.GetInt("Winsuu");
		
		int coin = PlayerPrefs.GetInt("coins");
		PlayerPrefs.SetInt("coins",coin + winCoin);

		UILabel objlWinsuu = GameObject.Find("lWinsuu").GetComponent<UILabel>();;
		objlWinsuu.text = "0";

		int rCoin = PlayerPrefs.GetInt("coins");
		UILabel objlCoinsuu = GameObject.Find("lCoinsuu").GetComponent<UILabel>();;
		objlCoinsuu.text = (rCoin).ToString();


		GameObject objTripleUpButton = GameObject.Find("TripleUpButton");
		objTripleUpButton.SetActiveRecursively(false);
		GameObject objCollectButton = GameObject.Find("CollectButton");
		objCollectButton.SetActiveRecursively(false);

		objRetryButton.SetActiveRecursively(true);
		objExitButton.SetActiveRecursively(true);
	}

	public void clickExit ()
	{
		Application.LoadLevel("StartMenu");
	}

	public void clickTriple ()
	{
		Application.LoadLevel("ana3");
	}

}
