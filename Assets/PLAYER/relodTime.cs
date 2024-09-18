using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relodTime : MonoBehaviour
{
    public bool relod = false;
    public float timeWoapen;
    public WOAPENdesplay woapen;
    public ammo amo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (woapen.ISferdi)//pistol
        {
            timeWoapen = 1.18f;
        }
        if (woapen.ISGAUN)//M16
        {
            timeWoapen = 2.47f;
        }
        if (woapen.isshootgan)//SHOTGUN
        {
            timeWoapen = 2.22f;
        }
        if (woapen.issnaiper)//SNAIPER
        {
            timeWoapen = 4.04f;
        }

        if ((Input.GetKeyDown(KeyCode.R) && (amo.relodPistol == true || amo.relodM16 == true || amo.relodShotgun == true || amo.relodSniper == true)))
        {
            relod = true;
            StartCoroutine(relodttime());
        }
        else if (amo.pistolrelod0==true || amo.m16relod0 ==true || amo.sniperrelod0==true || amo.shotgunrelod0==true)
        {
            
            relod = true;
            StartCoroutine(relodttime());
        }

    }
    IEnumerator relodttime()
    {
        yield return new WaitForSeconds(timeWoapen);
        relod = false;
    }
}
