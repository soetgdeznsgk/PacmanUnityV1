using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportadores : MonoBehaviour
{
    public BoxCollider2D TP1, TP2, _colisionador;
    public Vector2  posicionTP1, posicionTP2, objetivo;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }   

    void OnTriggerEnter2D(Collider2D otro) {
        _colisionador = otro.gameObject.GetComponent<BoxCollider2D>();

        if (_colisionador.IsTouching(TP1)){
            //Debug.Log("Choca TP1");
            objetivo = new Vector2(1.17f, -0.032f);
        }

        else if (_colisionador.IsTouching(TP2)){
            //Debug.Log("Choca TP2");
            objetivo = new Vector2(-1.07f, -0.032f);
        }
    }

    void OnTriggerExit2D(Collider2D otro) {

        otro.attachedRigidbody.position = objetivo;
    }
}
