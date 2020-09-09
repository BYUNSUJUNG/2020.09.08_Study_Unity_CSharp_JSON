using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System; // Convert.ToInt32
using Newtonsoft.Json; // JsonConvert, Formatting

public class CountSaveTest : MonoBehaviour
{
    private string CountString; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData CountData; //string 형태의 데이터를 Json 형태로 변경하기 위해
    //private string[] Cstring = new string[2];
    //private JsonData Cdata;

    private int iUpCount = 0;
    private string sUpCount;

    void Start()
    {
        CountString = File.ReadAllText(Application.dataPath + "/DB/Count.json");
        CountData = JsonMapper.ToObject(CountString);
        
    }

    public void ClickSave()
    {
        //UpCount = CountData["Count"]+1;
        iUpCount = Convert.ToInt32(CountData["Count"].ToString())+1;
        sUpCount = iUpCount.ToString();

        //Cstring[0] = "Count";
        //Cstring[1] = CountData["Count"].ToString();
        //Cdata = JsonMapper.ToJson(Cstring);

        Dictionary<string, string> CountDataDict = new Dictionary<string, string>
        {
            {"Count", sUpCount/*CountData["Count"].ToString()*/}
        };
        string json = JsonConvert.SerializeObject(CountDataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/Count.json", json/*Cdata.ToString()*/);
        Debug.Log("[Save]: "+ sUpCount);
    }
}

/*
 * Dictionary로 만들기
 * string uploadedUrl = "http://whereTheFileWas.com/uploaded/what.jpg"
Dictionary<string, string> location = new Dictionary<string, string>
{
    {"location", uploadedUrl}
};
string json = JsonConvert.SerializeObject(location, Formatting.Indented); */
//Formatting.Indented(옵션): 자동으로 라인/들여쓰기된 문자열