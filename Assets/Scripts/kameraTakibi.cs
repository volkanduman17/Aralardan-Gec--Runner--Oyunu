using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakibi : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    
    void Update()
    {
        transform.position = player.position + offset;
    }
}
