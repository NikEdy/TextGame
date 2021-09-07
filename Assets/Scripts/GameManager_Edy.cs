using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Edy : MonoBehaviour
{
    public static GameManager_Edy instance;

    public GameUI_Edy gameUI;  //Drag UI on here
    public List<Question_Edy> questions = new List<Question_Edy>();

    public string questionTitleToStartFrom; //Starting from this Question State

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        PlayQuestionByTitle_Edy(questionTitleToStartFrom);
        //gameUI.PopulateUI(Question_Edy.questionTitle[0]);
        //PlayQuestionByTitle_Edy(questionTitleToStartFrom);
    }

    public void PlayQuestionByTitle_Edy(string title)
    {

		foreach (Question_Edy question in questions)
		{
		    if (question.questionTitle == title)
		    {
		        gameUI.PopulateUI(question);
		    }
		}

	}
}

