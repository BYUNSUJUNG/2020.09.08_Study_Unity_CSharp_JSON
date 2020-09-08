using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class CountLoadTest : MonoBehaviour 
{
    private string CountString; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData CountData; //string 형태의 데이터를 Json 형태로 변경하기 위해

    public void ClickLoad () 
    {
        Debug.Log(CountData["Count"].ToString());
    }

    void Start () 
    {
        CountString = File.ReadAllText(Application.dataPath + "/DB/Count.json");
        CountData = JsonMapper.ToObject(CountString);
    }

    void Update () 
    {
        //Debug.Log(PMdata[0]["이름"].ToString());
    }

   
}