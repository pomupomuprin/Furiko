using UnityEngine;
using System.Collections;

public class lBingoClass : MonoBehaviour {

	public UILabel lBingo;

	private int mCount = 0;
	private bool mFlgDirection = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (mFlgDirection)
		{
			mCount++;
		}
		else
		{
			mCount--;
		}

		lBingo.transform.localPosition = new Vector3(130 + (mCount * 0.5f),-1,0);

		if (mCount > 50)
		{
			mFlgDirection = false;
		}
		else if (mCount < -50)
		{
			mFlgDirection = true;
		}
	}
}
