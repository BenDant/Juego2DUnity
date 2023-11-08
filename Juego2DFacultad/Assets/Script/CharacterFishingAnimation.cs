using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingAnimation : MonoBehaviour
{
    public GameObject Player; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FIsh"))
        {
            Destroy(collision.gameObject); // Destruye el objeto colisionado
            if (Player != null)
            {
                // Reproduce la animación del personaje
                Animator animator = Player.GetComponent<Animator>();
                if (animator != null)
                {
                    animator.SetTrigger("IsFishing"); 
                    Debug.Log(" AnimacionDePesca");
                }
            }
        }
    }
}
