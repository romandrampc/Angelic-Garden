using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}

    public void CreditSceneSelection()
    {
        SceneManager.LoadScene(2);
    }
}
