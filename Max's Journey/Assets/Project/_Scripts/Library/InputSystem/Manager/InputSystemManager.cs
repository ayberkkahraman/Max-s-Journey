using Project._Scripts.Library.InputSystem.Controller;
using UnityEngine;

namespace Project._Scripts.Library.InputSystem.Manager
{
  [DefaultExecutionOrder(520)]
  public class InputSystemManager : MonoBehaviour
  {
    private void Awake() => InputController.CreateControllerInput();
    private void OnEnable() => InputController.InitializeControllerInput();
    private void OnDisable() => InputController.DeInitializeControllerInput();

  }
}
