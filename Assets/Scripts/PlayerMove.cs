using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject porta;
    float _velocidadeFrente;
    float _velocidadeTras;
    float _velocidadeGirar;
    // Start is called before the first frame update
    void Start()
    {
        _velocidadeFrente = 5;
        _velocidadeTras = 2;
        _velocidadeGirar = 60;
        DataControler.movePermition = true;
    }

    // Update is called once per frame
  

       
       

        //Metodo Start e executado uma unica vez, quando o script e executado.
       

        //Medodo Update e executado a cada Frame
        void Update()
        {
                Move();
        }

    void Move()
    {
        if(DataControler.movePermition)
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
          
        }

    }
}



