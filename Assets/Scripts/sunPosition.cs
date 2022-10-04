using UnityEngine;

public class sunPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.1f, 0); // con esto giro al sol
    }
}
