using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void restart(){
		SceneManager.LoadScene ("Menu");

	}
	public void jogarnovamente(){
		Player.numero_sort=10;

		Player.pontuacao = 0;
		Player.NumeroColetados = 0;
		Player.erros = 0;
		Player.tempo = 0;
		Player.fase = 1;
		StatusBar.paramStatus = 0;

		SceneManager.LoadScene ("Principal");

	}
}
