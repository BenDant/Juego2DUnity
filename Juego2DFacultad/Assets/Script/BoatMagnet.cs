/*Este script se encarga de mantener al personaje pegado al barco*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMagnet : MonoBehaviour
{
 /*cuando entre en colision*/
 private void OnCollisionEnter2D(Collision2D collision)
 {
    if (collision.gameObject.name == "Boat")
     {
        /*si el jugador colisiona con el bote*/
        collision.gameObject.transform.SetParent(transform);
     }   
 }

  
}