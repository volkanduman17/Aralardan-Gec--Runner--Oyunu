using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{

    public Transform player;
    public Text skorYazisi;

    
    void Update()
    {
        skorYazisi.text = player.position.z.ToString("0");
    }
}
