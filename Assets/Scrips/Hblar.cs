using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
// este codigo se usa para dar voz a los personajes por medio del audio source
public class Hblar : MonoBehaviour
{
    // declaramos las variables necesarias para que el programa reconozca los audios que vamos a reproducir 
    public AudioSource vozH,vozM;
    // el animator lo usaremos para  con cada corrutina usar los parametros del animator 
    public Animator Hombre,mujer;
    public AudioClip vozH2;
    // declaramos un int para reconocer en que escena se va a ejecutar el codigo 
    public int nivel;
    
    void Start()
    {
        // usamos metodos if para diferenciar entre las diferentes escenas y segun la escena ejecutar la corrutina
        if (nivel == 1)
        {
            StartCoroutine(ComenzarVoz());
            StartCoroutine(Siguiente());

        }
        if (nivel == 2)
        {
            StartCoroutine(Siguiente2());
        }
        if (nivel == 3)
        {
            StartCoroutine(Siguiente3());
        }
        if (nivel == 4)
        {
            StartCoroutine(Siguiente4());
        }
        if (nivel == 5)
        {
            StartCoroutine(Siguiente5());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Usamos corrutinas para dar inicio a los audios y animaciones, segun la escena se usa
    // una corrutina distinta ya que los dialogos son distintos 
    IEnumerator ComenzarVoz()
    {
        yield return new WaitForSeconds(0.03f);
        vozH.Play();
        yield return new WaitForSeconds(35f);
        mujer.SetBool("enojo", true);
        yield return new WaitForSeconds(0.1f);
        vozM.Play();
        yield return new WaitForSeconds(10f);
        vozH.clip = vozH2;
        vozH.Play();
        
    }
    IEnumerator Siguiente()
    {
        yield return new WaitForSeconds(3f);
        Hombre.SetBool("Siguiente", true);
        yield return new WaitForSeconds(0.2f);
        Hombre.SetBool("Siguiente", false);
        yield return new WaitForSeconds(8f);
        Hombre.SetBool("siguiente2", true);
    }
    IEnumerator Siguiente2()
    {
        yield return new WaitForSeconds(0.03f);
        vozH.Play();
        Hombre.SetBool("Siguiente", true);
        yield return new WaitForSeconds(0.3f);
        Hombre.SetBool("Siguiente", false);
        yield return new WaitForSeconds(8f);
        Hombre.SetBool("siguiente2", true);
        yield return new WaitForSeconds(14f);
        vozM.Play();
    }
    IEnumerator Siguiente3()
    {
        yield return new WaitForSeconds(0.03f);
        vozH.Play();
        yield return new WaitForSeconds(3f);
        Hombre.SetBool("Siguiente", true);
        yield return new WaitForSeconds(0.2f);
        Hombre.SetBool("Siguiente", false);
        yield return new WaitForSeconds(8f);
        Hombre.SetBool("siguiente2", true);

    }
    IEnumerator Siguiente4()
    {
        yield return new WaitForSeconds(4f);
        vozM.Play();
    }
    IEnumerator Siguiente5()
    {
        vozM.Play();
        yield return new WaitForSeconds(33f);
        vozH.Play();
    }
}
