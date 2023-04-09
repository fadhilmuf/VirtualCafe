    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Menu : MonoBehaviour
{
    public Canvas menuCanvas;

    private void Start()
    {
        menuCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Selamat malam kak, ada yang bisa dibanting?");
            Debug.Log("Silahkan tekan 'F' untuk melihat menu");
            menuCanvas.enabled = true;
        }
    }
}
