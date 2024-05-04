using DG.Tweening;
using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Action OnCollidedWithWall;

    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _speedSpeed;

    private void Update()
    {
        Run();

        if (Input.GetKey(KeyCode.D) == true)
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
        Scale();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WallTag>() != null)
    
      {
            OnCollidedWithWall?.Invoke(); 
    }
    }
    public void Boost(float miltiplier)
    {
        _forwardSpeed = _forwardSpeed* miltiplier;
    }
private void Run()
{
    transform.position = GetNextPosition(_forwardSpeed);
}

private Vector3 GetNextPosition(float stepLenth)
{
    Vector3 newPosition = new Vector3();

    newPosition.x = transform.position.x;
    newPosition.y = transform.position.y;
    newPosition.z = transform.position.z + stepLenth;

    return newPosition;
}

private bool CanBoost()
{
    return Input.GetKeyUp(KeyCode.Space);
}

private Vector3 GetSidePosition(int sideDirection)
{
    Vector3 newPosition = new Vector3();

    newPosition.x = transform.position.x + (sideDirection * _speedSpeed);
    newPosition.y = transform.position.y;
    newPosition.z = transform.position.z;

    return newPosition;
}

private void Scale()
{
    if (Input.GetKeyUp(KeyCode.Alpha1))
    {
        transform.DOScale(Vector3.one * 1, 1f);
    }
    else if (Input.GetKeyUp(KeyCode.Alpha2))
    {
        transform.DOScale(Vector3.one * 2, 1f);
    }
    else if (Input.GetKeyUp(KeyCode.Alpha3))
    {
        transform.DOScale(Vector3.one * 3, 1f);
    }
}
    public void Stop()
    {
        _forwardSpeed = 0;
        _speedSpeed = 0;
    }


}





