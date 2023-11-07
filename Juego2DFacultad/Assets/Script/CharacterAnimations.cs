using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator animator; //referencia al componente de animacion del pj
   // private bool IsAnimationPlaying = false; //se asegura de si la animacion se reproduce o no




    private void Start()
    {
        animator = GetComponent<Animator>(); //obtenemos la referencia al componente Animator 
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) //comparamos el valor de movimiento (-1 / 0 / 1 )
        {
            animator.SetBool("IsRowing", true); //activa la animacion de remar
        }
        else
        {
            animator.SetBool("IsRowing", false); //desactiva la animacion de remar
        }



        /*if (Input.GetKeyDown(KeyCode.Space)) //si apretamos la barra espaciadora, y la animacion no esta reproduciendose, se activa la animacion
        {
            if (!IsAnimationPlaying)
            {
                animator.SetBool("IsCatching",true); //activa la animacion
                IsAnimationPlaying = true;
            }
            else
            {
                animator.SetBool("IsCatching",false); //desactiva la animacion
                Debug.Log("se ha desactivado");  
                IsAnimationPlaying = false;

            }
        }*/
    }
          



    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger==true && collision.CompareTag("FIsh") )
        {
            animator.SetBool("IsFishing",true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {      
        animator.SetBool("IsFishing",false);
        Debug.Log("se ha desactivado");  
    }  */
    /*private void OnMouseDown()    
   {
     animator.SetBool("IsFishing",false);
     Debug.Log("se ha desactivado");*/
}