using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    // Variável - Um objeto na memoria capaz de armazenar dados de diversos tipos

    // Todas as variável presente dentro de nossa <classe Variaveis> estão privada.

    // Sintaxe no C# para escrever número <int>, <float>, <booleanas>, <string>

    //Inteiro
    public int number = 10;

    // Para torna a vriável pública basta colocar antes da definição da mesma um <public>

    //Flutuante
    public float numberFloat = 10.2f;

    //Booleanas
    bool verdadeiro = true;
    bool falso = false;

    //String
    string nome = "Bass";

    // Variaveis próprias da unity

    public GameObject chao;
    public Transform inimigo;
}

public class Metodos : MonoBehaviour
{

    // Métodos - São blocos de instruções de códgio 

    // Como declrar um método no C# 

    // Antes de definir o método, precisamor definir o seu tipo, ser vai ser <int>, <float>, <void> ou entre outros...

    void Atack()
    {

    }

    void Movement()
    {

    }

    void Jump()
    {
        
    }
}
