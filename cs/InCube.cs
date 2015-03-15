using UnityEngine;
using System.Collections;

public class InCube : MonoBehaviour {

	public string HoleNo= "0";
	private GameObject _BallShoot; 
	void  Start (){
		_BallShoot = GameObject.Find("BallShoot");
	}

	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(UnityEngine.Collision collision)
	{
		renderer.material.color = new Color(1, 0, 0, 1);
		Destroy(collision.gameObject);
		this.InBall(HoleNo);

		_BallShoot.SendMessage("InBall", HoleNo);
	}
	
	void InBall (string holeNo){
		GameObject objBingoBoard= GameObject.Find("kekka" + holeNo);
		objBingoBoard.renderer.material.color = new Color(1, 0, 0, 1);
	}
}
