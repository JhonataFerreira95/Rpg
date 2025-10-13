# Rpg IFRN

## Dependências 

- Unity version 2021.3.45f1
- C#

## Índice

1. [Introdução](#introdução)
2. [Variaveis e Métodos](#variaveis-métodos-e-tipos)
3. [Classes](#classes)
4. [Condicionais(if/else)](#condicionaisifelse)


---

## Estrutura do projeto

```bash

IFRN RPG/
├── Assets/
│   └── Scenes/
│   └── script
│   └── Lógica em c#
├── Logs/
├── Packages/
├── Ruby fundamentos/
│   ├── layouts/
│   └── Search.settings
├── .gitattributes
├── .gitignore
├── Rpg_IFRN.sln
└── README.md

```

# Introdução

O projeto visa a apredizagem com `C#` em conjunto da IDE `Unity` para desenvovilmento de um jogo para o IFRN campus parnamirim, com objetivo de ser utilizado para o TCC de conclusão do curso.

## Variaveis, Métodos e Tipos

- Variáveis são espaços reservados na memória do computador usados para armazenar valores ou dados que podem ser manipulados durante a execução de um programa.

- Métodos são blocos de código reutilizáveis que contêm instruções para realizar uma tarefa específica, como resolver um problema ou executar uma ação dentro do programa.

- Os tipos são algo importante, afinal é onde definimos qual tipo que caracter nossa váriavel vei conter. Existem algums deles, o mias comum é o tipo `string`(lestras), `int`(número inteiros), `float`(números flutuantes) e `boolean`(verdeiro ou falso). Esses são os tipos básicos, antes de definir uma váriavel é preciso definir o seu tipo, segue o exemplo na prática:

    - Atribuição para uma váriavel:

        ```cs

            string Nome = "Seu nome";

        ```

    - Definimos a váriavel com seu tipo `string`, ou seja, tudo que colocarmos em `"aqui"` dentro das aspas são lestras.

    - Para definirmos o método ou váriavel público, passamos a palavra reservada `public` antes de declarar o tipo e o nome da váriavel/método.

    - Exemplo na prática:

        ```cs

            public diaSemana = 2;

        ```

    - O mesmo vale para `privado(privade)` ou `protegido(protected)`

## Classes

- O que é uma classe? 

    - Uma classe é nada mais nada menos que um agrupamento de código, com métodos e váriveis com funcionalidades generalista, criada pra solucionar ou inovar uma solução

    - A classe pode ser definida como `public`, `private` ou `protected`, isso se chama `Encapsulamento`.

    - A sintaxe para definir uma classe é a seguinte: 

        ```cs

            public class SuaClasse {
                public int diaSemana = 2; // sua várivel
                public void SuaFuncao()
                {
                     Debug.Log("Seu método foi criad0!");
                }
            }

        ```
    
    - Aqui no exemplo temos a nossa `classe` em `public`, nosso `método` e seu tipo `void` e nossa váriavel `diaSemana` com seu tipo `int` e `public`.

## Condicionais(if/else)

- O que são condicionais?

    - São o nosso `sim` ou `não`, nossa decisão, onde faremos decisões e comparações de código.

    - Utilizamos a palavra reversada `if` para se e `else` para se não

    - Exemplo na prática:

        ```cs
        
            using UnityEngine;

            public class ExemploIdade : MonoBehaviour
            {
                public int idade = 20;

                void Start()
                {
                    if (idade >= 18)
                    {
                        Debug.Log("Você tem mais de 18 anos");
                    }
                    else
                    {
                        Debug.Log("Sua idade é menor que 18 anos");
                    }
                }
            }


        ``` 
