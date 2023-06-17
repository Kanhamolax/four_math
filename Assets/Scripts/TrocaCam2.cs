using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaCam2 : MonoBehaviour
{
    public GameObject player,camPlayer,camProf, camQ1,camQ2,camQ3;
    public Transform spot1, spot2, spot3;
   
    // Start is called before the first frame update
   public void TrocaCamera()
    {
        camPlayer.SetActive(false);
        camProf.SetActive(true);
        DataControler.movePermition = false;

    }

    public void TrocaCameraMove(int op)
    {
        DataControler.movePermition = false;
        if (op==1)
        {
            player.transform.position = spot1.position;
            player.transform.rotation= spot1.rotation;
            camProf.SetActive(false);
            camQ1.SetActive(true) ;
        }
        else if (op==2) 
        {

            player.transform.position = spot2.position;
            player.transform.rotation = spot2.rotation;
            camProf.SetActive(false);
            camQ2.SetActive(true);

        }
        else if (op==3)
        {

            player.transform.position = spot3.position;
            player.transform.rotation = spot3.rotation;
            camProf.SetActive(false);
            camQ3.SetActive(true);
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


            camQ1.SetActive(false);
            camPlayer.SetActive(true);
        }
        else if (op == 2)
        {

            camQ2.SetActive(false);
            camPlayer.SetActive(true);

        }
        else if (op == 3)
        {

            camQ3.SetActive(false);
            camPlayer.SetActive(true);
        }
    }
}
