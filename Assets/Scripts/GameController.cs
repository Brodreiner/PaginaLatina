using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private System.Random rnd = new System.Random();

    public Text question;
    public Button[] answers;

    public WordManager wordManager;

    private Word currentWord;


    private Button rightAnswer;

    // Use this for initialization
    void Start()
    {
        NextQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void NextQuestion()
    {
        List<Word> wordList = wordManager.GetWords(5);

        currentWord = wordList[rnd.Next(wordList.Count)];

        question.text = currentWord.latein;
        answers[0].GetComponentInChildren<Text>().text = wordList[0].deutsch;
        answers[1].GetComponentInChildren<Text>().text = wordList[1].deutsch;
        answers[2].GetComponentInChildren<Text>().text = wordList[2].deutsch;
        answers[3].GetComponentInChildren<Text>().text = wordList[3].deutsch;
        answers[4].GetComponentInChildren<Text>().text = wordList[4].deutsch;


        foreach (Button answer in answers)
        {
            answer.interactable = true;
        }
    }

    public void OnClickQuestion()
    {
        NextQuestion();
    }

    public void OnClickAnswer(Button buttonClicked)
    {
        foreach (Button answer in answers)
        {
            string answerText = answer.GetComponentInChildren<Text>().text;
            answer.interactable = false;
            var colors = answer.colors;

            if (answer == buttonClicked)
            {
                if (answerText == currentWord.deutsch)
                {
                    colors.disabledColor = new Color(0, 0.8f, 0);
                }
                else
                {
                    colors.disabledColor = new Color(1, 0, 0);
                }
            }
            else
            {
                if (answerText == currentWord.deutsch)
                {
                    colors.disabledColor = new Color(0, 0.5f, 0);
                }
                else
                {
                    colors.disabledColor = new Color(.7f, .7f, .7f);
                }
            }
            answer.colors = colors;
        }
    }
}
