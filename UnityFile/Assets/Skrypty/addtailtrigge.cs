using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class addtailtrigge : MonoBehaviour
{
    public SnakeController SnakeController;
  
    public GameObject ball;
    public bool pojawieniesie = false;

    void pojawianie()
    {
        while (!pojawieniesie)
        {
            Vector3 pozycjakuli = new Vector3(Random.Range(-9f, 9f), 0.51f, Random.Range(-9f, 9f));
            if ((pozycjakuli - transform.position).magnitude < 2)
            {
                continue;
            }
            else
            {
                bool tocloase = false;

                foreach (var part in SnakeController.Cialo)
                {
                    if ((pozycjakuli - part.transform.position).magnitude < 2f)
                    {
                        tocloase = true;
                        break;
                    }
                }
                if (tocloase)
                {
                    continue;
                }
                Instantiate(ball, pozycjakuli, Quaternion.identity);
                pojawieniesie = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(ball);
            pojawianie();
            SnakeController.Zwiekszenie();
            PUNKTY.instance.AddPoint();
        }
       
    }
}
