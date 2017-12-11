using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject _Inventory;

    private bool _IsOpen;

	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.I) && !_IsOpen)
        {
            _Inventory.SetActive(true);
            _IsOpen = true;
        }
        else if (Input.GetKeyUp(KeyCode.I) && _IsOpen)
        {
            _Inventory.SetActive(false);
            _IsOpen = false;
        }
	}
}
