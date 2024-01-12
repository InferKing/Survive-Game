using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject != null) 
                {
                    Debug.Log(hit.collider.gameObject.name);
                }
            }
        }
    }
}
