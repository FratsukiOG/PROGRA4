//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/GAME2/Player_Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player_Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Inputs"",
    ""maps"": [
        {
            ""name"": ""Standards"",
            ""id"": ""edb9c030-e38e-45ed-864e-2f5b26405fc2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""724fc3a7-9174-4262-b610-00f88426e5f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f7e03cf-0841-4edb-b0d8-453daab433b0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Standards
        m_Standards = asset.FindActionMap("Standards", throwIfNotFound: true);
        m_Standards_Move = m_Standards.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Standards
    private readonly InputActionMap m_Standards;
    private IStandardsActions m_StandardsActionsCallbackInterface;
    private readonly InputAction m_Standards_Move;
    public struct StandardsActions
    {
        private @Player_Inputs m_Wrapper;
        public StandardsActions(@Player_Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Standards_Move;
        public InputActionMap Get() { return m_Wrapper.m_Standards; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardsActions set) { return set.Get(); }
        public void SetCallbacks(IStandardsActions instance)
        {
            if (m_Wrapper.m_StandardsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_StandardsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_StandardsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_StandardsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_StandardsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public StandardsActions @Standards => new StandardsActions(this);
    public interface IStandardsActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}