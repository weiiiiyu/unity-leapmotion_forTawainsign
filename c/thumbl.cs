using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class thumbl : MonoBehaviour
{
    public float testf;
    public static bool thumb=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testf = GetComponent<RigidFinger>().GetFingerJointStretchMecanim(1);
        if(testf>-10)
        {
            Debug.Log("T");
            thumb=true;
        }
        else
            thumb=false;
    
    }
}
