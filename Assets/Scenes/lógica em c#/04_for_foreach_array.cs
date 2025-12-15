using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class For_foreach_array : MonoBehaviour
{
    // Start is called before the first frame update

    // foreach e array
   
    public int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7 };  // Sintaxe do array
      
    void Start()
    {
        // for (valorInicial; CondicionalFinal; ValorIncremento)
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(i);
        }
        
        // Sintaxe foreach

        foreach(int valor in arrayInt)
        {
            Debug.Log(valor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
