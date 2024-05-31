using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public Text txtQuestUpdate;
    public Text txtInteractMessage;
    private void OnTriggerEnter(Collider actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            if(gameManager.gameStatus == 2)
            {
                gameManager.gameStatus = 3;
                txtInteractMessage.text = "I need to fine the guild master...";
                txtQuestUpdate.text = "Look for the guild master and give the fragment...";
                Invoke("ClearMessage", 2f);
            }
        }
    }
    void ClearMessage()
    {
        txtInteractMessage.text = "";
        this.gameObject.SetActive(false);
    }

}

