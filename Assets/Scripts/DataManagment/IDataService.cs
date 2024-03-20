using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataService
{
    void SaveData<T>(string RelativePath, T Data, bool Encrypted) where T : class;

    T LoadData<T>(string RelativePath, bool Encrypted) where T : class;

}
