using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
 //Propiedades
    public float velocidad = 2f;
    public float TimetoDie = 3f;
    public Vector3 direction = new Vector3(0, 0, 3);
    public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * velocidad * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2;
        }

        Destroy(gameObject, TimetoDie);
       
        
    }

}


