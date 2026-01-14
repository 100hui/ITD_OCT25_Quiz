using UnityEngine;

public class StartQuiz : MonoBehaviour
{
    public GameObject quizElements;

    public void StartExperience()
    {
        quizElements.SetActive(true);
    }
}
