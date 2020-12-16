using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimeSet : MonoBehaviour {

    public GameObject FristSetup;
	// Use this for initialization
	void Start () {
        PlayerPrefs.DeleteKey("PlayerX");
        PlayerPrefs.DeleteKey("PlayerY");
        PlayerPrefs.DeleteKey("PlayerZ");
        FristSetup.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
