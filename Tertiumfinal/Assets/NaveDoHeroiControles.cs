using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // Para serializar nossa nova classe é preciso usar [System.Serializable] - armazenar o objeto na memória e transfere informações.

public class Classe_Fronteira // Classes organizam código, reduzem repetição de código, simplificam a manutenção.
{
    public float xMin, xMax, zMin, zMax;
}

//Unity User Manual - https://docs.unity3d.com/Manual/index.html
//Documentação do C# - https://docs.microsoft.com/pt-br/dotnet/csharp/


public class NaveDoHeroiControles : MonoBehaviour   
{

    public Classe_Fronteira fronteira;


   

    private Vector3 PosicaoTouch; 
    private Rigidbody Fisica; 
    private Vector3 Direcao; 
    public float VelocidadeMover; 




    public float velocidade; 
    public float inclinar;
    public GameObject Tiro;  
    public GameObject TiroTriplo;
    public Transform posicao_do_tiro; 
    public float taxa_de_fogo;
    private float proximo_tiro;

    
    public static NaveDoHeroiControles instance; 


    public bool TiroTriploAtivar;



    





    
    private void Awake() 
    {
        instance = this; 
    }






    
    private void Start()
    {
        Fisica = GetComponent<Rigidbody>(); 
    }







    void Update()
    {
      

        if (Input.GetButton("Fire1") && Time.time > proximo_tiro)
        {
            if (!TiroTriploAtivar)
            {
                Instantiate(Tiro, posicao_do_tiro.position, posicao_do_tiro.rotation); 
            }
            else
            {
                Instantiate(TiroTriplo, posicao_do_tiro.position, posicao_do_tiro.rotation);
            }

            proximo_tiro = Time.time + taxa_de_fogo;
            
        }
    }



    void FixedUpdate()
    {

        float MoverNaHorizontal2 = Input.GetAxis("Horizontal"); 
        float MoverNaVertical2 = Input.GetAxis("Vertical"); 

        Vector3 movimento2 = new Vector3(MoverNaHorizontal2, 0, MoverNaVertical2);
        GetComponent<Rigidbody>().velocity = movimento2 * velocidade;



        GetComponent<Rigidbody>().position = new Vector3
        (Mathf.Clamp(GetComponent<Rigidbody>().position.x, fronteira.xMin, fronteira.xMax), 0, Mathf.Clamp(GetComponent<Rigidbody>().position.z, fronteira.zMin, fronteira.zMax));
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, GetComponent<Rigidbody>().velocity.x * -inclinar);


    }
}

