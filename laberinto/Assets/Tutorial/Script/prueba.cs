using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour {

    private float VelMov = 5f;
    private float VelGiro = 20f;
    private bool avanzar = false;
    private bool girarIzq = false;
    private bool girarDer = false;
    
	// Use this for initialization
	void Start () {
		
	}


    private void FixedUpdate()
    {
        if (avanzar == true)
        {
            transform.Translate(Vector3.forward * VelMov * Time.deltaTime);
        }
        if (girarIzq == true)
        {
            transform.Rotate (Vector2.up * VelGiro * Time.deltaTime);
        }if (girarDer == true)
        {
            transform.Rotate(Vector2.down * VelGiro * Time.deltaTime);
        }
    }

    public void Avanzar()
    {
        avanzar = true;
    }

    public void DejarDeAvanzar()
    {
        avanzar = false;
    }

    public void GirarIzq ()
    {
        girarIzq = true;
    }

    public void GirarDer()
    {
        girarDer = true;
    }

    public void DejarDeGirar ()
    {
        girarDer = false;
        girarIzq = false;
    }

    // Update is called once per frame

	
}
