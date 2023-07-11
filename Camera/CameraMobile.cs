using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class CameraMobile : MonoBehaviour
{
    /*
    public float panSpeed = 5f;
    public float panBorderThickness = 5f;
    */

    public float minY = -5f;
    public float maxY = 5f;
    public float minX = -5f;
    public float maxX = 5f;
    public float Speed;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x * Speed, -TouchDeltaPosition.y * Speed, 0);

            transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX,maxX),
            Mathf.Clamp(transform.position.x, minY, maxY));

        }
        /*
        if (GameManager.GameIsOver)
        {
            this.enabled = false;
            return;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase== TouchPhase.Moved)
        {
            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x * panSpeed, -TouchDeltaPosition.y * panSpeed, 0);
            
            Vector3 pos = transform.position;

            pos.y = Mathf.Clamp(pos.y, minY, maxY);

            pos.x = Mathf.Clamp(pos.x, minX, maxX);

            transform.position = pos; 
        }*/
    }
}
