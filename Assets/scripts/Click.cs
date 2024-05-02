using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 引入事件系统命名空间  

public class Click : MonoBehaviour,IPointerDownHandler, IPointerUpHandler  
{

    public PlayerMovment playerMovment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click(){
        Debug.Log("click");
    }

        public void OnPointerDown(PointerEventData eventData)  
    {  
        // 按下按钮时开始移动  
        playerMovment.left();
    }

        public void OnPointerUp(PointerEventData eventData)  
    {  
        // 释放按钮时停止移动  
        playerMovment.stand();
    }    
}
