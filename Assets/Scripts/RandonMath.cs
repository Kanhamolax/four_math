using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandonMath : MonoBehaviour
{
    public string[] contasF,contasM,contasD,respF,respM,respD;
    public string[] erradasF1, erradasF2, erradasF3, erradasF4;
    public string[] erradasM1, erradasM2, erradasM3, erradasM4;
    public string[] erradasD1, erradasD2, erradasD3, erradasD4;
    public Material q1, q2, q3;
    public GameObject p1, p2;
    public TextMeshProUGUI[] bq1, bq2, bq3;
    public TextMeshProUGUI conta1, conta2, conta3,acertou1, acertou2, acertou3;
  
    int range;

    // Start is called before the first frame update

    void Start()
    {
        q1.color = Color.red;
        q2.color = Color.red;
        q3.color = Color.red;
        DataControler.okp1 = true;

    }
    void Update()
    {
        if(q1.color==Color.green && q2.color == Color.green&& q3.color == Color.green&&DataControler.okp1)
        {
            StartCoroutine(WaitChangeCollor());
            DataControler.okp1 = false;

        }
        
    }
    public void Facil()
    {
       range = Random.Range(0, 4);
       conta1.text= contasF[range];
        DataControler.valorCorreto = respF[range];
        acertou1.text = "";

        switch (range) 
        {
            case 0:
                for (int i = 0; i < 4; i++)
                {
                    bq1[i].text = erradasF1[i];

                }
                bq1[range].text = respF[range];

                break;

            case 1:
                for (int i = 0; i < 4; i++)
                {
                    bq1[i].text = erradasF2[i];

                }
                bq1[range].text = respF[range];
                break;
            case 2:
                for (int i = 0; i < 4; i++)
                {
                    bq1[i].text = erradasF3[i];

                }
                bq1[range].text = respF[range];

                break;
            case 3:
                for (int i = 0; i < 4; i++)
                {
                    bq1[i].text = erradasF4[i];

                }
                bq1[range].text = respF[range];
                break;
        }
        bq1[range].text = respF[range];


    }

    public void Medio()
    {
        range = Random.Range(0, 4);
        conta2.text = contasM[range];
        DataControler.valorCorreto = respM[range];
        acertou2.text = "";

        switch (range)
        {
            case 0:
                for (int i = 0; i < 4; i++)
                {
                    bq2[i].text = erradasM1[i];

                }
                bq2[range].text = respM[range];

                break;

            case 1:
                for (int i = 0; i < 4; i++)
                {
                    bq2[i].text = erradasM2[i];

                }
                bq2[range].text = respM[range];
                break;
            case 2:
                for (int i = 0; i < 4; i++)
                {
                    bq2[i].text = erradasM3[i];

                }
                bq2[range].text = respM[range];
                break;
            case 3:
                for (int i = 0; i < 4; i++)
                {
                    bq2[i].text = erradasM4[i];

                }
                bq2[range].text = respM[range];
                break;
        }


    }

    public void Dificil()
    {
        range = Random.Range(0, 4);
        conta3.text = contasD[range];
        DataControler.valorCorreto = respD[range];
        acertou3.text = "";

        switch (range)
        {
            case 0:
                for (int i = 0; i < 4; i++)
                {
                    bq3[i].text = erradasD1[i];

                }
                bq3[range].text = respD[range];

                break;

            case 1:
                for (int i = 0; i < 4; i++)
                {
                    bq3[i].text = erradasD2[i];

                }
                bq3[range].text = respD[range];
                break;
            case 2:
                for (int i = 0; i < 4; i++)
                {
                    bq3[i].text = erradasD3[i];

                }
                bq3[range].text = respD[range];
                break;
            case 3:
                for (int i = 0; i < 4; i++)
                {
                    bq3[i].text = erradasD4[i];

                }
                bq3[range].text = respD[range];
                break;
        }


    }
    public void CorretorF(int op)
    {
        switch (op) 
        {
            case 1:
                Debug.Log(DataControler.valorCorreto + "--" + bq1[0].text);
                if (DataControler.valorCorreto == bq1[0].text)
                {
                    q1.color = Color.green;
                    acertou1.text = "Acertou";
                }
                else
                {
                    acertou1.text = "Errou";
                }
                break;
            case 2:
                Debug.Log(DataControler.valorCorreto + "--" + bq1[1].text);
                if (DataControler.valorCorreto == bq1[1].text)
                {
                    q1.color = Color.green;
                    acertou1.text = "Acertou";
                }
                else
                {
                    acertou1.text = "Errou";
                }
                break;
            case 3:
                Debug.Log(DataControler.valorCorreto + "--" + bq1[2].text);
                if (DataControler.valorCorreto == bq1[2].text)
                {
                    q1.color = Color.green;
                    acertou1.text = "Acertou";
                }
                else
                {
                    acertou1.text = "Errou";
                }
                break;
            case 4:
                Debug.Log(DataControler.valorCorreto + "--" + bq1[3].text);
                if (DataControler.valorCorreto == bq1[3].text)
                {
                    q1.color = Color.green;
                    acertou1.text = "Acertou";
                }
                else
                {
                    acertou1.text = "Errou";
                }
                break;
        }

    }

    public void CorretorM(int op)
    {
        switch (op)
        {
            case 1:
                Debug.Log(DataControler.valorCorreto + "--" + bq2[0].text);
                if (DataControler.valorCorreto == bq2[0].text)
                {
                    q2.color = Color.green;
                    acertou2.text = "Acertou";
                }
                else
                {
                    acertou2.text = "Errou";
                }
                break;
            case 2:
                Debug.Log(DataControler.valorCorreto + "--" + bq2[1].text);
                if (DataControler.valorCorreto == bq2[1].text)
                {
                    q2.color = Color.green;
                    acertou2.text = "Acertou";
                }
                else
                {
                    acertou2.text = "Errou";
                }
                break;
            case 3:
                Debug.Log(DataControler.valorCorreto + "--" + bq2[2].text);
                if (DataControler.valorCorreto == bq2[2].text)
                {
                    q2.color = Color.green;
                    acertou2.text = "Acertou";
                }
                else
                {
                    acertou2.text = "Errou";
                }
                break;
            case 4:
                Debug.Log(DataControler.valorCorreto + "--" + bq2[3].text);
                if (DataControler.valorCorreto == bq2[3].text)
                {
                    q2.color = Color.green;
                    acertou2.text = "Acertou";
                }
                else
                {
                    acertou2.text = "Errou";
                }
                break;
        }

    }


    public void CorretorD(int op)
    {
        switch (op)
        {
            case 1:
                Debug.Log(DataControler.valorCorreto + "--" + bq3[0].text);
                if (DataControler.valorCorreto == bq3[0].text)
                {
                    q3.color = Color.green;
                    acertou3.text = "Acertou";
                }
                else
                {
                    acertou3.text = "Errou";
                }
                break;
            case 2:
                Debug.Log(DataControler.valorCorreto + "--" + bq3[1].text);
                if (DataControler.valorCorreto == bq3[1].text)
                {
                    q3.color = Color.green;
                    acertou3.text = "Acertou";
                }
                else
                {
                    acertou3.text = "Errou";
                }
                break;
            case 3:
                Debug.Log(DataControler.valorCorreto + "--" + bq3[2].text);
                if (DataControler.valorCorreto == bq3[2].text)
                {
                    q3.color = Color.green;
                    acertou3.text = "Acertou";
                }
                else
                {
                    acertou3.text = "Errou";
                }
                break;
            case 4:
                Debug.Log(DataControler.valorCorreto + "--" + bq3[3].text);
                if (DataControler.valorCorreto == bq3[3].text)
                {
                    q3.color = Color.green;
                    acertou3.text = "Acertou";
                }
                else
                {
                    acertou3.text = "Errou";
                }
                break;
        }

    }
    IEnumerator WaitChangeCollor()
    {
        yield return new WaitForSeconds(2);
        p1.transform.Rotate(0, 90, 0);
        p2.transform.Rotate(0, -90, 0);
        q1.color = Color.white;
        q2.color = Color.white;
        q3.color = Color.white;

    }
}
