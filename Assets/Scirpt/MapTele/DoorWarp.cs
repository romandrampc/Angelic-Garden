using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorWarp : MonoBehaviour {

    public GameObject player;
    public Transform WarpPosition;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            player.transform.position = WarpPosition.position;
        }
    }
}
