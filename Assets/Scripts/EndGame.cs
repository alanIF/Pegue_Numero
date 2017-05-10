using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public UnityEngine.UI.Text sequencia;

	public  Animator animator;
	//igual a 3 fim de jogo
	public static int  acerto;
	public static string sequenciaTexto;
	public static int fim;
	// Use this for initialization
	void Start () {
		texto.text="Pegue "+Player.numero_sort+" números na ordem descrescente";
		acerto = 0;
		fim = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (fim == 1) {
			sequencia.text = "Pode entrar na porta";
		} else if (acerto == 3) {
			animator.SetBool ("open", true);
			sequencia.text = "Pode entrar na porta";

			fim = 1;
		} else if (acerto == 1) {
			sequencia.text = "" + ordenacao.numeroAnterior;

		} else if (acerto == 2) {
			sequencia.text = "" + sequenciaTexto;

		} else if (acerto == 0) {
			sequencia.text = "";
		} else {
			acerto = 0;
		
		}
	}
	void OnCollisionEnter2D(Collision2D colisor){

		if (colisor.gameObject.tag == "Player") {
			if (fim==1) {


				Player.pontuacao += 500;
				SceneManager.LoadScene ("GameOver");

			}
		
		}

		if( (colisor.gameObject.tag == "Player")&&(fim==0) ){
			Player.erros += 1;
			Aviso.Tipoaviso = 1;
		}

	}
}
