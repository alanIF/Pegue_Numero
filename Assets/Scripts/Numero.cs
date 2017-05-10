using UnityEngine;
using System.Collections;
using System.IO;

public class Numero : MonoBehaviour {
	
	public static int pontos;
	private float timevida;
	public float tempoMaximoVida;
	public UnityEngine.UI.Text txtpontos;
	public int numero;

	// para cada fase
	// Use this for initialization
	public GameObject player;

	//variavel para identificar se ele errou
	public static bool erro;
	public int contadorfase1;


	void Start () {
		erro = true;
		timevida = 0;
		player = GameObject.FindGameObjectWithTag ("Player")as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		timevida += Time.deltaTime;
		if (timevida >= tempoMaximoVida) {
			Destroy (gameObject);
			timevida = 0;
		}

	}
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Player") {
			
			string linha="";
			Level2.contador = "";
			if (Player.fase == 1) {
				for (contadorfase1 = 0; contadorfase1 < 10; contadorfase1++) {
					if (Aviso.numeroColetadosfase >= contadorfase1) {
						Level2.contador = Level2.contador+"o" ;
					} else {
						Level2.contador =   Level2.contador+"x";

					}
				}
			
			}
			StreamReader rd = new StreamReader(Application.persistentDataPath + "/Dados/"+Player.arquivo);
			//leitura arquivos
			while(!rd.EndOfStream){
				linha += rd.ReadLine()+"\n";
			}

			rd.Close();
			if (Player.fase== 2) {
				ordenacao.numeroAtual = numero;
				ordenacao.comparar ();
			
			}

			if (Player.fase== 3) {
				ordenacao.numeroAtual = numero;
				ordenacao.compararDescrescente ();
			}
			StreamWriter wr = new StreamWriter(Application.persistentDataPath + "/Dados/"+Player.arquivo, false);
			linha += "" + Player.tempo + "," + numero + "," + erro;
			linha = linha.Replace ("\n", System.Environment.NewLine);

			wr.WriteLine (linha);

			wr.Close();
		

			Player.pontuacao += numero*10;
			Player.NumeroColetados += 1;
			Aviso.numeroColetadosfase += 1;
			Destroy (gameObject);
		}
	}

}
