using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WarpDialogue : MonoBehaviour {

    public GameObject player;
    public GameObject Erin;
    public GameObject Lada;
    public GameObject Mintra;
    public GameObject Nicha;
    public static Transform WarpPosition;

    public void Start()
    {
        if(PlayerPrefs.HasKey("PlayerX"))
        {
            WarpGate();
        }
        else
        {

        }
    }

    public void WarpGate()
    {
        
        float posX = PlayerPrefs.GetFloat("PlayerX");
        float posY = PlayerPrefs.GetFloat("PlayerY");
        float posZ = PlayerPrefs.GetFloat("PlayerZ");
        Debug.Log(posX);
        if (PlayerPrefs.GetFloat("PlayerX") <= -12 && PlayerPrefs.GetFloat("PlayerX") >= -15)
        {
            Erin.SetActive(false);
        }
        else if (PlayerPrefs.GetFloat("PlayerX") == 14.787)
        {
            Nicha.SetActive(false);
        }
        else if (PlayerPrefs.GetFloat("PlayerX") <= 1590 && PlayerPrefs.GetFloat("PlayerX") >= 1351)
        {
            
            Lada.SetActive(false);
        }
        else if (PlayerPrefs.GetFloat("PlayerX") <= 83 && PlayerPrefs.GetFloat("PlayerX") >= 80)
        {

            Mintra.SetActive(false);
        }


        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/

        Vector3 newPos = new Vector3(posX,posY,posZ);
        player.transform.position = newPos;
        PlayerPrefs.DeleteKey("PlayerX");
        PlayerPrefs.DeleteKey("PlayerY");
        PlayerPrefs.DeleteKey("PlayerZ");


    }
    

}