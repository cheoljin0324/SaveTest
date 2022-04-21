using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;
    SaveManager saveManager;

    public void Start()
    {
        saveManager = GetComponent<SaveManager>();
    }

    void SaveInData()
    {
        string JsonData = JsonUtility.ToJson(playerData,true);
        string path = Application.dataPath + "Resources/"+saveManager.value.ToString()+"/"+"playerData.json";
        File.WriteAllText(path, JsonData);
    }

    void LoadOutData()
    {
        string path = Application.dataPath + "Resources/" + saveManager.value.ToString() + "/" + "playerData.json";
        string JsonData = File.ReadAllText(path);
        JsonUtility.FromJson<PlayerData>(JsonData);

    }

}
