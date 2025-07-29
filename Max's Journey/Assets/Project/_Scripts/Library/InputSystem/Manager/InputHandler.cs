using Project._Scripts.Library.InputSystem.Controller;
using UnityEngine;

namespace Project._Scripts.Library.InputSystem.Manager
{
    public class InputHandler : MonoBehaviour
    {
        private void Awake()
        {
            InputController.CreateControllerInput();
        }

        private void OnEnable()
        {
            InputController.InitializeControllerInput();
        }

        private void OnDisable()
        {
            InputController.DeInitializeControllerInput();
        }
    }
}
