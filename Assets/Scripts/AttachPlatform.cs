using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlatform : MonoBehaviour
{

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject platformParent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.parent = platformParent.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.parent = null;
        }

    }
}
