/*Encontre este script en archivos de unity, genera objetos aleatoriamente en una zona especifica*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] fishes; //creamos el Array fishes
    [SerializeField] private float minX, maxX, minY, maxY; //se crea un campo para el tamaño de la zona del generador
    void Start()
    {
        StartCoroutine(SpawnFish()); //se inicia la corrutina para generar peces
    }


     private IEnumerator SpawnFish()  //se crea la corrutina para generar peces
     {
        float SpawnTime = 10f; //determina el tiempo de generacion entre cada pez
        
        while (true)
        {
            float randomX = Random.Range(minX,maxX); //obtiene un valor de gen. aleatorio en X
            float randomY = Random.Range(minY,maxY); //obtiene un valor de gen. aleatorio en Y
            Vector2 randomPosition = new (randomX, randomY); //contiene la posicion aleatoria en ambos ejes
            int RandomIndex = Random.Range(0, fishes.Length); //Hace aleatorio que pez sera generado a continuacion
            Instantiate(fishes[RandomIndex], randomPosition, Quaternion.identity); //instancia al pez en la posicion aleatoria
            yield return new WaitForSeconds(SpawnTime);
        }        
     }

        
     


    private void OnDrawGizmos()   //metodo para visualizar los bordes de la zona del generador
    {
       Vector2  center = new((maxX + minX)/2, (maxY + minY)/2); //posicion del centro de la zona
       Vector2 size = new (maxX - minX, maxY - minY); //vector con las longitudes de los lados
       Gizmos.DrawWireCube(center,size); //dibuja el contorno
    }
}
