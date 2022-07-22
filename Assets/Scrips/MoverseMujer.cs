using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverseMujer : MonoBehaviour
{
    // variables de tipo trasnform para indicar hacia a donde queremos que camine el personaje
    public Transform target1, target2, target3;


    public NavMeshAgent nav;
    public Animator miAnim;

    private bool target;// target de tipo bool para indicar si ya pasamos de un traget al otro
    public float Tiempo1, tiempo2; // indica el tiempo en el que debe cambiar de posicion el personaje 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Vector3.Distance(this.gameObject.transform.position, target1.position));
        // un metodo if para que el personaje se mueva unicamente cuando se esté en la animación de caminar
        if (miAnim.GetCurrentAnimatorStateInfo(0).IsName("Caminar") && target == false)
        {
            nav.SetDestination(target1.position);// se le indica con el componente navMes a que punto debe desplazarce 
            //StartCoroutine(prueba());// la corrutina indica el true de que el target 1 ya fue tomado
            Debug.Log(Vector3.Distance(this.gameObject.transform.position, target1.position));
        }
        if (target == true)// si ya hay un primer target, con este metodo pasa al segundo target 
        {
            nav.SetDestination(target2.position);
            //StartCoroutine(Target2()); // esta corrutina indica el tiempo en el que cabiara de target
        }
        if (Vector3.Distance(this.gameObject.transform.position, target1.position) < 1)
        {
            miAnim.SetBool("LavarPlatos", true);
        }

    }
    // corrutina para pasar al target 2
    IEnumerator prueba()
    {
        yield return new WaitForSeconds(Tiempo1);
        target = true;
    }
    // corrutina para el tiempo en el que se cambia de target 
    IEnumerator Target2()
    {
        yield return new WaitForSeconds(tiempo2);
        target = false;
        nav.SetDestination(target3.position);
    }
}
