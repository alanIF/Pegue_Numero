using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		Player.pontuacao = 0;
		Player.NumeroColetados = 0;
		Player.erros = 0;
		Player.fase = 1;
	}
	
	// Update is called once per frame
	void Update () {


	
	}
	public void iniciar(){
		StatusBar.paramStatus = 0;

		SceneManager.LoadScene ("Principal");

	}
}
