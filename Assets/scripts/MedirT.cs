using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedirT : MonoBehaviour
{
    public Transform target;
    public float distanciaMinima;
    public Material texture;

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(target.position,transform.position);
        if(distancia < distanciaMinima)
        {
          Debug.Log("que pedo gato!");
        }
    }
}
