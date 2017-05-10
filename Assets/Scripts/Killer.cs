using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Killer : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void  OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Player") {
			

			SceneManager.LoadScene ("GameOver");
			//gameover
		}
	}
}
