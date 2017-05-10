using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour {
	//Avisar que falta números para coletar
	public UnityEngine.UI.Text texto;
	public  Animator animator;
	public static string contador;
	public UnityEngine.UI.Text textoContador;

	// Use this for initialization
	public GameObject jogador;
	void Start () {
		contador = "";
		textoContador.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Aviso.numeroColetadosfase == Player.numero_sort) {
			animator.SetBool ("open",true);

		
		}
		textoContador.text = contador;
	}
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Player") {
			
			if (Aviso.numeroColetadosfase == Player.numero_sort) {
				
			
				Player.pontuacao += 500;
				// numero sorteado para fase seguinte
				Player.numero_sort = 3;
				//mudando a fase

				Player.fase = 2;
		
			
				SceneManager.LoadScene ("T2");

			}
			if (Aviso.numeroColetadosfase >= Player.numero_sort) {

				Player.numero_sort = 3;
				Player.fase = 2;
				// teste

	


				SceneManager.LoadScene ("T2");

			}
		}

		if( (colisor.gameObject.tag == "Player")&&(Aviso.numeroColetadosfase < Player.numero_sort) ){
			Player.erros += 1;
			Aviso.Tipoaviso= 1;

		}

	}
}
