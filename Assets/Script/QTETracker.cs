using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTETracker : MonoBehaviour
{
   
    //public float perfectTime;
    public float shrinkTime;
    public Slider Slider;
    public Slider EnemySlider;
    public GameObject CirclePrefab;
    public GameObject TransPrefab;
    public List<GameObject> hitCircles = new List<GameObject>();
    public float wait;
    public bool playerturn;

    // Start is called before the first frame update
    void Start()
    {
        playerturn = true;
        
    }
    public void UpdateSlider(int value)
    {
        if(playerturn)
        {
            Slider.value += value;
        }
        else
        {
            EnemySlider.value += value;
        }
    }
    public IEnumerator InstantiateCircle(CircleTrans trans)
    {
        
        for (int i = 0; i < trans.transforms.Length; i++)
        {
            GameObject circle = GameObject.Instantiate(CirclePrefab,trans.transforms[i].localPosition,Quaternion.identity);
            circle.transform.SetParent(this.transform, false);
            HitCircle instance = circle.GetComponent<HitCircle>();
            instance.tracker = this;
            instance.SetNumber(i + 1);
            hitCircles.Add(circle);
            yield return new WaitForSeconds(wait);
        }
        yield return new WaitForSeconds(1f);
        yield break;
    }
    public void DeleteObjects()
    {
        for (int i = 0; i < hitCircles.Count; i++)
        {
            Destroy(hitCircles[i]);
        }
        hitCircles.Clear();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
