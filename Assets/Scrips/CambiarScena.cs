using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiarScena : MonoBehaviour
{
    // Variable para dar el nombre de la escena a la que queremos cambiar  
    public string nombre;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    //Este metodo cambia de escena usando un collisionador trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mujer")
        {
            SceneManager.LoadScene(nombre);
        }
    }
}
