using UnityEngine;
using System.Collections;

public class SaraMojiClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int Winsuu = PlayerPrefs.GetInt("Winsuu");
		UILabel objYouHaveNum = GameObject.Find("YouHaveNum").GetComponent<UILabel>();;
		objYouHaveNum.text =  Winsuu.ToString();
		UILabel objTripleUpToNum = GameObject.Find("TripleUpToNum").GetComponent<UILabel>();;
		objTripleUpToNum.text =  (Winsuu*3).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
