using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchArea : MonoBehaviour
{
    private int strength = 1; //fuerza para sacar al pez (hay que tirar varias veces)

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<FishScore>() != null)
        {
            FishScore resistance = collider.GetComponent<FishScore>();
            resistance.Catch(strength);
            Debug.Log("tira");
        }
    }
}

