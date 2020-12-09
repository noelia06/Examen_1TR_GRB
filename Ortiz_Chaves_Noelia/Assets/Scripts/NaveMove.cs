using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
    }

    void MoverNave()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
      
        float DesplZ = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * DesplZ);

        float DesplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * DesplX);

     


    }
}
