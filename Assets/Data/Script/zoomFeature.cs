using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zoomFeature : MonoBehaviour
{
    public GameObject mainObj;

    public float perspectiveZoomSpeed = .5f;

    float initialDistance = 0;
    Vector3 initialScale;
    bool spawned = false;
    public void changeCondition()
    {
        spawned = true;
    }
    private void Update()
    {
        if (spawned == true)
        {
            mainObj = this.gameObject;
            if (Input.touchCount == 2)
            {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);


                if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
                {
                    initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
                    initialScale = mainObj.transform.localScale;
                }
                else
                {
                    var currentDistance = Vector2.Distance(touchZero.position, touchOne.position);
                    var factor = currentDistance / initialDistance;
                    mainObj.transform.localScale = initialScale * factor;
                }
            }
        }
    }


}