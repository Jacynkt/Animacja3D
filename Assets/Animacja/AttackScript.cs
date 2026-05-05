using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AttackScript : MonoBehaviour
{
    [SerializeField] private InputActionReference _lightAttack;
    [SerializeField] private InputActionReference _heavyAttack;

    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        _lightAttack.action.performed += OnLightPerformed;
        _heavyAttack.action.performed += OnHeavyPerformed;

    }

    private void OnDisable()
    {
        _lightAttack.action.performed -= OnLightPerformed;
        _heavyAttack.action.performed += OnHeavyPerformed;
    }


    private void OnLightPerformed(InputAction.CallbackContext value)
    {
        _animator.SetTrigger("LightAttack");
    }

    private void OnHeavyPerformed(InputAction.CallbackContext value)
    {
        _animator.SetTrigger("HeavyAttack");
    }

}