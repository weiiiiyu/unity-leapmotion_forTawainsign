using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class indexR : MonoBehaviour
{

    public float testf;

    public static bool index=false;
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
            index=true;
            //Debug.Log("1");
        }
        else
            index=false;
    
        
    }   
}
