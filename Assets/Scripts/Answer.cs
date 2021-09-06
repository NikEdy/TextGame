using System;
using UnityEngine;

[Serializable]
public class Answer
{
    [TextArea]
    public string answerText;

    public bool isCorrect;
}
