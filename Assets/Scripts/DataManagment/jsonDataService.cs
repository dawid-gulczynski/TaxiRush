using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class jsonDataService : IDataService
{

    public void SaveData<T>(string RelativePath, T Data, bool Encrypted) where T : class
    {
        string path = Application.persistentDataPath + RelativePath;



        try
        {
            if (File.Exists(path))
            {
                Debug.Log("Datafile exist. Deleting old file and writing new one!");
                File.Delete(path);

            }
            else
            {
                Debug.Log("Creating new Save file");
            }

            using FileStream stream = File.Create(path);
            stream.Close();
            File.WriteAllText(path, JsonConvert.SerializeObject(Data));


        }
        catch (Exception e)
        {
            Debug.Log($"Unable to save data due to: {e.Message} {e.StackTrace}");

        }


    }


    public T LoadData<T>(string RelativePath, bool Encrypted) where T : class
    {
        string path = Application.persistentDataPath + RelativePath;

        if (!File.Exists(path))
        {
            Debug.LogError($"Cannot load file at {path},File does not exist!");
            throw new FileNotFoundException($"{path} does not exists");
        }
        try
        {
            T data = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            return data;
        }
        catch (Exception e)
        {
            Debug.Log($"Unable to load data due to: {e.Message} {e.StackTrace}");
            throw e;
        }
    }


}
