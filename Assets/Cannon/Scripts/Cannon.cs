using UnityEngine;

public class Cannon : MonoBehaviour
{
	  // Propiedades
    public float spawnrate = 4f;
    public GameObject Bala;
    public float whenToStart = 1f;
    public bool dispara = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dispara)
        {
            dispara = false;
            Generator();
            Invoke("shoot",spawnrate);
        }
    }
    void Generator()
    {
        Instantiate(Bala, transform.position, transform.localRotation);
    }
    void shoot()
    {
        dispara = true;
    }
}


