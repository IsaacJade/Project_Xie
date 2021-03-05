using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTETracker : MonoBehaviour
{
   
    //public float perfectTime;
    private static QTETracker pInstance;
    public float shrinkTime;
    public Slider Slider;
    public Slider EnemySlider;
    public GameObject CirclePrefab;
    public GameObject TransPrefab;
    public int unitScore = 20;
    public List<GameObject> hitCircles = new List<GameObject>();
    public float wait;
    public bool playerturn;
    public int damagepool = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        if (pInstance != null && pInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        pInstance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    private static QTETracker privGetInstance()
    {
        return pInstance;
    }
    public static void UpdateSlider()
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        if(pTracker.playerturn)
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
    public static IEnumerator InstantiateCircle(CircleTrans trans, int score, int damage)
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        pTracker.damagepool += damage;
        pTracker.unitScore = score;
        for (int i = 0; i < trans.transforms.Length; i++)
        {
            GameObject circle = GameObject.Instantiate(pTracker.CirclePrefab,trans.transforms[i].localPosition,Quaternion.identity);
            circle.transform.SetParent(pTracker.transform, false);
            HitCircle instance = circle.GetComponent<HitCircle>();
            instance.SetNumber(i + 1);
            pTracker.hitCircles.Add(circle);
            instance.Initialize();
            yield return new WaitForSeconds(pTracker.wait);
        }
        yield return new WaitForSeconds(1f);
    }

    public static void ClearSlider(bool playerturn)
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        if (playerturn)
        {
            pTracker.Slider.value = 0;
        }
        else
        {
            pTracker.EnemySlider.value = 0;
        }
    }

    public static int GetandClearDamage()
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        int res = pTracker.damagepool;
        pTracker.damagepool = 0;
        return res;
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

    public static float GetShrinkTime()
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        return pTracker.shrinkTime;
    }
    public static void SetTurn(bool t)
    {
        QTETracker pTracker = QTETracker.privGetInstance();
        pTracker.playerturn = t;
    }

    void Update()
    {
        
    }
}
