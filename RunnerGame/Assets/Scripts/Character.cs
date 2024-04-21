using UnityEngine;

public class Character : MonoBehaviour
{
    public string name;
    public bool isFinished;
    [SerializeField] private float speed;
    private bool isJamping;
    private void Update()
    {
        Run(); 
    }
    
    public void Boost(float miltiplier)
    {
        speed = speed * miltiplier;
    }
    private void Jump()
    {
        isJamping = true;
    }
    private void Run()
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = transform.position.x;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z + speed;

        transform.position = newPosition;

    }

}


