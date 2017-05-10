using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using System;
public class Registro : MonoBehaviour {
	public UnityEngine.UI.Text nome;
	public UnityEngine.UI.Text idade;
	// Use this for initialization
	void Start () {
		string folder = "Dados"; //nome do diretorio a ser criado

		//Se o diretório não existir...

		if (!Directory.Exists(Application.persistentDataPath+"/"+folder))
		{

			//Criamos um com o nome folder
			Directory.CreateDirectory(Application.persistentDataPath +"/"+folder);

		}

		if (!File.Exists (Application.persistentDataPath+ "/Dados/dados.txt")) {
			File.Create (Application.persistentDataPath + "/Dados/dados.txt").Dispose();

		}
		Player.tempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void registrar(){
		try {
			
			//sorteiar o número
			Player.numero_sort=10;
			if (!nome.text.ToString().Equals("") && int.Parse(idade.text.ToString()) > 0) {
				Player.nome = nome.text.ToString().ToLower();
				Player.idade = int.Parse(idade.text);
				SceneManager.LoadScene ("Tutorial");
			}

		} catch (Exception e) {
		}


	}
}

