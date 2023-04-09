    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Open : MonoBehaviour
{
    public Canvas cvs;

    private void Start()
    {
        cvs.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cvs.enabled = true;
        }
    }
}
