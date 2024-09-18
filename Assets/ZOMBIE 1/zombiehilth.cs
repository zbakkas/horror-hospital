using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombiehilth : MonoBehaviour
{
    public Animator anim;
    public float hilth = 100f;

    public Slider hilthpar;

    //public GameObject lotammo;
   // public GameObject slaiddisplaye;


    //public CapsuleCollider Capsule;
    private void Start()
    {
        //lotammo.SetActive(false);
        //Capsule = GetComponent<CapsuleCollider>();
    }

    public void Update()
    {
        hilthpar.value = hilth;

    }

    public void hilthpins(float damage)
    {
        hilth -= damage;
        if (hilth <= 0)
        {
            //slaiddisplaye.SetActive(false);
            anim.SetBool("mwt", true);
            Destroy(gameObject, 4f);
            //lotammo.SetActive(true);
            //Capsule.isTrigger = true;
        }
    }
}
