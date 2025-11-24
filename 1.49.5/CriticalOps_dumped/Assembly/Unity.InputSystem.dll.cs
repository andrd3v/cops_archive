// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class UISupport
{
	// Methods

	// RVA: 0x1379954
	public static void Initialize() { }

}

// Namespace: 
private struct MonoScriptData
{
	// Fields
	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28
}

// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Methods

	// RVA: 0x13799CC
	private static MonoScriptData Get() { }

	// RVA: 0x1379AD0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputActionCollection
{
	// Methods

	// RVA: -1
	public abstract System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: -1
	public abstract void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: -1
	public abstract System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: -1
	public abstract void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: -1
	public abstract UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: -1
	public abstract bool Contains(InputAction action) { }

	// RVA: -1
	public abstract void Enable() { }

	// RVA: -1
	public abstract void Disable() { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputActionCollection2
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: -1
	public abstract InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: -1
	public abstract int FindBinding(InputBinding mask, InputAction action) { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputInteraction
{
	// Methods

	// RVA: -1
	public abstract void Process(InputInteractionContext context) { }

	// RVA: -1
	public abstract void Reset() { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputInteraction<T0>
{}

// Namespace: UnityEngine.InputSystem
internal static class InputInteraction
{
	// Fields
	public static TypeTable s_Interactions; // 0x0

	// Methods

	// RVA: 0x1379AD8
	public static Type GetValueType(Type interactionType) { }

	// RVA: 0x1379BF4
	public static string GetDisplayName(string interaction) { }

	// RVA: 0x1379D14
	public static string GetDisplayName(Type interactionType) { }

}

// Namespace: 
internal enum ActionFlags
{
	// Fields
	public int value__; // 0x10
	public const ActionFlags WantsInitialStateCheck = 1;
}

// Namespace: 
public struct CallbackContext
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal int m_ActionIndex; // 0x18

	// Methods

	// RVA: 0x137C53C
	private int get_actionIndex() { }

	// RVA: 0x137C544
	private int get_bindingIndex() { }

	// RVA: 0x137C584
	private int get_controlIndex() { }

	// RVA: 0x137C5C4
	private int get_interactionIndex() { }

	// RVA: 0x137C604
	public InputActionPhase get_phase() { }

	// RVA: 0x137C640
	public bool get_started() { }

	// RVA: 0x137C684
	public bool get_performed() { }

	// RVA: 0x137C6C8
	public bool get_canceled() { }

	// RVA: 0x137C70C
	public InputAction get_action() { }

	// RVA: 0x137C764
	public InputControl get_control() { }

	// RVA: 0x137C7C8
	public IInputInteraction get_interaction() { }

	// RVA: 0x137C84C
	public Double get_time() { }

	// RVA: 0x137C898
	public Double get_startTime() { }

	// RVA: 0x137C8E4
	public Double get_duration() { }

	// RVA: 0x137C968
	public Type get_valueType() { }

	// RVA: 0x137C9FC
	public int get_valueSizeInBytes() { }

	// RVA: 0x137CA90
	public void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x137CD44
	public bool ReadValueAsButton() { }

	// RVA: 0x137CE04
	public object ReadValueAsObject() { }

	// RVA: 0x137CEC8
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
public sealed class InputAction
{
	// Fields
	internal string m_Name; // 0x10
	internal InputActionType m_Type; // 0x18
	internal string m_ExpectedControlType; // 0x20
	internal string m_Id; // 0x28
	internal string m_Processors; // 0x30
	internal string m_Interactions; // 0x38
	internal InputBinding[] m_SingletonActionBindings; // 0x40
	internal ActionFlags m_Flags; // 0x48
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x50
	internal int m_BindingsStartIndex; // 0xB0
	internal int m_BindingsCount; // 0xB4
	internal int m_ControlStartIndex; // 0xB8
	internal int m_ControlCount; // 0xBC
	internal int m_ActionIndexInState; // 0xC0
	internal InputActionMap m_ActionMap; // 0xC8
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnStarted; // 0xD0
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnCanceled; // 0x120
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnPerformed; // 0x170

	// Methods

	// RVA: 0x1379ECC
	public string get_name() { }

	// RVA: 0x1379ED4
	public InputActionType get_type() { }

	// RVA: 0x1379EDC
	public Guid get_id() { }

	// RVA: 0x1379FB0
	internal Guid get_idDontGenerate() { }

	// RVA: 0x137A014
	public string get_expectedControlType() { }

	// RVA: 0x137A01C
	public void set_expectedControlType(string value) { }

	// RVA: 0x137A024
	public string get_processors() { }

	// RVA: 0x137A02C
	public string get_interactions() { }

	// RVA: 0x137A034
	public InputActionMap get_actionMap() { }

	// RVA: 0x137A074
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x137A090
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x137A5F8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x137A72C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x137A8C8
	public InputActionPhase get_phase() { }

	// RVA: 0x137A990
	public bool get_inProgress() { }

	// RVA: 0x137A9E4
	public bool get_enabled() { }

	// RVA: 0x137AA38
	public void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137AA94
	public void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137AAF0
	public void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137AB4C
	public void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137ABA8
	public void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137AC04
	public void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137AC60
	public bool get_triggered() { }

	// RVA: 0x137AD90
	public InputControl get_activeControl() { }

	// RVA: 0x137AE28
	public Type get_activeValueType() { }

	// RVA: 0x137AEB4
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x137AED0
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x137AEE4
	public void .ctor() { }

	// RVA: 0x137AF40
	public void .ctor(string name, InputActionType type, string binding, string interactions, string processors, string expectedControlType) { }

	// RVA: 0x137B158
	public void Dispose() { }

	// RVA: 0x137B174
	public override string ToString() { }

	// RVA: 0x137B4B8
	public void Enable() { }

	// RVA: 0x137B55C
	public void Disable() { }

	// RVA: 0x137B5D0
	public InputAction Clone() { }

	// RVA: 0x137B6E4
	private object System.ICloneable.Clone() { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x137B6E8
	public object ReadValueAsObject() { }

	// RVA: 0x137B788
	public float GetControlMagnitude() { }

	// RVA: 0x137B800
	public void Reset() { }

	// RVA: 0x137B898
	public bool IsPressed() { }

	// RVA: 0x137B8FC
	public bool IsInProgress() { }

	// RVA: 0x137B964
	public bool WasPressedThisFrame() { }

	// RVA: 0x137B9FC
	public bool WasReleasedThisFrame() { }

	// RVA: 0x137ACF8
	public bool WasPerformedThisFrame() { }

	// RVA: 0x137BA94
	public bool WasCompletedThisFrame() { }

	// RVA: 0x137BB2C
	public float GetTimeoutCompletionPercentage() { }

	// RVA: 0x137A054
	internal bool get_isSingletonAction() { }

	// RVA: 0x137A914
	private TriggerState get_currentState() { }

	// RVA: 0x1379F50
	internal string MakeSureIdIsInPlace() { }

	// RVA: 0x137BC78
	internal void GenerateId() { }

	// RVA: 0x137A4D8
	internal InputActionMap GetOrCreateActionMap() { }

	// RVA: 0x137BCC4
	private void CreateInternalActionMapForSingletonAction() { }

	// RVA: 0x137BDC0
	internal void RequestInitialStateCheckOnEnabledAction() { }

	// RVA: 0x137BE0C
	internal bool ActiveControlIsValid(InputControl control) { }

	// RVA: 0x137C144
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask() { }

	// RVA: 0x137C2C4
	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	// RVA: 0x137C46C
	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

}

// Namespace: 
[Serializable]
internal struct WriteFileJson
{
	// Fields
	public string name; // 0x10
	public WriteMapJson[] maps; // 0x18
	public SchemeJson[] controlSchemes; // 0x20
}

// Namespace: 
[Serializable]
internal struct WriteFileJsonNoName
{
	// Fields
	public WriteMapJson[] maps; // 0x10
	public SchemeJson[] controlSchemes; // 0x18
}

// Namespace: 
[Serializable]
internal struct ReadFileJson
{
	// Fields
	public string name; // 0x10
	public ReadMapJson[] maps; // 0x18
	public SchemeJson[] controlSchemes; // 0x20

	// Methods

	// RVA: 0x137E634
	public void ToAsset(InputActionAsset asset) { }

}

// Namespace: 
private sealed class <GetEnumerator>d__32
{
	// Fields
	private int <>1__state; // 0x10
	private InputAction <>2__current; // 0x18
	public InputActionAsset <>4__this; // 0x20
	private int <i>5__2; // 0x28
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> <actions>5__3; // 0x30
	private int <actionCount>5__4; // 0x40
	private int <n>5__5; // 0x44

	// Methods

	// RVA: 0x137F9D8
	public void .ctor(int <>1__state) { }

	// RVA: 0x1381380
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1381384
	private bool MoveNext() { }

	// RVA: 0x1381598
	private InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

	// RVA: 0x13815A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13815E0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private sealed class <get_bindings>d__9
{
	// Fields
	private int <>1__state; // 0x10
	private InputBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x70
	public InputActionAsset <>4__this; // 0x78
	private int <numActionMaps>5__2; // 0x80
	private int <i>5__3; // 0x84
	private InputBinding[] <bindings>5__4; // 0x88
	private int <numBindings>5__5; // 0x90
	private int <n>5__6; // 0x94

	// Methods

	// RVA: 0x137D578
	public void .ctor(int <>1__state) { }

	// RVA: 0x13815E8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13815EC
	private bool MoveNext() { }

	// RVA: 0x1381788
	private InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

	// RVA: 0x13817B4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13817F4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x138187C
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

	// RVA: 0x1381930
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public class InputActionAsset
{
	// Fields
	public const string Extension = "inputactions";
	internal const string kDefaultAssetLayoutJson = "{}";
	internal InputActionMap[] m_ActionMaps; // 0x18
	internal InputControlScheme[] m_ControlSchemes; // 0x20
	internal bool m_IsProjectWide; // 0x28
	internal InputActionState m_SharedStateForAllMaps; // 0x30
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x38
	internal int m_ParameterOverridesCount; // 0x98
	internal ParameterOverride[] m_ParameterOverrides; // 0xA0
	internal DeviceArray m_Devices; // 0xA8

	// Methods

	// RVA: 0x137D264
	public bool get_enabled() { }

	// RVA: 0x137D408
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps() { }

	// RVA: 0x137D484
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x137D4F0
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x137D5B0
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x137D5D8
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x137D998
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x137DB30
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x137DD3C
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x137E0E4
	public string ToJson() { }

	// RVA: 0x137E558
	public void LoadFromJson(string json) { }

	// RVA: 0x137E708
	public static InputActionAsset FromJson(string json) { }

	// RVA: 0x137DDC0
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x137E8F0
	public int FindBinding(InputBinding mask, InputAction action) { }

	// RVA: 0x137EBB8
	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound) { }

	// RVA: 0x137EE00
	public InputActionMap FindActionMap(Guid id) { }

	// RVA: 0x137EEC0
	public InputAction FindAction(Guid guid) { }

	// RVA: 0x137EFDC
	public int FindControlSchemeIndex(string name) { }

	// RVA: 0x137F0AC
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(string name) { }

	// RVA: 0x137F1E4
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x137F488
	public void Enable() { }

	// RVA: 0x137F6DC
	public void Disable() { }

	// RVA: 0x137F8C4
	public bool Contains(InputAction action) { }

	// RVA: 0x137F960
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x137FA04
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x137FA7C
	internal void MarkAsDirty() { }

	// RVA: 0x137FA80
	internal bool IsEmpty() { }

	// RVA: 0x137FB7C
	internal void OnWantToChangeSetup() { }

	// RVA: 0x137FEF4
	internal void OnSetupChanged() { }

	// RVA: 0x137D8B0
	private void ReResolveIfNecessary(bool fullResolve) { }

	// RVA: 0x138027C
	internal void ResolveBindingsIfNecessary() { }

	// RVA: 0x1380338
	private void OnDestroy() { }

	// RVA: 0x1380380
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public enum InputActionChange
{
	// Fields
	public int value__; // 0x10
	public const InputActionChange ActionEnabled = 0;
	public const InputActionChange ActionDisabled = 1;
	public const InputActionChange ActionMapEnabled = 2;
	public const InputActionChange ActionMapDisabled = 3;
	public const InputActionChange ActionStarted = 4;
	public const InputActionChange ActionPerformed = 5;
	public const InputActionChange ActionCanceled = 6;
	public const InputActionChange BoundControlsAboutToChange = 7;
	public const InputActionChange BoundControlsChanged = 8;
}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags NeedToResolveBindings = 1;
	public const Flags BindingResolutionNeedsFullReResolve = 2;
	public const Flags ControlsForEachActionInitialized = 4;
	public const Flags BindingsForEachActionInitialized = 8;
}

// Namespace: 
internal struct DeviceArray
{
	// Fields
	private bool m_HaveValue; // 0x10
	private int m_DeviceCount; // 0x14
	private InputDevice[] m_DeviceArray; // 0x18

	// Methods

	// RVA: 0x1384604
	public int IndexOf(InputDevice device) { }

	// RVA: 0x1384664
	public bool Remove(InputDevice device) { }

	// RVA: 0x137DA64
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get() { }

	// RVA: 0x137DB80
	public bool Set(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> devices) { }

}

// Namespace: 
[Serializable]
internal struct BindingOverrideListJson
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> bindings; // 0x10
}

// Namespace: 
[Serializable]
internal struct BindingOverrideJson
{
	// Fields
	public string action; // 0x10
	public string id; // 0x18
	public string path; // 0x20
	public string interactions; // 0x28
	public string processors; // 0x30

	// Methods

	// RVA: 0x1384718
	public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) { }

	// RVA: 0x1384830
	public static BindingOverrideJson FromBinding(InputBinding binding) { }

	// RVA: 0x1384898
	public static InputBinding ToBinding(BindingOverrideJson bindingOverride) { }

}

// Namespace: 
[Serializable]
internal struct BindingJson
{
	// Fields
	public string name; // 0x10
	public string id; // 0x18
	public string path; // 0x20
	public string interactions; // 0x28
	public string processors; // 0x30
	public string groups; // 0x38
	public string action; // 0x40
	public bool isComposite; // 0x48
	public bool isPartOfComposite; // 0x49

	// Methods

	// RVA: 0x13849A4
	public InputBinding ToBinding() { }

	// RVA: 0x1384B30
	public static BindingJson FromBinding(InputBinding binding) { }

}

// Namespace: 
[Serializable]
internal struct ReadActionJson
{
	// Fields
	public string name; // 0x10
	public string type; // 0x18
	public string id; // 0x20
	public string expectedControlType; // 0x28
	public string expectedControlLayout; // 0x30
	public string processors; // 0x38
	public string interactions; // 0x40
	public bool passThrough; // 0x48
	public bool initialStateCheck; // 0x49
	public BindingJson[] bindings; // 0x50

	// Methods

	// RVA: 0x1384C1C
	public InputAction ToAction(string actionName) { }

}

// Namespace: 
[Serializable]
internal struct WriteActionJson
{
	// Fields
	public string name; // 0x10
	public string type; // 0x18
	public string id; // 0x20
	public string expectedControlType; // 0x28
	public string processors; // 0x30
	public string interactions; // 0x38
	public bool initialStateCheck; // 0x40

	// Methods

	// RVA: 0x1384EC8
	public static WriteActionJson FromAction(InputAction action) { }

}

// Namespace: 
[Serializable]
internal struct ReadMapJson
{
	// Fields
	public string name; // 0x10
	public string id; // 0x18
	public ReadActionJson[] actions; // 0x20
	public BindingJson[] bindings; // 0x28
}

// Namespace: 
[Serializable]
internal struct WriteMapJson
{
	// Fields
	public string name; // 0x10
	public string id; // 0x18
	public WriteActionJson[] actions; // 0x20
	public BindingJson[] bindings; // 0x28

	// Methods

	// RVA: 0x1384FF0
	public static WriteMapJson FromMap(InputActionMap map) { }

}

// Namespace: 
[Serializable]
internal struct WriteFileJson
{
	// Fields
	public WriteMapJson[] maps; // 0x10

	// Methods

	// RVA: 0x1384424
	public static WriteFileJson FromMap(InputActionMap map) { }

	// RVA: 0x137E1BC
	public static WriteFileJson FromMaps(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

}

// Namespace: 
[Serializable]
internal struct ReadFileJson
{
	// Fields
	public ReadActionJson[] actions; // 0x10
	public ReadMapJson[] maps; // 0x18

	// Methods

	// RVA: 0x1380388
	public InputActionMap[] ToMaps() { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
public sealed class InputActionMap
{
	// Fields
	internal string m_Name; // 0x10
	internal string m_Id; // 0x18
	internal InputActionAsset m_Asset; // 0x20
	internal InputAction[] m_Actions; // 0x28
	internal InputBinding[] m_Bindings; // 0x30
	private InputBinding[] m_BindingsForEachAction; // 0x38
	private InputControl[] m_ControlsForEachAction; // 0x40
	internal int m_EnabledActionsCount; // 0x48
	internal InputAction m_SingletonAction; // 0x50
	internal int m_MapIndexInState; // 0x58
	internal InputActionState m_State; // 0x60
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x68
	private Flags m_Flags; // 0xC8
	internal int m_ParameterOverridesCount; // 0xCC
	internal ParameterOverride[] m_ParameterOverrides; // 0xD0
	internal DeviceArray m_Devices; // 0xD8
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionCallbacks; // 0xE8
	internal System.Collections.Generic.Dictionary<System.String,System.Int32> m_ActionIndexByNameOrId; // 0x138
	internal static int s_DeferBindingResolution; // 0x0

	// Methods

	// RVA: 0x1381934
	public string get_name() { }

	// RVA: 0x138193C
	public InputActionAsset get_asset() { }

	// RVA: 0x1381944
	public Guid get_id() { }

	// RVA: 0x137ED9C
	internal Guid get_idDontGenerate() { }

	// RVA: 0x137D474
	public bool get_enabled() { }

	// RVA: 0x138152C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions() { }

	// RVA: 0x1381A04
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1381A70
	private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

	// RVA: 0x1381B14
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x1381BE8
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x1381C10
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x137BF4C
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x1381F6C
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x1382034
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x1382114
	public void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1382170
	public void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x137BDB0
	public void .ctor() { }

	// RVA: 0x13821CC
	public void .ctor(string name) { }

	// RVA: 0x1382208
	public void Dispose() { }

	// RVA: 0x138221C
	internal int FindActionIndex(string nameOrId) { }

	// RVA: 0x1382428
	private void SetUpActionLookupTable() { }

	// RVA: 0x13825B0
	internal void ClearActionLookupTable() { }

	// RVA: 0x138260C
	private int FindActionIndex(Guid id) { }

	// RVA: 0x137E7C4
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x137EF80
	public InputAction FindAction(Guid id) { }

	// RVA: 0x137F374
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x137F668
	public void Enable() { }

	// RVA: 0x137F88C
	public void Disable() { }

	// RVA: 0x13826E4
	public InputActionMap Clone() { }

	// RVA: 0x1382988
	private object System.ICloneable.Clone() { }

	// RVA: 0x138298C
	public bool Contains(InputAction action) { }

	// RVA: 0x13829B8
	public override string ToString() { }

	// RVA: 0x1382AC0
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x1382BA0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1382BA4
	private bool get_needToResolveBindings() { }

	// RVA: 0x1382BB0
	private void set_needToResolveBindings(bool value) { }

	// RVA: 0x1382BC4
	private bool get_bindingResolutionNeedsFullReResolve() { }

	// RVA: 0x1382BD0
	private void set_bindingResolutionNeedsFullReResolve(bool value) { }

	// RVA: 0x1382BF0
	private bool get_controlsForEachActionInitialized() { }

	// RVA: 0x1382BFC
	private void set_controlsForEachActionInitialized(bool value) { }

	// RVA: 0x1382C1C
	private bool get_bindingsForEachActionInitialized() { }

	// RVA: 0x1382C28
	private void set_bindingsForEachActionInitialized(bool value) { }

	// RVA: 0x137A694
	internal UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(InputAction action) { }

	// RVA: 0x137A830
	internal UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(InputAction action) { }

	// RVA: 0x1382C48
	private void SetUpPerActionControlAndBindingArrays() { }

	// RVA: 0x137FC0C
	internal void OnWantToChangeSetup() { }

	// RVA: 0x137FF90
	internal void OnSetupChanged() { }

	// RVA: 0x13833EC
	internal void OnBindingModified() { }

	// RVA: 0x1383384
	internal void ClearCachedActionData(bool onlyControls) { }

	// RVA: 0x13819B8
	internal void GenerateId() { }

	// RVA: 0x137A514
	internal bool LazyResolveBindings(bool fullResolve) { }

	// RVA: 0x137A7E8
	internal bool ResolveBindingsIfNecessary() { }

	// RVA: 0x13834D8
	internal void ResolveBindings() { }

	// RVA: 0x137E9E8
	public int FindBinding(InputBinding mask, InputAction action) { }

	// RVA: 0x1384174
	internal int FindBindingRelativeToMap(InputBinding mask) { }

	// RVA: 0x1384238
	public static InputActionMap[] FromJson(string json) { }

	// RVA: 0x13842F0
	public static string ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

	// RVA: 0x13843AC
	public string ToJson() { }

	// RVA: 0x13844D4
	public void OnBeforeSerialize() { }

	// RVA: 0x13844D8
	public void OnAfterDeserialize() { }

}

// Namespace: 
internal struct Parameter
{
	// Fields
	public object instance; // 0x10
	public FieldInfo field; // 0x18
	public int bindingIndex; // 0x20
}

// Namespace: 
private struct ParameterEnumerable
{
	// Fields
	private InputActionState m_State; // 0x10
	private ParameterOverride m_Parameter; // 0x18
	private int m_MapIndex; // 0x90

	// Methods

	// RVA: 0x13857F4
	public void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x138584C
	public ParameterEnumerator GetEnumerator() { }

	// RVA: 0x138BD7C
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }

	// RVA: 0x138BE70
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private struct ParameterEnumerator
{
	// Fields
	private InputActionState m_State; // 0x10
	private int m_MapIndex; // 0x18
	private int m_BindingCurrentIndex; // 0x1C
	private int m_BindingEndIndex; // 0x20
	private int m_InteractionCurrentIndex; // 0x24
	private int m_InteractionEndIndex; // 0x28
	private int m_ProcessorCurrentIndex; // 0x2C
	private int m_ProcessorEndIndex; // 0x30
	private InputBinding m_BindingMask; // 0x38
	private Type m_ObjectType; // 0x90
	private string m_ParameterName; // 0x98
	private bool m_MayBeInteraction; // 0xA0
	private bool m_MayBeProcessor; // 0xA1
	private bool m_MayBeComposite; // 0xA2
	private bool m_CurrentBindingIsComposite; // 0xA3
	private object m_CurrentObject; // 0xA8
	private FieldInfo m_CurrentParameter; // 0xB0

	// Methods

	// RVA: 0x138BA70
	public void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x138C120
	private bool MoveToNextBinding() { }

	// RVA: 0x138C2F0
	private bool MoveToNextInteraction() { }

	// RVA: 0x138C4B0
	private bool MoveToNextProcessor() { }

	// RVA: 0x138C374
	private bool FindParameter(object instance) { }

	// RVA: 0x138593C
	public bool MoveNext() { }

	// RVA: 0x138C028
	public void Reset() { }

	// RVA: 0x13858C8
	public Parameter get_Current() { }

	// RVA: 0x138C534
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x138C5D8
	public void Dispose() { }

}

// Namespace: 
internal struct ParameterOverride
{
	// Fields
	public string objectRegistrationName; // 0x10
	public string parameter; // 0x18
	public InputBinding bindingMask; // 0x20
	public PrimitiveValue value; // 0x78

	// Methods

	// RVA: 0x138BF64
	public Type get_objectType() { }

	// RVA: 0x1385414
	public void .ctor(string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x138C5DC
	public void .ctor(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x1386C38
	public static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(InputActionMap actionMap, InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x138C654
	private static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(ParameterOverride[] overrides, int overrideCount, InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x138C914
	private static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> PickMoreSpecificOne(System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> first, System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> second) { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags Started = 1;
	public const Flags Completed = 2;
	public const Flags Canceled = 4;
	public const Flags OnEventHooked = 8;
	public const Flags OnAfterUpdateHooked = 16;
	public const Flags DontIgnoreNoisyControls = 64;
	public const Flags DontGeneralizePathOfSelectedControl = 128;
	public const Flags AddNewBinding = 256;
	public const Flags SuppressMatchingEvents = 512;
}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public string group; // 0x10

	// Methods

	// RVA: 0x138D394
	public void .ctor() { }

	// RVA: 0x138F6CC
	internal bool <WithTargetBinding>b__0(InputControlScheme x) { }

}

// Namespace: 
public sealed class RebindingOperation
{
	// Fields
	public const float kDefaultMagnitudeThreshold = 0.2;
	private InputAction m_ActionToRebind; // 0x10
	private System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x18
	private Type m_ControlType; // 0x78
	private InternedString m_ExpectedLayout; // 0x80
	private int m_IncludePathCount; // 0x90
	private string[] m_IncludePaths; // 0x98
	private int m_ExcludePathCount; // 0xA0
	private string[] m_ExcludePaths; // 0xA8
	private int m_TargetBindingIndex; // 0xB0
	private string m_BindingGroupForNewBinding; // 0xB8
	private string m_CancelBinding; // 0xC0
	private float m_MagnitudeThreshold; // 0xC8
	private float[] m_Scores; // 0xD0
	private float[] m_Magnitudes; // 0xD8
	private Double m_LastMatchTime; // 0xE0
	private Double m_StartTime; // 0xE8
	private float m_Timeout; // 0xF0
	private float m_WaitSecondsAfterMatch; // 0xF4
	private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Candidates; // 0xF8
	private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnComplete; // 0x118
	private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnCancel; // 0x120
	private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnPotentialMatch; // 0x128
	private System.Func<UnityEngine.InputSystem.InputControl,System.String> m_OnGeneratePath; // 0x130
	private System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> m_OnComputeScore; // 0x138
	private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> m_OnApplyBinding; // 0x140
	private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEventDelegate; // 0x148
	private Action m_OnAfterUpdateDelegate; // 0x150
	private Cache m_LayoutCache; // 0x158
	private StringBuilder m_PathBuilder; // 0x160
	private Flags m_Flags; // 0x168
	private System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputControl,System.Single> m_StartingActuations; // 0x170

	// Methods

	// RVA: 0x138CD3C
	public InputAction get_action() { }

	// RVA: 0x138CD44
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x138CD6C
	public UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates() { }

	// RVA: 0x138CD80
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_scores() { }

	// RVA: 0x138CE00
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_magnitudes() { }

	// RVA: 0x138CE80
	public InputControl get_selectedControl() { }

	// RVA: 0x138CEF4
	public bool get_started() { }

	// RVA: 0x138CF00
	public bool get_completed() { }

	// RVA: 0x138CF0C
	public bool get_canceled() { }

	// RVA: 0x138CF18
	public Double get_startTime() { }

	// RVA: 0x138CF20
	public float get_timeout() { }

	// RVA: 0x138B3BC
	public string get_expectedControlType() { }

	// RVA: 0x138B010
	public RebindingOperation WithAction(InputAction action) { }

	// RVA: 0x138B33C
	public RebindingOperation WithMatchingEventsBeingSuppressed(bool value) { }

	// RVA: 0x138B3CC
	public RebindingOperation WithCancelingThrough(string binding) { }

	// RVA: 0x138D02C
	public RebindingOperation WithCancelingThrough(InputControl control) { }

	// RVA: 0x138CF90
	public RebindingOperation WithExpectedControlType(string layoutName) { }

	// RVA: 0x138D10C
	public RebindingOperation WithExpectedControlType(Type type) { }

	// RVA: 0x30B1CD4
	public RebindingOperation WithExpectedControlType() { }

	// RVA: 0x138B444
	public RebindingOperation WithTargetBinding(int bindingIndex) { }

	// RVA: 0x138D50C
	public RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask) { }

	// RVA: 0x138D544
	public RebindingOperation WithBindingGroup(string group) { }

	// RVA: 0x138D640
	public RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

	// RVA: 0x138D650
	public RebindingOperation WithRebindAddingNewBinding(string group) { }

	// RVA: 0x138D684
	public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

	// RVA: 0x138D784
	public RebindingOperation WithoutIgnoringNoisyControls() { }

	// RVA: 0x138D39C
	public RebindingOperation WithControlsHavingToMatchPath(string path) { }

	// RVA: 0x138B1CC
	public RebindingOperation WithControlsExcluding(string path) { }

	// RVA: 0x138D7F4
	public RebindingOperation WithTimeout(float timeInSeconds) { }

	// RVA: 0x138D7FC
	public RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x138D828
	public RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x138D854
	public RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x138D880
	public RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl,System.String> callback) { }

	// RVA: 0x138D8AC
	public RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> callback) { }

	// RVA: 0x138D8D8
	public RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> callback) { }

	// RVA: 0x138B1C4
	public RebindingOperation OnMatchWaitForAnother(float seconds) { }

	// RVA: 0x138D904
	public RebindingOperation Start() { }

	// RVA: 0x138DC88
	public void Cancel() { }

	// RVA: 0x138DD28
	public void Complete() { }

	// RVA: 0x138E124
	public void AddCandidate(InputControl control, float score, float magnitude) { }

	// RVA: 0x138E3F0
	public void RemoveCandidate(InputControl control) { }

	// RVA: 0x138E514
	public void Dispose() { }

	// RVA: 0x138E79C
	protected override void Finalize() { }

	// RVA: 0x138E82C
	public RebindingOperation Reset() { }

	// RVA: 0x138DB6C
	private void HookOnEvent() { }

	// RVA: 0x138E670
	private void UnhookOnEvent() { }

	// RVA: 0x138E940
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x138E2AC
	private void SortCandidatesByScore() { }

	// RVA: 0x138F194
	private static bool HavePathMatch(InputControl control, string[] paths, int pathCount) { }

	// RVA: 0x138DA64
	private void HookOnAfterUpdate() { }

	// RVA: 0x138E710
	private void UnhookOnAfterUpdate() { }

	// RVA: 0x138F23C
	private void OnAfterUpdate() { }

	// RVA: 0x138DD38
	private void OnComplete() { }

	// RVA: 0x138DCE0
	private void OnCancel() { }

	// RVA: 0x138F51C
	private void ResetAfterMatchCompleted() { }

	// RVA: 0x138CF28
	private void ThrowIfRebindInProgress() { }

	// RVA: 0x138F31C
	private string GeneratePathForControl(InputControl control) { }

	// RVA: 0x138AF70
	public void .ctor() { }

}

// Namespace: 
internal class DeferBindingResolutionWrapper
{
	// Methods

	// RVA: 0x138BA1C
	public void Acquire() { }

	// RVA: 0x138F6F4
	public void Dispose() { }

	// RVA: 0x138BA14
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> bindings; // 0x10
	public int firstPartIndex; // 0x20
	public string[] partStrings; // 0x28
	public int partCount; // 0x30

	// Methods

	// RVA: 0x1387FAC
	public void .ctor() { }

	// RVA: 0x138F764
	internal string <GetBindingDisplayString>b__0(string fragment) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionRebindingExtensions
{
	// Fields
	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x0

	// Methods

	// RVA: 0x13852C0
	public static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask) { }

	// RVA: 0x13854F8
	private static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, ParameterOverride parameterOverride) { }

	// RVA: 0x1385C54
	public static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	// RVA: 0x316B894
	public static System.Nullable<TValue> GetParameterValue(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask) { }

	// RVA: 0x316B894
	public static void ApplyParameterOverride(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x316B894
	public static void ApplyParameterOverride(InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x316B894
	public static void ApplyParameterOverride(InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x316B894
	private static ParameterOverride ExtractParameterOverride(System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x1385EBC
	public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x1386640
	public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x138681C
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x13869D4
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	// RVA: 0x138604C
	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ParameterOverride[] parameterOverrides, int parameterOverridesCount, ParameterOverride parameterOverride) { }

	// RVA: 0x1386E30
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x1386F64
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x13870D0
	public static int GetBindingIndex(InputAction action, string group, string path) { }

	// RVA: 0x13871A4
	public static System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	// RVA: 0x1387328
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	// RVA: 0x1387500
	public static string GetBindingDisplayString(InputAction action, DisplayStringOptions options, string group) { }

	// RVA: 0x13876A0
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options) { }

	// RVA: 0x13878DC
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options) { }

	// RVA: 0x138795C
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, string deviceLayoutName, string controlPath, DisplayStringOptions options) { }

	// RVA: 0x1387FB4
	public static void ApplyBindingOverride(InputAction action, string newPath, string group, string path) { }

	// RVA: 0x13880B0
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	// RVA: 0x1388370
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x13885FC
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	// RVA: 0x1388214
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	// RVA: 0x1388444
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x13886DC
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	// RVA: 0x1388764
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x1388844
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x1388924
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	// RVA: 0x1388DD0
	public static void RemoveAllBindingOverrides(InputAction action) { }

	// RVA: 0x1388F34
	public static void ApplyBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x13892A8
	public static void RemoveBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x138961C
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	// RVA: 0x138977C
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	// RVA: 0x13898E8
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	// RVA: 0x1389F60
	public static string SaveBindingOverridesAsJson(InputAction action) { }

	// RVA: 0x1389DA0
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, InputAction action) { }

	// RVA: 0x138A330
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting) { }

	// RVA: 0x138A914
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting) { }

	// RVA: 0x138A4C0
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	// RVA: 0x138AAB8
	public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex) { }

	// RVA: 0x138407C
	internal static DeferBindingResolutionWrapper DeferBindingResolution() { }

}

// Namespace: UnityEngine.InputSystem
public enum InputActionPhase
{
	// Fields
	public int value__; // 0x10
	public const InputActionPhase Disabled = 0;
	public const InputActionPhase Waiting = 1;
	public const InputActionPhase Started = 2;
	public const InputActionPhase Performed = 3;
	public const InputActionPhase Canceled = 4;
}

// Namespace: UnityEngine.InputSystem
[Serializable]
public struct InputActionProperty
{
	// Fields
	private bool m_UseReference; // 0x10
	private InputAction m_Action; // 0x18
	private InputActionReference m_Reference; // 0x20

	// Methods

	// RVA: 0x138F8EC
	public InputAction get_action() { }

	// RVA: 0x138FA64
	public InputActionReference get_reference() { }

	// RVA: 0x138FA7C
	internal InputAction get_serializedAction() { }

	// RVA: 0x138FA84
	internal InputActionReference get_serializedReference() { }

	// RVA: 0x138FA8C
	public void .ctor(InputAction action) { }

	// RVA: 0x138FAC0
	public void .ctor(InputActionReference reference) { }

	// RVA: 0x138FB00
	public bool Equals(InputActionProperty other) { }

	// RVA: 0x138FBFC
	public bool Equals(InputAction other) { }

	// RVA: 0x138FCB8
	public bool Equals(InputActionReference other) { }

	// RVA: 0x138FD28
	public override bool Equals(object obj) { }

	// RVA: 0x138FEF0
	public override int GetHashCode() { }

	// RVA: 0x138FFAC
	public static bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	// RVA: 0x139009C
	public static bool op_Inequality(InputActionProperty left, InputActionProperty right) { }

}

// Namespace: UnityEngine.InputSystem
public class InputActionReference
{
	// Fields
	internal InputActionAsset m_Asset; // 0x18
	internal string m_ActionId; // 0x20
	private InputAction m_Action; // 0x28

	// Methods

	// RVA: 0x139017C
	public InputActionAsset get_asset() { }

	// RVA: 0x138F984
	public InputAction get_action() { }

	// RVA: 0x1390184
	public void Set(InputAction action) { }

	// RVA: 0x13904B4
	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	// RVA: 0x13902A0
	private void SetInternal(InputActionAsset asset, InputAction action) { }

	// RVA: 0x13907C8
	public override string ToString() { }

	// RVA: 0x13906E8
	internal static string GetDisplayName(InputAction action) { }

	// RVA: 0x1390B38
	internal string ToDisplayName() { }

	// RVA: 0x1390B84
	public static InputAction op_Implicit(InputActionReference reference) { }

	// RVA: 0x1390B90
	public static InputActionReference Create(InputAction action) { }

	// RVA: 0x1390C0C
	public InputAction ToInputAction() { }

	// RVA: 0x1390C10
	public void .ctor() { }

}

// Namespace: 
public struct BindingSyntax
{
	// Fields
	private readonly InputActionMap m_ActionMap; // 0x10
	private readonly InputAction m_Action; // 0x18
	internal readonly int m_BindingIndexInMap; // 0x20

	// Methods

	// RVA: 0x1393F44
	public bool get_valid() { }

	// RVA: 0x1393FBC
	public int get_bindingIndex() { }

	// RVA: 0x139405C
	public InputBinding get_binding() { }

	// RVA: 0x1394168
	internal void .ctor(InputActionMap map, int bindingIndexInMap, InputAction action) { }

	// RVA: 0x13941AC
	public BindingSyntax WithName(string name) { }

	// RVA: 0x13942C8
	public BindingSyntax WithPath(string path) { }

	// RVA: 0x13943E4
	public BindingSyntax WithGroup(string group) { }

	// RVA: 0x13945E0
	public BindingSyntax WithGroups(string groups) { }

	// RVA: 0x1394804
	public BindingSyntax WithInteraction(string interaction) { }

	// RVA: 0x1394A00
	public BindingSyntax WithInteractions(string interactions) { }

	// RVA: 0x316B894
	public BindingSyntax WithInteraction() { }

	// RVA: 0x1394C24
	public BindingSyntax WithProcessor(string processor) { }

	// RVA: 0x1394E20
	public BindingSyntax WithProcessors(string processors) { }

	// RVA: 0x316B894
	public BindingSyntax WithProcessor() { }

	// RVA: 0x1395044
	public BindingSyntax Triggering(InputAction action) { }

	// RVA: 0x1395224
	public BindingSyntax To(InputBinding binding) { }

	// RVA: 0x1395390
	public BindingSyntax NextBinding() { }

	// RVA: 0x1395534
	public BindingSyntax PreviousBinding() { }

	// RVA: 0x1395574
	public BindingSyntax NextPartBinding(string partName) { }

	// RVA: 0x1395824
	public BindingSyntax PreviousPartBinding(string partName) { }

	// RVA: 0x13958D4
	public BindingSyntax NextCompositeBinding(string compositeName) { }

	// RVA: 0x1395AE8
	public BindingSyntax PreviousCompositeBinding(string compositeName) { }

	// RVA: 0x13953D0
	private BindingSyntax Iterate(bool next) { }

	// RVA: 0x1395918
	private BindingSyntax IterateCompositeBinding(bool next, string compositeName) { }

	// RVA: 0x1395624
	private BindingSyntax IteratePartBinding(bool next, string partName) { }

	// RVA: 0x1395BA0
	public void Erase() { }

	// RVA: 0x1395DA8
	public BindingSyntax InsertPartBinding(string partName, string path) { }

}

// Namespace: 
public struct CompositeSyntax
{
	// Fields
	private readonly InputAction m_Action; // 0x10
	private readonly InputActionMap m_ActionMap; // 0x18
	private int m_BindingIndexInMap; // 0x20

	// Methods

	// RVA: 0x1395FEC
	public int get_bindingIndex() { }

	// RVA: 0x139601C
	internal void .ctor(InputActionMap map, InputAction action, int compositeIndex) { }

	// RVA: 0x1396068
	public CompositeSyntax With(string name, string binding, string groups, string processors) { }

}

// Namespace: 
public struct ControlSchemeSyntax
{
	// Fields
	private readonly InputActionAsset m_Asset; // 0x10
	private readonly int m_ControlSchemeIndex; // 0x18
	private InputControlScheme m_ControlScheme; // 0x20

	// Methods

	// RVA: 0x13962BC
	internal void .ctor(InputActionAsset asset, int index) { }

	// RVA: 0x13962F0
	internal void .ctor(InputControlScheme controlScheme) { }

	// RVA: 0x139633C
	public ControlSchemeSyntax WithBindingGroup(string bindingGroup) { }

	// RVA: 0x316B894
	public ControlSchemeSyntax WithRequiredDevice() { }

	// RVA: 0x316B894
	public ControlSchemeSyntax WithOptionalDevice() { }

	// RVA: 0x316B894
	public ControlSchemeSyntax OrWithRequiredDevice() { }

	// RVA: 0x316B894
	public ControlSchemeSyntax OrWithOptionalDevice() { }

	// RVA: 0x139647C
	public ControlSchemeSyntax WithRequiredDevice(string controlPath) { }

	// RVA: 0x13966E0
	public ControlSchemeSyntax WithOptionalDevice(string controlPath) { }

	// RVA: 0x1396718
	public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) { }

	// RVA: 0x1396750
	public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) { }

	// RVA: 0x30B1CD4
	private string DeviceTypeToControlPath() { }

	// RVA: 0x1396788
	public InputControlScheme Done() { }

	// RVA: 0x13964B4
	private void AddDeviceEntry(string controlPath, Flags flags) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public InputBinding binding; // 0x10

	// Methods

	// RVA: 0x1396870
	public void .ctor() { }

	// RVA: 0x1396878
	internal bool <RemoveAction>b__0(InputBinding b) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionSetupExtensions
{
	// Methods

	// RVA: 0x1390C18
	public static InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	// RVA: 0x1390E2C
	public static void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x13910C4
	public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x1391270
	public static void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x13913A4
	public static InputAction AddAction(InputActionMap map, string name, InputActionType type, string binding, string interactions, string processors, string groups, string expectedControlLayout) { }

	// RVA: 0x13917E8
	public static void RemoveAction(InputAction action) { }

	// RVA: 0x1391B70
	public static void RemoveAction(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x138F438
	public static BindingSyntax AddBinding(InputAction action, string path, string interactions, string processors, string groups) { }

	// RVA: 0x1391D90
	public static BindingSyntax AddBinding(InputAction action, InputControl control) { }

	// RVA: 0x1391C9C
	public static BindingSyntax AddBinding(InputAction action, InputBinding binding) { }

	// RVA: 0x1392068
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions, string groups, string action, string processors) { }

	// RVA: 0x13922F0
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions, string groups) { }

	// RVA: 0x1392460
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions, string groups) { }

	// RVA: 0x13921CC
	public static BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x1392560
	public static CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions, string processors) { }

	// RVA: 0x1391EBC
	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex) { }

	// RVA: 0x138D2EC
	public static BindingSyntax ChangeBinding(InputAction action, int index) { }

	// RVA: 0x139275C
	public static BindingSyntax ChangeBinding(InputAction action, string name) { }

	// RVA: 0x1392B0C
	public static BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	// RVA: 0x1392C28
	public static BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	// RVA: 0x1392D00
	public static BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	// RVA: 0x1392DD4
	public static BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	// RVA: 0x1392EAC
	public static BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	// RVA: 0x13927F4
	public static BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	// RVA: 0x1392F84
	public static BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	// RVA: 0x13931AC
	public static void Rename(InputAction action, string newName) { }

	// RVA: 0x1393490
	public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	// RVA: 0x13937B0
	public static ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x1393980
	public static void RemoveControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x1393AD8
	public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	// RVA: 0x1393B84
	public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	// RVA: 0x1393C94
	public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x1393D40
	public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x1393DEC
	public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x1393E98
	public static InputControlScheme OrWithOptionalDevice(InputControlScheme scheme, string controlPath) { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags TimerRunning = 1;
}

// Namespace: 
internal struct InteractionState
{
	// Fields
	private UInt16 m_TriggerControlIndex; // 0x10
	private Byte m_Phase; // 0x12
	private Byte m_Flags; // 0x13
	private float m_TimerDuration; // 0x14
	private Double m_StartTime; // 0x18
	private Double m_TimerStartTime; // 0x20
	private Double m_PerformedTime; // 0x28
	private float m_TotalTimeoutCompletionTimeDone; // 0x30
	private float m_TotalTimeoutCompletionTimeRemaining; // 0x34
	private Int64 m_TimerMonitorIndex; // 0x38

	// Methods

	// RVA: 0x1398804
	public int get_triggerControlIndex() { }

	// RVA: 0x1399AF0
	public void set_triggerControlIndex(int value) { }

	// RVA: 0x139F594
	public Double get_startTime() { }

	// RVA: 0x139F59C
	public void set_startTime(Double value) { }

	// RVA: 0x139F5A4
	public Double get_performedTime() { }

	// RVA: 0x139F5AC
	public void set_performedTime(Double value) { }

	// RVA: 0x139F5B4
	public Double get_timerStartTime() { }

	// RVA: 0x139F5BC
	public void set_timerStartTime(Double value) { }

	// RVA: 0x139F5C4
	public float get_timerDuration() { }

	// RVA: 0x139F5CC
	public void set_timerDuration(float value) { }

	// RVA: 0x139F5D4
	public float get_totalTimeoutCompletionDone() { }

	// RVA: 0x139F5DC
	public void set_totalTimeoutCompletionDone(float value) { }

	// RVA: 0x139F5E4
	public float get_totalTimeoutCompletionTimeRemaining() { }

	// RVA: 0x139F5EC
	public void set_totalTimeoutCompletionTimeRemaining(float value) { }

	// RVA: 0x139F5F4
	public Int64 get_timerMonitorIndex() { }

	// RVA: 0x139F5FC
	public void set_timerMonitorIndex(Int64 value) { }

	// RVA: 0x1399B6C
	public bool get_isTimerRunning() { }

	// RVA: 0x139CA48
	public void set_isTimerRunning(bool value) { }

	// RVA: 0x139F604
	public InputActionPhase get_phase() { }

	// RVA: 0x1399AE8
	public void set_phase(InputActionPhase value) { }

}

// Namespace: 
public enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags ChainsWithNext = 1;
	public const Flags EndOfChain = 2;
	public const Flags Composite = 4;
	public const Flags PartOfComposite = 8;
	public const Flags InitialStateCheckPending = 16;
	public const Flags WantsInitialStateCheck = 32;
}

// Namespace: 
internal struct BindingState
{
	// Fields
	private Byte m_ControlCount; // 0x10
	private Byte m_InteractionCount; // 0x11
	private Byte m_ProcessorCount; // 0x12
	private Byte m_MapIndex; // 0x13
	private Byte m_Flags; // 0x14
	private Byte m_PartIndex; // 0x15
	private UInt16 m_ActionIndex; // 0x16
	private UInt16 m_CompositeOrCompositeBindingIndex; // 0x18
	private UInt16 m_ProcessorStartIndex; // 0x1A
	private UInt16 m_InteractionStartIndex; // 0x1C
	private UInt16 m_ControlStartIndex; // 0x1E
	private Double m_PressTime; // 0x20
	private int m_TriggerEventIdForComposite; // 0x28
	private int __padding; // 0x2C

	// Methods

	// RVA: 0x139F60C
	public int get_controlStartIndex() { }

	// RVA: 0x139F614
	public void set_controlStartIndex(int value) { }

	// RVA: 0x139F6AC
	public int get_controlCount() { }

	// RVA: 0x139F6B4
	public void set_controlCount(int value) { }

	// RVA: 0x13987F0
	public int get_interactionStartIndex() { }

	// RVA: 0x139F74C
	public void set_interactionStartIndex(int value) { }

	// RVA: 0x139F7F0
	public int get_interactionCount() { }

	// RVA: 0x139F7F8
	public void set_interactionCount(int value) { }

	// RVA: 0x139DB7C
	public int get_processorStartIndex() { }

	// RVA: 0x139F890
	public void set_processorStartIndex(int value) { }

	// RVA: 0x139F934
	public int get_processorCount() { }

	// RVA: 0x139F93C
	public void set_processorCount(int value) { }

	// RVA: 0x1399764
	public int get_actionIndex() { }

	// RVA: 0x139F9D4
	public void set_actionIndex(int value) { }

	// RVA: 0x139FA78
	public int get_mapIndex() { }

	// RVA: 0x139FA80
	public void set_mapIndex(int value) { }

	// RVA: 0x1396E50
	public int get_compositeOrCompositeBindingIndex() { }

	// RVA: 0x139FB18
	public void set_compositeOrCompositeBindingIndex(int value) { }

	// RVA: 0x139FBBC
	public int get_triggerEventIdForComposite() { }

	// RVA: 0x139FBC4
	public void set_triggerEventIdForComposite(int value) { }

	// RVA: 0x139FBCC
	public Double get_pressTime() { }

	// RVA: 0x139FBD4
	public void set_pressTime(Double value) { }

	// RVA: 0x139FBDC
	public Flags get_flags() { }

	// RVA: 0x139FBE4
	public void set_flags(Flags value) { }

	// RVA: 0x139FBEC
	public bool get_chainsWithNext() { }

	// RVA: 0x139FBF8
	public void set_chainsWithNext(bool value) { }

	// RVA: 0x139FC0C
	public bool get_isEndOfChain() { }

	// RVA: 0x139FC18
	public void set_isEndOfChain(bool value) { }

	// RVA: 0x139FC38
	public bool get_isPartOfChain() { }

	// RVA: 0x1397D4C
	public bool get_isComposite() { }

	// RVA: 0x139FC48
	public void set_isComposite(bool value) { }

	// RVA: 0x1396E44
	public bool get_isPartOfComposite() { }

	// RVA: 0x139FC68
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x139B1F0
	public bool get_initialStateCheckPending() { }

	// RVA: 0x1399794
	public void set_initialStateCheckPending(bool value) { }

	// RVA: 0x1399788
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x139FC88
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x139FCA8
	public int get_partIndex() { }

	// RVA: 0x139FCB0
	public void set_partIndex(int value) { }

}

// Namespace: 
public enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags HaveMagnitude = 1;
	public const Flags PassThrough = 2;
	public const Flags MayNeedConflictResolution = 4;
	public const Flags HasMultipleConcurrentActuations = 8;
	public const Flags InProcessing = 16;
	public const Flags Button = 32;
	public const Flags Pressed = 64;
}

// Namespace: 
public struct TriggerState
{
	// Fields
	public const int kMaxNumMaps = 255;
	public const int kMaxNumControls = 65535;
	public const int kMaxNumBindings = 65535;
	private Byte m_Phase; // 0x10
	private Byte m_Flags; // 0x11
	private Byte m_MapIndex; // 0x12
	private UInt16 m_ControlIndex; // 0x14
	private Double m_Time; // 0x18
	private Double m_StartTime; // 0x20
	private UInt16 m_BindingIndex; // 0x28
	private UInt16 m_InteractionIndex; // 0x2A
	private float m_Magnitude; // 0x2C
	private UInt32 m_LastPerformedInUpdate; // 0x30
	private UInt32 m_LastCanceledInUpdate; // 0x34
	private UInt32 m_PressedInUpdate; // 0x38
	private UInt32 m_ReleasedInUpdate; // 0x3C
	private UInt32 m_LastCompletedInUpdate; // 0x40

	// Methods

	// RVA: 0x139FCB8
	public InputActionPhase get_phase() { }

	// RVA: 0x139975C
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x1399778
	public bool get_isDisabled() { }

	// RVA: 0x139FCC0
	public bool get_isWaiting() { }

	// RVA: 0x139FCD0
	public bool get_isStarted() { }

	// RVA: 0x139FCE0
	public bool get_isPerformed() { }

	// RVA: 0x139FCF0
	public bool get_isCanceled() { }

	// RVA: 0x139FD00
	public Double get_time() { }

	// RVA: 0x139FD08
	public void set_time(Double value) { }

	// RVA: 0x139FD10
	public Double get_startTime() { }

	// RVA: 0x139FD18
	public void set_startTime(Double value) { }

	// RVA: 0x139FD20
	public float get_magnitude() { }

	// RVA: 0x1399A44
	public void set_magnitude(float value) { }

	// RVA: 0x139FD28
	public bool get_haveMagnitude() { }

	// RVA: 0x139FD34
	public int get_mapIndex() { }

	// RVA: 0x1399B78
	public void set_mapIndex(int value) { }

	// RVA: 0x13987DC
	public int get_controlIndex() { }

	// RVA: 0x13999C8
	public void set_controlIndex(int value) { }

	// RVA: 0x139FD3C
	public int get_bindingIndex() { }

	// RVA: 0x13996F0
	public void set_bindingIndex(int value) { }

	// RVA: 0x1399A58
	public int get_interactionIndex() { }

	// RVA: 0x1399A6C
	public void set_interactionIndex(int value) { }

	// RVA: 0x139FD44
	public UInt32 get_lastPerformedInUpdate() { }

	// RVA: 0x139FD4C
	public void set_lastPerformedInUpdate(UInt32 value) { }

	// RVA: 0x139FD54
	public UInt32 get_lastCompletedInUpdate() { }

	// RVA: 0x139FD5C
	public void set_lastCompletedInUpdate(UInt32 value) { }

	// RVA: 0x139FD64
	public UInt32 get_lastCanceledInUpdate() { }

	// RVA: 0x139FD6C
	public void set_lastCanceledInUpdate(UInt32 value) { }

	// RVA: 0x139FD74
	public UInt32 get_pressedInUpdate() { }

	// RVA: 0x139FD7C
	public void set_pressedInUpdate(UInt32 value) { }

	// RVA: 0x139FD84
	public UInt32 get_releasedInUpdate() { }

	// RVA: 0x139FD8C
	public void set_releasedInUpdate(UInt32 value) { }

	// RVA: 0x139A250
	public bool get_isPassThrough() { }

	// RVA: 0x139BBCC
	public void set_isPassThrough(bool value) { }

	// RVA: 0x139BBEC
	public bool get_isButton() { }

	// RVA: 0x139BBF8
	public void set_isButton(bool value) { }

	// RVA: 0x139C94C
	public bool get_isPressed() { }

	// RVA: 0x139A670
	public void set_isPressed(bool value) { }

	// RVA: 0x139C958
	public bool get_mayNeedConflictResolution() { }

	// RVA: 0x139FD94
	public void set_mayNeedConflictResolution(bool value) { }

	// RVA: 0x139C964
	public bool get_hasMultipleConcurrentActuations() { }

	// RVA: 0x139A630
	public void set_hasMultipleConcurrentActuations(bool value) { }

	// RVA: 0x139D318
	public bool get_inProcessing() { }

	// RVA: 0x139A650
	public void set_inProcessing(bool value) { }

	// RVA: 0x139FDB4
	public Flags get_flags() { }

	// RVA: 0x139D324
	public void set_flags(Flags value) { }

}

// Namespace: 
public struct ActionMapIndices
{
	// Fields
	public int actionStartIndex; // 0x10
	public int actionCount; // 0x14
	public int controlStartIndex; // 0x18
	public int controlCount; // 0x1C
	public int bindingStartIndex; // 0x20
	public int bindingCount; // 0x24
	public int interactionStartIndex; // 0x28
	public int interactionCount; // 0x2C
	public int processorStartIndex; // 0x30
	public int processorCount; // 0x34
	public int compositeStartIndex; // 0x38
	public int compositeCount; // 0x3C
}

// Namespace: 
public struct UnmanagedMemory
{
	// Fields
	public Void* basePtr; // 0x10
	public int mapCount; // 0x18
	public int actionCount; // 0x1C
	public int interactionCount; // 0x20
	public int bindingCount; // 0x24
	public int controlCount; // 0x28
	public int compositeCount; // 0x2C
	public TriggerState* actionStates; // 0x30
	public BindingState* bindingStates; // 0x38
	public InteractionState* interactionStates; // 0x40
	public Single* controlMagnitudes; // 0x48
	public Single* compositeMagnitudes; // 0x50
	public Int32* enabledControls; // 0x58
	public UInt16* actionBindingIndicesAndCounts; // 0x60
	public UInt16* actionBindingIndices; // 0x68
	public Int32* controlIndexToBindingIndex; // 0x70
	public UInt16* controlGroupingAndComplexity; // 0x78
	public bool controlGroupingInitialized; // 0x80
	public ActionMapIndices* mapIndices; // 0x88

	// Methods

	// RVA: 0x139FDBC
	public bool get_isAllocated() { }

	// RVA: 0x139FDCC
	public int get_sizeInBytes() { }

	// RVA: 0x139FE1C
	public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) { }

	// RVA: 0x13973E4
	public void Dispose() { }

	// RVA: 0x139FF50
	public void CopyDataFrom(UnmanagedMemory memory) { }

	// RVA: 0x13975D4
	public UnmanagedMemory Clone() { }

}

// Namespace: 
internal struct GlobalState
{
	// Fields
	internal UnityEngine.InputSystem.Utilities.InlinedArray<System.Runtime.InteropServices.GCHandle> globalList; // 0x10
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.Object,UnityEngine.InputSystem.InputActionChange>> onActionChange; // 0x28
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.Object>> onActionControlsChanged; // 0x78
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputActionState.<>c <>9; // 0x0
	public static TypedRestore <>9__135_0; // 0x8
	public static Action <>9__135_1; // 0x10

	// Methods

	// RVA: 0x13A00C0
	private static void .cctor() { }

	// RVA: 0x13A012C
	public void .ctor() { }

	// RVA: 0x13A0134
	internal void <SaveAndResetState>b__135_0(GlobalState state) { }

	// RVA: 0x13A01A4
	internal void <SaveAndResetState>b__135_1() { }

}

// Namespace: UnityEngine.InputSystem
internal class InputActionState
{
	// Fields
	public const int kInvalidIndex = 4294967295;
	public InputActionMap[] maps; // 0x10
	public InputControl[] controls; // 0x18
	public IInputInteraction[] interactions; // 0x20
	public InputProcessor[] processors; // 0x28
	public InputBindingComposite[] composites; // 0x30
	public int totalProcessorCount; // 0x38
	public UnmanagedMemory memory; // 0x40
	private bool m_OnBeforeUpdateHooked; // 0xC0
	private bool m_OnAfterUpdateHooked; // 0xC1
	private bool m_InProcessControlStateChange; // 0xC2
	private InputEventPtr m_CurrentlyProcessingThisEvent; // 0xC8
	private Action m_OnBeforeUpdateDelegate; // 0xD0
	private Action m_OnAfterUpdateDelegate; // 0xD8
	internal static GlobalState s_GlobalState; // 0x0

	// Methods

	// RVA: 0x139691C
	public int get_totalCompositeCount() { }

	// RVA: 0x1396924
	public int get_totalMapCount() { }

	// RVA: 0x139692C
	public int get_totalActionCount() { }

	// RVA: 0x1396934
	public int get_totalBindingCount() { }

	// RVA: 0x139693C
	public int get_totalInteractionCount() { }

	// RVA: 0x1396944
	public int get_totalControlCount() { }

	// RVA: 0x139694C
	public ActionMapIndices* get_mapIndices() { }

	// RVA: 0x1396954
	public TriggerState* get_actionStates() { }

	// RVA: 0x139695C
	public BindingState* get_bindingStates() { }

	// RVA: 0x1396964
	public InteractionState* get_interactionStates() { }

	// RVA: 0x139696C
	public Int32* get_controlIndexToBindingIndex() { }

	// RVA: 0x1396974
	public UInt16* get_controlGroupingAndComplexity() { }

	// RVA: 0x139697C
	public Single* get_controlMagnitudes() { }

	// RVA: 0x1396984
	public UInt32* get_enabledControls() { }

	// RVA: 0x139698C
	public bool get_isProcessingControlStateChange() { }

	// RVA: 0x1396994
	public void Initialize(InputBindingResolver resolver) { }

	// RVA: 0x1396C58
	private void ComputeControlGroupingIfNecessary() { }

	// RVA: 0x1396AE0
	public void ClaimDataFrom(InputBindingResolver resolver) { }

	// RVA: 0x1396E64
	protected override void Finalize() { }

	// RVA: 0x1397104
	public void Dispose() { }

	// RVA: 0x1396F44
	private void Destroy(bool isFinalizing) { }

	// RVA: 0x139742C
	public InputActionState Clone() { }

	// RVA: 0x1397798
	private object System.ICloneable.Clone() { }

	// RVA: 0x139779C
	private bool IsUsingDevice(InputDevice device) { }

	// RVA: 0x139799C
	private bool CanUseDevice(InputDevice device) { }

	// RVA: 0x1397BEC
	public bool HasEnabledActions() { }

	// RVA: 0x1397C6C
	private void FinishBindingCompositeSetups() { }

	// RVA: 0x1397D64
	internal void PrepareForBindingReResolution(bool needFullResolve, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& activeControls, bool hasEnabledActions) { }

	// RVA: 0x1398C44
	public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x1398CEC
	private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x1399F8C
	private bool IsActiveControl(int bindingIndex, int controlIndex) { }

	// RVA: 0x139995C
	private int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	// RVA: 0x139A038
	private void ResetActionStatesDrivenBy(InputDevice device) { }

	// RVA: 0x139A25C
	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	// RVA: 0x139893C
	public void ResetActionState(int actionIndex, InputActionPhase toPhase, bool hardReset) { }

	// RVA: 0x139A690
	public TriggerState FetchActionState(InputAction action) { }

	// RVA: 0x139A6B8
	public ActionMapIndices FetchMapIndices(InputActionMap map) { }

	// RVA: 0x139A6F0
	public void EnableAllActions(InputActionMap map) { }

	// RVA: 0x139A8F4
	private void EnableControls(InputActionMap map) { }

	// RVA: 0x139A938
	public void EnableSingleAction(InputAction action) { }

	// RVA: 0x139AA40
	private void EnableControls(InputAction action) { }

	// RVA: 0x13984BC
	public void DisableAllActions(InputActionMap map) { }

	// RVA: 0x1398B00
	public void DisableControls(InputActionMap map) { }

	// RVA: 0x139AB04
	public void DisableSingleAction(InputAction action) { }

	// RVA: 0x139AC04
	private void DisableControls(InputAction action) { }

	// RVA: 0x13997B4
	private void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x139710C
	private void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x139AD9C
	public void SetInitialStateCheckPending(int actionIndex, bool value) { }

	// RVA: 0x139AD14
	private void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) { }

	// RVA: 0x139ACC8
	private bool IsControlEnabled(int controlIndex) { }

	// RVA: 0x139AD60
	private void SetControlEnabled(int controlIndex, bool state) { }

	// RVA: 0x1399D70
	private void HookOnBeforeUpdate() { }

	// RVA: 0x139AE38
	private void UnhookOnBeforeUpdate() { }

	// RVA: 0x139AEB8
	private void OnBeforeInitialUpdate() { }

	// RVA: 0x139B1FC
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 mapControlAndBindingIndex) { }

	// RVA: 0x139B870
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 mapControlAndBindingIndex, int interactionIndex) { }

	// RVA: 0x139ACEC
	private Int64 ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x139B214
	private void SplitUpMapAndControlAndBindingIndex(Int64 mapControlAndBindingIndex, int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x139BBC4
	internal static int GetComplexityFromMonitorIndex(Int64 mapControlAndBindingIndex) { }

	// RVA: 0x139B230
	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x139C2B8
	private void ProcessButtonState(TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) { }

	// RVA: 0x139BC18
	private static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) { }

	// RVA: 0x139BE94
	private bool IsConflictingInput(TriggerState trigger, int actionIndex) { }

	// RVA: 0x139A31C
	private UInt16 GetActionBindingStartIndexAndCount(int actionIndex, UInt16 bindingCount) { }

	// RVA: 0x139C480
	private void ProcessDefaultInteraction(TriggerState trigger, int actionIndex) { }

	// RVA: 0x139BC78
	private void ProcessInteractions(TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	// RVA: 0x139B888
	private void ProcessTimeout(Double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	// RVA: 0x139CA5C
	internal void SetTotalTimeoutCompletionTime(float seconds, TriggerState trigger) { }

	// RVA: 0x1399BE4
	internal void StartTimeout(float seconds, TriggerState trigger) { }

	// RVA: 0x139CA8C
	private void StopTimeout(int interactionIndex) { }

	// RVA: 0x139CB70
	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, TriggerState trigger, InputActionPhase phaseAfterPerformed, InputActionPhase phaseAfterCanceled, bool processNextInteractionOnCancel) { }

	// RVA: 0x139A3EC
	private bool ChangePhaseOfAction(InputActionPhase newPhase, TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled) { }

	// RVA: 0x139D01C
	private void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, TriggerState trigger, bool isDisablingAction) { }

	// RVA: 0x139D32C
	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>& listeners, string callbackName) { }

	// RVA: 0x139D530
	private object GetActionOrNoneString(TriggerState trigger) { }

	// RVA: 0x139D630
	internal InputAction GetActionOrNull(int bindingIndex) { }

	// RVA: 0x139D598
	internal InputAction GetActionOrNull(TriggerState trigger) { }

	// RVA: 0x139D6C8
	internal InputControl GetControl(TriggerState trigger) { }

	// RVA: 0x139D70C
	private IInputInteraction GetInteractionOrNull(TriggerState trigger) { }

	// RVA: 0x139D75C
	internal int GetBindingIndexInMap(int bindingIndex) { }

	// RVA: 0x139D798
	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	// RVA: 0x139D7C4
	internal BindingState GetBindingState(int bindingIndex) { }

	// RVA: 0x139D7D4
	internal InputBinding GetBinding(int bindingIndex) { }

	// RVA: 0x139D854
	internal InputActionMap GetActionMap(int bindingIndex) { }

	// RVA: 0x139A33C
	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	// RVA: 0x1398818
	private void ResetInteractionState(int interactionIndex) { }

	// RVA: 0x139D898
	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	// RVA: 0x139D930
	internal Type GetValueType(int bindingIndex, int controlIndex) { }

	// RVA: 0x139C970
	internal static bool IsActuated(TriggerState trigger, float threshold) { }

	// RVA: 0x139D9C8
	internal void ReadValue(int bindingIndex, int controlIndex, Void* buffer, int bufferSize, bool ignoreComposites) { }

	// RVA: 0x316B894
	internal TValue ReadValue(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x316B894
	internal TValue ApplyProcessors(int bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType) { }

	// RVA: 0x139DB90
	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	// RVA: 0x139DC74
	internal Double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	// RVA: 0x316B894
	internal TValue ReadCompositePartValue(int bindingIndex, int partNumber, Boolean* buttonValuePtr, int controlIndex, TComparer comparer) { }

	// RVA: 0x139DCFC
	internal bool ReadCompositePartValue(int bindingIndex, int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x139DEE8
	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	// RVA: 0x139E0B4
	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x139E254
	internal bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	// RVA: 0x139E38C
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x1396BBC
	private void AddToGlobalList() { }

	// RVA: 0x13972AC
	private void RemoveMapFromGlobalList() { }

	// RVA: 0x139E5C8
	private static void CompactGlobalList() { }

	// RVA: 0x1398B44
	internal void NotifyListenersOfActionChange(InputActionChange change) { }

	// RVA: 0x1399E8C
	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	// RVA: 0x139E768
	private static void ResetGlobals() { }

	// RVA: 0x139EA4C
	internal static int FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result) { }

	// RVA: 0x139EE24
	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x139F158
	internal static void DeferredResolutionOfBindings() { }

	// RVA: 0x139F420
	internal static void DisableAllActions() { }

	// RVA: 0x139E8B0
	internal static void DestroyAllActionMapStates() { }

	// RVA: 0x13975CC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public enum InputActionType
{
	// Fields
	public int value__; // 0x10
	public const InputActionType Value = 0;
	public const InputActionType Button = 1;
	public const InputActionType PassThrough = 2;
}

// Namespace: 
public enum DisplayStringOptions
{
	// Fields
	public int value__; // 0x10
	public const DisplayStringOptions DontUseShortDisplayNames = 1;
	public const DisplayStringOptions DontOmitDevice = 2;
	public const DisplayStringOptions DontIncludeInteractions = 4;
	public const DisplayStringOptions IgnoreBindingOverrides = 8;
}

// Namespace: 
internal enum MatchOptions
{
	// Fields
	public int value__; // 0x10
	public const MatchOptions EmptyGroupMatchesAny = 1;
}

// Namespace: 
internal enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags None = 0;
	public const Flags Composite = 4;
	public const Flags PartOfComposite = 8;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputBinding.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean> <>9__45_0; // 0x8

	// Methods

	// RVA: 0x13A1268
	private static void .cctor() { }

	// RVA: 0x13A12D4
	public void .ctor() { }

	// RVA: 0x13A12DC
	internal bool <MaskByGroups>b__45_0(string x) { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
public struct InputBinding
{
	// Fields
	public const Char Separator = 59;
	internal const string kSeparatorString = ";";
	private string m_Name; // 0x10
	internal string m_Id; // 0x18
	private string m_Path; // 0x20
	private string m_Interactions; // 0x28
	private string m_Processors; // 0x30
	internal string m_Groups; // 0x38
	private string m_Action; // 0x40
	internal Flags m_Flags; // 0x48
	private string m_OverridePath; // 0x50
	private string m_OverrideInteractions; // 0x58
	private string m_OverrideProcessors; // 0x60

	// Methods

	// RVA: 0x13A01A8
	public string get_name() { }

	// RVA: 0x13A01B0
	public void set_name(string value) { }

	// RVA: 0x13A01B8
	public Guid get_id() { }

	// RVA: 0x13A021C
	public void set_id(Guid value) { }

	// RVA: 0x13A0260
	public string get_path() { }

	// RVA: 0x13A0268
	public void set_path(string value) { }

	// RVA: 0x13A0270
	public string get_overridePath() { }

	// RVA: 0x13A0278
	public void set_overridePath(string value) { }

	// RVA: 0x13A0280
	public string get_interactions() { }

	// RVA: 0x13A0288
	public void set_interactions(string value) { }

	// RVA: 0x13A0290
	public string get_overrideInteractions() { }

	// RVA: 0x13A0298
	public void set_overrideInteractions(string value) { }

	// RVA: 0x13A02A0
	public string get_processors() { }

	// RVA: 0x13A02A8
	public void set_processors(string value) { }

	// RVA: 0x13A02B0
	public string get_overrideProcessors() { }

	// RVA: 0x13A02B8
	public void set_overrideProcessors(string value) { }

	// RVA: 0x13A02C0
	public string get_groups() { }

	// RVA: 0x13A02C8
	public void set_groups(string value) { }

	// RVA: 0x13A02D0
	public string get_action() { }

	// RVA: 0x13A02D8
	public void set_action(string value) { }

	// RVA: 0x1395B88
	public bool get_isComposite() { }

	// RVA: 0x13A02E0
	public void set_isComposite(bool value) { }

	// RVA: 0x1395B94
	public bool get_isPartOfComposite() { }

	// RVA: 0x1395FCC
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x13A0300
	public bool get_hasOverrides() { }

	// RVA: 0x13A0330
	public void .ctor(string path, string action, string groups, string processors, string interactions, string name) { }

	// RVA: 0x13A0408
	public string GetNameOfComposite() { }

	// RVA: 0x13A0458
	internal void GenerateId() { }

	// RVA: 0x13A04A4
	internal void RemoveOverrides() { }

	// RVA: 0x13A04E8
	public static InputBinding MaskByGroup(string group) { }

	// RVA: 0x13A0554
	public static InputBinding MaskByGroups(string[] groups) { }

	// RVA: 0x1397BD4
	public string get_effectivePath() { }

	// RVA: 0x13A06FC
	public string get_effectiveInteractions() { }

	// RVA: 0x13A0714
	public string get_effectiveProcessors() { }

	// RVA: 0x13A072C
	internal bool get_isEmpty() { }

	// RVA: 0x13A0798
	public bool Equals(InputBinding other) { }

	// RVA: 0x13A08BC
	public override bool Equals(object obj) { }

	// RVA: 0x13968DC
	public static bool op_Equality(InputBinding left, InputBinding right) { }

	// RVA: 0x13A0974
	public static bool op_Inequality(InputBinding left, InputBinding right) { }

	// RVA: 0x13A09DC
	public override int GetHashCode() { }

	// RVA: 0x13A0AF0
	public override string ToString() { }

	// RVA: 0x13A0C30
	public string ToDisplayString(DisplayStringOptions options, InputControl control) { }

	// RVA: 0x13A0C60
	public string ToDisplayString(string deviceLayoutName, string controlPath, DisplayStringOptions options, InputControl control) { }

	// RVA: 0x1395B2C
	internal bool TriggersAction(InputAction action) { }

	// RVA: 0x13A10B0
	public bool Matches(InputBinding binding) { }

	// RVA: 0x13A10B8
	internal bool Matches(InputBinding binding, MatchOptions options) { }

}

// Namespace: 
private sealed class <GetPartNames>d__12
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string composite; // 0x28
	public string <>3__composite; // 0x30
	private FieldInfo[] <>7__wrap1; // 0x38
	private int <>7__wrap2; // 0x40

	// Methods

	// RVA: 0x13A168C
	public void .ctor(int <>1__state) { }

	// RVA: 0x13A17E8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13A17EC
	private bool MoveNext() { }

	// RVA: 0x13A1A00
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13A1A08
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13A1A48
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13A1A50
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13A1AF8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputBindingComposite
{
	// Fields
	internal static TypeTable s_Composites; // 0x0

	// Methods

	// RVA: -1
	public abstract Type get_valueType() { }

	// RVA: -1
	public abstract int get_valueSizeInBytes() { }

	// RVA: -1
	public abstract void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: -1
	public abstract object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13A12FC
	public virtual float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A1304
	protected virtual void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x1397D58
	internal void CallFinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13A1308
	internal static Type GetValueType(string composite) { }

	// RVA: 0x13A1468
	public static string GetExpectedControlLayoutName(string composite, string part) { }

	// RVA: 0x13A1604
	internal static System.Collections.Generic.IEnumerable<System.String> GetPartNames(string composite) { }

	// RVA: 0x13A16C4
	internal static string GetDisplayFormatString(string composite) { }

	// RVA: 0x13A17E0
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputBindingComposite<T0>
{
	// Methods

	// RVA: 0x30B1CD4
	public override Type get_valueType() { }

	// RVA: 0x30B199C
	public override int get_valueSizeInBytes() { }

	// RVA: -1
	public abstract TValue ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x316B894
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x30B1D84
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: 
public struct PartBinding
{
	// Fields
	private int <part>k__BackingField; // 0x10
	private InputControl <control>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13A1D70
	public int get_part() { }

	// RVA: 0x13A1D78
	public void set_part(int value) { }

	// RVA: 0x13A1D80
	public InputControl get_control() { }

	// RVA: 0x13A1D88
	public void set_control(InputControl value) { }

}

// Namespace: 
private struct DefaultComparer<T0>
{
	// Methods

	// RVA: 0x316B894
	public int Compare(TValue x, TValue y) { }

}

// Namespace: 
private sealed class <get_controls>d__2
{
	// Fields
	private int <>1__state; // 0x10
	private PartBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	public InputBindingCompositeContext <>4__this; // 0x30
	public InputBindingCompositeContext <>3__<>4__this; // 0x40
	private int <totalBindingCount>5__2; // 0x50
	private int <bindingIndex>5__3; // 0x54
	private BindingState <bindingState>5__4; // 0x58
	private int <controlStartIndex>5__5; // 0x78
	private int <i>5__6; // 0x7C

	// Methods

	// RVA: 0x13A1B88
	public void .ctor(int <>1__state) { }

	// RVA: 0x13A1D90
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13A1D94
	private bool MoveNext() { }

	// RVA: 0x13A1EDC
	private PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current() { }

	// RVA: 0x13A1EE8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13A1F28
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13A1F90
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() { }

	// RVA: 0x13A203C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public struct InputBindingCompositeContext
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal int m_BindingIndex; // 0x18

	// Methods

	// RVA: 0x13A1AFC
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls() { }

	// RVA: 0x13A1BC0
	public float EvaluateMagnitude(int partNumber) { }

	// RVA: 0x316B894
	public TValue ReadValue(int partNumber) { }

	// RVA: 0x316B894
	public TValue ReadValue(int partNumber, InputControl sourceControl) { }

	// RVA: 0x316B894
	public TValue ReadValue(int partNumber, TComparer comparer) { }

	// RVA: 0x316B894
	public TValue ReadValue(int partNumber, InputControl sourceControl, TComparer comparer) { }

	// RVA: 0x13A1BE8
	public bool ReadValueAsButton(int partNumber) { }

	// RVA: 0x13A1C80
	public void ReadValue(int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x13A1CA4
	public object ReadValueAsObject(int partNumber) { }

	// RVA: 0x13A1CCC
	public Double GetPressTime(int partNumber) { }

}

// Namespace: UnityEngine.InputSystem
internal struct InputBindingResolver
{
	// Fields
	public int totalProcessorCount; // 0x10
	public int totalCompositeCount; // 0x14
	public int totalInteractionCount; // 0x18
	public InputActionMap[] maps; // 0x20
	public InputControl[] controls; // 0x28
	public UnmanagedMemory memory; // 0x30
	public IInputInteraction[] interactions; // 0xB0
	public InputProcessor[] processors; // 0xB8
	public InputBindingComposite[] composites; // 0xC0
	public System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask; // 0xC8
	private bool m_IsControlOnlyResolve; // 0x128
	private System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters> m_Parameters; // 0x130

	// Methods

	// RVA: 0x13A2040
	public int get_totalMapCount() { }

	// RVA: 0x13A2048
	public int get_totalActionCount() { }

	// RVA: 0x13A2050
	public int get_totalBindingCount() { }

	// RVA: 0x13A2058
	public int get_totalControlCount() { }

	// RVA: 0x13A2060
	public void Dispose() { }

	// RVA: 0x13A20AC
	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

	// RVA: 0x13A224C
	public void AddActionMap(InputActionMap actionMap) { }

	// RVA: 0x316B894
	private int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, TType[] array, int count, InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x13A3CF0
	private static InputBindingComposite InstantiateBindingComposite(InputBinding binding, InputActionMap actionMap) { }

	// RVA: 0x13A41B4
	private static void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, InputActionMap actionMap, InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	// RVA: 0x13A3F7C
	private static int AssignCompositePartIndex(object composite, string name, int currentCompositePartCount) { }

}

// Namespace: 
internal enum Result
{
	// Fields
	public int value__; // 0x10
	public const Result AllSatisfied = 0;
	public const Result MissingRequired = 1;
	public const Result MissingOptional = 2;
}

// Namespace: 
public struct Match
{
	// Fields
	internal int m_RequirementIndex; // 0x10
	internal DeviceRequirement[] m_Requirements; // 0x18
	internal UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls; // 0x20

	// Methods

	// RVA: 0x13B6384
	public InputControl get_control() { }

	// RVA: 0x13B63DC
	public InputDevice get_device() { }

	// RVA: 0x13B6440
	public int get_requirementIndex() { }

	// RVA: 0x13B6448
	public DeviceRequirement get_requirement() { }

	// RVA: 0x13B6480
	public bool get_isOptional() { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	internal int m_Index; // 0x10
	internal DeviceRequirement[] m_Requirements; // 0x18
	internal UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls; // 0x20

	// Methods

	// RVA: 0x13B64C8
	public bool MoveNext() { }

	// RVA: 0x13B64F4
	public void Reset() { }

	// RVA: 0x13B6500
	public Match get_Current() { }

	// RVA: 0x13B65BC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13B6628
	public void Dispose() { }

}

// Namespace: 
public struct MatchResult
{
	// Fields
	internal Result m_Result; // 0x10
	internal float m_Score; // 0x14
	internal UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices; // 0x18
	internal UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls; // 0x38
	internal DeviceRequirement[] m_Requirements; // 0x58

	// Methods

	// RVA: 0x13B5F88
	public float get_score() { }

	// RVA: 0x13B5F90
	public bool get_isSuccessfulMatch() { }

	// RVA: 0x13B5FA0
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x13B5FB0
	public bool get_hasMissingOptionalDevices() { }

	// RVA: 0x13B5FC0
	public UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13B6110
	public Match get_Item(int index) { }

	// RVA: 0x13B61D0
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator() { }

	// RVA: 0x13B6270
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13B6310
	public void Dispose() { }

}

// Namespace: 
internal enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags None = 0;
	public const Flags Optional = 1;
	public const Flags Or = 2;
}

// Namespace: 
[Serializable]
public struct DeviceRequirement
{
	// Fields
	internal string m_ControlPath; // 0x10
	internal Flags m_Flags; // 0x18

	// Methods

	// RVA: 0x13B662C
	public string get_controlPath() { }

	// RVA: 0x13B6634
	public void set_controlPath(string value) { }

	// RVA: 0x13B64BC
	public bool get_isOptional() { }

	// RVA: 0x13B663C
	public void set_isOptional(bool value) { }

	// RVA: 0x13B6650
	public bool get_isAND() { }

	// RVA: 0x13B666C
	public void set_isAND(bool value) { }

	// RVA: 0x13B6660
	public bool get_isOR() { }

	// RVA: 0x13B668C
	public void set_isOR(bool value) { }

	// RVA: 0x13B66AC
	public override string ToString() { }

	// RVA: 0x13B6788
	public bool Equals(DeviceRequirement other) { }

	// RVA: 0x13B6810
	public override bool Equals(object obj) { }

	// RVA: 0x13B68E4
	public override int GetHashCode() { }

	// RVA: 0x13B5BD8
	public static bool op_Equality(DeviceRequirement left, DeviceRequirement right) { }

	// RVA: 0x13B69F0
	public static bool op_Inequality(DeviceRequirement left, DeviceRequirement right) { }

}

// Namespace: 
[Serializable]
public struct DeviceJson
{
	// Fields
	public string devicePath; // 0x10
	public bool isOptional; // 0x18
	public bool isOR; // 0x19

	// Methods

	// RVA: 0x13B6C3C
	public DeviceRequirement ToDeviceEntry() { }

	// RVA: 0x13B6E24
	public static DeviceJson From(DeviceRequirement requirement) { }

}

// Namespace: 
[Serializable]
internal struct SchemeJson
{
	// Fields
	public string name; // 0x10
	public string bindingGroup; // 0x18
	public DeviceJson[] devices; // 0x20

	// Methods

	// RVA: 0x13B6A54
	public InputControlScheme ToScheme() { }

	// RVA: 0x13B6C90
	public static SchemeJson ToJson(InputControlScheme scheme) { }

	// RVA: 0x13B6E6C
	public static SchemeJson[] ToJson(InputControlScheme[] schemes) { }

	// RVA: 0x13B6FA8
	public static InputControlScheme[] ToSchemes(SchemeJson[] schemes) { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
public struct InputControlScheme
{
	// Fields
	internal string m_Name; // 0x10
	internal string m_BindingGroup; // 0x18
	internal DeviceRequirement[] m_DeviceRequirements; // 0x20

	// Methods

	// RVA: 0x13B5658
	public string get_name() { }

	// RVA: 0x13B5660
	public string get_bindingGroup() { }

	// RVA: 0x13B5668
	public void set_bindingGroup(string value) { }

	// RVA: 0x13B5670
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements() { }

	// RVA: 0x13B56DC
	public void .ctor(string name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, string bindingGroup) { }

	// RVA: 0x13B5810
	internal void SetNameAndBindingGroup(string name, string bindingGroup) { }

	// RVA: 0x316B894
	public static System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch) { }

	// RVA: 0x316B894
	public static bool FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputControlScheme controlScheme, MatchResult matchResult, InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch) { }

	// RVA: 0x316B894
	public static System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice(InputDevice device, TSchemes schemes) { }

	// RVA: 0x13B58F4
	public bool SupportsDevice(InputDevice device) { }

	// RVA: 0x316B894
	public MatchResult PickDevicesFrom(TDevices devices, InputDevice favorDevice) { }

	// RVA: 0x13B5A64
	public bool Equals(InputControlScheme other) { }

	// RVA: 0x13B5C40
	public override bool Equals(object obj) { }

	// RVA: 0x13B5CE8
	public override int GetHashCode() { }

	// RVA: 0x13B5D80
	public override string ToString() { }

	// RVA: 0x13B5F24
	public static bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	// RVA: 0x13B5F54
	public static bool op_Inequality(InputControlScheme left, InputControlScheme right) { }

}

// Namespace: 
internal enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags TimerHasExpired = 2;
}

// Namespace: UnityEngine.InputSystem
public struct InputInteractionContext
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal Flags m_Flags; // 0x18
	internal TriggerState m_TriggerState; // 0x1C

	// Methods

	// RVA: 0x13B70C0
	public InputAction get_action() { }

	// RVA: 0x13B70E8
	public InputControl get_control() { }

	// RVA: 0x13B7110
	public InputActionPhase get_phase() { }

	// RVA: 0x13B7118
	public Double get_time() { }

	// RVA: 0x13B7120
	public Double get_startTime() { }

	// RVA: 0x13B7128
	public bool get_timerHasExpired() { }

	// RVA: 0x13B7134
	internal void set_timerHasExpired(bool value) { }

	// RVA: 0x13B7154
	public bool get_isWaiting() { }

	// RVA: 0x13B7164
	public bool get_isStarted() { }

	// RVA: 0x13B7174
	public float ComputeMagnitude() { }

	// RVA: 0x13B717C
	public bool ControlIsActuated(float threshold) { }

	// RVA: 0x13B7188
	public void Started() { }

	// RVA: 0x13B71C8
	public void Performed() { }

	// RVA: 0x13B7210
	public void PerformedAndStayStarted() { }

	// RVA: 0x13B7258
	public void PerformedAndStayPerformed() { }

	// RVA: 0x13B72A0
	public void Canceled() { }

	// RVA: 0x13B72E8
	public void Waiting() { }

	// RVA: 0x13B7330
	public void SetTimeout(float seconds) { }

	// RVA: 0x13B7358
	public void SetTotalTimeoutCompletionTime(float seconds) { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x13B73EC
	internal int get_mapIndex() { }

	// RVA: 0x13B73F4
	internal int get_controlIndex() { }

	// RVA: 0x13B7400
	internal int get_bindingIndex() { }

	// RVA: 0x13B7408
	internal int get_interactionIndex() { }

}

// Namespace: 
public struct <data>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
private struct StateEventBuffer
{
	// Fields
	public StateEvent stateEvent; // 0x10
	public const int kMaxSize = 512;
	public UnityEngine.InputSystem.InputSystem.StateEventBuffer.<data>e__FixedBuffer data; // 0x29
}

// Namespace: 
public struct <data>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
private struct DeltaStateEventBuffer
{
	// Fields
	public DeltaStateEvent stateEvent; // 0x10
	public const int kMaxSize = 512;
	public UnityEngine.InputSystem.InputSystem.DeltaStateEventBuffer.<data>e__FixedBuffer data; // 0x2D
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputSystem.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputControl> <>9__79_0; // 0x8
	public static System.Func<UnityEngine.InputSystem.InputControl,System.Boolean> <>9__79_1; // 0x10

	// Methods

	// RVA: 0x13BD624
	private static void .cctor() { }

	// RVA: 0x13BD690
	public void .ctor() { }

	// RVA: 0x13BD698
	internal InputControl <get_onAnyButtonPress>b__79_0(InputEventPtr e) { }

	// RVA: 0x13BD8F4
	internal bool <get_onAnyButtonPress>b__79_1(InputControl c) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputSystem
{
	// Fields
	internal const string kAssemblyVersion = "1.8.1";
	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8";
	internal static InputManager s_Manager; // 0x0
	internal static InputRemoting s_Remote; // 0x8

	// Methods

	// RVA: 0x13B7414
	public static void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13B7554
	public static void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13B7694
	public static void RegisterLayout(Type type, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x316B894
	public static void RegisterLayout(string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x13B788C
	public static void RegisterLayout(string json, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x13B79DC
	public static void RegisterLayoutOverride(string json, string name) { }

	// RVA: 0x13B7A78
	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x316B894
	public static void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x13B7B10
	public static void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x30B8148
	public static void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x13B7CCC
	public static void RemoveLayout(string name) { }

	// RVA: 0x13B7D5C
	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x13B7DF8
	public static System.Collections.Generic.IEnumerable<System.String> ListLayouts() { }

	// RVA: 0x13B7E7C
	public static System.Collections.Generic.IEnumerable<System.String> ListLayoutsBasedOn(string baseLayout) { }

	// RVA: 0x13B7F44
	public static InputControlLayout LoadLayout(string name) { }

	// RVA: 0x30B5790
	public static InputControlLayout LoadLayout() { }

	// RVA: 0x13B8030
	public static string GetNameOfBaseLayout(string layoutName) { }

	// RVA: 0x13B8160
	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	// RVA: 0x13B82C0
	public static void RegisterProcessor(Type type, string name) { }

	// RVA: 0x30B8148
	public static void RegisterProcessor(string name) { }

	// RVA: 0x13B8758
	public static Type TryGetProcessor(string name) { }

	// RVA: 0x13B8838
	public static System.Collections.Generic.IEnumerable<System.String> ListProcessors() { }

	// RVA: 0x13B88D0
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13B8950
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices() { }

	// RVA: 0x13B8A08
	public static void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13B8B8C
	public static void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13B8D10
	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13B8E94
	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13B9018
	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13B9158
	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13B9298
	public static float get_pollingFrequency() { }

	// RVA: 0x13B9318
	public static void set_pollingFrequency(float value) { }

	// RVA: 0x13B93A8
	public static InputDevice AddDevice(string layout, string name, string variants) { }

	// RVA: 0x316B894
	public static TDevice AddDevice(string name) { }

	// RVA: 0x13B94AC
	public static InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x13B95AC
	public static void AddDevice(InputDevice device) { }

	// RVA: 0x13B9668
	public static void RemoveDevice(InputDevice device) { }

	// RVA: 0x13B96FC
	public static void FlushDisconnectedDevices() { }

	// RVA: 0x13B977C
	public static InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x316B894
	public static TDevice GetDevice() { }

	// RVA: 0x13B980C
	public static InputDevice GetDevice(Type type) { }

	// RVA: 0x316B894
	public static TDevice GetDevice(InternedString usage) { }

	// RVA: 0x316B894
	public static TDevice GetDevice(string usage) { }

	// RVA: 0x13B9B24
	public static InputDevice GetDeviceById(int deviceId) { }

	// RVA: 0x13B9BB4
	public static System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices() { }

	// RVA: 0x13B9CC0
	public static int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x13B9D50
	public static void EnableDevice(InputDevice device) { }

	// RVA: 0x13B9DE8
	public static void DisableDevice(InputDevice device, bool keepSendingEvents) { }

	// RVA: 0x13B9E84
	public static bool TrySyncDevice(InputDevice device) { }

	// RVA: 0x13BA048
	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls) { }

	// RVA: 0x13BA0E4
	public static bool TryResetDevice(InputDevice device) { }

	// RVA: 0x13BA238
	public static void PauseHaptics() { }

	// RVA: 0x13BA3F8
	public static void ResumeHaptics() { }

	// RVA: 0x13BA5BC
	public static void ResetHaptics() { }

	// RVA: 0x13BA780
	public static void SetDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13BA888
	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13BA930
	public static void AddDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13BA9D4
	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13BAA7C
	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13BAB20
	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13BABC8
	public static InputControl FindControl(string path) { }

	// RVA: 0x13BAD48
	public static UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(string path) { }

	// RVA: 0x316B894
	public static UnityEngine.InputSystem.InputControlList<TControl> FindControls(string path) { }

	// RVA: 0x30B4D6C
	public static int FindControls(string path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x13BADDC
	internal static bool get_isProcessingEvents() { }

	// RVA: 0x13BAE5C
	public static InputEventListener get_onEvent() { }

	// RVA: 0x13BAE64
	public static void set_onEvent(InputEventListener value) { }

	// RVA: 0x13BAE68
	public static System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress() { }

	// RVA: 0x13BB0A8
	public static void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x30B8148
	public static void QueueEvent(TEvent inputEvent) { }

	// RVA: 0x316B894
	public static void QueueStateEvent(InputDevice device, TState state, Double time) { }

	// RVA: 0x316B894
	public static void QueueDeltaStateEvent(InputControl control, TDelta delta, Double time) { }

	// RVA: 0x13BB190
	public static void QueueConfigChangeEvent(InputDevice device, Double time) { }

	// RVA: 0x13BB3BC
	public static void QueueTextEvent(InputDevice device, Char character, Double time) { }

	// RVA: 0x13BB5F8
	public static void Update() { }

	// RVA: 0x13BB678
	internal static void Update(InputUpdateType updateType) { }

	// RVA: 0x13BB854
	public static void add_onBeforeUpdate(Action value) { }

	// RVA: 0x13BB994
	public static void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x13BBAD4
	public static void add_onAfterUpdate(Action value) { }

	// RVA: 0x13BBC14
	public static void remove_onAfterUpdate(Action value) { }

	// RVA: 0x13BB7D4
	public static InputSettings get_settings() { }

	// RVA: 0x13BBD54
	public static void set_settings(InputSettings value) { }

	// RVA: 0x13BBED8
	public static void add_onSettingsChange(Action value) { }

	// RVA: 0x13BBF68
	public static void remove_onSettingsChange(Action value) { }

	// RVA: 0x13BBFF8
	private static void EnableActions() { }

	// RVA: 0x13BC244
	private static void DisableActions(bool triggerSetupChanged) { }

	// RVA: 0x13BC1B8
	public static InputActionAsset get_actions() { }

	// RVA: 0x13BC3AC
	public static void set_actions(InputActionAsset value) { }

	// RVA: 0x13BC524
	public static void add_onActionsChange(Action value) { }

	// RVA: 0x13BC5B4
	public static void remove_onActionsChange(Action value) { }

	// RVA: 0x13BC644
	public static void add_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x13BC6FC
	public static void remove_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x13BC7B4
	public static void RegisterInteraction(Type type, string name) { }

	// RVA: 0x30B8148
	public static void RegisterInteraction(string name) { }

	// RVA: 0x13BC96C
	public static Type TryGetInteraction(string name) { }

	// RVA: 0x13BCA4C
	public static System.Collections.Generic.IEnumerable<System.String> ListInteractions() { }

	// RVA: 0x13BCAE4
	public static void RegisterBindingComposite(Type type, string name) { }

	// RVA: 0x30B8148
	public static void RegisterBindingComposite(string name) { }

	// RVA: 0x13BCC9C
	public static Type TryGetBindingComposite(string name) { }

	// RVA: 0x13BCD7C
	public static void DisableAllEnabledActions() { }

	// RVA: 0x13BCD84
	public static System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions() { }

	// RVA: 0x13BCE74
	public static int ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions) { }

	// RVA: 0x13BCED4
	public static InputRemoting get_remoting() { }

	// RVA: 0x13BCF50
	public static Version get_version() { }

	// RVA: 0x13BCFC8
	public static bool get_runInBackground() { }

	// RVA: 0x13BD0CC
	public static void set_runInBackground(bool value) { }

	// RVA: 0x13BD1D0
	public static InputMetrics get_metrics() { }

	// RVA: 0x13BD288
	private static void .cctor() { }

	// RVA: 0x13BD474
	private static void RunInitializeInPlayer() { }

	// RVA: 0x13BD520
	internal static void EnsureInitialized() { }

	// RVA: 0x13BD294
	private static void InitializeInPlayer(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x13BD558
	private static void RunInitialUpdate() { }

	// RVA: 0x13BD524
	private static void PerformDefaultPluginInitialization() { }

}

// Namespace: UnityEngine.InputSystem
public static class CommonUsages
{
	// Fields
	public static readonly InternedString Primary2DMotion; // 0x0
	public static readonly InternedString Secondary2DMotion; // 0x10
	public static readonly InternedString PrimaryAction; // 0x20
	public static readonly InternedString SecondaryAction; // 0x30
	public static readonly InternedString PrimaryTrigger; // 0x40
	public static readonly InternedString SecondaryTrigger; // 0x50
	public static readonly InternedString Modifier; // 0x60
	public static readonly InternedString Position; // 0x70
	public static readonly InternedString Orientation; // 0x80
	public static readonly InternedString Hatswitch; // 0x90
	public static readonly InternedString Back; // 0xA0
	public static readonly InternedString Forward; // 0xB0
	public static readonly InternedString Menu; // 0xC0
	public static readonly InternedString Submit; // 0xD0
	public static readonly InternedString Cancel; // 0xE0
	public static readonly InternedString Horizontal; // 0xF0
	public static readonly InternedString Vertical; // 0x100
	public static readonly InternedString Twist; // 0x110
	public static readonly InternedString Pressure; // 0x120
	public static readonly InternedString ScrollHorizontal; // 0x130
	public static readonly InternedString ScrollVertical; // 0x140
	public static readonly InternedString Point; // 0x150
	public static readonly InternedString LowFreqMotor; // 0x160
	public static readonly InternedString HighFreqMotor; // 0x170
	public static readonly InternedString LeftHand; // 0x180
	public static readonly InternedString RightHand; // 0x190
	public static readonly InternedString BatteryStrength; // 0x1A0

	// Methods

	// RVA: 0x13BD900
	private static void .cctor() { }

}

// Namespace: 
internal enum ControlFlags
{
	// Fields
	public int value__; // 0x10
	public const ControlFlags ConfigUpToDate = 1;
	public const ControlFlags IsNoisy = 2;
	public const ControlFlags IsSynthetic = 4;
	public const ControlFlags IsButton = 8;
	public const ControlFlags DontReset = 16;
	public const ControlFlags SetupFinished = 32;
	public const ControlFlags UsesStateFromOtherControl = 64;
}

// Namespace: UnityEngine.InputSystem
public abstract class InputControl
{
	// Fields
	protected internal InputStateBlock m_StateBlock; // 0x10
	internal InternedString m_Name; // 0x20
	internal string m_Path; // 0x30
	internal string m_DisplayName; // 0x38
	internal string m_DisplayNameFromLayout; // 0x40
	internal string m_ShortDisplayName; // 0x48
	internal string m_ShortDisplayNameFromLayout; // 0x50
	internal InternedString m_Layout; // 0x58
	internal InternedString m_Variants; // 0x68
	internal InputDevice m_Device; // 0x78
	internal InputControl m_Parent; // 0x80
	internal int m_UsageCount; // 0x88
	internal int m_UsageStartIndex; // 0x8C
	internal int m_AliasCount; // 0x90
	internal int m_AliasStartIndex; // 0x94
	internal int m_ChildCount; // 0x98
	internal int m_ChildStartIndex; // 0x9C
	internal ControlFlags m_ControlFlags; // 0xA0
	internal bool m_CachedValueIsStale; // 0xA4
	internal bool m_UnprocessedCachedValueIsStale; // 0xA5
	internal PrimitiveValue m_DefaultState; // 0xA8
	internal PrimitiveValue m_MinValue; // 0xB8
	internal PrimitiveValue m_MaxValue; // 0xC8
	internal FourCC m_OptimizedControlDataType; // 0xD8

	// Methods

	// RVA: 0x13BE104
	public string get_name() { }

	// RVA: 0x13BE114
	public string get_displayName() { }

	// RVA: 0x13BE1BC
	protected void set_displayName(string value) { }

	// RVA: 0x13BE1C4
	public string get_shortDisplayName() { }

	// RVA: 0x13BE228
	protected void set_shortDisplayName(string value) { }

	// RVA: 0x13BE230
	public string get_path() { }

	// RVA: 0x13BE430
	public string get_layout() { }

	// RVA: 0x13BE440
	public string get_variants() { }

	// RVA: 0x13BE450
	public InputDevice get_device() { }

	// RVA: 0x13BE458
	public InputControl get_parent() { }

	// RVA: 0x13BE460
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children() { }

	// RVA: 0x13BE4D4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x13BE548
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x13BE5BC
	public InputStateBlock get_stateBlock() { }

	// RVA: 0x13BE5C8
	public bool get_noisy() { }

	// RVA: 0x13BE5D4
	internal void set_noisy(bool value) { }

	// RVA: 0x13BE70C
	public bool get_synthetic() { }

	// RVA: 0x13BE718
	internal void set_synthetic(bool value) { }

	// RVA: 0x13BE738
	public InputControl get_Item(string path) { }

	// RVA: -1
	public abstract Type get_valueType() { }

	// RVA: -1
	public abstract int get_valueSizeInBytes() { }

	// RVA: 0x13BE864
	public float get_magnitude() { }

	// RVA: 0x13BE8D4
	public override string ToString() { }

	// RVA: 0x13BE97C
	private string DebuggerDisplay() { }

	// RVA: 0x13BE89C
	public float EvaluateMagnitude() { }

	// RVA: 0x13BEB80
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	// RVA: -1
	public abstract object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: -1
	public abstract object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: -1
	public abstract void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x13BEB88
	public virtual void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x13BEBEC
	public virtual void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: -1
	public abstract bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13BEC50
	public InputControl TryGetChildControl(string path) { }

	// RVA: 0x316B894
	public TControl TryGetChildControl(string path) { }

	// RVA: 0x13BED08
	public InputControl GetChildControl(string path) { }

	// RVA: 0x316B894
	public TControl GetChildControl(string path) { }

	// RVA: 0x13BEF1C
	protected void .ctor() { }

	// RVA: 0x13BEFAC
	protected virtual void FinishSetup() { }

	// RVA: 0x13BE17C
	protected void RefreshConfigurationIfNeeded() { }

	// RVA: 0x13BEFD0
	protected virtual void RefreshConfiguration() { }

	// RVA: 0x13BEB68
	protected internal Void* get_currentStatePtr() { }

	// RVA: 0x13BF134
	protected internal Void* get_previousFrameStatePtr() { }

	// RVA: 0x13BF14C
	protected internal Void* get_defaultStatePtr() { }

	// RVA: 0x13BF198
	protected internal Void* get_noiseMaskPtr() { }

	// RVA: 0x13BF1E4
	protected internal UInt32 get_stateOffsetRelativeToDeviceRoot() { }

	// RVA: 0x13BF268
	public FourCC get_optimizedControlDataType() { }

	// RVA: 0x13BF270
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	// RVA: 0x13BF278
	public void ApplyParameterChanges() { }

	// RVA: 0x13BF744
	private void SetOptimizedControlDataType() { }

	// RVA: 0x13BF7D8
	internal void SetOptimizedControlDataTypeRecursively() { }

	// RVA: 0x13BFA08
	internal void EnsureOptimizationTypeHasNotChanged() { }

	// RVA: 0x13BFE30
	internal bool get_isSetupFinished() { }

	// RVA: 0x13BFE3C
	internal void set_isSetupFinished(bool value) { }

	// RVA: 0x13BFE5C
	internal bool get_isButton() { }

	// RVA: 0x13BFE68
	internal void set_isButton(bool value) { }

	// RVA: 0x13BEFB0
	internal bool get_isConfigUpToDate() { }

	// RVA: 0x13BEFBC
	internal void set_isConfigUpToDate(bool value) { }

	// RVA: 0x13BFE88
	internal bool get_dontReset() { }

	// RVA: 0x13BFE94
	internal void set_dontReset(bool value) { }

	// RVA: 0x13BFEB4
	internal bool get_usesStateFromOtherControl() { }

	// RVA: 0x13BFEC0
	internal void set_usesStateFromOtherControl(bool value) { }

	// RVA: 0x13BFEE0
	internal bool get_hasDefaultState() { }

	// RVA: 0x13BFF00
	internal void CallFinishSetupRecursive() { }

	// RVA: 0x13BEE20
	internal string MakeChildPath(string path) { }

	// RVA: 0x13C002C
	internal void BakeOffsetIntoStateBlockRecursive(UInt32 offset) { }

	// RVA: 0x13BEFD4
	internal int GetDeviceIndex() { }

	// RVA: 0x13C0188
	internal bool IsValueConsideredPressed(float value) { }

	// RVA: 0x13C023C
	internal virtual void AddProcessor(object first) { }

	// RVA: 0x13C0240
	internal void MarkAsStale() { }

	// RVA: 0x13BF590
	internal void MarkAsStaleRecursively() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputControl<T0>
{
	// Fields
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputProcessor<TValue>> m_ProcessorStack; // 0x0
	private TValue m_CachedValue; // 0x0
	private TValue m_UnprocessedCachedValue; // 0x0
	internal bool evaluateProcessorsEveryRead; // 0x0

	// Methods

	// RVA: 0x30B1CD4
	public override Type get_valueType() { }

	// RVA: 0x30B199C
	public override int get_valueSizeInBytes() { }

	// RVA: 0x30B1CD4
	public TValue get_value() { }

	// RVA: 0x30B1CD4
	internal TValue get_unprocessedValue() { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x316B894
	public TValue ReadValueFromPreviousFrame() { }

	// RVA: 0x316B894
	public TValue ReadDefaultValue() { }

	// RVA: 0x316B894
	public TValue ReadValueFromState(Void* statePtr) { }

	// RVA: 0x316B894
	public TValue ReadValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x316B894
	public TValue ReadUnprocessedValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x316B894
	public TValue ReadUnprocessedValue() { }

	// RVA: -1
	public abstract TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x316B894
	public override object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x316B894
	public override void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x316B894
	public override void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x316B894
	public override void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: 0x316B894
	public virtual void WriteValueIntoState(TValue value, Void* statePtr) { }

	// RVA: 0x316B894
	public override object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x30B410C
	private static bool CompareValue(TValue firstValue, TValue secondValue) { }

	// RVA: 0x316B894
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x316B894
	public TValue ProcessValue(TValue value) { }

	// RVA: 0x30B2CB8
	public void ProcessValue(TValue value) { }

	// RVA: 0x316B894
	internal TProcessor TryGetProcessor() { }

	// RVA: 0x30B2CB8
	internal override void AddProcessor(object processor) { }

	// RVA: 0x30B2870
	protected override void FinishSetup() { }

	// RVA: 0x30B1CD4
	internal UnityEngine.InputSystem.InputProcessor<TValue>[] get_processors() { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: 
public enum Enumerate
{
	// Fields
	public int value__; // 0x10
	public const Enumerate IgnoreControlsInDefaultState = 1;
	public const Enumerate IgnoreControlsInCurrentState = 2;
	public const Enumerate IncludeSyntheticControls = 4;
	public const Enumerate IncludeNoisyControls = 8;
	public const Enumerate IncludeNonLeafControls = 16;
}

// Namespace: 
public struct InputEventControlCollection
{
	// Fields
	internal InputDevice m_Device; // 0x10
	internal InputEventPtr m_EventPtr; // 0x18
	internal Enumerate m_Flags; // 0x20
	internal float m_MagnitudeThreshold; // 0x24

	// Methods

	// RVA: 0x13C2948
	public InputEventPtr get_eventPtr() { }

	// RVA: 0x13C20C4
	public InputEventControlEnumerator GetEnumerator() { }

	// RVA: 0x13C2B48
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x13C2BF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct InputEventControlEnumerator
{
	// Fields
	private Enumerate m_Flags; // 0x10
	private readonly InputDevice m_Device; // 0x18
	private readonly UInt32[] m_StateOffsetToControlIndex; // 0x20
	private readonly int m_StateOffsetToControlIndexLength; // 0x28
	private readonly InputControl[] m_AllControls; // 0x30
	private Byte* m_DefaultState; // 0x38
	private Byte* m_CurrentState; // 0x40
	private Byte* m_NoiseMask; // 0x48
	private InputEventPtr m_EventPtr; // 0x50
	private InputControl m_CurrentControl; // 0x58
	private int m_CurrentIndexInStateOffsetToControlIndexMap; // 0x60
	private UInt32 m_CurrentControlStateBitOffset; // 0x64
	private Byte* m_EventState; // 0x68
	private UInt32 m_CurrentBitOffset; // 0x70
	private UInt32 m_EndBitOffset; // 0x74
	private float m_MagnitudeThreshold; // 0x78

	// Methods

	// RVA: 0x13C2950
	internal void .ctor(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold) { }

	// RVA: 0x13C3114
	private bool CheckDefault(UInt32 numBits) { }

	// RVA: 0x13C3134
	private bool CheckCurrent(UInt32 numBits) { }

	// RVA: 0x13C20EC
	public bool MoveNext() { }

	// RVA: 0x13C2C98
	public void Reset() { }

	// RVA: 0x13C316C
	public void Dispose() { }

	// RVA: 0x13C3174
	public InputControl get_Current() { }

	// RVA: 0x13C317C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ControlBuilder
{
	// Fields
	private InputControl <control>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13C3184
	public InputControl get_control() { }

	// RVA: 0x13C318C
	internal void set_control(InputControl value) { }

	// RVA: 0x13C3194
	public ControlBuilder At(InputDevice device, int index) { }

	// RVA: 0x13C32DC
	public ControlBuilder WithParent(InputControl parent) { }

	// RVA: 0x13C3310
	public ControlBuilder WithName(string name) { }

	// RVA: 0x13C3368
	public ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x13C33C8
	public ControlBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x13C3428
	public ControlBuilder WithLayout(InternedString layout) { }

	// RVA: 0x13C3460
	public ControlBuilder WithUsages(int startIndex, int count) { }

	// RVA: 0x13C3480
	public ControlBuilder WithAliases(int startIndex, int count) { }

	// RVA: 0x13C34A0
	public ControlBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x13C34C0
	public ControlBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x13C34E4
	public ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x13C3540
	public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) { }

	// RVA: 0x316B894
	public ControlBuilder WithProcessor(TProcessor processor) { }

	// RVA: 0x13C3570
	public ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x13C35A0
	public ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x13C35D8
	public ControlBuilder DontReset(bool value) { }

	// RVA: 0x13C3648
	public ControlBuilder IsButton(bool value) { }

	// RVA: 0x13C3680
	public void Finish() { }

}

// Namespace: 
public struct DeviceBuilder
{
	// Fields
	private InputDevice <device>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13C36A8
	public InputDevice get_device() { }

	// RVA: 0x13C36B0
	internal void set_device(InputDevice value) { }

	// RVA: 0x13C36B8
	public DeviceBuilder WithName(string name) { }

	// RVA: 0x13C3710
	public DeviceBuilder WithDisplayName(string displayName) { }

	// RVA: 0x13C3770
	public DeviceBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x13C37D0
	public DeviceBuilder WithLayout(InternedString layout) { }

	// RVA: 0x13C3808
	public DeviceBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x13C3828
	public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x13C384C
	public DeviceBuilder IsNoisy(bool value) { }

	// RVA: 0x13C387C
	public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) { }

	// RVA: 0x13C39FC
	public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) { }

	// RVA: 0x13C3A50
	public DeviceBuilder WithStateOffsetToControlIndexMap(UInt32[] map) { }

	// RVA: 0x13C3A88
	public DeviceBuilder WithControlTree(Byte[] controlTreeNodes, UInt16[] controlTreeIndicies) { }

	// RVA: 0x13C3D70
	public void Finish() { }

}

// Namespace: 
private sealed class <GetAllButtonPresses>d__43
{
	// Fields
	private int <>1__state; // 0x10
	private InputControl <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private InputEventPtr eventPtr; // 0x28
	public InputEventPtr <>3__eventPtr; // 0x30
	private float magnitude; // 0x38
	public float <>3__magnitude; // 0x3C
	private bool buttonControlsOnly; // 0x40
	public bool <>3__buttonControlsOnly; // 0x41
	private InputEventControlEnumerator <>7__wrap1; // 0x48

	// Methods

	// RVA: 0x13C25D8
	public void .ctor(int <>1__state) { }

	// RVA: 0x13C3D98
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C3DB8
	private bool MoveNext() { }

	// RVA: 0x13C4098
	private void <>m__Finally1() { }

	// RVA: 0x13C40A8
	private InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current() { }

	// RVA: 0x13C40B0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13C40F0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13C40F8
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x13C41A8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputControlExtensions
{
	// Methods

	// RVA: 0x316B894
	public static TControl FindInParentChain(InputControl control) { }

	// RVA: 0x13C024C
	public static bool IsPressed(InputControl control, float buttonPressPoint) { }

	// RVA: 0x13C03AC
	public static bool IsActuated(InputControl control, float threshold) { }

	// RVA: 0x13BEAE4
	public static object ReadValueAsObject(InputControl control) { }

	// RVA: 0x13C05B8
	public static void ReadValueIntoBuffer(InputControl control, Void* buffer, int bufferSize) { }

	// RVA: 0x13C0678
	public static object ReadDefaultValueAsObject(InputControl control) { }

	// RVA: 0x316B894
	public static TValue ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent) { }

	// RVA: -1
	public static bool ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, TValue value) { }

	// RVA: 0x13C0720
	public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	// RVA: 0x316B894
	public static TValue ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr eventPtr) { }

	// RVA: -1
	public static bool ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, TValue value) { }

	// RVA: 0x13C0874
	public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	// RVA: 0x13C0908
	public static void WriteValueIntoState(InputControl control, Void* statePtr) { }

	// RVA: 0x316B894
	public static void WriteValueIntoState(InputControl control, TValue value, Void* statePtr) { }

	// RVA: 0x316B894
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Void* statePtr) { }

	// RVA: 0x316B894
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, Void* statePtr) { }

	// RVA: 0x316B894
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, TState state) { }

	// RVA: 0x316B894
	public static void WriteValueIntoEvent(InputControl control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x316B894
	public static void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x13C0A90
	public static void CopyState(InputDevice device, Void* buffer, int bufferSizeInBytes) { }

	// RVA: 0x30B933C
	public static void CopyState(InputDevice device, TState state) { }

	// RVA: 0x13C0538
	public static bool CheckStateIsAtDefault(InputControl control) { }

	// RVA: 0x13C0C2C
	public static bool CheckStateIsAtDefault(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x13C0EA4
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	// RVA: 0x13C0F20
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x13C0FF4
	public static bool CompareStateIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x13C0D08
	public static bool CompareState(InputControl control, Void* firstStatePtr, Void* secondStatePtr, Void* maskPtr) { }

	// RVA: 0x13C10DC
	public static bool CompareState(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x13C1194
	public static bool HasValueChangeInState(InputControl control, Void* statePtr) { }

	// RVA: 0x13C1244
	public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13C07B0
	public static Void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13C1324
	internal static Void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	// RVA: 0x13C164C
	public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x316B894
	public static void QueueValueChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x13C1820
	public static void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<System.Single> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x13C1930
	internal static void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x30B9868
	public static void FindControlsRecursive(InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl,System.Boolean> predicate) { }

	// RVA: 0x13C1A44
	internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder) { }

	// RVA: 0x13C1DD8
	public static InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x13C2064
	public static InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x13C20A8
	public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13BD6A8
	public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13C2544
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13C2610
	public static ControlBuilder Setup(InputControl control) { }

	// RVA: 0x13C26F0
	public static DeviceBuilder Setup(InputDevice device, int controlCount, int usageCount, int aliasCount) { }

}

// Namespace: UnityEngine.InputSystem
public enum InputControlLayoutChange
{
	// Fields
	public int value__; // 0x10
	public const InputControlLayoutChange Added = 0;
	public const InputControlLayoutChange Removed = 1;
	public const InputControlLayoutChange Replaced = 2;
}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly UInt64* m_Indices; // 0x0
	private readonly int m_Count; // 0x0
	private int m_Current; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(UnityEngine.InputSystem.InputControlList<TControl> list) { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public TControl get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	public void Dispose() { }

}

// Namespace: UnityEngine.InputSystem
public struct InputControlList<T0>
{
	// Fields
	private int m_Count; // 0x0
	private Unity.Collections.NativeArray<System.UInt64> m_Indices; // 0x0
	private readonly Allocator m_Allocator; // 0x0
	private const UInt64 kInvalidIndex = 18446744073709551615;

	// Methods

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B199C
	public int get_Capacity() { }

	// RVA: 0x30B29E8
	public void set_Capacity(int value) { }

	// RVA: 0x30B171C
	public bool get_IsReadOnly() { }

	// RVA: 0x316B894
	public TControl get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, TControl value) { }

	// RVA: 0x30B2A58
	public void .ctor(Allocator allocator, int initialCapacity) { }

	// RVA: 0x30B2D20
	public void .ctor(System.Collections.Generic.IEnumerable<TControl> values, Allocator allocator) { }

	// RVA: 0x30B2CB8
	public void .ctor(TControl[] values) { }

	// RVA: 0x30B29E8
	public void Resize(int size) { }

	// RVA: 0x316B894
	public void Add(TControl item) { }

	// RVA: 0x316B894
	public void AddSlice(TList list, int count, int destinationIndex, int sourceIndex) { }

	// RVA: -1
	public void AddRange(System.Collections.Generic.IEnumerable<TControl> list, int count, int destinationIndex) { }

	// RVA: 0x316B894
	public bool Remove(TControl item) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int index) { }

	// RVA: 0x30B2D20
	public void CopyTo(TControl[] array, int arrayIndex) { }

	// RVA: 0x316B894
	public int IndexOf(TControl item) { }

	// RVA: 0x316B894
	public int IndexOf(TControl item, int startIndex, int count) { }

	// RVA: 0x316B894
	public void Insert(int index, TControl item) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool Contains(TControl item) { }

	// RVA: 0x316B894
	public bool Contains(TControl item, int startIndex, int count) { }

	// RVA: 0x30B2A58
	public void SwapElements(int index1, int index2) { }

	// RVA: 0x316B894
	public void Sort(int startIndex, int count, TCompare comparer) { }

	// RVA: -1
	public TControl[] ToArray(bool dispose) { }

	// RVA: 0x30B2F18
	internal void AppendTo(TControl[] array, int count) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<TControl> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B1CD4
	public override string ToString() { }

	// RVA: 0x316B894
	private static UInt64 ToIndex(TControl control) { }

	// RVA: 0x316B894
	private static TControl FromIndex(UInt64 index) { }

}

// Namespace: 
public enum HumanReadableStringOptions
{
	// Fields
	public int value__; // 0x10
	public const HumanReadableStringOptions None = 0;
	public const HumanReadableStringOptions OmitDevice = 2;
	public const HumanReadableStringOptions UseShortNames = 4;
}

// Namespace: 
private enum PathComponentType
{
	// Fields
	public int value__; // 0x10
	public const PathComponentType Name = 0;
	public const PathComponentType DisplayName = 1;
	public const PathComponentType Usage = 2;
	public const PathComponentType Layout = 3;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputControlPath.ParsedPathComponent.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.Substring,System.String> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x13C7B4C
	private static void .cctor() { }

	// RVA: 0x13C7BB8
	public void .ctor() { }

	// RVA: 0x13C7BC0
	internal string <get_usages>b__7_0(Substring x) { }

}

// Namespace: 
public struct ParsedPathComponent
{
	// Fields
	internal Substring m_Layout; // 0x10
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.Substring> m_Usages; // 0x20
	internal Substring m_Name; // 0x40
	internal Substring m_DisplayName; // 0x50

	// Methods

	// RVA: 0x13C7784
	public string get_layout() { }

	// RVA: 0x13C778C
	public System.Collections.Generic.IEnumerable<System.String> get_usages() { }

	// RVA: 0x13C78E0
	public string get_name() { }

	// RVA: 0x13C78EC
	public string get_displayName() { }

	// RVA: 0x13C5BB8
	internal bool get_isWildcard() { }

	// RVA: 0x13C78F8
	internal bool get_isDoubleWildcard() { }

	// RVA: 0x13C4D6C
	internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, string referencedLayoutName, string controlPath, HumanReadableStringOptions options) { }

	// RVA: 0x13C7968
	private static string ToHumanReadableString(Substring substring) { }

	// RVA: 0x13C6DC0
	public bool Matches(InputControl control) { }

	// RVA: 0x13C79D0
	private static bool ComparePathElementToString(Substring pathElement, string element) { }

}

// Namespace: 
private struct PathParser
{
	// Fields
	private string path; // 0x10
	private int length; // 0x18
	private int leftIndexInPath; // 0x1C
	private int rightIndexInPath; // 0x20
	public ParsedPathComponent current; // 0x28

	// Methods

	// RVA: 0x13C63C4
	public bool get_isAtEnd() { }

	// RVA: 0x13C4A20
	public void .ctor(string path) { }

	// RVA: 0x13C4A74
	public bool MoveToNextComponent() { }

	// RVA: 0x13C7BE8
	private Substring ParseComponentPart(Char terminator) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputControlPath.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.Substring,System.String> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x13C7CE8
	private static void .cctor() { }

	// RVA: 0x13C7D54
	public void .ctor() { }

	// RVA: 0x13C7D5C
	internal string <TryGetDeviceUsages>b__9_0(Substring x) { }

}

// Namespace: 
private sealed class <Parse>d__34
{
	// Fields
	private int <>1__state; // 0x10
	private ParsedPathComponent <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x68
	private string path; // 0x70
	public string <>3__path; // 0x78
	private PathParser <parser>5__2; // 0x80

	// Methods

	// RVA: 0x13C774C
	public void .ctor(int <>1__state) { }

	// RVA: 0x13C7D84
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C7D88
	private bool MoveNext() { }

	// RVA: 0x13C7F0C
	private ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current() { }

	// RVA: 0x13C7F30
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13C7F70
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13C7FF0
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() { }

	// RVA: 0x13C8098
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputControlPath
{
	// Fields
	public const string Wildcard = "*";
	public const string DoubleWildcard = "**";
	public const Char Separator = 47;
	internal const Char SeparatorReplacement = 32;

	// Methods

	// RVA: 0x13C4258
	internal static string CleanSlashes(string pathComponent) { }

	// RVA: 0x13BE2A0
	public static string Combine(InputControl parent, string path) { }

	// RVA: 0x13C4278
	public static string ToHumanReadableString(string path, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x13C42A8
	public static string ToHumanReadableString(string path, string deviceLayoutName, string controlPath, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x13C5834
	public static string[] TryGetDeviceUsages(string path) { }

	// RVA: 0x13C59FC
	public static string TryGetDeviceLayout(string path) { }

	// RVA: 0x13C5C28
	public static string TryGetControlLayout(string path) { }

	// RVA: 0x13C5F38
	private static string FindControlLayoutRecursive(PathParser parser, string layoutName) { }

	// RVA: 0x13C6098
	private static string FindControlLayoutRecursive(PathParser parser, InputControlLayout layout) { }

	// RVA: 0x13C6248
	private static bool ControlLayoutMatchesPathComponent(ControlItem controlItem, PathParser parser) { }

	// RVA: 0x13C63D8
	private static bool StringMatches(Substring str, InternedString matchTo) { }

	// RVA: 0x13B59F8
	public static InputControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13C668C
	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13C67E0
	public static int TryFindControls(InputControl control, string path, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& matches, int indexInPath) { }

	// RVA: 0x316B894
	public static TControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x316B894
	public static int TryFindControls(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches) { }

	// RVA: 0x13BE7F8
	public static InputControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x316B894
	public static TControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13C492C
	public static bool Matches(string expected, InputControl control) { }

	// RVA: 0x13C68CC
	internal static bool MatchControlComponent(ParsedPathComponent expectedControlComponent, ControlItem controlItem, bool matchAlias) { }

	// RVA: 0x13C6CA0
	public static bool MatchesPrefix(string expected, InputControl control) { }

	// RVA: 0x13C6854
	private static bool MatchesRecursive(PathParser parser, InputControl currentControl, bool prefixOnly) { }

	// RVA: 0x316B894
	private static TControl MatchControlsRecursive(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x316B894
	private static TControl MatchByUsageAtDeviceRootRecursive(InputDevice device, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x316B894
	private static TControl MatchChildrenRecursive(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x13C730C
	private static bool MatchPathComponent(string component, string path, int indexInPath, PathComponentType componentType, int startIndexInComponent) { }

	// RVA: 0x13C75C8
	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	// RVA: 0x13C76C4
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(string path) { }

}

// Namespace: 
public enum CachingPolicy
{
	// Fields
	public int value__; // 0x10
	public const CachingPolicy CacheResult = 0;
	public const CachingPolicy EvaluateOnEveryRead = 1;
}

// Namespace: UnityEngine.InputSystem
public abstract class InputProcessor
{
	// Fields
	internal static TypeTable s_Processors; // 0x0

	// Methods

	// RVA: -1
	public abstract object ProcessAsObject(object value, InputControl control) { }

	// RVA: -1
	public abstract void Process(Void* buffer, int bufferSize, InputControl control) { }

	// RVA: 0x13C809C
	internal static Type GetValueTypeFromType(Type processorType) { }

	// RVA: 0x13C81B8
	public virtual CachingPolicy get_cachingPolicy() { }

	// RVA: 0x13C81C0
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputProcessor<T0>
{
	// Methods

	// RVA: -1
	public abstract TValue Process(TValue value, InputControl control) { }

	// RVA: 0x30B1E68
	public override object ProcessAsObject(object value, InputControl control) { }

	// RVA: 0x316B894
	public override void Process(Void* buffer, int bufferSize, InputControl control) { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Gamepad
{
	// Fields
	private ButtonControl <buttonWest>k__BackingField; // 0x170
	private ButtonControl <buttonNorth>k__BackingField; // 0x178
	private ButtonControl <buttonSouth>k__BackingField; // 0x180
	private ButtonControl <buttonEast>k__BackingField; // 0x188
	private ButtonControl <leftStickButton>k__BackingField; // 0x190
	private ButtonControl <rightStickButton>k__BackingField; // 0x198
	private ButtonControl <startButton>k__BackingField; // 0x1A0
	private ButtonControl <selectButton>k__BackingField; // 0x1A8
	private DpadControl <dpad>k__BackingField; // 0x1B0
	private ButtonControl <leftShoulder>k__BackingField; // 0x1B8
	private ButtonControl <rightShoulder>k__BackingField; // 0x1C0
	private StickControl <leftStick>k__BackingField; // 0x1C8
	private StickControl <rightStick>k__BackingField; // 0x1D0
	private ButtonControl <leftTrigger>k__BackingField; // 0x1D8
	private ButtonControl <rightTrigger>k__BackingField; // 0x1E0
	private static Gamepad <current>k__BackingField; // 0x0
	private DualMotorRumble m_Rumble; // 0x1E8
	private static int s_GamepadCount; // 0x8
	private static Gamepad[] s_Gamepads; // 0x10

	// Methods

	// RVA: 0x13C81C8
	public ButtonControl get_buttonWest() { }

	// RVA: 0x13C81D0
	protected void set_buttonWest(ButtonControl value) { }

	// RVA: 0x13C81E0
	public ButtonControl get_buttonNorth() { }

	// RVA: 0x13C81E8
	protected void set_buttonNorth(ButtonControl value) { }

	// RVA: 0x13C81F8
	public ButtonControl get_buttonSouth() { }

	// RVA: 0x13C8200
	protected void set_buttonSouth(ButtonControl value) { }

	// RVA: 0x13C8210
	public ButtonControl get_buttonEast() { }

	// RVA: 0x13C8218
	protected void set_buttonEast(ButtonControl value) { }

	// RVA: 0x13C8228
	public ButtonControl get_leftStickButton() { }

	// RVA: 0x13C8230
	protected void set_leftStickButton(ButtonControl value) { }

	// RVA: 0x13C8240
	public ButtonControl get_rightStickButton() { }

	// RVA: 0x13C8248
	protected void set_rightStickButton(ButtonControl value) { }

	// RVA: 0x13C8258
	public ButtonControl get_startButton() { }

	// RVA: 0x13C8260
	protected void set_startButton(ButtonControl value) { }

	// RVA: 0x13C8270
	public ButtonControl get_selectButton() { }

	// RVA: 0x13C8278
	protected void set_selectButton(ButtonControl value) { }

	// RVA: 0x13C8288
	public DpadControl get_dpad() { }

	// RVA: 0x13C8290
	protected void set_dpad(DpadControl value) { }

	// RVA: 0x13C82A0
	public ButtonControl get_leftShoulder() { }

	// RVA: 0x13C82A8
	protected void set_leftShoulder(ButtonControl value) { }

	// RVA: 0x13C82B8
	public ButtonControl get_rightShoulder() { }

	// RVA: 0x13C82C0
	protected void set_rightShoulder(ButtonControl value) { }

	// RVA: 0x13C82D0
	public StickControl get_leftStick() { }

	// RVA: 0x13C82D8
	protected void set_leftStick(StickControl value) { }

	// RVA: 0x13C82E8
	public StickControl get_rightStick() { }

	// RVA: 0x13C82F0
	protected void set_rightStick(StickControl value) { }

	// RVA: 0x13C8300
	public ButtonControl get_leftTrigger() { }

	// RVA: 0x13C8308
	protected void set_leftTrigger(ButtonControl value) { }

	// RVA: 0x13C8318
	public ButtonControl get_rightTrigger() { }

	// RVA: 0x13C8320
	protected void set_rightTrigger(ButtonControl value) { }

	// RVA: 0x13C8330
	public ButtonControl get_aButton() { }

	// RVA: 0x13C8338
	public ButtonControl get_bButton() { }

	// RVA: 0x13C8340
	public ButtonControl get_xButton() { }

	// RVA: 0x13C8348
	public ButtonControl get_yButton() { }

	// RVA: 0x13C8350
	public ButtonControl get_triangleButton() { }

	// RVA: 0x13C8358
	public ButtonControl get_squareButton() { }

	// RVA: 0x13C8360
	public ButtonControl get_circleButton() { }

	// RVA: 0x13C8368
	public ButtonControl get_crossButton() { }

	// RVA: 0x13C8370
	public ButtonControl get_Item(GamepadButton button) { }

	// RVA: 0x13C85CC
	public static Gamepad get_current() { }

	// RVA: 0x13C8618
	private static void set_current(Gamepad value) { }

	// RVA: 0x13C867C
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all() { }

	// RVA: 0x13C8708
	protected override void FinishSetup() { }

	// RVA: 0x13C8A9C
	public override void MakeCurrent() { }

	// RVA: 0x13C8AFC
	protected override void OnAdded() { }

	// RVA: 0x13C8B78
	protected override void OnRemoved() { }

	// RVA: 0x13C8CA4
	public virtual void PauseHaptics() { }

	// RVA: 0x13C8CB4
	public virtual void ResumeHaptics() { }

	// RVA: 0x13C8CC4
	public virtual void ResetHaptics() { }

	// RVA: 0x13C8CD4
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x13C8CE4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
internal enum DeviceFlags
{
	// Fields
	public int value__; // 0x10
	public const DeviceFlags UpdateBeforeRender = 1;
	public const DeviceFlags HasStateCallbacks = 2;
	public const DeviceFlags HasControlsWithDefaultState = 4;
	public const DeviceFlags HasDontResetControls = 1024;
	public const DeviceFlags HasEventMerger = 8192;
	public const DeviceFlags HasEventPreProcessor = 16384;
	public const DeviceFlags Remote = 8;
	public const DeviceFlags Native = 16;
	public const DeviceFlags DisabledInFrontend = 32;
	public const DeviceFlags DisabledInRuntime = 128;
	public const DeviceFlags DisabledWhileInBackground = 256;
	public const DeviceFlags DisabledStateHasBeenQueriedFromRuntime = 64;
	public const DeviceFlags CanRunInBackground = 2048;
	public const DeviceFlags CanRunInBackgroundHasBeenQueried = 4096;
}

// Namespace: 
internal struct ControlBitRangeNode
{
	// Fields
	public UInt16 endBitOffset; // 0x10
	public Int16 leftChildIndex; // 0x12
	public UInt16 controlStartIndex; // 0x14
	public Byte controlCount; // 0x16

	// Methods

	// RVA: 0x13CABE0
	public void .ctor(UInt16 endOffset) { }

}

// Namespace: UnityEngine.InputSystem
public class InputDevice
{
	// Fields
	public const int InvalidDeviceId = 0;
	internal const int kLocalParticipantId = 0;
	internal const int kInvalidDeviceIndex = 4294967295;
	internal DeviceFlags m_DeviceFlags; // 0xDC
	internal int m_DeviceId; // 0xE0
	internal int m_ParticipantId; // 0xE4
	internal int m_DeviceIndex; // 0xE8
	internal InputDeviceDescription m_Description; // 0xF0
	internal Double m_LastUpdateTimeInternal; // 0x128
	internal UInt32 m_CurrentUpdateStepCount; // 0x130
	internal InternedString[] m_AliasesForEachControl; // 0x138
	internal InternedString[] m_UsagesForEachControl; // 0x140
	internal InputControl[] m_UsageToControl; // 0x148
	internal InputControl[] m_ChildrenForEachControl; // 0x150
	internal UInt32[] m_StateOffsetToControlMap; // 0x158
	internal ControlBitRangeNode[] m_ControlTreeNodes; // 0x160
	internal UInt16[] m_ControlTreeIndices; // 0x168
	internal const int kControlIndexBits = 10;
	internal const int kStateOffsetBits = 13;
	internal const int kStateSizeBits = 9;

	// Methods

	// RVA: 0x13C8DEC
	public InputDeviceDescription get_description() { }

	// RVA: 0x13C8E08
	public bool get_enabled() { }

	// RVA: 0x13C8FA4
	public bool get_canRunInBackground() { }

	// RVA: 0x13B9FB4
	public bool get_added() { }

	// RVA: 0x13C9074
	public bool get_remote() { }

	// RVA: 0x13C9080
	public bool get_native() { }

	// RVA: 0x13C908C
	public bool get_updateBeforeRender() { }

	// RVA: 0x13C9098
	public int get_deviceId() { }

	// RVA: 0x13C90A0
	public Double get_lastUpdateTime() { }

	// RVA: 0x13C9100
	public bool get_wasUpdatedThisFrame() { }

	// RVA: 0x13C9164
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls() { }

	// RVA: 0x13C91D0
	public override Type get_valueType() { }

	// RVA: 0x13C9270
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13C92F8
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all() { }

	// RVA: 0x13C8D68
	public void .ctor() { }

	// RVA: 0x13C93C0
	public override object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x13C9400
	public override object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x13C9514
	public override void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x13C96D8
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13C97DC
	internal void NotifyConfigurationChanged() { }

	// RVA: 0x13C8AF8
	public virtual void MakeCurrent() { }

	// RVA: 0x13C984C
	protected virtual void OnAdded() { }

	// RVA: 0x13C9850
	protected virtual void OnRemoved() { }

	// RVA: 0x13C9854
	protected virtual void OnConfigurationChanged() { }

	// RVA: -1
	public Int64 ExecuteCommand(TCommand command) { }

	// RVA: 0x13C9858
	protected virtual Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x13C8ED8
	internal bool QueryEnabledStateFromRuntime() { }

	// RVA: 0x13C9934
	internal bool get_disabledInFrontend() { }

	// RVA: 0x13C9940
	internal void set_disabledInFrontend(bool value) { }

	// RVA: 0x13C9960
	internal bool get_disabledInRuntime() { }

	// RVA: 0x13C996C
	internal void set_disabledInRuntime(bool value) { }

	// RVA: 0x13C998C
	internal bool get_disabledWhileInBackground() { }

	// RVA: 0x13C9998
	internal void set_disabledWhileInBackground(bool value) { }

	// RVA: 0x13C99B8
	internal static UInt32 EncodeStateOffsetToControlMapEntry(UInt32 controlIndex, UInt32 stateOffsetInBits, UInt32 stateSizeInBits) { }

	// RVA: 0x13C3150
	internal static void DecodeStateOffsetToControlMapEntry(UInt32 entry, UInt32 controlIndex, UInt32 stateOffset, UInt32 stateSize) { }

	// RVA: 0x13C99C4
	internal bool get_hasControlsWithDefaultState() { }

	// RVA: 0x13C3520
	internal void set_hasControlsWithDefaultState(bool value) { }

	// RVA: 0x13C99D0
	internal bool get_hasDontResetControls() { }

	// RVA: 0x13C3628
	internal void set_hasDontResetControls(bool value) { }

	// RVA: 0x13C1640
	internal bool get_hasStateCallbacks() { }

	// RVA: 0x13C99DC
	internal void set_hasStateCallbacks(bool value) { }

	// RVA: 0x13C99FC
	internal bool get_hasEventMerger() { }

	// RVA: 0x13C9A08
	internal void set_hasEventMerger(bool value) { }

	// RVA: 0x13C9A28
	internal bool get_hasEventPreProcessor() { }

	// RVA: 0x13C9A34
	internal void set_hasEventPreProcessor(bool value) { }

	// RVA: 0x13C9A54
	internal void AddDeviceUsage(InternedString usage) { }

	// RVA: 0x13C9B14
	internal void RemoveDeviceUsage(InternedString usage) { }

	// RVA: 0x13C9C14
	internal void ClearDeviceUsages() { }

	// RVA: 0x13B9FC4
	internal bool RequestSync() { }

	// RVA: 0x13BA1B4
	internal bool RequestReset() { }

	// RVA: 0x13C9C78
	internal bool ExecuteEnableCommand() { }

	// RVA: 0x13C9CFC
	internal bool ExecuteDisableCommand() { }

	// RVA: 0x13C9D74
	internal void NotifyAdded() { }

	// RVA: 0x13C9D84
	internal void NotifyRemoved() { }

	// RVA: 0x316B894
	internal static TDevice Build(string layoutName, string layoutVariants, InputDeviceDescription deviceDescription, bool noPrecompiledLayouts) { }

	// RVA: 0x13C9D94
	internal void WriteChangedControlStates(Byte* deviceStateBuffer, Void* statePtr, UInt32 stateSizeInBytes, UInt32 stateOffsetInDevice) { }

	// RVA: 0x13C9EF0
	private void WritePartialChangedControlStatesInternal(Void* statePtr, UInt32 stateSizeInBits, UInt32 stateOffsetInDeviceInBits, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x13CA4DC
	private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, UInt32 startOffset, UInt32 sizeInBits, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x13CA964
	private void DumpControlTree(ControlBitRangeNode parentNode, UInt32 startOffset, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x13CAA94
	internal string DumpControlTree() { }

	// RVA: 0x13CA18C
	private void WriteChangedControlStatesInternal(Void* statePtr, UInt32 stateSizeInBits, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x13CAB64
	private static bool HasDataChangedInRange(Byte* deviceStatePtr, Void* statePtr, UInt32 startOffset, UInt32 sizeInBits) { }

}

// Namespace: UnityEngine.InputSystem
public enum InputDeviceChange
{
	// Fields
	public int value__; // 0x10
	public const InputDeviceChange Added = 0;
	public const InputDeviceChange Removed = 1;
	public const InputDeviceChange Disconnected = 2;
	public const InputDeviceChange Reconnected = 3;
	public const InputDeviceChange Enabled = 4;
	public const InputDeviceChange Disabled = 5;
	public const InputDeviceChange UsageChanged = 6;
	public const InputDeviceChange ConfigurationChanged = 7;
	public const InputDeviceChange SoftReset = 8;
	public const InputDeviceChange HardReset = 9;
	public const InputDeviceChange Destroyed = 10;
}

// Namespace: UnityEngine.InputSystem
public class Joystick
{
	// Fields
	private ButtonControl <trigger>k__BackingField; // 0x170
	private StickControl <stick>k__BackingField; // 0x178
	private AxisControl <twist>k__BackingField; // 0x180
	private Vector2Control <hatswitch>k__BackingField; // 0x188
	private static Joystick <current>k__BackingField; // 0x0
	private static int s_JoystickCount; // 0x8
	private static Joystick[] s_Joysticks; // 0x10

	// Methods

	// RVA: 0x13CABF4
	public ButtonControl get_trigger() { }

	// RVA: 0x13CABFC
	protected void set_trigger(ButtonControl value) { }

	// RVA: 0x13CAC0C
	public StickControl get_stick() { }

	// RVA: 0x13CAC14
	protected void set_stick(StickControl value) { }

	// RVA: 0x13CAC24
	public AxisControl get_twist() { }

	// RVA: 0x13CAC2C
	protected void set_twist(AxisControl value) { }

	// RVA: 0x13CAC3C
	public Vector2Control get_hatswitch() { }

	// RVA: 0x13CAC44
	protected void set_hatswitch(Vector2Control value) { }

	// RVA: 0x13CAC54
	public static Joystick get_current() { }

	// RVA: 0x13CACA0
	private static void set_current(Joystick value) { }

	// RVA: 0x13CAD04
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all() { }

	// RVA: 0x13CAD90
	protected override void FinishSetup() { }

	// RVA: 0x13CAEFC
	public override void MakeCurrent() { }

	// RVA: 0x13CAF58
	protected override void OnAdded() { }

	// RVA: 0x13CAFD4
	protected override void OnRemoved() { }

	// RVA: 0x13CB100
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public enum Key
{
	// Fields
	public int value__; // 0x10
	public const Key None = 0;
	public const Key Space = 1;
	public const Key Enter = 2;
	public const Key Tab = 3;
	public const Key Backquote = 4;
	public const Key Quote = 5;
	public const Key Semicolon = 6;
	public const Key Comma = 7;
	public const Key Period = 8;
	public const Key Slash = 9;
	public const Key Backslash = 10;
	public const Key LeftBracket = 11;
	public const Key RightBracket = 12;
	public const Key Minus = 13;
	public const Key Equals = 14;
	public const Key A = 15;
	public const Key B = 16;
	public const Key C = 17;
	public const Key D = 18;
	public const Key E = 19;
	public const Key F = 20;
	public const Key G = 21;
	public const Key H = 22;
	public const Key I = 23;
	public const Key J = 24;
	public const Key K = 25;
	public const Key L = 26;
	public const Key M = 27;
	public const Key N = 28;
	public const Key O = 29;
	public const Key P = 30;
	public const Key Q = 31;
	public const Key R = 32;
	public const Key S = 33;
	public const Key T = 34;
	public const Key U = 35;
	public const Key V = 36;
	public const Key W = 37;
	public const Key X = 38;
	public const Key Y = 39;
	public const Key Z = 40;
	public const Key Digit1 = 41;
	public const Key Digit2 = 42;
	public const Key Digit3 = 43;
	public const Key Digit4 = 44;
	public const Key Digit5 = 45;
	public const Key Digit6 = 46;
	public const Key Digit7 = 47;
	public const Key Digit8 = 48;
	public const Key Digit9 = 49;
	public const Key Digit0 = 50;
	public const Key LeftShift = 51;
	public const Key RightShift = 52;
	public const Key LeftAlt = 53;
	public const Key RightAlt = 54;
	public const Key AltGr = 54;
	public const Key LeftCtrl = 55;
	public const Key RightCtrl = 56;
	public const Key LeftMeta = 57;
	public const Key RightMeta = 58;
	public const Key LeftWindows = 57;
	public const Key RightWindows = 58;
	public const Key LeftApple = 57;
	public const Key RightApple = 58;
	public const Key LeftCommand = 57;
	public const Key RightCommand = 58;
	public const Key ContextMenu = 59;
	public const Key Escape = 60;
	public const Key LeftArrow = 61;
	public const Key RightArrow = 62;
	public const Key UpArrow = 63;
	public const Key DownArrow = 64;
	public const Key Backspace = 65;
	public const Key PageDown = 66;
	public const Key PageUp = 67;
	public const Key Home = 68;
	public const Key End = 69;
	public const Key Insert = 70;
	public const Key Delete = 71;
	public const Key CapsLock = 72;
	public const Key NumLock = 73;
	public const Key PrintScreen = 74;
	public const Key ScrollLock = 75;
	public const Key Pause = 76;
	public const Key NumpadEnter = 77;
	public const Key NumpadDivide = 78;
	public const Key NumpadMultiply = 79;
	public const Key NumpadPlus = 80;
	public const Key NumpadMinus = 81;
	public const Key NumpadPeriod = 82;
	public const Key NumpadEquals = 83;
	public const Key Numpad0 = 84;
	public const Key Numpad1 = 85;
	public const Key Numpad2 = 86;
	public const Key Numpad3 = 87;
	public const Key Numpad4 = 88;
	public const Key Numpad5 = 89;
	public const Key Numpad6 = 90;
	public const Key Numpad7 = 91;
	public const Key Numpad8 = 92;
	public const Key Numpad9 = 93;
	public const Key F1 = 94;
	public const Key F2 = 95;
	public const Key F3 = 96;
	public const Key F4 = 97;
	public const Key F5 = 98;
	public const Key F6 = 99;
	public const Key F7 = 100;
	public const Key F8 = 101;
	public const Key F9 = 102;
	public const Key F10 = 103;
	public const Key F11 = 104;
	public const Key F12 = 105;
	public const Key OEM1 = 106;
	public const Key OEM2 = 107;
	public const Key OEM3 = 108;
	public const Key OEM4 = 109;
	public const Key OEM5 = 110;
	public const Key IMESelected = 111;
}

// Namespace: UnityEngine.InputSystem
public class Keyboard
{
	// Fields
	public const int KeyCount = 110;
	private AnyKeyControl <anyKey>k__BackingField; // 0x170
	private ButtonControl <shiftKey>k__BackingField; // 0x178
	private ButtonControl <ctrlKey>k__BackingField; // 0x180
	private ButtonControl <altKey>k__BackingField; // 0x188
	private ButtonControl <imeSelected>k__BackingField; // 0x190
	private static Keyboard <current>k__BackingField; // 0x0
	private UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<System.Char>> m_TextInputListeners; // 0x198
	private string m_KeyboardLayoutName; // 0x1B0
	private KeyControl[] m_Keys; // 0x1B8
	private UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString>> m_ImeCompositionListeners; // 0x1C0

	// Methods

	// RVA: 0x13CB184
	public void add_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13CB274
	public void remove_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13CB2D0
	public void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13CB3BC
	public void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13CB418
	public void SetIMEEnabled(bool enabled) { }

	// RVA: 0x13CB494
	public void SetIMECursorPosition(Vector2 position) { }

	// RVA: 0x13CB548
	public string get_keyboardLayout() { }

	// RVA: 0x13CB590
	protected void set_keyboardLayout(string value) { }

	// RVA: 0x13CB5A0
	public AnyKeyControl get_anyKey() { }

	// RVA: 0x13CB5A8
	protected void set_anyKey(AnyKeyControl value) { }

	// RVA: 0x13CB5B8
	public KeyControl get_spaceKey() { }

	// RVA: 0x13CB6BC
	public KeyControl get_enterKey() { }

	// RVA: 0x13CB738
	public KeyControl get_tabKey() { }

	// RVA: 0x13CB7B4
	public KeyControl get_backquoteKey() { }

	// RVA: 0x13CB830
	public KeyControl get_quoteKey() { }

	// RVA: 0x13CB8AC
	public KeyControl get_semicolonKey() { }

	// RVA: 0x13CB928
	public KeyControl get_commaKey() { }

	// RVA: 0x13CB9A4
	public KeyControl get_periodKey() { }

	// RVA: 0x13CBA20
	public KeyControl get_slashKey() { }

	// RVA: 0x13CBA9C
	public KeyControl get_backslashKey() { }

	// RVA: 0x13CBB18
	public KeyControl get_leftBracketKey() { }

	// RVA: 0x13CBB94
	public KeyControl get_rightBracketKey() { }

	// RVA: 0x13CBC10
	public KeyControl get_minusKey() { }

	// RVA: 0x13CBC8C
	public KeyControl get_equalsKey() { }

	// RVA: 0x13CBD08
	public KeyControl get_aKey() { }

	// RVA: 0x13CBD84
	public KeyControl get_bKey() { }

	// RVA: 0x13CBE00
	public KeyControl get_cKey() { }

	// RVA: 0x13CBE7C
	public KeyControl get_dKey() { }

	// RVA: 0x13CBEF8
	public KeyControl get_eKey() { }

	// RVA: 0x13CBF74
	public KeyControl get_fKey() { }

	// RVA: 0x13CBFF0
	public KeyControl get_gKey() { }

	// RVA: 0x13CC06C
	public KeyControl get_hKey() { }

	// RVA: 0x13CC0E8
	public KeyControl get_iKey() { }

	// RVA: 0x13CC164
	public KeyControl get_jKey() { }

	// RVA: 0x13CC1E0
	public KeyControl get_kKey() { }

	// RVA: 0x13CC25C
	public KeyControl get_lKey() { }

	// RVA: 0x13CC2D8
	public KeyControl get_mKey() { }

	// RVA: 0x13CC354
	public KeyControl get_nKey() { }

	// RVA: 0x13CC3D0
	public KeyControl get_oKey() { }

	// RVA: 0x13CC44C
	public KeyControl get_pKey() { }

	// RVA: 0x13CC4C8
	public KeyControl get_qKey() { }

	// RVA: 0x13CC544
	public KeyControl get_rKey() { }

	// RVA: 0x13CC5C0
	public KeyControl get_sKey() { }

	// RVA: 0x13CC63C
	public KeyControl get_tKey() { }

	// RVA: 0x13CC6B8
	public KeyControl get_uKey() { }

	// RVA: 0x13CC734
	public KeyControl get_vKey() { }

	// RVA: 0x13CC7B0
	public KeyControl get_wKey() { }

	// RVA: 0x13CC82C
	public KeyControl get_xKey() { }

	// RVA: 0x13CC8A8
	public KeyControl get_yKey() { }

	// RVA: 0x13CC924
	public KeyControl get_zKey() { }

	// RVA: 0x13CC9A0
	public KeyControl get_digit1Key() { }

	// RVA: 0x13CCA1C
	public KeyControl get_digit2Key() { }

	// RVA: 0x13CCA98
	public KeyControl get_digit3Key() { }

	// RVA: 0x13CCB14
	public KeyControl get_digit4Key() { }

	// RVA: 0x13CCB90
	public KeyControl get_digit5Key() { }

	// RVA: 0x13CCC0C
	public KeyControl get_digit6Key() { }

	// RVA: 0x13CCC88
	public KeyControl get_digit7Key() { }

	// RVA: 0x13CCD04
	public KeyControl get_digit8Key() { }

	// RVA: 0x13CCD80
	public KeyControl get_digit9Key() { }

	// RVA: 0x13CCDFC
	public KeyControl get_digit0Key() { }

	// RVA: 0x13CCE78
	public KeyControl get_leftShiftKey() { }

	// RVA: 0x13CCEF4
	public KeyControl get_rightShiftKey() { }

	// RVA: 0x13CCF70
	public KeyControl get_leftAltKey() { }

	// RVA: 0x13CCFEC
	public KeyControl get_rightAltKey() { }

	// RVA: 0x13CD068
	public KeyControl get_leftCtrlKey() { }

	// RVA: 0x13CD0E4
	public KeyControl get_rightCtrlKey() { }

	// RVA: 0x13CD160
	public KeyControl get_leftMetaKey() { }

	// RVA: 0x13CD1DC
	public KeyControl get_rightMetaKey() { }

	// RVA: 0x13CD258
	public KeyControl get_leftWindowsKey() { }

	// RVA: 0x13CD2D4
	public KeyControl get_rightWindowsKey() { }

	// RVA: 0x13CD350
	public KeyControl get_leftAppleKey() { }

	// RVA: 0x13CD3CC
	public KeyControl get_rightAppleKey() { }

	// RVA: 0x13CD448
	public KeyControl get_leftCommandKey() { }

	// RVA: 0x13CD4C4
	public KeyControl get_rightCommandKey() { }

	// RVA: 0x13CD540
	public KeyControl get_contextMenuKey() { }

	// RVA: 0x13CD5BC
	public KeyControl get_escapeKey() { }

	// RVA: 0x13CD638
	public KeyControl get_leftArrowKey() { }

	// RVA: 0x13CD6B4
	public KeyControl get_rightArrowKey() { }

	// RVA: 0x13CD730
	public KeyControl get_upArrowKey() { }

	// RVA: 0x13CD7AC
	public KeyControl get_downArrowKey() { }

	// RVA: 0x13CD828
	public KeyControl get_backspaceKey() { }

	// RVA: 0x13CD8A4
	public KeyControl get_pageDownKey() { }

	// RVA: 0x13CD920
	public KeyControl get_pageUpKey() { }

	// RVA: 0x13CD99C
	public KeyControl get_homeKey() { }

	// RVA: 0x13CDA18
	public KeyControl get_endKey() { }

	// RVA: 0x13CDA94
	public KeyControl get_insertKey() { }

	// RVA: 0x13CDB10
	public KeyControl get_deleteKey() { }

	// RVA: 0x13CDB8C
	public KeyControl get_capsLockKey() { }

	// RVA: 0x13CDC08
	public KeyControl get_scrollLockKey() { }

	// RVA: 0x13CDC84
	public KeyControl get_numLockKey() { }

	// RVA: 0x13CDD00
	public KeyControl get_printScreenKey() { }

	// RVA: 0x13CDD7C
	public KeyControl get_pauseKey() { }

	// RVA: 0x13CDDF8
	public KeyControl get_numpadEnterKey() { }

	// RVA: 0x13CDE74
	public KeyControl get_numpadDivideKey() { }

	// RVA: 0x13CDEF0
	public KeyControl get_numpadMultiplyKey() { }

	// RVA: 0x13CDF6C
	public KeyControl get_numpadMinusKey() { }

	// RVA: 0x13CDFE8
	public KeyControl get_numpadPlusKey() { }

	// RVA: 0x13CE064
	public KeyControl get_numpadPeriodKey() { }

	// RVA: 0x13CE0E0
	public KeyControl get_numpadEqualsKey() { }

	// RVA: 0x13CE15C
	public KeyControl get_numpad0Key() { }

	// RVA: 0x13CE1D8
	public KeyControl get_numpad1Key() { }

	// RVA: 0x13CE254
	public KeyControl get_numpad2Key() { }

	// RVA: 0x13CE2D0
	public KeyControl get_numpad3Key() { }

	// RVA: 0x13CE34C
	public KeyControl get_numpad4Key() { }

	// RVA: 0x13CE3C8
	public KeyControl get_numpad5Key() { }

	// RVA: 0x13CE444
	public KeyControl get_numpad6Key() { }

	// RVA: 0x13CE4C0
	public KeyControl get_numpad7Key() { }

	// RVA: 0x13CE53C
	public KeyControl get_numpad8Key() { }

	// RVA: 0x13CE5B8
	public KeyControl get_numpad9Key() { }

	// RVA: 0x13CE634
	public KeyControl get_f1Key() { }

	// RVA: 0x13CE6B0
	public KeyControl get_f2Key() { }

	// RVA: 0x13CE72C
	public KeyControl get_f3Key() { }

	// RVA: 0x13CE7A8
	public KeyControl get_f4Key() { }

	// RVA: 0x13CE824
	public KeyControl get_f5Key() { }

	// RVA: 0x13CE8A0
	public KeyControl get_f6Key() { }

	// RVA: 0x13CE91C
	public KeyControl get_f7Key() { }

	// RVA: 0x13CE998
	public KeyControl get_f8Key() { }

	// RVA: 0x13CEA14
	public KeyControl get_f9Key() { }

	// RVA: 0x13CEA90
	public KeyControl get_f10Key() { }

	// RVA: 0x13CEB0C
	public KeyControl get_f11Key() { }

	// RVA: 0x13CEB88
	public KeyControl get_f12Key() { }

	// RVA: 0x13CEC04
	public KeyControl get_oem1Key() { }

	// RVA: 0x13CEC80
	public KeyControl get_oem2Key() { }

	// RVA: 0x13CECFC
	public KeyControl get_oem3Key() { }

	// RVA: 0x13CED78
	public KeyControl get_oem4Key() { }

	// RVA: 0x13CEDF4
	public KeyControl get_oem5Key() { }

	// RVA: 0x13CEE70
	public ButtonControl get_shiftKey() { }

	// RVA: 0x13CEE78
	protected void set_shiftKey(ButtonControl value) { }

	// RVA: 0x13CEE88
	public ButtonControl get_ctrlKey() { }

	// RVA: 0x13CEE90
	protected void set_ctrlKey(ButtonControl value) { }

	// RVA: 0x13CEEA0
	public ButtonControl get_altKey() { }

	// RVA: 0x13CEEA8
	protected void set_altKey(ButtonControl value) { }

	// RVA: 0x13CEEB8
	public ButtonControl get_imeSelected() { }

	// RVA: 0x13CEEC0
	protected void set_imeSelected(ButtonControl value) { }

	// RVA: 0x13CB634
	public KeyControl get_Item(Key key) { }

	// RVA: 0x13CEED0
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys() { }

	// RVA: 0x13CEF3C
	public static Keyboard get_current() { }

	// RVA: 0x13CEF88
	private static void set_current(Keyboard value) { }

	// RVA: 0x13CEFEC
	public override void MakeCurrent() { }

	// RVA: 0x13CF048
	protected override void OnRemoved() { }

	// RVA: 0x13CF0E0
	protected override void FinishSetup() { }

	// RVA: 0x13D0878
	protected override void RefreshConfiguration() { }

	// RVA: 0x13D0958
	public void OnTextInput(Char character) { }

	// RVA: 0x13D0A0C
	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	// RVA: 0x13D0B7C
	public void OnIMECompositionChanged(IMECompositionString compositionString) { }

	// RVA: 0x13D0C80
	protected KeyControl[] get_keys() { }

	// RVA: 0x13D0C88
	protected void set_keys(KeyControl[] value) { }

	// RVA: 0x13D0C98
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Mouse
{
	// Fields
	private DeltaControl <scroll>k__BackingField; // 0x1A0
	private ButtonControl <leftButton>k__BackingField; // 0x1A8
	private ButtonControl <middleButton>k__BackingField; // 0x1B0
	private ButtonControl <rightButton>k__BackingField; // 0x1B8
	private ButtonControl <backButton>k__BackingField; // 0x1C0
	private ButtonControl <forwardButton>k__BackingField; // 0x1C8
	private IntegerControl <clickCount>k__BackingField; // 0x1D0
	private static Mouse <current>k__BackingField; // 0x0
	internal static Mouse s_PlatformMouseDevice; // 0x8

	// Methods

	// RVA: 0x13D0D1C
	public DeltaControl get_scroll() { }

	// RVA: 0x13D0D24
	protected void set_scroll(DeltaControl value) { }

	// RVA: 0x13D0D34
	public ButtonControl get_leftButton() { }

	// RVA: 0x13D0D3C
	protected void set_leftButton(ButtonControl value) { }

	// RVA: 0x13D0D4C
	public ButtonControl get_middleButton() { }

	// RVA: 0x13D0D54
	protected void set_middleButton(ButtonControl value) { }

	// RVA: 0x13D0D64
	public ButtonControl get_rightButton() { }

	// RVA: 0x13D0D6C
	protected void set_rightButton(ButtonControl value) { }

	// RVA: 0x13D0D7C
	public ButtonControl get_backButton() { }

	// RVA: 0x13D0D84
	protected void set_backButton(ButtonControl value) { }

	// RVA: 0x13D0D94
	public ButtonControl get_forwardButton() { }

	// RVA: 0x13D0D9C
	protected void set_forwardButton(ButtonControl value) { }

	// RVA: 0x13D0DAC
	public IntegerControl get_clickCount() { }

	// RVA: 0x13D0DB4
	protected void set_clickCount(IntegerControl value) { }

	// RVA: 0x13D0DC4
	public static Mouse get_current() { }

	// RVA: 0x13D0E10
	private static void set_current(Mouse value) { }

	// RVA: 0x13D0E74
	public override void MakeCurrent() { }

	// RVA: 0x13D0ED8
	protected override void OnAdded() { }

	// RVA: 0x13D0F54
	protected override void OnRemoved() { }

	// RVA: 0x13D0FF4
	public void WarpCursorPosition(Vector2 position) { }

	// RVA: 0x13D10A8
	protected override void FinishSetup() { }

	// RVA: 0x13D12DC
	protected void OnNextUpdate() { }

	// RVA: 0x13D1390
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13D13E4
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13D1498
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13D14EC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public enum PenButton
{
	// Fields
	public int value__; // 0x10
	public const PenButton Tip = 0;
	public const PenButton Eraser = 1;
	public const PenButton BarrelFirst = 2;
	public const PenButton BarrelSecond = 3;
	public const PenButton InRange = 4;
	public const PenButton BarrelThird = 5;
	public const PenButton BarrelFourth = 6;
	public const PenButton Barrel1 = 2;
	public const PenButton Barrel2 = 3;
	public const PenButton Barrel3 = 5;
	public const PenButton Barrel4 = 6;
}

// Namespace: UnityEngine.InputSystem
public class Pen
{
	// Fields
	private ButtonControl <tip>k__BackingField; // 0x1A0
	private ButtonControl <eraser>k__BackingField; // 0x1A8
	private ButtonControl <firstBarrelButton>k__BackingField; // 0x1B0
	private ButtonControl <secondBarrelButton>k__BackingField; // 0x1B8
	private ButtonControl <thirdBarrelButton>k__BackingField; // 0x1C0
	private ButtonControl <fourthBarrelButton>k__BackingField; // 0x1C8
	private ButtonControl <inRange>k__BackingField; // 0x1D0
	private Vector2Control <tilt>k__BackingField; // 0x1D8
	private AxisControl <twist>k__BackingField; // 0x1E0
	private static Pen <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13D14F4
	public ButtonControl get_tip() { }

	// RVA: 0x13D14FC
	protected void set_tip(ButtonControl value) { }

	// RVA: 0x13D150C
	public ButtonControl get_eraser() { }

	// RVA: 0x13D1514
	protected void set_eraser(ButtonControl value) { }

	// RVA: 0x13D1524
	public ButtonControl get_firstBarrelButton() { }

	// RVA: 0x13D152C
	protected void set_firstBarrelButton(ButtonControl value) { }

	// RVA: 0x13D153C
	public ButtonControl get_secondBarrelButton() { }

	// RVA: 0x13D1544
	protected void set_secondBarrelButton(ButtonControl value) { }

	// RVA: 0x13D1554
	public ButtonControl get_thirdBarrelButton() { }

	// RVA: 0x13D155C
	protected void set_thirdBarrelButton(ButtonControl value) { }

	// RVA: 0x13D156C
	public ButtonControl get_fourthBarrelButton() { }

	// RVA: 0x13D1574
	protected void set_fourthBarrelButton(ButtonControl value) { }

	// RVA: 0x13D1584
	public ButtonControl get_inRange() { }

	// RVA: 0x13D158C
	protected void set_inRange(ButtonControl value) { }

	// RVA: 0x13D159C
	public Vector2Control get_tilt() { }

	// RVA: 0x13D15A4
	protected void set_tilt(Vector2Control value) { }

	// RVA: 0x13D15B4
	public AxisControl get_twist() { }

	// RVA: 0x13D15BC
	protected void set_twist(AxisControl value) { }

	// RVA: 0x13D15CC
	public static Pen get_current() { }

	// RVA: 0x13D1618
	internal static void set_current(Pen value) { }

	// RVA: 0x13D167C
	public ButtonControl get_Item(PenButton button) { }

	// RVA: 0x13D17DC
	public override void MakeCurrent() { }

	// RVA: 0x13D1840
	protected override void OnRemoved() { }

	// RVA: 0x13D18E0
	protected override void FinishSetup() { }

	// RVA: 0x13D1B48
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Pointer
{
	// Fields
	private Vector2Control <position>k__BackingField; // 0x170
	private DeltaControl <delta>k__BackingField; // 0x178
	private Vector2Control <radius>k__BackingField; // 0x180
	private AxisControl <pressure>k__BackingField; // 0x188
	private ButtonControl <press>k__BackingField; // 0x190
	private IntegerControl <displayIndex>k__BackingField; // 0x198
	private static Pointer <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13D1B50
	public Vector2Control get_position() { }

	// RVA: 0x13D1B58
	protected void set_position(Vector2Control value) { }

	// RVA: 0x13D1B68
	public DeltaControl get_delta() { }

	// RVA: 0x13D1B70
	protected void set_delta(DeltaControl value) { }

	// RVA: 0x13D1B80
	public Vector2Control get_radius() { }

	// RVA: 0x13D1B88
	protected void set_radius(Vector2Control value) { }

	// RVA: 0x13D1B98
	public AxisControl get_pressure() { }

	// RVA: 0x13D1BA0
	protected void set_pressure(AxisControl value) { }

	// RVA: 0x13D1BB0
	public ButtonControl get_press() { }

	// RVA: 0x13D1BB8
	protected void set_press(ButtonControl value) { }

	// RVA: 0x13D1BC8
	public IntegerControl get_displayIndex() { }

	// RVA: 0x13D1BD0
	protected void set_displayIndex(IntegerControl value) { }

	// RVA: 0x13D1BE0
	public static Pointer get_current() { }

	// RVA: 0x13D1C2C
	internal static void set_current(Pointer value) { }

	// RVA: 0x13D1C90
	public override void MakeCurrent() { }

	// RVA: 0x13D1CF4
	protected override void OnRemoved() { }

	// RVA: 0x13D1D94
	protected override void FinishSetup() { }

	// RVA: 0x13D1F88
	protected void OnNextUpdate() { }

	// RVA: 0x13D2030
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13D2088
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13D2130
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13D2188
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

	// RVA: 0x13D2190
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
internal class FastKeyboard
{
	// Fields
	public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard";

	// Methods

	// RVA: 0x13D2198
	public void .ctor() { }

	// RVA: 0x13D50F4
	private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) { }

	// RVA: 0x13D52F4
	private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D54F8
	private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D56F0
	private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D58F4
	private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D5AEC
	private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D5CE4
	private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D5EDC
	private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D60D4
	private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D62CC
	private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D64C4
	private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D66BC
	private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D68B4
	private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D6AAC
	private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D6CA4
	private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D6E9C
	private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D7094
	private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D728C
	private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D7484
	private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D767C
	private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D7874
	private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D7A6C
	private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D7C64
	private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D7E5C
	private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D8054
	private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D824C
	private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D8444
	private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D863C
	private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D8834
	private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D8A2C
	private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D8C24
	private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D8E1C
	private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D9014
	private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D920C
	private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D9404
	private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D95FC
	private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D97F4
	private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D99EC
	private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D9BE4
	private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D9DDC
	private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D9FD4
	private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DA1CC
	private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DA3C4
	private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DA5BC
	private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DA7B4
	private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DA9AC
	private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DABA4
	private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DAD88
	private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DAF6C
	private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DB150
	private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DB334
	private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DB518
	private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DB6FC
	private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DB8E0
	private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DBAC4
	private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DBCA8
	private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DBE8C
	private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DC090
	private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DC294
	private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13DC4B8
	private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DC6BC
	private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DC8C0
	private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13DCAE4
	private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DCCE8
	private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DCEEC
	private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13DD110
	private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DD314
	private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DD518
	private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DD71C
	private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DD914
	private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DDB0C
	private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DDD04
	private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DDEFC
	private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DE0F4
	private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DE2EC
	private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DE4E4
	private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DE6DC
	private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DE8D4
	private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DEACC
	private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DECC4
	private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DEEBC
	private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DF0B4
	private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DF2AC
	private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DF4A4
	private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DF69C
	private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DF894
	private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DFA8C
	private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DFC84
	private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13DFE7C
	private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E0074
	private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E026C
	private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E0464
	private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E065C
	private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E0854
	private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E0A4C
	private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E0C44
	private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E0E3C
	private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1034
	private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E122C
	private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1424
	private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E161C
	private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1814
	private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1A0C
	private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1C04
	private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1DFC
	private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E1FF4
	private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E21EC
	private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E23E4
	private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E25DC
	private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E27D4
	private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E29B8
	private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E2B9C
	private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E2D80
	private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E2F64
	private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13E3148
	private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastMouse
{
	// Fields
	public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";

	// Methods

	// RVA: 0x13E3334
	public void .ctor() { }

	// RVA: 0x13E3E08
	private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E3FF4
	private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13E41B8
	private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13E4368
	private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E4568
	private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E47AC
	private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E49F0
	private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E4C28
	private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E4E20
	private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E5018
	private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E5204
	private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E53CC
	private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	// RVA: 0x13E555C
	private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E5700
	private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E58B8
	private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E5AC4
	private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E5CD0
	private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E5ED8
	private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E60E8
	private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E62F8
	private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E6500
	private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E66DC
	private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E68B8
	private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E6AC0
	private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E6CD0
	private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E6EE0
	private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E70E8
	private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E72DC
	private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E74E4
	private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E76C0
	private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E789C
	protected void OnNextUpdate() { }

	// RVA: 0x13E7A10
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13E7BB8
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13E7BBC
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13E7BC0
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x13E7CEC
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastTouchscreen
{
	// Fields
	public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer";

	// Methods

	// RVA: 0x13E7CF8
	public void .ctor() { }

	// RVA: 0x13EB2B0
	private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EB474
	private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EB65C
	private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13EB824
	private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) { }

	// RVA: 0x13EBA10
	private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EBBD8
	private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13EBDD8
	private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EBF88
	private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EC138
	private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EC2E8
	private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EC498
	private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EC648
	private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EC7F8
	private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13EC9A8
	private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13ECB58
	private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13ECD08
	private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13ECEB8
	private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13ED05C
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13ED27C
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13ED494
	private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13ED67C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13ED858
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EDA40
	private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13EDC30
	private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13EDE54
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EE030
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EE20C
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13EE444
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13EE674
	private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13EE864
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EEA60
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EEC6C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EEE78
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EF080
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EF290
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EF4A0
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EF6A8
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EF884
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EFA60
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EFC3C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EFE18
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EFFF4
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F01D0
	private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F03DC
	private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F05E8
	private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F07F0
	private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0A00
	private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0C10
	private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0E18
	private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0FF4
	private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F11D0
	private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F13AC
	private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F1588
	private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F17A8
	private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F19C0
	private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13F1BA8
	private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F1D84
	private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F1F6C
	private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13F215C
	private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13F2380
	private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F255C
	private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F2738
	private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F2970
	private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F2B94
	private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13F2D84
	private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F2F80
	private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F318C
	private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3398
	private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F35A0
	private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F37B0
	private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F39C0
	private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3BC8
	private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3DA4
	private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3F80
	private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F415C
	private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4338
	private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4514
	private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F46F0
	private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F4910
	private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F4B28
	private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13F4D10
	private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4EEC
	private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F50D4
	private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13F52C4
	private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13F54E8
	private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F56C4
	private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F58A0
	private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F5AD8
	private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F5CFC
	private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13F5EEC
	private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F60E8
	private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F62F4
	private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6500
	private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6708
	private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6918
	private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6B28
	private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6D30
	private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6F0C
	private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F70E8
	private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F72C4
	private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F74A0
	private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F767C
	private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F7858
	private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F7A78
	private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F7C90
	private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13F7E78
	private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F8054
	private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F823C
	private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13F842C
	private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13F8650
	private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F882C
	private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F8A08
	private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F8C40
	private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F8E64
	private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13F9054
	private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F9250
	private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F945C
	private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9668
	private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9870
	private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9A80
	private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9C90
	private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9E98
	private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA074
	private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA250
	private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA42C
	private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA608
	private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA7E4
	private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA9C0
	private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FABE0
	private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FADF8
	private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13FAFE0
	private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FB1BC
	private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FB3A4
	private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13FB594
	private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13FB7B8
	private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FB994
	private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FBB70
	private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FBDA8
	private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FBFCC
	private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13FC1BC
	private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FC3B8
	private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FC5C4
	private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FC7D0
	private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FC9D8
	private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FCBE8
	private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FCDF8
	private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD000
	private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD1DC
	private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD3B8
	private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD594
	private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD770
	private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD94C
	private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FDB28
	private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FDD48
	private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FDF60
	private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13FE148
	private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FE324
	private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FE50C
	private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13FE6FC
	private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13FE920
	private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FEAFC
	private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FECD8
	private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FEF10
	private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FF134
	private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13FF324
	private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FF520
	private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FF72C
	private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FF938
	private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FFB40
	private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FFD50
	private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FFF60
	private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400168
	private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400344
	private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400520
	private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14006FC
	private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14008D8
	private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400AB4
	private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400C90
	private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1400EB0
	private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14010C8
	private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x14012B0
	private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140148C
	private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1401674
	private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1401864
	private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1401A88
	private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1401C64
	private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1401E40
	private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1402078
	private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x140229C
	private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x140248C
	private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1402688
	private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1402894
	private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1402AA0
	private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1402CA8
	private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1402EB8
	private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14030C8
	private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14032D0
	private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14034AC
	private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1403688
	private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1403864
	private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1403A40
	private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1403C1C
	private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1403DF8
	private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1404018
	private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1404230
	private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1404418
	private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14045F4
	private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14047DC
	private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x14049CC
	private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1404BF0
	private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1404DCC
	private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1404FA8
	private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14051E0
	private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1405404
	private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x14055F4
	private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14057F0
	private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14059FC
	private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1405C08
	private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1405E10
	private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406020
	private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406230
	private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406438
	private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406614
	private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14067F0
	private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14069CC
	private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406BA8
	private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406D84
	private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1406F60
	private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1407180
	private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1407398
	private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1407580
	private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140775C
	private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1407944
	private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1407B34
	private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1407D58
	private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1407F34
	private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1408110
	private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1408348
	private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x140856C
	private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x140875C
	private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1408958
	private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1408B64
	private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1408D70
	private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1408F78
	private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1409188
	private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1409398
	private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14095A0
	private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140977C
	private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1409958
	private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1409B34
	private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1409D10
	private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1409EEC
	private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140A0C8
	private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x140A2E8
	private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140A500
	private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x140A6E8
	private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140A8C4
	private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140AAAC
	private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x140AC9C
	private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x140AEC0
	private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x140B09C
	private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x140B278
	private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x140B4B0
	private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x140B6D4
	private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x140B8C4
	private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140BAC0
	private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140BCCC
	private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140BED8
	private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140C0E0
	private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140C2F0
	private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140C500
	private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140C708
	private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140C8E4
	private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140CAC0
	private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140CC9C
	private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140CE78
	private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140D054
	private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140D230
	private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x140D450
	private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140D668
	private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x140D850
	private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140DA2C
	private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140DC14
	private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x140DE04
	private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x140E028
	private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x140E204
	private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x140E3E0
	private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x140E618
	private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x140E83C
	private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x140EA2C
	private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140EC28
	private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140EE34
	private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140F040
	private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140F248
	private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140F458
	private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140F668
	private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140F870
	private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140FA4C
	private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140FC28
	private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140FE04
	private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140FFE0
	private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14101BC
	private AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent) { }

}

// Namespace: 
public enum MessageType
{
	// Fields
	public int value__; // 0x10
	public const MessageType Connect = 0;
	public const MessageType Disconnect = 1;
	public const MessageType NewLayout = 2;
	public const MessageType NewDevice = 3;
	public const MessageType NewEvents = 4;
	public const MessageType RemoveDevice = 5;
	public const MessageType RemoveLayout = 6;
	public const MessageType ChangeUsages = 7;
	public const MessageType StartSending = 8;
	public const MessageType StopSending = 9;
}

// Namespace: 
public struct Message
{
	// Fields
	public int participantId; // 0x10
	public MessageType type; // 0x14
	public Byte[] data; // 0x18
}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags Sending = 1;
	public const Flags StartSendingOnConnect = 2;
}

// Namespace: 
[Serializable]
internal struct RemoteSender
{
	// Fields
	public int senderId; // 0x10
	public InternedString[] layouts; // 0x18
	public RemoteInputDevice[] devices; // 0x20
}

// Namespace: 
[Serializable]
internal struct RemoteInputDevice
{
	// Fields
	public int remoteId; // 0x10
	public int localId; // 0x14
	public InputDeviceDescription description; // 0x18
}

// Namespace: 
internal class Subscriber
{
	// Fields
	public InputRemoting owner; // 0x10
	public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer; // 0x18

	// Methods

	// RVA: 0x1413A48
	public void Dispose() { }

	// RVA: 0x1411BE4
	public void .ctor() { }

}

// Namespace: 
private static class ConnectMsg
{
	// Methods

	// RVA: 0x1410B80
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StartSendingMsg
{
	// Methods

	// RVA: 0x1411AB4
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StopSendingMsg
{
	// Methods

	// RVA: 0x1411AC8
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class DisconnectMsg
{
	// Methods

	// RVA: 0x1410BD8
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
[Serializable]
public struct Data
{
	// Fields
	public string name; // 0x10
	public string layoutJson; // 0x18
	public bool isOverride; // 0x20
}

// Namespace: 
private static class NewLayoutMsg
{
	// Methods

	// RVA: 0x141215C
	public static System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(InputRemoting sender, string layoutName) { }

	// RVA: 0x1410C94
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
[Serializable]
public struct Data
{
	// Fields
	public string name; // 0x10
	public string layout; // 0x18
	public int deviceId; // 0x20
	public string[] usages; // 0x28
	public InputDeviceDescription description; // 0x30
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputRemoting.NewDeviceMsg.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x1414370
	private static void .cctor() { }

	// RVA: 0x14143DC
	public void .ctor() { }

	// RVA: 0x14143E4
	internal string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class NewDeviceMsg
{
	// Methods

	// RVA: 0x1412624
	public static Message Create(InputDevice device) { }

	// RVA: 0x1410E20
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class NewEventsMsg
{
	// Methods

	// RVA: 0x1412E90
	public static Message CreateResetEvent(InputDevice device, bool isHardReset) { }

	// RVA: 0x14128A0
	public static Message CreateStateEvent(InputDevice device) { }

	// RVA: 0x1412A00
	public static Message Create(InputEvent* events, int eventCount) { }

	// RVA: 0x14113E4
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
[Serializable]
public struct Data
{
	// Fields
	public int deviceId; // 0x10
	public string[] usages; // 0x18
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputRemoting.ChangeUsageMsg.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x14145E4
	private static void .cctor() { }

	// RVA: 0x1414650
	public void .ctor() { }

	// RVA: 0x1414658
	internal string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class ChangeUsageMsg
{
	// Methods

	// RVA: 0x1412CA0
	public static Message Create(InputDevice device) { }

	// RVA: 0x141164C
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class RemoveDeviceMsg
{
	// Methods

	// RVA: 0x1412C50
	public static Message Create(InputDevice device) { }

	// RVA: 0x14119BC
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: UnityEngine.InputSystem
public sealed class InputRemoting
{
	// Fields
	private Flags m_Flags; // 0x10
	private InputManager m_LocalManager; // 0x18
	private Subscriber[] m_Subscribers; // 0x20
	private RemoteSender[] m_Senders; // 0x28

	// Methods

	// RVA: 0x1410398
	public bool get_sending() { }

	// RVA: 0x14103A4
	private void set_sending(bool value) { }

	// RVA: 0x14103B8
	internal void .ctor(InputManager manager, bool startSendingOnConnect) { }

	// RVA: 0x1410458
	public void StartSending() { }

	// RVA: 0x1410794
	public void StopSending() { }

	// RVA: 0x1410A8C
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x1411ADC
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x1411AE0
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x1411AE4
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x1410770
	private void SendInitialMessages() { }

	// RVA: 0x1411BEC
	private void SendAllGeneratedLayouts() { }

	// RVA: 0x141207C
	private void SendLayout(string layoutName) { }

	// RVA: 0x1411E70
	private void SendAllDevices() { }

	// RVA: 0x141259C
	private void SendDevice(InputDevice device) { }

	// RVA: 0x1412998
	private void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x1412B08
	private void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1412F0C
	private void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	// RVA: 0x1412424
	private void Send(Message msg) { }

	// RVA: 0x1413048
	private int FindOrCreateSenderRecord(int senderId) { }

	// RVA: 0x14130F4
	private static InternedString BuildLayoutNamespace(int senderId) { }

	// RVA: 0x1413194
	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x1413208
	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x141337C
	internal InputManager get_manager() { }

	// RVA: 0x1413384
	public void RemoveRemoteDevices(int participantId) { }

	// RVA: 0x316B894
	private static Byte[] SerializeData(TData data) { }

	// RVA: 0x316B894
	private static TData DeserializeData(Byte[] data) { }

}

// Namespace: 
private class Subscriber
{
	// Fields
	public RemoteInputPlayerConnection owner; // 0x10
	public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer; // 0x18

	// Methods

	// RVA: 0x141571C
	public void Dispose() { }

	// RVA: 0x1414FEC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
internal class RemoteInputPlayerConnection
{
	// Fields
	public static readonly Guid kNewDeviceMsg; // 0x0
	public static readonly Guid kNewLayoutMsg; // 0x10
	public static readonly Guid kNewEventsMsg; // 0x20
	public static readonly Guid kRemoveDeviceMsg; // 0x30
	public static readonly Guid kChangeUsagesMsg; // 0x40
	public static readonly Guid kStartSendingMsg; // 0x50
	public static readonly Guid kStopSendingMsg; // 0x60
	private IEditorPlayerConnection m_Connection; // 0x18
	private Subscriber[] m_Subscribers; // 0x20
	private int[] m_ConnectedIds; // 0x28

	// Methods

	// RVA: 0x1414680
	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	// RVA: 0x1414E38
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x1414D54
	private void OnConnected(int id) { }

	// RVA: 0x1415128
	private void OnDisconnected(int id) { }

	// RVA: 0x141520C
	private void OnNewDevice(MessageEventArgs args) { }

	// RVA: 0x1415218
	private void OnNewLayout(MessageEventArgs args) { }

	// RVA: 0x1415224
	private void OnNewEvents(MessageEventArgs args) { }

	// RVA: 0x1415230
	private void OnRemoveDevice(MessageEventArgs args) { }

	// RVA: 0x141523C
	private void OnChangeUsages(MessageEventArgs args) { }

	// RVA: 0x1415248
	private void OnStartSending(MessageEventArgs args) { }

	// RVA: 0x1415254
	private void OnStopSending(MessageEventArgs args) { }

	// RVA: 0x1414FF4
	private void SendToSubscribers(MessageType type, MessageEventArgs args) { }

	// RVA: 0x1415260
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x141551C
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x1415520
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x1415524
	public void .ctor() { }

	// RVA: 0x141552C
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Sensor
{
	// Methods

	// RVA: 0x1415778
	public float get_samplingFrequency() { }

	// RVA: 0x1415874
	public void set_samplingFrequency(float value) { }

	// RVA: 0x1415924
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Accelerometer
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x170
	private static Accelerometer <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x141592C
	public Vector3Control get_acceleration() { }

	// RVA: 0x1415934
	protected void set_acceleration(Vector3Control value) { }

	// RVA: 0x1415944
	public static Accelerometer get_current() { }

	// RVA: 0x1415990
	private static void set_current(Accelerometer value) { }

	// RVA: 0x14159F4
	public override void MakeCurrent() { }

	// RVA: 0x1415A58
	protected override void OnRemoved() { }

	// RVA: 0x1415AF8
	protected override void FinishSetup() { }

	// RVA: 0x1415B80
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Gyroscope
{
	// Fields
	private Vector3Control <angularVelocity>k__BackingField; // 0x170
	private static Gyroscope <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1415B88
	public Vector3Control get_angularVelocity() { }

	// RVA: 0x1415B90
	protected void set_angularVelocity(Vector3Control value) { }

	// RVA: 0x1415BA0
	public static Gyroscope get_current() { }

	// RVA: 0x1415BEC
	private static void set_current(Gyroscope value) { }

	// RVA: 0x1415C50
	public override void MakeCurrent() { }

	// RVA: 0x1415CB4
	protected override void OnRemoved() { }

	// RVA: 0x1415D54
	protected override void FinishSetup() { }

	// RVA: 0x1415DDC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class GravitySensor
{
	// Fields
	private Vector3Control <gravity>k__BackingField; // 0x170
	private static GravitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1415DE4
	public Vector3Control get_gravity() { }

	// RVA: 0x1415DEC
	protected void set_gravity(Vector3Control value) { }

	// RVA: 0x1415DFC
	public static GravitySensor get_current() { }

	// RVA: 0x1415E48
	private static void set_current(GravitySensor value) { }

	// RVA: 0x1415EAC
	protected override void FinishSetup() { }

	// RVA: 0x1415F34
	public override void MakeCurrent() { }

	// RVA: 0x1415F98
	protected override void OnRemoved() { }

	// RVA: 0x1416038
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AttitudeSensor
{
	// Fields
	private QuaternionControl <attitude>k__BackingField; // 0x170
	private static AttitudeSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1416040
	public QuaternionControl get_attitude() { }

	// RVA: 0x1416048
	protected void set_attitude(QuaternionControl value) { }

	// RVA: 0x1416058
	public static AttitudeSensor get_current() { }

	// RVA: 0x14160A4
	private static void set_current(AttitudeSensor value) { }

	// RVA: 0x1416108
	public override void MakeCurrent() { }

	// RVA: 0x141616C
	protected override void OnRemoved() { }

	// RVA: 0x141620C
	protected override void FinishSetup() { }

	// RVA: 0x1416294
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LinearAccelerationSensor
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x170
	private static LinearAccelerationSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x141629C
	public Vector3Control get_acceleration() { }

	// RVA: 0x14162A4
	protected void set_acceleration(Vector3Control value) { }

	// RVA: 0x14162B4
	public static LinearAccelerationSensor get_current() { }

	// RVA: 0x1416300
	private static void set_current(LinearAccelerationSensor value) { }

	// RVA: 0x1416364
	public override void MakeCurrent() { }

	// RVA: 0x14163C8
	protected override void OnRemoved() { }

	// RVA: 0x1416468
	protected override void FinishSetup() { }

	// RVA: 0x14164F0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class MagneticFieldSensor
{
	// Fields
	private Vector3Control <magneticField>k__BackingField; // 0x170
	private static MagneticFieldSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x14164F8
	public Vector3Control get_magneticField() { }

	// RVA: 0x1416500
	protected void set_magneticField(Vector3Control value) { }

	// RVA: 0x1416510
	public static MagneticFieldSensor get_current() { }

	// RVA: 0x141655C
	private static void set_current(MagneticFieldSensor value) { }

	// RVA: 0x14165C0
	public override void MakeCurrent() { }

	// RVA: 0x1416624
	protected override void OnRemoved() { }

	// RVA: 0x14166C4
	protected override void FinishSetup() { }

	// RVA: 0x141674C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LightSensor
{
	// Fields
	private AxisControl <lightLevel>k__BackingField; // 0x170
	private static LightSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1416754
	public AxisControl get_lightLevel() { }

	// RVA: 0x141675C
	protected void set_lightLevel(AxisControl value) { }

	// RVA: 0x141676C
	public static LightSensor get_current() { }

	// RVA: 0x14167B8
	private static void set_current(LightSensor value) { }

	// RVA: 0x141681C
	public override void MakeCurrent() { }

	// RVA: 0x1416880
	protected override void OnRemoved() { }

	// RVA: 0x1416920
	protected override void FinishSetup() { }

	// RVA: 0x14169A8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PressureSensor
{
	// Fields
	private AxisControl <atmosphericPressure>k__BackingField; // 0x170
	private static PressureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x14169B0
	public AxisControl get_atmosphericPressure() { }

	// RVA: 0x14169B8
	protected void set_atmosphericPressure(AxisControl value) { }

	// RVA: 0x14169C8
	public static PressureSensor get_current() { }

	// RVA: 0x1416A14
	private static void set_current(PressureSensor value) { }

	// RVA: 0x1416A78
	public override void MakeCurrent() { }

	// RVA: 0x1416ADC
	protected override void OnRemoved() { }

	// RVA: 0x1416B7C
	protected override void FinishSetup() { }

	// RVA: 0x1416C04
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class ProximitySensor
{
	// Fields
	private AxisControl <distance>k__BackingField; // 0x170
	private static ProximitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1416C0C
	public AxisControl get_distance() { }

	// RVA: 0x1416C14
	protected void set_distance(AxisControl value) { }

	// RVA: 0x1416C24
	public static ProximitySensor get_current() { }

	// RVA: 0x1416C70
	private static void set_current(ProximitySensor value) { }

	// RVA: 0x1416CD4
	public override void MakeCurrent() { }

	// RVA: 0x1416D38
	protected override void OnRemoved() { }

	// RVA: 0x1416DD8
	protected override void FinishSetup() { }

	// RVA: 0x1416E60
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class HumiditySensor
{
	// Fields
	private AxisControl <relativeHumidity>k__BackingField; // 0x170
	private static HumiditySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1416E68
	public AxisControl get_relativeHumidity() { }

	// RVA: 0x1416E70
	protected void set_relativeHumidity(AxisControl value) { }

	// RVA: 0x1416E80
	public static HumiditySensor get_current() { }

	// RVA: 0x1416ECC
	private static void set_current(HumiditySensor value) { }

	// RVA: 0x1416F30
	public override void MakeCurrent() { }

	// RVA: 0x1416F94
	protected override void OnRemoved() { }

	// RVA: 0x1417034
	protected override void FinishSetup() { }

	// RVA: 0x14170BC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AmbientTemperatureSensor
{
	// Fields
	private AxisControl <ambientTemperature>k__BackingField; // 0x170
	private static AmbientTemperatureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x14170C4
	public AxisControl get_ambientTemperature() { }

	// RVA: 0x14170CC
	protected void set_ambientTemperature(AxisControl value) { }

	// RVA: 0x14170DC
	public static AmbientTemperatureSensor get_current() { }

	// RVA: 0x1417128
	private static void set_current(AmbientTemperatureSensor value) { }

	// RVA: 0x141718C
	public override void MakeCurrent() { }

	// RVA: 0x14171F0
	protected override void OnRemoved() { }

	// RVA: 0x1417290
	protected override void FinishSetup() { }

	// RVA: 0x1417318
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class StepCounter
{
	// Fields
	private IntegerControl <stepCounter>k__BackingField; // 0x170
	private static StepCounter <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1417320
	public IntegerControl get_stepCounter() { }

	// RVA: 0x1417328
	protected void set_stepCounter(IntegerControl value) { }

	// RVA: 0x1417338
	public static StepCounter get_current() { }

	// RVA: 0x1417384
	private static void set_current(StepCounter value) { }

	// RVA: 0x14173E8
	public override void MakeCurrent() { }

	// RVA: 0x141744C
	protected override void OnRemoved() { }

	// RVA: 0x14174EC
	protected override void FinishSetup() { }

	// RVA: 0x1417574
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public enum TouchPhase
{
	// Fields
	public int value__; // 0x10
	public const TouchPhase None = 0;
	public const TouchPhase Began = 1;
	public const TouchPhase Moved = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
	public const TouchPhase Stationary = 5;
}

// Namespace: UnityEngine.InputSystem
public class Touchscreen
{
	// Fields
	private TouchControl <primaryTouch>k__BackingField; // 0x1A0
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> <touches>k__BackingField; // 0x1A8
	private static Touchscreen <current>k__BackingField; // 0x0
	internal static float s_TapTime; // 0x8
	internal static float s_TapDelayTime; // 0xC
	internal static float s_TapRadiusSquared; // 0x10

	// Methods

	// RVA: 0x141757C
	public TouchControl get_primaryTouch() { }

	// RVA: 0x1417584
	protected void set_primaryTouch(TouchControl value) { }

	// RVA: 0x1417594
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches() { }

	// RVA: 0x14175A0
	protected void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value) { }

	// RVA: 0x14175B4
	protected TouchControl[] get_touchControlArray() { }

	// RVA: 0x14175BC
	protected void set_touchControlArray(TouchControl[] value) { }

	// RVA: 0x141763C
	public static Touchscreen get_current() { }

	// RVA: 0x1417688
	internal static void set_current(Touchscreen value) { }

	// RVA: 0x14176EC
	public override void MakeCurrent() { }

	// RVA: 0x1417750
	protected override void OnRemoved() { }

	// RVA: 0x14177F0
	protected override void FinishSetup() { }

	// RVA: 0x1417C90
	protected void OnNextUpdate() { }

	// RVA: 0x1417FE4
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1418790
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x1418794
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1418798
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

	// RVA: 0x1418A8C
	private void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	// RVA: 0x1418F30
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x1419060
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x14186B8
	private static void TriggerTap(TouchControl control, TouchState state, InputEventPtr eventPtr) { }

	// RVA: 0x141906C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class TrackedDevice
{
	// Fields
	private IntegerControl <trackingState>k__BackingField; // 0x170
	private ButtonControl <isTracked>k__BackingField; // 0x178
	private Vector3Control <devicePosition>k__BackingField; // 0x180
	private QuaternionControl <deviceRotation>k__BackingField; // 0x188

	// Methods

	// RVA: 0x1419074
	public IntegerControl get_trackingState() { }

	// RVA: 0x141907C
	protected void set_trackingState(IntegerControl value) { }

	// RVA: 0x141908C
	public ButtonControl get_isTracked() { }

	// RVA: 0x1419094
	protected void set_isTracked(ButtonControl value) { }

	// RVA: 0x14190A4
	public Vector3Control get_devicePosition() { }

	// RVA: 0x14190AC
	protected void set_devicePosition(Vector3Control value) { }

	// RVA: 0x14190BC
	public QuaternionControl get_deviceRotation() { }

	// RVA: 0x14190C4
	protected void set_deviceRotation(QuaternionControl value) { }

	// RVA: 0x14190D4
	protected override void FinishSetup() { }

	// RVA: 0x141924C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputExtensions
{
	// Methods

	// RVA: 0x1419254
	public static bool IsInProgress(InputActionPhase phase) { }

	// RVA: 0x1419264
	public static bool IsEndedOrCanceled(TouchPhase phase) { }

	// RVA: 0x1418A78
	public static bool IsActive(TouchPhase phase) { }

	// RVA: 0x1419274
	public static bool IsModifierKey(Key key) { }

	// RVA: 0x1419284
	public static bool IsTextInputKey(Key key) { }

}

// Namespace: UnityEngine.InputSystem
internal static class InputFeatureNames
{
	// Fields
	public const string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE";
	public const string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT";
	public const string kUseWindowsGamingInputBackend = "USE_WINDOWS_GAMING_INPUT_BACKEND";
	public const string kUseOptimizedControls = "USE_OPTIMIZED_CONTROLS";
	public const string kUseReadValueCaching = "USE_READ_VALUE_CACHING";
	public const string kParanoidReadValueCachingChecks = "PARANOID_READ_VALUE_CACHING_CHECKS";
	public const string kUseIMGUIEditorForAssets = "USE_IMGUI_EDITOR_FOR_ASSETS";
}

// Namespace: 
internal enum DeviceDisableScope
{
	// Fields
	public int value__; // 0x10
	public const DeviceDisableScope Everywhere = 0;
	public const DeviceDisableScope InFrontendOnly = 1;
	public const DeviceDisableScope TemporaryWhilePlayerIsInBackground = 2;
}

// Namespace: 
[Serializable]
internal struct AvailableDevice
{
	// Fields
	public InputDeviceDescription description; // 0x10
	public int deviceId; // 0x48
	public bool isNative; // 0x4C
	public bool isRemoved; // 0x4D
}

// Namespace: 
private struct StateChangeMonitorTimeout
{
	// Fields
	public InputControl control; // 0x10
	public Double time; // 0x18
	public IInputStateChangeMonitor monitor; // 0x20
	public Int64 monitorIndex; // 0x28
	public int timerIndex; // 0x30
}

// Namespace: 
internal struct StateChangeMonitorListener
{
	// Fields
	public InputControl control; // 0x10
	public IInputStateChangeMonitor monitor; // 0x18
	public Int64 monitorIndex; // 0x20
	public UInt32 groupIndex; // 0x28
}

// Namespace: 
internal struct StateChangeMonitorsForDevice
{
	// Fields
	public BitRegion[] memoryRegions; // 0x10
	public StateChangeMonitorListener[] listeners; // 0x18
	public DynamicBitfield signalled; // 0x20
	public bool needToUpdateOrderingOfMonitors; // 0x40
	public bool needToCompactArrays; // 0x41

	// Methods

	// RVA: 0x1426198
	public int get_count() { }

	// RVA: 0x14256EC
	public void Add(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x1425A44
	public void Remove(IInputStateChangeMonitor monitor, Int64 monitorIndex, bool deferRemoval) { }

	// RVA: 0x1425870
	public void Clear() { }

	// RVA: 0x14255DC
	public void CompactArrays() { }

	// RVA: 0x1426220
	private void RemoveAt(int i) { }

	// RVA: 0x1425DC8
	public void SortMonitorsByIndex() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputManager.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.InputDevice,System.String> <>9__153_0; // 0x8

	// Methods

	// RVA: 0x14262DC
	private static void .cctor() { }

	// RVA: 0x1426348
	public void .ctor() { }

	// RVA: 0x1426350
	internal string <MakeDeviceNameUnique>b__153_0(InputDevice x) { }

}

// Namespace: 
[Serializable]
private sealed class <>c__66<T0>
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputManager.<>c__66<TDevice> <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.InputDevice> <>9__66_0; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1CD4
	internal InputDevice <RegisterPrecompiledLayout>b__66_0() { }

}

// Namespace: 
private sealed class <ListControlLayouts>d__81
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string basedOn; // 0x28
	public string <>3__basedOn; // 0x30
	public InputManager <>4__this; // 0x38
	private InternedString <internedBasedOn>5__2; // 0x40
	private Enumerator <>7__wrap2; // 0x50
	private Enumerator <>7__wrap3; // 0x80
	private Enumerator <>7__wrap4; // 0xB0

	// Methods

	// RVA: 0x141DAE0
	public void .ctor(int <>1__state) { }

	// RVA: 0x14263B8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1426534
	private bool MoveNext() { }

	// RVA: 0x1427914
	private void <>m__Finally1() { }

	// RVA: 0x1427970
	private void <>m__Finally2() { }

	// RVA: 0x14279CC
	private void <>m__Finally3() { }

	// RVA: 0x1427A28
	private void <>m__Finally4() { }

	// RVA: 0x1427A84
	private void <>m__Finally5() { }

	// RVA: 0x1427AE0
	private void <>m__Finally6() { }

	// RVA: 0x1427B3C
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x1427B44
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1427B84
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1427B8C
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x1427C44
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
internal class InputManager
{
	// Fields
	internal int m_LayoutRegistrationVersion; // 0x10
	private float m_PollingFrequency; // 0x14
	internal Collection m_Layouts; // 0x18
	private TypeTable m_Processors; // 0x58
	private TypeTable m_Interactions; // 0x60
	private TypeTable m_Composites; // 0x68
	private int m_DevicesCount; // 0x70
	private InputDevice[] m_Devices; // 0x78
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.InputSystem.InputDevice> m_DevicesById; // 0x80
	internal int m_AvailableDeviceCount; // 0x88
	internal AvailableDevice[] m_AvailableDevices; // 0x90
	internal int m_DisconnectedDevicesCount; // 0x98
	internal InputDevice[] m_DisconnectedDevices; // 0xA0
	internal InputUpdateType m_UpdateMask; // 0xA8
	private InputUpdateType m_CurrentUpdate; // 0xAC
	internal InputStateBuffers m_StateBuffers; // 0xB0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>> m_DeviceChangeListeners; // 0xE0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_DeviceStateChangeListeners; // 0x130
	private UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; // 0x180
	internal UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate> m_DeviceCommandCallbacks; // 0x1D0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange>> m_LayoutChangeListeners; // 0x220
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>> m_EventListeners; // 0x270
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_BeforeUpdateListeners; // 0x2C0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_AfterUpdateListeners; // 0x310
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_SettingsChangedListeners; // 0x360
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_ActionsChangedListeners; // 0x3B0
	private bool m_NativeBeforeUpdateHooked; // 0x400
	private bool m_HaveDevicesWithStateCallbackReceivers; // 0x401
	private bool m_HasFocus; // 0x402
	private InputEventStream m_InputEventStream; // 0x408
	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; // 0x480
	private int m_DeviceFindExecuteCommandDeviceId; // 0x488
	internal IInputRuntime m_Runtime; // 0x490
	internal InputMetrics m_Metrics; // 0x498
	internal InputSettings m_Settings; // 0x4D0
	private InputActionAsset m_Actions; // 0x4D8
	private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; // 0x4E0
	internal StateChangeMonitorsForDevice[] m_StateChangeMonitors; // 0x4E8
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; // 0x4F0

	// Methods

	// RVA: 0x1412528
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x14192A8
	public TypeTable get_processors() { }

	// RVA: 0x14192B0
	public TypeTable get_interactions() { }

	// RVA: 0x14192B8
	public TypeTable get_composites() { }

	// RVA: 0x14192C0
	public InputMetrics get_metrics() { }

	// RVA: 0x1419460
	public InputSettings get_settings() { }

	// RVA: 0x1419468
	public void set_settings(InputSettings value) { }

	// RVA: 0x1419BC0
	public InputActionAsset get_actions() { }

	// RVA: 0x1419BC8
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x1419C8C
	public InputUpdateType get_updateMask() { }

	// RVA: 0x1419C94
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x1419E30
	public InputUpdateType get_defaultUpdateType() { }

	// RVA: 0x1419E4C
	public float get_pollingFrequency() { }

	// RVA: 0x1419E54
	public void set_pollingFrequency(float value) { }

	// RVA: 0x14106B8
	public void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x14109D4
	public void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x1419F80
	public void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1419FDC
	public void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x141A038
	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x141A094
	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x141A0F0
	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x141A434
	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x1410714
	public void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x1410A30
	public void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x141065C
	public void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1410978
	public void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x141A490
	public void add_onBeforeUpdate(Action value) { }

	// RVA: 0x141A60C
	public void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x141A668
	public void add_onAfterUpdate(Action value) { }

	// RVA: 0x141A6C4
	public void remove_onAfterUpdate(Action value) { }

	// RVA: 0x141A720
	public void add_onSettingsChange(Action value) { }

	// RVA: 0x141A77C
	public void remove_onSettingsChange(Action value) { }

	// RVA: 0x141A7D8
	public void add_onActionsChange(Action value) { }

	// RVA: 0x141A834
	public void remove_onActionsChange(Action value) { }

	// RVA: 0x141A890
	public bool get_isProcessingEvents() { }

	// RVA: 0x141A898
	private bool get_gameIsPlaying() { }

	// RVA: 0x141A8A0
	private bool get_gameHasFocus() { }

	// RVA: 0x141A8DC
	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	// RVA: 0x141A904
	public void RegisterControlLayout(string name, Type type) { }

	// RVA: 0x1413AB4
	public void RegisterControlLayout(string json, string name, bool isOverride) { }

	// RVA: 0x141B6C4
	public void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout) { }

	// RVA: 0x141B054
	private void PerformLayoutPostRegistration(InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout, bool isOverride) { }

	// RVA: 0x30B2CB8
	public void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x141B868
	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout) { }

	// RVA: 0x141BC08
	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	// RVA: 0x141BB24
	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	// RVA: 0x141B550
	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x141C4FC
	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	// RVA: 0x141BEA8
	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x141BD1C
	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	// RVA: 0x141C100
	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	// RVA: 0x141D3EC
	public void RemoveControlLayout(string name) { }

	// RVA: 0x141D62C
	public InputControlLayout TryLoadControlLayout(Type type) { }

	// RVA: 0x1413AA4
	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	// RVA: 0x141C750
	public InternedString TryFindMatchingControlLayout(InputDeviceDescription deviceDescription, int deviceId) { }

	// RVA: 0x141D874
	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	// RVA: 0x141D918
	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	// RVA: 0x141DA44
	public System.Collections.Generic.IEnumerable<System.String> ListControlLayouts(string basedOn) { }

	// RVA: -1
	public int GetControls(string path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x141DB18
	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x141419C
	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x1414410
	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x141DD0C
	private void NotifyUsageChanged(InputDevice device) { }

	// RVA: 0x141DDD0
	public InputDevice AddDevice(Type type, string name) { }

	// RVA: 0x141404C
	public InputDevice AddDevice(string layout, string name, InternedString variants) { }

	// RVA: 0x141D230
	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName, InputDeviceDescription deviceDescription, DeviceFlags deviceFlags, InternedString variants) { }

	// RVA: 0x141CC7C
	public void AddDevice(InputDevice device) { }

	// RVA: 0x141E9FC
	public InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x141EA44
	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x141EC14
	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x1413578
	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices) { }

	// RVA: 0x141EE68
	public void FlushDisconnectedDevices() { }

	// RVA: 0x141EEC8
	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls, System.Nullable<System.Boolean> issueResetCommand) { }

	// RVA: 0x141F780
	public InputDevice TryGetDevice(string nameOrLayout) { }

	// RVA: 0x141F8A8
	public InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x141F94C
	public InputDevice TryGetDevice(Type layoutType) { }

	// RVA: 0x14132F4
	public InputDevice TryGetDeviceById(int id) { }

	// RVA: 0x141F9B0
	public int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x141E59C
	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope) { }

	// RVA: 0x141FB64
	private void QueueEvent(InputEvent* eventPtr) { }

	// RVA: 0x141440C
	public void QueueEvent(InputEventPtr ptr) { }

	// RVA: 0x30B2CB8
	public void QueueEvent(TEvent inputEvent) { }

	// RVA: 0x141FC40
	public void Update() { }

	// RVA: 0x141FD20
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x141FDD8
	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x1421DA0
	internal void Destroy() { }

	// RVA: 0x141FE74
	private void InitializeActions() { }

	// RVA: 0x141FF28
	internal void InitializeData() { }

	// RVA: 0x14213BC
	internal void InstallRuntime(IInputRuntime runtime) { }

	// RVA: 0x1421B3C
	internal void InstallGlobals() { }

	// RVA: 0x1421EEC
	internal void UninstallGlobals() { }

	// RVA: 0x141DEE0
	private void MakeDeviceNameUnique(InputDevice device) { }

	// RVA: 0x142233C
	private static void ResetControlPathsRecursive(InputControl control) { }

	// RVA: 0x141E090
	private void AssignUniqueDeviceId(InputDevice device) { }

	// RVA: 0x1419CB8
	private void ReallocateStateBuffers() { }

	// RVA: 0x14223FC
	private void InitializeDefaultState(InputDevice device) { }

	// RVA: 0x141E27C
	private void InitializeDeviceState(InputDevice device) { }

	// RVA: 0x14225B8
	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x14229F4
	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	// RVA: 0x141A4F4
	private void InstallBeforeUpdateHookIfNecessary() { }

	// RVA: 0x14229F0
	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	// RVA: 0x1422BE0
	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	// RVA: 0x1422BE4
	private void OnBeforeUpdate(InputUpdateType updateType) { }

	// RVA: 0x14195A4
	internal void ApplySettings() { }

	// RVA: 0x1419C30
	internal void ApplyActions() { }

	// RVA: -1
	internal Int64 ExecuteGlobalCommand(TCommand command) { }

	// RVA: 0x141A154
	internal void AddAvailableDevicesThatAreNowRecognized() { }

	// RVA: 0x141E55C
	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	// RVA: 0x1422DB0
	internal void OnFocusChanged(bool focus) { }

	// RVA: 0x1423094
	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	// RVA: 0x14230B0
	private void OnUpdate(InputUpdateType updateType, InputEventBuffer eventBuffer) { }

	// RVA: 0x1424830
	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	// RVA: 0x1424A1C
	internal void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	// RVA: 0x14248A8
	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	// RVA: 0x141F4D0
	internal bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, UInt32 stateOffsetInDevice, UInt32 stateSize, Double internalTime, InputEventPtr eventPtr) { }

	// RVA: 0x1424DC8
	private void WriteStateChange(DoubleBuffers buffers, int deviceIndex, InputStateBlock deviceStateBlock, UInt32 stateOffsetInDevice, Void* statePtr, UInt32 stateSizeInBytes, bool flippedBuffers) { }

	// RVA: 0x1424D00
	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	// RVA: 0x1425464
	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x141ECF8
	private void RemoveStateChangeMonitors(InputDevice device) { }

	// RVA: 0x14258E4
	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x1425BC0
	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1425CA0
	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1424A24
	private void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	// RVA: 0x1425F20
	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	// RVA: 0x142604C
	public void FireStateChangeNotifications() { }

	// RVA: 0x1424A78
	private bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, UInt32 newStateSizeInBytes, UInt32 newStateOffsetInBytes) { }

	// RVA: 0x1424FAC
	internal void FireStateChangeNotifications(int deviceIndex, Double internalTime, InputEvent* eventPtr) { }

	// RVA: 0x1424564
	private void ProcessStateChangeMonitorTimeouts() { }

	// RVA: 0x14261A0
	public void .ctor() { }

	// RVA: 0x14261A8
	private Int64 <TryFindMatchingControlLayout>b__78_0(InputDeviceCommand commandRef) { }

}

// Namespace: 
public enum UpdateMode
{
	// Fields
	public int value__; // 0x10
	public const UpdateMode ProcessEventsInDynamicUpdate = 1;
	public const UpdateMode ProcessEventsInFixedUpdate = 2;
	public const UpdateMode ProcessEventsManually = 3;
}

// Namespace: 
public enum BackgroundBehavior
{
	// Fields
	public int value__; // 0x10
	public const BackgroundBehavior ResetAndDisableNonBackgroundDevices = 0;
	public const BackgroundBehavior ResetAndDisableAllDevices = 1;
	public const BackgroundBehavior IgnoreFocus = 2;
}

// Namespace: 
public enum EditorInputBehaviorInPlayMode
{
	// Fields
	public int value__; // 0x10
	public const EditorInputBehaviorInPlayMode PointersAndKeyboardsRespectGameViewFocus = 0;
	public const EditorInputBehaviorInPlayMode AllDevicesRespectGameViewFocus = 1;
	public const EditorInputBehaviorInPlayMode AllDeviceInputAlwaysGoesToGameView = 2;
}

// Namespace: 
public enum InputActionPropertyDrawerMode
{
	// Fields
	public int value__; // 0x10
	public const InputActionPropertyDrawerMode Compact = 0;
	public const InputActionPropertyDrawerMode MultilineEffective = 1;
	public const InputActionPropertyDrawerMode MultilineBoth = 2;
}

// Namespace: 
[Serializable]
public class iOSSettings
{
	// Fields
	private PrivacyDataUsage m_MotionUsage; // 0x10

	// Methods

	// RVA: 0x1428678
	public PrivacyDataUsage get_motionUsage() { }

	// RVA: 0x1428680
	public void set_motionUsage(PrivacyDataUsage value) { }

	// RVA: 0x1428600
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class InputSettings
{
	// Fields
	private string[] m_SupportedDevices; // 0x18
	private UpdateMode m_UpdateMode; // 0x20
	private int m_MaxEventBytesPerUpdate; // 0x24
	private int m_MaxQueuedEventsPerUpdate; // 0x28
	private bool m_CompensateForScreenOrientation; // 0x2C
	private BackgroundBehavior m_BackgroundBehavior; // 0x30
	private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; // 0x34
	private InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; // 0x38
	private float m_DefaultDeadzoneMin; // 0x3C
	private float m_DefaultDeadzoneMax; // 0x40
	private float m_DefaultButtonPressPoint; // 0x44
	private float m_ButtonReleaseThreshold; // 0x48
	private float m_DefaultTapTime; // 0x4C
	private float m_DefaultSlowTapTime; // 0x50
	private float m_DefaultHoldTime; // 0x54
	private float m_TapRadius; // 0x58
	private float m_MultiTapDelayTime; // 0x5C
	private bool m_DisableRedundantEventsMerging; // 0x60
	private bool m_ShortcutKeysConsumeInputs; // 0x61
	internal System.Collections.Generic.HashSet<System.String> m_FeatureFlags; // 0x68
	internal static bool optimizedControlsFeatureEnabled; // 0x0
	internal static bool readValueCachingFeatureEnabled; // 0x1
	internal static bool paranoidReadValueCachingChecksEnabled; // 0x2
	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;
	private iOSSettings m_iOSSettings; // 0x70

	// Methods

	// RVA: 0x1427C48
	public UpdateMode get_updateMode() { }

	// RVA: 0x1427C50
	public void set_updateMode(UpdateMode value) { }

	// RVA: 0x1427D80
	public bool get_compensateForScreenOrientation() { }

	// RVA: 0x1427D88
	public void set_compensateForScreenOrientation(bool value) { }

	// RVA: 0x1427DA0
	public bool get_filterNoiseOnCurrent() { }

	// RVA: 0x1427DA8
	public void set_filterNoiseOnCurrent(bool value) { }

	// RVA: 0x1427DAC
	public float get_defaultDeadzoneMin() { }

	// RVA: 0x1427DB4
	public void set_defaultDeadzoneMin(float value) { }

	// RVA: 0x1427DCC
	public float get_defaultDeadzoneMax() { }

	// RVA: 0x1427DD4
	public void set_defaultDeadzoneMax(float value) { }

	// RVA: 0x1427DEC
	public float get_defaultButtonPressPoint() { }

	// RVA: 0x1427DF4
	public void set_defaultButtonPressPoint(float value) { }

	// RVA: 0x1427E30
	public float get_buttonReleaseThreshold() { }

	// RVA: 0x1427E38
	public void set_buttonReleaseThreshold(float value) { }

	// RVA: 0x1427E50
	public float get_defaultTapTime() { }

	// RVA: 0x1427E58
	public void set_defaultTapTime(float value) { }

	// RVA: 0x1427E70
	public float get_defaultSlowTapTime() { }

	// RVA: 0x1427E78
	public void set_defaultSlowTapTime(float value) { }

	// RVA: 0x1427E90
	public float get_defaultHoldTime() { }

	// RVA: 0x1427E98
	public void set_defaultHoldTime(float value) { }

	// RVA: 0x1427EB0
	public float get_tapRadius() { }

	// RVA: 0x1427EB8
	public void set_tapRadius(float value) { }

	// RVA: 0x1427ED0
	public float get_multiTapDelayTime() { }

	// RVA: 0x1427ED8
	public void set_multiTapDelayTime(float value) { }

	// RVA: 0x1427EF0
	public BackgroundBehavior get_backgroundBehavior() { }

	// RVA: 0x1427EF8
	public void set_backgroundBehavior(BackgroundBehavior value) { }

	// RVA: 0x1427F10
	public EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	// RVA: 0x1427F18
	public void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	// RVA: 0x1427F30
	public InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	// RVA: 0x1427F38
	public void set_inputActionPropertyDrawerMode(InputActionPropertyDrawerMode value) { }

	// RVA: 0x1427F50
	public int get_maxEventBytesPerUpdate() { }

	// RVA: 0x1427F58
	public void set_maxEventBytesPerUpdate(int value) { }

	// RVA: 0x1427F70
	public int get_maxQueuedEventsPerUpdate() { }

	// RVA: 0x1427F78
	public void set_maxQueuedEventsPerUpdate(int value) { }

	// RVA: 0x1427F90
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> get_supportedDevices() { }

	// RVA: 0x1427FFC
	public void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> value) { }

	// RVA: 0x1428184
	public bool get_disableRedundantEventsMerging() { }

	// RVA: 0x142818C
	public void set_disableRedundantEventsMerging(bool value) { }

	// RVA: 0x14281A4
	public bool get_shortcutKeysConsumeInput() { }

	// RVA: 0x14281AC
	public void set_shortcutKeysConsumeInput(bool value) { }

	// RVA: 0x14281C4
	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

	// RVA: 0x1428464
	internal bool IsFeatureEnabled(string featureName) { }

	// RVA: 0x1427C68
	internal void OnChange() { }

	// RVA: 0x14284F0
	public iOSSettings get_iOS() { }

	// RVA: 0x14284F8
	public void .ctor() { }

}

// Namespace: 
public struct PlayerActions
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x1429218
	public void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x1429220
	public InputAction get_Move() { }

	// RVA: 0x1429240
	public InputAction get_Look() { }

	// RVA: 0x1429260
	public InputAction get_Fire() { }

	// RVA: 0x1429280
	public InputActionMap Get() { }

	// RVA: 0x14292A0
	public void Enable() { }

	// RVA: 0x14292C8
	public void Disable() { }

	// RVA: 0x14292F0
	public bool get_enabled() { }

	// RVA: 0x1429318
	public static InputActionMap op_Implicit(PlayerActions set) { }

	// RVA: 0x1429334
	public void SetCallbacks(IPlayerActions instance) { }

}

// Namespace: 
public struct UIActions
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x1429FCC
	public void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x1429FD4
	public InputAction get_Navigate() { }

	// RVA: 0x1429FF4
	public InputAction get_Submit() { }

	// RVA: 0x142A014
	public InputAction get_Cancel() { }

	// RVA: 0x142A034
	public InputAction get_Point() { }

	// RVA: 0x142A054
	public InputAction get_Click() { }

	// RVA: 0x142A074
	public InputAction get_ScrollWheel() { }

	// RVA: 0x142A094
	public InputAction get_MiddleClick() { }

	// RVA: 0x142A0B4
	public InputAction get_RightClick() { }

	// RVA: 0x142A0D4
	public InputAction get_TrackedDevicePosition() { }

	// RVA: 0x142A0F4
	public InputAction get_TrackedDeviceOrientation() { }

	// RVA: 0x142A114
	public InputActionMap Get() { }

	// RVA: 0x142A134
	public void Enable() { }

	// RVA: 0x142A15C
	public void Disable() { }

	// RVA: 0x142A184
	public bool get_enabled() { }

	// RVA: 0x142A1AC
	public static InputActionMap op_Implicit(UIActions set) { }

	// RVA: 0x142A1C8
	public void SetCallbacks(IUIActions instance) { }

}

// Namespace: 
public interface IPlayerActions
{
	// Methods

	// RVA: -1
	public abstract void OnMove(CallbackContext context) { }

	// RVA: -1
	public abstract void OnLook(CallbackContext context) { }

	// RVA: -1
	public abstract void OnFire(CallbackContext context) { }

}

// Namespace: 
public interface IUIActions
{
	// Methods

	// RVA: -1
	public abstract void OnNavigate(CallbackContext context) { }

	// RVA: -1
	public abstract void OnSubmit(CallbackContext context) { }

	// RVA: -1
	public abstract void OnCancel(CallbackContext context) { }

	// RVA: -1
	public abstract void OnPoint(CallbackContext context) { }

	// RVA: -1
	public abstract void OnClick(CallbackContext context) { }

	// RVA: -1
	public abstract void OnScrollWheel(CallbackContext context) { }

	// RVA: -1
	public abstract void OnMiddleClick(CallbackContext context) { }

	// RVA: -1
	public abstract void OnRightClick(CallbackContext context) { }

	// RVA: -1
	public abstract void OnTrackedDevicePosition(CallbackContext context) { }

	// RVA: -1
	public abstract void OnTrackedDeviceOrientation(CallbackContext context) { }

}

// Namespace: UnityEngine.InputSystem
public class DefaultInputActions
{
	// Fields
	private readonly InputActionAsset <asset>k__BackingField; // 0x10
	private readonly InputActionMap m_Player; // 0x18
	private IPlayerActions m_PlayerActionsCallbackInterface; // 0x20
	private readonly InputAction m_Player_Move; // 0x28
	private readonly InputAction m_Player_Look; // 0x30
	private readonly InputAction m_Player_Fire; // 0x38
	private readonly InputActionMap m_UI; // 0x40
	private IUIActions m_UIActionsCallbackInterface; // 0x48
	private readonly InputAction m_UI_Navigate; // 0x50
	private readonly InputAction m_UI_Submit; // 0x58
	private readonly InputAction m_UI_Cancel; // 0x60
	private readonly InputAction m_UI_Point; // 0x68
	private readonly InputAction m_UI_Click; // 0x70
	private readonly InputAction m_UI_ScrollWheel; // 0x78
	private readonly InputAction m_UI_MiddleClick; // 0x80
	private readonly InputAction m_UI_RightClick; // 0x88
	private readonly InputAction m_UI_TrackedDevicePosition; // 0x90
	private readonly InputAction m_UI_TrackedDeviceOrientation; // 0x98
	private int m_KeyboardMouseSchemeIndex; // 0xA0
	private int m_GamepadSchemeIndex; // 0xA4
	private int m_TouchSchemeIndex; // 0xA8
	private int m_JoystickSchemeIndex; // 0xAC
	private int m_XRSchemeIndex; // 0xB0

	// Methods

	// RVA: 0x1428688
	public InputActionAsset get_asset() { }

	// RVA: 0x1428690
	public void .ctor() { }

	// RVA: 0x1428AD0
	public void Dispose() { }

	// RVA: 0x1428B60
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x1428BA0
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1428BE8
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x1428C34
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x1428C74
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x1428C94
	public bool Contains(InputAction action) { }

	// RVA: 0x1428CB4
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x1428CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1428CF4
	public void Enable() { }

	// RVA: 0x1428D14
	public void Disable() { }

	// RVA: 0x1428D34
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1428D54
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1428D74
	public int FindBinding(InputBinding bindingMask, InputAction action) { }

	// RVA: 0x1428DC4
	public PlayerActions get_Player() { }

	// RVA: 0x1428DF0
	public UIActions get_UI() { }

	// RVA: 0x1428E1C
	public InputControlScheme get_KeyboardMouseScheme() { }

	// RVA: 0x1428EE8
	public InputControlScheme get_GamepadScheme() { }

	// RVA: 0x1428FB4
	public InputControlScheme get_TouchScheme() { }

	// RVA: 0x1429080
	public InputControlScheme get_JoystickScheme() { }

	// RVA: 0x142914C
	public InputControlScheme get_XRScheme() { }

}

// Namespace: UnityEngine.InputSystem
public class InputValue
{
	// Fields
	internal System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext> m_Context; // 0x10

	// Methods

	// RVA: 0x142CA98
	public object Get() { }

	// RVA: 0x316B894
	public TValue Get() { }

	// RVA: 0x142CB10
	public bool get_isPressed() { }

	// RVA: 0x142CBA0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ActionEvent
{
	// Fields
	private string m_ActionId; // 0x30
	private string m_ActionName; // 0x38

	// Methods

	// RVA: 0x14353CC
	public string get_actionId() { }

	// RVA: 0x14353D4
	public string get_actionName() { }

	// RVA: 0x14353DC
	public void .ctor() { }

	// RVA: 0x1435430
	public void .ctor(InputAction action) { }

	// RVA: 0x1435614
	public void .ctor(Guid actionGUID, string name) { }

}

// Namespace: 
[Serializable]
public class DeviceLostEvent
{
	// Methods

	// RVA: 0x142EAD8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DeviceRegainedEvent
{
	// Methods

	// RVA: 0x142EBEC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ControlsChangedEvent
{
	// Methods

	// RVA: 0x142ED00
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PlayerInput
{
	// Fields
	public const string DeviceLostMessage = "OnDeviceLost";
	public const string DeviceRegainedMessage = "OnDeviceRegained";
	public const string ControlsChangedMessage = "OnControlsChanged";
	internal InputActionAsset m_Actions; // 0x20
	internal PlayerNotifications m_NotificationBehavior; // 0x28
	internal InputSystemUIInputModule m_UIInputModule; // 0x30
	internal DeviceLostEvent m_DeviceLostEvent; // 0x38
	internal DeviceRegainedEvent m_DeviceRegainedEvent; // 0x40
	internal ControlsChangedEvent m_ControlsChangedEvent; // 0x48
	internal ActionEvent[] m_ActionEvents; // 0x50
	internal bool m_NeverAutoSwitchControlSchemes; // 0x58
	internal string m_DefaultControlScheme; // 0x60
	internal string m_DefaultActionMap; // 0x68
	internal int m_SplitScreenIndex; // 0x70
	internal Camera m_Camera; // 0x78
	private InputValue m_InputValueObject; // 0x80
	internal InputActionMap m_CurrentActionMap; // 0x88
	private int m_PlayerIndex; // 0x90
	private bool m_InputActive; // 0x94
	private bool m_Enabled; // 0x95
	internal bool m_ActionsInitialized; // 0x96
	private System.Collections.Generic.Dictionary<System.String,System.String> m_ActionMessageNames; // 0x98
	private InputUser m_InputUser; // 0xA0
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ActionTriggeredDelegate; // 0xA8
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceLostCallbacks; // 0xB0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceRegainedCallbacks; // 0x100
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_ControlsChangedCallbacks; // 0x150
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionTriggeredCallbacks; // 0x1A0
	private System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x1F0
	private System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> m_PreFilterUnpairedDeviceUsedDelegate; // 0x1F8
	private bool m_OnUnpairedDeviceUsedHooked; // 0x200
	private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> m_DeviceChangeDelegate; // 0x208
	private bool m_OnDeviceChangeHooked; // 0x210
	internal static int s_AllActivePlayersCount; // 0x0
	internal static PlayerInput[] s_AllActivePlayers; // 0x8
	private static System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> s_UserChangeDelegate; // 0x10
	private static int s_InitPairWithDevicesCount; // 0x18
	private static InputDevice[] s_InitPairWithDevices; // 0x20
	private static int s_InitPlayerIndex; // 0x28
	private static int s_InitSplitScreenIndex; // 0x2C
	private static string s_InitControlScheme; // 0x30
	internal static bool s_DestroyIfDeviceSetupUnsuccessful; // 0x38

	// Methods

	// RVA: 0x142CBA8
	public bool get_inputIsActive() { }

	// RVA: 0x142CBB0
	public bool get_active() { }

	// RVA: 0x142CBB8
	public int get_playerIndex() { }

	// RVA: 0x142CBC0
	public int get_splitScreenIndex() { }

	// RVA: 0x142CBC8
	public InputActionAsset get_actions() { }

	// RVA: 0x142D1C0
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x142E214
	public string get_currentControlScheme() { }

	// RVA: 0x142E570
	public string get_defaultControlScheme() { }

	// RVA: 0x142E578
	public void set_defaultControlScheme(string value) { }

	// RVA: 0x142E580
	public bool get_neverAutoSwitchControlSchemes() { }

	// RVA: 0x142E588
	public void set_neverAutoSwitchControlSchemes(bool value) { }

	// RVA: 0x142E840
	public InputActionMap get_currentActionMap() { }

	// RVA: 0x142E848
	public void set_currentActionMap(InputActionMap value) { }

	// RVA: 0x142E8C0
	public string get_defaultActionMap() { }

	// RVA: 0x142E8C8
	public void set_defaultActionMap(string value) { }

	// RVA: 0x142E8D0
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x142E8D8
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x142E934
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents() { }

	// RVA: 0x142E988
	public void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value) { }

	// RVA: 0x142EA18
	public DeviceLostEvent get_deviceLostEvent() { }

	// RVA: 0x142EB2C
	public DeviceRegainedEvent get_deviceRegainedEvent() { }

	// RVA: 0x142EC40
	public ControlsChangedEvent get_controlsChangedEvent() { }

	// RVA: 0x142ED54
	public void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x142EDFC
	public void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x142EEA4
	public void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x142EF4C
	public void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x142EFF4
	public void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x142F09C
	public void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x142F144
	public void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x142F1EC
	public void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x142F294
	public Camera get_camera() { }

	// RVA: 0x142F29C
	public void set_camera(Camera value) { }

	// RVA: 0x142F2A4
	public InputSystemUIInputModule get_uiInputModule() { }

	// RVA: 0x142F2AC
	public void set_uiInputModule(InputSystemUIInputModule value) { }

	// RVA: 0x142F720
	public InputUser get_user() { }

	// RVA: 0x142F728
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x142F894
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x142FA34
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all() { }

	// RVA: 0x142FAC8
	public static bool get_isSinglePlayer() { }

	// RVA: 0x316B894
	public TDevice GetDevice() { }

	// RVA: 0x142E144
	public void ActivateInput() { }

	// RVA: 0x142FE24
	public void DeactivateInput() { }

	// RVA: 0x142FE54
	public void PassivateInput() { }

	// RVA: 0x142FE84
	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	// RVA: 0x1430570
	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	// RVA: 0x142FC34
	public void SwitchCurrentActionMap(string mapNameOrId) { }

	// RVA: 0x1430710
	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	// RVA: 0x1430824
	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	// RVA: 0x1430A40
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice pairWithDevice) { }

	// RVA: 0x1430EBC
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice[] pairWithDevices) { }

	// RVA: 0x1430BD0
	private static PlayerInput DoInstantiate(GameObject prefab) { }

	// RVA: 0x142CC28
	private void InitializeActions() { }

	// RVA: 0x142D31C
	private void UninitializeActions() { }

	// RVA: 0x14310A0
	private void InstallOnActionTriggeredHook() { }

	// RVA: 0x1431674
	private void UninstallOnActionTriggeredHook() { }

	// RVA: 0x14317F4
	private void OnActionTriggered(CallbackContext context) { }

	// RVA: 0x1431294
	private void CacheMessageNames() { }

	// RVA: 0x142D510
	private void ClearCaches() { }

	// RVA: 0x142D514
	private void AssignUserAndDevices() { }

	// RVA: 0x14322A0
	private bool HaveBindingForDevice(InputDevice device) { }

	// RVA: 0x1432760
	private void UnassignUserAndDevices() { }

	// RVA: 0x1431EC0
	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	// RVA: 0x1432CFC
	private void AssignPlayerIndex() { }

	// RVA: 0x1432F50
	private void OnEnable() { }

	// RVA: 0x142E648
	private void StartListeningForUnpairedDeviceActivity() { }

	// RVA: 0x142E7C4
	private void StopListeningForUnpairedDeviceActivity() { }

	// RVA: 0x1433514
	private void StartListeningForDeviceChanges() { }

	// RVA: 0x1433D30
	private void StopListeningForDeviceChanges() { }

	// RVA: 0x1433DA0
	private void OnDisable() { }

	// RVA: 0x1434304
	public void DebugLogAction(CallbackContext context) { }

	// RVA: 0x143437C
	private void HandleDeviceLost() { }

	// RVA: 0x14344A4
	private void HandleDeviceRegained() { }

	// RVA: 0x1433620
	private void HandleControlsChanged() { }

	// RVA: 0x14345CC
	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	// RVA: 0x1434758
	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	// RVA: 0x1434920
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1435158
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x14300E0
	private void SwitchControlSchemeInternal(InputControlScheme controlScheme, InputDevice[] devices) { }

	// RVA: 0x1435368
	public void .ctor() { }

	// RVA: 0x143537C
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class PlayerJoinedEvent
{
	// Methods

	// RVA: 0x14365F0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class PlayerLeftEvent
{
	// Methods

	// RVA: 0x1436704
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PlayerInputManager
{
	// Fields
	public const string PlayerJoinedMessage = "OnPlayerJoined";
	public const string PlayerLeftMessage = "OnPlayerLeft";
	private static PlayerInputManager <instance>k__BackingField; // 0x0
	internal PlayerNotifications m_NotificationBehavior; // 0x20
	internal int m_MaxPlayerCount; // 0x24
	internal bool m_AllowJoining; // 0x28
	internal PlayerJoinBehavior m_JoinBehavior; // 0x2C
	internal PlayerJoinedEvent m_PlayerJoinedEvent; // 0x30
	internal PlayerLeftEvent m_PlayerLeftEvent; // 0x38
	internal InputActionProperty m_JoinAction; // 0x40
	internal GameObject m_PlayerPrefab; // 0x58
	internal bool m_SplitScreen; // 0x60
	internal bool m_MaintainAspectRatioInSplitScreen; // 0x61
	internal int m_FixedNumberOfSplitScreens; // 0x64
	internal Rect m_SplitScreenRect; // 0x68
	private bool m_JoinActionDelegateHooked; // 0x78
	private bool m_UnpairedDeviceUsedDelegateHooked; // 0x79
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_JoinActionDelegate; // 0x80
	private System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x88
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_PlayerJoinedCallbacks; // 0x90
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_PlayerLeftCallbacks; // 0xE0

	// Methods

	// RVA: 0x14356A8
	public bool get_splitScreen() { }

	// RVA: 0x14356B0
	public void set_splitScreen(bool value) { }

	// RVA: 0x1435FF0
	public bool get_maintainAspectRatioInSplitScreen() { }

	// RVA: 0x1435FF8
	public int get_fixedNumberOfSplitScreens() { }

	// RVA: 0x1436000
	public Rect get_splitScreenArea() { }

	// RVA: 0x143600C
	public int get_playerCount() { }

	// RVA: 0x1436088
	public int get_maxPlayerCount() { }

	// RVA: 0x1436090
	public bool get_joiningEnabled() { }

	// RVA: 0x1436098
	public PlayerJoinBehavior get_joinBehavior() { }

	// RVA: 0x14360A0
	public void set_joinBehavior(PlayerJoinBehavior value) { }

	// RVA: 0x1436434
	public InputActionProperty get_joinAction() { }

	// RVA: 0x1436448
	public void set_joinAction(InputActionProperty value) { }

	// RVA: 0x1436520
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x1436528
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x1436530
	public PlayerJoinedEvent get_playerJoinedEvent() { }

	// RVA: 0x1436644
	public PlayerLeftEvent get_playerLeftEvent() { }

	// RVA: 0x1436758
	public void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x1436800
	public void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x14368A8
	public void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x1436950
	public void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x14369F8
	public GameObject get_playerPrefab() { }

	// RVA: 0x1436A00
	public void set_playerPrefab(GameObject value) { }

	// RVA: 0x1436A08
	public static PlayerInputManager get_instance() { }

	// RVA: 0x1436A54
	private static void set_instance(PlayerInputManager value) { }

	// RVA: 0x14361E8
	public void EnableJoining() { }

	// RVA: 0x14360F4
	public void DisableJoining() { }

	// RVA: 0x1436ABC
	internal void JoinPlayerFromUI() { }

	// RVA: 0x1436E40
	public void JoinPlayerFromAction(CallbackContext context) { }

	// RVA: 0x1436FD4
	public void JoinPlayerFromActionIfNotAlreadyJoined(CallbackContext context) { }

	// RVA: 0x1436F04
	public PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice pairWithDevice) { }

	// RVA: 0x1437138
	public PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice[] pairWithDevices) { }

	// RVA: 0x1437208
	internal static string[] get_messages() { }

	// RVA: 0x1436B14
	private bool CheckIfPlayerCanJoin(int playerIndex) { }

	// RVA: 0x14372C8
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1437870
	private void OnEnable() { }

	// RVA: 0x1437CA0
	private void OnDisable() { }

	// RVA: 0x1435980
	private void UpdateSplitScreen() { }

	// RVA: 0x14373E8
	private bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	// RVA: 0x1436AB8
	private void ValidateInputActionAsset() { }

	// RVA: 0x1433748
	internal void NotifyPlayerJoined(PlayerInput player) { }

	// RVA: 0x14341B8
	internal void NotifyPlayerLeft(PlayerInput player) { }

	// RVA: 0x1437DB8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public enum PlayerJoinBehavior
{
	// Fields
	public int value__; // 0x10
	public const PlayerJoinBehavior JoinPlayersWhenButtonIsPressed = 0;
	public const PlayerJoinBehavior JoinPlayersWhenJoinActionIsTriggered = 1;
	public const PlayerJoinBehavior JoinPlayersManually = 2;
}

// Namespace: UnityEngine.InputSystem
public enum PlayerNotifications
{
	// Fields
	public int value__; // 0x10
	public const PlayerNotifications SendMessages = 0;
	public const PlayerNotifications BroadcastMessages = 1;
	public const PlayerNotifications InvokeUnityEvents = 2;
	public const PlayerNotifications InvokeCSharpEvents = 3;
}

// Namespace: UnityEngine.InputSystem
internal struct DynamicBitfield
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<System.UInt64> array; // 0x10
	public int length; // 0x28

	// Methods

	// RVA: 0x1437DE0
	public void SetLength(int newLength) { }

	// RVA: 0x1437E78
	public void SetBit(int bitIndex) { }

	// RVA: 0x1437F38
	public bool TestBit(int bitIndex) { }

	// RVA: 0x1437FBC
	public void ClearBit(int bitIndex) { }

	// RVA: 0x1437E60
	private static int BitCountToULongCount(int bitCount) { }

}

// Namespace: 
public enum TrackingType
{
	// Fields
	public int value__; // 0x10
	public const TrackingType RotationAndPosition = 0;
	public const TrackingType RotationOnly = 1;
	public const TrackingType PositionOnly = 2;
}

// Namespace: 
private enum TrackingStates
{
	// Fields
	public int value__; // 0x10
	public const TrackingStates None = 0;
	public const TrackingStates Position = 1;
	public const TrackingStates Rotation = 2;
}

// Namespace: 
public enum UpdateType
{
	// Fields
	public int value__; // 0x10
	public const UpdateType UpdateAndBeforeRender = 0;
	public const UpdateType Update = 1;
	public const UpdateType BeforeRender = 2;
}

// Namespace: UnityEngine.InputSystem.XR
[Serializable]
public class TrackedPoseDriver
{
	// Fields
	private TrackingType m_TrackingType; // 0x20
	private UpdateType m_UpdateType; // 0x24
	private bool m_IgnoreTrackingState; // 0x28
	private InputActionProperty m_PositionInput; // 0x30
	private InputActionProperty m_RotationInput; // 0x48
	private InputActionProperty m_TrackingStateInput; // 0x60
	private Vector3 m_CurrentPosition; // 0x78
	private Quaternion m_CurrentRotation; // 0x84
	private TrackingStates m_CurrentTrackingState; // 0x94
	private bool m_RotationBound; // 0x98
	private bool m_PositionBound; // 0x99
	private bool m_TrackingStateBound; // 0x9A
	private bool m_IsFirstUpdate; // 0x9B
	private InputAction m_PositionAction; // 0xA0
	private InputAction m_RotationAction; // 0xA8

	// Methods

	// RVA: 0x143807C
	public TrackingType get_trackingType() { }

	// RVA: 0x1438084
	public void set_trackingType(TrackingType value) { }

	// RVA: 0x143808C
	public UpdateType get_updateType() { }

	// RVA: 0x1438094
	public void set_updateType(UpdateType value) { }

	// RVA: 0x143809C
	public bool get_ignoreTrackingState() { }

	// RVA: 0x14380A4
	public void set_ignoreTrackingState(bool value) { }

	// RVA: 0x14380AC
	public InputActionProperty get_positionInput() { }

	// RVA: 0x14380C0
	public void set_positionInput(InputActionProperty value) { }

	// RVA: 0x14384C4
	public InputActionProperty get_rotationInput() { }

	// RVA: 0x14384D8
	public void set_rotationInput(InputActionProperty value) { }

	// RVA: 0x14388DC
	public InputActionProperty get_trackingStateInput() { }

	// RVA: 0x14388F0
	public void set_trackingStateInput(InputActionProperty value) { }

	// RVA: 0x1438CF4
	private void BindActions() { }

	// RVA: 0x1438D20
	private void UnbindActions() { }

	// RVA: 0x1438318
	private void BindPosition() { }

	// RVA: 0x1438730
	private void BindRotation() { }

	// RVA: 0x1438B48
	private void BindTrackingState() { }

	// RVA: 0x14381BC
	private void UnbindPosition() { }

	// RVA: 0x14385D4
	private void UnbindRotation() { }

	// RVA: 0x14389EC
	private void UnbindTrackingState() { }

	// RVA: 0x1438D4C
	private void OnPositionPerformed(CallbackContext context) { }

	// RVA: 0x1438DC4
	private void OnPositionCanceled(CallbackContext context) { }

	// RVA: 0x1438E20
	private void OnRotationPerformed(CallbackContext context) { }

	// RVA: 0x1438E90
	private void OnRotationCanceled(CallbackContext context) { }

	// RVA: 0x1438EE4
	private void OnTrackingStatePerformed(CallbackContext context) { }

	// RVA: 0x1438F54
	private void OnTrackingStateCanceled(CallbackContext context) { }

	// RVA: 0x1438F5C
	protected void Reset() { }

	// RVA: 0x1439160
	protected virtual void Awake() { }

	// RVA: 0x1439164
	protected void OnEnable() { }

	// RVA: 0x1439238
	protected void OnDisable() { }

	// RVA: 0x1439300
	protected virtual void OnDestroy() { }

	// RVA: 0x1439304
	protected void UpdateCallback() { }

	// RVA: 0x1439458
	private void ReadTrackingState() { }

	// RVA: 0x14395A0
	protected virtual void OnUpdate() { }

	// RVA: 0x14395BC
	protected virtual void OnBeforeRender() { }

	// RVA: 0x14395DC
	protected virtual void PerformUpdate() { }

	// RVA: 0x14395F8
	protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	// RVA: 0x143977C
	private bool HasStereoCamera(Camera cameraComponent) { }

	// RVA: 0x1439800
	public InputAction get_positionAction() { }

	// RVA: 0x143980C
	public void set_positionAction(InputAction value) { }

	// RVA: 0x1439860
	public InputAction get_rotationAction() { }

	// RVA: 0x143986C
	public void set_rotationAction(InputAction value) { }

	// RVA: 0x14398C0
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x14398C4
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x14399A0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.XInput
public interface IXboxOneRumble
{
	// Methods

	// RVA: -1
	public abstract void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger) { }

}

// Namespace: 
internal enum DeviceType
{
	// Fields
	public int value__; // 0x10
	public const DeviceType Gamepad = 0;
}

// Namespace: 
public enum DeviceSubType
{
	// Fields
	public int value__; // 0x10
	public const DeviceSubType Unknown = 0;
	public const DeviceSubType Gamepad = 1;
	public const DeviceSubType Wheel = 2;
	public const DeviceSubType ArcadeStick = 3;
	public const DeviceSubType FlightStick = 4;
	public const DeviceSubType DancePad = 5;
	public const DeviceSubType Guitar = 6;
	public const DeviceSubType GuitarAlternate = 7;
	public const DeviceSubType DrumKit = 8;
	public const DeviceSubType GuitarBass = 11;
	public const DeviceSubType ArcadePad = 19;
}

// Namespace: 
public enum DeviceFlags
{
	// Fields
	public int value__; // 0x10
	public const DeviceFlags ForceFeedbackSupported = 1;
	public const DeviceFlags Wireless = 2;
	public const DeviceFlags VoiceSupported = 4;
	public const DeviceFlags PluginModulesSupported = 8;
	public const DeviceFlags NoNavigation = 16;
}

// Namespace: 
[Serializable]
internal struct Capabilities
{
	// Fields
	public DeviceType type; // 0x10
	public DeviceSubType subType; // 0x14
	public DeviceFlags flags; // 0x18
}

// Namespace: UnityEngine.InputSystem.XInput
public class XInputController
{
	// Fields
	private ButtonControl <menu>k__BackingField; // 0x1F0
	private ButtonControl <view>k__BackingField; // 0x1F8
	private bool m_HaveParsedCapabilities; // 0x200
	private DeviceSubType m_SubType; // 0x204
	private DeviceFlags m_Flags; // 0x208

	// Methods

	// RVA: 0x1439A4C
	public ButtonControl get_menu() { }

	// RVA: 0x1439A54
	protected void set_menu(ButtonControl value) { }

	// RVA: 0x1439A64
	public ButtonControl get_view() { }

	// RVA: 0x1439A6C
	protected void set_view(ButtonControl value) { }

	// RVA: 0x1439A7C
	public DeviceSubType get_subType() { }

	// RVA: 0x1439BC4
	public DeviceFlags get_flags() { }

	// RVA: 0x1439C64
	protected override void FinishSetup() { }

	// RVA: 0x1439B1C
	private void ParseCapabilities() { }

	// RVA: 0x1439CA4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.XInput
internal static class XInputSupport
{
	// Methods

	// RVA: 0x1439CAC
	public static void Initialize() { }

}

// Namespace: 
public struct ControlSchemeChangeSyntax
{
	// Fields
	internal int m_UserIndex; // 0x10

	// Methods

	// RVA: 0x1432C40
	public ControlSchemeChangeSyntax AndPairRemainingDevices() { }

}

// Namespace: 
internal enum UserFlags
{
	// Fields
	public int value__; // 0x10
	public const UserFlags BindToAllDevices = 1;
	public const UserFlags UserAccountSelectionInProgress = 2;
}

// Namespace: 
private struct UserData
{
	// Fields
	public System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> platformUserAccountHandle; // 0x10
	public string platformUserAccountName; // 0x28
	public string platformUserAccountId; // 0x30
	public int deviceCount; // 0x38
	public int deviceStartIndex; // 0x3C
	public IInputActionCollection actions; // 0x40
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> controlScheme; // 0x48
	public MatchResult controlSchemeMatch; // 0x68
	public int lostDeviceCount; // 0xB8
	public int lostDeviceStartIndex; // 0xBC
	public UserFlags flags; // 0xC0
}

// Namespace: 
private struct CompareDevicesByUserAccount
{
	// Fields
	public InputUserAccountHandle platformUserAccountHandle; // 0x10

	// Methods

	// RVA: 0x143F5C4
	public int Compare(InputDevice x, InputDevice y) { }

	// RVA: 0x143FC08
	private static System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> GetUserAccountHandleForDevice(InputDevice device) { }

}

// Namespace: 
private struct OngoingAccountSelection
{
	// Fields
	public InputDevice device; // 0x10
	public UInt32 userId; // 0x18
}

// Namespace: 
private struct GlobalState
{
	// Fields
	internal int pairingStateVersion; // 0x10
	internal UInt32 lastUserId; // 0x14
	internal int allUserCount; // 0x18
	internal int allPairedDeviceCount; // 0x1C
	internal int allLostDeviceCount; // 0x20
	internal InputUser[] allUsers; // 0x28
	internal UserData[] allUserData; // 0x30
	internal InputDevice[] allPairedDevices; // 0x38
	internal InputDevice[] allLostDevices; // 0x40
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Users.InputUser.OngoingAccountSelection> ongoingAccountSelections; // 0x48
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice>> onChange; // 0x68
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr>> onUnpairedDeviceUsed; // 0xB8
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean>> onPreFilterUnpairedDeviceUsed; // 0x108
	internal System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> actionChangeDelegate; // 0x158
	internal System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> onDeviceChangeDelegate; // 0x160
	internal System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x168
	internal bool onActionChangeHooked; // 0x170
	internal bool onDeviceChangeHooked; // 0x171
	internal bool onEventHooked; // 0x172
	internal int listenForUnpairedDeviceActivity; // 0x174
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Users.InputUser.<>c <>9; // 0x0
	public static TypedRestore <>9__86_0; // 0x8
	public static Action <>9__86_1; // 0x10

	// Methods

	// RVA: 0x143FC14
	private static void .cctor() { }

	// RVA: 0x143FC80
	public void .ctor() { }

	// RVA: 0x143FC88
	internal void <SaveAndResetState>b__86_0(GlobalState state) { }

	// RVA: 0x143FCF8
	internal void <SaveAndResetState>b__86_1() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUser
{
	// Fields
	public const UInt32 InvalidId = 0;
	private UInt32 m_Id; // 0x10
	private static GlobalState s_GlobalState; // 0x0

	// Methods

	// RVA: 0x142E438
	public bool get_valid() { }

	// RVA: 0x1439D20
	public int get_index() { }

	// RVA: 0x1439F28
	public UInt32 get_id() { }

	// RVA: 0x1439F30
	public System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle() { }

	// RVA: 0x1439FC4
	public string get_platformUserAccountName() { }

	// RVA: 0x143A048
	public string get_platformUserAccountId() { }

	// RVA: 0x142F7DC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices() { }

	// RVA: 0x143A0CC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices() { }

	// RVA: 0x143A184
	public IInputActionCollection get_actions() { }

	// RVA: 0x142E4E0
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme() { }

	// RVA: 0x143A208
	public MatchResult get_controlSchemeMatch() { }

	// RVA: 0x142F9AC
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x143A2AC
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all() { }

	// RVA: 0x143345C
	public static void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1434100
	public static void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1433894
	public static void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1433B78
	public static void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1433970
	public static void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x1433C78
	public static void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x1433A28
	public static int get_listenForUnpairedDeviceActivity() { }

	// RVA: 0x1433A74
	public static void set_listenForUnpairedDeviceActivity(int value) { }

	// RVA: 0x143A52C
	public override string ToString() { }

	// RVA: 0x14323E8
	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	// RVA: 0x1432C6C
	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	// RVA: 0x143ADB8
	private bool TryFindControlScheme(string schemeName, InputControlScheme scheme) { }

	// RVA: 0x1430650
	internal void FindControlScheme(string schemeName, InputControlScheme scheme) { }

	// RVA: 0x143298C
	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	// RVA: 0x143A9D0
	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	// RVA: 0x143528C
	public void UnpairDevice(InputDevice device) { }

	// RVA: 0x1431A18
	public void UnpairDevices() { }

	// RVA: 0x143BDC4
	private static void RemoveLostDevicesForUser(int userIndex) { }

	// RVA: 0x14328EC
	public void UnpairDevicesAndRemoveUser() { }

	// RVA: 0x1432220
	public static UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() { }

	// RVA: 0x143C7E4
	public static int GetUnpairedInputDevices(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>& list) { }

	// RVA: 0x143C9F0
	public static System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(InputDevice device) { }

	// RVA: 0x143CC0C
	public static System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	// RVA: 0x143291C
	public static InputUser CreateUserWithoutPairedDevices() { }

	// RVA: 0x1431C8C
	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user, InputUserPairingOptions options) { }

	// RVA: 0x143D230
	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	// RVA: 0x143DFF8
	public bool Equals(InputUser other) { }

	// RVA: 0x143E008
	public override bool Equals(object obj) { }

	// RVA: 0x143E098
	public override int GetHashCode() { }

	// RVA: 0x143474C
	public static bool op_Equality(InputUser left, InputUser right) { }

	// RVA: 0x143D224
	public static bool op_Inequality(InputUser left, InputUser right) { }

	// RVA: 0x143D128
	private static int AddUser() { }

	// RVA: 0x143C458
	private static void RemoveUser(int userIndex) { }

	// RVA: 0x143B050
	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	// RVA: 0x1439E88
	private static int TryFindUserIndex(UInt32 userId) { }

	// RVA: 0x143CEBC
	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	// RVA: 0x143CB08
	private static int TryFindUserIndex(InputDevice device) { }

	// RVA: 0x143D378
	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice, bool dontUpdateControlScheme) { }

	// RVA: 0x143BF08
	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice) { }

	// RVA: 0x143B364
	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing) { }

	// RVA: 0x143D7F8
	private static Int64 UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

	// RVA: 0x143E208
	private static Int64 QueryPairedPlatformUserAccount(InputDevice device, System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>& platformAccountHandle, string platformAccountName, string platformAccountId) { }

	// RVA: 0x143DDFC
	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	// RVA: 0x143E530
	private static void OnActionChange(object obj, InputActionChange change) { }

	// RVA: 0x143E658
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x143EB38
	private static int FindLostDevice(InputDevice device, int startIndex) { }

	// RVA: 0x143EC04
	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x143F124
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x143A894
	private static void HookIntoActionChange() { }

	// RVA: 0x143E130
	private static void UnhookFromActionChange() { }

	// RVA: 0x143DEC4
	private static void HookIntoDeviceChange() { }

	// RVA: 0x143E0A0
	private static void UnhookFromDeviceChange() { }

	// RVA: 0x143A338
	private static void HookIntoEvents() { }

	// RVA: 0x143A480
	private static void UnhookFromDeviceStateChange() { }

	// RVA: 0x143F374
	private static void DisposeAndResetGlobalState() { }

	// RVA: 0x143F460
	internal static void ResetGlobals() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUserAccountHandle
{
	// Fields
	private string m_ApiName; // 0x10
	private UInt64 m_Handle; // 0x18

	// Methods

	// RVA: 0x143FDE4
	public string get_apiName() { }

	// RVA: 0x143FDEC
	public UInt64 get_handle() { }

	// RVA: 0x143E498
	public void .ctor(string apiName, UInt64 handle) { }

	// RVA: 0x143FDF4
	public override string ToString() { }

	// RVA: 0x143FED0
	public bool Equals(InputUserAccountHandle other) { }

	// RVA: 0x143FFA0
	public override bool Equals(object obj) { }

	// RVA: 0x143CDE0
	public static bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x143E3C8
	public static bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x14400D4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.InputSystem.Users
public enum InputUserChange
{
	// Fields
	public int value__; // 0x10
	public const InputUserChange Added = 0;
	public const InputUserChange Removed = 1;
	public const InputUserChange DevicePaired = 2;
	public const InputUserChange DeviceUnpaired = 3;
	public const InputUserChange DeviceLost = 4;
	public const InputUserChange DeviceRegained = 5;
	public const InputUserChange AccountChanged = 6;
	public const InputUserChange AccountNameChanged = 7;
	public const InputUserChange AccountSelectionInProgress = 8;
	public const InputUserChange AccountSelectionCanceled = 9;
	public const InputUserChange AccountSelectionComplete = 10;
	public const InputUserChange ControlSchemeChanged = 11;
	public const InputUserChange ControlsChanged = 12;
}

// Namespace: UnityEngine.InputSystem.Users
public enum InputUserPairingOptions
{
	// Fields
	public int value__; // 0x10
	public const InputUserPairingOptions None = 0;
	public const InputUserPairingOptions ForcePlatformUserAccountSelection = 1;
	public const InputUserPairingOptions ForceNoPlatformUserAccountSelection = 2;
	public const InputUserPairingOptions UnpairCurrentDevicesFromUser = 8;
}

// Namespace: UnityEngine.InputSystem.Users
[Serializable]
internal class InputUserSettings
{
	// Fields
	private string <customBindings>k__BackingField; // 0x10
	private bool <invertMouseX>k__BackingField; // 0x18
	private bool <invertMouseY>k__BackingField; // 0x19
	private System.Nullable<System.Single> <mouseSmoothing>k__BackingField; // 0x1C
	private System.Nullable<System.Single> <mouseSensitivity>k__BackingField; // 0x24
	private bool <invertStickX>k__BackingField; // 0x2C
	private bool <invertStickY>k__BackingField; // 0x2D
	private bool <swapSticks>k__BackingField; // 0x2E
	private bool <swapBumpers>k__BackingField; // 0x2F
	private bool <swapTriggers>k__BackingField; // 0x30
	private bool <swapDpadAndLeftStick>k__BackingField; // 0x31
	private float <vibrationStrength>k__BackingField; // 0x34
	private string m_CustomBindings; // 0x38

	// Methods

	// RVA: 0x1440134
	public string get_customBindings() { }

	// RVA: 0x144013C
	public void set_customBindings(string value) { }

	// RVA: 0x1440144
	public bool get_invertMouseX() { }

	// RVA: 0x144014C
	public void set_invertMouseX(bool value) { }

	// RVA: 0x1440154
	public bool get_invertMouseY() { }

	// RVA: 0x144015C
	public void set_invertMouseY(bool value) { }

	// RVA: 0x1440164
	public System.Nullable<System.Single> get_mouseSmoothing() { }

	// RVA: 0x144016C
	public void set_mouseSmoothing(System.Nullable<System.Single> value) { }

	// RVA: 0x1440174
	public System.Nullable<System.Single> get_mouseSensitivity() { }

	// RVA: 0x144017C
	public void set_mouseSensitivity(System.Nullable<System.Single> value) { }

	// RVA: 0x1440184
	public bool get_invertStickX() { }

	// RVA: 0x144018C
	public void set_invertStickX(bool value) { }

	// RVA: 0x1440194
	public bool get_invertStickY() { }

	// RVA: 0x144019C
	public void set_invertStickY(bool value) { }

	// RVA: 0x14401A4
	public bool get_swapSticks() { }

	// RVA: 0x14401AC
	public void set_swapSticks(bool value) { }

	// RVA: 0x14401B4
	public bool get_swapBumpers() { }

	// RVA: 0x14401BC
	public void set_swapBumpers(bool value) { }

	// RVA: 0x14401C4
	public bool get_swapTriggers() { }

	// RVA: 0x14401CC
	public void set_swapTriggers(bool value) { }

	// RVA: 0x14401D4
	public bool get_swapDpadAndLeftStick() { }

	// RVA: 0x14401DC
	public void set_swapDpadAndLeftStick(bool value) { }

	// RVA: 0x14401E4
	public float get_vibrationStrength() { }

	// RVA: 0x14401EC
	public void set_vibrationStrength(float value) { }

	// RVA: 0x14401F4
	public virtual void Apply(IInputActionCollection actions) { }

	// RVA: 0x14401F8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class BaseInputOverride
{
	// Fields
	private readonly string <compositionString>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1440200
	public override string get_compositionString() { }

	// RVA: 0x1440208
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class ExtendedAxisEventData
{
	// Methods

	// RVA: 0x1440210
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1440218
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem.UI
public class ExtendedPointerEventData
{
	// Fields
	private InputControl <control>k__BackingField; // 0x180
	private InputDevice <device>k__BackingField; // 0x188
	private int <touchId>k__BackingField; // 0x190
	private UIPointerType <pointerType>k__BackingField; // 0x194
	private int <uiToolkitPointerId>k__BackingField; // 0x198
	private Vector3 <trackedDevicePosition>k__BackingField; // 0x19C
	private Quaternion <trackedDeviceOrientation>k__BackingField; // 0x1A8

	// Methods

	// RVA: 0x14402DC
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x14402E4
	public InputControl get_control() { }

	// RVA: 0x14402EC
	public void set_control(InputControl value) { }

	// RVA: 0x14402FC
	public InputDevice get_device() { }

	// RVA: 0x1440304
	public void set_device(InputDevice value) { }

	// RVA: 0x1440314
	public int get_touchId() { }

	// RVA: 0x144031C
	public void set_touchId(int value) { }

	// RVA: 0x1440324
	public UIPointerType get_pointerType() { }

	// RVA: 0x144032C
	public void set_pointerType(UIPointerType value) { }

	// RVA: 0x1440334
	public int get_uiToolkitPointerId() { }

	// RVA: 0x144033C
	public void set_uiToolkitPointerId(int value) { }

	// RVA: 0x1440344
	public Vector3 get_trackedDevicePosition() { }

	// RVA: 0x1440354
	public void set_trackedDevicePosition(Vector3 value) { }

	// RVA: 0x1440364
	public Quaternion get_trackedDeviceOrientation() { }

	// RVA: 0x1440378
	public void set_trackedDeviceOrientation(Quaternion value) { }

	// RVA: 0x144038C
	public override string ToString() { }

	// RVA: 0x14408FC
	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	// RVA: 0x1440904
	internal static int TouchIdFromPointerId(int pointerId) { }

	// RVA: 0x144090C
	internal void ReadDeviceState() { }

	// RVA: 0x1440C40
	private static int GetPenPointerId(Pen pen) { }

	// RVA: 0x1440E80
	private static int GetTouchPointerId(TouchControl touchControl) { }

}

// Namespace: UnityEngine.InputSystem.UI
public enum UIPointerType
{
	// Fields
	public int value__; // 0x10
	public const UIPointerType None = 0;
	public const UIPointerType MouseOrPen = 1;
	public const UIPointerType Touch = 2;
	public const UIPointerType Tracked = 3;
}

// Namespace: UnityEngine.InputSystem.UI
public enum UIPointerBehavior
{
	// Fields
	public int value__; // 0x10
	public const UIPointerBehavior SingleMouseOrPenButMultiTouchAndTrack = 0;
	public const UIPointerBehavior SingleUnifiedPointer = 1;
	public const UIPointerBehavior AllPointersAsIs = 2;
}

// Namespace: 
private struct InputActionReferenceState
{
	// Fields
	public int refCount; // 0x10
	public bool enabledByInputModule; // 0x14
}

// Namespace: 
public enum CursorLockBehavior
{
	// Fields
	public int value__; // 0x10
	public const CursorLockBehavior OutsideScreen = 0;
	public const CursorLockBehavior ScreenCenter = 1;
}

// Namespace: UnityEngine.InputSystem.UI
public class InputSystemUIInputModule
{
	// Fields
	private const float kClickSpeed = 0.3;
	private float m_MoveRepeatDelay; // 0x58
	private float m_MoveRepeatRate; // 0x5C
	private float m_TrackedDeviceDragThresholdMultiplier; // 0x60
	private Transform m_XRTrackingOrigin; // 0x68
	private static DefaultInputActions defaultActions; // 0x0
	internal const float kPixelPerLine = 20;
	private InputActionAsset m_ActionsAsset; // 0x70
	private InputActionReference m_PointAction; // 0x78
	private InputActionReference m_MoveAction; // 0x80
	private InputActionReference m_SubmitAction; // 0x88
	private InputActionReference m_CancelAction; // 0x90
	private InputActionReference m_LeftClickAction; // 0x98
	private InputActionReference m_MiddleClickAction; // 0xA0
	private InputActionReference m_RightClickAction; // 0xA8
	private InputActionReference m_ScrollWheelAction; // 0xB0
	private InputActionReference m_TrackedDevicePositionAction; // 0xB8
	private InputActionReference m_TrackedDeviceOrientationAction; // 0xC0
	private bool m_DeselectOnBackgroundClick; // 0xC8
	private UIPointerBehavior m_PointerBehavior; // 0xCC
	internal CursorLockBehavior m_CursorLockBehavior; // 0xD0
	private static System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputAction,UnityEngine.InputSystem.UI.InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts; // 0x8
	private bool m_ActionsHooked; // 0xD4
	private bool m_NeedToPurgeStalePointers; // 0xD5
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnPointDelegate; // 0xD8
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMoveDelegate; // 0xE0
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnLeftClickDelegate; // 0xE8
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnRightClickDelegate; // 0xF0
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMiddleClickDelegate; // 0xF8
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnScrollWheelDelegate; // 0x100
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate; // 0x108
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate; // 0x110
	private System.Action<System.Object> m_OnControlsChangedDelegate; // 0x118
	private int m_CurrentPointerId; // 0x120
	private int m_CurrentPointerIndex; // 0x124
	internal UIPointerType m_CurrentPointerType; // 0x128
	internal UnityEngine.InputSystem.Utilities.InlinedArray<System.Int32> m_PointerIds; // 0x130
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputControl> m_PointerTouchControls; // 0x140
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.PointerModel> m_PointerStates; // 0x158
	private NavigationModel m_NavigationState; // 0x388
	private GameObject m_LocalMultiPlayerRoot; // 0x3A8

	// Methods

	// RVA: 0x1440F78
	public bool get_deselectOnBackgroundClick() { }

	// RVA: 0x1440F80
	public void set_deselectOnBackgroundClick(bool value) { }

	// RVA: 0x1440F88
	public UIPointerBehavior get_pointerBehavior() { }

	// RVA: 0x1440F90
	public void set_pointerBehavior(UIPointerBehavior value) { }

	// RVA: 0x1440F98
	public CursorLockBehavior get_cursorLockBehavior() { }

	// RVA: 0x1440FA0
	public void set_cursorLockBehavior(CursorLockBehavior value) { }

	// RVA: 0x1440FA8
	internal GameObject get_localMultiPlayerRoot() { }

	// RVA: 0x1440FB0
	internal void set_localMultiPlayerRoot(GameObject value) { }

	// RVA: 0x1440FC0
	public override void ActivateModule() { }

	// RVA: 0x144109C
	public override bool IsPointerOverGameObject(int pointerOrTouchId) { }

	// RVA: 0x14413A0
	public RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	// RVA: 0x1441478
	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	// RVA: 0x1441758
	private void ProcessPointer(PointerModel state) { }

	// RVA: 0x1442BB8
	private bool PointerShouldIgnoreTransform(Transform t) { }

	// RVA: 0x1441BCC
	private void ProcessPointerMovement(PointerModel pointer, ExtendedPointerEventData eventData) { }

	// RVA: 0x1442CD4
	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	// RVA: 0x1441C28
	private void ProcessPointerButton(ButtonState button, PointerEventData eventData) { }

	// RVA: 0x1442634
	private void ProcessPointerButtonDrag(ButtonState button, ExtendedPointerEventData eventData) { }

	// RVA: 0x1442A04
	private static void ProcessPointerScroll(PointerModel pointer, PointerEventData eventData) { }

	// RVA: 0x14434B8
	internal void ProcessNavigation(NavigationModel navigationState) { }

	// RVA: 0x1443B84
	private bool IsMoveAllowed(AxisEventData eventData) { }

	// RVA: 0x1443EC0
	public float get_moveRepeatDelay() { }

	// RVA: 0x1443EC8
	public void set_moveRepeatDelay(float value) { }

	// RVA: 0x1443ED0
	public float get_moveRepeatRate() { }

	// RVA: 0x1443ED8
	public void set_moveRepeatRate(float value) { }

	// RVA: 0x1443EE0
	private bool get_explictlyIgnoreFocus() { }

	// RVA: 0x1443F64
	private bool get_shouldIgnoreFocus() { }

	// RVA: 0x14440C4
	public float get_repeatRate() { }

	// RVA: 0x14440CC
	public void set_repeatRate(float value) { }

	// RVA: 0x14440D4
	public float get_repeatDelay() { }

	// RVA: 0x14440DC
	public void set_repeatDelay(float value) { }

	// RVA: 0x14440E4
	public Transform get_xrTrackingOrigin() { }

	// RVA: 0x14440EC
	public void set_xrTrackingOrigin(Transform value) { }

	// RVA: 0x14440F4
	public float get_trackedDeviceDragThresholdMultiplier() { }

	// RVA: 0x14440FC
	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	// RVA: 0x1444104
	private void SwapAction(InputActionReference property, InputActionReference newValue, bool actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback) { }

	// RVA: 0x1444770
	public InputActionReference get_point() { }

	// RVA: 0x1444778
	public void set_point(InputActionReference value) { }

	// RVA: 0x144478C
	public InputActionReference get_scrollWheel() { }

	// RVA: 0x1444794
	public void set_scrollWheel(InputActionReference value) { }

	// RVA: 0x14447A8
	public InputActionReference get_leftClick() { }

	// RVA: 0x14447B0
	public void set_leftClick(InputActionReference value) { }

	// RVA: 0x14447C4
	public InputActionReference get_middleClick() { }

	// RVA: 0x14447CC
	public void set_middleClick(InputActionReference value) { }

	// RVA: 0x14447E0
	public InputActionReference get_rightClick() { }

	// RVA: 0x14447E8
	public void set_rightClick(InputActionReference value) { }

	// RVA: 0x14447FC
	public InputActionReference get_move() { }

	// RVA: 0x1444804
	public void set_move(InputActionReference value) { }

	// RVA: 0x1444818
	public InputActionReference get_submit() { }

	// RVA: 0x1444820
	public void set_submit(InputActionReference value) { }

	// RVA: 0x1444834
	public InputActionReference get_cancel() { }

	// RVA: 0x144483C
	public void set_cancel(InputActionReference value) { }

	// RVA: 0x1444850
	public InputActionReference get_trackedDeviceOrientation() { }

	// RVA: 0x1444858
	public void set_trackedDeviceOrientation(InputActionReference value) { }

	// RVA: 0x144486C
	public InputActionReference get_trackedDevicePosition() { }

	// RVA: 0x1444874
	public void set_trackedDevicePosition(InputActionReference value) { }

	// RVA: 0x1444888
	public void AssignDefaultActions() { }

	// RVA: 0x1444C7C
	public void UnassignActions() { }

	// RVA: 0x1444E80
	public InputActionReference get_trackedDeviceSelect() { }

	// RVA: 0x1444EC0
	public void set_trackedDeviceSelect(InputActionReference value) { }

	// RVA: 0x1444F00
	protected override void Awake() { }

	// RVA: 0x1444F2C
	protected override void OnDestroy() { }

	// RVA: 0x1444F80
	protected override void OnEnable() { }

	// RVA: 0x14456E4
	protected override void OnDisable() { }

	// RVA: 0x14452D0
	private void ResetPointers() { }

	// RVA: 0x14450B8
	private bool HasNoActions() { }

	// RVA: 0x144567C
	private void EnableAllActions() { }

	// RVA: 0x14457AC
	private void DisableAllActions() { }

	// RVA: 0x14445EC
	private void EnableInputAction(InputActionReference inputActionReference) { }

	// RVA: 0x144443C
	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling) { }

	// RVA: 0x144125C
	private int GetPointerStateIndexFor(int pointerOrTouchId) { }

	// RVA: 0x1445950
	private PointerModel GetPointerStateForIndex(int index) { }

	// RVA: 0x144599C
	private int GetDisplayIndexFor(InputControl control) { }

	// RVA: 0x1445A64
	private int GetPointerStateIndexFor(CallbackContext context) { }

	// RVA: 0x1445B7C
	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists) { }

	// RVA: 0x1446538
	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl) { }

	// RVA: 0x1445860
	private void SendPointerExitEventsAndRemovePointer(int index) { }

	// RVA: 0x1446730
	private void RemovePointerAtIndex(int index) { }

	// RVA: 0x144699C
	private void PurgeStalePointers() { }

	// RVA: 0x1446460
	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	// RVA: 0x1446B34
	private void OnPointCallback(CallbackContext context) { }

	// RVA: 0x1446C7C
	private bool IgnoreNextClick(CallbackContext context, bool wasPressed) { }

	// RVA: 0x1446E44
	private void OnLeftClickCallback(CallbackContext context) { }

	// RVA: 0x1446F1C
	private void OnRightClickCallback(CallbackContext context) { }

	// RVA: 0x1446FF4
	private void OnMiddleClickCallback(CallbackContext context) { }

	// RVA: 0x1445B0C
	private bool CheckForRemovedDevice(CallbackContext context) { }

	// RVA: 0x14470CC
	private void OnScrollCallback(CallbackContext context) { }

	// RVA: 0x14471BC
	private void OnMoveCallback(CallbackContext context) { }

	// RVA: 0x144722C
	private void OnTrackedDeviceOrientationCallback(CallbackContext context) { }

	// RVA: 0x144730C
	private void OnTrackedDevicePositionCallback(CallbackContext context) { }

	// RVA: 0x14473EC
	private void OnControlsChanged(object obj) { }

	// RVA: 0x14473F8
	private void FilterPointerStatesByType() { }

	// RVA: 0x144764C
	public override void Process() { }

	// RVA: 0x1447808
	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x1445318
	private void HookActions() { }

	// RVA: 0x1444F6C
	private void UnhookActions() { }

	// RVA: 0x14478F4
	private void SetActionCallbacks(bool install) { }

	// RVA: 0x14479E4
	private static void SetActionCallback(InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x1447AE4
	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

	// RVA: 0x1447B70
	public InputActionAsset get_actionsAsset() { }

	// RVA: 0x142F4A8
	public void set_actionsAsset(InputActionAsset value) { }

	// RVA: 0x1447B78
	public void .ctor() { }

	// RVA: 0x1447BA4
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
public class MultiplayerEventSystem
{
	// Fields
	private GameObject m_PlayerRoot; // 0x60

	// Methods

	// RVA: 0x1448220
	public GameObject get_playerRoot() { }

	// RVA: 0x1448228
	public void set_playerRoot(GameObject value) { }

	// RVA: 0x1448380
	protected override void OnEnable() { }

	// RVA: 0x14483A8
	protected override void OnDisable() { }

	// RVA: 0x1448250
	private void InitializePlayerRoot() { }

	// RVA: 0x14483B0
	protected override void Update() { }

	// RVA: 0x14484C0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal struct NavigationModel
{
	// Fields
	public Vector2 move; // 0x10
	public int consecutiveMoveCount; // 0x18
	public MoveDirection lastMoveDirection; // 0x1C
	public float lastMoveTime; // 0x20
	public AxisEventData eventData; // 0x28

	// Methods

	// RVA: 0x1448548
	public void Reset() { }

}

// Namespace: 
public struct ButtonState
{
	// Fields
	private bool m_IsPressed; // 0x10
	private FramePressState m_FramePressState; // 0x14
	private float m_PressTime; // 0x18
	private RaycastResult m_PressRaycast; // 0x20
	private GameObject m_PressObject; // 0x70
	private GameObject m_RawPressObject; // 0x78
	private GameObject m_LastPressObject; // 0x80
	private GameObject m_DragObject; // 0x88
	private Vector2 m_PressPosition; // 0x90
	private float m_ClickTime; // 0x98
	private int m_ClickCount; // 0x9C
	private bool m_Dragging; // 0xA0
	private bool m_ClickedOnSameGameObject; // 0xA1
	private bool m_IgnoreNextClick; // 0xA2

	// Methods

	// RVA: 0x1448A2C
	public bool get_isPressed() { }

	// RVA: 0x1448A34
	public void set_isPressed(bool value) { }

	// RVA: 0x1448A84
	public bool get_ignoreNextClick() { }

	// RVA: 0x1448A8C
	public void set_ignoreNextClick(bool value) { }

	// RVA: 0x1448A94
	public float get_pressTime() { }

	// RVA: 0x1448A9C
	public void set_pressTime(float value) { }

	// RVA: 0x1448AA4
	public bool get_clickedOnSameGameObject() { }

	// RVA: 0x1448AAC
	public void set_clickedOnSameGameObject(bool value) { }

	// RVA: 0x1448AB4
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x1448AC4
	public bool get_wasReleasedThisFrame() { }

	// RVA: 0x1448AD8
	public void CopyPressStateTo(PointerEventData eventData) { }

	// RVA: 0x1448B9C
	public void CopyPressStateFrom(PointerEventData eventData) { }

	// RVA: 0x14488D0
	public void OnEndFrame() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal struct PointerModel
{
	// Fields
	public bool changedThisFrame; // 0x10
	public ButtonState leftButton; // 0x18
	public ButtonState rightButton; // 0xB0
	public ButtonState middleButton; // 0x148
	public ExtendedPointerEventData eventData; // 0x1E0
	private Vector2 m_ScreenPosition; // 0x1E8
	private Vector2 m_ScrollDelta; // 0x1F0
	private Vector3 m_WorldPosition; // 0x1F8
	private Quaternion m_WorldOrientation; // 0x204
	private float m_Pressure; // 0x214
	private float m_AzimuthAngle; // 0x218
	private float m_AltitudeAngle; // 0x21C
	private float m_Twist; // 0x220
	private Vector2 m_Radius; // 0x224

	// Methods

	// RVA: 0x144859C
	public UIPointerType get_pointerType() { }

	// RVA: 0x14485BC
	public Vector2 get_screenPosition() { }

	// RVA: 0x14485C8
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x144860C
	public Vector3 get_worldPosition() { }

	// RVA: 0x144861C
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x1448674
	public Quaternion get_worldOrientation() { }

	// RVA: 0x1448688
	public void set_worldOrientation(Quaternion value) { }

	// RVA: 0x14486E4
	public Vector2 get_scrollDelta() { }

	// RVA: 0x14486F0
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x1448734
	public float get_pressure() { }

	// RVA: 0x144873C
	public void set_pressure(float value) { }

	// RVA: 0x144875C
	public float get_azimuthAngle() { }

	// RVA: 0x1448764
	public void set_azimuthAngle(float value) { }

	// RVA: 0x1448784
	public float get_altitudeAngle() { }

	// RVA: 0x144878C
	public void set_altitudeAngle(float value) { }

	// RVA: 0x14487AC
	public float get_twist() { }

	// RVA: 0x14487B4
	public void set_twist(float value) { }

	// RVA: 0x14487D4
	public Vector2 get_radius() { }

	// RVA: 0x14487E0
	public void set_radius(Vector2 value) { }

	// RVA: 0x1448824
	public void .ctor(ExtendedPointerEventData eventData) { }

	// RVA: 0x14488DC
	public void OnFrameFinished() { }

	// RVA: 0x1448928
	public void CopyTouchOrPenStateFrom(PointerEventData eventData) { }

}

// Namespace: 
private struct RaycastHitData
{
	// Fields
	private readonly Graphic <graphic>k__BackingField; // 0x10
	private readonly Vector3 <worldHitPosition>k__BackingField; // 0x18
	private readonly Vector2 <screenPosition>k__BackingField; // 0x24
	private readonly float <distance>k__BackingField; // 0x2C

	// Methods

	// RVA: 0x1449F64
	public void .ctor(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) { }

	// RVA: 0x144A0EC
	public Graphic get_graphic() { }

	// RVA: 0x144A0F4
	public Vector3 get_worldHitPosition() { }

	// RVA: 0x144A100
	public Vector2 get_screenPosition() { }

	// RVA: 0x144A108
	public float get_distance() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> <>9__25_0; // 0x8

	// Methods

	// RVA: 0x144A110
	private static void .cctor() { }

	// RVA: 0x144A17C
	public void .ctor() { }

	// RVA: 0x144A184
	internal int <SortedRaycastGraphics>b__25_0(RaycastHitData g1, RaycastHitData g2) { }

}

// Namespace: UnityEngine.InputSystem.UI
public class TrackedDeviceRaycaster
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> m_RaycastResultsCache; // 0x28
	internal static UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> s_Instances; // 0x0
	private static readonly System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> s_SortedGraphics; // 0x18
	private bool m_IgnoreReversedGraphics; // 0x30
	private bool m_CheckFor2DOcclusion; // 0x31
	private bool m_CheckFor3DOcclusion; // 0x32
	private float m_MaxDistance; // 0x34
	private LayerMask m_BlockingMask; // 0x38
	private Canvas m_Canvas; // 0x40

	// Methods

	// RVA: 0x1448C50
	public override Camera get_eventCamera() { }

	// RVA: 0x1448E14
	public LayerMask get_blockingMask() { }

	// RVA: 0x1448E1C
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x1448E24
	public bool get_checkFor3DOcclusion() { }

	// RVA: 0x1448E2C
	public void set_checkFor3DOcclusion(bool value) { }

	// RVA: 0x1448E34
	public bool get_checkFor2DOcclusion() { }

	// RVA: 0x1448E3C
	public void set_checkFor2DOcclusion(bool value) { }

	// RVA: 0x1448E44
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x1448E4C
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1448E54
	public float get_maxDistance() { }

	// RVA: 0x1448E5C
	public void set_maxDistance(float value) { }

	// RVA: 0x1448E64
	protected override void OnEnable() { }

	// RVA: 0x1448EF4
	protected override void OnDisable() { }

	// RVA: 0x1448FEC
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1449098
	internal void PerformRaycast(ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x144965C
	private void SortedRaycastGraphics(Canvas canvas, Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results) { }

	// RVA: 0x1449B6C
	private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, Vector3 worldPosition, float distance) { }

	// RVA: 0x1448D1C
	private Canvas get_canvas() { }

	// RVA: 0x1449FC4
	public void .ctor() { }

	// RVA: 0x144A058
	private static void .cctor() { }

}

// Namespace: 
public enum CursorMode
{
	// Fields
	public int value__; // 0x10
	public const CursorMode SoftwareCursor = 0;
	public const CursorMode HardwareCursorIfAvailable = 1;
}

// Namespace: UnityEngine.InputSystem.UI
public class VirtualMouseInput
{
	// Fields
	private CursorMode m_CursorMode; // 0x20
	private Graphic m_CursorGraphic; // 0x28
	private RectTransform m_CursorTransform; // 0x30
	private float m_CursorSpeed; // 0x38
	private float m_ScrollSpeed; // 0x3C
	private InputActionProperty m_StickAction; // 0x40
	private InputActionProperty m_LeftButtonAction; // 0x58
	private InputActionProperty m_MiddleButtonAction; // 0x70
	private InputActionProperty m_RightButtonAction; // 0x88
	private InputActionProperty m_ForwardButtonAction; // 0xA0
	private InputActionProperty m_BackButtonAction; // 0xB8
	private InputActionProperty m_ScrollWheelAction; // 0xD0
	private Canvas m_Canvas; // 0xE8
	private Mouse m_VirtualMouse; // 0xF0
	private Mouse m_SystemMouse; // 0xF8
	private Action m_AfterInputUpdateDelegate; // 0x100
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x108
	private Double m_LastTime; // 0x110
	private Vector2 m_LastStickValue; // 0x118

	// Methods

	// RVA: 0x144A1E0
	public RectTransform get_cursorTransform() { }

	// RVA: 0x144A1E8
	public void set_cursorTransform(RectTransform value) { }

	// RVA: 0x144A1F0
	public float get_cursorSpeed() { }

	// RVA: 0x144A1F8
	public void set_cursorSpeed(float value) { }

	// RVA: 0x144A200
	public CursorMode get_cursorMode() { }

	// RVA: 0x144A208
	public void set_cursorMode(CursorMode value) { }

	// RVA: 0x144A5E8
	public Graphic get_cursorGraphic() { }

	// RVA: 0x144A5F0
	public void set_cursorGraphic(Graphic value) { }

	// RVA: 0x144A6F8
	public float get_scrollSpeed() { }

	// RVA: 0x144A700
	public void set_scrollSpeed(float value) { }

	// RVA: 0x144A708
	public Mouse get_virtualMouse() { }

	// RVA: 0x144A710
	public InputActionProperty get_stickAction() { }

	// RVA: 0x144A724
	public void set_stickAction(InputActionProperty value) { }

	// RVA: 0x144A8B0
	public InputActionProperty get_leftButtonAction() { }

	// RVA: 0x144A8C4
	public void set_leftButtonAction(InputActionProperty value) { }

	// RVA: 0x144AA28
	public InputActionProperty get_rightButtonAction() { }

	// RVA: 0x144AA3C
	public void set_rightButtonAction(InputActionProperty value) { }

	// RVA: 0x144AB1C
	public InputActionProperty get_middleButtonAction() { }

	// RVA: 0x144AB30
	public void set_middleButtonAction(InputActionProperty value) { }

	// RVA: 0x144AC10
	public InputActionProperty get_forwardButtonAction() { }

	// RVA: 0x144AC24
	public void set_forwardButtonAction(InputActionProperty value) { }

	// RVA: 0x144AD04
	public InputActionProperty get_backButtonAction() { }

	// RVA: 0x144AD18
	public void set_backButtonAction(InputActionProperty value) { }

	// RVA: 0x144ADF8
	public InputActionProperty get_scrollWheelAction() { }

	// RVA: 0x144AE0C
	public void set_scrollWheelAction(InputActionProperty value) { }

	// RVA: 0x144AE40
	protected void OnEnable() { }

	// RVA: 0x144B3CC
	protected void OnDisable() { }

	// RVA: 0x144A680
	private void TryFindCanvas() { }

	// RVA: 0x144A324
	private void TryEnableHardwareCursor() { }

	// RVA: 0x144B6D8
	private void UpdateMotion() { }

	// RVA: 0x144BA94
	private void OnButtonActionTriggered(CallbackContext context) { }

	// RVA: 0x144A9A4
	private static void SetActionCallback(InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x144A758
	private static void SetAction(InputActionProperty field, InputActionProperty value) { }

	// RVA: 0x144BD0C
	private void OnAfterInputUpdate() { }

	// RVA: 0x144BD10
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
public class OnScreenButton
{
	// Fields
	private string m_ControlPath; // 0x38

	// Methods

	// RVA: 0x144BD24
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x144BD8C
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x144BDF8
	protected override string get_controlPathInternal() { }

	// RVA: 0x144BE00
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x144BE08
	public void .ctor() { }

}

// Namespace: 
private struct OnScreenDeviceInfo
{
	// Fields
	public InputEventPtr eventPtr; // 0x10
	public Unity.Collections.NativeArray<System.Byte> buffer; // 0x18
	public InputDevice device; // 0x28
	public OnScreenControl firstControl; // 0x30

	// Methods

	// RVA: 0x144C770
	public OnScreenDeviceInfo AddControl(OnScreenControl control) { }

	// RVA: 0x144CB5C
	public OnScreenDeviceInfo RemoveControl(OnScreenControl control) { }

	// RVA: 0x144C6B4
	public void Destroy() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
public abstract class OnScreenControl
{
	// Fields
	private InputControl m_Control; // 0x20
	private OnScreenControl m_NextControlOnDevice; // 0x28
	private InputEventPtr m_InputEventPtr; // 0x30
	private static UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices; // 0x0

	// Methods

	// RVA: 0x144BE18
	public string get_controlPath() { }

	// RVA: 0x144BE24
	public void set_controlPath(string value) { }

	// RVA: 0x144C6AC
	public InputControl get_control() { }

	// RVA: -1
	protected abstract string get_controlPathInternal() { }

	// RVA: -1
	protected abstract void set_controlPathInternal(string value) { }

	// RVA: 0x144BE6C
	private void SetupInputControl() { }

	// RVA: 0x316B894
	protected void SendValueToControl(TValue value) { }

	// RVA: 0x144C7D8
	protected void SentDefaultValueToControl() { }

	// RVA: 0x144C928
	protected virtual void OnEnable() { }

	// RVA: 0x144C92C
	protected virtual void OnDisable() { }

	// RVA: 0x144BE10
	protected void .ctor() { }

}

// Namespace: 
public enum Behaviour
{
	// Fields
	public int value__; // 0x10
	public const Behaviour RelativePositionWithStaticOrigin = 0;
	public const Behaviour ExactPositionWithStaticOrigin = 1;
	public const Behaviour ExactPositionWithDynamicOrigin = 2;
}

// Namespace: UnityEngine.InputSystem.OnScreen
public class OnScreenStick
{
	// Fields
	private const string kDynamicOriginClickable = "DynamicOriginClickable";
	private float m_MovementRange; // 0x38
	private float m_DynamicOriginRange; // 0x3C
	private string m_ControlPath; // 0x40
	private Behaviour m_Behaviour; // 0x48
	private bool m_UseIsolatedInputActions; // 0x4C
	private InputAction m_PointerDownAction; // 0x50
	private InputAction m_PointerMoveAction; // 0x58
	private Vector3 m_StartPos; // 0x60
	private Vector2 m_PointerDownPos; // 0x6C
	private System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResults; // 0x78
	private PointerEventData m_PointerEventData; // 0x80

	// Methods

	// RVA: 0x144CCBC
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x144D018
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x144D498
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x144D590
	private void Start() { }

	// RVA: 0x144CD68
	private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x144D0C4
	private void MoveStick(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x144D4A8
	private void EndInteraction() { }

	// RVA: 0x144DC30
	private void OnPointerDown(CallbackContext ctx) { }

	// RVA: 0x144E31C
	private void OnPointerMove(CallbackContext ctx) { }

	// RVA: 0x144E408
	private void OnPointerUp(CallbackContext ctx) { }

	// RVA: 0x144DFFC
	private Camera GetCameraFromCanvas() { }

	// RVA: 0x144E4A4
	private void OnDrawGizmosSelected() { }

	// RVA: 0x144E7BC
	private void DrawGizmoCircle(Vector2 center, float radius) { }

	// RVA: 0x144E884
	private void UpdateDynamicOriginClickableArea() { }

	// RVA: 0x144E98C
	public float get_movementRange() { }

	// RVA: 0x144E994
	public void set_movementRange(float value) { }

	// RVA: 0x144E99C
	public float get_dynamicOriginRange() { }

	// RVA: 0x144E9A4
	public void set_dynamicOriginRange(float value) { }

	// RVA: 0x144E9BC
	public bool get_useIsolatedInputActions() { }

	// RVA: 0x144E9C4
	public void set_useIsolatedInputActions(bool value) { }

	// RVA: 0x144E9CC
	protected override string get_controlPathInternal() { }

	// RVA: 0x144E9D4
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x144E9DC
	public Behaviour get_behaviour() { }

	// RVA: 0x144E9E4
	public void set_behaviour(Behaviour value) { }

	// RVA: 0x144E9EC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
internal static class OnScreenSupport
{
	// Methods

	// RVA: 0x144EA00
	public static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.iOS
[Serializable]
public class PrivacyDataUsage
{
	// Fields
	private bool m_Enabled; // 0x10
	private string m_Description; // 0x18

	// Methods

	// RVA: 0x144EA04
	public bool get_enabled() { }

	// RVA: 0x144EA0C
	public void set_enabled(bool value) { }

	// RVA: 0x144EA14
	public string get_usageDescription() { }

	// RVA: 0x144EA1C
	public void set_usageDescription(string value) { }

	// RVA: 0x144EA24
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class iOSGameController
{
	// Methods

	// RVA: 0x144EA2C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class XboxOneGampadiOS
{
	// Methods

	// RVA: 0x144EA34
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualShock4GampadiOS
{
	// Methods

	// RVA: 0x144EA3C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualSenseGampadiOS
{
	// Methods

	// RVA: 0x144EA4C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
internal static class iOSSupport
{
	// Methods

	// RVA: 0x144EA54
	public static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.iOS.LowLevel
internal enum iOSButton
{
	// Fields
	public int value__; // 0x10
	public const iOSButton DpadUp = 0;
	public const iOSButton DpadDown = 1;
	public const iOSButton DpadLeft = 2;
	public const iOSButton DpadRight = 3;
	public const iOSButton LeftStick = 4;
	public const iOSButton RightStick = 5;
	public const iOSButton LeftShoulder = 6;
	public const iOSButton RightShoulder = 7;
	public const iOSButton LeftTrigger = 8;
	public const iOSButton RightTrigger = 9;
	public const iOSButton X = 10;
	public const iOSButton Y = 11;
	public const iOSButton A = 12;
	public const iOSButton B = 13;
	public const iOSButton Start = 14;
	public const iOSButton Select = 15;
}

// Namespace: UnityEngine.InputSystem.iOS.LowLevel
internal enum iOSAxis
{
	// Fields
	public int value__; // 0x10
	public const iOSAxis LeftStickX = 0;
	public const iOSAxis LeftStickY = 1;
	public const iOSAxis RightStickX = 2;
	public const iOSAxis RightStickY = 3;
}

// Namespace: 
public struct <axisValues>e__FixedBuffer
{
	// Fields
	public float FixedElementField; // 0x10
}

// Namespace: 
public struct <buttonValues>e__FixedBuffer
{
	// Fields
	public float FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.iOS.LowLevel
internal struct iOSGameControllerState
{
	// Fields
	public static FourCC kFormat; // 0x0
	public const int MaxButtons = 16;
	public const int MaxAxis = 4;
	public UInt32 buttons; // 0x10
	public UnityEngine.InputSystem.iOS.LowLevel.iOSGameControllerState.<buttonValues>e__FixedBuffer buttonValues; // 0x14
	private const UInt32 kAxisOffset = 68;
	public UnityEngine.InputSystem.iOS.LowLevel.iOSGameControllerState.<axisValues>e__FixedBuffer axisValues; // 0x54

	// Methods

	// RVA: 0x144EFAC
	public FourCC get_format() { }

	// RVA: 0x144F028
	public iOSGameControllerState WithButton(iOSButton button, bool value, float rawValue) { }

	// RVA: 0x144F074
	public iOSGameControllerState WithAxis(iOSAxis axis, float value) { }

	// RVA: 0x144F0A0
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS.LowLevel
public enum MotionAuthorizationStatus
{
	// Fields
	public int value__; // 0x10
	public const MotionAuthorizationStatus NotDetermined = 0;
	public const MotionAuthorizationStatus Restricted = 1;
	public const MotionAuthorizationStatus Denied = 2;
	public const MotionAuthorizationStatus Authorized = 3;
}

// Namespace: UnityEngine.InputSystem.iOS.LowLevel
internal struct iOSStepCounterState
{
	// Fields
	public static FourCC kFormat; // 0x0
	public int stepCounter; // 0x10

	// Methods

	// RVA: 0x144F118
	public FourCC get_format() { }

	// RVA: 0x144F194
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDataReceivedDelegate
{
	// Methods

	// RVA: 0x144F7C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x144F8F0
	public virtual void Invoke(int deviceId, int numberOfSteps) { }

	// RVA: 0x144F904
	public virtual IAsyncResult BeginInvoke(int deviceId, int numberOfSteps, AsyncCallback callback, object object) { }

	// RVA: 0x144F9D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private struct iOSStepCounterCallbacks
{
	// Fields
	internal OnDataReceivedDelegate onData; // 0x10
}

// Namespace: UnityEngine.InputSystem.iOS.LowLevel
public class iOSStepCounter
{
	// Fields
	private const int kCommandFailure = 4294967295;
	private const int kCommandSuccess = 1;

	// Methods

	// RVA: 0x144F310
	private static extern int _iOSStepCounterEnable(int deviceId, iOSStepCounterCallbacks callbacks, int sizeOfCallbacks) { }

	// RVA: 0x144F3CC
	private static extern int _iOSStepCounterDisable(int deviceId) { }

	// RVA: 0x144F3D0
	private static extern int _iOSStepCounterIsEnabled(int deviceId) { }

	// RVA: 0x144F3D4
	private static extern int _iOSStepCounterIsAvailable() { }

	// RVA: 0x144F3D8
	private static extern int _iOSStepCounterGetAuthorizationStatus() { }

	// RVA: 0x144F20C
	private static void OnDataReceived(int deviceId, int numberOfSteps) { }

	// RVA: 0x144F3DC
	protected override Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x144EF90
	public static bool IsAvailable() { }

	// RVA: 0x144F8E4
	public static MotionAuthorizationStatus get_AuthorizationStatus() { }

	// RVA: 0x144F8E8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.HID.HID.HIDLayoutBuilder.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_0; // 0x8
	public static System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_1; // 0x10
	public static System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem,System.String> <>9__4_2; // 0x18

	// Methods

	// RVA: 0x1455460
	private static void .cctor() { }

	// RVA: 0x14554CC
	public void .ctor() { }

	// RVA: 0x14554D4
	internal bool <Build>b__4_0(HIDElementDescriptor element) { }

	// RVA: 0x14554F8
	internal bool <Build>b__4_1(HIDElementDescriptor element) { }

	// RVA: 0x145551C
	internal string <Build>b__4_2(ControlItem x) { }

}

// Namespace: 
[Serializable]
private class HIDLayoutBuilder
{
	// Fields
	public string displayName; // 0x10
	public HIDDeviceDescriptor hidDescriptor; // 0x18
	public string parentLayout; // 0x48
	public Type deviceType; // 0x50

	// Methods

	// RVA: 0x145354C
	public InputControlLayout Build() { }

	// RVA: 0x1450DB8
	public void .ctor() { }

}

// Namespace: 
public enum HIDReportType
{
	// Fields
	public int value__; // 0x10
	public const HIDReportType Unknown = 0;
	public const HIDReportType Input = 1;
	public const HIDReportType Output = 2;
	public const HIDReportType Feature = 3;
}

// Namespace: 
public enum HIDCollectionType
{
	// Fields
	public int value__; // 0x10
	public const HIDCollectionType Physical = 0;
	public const HIDCollectionType Application = 1;
	public const HIDCollectionType Logical = 2;
	public const HIDCollectionType Report = 3;
	public const HIDCollectionType NamedArray = 4;
	public const HIDCollectionType UsageSwitch = 5;
	public const HIDCollectionType UsageModifier = 6;
}

// Namespace: 
public enum HIDElementFlags
{
	// Fields
	public int value__; // 0x10
	public const HIDElementFlags Constant = 1;
	public const HIDElementFlags Variable = 2;
	public const HIDElementFlags Relative = 4;
	public const HIDElementFlags Wrap = 8;
	public const HIDElementFlags NonLinear = 16;
	public const HIDElementFlags NoPreferred = 32;
	public const HIDElementFlags NullState = 64;
	public const HIDElementFlags Volatile = 128;
	public const HIDElementFlags BufferedBytes = 256;
}

// Namespace: 
[Serializable]
public struct HIDElementDescriptor
{
	// Fields
	public int usage; // 0x10
	public UsagePage usagePage; // 0x14
	public int unit; // 0x18
	public int unitExponent; // 0x1C
	public int logicalMin; // 0x20
	public int logicalMax; // 0x24
	public int physicalMin; // 0x28
	public int physicalMax; // 0x2C
	public HIDReportType reportType; // 0x30
	public int collectionIndex; // 0x34
	public int reportId; // 0x38
	public int reportSizeInBits; // 0x3C
	public int reportOffsetInBits; // 0x40
	public HIDElementFlags flags; // 0x44
	public System.Nullable<System.Int32> usageMin; // 0x48
	public System.Nullable<System.Int32> usageMax; // 0x50

	// Methods

	// RVA: 0x1455528
	public bool get_hasNullState() { }

	// RVA: 0x1455534
	public bool get_hasPreferredState() { }

	// RVA: 0x1455544
	public bool get_isArray() { }

	// RVA: 0x1455554
	public bool get_isNonLinear() { }

	// RVA: 0x1455560
	public bool get_isRelative() { }

	// RVA: 0x145556C
	public bool get_isConstant() { }

	// RVA: 0x1455578
	public bool get_isWrapping() { }

	// RVA: 0x1454400
	internal bool get_isSigned() { }

	// RVA: 0x1455584
	internal float get_minFloatValue() { }

	// RVA: 0x145561C
	internal float get_maxFloatValue() { }

	// RVA: 0x1454560
	public bool Is(UsagePage usagePage, int usage) { }

	// RVA: 0x14546A4
	internal string DetermineName() { }

	// RVA: 0x14548DC
	internal string DetermineDisplayName() { }

	// RVA: 0x1450D78
	internal bool IsUsableElement() { }

	// RVA: 0x1454584
	internal string DetermineLayout() { }

	// RVA: 0x14549FC
	internal FourCC DetermineFormat() { }

	// RVA: 0x1454BF8
	internal InternedString[] DetermineUsages() { }

	// RVA: 0x14542A4
	internal string DetermineParameters() { }

	// RVA: 0x14556BC
	private string DetermineAxisNormalizationParameters() { }

	// RVA: 0x14544E4
	internal string DetermineProcessors() { }

	// RVA: 0x145440C
	internal PrimitiveValue DetermineDefaultState() { }

	// RVA: 0x1454DF0
	internal void AddChildControls(HIDElementDescriptor element, string controlName, Builder builder) { }

}

// Namespace: 
[Serializable]
public struct HIDCollectionDescriptor
{
	// Fields
	public HIDCollectionType type; // 0x10
	public int usage; // 0x14
	public UsagePage usagePage; // 0x18
	public int parent; // 0x1C
	public int childCount; // 0x20
	public int firstChild; // 0x24
}

// Namespace: 
[Serializable]
public struct HIDDeviceDescriptor
{
	// Fields
	public int vendorId; // 0x10
	public int productId; // 0x14
	public int usage; // 0x18
	public UsagePage usagePage; // 0x1C
	public int inputReportSize; // 0x20
	public int outputReportSize; // 0x24
	public int featureReportSize; // 0x28
	public HIDElementDescriptor[] elements; // 0x30
	public HIDCollectionDescriptor[] collections; // 0x38

	// Methods

	// RVA: 0x1453378
	public string ToJson() { }

	// RVA: 0x1450DC0
	public static HIDDeviceDescriptor FromJson(string json) { }

}

// Namespace: 
public struct HIDDeviceDescriptorBuilder
{
	// Fields
	public UsagePage usagePage; // 0x10
	public int usage; // 0x14
	private int m_CurrentReportId; // 0x18
	private HIDReportType m_CurrentReportType; // 0x1C
	private int m_CurrentReportOffsetInBits; // 0x20
	private System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> m_Elements; // 0x28
	private System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor> m_Collections; // 0x30
	private int m_InputReportSize; // 0x38
	private int m_OutputReportSize; // 0x3C
	private int m_FeatureReportSize; // 0x40

	// Methods

	// RVA: 0x1455990
	public void .ctor(UsagePage usagePage, int usage) { }

	// RVA: 0x14559A8
	public void .ctor(GenericDesktop usage) { }

	// RVA: 0x14559C4
	public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId) { }

	// RVA: 0x14559EC
	public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) { }

	// RVA: 0x1455DA4
	public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) { }

	// RVA: 0x1455DF8
	public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) { }

	// RVA: 0x1455F68
	public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) { }

	// RVA: 0x14560C4
	public HIDDeviceDescriptor Finish() { }

}

// Namespace: 
public enum UsagePage
{
	// Fields
	public int value__; // 0x10
	public const UsagePage Undefined = 0;
	public const UsagePage GenericDesktop = 1;
	public const UsagePage Simulation = 2;
	public const UsagePage VRControls = 3;
	public const UsagePage SportControls = 4;
	public const UsagePage GameControls = 5;
	public const UsagePage GenericDeviceControls = 6;
	public const UsagePage Keyboard = 7;
	public const UsagePage LEDs = 8;
	public const UsagePage Button = 9;
	public const UsagePage Ordinal = 10;
	public const UsagePage Telephony = 11;
	public const UsagePage Consumer = 12;
	public const UsagePage Digitizer = 13;
	public const UsagePage PID = 15;
	public const UsagePage Unicode = 16;
	public const UsagePage AlphanumericDisplay = 20;
	public const UsagePage MedicalInstruments = 64;
	public const UsagePage Monitor = 128;
	public const UsagePage Power = 132;
	public const UsagePage BarCodeScanner = 140;
	public const UsagePage MagneticStripeReader = 142;
	public const UsagePage Camera = 144;
	public const UsagePage Arcade = 145;
	public const UsagePage VendorDefined = 65280;
}

// Namespace: 
public enum GenericDesktop
{
	// Fields
	public int value__; // 0x10
	public const GenericDesktop Undefined = 0;
	public const GenericDesktop Pointer = 1;
	public const GenericDesktop Mouse = 2;
	public const GenericDesktop Joystick = 4;
	public const GenericDesktop Gamepad = 5;
	public const GenericDesktop Keyboard = 6;
	public const GenericDesktop Keypad = 7;
	public const GenericDesktop MultiAxisController = 8;
	public const GenericDesktop TabletPCControls = 9;
	public const GenericDesktop AssistiveControl = 10;
	public const GenericDesktop X = 48;
	public const GenericDesktop Y = 49;
	public const GenericDesktop Z = 50;
	public const GenericDesktop Rx = 51;
	public const GenericDesktop Ry = 52;
	public const GenericDesktop Rz = 53;
	public const GenericDesktop Slider = 54;
	public const GenericDesktop Dial = 55;
	public const GenericDesktop Wheel = 56;
	public const GenericDesktop HatSwitch = 57;
	public const GenericDesktop CountedBuffer = 58;
	public const GenericDesktop ByteCount = 59;
	public const GenericDesktop MotionWakeup = 60;
	public const GenericDesktop Start = 61;
	public const GenericDesktop Select = 62;
	public const GenericDesktop Vx = 64;
	public const GenericDesktop Vy = 65;
	public const GenericDesktop Vz = 66;
	public const GenericDesktop Vbrx = 67;
	public const GenericDesktop Vbry = 68;
	public const GenericDesktop Vbrz = 69;
	public const GenericDesktop Vno = 70;
	public const GenericDesktop FeatureNotification = 71;
	public const GenericDesktop ResolutionMultiplier = 72;
	public const GenericDesktop SystemControl = 128;
	public const GenericDesktop SystemPowerDown = 129;
	public const GenericDesktop SystemSleep = 130;
	public const GenericDesktop SystemWakeUp = 131;
	public const GenericDesktop SystemContextMenu = 132;
	public const GenericDesktop SystemMainMenu = 133;
	public const GenericDesktop SystemAppMenu = 134;
	public const GenericDesktop SystemMenuHelp = 135;
	public const GenericDesktop SystemMenuExit = 136;
	public const GenericDesktop SystemMenuSelect = 137;
	public const GenericDesktop SystemMenuRight = 138;
	public const GenericDesktop SystemMenuLeft = 139;
	public const GenericDesktop SystemMenuUp = 140;
	public const GenericDesktop SystemMenuDown = 141;
	public const GenericDesktop SystemColdRestart = 142;
	public const GenericDesktop SystemWarmRestart = 143;
	public const GenericDesktop DpadUp = 144;
	public const GenericDesktop DpadDown = 145;
	public const GenericDesktop DpadRight = 146;
	public const GenericDesktop DpadLeft = 147;
	public const GenericDesktop SystemDock = 160;
	public const GenericDesktop SystemUndock = 161;
	public const GenericDesktop SystemSetup = 162;
	public const GenericDesktop SystemBreak = 163;
	public const GenericDesktop SystemDebuggerBreak = 164;
	public const GenericDesktop ApplicationBreak = 165;
	public const GenericDesktop ApplicationDebuggerBreak = 166;
	public const GenericDesktop SystemSpeakerMute = 167;
	public const GenericDesktop SystemHibernate = 168;
	public const GenericDesktop SystemDisplayInvert = 176;
	public const GenericDesktop SystemDisplayInternal = 177;
	public const GenericDesktop SystemDisplayExternal = 178;
	public const GenericDesktop SystemDisplayBoth = 179;
	public const GenericDesktop SystemDisplayDual = 180;
	public const GenericDesktop SystemDisplayToggleIntExt = 181;
	public const GenericDesktop SystemDisplaySwapPrimarySecondary = 182;
	public const GenericDesktop SystemDisplayLCDAutoScale = 183;
}

// Namespace: 
public enum Simulation
{
	// Fields
	public int value__; // 0x10
	public const Simulation Undefined = 0;
	public const Simulation FlightSimulationDevice = 1;
	public const Simulation AutomobileSimulationDevice = 2;
	public const Simulation TankSimulationDevice = 3;
	public const Simulation SpaceshipSimulationDevice = 4;
	public const Simulation SubmarineSimulationDevice = 5;
	public const Simulation SailingSimulationDevice = 6;
	public const Simulation MotorcycleSimulationDevice = 7;
	public const Simulation SportsSimulationDevice = 8;
	public const Simulation AirplaneSimulationDevice = 9;
	public const Simulation HelicopterSimulationDevice = 10;
	public const Simulation MagicCarpetSimulationDevice = 11;
	public const Simulation BicylcleSimulationDevice = 12;
	public const Simulation FlightControlStick = 32;
	public const Simulation FlightStick = 33;
	public const Simulation CyclicControl = 34;
	public const Simulation CyclicTrim = 35;
	public const Simulation FlightYoke = 36;
	public const Simulation TrackControl = 37;
	public const Simulation Aileron = 176;
	public const Simulation AileronTrim = 177;
	public const Simulation AntiTorqueControl = 178;
	public const Simulation AutopilotEnable = 179;
	public const Simulation ChaffRelease = 180;
	public const Simulation CollectiveControl = 181;
	public const Simulation DiveBreak = 182;
	public const Simulation ElectronicCountermeasures = 183;
	public const Simulation Elevator = 184;
	public const Simulation ElevatorTrim = 185;
	public const Simulation Rudder = 186;
	public const Simulation Throttle = 187;
	public const Simulation FlightCommunications = 188;
	public const Simulation FlareRelease = 189;
	public const Simulation LandingGear = 190;
	public const Simulation ToeBreak = 191;
	public const Simulation Trigger = 192;
	public const Simulation WeaponsArm = 193;
	public const Simulation WeaponsSelect = 194;
	public const Simulation WingFlaps = 195;
	public const Simulation Accelerator = 196;
	public const Simulation Brake = 197;
	public const Simulation Clutch = 198;
	public const Simulation Shifter = 199;
	public const Simulation Steering = 200;
	public const Simulation TurretDirection = 201;
	public const Simulation BarrelElevation = 202;
	public const Simulation DivePlane = 203;
	public const Simulation Ballast = 204;
	public const Simulation BicycleCrank = 205;
	public const Simulation HandleBars = 206;
	public const Simulation FrontBrake = 207;
	public const Simulation RearBrake = 208;
}

// Namespace: 
public enum Button
{
	// Fields
	public int value__; // 0x10
	public const Button Undefined = 0;
	public const Button Primary = 1;
	public const Button Secondary = 2;
	public const Button Tertiary = 3;
}

// Namespace: 
private sealed class <>c__DisplayClass12_0
{
	// Fields
	public HIDLayoutBuilder layout; // 0x10

	// Methods

	// RVA: 0x14504AC
	public void .ctor() { }

	// RVA: 0x14561C0
	internal InputControlLayout <OnFindLayoutForDevice>b__0() { }

}

// Namespace: UnityEngine.InputSystem.HID
public class HID
{
	// Fields
	internal const string kHIDInterface = "HID";
	internal const string kHIDNamespace = "HID";
	private bool m_HaveParsedHIDDescriptor; // 0x170
	private HIDDeviceDescriptor m_HIDDescriptor; // 0x178

	// Methods

	// RVA: 0x144F9DC
	public static FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	// RVA: 0x144FA18
	public static FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	// RVA: 0x144FA54
	public static FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	// RVA: 0x144FA90
	public HIDDeviceDescriptor get_hidDescriptor() { }

	// RVA: 0x144FB4C
	internal static string OnFindLayoutForDevice(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x14504B4
	internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	// RVA: 0x14533F4
	public static string UsagePageToString(UsagePage usagePage) { }

	// RVA: 0x1453490
	public static string UsageToString(UsagePage usagePage, int usage) { }

	// RVA: 0x1453544
	public void .ctor() { }

}

// Namespace: 
private struct HIDReportData
{
	// Fields
	public int reportId; // 0x10
	public HIDReportType reportType; // 0x14
	public int currentBitOffset; // 0x18

	// Methods

	// RVA: 0x14567E4
	public static int FindOrAddReport(System.Nullable<System.Int32> reportId, HIDReportType reportType, System.Collections.Generic.List<UnityEngine.InputSystem.HID.HIDParser.HIDReportData> reports) { }

}

// Namespace: 
private enum HIDItemTypeAndTag
{
	// Fields
	public int value__; // 0x10
	public const HIDItemTypeAndTag Input = 128;
	public const HIDItemTypeAndTag Output = 144;
	public const HIDItemTypeAndTag Feature = 176;
	public const HIDItemTypeAndTag Collection = 160;
	public const HIDItemTypeAndTag EndCollection = 192;
	public const HIDItemTypeAndTag UsagePage = 4;
	public const HIDItemTypeAndTag LogicalMinimum = 20;
	public const HIDItemTypeAndTag LogicalMaximum = 36;
	public const HIDItemTypeAndTag PhysicalMinimum = 52;
	public const HIDItemTypeAndTag PhysicalMaximum = 68;
	public const HIDItemTypeAndTag UnitExponent = 84;
	public const HIDItemTypeAndTag Unit = 100;
	public const HIDItemTypeAndTag ReportSize = 116;
	public const HIDItemTypeAndTag ReportID = 132;
	public const HIDItemTypeAndTag ReportCount = 148;
	public const HIDItemTypeAndTag Push = 164;
	public const HIDItemTypeAndTag Pop = 180;
	public const HIDItemTypeAndTag Usage = 8;
	public const HIDItemTypeAndTag UsageMinimum = 24;
	public const HIDItemTypeAndTag UsageMaximum = 40;
	public const HIDItemTypeAndTag DesignatorIndex = 56;
	public const HIDItemTypeAndTag DesignatorMinimum = 72;
	public const HIDItemTypeAndTag DesignatorMaximum = 88;
	public const HIDItemTypeAndTag StringIndex = 120;
	public const HIDItemTypeAndTag StringMinimum = 136;
	public const HIDItemTypeAndTag StringMaximum = 152;
	public const HIDItemTypeAndTag Delimiter = 168;
}

// Namespace: 
private struct HIDItemStateLocal
{
	// Fields
	public System.Nullable<System.Int32> usage; // 0x10
	public System.Nullable<System.Int32> usageMinimum; // 0x18
	public System.Nullable<System.Int32> usageMaximum; // 0x20
	public System.Nullable<System.Int32> designatorIndex; // 0x28
	public System.Nullable<System.Int32> designatorMinimum; // 0x30
	public System.Nullable<System.Int32> designatorMaximum; // 0x38
	public System.Nullable<System.Int32> stringIndex; // 0x40
	public System.Nullable<System.Int32> stringMinimum; // 0x48
	public System.Nullable<System.Int32> stringMaximum; // 0x50
	public System.Collections.Generic.List<System.Int32> usageList; // 0x58

	// Methods

	// RVA: 0x1456714
	public static void Reset(HIDItemStateLocal state) { }

	// RVA: 0x14562BC
	public void SetUsage(int value) { }

	// RVA: 0x1456520
	public int GetUsage(int index) { }

}

// Namespace: 
private struct HIDItemStateGlobal
{
	// Fields
	public System.Nullable<System.Int32> usagePage; // 0x10
	public System.Nullable<System.Int32> logicalMinimum; // 0x18
	public System.Nullable<System.Int32> logicalMaximum; // 0x20
	public System.Nullable<System.Int32> physicalMinimum; // 0x28
	public System.Nullable<System.Int32> physicalMaximum; // 0x30
	public System.Nullable<System.Int32> unitExponent; // 0x38
	public System.Nullable<System.Int32> unit; // 0x40
	public System.Nullable<System.Int32> reportSize; // 0x48
	public System.Nullable<System.Int32> reportCount; // 0x50
	public System.Nullable<System.Int32> reportId; // 0x58

	// Methods

	// RVA: 0x1456438
	public UsagePage GetUsagePage(int index, HIDItemStateLocal localItemState) { }

	// RVA: 0x145697C
	public int GetPhysicalMin() { }

	// RVA: 0x1456ADC
	public int GetPhysicalMax() { }

}

// Namespace: UnityEngine.InputSystem.HID
internal static class HIDParser
{
	// Methods

	// RVA: 0x14561DC
	public static bool ParseReportDescriptor(Byte[] buffer, HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x1451CAC
	public static bool ParseReportDescriptor(Byte* bufferPtr, int bufferLength, HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x1456254
	private static int ReadData(int itemSize, Byte* currentPtr, Byte* endPtr) { }

}

// Namespace: 
public struct HIDPageUsage
{
	// Fields
	public UsagePage page; // 0x10
	public int usage; // 0x14

	// Methods

	// RVA: 0x1450D70
	public void .ctor(UsagePage page, int usage) { }

	// RVA: 0x14570C0
	public void .ctor(GenericDesktop usage) { }

}

// Namespace: UnityEngine.InputSystem.HID
public static class HIDSupport
{
	// Fields
	private static HIDPageUsage[] s_SupportedHIDUsages; // 0x0

	// Methods

	// RVA: 0x1450D04
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages() { }

	// RVA: 0x1456C3C
	public static void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value) { }

	// RVA: 0x1456F5C
	internal static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public static class EnhancedTouchSupport
{
	// Fields
	private static int s_Enabled; // 0x0
	private static UpdateMode s_UpdateMode; // 0x4

	// Methods

	// RVA: 0x14570CC
	public static bool get_enabled() { }

	// RVA: 0x1457120
	public static void Enable() { }

	// RVA: 0x1457498
	public static void Disable() { }

	// RVA: 0x1457884
	internal static void Reset() { }

	// RVA: 0x14572A0
	private static void SetUpState() { }

	// RVA: 0x145764C
	internal static void TearDownState() { }

	// RVA: 0x14579B8
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1457CE8
	private static void OnSettingsChange() { }

	// RVA: 0x1457D9C
	internal static void CheckEnabled() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public class Finger
{
	// Fields
	private readonly Touchscreen <screen>k__BackingField; // 0x10
	private readonly int <index>k__BackingField; // 0x18
	internal readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory; // 0x20

	// Methods

	// RVA: 0x1457E38
	public Touchscreen get_screen() { }

	// RVA: 0x1457E40
	public int get_index() { }

	// RVA: 0x1457E48
	public bool get_isActive() { }

	// RVA: 0x145821C
	public Vector2 get_screenPosition() { }

	// RVA: 0x145843C
	public Touch get_lastTouch() { }

	// RVA: 0x1457F10
	public Touch get_currentTouch() { }

	// RVA: 0x14587C4
	public TouchHistory get_touchHistory() { }

	// RVA: 0x14588D0
	internal void .ctor(Touchscreen screen, int index, InputUpdateType updateMask) { }

	// RVA: 0x1458D0C
	private static bool ShouldRecordTouch(InputControl control, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x1458DE8
	private void OnTouchRecorded(Record record) { }

	// RVA: 0x14590B0
	private Touch FindTouch(UInt32 uniqueId) { }

	// RVA: 0x14593F4
	internal TouchHistory GetTouchHistory(Touch touch) { }

}

// Namespace: 
internal struct GlobalState
{
	// Fields
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Touchscreen> touchscreens; // 0x10
	internal int historyLengthPerFinger; // 0x28
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerDown; // 0x30
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerMove; // 0x80
	internal UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerUp; // 0xD0
	internal FingerAndTouchState playerState; // 0x120
}

// Namespace: 
internal struct FingerAndTouchState
{
	// Fields
	public InputUpdateType updateMask; // 0x10
	public Finger[] fingers; // 0x18
	public Finger[] activeFingers; // 0x20
	public Touch[] activeTouches; // 0x28
	public int activeFingerCount; // 0x30
	public int activeTouchCount; // 0x34
	public int totalFingerCount; // 0x38
	public UInt32 lastId; // 0x3C
	public bool haveBuiltActiveTouches; // 0x40
	public bool haveActiveTouchesNeedingRefreshNextUpdate; // 0x41
	public UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> activeTouchState; // 0x48

	// Methods

	// RVA: 0x145BFBC
	public void AddFingers(Touchscreen screen) { }

	// RVA: 0x145C0D4
	public void RemoveFingers(Touchscreen screen) { }

	// RVA: 0x1457928
	public void Destroy() { }

	// RVA: 0x145B128
	public void UpdateActiveFingers() { }

	// RVA: 0x145A8A0
	public void UpdateActiveTouches() { }

}

// Namespace: 
internal struct ExtraDataPerTouchState
{
	// Fields
	public Vector2 accumulatedDelta; // 0x10
	public UInt32 uniqueId; // 0x18
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.EnhancedTouch.Touch.<>c <>9; // 0x0
	public static TypedRestore <>9__80_0; // 0x8
	public static Action <>9__80_1; // 0x10

	// Methods

	// RVA: 0x145C68C
	private static void .cctor() { }

	// RVA: 0x145C6F8
	public void .ctor() { }

	// RVA: 0x145C700
	internal void <SaveAndResetState>b__80_0(GlobalState state) { }

	// RVA: 0x145C798
	internal void <SaveAndResetState>b__80_1() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public struct Touch
{
	// Fields
	private readonly Finger m_Finger; // 0x10
	internal Record m_TouchRecord; // 0x18
	internal static GlobalState s_GlobalState; // 0x0

	// Methods

	// RVA: 0x14581C8
	public bool get_valid() { }

	// RVA: 0x1459A1C
	public Finger get_finger() { }

	// RVA: 0x1459964
	public TouchPhase get_phase() { }

	// RVA: 0x1459A78
	public bool get_began() { }

	// RVA: 0x1459B80
	public bool get_inProgress() { }

	// RVA: 0x1459DF8
	public bool get_ended() { }

	// RVA: 0x14598AC
	public int get_touchId() { }

	// RVA: 0x1459FB4
	public float get_pressure() { }

	// RVA: 0x145A06C
	public Vector2 get_radius() { }

	// RVA: 0x145A124
	public Double get_startTime() { }

	// RVA: 0x145A1DC
	public Double get_time() { }

	// RVA: 0x145A230
	public Touchscreen get_screen() { }

	// RVA: 0x1458504
	public Vector2 get_screenPosition() { }

	// RVA: 0x145A2B0
	public Vector2 get_startScreenPosition() { }

	// RVA: 0x145A368
	public Vector2 get_delta() { }

	// RVA: 0x145A420
	public int get_tapCount() { }

	// RVA: 0x145A4D8
	public bool get_isTap() { }

	// RVA: 0x145A590
	public int get_displayIndex() { }

	// RVA: 0x14585FC
	public bool get_isInProgress() { }

	// RVA: 0x145870C
	internal UInt32 get_updateStepCount() { }

	// RVA: 0x14597F4
	internal UInt32 get_uniqueId() { }

	// RVA: 0x1459A24
	private TouchState get_state() { }

	// RVA: 0x145A648
	private ExtraDataPerTouchState get_extraData() { }

	// RVA: 0x145A69C
	public TouchHistory get_history() { }

	// RVA: 0x145A7FC
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches() { }

	// RVA: 0x145AFF0
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers() { }

	// RVA: 0x145B084
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers() { }

	// RVA: 0x145B2A8
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens() { }

	// RVA: 0x145B340
	public static void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x145B410
	public static void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x145B4E0
	public static void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x145B5B0
	public static void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x145B680
	public static void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x145B750
	public static void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1458C90
	public static int get_maxHistoryLengthPerFinger() { }

	// RVA: 0x14585BC
	internal void .ctor(Finger finger, Record touchRecord) { }

	// RVA: 0x145B820
	public override string ToString() { }

	// RVA: 0x145BDAC
	public bool Equals(Touch other) { }

	// RVA: 0x145BE2C
	public override bool Equals(object obj) { }

	// RVA: 0x145BF3C
	public override int GetHashCode() { }

	// RVA: 0x1457B6C
	internal static void AddTouchscreen(Touchscreen screen) { }

	// RVA: 0x1457C04
	internal static void RemoveTouchscreen(Touchscreen screen) { }

	// RVA: 0x145C214
	internal static void BeginUpdate() { }

	// RVA: 0x145C2C0
	private static GlobalState CreateGlobalState() { }

	// RVA: 0x145C320
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x145C5D8
	private static void .cctor() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private readonly TouchHistory m_Owner; // 0x10
	private int m_Index; // 0x30

	// Methods

	// RVA: 0x145C82C
	internal void .ctor(TouchHistory owner) { }

	// RVA: 0x145CB20
	public bool MoveNext() { }

	// RVA: 0x145CB48
	public void Reset() { }

	// RVA: 0x145CB54
	public Touch get_Current() { }

	// RVA: 0x145CBA0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x145CC28
	public void Dispose() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public struct TouchHistory
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_History; // 0x10
	private readonly Finger m_Finger; // 0x18
	private readonly int m_Count; // 0x20
	private readonly int m_StartIndex; // 0x24
	private readonly UInt32 m_Version; // 0x28

	// Methods

	// RVA: 0x1458830
	internal void .ctor(Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex, int count) { }

	// RVA: 0x145C79C
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator() { }

	// RVA: 0x145C870
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x145C900
	public int get_Count() { }

	// RVA: 0x145C908
	public Touch get_Item(int index) { }

	// RVA: 0x145CA80
	internal void CheckValid() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public class TouchSimulation
{
	// Fields
	private Touchscreen <simulatedTouchscreen>k__BackingField; // 0x20
	private int m_NumPointers; // 0x28
	private Pointer[] m_Pointers; // 0x30
	private Vector2[] m_CurrentPositions; // 0x38
	private int[] m_CurrentDisplayIndices; // 0x40
	private ButtonControl[] m_Touches; // 0x48
	private int m_LastTouchId; // 0x50
	private int m_PrimaryTouchIndex; // 0x54
	private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> m_OnDeviceChange; // 0x58
	private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEvent; // 0x60
	internal static TouchSimulation s_Instance; // 0x0

	// Methods

	// RVA: 0x145CC2C
	public Touchscreen get_simulatedTouchscreen() { }

	// RVA: 0x145CC34
	private void set_simulatedTouchscreen(Touchscreen value) { }

	// RVA: 0x145CC3C
	public static TouchSimulation get_instance() { }

	// RVA: 0x145CC88
	public static void Enable() { }

	// RVA: 0x145CE80
	public static void Disable() { }

	// RVA: 0x145CF7C
	public static void Destroy() { }

	// RVA: 0x145D084
	protected void AddPointer(Pointer pointer) { }

	// RVA: 0x145D1F8
	protected void RemovePointer(Pointer pointer) { }

	// RVA: 0x145D810
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x145DE38
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x145DF88
	protected void OnEnable() { }

	// RVA: 0x145E4A8
	protected void OnDisable() { }

	// RVA: 0x145D3EC
	private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr) { }

	// RVA: 0x145E61C
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x145E620
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x145E624
	protected void InstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x145E628
	protected void OnSourceControlChangedValue(InputControl control, Double time, InputEventPtr eventPtr, Int64 sourceDeviceAndButtonIndex) { }

	// RVA: 0x145E62C
	protected void UninstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x145E630
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
public class DualShockGamepad
{
	// Fields
	private ButtonControl <touchpadButton>k__BackingField; // 0x1F0
	private ButtonControl <optionsButton>k__BackingField; // 0x1F8
	private ButtonControl <shareButton>k__BackingField; // 0x200
	private ButtonControl <L1>k__BackingField; // 0x208
	private ButtonControl <R1>k__BackingField; // 0x210
	private ButtonControl <L2>k__BackingField; // 0x218
	private ButtonControl <R2>k__BackingField; // 0x220
	private ButtonControl <L3>k__BackingField; // 0x228
	private ButtonControl <R3>k__BackingField; // 0x230
	private static DualShockGamepad <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x145E640
	public ButtonControl get_touchpadButton() { }

	// RVA: 0x145E648
	protected void set_touchpadButton(ButtonControl value) { }

	// RVA: 0x145E658
	public ButtonControl get_optionsButton() { }

	// RVA: 0x145E660
	protected void set_optionsButton(ButtonControl value) { }

	// RVA: 0x145E670
	public ButtonControl get_shareButton() { }

	// RVA: 0x145E678
	protected void set_shareButton(ButtonControl value) { }

	// RVA: 0x145E688
	public ButtonControl get_L1() { }

	// RVA: 0x145E690
	protected void set_L1(ButtonControl value) { }

	// RVA: 0x145E6A0
	public ButtonControl get_R1() { }

	// RVA: 0x145E6A8
	protected void set_R1(ButtonControl value) { }

	// RVA: 0x145E6B8
	public ButtonControl get_L2() { }

	// RVA: 0x145E6C0
	protected void set_L2(ButtonControl value) { }

	// RVA: 0x145E6D0
	public ButtonControl get_R2() { }

	// RVA: 0x145E6D8
	protected void set_R2(ButtonControl value) { }

	// RVA: 0x145E6E8
	public ButtonControl get_L3() { }

	// RVA: 0x145E6F0
	protected void set_L3(ButtonControl value) { }

	// RVA: 0x145E700
	public ButtonControl get_R3() { }

	// RVA: 0x145E708
	protected void set_R3(ButtonControl value) { }

	// RVA: 0x145E718
	public static DualShockGamepad get_current() { }

	// RVA: 0x145E764
	private static void set_current(DualShockGamepad value) { }

	// RVA: 0x145E7C8
	public override void MakeCurrent() { }

	// RVA: 0x145E82C
	protected override void OnRemoved() { }

	// RVA: 0x145E8CC
	protected override void FinishSetup() { }

	// RVA: 0x145E9D4
	public virtual void SetLightBarColor(Color color) { }

	// RVA: 0x144EA44
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
internal static class DualShockSupport
{
	// Methods

	// RVA: 0x145E9D8
	public static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
public interface IDualShockHaptics
{
	// Methods

	// RVA: -1
	public abstract void SetLightBarColor(Color color) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
internal struct DualMotorRumble
{
	// Fields
	private float <lowFrequencyMotorSpeed>k__BackingField; // 0x10
	private float <highFrequencyMotorSpeed>k__BackingField; // 0x14

	// Methods

	// RVA: 0x145EA4C
	public float get_lowFrequencyMotorSpeed() { }

	// RVA: 0x145EA54
	private void set_lowFrequencyMotorSpeed(float value) { }

	// RVA: 0x145EA5C
	public float get_highFrequencyMotorSpeed() { }

	// RVA: 0x145EA64
	private void set_highFrequencyMotorSpeed(float value) { }

	// RVA: 0x145EA6C
	public bool get_isRumbling() { }

	// RVA: 0x145EB54
	public void PauseHaptics(InputDevice device) { }

	// RVA: 0x145ED00
	public void ResumeHaptics(InputDevice device) { }

	// RVA: 0x145EF74
	public void ResetHaptics(InputDevice device) { }

	// RVA: 0x145EE4C
	public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
public interface IDualMotorRumble
{
	// Methods

	// RVA: -1
	public abstract void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
public interface IHaptics
{
	// Methods

	// RVA: -1
	public abstract void PauseHaptics() { }

	// RVA: -1
	public abstract void ResumeHaptics() { }

	// RVA: -1
	public abstract void ResetHaptics() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DisableDeviceCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x144F86C
	public static FourCC get_Type() { }

	// RVA: 0x145F0C4
	public FourCC get_typeStatic() { }

	// RVA: 0x145F100
	public static DisableDeviceCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct EnableDeviceCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x144F78C
	public static FourCC get_Type() { }

	// RVA: 0x145F140
	public FourCC get_typeStatic() { }

	// RVA: 0x145F17C
	public static EnableDeviceCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct EnableIMECompositionCommand
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x10
	private Byte m_ImeEnabled; // 0x18

	// Methods

	// RVA: 0x145F1BC
	public static FourCC get_Type() { }

	// RVA: 0x145F1F8
	public bool get_imeEnabled() { }

	// RVA: 0x145F208
	public FourCC get_typeStatic() { }

	// RVA: 0x145F244
	public static EnableIMECompositionCommand Create(bool enabled) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputDeviceCommandInfo
{
	// Methods

	// RVA: -1
	public abstract FourCC get_typeStatic() { }

}

// Namespace: 
public enum Result
{
	// Fields
	public int value__; // 0x10
	public const Result SuccessfullyInitiated = 1;
	public const Result ErrorNotSupported = 4294967295;
	public const Result ErrorAlreadyInProgress = 4294967294;
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InitiateUserAccountPairingCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x145F2A0
	public static FourCC get_Type() { }

	// RVA: 0x145F2DC
	public FourCC get_typeStatic() { }

	// RVA: 0x145F318
	public static InitiateUserAccountPairingCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceCommandDelegate
{
	// Methods

	// RVA: 0x145F358
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145F47C
	public virtual System.Nullable<System.Int64> Invoke(InputDevice device, InputDeviceCommand* command) { }

	// RVA: 0x145F490
	public virtual IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	// RVA: 0x145F4EC
	public virtual System.Nullable<System.Int64> EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceExecuteCommandDelegate
{
	// Methods

	// RVA: 0x145F51C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145F5D0
	public virtual Int64 Invoke(InputDeviceCommand command) { }

	// RVA: 0x145F5E4
	public virtual IAsyncResult BeginInvoke(InputDeviceCommand command, AsyncCallback callback, object object) { }

	// RVA: 0x145F6A0
	public virtual Int64 EndInvoke(InputDeviceCommand command, IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputDeviceCommand
{
	// Fields
	internal const int kBaseCommandSize = 8;
	public const int BaseCommandSize = 8;
	public const Int64 GenericFailure = 18446744073709551615;
	public const Int64 GenericSuccess = 1;
	public FourCC type; // 0x10
	public int sizeInBytes; // 0x14

	// Methods

	// RVA: 0x145F704
	public int get_payloadSizeInBytes() { }

	// RVA: 0x1451CA4
	public Void* get_payloadPtr() { }

	// RVA: 0x1451BE0
	public void .ctor(FourCC type, int sizeInBytes) { }

	// RVA: 0x1451BE8
	public static Unity.Collections.NativeArray<System.Byte> AllocateNative(FourCC type, int payloadSize) { }

	// RVA: 0x145F710
	public FourCC get_typeStatic() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryCanRunInBackground
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x10
	public bool canRunInBackground; // 0x18

	// Methods

	// RVA: 0x144F8A8
	public static FourCC get_Type() { }

	// RVA: 0x145F718
	public FourCC get_typeStatic() { }

	// RVA: 0x145F754
	public static QueryCanRunInBackground Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryDimensionsCommand
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	public Vector2 outDimensions; // 0x18

	// Methods

	// RVA: 0x145F79C
	public static FourCC get_Type() { }

	// RVA: 0x145F7D8
	public FourCC get_typeStatic() { }

	// RVA: 0x145F814
	public static QueryDimensionsCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryEnabledStateCommand
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x10
	public bool isEnabled; // 0x18

	// Methods

	// RVA: 0x144F750
	public static FourCC get_Type() { }

	// RVA: 0x145F858
	public FourCC get_typeStatic() { }

	// RVA: 0x145F894
	public static QueryEnabledStateCommand Create() { }

}

// Namespace: 
public struct <nameBuffer>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryKeyboardLayoutCommand
{
	// Fields
	internal const int kMaxNameLength = 256;
	public InputDeviceCommand baseCommand; // 0x10
	public UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand.<nameBuffer>e__FixedBuffer nameBuffer; // 0x18

	// Methods

	// RVA: 0x145F8DC
	public static FourCC get_Type() { }

	// RVA: 0x145F918
	public string ReadLayoutName() { }

	// RVA: 0x145F928
	public void WriteLayoutName(string name) { }

	// RVA: 0x145F950
	public FourCC get_typeStatic() { }

	// RVA: 0x145F98C
	public static QueryKeyboardLayoutCommand Create() { }

}

// Namespace: 
public struct <nameBuffer>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryKeyNameCommand
{
	// Fields
	internal const int kMaxNameLength = 256;
	internal const int kSize = 268;
	public InputDeviceCommand baseCommand; // 0x10
	public int scanOrKeyCode; // 0x18
	public UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand.<nameBuffer>e__FixedBuffer nameBuffer; // 0x1C

	// Methods

	// RVA: 0x145FA24
	public static FourCC get_Type() { }

	// RVA: 0x145FA60
	public string ReadKeyName() { }

	// RVA: 0x145FA70
	public FourCC get_typeStatic() { }

	// RVA: 0x145FAAC
	public static QueryKeyNameCommand Create(Key key) { }

}

// Namespace: 
public enum Result
{
	// Fields
	public Int64 value__; // 0x10
	public const Result DevicePairedToUserAccount = 2;
	public const Result UserAccountSelectionInProgress = 4;
	public const Result UserAccountSelectionComplete = 8;
	public const Result UserAccountSelectionCanceled = 16;
}

// Namespace: 
public struct <idBuffer>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <nameBuffer>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryPairedUserAccountCommand
{
	// Fields
	internal const int kMaxNameLength = 256;
	internal const int kMaxIdLength = 256;
	internal const int kSize = 1040;
	public InputDeviceCommand baseCommand; // 0x10
	public UInt64 handle; // 0x18
	internal UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<nameBuffer>e__FixedBuffer nameBuffer; // 0x20
	internal UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<idBuffer>e__FixedBuffer idBuffer; // 0x220

	// Methods

	// RVA: 0x145FB4C
	public static FourCC get_Type() { }

	// RVA: 0x145FB88
	public string get_id() { }

	// RVA: 0x145FB98
	public void set_id(string value) { }

	// RVA: 0x145FCB4
	public string get_name() { }

	// RVA: 0x145FCC4
	public void set_name(string value) { }

	// RVA: 0x145FDE0
	public FourCC get_typeStatic() { }

	// RVA: 0x145FE1C
	public static QueryPairedUserAccountCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct QuerySamplingFrequencyCommand
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x10
	public float frequency; // 0x18

	// Methods

	// RVA: 0x145FE7C
	public static FourCC get_Type() { }

	// RVA: 0x145FEB8
	public FourCC get_typeStatic() { }

	// RVA: 0x145FEF4
	public static QuerySamplingFrequencyCommand Create() { }

}

// Namespace: 
public struct <idBuffer>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct QueryUserIdCommand
{
	// Fields
	public const int kMaxIdLength = 256;
	internal const int kSize = 520;
	public InputDeviceCommand baseCommand; // 0x10
	public UnityEngine.InputSystem.LowLevel.QueryUserIdCommand.<idBuffer>e__FixedBuffer idBuffer; // 0x18

	// Methods

	// RVA: 0x145FF4C
	public static FourCC get_Type() { }

	// RVA: 0x145FF88
	public string ReadId() { }

	// RVA: 0x145FF98
	public FourCC get_typeStatic() { }

	// RVA: 0x145FFD4
	public static QueryUserIdCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestResetCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x146009C
	public static FourCC get_Type() { }

	// RVA: 0x14600D8
	public FourCC get_typeStatic() { }

	// RVA: 0x1460114
	public static RequestResetCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestSyncCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1460168
	public static FourCC get_Type() { }

	// RVA: 0x14601A4
	public FourCC get_typeStatic() { }

	// RVA: 0x14601E0
	public static RequestSyncCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct SetIMECursorPositionCommand
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	private Vector2 m_Position; // 0x18

	// Methods

	// RVA: 0x1460234
	public static FourCC get_Type() { }

	// RVA: 0x1460270
	public Vector2 get_position() { }

	// RVA: 0x1460278
	public FourCC get_typeStatic() { }

	// RVA: 0x14602B4
	public static SetIMECursorPositionCommand Create(Vector2 cursorPosition) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct SetSamplingFrequencyCommand
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x10
	public float frequency; // 0x18

	// Methods

	// RVA: 0x1460324
	public static FourCC get_Type() { }

	// RVA: 0x1460360
	public FourCC get_typeStatic() { }

	// RVA: 0x146039C
	public static SetSamplingFrequencyCommand Create(float frequency) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct UseWindowsGamingInputCommand
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x10
	public Byte enable; // 0x18

	// Methods

	// RVA: 0x1460400
	public static FourCC get_Type() { }

	// RVA: 0x146043C
	public FourCC get_typeStatic() { }

	// RVA: 0x1460478
	public static UseWindowsGamingInputCommand Create(bool enable) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct WarpMousePositionCommand
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	public Vector2 warpPositionInPlayerDisplaySpace; // 0x18

	// Methods

	// RVA: 0x14604DC
	public static FourCC get_Type() { }

	// RVA: 0x1460518
	public FourCC get_typeStatic() { }

	// RVA: 0x1460554
	public static WarpMousePositionCommand Create(Vector2 position) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct GamepadState
{
	// Fields
	internal const string ButtonSouthShortDisplayName = "A";
	internal const string ButtonNorthShortDisplayName = "Y";
	internal const string ButtonWestShortDisplayName = "X";
	internal const string ButtonEastShortDisplayName = "B";
	public UInt32 buttons; // 0x10
	public Vector2 leftStick; // 0x14
	public Vector2 rightStick; // 0x1C
	public float leftTrigger; // 0x24
	public float rightTrigger; // 0x28

	// Methods

	// RVA: 0x14605C4
	public static FourCC get_Format() { }

	// RVA: 0x1460600
	public FourCC get_format() { }

	// RVA: 0x146063C
	public void .ctor(GamepadButton[] buttons) { }

	// RVA: 0x14606E8
	public GamepadState WithButton(GamepadButton button, bool value) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public enum GamepadButton
{
	// Fields
	public int value__; // 0x10
	public const GamepadButton DpadUp = 0;
	public const GamepadButton DpadDown = 1;
	public const GamepadButton DpadLeft = 2;
	public const GamepadButton DpadRight = 3;
	public const GamepadButton North = 4;
	public const GamepadButton East = 5;
	public const GamepadButton South = 6;
	public const GamepadButton West = 7;
	public const GamepadButton LeftStick = 8;
	public const GamepadButton RightStick = 9;
	public const GamepadButton LeftShoulder = 10;
	public const GamepadButton RightShoulder = 11;
	public const GamepadButton Start = 12;
	public const GamepadButton Select = 13;
	public const GamepadButton LeftTrigger = 32;
	public const GamepadButton RightTrigger = 33;
	public const GamepadButton X = 7;
	public const GamepadButton Y = 4;
	public const GamepadButton A = 6;
	public const GamepadButton B = 5;
	public const GamepadButton Cross = 6;
	public const GamepadButton Square = 7;
	public const GamepadButton Triangle = 4;
	public const GamepadButton Circle = 5;
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct DualMotorRumbleCommand
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	public float lowFrequencyMotorSpeed; // 0x18
	public float highFrequencyMotorSpeed; // 0x1C

	// Methods

	// RVA: 0x146071C
	public static FourCC get_Type() { }

	// RVA: 0x1460758
	public FourCC get_typeStatic() { }

	// RVA: 0x1460794
	public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface ICustomDeviceReset
{
	// Methods

	// RVA: -1
	public abstract void Reset() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface IEventMerger
{
	// Methods

	// RVA: -1
	public abstract bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface IEventPreProcessor
{
	// Methods

	// RVA: -1
	public abstract bool PreProcessEvent(InputEventPtr currentEventPtr) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputUpdateCallbackReceiver
{
	// Methods

	// RVA: -1
	public abstract void OnUpdate() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface ITextInputReceiver
{
	// Methods

	// RVA: -1
	public abstract void OnTextInput(Char character) { }

	// RVA: -1
	public abstract void OnIMECompositionChanged(IMECompositionString compositionString) { }

}

// Namespace: 
public enum Button
{
	// Fields
	public int value__; // 0x10
	public const Button HatSwitchUp = 0;
	public const Button HatSwitchDown = 1;
	public const Button HatSwitchLeft = 2;
	public const Button HatSwitchRight = 3;
	public const Button Trigger = 4;
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct JoystickState
{
	// Fields
	public int buttons; // 0x10
	public Vector2 stick; // 0x14

	// Methods

	// RVA: 0x1460804
	public static FourCC get_kFormat() { }

	// RVA: 0x1460840
	public FourCC get_format() { }

}

// Namespace: 
public struct <keys>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct KeyboardState
{
	// Fields
	private const int kSizeInBits = 110;
	internal const int kSizeInBytes = 14;
	public UnityEngine.InputSystem.LowLevel.KeyboardState.<keys>e__FixedBuffer keys; // 0x10

	// Methods

	// RVA: 0x146087C
	public static FourCC get_Format() { }

	// RVA: 0x14608B8
	public void .ctor(Key[] pressedKeys) { }

	// RVA: 0x1460970
	public void Set(Key key, bool state) { }

	// RVA: 0x1460978
	public void Press(Key key) { }

	// RVA: 0x1460984
	public void Release(Key key) { }

	// RVA: 0x1460990
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct MouseState
{
	// Fields
	public Vector2 position; // 0x10
	public Vector2 delta; // 0x18
	public Vector2 scroll; // 0x20
	public UInt16 buttons; // 0x28
	public UInt16 displayIndex; // 0x2A
	public UInt16 clickCount; // 0x2C

	// Methods

	// RVA: 0x14609CC
	public static FourCC get_Format() { }

	// RVA: 0x1460A08
	public MouseState WithButton(MouseButton button, bool state) { }

	// RVA: 0x1460A3C
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public enum MouseButton
{
	// Fields
	public int value__; // 0x10
	public const MouseButton Left = 0;
	public const MouseButton Right = 1;
	public const MouseButton Middle = 2;
	public const MouseButton Forward = 3;
	public const MouseButton Back = 4;
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct PenState
{
	// Fields
	public Vector2 position; // 0x10
	public Vector2 delta; // 0x18
	public Vector2 tilt; // 0x20
	public float pressure; // 0x28
	public float twist; // 0x2C
	public UInt16 buttons; // 0x30
	private UInt16 displayIndex; // 0x32

	// Methods

	// RVA: 0x1460A78
	public static FourCC get_Format() { }

	// RVA: 0x1460AB4
	public PenState WithButton(PenButton button, bool state) { }

	// RVA: 0x1460AE8
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct PointerState
{
	// Fields
	private UInt32 pointerId; // 0x10
	public Vector2 position; // 0x14
	public Vector2 delta; // 0x1C
	public float pressure; // 0x24
	public Vector2 radius; // 0x28
	public UInt16 buttons; // 0x30
	public UInt16 displayIndex; // 0x32

	// Methods

	// RVA: 0x1460B24
	public static FourCC get_kFormat() { }

	// RVA: 0x1460B60
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AccelerometerState
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x1460B9C
	public static FourCC get_kFormat() { }

	// RVA: 0x1460BD8
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GyroscopeState
{
	// Fields
	public Vector3 angularVelocity; // 0x10

	// Methods

	// RVA: 0x1460C14
	public static FourCC get_kFormat() { }

	// RVA: 0x1460C50
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GravityState
{
	// Fields
	public Vector3 gravity; // 0x10

	// Methods

	// RVA: 0x1460C8C
	public static FourCC get_kFormat() { }

	// RVA: 0x1460CC8
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AttitudeState
{
	// Fields
	public Quaternion attitude; // 0x10

	// Methods

	// RVA: 0x1460D04
	public static FourCC get_kFormat() { }

	// RVA: 0x1460D40
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct LinearAccelerationState
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x1460D7C
	public static FourCC get_kFormat() { }

	// RVA: 0x1460DB8
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal enum TouchFlags
{
	// Fields
	public Byte value__; // 0x10
	public const TouchFlags IndirectTouch = 1;
	public const TouchFlags PrimaryTouch = 8;
	public const TouchFlags TapPress = 16;
	public const TouchFlags TapRelease = 32;
	public const TouchFlags OrphanedPrimaryTouch = 64;
	public const TouchFlags BeganInSameFrame = 128;
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct TouchState
{
	// Fields
	internal const int kSizeInBytes = 56;
	public int touchId; // 0x10
	public Vector2 position; // 0x14
	public Vector2 delta; // 0x1C
	public float pressure; // 0x24
	public Vector2 radius; // 0x28
	public Byte phaseId; // 0x30
	public Byte tapCount; // 0x31
	public Byte displayIndex; // 0x32
	public Byte flags; // 0x33
	internal UInt32 updateStepCount; // 0x34
	public Double startTime; // 0x38
	public Vector2 startPosition; // 0x40

	// Methods

	// RVA: 0x1460DF4
	public static FourCC get_Format() { }

	// RVA: 0x1460E30
	public TouchPhase get_phase() { }

	// RVA: 0x1460E38
	public void set_phase(TouchPhase value) { }

	// RVA: 0x1460E40
	public bool get_isNoneEndedOrCanceled() { }

	// RVA: 0x1460E5C
	public bool get_isInProgress() { }

	// RVA: 0x1460E78
	public bool get_isPrimaryTouch() { }

	// RVA: 0x1460E84
	public void set_isPrimaryTouch(bool value) { }

	// RVA: 0x1460EA4
	internal bool get_isOrphanedPrimaryTouch() { }

	// RVA: 0x1460EB0
	internal void set_isOrphanedPrimaryTouch(bool value) { }

	// RVA: 0x1460ED0
	public bool get_isIndirectTouch() { }

	// RVA: 0x1460EDC
	public void set_isIndirectTouch(bool value) { }

	// RVA: 0x1460EF0
	public bool get_isTap() { }

	// RVA: 0x1460F08
	public void set_isTap(bool value) { }

	// RVA: 0x1460EFC
	internal bool get_isTapPress() { }

	// RVA: 0x1460F28
	internal void set_isTapPress(bool value) { }

	// RVA: 0x1460F48
	internal bool get_isTapRelease() { }

	// RVA: 0x1460F54
	internal void set_isTapRelease(bool value) { }

	// RVA: 0x1460F74
	internal bool get_beganInSameFrame() { }

	// RVA: 0x1460F80
	internal void set_beganInSameFrame(bool value) { }

	// RVA: 0x1460F9C
	public FourCC get_format() { }

	// RVA: 0x1460FD8
	public override string ToString() { }

}

// Namespace: 
public struct <primaryTouchData>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <touchData>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct TouchscreenState
{
	// Fields
	public const int MaxTouches = 10;
	public UnityEngine.InputSystem.LowLevel.TouchscreenState.<primaryTouchData>e__FixedBuffer primaryTouchData; // 0x10
	internal const int kTouchDataOffset = 56;
	public UnityEngine.InputSystem.LowLevel.TouchscreenState.<touchData>e__FixedBuffer touchData; // 0x48

	// Methods

	// RVA: 0x14612F8
	public static FourCC get_Format() { }

	// RVA: 0x1461334
	public TouchState* get_primaryTouch() { }

	// RVA: 0x1461338
	public TouchState* get_touches() { }

	// RVA: 0x1461340
	public FourCC get_format() { }

}

// Namespace: 
public struct <m_ValueData>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct ActionEvent
{
	// Fields
	public InputEvent baseEvent; // 0x10
	private UInt16 m_ControlIndex; // 0x24
	private UInt16 m_BindingIndex; // 0x26
	private UInt16 m_InteractionIndex; // 0x28
	private Byte m_StateIndex; // 0x2A
	private Byte m_Phase; // 0x2B
	private Double m_StartTime; // 0x2C
	public UnityEngine.InputSystem.LowLevel.ActionEvent.<m_ValueData>e__FixedBuffer m_ValueData; // 0x34

	// Methods

	// RVA: 0x146137C
	public static FourCC get_Type() { }

	// RVA: 0x14613B8
	public Double get_startTime() { }

	// RVA: 0x14613C0
	public void set_startTime(Double value) { }

	// RVA: 0x14613C8
	public InputActionPhase get_phase() { }

	// RVA: 0x14613D0
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x14613D8
	public Byte* get_valueData() { }

	// RVA: 0x14613E0
	public int get_valueSizeInBytes() { }

	// RVA: 0x14613F4
	public int get_stateIndex() { }

	// RVA: 0x14613FC
	public void set_stateIndex(int value) { }

	// RVA: 0x1461468
	public int get_controlIndex() { }

	// RVA: 0x1461470
	public void set_controlIndex(int value) { }

	// RVA: 0x14614DC
	public int get_bindingIndex() { }

	// RVA: 0x14614E4
	public void set_bindingIndex(int value) { }

	// RVA: 0x1461550
	public int get_interactionIndex() { }

	// RVA: 0x1461564
	public void set_interactionIndex(int value) { }

	// RVA: 0x14615E0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x14615E4
	public FourCC get_typeStatic() { }

	// RVA: 0x1461620
	public static int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	// RVA: 0x1461628
	public static ActionEvent* From(InputEventPtr ptr) { }

}

// Namespace: 
public struct <stateData>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeltaStateEvent
{
	// Fields
	public const int Type = 1145852993;
	public InputEvent baseEvent; // 0x10
	public FourCC stateFormat; // 0x24
	public UInt32 stateOffset; // 0x28
	internal UnityEngine.InputSystem.LowLevel.DeltaStateEvent.<stateData>e__FixedBuffer stateData; // 0x2C

	// Methods

	// RVA: 0x1461784
	public UInt32 get_deltaStateSizeInBytes() { }

	// RVA: 0x1461790
	public Void* get_deltaState() { }

	// RVA: 0x1461798
	public FourCC get_typeStatic() { }

	// RVA: 0x14617A4
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x14617A8
	public static DeltaStateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x14618DC
	internal static DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x14618E0
	public static Unity.Collections.NativeArray<System.Byte> From(InputControl control, InputEventPtr eventPtr, Allocator allocator) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceConfigurationEvent
{
	// Fields
	public const int Type = 1145259591;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x1461E80
	public FourCC get_typeStatic() { }

	// RVA: 0x1461E8C
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1461E90
	public static DeviceConfigurationEvent Create(int deviceId, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceRemoveEvent
{
	// Fields
	public const int Type = 1146242381;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x1461F9C
	public FourCC get_typeStatic() { }

	// RVA: 0x1461FA8
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1461FAC
	public static DeviceRemoveEvent Create(int deviceId, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceResetEvent
{
	// Fields
	public const int Type = 1146245972;
	public InputEvent baseEvent; // 0x10
	public bool hardReset; // 0x18

	// Methods

	// RVA: 0x14620B8
	public FourCC get_typeStatic() { }

	// RVA: 0x14620C4
	public static DeviceResetEvent Create(int deviceId, bool hardReset, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputEventTypeInfo
{
	// Methods

	// RVA: -1
	public abstract FourCC get_typeStatic() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct IMECompositionEvent
{
	// Fields
	internal const int kIMECharBufferSize = 64;
	public const int Type = 1229800787;
	public InputEvent baseEvent; // 0x10
	public IMECompositionString compositionString; // 0x24

	// Methods

	// RVA: 0x14621EC
	public FourCC get_typeStatic() { }

	// RVA: 0x14621F8
	public static IMECompositionEvent Create(int deviceId, string compositionString, Double time) { }

}

// Namespace: 
internal struct Enumerator
{
	// Fields
	private IMECompositionString m_CompositionString; // 0x10
	private Char m_CurrentCharacter; // 0x94
	private int m_CurrentIndex; // 0x98

	// Methods

	// RVA: 0x14625D4
	public void .ctor(IMECompositionString compositionString) { }

	// RVA: 0x14626C0
	public bool MoveNext() { }

	// RVA: 0x14626F0
	public void Reset() { }

	// RVA: 0x14626FC
	public void Dispose() { }

	// RVA: 0x1462700
	public Char get_Current() { }

	// RVA: 0x1462708
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct <buffer>e__FixedBuffer
{
	// Fields
	public Char FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct IMECompositionString
{
	// Fields
	private int size; // 0x10
	private UnityEngine.InputSystem.LowLevel.IMECompositionString.<buffer>e__FixedBuffer buffer; // 0x14

	// Methods

	// RVA: 0x1462480
	public int get_Count() { }

	// RVA: 0x1462488
	public Char get_Item(int index) { }

	// RVA: 0x14623F0
	public void .ctor(string characters) { }

	// RVA: 0x1462500
	public override string ToString() { }

	// RVA: 0x1462518
	public System.Collections.Generic.IEnumerator<System.Char> GetEnumerator() { }

	// RVA: 0x1462604
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEvent
{
	// Fields
	private const UInt32 kHandledMask = 2147483648;
	private const UInt32 kIdMask = 2147483647;
	internal const int kBaseEventSize = 20;
	public const int InvalidEventId = 0;
	internal const int kAlignment = 4;
	private NativeInputEvent m_Event; // 0x10

	// Methods

	// RVA: 0x1462770
	public FourCC get_type() { }

	// RVA: 0x1462778
	public void set_type(FourCC value) { }

	// RVA: 0x14613EC
	public UInt32 get_sizeInBytes() { }

	// RVA: 0x1462780
	public void set_sizeInBytes(UInt32 value) { }

	// RVA: 0x146282C
	public int get_eventId() { }

	// RVA: 0x1462838
	public void set_eventId(int value) { }

	// RVA: 0x146284C
	public int get_deviceId() { }

	// RVA: 0x1462854
	public void set_deviceId(int value) { }

	// RVA: 0x146285C
	public Double get_time() { }

	// RVA: 0x14628BC
	public void set_time(Double value) { }

	// RVA: 0x1462928
	internal Double get_internalTime() { }

	// RVA: 0x1462930
	internal void set_internalTime(Double value) { }

	// RVA: 0x1461D70
	public void .ctor(FourCC type, int sizeInBytes, int deviceId, Double time) { }

	// RVA: 0x1462938
	public bool get_handled() { }

	// RVA: 0x1462944
	public void set_handled(bool value) { }

	// RVA: 0x1462960
	public override string ToString() { }

	// RVA: 0x1462C0C
	internal static InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	// RVA: 0x1462C28
	internal static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, InputEventBuffer buffer) { }

	// RVA: 0x1462E00
	public static bool Equals(InputEvent* first, InputEvent* second) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly InputEvent* m_Buffer; // 0x10
	private readonly int m_EventCount; // 0x18
	private InputEvent* m_CurrentEvent; // 0x20
	private int m_CurrentIndex; // 0x28

	// Methods

	// RVA: 0x1463730
	public void .ctor(InputEventBuffer buffer) { }

	// RVA: 0x1463A0C
	public bool MoveNext() { }

	// RVA: 0x1463A7C
	public void Reset() { }

	// RVA: 0x1463A88
	public void Dispose() { }

	// RVA: 0x1463A8C
	public InputEventPtr get_Current() { }

	// RVA: 0x1463A94
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventBuffer
{
	// Fields
	public const Int64 BufferSizeUnknown = 18446744073709551615;
	private Unity.Collections.NativeArray<System.Byte> m_Buffer; // 0x10
	private Int64 m_SizeInBytes; // 0x20
	private int m_EventCount; // 0x28
	private bool m_WeOwnTheBuffer; // 0x2C

	// Methods

	// RVA: 0x1462E64
	public int get_eventCount() { }

	// RVA: 0x1462E6C
	public Int64 get_sizeInBytes() { }

	// RVA: 0x1462E74
	public Int64 get_capacityInBytes() { }

	// RVA: 0x1462ECC
	public Unity.Collections.NativeArray<System.Byte> get_data() { }

	// RVA: 0x1462ED8
	public InputEventPtr get_bufferPtr() { }

	// RVA: 0x1462F30
	public void .ctor(InputEvent* eventPtr, int eventCount, int sizeInBytes, int capacityInBytes) { }

	// RVA: 0x14630F4
	public void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, int eventCount, int sizeInBytes, bool transferNativeArrayOwnership) { }

	// RVA: 0x1463230
	public void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x14632B0
	public InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x1462D68
	public bool Contains(InputEvent* eventPtr) { }

	// RVA: 0x146359C
	public void Reset() { }

	// RVA: 0x14635B4
	internal void AdvanceToNextEvent(InputEvent* currentReadPos, InputEvent* currentWritePos, int numEventsRetainedInBuffer, int numRemainingEvents, bool leaveEventInBuffer) { }

	// RVA: 0x1463674
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x14637A0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x146385C
	public void Dispose() { }

	// RVA: 0x14638C0
	public InputEventBuffer Clone() { }

	// RVA: 0x146399C
	private object System.ICloneable.Clone() { }

}

// Namespace: 
internal class ObserverState
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers; // 0x10
	public System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28

	// Methods

	// RVA: 0x1464004
	public void .ctor() { }

	// RVA: 0x14640A0
	private void <.ctor>b__2_0(InputEventPtr eventPtr, InputDevice device) { }

}

// Namespace: 
private class DisposableObserver
{
	// Fields
	public System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer; // 0x10

	// Methods

	// RVA: 0x14641B4
	public void Dispose() { }

	// RVA: 0x1464098
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventListener
{
	// Fields
	internal static ObserverState s_ObserverState; // 0x0

	// Methods

	// RVA: 0x1463AFC
	public static InputEventListener op_Addition(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x1463C84
	public static InputEventListener op_Subtraction(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x1463E0C
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventPtr
{
	// Fields
	private readonly InputEvent* m_EventPtr; // 0x10

	// Methods

	// RVA: 0x146430C
	public void .ctor(InputEvent* eventPtr) { }

	// RVA: 0x146175C
	public bool get_valid() { }

	// RVA: 0x1464314
	public bool get_handled() { }

	// RVA: 0x1464330
	public void set_handled(bool value) { }

	// RVA: 0x14643B0
	public int get_id() { }

	// RVA: 0x14643CC
	public void set_id(int value) { }

	// RVA: 0x146176C
	public FourCC get_type() { }

	// RVA: 0x1464444
	public UInt32 get_sizeInBytes() { }

	// RVA: 0x146445C
	public int get_deviceId() { }

	// RVA: 0x1464474
	public void set_deviceId(int value) { }

	// RVA: 0x14644E0
	public Double get_time() { }

	// RVA: 0x1464558
	public void set_time(Double value) { }

	// RVA: 0x1464610
	internal Double get_internalTime() { }

	// RVA: 0x1464628
	internal void set_internalTime(Double value) { }

	// RVA: 0x1464694
	public InputEvent* get_data() { }

	// RVA: 0x146469C
	internal FourCC get_stateFormat() { }

	// RVA: 0x1464804
	internal UInt32 get_stateSizeInBytes() { }

	// RVA: 0x1464A58
	internal UInt32 get_stateOffset() { }

	// RVA: 0x30B171C
	public bool IsA() { }

	// RVA: 0x1464B38
	public InputEventPtr Next() { }

	// RVA: 0x1464750
	public override string ToString() { }

	// RVA: 0x1464B64
	public InputEvent* ToPointer() { }

	// RVA: 0x1464B6C
	public bool Equals(InputEventPtr other) { }

	// RVA: 0x1464BDC
	public override bool Equals(object obj) { }

	// RVA: 0x1464CC4
	public override int GetHashCode() { }

	// RVA: 0x1464CCC
	public static bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x1464CD8
	public static bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x1462F2C
	public static InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	// RVA: 0x1464CE4
	public static InputEventPtr From(InputEvent* eventPtr) { }

	// RVA: 0x1463A08
	public static InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	// RVA: 0x1464CE8
	public static InputEvent* FromInputEventPtr(InputEventPtr eventPtr) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct InputEventStream
{
	// Fields
	private InputEventBuffer m_NativeBuffer; // 0x10
	private InputEvent* m_CurrentNativeEventReadPtr; // 0x30
	private InputEvent* m_CurrentNativeEventWritePtr; // 0x38
	private int m_RemainingNativeEventCount; // 0x40
	private readonly int m_MaxAppendedEvents; // 0x44
	private InputEventBuffer m_AppendBuffer; // 0x48
	private InputEvent* m_CurrentAppendEventReadPtr; // 0x68
	private InputEvent* m_CurrentAppendEventWritePtr; // 0x70
	private int m_RemainingAppendEventCount; // 0x78
	private int m_NumEventsRetainedInBuffer; // 0x7C
	private bool m_IsOpen; // 0x80

	// Methods

	// RVA: 0x1464CEC
	public bool get_isOpen() { }

	// RVA: 0x1464CF4
	public int get_remainingEventCount() { }

	// RVA: 0x1464D04
	public int get_numEventsRetainedInBuffer() { }

	// RVA: 0x1464D0C
	public InputEvent* get_currentEventPtr() { }

	// RVA: 0x1464D44
	public UInt32 get_numBytesRetainedInBuffer() { }

	// RVA: 0x1464DA4
	public void .ctor(InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	// RVA: 0x1464E3C
	public void Close(InputEventBuffer eventBuffer) { }

	// RVA: 0x1464FA0
	public void CleanUpAfterException() { }

	// RVA: 0x1465058
	public void Write(InputEvent* eventPtr) { }

	// RVA: 0x146523C
	public InputEvent* Advance(bool leaveEventInBuffer) { }

	// RVA: 0x1465378
	public InputEvent* Peek() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private InputEventTrace m_Trace; // 0x10
	private int m_ChangeCounter; // 0x18
	internal InputEventPtr m_Current; // 0x20

	// Methods

	// RVA: 0x14674D8
	public void .ctor(InputEventTrace trace) { }

	// RVA: 0x1467E70
	public void Dispose() { }

	// RVA: 0x1467EA0
	public bool MoveNext() { }

	// RVA: 0x1467FDC
	public void Reset() { }

	// RVA: 0x1468004
	public InputEventPtr get_Current() { }

	// RVA: 0x146800C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private enum FileFlags
{
	// Fields
	public int value__; // 0x10
	public const FileFlags FixedUpdate = 1;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.InputSystem.LowLevel.InputEventPtr> <>9__38_0; // 0x8

	// Methods

	// RVA: 0x1469AF8
	private static void .cctor() { }

	// RVA: 0x1469B64
	public void .ctor() { }

	// RVA: 0x1469B6C
	internal int <PlayAllEventsAccordingToTimestamps>b__38_0(InputEventPtr a, InputEventPtr b) { }

}

// Namespace: 
private sealed class <>c__DisplayClass43_0
{
	// Fields
	public int originalDeviceId; // 0x10

	// Methods

	// RVA: 0x1469AF0
	public void .ctor() { }

	// RVA: 0x1469C34
	internal bool <ApplyDeviceMapping>b__0(DeviceInfo x) { }

}

// Namespace: 
public class ReplayController
{
	// Fields
	private bool <finished>k__BackingField; // 0x10
	private bool <paused>k__BackingField; // 0x11
	private int <position>k__BackingField; // 0x14
	private InputEventTrace m_EventTrace; // 0x18
	private Enumerator m_Enumerator; // 0x20
	private UnityEngine.InputSystem.Utilities.InlinedArray<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> m_DeviceIDMappings; // 0x28
	private bool m_CreateNewDevices; // 0x40
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputDevice> m_CreatedDevices; // 0x48
	private Action m_OnFinished; // 0x60
	private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_OnEvent; // 0x68
	private Double m_StartTimeAsPerFirstEvent; // 0x70
	private Double m_StartTimeAsPerRuntime; // 0x78
	private int m_AllEventsByTimeIndex; // 0x80
	private System.Collections.Generic.List<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_AllEventsByTime; // 0x88

	// Methods

	// RVA: 0x1468074
	public InputEventTrace get_trace() { }

	// RVA: 0x146807C
	public bool get_finished() { }

	// RVA: 0x1468084
	private void set_finished(bool value) { }

	// RVA: 0x146808C
	public bool get_paused() { }

	// RVA: 0x1468094
	public void set_paused(bool value) { }

	// RVA: 0x146809C
	public int get_position() { }

	// RVA: 0x14680A4
	private void set_position(int value) { }

	// RVA: 0x14680AC
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices() { }

	// RVA: 0x1466F80
	internal void .ctor(InputEventTrace trace) { }

	// RVA: 0x146811C
	public void Dispose() { }

	// RVA: 0x1468420
	public ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice) { }

	// RVA: 0x14684B0
	public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) { }

	// RVA: 0x14686EC
	public ReplayController WithAllDevicesMappedToNewInstances() { }

	// RVA: 0x14686F8
	public ReplayController OnFinished(Action action) { }

	// RVA: 0x1468720
	public ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action) { }

	// RVA: 0x1468748
	public ReplayController PlayOneEvent() { }

	// RVA: 0x1468DAC
	public ReplayController Rewind() { }

	// RVA: 0x1468DF4
	public ReplayController PlayAllFramesOneByOne() { }

	// RVA: 0x1468EB0
	public ReplayController PlayAllEvents() { }

	// RVA: 0x1468F60
	public ReplayController PlayAllEventsAccordingToTimestamps() { }

	// RVA: 0x14691FC
	private void OnBeginFrame() { }

	// RVA: 0x14694D4
	private void Finished() { }

	// RVA: 0x1468B74
	private void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x14687D8
	private bool MoveNext(bool skipFrameEvents, InputEventPtr eventPtr) { }

	// RVA: 0x14695CC
	private int ApplyDeviceMapping(int originalDeviceId) { }

}

// Namespace: 
[Serializable]
public struct DeviceInfo
{
	// Fields
	internal int m_DeviceId; // 0x10
	internal string m_Layout; // 0x18
	internal FourCC m_StateFormat; // 0x20
	internal int m_StateSizeInBytes; // 0x24
	internal string m_FullLayoutJson; // 0x28

	// Methods

	// RVA: 0x1469C48
	public int get_deviceId() { }

	// RVA: 0x1469C50
	public void set_deviceId(int value) { }

	// RVA: 0x1469C58
	public string get_layout() { }

	// RVA: 0x1469C60
	public void set_layout(string value) { }

	// RVA: 0x1469C68
	public FourCC get_stateFormat() { }

	// RVA: 0x1469C70
	public void set_stateFormat(FourCC value) { }

	// RVA: 0x1469C78
	public int get_stateSizeInBytes() { }

	// RVA: 0x1469C80
	public void set_stateSizeInBytes(int value) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
[Serializable]
public sealed class InputEventTrace
{
	// Fields
	private const int kDefaultBufferSize = 1048576;
	private int m_ChangeCounter; // 0x10
	private bool m_Enabled; // 0x14
	private System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> m_OnFilterEvent; // 0x18
	private int m_DeviceId; // 0x20
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_EventListeners; // 0x28
	private Int64 m_EventBufferSize; // 0x78
	private Int64 m_MaxEventBufferSize; // 0x80
	private Int64 m_GrowIncrementSize; // 0x88
	private Int64 m_EventCount; // 0x90
	private Int64 m_EventSizeInBytes; // 0x98
	private UInt64 m_EventBufferStorage; // 0xA0
	private UInt64 m_EventBufferHeadStorage; // 0xA8
	private UInt64 m_EventBufferTailStorage; // 0xB0
	private bool m_HasWrapped; // 0xB8
	private bool m_RecordFrameMarkers; // 0xB9
	private DeviceInfo[] m_DeviceInfos; // 0xC0
	private static int kFileVersion; // 0x0

	// Methods

	// RVA: 0x14653D8
	public static FourCC get_FrameMarkerEvent() { }

	// RVA: 0x1465414
	public int get_deviceId() { }

	// RVA: 0x146541C
	public void set_deviceId(int value) { }

	// RVA: 0x1465424
	public bool get_enabled() { }

	// RVA: 0x146542C
	public bool get_recordFrameMarkers() { }

	// RVA: 0x1465434
	public void set_recordFrameMarkers(bool value) { }

	// RVA: 0x146555C
	public Int64 get_eventCount() { }

	// RVA: 0x1465564
	public Int64 get_totalEventSizeInBytes() { }

	// RVA: 0x146556C
	public Int64 get_allocatedSizeInBytes() { }

	// RVA: 0x146558C
	public Int64 get_maxSizeInBytes() { }

	// RVA: 0x1465594
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos() { }

	// RVA: 0x14655E8
	public System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> get_onFilterEvent() { }

	// RVA: 0x14655F0
	public void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> value) { }

	// RVA: 0x14655F8
	public void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1465654
	public void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x14656B0
	public void .ctor(InputDevice device, Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x1465788
	public void .ctor(Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x1465824
	public void WriteTo(string filePath) { }

	// RVA: 0x14659B0
	public void WriteTo(Stream stream) { }

	// RVA: 0x146618C
	public void ReadFrom(string filePath) { }

	// RVA: 0x1466318
	public void ReadFrom(Stream stream) { }

	// RVA: 0x1466B04
	public static InputEventTrace LoadFrom(string filePath) { }

	// RVA: 0x1466CC4
	public static InputEventTrace LoadFrom(Stream stream) { }

	// RVA: 0x1466DF4
	public ReplayController Replay() { }

	// RVA: 0x1467000
	public bool Resize(Int64 newBufferSize, Int64 newMaxBufferSize) { }

	// RVA: 0x14672F8
	public void Clear() { }

	// RVA: 0x1467318
	public void Enable() { }

	// RVA: 0x1466E60
	public void Disable() { }

	// RVA: 0x1467280
	public bool GetNextEvent(InputEventPtr current) { }

	// RVA: 0x1466108
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x1467520
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14675A4
	public void Dispose() { }

	// RVA: 0x1465584
	private Byte* get_m_EventBuffer() { }

	// RVA: 0x1466AEC
	private void set_m_EventBuffer(Byte* value) { }

	// RVA: 0x1467278
	private Byte* get_m_EventBufferHead() { }

	// RVA: 0x1466AF4
	private void set_m_EventBufferHead(Byte* value) { }

	// RVA: 0x14674D0
	private Byte* get_m_EventBufferTail() { }

	// RVA: 0x1466AFC
	private void set_m_EventBufferTail(Byte* value) { }

	// RVA: 0x146749C
	private void Allocate() { }

	// RVA: 0x1467604
	private void Release() { }

	// RVA: 0x1467660
	private void OnBeforeUpdate() { }

	// RVA: 0x146781C
	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	// RVA: 0x14660CC
	private static FourCC get_kFileFormat() { }

	// RVA: 0x1467E20
	private static void .cctor() { }

}

// Namespace: 
public struct <stateData>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct StateEvent
{
	// Fields
	public const int Type = 1398030676;
	internal const int kStateDataSizeToSubtract = 1;
	public InputEvent baseEvent; // 0x10
	public FourCC stateFormat; // 0x24
	internal UnityEngine.InputSystem.LowLevel.StateEvent.<stateData>e__FixedBuffer stateData; // 0x28

	// Methods

	// RVA: 0x1464A4C
	public UInt32 get_stateSizeInBytes() { }

	// RVA: 0x1469C88
	public Void* get_state() { }

	// RVA: 0x1469C90
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1469C94
	public FourCC get_typeStatic() { }

	// RVA: 0x316B894
	public TState GetState() { }

	// RVA: 0x316B894
	public static TState GetState(InputEventPtr ptr) { }

	// RVA: 0x30B44C8
	public static int GetEventSizeWithPayload() { }

	// RVA: 0x1464918
	public static StateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x146474C
	internal static StateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x1469CA0
	public static Unity.Collections.NativeArray<System.Byte> From(InputDevice device, InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x146A0C0
	public static Unity.Collections.NativeArray<System.Byte> FromDefaultStateFor(InputDevice device, InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x1469CA8
	private static Unity.Collections.NativeArray<System.Byte> From(InputDevice device, InputEventPtr eventPtr, Allocator allocator, bool useDefaultState) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct TextEvent
{
	// Fields
	public const int Type = 1413830740;
	public InputEvent baseEvent; // 0x10
	public int character; // 0x24

	// Methods

	// RVA: 0x146A0C8
	public FourCC get_typeStatic() { }

	// RVA: 0x146A0D4
	public static TextEvent* From(InputEventPtr eventPtr) { }

	// RVA: 0x146A208
	public static TextEvent Create(int deviceId, Char character, Double time) { }

	// RVA: 0x146A318
	public static TextEvent Create(int deviceId, int character, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal sealed class InputUpdateDelegate
{
	// Methods

	// RVA: 0x146A428
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x146A4CC
	public virtual void Invoke(InputUpdateType updateType, InputEventBuffer eventBuffer) { }

	// RVA: 0x146A4E0
	public virtual IAsyncResult BeginInvoke(InputUpdateType updateType, InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	// RVA: 0x146A5CC
	public virtual void EndInvoke(InputEventBuffer eventBuffer, IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface IInputRuntime
{
	// Methods

	// RVA: -1
	public abstract int AllocateDeviceId() { }

	// RVA: -1
	public abstract void Update(InputUpdateType type) { }

	// RVA: -1
	public abstract void QueueEvent(InputEvent* ptr) { }

	// RVA: -1
	public abstract Int64 DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: -1
	public abstract InputUpdateDelegate get_onUpdate() { }

	// RVA: -1
	public abstract void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: -1
	public abstract System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }

	// RVA: -1
	public abstract void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }

	// RVA: -1
	public abstract System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }

	// RVA: -1
	public abstract void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }

	// RVA: -1
	public abstract System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: -1
	public abstract void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: -1
	public abstract System.Action<System.Boolean> get_onPlayerFocusChanged() { }

	// RVA: -1
	public abstract void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }

	// RVA: -1
	public abstract bool get_isPlayerFocused() { }

	// RVA: -1
	public abstract Action get_onShutdown() { }

	// RVA: -1
	public abstract void set_onShutdown(Action value) { }

	// RVA: -1
	public abstract float get_pollingFrequency() { }

	// RVA: -1
	public abstract void set_pollingFrequency(float value) { }

	// RVA: -1
	public abstract Double get_currentTime() { }

	// RVA: -1
	public abstract Double get_currentTimeForFixedUpdate() { }

	// RVA: -1
	public abstract float get_unscaledGameTime() { }

	// RVA: -1
	public abstract Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: -1
	public abstract bool get_runInBackground() { }

	// RVA: -1
	public abstract void set_runInBackground(bool value) { }

	// RVA: -1
	public abstract Vector2 get_screenSize() { }

	// RVA: -1
	public abstract ScreenOrientation get_screenOrientation() { }

	// RVA: -1
	public abstract bool get_isInBatchMode() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal static class InputRuntime
{
	// Fields
	public static IInputRuntime s_Instance; // 0x0
	public static Double s_CurrentTimeOffsetToRealtimeSinceStartup; // 0x8
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal static class InputRuntimeExtensions
{
	// Methods

	// RVA: 0x316B894
	public static Int64 DeviceCommand(IInputRuntime runtime, int deviceId, TCommand command) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
[Serializable]
public struct InputMetrics
{
	// Fields
	private int <maxNumDevices>k__BackingField; // 0x10
	private int <currentNumDevices>k__BackingField; // 0x14
	private int <maxStateSizeInBytes>k__BackingField; // 0x18
	private int <currentStateSizeInBytes>k__BackingField; // 0x1C
	private int <currentControlCount>k__BackingField; // 0x20
	private int <currentLayoutCount>k__BackingField; // 0x24
	private int <totalEventBytes>k__BackingField; // 0x28
	private int <totalEventCount>k__BackingField; // 0x2C
	private int <totalUpdateCount>k__BackingField; // 0x30
	private Double <totalEventProcessingTime>k__BackingField; // 0x38
	private Double <totalEventLagTime>k__BackingField; // 0x40

	// Methods

	// RVA: 0x146A620
	public int get_maxNumDevices() { }

	// RVA: 0x146A628
	public void set_maxNumDevices(int value) { }

	// RVA: 0x146A630
	public int get_currentNumDevices() { }

	// RVA: 0x146A638
	public void set_currentNumDevices(int value) { }

	// RVA: 0x146A640
	public int get_maxStateSizeInBytes() { }

	// RVA: 0x146A648
	public void set_maxStateSizeInBytes(int value) { }

	// RVA: 0x146A650
	public int get_currentStateSizeInBytes() { }

	// RVA: 0x146A658
	public void set_currentStateSizeInBytes(int value) { }

	// RVA: 0x146A660
	public int get_currentControlCount() { }

	// RVA: 0x146A668
	public void set_currentControlCount(int value) { }

	// RVA: 0x146A670
	public int get_currentLayoutCount() { }

	// RVA: 0x146A678
	public void set_currentLayoutCount(int value) { }

	// RVA: 0x146A680
	public int get_totalEventBytes() { }

	// RVA: 0x146A688
	public void set_totalEventBytes(int value) { }

	// RVA: 0x146A690
	public int get_totalEventCount() { }

	// RVA: 0x146A698
	public void set_totalEventCount(int value) { }

	// RVA: 0x146A6A0
	public int get_totalUpdateCount() { }

	// RVA: 0x146A6A8
	public void set_totalUpdateCount(int value) { }

	// RVA: 0x146A6B0
	public Double get_totalEventProcessingTime() { }

	// RVA: 0x146A6B8
	public void set_totalEventProcessingTime(Double value) { }

	// RVA: 0x146A6C0
	public Double get_totalEventLagTime() { }

	// RVA: 0x146A6C8
	public void set_totalEventLagTime(Double value) { }

	// RVA: 0x146A6D0
	public float get_averageEventBytesPerFrame() { }

	// RVA: 0x146A6E8
	public Double get_averageProcessingTimePerEvent() { }

	// RVA: 0x146A700
	public Double get_averageLagTimePerEvent() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public enum InputUpdateType
{
	// Fields
	public int value__; // 0x10
	public const InputUpdateType None = 0;
	public const InputUpdateType Dynamic = 1;
	public const InputUpdateType Fixed = 2;
	public const InputUpdateType BeforeRender = 4;
	public const InputUpdateType Editor = 8;
	public const InputUpdateType Manual = 16;
	public const InputUpdateType Default = 11;
}

// Namespace: 
[Serializable]
public struct UpdateStepCount
{
	// Fields
	private bool m_WasUpdated; // 0x10
	private UInt32 <value>k__BackingField; // 0x14

	// Methods

	// RVA: 0x146A9AC
	public UInt32 get_value() { }

	// RVA: 0x146A9B4
	private void set_value(UInt32 value) { }

	// RVA: 0x146A7A4
	public void OnBeforeUpdate() { }

	// RVA: 0x146A850
	public void OnUpdate() { }

}

// Namespace: 
[Serializable]
public struct SerializedState
{
	// Fields
	public InputUpdateType lastUpdateType; // 0x10
	public UpdateStepCount playerUpdateStepCount; // 0x14
}

// Namespace: UnityEngine.InputSystem.LowLevel
internal static class InputUpdate
{
	// Fields
	public static UInt32 s_UpdateStepCount; // 0x0
	public static InputUpdateType s_LatestUpdateType; // 0x4
	public static UpdateStepCount s_PlayerUpdateStepCount; // 0x8

	// Methods

	// RVA: 0x146A718
	internal static void OnBeforeUpdate(InputUpdateType type) { }

	// RVA: 0x146A7BC
	internal static void OnUpdate(InputUpdateType type) { }

	// RVA: 0x146A874
	public static SerializedState Save() { }

	// RVA: 0x146A8DC
	public static void Restore(SerializedState state) { }

	// RVA: 0x146A984
	public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	// RVA: 0x146A9A0
	public static bool IsPlayerUpdate(InputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value; // 0x10

	// Methods

	// RVA: 0x146AEB4
	public void .ctor() { }

	// RVA: 0x146B830
	internal void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value; // 0x10

	// Methods

	// RVA: 0x146B000
	public void .ctor() { }

	// RVA: 0x146B86C
	internal bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public InputUpdateDelegate value; // 0x10

	// Methods

	// RVA: 0x146AD68
	public void .ctor() { }

	// RVA: 0x146B8B0
	internal void <set_onUpdate>b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal class NativeInputRuntime
{
	// Fields
	public static readonly NativeInputRuntime instance; // 0x0
	private bool m_RunInBackground; // 0x10
	private Action m_ShutdownMethod; // 0x18
	private InputUpdateDelegate m_OnUpdate; // 0x20
	private System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> m_OnBeforeUpdate; // 0x28
	private System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> m_OnShouldRunUpdate; // 0x30
	private float m_PollingFrequency; // 0x38
	private bool m_DidCallOnShutdown; // 0x3C
	private System.Action<System.Boolean> m_FocusChangedMethod; // 0x40

	// Methods

	// RVA: 0x146A9BC
	public int AllocateDeviceId() { }

	// RVA: 0x146AA2C
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x146AAB4
	public void QueueEvent(InputEvent* ptr) { }

	// RVA: 0x146AB40
	public Int64 DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: 0x146AC2C
	public InputUpdateDelegate get_onUpdate() { }

	// RVA: 0x146AC34
	public void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: 0x146AD70
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }

	// RVA: 0x146AD78
	public void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }

	// RVA: 0x146AEBC
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }

	// RVA: 0x146AEC4
	public void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }

	// RVA: 0x146B008
	public System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x146B078
	public void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x146B100
	public Action get_onShutdown() { }

	// RVA: 0x146B108
	public void set_onShutdown(Action value) { }

	// RVA: 0x146B224
	public System.Action<System.Boolean> get_onPlayerFocusChanged() { }

	// RVA: 0x146B22C
	public void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x146B348
	public bool get_isPlayerFocused() { }

	// RVA: 0x146B3B8
	public float get_pollingFrequency() { }

	// RVA: 0x146B3C0
	public void set_pollingFrequency(float value) { }

	// RVA: 0x146B434
	public Double get_currentTime() { }

	// RVA: 0x146B4A4
	public Double get_currentTimeForFixedUpdate() { }

	// RVA: 0x146B518
	public Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x146B588
	public float get_unscaledGameTime() { }

	// RVA: 0x146B590
	public bool get_runInBackground() { }

	// RVA: 0x146B630
	public void set_runInBackground(bool value) { }

	// RVA: 0x146B638
	private void OnShutdown() { }

	// RVA: 0x146B660
	private bool OnWantsToShutdown() { }

	// RVA: 0x146B6BC
	private void OnFocusChanged(bool focus) { }

	// RVA: 0x146B6F8
	public Vector2 get_screenSize() { }

	// RVA: 0x146B72C
	public ScreenOrientation get_screenOrientation() { }

	// RVA: 0x146B734
	public bool get_isInBatchMode() { }

	// RVA: 0x146B7A4
	public void RegisterAnalyticsEvent(string name, int maxPerHour, int maxPropertiesPerEvent) { }

	// RVA: 0x146B7A8
	public void SendAnalyticsEvent(string name, object data) { }

	// RVA: 0x146B7AC
	public void .ctor() { }

	// RVA: 0x146B7BC
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputStateCallbackReceiver
{
	// Methods

	// RVA: -1
	public abstract void OnNextUpdate() { }

	// RVA: -1
	public abstract void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: -1
	public abstract bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputStateChangeMonitor
{
	// Methods

	// RVA: -1
	public abstract void NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: -1
	public abstract void NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputStateTypeInfo
{
	// Methods

	// RVA: -1
	public abstract FourCC get_format() { }

}

// Namespace: 
private class StateChangeMonitorDelegate
{
	// Fields
	public System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback; // 0x10
	public System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback; // 0x18

	// Methods

	// RVA: 0x146C75C
	public void NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x146C7A8
	public void NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x146C494
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public static class InputState
{
	// Methods

	// RVA: 0x146BAC0
	public static InputUpdateType get_currentUpdateType() { }

	// RVA: 0x146BB0C
	public static UInt32 get_updateCount() { }

	// RVA: 0x146BB58
	public static Double get_currentTime() { }

	// RVA: 0x146BC2C
	public static void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x146BCBC
	public static void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x146BD4C
	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType) { }

	// RVA: 0x316B894
	public static void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x316B894
	public static void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x146BFD4
	public static bool IsIntegerFormat(FourCC format) { }

	// RVA: 0x146C224
	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x146C394
	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback, int monitorIndex, System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback) { }

	// RVA: 0x146C49C
	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x146C594
	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x146C688
	public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, Int64 monitorIndex, int timerIndex) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputStateBlock
{
	// Fields
	public const UInt32 InvalidOffset = 4294967295;
	public const UInt32 AutomaticOffset = 4294967294;
	public static readonly FourCC FormatInvalid; // 0x0
	internal const int kFormatInvalid = 0;
	public static readonly FourCC FormatBit; // 0x4
	internal const int kFormatBit = 1112101920;
	public static readonly FourCC FormatSBit; // 0x8
	internal const int kFormatSBit = 1396853076;
	public static readonly FourCC FormatInt; // 0xC
	internal const int kFormatInt = 1229870112;
	public static readonly FourCC FormatUInt; // 0x10
	internal const int kFormatUInt = 1430867540;
	public static readonly FourCC FormatShort; // 0x14
	internal const int kFormatShort = 1397248596;
	public static readonly FourCC FormatUShort; // 0x18
	internal const int kFormatUShort = 1431521364;
	public static readonly FourCC FormatByte; // 0x1C
	internal const int kFormatByte = 1113150533;
	public static readonly FourCC FormatSByte; // 0x20
	internal const int kFormatSByte = 1396857172;
	public static readonly FourCC FormatLong; // 0x24
	internal const int kFormatLong = 1280198432;
	public static readonly FourCC FormatULong; // 0x28
	internal const int kFormatULong = 1431064135;
	public static readonly FourCC FormatFloat; // 0x2C
	internal const int kFormatFloat = 1179407392;
	public static readonly FourCC FormatDouble; // 0x30
	internal const int kFormatDouble = 1145195552;
	public static readonly FourCC FormatVector2; // 0x34
	internal const int kFormatVector2 = 1447379762;
	public static readonly FourCC FormatVector3; // 0x38
	internal const int kFormatVector3 = 1447379763;
	public static readonly FourCC FormatQuaternion; // 0x3C
	internal const int kFormatQuaternion = 1364541780;
	public static readonly FourCC FormatVector2Short; // 0x40
	public static readonly FourCC FormatVector3Short; // 0x44
	public static readonly FourCC FormatVector2Byte; // 0x48
	public static readonly FourCC FormatVector3Byte; // 0x4C
	public static readonly FourCC FormatPose; // 0x50
	internal const int kFormatPose = 1349481317;
	private FourCC <format>k__BackingField; // 0x10
	internal UInt32 m_ByteOffset; // 0x14
	private UInt32 <bitOffset>k__BackingField; // 0x18
	private UInt32 <sizeInBits>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x146C7F0
	public static int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	// RVA: 0x146CC4C
	public static FourCC GetPrimitiveFormatFromType(Type type) { }

	// RVA: 0x146D2CC
	public FourCC get_format() { }

	// RVA: 0x146D2D4
	public void set_format(FourCC value) { }

	// RVA: 0x146D2DC
	public UInt32 get_byteOffset() { }

	// RVA: 0x146D2E4
	public void set_byteOffset(UInt32 value) { }

	// RVA: 0x146D2EC
	public UInt32 get_bitOffset() { }

	// RVA: 0x146D2F4
	public void set_bitOffset(UInt32 value) { }

	// RVA: 0x146D2FC
	public UInt32 get_sizeInBits() { }

	// RVA: 0x146D304
	public void set_sizeInBits(UInt32 value) { }

	// RVA: 0x1461D08
	internal UInt32 get_alignedSizeInBytes() { }

	// RVA: 0x146D30C
	internal UInt32 get_effectiveByteOffset() { }

	// RVA: 0x146D394
	internal UInt32 get_effectiveBitOffset() { }

	// RVA: 0x146D41C
	public int ReadInt(Void* statePtr) { }

	// RVA: 0x146D754
	public void WriteInt(Void* statePtr, int value) { }

	// RVA: 0x146DA64
	public float ReadFloat(Void* statePtr) { }

	// RVA: 0x146DF08
	public void WriteFloat(Void* statePtr, float value) { }

	// RVA: 0x146E4DC
	internal PrimitiveValue FloatToPrimitiveValue(float value) { }

	// RVA: 0x146EAE0
	public Double ReadDouble(Void* statePtr) { }

	// RVA: 0x146EF94
	public void WriteDouble(Void* statePtr, Double value) { }

	// RVA: 0x146F580
	public void Write(Void* statePtr, PrimitiveValue value) { }

	// RVA: 0x146F99C
	public void CopyToFrom(Void* toStatePtr, Void* fromStatePtr) { }

	// RVA: 0x146FB08
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
internal struct DoubleBuffers
{
	// Fields
	public Void** deviceToBufferMapping; // 0x10

	// Methods

	// RVA: 0x1470A7C
	public bool get_valid() { }

	// RVA: 0x1470350
	public void SetFrontBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x1470360
	public void SetBackBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x1470054
	public Void* GetFrontBuffer(int deviceIndex) { }

	// RVA: 0x14700C8
	public Void* GetBackBuffer(int deviceIndex) { }

	// RVA: 0x1470A8C
	public void SwapBuffers(int deviceIndex) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct InputStateBuffers
{
	// Fields
	public UInt32 sizePerBuffer; // 0x10
	public UInt32 totalSize; // 0x14
	public Void* defaultStateBuffer; // 0x18
	public Void* noiseMaskBuffer; // 0x20
	public Void* resetMaskBuffer; // 0x28
	private Void* m_AllBuffers; // 0x30
	internal DoubleBuffers m_PlayerStateBuffers; // 0x38
	internal static Void* s_DefaultStateBuffer; // 0x0
	internal static Void* s_NoiseMaskBuffer; // 0x8
	internal static Void* s_ResetMaskBuffer; // 0x10
	internal static DoubleBuffers s_CurrentBuffers; // 0x18

	// Methods

	// RVA: 0x146FF1C
	public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	// RVA: 0x146FFF4
	public static Void* GetFrontBufferForDevice(int deviceIndex) { }

	// RVA: 0x1470064
	public static Void* GetBackBufferForDevice(int deviceIndex) { }

	// RVA: 0x14700DC
	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

	// RVA: 0x1470144
	public void AllocateAll(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x14702F4
	private static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, Byte* bufferPtr, UInt32 sizePerBuffer, UInt32 mappingTableSizePerBuffer) { }

	// RVA: 0x1470374
	public void FreeAll() { }

	// RVA: 0x1470474
	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	// RVA: 0x14705FC
	private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) { }

	// RVA: 0x14707D8
	private static void MigrateSingleBuffer(Void* newBuffer, InputDevice[] devices, int deviceCount, Void* oldBuffer) { }

	// RVA: 0x1470278
	private static UInt32 ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x147092C
	private static UInt32 NextDeviceOffset(UInt32 currentOffset, InputDevice device) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly InputStateHistory m_History; // 0x10
	private int m_Index; // 0x18

	// Methods

	// RVA: 0x147286C
	public void .ctor(InputStateHistory history) { }

	// RVA: 0x1473028
	public bool MoveNext() { }

	// RVA: 0x1473064
	public void Reset() { }

	// RVA: 0x1473070
	public Record get_Current() { }

	// RVA: 0x1473094
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1473104
	public void Dispose() { }

}

// Namespace: 
public struct <m_StateWithControlIndex>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <m_StateWithoutControlIndex>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
protected internal struct RecordHeader
{
	// Fields
	public Double time; // 0x10
	public UInt32 version; // 0x18
	public int controlIndex; // 0x1C
	private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithoutControlIndex>e__FixedBuffer m_StateWithoutControlIndex; // 0x1C
	private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithControlIndex>e__FixedBuffer m_StateWithControlIndex; // 0x20
	public const int kSizeWithControlIndex = 16;
	public const int kSizeWithoutControlIndex = 12;

	// Methods

	// RVA: 0x14727E4
	public Byte* get_statePtrWithControlIndex() { }

	// RVA: 0x14727DC
	public Byte* get_statePtrWithoutControlIndex() { }

}

// Namespace: 
public struct Record
{
	// Fields
	private readonly InputStateHistory m_Owner; // 0x10
	private readonly int m_IndexPlusOne; // 0x18
	private UInt32 m_Version; // 0x1C

	// Methods

	// RVA: 0x1473108
	internal RecordHeader* get_header() { }

	// RVA: 0x1473130
	internal int get_recordIndex() { }

	// RVA: 0x147313C
	internal UInt32 get_version() { }

	// RVA: 0x1473144
	public bool get_valid() { }

	// RVA: 0x14731A0
	public InputStateHistory get_owner() { }

	// RVA: 0x14731A8
	public int get_index() { }

	// RVA: 0x14732A4
	public Double get_time() { }

	// RVA: 0x14732E4
	public InputControl get_control() { }

	// RVA: 0x1473400
	public Record get_next() { }

	// RVA: 0x14734CC
	public Record get_previous() { }

	// RVA: 0x1471238
	internal void .ctor(InputStateHistory owner, int index, RecordHeader* header) { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x1473590
	public object ReadValueAsObject() { }

	// RVA: 0x14735D4
	public Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x14735F8
	internal Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x14736E8
	public Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x147370C
	internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x14713DC
	public void CopyFrom(Record record) { }

	// RVA: 0x14731F0
	internal void CheckValid() { }

	// RVA: 0x14737F0
	public bool Equals(Record other) { }

	// RVA: 0x1473824
	public override bool Equals(object obj) { }

	// RVA: 0x14738D4
	public override int GetHashCode() { }

	// RVA: 0x1473928
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public class InputStateHistory
{
	// Fields
	private const int kDefaultHistorySize = 128;
	private System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> <onRecordAdded>k__BackingField; // 0x10
	private System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> <onShouldRecordStateChange>k__BackingField; // 0x18
	internal InputControl[] m_Controls; // 0x20
	internal int m_ControlCount; // 0x28
	private Unity.Collections.NativeArray<System.Byte> m_RecordBuffer; // 0x30
	private int m_StateSizeInBytes; // 0x40
	private int m_RecordCount; // 0x44
	private int m_HistoryDepth; // 0x48
	private int m_ExtraMemoryPerRecord; // 0x4C
	internal int m_HeadIndex; // 0x50
	internal UInt32 m_CurrentVersion; // 0x54
	private System.Nullable<UnityEngine.InputSystem.LowLevel.InputUpdateType> m_UpdateMask; // 0x58
	internal readonly bool m_AddNewControls; // 0x60

	// Methods

	// RVA: 0x1470ABC
	public int get_Count() { }

	// RVA: 0x1470AC4
	public UInt32 get_version() { }

	// RVA: 0x1470ACC
	public int get_historyDepth() { }

	// RVA: 0x1470AD4
	public void set_historyDepth(int value) { }

	// RVA: 0x1470BBC
	public int get_extraMemoryPerRecord() { }

	// RVA: 0x1470BC4
	public void set_extraMemoryPerRecord(int value) { }

	// RVA: 0x1470CAC
	public InputUpdateType get_updateMask() { }

	// RVA: 0x1470E20
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x1470EF8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x1470F6C
	public Record get_Item(int index) { }

	// RVA: 0x1471284
	public void set_Item(int index, Record value) { }

	// RVA: 0x1471800
	public System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded() { }

	// RVA: 0x1471808
	public void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value) { }

	// RVA: 0x1471810
	public System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> get_onShouldRecordStateChange() { }

	// RVA: 0x1471818
	public void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x1471820
	public void .ctor(int maxStateSizeInBytes) { }

	// RVA: 0x14718C8
	public void .ctor(string path) { }

	// RVA: 0x1471A30
	public void .ctor(InputControl control) { }

	// RVA: 0x1471B4C
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls) { }

	// RVA: 0x1471BE8
	protected override void Finalize() { }

	// RVA: 0x1471D78
	public void Clear() { }

	// RVA: 0x1471D8C
	public Record AddRecord(Record record) { }

	// RVA: 0x1471F34
	public void StartRecording() { }

	// RVA: 0x14720D0
	public void StopRecording() { }

	// RVA: 0x1472268
	public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1472470
	public Record RecordStateChange(InputControl control, Void* statePtr, Double time) { }

	// RVA: 0x14727EC
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator() { }

	// RVA: 0x1472898
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1471C78
	public void Dispose() { }

	// RVA: 0x1472918
	protected void Destroy() { }

	// RVA: 0x1472980
	private void Allocate() { }

	// RVA: 0x1472CD8
	protected internal int RecordIndexToUserIndex(int index) { }

	// RVA: 0x14710A0
	protected internal int UserIndexToRecordIndex(int index) { }

	// RVA: 0x14710B8
	protected internal RecordHeader* GetRecord(int index) { }

	// RVA: 0x1472CF4
	internal RecordHeader* GetRecordUnchecked(int index) { }

	// RVA: 0x1471E1C
	protected internal RecordHeader* AllocateRecord(int index) { }

	// RVA: 0x316B894
	protected TValue ReadValue(RecordHeader* data) { }

	// RVA: 0x1472DA8
	protected object ReadValueAsObject(RecordHeader* data) { }

	// RVA: 0x1472F40
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x1473024
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1472C84
	internal int get_bytesPerRecord() { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history) { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public Record get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	public void Dispose() { }

}

// Namespace: 
public struct Record
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_Owner; // 0x0
	private readonly int m_IndexPlusOne; // 0x0
	private UInt32 m_Version; // 0x0

	// Methods

	// RVA: 0x316B894
	internal RecordHeader* get_header() { }

	// RVA: 0x30B199C
	internal int get_recordIndex() { }

	// RVA: 0x30B171C
	public bool get_valid() { }

	// RVA: 0x30B1CD4
	public UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner() { }

	// RVA: 0x30B199C
	public int get_index() { }

	// RVA: -1
	public Double get_time() { }

	// RVA: 0x30B1CD4
	public UnityEngine.InputSystem.InputControl<TValue> get_control() { }

	// RVA: 0x316B894
	public Record get_next() { }

	// RVA: 0x316B894
	public Record get_previous() { }

	// RVA: 0x316B894
	internal void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, RecordHeader* header) { }

	// RVA: 0x30B2D20
	internal void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index) { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x316B894
	public Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x316B894
	internal Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x316B894
	public Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x316B894
	internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x316B894
	public void CopyFrom(Record record) { }

	// RVA: 0x30B2870
	private void CheckValid() { }

	// RVA: 0x316B894
	public bool Equals(Record other) { }

	// RVA: 0x30B183C
	public override bool Equals(object obj) { }

	// RVA: 0x30B199C
	public override int GetHashCode() { }

	// RVA: 0x30B1CD4
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public class InputStateHistory<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(System.Nullable<System.Int32> maxStateSizeInBytes) { }

	// RVA: 0x30B2CB8
	public void .ctor(UnityEngine.InputSystem.InputControl<TValue> control) { }

	// RVA: 0x30B2CB8
	public void .ctor(string path) { }

	// RVA: 0x30B2870
	protected override void Finalize() { }

	// RVA: 0x316B894
	public Record AddRecord(Record record) { }

	// RVA: 0x316B894
	public Record RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public Record get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, Record value) { }

}

// Namespace: 
private class Select
{
	// Fields
	private UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x30B2870
	public void OnCompleted() { }

	// RVA: 0x30B2CB8
	public void OnError(Exception error) { }

	// RVA: 0x316B894
	public void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal class SelectObservable<T0, T1>
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,TResult> m_Filter; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x30B1D84
	public IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class AxisDeadzoneProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x1473A74
	private float get_minOrDefault() { }

	// RVA: 0x1473AE8
	private float get_maxOrDefault() { }

	// RVA: 0x1473B5C
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1473C70
	public override string ToString() { }

	// RVA: 0x1473DE0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ClampProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x1473E34
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1473E4C
	public override string ToString() { }

	// RVA: 0x1473EF4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateDirectionProcessor
{
	// Methods

	// RVA: 0x1473F48
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x1474174
	public override string ToString() { }

	// RVA: 0x14741B8
	public override CachingPolicy get_cachingPolicy() { }

	// RVA: 0x14741C0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateRotationProcessor
{
	// Methods

	// RVA: 0x1474214
	public override Quaternion Process(Quaternion value, InputControl control) { }

	// RVA: 0x1474460
	public override string ToString() { }

	// RVA: 0x14744A4
	public override CachingPolicy get_cachingPolicy() { }

	// RVA: 0x14744AC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertProcessor
{
	// Methods

	// RVA: 0x1474500
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1474508
	public override string ToString() { }

	// RVA: 0x147454C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertVector2Processor
{
	// Fields
	public bool invertX; // 0x10
	public bool invertY; // 0x11

	// Methods

	// RVA: 0x14745A0
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x14745C4
	public override string ToString() { }

	// RVA: 0x147466C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertVector3Processor
{
	// Fields
	public bool invertX; // 0x10
	public bool invertY; // 0x11
	public bool invertZ; // 0x12

	// Methods

	// RVA: 0x14746C8
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14746FC
	public override string ToString() { }

	// RVA: 0x14747C8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14
	public float zero; // 0x18

	// Methods

	// RVA: 0x147482C
	public override float Process(float value, InputControl control) { }

	// RVA: 0x147491C
	public static float Normalize(float value, float min, float max, float zero) { }

	// RVA: 0x1474A0C
	internal static float Denormalize(float value, float min, float max, float zero) { }

	// RVA: 0x1474A50
	public override string ToString() { }

	// RVA: 0x1474B1C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector2Processor
{
	// Methods

	// RVA: 0x1474B70
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x1474C58
	public override string ToString() { }

	// RVA: 0x1474C9C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector3Processor
{
	// Methods

	// RVA: 0x1474CF0
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x1474DF8
	public override string ToString() { }

	// RVA: 0x1474E3C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleProcessor
{
	// Fields
	public float factor; // 0x10

	// Methods

	// RVA: 0x1474E90
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1474E9C
	public override string ToString() { }

	// RVA: 0x1474F28
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleVector2Processor
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14

	// Methods

	// RVA: 0x1474F84
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x1474F94
	public override string ToString() { }

	// RVA: 0x147503C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleVector3Processor
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x1475098
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14750B0
	public override string ToString() { }

	// RVA: 0x147517C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class StickDeadzoneProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x14751E0
	private float get_minOrDefault() { }

	// RVA: 0x1475254
	private float get_maxOrDefault() { }

	// RVA: 0x14752C8
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x14753C4
	private float GetDeadZoneAdjustedValue(float value) { }

	// RVA: 0x14754D8
	public override string ToString() { }

	// RVA: 0x1475648
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public sealed class InputControlAttribute
{
	// Fields
	private string <layout>k__BackingField; // 0x18
	private string <variants>k__BackingField; // 0x20
	private string <name>k__BackingField; // 0x28
	private string <format>k__BackingField; // 0x30
	private string <usage>k__BackingField; // 0x38
	private string[] <usages>k__BackingField; // 0x40
	private string <parameters>k__BackingField; // 0x48
	private string <processors>k__BackingField; // 0x50
	private string <alias>k__BackingField; // 0x58
	private string[] <aliases>k__BackingField; // 0x60
	private string <useStateFrom>k__BackingField; // 0x68
	private UInt32 <bit>k__BackingField; // 0x70
	private UInt32 <offset>k__BackingField; // 0x74
	private UInt32 <sizeInBits>k__BackingField; // 0x78
	private int <arraySize>k__BackingField; // 0x7C
	private string <displayName>k__BackingField; // 0x80
	private string <shortDisplayName>k__BackingField; // 0x88
	private bool <noisy>k__BackingField; // 0x90
	private bool <synthetic>k__BackingField; // 0x91
	private bool <dontReset>k__BackingField; // 0x92
	private object <defaultState>k__BackingField; // 0x98
	private object <minValue>k__BackingField; // 0xA0
	private object <maxValue>k__BackingField; // 0xA8

	// Methods

	// RVA: 0x147569C
	public string get_layout() { }

	// RVA: 0x14756A4
	public void set_layout(string value) { }

	// RVA: 0x14756AC
	public string get_variants() { }

	// RVA: 0x14756B4
	public void set_variants(string value) { }

	// RVA: 0x14756BC
	public string get_name() { }

	// RVA: 0x14756C4
	public void set_name(string value) { }

	// RVA: 0x14756CC
	public string get_format() { }

	// RVA: 0x14756D4
	public void set_format(string value) { }

	// RVA: 0x14756DC
	public string get_usage() { }

	// RVA: 0x14756E4
	public void set_usage(string value) { }

	// RVA: 0x14756EC
	public string[] get_usages() { }

	// RVA: 0x14756F4
	public void set_usages(string[] value) { }

	// RVA: 0x14756FC
	public string get_parameters() { }

	// RVA: 0x1475704
	public void set_parameters(string value) { }

	// RVA: 0x147570C
	public string get_processors() { }

	// RVA: 0x1475714
	public void set_processors(string value) { }

	// RVA: 0x147571C
	public string get_alias() { }

	// RVA: 0x1475724
	public void set_alias(string value) { }

	// RVA: 0x147572C
	public string[] get_aliases() { }

	// RVA: 0x1475734
	public void set_aliases(string[] value) { }

	// RVA: 0x147573C
	public string get_useStateFrom() { }

	// RVA: 0x1475744
	public void set_useStateFrom(string value) { }

	// RVA: 0x147574C
	public UInt32 get_bit() { }

	// RVA: 0x1475754
	public void set_bit(UInt32 value) { }

	// RVA: 0x147575C
	public UInt32 get_offset() { }

	// RVA: 0x1475764
	public void set_offset(UInt32 value) { }

	// RVA: 0x147576C
	public UInt32 get_sizeInBits() { }

	// RVA: 0x1475774
	public void set_sizeInBits(UInt32 value) { }

	// RVA: 0x147577C
	public int get_arraySize() { }

	// RVA: 0x1475784
	public void set_arraySize(int value) { }

	// RVA: 0x147578C
	public string get_displayName() { }

	// RVA: 0x1475794
	public void set_displayName(string value) { }

	// RVA: 0x147579C
	public string get_shortDisplayName() { }

	// RVA: 0x14757A4
	public void set_shortDisplayName(string value) { }

	// RVA: 0x14757AC
	public bool get_noisy() { }

	// RVA: 0x14757B4
	public void set_noisy(bool value) { }

	// RVA: 0x14757BC
	public bool get_synthetic() { }

	// RVA: 0x14757C4
	public void set_synthetic(bool value) { }

	// RVA: 0x14757CC
	public bool get_dontReset() { }

	// RVA: 0x14757D4
	public void set_dontReset(bool value) { }

	// RVA: 0x14757DC
	public object get_defaultState() { }

	// RVA: 0x14757E4
	public void set_defaultState(object value) { }

	// RVA: 0x14757EC
	public object get_minValue() { }

	// RVA: 0x14757F4
	public void set_minValue(object value) { }

	// RVA: 0x14757FC
	public object get_maxValue() { }

	// RVA: 0x1475804
	public void set_maxValue(object value) { }

	// RVA: 0x147580C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public sealed class InputDeviceFindControlLayoutDelegate
{
	// Methods

	// RVA: 0x147581C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14758D8
	public virtual string Invoke(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x14758EC
	public virtual IAsyncResult BeginInvoke(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	// RVA: 0x14759BC
	public virtual string EndInvoke(InputDeviceDescription description, IAsyncResult result) { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags isModifyingExistingControl = 1;
	public const Flags IsNoisy = 2;
	public const Flags IsSynthetic = 4;
	public const Flags IsFirstDefinedInThisLayout = 8;
	public const Flags DontReset = 16;
}

// Namespace: 
public struct ControlItem
{
	// Fields
	private InternedString <name>k__BackingField; // 0x10
	private InternedString <layout>k__BackingField; // 0x20
	private InternedString <variants>k__BackingField; // 0x30
	private string <useStateFrom>k__BackingField; // 0x40
	private string <displayName>k__BackingField; // 0x48
	private string <shortDisplayName>k__BackingField; // 0x50
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> <usages>k__BackingField; // 0x58
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> <aliases>k__BackingField; // 0x68
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField; // 0x78
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> <processors>k__BackingField; // 0x88
	private UInt32 <offset>k__BackingField; // 0x98
	private UInt32 <bit>k__BackingField; // 0x9C
	private UInt32 <sizeInBits>k__BackingField; // 0xA0
	private FourCC <format>k__BackingField; // 0xA4
	private Flags <flags>k__BackingField; // 0xA8
	private int <arraySize>k__BackingField; // 0xAC
	private PrimitiveValue <defaultState>k__BackingField; // 0xB0
	private PrimitiveValue <minValue>k__BackingField; // 0xC0
	private PrimitiveValue <maxValue>k__BackingField; // 0xD0

	// Methods

	// RVA: 0x147B394
	public InternedString get_name() { }

	// RVA: 0x147B3A0
	internal void set_name(InternedString value) { }

	// RVA: 0x147B3AC
	public InternedString get_layout() { }

	// RVA: 0x147B3B8
	internal void set_layout(InternedString value) { }

	// RVA: 0x147B3C4
	public InternedString get_variants() { }

	// RVA: 0x147B3D0
	internal void set_variants(InternedString value) { }

	// RVA: 0x147B3DC
	public string get_useStateFrom() { }

	// RVA: 0x147B3E4
	internal void set_useStateFrom(string value) { }

	// RVA: 0x147B3EC
	public string get_displayName() { }

	// RVA: 0x147B3F4
	internal void set_displayName(string value) { }

	// RVA: 0x147B3FC
	public string get_shortDisplayName() { }

	// RVA: 0x147B404
	internal void set_shortDisplayName(string value) { }

	// RVA: 0x147B40C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x147B418
	internal void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x147B424
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x147B430
	internal void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x147B43C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x147B448
	internal void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x147B454
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors() { }

	// RVA: 0x147B460
	internal void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value) { }

	// RVA: 0x147B46C
	public UInt32 get_offset() { }

	// RVA: 0x147B474
	internal void set_offset(UInt32 value) { }

	// RVA: 0x147B47C
	public UInt32 get_bit() { }

	// RVA: 0x147B484
	internal void set_bit(UInt32 value) { }

	// RVA: 0x147B48C
	public UInt32 get_sizeInBits() { }

	// RVA: 0x147B494
	internal void set_sizeInBits(UInt32 value) { }

	// RVA: 0x147B49C
	public FourCC get_format() { }

	// RVA: 0x147B4A4
	internal void set_format(FourCC value) { }

	// RVA: 0x147B4AC
	private Flags get_flags() { }

	// RVA: 0x147B4B4
	private void set_flags(Flags value) { }

	// RVA: 0x147B4BC
	public int get_arraySize() { }

	// RVA: 0x147B4C4
	internal void set_arraySize(int value) { }

	// RVA: 0x147B4CC
	public PrimitiveValue get_defaultState() { }

	// RVA: 0x147B4D8
	internal void set_defaultState(PrimitiveValue value) { }

	// RVA: 0x147B4E0
	public PrimitiveValue get_minValue() { }

	// RVA: 0x147B4EC
	internal void set_minValue(PrimitiveValue value) { }

	// RVA: 0x147B4F4
	public PrimitiveValue get_maxValue() { }

	// RVA: 0x147B500
	internal void set_maxValue(PrimitiveValue value) { }

	// RVA: 0x147B508
	public bool get_isModifyingExistingControl() { }

	// RVA: 0x147B514
	internal void set_isModifyingExistingControl(bool value) { }

	// RVA: 0x147B528
	public bool get_isNoisy() { }

	// RVA: 0x147B534
	internal void set_isNoisy(bool value) { }

	// RVA: 0x147B554
	public bool get_isSynthetic() { }

	// RVA: 0x147B560
	internal void set_isSynthetic(bool value) { }

	// RVA: 0x147B580
	public bool get_dontReset() { }

	// RVA: 0x147B58C
	internal void set_dontReset(bool value) { }

	// RVA: 0x147B5AC
	public bool get_isFirstDefinedInThisLayout() { }

	// RVA: 0x147B5B8
	internal void set_isFirstDefinedInThisLayout(bool value) { }

	// RVA: 0x147B5D8
	public bool get_isArray() { }

	// RVA: 0x147B5E8
	public ControlItem Merge(ControlItem other) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x147CAC0
	private static void .cctor() { }

	// RVA: 0x147CB2C
	public void .ctor() { }

	// RVA: 0x147CB34
	internal InternedString <WithUsages>b__14_0(string x) { }

}

// Namespace: 
public struct ControlBuilder
{
	// Fields
	internal Builder builder; // 0x10
	internal int index; // 0x18

	// Methods

	// RVA: 0x147C034
	public ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x147C08C
	public ControlBuilder WithLayout(string layout) { }

	// RVA: 0x147C180
	public ControlBuilder WithFormat(FourCC format) { }

	// RVA: 0x147C1CC
	public ControlBuilder WithFormat(string format) { }

	// RVA: 0x147C23C
	public ControlBuilder WithByteOffset(UInt32 offset) { }

	// RVA: 0x147C288
	public ControlBuilder WithBitOffset(UInt32 bit) { }

	// RVA: 0x147C2D4
	public ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x147C338
	public ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x147C39C
	public ControlBuilder DontReset(bool value) { }

	// RVA: 0x147C400
	public ControlBuilder WithSizeInBits(UInt32 sizeInBits) { }

	// RVA: 0x147C44C
	public ControlBuilder WithRange(float minValue, float maxValue) { }

	// RVA: 0x147C4F4
	public ControlBuilder WithUsages(InternedString[] usages) { }

	// RVA: 0x147C6C8
	public ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<System.String> usages) { }

	// RVA: 0x147C800
	public ControlBuilder WithUsages(string[] usages) { }

	// RVA: 0x147C804
	public ControlBuilder WithParameters(string parameters) { }

	// RVA: 0x147C8D0
	public ControlBuilder WithProcessors(string processors) { }

	// RVA: 0x147C9B8
	public ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x147CA04
	public ControlBuilder UsingStateFrom(string path) { }

	// RVA: 0x147CA74
	public ControlBuilder AsArrayOfControlsWithSize(int arraySize) { }

}

// Namespace: 
public class Builder
{
	// Fields
	private string <name>k__BackingField; // 0x10
	private string <displayName>k__BackingField; // 0x18
	private Type <type>k__BackingField; // 0x20
	private FourCC <stateFormat>k__BackingField; // 0x28
	private int <stateSizeInBytes>k__BackingField; // 0x2C
	private string m_ExtendsLayout; // 0x30
	private System.Nullable<System.Boolean> <updateBeforeRender>k__BackingField; // 0x38
	private int m_ControlCount; // 0x3C
	private ControlItem[] m_Controls; // 0x40

	// Methods

	// RVA: 0x147BA54
	public string get_name() { }

	// RVA: 0x147BA5C
	public void set_name(string value) { }

	// RVA: 0x147BA64
	public string get_displayName() { }

	// RVA: 0x147BA6C
	public void set_displayName(string value) { }

	// RVA: 0x147BA74
	public Type get_type() { }

	// RVA: 0x147BA7C
	public void set_type(Type value) { }

	// RVA: 0x147BA84
	public FourCC get_stateFormat() { }

	// RVA: 0x147BA8C
	public void set_stateFormat(FourCC value) { }

	// RVA: 0x147BA94
	public int get_stateSizeInBytes() { }

	// RVA: 0x147BA9C
	public void set_stateSizeInBytes(int value) { }

	// RVA: 0x147BAA4
	public string get_extendsLayout() { }

	// RVA: 0x147BAAC
	public void set_extendsLayout(string value) { }

	// RVA: 0x147BAE8
	public System.Nullable<System.Boolean> get_updateBeforeRender() { }

	// RVA: 0x147BAF0
	public void set_updateBeforeRender(System.Nullable<System.Boolean> value) { }

	// RVA: 0x147BAF8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x147BB6C
	public ControlBuilder AddControl(string name) { }

	// RVA: 0x147BD04
	public Builder WithName(string name) { }

	// RVA: 0x147BD2C
	public Builder WithDisplayName(string displayName) { }

	// RVA: 0x30B1CD4
	public Builder WithType() { }

	// RVA: 0x147BD54
	public Builder WithFormat(FourCC format) { }

	// RVA: 0x147BD5C
	public Builder WithFormat(string format) { }

	// RVA: 0x147BD9C
	public Builder WithSizeInBytes(int sizeInBytes) { }

	// RVA: 0x147BDA4
	public Builder Extend(string baseLayoutName) { }

	// RVA: 0x147BDE8
	public InputControlLayout Build() { }

	// RVA: 0x147C02C
	public void .ctor() { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags IsGenericTypeOfDevice = 1;
	public const Flags HideInUI = 2;
	public const Flags IsOverride = 4;
	public const Flags CanRunInBackground = 8;
	public const Flags CanRunInBackgroundIsSet = 16;
	public const Flags IsNoisy = 32;
}

// Namespace: 
[Serializable]
internal struct LayoutJsonNameAndDescriptorOnly
{
	// Fields
	public string name; // 0x10
	public string extend; // 0x18
	public string[] extendMultiple; // 0x20
	public MatcherJson device; // 0x28
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0; // 0x8
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__15_0; // 0x10
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__15_1; // 0x18

	// Methods

	// RVA: 0x147E818
	private static void .cctor() { }

	// RVA: 0x147E884
	public void .ctor() { }

	// RVA: 0x147E88C
	internal InternedString <ToLayout>b__14_0(string x) { }

	// RVA: 0x147E8B8
	internal string <FromLayout>b__15_0(InternedString x) { }

	// RVA: 0x147E8E0
	internal string <FromLayout>b__15_1(InternedString x) { }

}

// Namespace: 
[Serializable]
private struct LayoutJson
{
	// Fields
	public string name; // 0x10
	public string extend; // 0x18
	public string[] extendMultiple; // 0x20
	public string format; // 0x28
	public string beforeRender; // 0x30
	public string runInBackground; // 0x38
	public string[] commonUsages; // 0x40
	public string displayName; // 0x48
	public string description; // 0x50
	public string type; // 0x58
	public string variant; // 0x60
	public bool isGenericTypeOfDevice; // 0x68
	public bool hideInUI; // 0x69
	public ControlItemJson[] controls; // 0x70

	// Methods

	// RVA: 0x147CB60
	public InputControlLayout ToLayout() { }

	// RVA: 0x147DC38
	public static LayoutJson FromLayout(InputControlLayout layout) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__24_0; // 0x8
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__24_1; // 0x10
	public static System.Func<UnityEngine.InputSystem.Utilities.NamedValue,System.String> <>9__25_0; // 0x18
	public static System.Func<UnityEngine.InputSystem.Utilities.NameAndParameters,System.String> <>9__25_1; // 0x20
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__25_2; // 0x28
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__25_3; // 0x30

	// Methods

	// RVA: 0x147E934
	private static void .cctor() { }

	// RVA: 0x147E9A0
	public void .ctor() { }

	// RVA: 0x147E9A8
	internal InternedString <ToLayout>b__24_0(string x) { }

	// RVA: 0x147E9D4
	internal InternedString <ToLayout>b__24_1(string x) { }

	// RVA: 0x147EA00
	internal string <FromControlItems>b__25_0(NamedValue x) { }

	// RVA: 0x147EA0C
	internal string <FromControlItems>b__25_1(NameAndParameters x) { }

	// RVA: 0x147EA18
	internal string <FromControlItems>b__25_2(InternedString x) { }

	// RVA: 0x147EA40
	internal string <FromControlItems>b__25_3(InternedString x) { }

}

// Namespace: 
[Serializable]
private class ControlItemJson
{
	// Fields
	public string name; // 0x10
	public string layout; // 0x18
	public string variants; // 0x20
	public string usage; // 0x28
	public string alias; // 0x30
	public string useStateFrom; // 0x38
	public UInt32 offset; // 0x40
	public UInt32 bit; // 0x44
	public UInt32 sizeInBits; // 0x48
	public string format; // 0x50
	public int arraySize; // 0x58
	public string[] usages; // 0x60
	public string[] aliases; // 0x68
	public string parameters; // 0x70
	public string processors; // 0x78
	public string displayName; // 0x80
	public string shortDisplayName; // 0x88
	public bool noisy; // 0x90
	public bool dontReset; // 0x91
	public bool synthetic; // 0x92
	public string defaultState; // 0x98
	public string minValue; // 0xA0
	public string maxValue; // 0xA8

	// Methods

	// RVA: 0x147E908
	public void .ctor() { }

	// RVA: 0x147D55C
	public ControlItem ToLayout() { }

	// RVA: 0x147E0A4
	public static ControlItemJson[] FromControlItems(ControlItem[] items) { }

}

// Namespace: 
public struct LayoutMatcher
{
	// Fields
	public InternedString layoutName; // 0x10
	public InputDeviceMatcher deviceMatcher; // 0x20
}

// Namespace: 
public struct PrecompiledLayout
{
	// Fields
	public System.Func<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x10
	public string metadata; // 0x18
}

// Namespace: 
private sealed class <GetBaseLayouts>d__24
{
	// Fields
	private int <>1__state; // 0x10
	private InternedString <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	private bool includeSelf; // 0x2C
	public bool <>3__includeSelf; // 0x2D
	private InternedString layout; // 0x30
	public InternedString <>3__layout; // 0x40
	public Collection <>4__this; // 0x50
	public Collection <>3__<>4__this; // 0x90

	// Methods

	// RVA: 0x1480A20
	public void .ctor(int <>1__state) { }

	// RVA: 0x1480D4C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1480D50
	private bool MoveNext() { }

	// RVA: 0x1480E58
	private InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current() { }

	// RVA: 0x1480E64
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1480EA4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1480F0C
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator() { }

	// RVA: 0x1480FDC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
internal struct Collection
{
	// Fields
	public const float kBaseScoreForNonGeneratedLayouts = 1;
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> layoutTypes; // 0x10
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.String> layoutStrings; // 0x18
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>> layoutBuilders; // 0x20
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> baseLayoutTable; // 0x28
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> layoutOverrides; // 0x30
	public System.Collections.Generic.HashSet<UnityEngine.InputSystem.Utilities.InternedString> layoutOverrideNames; // 0x38
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.PrecompiledLayout> precompiledLayouts; // 0x40
	public System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.LayoutMatcher> layoutMatchers; // 0x48

	// Methods

	// RVA: 0x147EA68
	public void Allocate() { }

	// RVA: 0x147ED14
	public InternedString TryFindLayoutForType(Type layoutType) { }

	// RVA: 0x147F078
	public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x147F87C
	public bool HasLayout(InternedString name) { }

	// RVA: 0x147F984
	private InputControlLayout TryLoadLayoutInternal(InternedString name) { }

	// RVA: 0x147FBA8
	public InputControlLayout TryLoadLayout(InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table) { }

	// RVA: 0x1480030
	public InternedString GetBaseLayoutName(InternedString layoutName) { }

	// RVA: 0x14800C0
	public InternedString GetRootLayoutName(InternedString layoutName) { }

	// RVA: 0x1480158
	public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, int distance) { }

	// RVA: 0x1480344
	public InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache) { }

	// RVA: 0x1480644
	public Type GetControlTypeForLayout(InternedString layoutName) { }

	// RVA: 0x14807A8
	public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType) { }

	// RVA: 0x14808E8
	public bool IsGeneratedLayout(InternedString layout) { }

	// RVA: 0x1480960
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(InternedString layout, bool includeSelf) { }

	// RVA: 0x1480A58
	public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) { }

	// RVA: 0x1480B10
	public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) { }

}

// Namespace: 
public class LayoutNotFoundException
{
	// Fields
	private readonly string <layout>k__BackingField; // 0x90

	// Methods

	// RVA: 0x1480FE0
	public string get_layout() { }

	// RVA: 0x1480FE8
	public void .ctor() { }

	// RVA: 0x1481070
	public void .ctor(string name, string message) { }

	// RVA: 0x147FF6C
	public void .ctor(string name) { }

	// RVA: 0x14810F8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1481174
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
internal struct Cache
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table; // 0x10

	// Methods

	// RVA: 0x14811F8
	public void Clear() { }

	// RVA: 0x1480500
	public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound) { }

}

// Namespace: 
internal struct CacheRefInstance
{
	// Fields
	public bool valid; // 0x10

	// Methods

	// RVA: 0x1481204
	public void Dispose() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__52_0; // 0x8
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__75_0; // 0x10
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__75_1; // 0x18

	// Methods

	// RVA: 0x14812BC
	private static void .cctor() { }

	// RVA: 0x1481328
	public void .ctor() { }

	// RVA: 0x1481330
	internal InternedString <FromType>b__52_0(string x) { }

	// RVA: 0x148135C
	internal InternedString <CreateControlItemFromMember>b__75_0(string x) { }

	// RVA: 0x1481388
	internal InternedString <CreateControlItemFromMember>b__75_1(string x) { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public class InputControlLayout
{
	// Fields
	private static InternedString s_DefaultVariant; // 0x0
	public const string VariantSeparator = ";";
	private InternedString m_Name; // 0x10
	private Type m_Type; // 0x20
	private InternedString m_Variants; // 0x28
	private FourCC m_StateFormat; // 0x38
	internal int m_StateSizeInBytes; // 0x3C
	internal System.Nullable<System.Boolean> m_UpdateBeforeRender; // 0x40
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> m_BaseLayouts; // 0x48
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> m_AppliedOverrides; // 0x68
	private InternedString[] m_CommonUsages; // 0x88
	internal ControlItem[] m_Controls; // 0x90
	internal string m_DisplayName; // 0x98
	private string m_Description; // 0xA0
	private Flags m_Flags; // 0xA8
	internal static Collection s_Layouts; // 0x10
	internal static Cache s_CacheInstance; // 0x50
	internal static int s_CacheInstanceRef; // 0x58

	// Methods

	// RVA: 0x1475A10
	public static InternedString get_DefaultVariant() { }

	// RVA: 0x1475A8C
	public InternedString get_name() { }

	// RVA: 0x1475A98
	public string get_displayName() { }

	// RVA: 0x1475AB8
	public Type get_type() { }

	// RVA: 0x1475AC0
	public InternedString get_variants() { }

	// RVA: 0x1475ACC
	public FourCC get_stateFormat() { }

	// RVA: 0x1475AD4
	public int get_stateSizeInBytes() { }

	// RVA: 0x1475ADC
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts() { }

	// RVA: 0x1475B48
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides() { }

	// RVA: 0x1475BB4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages() { }

	// RVA: 0x1475C20
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x1475C8C
	public bool get_updateBeforeRender() { }

	// RVA: 0x1475D64
	public bool get_isDeviceLayout() { }

	// RVA: 0x1475E1C
	public bool get_isControlLayout() { }

	// RVA: 0x1475EDC
	public bool get_isOverride() { }

	// RVA: 0x1475EE8
	internal void set_isOverride(bool value) { }

	// RVA: 0x1475F08
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x1475F14
	internal void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x1475F28
	public bool get_hideInUI() { }

	// RVA: 0x1475F34
	internal void set_hideInUI(bool value) { }

	// RVA: 0x1475F54
	public bool get_isNoisy() { }

	// RVA: 0x1475F60
	internal void set_isNoisy(bool value) { }

	// RVA: 0x1475F80
	public System.Nullable<System.Boolean> get_canRunInBackground() { }

	// RVA: 0x1476008
	internal void set_canRunInBackground(System.Nullable<System.Boolean> value) { }

	// RVA: 0x14760FC
	public ControlItem get_Item(string path) { }

	// RVA: 0x14762A4
	public System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(InternedString path) { }

	// RVA: 0x14764AC
	public System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, int arrayIndex) { }

	// RVA: 0x14768D8
	public Type GetValueType() { }

	// RVA: 0x147696C
	public static InputControlLayout FromType(string name, Type type) { }

	// RVA: 0x1467D74
	public string ToJson() { }

	// RVA: 0x1477034
	public static InputControlLayout FromJson(string json) { }

	// RVA: 0x1476FC0
	private void .ctor(string name, Type type) { }

	// RVA: 0x1476E7C
	private static void AddControlItems(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x14770DC
	private static void AddControlItemsFromFields(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x1477170
	private static void AddControlItemsFromProperties(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x1477204
	private static void AddControlItemsFromMembers(MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName) { }

	// RVA: 0x147779C
	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems) { }

	// RVA: 0x14779D0
	private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	// RVA: 0x147834C
	private static string InferLayoutFromValueType(Type type) { }

	// RVA: 0x1478528
	public void MergeLayout(InputControlLayout other) { }

	// RVA: 0x147A8FC
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, System.Collections.Generic.List<System.String> variants) { }

	// RVA: 0x147AF0C
	internal static bool VariantsMatch(InternedString expected, InternedString actual) { }

	// RVA: 0x147ADBC
	internal static bool VariantsMatch(string expected, string actual) { }

	// RVA: 0x147AF98
	internal static void ParseHeaderFieldsFromJson(string json, InternedString name, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>& baseLayouts, InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x147B134
	internal static Cache get_cache() { }

	// RVA: 0x147B1B0
	internal static CacheRefInstance CacheRef() { }

	// RVA: 0x147B218
	private static void .cctor() { }

	// RVA: 0x147B2B0
	private bool <MergeLayout>b__77_0(ControlItem x) { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public sealed class InputControlLayoutAttribute
{
	// Fields
	private Type <stateType>k__BackingField; // 0x10
	private string <stateFormat>k__BackingField; // 0x18
	private string[] <commonUsages>k__BackingField; // 0x20
	private string <variants>k__BackingField; // 0x28
	private bool <isNoisy>k__BackingField; // 0x30
	internal System.Nullable<System.Boolean> canRunInBackgroundInternal; // 0x31
	internal System.Nullable<System.Boolean> updateBeforeRenderInternal; // 0x33
	private bool <isGenericTypeOfDevice>k__BackingField; // 0x35
	private string <displayName>k__BackingField; // 0x38
	private string <description>k__BackingField; // 0x40
	private bool <hideInUI>k__BackingField; // 0x48

	// Methods

	// RVA: 0x14813B4
	public Type get_stateType() { }

	// RVA: 0x14813BC
	public void set_stateType(Type value) { }

	// RVA: 0x14813C4
	public string get_stateFormat() { }

	// RVA: 0x14813CC
	public void set_stateFormat(string value) { }

	// RVA: 0x14813D4
	public string[] get_commonUsages() { }

	// RVA: 0x14813DC
	public void set_commonUsages(string[] value) { }

	// RVA: 0x14813E4
	public string get_variants() { }

	// RVA: 0x14813EC
	public void set_variants(string value) { }

	// RVA: 0x14813F4
	public bool get_isNoisy() { }

	// RVA: 0x14813FC
	public void set_isNoisy(bool value) { }

	// RVA: 0x1481404
	public bool get_canRunInBackground() { }

	// RVA: 0x148146C
	public void set_canRunInBackground(bool value) { }

	// RVA: 0x14814E4
	public bool get_updateBeforeRender() { }

	// RVA: 0x148154C
	public void set_updateBeforeRender(bool value) { }

	// RVA: 0x14815C4
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x14815CC
	public void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x14815D4
	public string get_displayName() { }

	// RVA: 0x14815DC
	public void set_displayName(string value) { }

	// RVA: 0x14815E4
	public string get_description() { }

	// RVA: 0x14815EC
	public void set_description(string value) { }

	// RVA: 0x14815F4
	public bool get_hideInUI() { }

	// RVA: 0x14815FC
	public void set_hideInUI(bool value) { }

	// RVA: 0x1481604
	public void .ctor() { }

}

// Namespace: 
internal struct RefInstance
{
	// Methods

	// RVA: 0x1486068
	public void Dispose() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
internal struct InputDeviceBuilder
{
	// Fields
	private InputDevice m_Device; // 0x10
	private CacheRefInstance m_LayoutCacheRef; // 0x18
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> m_ChildControlOverrides; // 0x20
	private System.Collections.Generic.List<System.UInt32> m_StateOffsetToControlMap; // 0x28
	private StringBuilder m_StringBuilder; // 0x30
	private const UInt32 kSizeForControlUsingStateFromOtherControl = 4294967295;
	private static InputDeviceBuilder s_Instance; // 0x0
	private static int s_InstanceRef; // 0x28

	// Methods

	// RVA: 0x148160C
	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription) { }

	// RVA: 0x1481B18
	public InputDevice Finish() { }

	// RVA: 0x1481C0C
	public void Dispose() { }

	// RVA: 0x1481B3C
	private void Reset() { }

	// RVA: 0x14817B4
	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x1481D30
	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x1482548
	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls) { }

	// RVA: 0x1483A48
	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem, int childIndex, string nameOverride) { }

	// RVA: 0x1483788
	private void InsertChildControlOverride(InputControl parent, ControlItem controlItem) { }

	// RVA: 0x1484440
	private string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	// RVA: 0x1484384
	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem) { }

	// RVA: 0x14847EC
	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem) { }

	// RVA: 0x148358C
	private static void ApplyUseStateFrom(InputControl parent, ControlItem controlItem, InputControlLayout layout) { }

	// RVA: 0x1484B68
	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

	// RVA: 0x1484BD4
	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	// RVA: 0x1484E3C
	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	// RVA: 0x14845BC
	private static void AddProcessors(InputControl control, ControlItem controlItem, string layoutName) { }

	// RVA: 0x14844D4
	private static void SetFormat(InputControl control, ControlItem controlItem) { }

	// RVA: 0x1481CC4
	private static InputControlLayout FindOrLoadLayout(string name) { }

	// RVA: 0x1482C5C
	private static void ComputeStateLayout(InputControl control) { }

	// RVA: 0x1481880
	private void FinalizeControlHierarchy() { }

	// RVA: 0x1484EF8
	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, int controlIndiciesNextFreeIndex) { }

	// RVA: 0x1485344
	private void InsertControlBitRangeNode(ControlBitRangeNode parent, InputControl control, int controlIndiciesNextFreeIndex, UInt16 startOffset) { }

	// RVA: 0x1485708
	private UInt16 GetBestMidPoint(ControlBitRangeNode parent, UInt16 startOffset) { }

	// RVA: 0x1485DCC
	private void AddControlToNode(InputControl control, int controlIndiciesNextFreeIndex, int nodeIndex) { }

	// RVA: 0x1485CA8
	private void AddChildren(ControlBitRangeNode parent, ControlBitRangeNode left, ControlBitRangeNode right) { }

	// RVA: 0x1485F14
	private UInt16 GetControlIndex(InputControl control) { }

	// RVA: 0x1485FC8
	internal static InputDeviceBuilder get_instance() { }

	// RVA: 0x1486010
	internal static RefInstance Ref() { }

}

// Namespace: 
private struct DeviceDescriptionJson
{
	// Fields
	public string interface; // 0x10
	public string type; // 0x18
	public string product; // 0x20
	public string serial; // 0x28
	public string version; // 0x30
	public string manufacturer; // 0x38
	public string capabilities; // 0x40
}

// Namespace: UnityEngine.InputSystem.Layouts
[Serializable]
public struct InputDeviceDescription
{
	// Fields
	private string m_InterfaceName; // 0x10
	private string m_DeviceClass; // 0x18
	private string m_Manufacturer; // 0x20
	private string m_Product; // 0x28
	private string m_Serial; // 0x30
	private string m_Version; // 0x38
	private string m_Capabilities; // 0x40

	// Methods

	// RVA: 0x148619C
	public string get_interfaceName() { }

	// RVA: 0x14861A4
	public void set_interfaceName(string value) { }

	// RVA: 0x14861AC
	public string get_deviceClass() { }

	// RVA: 0x14861B4
	public void set_deviceClass(string value) { }

	// RVA: 0x14861BC
	public string get_manufacturer() { }

	// RVA: 0x14861C4
	public void set_manufacturer(string value) { }

	// RVA: 0x14861CC
	public string get_product() { }

	// RVA: 0x14861D4
	public void set_product(string value) { }

	// RVA: 0x14861DC
	public string get_serial() { }

	// RVA: 0x14861E4
	public void set_serial(string value) { }

	// RVA: 0x14861EC
	public string get_version() { }

	// RVA: 0x14861F4
	public void set_version(string value) { }

	// RVA: 0x14861FC
	public string get_capabilities() { }

	// RVA: 0x1486204
	public void set_capabilities(string value) { }

	// RVA: 0x148620C
	public bool get_empty() { }

	// RVA: 0x14862A0
	public override string ToString() { }

	// RVA: 0x1486558
	public bool Equals(InputDeviceDescription other) { }

	// RVA: 0x148660C
	public override bool Equals(object obj) { }

	// RVA: 0x14866BC
	public override int GetHashCode() { }

	// RVA: 0x1486814
	public static bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x148684C
	public static bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x1486888
	public string ToJson() { }

	// RVA: 0x1486994
	public static InputDeviceDescription FromJson(string json) { }

	// RVA: 0x1486B0C
	internal static bool ComparePropertyToDeviceDescriptor(string propertyName, string propertyValue, string deviceDescriptor) { }

}

// Namespace: 
public struct Capability
{
	// Fields
	public string path; // 0x10
	public string value; // 0x18
}

// Namespace: 
[Serializable]
internal struct MatcherJson
{
	// Fields
	public string interface; // 0x10
	public string[] interfaces; // 0x18
	public string deviceClass; // 0x20
	public string[] deviceClasses; // 0x28
	public string manufacturer; // 0x30
	public string[] manufacturers; // 0x38
	public string product; // 0x40
	public string[] products; // 0x48
	public string version; // 0x50
	public string[] versions; // 0x58
	public Capability[] capabilities; // 0x60

	// Methods

	// RVA: 0x1488124
	public static MatcherJson FromMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x148862C
	public InputDeviceMatcher ToMatcher() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputDeviceMatcher.<>c <>9; // 0x0
	public static System.Func<System.Char,System.Boolean> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x1488D44
	private static void .cctor() { }

	// RVA: 0x1488DB0
	public void .ctor() { }

	// RVA: 0x1488DB8
	internal bool <With>b__11_0(Char ch) { }

}

// Namespace: 
private sealed class <get_patterns>d__4
{
	// Fields
	private int <>1__state; // 0x10
	private System.Collections.Generic.KeyValuePair<System.String,System.Object> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	public InputDeviceMatcher <>4__this; // 0x30
	public InputDeviceMatcher <>3__<>4__this; // 0x38
	private int <count>5__2; // 0x40
	private int <i>5__3; // 0x44

	// Methods

	// RVA: 0x1486C50
	public void .ctor(int <>1__state) { }

	// RVA: 0x1488E84
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1488E88
	private bool MoveNext() { }

	// RVA: 0x14890F8
	private System.Collections.Generic.KeyValuePair<System.String,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	// RVA: 0x1489104
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1489144
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x14891AC
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1489258
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public struct InputDeviceMatcher
{
	// Fields
	private System.Collections.Generic.KeyValuePair<UnityEngine.InputSystem.Utilities.InternedString,System.Object>[] m_Patterns; // 0x10
	private static readonly InternedString kInterfaceKey; // 0x0
	private static readonly InternedString kDeviceClassKey; // 0x10
	private static readonly InternedString kManufacturerKey; // 0x20
	private static readonly InternedString kProductKey; // 0x30
	private static readonly InternedString kVersionKey; // 0x40

	// Methods

	// RVA: 0x1486BB4
	public bool get_empty() { }

	// RVA: 0x1486BC4
	public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> get_patterns() { }

	// RVA: 0x1486C88
	public InputDeviceMatcher WithInterface(string pattern, bool supportRegex) { }

	// RVA: 0x1486F2C
	public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex) { }

	// RVA: 0x1486FB0
	public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex) { }

	// RVA: 0x1487034
	public InputDeviceMatcher WithProduct(string pattern, bool supportRegex) { }

	// RVA: 0x14870B8
	public InputDeviceMatcher WithVersion(string pattern, bool supportRegex) { }

	// RVA: 0x316B894
	public InputDeviceMatcher WithCapability(string path, TValue value) { }

	// RVA: 0x1486D0C
	private InputDeviceMatcher With(InternedString key, object value, bool supportRegex) { }

	// RVA: 0x147F260
	public float MatchPercentage(InputDeviceDescription deviceDescription) { }

	// RVA: 0x148713C
	private static bool MatchSingleProperty(object pattern, string value) { }

	// RVA: 0x1487228
	private static int GetNumPropertiesIn(InputDeviceDescription description) { }

	// RVA: 0x14872D0
	public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	// RVA: 0x1487660
	public override string ToString() { }

	// RVA: 0x1487A34
	public bool Equals(InputDeviceMatcher other) { }

	// RVA: 0x1487DB8
	public override bool Equals(object obj) { }

	// RVA: 0x1480CD8
	public static bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x1487E6C
	public static bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x1487F44
	public override int GetHashCode() { }

	// RVA: 0x1487F5C
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class AnyKeyControl
{
	// Methods

	// RVA: 0x148925C
	public void .ctor() { }

	// RVA: 0x14893F8
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

}

// Namespace: 
public enum Clamp
{
	// Fields
	public int value__; // 0x10
	public const Clamp None = 0;
	public const Clamp BeforeNormalize = 1;
	public const Clamp AfterNormalize = 2;
	public const Clamp ToConstantBeforeNormalize = 3;
}

// Namespace: UnityEngine.InputSystem.Controls
public class AxisControl
{
	// Fields
	public Clamp clamp; // 0x104
	public float clampMin; // 0x108
	public float clampMax; // 0x10C
	public float clampConstant; // 0x110
	public bool invert; // 0x114
	public bool normalize; // 0x115
	public float normalizeMin; // 0x118
	public float normalizeMax; // 0x11C
	public float normalizeZero; // 0x120
	public bool scale; // 0x124
	public float scaleFactor; // 0x128

	// Methods

	// RVA: 0x1489424
	protected float Preprocess(float value) { }

	// RVA: 0x14894F4
	private float Unpreprocess(float value) { }

	// RVA: 0x148954C
	public void .ctor() { }

	// RVA: 0x14895D8
	protected override void FinishSetup() { }

	// RVA: 0x14896C8
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1489860
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x14899A4
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x1489AB0
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x1489B28
	private float EvaluateMagnitude(float value) { }

	// RVA: 0x1489C04
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class ButtonControl
{
	// Fields
	public float pressPoint; // 0x12C
	internal static float s_GlobalDefaultButtonPressPoint; // 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x4
	internal const float kMinButtonPressPoint = 0.0001;

	// Methods

	// RVA: 0x1489D80
	public float get_pressPointOrDefault() { }

	// RVA: 0x14892D8
	public void .ctor() { }

	// RVA: 0x1489DF4
	public bool IsValueConsideredPressed(float value) { }

	// RVA: 0x1489E88
	public bool get_isPressed() { }

	// RVA: 0x1489F34
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x148A090
	public bool get_wasReleasedThisFrame() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class DeltaControl
{
	// Fields
	private AxisControl <up>k__BackingField; // 0x120
	private AxisControl <down>k__BackingField; // 0x128
	private AxisControl <left>k__BackingField; // 0x130
	private AxisControl <right>k__BackingField; // 0x138

	// Methods

	// RVA: 0x148A1EC
	public AxisControl get_up() { }

	// RVA: 0x148A1F4
	public void set_up(AxisControl value) { }

	// RVA: 0x148A204
	public AxisControl get_down() { }

	// RVA: 0x148A20C
	public void set_down(AxisControl value) { }

	// RVA: 0x148A21C
	public AxisControl get_left() { }

	// RVA: 0x148A224
	public void set_left(AxisControl value) { }

	// RVA: 0x148A234
	public AxisControl get_right() { }

	// RVA: 0x148A23C
	public void set_right(AxisControl value) { }

	// RVA: 0x148A24C
	protected override void FinishSetup() { }

	// RVA: 0x148A454
	public void .ctor() { }

}

// Namespace: 
public enum WriteMode
{
	// Fields
	public int value__; // 0x10
	public const WriteMode WriteDisabled = 0;
	public const WriteMode WriteNullAndMaxValue = 1;
}

// Namespace: UnityEngine.InputSystem.Controls
public class DiscreteButtonControl
{
	// Fields
	public int minValue; // 0x130
	public int maxValue; // 0x134
	public int wrapAtValue; // 0x138
	public int nullValue; // 0x13C
	public WriteMode writeMode; // 0x140

	// Methods

	// RVA: 0x148A56C
	protected override void FinishSetup() { }

	// RVA: 0x148A69C
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148A834
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x148A994
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class DoubleControl
{
	// Methods

	// RVA: 0x148A998
	public void .ctor() { }

	// RVA: 0x148AA24
	public override Double ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148AA90
	public override void WriteValueIntoState(Double value, Void* statePtr) { }

}

// Namespace: 
public class DpadAxisControl
{
	// Fields
	private int <component>k__BackingField; // 0x12C

	// Methods

	// RVA: 0x148B278
	public int get_component() { }

	// RVA: 0x148B280
	public void set_component(int value) { }

	// RVA: 0x148B288
	protected override void FinishSetup() { }

	// RVA: 0x148B314
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148B40C
	public void .ctor() { }

}

// Namespace: 
internal enum ButtonBits
{
	// Fields
	public int value__; // 0x10
	public const ButtonBits Up = 0;
	public const ButtonBits Down = 1;
	public const ButtonBits Left = 2;
	public const ButtonBits Right = 3;
}

// Namespace: UnityEngine.InputSystem.Controls
public class DpadControl
{
	// Fields
	private ButtonControl <up>k__BackingField; // 0x120
	private ButtonControl <down>k__BackingField; // 0x128
	private ButtonControl <left>k__BackingField; // 0x130
	private ButtonControl <right>k__BackingField; // 0x138

	// Methods

	// RVA: 0x148AB0C
	public ButtonControl get_up() { }

	// RVA: 0x148AB14
	public void set_up(ButtonControl value) { }

	// RVA: 0x148AB24
	public ButtonControl get_down() { }

	// RVA: 0x148AB2C
	public void set_down(ButtonControl value) { }

	// RVA: 0x148AB3C
	public ButtonControl get_left() { }

	// RVA: 0x148AB44
	public void set_left(ButtonControl value) { }

	// RVA: 0x148AB54
	public ButtonControl get_right() { }

	// RVA: 0x148AB5C
	public void set_right(ButtonControl value) { }

	// RVA: 0x148AB6C
	public void .ctor() { }

	// RVA: 0x148AC6C
	protected override void FinishSetup() { }

	// RVA: 0x148AD9C
	public override Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148B0A0
	public override void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x148B040
	public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize) { }

	// RVA: 0x148B268
	public static Vector2 MakeDpadVector(float up, float down, float left, float right) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class IntegerControl
{
	// Methods

	// RVA: 0x148B498
	public void .ctor() { }

	// RVA: 0x148B524
	public override int ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148B5E8
	public override void WriteValueIntoState(int value, Void* statePtr) { }

	// RVA: 0x148B6B4
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class KeyControl
{
	// Fields
	private Key <keyCode>k__BackingField; // 0x130
	private int m_ScanCode; // 0x134

	// Methods

	// RVA: 0x148B7D8
	public Key get_keyCode() { }

	// RVA: 0x148B7E0
	public void set_keyCode(Key value) { }

	// RVA: 0x148B7E8
	public int get_scanCode() { }

	// RVA: 0x148B810
	protected override void RefreshConfiguration() { }

	// RVA: 0x148B99C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class QuaternionControl
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x120
	private AxisControl <y>k__BackingField; // 0x128
	private AxisControl <z>k__BackingField; // 0x130
	private AxisControl <w>k__BackingField; // 0x138

	// Methods

	// RVA: 0x148B9A0
	public AxisControl get_x() { }

	// RVA: 0x148B9A8
	public void set_x(AxisControl value) { }

	// RVA: 0x148B9B8
	public AxisControl get_y() { }

	// RVA: 0x148B9C0
	public void set_y(AxisControl value) { }

	// RVA: 0x148B9D0
	public AxisControl get_z() { }

	// RVA: 0x148B9D8
	public void set_z(AxisControl value) { }

	// RVA: 0x148B9E8
	public AxisControl get_w() { }

	// RVA: 0x148B9F0
	public void set_w(AxisControl value) { }

	// RVA: 0x148BA00
	public void .ctor() { }

	// RVA: 0x148BA94
	protected override void FinishSetup() { }

	// RVA: 0x148BBDC
	public override Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148BD24
	public override void WriteValueIntoState(Quaternion value, Void* statePtr) { }

	// RVA: 0x148BE60
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class StickControl
{
	// Fields
	private ButtonControl <up>k__BackingField; // 0x120
	private ButtonControl <down>k__BackingField; // 0x128
	private ButtonControl <left>k__BackingField; // 0x130
	private ButtonControl <right>k__BackingField; // 0x138

	// Methods

	// RVA: 0x148C0E8
	public ButtonControl get_up() { }

	// RVA: 0x148C0F0
	public void set_up(ButtonControl value) { }

	// RVA: 0x148C100
	public ButtonControl get_down() { }

	// RVA: 0x148C108
	public void set_down(ButtonControl value) { }

	// RVA: 0x148C118
	public ButtonControl get_left() { }

	// RVA: 0x148C120
	public void set_left(ButtonControl value) { }

	// RVA: 0x148C130
	public ButtonControl get_right() { }

	// RVA: 0x148C138
	public void set_right(ButtonControl value) { }

	// RVA: 0x148C148
	protected override void FinishSetup() { }

	// RVA: 0x148C278
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchControl
{
	// Fields
	private TouchPressControl <press>k__BackingField; // 0x170
	private IntegerControl <displayIndex>k__BackingField; // 0x178
	private IntegerControl <touchId>k__BackingField; // 0x180
	private Vector2Control <position>k__BackingField; // 0x188
	private DeltaControl <delta>k__BackingField; // 0x190
	private AxisControl <pressure>k__BackingField; // 0x198
	private Vector2Control <radius>k__BackingField; // 0x1A0
	private TouchPhaseControl <phase>k__BackingField; // 0x1A8
	private ButtonControl <indirectTouch>k__BackingField; // 0x1B0
	private ButtonControl <tap>k__BackingField; // 0x1B8
	private IntegerControl <tapCount>k__BackingField; // 0x1C0
	private DoubleControl <startTime>k__BackingField; // 0x1C8
	private Vector2Control <startPosition>k__BackingField; // 0x1D0

	// Methods

	// RVA: 0x148C304
	public TouchPressControl get_press() { }

	// RVA: 0x148C30C
	public void set_press(TouchPressControl value) { }

	// RVA: 0x148C31C
	public IntegerControl get_displayIndex() { }

	// RVA: 0x148C324
	public void set_displayIndex(IntegerControl value) { }

	// RVA: 0x148C334
	public IntegerControl get_touchId() { }

	// RVA: 0x148C33C
	public void set_touchId(IntegerControl value) { }

	// RVA: 0x148C34C
	public Vector2Control get_position() { }

	// RVA: 0x148C354
	public void set_position(Vector2Control value) { }

	// RVA: 0x148C364
	public DeltaControl get_delta() { }

	// RVA: 0x148C36C
	public void set_delta(DeltaControl value) { }

	// RVA: 0x148C37C
	public AxisControl get_pressure() { }

	// RVA: 0x148C384
	public void set_pressure(AxisControl value) { }

	// RVA: 0x148C394
	public Vector2Control get_radius() { }

	// RVA: 0x148C39C
	public void set_radius(Vector2Control value) { }

	// RVA: 0x148C3AC
	public TouchPhaseControl get_phase() { }

	// RVA: 0x148C3B4
	public void set_phase(TouchPhaseControl value) { }

	// RVA: 0x148C3C4
	public ButtonControl get_indirectTouch() { }

	// RVA: 0x148C3CC
	public void set_indirectTouch(ButtonControl value) { }

	// RVA: 0x148C3DC
	public ButtonControl get_tap() { }

	// RVA: 0x148C3E4
	public void set_tap(ButtonControl value) { }

	// RVA: 0x148C3F4
	public IntegerControl get_tapCount() { }

	// RVA: 0x148C3FC
	public void set_tapCount(IntegerControl value) { }

	// RVA: 0x148C40C
	public DoubleControl get_startTime() { }

	// RVA: 0x148C414
	public void set_startTime(DoubleControl value) { }

	// RVA: 0x148C424
	public Vector2Control get_startPosition() { }

	// RVA: 0x148C42C
	public void set_startPosition(Vector2Control value) { }

	// RVA: 0x148C43C
	public bool get_isInProgress() { }

	// RVA: 0x148C4A8
	public void .ctor() { }

	// RVA: 0x148C554
	protected override void FinishSetup() { }

	// RVA: 0x148C904
	public override TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148C990
	public override void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPhaseControl
{
	// Methods

	// RVA: 0x148CA68
	public void .ctor() { }

	// RVA: 0x148CAF4
	public override TouchPhase ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148CB74
	public override void WriteValueIntoState(TouchPhase value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPressControl
{
	// Methods

	// RVA: 0x148CBE8
	protected override void FinishSetup() { }

	// RVA: 0x148CD18
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148CEA4
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x148CEE4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class Vector2Control
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x110
	private AxisControl <y>k__BackingField; // 0x118

	// Methods

	// RVA: 0x148CEE8
	public AxisControl get_x() { }

	// RVA: 0x148CEF0
	public void set_x(AxisControl value) { }

	// RVA: 0x148CF00
	public AxisControl get_y() { }

	// RVA: 0x148CF08
	public void set_y(AxisControl value) { }

	// RVA: 0x148A4E0
	public void .ctor() { }

	// RVA: 0x148A37C
	protected override void FinishSetup() { }

	// RVA: 0x148CF18
	public override Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148D000
	public override void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x148D0E4
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x148D1BC
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class Vector3Control
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x118
	private AxisControl <y>k__BackingField; // 0x120
	private AxisControl <z>k__BackingField; // 0x128

	// Methods

	// RVA: 0x148D374
	public AxisControl get_x() { }

	// RVA: 0x148D37C
	public void set_x(AxisControl value) { }

	// RVA: 0x148D38C
	public AxisControl get_y() { }

	// RVA: 0x148D394
	public void set_y(AxisControl value) { }

	// RVA: 0x148D3A4
	public AxisControl get_z() { }

	// RVA: 0x148D3AC
	public void set_z(AxisControl value) { }

	// RVA: 0x148D3BC
	public void .ctor() { }

	// RVA: 0x148D448
	protected override void FinishSetup() { }

	// RVA: 0x148D55C
	public override Vector3 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x148D668
	public override void WriteValueIntoState(Vector3 value, Void* statePtr) { }

	// RVA: 0x148D780
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x148D86C
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public class HoldInteraction
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private Double m_TimePressed; // 0x18

	// Methods

	// RVA: 0x148DA6C
	private float get_durationOrDefault() { }

	// RVA: 0x148DAE0
	private float get_pressPointOrDefault() { }

	// RVA: 0x148DB54
	public void Process(InputInteractionContext context) { }

	// RVA: 0x148DDFC
	public void Reset() { }

	// RVA: 0x148DE04
	public void .ctor() { }

}

// Namespace: 
private enum TapPhase
{
	// Fields
	public int value__; // 0x10
	public const TapPhase None = 0;
	public const TapPhase WaitingForNextRelease = 1;
	public const TapPhase WaitingForNextPress = 2;
}

// Namespace: UnityEngine.InputSystem.Interactions
public class MultiTapInteraction
{
	// Fields
	public float tapTime; // 0x10
	public float tapDelay; // 0x14
	public int tapCount; // 0x18
	public float pressPoint; // 0x1C
	private TapPhase m_CurrentTapPhase; // 0x20
	private int m_CurrentTapCount; // 0x24
	private Double m_CurrentTapStartTime; // 0x28
	private Double m_LastTapReleaseTime; // 0x30

	// Methods

	// RVA: 0x148DE0C
	private float get_tapTimeOrDefault() { }

	// RVA: 0x148DE80
	internal float get_tapDelayOrDefault() { }

	// RVA: 0x148DEF4
	private float get_pressPointOrDefault() { }

	// RVA: 0x148DF68
	private float get_releasePointOrDefault() { }

	// RVA: 0x148E030
	public void Process(InputInteractionContext context) { }

	// RVA: 0x148E4DC
	public void Reset() { }

	// RVA: 0x148E4E8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public class PressInteraction
{
	// Fields
	public float pressPoint; // 0x10
	public PressBehavior behavior; // 0x14
	private bool m_WaitingForRelease; // 0x18

	// Methods

	// RVA: 0x148E4F8
	private float get_pressPointOrDefault() { }

	// RVA: 0x148E56C
	private float get_releasePointOrDefault() { }

	// RVA: 0x148E634
	public void Process(InputInteractionContext context) { }

	// RVA: 0x148EBC0
	public void Reset() { }

	// RVA: 0x148EBC8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public enum PressBehavior
{
	// Fields
	public int value__; // 0x10
	public const PressBehavior PressOnly = 0;
	public const PressBehavior ReleaseOnly = 1;
	public const PressBehavior PressAndRelease = 2;
}

// Namespace: UnityEngine.InputSystem.Interactions
public class SlowTapInteraction
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private Double m_SlowTapStartTime; // 0x18

	// Methods

	// RVA: 0x148EBD0
	private float get_durationOrDefault() { }

	// RVA: 0x148EC44
	private float get_pressPointOrDefault() { }

	// RVA: 0x148ECB8
	public void Process(InputInteractionContext context) { }

	// RVA: 0x148EEB8
	public void Reset() { }

	// RVA: 0x148EEC0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public class TapInteraction
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private Double m_TapStartTime; // 0x18

	// Methods

	// RVA: 0x148EEC8
	private float get_durationOrDefault() { }

	// RVA: 0x148EF3C
	private float get_pressPointOrDefault() { }

	// RVA: 0x148EFB0
	private float get_releasePointOrDefault() { }

	// RVA: 0x148F078
	public void Process(InputInteractionContext context) { }

	// RVA: 0x148F348
	public void Reset() { }

	// RVA: 0x148F350
	public void .ctor() { }

}

// Namespace: 
public struct ActionEventPtr
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal ActionEvent* m_Ptr; // 0x18

	// Methods

	// RVA: 0x13A47D8
	public InputAction get_action() { }

	// RVA: 0x13A4804
	public InputActionPhase get_phase() { }

	// RVA: 0x13A4810
	public InputControl get_control() { }

	// RVA: 0x13A4854
	public IInputInteraction get_interaction() { }

	// RVA: 0x13A48C0
	public Double get_time() { }

	// RVA: 0x13A48E0
	public Double get_startTime() { }

	// RVA: 0x13A48EC
	public Double get_duration() { }

	// RVA: 0x13A4928
	public int get_valueSizeInBytes() { }

	// RVA: 0x13A4934
	public object ReadValueAsObject() { }

	// RVA: 0x13A4B90
	public void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x316B894
	public TValue ReadValue() { }

	// RVA: 0x13A4C9C
	public override string ToString() { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly InputActionTrace m_Trace; // 0x10
	private readonly ActionEvent* m_Buffer; // 0x18
	private readonly int m_EventCount; // 0x20
	private ActionEvent* m_CurrentEvent; // 0x28
	private int m_CurrentIndex; // 0x30

	// Methods

	// RVA: 0x13A50C0
	public void .ctor(InputActionTrace trace) { }

	// RVA: 0x13A5110
	public bool MoveNext() { }

	// RVA: 0x13A51A0
	public void Reset() { }

	// RVA: 0x13A51AC
	public void Dispose() { }

	// RVA: 0x13A51B0
	public ActionEventPtr get_Current() { }

	// RVA: 0x13A5238
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public sealed class InputActionTrace
{
	// Fields
	private bool m_SubscribedToAll; // 0x10
	private bool m_OnActionChangeHooked; // 0x11
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputAction> m_SubscribedActions; // 0x18
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionMap> m_SubscribedActionMaps; // 0x30
	private InputEventBuffer m_EventBuffer; // 0x48
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState> m_ActionMapStates; // 0x68
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState> m_ActionMapStateClones; // 0x80
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_CallbackDelegate; // 0x98
	private System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> m_ActionChangeDelegate; // 0xA0

	// Methods

	// RVA: 0x148F358
	public InputEventBuffer get_buffer() { }

	// RVA: 0x148F368
	public int get_count() { }

	// RVA: 0x148F370
	public void .ctor() { }

	// RVA: 0x148F378
	public void .ctor(InputAction action) { }

	// RVA: 0x148F538
	public void .ctor(InputActionMap actionMap) { }

	// RVA: 0x148F6D8
	public void SubscribeToAll() { }

	// RVA: 0x148FB04
	public void UnsubscribeFromAll() { }

	// RVA: 0x148F3F4
	public void SubscribeTo(InputAction action) { }

	// RVA: 0x148F5B4
	public void SubscribeTo(InputActionMap actionMap) { }

	// RVA: 0x148F8DC
	public void UnsubscribeFrom(InputAction action) { }

	// RVA: 0x148FA00
	public void UnsubscribeFrom(InputActionMap actionMap) { }

	// RVA: 0x148FCB4
	public void RecordAction(CallbackContext context) { }

	// RVA: 0x148FE84
	public void Clear() { }

	// RVA: 0x148FEE4
	protected override void Finalize() { }

	// RVA: 0x1490094
	public override string ToString() { }

	// RVA: 0x14904BC
	public void Dispose() { }

	// RVA: 0x148FF74
	private void DisposeInternal() { }

	// RVA: 0x1490430
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator() { }

	// RVA: 0x14904E0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x148F7D0
	private void HookOnActionChange() { }

	// RVA: 0x148FC44
	private void UnhookOnActionChange() { }

	// RVA: 0x149056C
	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	// RVA: 0x14907E8
	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0<T0>
{
	// Fields
	public TValue secondValue; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal bool <Merge>b__0(TValue x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0<T0>
{
	// Fields
	public System.Collections.Generic.IEqualityComparer<TValue> comparer; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1<T0>
{
	// Fields
	public TValue secondValue; // 0x0
	public UnityEngine.InputSystem.Utilities.ArrayHelpers.<>c__DisplayClass34_0<TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal bool <Merge>b__0(TValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ArrayHelpers
{
	// Methods

	// RVA: 0x30B4880
	public static int LengthSafe(TValue[] array) { }

	// RVA: 0x30B8148
	public static void Clear(TValue[] array) { }

	// RVA: 0x30B8450
	public static void Clear(TValue[] array, int count) { }

	// RVA: 0x30B933C
	public static void Clear(TValue[] array, int count) { }

	// RVA: -1
	public static void EnsureCapacity(TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: -1
	public static void DuplicateWithCapacity(TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: 0x316B894
	public static bool Contains(TValue[] array, TValue value) { }

	// RVA: 0x316B894
	public static bool ContainsReference(TValue[] array, TValue value) { }

	// RVA: 0x316B894
	public static bool ContainsReference(TFirst[] array, int count, TSecond value) { }

	// RVA: 0x316B894
	public static bool ContainsReference(TFirst[] array, int startIndex, int count, TSecond value) { }

	// RVA: -1
	public static bool HaveDuplicateReferences(TFirst[] first, int index, int count) { }

	// RVA: 0x30B4174
	public static bool HaveEqualElements(TValue[] first, TValue[] second, int count) { }

	// RVA: 0x316B894
	public static int IndexOf(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x30B4D6C
	public static int IndexOf(TValue[] array, System.Predicate<TValue> predicate) { }

	// RVA: 0x30B4DD4
	public static int IndexOf(TValue[] array, System.Predicate<TValue> predicate, int startIndex, int count) { }

	// RVA: 0x316B894
	public static int IndexOfReference(TFirst[] array, TSecond value, int count) { }

	// RVA: 0x316B894
	public static int IndexOfReference(TFirst[] array, TSecond value, int startIndex, int count) { }

	// RVA: 0x316B894
	public static int IndexOfValue(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x30B8538
	public static void Resize(Unity.Collections.NativeArray<TValue>& array, int newSize, Allocator allocator) { }

	// RVA: 0x316B894
	public static int Append(TValue[] array, TValue value) { }

	// RVA: 0x30B4D6C
	public static int Append(TValue[] array, System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x30B4D6C
	public static int AppendToImmutable(TValue[] array, TValue[] values) { }

	// RVA: 0x316B894
	public static int AppendWithCapacity(TValue[] array, int count, TValue value, int capacityIncrement) { }

	// RVA: 0x316B894
	public static int AppendListWithCapacity(TValue[] array, int length, TValues values, int capacityIncrement) { }

	// RVA: 0x316B894
	public static int AppendWithCapacity(Unity.Collections.NativeArray<TValue>& array, int count, TValue value, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x316B894
	public static void InsertAt(TValue[] array, int index, TValue value) { }

	// RVA: 0x316B894
	public static void InsertAtWithCapacity(TValue[] array, int count, int index, TValue value, int capacityIncrement) { }

	// RVA: 0x30B8894
	public static void PutAtIfNotSet(TValue[] array, int index, System.Func<TValue> valueFn) { }

	// RVA: -1
	public static int GrowBy(TValue[] array, int count) { }

	// RVA: 0x30B48E4
	public static int GrowBy(Unity.Collections.NativeArray<TValue>& array, int count, Allocator allocator) { }

	// RVA: 0x30B4DD4
	public static int GrowWithCapacity(TValue[] array, int count, int growBy, int capacityIncrement) { }

	// RVA: -1
	public static int GrowWithCapacity(Unity.Collections.NativeArray<TValue>& array, int count, int growBy, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x316B894
	public static TValue[] Join(TValue value, TValue[] values) { }

	// RVA: 0x30B58A8
	public static TValue[] Merge(TValue[] first, TValue[] second) { }

	// RVA: 0x30B5A04
	public static TValue[] Merge(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x30B8450
	public static void EraseAt(TValue[] array, int index) { }

	// RVA: 0x30B9504
	public static void EraseAtWithCapacity(TValue[] array, int count, int index) { }

	// RVA: 0x316B894
	public static void EraseAtWithCapacity(Unity.Collections.NativeArray<TValue> array, int count, int index) { }

	// RVA: 0x316B894
	public static bool Erase(TValue[] array, TValue value) { }

	// RVA: 0x30B9504
	public static void EraseAtByMovingTail(TValue[] array, int count, int index) { }

	// RVA: 0x30B57C8
	public static TValue[] Copy(TValue[] array) { }

	// RVA: 0x30B57C8
	public static TValue[] Clone(TValue[] array) { }

	// RVA: 0x30B58A8
	public static TNew[] Select(TOld[] array, System.Func<TOld,TNew> converter) { }

	// RVA: 0x30B933C
	private static void Swap(TValue first, TValue second) { }

	// RVA: -1
	public static void MoveSlice(TValue[] array, int sourceIndex, int destinationIndex, int count) { }

	// RVA: 0x30B9578
	public static void EraseSliceWithCapacity(TValue[] array, int length, int index, int count) { }

	// RVA: 0x30B8538
	public static void SwapElements(TValue[] array, int index1, int index2) { }

	// RVA: 0x316B894
	public static void SwapElements(Unity.Collections.NativeArray<TValue> array, int index1, int index2) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct CallbackArray<T0>
{
	// Fields
	private bool m_CannotMutateCallbacksArray; // 0x0
	private UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_Callbacks; // 0x0
	private UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToAdd; // 0x0
	private UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToRemove; // 0x0

	// Methods

	// RVA: 0x30B199C
	public int get_length() { }

	// RVA: 0x316B894
	public TDelegate get_Item(int index) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public void AddCallback(TDelegate dlg) { }

	// RVA: 0x316B894
	public void RemoveCallback(TDelegate dlg) { }

	// RVA: 0x30B2870
	public void LockForChanges() { }

	// RVA: 0x30B2870
	public void UnlockForChanges() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector2MagnitudeComparer
{
	// Methods

	// RVA: 0x13A530C
	public int Compare(Vector2 x, Vector2 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector3MagnitudeComparer
{
	// Methods

	// RVA: 0x13A5334
	public int Compare(Vector3 x, Vector3 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class CSharpCodeHelpers
{
	// Methods

	// RVA: 0x13A536C
	public static bool IsProperIdentifier(string name) { }

	// RVA: 0x13A54A0
	public static bool IsEmptyOrProperIdentifier(string name) { }

	// RVA: 0x13A54DC
	public static bool IsEmptyOrProperNamespaceName(string name) { }

	// RVA: 0x13A55B0
	public static string MakeIdentifier(string name, string suffix) { }

	// RVA: 0x13A585C
	public static string MakeTypeName(string name, string suffix) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class DelegateHelpers
{
	// Methods

	// RVA: 0x13A5988
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>& callbacks, string callbackName, object context) { }

	// RVA: 0x316B894
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x316B894
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1,TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x316B894
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1,TValue2,System.Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x316B894
	public static void InvokeCallbacksSafe_AndInvokeReturnedActions(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,System.Action>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x316B894
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,TReturn>>& callbacks, TValue argument, string callbackName, object context) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public class DisplayStringFormatAttribute
{
	// Fields
	private string <formatString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13A5C84
	public string get_formatString() { }

	// RVA: 0x13A5C8C
	public void set_formatString(string value) { }

	// RVA: 0x13A5C94
	public void .ctor(string formatString) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ExceptionHelpers
{
	// Methods

	// RVA: 0x13A5CC8
	public static bool IsExceptionIndicatingBugInCode(Exception exception) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct FourCC
{
	// Fields
	private int m_Code; // 0x10

	// Methods

	// RVA: 0x13A5DC4
	public void .ctor(int code) { }

	// RVA: 0x13A5DCC
	public void .ctor(Char a, Char b, Char c, Char d) { }

	// RVA: 0x13A5DE4
	public void .ctor(string str) { }

	// RVA: 0x13A5F64
	public static int op_Implicit(FourCC fourCC) { }

	// RVA: 0x13A5F68
	public static FourCC op_Implicit(int i) { }

	// RVA: 0x13A5F6C
	public override string ToString() { }

	// RVA: 0x13A614C
	public bool Equals(FourCC other) { }

	// RVA: 0x13A615C
	public override bool Equals(object obj) { }

	// RVA: 0x13A61EC
	public override int GetHashCode() { }

	// RVA: 0x13A61F4
	public static bool op_Equality(FourCC left, FourCC right) { }

	// RVA: 0x13A6200
	public static bool op_Inequality(FourCC left, FourCC right) { }

	// RVA: 0x13A620C
	public static FourCC FromInt32(int i) { }

	// RVA: 0x13A6210
	public static int ToInt32(FourCC fourCC) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public TValue get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	public void Dispose() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct InlinedArray<T0>
{
	// Fields
	public int length; // 0x0
	public TValue firstValue; // 0x0
	public TValue[] additionalValues; // 0x0

	// Methods

	// RVA: 0x30B199C
	public int get_Capacity() { }

	// RVA: 0x316B894
	public void .ctor(TValue value) { }

	// RVA: 0x316B894
	public void .ctor(TValue firstValue, TValue[] additionalValues) { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x316B894
	public TValue get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, TValue value) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x30B2870
	public void ClearWithCapacity() { }

	// RVA: 0x316B894
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone() { }

	// RVA: 0x30B29E8
	public void SetLength(int size) { }

	// RVA: 0x30B1CD4
	public TValue[] ToArray() { }

	// RVA: 0x30B1D84
	public TOther[] ToArray(System.Func<TValue,TOther> mapFunction) { }

	// RVA: 0x316B894
	public int IndexOf(TValue value) { }

	// RVA: 0x316B894
	public int Append(TValue value) { }

	// RVA: 0x316B894
	public int AppendWithCapacity(TValue value, int capacityIncrement) { }

	// RVA: 0x316B894
	public void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values) { }

	// RVA: 0x30B2CB8
	public void Append(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x316B894
	public void Remove(TValue value) { }

	// RVA: 0x30B29E8
	public void RemoveAtWithCapacity(int index) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int index) { }

	// RVA: 0x30B29E8
	public void RemoveAtByMovingTailWithCapacity(int index) { }

	// RVA: 0x316B894
	public bool RemoveByMovingTailWithCapacity(TValue value) { }

	// RVA: 0x316B894
	public bool Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x316B894
	public void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class InputArrayExtensions
{
	// Methods

	// RVA: 0x316B894
	public static int IndexOfReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x316B894
	public static bool Contains(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x316B894
	public static bool ContainsReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct InternedString
{
	// Fields
	private readonly string m_StringOriginalCase; // 0x10
	private readonly string m_StringLowerCase; // 0x18

	// Methods

	// RVA: 0x13A6214
	public int get_length() { }

	// RVA: 0x13A622C
	public void .ctor(string text) { }

	// RVA: 0x13A6318
	public bool IsEmpty() { }

	// RVA: 0x13A6328
	public string ToLower() { }

	// RVA: 0x13A6330
	public override bool Equals(object obj) { }

	// RVA: 0x13A6458
	public bool Equals(InternedString other) { }

	// RVA: 0x13A6468
	public int CompareTo(InternedString other) { }

	// RVA: 0x13A647C
	public override int GetHashCode() { }

	// RVA: 0x13A6494
	public override string ToString() { }

	// RVA: 0x13A6500
	public static bool op_Equality(InternedString a, InternedString b) { }

	// RVA: 0x13A650C
	public static bool op_Inequality(InternedString a, InternedString b) { }

	// RVA: 0x13A6518
	public static bool op_Equality(InternedString a, string b) { }

	// RVA: 0x13A65CC
	public static bool op_Inequality(InternedString a, string b) { }

	// RVA: 0x13A6680
	public static bool op_Equality(string a, InternedString b) { }

	// RVA: 0x13A6730
	public static bool op_Inequality(string a, InternedString b) { }

	// RVA: 0x13A67E0
	public static bool op_LessThan(InternedString left, InternedString right) { }

	// RVA: 0x13A6808
	public static bool op_GreaterThan(InternedString left, InternedString right) { }

	// RVA: 0x13A6834
	public static string op_Implicit(InternedString str) { }

}

// Namespace: 
public enum JsonValueType
{
	// Fields
	public int value__; // 0x10
	public const JsonValueType None = 0;
	public const JsonValueType Bool = 1;
	public const JsonValueType Real = 2;
	public const JsonValueType Integer = 3;
	public const JsonValueType String = 4;
	public const JsonValueType Array = 5;
	public const JsonValueType Object = 6;
	public const JsonValueType Any = 7;
}

// Namespace: 
public struct JsonString
{
	// Fields
	public Substring text; // 0x10
	public bool hasEscapes; // 0x20

	// Methods

	// RVA: 0x13A8418
	public override string ToString() { }

	// RVA: 0x13A867C
	public bool Equals(JsonString other) { }

	// RVA: 0x13A8844
	public override bool Equals(object obj) { }

	// RVA: 0x13A88EC
	public override int GetHashCode() { }

	// RVA: 0x13A8AA8
	public static bool op_Equality(JsonString left, JsonString right) { }

	// RVA: 0x13A8AD8
	public static bool op_Inequality(JsonString left, JsonString right) { }

	// RVA: 0x13A8B0C
	public static JsonString op_Implicit(string str) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Utilities.JsonParser.JsonValue.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue,System.String> <>9__11_0; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>,System.String> <>9__11_1; // 0x10

	// Methods

	// RVA: 0x13AA438
	private static void .cctor() { }

	// RVA: 0x13AA4A4
	public void .ctor() { }

	// RVA: 0x13AA4AC
	internal string <ToString>b__11_0(JsonValue x) { }

	// RVA: 0x13AA4B4
	internal string <ToString>b__11_1(System.Collections.Generic.KeyValuePair<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> pair) { }

}

// Namespace: 
public struct JsonValue
{
	// Fields
	public JsonValueType type; // 0x10
	public bool boolValue; // 0x14
	public Double realValue; // 0x18
	public Int64 integerValue; // 0x20
	public JsonString stringValue; // 0x28
	public System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> arrayValue; // 0x40
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> objectValue; // 0x48
	public object anyValue; // 0x50

	// Methods

	// RVA: 0x13A8BE8
	public bool ToBoolean() { }

	// RVA: 0x13A92D0
	public Int64 ToInteger() { }

	// RVA: 0x13A93CC
	public Double ToDouble() { }

	// RVA: 0x13A8E38
	public override string ToString() { }

	// RVA: 0x13A83E0
	public static JsonValue op_Implicit(bool val) { }

	// RVA: 0x13A82D4
	public static JsonValue op_Implicit(Int64 val) { }

	// RVA: 0x13A82FC
	public static JsonValue op_Implicit(Double val) { }

	// RVA: 0x13A94B8
	public static JsonValue op_Implicit(string str) { }

	// RVA: 0x13A81F4
	public static JsonValue op_Implicit(JsonString str) { }

	// RVA: 0x13A826C
	public static JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array) { }

	// RVA: 0x13A9570
	public static JsonValue op_Implicit(System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj) { }

	// RVA: 0x13A95D4
	public static JsonValue op_Implicit(Enum val) { }

	// RVA: 0x13A9638
	public bool Equals(JsonValue other) { }

	// RVA: 0x13A98B0
	private static bool Equals(object obj, JsonValue value) { }

	// RVA: 0x13AA1F4
	public override bool Equals(object obj) { }

	// RVA: 0x13AA2A4
	public override int GetHashCode() { }

	// RVA: 0x13A7488
	public static bool op_Equality(JsonValue left, JsonValue right) { }

	// RVA: 0x13AA3FC
	public static bool op_Inequality(JsonValue left, JsonValue right) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct JsonParser
{
	// Fields
	private readonly string m_Text; // 0x10
	private readonly int m_Length; // 0x18
	private int m_Position; // 0x1C
	private bool m_MatchAnyElementInArray; // 0x20
	private bool m_DryRun; // 0x21

	// Methods

	// RVA: 0x13A68A0
	public void .ctor(string json) { }

	// RVA: 0x13A6924
	public void Reset() { }

	// RVA: 0x13A6930
	public override string ToString() { }

	// RVA: 0x13A6A30
	public bool NavigateToProperty(string path) { }

	// RVA: 0x13A7134
	public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) { }

	// RVA: 0x13A6F74
	public bool ParseToken(Char token) { }

	// RVA: 0x13A7104
	public bool ParseValue() { }

	// RVA: 0x13A72DC
	public bool ParseValue(JsonValue result) { }

	// RVA: 0x13A74C0
	public bool ParseStringValue(JsonValue result) { }

	// RVA: 0x13A7680
	public bool ParseArrayValue(JsonValue result) { }

	// RVA: 0x13A79C4
	public bool ParseObjectValue(JsonValue result) { }

	// RVA: 0x13A7D40
	public bool ParseNumber(JsonValue result) { }

	// RVA: 0x13A7BCC
	public bool ParseBooleanValue(JsonValue result) { }

	// RVA: 0x13A7CD8
	public bool ParseNullValue(JsonValue result) { }

	// RVA: 0x13A7094
	public bool SkipToValue() { }

	// RVA: 0x13A831C
	private bool SkipString(string text) { }

	// RVA: 0x13A6FF0
	private void SkipWhitespace() { }

	// RVA: 0x13A8408
	public bool get_isAtEnd() { }

}

// Namespace: 
public struct BitRegion
{
	// Fields
	public UInt32 bitOffset; // 0x10
	public UInt32 sizeInBits; // 0x14

	// Methods

	// RVA: 0x13AB1E8
	public bool get_isEmpty() { }

	// RVA: 0x13AB1F8
	public void .ctor(UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x13AB200
	public void .ctor(UInt32 byteOffset, UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x13AB20C
	public BitRegion Overlap(BitRegion other) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MemoryHelpers
{
	// Methods

	// RVA: 0x13AA67C
	public static bool Compare(Void* ptr1, Void* ptr2, BitRegion region) { }

	// RVA: 0x13AA860
	public static UInt32 ComputeFollowingByteOffset(UInt32 byteOffset, UInt32 sizeInBits) { }

	// RVA: 0x13AA870
	public static void WriteSingleBit(Void* ptr, UInt32 bitOffset, bool value) { }

	// RVA: 0x13AA6C0
	public static bool ReadSingleBit(Void* ptr, UInt32 bitOffset) { }

	// RVA: 0x13AA8A0
	public static void MemCpyBitRegion(Void* destination, Void* source, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13AA6DC
	public static bool MemCmpBitRegion(Void* ptr1, Void* ptr2, UInt32 bitOffset, UInt32 bitCount, Void* mask) { }

	// RVA: 0x13AA998
	public static void MemSet(Void* destination, int numBytes, Byte value) { }

	// RVA: 0x13AAA70
	public static void MemCpyMasked(Void* destination, Void* source, int numBytes, Void* mask) { }

	// RVA: 0x13AAB04
	public static UInt32 ReadMultipleBitsAsUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13AAC98
	public static void WriteUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, UInt32 value) { }

	// RVA: 0x13AAE7C
	public static int ReadTwosComplementMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13AAE80
	public static void WriteIntAsTwosComplementMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x13AAE84
	public static int ReadExcessKMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13AAEB4
	public static void WriteIntAsExcessKMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x13AAEC8
	public static float ReadMultipleBitsAsNormalizedUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13AAF24
	public static void WriteNormalizedUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, float value) { }

	// RVA: 0x13AAF74
	public static void SetBitsInBuffer(Void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	// RVA: 0x30B933C
	public static void Swap(TValue a, TValue b) { }

	// RVA: 0x13AB160
	public static UInt32 AlignNatural(UInt32 offset, UInt32 sizeInBytes) { }

}

// Namespace: 
private sealed class <EveryNth>d__1<T0>
{
	// Fields
	private int <>1__state; // 0x0
	private TValue <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private System.Collections.Generic.IEnumerable<TValue> enumerable; // 0x0
	public System.Collections.Generic.IEnumerable<TValue> <>3__enumerable; // 0x0
	private int start; // 0x0
	public int <>3__start; // 0x0
	private int n; // 0x0
	public int <>3__n; // 0x0
	private int <index>5__2; // 0x0
	private System.Collections.Generic.IEnumerator<TValue> <>7__wrap2; // 0x0

	// Methods

	// RVA: 0x30B29E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x30B2870
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30B171C
	private bool MoveNext() { }

	// RVA: 0x30B2870
	private void <>m__Finally1() { }

	// RVA: 0x316B894
	private TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MiscHelpers
{
	// Methods

	// RVA: 0x316B894
	public static TValue GetValueOrDefault(System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key) { }

	// RVA: -1
	public static System.Collections.Generic.IEnumerable<TValue> EveryNth(System.Collections.Generic.IEnumerable<TValue> enumerable, int n, int start) { }

	// RVA: 0x316B894
	public static int IndexOf(System.Collections.Generic.IEnumerable<TValue> enumerable, TValue value) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Utilities.NameAndParameters.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.NamedValue,System.String> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x13ABEA0
	private static void .cctor() { }

	// RVA: 0x13ABF0C
	public void .ctor() { }

	// RVA: 0x13ABF14
	internal string <ToString>b__8_0(NamedValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct NameAndParameters
{
	// Fields
	private string <name>k__BackingField; // 0x10
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13AB2E4
	public string get_name() { }

	// RVA: 0x13AB2EC
	public void set_name(string value) { }

	// RVA: 0x13AB2F4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x13AB300
	public void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x13AB30C
	public override string ToString() { }

	// RVA: 0x13AB51C
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text) { }

	// RVA: 0x13AB634
	internal static bool ParseMultiple(string text, System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>& list) { }

	// RVA: 0x13ABBA4
	internal static string ParseName(string text) { }

	// RVA: 0x13ABC28
	public static NameAndParameters Parse(string text) { }

	// RVA: 0x13AB7E4
	private static NameAndParameters ParseNameAndParameters(string text, int index, bool nameOnly) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct NamedValue
{
	// Fields
	public const string Separator = ",";
	private string <name>k__BackingField; // 0x10
	private PrimitiveValue <value>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13AC03C
	public string get_name() { }

	// RVA: 0x13AC044
	public void set_name(string value) { }

	// RVA: 0x13AC04C
	public PrimitiveValue get_value() { }

	// RVA: 0x13AC058
	public void set_value(PrimitiveValue value) { }

	// RVA: 0x13AC060
	public TypeCode get_type() { }

	// RVA: 0x13AC068
	public NamedValue ConvertTo(TypeCode type) { }

	// RVA: 0x316B894
	public static NamedValue From(string name, TValue value) { }

	// RVA: 0x13ABFA8
	public override string ToString() { }

	// RVA: 0x13AC874
	public bool Equals(NamedValue other) { }

	// RVA: 0x13AC96C
	public override bool Equals(object obj) { }

	// RVA: 0x13ACA6C
	public override int GetHashCode() { }

	// RVA: 0x13ACB40
	public static bool op_Equality(NamedValue left, NamedValue right) { }

	// RVA: 0x13ACBE0
	public static bool op_Inequality(NamedValue left, NamedValue right) { }

	// RVA: 0x13ABCBC
	public static NamedValue[] ParseMultiple(string parameterString) { }

	// RVA: 0x13AD084
	public static NamedValue Parse(string str) { }

	// RVA: 0x13ACD0C
	private static NamedValue ParseParameter(string parameterString, int index) { }

	// RVA: 0x13AD434
	public void ApplyToObject(object instance) { }

	// RVA: 0x316B894
	public static void ApplyAllToObject(object instance, TParameterList parameters) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class NumberHelpers
{
	// Methods

	// RVA: 0x13AD8B8
	public static int AlignToMultipleOf(int number, int alignment) { }

	// RVA: 0x13AD8D4
	public static Int64 AlignToMultipleOf(Int64 number, Int64 alignment) { }

	// RVA: 0x13AD8F0
	public static UInt32 AlignToMultipleOf(UInt32 number, UInt32 alignment) { }

	// RVA: 0x13AD90C
	public static bool Approximately(Double a, Double b) { }

	// RVA: 0x13AD9AC
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	// RVA: 0x13AD9E4
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	// RVA: 0x13ADA34
	public static float UIntToNormalizedFloat(UInt32 value, UInt32 minValue, UInt32 maxValue) { }

	// RVA: 0x13ADA6C
	public static UInt32 NormalizedFloatToUInt(float value, UInt32 uintMinValue, UInt32 uintMaxValue) { }

	// RVA: 0x13ADAB4
	public static UInt32 RemapUIntBitsToNormalizeFloatToUIntBits(UInt32 value, UInt32 inBitSize, UInt32 outBitSize) { }

}

// Namespace: 
private class ForDevice
{
	// Fields
	private System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer; // 0x10
	private InputDevice m_Device; // 0x18
	private Type m_DeviceType; // 0x20

	// Methods

	// RVA: 0x13ADCA8
	public void .ctor(Type deviceType, InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

	// RVA: 0x13ADD0C
	public void OnCompleted() { }

	// RVA: 0x13ADD10
	public void OnError(Exception error) { }

	// RVA: 0x13ADD98
	public void OnNext(InputEventPtr value) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class ForDeviceEventObservable
{
	// Fields
	private System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source; // 0x10
	private InputDevice m_Device; // 0x18
	private Type m_DeviceType; // 0x20

	// Methods

	// RVA: 0x13ADB2C
	public void .ctor(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, Type deviceType, InputDevice device) { }

	// RVA: 0x13ADB90
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public IDisposable subscription; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2870
	internal void <CallOnce>b__0() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class Observable
{
	// Methods

	// RVA: 0x30B58A8
	public static System.IObservable<TValue> Where(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x30B58A8
	public static System.IObservable<TResult> Select(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x30B58A8
	public static System.IObservable<TResult> SelectMany(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: -1
	public static System.IObservable<TValue> Take(System.IObservable<TValue> source, int count) { }

	// RVA: 0x13ADF70
	public static System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, InputDevice device) { }

	// RVA: 0x30B57C8
	public static System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source) { }

	// RVA: 0x30B58A8
	public static IDisposable CallOnce(System.IObservable<TValue> source, System.Action<TValue> action) { }

	// RVA: 0x30B58A8
	public static IDisposable Call(System.IObservable<TValue> source, System.Action<TValue> action) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class Observer<T0>
{
	// Fields
	private System.Action<TValue> m_OnNext; // 0x0
	private Action m_OnCompleted; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(System.Action<TValue> onNext, Action onCompleted) { }

	// RVA: 0x30B2870
	public void OnCompleted() { }

	// RVA: 0x30B2CB8
	public void OnError(Exception error) { }

	// RVA: 0x316B894
	public void OnNext(TValue evt) { }

}

// Namespace: 
private class Select
{
	// Fields
	private UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x30B2870
	public void OnCompleted() { }

	// RVA: 0x30B2CB8
	public void OnError(Exception error) { }

	// RVA: 0x316B894
	public void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class SelectManyObservable<T0, T1>
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> m_Filter; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: 0x30B1D84
	public IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: 
private class Take
{
	// Fields
	private System.IObserver<TValue> m_Observer; // 0x0
	private int m_Remaining; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x30B2870
	public void OnCompleted() { }

	// RVA: 0x30B2CB8
	public void OnError(Exception error) { }

	// RVA: 0x316B894
	public void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class TakeNObservable<T0>
{
	// Fields
	private System.IObservable<TValue> m_Source; // 0x0
	private int m_Count; // 0x0

	// Methods

	// RVA: 0x30B2D20
	public void .ctor(System.IObservable<TValue> source, int count) { }

	// RVA: 0x30B1D84
	public IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Where
{
	// Fields
	private UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable; // 0x0
	private readonly System.IObserver<TValue> m_Observer; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x30B2870
	public void OnCompleted() { }

	// RVA: 0x30B2CB8
	public void OnError(Exception error) { }

	// RVA: 0x316B894
	public void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class WhereObservable<T0>
{
	// Fields
	private readonly System.IObservable<TValue> m_Source; // 0x0
	private readonly System.Func<TValue,System.Boolean> m_Predicate; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x30B1D84
	public IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	internal int m_Index; // 0x0
	internal UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> m_List; // 0x0

	// Methods

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public TValue get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct OneOrMore<T0, T1>
{
	// Fields
	private readonly bool m_IsSingle; // 0x0
	private readonly TValue m_Single; // 0x0
	private readonly TList m_Multiple; // 0x0

	// Methods

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x316B894
	public TValue get_Item(int index) { }

	// RVA: 0x316B894
	public void .ctor(TValue single) { }

	// RVA: 0x316B894
	public void .ctor(TList multiple) { }

	// RVA: 0x316B894
	public static UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TValue single) { }

	// RVA: 0x316B894
	public static UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TList multiple) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct PredictiveParser
{
	// Fields
	private int m_Position; // 0x10

	// Methods

	// RVA: 0x13AE054
	public void ExpectSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x13AE160
	public int ExpectInt(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x13AE284
	public System.ReadOnlySpan<System.Char> ExpectString(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x13AE4CC
	public bool AcceptSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x13AE508
	public bool AcceptString(System.ReadOnlySpan<System.Char> input, System.ReadOnlySpan<System.Char>& output) { }

	// RVA: 0x13AE674
	public void AcceptInt(System.ReadOnlySpan<System.Char> str) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct PrimitiveValue
{
	// Fields
	private TypeCode m_Type; // 0x10
	private bool m_BoolValue; // 0x14
	private Char m_CharValue; // 0x14
	private Byte m_ByteValue; // 0x14
	private SByte m_SByteValue; // 0x14
	private Int16 m_ShortValue; // 0x14
	private UInt16 m_UShortValue; // 0x14
	private int m_IntValue; // 0x14
	private UInt32 m_UIntValue; // 0x14
	private Int64 m_LongValue; // 0x14
	private UInt64 m_ULongValue; // 0x14
	private float m_FloatValue; // 0x14
	private Double m_DoubleValue; // 0x14

	// Methods

	// RVA: 0x13AE6D4
	internal Byte* get_valuePtr() { }

	// RVA: 0x13AE6DC
	public TypeCode get_type() { }

	// RVA: 0x13AE6E4
	public bool get_isEmpty() { }

	// RVA: 0x13AE6F4
	public void .ctor(bool value) { }

	// RVA: 0x13AE70C
	public void .ctor(Char value) { }

	// RVA: 0x13AE724
	public void .ctor(Byte value) { }

	// RVA: 0x13AE73C
	public void .ctor(SByte value) { }

	// RVA: 0x13AE754
	public void .ctor(Int16 value) { }

	// RVA: 0x13AE76C
	public void .ctor(UInt16 value) { }

	// RVA: 0x13AE784
	public void .ctor(int value) { }

	// RVA: 0x13AE794
	public void .ctor(UInt32 value) { }

	// RVA: 0x13AE7A4
	public void .ctor(Int64 value) { }

	// RVA: 0x13AE7B8
	public void .ctor(UInt64 value) { }

	// RVA: 0x13AE7CC
	public void .ctor(float value) { }

	// RVA: 0x13AE7E0
	public void .ctor(Double value) { }

	// RVA: 0x13AC0D4
	public PrimitiveValue ConvertTo(TypeCode type) { }

	// RVA: 0x13AF0A4
	public bool Equals(PrimitiveValue other) { }

	// RVA: 0x13AF0FC
	public override bool Equals(object obj) { }

	// RVA: 0x13AC910
	public static bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x13AF8A8
	public static bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x13ACAF4
	public override int GetHashCode() { }

	// RVA: 0x13AF904
	public override string ToString() { }

	// RVA: 0x13AD0E4
	public static PrimitiveValue FromString(string value) { }

	// RVA: 0x13AFD60
	public TypeCode GetTypeCode() { }

	// RVA: 0x13AE7F4
	public bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x13AEA44
	public Byte ToByte(IFormatProvider provider) { }

	// RVA: 0x13AE9C0
	public Char ToChar(IFormatProvider provider) { }

	// RVA: 0x13AFD68
	public DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x13AFDBC
	public Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x13AEFC0
	public Double ToDouble(IFormatProvider provider) { }

	// RVA: 0x13AEBC0
	public Int16 ToInt16(IFormatProvider provider) { }

	// RVA: 0x13AEC8C
	public int ToInt32(IFormatProvider provider) { }

	// RVA: 0x13AED3C
	public Int64 ToInt64(IFormatProvider provider) { }

	// RVA: 0x13AEB00
	public SByte ToSByte(IFormatProvider provider) { }

	// RVA: 0x13AEEB4
	public float ToSingle(IFormatProvider provider) { }

	// RVA: 0x13AFED8
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x13AFEDC
	public object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x13AFF1C
	public UInt16 ToUInt16(IFormatProvider provider) { }

	// RVA: 0x13AFFC4
	public UInt32 ToUInt32(IFormatProvider provider) { }

	// RVA: 0x13AEE00
	public UInt64 ToUInt64(IFormatProvider provider) { }

	// RVA: 0x13AD6BC
	public object ToObject() { }

	// RVA: 0x316B894
	public static PrimitiveValue From(TValue value) { }

	// RVA: 0x13AF358
	public static PrimitiveValue FromObject(object value) { }

	// RVA: 0x13AD0C8
	public static PrimitiveValue op_Implicit(bool value) { }

	// RVA: 0x13AEA34
	public static PrimitiveValue op_Implicit(Char value) { }

	// RVA: 0x13AEAF0
	public static PrimitiveValue op_Implicit(Byte value) { }

	// RVA: 0x13AEBAC
	public static PrimitiveValue op_Implicit(SByte value) { }

	// RVA: 0x13AEC78
	public static PrimitiveValue op_Implicit(Int16 value) { }

	// RVA: 0x13B0054
	public static PrimitiveValue op_Implicit(UInt16 value) { }

	// RVA: 0x13AED2C
	public static PrimitiveValue op_Implicit(int value) { }

	// RVA: 0x13B0064
	public static PrimitiveValue op_Implicit(UInt32 value) { }

	// RVA: 0x13AEDE4
	public static PrimitiveValue op_Implicit(Int64 value) { }

	// RVA: 0x13AEE98
	public static PrimitiveValue op_Implicit(UInt64 value) { }

	// RVA: 0x13AEFAC
	public static PrimitiveValue op_Implicit(float value) { }

	// RVA: 0x13AF088
	public static PrimitiveValue op_Implicit(Double value) { }

	// RVA: 0x13B0074
	public static PrimitiveValue FromBoolean(bool value) { }

	// RVA: 0x13B0090
	public static PrimitiveValue FromChar(Char value) { }

	// RVA: 0x13B00A0
	public static PrimitiveValue FromByte(Byte value) { }

	// RVA: 0x13B00B0
	public static PrimitiveValue FromSByte(SByte value) { }

	// RVA: 0x13B00C4
	public static PrimitiveValue FromInt16(Int16 value) { }

	// RVA: 0x13B00D8
	public static PrimitiveValue FromUInt16(UInt16 value) { }

	// RVA: 0x13B00E8
	public static PrimitiveValue FromInt32(int value) { }

	// RVA: 0x13B00F8
	public static PrimitiveValue FromUInt32(UInt32 value) { }

	// RVA: 0x13B0108
	public static PrimitiveValue FromInt64(Int64 value) { }

	// RVA: 0x13B0124
	public static PrimitiveValue FromUInt64(UInt64 value) { }

	// RVA: 0x13B0140
	public static PrimitiveValue FromSingle(float value) { }

	// RVA: 0x13B0154
	public static PrimitiveValue FromDouble(Double value) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly TValue[] m_Array; // 0x0
	private readonly int m_IndexStart; // 0x0
	private readonly int m_IndexEnd; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: -1
	internal void .ctor(TValue[] array, int index, int length) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public TValue get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct ReadOnlyArray<T0>
{
	// Fields
	internal TValue[] m_Array; // 0x0
	internal int m_StartIndex; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(TValue[] array) { }

	// RVA: -1
	public void .ctor(TValue[] array, int index, int length) { }

	// RVA: 0x30B1CD4
	public TValue[] ToArray() { }

	// RVA: 0x30B1ACC
	public int IndexOf(System.Predicate<TValue> predicate) { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x316B894
	public TValue get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class ReadOnlyArrayExtensions
{
	// Methods

	// RVA: 0x316B894
	public static bool Contains(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x316B894
	public static bool ContainsReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x316B894
	public static int IndexOfReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x316B894
	internal static bool HaveEqualReferences(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, System.Collections.Generic.IReadOnlyList<TValue> array2, int count) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal interface ISavedState
{
	// Methods

	// RVA: -1
	public abstract void StaticDisposeCurrentState() { }

	// RVA: -1
	public abstract void RestoreSavedState() { }

}

// Namespace: 
public sealed class TypedRestore
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30B2CB8
	public virtual void Invoke(T state) { }

	// RVA: 0x30B1ED8
	public virtual IAsyncResult BeginInvoke(T state, AsyncCallback callback, object object) { }

	// RVA: 0x30B2F18
	public virtual void EndInvoke(T state, IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal sealed class SavedStructState<T0>
{
	// Fields
	private T m_State; // 0x0
	private TypedRestore m_RestoreAction; // 0x0
	private Action m_StaticDisposeCurrentState; // 0x0

	// Methods

	// RVA: 0x30B30EC
	internal void .ctor(T state, TypedRestore restoreAction, Action staticDisposeCurrentState) { }

	// RVA: 0x30B2870
	public void StaticDisposeCurrentState() { }

	// RVA: 0x30B2870
	public void RestoreSavedState() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class SpriteUtilities
{
	// Methods

	// RVA: 0x13B0170
	public static Sprite CreateCircleSprite(int radius, Color32 colour) { }

}

// Namespace: 
private sealed class <Split>d__9
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string str; // 0x28
	public string <>3__str; // 0x30
	private System.Func<System.Char,System.Boolean> predicate; // 0x38
	public System.Func<System.Char,System.Boolean> <>3__predicate; // 0x40
	private int <length>5__2; // 0x48
	private int <position>5__3; // 0x4C

	// Methods

	// RVA: 0x13B0F34
	public void .ctor(int <>1__state) { }

	// RVA: 0x13B1B64
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13B1B68
	private bool MoveNext() { }

	// RVA: 0x13B1CD8
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13B1CE0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13B1D20
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13B1D28
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13B1DE0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <Tokenize>d__8
{
	// Fields
	private int <>1__state; // 0x10
	private Substring <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	private string str; // 0x30
	public string <>3__str; // 0x38
	private int <length>5__2; // 0x40
	private int <endPos>5__3; // 0x44

	// Methods

	// RVA: 0x13B0E60
	public void .ctor(int <>1__state) { }

	// RVA: 0x13B1DE4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13B1DE8
	private bool MoveNext() { }

	// RVA: 0x13B209C
	private Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current() { }

	// RVA: 0x13B20A8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13B20E8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13B2150
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator() { }

	// RVA: 0x13B21F8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class StringHelpers
{
	// Methods

	// RVA: 0x13B039C
	public static string Escape(string str, string chars, string replacements) { }

	// RVA: 0x13B05B8
	public static string Unescape(string str, string chars, string replacements) { }

	// RVA: 0x13B08AC
	public static bool Contains(string str, Char ch) { }

	// RVA: 0x13B08D0
	public static bool Contains(string str, string text, StringComparison comparison) { }

	// RVA: 0x13B08F4
	public static string GetPlural(string str) { }

	// RVA: 0x13B0AC0
	public static string NicifyMemorySize(Int64 numBytes) { }

	// RVA: 0x13B0C44
	public static bool FromNicifiedMemorySize(string text, Int64 result, Int64 defaultMultiplier) { }

	// RVA: 0x13ACC88
	public static int CountOccurrences(string str, Char ch) { }

	// RVA: 0x13B0DD8
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(string str) { }

	// RVA: 0x13B0E98
	public static System.Collections.Generic.IEnumerable<System.String> Split(string str, System.Func<System.Char,System.Boolean> predicate) { }

	// RVA: 0x30B58A8
	public static string Join(string separator, TValue[] values) { }

	// RVA: 0x30B58A8
	public static string Join(System.Collections.Generic.IEnumerable<TValue> values, string separator) { }

	// RVA: 0x30B5A04
	public static string MakeUniqueName(string baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting,System.String> getNameFunc) { }

	// RVA: 0x13B0F6C
	public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, Char separator) { }

	// RVA: 0x13B12A8
	public static int ParseInt(string str, int pos) { }

	// RVA: 0x13B134C
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) { }

	// RVA: 0x13B1370
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, UInt32 offset) { }

	// RVA: 0x13B153C
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) { }

	// RVA: 0x13B1560
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, UInt32 offset) { }

	// RVA: 0x13B1698
	public static bool IsPrintable(Char ch) { }

	// RVA: 0x13B1754
	public static string WithAllWhitespaceStripped(string str) { }

	// RVA: 0x13B18C0
	public static bool InvariantEqualsIgnoreCase(string left, string right) { }

	// RVA: 0x13B1910
	public static string ExpandTemplateString(string template, System.Func<System.String,System.String> mapFunc) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct Substring
{
	// Fields
	private readonly string m_String; // 0x10
	private readonly int m_Index; // 0x18
	private readonly int m_Length; // 0x1C

	// Methods

	// RVA: 0x13B21FC
	public bool get_isEmpty() { }

	// RVA: 0x13B220C
	public void .ctor(string str) { }

	// RVA: 0x13A81BC
	public void .ctor(string str, int index, int length) { }

	// RVA: 0x13B2258
	public void .ctor(string str, int index) { }

	// RVA: 0x13B22A4
	public override bool Equals(object obj) { }

	// RVA: 0x13B23E0
	public bool Equals(string other) { }

	// RVA: 0x13B2390
	public bool Equals(Substring other) { }

	// RVA: 0x13B24F0
	public bool Equals(InternedString other) { }

	// RVA: 0x13B24B8
	public int CompareTo(Substring other) { }

	// RVA: 0x13A881C
	public static int Compare(Substring left, Substring right, StringComparison comparison) { }

	// RVA: 0x13B25C0
	public bool StartsWith(string str) { }

	// RVA: 0x13B266C
	public string Substr(int index, int length) { }

	// RVA: 0x13A8584
	public override string ToString() { }

	// RVA: 0x13A89FC
	public override int GetHashCode() { }

	// RVA: 0x13B26A4
	public static bool op_Equality(Substring a, Substring b) { }

	// RVA: 0x13B26E0
	public static bool op_Inequality(Substring a, Substring b) { }

	// RVA: 0x13B271C
	public static bool op_Equality(Substring a, InternedString b) { }

	// RVA: 0x13B27E8
	public static bool op_Inequality(Substring a, InternedString b) { }

	// RVA: 0x13B28B4
	public static bool op_Equality(InternedString a, Substring b) { }

	// RVA: 0x13B2980
	public static bool op_Inequality(InternedString a, Substring b) { }

	// RVA: 0x13A8B84
	public static Substring op_Implicit(string s) { }

	// RVA: 0x13B2A4C
	public int get_length() { }

	// RVA: 0x13B2A54
	public int get_index() { }

	// RVA: 0x13A85F0
	public Char get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class TypeHelpers
{
	// Methods

	// RVA: 0x316B894
	public static TObject As(object obj) { }

	// RVA: 0x13B2A5C
	public static bool IsInt(TypeCode type) { }

	// RVA: 0x13B2A6C
	public static Type GetValueType(MemberInfo member) { }

	// RVA: 0x13B2C7C
	public static string GetNiceTypeName(Type type) { }

	// RVA: 0x13B31BC
	public static Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Utilities.TypeTable.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x13B3E44
	private static void .cctor() { }

	// RVA: 0x13B3EB0
	public void .ctor() { }

	// RVA: 0x13B3EB8
	internal string <get_names>b__2_0(InternedString x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct TypeTable
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table; // 0x10

	// Methods

	// RVA: 0x13B35B0
	public System.Collections.Generic.IEnumerable<System.String> get_names() { }

	// RVA: 0x13B36F8
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames() { }

	// RVA: 0x13B374C
	public void Initialize() { }

	// RVA: 0x13B37CC
	public InternedString FindNameForType(Type type) { }

	// RVA: 0x13B3BC4
	public void AddTypeRegistration(string name, Type type) { }

	// RVA: 0x13B3D40
	public Type LookupTypeRegistration(string name) { }

}

// Namespace: 
public enum WhichSideWins
{
	// Fields
	public int value__; // 0x10
	public const WhichSideWins Neither = 0;
	public const WhichSideWins Positive = 1;
	public const WhichSideWins Negative = 2;
}

// Namespace: UnityEngine.InputSystem.Composites
public class AxisComposite
{
	// Fields
	public int negative; // 0x10
	public int positive; // 0x14
	public float minValue; // 0x18
	public float maxValue; // 0x1C
	public WhichSideWins whichSideWins; // 0x20

	// Methods

	// RVA: 0x13B3F24
	public float get_midPoint() { }

	// RVA: 0x13B3F38
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13B407C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B40D4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Composites
public class ButtonWithOneModifier
{
	// Fields
	public int modifier; // 0x10
	public int button; // 0x14
	public bool overrideModifiersNeedToBePressedFirst; // 0x18

	// Methods

	// RVA: 0x13B4134
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13B41FC
	private bool ModifierIsPressed(InputBindingCompositeContext context) { }

	// RVA: 0x13B4280
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B428C
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13B4310
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Composites
public class ButtonWithTwoModifiers
{
	// Fields
	public int modifier1; // 0x10
	public int modifier2; // 0x14
	public int button; // 0x18
	public bool overrideModifiersNeedToBePressedFirst; // 0x1C

	// Methods

	// RVA: 0x13B4364
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13B4460
	private bool ModifiersArePressed(InputBindingCompositeContext context) { }

	// RVA: 0x13B4514
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B4520
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13B45A4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Composites
public class OneModifierComposite
{
	// Fields
	public int modifier; // 0x10
	public int binding; // 0x14
	public bool overrideModifiersNeedToBePressedFirst; // 0x18
	private int m_ValueSizeInBytes; // 0x1C
	private Type m_ValueType; // 0x20
	private bool m_BindingIsButton; // 0x28

	// Methods

	// RVA: 0x13B45F8
	public override Type get_valueType() { }

	// RVA: 0x13B4600
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13B4608
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B4740
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x13B46A0
	private bool ModifierIsPressed(InputBindingCompositeContext context) { }

	// RVA: 0x13B47FC
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13B4D54
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13B48A8
	internal static void DetermineValueTypeAndSize(InputBindingCompositeContext context, int part, Type valueType, int valueSizeInBytes, bool isButton) { }

	// RVA: 0x13B4DA4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Composites
public class TwoModifiersComposite
{
	// Fields
	public int modifier1; // 0x10
	public int modifier2; // 0x14
	public int binding; // 0x18
	public bool overrideModifiersNeedToBePressedFirst; // 0x1C
	private int m_ValueSizeInBytes; // 0x20
	private Type m_ValueType; // 0x28
	private bool m_BindingIsButton; // 0x30

	// Methods

	// RVA: 0x13B4DAC
	public override Type get_valueType() { }

	// RVA: 0x13B4DB4
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13B4DBC
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B4ED0
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x13B4E00
	private bool ModifiersArePressed(InputBindingCompositeContext context) { }

	// RVA: 0x13B4F38
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13B4FE4
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13B5048
	public void .ctor() { }

}

// Namespace: 
public enum Mode
{
	// Fields
	public int value__; // 0x10
	public const Mode Analog = 2;
	public const Mode DigitalNormalized = 0;
	public const Mode Digital = 1;
}

// Namespace: UnityEngine.InputSystem.Composites
public class Vector2Composite
{
	// Fields
	public int up; // 0x10
	public int down; // 0x14
	public int left; // 0x18
	public int right; // 0x1C
	public bool normalize; // 0x20
	public Mode mode; // 0x24

	// Methods

	// RVA: 0x13B5050
	public override Vector2 ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13B51CC
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B5260
	public void .ctor() { }

}

// Namespace: 
public enum Mode
{
	// Fields
	public int value__; // 0x10
	public const Mode Analog = 0;
	public const Mode DigitalNormalized = 1;
	public const Mode Digital = 2;
}

// Namespace: UnityEngine.InputSystem.Composites
public class Vector3Composite
{
	// Fields
	public int up; // 0x10
	public int down; // 0x14
	public int left; // 0x18
	public int right; // 0x1C
	public int forward; // 0x20
	public int backward; // 0x24
	public Mode mode; // 0x28

	// Methods

	// RVA: 0x13B52BC
	public override Vector3 ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13B555C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13B5604
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=84
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=104
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=234
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=371
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=460
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=976
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1038
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1575
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=4011
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=22735
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=22984
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=1575 20D6FD557BDCEEB113CF0C3EFEF501EB9D7AC4BA787A6A8C0EE057D8A217C869; // 0x0
	internal static readonly __StaticArrayInitTypeSize=22735 454DC7D0F89606110C4408E7B01933F2F8E4764FB2A1CD66E5BBF4DAEC225082; // 0x627
	internal static readonly __StaticArrayInitTypeSize=4011 63B74E5F0660F3254FE5AC58EE3CD9AC8FF8948DD7A5C9B54D0F8E0C67B3260F; // 0x5EF6
	internal static readonly __StaticArrayInitTypeSize=234 754FF720715FE60E11AD0300104CDEEB8E30183CF25B417CB06EEF78356058EB; // 0x6EA1
	internal static readonly __StaticArrayInitTypeSize=976 874A158EE5E9824634584F1FFF431FA5FC62C2D71CA9FCDCAA012D8A6A926392; // 0x6F8B
	internal static readonly __StaticArrayInitTypeSize=460 A9936AC77D07F78E7B0473F80D59F6E15FD898CEF491CA47D4EB1BA2AA6A4E66; // 0x735B
	internal static readonly __StaticArrayInitTypeSize=371 BD3331923AE2D87F6296377CB80C86CE12BF445ED38D4485D28FACFEC06BFF5B; // 0x7527
	internal static readonly __StaticArrayInitTypeSize=22984 D842C78BF09DD551FD698A21EA259ED9FEB6500E4B4249D77BE18D9650E67681; // 0x769A
	internal static readonly __StaticArrayInitTypeSize=84 D9D05356900CBD90C107CDBD184BC94526EC3F9228772F900FC7C60E3FE82B5A; // 0xD062
	internal static readonly __StaticArrayInitTypeSize=1038 DECF56A62725B03F2A8BBB3B372DB9FB38E9C95146DAF31983F2C2EDE07A762B; // 0xD0B6
	internal static readonly __StaticArrayInitTypeSize=104 FFCB0A1E90587D61767DBCE765CBEC8743DC4A67B865900B464ED065E4625BD5; // 0xD4C4
}


