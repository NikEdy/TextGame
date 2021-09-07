using System; //.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Question_Edy
{
    public string questionTitle;

    [TextArea]
    public string questionText;

    public List<Answer_Edy> answers = new List<Answer_Edy>();
}
