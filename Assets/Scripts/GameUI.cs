using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text questionTitle;
    public Text questionText;

    public GameObject answersArea;

    public void PopulateUI(Question question)
    {
        questionTitle.text = question.questionTitle;

        questionText.text = question.questionText;

        foreach (Answer answer in question.answers)
        {
            GameObject go = Instantiate(GameManager.instance.answerBtnPrefab, answersArea.transform);

            go.transform.GetChild(0).GetComponent<Text>().text = answer.answerText;

            AnswerBTN answerBTN = go.transform.GetComponent<AnswerBTN>();

            answerBTN.myAnswer = answer;

            go.transform.GetComponent<Button>().onClick.AddListener(() => answerBTN.ButtonListener());
        }
    }
}
