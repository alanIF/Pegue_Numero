using UnityEngine;
using System.Collections;
using System.IO;

public class Arquivo : MonoBehaviour {
	public string linha;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Coletados", Player.NumeroColetados);
		PlayerPrefs.SetInt ("Pontuacao", Player.pontuacao);
		if(Player.pontuacao>PlayerPrefs.GetInt("recorde")){
			PlayerPrefs.SetInt ("recorde", Player.pontuacao);

		}
		if(Player.NumeroColetados>PlayerPrefs.GetInt("recorde_coletados")){
			PlayerPrefs.SetInt ("recorde_coletados", Player.pontuacao);

		}
		string folder = "Dados"; //nome do diretorio a ser criado

		//Se o diretório não existir...

		if (!Directory.Exists(folder))
		{

			//Criamos um com o nome folder
			Directory.CreateDirectory(Application.persistentDataPath +"/"+folder);

		}

		if (!File.Exists (Application.persistentDataPath+ "/Dados/dados.txt")) {
			File.Create (Application.persistentDataPath  + "/Dados/dados.txt").Dispose();
		}
		int j;
		j = 0;
		StreamReader rd = new StreamReader(Application.persistentDataPath  + "/Dados/dados.txt");
		//leitura arquivo
		while(!rd.EndOfStream){
			linha += rd.ReadLine()+"\n";
		}

		rd.Close();
		StreamWriter wr = new StreamWriter(Application.persistentDataPath + "/Dados/dados.txt", false);

		wr.WriteLine (linha);
		// nome, idade, pontuação, números coletados, erros, e tempo total
		wr.WriteLine(Player.nome+","+Player.idade+","+PlayerPrefs.GetInt("Pontuacao")+","+PlayerPrefs.GetInt("Coletados")+","+Player.erros+","+Player.tempo);
		wr.Close();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
