using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, IDamagable
{
    public void TakeDamage()
    {
        Debug.Log("Barrel exploded!");
        // make an explosion
        // drop item
    }
}
