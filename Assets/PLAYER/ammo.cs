using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float amoofrdi;
    public float maxamoofrdi ;
    public GameObject amooGOfrdi;

    public float amoogun ;
    public float maxamoogun ;
    public GameObject amooGOgun;

    public float amooshotgun ;
    public float maxamooshorgan ;
    public GameObject amooGOshtgun;

    public float amoosnaiper ;
    public float maxamoosnaiper;
    public GameObject amooGOsnaiper;

    public int ziadaamofrdi;
    public int ziadaamogun;
    public int ziadaamoshotgan;
    public int ziadaamosnaiper;
    public WOAPENdesplay wopen;

    //
    public float Amoofrdi = 15;
    public int Maxamoofrdi = 30;

    public float Amoogun = 40;
    public int Maxamoogun = 80;

    public float Amooshotgun = 5;
    public int Maxamooshorgan = 10;

    public float Amoosnaiper = 10;
    public int Maxamoosnaiper = 10;

    public bool relodPistol = false;
    public bool relodM16 = false;
    public bool relodShotgun =false;
    public bool relodSniper =false;

    public bool pistolrelod = false;
    public bool m16relod = false;
    public bool sniperrelod = false;
    public bool shotgunrelod = false;

    public bool pistolrelod0 = false;
    public bool m16relod0 = false;
    public bool sniperrelod0 = false;
    public bool shotgunrelod0 = false;
    // Start is called before the first frame update
    void Start()
    {
        amoofrdi = Amoofrdi;
        maxamoofrdi = Maxamoofrdi;

        amoogun = Amoogun;
        maxamoogun = Maxamoogun;

        amooshotgun = Amooshotgun;
        maxamooshorgan = Maxamooshorgan;

        amoosnaiper = Amoosnaiper;
        maxamoosnaiper = Maxamoosnaiper;
    }

    // Update is called once per frame
    void Update()
    {

        if (wopen.isslah == true)
        {
            if (amoofrdi == 0 && maxamoofrdi > 0)
            {
                pistolrelod0 = true;
            }
            else
            {
                pistolrelod0 = false;
            }
            //M16
            if (amoogun == 0 && maxamoogun > 0)
            {
                m16relod0 = true;
            }
            else
            {
                m16relod0 = false;
            }
            //SNIPER
            if (amoosnaiper == 0 && maxamoosnaiper > 0)
            {
                sniperrelod0 = true;
            }
            else
            {
                sniperrelod0 = false;
            }
            //SHOTGUN
            if (amooshotgun == 0 && maxamooshorgan > 0)
            {
                shotgunrelod0 = true;
            }
            else
            {
                shotgunrelod0 = false;
            }
            //PISTOL
            if ((Input.GetKeyDown(KeyCode.R) && wopen.ISferdi == true && amoofrdi < Amoofrdi && maxamoofrdi >= 1)|| (amoofrdi==0 && maxamoofrdi >= 1))
            {
                pistolrelod = true;
                if (maxamoofrdi >= Amoofrdi)
                {
                    maxamoofrdi -= Amoofrdi - amoofrdi;
                    amoofrdi += Amoofrdi - amoofrdi;

                }
                if (maxamoofrdi < Amoofrdi && maxamoofrdi - (Amoofrdi - amoofrdi) >= 1)
                {
                    maxamoofrdi -= Amoofrdi - amoofrdi;
                    amoofrdi += Amoofrdi - amoofrdi;

                }
                if (maxamoofrdi - (Amoofrdi - amoofrdi) < 0)
                {
                    amoofrdi += maxamoofrdi;
                    maxamoofrdi -= maxamoofrdi;
                }
            }
            else
            {
                pistolrelod = false;
            }
            //M16
            if ((Input.GetKey(KeyCode.R) && wopen.ISGAUN == true && amoogun < Amoogun && maxamoogun >= 1)|| (amoogun == 0 && maxamoogun > 0))
            {
                m16relod = true;
                if (maxamoogun >= Amoogun)
                {
                    maxamoogun -= Amoogun - amoogun;
                    amoogun += Amoogun - amoogun;

                }
                if (maxamoogun < Amoogun && maxamoogun - (Amoogun - amoogun) >= 1)
                {
                    maxamoogun -= Amoogun - amoogun;
                    amoogun += Amoogun - amoogun;

                }
                if (maxamoogun - (Amoogun - amoogun) < 0)
                {
                    amoogun += maxamoogun;
                    maxamoogun -= maxamoogun;
                }
            }
            else
            {
                m16relod = false;
            }
            //SHOTGUN
            if ((Input.GetKey(KeyCode.R) && wopen.isshootgan == true && amooshotgun < Amooshotgun && maxamooshorgan >= 1)|| (amooshotgun == 0 && maxamooshorgan > 0))
            {
                shotgunrelod = true;
                if (maxamooshorgan >= Amooshotgun)
                {
                    maxamooshorgan -= Amooshotgun - amooshotgun;
                    amooshotgun += Amooshotgun - amooshotgun;

                }
                if (maxamooshorgan < Amooshotgun && maxamooshorgan - (Amooshotgun - amooshotgun) >= 1)
                {
                    maxamooshorgan -= Amooshotgun - amooshotgun;
                    amooshotgun += Amooshotgun - amooshotgun;

                }
                if (maxamooshorgan - (Amooshotgun - amooshotgun) < 0)
                {
                    amooshotgun += maxamooshorgan;
                    maxamooshorgan -= maxamooshorgan;
                }
            }
            else
            {
                shotgunrelod = false;
            }
            //SNIPER
            if ((Input.GetKey(KeyCode.R) && wopen.issnaiper == true && amoosnaiper < Amoosnaiper && maxamoosnaiper >= 1)|| (Amoosnaiper == 0 && maxamoosnaiper > 0))
            {
                sniperrelod = true;
                relodPistol = false;
                relodM16 = false;
                relodShotgun = false;
                relodSniper = true;
                if (maxamoosnaiper >= Amoosnaiper)
                {
                    maxamoosnaiper -= Amoosnaiper - amoosnaiper;
                    amoosnaiper += Amoosnaiper - amoosnaiper;

                }
                if (maxamoosnaiper < Amoosnaiper && maxamoosnaiper - (Amoosnaiper - amoosnaiper) >= 1)
                {
                    maxamoosnaiper -= Amoosnaiper - amoosnaiper;
                    amoosnaiper += Amoosnaiper - amoosnaiper;

                }
                if (maxamoosnaiper - (Amoosnaiper - amoosnaiper) < 0)
                {
                    amoosnaiper += maxamoosnaiper;
                    maxamoosnaiper -= maxamoosnaiper;
                }
            }
        }
        else
        {
            sniperrelod = false;
        }

        //
        if ((wopen.ISferdi == true && amoofrdi < Amoofrdi && maxamoofrdi >= 1) )
        {
            relodPistol = true;
            
        }
        else if (wopen.ISGAUN == true && amoogun < Amoogun && maxamoogun >= 1)
        {
            
            relodM16 = true;
            
        }
        else if (wopen.isshootgan == true && amooshotgun < Amooshotgun && maxamooshorgan >= 1)
        {
            
            relodShotgun = true;
            
        }
        else if (wopen.issnaiper == true && amoosnaiper < Amoosnaiper && maxamoosnaiper >= 1)
        {
            relodSniper = true;
        }
        else
        {
            relodPistol = false;
            relodM16 = false;
            relodShotgun = false;
            relodSniper = false;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        //z = GameObject.Find("FRDI").GetComponent<WAMOD>();
        //akhd = GameObject.Find("Player").GetComponent<AudioSource>();
        if (other.gameObject.tag == "amoofrdi")
        {
            //akhd.PlayOneShot(clakd);
            //Debug.Log("amozayed");
            //Destroy(gameObject);
            //Destroy(zombie, 4);
            //z.amo = z.amo + amooo;
            maxamoofrdi = maxamoofrdi + ziadaamofrdi;
            Destroy(amooGOfrdi);
        }
        //

        if (other.gameObject.tag == "amoogun")
        {
            maxamoogun = maxamoogun + ziadaamogun;
            Destroy(amooGOgun);
        }
    }
}
