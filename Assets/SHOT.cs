using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOT : MonoBehaviour
{
    Ray ay;
    RaycastHit hit;
    public Transform rayorigiFRDI;
    public Transform raydistin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {

            ay.origin = rayorigiFRDI.position;
            ay.direction = raydistin.position - rayorigiFRDI.position;
            if (Physics.Raycast(ay, out hit))
            {
                Debug.DrawLine(ay.origin, hit.point, Color.red, 1f); //khat mkan rasasa
                                                                     //
                if (hit.collider.GetComponent<BOOX>())
                {
                    Debug.Log("shoot");
                }




            }
            if (Input.GetButtonUp("Fire1"))
            {
                //isfire = false;
            }
        }
    }
}
