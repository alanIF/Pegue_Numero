using UnityEngine;
using System.Collections;

public class ordenacao : MonoBehaviour {
	//fazendo ordenacao
	public static int numeroAnterior;
	public static int numeroAtual;

	// Use this for initialization
	void Start () {
		if (Player.fase == 2) {
			numeroAnterior = 0;
		}
		if (Player.fase == 3) {
			numeroAnterior = 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void comparar(){
		if (numeroAtual > numeroAnterior) {

			level3.acerto += 1;
			level3.sequenciaTexto = "" + numeroAnterior + "-" + numeroAtual;
			numeroAnterior = numeroAtual;


		}
		else {

			Player.erros += 1;

			Numero.erro = false;
			// errou e terá que  voltar a sequencia
			// caso ele tenha completado a sequencia, ai nao contara como erro
			if (level3.faseSeguinte == 1) {
				Numero.erro = true;
				Player.erros -= 1;

			}

			numeroAnterior = 0;
			level3.acerto = 0;

		}
	

	}
	public static void compararDescrescente(){
		if (numeroAtual >= numeroAnterior) {
			Player.erros += 1;
			numeroAnterior = 10;

			Numero.erro = false;
			if (EndGame.fim == 1) {
				Numero.erro = true;
				Player.erros -= 1;

			}
			EndGame.acerto = 0;
		}
		else{
			EndGame.sequenciaTexto = "" + numeroAnterior + "-" + numeroAtual;

			numeroAnterior = numeroAtual;
			EndGame.acerto += 1;
		}
	}
}
