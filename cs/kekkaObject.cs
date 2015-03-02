using UnityEngine;
using System.Collections;

public class kekkaObject : MonoBehaviour {

	static int[] sWinCoin = {0,0,1,2,3,5,10,20,100};
	public int BingoSu = 8;
	// Use this for initialization
	void Start () {

		int coin = PlayerPrefs.GetInt("coins");
		UILabel objlCoinsuu = GameObject.Find("lCoinsuu").GetComponent<UILabel>();;
		objlCoinsuu.text = (coin).ToString();

		int saraKekka = PlayerPrefs.GetInt("saraKekka");
		//bingo end
		if (saraKekka == 0)
		{
			EndBingo();
		}
		//sara win
		else if (saraKekka == 1)
		{
			int Winsuu = PlayerPrefs.GetInt("Winsuu");
			PlayerPrefs.SetInt("Winsuu", Winsuu * 3);
			UILabel objlWinsuu = GameObject.Find("lWinsuu").GetComponent<UILabel>();;
			objlWinsuu.text = (PlayerPrefs.GetInt("Winsuu")).ToString();

			HideRetryExitButoon();
			DestoryStars();
		}
		//sara lose
		else if (saraKekka == 2)
		{
			PlayerPrefs.SetInt("Winsuu", 0);
			
			UILabel objlWinsuu = GameObject.Find("lWinsuu").GetComponent<UILabel>();;
			objlWinsuu.text = (PlayerPrefs.GetInt("Winsuu")).ToString();

			HideTripleUpCollectButton();
			DestoryStars();
		}

		PlayerPrefs.SetInt("saraKekka", 0);
	}

	private void DestoryStars()
	{

		for (int i = 1; i < 9; i++) {

			GameObject obj = GameObject.Find("b" + i);
			Destroy(obj);
			GameObject obja = GameObject.Find("s" + i);
			Destroy(obja);
		}
	}

	private void HideTripleUpCollectButton()
	{
		GameObject objTripleUpButton = GameObject.Find("TripleUpButton");
		objTripleUpButton.SetActiveRecursively(false);
		GameObject objCollectButton = GameObject.Find("CollectButton");
		objCollectButton.SetActiveRecursively(false);
	}

	private void HideRetryExitButoon()
	{
		GameObject objRetryButton = GameObject.Find("RetryButton");
		objRetryButton.SetActiveRecursively(false);
		GameObject objExitButton = GameObject.Find("ExitButton");
		objExitButton.SetActiveRecursively(false);
	}

	private void EndBingo()
	{
		string strBingoSu = PlayerPrefs.GetString("gBingoSuu");
		BingoSu = int.Parse(strBingoSu); 
		//UILabel objstr = GameObject.Find("lBingosuu").GetComponent<UILabel>();;
		//objstr.text= BingoSu.ToString();
		
		for (int i = 1; i < 9; i++) {
			//Debug.Log(i.ToString() + ":" + BingoSu.ToString());
			if (i <= BingoSu)
			{
				GameObject obj = GameObject.Find("b" + i);
				Destroy(obj);
			}
			else
			{
				GameObject obj = GameObject.Find("s" + i);
				Destroy(obj);
			}
		}
		int winCoin = sWinCoin[BingoSu];
		PlayerPrefs.SetInt("Winsuu", winCoin);

		UILabel objlWinsuu = GameObject.Find("lWinsuu").GetComponent<UILabel>();;
		objlWinsuu.text = (PlayerPrefs.GetInt("Winsuu")).ToString();

		if (winCoin > 0)
		{
			HideRetryExitButoon();
		}
		else
		{
			HideTripleUpCollectButton();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
