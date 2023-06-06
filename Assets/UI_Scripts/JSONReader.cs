using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONReader : MonoBehaviour
{
    public TextAsset JSON;

    [System.Serializable]
    public class Player
    {
        public string name;
        public int annualCO2;
        public int household;
        public int globaly;
        public int greece;
        public int usa;
        public int india;
        public int china;
    }

    [System.Serializable]

    public class PlayerList
    {
        public Player[] stats;
    }

    public PlayerList myPlayerList = new PlayerList();

    void Start()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(JSON.text);
    }
}