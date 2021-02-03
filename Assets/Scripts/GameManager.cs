using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Questions> Qna;
    public GameObject[] options;
    public int currentQues;

    public Text questionText;

    private void Start()
    {
        //Qna.RemoveAt(currentQues);
        GenerateQues();
    } 
    public void Correct()
    {
        Qna.RemoveAt(currentQues);
        GenerateQues();
    }
    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = Qna[currentQues].ans[i];

            if(Qna[currentQues].correctAns == i + 1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }
    void GenerateQues()
    {
        if(Qna.Count > 0)
        {
            currentQues = Random.Range(0, Qna.Count);
            questionText.text = Qna[currentQues].ques;
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of Display");
        }
    }
}

