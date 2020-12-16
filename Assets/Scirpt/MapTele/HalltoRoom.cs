using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalltoRoom : MonoBehaviour
{

    public Transform WarpPosition;
    public GameObject player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            player.transform.position = WarpPosition.position;
        }
    }
}
