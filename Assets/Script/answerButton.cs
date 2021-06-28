using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerButton : MonoBehaviour
{

	public Text answerText;
	private AnswerData answerData;
    private gameController gameController;
    //method start dipanggil sebelum update frame pertama bro
    void Start()
    {
        gameController = FindObjectOfType<gameController>();
    }

    public void Setup(AnswerData data){
    	answerData = data;
    	answerText.text = answerData.answerText;

    }

    public void HandleClick()
    {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}
