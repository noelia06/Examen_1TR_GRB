using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NaveMove : MonoBehaviour
{
    public float speed;
    [SerializeField] Text Alerta;

    bool AlertaText = false;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
        UIAlerta();
    }

    void MoverNave()
    {
        

        float DesplZ = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * DesplZ);

        float DesplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * DesplX);

        
        

    }
     public void UIAlerta()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;

        Alerta.text = "ALERTA";
        if (posX<198f && -198f>posX || posZ<94f && -94f > posZ)
        {
            AlertaText = true;
        }

        else if (posX > 198f && -198f < posX || posZ > 94f && -94f < posZ)
        {
            AlertaText = true;
           
        }
    }
    

    
}

