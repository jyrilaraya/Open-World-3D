using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpFragment : MonoBehaviour
{
    public GameManager gameManager;

    public Text txtQuestUpdate;
    public Text txtInteractMessage;

    public void OnTriggerEnter(Collider actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            if(gameManager.gameStatus == 1)
            {
                txtInteractMessage.text = "Press [F] to pick up";
            }
        }
    }
    public void OnTriggerStay(Collider actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            if (gameManager.gameStatus == 1)
            {
                if(Input.GetKey(KeyCode.F))
                {
                    gameManager.isFragmentCollected = true;
                    gameManager.gameStatus = 2;
                    txtQuestUpdate.text = "Find the Nearest Town...";
                    txtInteractMessage.text = "";
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
    public void OnTriggerExit(Collider actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            txtInteractMessage.text = "";
        }
    }
}
