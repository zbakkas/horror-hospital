using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SHOOT : MonoBehaviour
{
    public ParticleSystem flashGUN;
    public ParticleSystem flash1GUN;

    public ParticleSystem flashFRDI;
    public ParticleSystem flash1FRDI;

    public ParticleSystem flashshotGUN;
    public ParticleSystem flash1shotGUN;

    public ParticleSystem flashSNAIPER;
    public ParticleSystem flash1SNAIPER;

    public ParticleSystem posamoflash;

    Ray ay;
    RaycastHit hit;

    public Transform rayorigi;
    public Transform rayorSHOTGAN;
    public Transform rayorSNAIPER;
    public Transform rayorigiFRDI;
    public Transform raydistin;

    public ParticleSystem posamofDAMAGZOMBIE;

    public WOAPENdesplay wope;
    public ammo a;
    public CONTROLPLAYER control;


    public float damageGUN;
    public float damageSHOTGUN;
    public float damageSNAIPER;
    public float damagePistol;


    //public irtidad I;


    public float fireRate = 0.15f;
    public float timeStamp = 0.0f;

    public AudioSource ADUIouto;
    public AudioClip isamoM16;
    public AudioClip noamoM16;

    public AudioSource ADUI;
    public AudioClip isamoFRDI;
    public AudioClip noamoFRDI;

    public AudioClip isamoshotgun;
    public AudioClip noamoshotgun;

    public AudioClip isamosniper;
    public AudioClip noamosniper;

    public relodTime relod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //PISTOL
        if (wope.ISferdi == true && relod.relod == false)
        {
            if (Input.GetButtonDown("Fire1") )
            {
                if (a.amoofrdi > 0)
                {
                    control.recoil = 0.9f;
                    //
                    ADUI.clip = isamoFRDI;
                    ADUI.Play();

                    //
                    // I.irtidddad();
                    a.amoofrdi = a.amoofrdi - 1;
                    //
                    flashFRDI.Emit(1);
                    //flash1FRDI.Emit(1);
                    ay.origin = rayorigiFRDI.position;
                    ay.direction = raydistin.position - rayorigiFRDI.position;
                    if (Physics.Raycast(ay, out hit))
                    {
                        Debug.DrawLine(ay.origin, hit.point, Color.red, 1f); //khat mkan rasasa
                                                                             //
                        hiidd hidd = hit.collider.GetComponent<hiidd>();
                        baddy badyy = hit.collider.GetComponent<baddy>();
                        rjlin rjlinn = hit.collider.GetComponent<rjlin>();
                        //
                        if (hidd || badyy || rjlinn)
                        {
                            
                            posamofDAMAGZOMBIE.transform.position = hit.point;
                            posamofDAMAGZOMBIE.transform.forward = hit.normal;
                            posamofDAMAGZOMBIE.Emit(1);
                        }
                        else
                        {
                            posamoflash.transform.position = hit.point;
                            posamoflash.transform.forward = hit.normal;
                            posamoflash.Emit(2);
                        }

                        //
                        if (hidd)
                        {
                            damagePistol = 30;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damagePistol);
                        }
                        if (badyy)
                        {
                            damagePistol = 20;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damagePistol);
                        }
                        if (rjlinn)
                        {
                            damagePistol = 10;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damagePistol);
                        }
                        //



                    }
                }
                else
                {
                    ADUI.clip = noamoFRDI;
                    ADUI.Play();
                }
            }
            else
            {
                control.recoil = 0;
            }


        }
        else
        {
            control.recoil = 0;
        }

        //M16

        if (wope.ISGAUN == true && Time.time > timeStamp && relod.relod == false)
        {
            if (Input.GetButton("Fire1"))
            {
                if (a.amoogun > 0)
                {
                    control.recoil = 0.3f;
                    //
                    ADUI.clip = isamoM16;
                    ADUI.Play();
                    //
                    timeStamp = Time.time + fireRate;
                    //I.irtidddad();
                    a.amoogun = a.amoogun - 1;
                    //
                    flashGUN.Emit(1);
                    //flash1GUN.Emit(1);
                    //
                    ay.origin = rayorigi.position;
                    ay.direction = raydistin.position - rayorigi.position;
                    if (Physics.Raycast(ay, out hit))
                    {
                        Debug.DrawLine(ay.origin, hit.point, Color.red, 1f); //khat mkan rasasa
                        
                        //
                        hiidd hidd = hit.collider.GetComponent<hiidd>();
                        baddy badyy = hit.collider.GetComponent<baddy>();
                        rjlin rjlinn = hit.collider.GetComponent<rjlin>();
                        //
                        if (hidd || badyy || rjlinn)
                        {
                            posamofDAMAGZOMBIE.transform.position = hit.point;
                            posamofDAMAGZOMBIE.transform.forward = hit.normal;
                            posamofDAMAGZOMBIE.Emit(1);
                        }
                        else
                        {
                            posamoflash.transform.position = hit.point;
                            posamoflash.transform.forward = hit.normal;
                            posamoflash.Emit(2);
                        }
                        //


                        //
                        if (hidd)
                        {
                            damageGUN = 60;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageGUN);
                        }
                        if (badyy)
                        {
                            damageGUN = 40;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageGUN);
                        }
                        if (rjlinn)
                        {
                            damageGUN = 20;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageGUN);
                        }
                        

                    }
                }
                else
                {
                    ADUI.clip = noamoM16;
                    ADUI.Play();
                }
            }
           
            else 
            {
                control.recoil = 0;
            }

        }
       
        //SHOTGUN

        if (wope.isshootgan == true && relod.relod == false)
        {
            if (Input.GetButtonDown("Fire1") )
            {
                if (a.amooshotgun > 0)
                {
                    control.recoil = 1f;
                    //
                    ADUI.clip = isamoshotgun;
                    ADUI.Play();
                    //
                    //I.irtidddad();
                    a.amooshotgun = a.amooshotgun - 1;
                    //
                    flashshotGUN.Emit(1);
                    flash1shotGUN.Emit(1);
                    ay.origin = rayorSHOTGAN.position;
                    ay.direction = raydistin.position - rayorSHOTGAN.position;
                    if (Physics.Raycast(ay, out hit))
                    {
                        Debug.DrawLine(ay.origin, hit.point, Color.red, 1f); //khat mkan rasasa
                                                                             //
                        hiidd hidd = hit.collider.GetComponent<hiidd>();
                        baddy badyy = hit.collider.GetComponent<baddy>();
                        rjlin rjlinn = hit.collider.GetComponent<rjlin>();
                        //
                        if (hidd || badyy || rjlinn)
                        {
                            posamofDAMAGZOMBIE.transform.position = hit.point;
                            posamofDAMAGZOMBIE.transform.forward = hit.normal;
                            posamofDAMAGZOMBIE.Emit(1);
                        }
                        else
                        {
                            posamoflash.transform.position = hit.point;
                            posamoflash.transform.forward = hit.normal;
                            posamoflash.Emit(2);
                        }

                        //
                        if (hidd)
                        {
                            damageSHOTGUN = 110;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageSHOTGUN);
                        }
                        if (badyy)
                        {
                            damageSHOTGUN = 60;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageSHOTGUN);
                        }
                        if (rjlinn)
                        {
                            damageSHOTGUN = 20;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageSHOTGUN);
                        }
                        //



                    }
                }
                else
                {
                    ADUI.clip = noamoshotgun;
                    ADUI.Play();
                }
            }


            if (Input.GetButtonUp("Fire1"))
            {
                control.recoil = 0;
            }

        }
       
        //sniper

        if ( wope.issnaiper == true && relod.relod == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (a.amoosnaiper > 0)
                {
                    control.recoil = 2f;
                    // 
                    ADUI.clip = isamosniper;
                    ADUI.Play();
                    //
                    //I.irtidddad();
                    a.amoosnaiper = a.amoosnaiper - 1;
                    //
                    flashSNAIPER.Emit(1);
                    flash1SNAIPER.Emit(1);
                    ay.origin = rayorSNAIPER.position;
                    ay.direction = raydistin.position - rayorSNAIPER.position;
                    if (Physics.Raycast(ay, out hit))
                    {
                        Debug.DrawLine(ay.origin, hit.point, Color.red, 1f); //khat mkan rasasa
                                                                             //
                        hiidd hidd = hit.collider.GetComponent<hiidd>();
                        baddy badyy = hit.collider.GetComponent<baddy>();
                        rjlin rjlinn = hit.collider.GetComponent<rjlin>();
                        //
                        if (hidd || badyy || rjlinn)
                        {
                            posamofDAMAGZOMBIE.transform.position = hit.point;
                            posamofDAMAGZOMBIE.transform.forward = hit.normal;
                            posamofDAMAGZOMBIE.Emit(1);
                        }
                        else
                        {
                            posamoflash.transform.position = hit.point;
                            posamoflash.transform.forward = hit.normal;
                            posamoflash.Emit(2);
                        }

                        //
                        if (hidd)
                        {
                            damageSNAIPER = 200;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageSNAIPER);
                        }
                        if (badyy)
                        {
                            damageSNAIPER = 100;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageSNAIPER);
                        }
                        if (rjlinn)
                        {
                            damageSNAIPER = 50;
                            zombiehilth zz = hit.collider.GetComponentInParent<zombiehilth>();
                            zz.hilthpins(damageSNAIPER);
                        }
                        //



                    }
                }
                else
                {
                    ADUI.clip = noamosniper;
                    ADUI.Play();
                }
            }

          
            if (Input.GetButtonUp("Fire1"))
            {
                control.recoil = 0;
            }

        }
        
    }
}
