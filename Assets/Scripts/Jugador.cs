using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Entidad
{
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    public override void Update()
    {
        if (_vivo){
            base.Update();
            if (Input.GetKeyDown(KeyCode.UpArrow)){
                IrArriba();
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow)){
                IrAbajo();
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow)){
                IrIzq();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)){
                IrDer();
            }
        }
    }

    public void Morir(){
        _anim.Play("jMuerte");
        _vivo = false;
        Invoke("selfDestruct", 0.85f);
    }

    private void selfDestruct(){
        Destroy(gameObject);
    }

}
