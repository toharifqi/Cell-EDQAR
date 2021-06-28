using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void GoToMainMenu(){
		Application.LoadLevel("mainMenuScene");
	}

	public void GoToARCamera(){
		Application.LoadLevel("augmentedRealityScene");
	}

	public void GoToQuiz(){
		Application.LoadLevel("quizScene");
	}

	public void GoToVideo(){
		Application.LoadLevel("videoScene");
	}

	public void ExitApplication(){
		Application.Quit ();
	}

}
