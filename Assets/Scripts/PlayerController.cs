using Assets.Scripts;
using UnityEngine;

public class PlayerController1 : MonoBehaviour, StateActions
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJumpAction();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            OnMoveAction();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnDuckAction();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            OnAttackAction();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OnDeathAction();
        }
    }

    public void OnJumpAction()
    {
        Debug.Log("Jumped!");
    }

    public void OnMoveAction()
    {
        Debug.Log("Moved!");
    }

    public void OnDuckAction()
    {
        Debug.Log("Ducked!");
    }

    public void OnAttackAction()
    {
        Debug.Log("Attacked!");
    }

    public void OnDeathAction()
    {
        Debug.Log("Died!");
    }
}
