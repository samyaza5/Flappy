using JetBrains.Annotations;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public Transform target; 
    float offsetx = 0f;

    void Start()
    {
       if (target == null)
        return;

        offsetx = transform.position.x - target.position.x;
    }

   
    void Update()
    {
        if(target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetx;
        transform.position = pos;
    }
}
