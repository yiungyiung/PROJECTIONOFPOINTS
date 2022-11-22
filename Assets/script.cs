using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public GameObject hp;
    public GameObject vp;
    public float hppoint;
    public float vppoint;
    public InputField inputFieldHP;
    public InputField inputFieldVP;
    public GameObject linehp;
    public GameObject linevp;


    public void quad(float h,float v)
    {   
        foreach (GameObject point in GameObject.FindGameObjectsWithTag("Player"))
        {
                Destroy(point);
        }
        Instantiate(hp, new Vector3(0,h/10,0), Quaternion.identity);
        Instantiate(vp, new Vector3(0,-v/10,0), Quaternion.identity);
        GameObject hpy = Instantiate(linehp, new Vector3(0,h/20,0), Quaternion.identity);
        hpy.transform.localScale=new Vector3(1,Mathf.Abs(h)/10,1);
        GameObject vpy = Instantiate(linevp, new Vector3(0,-v/20,0), Quaternion.identity);
        vpy.transform.localScale=new Vector3(1,Mathf.Abs(v)/10,1);

    }

    public void callbtn(){
        hppoint=float.Parse(inputFieldHP.text);
        vppoint=float.Parse(inputFieldVP.text);
        quad(hppoint,vppoint);
    }
}
