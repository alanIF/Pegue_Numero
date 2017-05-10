using UnityEngine;
using System.Collections;

public class MouveTouch : MonoBehaviour {
	public float velocidade;
	public Transform player;
	public Animator animator;

	public AudioSource audio;
	public AudioClip soundJump;



	public UnityEngine.UI.Text txtpontos;

	public Rigidbody2D PlayerRigidBody;

	public bool isGrounded;
	public float force;

	public float jumpTime=0.4f;
	public float jumpDelay=0.4f;
	public bool jumped;
	public Transform ground;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		txtpontos.text = Player.pontuacao.ToString ();
		isGrounded = Physics2D.Linecast (player.transform.position,ground.position,1<<LayerMask.NameToLayer("Plataforma"));
		if (isGrounded) {
			animator.SetTrigger ("ground");
			jumped = false;

		}
		if (jumped) {
			isGrounded = false;
		}
		jumpTime -= Time.deltaTime;

		move (StatusBar.paramStatus);
	}
	void move(int param){

		if (param > 0) {
			animator.SetBool("Run",true);

			player.transform.Translate (Vector2.right*velocidade*Time.deltaTime);
			player.transform.eulerAngles = new Vector2 (0, 0);
		}
		if (param < 0) {
			animator.SetBool("Run",true);

			player.transform.Translate (Vector2.right*velocidade*Time.deltaTime);
			player.transform.eulerAngles = new Vector2 (0, 180);
		}
		if (param == 0) {
			animator.SetBool("Run",false);

		}
	}

	public void StartMove(int param){
		StatusBar.paramStatus = param;
	}
	public void jump(){
		if (isGrounded && !jumped) {
			animator.SetTrigger ("jump");

			PlayerRigidBody.AddForce (new Vector2 (0, force));
			audio.PlayOneShot (soundJump);
			audio.volume = 0.2f; 
			jumpTime = jumpDelay;
			jumped = true;
			isGrounded = false;
		}
	}

}
