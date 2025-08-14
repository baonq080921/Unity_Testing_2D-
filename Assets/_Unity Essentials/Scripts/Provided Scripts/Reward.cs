using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Reward : MonoBehaviour
{
    private int count;

    public List<Transform> rewards = new List<Transform>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rewards = GetComponentsInChildren<Transform>()
            .Skip(1) // skip the parent
            .ToList();
        count = rewards.Count;
        UI.instance.UpdateUI(count);
    }

    public void CollectReward( Transform reward)
    {
        if (rewards.Remove(reward))
        {
            count--;
            Debug.Log(count);
            UI.instance.UpdateUI(count);
            Destroy(reward.gameObject);

            if (rewards.Count == 0)
                Debug.Log(" collected! All rewards collected!");
        }
    }
}
