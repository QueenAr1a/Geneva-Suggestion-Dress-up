using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class CheckCollide : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Check");
    }
}
