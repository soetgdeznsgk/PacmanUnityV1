using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoChiquito : MonoBehaviour
{
    GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D Collider){

        if (Collider.gameObject.CompareTag("Player")) {
            Destroy(gameObject);}
    }
}
