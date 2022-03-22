using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unity User Manual - https://docs.unity3d.com/Manual/index.html
//Documentação do C# - https://docs.microsoft.com/pt-br/dotnet/csharp/

public class Movendo_Tiro : MonoBehaviour
{
    public float VelocidadeTiro;

    void Start()
    {

        GetComponent<Rigidbody>().velocity = transform.forward * VelocidadeTiro;
    }
}