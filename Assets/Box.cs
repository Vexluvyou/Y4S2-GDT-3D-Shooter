using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IDamagable
{
    public void TakeDamage()
    {
        Debug.Log("Box with coins was opened!");
        // drop coins
    }
}

