using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class cardmove : MonoBehaviour
{
    public void Enter()
    {
        //鼠标放上，突出所选卡牌
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void Exit()
    {
        //挪开鼠标后变回
        transform.localScale = new Vector3(1f, 1f, 1f);
    }


        Vector3 offset;   ///卡牌初始的位置
        /// 开始拖拽的时候

        public void OnpointDown()    ///点击后获取位置
        {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);   
        }
        /// <summary>
        /// 拖拽中
        /// </summary>
        /// <param name="eventData"></param>
        public void OnDrag()
        {
            transform.position = offset + Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.SetParent(GameObject.Find("Tempcard").transform);
        }

        public void Up()
        {
            transform.SetParent(GameObject.Find("cards").transform);
        }

        

}


