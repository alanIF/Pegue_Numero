using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;

public class Restart : MonoBehaviour {
	public UnityEngine.UI.Text txtpontos;
	public UnityEngine.UI.Text txtRecorde;
	public UnityEngine.UI.Text txtNumeros;
	string linha;
	public string conexao;



	// Use this for initialization
	void Start () {
		txtpontos.text = PlayerPrefs.GetInt ("Pontuacao").ToString ();
		txtRecorde.text = PlayerPrefs.GetInt ("recorde").ToString ();
		txtNumeros.text=PlayerPrefs.GetInt ("Coletados").ToString ();

	
	}

	void Update () {
		
	}

}
