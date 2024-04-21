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
        bool isSpaceClicked = Input.GetKeyUp(KeyCode.Space);

        if (isSpaceClicked == true)
        {
            Boost(2);
        }

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
        transform.position = GetNextPosition(speed);
    }
    private Vector3 GetNextPosition(float steplenth)
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = transform.position.x;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z + steplenth;

        transform.position = newPosition;
        return newPosition;
    }
    private int GetSum(int firstNumber, int secondNumber)
    {
        int sum = 0;
        sum += firstNumber + secondNumber;
        return sum;
    }


    private float ЖарымынБер(int number)
    {
        float result = 0;
        result += number / 2;
        return result;
    }

}


