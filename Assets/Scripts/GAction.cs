using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class GAction : MonoBehaviour
{
    public string ActionName = "Action";
    public float Cost = 1f;

    public GameObject Target;
    public GameObject TargetTag;

    public float Duration;

    public WorldState[] PreConditionsArray;
    public WorldState[] AfterEffects;

    public NavMeshAgent Agent;

    public Dictionary<string, int> PreConditions = new Dictionary<string, int>();
    public Dictionary<string, int> Effects = new Dictionary<string, int>();

    public WorldStates AgentBeliefs;

    public bool IsRunning = false;

    public GAction()
    {

    }

    private void Awake()
    {
        Agent = this.gameObject.GetComponent<NavMeshAgent>();
        if (PreConditions != null)
        {
            foreach (var preCondition in PreConditionsArray)
            {
                PreConditions.Add(preCondition.Key, preCondition.Value);
            }
        }

        if (AfterEffects != null)
        {
            foreach (var afterEffect in AfterEffects)
            {
                Effects.Add(afterEffect.Key, afterEffect.Value);
            }
        }
    }


    public bool IsReachable() => true;

    public bool IsAchievable(Dictionary<string, int> conditions)
    {
        foreach (var preCondition in PreConditions)
        {
            if (!conditions.ContainsKey(preCondition.Key))
            {
                return false;
            }
        }

        return true;
    }

    public abstract bool PrePerform();
    public abstract bool PostPerform();
}
