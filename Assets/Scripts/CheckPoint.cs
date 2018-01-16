using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {


    /// <summary>
    /// funzione per tornare a checkpoint, setta lo spawn dei BasePlayer al checkpoint
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            BasePlayer playerScript = other.GetComponent<BasePlayer>();
            playerScript.SetRespawnPoint(transform.position);
        }
    }
}
