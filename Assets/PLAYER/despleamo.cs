using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class despleamo : MonoBehaviour
{
    public GameObject despleammo;
    public Text amotext;
    public Text amomaxtext;
    public ammo amo;
    public WOAPENdesplay wopen;
    public Image AMOpar;
    // Start is called before the first frame update
    void Start()
    {
        despleammo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (wopen.isslah == false)
        {
            despleammo.SetActive(false);
        }
        else
        {
            despleammo.SetActive(true);
        }


        if (wopen.ISferdi)
        {
            amotext.text = amo.amoofrdi.ToString();
            amomaxtext.text = amo.maxamoofrdi.ToString();
            AMOpar.fillAmount = amo.amoofrdi / amo.Amoofrdi;
        }
        if (wopen.ISGAUN)
        {
            amotext.text = amo.amoogun.ToString();
            amomaxtext.text = amo.maxamoogun.ToString();
            AMOpar.fillAmount = amo.amoogun / amo.Amoogun;
        }
        if (wopen.issnaiper)
        {
            amotext.text = amo.amoosnaiper.ToString();
            amomaxtext.text = amo.maxamoosnaiper.ToString();
            AMOpar.fillAmount = amo.amoosnaiper / amo.Amoosnaiper;
        }
        if (wopen.isshootgan)
        {
            amotext.text = amo.amooshotgun.ToString();
            amomaxtext.text = amo.maxamooshorgan.ToString();
            AMOpar.fillAmount = amo.amooshotgun / amo.Amooshotgun;
        }
        
    }
  
}
