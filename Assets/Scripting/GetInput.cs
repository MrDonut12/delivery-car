using UnityEngine;

public class GetInput : MonoBehaviour
{  
    
    
    public Vector2 GetMovementInput()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        return new Vector2(x, y);
    }
}
