using TMPro;
using UnityEngine;

namespace ElectrumGames.Joysticks.Example.UI
{
    public class JoystickExampleView : MonoBehaviour
    {
        [SerializeField] private DynamicJoystick dynamicJoystick;
        [SerializeField] private FixedJoystick fixedJoystick;
        [SerializeField] private FloatingJoystick floatingJoystick;
        [SerializeField] private VariableJoystick variableJoystick;
        [Space]
        [SerializeField] private TMP_Text dynamicJoystickText;
        [SerializeField] private TMP_Text fixedJoystickText;
        [SerializeField] private TMP_Text floatingJoystickText;
        [SerializeField] private TMP_Text variableJoystickText;

        private void LateUpdate()
        {
            dynamicJoystickText.text = $"Dynamic joystick: x: {dynamicJoystick.Horizontal}, y: {dynamicJoystick.Vertical}";
            fixedJoystickText.text = $"Fixed joystick: x: {fixedJoystick.Horizontal}, y: {fixedJoystick.Vertical}";
            floatingJoystickText.text = $"Floating joystick: x: {floatingJoystick.Horizontal}, y: {floatingJoystick.Vertical}";
            variableJoystickText.text = $"Variable joystick: x: {variableJoystick.Horizontal}, y: {variableJoystick.Vertical}";
        }
    }
}