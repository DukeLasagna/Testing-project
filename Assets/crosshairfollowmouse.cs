using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshairfollowmouse : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Cursor.visible = (false);
    }
    private IEnumerator OnMyMouseDown()
    {
        while (true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 camera = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.z);
                transform.position = Camera.main.ScreenToWorldPoint(pos);
                Debug.Log("Down True ");

            }
            yield return new WaitForEndOfFrame();
        }

    }
    // Update is called once per frame
    void Update()
    {


        Vector3 camera = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.z);
        transform.position = Camera.main.ScreenToWorldPoint(pos);
        Debug.Log("Down True ");


    }
}
