using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class jsonController : MonoBehaviour
{
    public string jsonURL;
    void Awake()
    {
        StartCoroutine(GetData());
    }

    IEnumerator GetData()
    {
        Debug.Log("Processing data");
        WWW _WWW = new WWW(jsonURL);
        yield return _WWW;
        if (_WWW.error == null)
        {
            processJsonData(_WWW.text);
        }
        else
        {
            Debug.Log("error");
        }
    }
    public string[] numbers = null;
    public void processJsonData(string _url)
    {
        jsonDataClass jsnData = JsonUtility.FromJson<jsonDataClass>(_url);
        Debug.Log(jsnData.ip);
        numbers = jsnData.ip.Split('.');
    }
}