//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Inputs/DebugInputActions.inputactions
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

public partial class @DebugInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DebugInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugInputActions"",
    ""maps"": [
        {
            ""name"": ""Debug"",
            ""id"": ""62ea052b-2012-4c7f-87e1-80580e3eb502"",
            ""actions"": [
                {
                    ""name"": ""DebugEction"",
                    ""type"": ""Button"",
                    ""id"": ""162f35ee-7714-44ca-bdf7-c0e83fb51fd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8579313b-68e7-436d-bf26-efb2146c44a0"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugEction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_DebugEction = m_Debug.FindAction("DebugEction", throwIfNotFound: true);
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

    // Debug
    private readonly InputActionMap m_Debug;
    private List<IDebugActions> m_DebugActionsCallbackInterfaces = new List<IDebugActions>();
    private readonly InputAction m_Debug_DebugEction;
    public struct DebugActions
    {
        private @DebugInputActions m_Wrapper;
        public DebugActions(@DebugInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction DebugAction => m_Wrapper.m_Debug_DebugEction;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void AddCallbacks(IDebugActions instance)
        {
            if (instance == null || m_Wrapper.m_DebugActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DebugActionsCallbackInterfaces.Add(instance);
            DebugAction.started += instance.OnDebugAction;
            DebugAction.performed += instance.OnDebugAction;
            DebugAction.canceled += instance.OnDebugAction;
        }

        private void UnregisterCallbacks(IDebugActions instance)
        {
            DebugAction.started -= instance.OnDebugAction;
            DebugAction.performed -= instance.OnDebugAction;
            DebugAction.canceled -= instance.OnDebugAction;
        }

        public void RemoveCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDebugActions instance)
        {
            foreach (var item in m_Wrapper.m_DebugActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DebugActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface IDebugActions
    {
        void OnDebugAction(InputAction.CallbackContext context);
    }
}