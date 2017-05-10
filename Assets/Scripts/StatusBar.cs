using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StatusBar : MonoBehaviour {

	/* 
     * Parâmetros estáticos, definidos na intenção
     * de utilizarmos os dados contidos neles, até
     * o fim da execução da aplicação (jogo)
     */

	public static int paramStatus;



	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Principal");
		}
	
	}
}