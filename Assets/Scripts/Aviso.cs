using UnityEngine;
using System.Collections;

public class Aviso : MonoBehaviour {
	public  UnityEngine.UI.Text aviso;
	public  int i,temp;
	public static int Tipoaviso;
	// numero da fase
 	public static int numeroColetadosfase;


	// Use this for initialization
	void Start () {
		numeroColetadosfase = 0;
		temp = 10;
		i = 0;
		if (Player.fase == 1) {
			aviso.text = "Pegue "+Player.numero_sort+" numeros" ;

		}
	}

	// Update is called once per frame
	void Update () {
		
		if (Tipoaviso == 1) {
			aviso.text = "Você não concluiu o objetivo da fase!";
				i=0;
				temp=10;
			Tipoaviso = 0;
		}
		if (i == 30) {
			temp -= 1;
			i = 0;
		}
		if (temp == 0) {
			aviso.text = "";
		}
		i += 1;
	}
}
