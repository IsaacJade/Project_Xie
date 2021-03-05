using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitCircle : MonoBehaviour
{
    private float time;
    private bool isClick;
    private float ringMinScale;
    private float ringStartScale;
    private bool shrinkDone;
    private float scaleModifier;
    public bool overtime;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Circle Start called");
        Time.timeScale = 1.0f;
        ringMinScale = 1f;
        isClick = false;
        time = QTETracker.GetShrinkTime();
        ringStartScale = transform.GetChild(2).GetComponent<RectTransform>().localScale.x;
        scaleModifier = (ringStartScale - ringMinScale) / QTETracker.GetShrinkTime();
        overtime = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(time > 0f)
        {
            if (!isClick)
            {
                float delta = Time.fixedDeltaTime;
                    //Debug.Log(time);
                    time -= delta;
                    SetHitRingScale(delta * scaleModifier);
                Debug.Log(QTETracker.GetShrinkTime());
            }
        } else
        {
            
            overtime = true;
            Debug.Log("TimeDone:" + Time.timeSinceLevelLoad);
            this.gameObject.SetActive(false);
        }
    }

    public void Initialize()
    {
        Time.timeScale = 1.0f;
        ringMinScale = 1f;
        isClick = false;
        time = QTETracker.GetShrinkTime();
        ringStartScale = transform.GetChild(2).GetComponent<RectTransform>().localScale.x;
        scaleModifier = (ringStartScale - ringMinScale) / QTETracker.GetShrinkTime();
        overtime = false;
    }
    public void SetNumber(int i)
    {
        Text text = transform.GetChild(0).GetComponent<Text>();
        text.text = i.ToString();
    }
    private void SetHitRingScale(float scale)
    {
        var child = transform.GetChild(2).GetComponent<RectTransform>();
        float newScale = child.localScale.x - scale;
        child.localScale = new Vector3(newScale, newScale, 0);
    }
    public void Click()
    {
        //Debug.Log("is click");
        //Debug.Log("time is "+time.ToString());

        if(!overtime)
        {
            if (time < 0.25f && time > -0.1f)
            {
                //Debug.Log("perfect");
                QTETracker.UpdateSlider();
                //根据弱点条，qte数量计算
            }
            else if (time >= 0.25f && time > -0.1f && time < 0.5f)
            {
                //Debug.Log("normal");
                QTETracker.UpdateSlider();
            }
            else
            {
               // Debug.Log("too early fail");
            }
        }
        else
        {
            //Debug.Log("overtime fail");
        }
       
        //
        isClick = true;
        this.gameObject.SetActive(false);
    }
}
