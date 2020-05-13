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
        if(doswitch==false&x==1&thumbL.thumb==false&indexL.index==true&middleL.middle==false&ringL.ring==false&littlelL.little==false
        ||doswitch==false&x==1&thumbR.thumb==false&indexR.index==true&middleR.middle==false&ringR.ring==false&littlelR.little==false){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s1");
        }
        if(doswitch==false&x==2&thumbL.thumb==true&indexL.index==true&middleL.middle==true&ringL.ring==false&littlelL.little==false
        ||doswitch==false&x==2&thumbR.thumb==true&indexR.index==true&middleR.middle==true&ringR.ring==false&littlelR.little==false){    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("s7");
        }
        if(doswitch==false&x==3&thumbL.thumb==true&indexL.index==false&middleL.middle==false&ringL.ring==false&littlelL.little==true
        ||doswitch==false&x==3&thumbR.thumb==true&indexR.index==false&middleR.middle==false&ringR.ring==false&littlelR.little==true)
        {    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
           Debug.Log("ming");
        }
        if(doswitch==false&x==4&thumbL.thumb==true&indexL.index==false&middleL.middle==true&ringL.ring==false&littlelL.little==true
        ||doswitch==false&x==4&thumbR.thumb==true&indexR.index==false&middleR.middle==true&ringR.ring==false&littlelR.little==true)
        {    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("plane");
        }
        if(doswitch==false&x==5&thumbL.thumb==true&indexL.index==true&middleL.middle==false&ringL.ring==false&littlelL.little==true
        ||doswitch==false&x==5&thumbR.thumb==true&indexR.index==true&middleR.middle==false&ringR.ring==false&littlelR.little==true)
        {    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
           Debug.Log("protect");

        }
        if(doswitch==false&x==0&thumbL.thumb==false&indexL.index==true&middleL.middle==false&ringL.ring==false&littlelL.little==true
        ||doswitch==false&x==0&thumbR.thumb==false&indexR.index==true&middleR.middle==false&ringR.ring==false&littlelR.little==true)
        {    
            stage1.text="good";
            Invoke("nextstage",1);
            doswitch=true;
            Debug.Log("show");

        }
        
    }
    public void nextstage()
    {
        if(doswitch==true){
            x=Random.Range(0,6);
            if(x==0){
                stage1.text="show";
                doswitch=false;
            }
            else if(x==1)
            {
                stage1.text="one";
                doswitch=false;
            }
            else if(x==2)
            {
                stage1.text="seven";
                doswitch=false;
            }
            else if(x==3)
            {
                stage1.text="ming";
                doswitch=false;
            }
            else if(x==4)
            {
                stage1.text="plane";
                doswitch=false;
            }
            else if(x==5)
            {
                stage1.text="protect";
                doswitch=false;
            }
        thumbR.thumb=false;
        indexR.index=false;
        middleR.middle=false;
        ringR.ring=false;
        littlelR.little=false;
        thumbL.thumb=false;
        indexL.index=false;
        middleL.middle=false;
        ringL.ring=false;
        littlelL.little=false;
        }
    }

}
