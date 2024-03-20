using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class SaveFileObject 
{
    public List<int> carUnlocked;
    public int playerCoins;
    public int playerDiamonds;
    public int playerBest;
    public int playerAchievements;
    public int playerGames;
    public int coinsRecord;
}
