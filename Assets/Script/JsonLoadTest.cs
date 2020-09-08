using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class JsonLoadTest : MonoBehaviour 
{
    private string PMstring; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData PMdata; //string 형태의 데이터를 Json 형태로 변경하기 위해

    void ClickLoad() 
    {
        Debug.Log(PMdata[0]["이름"].ToString());
    }
    void Start () 
    {
        PMstring = File.ReadAllText(Application.dataPath + "/DB/PM.json");
        PMdata = JsonMapper.ToObject(PMstring);
    }

    void Update () 
    {
        //Debug.Log(PMdata[0]["이름"].ToString());
    }
}