using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgController : MonoBehaviour
{
    public Text txt;
    private static string currentmsg;
    public static void addmsg(string msg) {
        currentmsg = currentmsg + "\n"+ "\n" + msg;
    }

    IEnumerator msgUpdate(){
        while (true){
            txt.text = currentmsg;
            yield return new WaitForSeconds(0.5f);
        }
    }
    void OnEnable() {
        StartCoroutine(msgUpdate());
    }
    private void OnDisable(){
        StopCoroutine(msgUpdate());
    }
}
