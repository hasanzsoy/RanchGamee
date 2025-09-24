using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
      Vector3 newPosition = new Vector3(transform.position.x,transform.position.y, transform.position.z + runningSpeed * Time.deltaTime);
      transform.position = newPosition;
    }
}
