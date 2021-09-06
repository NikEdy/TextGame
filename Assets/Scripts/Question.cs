using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Question
{
    public string questionTitle;

    [TextArea]
    public string questionText;

    public List<Answer> answers = new List<Answer>();
}
