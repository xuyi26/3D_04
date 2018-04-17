using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOFactory : MonoBehaviour {
    public GameObject UFO = null;
    private List<UFODate> used = new List<UFODate>();
    private List<UFODate> free = new List<UFODate>();

    public GameObject GetUFO(int round)
    {
        int choice = 0;
        int round1 = 1, round2 = 3, round3 = 5;
        UFO = null;
        if (round == 1)
        {
            choice = Random.Range(0, round1);
        }
        if (round == 2)
        {
            choice = Random.Range(0, round2);
        }
        if (round == 3)
        {
            choice = Random.Range(0, round3);
        }
        for(int i = 0; i < free.Count; i++)
        {
            UFO = free[i].gameObject;
            free.Remove(free[i]);
        }
        if (UFO == null)
        {
            UFO = Instantiate(Resources.Load<GameObject>(" "), new Vector3(0, 0, 0), Quaternion.identity);
            UFO.GetComponent<Renderer>().material.color = UFO.GetComponent<UFODate>().color;
            UFO.GetComponent<UFODate>().direction = new Vector3(0, 0, 0);
            UFO.transform.localScale = UFO.GetComponent<UFODate>().scale;
        }
        used.Add(UFO.GetComponent<UFODate>());
        return UFO;
    }
    public void FreeUFO(GameObject UFO_)
    {
        for(int i = 0; i < used.Count; i++)
        {
            if (UFO.GetInstanceID() == used[i].gameObject.GetInstanceID())
            {
                used[i].gameObject.SetActive(false);
                free.Add(used[i]);
                used.Remove(used[i]);
                break;
            }
        }
    }
}
