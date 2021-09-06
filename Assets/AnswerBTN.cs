using UnityEngine;

public class AnswerBTN : MonoBehaviour
{
    public Answer myAnswer;

    public void ButtonListener()
    {
        if (myAnswer.isCorrect)
        {
            Debug.Log("mpbravo");
        }
        else
        {
            Debug.Log("la8os");
        }
    }
}
