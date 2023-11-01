/*este codigo se encarga del efecto Parallax*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
  [SerializeField] private Vector2 movementSpeed;    
  private Vector2 offset;
  /*referencia al material*/
  private Material material;
  /*referencia al RB del personaje*/
  private Rigidbody2D playerRB;
  private void Awake()
  {
    /*le decimos que el material sea el mismo al del sprite renderer*/
    material= GetComponent<SpriteRenderer>().material;
    /*buscamos por etiqueta y le pasamos el componente*/
    playerRB =  GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
  }

  private void Update() 
  {
    /*se toma una decima parte de la velocidad del jugador, y regularizamos el offset con deltatime*/
    offset = (playerRB.velocity.x * 0.1f) * movementSpeed * Time.deltaTime;
    /*tomamos el offset y le sumamos el que se creó arriba*/
    material.mainTextureOffset += offset;
  }
}
