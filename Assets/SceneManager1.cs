using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneManager1 : MonoBehaviour {


	[SerializeField] public Text Info;




	[SerializeField] public Button Play;  //Drag But Play on here
	[SerializeField] public Button Quit;  //Drag But Quit on here


	//Start
	void Start() {

		//Quit = GetComponent<Button>();
		Quit.onClick.AddListener(() => Quit_Clicked());

		//Play = GetComponent<Button>();
		Play.onClick.AddListener(() => Play_Clicked());


		//button = GameObject.Find("Play").GetComponent<Button>();
		//button.onClick.AddListener(() => Titles_But_Play());
		//button = GameObject.Find("Quit").GetComponent<Button>();
		//button.onClick.AddListener(() => Titles_But_Quit());
	} 

	//Button Play



	void Play_Clicked() {
		//print("Play");
		SceneManager.LoadScene("Scene2");
	}


	void Quit_Clicked(){
		//print("Quit");
		Application.Quit();
	}
}






/*
public class Cl_List {
	public string Text;
	public int State;

	public Cl_List(string newName, int newState) {
		Text = newName;
		State = newState;
	}

}


/*
	public void RunList()
	{
		List<Cl_List> Cl_List = new List<Cl_List>();

		Cl_List.Add(new Cl_List("Hello", 50));
		Cl_List.Add(new Cl_List("Hello1", 100));
		Cl_List.Add(new Cl_List("Hello2", 250));

		//Cl_List.Remove

	}








/*
Dictionary<string, int> List = new Dictionary<string, int>();
List.Add("hello", 1);
List.Add("WhatsUp", 3);
List.Add("Bye", 8);

//Debug.Log(fruits["apple"]);


*/


