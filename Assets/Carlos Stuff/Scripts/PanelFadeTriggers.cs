using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFadeTriggers : MonoBehaviour
{

    [SerializeField] private GameObject waterWall;
    [SerializeField] private GameObject pillars;

    public void TriggerWater()
    {
        waterWall.SetActive(true);
    }

    public void TriggerPillars()
    {
        pillars.SetActive(true);
    }

}
