using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour {
	public float velocidade=5f;
	public float maxDelay;
	private bool isEsquerda=true;
	private float timeMovimentacao=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movimentar ();
	}
	void movimentar(){
		timeMovimentacao += Time.deltaTime;
		if (timeMovimentacao <= maxDelay) {


			if (isEsquerda) {
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 0);
			} else {
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 180);

			}
		} else {
			isEsquerda = !isEsquerda;
			timeMovimentacao = 0;
		}
	}
}
