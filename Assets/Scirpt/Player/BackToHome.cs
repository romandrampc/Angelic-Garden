using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class BackToHome : MonoBehaviour {

    public GameObject player;
    public GameObject MenuHome;

    private void Start()
    {
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && Input.GetMouseButton(0))
        {
            MenuHome.SetActive(true);
        }

    }

    public void ToCredit()
    {
        SceneManager.LoadScene(2);
    }

    public void ToGame()
    {
        MenuHome.SetActive(false);
    }
}
