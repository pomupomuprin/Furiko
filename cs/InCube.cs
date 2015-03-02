using UnityEngine;
using System.Collections;

public class InCube : MonoBehaviour {

	public string flg= "0";
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
		this.InBall(flg);

		_BallShoot.SendMessage("InBall", flg);
		//BallShoot.InBall(flg);
		

	}
	
	void InBall ( string flg  ){
		GameObject obj= GameObject.Find("kekka" + flg);
		obj.renderer.material.color = new Color(1, 0, 0, 1);
	}
}
