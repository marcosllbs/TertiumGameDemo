using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unity User Manual - https://docs.unity3d.com/Manual/index.html
//Documentação do C# - https://docs.microsoft.com/pt-br/dotnet/csharp/

public class MoverBackground : MonoBehaviour 
{
    public float VelocidadeDaRolagem = 1; // Declarações de variáveis.
    public float juncao = 1
       ;
    private Vector3 PosicaoInicial; /* Vector3 -- Representação de vetores e pontos 3D.
         Essa estrutura é usada em todo o Unity para passar posições e direções 3D. Ele também contém funções para executar operações vetoriais comuns.*/

    void Start()
    {
        PosicaoInicial = transform.position; // = Atribuição 
    }

    void Update()
    {
        float NovaPosicao = Mathf.Repeat(Time.time * VelocidadeDaRolagem, -juncao);
        transform.position = PosicaoInicial + Vector3.forward * NovaPosicao;
    }
}
