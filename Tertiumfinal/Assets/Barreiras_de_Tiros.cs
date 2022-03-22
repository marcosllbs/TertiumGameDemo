using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unity User Manual - https://docs.unity3d.com/Manual/index.html
//Documentação do C# - https://docs.microsoft.com/pt-br/dotnet/csharp/

public class Barreiras_de_Tiros : MonoBehaviour
{

   
    void OnTriggerExit(Collider Tiros) 
    {
        Destroy(Tiros.gameObject); 
    }
}

