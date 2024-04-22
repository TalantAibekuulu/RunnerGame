using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class Character : MonoBehaviour
{
    public string Name;
    public bool isFinished;

    [SerializeField] private float forwardSpeed;

    [SerializeField] private float sideSpeed;

    private bool isJjumping;

    private void Update()
    {
       Scale();
       
        Run();

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position = GetSidePosition(1);
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position = GetSidePosition(-1);
        }

        bool isSpaceCicked = Input.GetKeyUp(KeyCode.Space);

        if (isSpaceCicked == true)
        {
            Boost(2);
        }
    }

    private void Boost(float multiplier)
    {
        forwardSpeed = forwardSpeed * multiplier;
    }

    private void Jump()
    {
        isJjumping = true;
    }

    private void Run()
    {
        transform.position = GetNextPosition(forwardSpeed);
    }
    private Vector3 GetNextPosition(float stepLenth)
    {
        Vector3 nemPosition = new Vector3();
        nemPosition.x = transform.position.x;
        nemPosition.y = transform.position.y;
        nemPosition.z = transform.position.z + stepLenth;

        return nemPosition;
    }

    private int GetSum(int firstNumber, int secondNumber)
    {
        int sum = 0;

        sum = firstNumber + secondNumber;

        return sum;
    }

    private float ЖарымынБер(int number)

    {
        float sum = 5;

        sum = number / 2;


        return sum;
    }

    private bool CanBoost()
    {
        return Input.GetKeyUp(KeyCode.Space);
    }

    private Vector3 GetSidePosition(int sideDirection)
    {
        Vector3 nemPosition = new Vector3();
        nemPosition.x = transform.position.x + sideDirection * sideSpeed;
        nemPosition.y = transform.position.y;
        nemPosition.z = transform.position.z;

        return nemPosition;
    }
    private void Scale()
    {
       
   
        
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            transform.DOScale(Vector3.one*1, 1f);
        }
    else if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            transform.DOScale(Vector3.one*2, 1f);
        }
   
    else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            transform.DOScale(Vector3.one*3, 1f);
        }
            
     }


}


