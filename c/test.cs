﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class test : MonoBehaviour
{
    public float testf;
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
            Debug.Log("one");
        }
    
    }
}
