# Rpg IFRN

## Dependências 

- Unity version 2021.3.45f1
- C#

## Índice

1. [Introdução](#introdução)
2. [Variaveis e Métodos](#variaveis-métodos-e-tipos)
3. [Classes](#classes)
4. [Condicionais(if/else)](#condicionaisifelse)
5. [Condicionais com switch/case](#condicionais-com-switchcase)
6. [For, Foreach e Array](#for-foreach-e-array)


---

## Estrutura do projeto

```bash

IFRN RPG/
├── .vscode
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

            public int diaSemana = 2;

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

## Condicionais com switch/case

- O são condicionais com switch/case?
    
    - Na verdade é algo super simples e prática, sabe aquele seu código cheio de `if` e `else` para validar ou verificar algo? Pode ser "simplificado", já que ainda terá várias verificações mas crio que com menos linhas utilizando o `switch/case`.

    - Com `switch/case` podemos deixar a quantidade de linhas de verificações menores, segue o exemplo:

        ```cs

            using UnityEngine;

            public class Switch_case : MonoBehaviour {
                
                public int idade = 17;

                void start(){
                    // Sintaxe do switch case
                    switch(idade);
                        case 16:
                            Debug.Log("Sua idade é 16 anos");
                            break;
                        case 17:
                            Debug.Log("Sua idade é 17 anos");
                            break;
                        case 18:
                            Debug.Log("Sua idade é 18 anos");
                            break;
                        default:
                            Debug.Log("Sua idade não é 16, 17 nem 18.");
                            break;
                }
            }

        ```
    
    - Resultado:

        - Vale resaltar que no `switch/case` possuímos o valor `default`, que podemo definir como se fosse um `else`.

        - O `switch/case` não aceita operadores lógicos.

## For, Foreach e Array

- O que são laços de repetição?`for` e `foreach`

- Laço de repetição é uma estrutura que execulta uma conjunto e instruções definidas, até todas as condições serem concluídas o laço continua se repetindo até concluír as instruções impostas.

- Como funciona o `for`?

    - Funciona de uma forma simples, vamos supor que você sabe quantas vezes a estrutura de código dentro do `for` vai se repetir, para isso temos a váriavel chamada contador, geralmente representada por um `i` que vai se repetir x vezes, ou seja, definimos nosso `i=5` ele vai se repetir 5 vezes. A condição de parada, que quando o laço concluír nossa condição ele deve parar. Váriavel incrementador serve para incrementar todas vez que o código rodar, exemplo, se o `i=5` vai rodar 5 vezes, ao final do primeiro laço nossa váriavel vai incrementar que o laço foi rodado 1 vez, assim atualizando nossa váriavel contador que inicialmente era 5 e vai passar a ser `i=4`, vale resltar que nossa `i` é tanto nossa váriavel contador, condição de parada como inteirador.

    - Exemplo na prática:

        ```cs

        using UnityEngine;

        public class Testfor : MonoBehaviour{

            void start(){
                public int result;
                public int soma = 1;

                for(i = 5; i < 10; i++){
                    result = soma++
                    Debug.Log("soma + " + result)
                }
            }
        }

        ```