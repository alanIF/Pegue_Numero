using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartFase3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void fase3(){
		StatusBar.paramStatus = 0;
		SceneManager.LoadScene ("Level3");

	}
}
