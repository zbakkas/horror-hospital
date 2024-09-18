using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class foloPlayer : MonoBehaviour
{
    public float chaserenge;
    public float chaserengeattack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, chaserenge);
        Gizmos.DrawWireSphere(transform.position, chaserengeattack);
    }
}
