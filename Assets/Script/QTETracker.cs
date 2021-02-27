using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTETracker : MonoBehaviour
{
   
    //public float perfectTime;
    private static QTETracker pInstance;
    public static float shrinkTime;
    public Slider Slider;
    public Slider EnemySlider;
    public GameObject CirclePrefab;
    public GameObject TransPrefab;
    public int unitScore = 20;
    public List<GameObject> hitCircles = new List<GameObject>();
    public float wait;
    public static bool playerturn;

    // Start is called before the first frame update
    void Start()
    {
        if(pInstance == null)
        {
            pInstance = new QTETracker();
        }
        playerturn = true;
        
    }
    private static QTETracker privGetInstance()
    {
        if(pInstance == null)
        {
            pInstance = new QTETracker();
        }
        return pInstance;
    }
    public static void UpdateSlider()
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        if(QTETracker.playerturn)
        {
            pTracker.Slider.value += pTracker.unitScore;
        }
        else
        {
            pTracker.EnemySlider.value += pTracker.unitScore;
        }
    }
    public static Slider GetSlider(bool playerturn)
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        if (playerturn)
        {
            return pTracker.Slider;
        }
        else
        {
            return pTracker.EnemySlider;
        }
    }
    public static IEnumerator InstantiateCircle(CircleTrans trans, int score)
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        pTracker.unitScore = score;
        for (int i = 0; i < trans.transforms.Length; i++)
        {
            GameObject circle = GameObject.Instantiate(pTracker.CirclePrefab,trans.transforms[i].localPosition,Quaternion.identity);
            circle.transform.SetParent(pTracker.transform, false);
            HitCircle instance = circle.GetComponent<HitCircle>();
            instance.SetNumber(i + 1);
            pTracker.hitCircles.Add(circle);
            yield return new WaitForSeconds(pTracker.wait);
        }
        yield return new WaitForSeconds(1f);
        yield break;
    }
    public static void DeleteObjects()
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        for (int i = 0; i < pTracker.hitCircles.Count; i++)
        {
            Destroy(pTracker.hitCircles[i]);
        }
        pTracker.hitCircles.Clear();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
