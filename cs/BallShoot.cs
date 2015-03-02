// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class BallShoot : MonoBehaviour {
	public GameObject ballPrefab;
	private int ballCount= 9;
	private int BingoSuu= 0;

	private bool[] flgIn = new bool[9];

	void  Start (){
		inBallCount = 0;
		ballCount = 9;
		BingoSuu = 0;
		for(int i=1;i<10;i++)
		{
			GameObject obj= GameObject.Find("kekka" + i);
			obj.renderer.material.color = new  Color(0, 0, 1, 1);
			GameObject obj2= GameObject.Find("In" + i);
			obj2 .renderer.material.color = new Color(0, 0, 1, 1);
		}
		//AudioReverbFilteFIXME_VAR_TYPE obj3= GameObject.Find("Ball");
		//obj3.renderer.material.color = Color(0, 0, 1, 1);
		for(int k=0;k<9;k++)
		{
			flgIn[k] = false;
		}
		for(int j=0;j<8;j++)
		{
			int j1= j + 1;
			GameObject obj4= GameObject.Find("Tousen" + j1);
			// sitanosyorihairisou 
			obj4.renderer.material.color = new Color(1, 1, 1, 1);
			
		}
	}
	void  OnGUI (){
		GUIStyle myStyle = new GUIStyle();
		//myStyle.normal.textColor = Color.black;
		myStyle.fontSize = 50;
		if(GUI.Button(new Rect(0,0,Screen.width, Screen.height * 2 / 3),"",myStyle)) 
		{
			if (ballCount > 0)
			{
				GameObject newBall= Instantiate(ballPrefab) as GameObject;
				newBall.transform.position =new Vector3(0,15,8.5f);
				ballCount --;	    
				
				GameObject ZanBall= GameObject.Find("ZanBall" + (9-ballCount));
				Destroy(ZanBall);	
			}
		}
		
		/*
    if(GUI.Button(new Rect(20,220,120,180), "reset")) 
	{
		ballCount = 9;
		BingoSuu = 0;
		for(FIXME_VAR_TYPE i=1;i<10;i++)
		{
			FIXME_VAR_TYPE obj= GameObject.Find("kekka" + i);
			obj.renderer.material.color = Color(0, 0, 1, 1);
			FIXME_VAR_TYPE obj2= GameObject.Find("In" + i);
			obj2 .renderer.material.color = Color(0, 0, 1, 1);
		}
		//AudioReverbFilteFIXME_VAR_TYPE obj3= GameObject.Find("Ball");
		//obj3.renderer.material.color = Color(0, 0, 1, 1);
		
		for(FIXME_VAR_TYPE j=0;j<8;j++)
		{
			flgIn[j] = false;
			FIXME_VAR_TYPE j1= j + 1;
			FIXME_VAR_TYPE obj4= GameObject.Find("Tousen" + j1);
			// sitanosyorihairisou 
			obj4.renderer.material.color = Color(1, 1, 1, 1);
		
		}
    }
    */
	}

	private int inBallCount= 0;

	public IEnumerator InBall ( string inBox  ){
		inBallCount++;

		Debug.Log("flgIn" + (int.Parse(inBox)-1));
		flgIn[int.Parse(inBox)-1] = true;
		
		int[,] tousen= new int[,]{
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

		BingoSuu = 0;
		for(int i=0;i<8;i++)
		{
			if (flgIn[tousen[i,0]-1] && flgIn[tousen[i,1]-1] && flgIn[tousen[i,2]-1])
			{
				//Debug.Log("Tousen" + i);
				int i1= i+1;
				GameObject obj= GameObject.Find("Tousen" + i1);
				obj.renderer.material.color =new Color(0, 0, 1, 1);
				BingoSuu++;
				
			}
		}
		if (inBallCount >= 9)
		{
			PlayerPrefs.SetString("gBingoSuu", this.BingoSuu.ToString());
			yield return new WaitForSeconds(3);
			
			Application.LoadLevel("Result");
		}
		
	}
	
}