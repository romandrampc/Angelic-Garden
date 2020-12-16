using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class AnsDialogue2 : MonoBehaviour {

    public GameObject QA;
    public GameObject Dialogue1;
    public GameObject A1Dialogue;
    public GameObject A2Dialogue;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DialogueWay1()
    {
        QA.SetActive(false);
        A1Dialogue.SetActive(true);
    }

    public void DialogueWay2()
    {
        QA.SetActive(false);
        A1Dialogue.SetActive(true);
    }
}
