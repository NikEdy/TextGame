using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string questionTitleToStartFrom;
    public int startingIndex;

    public static GameManager instance;

    public GameUI gameUI;

    public GameObject answerBtnPrefab;

    public List<Question> questions = new List<Question>();


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //PlayQuestionByTitle(questionTitleToStartFrom);

        PlayQuestionByIndex(startingIndex);
    }

    public void PlayQuestionByIndex(int index)
    {
        Question question = questions[index];

        if (question != null)
        {
            gameUI.PopulateUI(question);
        }
    }


    public void PlayQuestionByTitle(string title)
    {
        Question question = Array.Find(questions.ToArray(), qst => qst.questionTitle == title);

        if (question != null)
        {
            gameUI.PopulateUI(question);
        }



        //foreach (Question question in questions)
        //{
        //    if (question.questionTitle == title)
        //    {
        //        gameUI.PopulateUI(question);
        //    }
        //}
    }
}


