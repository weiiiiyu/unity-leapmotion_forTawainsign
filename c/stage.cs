using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stage : MonoBehaviour
{
    public Text stage1;
    public static bool doswitch;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        doswitch=true;
        if (doswitch==true)
        {
            Invoke("nextstage",1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(doswitch==false&x==1&thumbl.thumb==false&indexL.index==true&middleL.middle==false&ringL.ring==false&littlelL.little==false){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s1");
        }
        if(doswitch==false&x==2&thumbl.thumb==false&indexL.index==true&middleL.middle==true&ringL.ring==false&littlelL.little==false){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s2");
        }
        if(doswitch==false&x==3&thumbl.thumb==false&indexL.index==true&middleL.middle==true&ringL.ring==true&littlelL.little==false){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s3");
        }
        if(doswitch==false&x==4&thumbl.thumb==false&indexL.index==true&middleL.middle==true&ringL.ring==true&littlelL.little==true){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s4");


        }
        if(doswitch==false&x==5&thumbl.thumb==true&indexL.index==true&middleL.middle==true&ringL.ring==true&littlelL.little==true){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s5");

        }
        if(doswitch==false&x==0&thumbl.thumb==true&indexL.index==false&middleL.middle==false&ringL.ring==false&littlelL.little==false){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s0");

        }
        
    }
    public void nextstage()
    {
        if(doswitch==true){
            x=Random.Range(0,6);
            if(x==0){
                stage1.text="thump";
                doswitch=false;
            }
            else
                stage1.text=x+"";   
                doswitch=false;

        }
    }

}
