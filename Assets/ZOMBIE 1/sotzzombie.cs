using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sotzzombie : MonoBehaviour
{
    public AudioSource dakhl;


    public AudioSource kharj;

    public AudioSource atttack;

    public AudioSource mwt;

    public flomov z;
    public zombiehilth h;

    public bool f = false;
    public bool j = false;
    public bool d = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (z.distoplayer < z.chaserenge && f == true && h.hilth > 0)
        {
            f = false;

            kharj.mute = true;


        }
        else if (z.distoplayer > z.chaserenge && f == false && h.hilth > 0)
        {
            f = true;
            j = false;

            dakhl.mute = true;
            atttack.mute = true;

            //Debug.Log("khraaaj");
            kharj.mute = false;
            kharj.Play();

        }


        if (z.distoplayer > z.chaserengeattack && j == false && f == false && h.hilth > 0)
        {
            atttack.mute = true;
            j = true;
            dakhl.mute = false;
            //Debug.Log("dkhl");
            dakhl.Play();
        }
        else if (j == true && z.distoplayer < z.chaserengeattack && h.hilth > 0)
        {
            atttack.mute = false;
            atttack.Play();
            //Debug.Log("attack");
            dakhl.mute = true;
            j = false;
        }
        if (h.hilth <= 0)
        {
            
            dakhl.mute = true;
            kharj.mute = true;
            atttack.mute = true;
            if (d == false)
            {
                d = true;
                mwt.Play();
                
            }
        }
    }
    /*
    z.dakhl.mute = true;
            z.kharj.mute = true;
            z.atttack.mute = true;
            mwt.Play();*/
}