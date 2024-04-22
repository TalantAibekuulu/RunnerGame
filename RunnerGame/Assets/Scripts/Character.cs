using UnityEngine;

public class Character : MonoBehaviour
{

    [SerializeField] private float speed;


    private void Update()
    {
        Run();

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            transform.position = GetSidePosition(1);
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position = GetSidePosition(-1);
        }

        if (CanBoost() == true)
        {
            Boost(2);
        }

    }

    public void Boost(float miltiplier)
    {
        speed = speed * miltiplier;
    }

    private void Run()
    {
        transform.position = GetNextPosition(speed);
    }
    private Vector3 GetNextPosition(float steplenth)
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = transform.position.x;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z + steplenth;


        return newPosition;
    }
    private bool CanBoost()
    {
        return Input.GetKeyUp(KeyCode.Space);
    }
    private Vector3 GetSidePosition(int sideDirecton)
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = transform.position.x + sideDirecton;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z;

        return newPosition;

    }


}


