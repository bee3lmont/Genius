using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public GameManager gameManager;
    [SerializeField] private float timeBetweenQuestions = 1f;
    [SerializeField] private Text correct;
    [SerializeField] private Text wrong;
    IEnumerator TransistionToNextQuestion()
    {
        gameManager.Correct();

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Answer()
    {
        if (isCorrect)
        {
            correct.text = "CORRECT";
            Invoke("LoadCongratulations", 2f);
        }
        else
        {
            wrong.text = "WRONG";
            Invoke("LoadWrong", 2);
        }
       
    }
    private void LoadCongratulations()
    {
        SceneManager.LoadScene("Congratulations");
    }
    private void LoadWrong()
    {
        SceneManager.LoadScene("Wrong");
    }
}
