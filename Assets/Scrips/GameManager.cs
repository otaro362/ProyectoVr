using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject correcto;
    public GameObject incorrecto;
    public List<GameObject> botones=new List<GameObject>(); 
    // Start is called before the first frame update
    void Start()
    {
        correcto = GameObject.Find("Player/XR Origin/Camera Offset/LeftHand Controller/Canvas/PanelCorrect");
        incorrecto=GameObject.Find("Player/XR Origin/Camera Offset/LeftHand Controller/Canvas/PanelIncorrect");
        botones.Add(GameObject.Find("Player/XR Origin/Camera Offset/LeftHand Controller/Canvas/PasivoAgresivo"));
        botones.Add(GameObject.Find("Player/XR Origin/Camera Offset/LeftHand Controller/Canvas/Asertiva"));
        botones.Add(GameObject.Find("Player/XR Origin/Camera Offset/LeftHand Controller/Canvas/Pasivo"));
        botones.Add(GameObject.Find("Player/XR Origin/Camera Offset/LeftHand Controller/Canvas/Agresivo"));
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
    public void ActPanel()
    {
        correcto.SetActive(true);
    }
    public void BotonesRespuesta()
    {
        for (int i = 0; i < botones.Count; i++)
        {
            botones[i].SetActive(true);
        }
    }
    public void DesBotones()
    {
        for (int i = 0; i < botones.Count; i++)
        {
            botones[i].SetActive(false);
        }
    }

    
}
