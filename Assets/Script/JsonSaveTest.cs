using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class JsonSaveTest : MonoBehaviour
{
    private string PMstring; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData PMdata; //string 형태의 데이터를 Json 형태로 변경하기 위해
    private string[] Sstring = new string[2];
    private JsonData Sdata;

    void Start()
    {
        PMstring = File.ReadAllText(Application.dataPath + "/DB/PM.json");
        PMdata = JsonMapper.ToObject(PMstring);
    }

    void ClickSave()
    {
        Sstring[0] = PMdata[0]["파워"].ToString();
        Sstring[1] = PMdata[1]["파워"].ToString();

        Sdata = JsonMapper.ToJson(Sstring);
        File.WriteAllText(Application.dataPath + "/Save/PMpower.json", Sdata.ToString());
    }
}