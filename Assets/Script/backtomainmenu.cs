using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcamera : MonoBehaviour
{
    //method untuk kembali ke main menu
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.LoadLevel ("mainMenuScene");
	}

}
