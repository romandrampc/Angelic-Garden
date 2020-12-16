using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpToDialogueLada : MonoBehaviour {

    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && Input.GetMouseButton(0) || Input.GetMouseButton(1) )
        {
            PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
            PlayerPrefs.SetFloat("PlayerY", player.transform.position.y);
            PlayerPrefs.SetFloat("PlayerZ", player.transform.position.z);
            Debug.Log(player.transform.position.x);
            SceneManager.LoadScene(4);

        }
    }
}
