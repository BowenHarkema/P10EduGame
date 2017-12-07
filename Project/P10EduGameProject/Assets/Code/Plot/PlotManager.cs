using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    [SerializeField]
    private List<InteractionPlot> _PlotList = new List<InteractionPlot>();

    private void Start()
    {
        _PlotList.AddRange(FindObjectsOfType<InteractionPlot>());

        SetPlots();
    }

    void SetPlots()
    {
        for (int i = 0; i < _PlotList.Count; i++)
        {
            _PlotList[i].gameObject.SetActive(_PlotList[i]._Plot._Useable);
        }
    }

    public void DayUpdatePlots()
    {
        print("Farmy time.");
    }

    public void NightUpdatePlots()
    {
        print("Sleepy time.");

        for (int i = 0; i < _PlotList.Count; i++)
        {
            if (_PlotList[i]._Plot._Stage <= 2)
            {
                _PlotList[i]._Plot._Stage += 1;
            }
            else
            {
                print("Growth Final");
            }
            
        }
    }
}
