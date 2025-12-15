using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// O switch funciona parecido com o if e else.
public class Aula_switch : MonoBehaviour // É utilizado para evitar o uso exagerado de if/else
{

    public int diaSemana;

    // Start is called before the first frame update
    void Start()
    {
         // sintaxe do Switch case

        switch(diaSemana){
            case 1:
                Debug.Log("Segunda");
                break;
            case 2:
                Debug.Log("Terça");
                break;
            case 3:
                Debug.Log("Quarta");
                break;
            case 4:
                Debug.Log("Quinta");
                break;
            case 5:
                Debug.Log("Sexta");
                break;
            case 6:
                Debug.Log("Sábado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("Dia não encontrado");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
