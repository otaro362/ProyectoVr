using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject correcto;
    public GameObject incorrecto;
    public GameObject[] botones; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Respuesta(int Respuesta)
    {
        switch (Respuesta)
        {
            case 1:
                correcto.SetActive(true);
                break;
            case 2:
                incorrecto.SetActive(true);
                break;
        }
    }
    public void BotonesRespuesta()
    {
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].SetActive(true);
        }
    }
    
}
