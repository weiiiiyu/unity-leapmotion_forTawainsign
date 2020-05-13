using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class littlelR : MonoBehaviour
{

    public float testf;
    public static bool little=false;
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
            little=true;
           // Debug.Log("4");
        }
        else
            little=false;
    
    }
}
