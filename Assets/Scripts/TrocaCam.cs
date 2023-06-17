using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaCam : MonoBehaviour
{
    public GameObject player,camPlayer;
    public GameObject[] camProf, camQ1, camQ2, camQ3;
    public Transform[] spot1, spot2, spot3;
   
    // Start is called before the first frame update
   public void TrocaCamera()
    {
        camPlayer.SetActive(false);
        camProf[DataControler.prof].SetActive(true);
        DataControler.movePermition = false;

    }

    public void TrocaCameraMove(int op)
    {
        DataControler.movePermition = false;
        if (op==1)
        {
            player.transform.position = spot1[DataControler.prof].position;
            player.transform.rotation= spot1[DataControler.prof].rotation;
            camProf[DataControler.prof].SetActive(false);
            camQ1[DataControler.prof].SetActive(true) ;
        }
        else if (op==2) 
        {

            player.transform.position = spot2[DataControler.prof].position;
            player.transform.rotation = spot2[DataControler.prof].rotation;
            camProf[DataControler.prof].SetActive(false);
            camQ2[DataControler.prof].SetActive(true);

        }
        else if (op==3)
        {

            player.transform.position = spot3[DataControler.prof].position;
            player.transform.rotation = spot3[DataControler.prof].rotation;
            camProf[DataControler.prof].SetActive(false);
            camQ3[DataControler.prof].SetActive(true);
        } 

    }
    public void VoltaCamPlayer(int op)
    {
        DataControler.movePermition = true;
       StartCoroutine(WaitChange(op));  

    }

    IEnumerator WaitChange(int op)
    {
        yield return new WaitForSeconds(2);
        if (op == 1)
        {


            camQ1[DataControler.prof].SetActive(false);
            camPlayer.SetActive(true);
        }
        else if (op == 2)
        {

            camQ2[DataControler.prof].SetActive(false);
            camPlayer.SetActive(true);

        }
        else if (op == 3)
        {

            camQ3[DataControler.prof].SetActive(false);
            camPlayer.SetActive(true);
        }
    }
}
