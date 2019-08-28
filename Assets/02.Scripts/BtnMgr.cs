using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMgr : MonoBehaviour
{
    public Canvas canvas;
    public Canvas canvas_exit;

    public GameObject Button;

    bool isInfoOn;
  

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
        canvas_exit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    //종료이벤트
    //public void OnClickExit()
    //{
    //    Application.Quit();
    //    Debug.Log("Exit Button Click");

    //}
    //버튼클릭 이벤트
    public void OnClick(GameObject button)
    {
        switch (button.tag)
        {
            case "INFO":
                if (!isInfoOn)
                {
                    canvas.gameObject.SetActive(true);
                    isInfoOn = true;
                }
                else
                {
                    canvas.gameObject.SetActive(false);
                    isInfoOn = false;
                }
                break;
            case "EXIT":
                canvas_exit.gameObject.SetActive(true);
                break;
            case "YES":
                canvas_exit.gameObject.SetActive(true);
                break;
            case "NO":
                canvas_exit.gameObject.SetActive(false);
                break;
      
        }
    }


}
