using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class loading : MonoBehaviour
{
    public Transform LoadingBar;

	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;

	// untuk update loading bar
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			Debug.Log ((int)currentAmount);
		} else {
			Application.LoadLevel ("mainMenuScene");
		}

		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}

}
