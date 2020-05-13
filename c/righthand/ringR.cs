using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class ringR : MonoBehaviour
{
    public float testf;
    public static bool ring=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testf = GetComponent<RigidFinger>().GetFingerJointStretchMecanim(2);
        if(testf>-15)
        {
           // Debug.Log("3");
            ring=true;
        }
        else
            ring=false;
    
    }
}
