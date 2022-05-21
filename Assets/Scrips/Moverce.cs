using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// con este codigo damos movimiento al personaje masculino
public class Moverce : MonoBehaviour
{
    // variables de tipo trasnform para indicar hacia a donde queremos que camine el personaje
    public Transform target1, target2,Hombre;
    
    public NavMeshAgent nav;// se usa navMesh para indicar el movimiento del personaje 
    public Animator miAnim;
    bool primer= false;// target de tipo bool para indicar si ya pasamos de un traget al otro
    Quaternion angulo;// con cuaternion se establece un angulo para el personaje 

    void Start()
    {
        angulo = Hombre.rotation;// inicializacion del angulo 
    }

    
    void Update()
    {
        
        Seguir();
        //reconoce en que animacion esta el personaje y ejecuta el codigo
        if (miAnim.GetCurrentAnimatorStateInfo(0).IsName("sentarceSofaH"))
        {
            // angulo para el personaje 
            Hombre.transform.rotation = angulo;

            angulo.y = 90;
            angulo = Hombre.rotation;
            

        }
    }
    // usamos el metodo seguir para dar el punto al que el personaje se debe desplazar 
    void Seguir()
    {
        if (miAnim.GetCurrentAnimatorStateInfo(0).IsName("caminarH") & primer == false)
        {
            StartCoroutine(Target());// con la corrutina damos el target
            primer = true;
        }
       


    }
    // la corutina resetea el target para que el personaje tome el target 2 luego de cierto tiempo
    IEnumerator Target()
    {
        
        nav.SetDestination(target1.position);
        yield return new WaitForSeconds(1.2f);
        nav.SetDestination(target2.position);
        
    }
      
}
