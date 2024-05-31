using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoadBlock : MonoBehaviour
{
    public GameManager gameManager;

    public Text txtQuestUpdate;
    public Text txtInteractMessage;

    public GameObject companionNPC;

    public void OnTriggerEnter(Collider actor)
    {
        if (actor. gameObject.CompareTag("Player"))
        {
            if(gameManager.gameStatus == 0 || gameManager.gameStatus == 1)
            {
                txtInteractMessage.text = "Where is the fragment that we came here for?";
            }

            if(gameManager.gameStatus == 2)
            {
                txtInteractMessage.text = "Let's fo find the town...";
                Invoke("ClearMessage", 1.5f);
            }
        }

    }
    public void OnTriggerExit(Collider actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            if (gameManager.gameStatus == 0 || gameManager.gameStatus == 1)
            {
                gameManager.gameStatus = 1;
                txtQuestUpdate.text = "Investigate the crash site and look for the fragment...";
                txtInteractMessage.text = "";
            }
        }
    }
    void ClearMessage()
    {
        txtInteractMessage.text = "";
        companionNPC.gameObject.SetActive(false);
    }
}
