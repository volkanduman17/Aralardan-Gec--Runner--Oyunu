using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCarpisma : MonoBehaviour
{

    public playerGidisi hareket;

    private void OnCollisionEnter(Collision temas)
    {
        if (temas.collider.tag == "Engel")
        {
            hareket.enabled = false;
            Debug.Log("Yandýn !");
        }
    }
}
