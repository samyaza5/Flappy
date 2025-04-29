using UnityEditor;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float highposeY = 1f;
    public float lowposeY = -1f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform topObfect;
    public Transform bottomObject;

    public float withpPadding = 4;

    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstaclCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2f;

        topObfect.localPosition = new Vector3(0f, halfHoleSize);
        bottomObject.localPosition = new Vector3(0f, -halfHoleSize);
        
        Vector3 placePosition = lastPosition + new Vector3(withpPadding, 0);
        placePosition.y = Random.Range(lowposeY, highposeY);
       
        transform.position = placePosition;

        return placePosition;
    }
}
