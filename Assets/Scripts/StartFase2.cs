using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartFase2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void fase2(){
		StatusBar.paramStatus = 0;
		SceneManager.LoadScene ("Level2");

	}
}
