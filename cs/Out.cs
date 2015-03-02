// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class Out : MonoBehaviour {
//int score;

void  OnCollisionEnter ( Collision collision  ){
	//Common.AddScore(); 	
   	//score ++;
   	
    Destroy(collision.gameObject);
}

void  OnGUI (){
//	GUI.Label ( new Rect(10, 160, 200, 140), "Score: " + Common.score.ToString() );
}

void  Update (){
//    FIXME_VAR_TYPE level= Mathf.Abs(Mathf.Sin(Time.time * 6.0f));
//    renderer.material.color = Color(1, level, level, 1);
}
}