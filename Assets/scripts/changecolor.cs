using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer render;
    public Color color1;
    public Color color2;
    // Start is called before the first frame update
    void Start()
    {
        render=GetComponent<Renderer>();
    }
    
    public void Color1Change(){
          render.material.color=color1;
    }
    
     public void Color2Change(){
          render.material.color=color2;
    }
    

    
}
