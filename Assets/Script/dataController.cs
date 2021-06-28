using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dataController : MonoBehaviour
{

	public roundData[] allRoundData;
    // method untuk memanggil splashscene sebelum ke main menu bro
    void Start()
    {

    	DontDestroyOnLoad (gameObject);
    	SceneManager.LoadScene ("splashScene");
        
    }

    public roundData GetCurrentRoundData(){
    	return allRoundData[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
