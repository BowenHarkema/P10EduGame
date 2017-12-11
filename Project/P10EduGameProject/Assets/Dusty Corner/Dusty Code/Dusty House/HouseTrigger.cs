using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _PressEImage;

    [SerializeField]
    private PlotManager _PlotM;

    //Get plot manager.
    private void Start()
    {
        _PlotM = FindObjectOfType<PlotManager>();
    }

    //Set image active and more functions.
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _PressEImage.SetActive(true);

            if (Input.GetKeyUp(KeyCode.E))
            {
                _PlotM.NightUpdatePlots();
            }
        }
    }

    //Set image inactive.
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _PressEImage.SetActive(false);
        }
    }
}
