using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfOptions : MonoBehaviour
{
    public GameObject player,botao;
    public int nProf;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {

          botao.SetActive(true);
            DataControler.prof = nProf;



        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == player)
        {


            botao.SetActive(false);

        }
    }

   
}
