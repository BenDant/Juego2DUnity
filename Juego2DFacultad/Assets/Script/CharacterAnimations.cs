using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator animator; //referencia al componente de animacion del pj




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
    }
}