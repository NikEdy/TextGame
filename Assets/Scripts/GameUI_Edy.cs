using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI_Edy : MonoBehaviour
{
    public Text questionTitle;   //Drag UI Obj -  Title Text
    public Text questionText;     //Drag UI Obj - Main Text
    public GameObject answersArea;  //Drag UI Area



    public void PopulateUI(Question question)
    {
        questionTitle.text = question.questionTitle;

        questionText.text = question.questionText;

        /*
        foreach (Answer answer in question.answers)
        {
            GameObject go = Instantiate(GameManager.instance.answerBtnPrefab, answersArea.transform);

            go.transform.GetChild(0).GetComponent<Text>().text = answer.answerText;

            AnswerBTN answerBTN = go.transform.GetComponent<AnswerBTN>();

            answerBTN.myAnswer = answer;

            go.transform.GetComponent<Button>().onClick.AddListener(() => answerBTN.ButtonListener());
        }
        */
    }

}
