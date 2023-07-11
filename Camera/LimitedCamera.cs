using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedCamera : MonoBehaviour
{
    public float minY = -3f;
    public float maxY = 3f;
    public float minX = -10f;
    public float maxX = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }

    private void MoveCamera(Vector3 direction)
    {
        Vector3 newPos = transform.position + direction * 0.07f * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);
        transform.position = newPos;
    }
}
