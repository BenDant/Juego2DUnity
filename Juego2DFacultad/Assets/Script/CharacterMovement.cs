/*este script se encarga del movimiento del personaje*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1250f; //Velocidad de movimiento del pj
    private bool isFacingRight = true;   //representa el valor de mirar a la derecha
    private Rigidbody2D rb; //referencia al componente RigidBody del personaje
    
    private void Start()
    {
        rb= GetComponent<Rigidbody2D>(); //Obtenemos la referencia al RB2D del pj
    }

    private void Update()
    {
      float movementX = Input.GetAxis("Horizontal"); //obtenemos la entrada de movimiento horizontal (-1 a 1) y la almacenamos en MovementX
      Move(movementX*movementSpeed); //Normalizamos al multiplicar por DeltaTime
     
    }
    //Establece la velocidad del Personaje para el movimiento horizontal
    public void Move(float velocity)
    {
      rb.velocity = new Vector2(velocity * Time.deltaTime, rb.velocity.y);
    }
    //cambiamos la escala en el eje x para voltear al pj
    private void Flip()
    {
      transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
      isFacingRight = !isFacingRight;
    }
}