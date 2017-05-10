using UnityEngine;
using System.Collections;
using System.IO;

public class Player : MonoBehaviour {

	public float velocidade;
	public Transform player;
	private Animator animator;
	public static int fase;
	//arquivo da fase
	public static string arquivo;
	//
	public AudioSource audio;
	public AudioClip soundJump;
	//estatisticas jogador
	public static int pontuacao;
	public static int NumeroColetados;
	public static int recorde;
	public static int erros;
	public static int numero_sort;
	public static float tempo;

	//pontuacao jogador
	public UnityEngine.UI.Text txtpontos;

	//dados jogador
	public static string nome;
	public static int idade;

	public Rigidbody2D PlayerRigidBody;

	public bool isGrounded;
	public float force;

	public float jumpTime=0.4f;
	public float jumpDelay=0.4f;
	public bool jumped;
	public Transform ground;
	// Use this for initialization
	void Start () {
		string data = System.DateTime.Now.ToString ("dd-MM-yyyy");
		string hora=  System.DateTime.Now.ToString ("HH-mm-ss");
		arquivo = nome + "-" + data + "-" + hora + "-" + fase+".txt";

		if (!File.Exists (Application.persistentDataPath  + "/Dados/"+arquivo)) {
			File.Create (Application.persistentDataPath + "/Dados/"+arquivo).Dispose();
		}
		animator = player.GetComponent<Animator>();

		txtpontos.text = pontuacao.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		tempo+=Time.deltaTime;
		txtpontos.text = pontuacao.ToString ();
		movimentar ();

	}
	void movimentar(){
		isGrounded = Physics2D.Linecast (this.transform.position,ground.position,1<<LayerMask.NameToLayer("Plataforma"));
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			animator.SetBool("Run",true);

			transform.Translate (Vector2.right*velocidade*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
		}
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			animator.SetBool("Run",true);

			transform.Translate (Vector2.right*velocidade*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);

		}
	
		if (Input.GetButtonDown ("Jump")&& isGrounded && !jumped) {
			PlayerRigidBody.AddForce (new Vector2 (0, force));
			audio.PlayOneShot (soundJump);
			audio.volume = 0.2f; 
			jumpTime = jumpDelay;
			animator.SetTrigger ("jump");
			jumped = true;
		}
		jumpTime -= Time.deltaTime;
		if (jumpTime <= 0 && isGrounded && jumped) {
			animator.SetTrigger ("ground");
			jumped = false;
		}

	}
}
