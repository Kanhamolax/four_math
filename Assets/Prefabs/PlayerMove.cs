using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float _velocidadeFrente;
    float _velocidadeTras;
    float _velocidadeGirar;
    // Start is called before the first frame update
    void Start()
    {
        _velocidadeFrente = 5;
        _velocidadeTras = 2;
        _velocidadeGirar = 60;
    }

    // Update is called once per frame
  

       
       

        //Metodo Start e executado uma unica vez, quando o script e executado.
       

        //Medodo Update e executado a cada Frame
        void Update()
        {
            if (Input.GetKey("w"))
            {
                transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
            }

            if (Input.GetKey("s"))
            {
                transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
            }

            if (Input.GetKey("a"))
            {
                transform.Rotate(0, (-_velocidadeGirar * Time.deltaTime), 0);
            }

            if (Input.GetKey("d"))
            {
                transform.Rotate(0, (_velocidadeGirar * Time.deltaTime), 0);
            }
           if (Input.GetKey(KeyCode.Space))
           {
                transform.Translate(0, (2* Time.deltaTime), 0);
           }
    }
}



