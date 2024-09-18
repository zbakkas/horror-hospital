using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irtidad : MonoBehaviour
{

    public Transform cam = null;
    public CharacterController controller;
    public float moussansfti = 1;

    float campich = 0.0f;

    bool louckcrous = true;
    public float recoil;
    // Start is called before the first frame update
    private void Update()
    {
        DetermineRecoil();
        
    }
    public void DetermineRecoil()
    {
        Vector2 mosdelt = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        campich -= ((mosdelt.y) + recoil) * moussansfti;
        campich = Mathf.Clamp(campich, -90.0f, 90.0f);//lhad dyal lock

        cam.localEulerAngles = Vector3.right * campich;

        transform.Rotate(Vector2.up * mosdelt .x * moussansfti);
    }

    
}