using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class thumbR : MonoBehaviour
{
    public float testf;
    public static bool thumb=false;
    public static bool thumbmove=false;
    public static int x;
    public bool y=false;



    // Start is called before the first frame update
    void Start()
    {
        x=0;
    }

    // Update is called once per frame
    void Update()
    {
        testf = GetComponent<RigidFinger>().GetFingerJointStretchMecanim(2);

        if(testf>-15)
        {
            Debug.Log("T");
            thumb=true;

        }
            else
            {
                thumb=false;
            }




        
    
    }
}
