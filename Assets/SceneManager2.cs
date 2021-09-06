using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour {

	[SerializeField] public Button Yes;
	[SerializeField] public Button No;
	[SerializeField] public Text info;

	private GameState State;

	private int[] Ar = new int[4];      //Array with 5 Items


	void Start() {

		//Set State
		State = GameState.YouWantToSing;

		//Check Text
		info.text = CheckText(State);

		//Functions on Click
		Yes.onClick.AddListener(() => Clicked(1, State));
		No.onClick.AddListener(() => Clicked(2, State));

	}


	
	//Clicked
	void Clicked(int Choice, GameState StateNow){
		//int St = (int)State; //Convert enum to Num

		switch(StateNow){

			case GameState.YouWantToSing:
				if (Choice == 1) { State = GameState.YouAreInDanger; }
				else { State = GameState.YouFoundTheWayOut; }
				info.text = CheckText(State);
			break;


			case GameState.YouAreInDanger:
				if (Choice == 1) { State = GameState.YouFoundTheWayOut; }
				else { State = GameState.LionAteYou; }
				info.text = CheckText(State);
			break;

			case GameState.YouFoundTheWayOut:
				if (Choice == 1) { State = GameState.YouWin; }
				else { State = GameState.YouWantToSing; }
				info.text = CheckText(State);
			break;

			case GameState.YouWin:
				if (Choice == 1) { State = GameState.YouWantToSing; }
				else { SceneManager.LoadScene("Scene1"); }
				info.text = CheckText(State);
			break;

			case GameState.LionAteYou:
				if (Choice == 1) { State = GameState.YouWantToSing; }
				else { SceneManager.LoadScene("Scene1"); }
				info.text = CheckText(State);
			break;
		}
	}

	//Check Text
	string CheckText(GameState State) {
		int St = (int)State; //Convert enum to Num
		string[] Ar = new string[5];
		Ar[0] = "You are walking in the joungle, \n are you going to sing?";
		Ar[1] = "Lion Heard you! Kill it?";
		Ar[2] = "You see a Light behind trees! Going there?";
		Ar[3] = "Lion Ate you! Try again?";
		Ar[4] = "You Manage go to Village! Play again?";
		return Ar[St];
	}
}


//Game enums State
public enum GameState {
	YouWantToSing,
	YouAreInDanger,
	YouFoundTheWayOut,
	LionAteYou,
	YouWin
}

