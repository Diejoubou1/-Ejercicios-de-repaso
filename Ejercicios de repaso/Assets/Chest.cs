using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private bool isOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isOpen)
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        isOpen = true;
        Debug.Log("wii abriste el cofre");
    }
}

