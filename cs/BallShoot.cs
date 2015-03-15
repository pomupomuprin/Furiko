using UnityEngine;
using System.Collections;

public class BallShoot : MonoBehaviour {
	public GameObject BallPrefab;
	private int m_remainBallCount= 9;
	private int m_bingoCount= 0;
	private int m_inBallCount= 0;

	private bool[] m_flgInBalls = new bool[9];

	void  Start (){
		m_inBallCount = 0;
		m_remainBallCount = 9;
		m_bingoCount = 0;
		for(int i=1;i<10;i++)
		{
			GameObject objBingoBoard = GameObject.Find("kekka" + i);
			objBingoBoard.renderer.material.color = new  Color(0, 0, 1, 1);
			GameObject objInHole= GameObject.Find("In" + i);
			objInHole.renderer.material.color = new Color(0, 0, 1, 1);
		}

		for(int k=0;k<9;k++)
		{
			m_flgInBalls[k] = false;
		}
		for(int j=0;j<8;j++)
		{
			int j1= j + 1;
			GameObject objBingoLine = GameObject.Find("Tousen" + j1);
			// sitanosyorihairisou 
			objBingoLine.renderer.material.color = new Color(1, 1, 1, 1);
			
		}
	}
	void  OnGUI (){
		GUIStyle myStyle = new GUIStyle();
		//myStyle.normal.textColor = Color.black;
		myStyle.fontSize = 50;
		if(GUI.Button(new Rect(0,0,Screen.width, Screen.height * 2 / 3),"",myStyle)) 
		{
			if (m_remainBallCount > 0)
			{
				GameObject newBall= Instantiate(BallPrefab) as GameObject;
				newBall.transform.position =new Vector3(0,15,8.5f);
				m_remainBallCount --;	    
				
				GameObject ZanBall= GameObject.Find("ZanBall" + (9-m_remainBallCount));
				Destroy(ZanBall);	
			}
		}
	}


	public IEnumerator BallInHole ( string inBox  ){
		m_inBallCount++;

		//Debug.Log("flgIn" + (int.Parse(inBox)-1));
		m_flgInBalls[int.Parse(inBox)-1] = true;
		
		int[,] bingLines= new int[,]{
			{1,2,3},
		    {4,5,6},
		    {7,8,9},
		    {1,4,7},
		    {2,5,8},
		    {3,6,9},
		    {1,5,9},
		    {3,5,7}
		};
		//Debug.Log("flg:" + flgIn[int.Parse(inBox)-1]);

		m_bingoCount = 0;
		for(int i=0;i<8;i++)
		{
			if (m_flgInBalls[bingLines[i,0]-1] && m_flgInBalls[bingLines[i,1]-1] && m_flgInBalls[bingLines[i,2]-1])
			{
				//Debug.Log("Tousen" + i);
				int i1= i+1;
				GameObject objBingLine = GameObject.Find("Tousen" + i1);
				objBingLine.renderer.material.color =new Color(0, 0, 1, 1);
				m_bingoCount++;
				
			}
		}
		if (m_inBallCount >= 9)
		{
			PlayerPrefs.SetString("gBingoSuu", this.m_bingoCount.ToString());
			yield return new WaitForSeconds(3);
			
			Application.LoadLevel("Result");
		}
		
	}
	
}