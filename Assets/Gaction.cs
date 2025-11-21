using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Gaction : MonoBehaviour
{
    public string actionName = "Action";
    public float cost = 1.0f;
    public GameObject target;
    public string targetTag;
    public float duration = 0;
    public WorldStates[] preConditions;
    public WorldStates[] afterEffects;
    public NavMeshAgent agent;

    public Dictionary<string, int> preconditions;
    public Dictionary<string, int> effects;

    public WorldStates agenteBeliefs;

    public bool running = false;

    public Gaction()
    {
        preconditions = new Dictionary<string, int>();
        effects = new Dictionary<string, int>();
    }

    public void Awake()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();

        if (preConditions != null )
            foreach(WorldStates w  in preConditions)
            {
                preconditions.Add(w.key, w.value);
            }
        if (afterEffects != null)
            foreach (WorldStates w in afterEffects)
            {
                effects.Add(w.key, w.value);
            }

    }

    public bool isAchievable()
    {
        return true;
    }

    public bool isAchievableGiven(Dictionary<string, int> conditions)
    {
        foreach(KeyValuePair<string, int> p in preconditions)
        {
            if (!conditions.ContainsKey(p.Key))
                return false;
        }
        return true;
    }

    public abstract bool PrePerform();
    public abstract bool PostPerform();

   
}
