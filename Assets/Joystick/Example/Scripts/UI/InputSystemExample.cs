using ElectrumGames.Joystick.Example;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ElectrumGames.Joysticks.Example.UI
{
    public class InputSystemExample : MonoBehaviour, JoystickExample.IPlayerActions
    {
        [SerializeField] private TMP_Text textOutput;
        private JoystickExample _joystickExample;

        private void Awake()
        {
            _joystickExample = new JoystickExample();
            _joystickExample.Player.SetCallbacks(this);
            _joystickExample.Enable();
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            var value = context.ReadValue<Vector2>();
            textOutput.text = $"Value changed on: {value}";
        }
    }
}