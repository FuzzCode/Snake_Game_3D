using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour {


    public float Predkosc_por = 5;

    public float BodySpeed = 5;
    public int odleglosc = 15;

    bool blokadaLW = true;
    bool blokadaGD = false;

    public GameObject BlokCiala;


    public List<GameObject> Cialo = new List<GameObject>();
    public List<Vector3> Pozycja = new List<Vector3>();


    void Start() {
        Zwiekszenie();
    }


    void FixedUpdate()
    {
        transform.position += transform.forward * Predkosc_por * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.LeftArrow) && blokadaLW == true)
        {
            float degrees = -90;
            Vector3 to = new Vector3(0, degrees, 0);
            transform.eulerAngles = (to);
            blokadaLW = false;
            blokadaGD = true;
        }
        if (Input.GetKey(KeyCode.RightArrow) && blokadaLW == true)
        {
            float degrees = 90;
            Vector3 to = new Vector3(0, degrees, 0);
            transform.eulerAngles = (to);
            blokadaLW = false;
            blokadaGD = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) && blokadaGD == true)
        {
            float degrees = 0;
            Vector3 to = new Vector3(0, degrees, 0);
            transform.eulerAngles = (to);
            blokadaLW = true;
            blokadaGD = false;
        }
        if (Input.GetKey(KeyCode.DownArrow) && blokadaGD == true)
        {
            float degrees = -180;
            Vector3 to = new Vector3(0, degrees, 0);
            transform.eulerAngles = (to);
            blokadaLW = true;
            blokadaGD = false;
        }


        Pozycja.Insert(0, transform.position);

        int index = 0;
        foreach (var body in Cialo)
        {
            Vector3 point = Pozycja[(index * odleglosc)];

            Vector3 moveDirection = point - body.transform.position;
           body.transform.position += moveDirection * BodySpeed * Time.deltaTime;

            body.transform.LookAt(point);
            index++;
        }



    }

        public void Zwiekszenie() {

            
            GameObject body = Instantiate(BlokCiala);
            Cialo.Add(body);

        }
   


} 



