using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorldStates
{
    public Dictionary<string, int> States;

    public WorldStates()
    {
        States = new Dictionary<string, int>();
    }


    public bool HasState(string key) => States.ContainsKey(key);

    public void AddState(string key, int value) => States.Add(key, value);

    public void RemoveState(string key)
    {
        if (States.ContainsKey(key))
        {
            States.Remove(key);
        }
    }

    public void ModifyState(string key, int value)
    {
        if (States.ContainsKey(key))
        {
            States[key] += value;
            if (States[key] <= 0)
            {
                RemoveState(key);
            }
            else
            {
                States.Add(key, value);
            }
        }
    }

    public void SetState(string key,int value)
    {
        if (States.ContainsKey(key))
        {
            States[key] = value;
        }
        else
        {
            States.Add(key,value);
        }

    }

    public Dictionary<string, int> GetStates() => States;
}

[System.Serializable]
public class WorldState
{
    public string Key;
    public int Value;
}