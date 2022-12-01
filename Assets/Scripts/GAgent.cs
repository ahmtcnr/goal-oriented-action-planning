using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class GAgent : MonoBehaviour
{
    public List<GAction> Actions = new List<GAction>();

    public Dictionary<SubGoal, int> Goals = new Dictionary<SubGoal, int>();

    public GPlanner Planner;
    private Queue<GAction> ActionsQueue;
    public GAction CurrentAction;
    public SubGoal CurrentGoal;

    private void Start()
    {
        GAction[] gActions = GetComponents<GAction>();
        foreach (var gAction in gActions)
        {
            Actions.Add(gAction);
        }
    }
}

public class SubGoal
{
    public Dictionary<string, int> Goals = new Dictionary<string, int>();

    public bool Remove;

    public SubGoal(string s, int i, bool r)
    {
        Goals.Add(s, i);
        Remove = r;
    }
    
    
}