using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int i = 0;
    public TextAsset testTxt;
    IEnumerator Addtext(){
        //if(Input.GetMouseButtonDown(0)){
            string[] lines = testTxt.text.Split("\n"[0]);
            MsgController.addmsg(lines[i]);
            i++;
        yield return new WaitForSeconds(2f);
        //}
    }

    public void OnClick()
    {
        StartCoroutine(Addtext());
    }
}
