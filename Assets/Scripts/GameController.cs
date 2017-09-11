using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public Text question;
    public Button[] answers;


    private Button rightAnswer;

    // Use this for initialization
    void Start () {
        question.text = "Amicus";
        answers[0].GetComponentInChildren<Text>().text = "die Freundin";
        answers[1].GetComponentInChildren<Text>().text = "das Colosseum";
        answers[2].GetComponentInChildren<Text>().text = "der Freund";
        answers[3].GetComponentInChildren<Text>().text = "da, dann, darauf, damals";
        answers[4].GetComponentInChildren<Text>().text = "endlich";
        rightAnswer = answers[2];
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnClick(Button buttonClicked)
    {
        foreach(Button answer in answers)
        {
            answer.interactable = false;
        }
        if(buttonClicked == rightAnswer)
        {
            var colors = buttonClicked.colors;
            colors.disabledColor = new Color(0, 0.8f, 0);
            buttonClicked.colors = colors;
        }
        else
        {
            var colors = buttonClicked.colors;
            colors.disabledColor = new Color(1.0f, 0, 0);
            buttonClicked.colors = colors;

            colors = rightAnswer.colors;
            colors.disabledColor = new Color(0,0.5f,0);
            rightAnswer.colors = colors;

        }
    }
}
