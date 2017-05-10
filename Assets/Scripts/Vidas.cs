using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour {

	private int contador;

	public Sprite coracao1;
	public Sprite coracao2;
	public Sprite coracao3;
	public Transform player;


	// Use this for initialization
	void Start () {

		contador = 0;
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = coracao1;
		// mudar o sprite para o primeiro com tres estrelas

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (player.position.x + 7, player.position.y + 5);
	}
	public bool excluirVida(){
		if (contador ==0) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = coracao2;
			// mudar a posicao do vetor com a posicao do contador sprite ir para as outras estrelas
			contador+=1;
			return true;
		} 
		if (contador == 1) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = coracao3;
			// mudar a posicao do vetor com a posicao do contador sprite ir para as outras estrelas
			contador+=1;
			return true;
		}
		else {
			return false;
		
		}


	}

}
