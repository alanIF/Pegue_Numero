using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class level3 : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public UnityEngine.UI.Text sequencia;
	public  Animator animator;
	//igual a 3 passa de fase
	public static int  acerto;
	public static string sequenciaTexto;
	public static int faseSeguinte;
	// Use this for initialization
	void Start () {
		texto.text="Pegue "+Player.numero_sort+" numeros na ordem crescente";
		acerto = 0;
		faseSeguinte = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (faseSeguinte == 1) {
			sequencia.text="Pode entrar na porta";

		}
		else if (acerto == 3) {
			animator.SetBool ("open",true);
			sequencia.text="Pode entrar na porta";
			faseSeguinte = 1;
		}
		else if (acerto == 1) {
			sequencia.text = "" + ordenacao.numeroAtual;
		
		}
		else if (acerto == 2) {
			sequencia.text = "" +sequenciaTexto;

		}
		else {
			sequencia.text = "";
		}
	}
	void OnCollisionEnter2D(Collision2D colisor){

		if (colisor.gameObject.tag == "Player") {
			
			if (faseSeguinte==1) {


				Player.pontuacao += 500;
				Player.numero_sort = 3;
				Player.fase = 3;
				StatusBar.paramStatus = 0;

				SceneManager.LoadScene ("T3");

			}
		
		}

		if( (colisor.gameObject.tag == "Player")&&(faseSeguinte== 0) ){
			Player.erros += 1;
			Aviso.Tipoaviso = 1;
		}

	}
}
