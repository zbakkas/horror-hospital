using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katanadamag : MonoBehaviour
{
    float damage;
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "b" )
        {
            Debug.Log("b");
            damage = 10;
            zombiehilth z = other.GetComponentInParent<zombiehilth>();
            z.hilthpins(damage);
        }
        else if (other.gameObject.tag == "h")
        {
            Debug.Log("h");
            damage = 20;
            zombiehilth z = other.GetComponentInParent<zombiehilth>();
            z.hilthpins(damage);
        }
        else if (other.gameObject.tag == "r" )
        {
            Debug.Log("r");
            damage = 5;
            zombiehilth z = other.GetComponentInParent<zombiehilth>();
            z.hilthpins(damage);
        }

    }
}
