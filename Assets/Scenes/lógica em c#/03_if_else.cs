using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaif : MonoBehaviour
{

    public bool teste = false;
    // Start is called before the first frame update
    void Start() // O método start é chamado apenas quando inicializa
    {
       if(teste == true)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("Falso");
        } 
    }

    // Update is called once per frame
    void Update() // O método update é chamado a cada frame
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressionou spaço");
        }
        else
        {
            Debug.Log("Não pressionou");
        }
    }
}
