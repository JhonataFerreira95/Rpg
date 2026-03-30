using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class TestLists : MonoBehaviour
{
    // Sintaxe para criar uma lists
    public List<int> idade = new List<int>();


    // Start is called before the first frame update
    void Start()
    {
        // Sintaxe para adicionar elementos na lists         
        idade.Add(1);
        idade.Add(2);

        // Sintaxe para remover o nome da lits
        idade.Remove(1);
        idade.Remove(2);

        // Sintaxe para limpar a lists inteira
        idade.Clear();

        // Lendo uma lists com foreach
        foreach (int item in idade){
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
