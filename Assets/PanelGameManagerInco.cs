using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGameManagerInco : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.correcto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
