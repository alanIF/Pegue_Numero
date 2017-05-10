using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;
public class Letra : MonoBehaviour {

	public int ponto = 2;
	/* Tempo da letra*/
	public float tempoMaximoVida;
	private Vidas vida;
	// Use this for initialization
	public float tempoVida;
	public GameObject player;
	public string letra;


	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player")as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		tempoVida += Time.deltaTime;
		if (tempoVida >= tempoMaximoVida) {
			Destroy (gameObject);
			tempoVida = 0;
		}
	}
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Player") {
			Player.erros += 1;

			string linha="";
			StreamReader rd = new StreamReader(Application.persistentDataPath+ "/Dados/"+Player.arquivo);
			//leitura arquivos
			while(!rd.EndOfStream){
				linha += rd.ReadLine()+"\n";
			}

			rd.Close();
			linha += "" + Player.tempo + "," + letra + ",false";
			linha = linha.Replace ("\n", System.Environment.NewLine);
			StreamWriter wr = new StreamWriter(Application.persistentDataPath  + "/Dados/"+Player.arquivo, false);

			wr.WriteLine (linha);
		
			wr.Close();
			vida = GameObject.FindGameObjectWithTag ("Vidas").GetComponent<Vidas>() as Vidas;
			if (vida.excluirVida ()) {
				Player.pontuacao -= 10;

				Destroy (gameObject);
			} else {


				SceneManager.LoadScene ("GameOver");
				//gameover
			}
		

		}
	}
}
