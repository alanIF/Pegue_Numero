using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {

	public GameObject[] objetos;
	private bool isEsquerda=true;
	public float velocidade=5f;
	public float maxDelay;

	public float instaciadorTempo=5f;
	public float instaciadorDelay = 3f;

	private float timeMovimentacao=0f;
	public int valorMinimoRandom=0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spwan",instaciadorTempo,instaciadorDelay);
	}
	
	// Update is called once per frame
	void Update () {
		movimentar ();
	}
	void Spwan(){
		int index = Random.Range (valorMinimoRandom,objetos.Length);
		Instantiate (objetos [index],transform.position,objetos[index].transform.rotation);
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
