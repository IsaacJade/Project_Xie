using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    /// <summary>
    /// 卡牌集合
    /// </summary>
    // Start is called before the first frame update

    public Transform cards;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (cards.childCount == 3)
        {
            cards.GetComponent<RectTransform>().anchoredPosition = new Vector2(20, 0);
        }
        else if (cards.childCount == 4)
        {
            cards.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }
        else if (cards.childCount == 2)
        {
            cards.GetComponent<RectTransform>().anchoredPosition = new Vector2(60, 0);
        }
        else if (cards.childCount == 1)
        {
            cards.GetComponent<RectTransform>().anchoredPosition = new Vector2(90, 0);
        }
    }
}
