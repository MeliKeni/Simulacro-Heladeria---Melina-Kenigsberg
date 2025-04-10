using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public string codigoSabor;
    public float cantidadHelado;
    float costo;
    float descuento = 0.9f;
    float precioPorKilo = 500;

    void Start()
    {
        if (codigoSabor != "DDL" && codigoSabor != "CHO" && codigoSabor != "FRU" || cantidadHelado < 250 || cantidadHelado > 3000)
        {
            
                Debug.Log("El gusto ingresado o la cantidad de helado pedida son incorrectos");
                return;
            
        }    else
        {

            costo = cantidadHelado/1000 * precioPorKilo;

            if (codigoSabor == "FRU")
            {
                costo = costo * descuento;
            }

            Debug.Log("El costo es de " + costo + "$");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
