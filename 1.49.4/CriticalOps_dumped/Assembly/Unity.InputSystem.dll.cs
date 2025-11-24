// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class UISupport
{
	// Methods

	// RVA: 0x136A624
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

	// RVA: 0x136A69C
	private static MonoScriptData Get() { }

	// RVA: 0x136A7A0
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

	// RVA: 0x136A7A8
	public static Type GetValueType(Type interactionType) { }

	// RVA: 0x136A8C4
	public static string GetDisplayName(string interaction) { }

	// RVA: 0x136A9E4
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

	// RVA: 0x136D20C
	private int get_actionIndex() { }

	// RVA: 0x136D214
	private int get_bindingIndex() { }

	// RVA: 0x136D254
	private int get_controlIndex() { }

	// RVA: 0x136D294
	private int get_interactionIndex() { }

	// RVA: 0x136D2D4
	public InputActionPhase get_phase() { }

	// RVA: 0x136D310
	public bool get_started() { }

	// RVA: 0x136D354
	public bool get_performed() { }

	// RVA: 0x136D398
	public bool get_canceled() { }

	// RVA: 0x136D3DC
	public InputAction get_action() { }

	// RVA: 0x136D434
	public InputControl get_control() { }

	// RVA: 0x136D498
	public IInputInteraction get_interaction() { }

	// RVA: 0x136D51C
	public Double get_time() { }

	// RVA: 0x136D568
	public Double get_startTime() { }

	// RVA: 0x136D5B4
	public Double get_duration() { }

	// RVA: 0x136D638
	public Type get_valueType() { }

	// RVA: 0x136D6CC
	public int get_valueSizeInBytes() { }

	// RVA: 0x136D760
	public void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x136DA14
	public bool ReadValueAsButton() { }

	// RVA: 0x136DAD4
	public object ReadValueAsObject() { }

	// RVA: 0x136DB98
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

	// RVA: 0x136AB9C
	public string get_name() { }

	// RVA: 0x136ABA4
	public InputActionType get_type() { }

	// RVA: 0x136ABAC
	public Guid get_id() { }

	// RVA: 0x136AC80
	internal Guid get_idDontGenerate() { }

	// RVA: 0x136ACE4
	public string get_expectedControlType() { }

	// RVA: 0x136ACEC
	public void set_expectedControlType(string value) { }

	// RVA: 0x136ACF4
	public string get_processors() { }

	// RVA: 0x136ACFC
	public string get_interactions() { }

	// RVA: 0x136AD04
	public InputActionMap get_actionMap() { }

	// RVA: 0x136AD44
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x136AD60
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x136B2C8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x136B3FC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x136B598
	public InputActionPhase get_phase() { }

	// RVA: 0x136B660
	public bool get_inProgress() { }

	// RVA: 0x136B6B4
	public bool get_enabled() { }

	// RVA: 0x136B708
	public void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136B764
	public void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136B7C0
	public void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136B81C
	public void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136B878
	public void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136B8D4
	public void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136B930
	public bool get_triggered() { }

	// RVA: 0x136BA60
	public InputControl get_activeControl() { }

	// RVA: 0x136BAF8
	public Type get_activeValueType() { }

	// RVA: 0x136BB84
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x136BBA0
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x136BBB4
	public void .ctor() { }

	// RVA: 0x136BC10
	public void .ctor(string name, InputActionType type, string binding, string interactions, string processors, string expectedControlType) { }

	// RVA: 0x136BE28
	public void Dispose() { }

	// RVA: 0x136BE44
	public override string ToString() { }

	// RVA: 0x136C188
	public void Enable() { }

	// RVA: 0x136C22C
	public void Disable() { }

	// RVA: 0x136C2A0
	public InputAction Clone() { }

	// RVA: 0x136C3B4
	private object System.ICloneable.Clone() { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x136C3B8
	public object ReadValueAsObject() { }

	// RVA: 0x136C458
	public float GetControlMagnitude() { }

	// RVA: 0x136C4D0
	public void Reset() { }

	// RVA: 0x136C568
	public bool IsPressed() { }

	// RVA: 0x136C5CC
	public bool IsInProgress() { }

	// RVA: 0x136C634
	public bool WasPressedThisFrame() { }

	// RVA: 0x136C6CC
	public bool WasReleasedThisFrame() { }

	// RVA: 0x136B9C8
	public bool WasPerformedThisFrame() { }

	// RVA: 0x136C764
	public bool WasCompletedThisFrame() { }

	// RVA: 0x136C7FC
	public float GetTimeoutCompletionPercentage() { }

	// RVA: 0x136AD24
	internal bool get_isSingletonAction() { }

	// RVA: 0x136B5E4
	private TriggerState get_currentState() { }

	// RVA: 0x136AC20
	internal string MakeSureIdIsInPlace() { }

	// RVA: 0x136C948
	internal void GenerateId() { }

	// RVA: 0x136B1A8
	internal InputActionMap GetOrCreateActionMap() { }

	// RVA: 0x136C994
	private void CreateInternalActionMapForSingletonAction() { }

	// RVA: 0x136CA90
	internal void RequestInitialStateCheckOnEnabledAction() { }

	// RVA: 0x136CADC
	internal bool ActiveControlIsValid(InputControl control) { }

	// RVA: 0x136CE14
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask() { }

	// RVA: 0x136CF94
	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	// RVA: 0x136D13C
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

	// RVA: 0x136F304
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

	// RVA: 0x13706A8
	public void .ctor(int <>1__state) { }

	// RVA: 0x1372050
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1372054
	private bool MoveNext() { }

	// RVA: 0x1372268
	private InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

	// RVA: 0x1372270
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13722B0
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

	// RVA: 0x136E248
	public void .ctor(int <>1__state) { }

	// RVA: 0x13722B8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13722BC
	private bool MoveNext() { }

	// RVA: 0x1372458
	private InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

	// RVA: 0x1372484
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13724C4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x137254C
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

	// RVA: 0x1372600
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

	// RVA: 0x136DF34
	public bool get_enabled() { }

	// RVA: 0x136E0D8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps() { }

	// RVA: 0x136E154
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x136E1C0
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x136E280
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x136E2A8
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x136E668
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x136E800
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x136EA0C
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x136EDB4
	public string ToJson() { }

	// RVA: 0x136F228
	public void LoadFromJson(string json) { }

	// RVA: 0x136F3D8
	public static InputActionAsset FromJson(string json) { }

	// RVA: 0x136EA90
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x136F5C0
	public int FindBinding(InputBinding mask, InputAction action) { }

	// RVA: 0x136F888
	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound) { }

	// RVA: 0x136FAD0
	public InputActionMap FindActionMap(Guid id) { }

	// RVA: 0x136FB90
	public InputAction FindAction(Guid guid) { }

	// RVA: 0x136FCAC
	public int FindControlSchemeIndex(string name) { }

	// RVA: 0x136FD7C
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(string name) { }

	// RVA: 0x136FEB4
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x1370158
	public void Enable() { }

	// RVA: 0x13703AC
	public void Disable() { }

	// RVA: 0x1370594
	public bool Contains(InputAction action) { }

	// RVA: 0x1370630
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x13706D4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x137074C
	internal void MarkAsDirty() { }

	// RVA: 0x1370750
	internal bool IsEmpty() { }

	// RVA: 0x137084C
	internal void OnWantToChangeSetup() { }

	// RVA: 0x1370BC4
	internal void OnSetupChanged() { }

	// RVA: 0x136E580
	private void ReResolveIfNecessary(bool fullResolve) { }

	// RVA: 0x1370F4C
	internal void ResolveBindingsIfNecessary() { }

	// RVA: 0x1371008
	private void OnDestroy() { }

	// RVA: 0x1371050
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

	// RVA: 0x13752D4
	public int IndexOf(InputDevice device) { }

	// RVA: 0x1375334
	public bool Remove(InputDevice device) { }

	// RVA: 0x136E734
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get() { }

	// RVA: 0x136E850
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

	// RVA: 0x13753E8
	public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) { }

	// RVA: 0x1375500
	public static BindingOverrideJson FromBinding(InputBinding binding) { }

	// RVA: 0x1375568
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

	// RVA: 0x1375674
	public InputBinding ToBinding() { }

	// RVA: 0x1375800
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

	// RVA: 0x13758EC
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

	// RVA: 0x1375B98
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

	// RVA: 0x1375CC0
	public static WriteMapJson FromMap(InputActionMap map) { }

}

// Namespace: 
[Serializable]
internal struct WriteFileJson
{
	// Fields
	public WriteMapJson[] maps; // 0x10

	// Methods

	// RVA: 0x13750F4
	public static WriteFileJson FromMap(InputActionMap map) { }

	// RVA: 0x136EE8C
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

	// RVA: 0x1371058
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

	// RVA: 0x1372604
	public string get_name() { }

	// RVA: 0x137260C
	public InputActionAsset get_asset() { }

	// RVA: 0x1372614
	public Guid get_id() { }

	// RVA: 0x136FA6C
	internal Guid get_idDontGenerate() { }

	// RVA: 0x136E144
	public bool get_enabled() { }

	// RVA: 0x13721FC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions() { }

	// RVA: 0x13726D4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1372740
	private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

	// RVA: 0x13727E4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x13728B8
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x13728E0
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x136CC1C
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x1372C3C
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x1372D04
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x1372DE4
	public void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1372E40
	public void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x136CA80
	public void .ctor() { }

	// RVA: 0x1372E9C
	public void .ctor(string name) { }

	// RVA: 0x1372ED8
	public void Dispose() { }

	// RVA: 0x1372EEC
	internal int FindActionIndex(string nameOrId) { }

	// RVA: 0x13730F8
	private void SetUpActionLookupTable() { }

	// RVA: 0x1373280
	internal void ClearActionLookupTable() { }

	// RVA: 0x13732DC
	private int FindActionIndex(Guid id) { }

	// RVA: 0x136F494
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x136FC50
	public InputAction FindAction(Guid id) { }

	// RVA: 0x1370044
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x1370338
	public void Enable() { }

	// RVA: 0x137055C
	public void Disable() { }

	// RVA: 0x13733B4
	public InputActionMap Clone() { }

	// RVA: 0x1373658
	private object System.ICloneable.Clone() { }

	// RVA: 0x137365C
	public bool Contains(InputAction action) { }

	// RVA: 0x1373688
	public override string ToString() { }

	// RVA: 0x1373790
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x1373870
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1373874
	private bool get_needToResolveBindings() { }

	// RVA: 0x1373880
	private void set_needToResolveBindings(bool value) { }

	// RVA: 0x1373894
	private bool get_bindingResolutionNeedsFullReResolve() { }

	// RVA: 0x13738A0
	private void set_bindingResolutionNeedsFullReResolve(bool value) { }

	// RVA: 0x13738C0
	private bool get_controlsForEachActionInitialized() { }

	// RVA: 0x13738CC
	private void set_controlsForEachActionInitialized(bool value) { }

	// RVA: 0x13738EC
	private bool get_bindingsForEachActionInitialized() { }

	// RVA: 0x13738F8
	private void set_bindingsForEachActionInitialized(bool value) { }

	// RVA: 0x136B364
	internal UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(InputAction action) { }

	// RVA: 0x136B500
	internal UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(InputAction action) { }

	// RVA: 0x1373918
	private void SetUpPerActionControlAndBindingArrays() { }

	// RVA: 0x13708DC
	internal void OnWantToChangeSetup() { }

	// RVA: 0x1370C60
	internal void OnSetupChanged() { }

	// RVA: 0x13740BC
	internal void OnBindingModified() { }

	// RVA: 0x1374054
	internal void ClearCachedActionData(bool onlyControls) { }

	// RVA: 0x1372688
	internal void GenerateId() { }

	// RVA: 0x136B1E4
	internal bool LazyResolveBindings(bool fullResolve) { }

	// RVA: 0x136B4B8
	internal bool ResolveBindingsIfNecessary() { }

	// RVA: 0x13741A8
	internal void ResolveBindings() { }

	// RVA: 0x136F6B8
	public int FindBinding(InputBinding mask, InputAction action) { }

	// RVA: 0x1374E44
	internal int FindBindingRelativeToMap(InputBinding mask) { }

	// RVA: 0x1374F08
	public static InputActionMap[] FromJson(string json) { }

	// RVA: 0x1374FC0
	public static string ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

	// RVA: 0x137507C
	public string ToJson() { }

	// RVA: 0x13751A4
	public void OnBeforeSerialize() { }

	// RVA: 0x13751A8
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

	// RVA: 0x13764C4
	public void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x137651C
	public ParameterEnumerator GetEnumerator() { }

	// RVA: 0x137CA4C
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }

	// RVA: 0x137CB40
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

	// RVA: 0x137C740
	public void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x137CDF0
	private bool MoveToNextBinding() { }

	// RVA: 0x137CFC0
	private bool MoveToNextInteraction() { }

	// RVA: 0x137D180
	private bool MoveToNextProcessor() { }

	// RVA: 0x137D044
	private bool FindParameter(object instance) { }

	// RVA: 0x137660C
	public bool MoveNext() { }

	// RVA: 0x137CCF8
	public void Reset() { }

	// RVA: 0x1376598
	public Parameter get_Current() { }

	// RVA: 0x137D204
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x137D2A8
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

	// RVA: 0x137CC34
	public Type get_objectType() { }

	// RVA: 0x13760E4
	public void .ctor(string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x137D2AC
	public void .ctor(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x1377908
	public static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(InputActionMap actionMap, InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x137D324
	private static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(ParameterOverride[] overrides, int overrideCount, InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x137D5E4
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

	// RVA: 0x137E064
	public void .ctor() { }

	// RVA: 0x138039C
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

	// RVA: 0x137DA0C
	public InputAction get_action() { }

	// RVA: 0x137DA14
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x137DA3C
	public UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates() { }

	// RVA: 0x137DA50
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_scores() { }

	// RVA: 0x137DAD0
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_magnitudes() { }

	// RVA: 0x137DB50
	public InputControl get_selectedControl() { }

	// RVA: 0x137DBC4
	public bool get_started() { }

	// RVA: 0x137DBD0
	public bool get_completed() { }

	// RVA: 0x137DBDC
	public bool get_canceled() { }

	// RVA: 0x137DBE8
	public Double get_startTime() { }

	// RVA: 0x137DBF0
	public float get_timeout() { }

	// RVA: 0x137C08C
	public string get_expectedControlType() { }

	// RVA: 0x137BCE0
	public RebindingOperation WithAction(InputAction action) { }

	// RVA: 0x137C00C
	public RebindingOperation WithMatchingEventsBeingSuppressed(bool value) { }

	// RVA: 0x137C09C
	public RebindingOperation WithCancelingThrough(string binding) { }

	// RVA: 0x137DCFC
	public RebindingOperation WithCancelingThrough(InputControl control) { }

	// RVA: 0x137DC60
	public RebindingOperation WithExpectedControlType(string layoutName) { }

	// RVA: 0x137DDDC
	public RebindingOperation WithExpectedControlType(Type type) { }

	// RVA: 0x30A17DC
	public RebindingOperation WithExpectedControlType() { }

	// RVA: 0x137C114
	public RebindingOperation WithTargetBinding(int bindingIndex) { }

	// RVA: 0x137E1DC
	public RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask) { }

	// RVA: 0x137E214
	public RebindingOperation WithBindingGroup(string group) { }

	// RVA: 0x137E310
	public RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

	// RVA: 0x137E320
	public RebindingOperation WithRebindAddingNewBinding(string group) { }

	// RVA: 0x137E354
	public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

	// RVA: 0x137E454
	public RebindingOperation WithoutIgnoringNoisyControls() { }

	// RVA: 0x137E06C
	public RebindingOperation WithControlsHavingToMatchPath(string path) { }

	// RVA: 0x137BE9C
	public RebindingOperation WithControlsExcluding(string path) { }

	// RVA: 0x137E4C4
	public RebindingOperation WithTimeout(float timeInSeconds) { }

	// RVA: 0x137E4CC
	public RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x137E4F8
	public RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x137E524
	public RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x137E550
	public RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl,System.String> callback) { }

	// RVA: 0x137E57C
	public RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> callback) { }

	// RVA: 0x137E5A8
	public RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> callback) { }

	// RVA: 0x137BE94
	public RebindingOperation OnMatchWaitForAnother(float seconds) { }

	// RVA: 0x137E5D4
	public RebindingOperation Start() { }

	// RVA: 0x137E958
	public void Cancel() { }

	// RVA: 0x137E9F8
	public void Complete() { }

	// RVA: 0x137EDF4
	public void AddCandidate(InputControl control, float score, float magnitude) { }

	// RVA: 0x137F0C0
	public void RemoveCandidate(InputControl control) { }

	// RVA: 0x137F1E4
	public void Dispose() { }

	// RVA: 0x137F46C
	protected override void Finalize() { }

	// RVA: 0x137F4FC
	public RebindingOperation Reset() { }

	// RVA: 0x137E83C
	private void HookOnEvent() { }

	// RVA: 0x137F340
	private void UnhookOnEvent() { }

	// RVA: 0x137F610
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x137EF7C
	private void SortCandidatesByScore() { }

	// RVA: 0x137FE64
	private static bool HavePathMatch(InputControl control, string[] paths, int pathCount) { }

	// RVA: 0x137E734
	private void HookOnAfterUpdate() { }

	// RVA: 0x137F3E0
	private void UnhookOnAfterUpdate() { }

	// RVA: 0x137FF0C
	private void OnAfterUpdate() { }

	// RVA: 0x137EA08
	private void OnComplete() { }

	// RVA: 0x137E9B0
	private void OnCancel() { }

	// RVA: 0x13801EC
	private void ResetAfterMatchCompleted() { }

	// RVA: 0x137DBF8
	private void ThrowIfRebindInProgress() { }

	// RVA: 0x137FFEC
	private string GeneratePathForControl(InputControl control) { }

	// RVA: 0x137BC40
	public void .ctor() { }

}

// Namespace: 
internal class DeferBindingResolutionWrapper
{
	// Methods

	// RVA: 0x137C6EC
	public void Acquire() { }

	// RVA: 0x13803C4
	public void Dispose() { }

	// RVA: 0x137C6E4
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

	// RVA: 0x1378C7C
	public void .ctor() { }

	// RVA: 0x1380434
	internal string <GetBindingDisplayString>b__0(string fragment) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionRebindingExtensions
{
	// Fields
	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x0

	// Methods

	// RVA: 0x1375F90
	public static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask) { }

	// RVA: 0x13761C8
	private static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, ParameterOverride parameterOverride) { }

	// RVA: 0x1376924
	public static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	// RVA: 0x315B3A8
	public static System.Nullable<TValue> GetParameterValue(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask) { }

	// RVA: 0x315B3A8
	public static void ApplyParameterOverride(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x315B3A8
	public static void ApplyParameterOverride(InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x315B3A8
	public static void ApplyParameterOverride(InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x315B3A8
	private static ParameterOverride ExtractParameterOverride(System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x1376B8C
	public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x1377310
	public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x13774EC
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x13776A4
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	// RVA: 0x1376D1C
	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ParameterOverride[] parameterOverrides, int parameterOverridesCount, ParameterOverride parameterOverride) { }

	// RVA: 0x1377B00
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x1377C34
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x1377DA0
	public static int GetBindingIndex(InputAction action, string group, string path) { }

	// RVA: 0x1377E74
	public static System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	// RVA: 0x1377FF8
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	// RVA: 0x13781D0
	public static string GetBindingDisplayString(InputAction action, DisplayStringOptions options, string group) { }

	// RVA: 0x1378370
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options) { }

	// RVA: 0x13785AC
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options) { }

	// RVA: 0x137862C
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, string deviceLayoutName, string controlPath, DisplayStringOptions options) { }

	// RVA: 0x1378C84
	public static void ApplyBindingOverride(InputAction action, string newPath, string group, string path) { }

	// RVA: 0x1378D80
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	// RVA: 0x1379040
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x13792CC
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	// RVA: 0x1378EE4
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	// RVA: 0x1379114
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x13793AC
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	// RVA: 0x1379434
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x1379514
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x13795F4
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	// RVA: 0x1379AA0
	public static void RemoveAllBindingOverrides(InputAction action) { }

	// RVA: 0x1379C04
	public static void ApplyBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x1379F78
	public static void RemoveBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x137A2EC
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	// RVA: 0x137A44C
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	// RVA: 0x137A5B8
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	// RVA: 0x137AC30
	public static string SaveBindingOverridesAsJson(InputAction action) { }

	// RVA: 0x137AA70
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, InputAction action) { }

	// RVA: 0x137B000
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting) { }

	// RVA: 0x137B5E4
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting) { }

	// RVA: 0x137B190
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	// RVA: 0x137B788
	public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex) { }

	// RVA: 0x1374D4C
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

	// RVA: 0x13805BC
	public InputAction get_action() { }

	// RVA: 0x1380734
	public InputActionReference get_reference() { }

	// RVA: 0x138074C
	internal InputAction get_serializedAction() { }

	// RVA: 0x1380754
	internal InputActionReference get_serializedReference() { }

	// RVA: 0x138075C
	public void .ctor(InputAction action) { }

	// RVA: 0x1380790
	public void .ctor(InputActionReference reference) { }

	// RVA: 0x13807D0
	public bool Equals(InputActionProperty other) { }

	// RVA: 0x13808CC
	public bool Equals(InputAction other) { }

	// RVA: 0x1380988
	public bool Equals(InputActionReference other) { }

	// RVA: 0x13809F8
	public override bool Equals(object obj) { }

	// RVA: 0x1380BC0
	public override int GetHashCode() { }

	// RVA: 0x1380C7C
	public static bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	// RVA: 0x1380D6C
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

	// RVA: 0x1380E4C
	public InputActionAsset get_asset() { }

	// RVA: 0x1380654
	public InputAction get_action() { }

	// RVA: 0x1380E54
	public void Set(InputAction action) { }

	// RVA: 0x1381184
	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	// RVA: 0x1380F70
	private void SetInternal(InputActionAsset asset, InputAction action) { }

	// RVA: 0x1381498
	public override string ToString() { }

	// RVA: 0x13813B8
	internal static string GetDisplayName(InputAction action) { }

	// RVA: 0x1381808
	internal string ToDisplayName() { }

	// RVA: 0x1381854
	public static InputAction op_Implicit(InputActionReference reference) { }

	// RVA: 0x1381860
	public static InputActionReference Create(InputAction action) { }

	// RVA: 0x13818DC
	public InputAction ToInputAction() { }

	// RVA: 0x13818E0
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

	// RVA: 0x1384C14
	public bool get_valid() { }

	// RVA: 0x1384C8C
	public int get_bindingIndex() { }

	// RVA: 0x1384D2C
	public InputBinding get_binding() { }

	// RVA: 0x1384E38
	internal void .ctor(InputActionMap map, int bindingIndexInMap, InputAction action) { }

	// RVA: 0x1384E7C
	public BindingSyntax WithName(string name) { }

	// RVA: 0x1384F98
	public BindingSyntax WithPath(string path) { }

	// RVA: 0x13850B4
	public BindingSyntax WithGroup(string group) { }

	// RVA: 0x13852B0
	public BindingSyntax WithGroups(string groups) { }

	// RVA: 0x13854D4
	public BindingSyntax WithInteraction(string interaction) { }

	// RVA: 0x13856D0
	public BindingSyntax WithInteractions(string interactions) { }

	// RVA: 0x315B3A8
	public BindingSyntax WithInteraction() { }

	// RVA: 0x13858F4
	public BindingSyntax WithProcessor(string processor) { }

	// RVA: 0x1385AF0
	public BindingSyntax WithProcessors(string processors) { }

	// RVA: 0x315B3A8
	public BindingSyntax WithProcessor() { }

	// RVA: 0x1385D14
	public BindingSyntax Triggering(InputAction action) { }

	// RVA: 0x1385EF4
	public BindingSyntax To(InputBinding binding) { }

	// RVA: 0x1386060
	public BindingSyntax NextBinding() { }

	// RVA: 0x1386204
	public BindingSyntax PreviousBinding() { }

	// RVA: 0x1386244
	public BindingSyntax NextPartBinding(string partName) { }

	// RVA: 0x13864F4
	public BindingSyntax PreviousPartBinding(string partName) { }

	// RVA: 0x13865A4
	public BindingSyntax NextCompositeBinding(string compositeName) { }

	// RVA: 0x13867B8
	public BindingSyntax PreviousCompositeBinding(string compositeName) { }

	// RVA: 0x13860A0
	private BindingSyntax Iterate(bool next) { }

	// RVA: 0x13865E8
	private BindingSyntax IterateCompositeBinding(bool next, string compositeName) { }

	// RVA: 0x13862F4
	private BindingSyntax IteratePartBinding(bool next, string partName) { }

	// RVA: 0x1386870
	public void Erase() { }

	// RVA: 0x1386A78
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

	// RVA: 0x1386CBC
	public int get_bindingIndex() { }

	// RVA: 0x1386CEC
	internal void .ctor(InputActionMap map, InputAction action, int compositeIndex) { }

	// RVA: 0x1386D38
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

	// RVA: 0x1386F8C
	internal void .ctor(InputActionAsset asset, int index) { }

	// RVA: 0x1386FC0
	internal void .ctor(InputControlScheme controlScheme) { }

	// RVA: 0x138700C
	public ControlSchemeSyntax WithBindingGroup(string bindingGroup) { }

	// RVA: 0x315B3A8
	public ControlSchemeSyntax WithRequiredDevice() { }

	// RVA: 0x315B3A8
	public ControlSchemeSyntax WithOptionalDevice() { }

	// RVA: 0x315B3A8
	public ControlSchemeSyntax OrWithRequiredDevice() { }

	// RVA: 0x315B3A8
	public ControlSchemeSyntax OrWithOptionalDevice() { }

	// RVA: 0x138714C
	public ControlSchemeSyntax WithRequiredDevice(string controlPath) { }

	// RVA: 0x13873B0
	public ControlSchemeSyntax WithOptionalDevice(string controlPath) { }

	// RVA: 0x13873E8
	public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) { }

	// RVA: 0x1387420
	public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) { }

	// RVA: 0x30A17DC
	private string DeviceTypeToControlPath() { }

	// RVA: 0x1387458
	public InputControlScheme Done() { }

	// RVA: 0x1387184
	private void AddDeviceEntry(string controlPath, Flags flags) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public InputBinding binding; // 0x10

	// Methods

	// RVA: 0x1387540
	public void .ctor() { }

	// RVA: 0x1387548
	internal bool <RemoveAction>b__0(InputBinding b) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionSetupExtensions
{
	// Methods

	// RVA: 0x13818E8
	public static InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	// RVA: 0x1381AFC
	public static void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x1381D94
	public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x1381F40
	public static void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x1382074
	public static InputAction AddAction(InputActionMap map, string name, InputActionType type, string binding, string interactions, string processors, string groups, string expectedControlLayout) { }

	// RVA: 0x13824B8
	public static void RemoveAction(InputAction action) { }

	// RVA: 0x1382840
	public static void RemoveAction(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x1380108
	public static BindingSyntax AddBinding(InputAction action, string path, string interactions, string processors, string groups) { }

	// RVA: 0x1382A60
	public static BindingSyntax AddBinding(InputAction action, InputControl control) { }

	// RVA: 0x138296C
	public static BindingSyntax AddBinding(InputAction action, InputBinding binding) { }

	// RVA: 0x1382D38
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions, string groups, string action, string processors) { }

	// RVA: 0x1382FC0
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions, string groups) { }

	// RVA: 0x1383130
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions, string groups) { }

	// RVA: 0x1382E9C
	public static BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x1383230
	public static CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions, string processors) { }

	// RVA: 0x1382B8C
	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex) { }

	// RVA: 0x137DFBC
	public static BindingSyntax ChangeBinding(InputAction action, int index) { }

	// RVA: 0x138342C
	public static BindingSyntax ChangeBinding(InputAction action, string name) { }

	// RVA: 0x13837DC
	public static BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	// RVA: 0x13838F8
	public static BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	// RVA: 0x13839D0
	public static BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	// RVA: 0x1383AA4
	public static BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	// RVA: 0x1383B7C
	public static BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	// RVA: 0x13834C4
	public static BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	// RVA: 0x1383C54
	public static BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	// RVA: 0x1383E7C
	public static void Rename(InputAction action, string newName) { }

	// RVA: 0x1384160
	public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	// RVA: 0x1384480
	public static ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x1384650
	public static void RemoveControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x13847A8
	public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	// RVA: 0x1384854
	public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	// RVA: 0x1384964
	public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x1384A10
	public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x1384ABC
	public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x1384B68
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

	// RVA: 0x13894D4
	public int get_triggerControlIndex() { }

	// RVA: 0x138A7C0
	public void set_triggerControlIndex(int value) { }

	// RVA: 0x1390264
	public Double get_startTime() { }

	// RVA: 0x139026C
	public void set_startTime(Double value) { }

	// RVA: 0x1390274
	public Double get_performedTime() { }

	// RVA: 0x139027C
	public void set_performedTime(Double value) { }

	// RVA: 0x1390284
	public Double get_timerStartTime() { }

	// RVA: 0x139028C
	public void set_timerStartTime(Double value) { }

	// RVA: 0x1390294
	public float get_timerDuration() { }

	// RVA: 0x139029C
	public void set_timerDuration(float value) { }

	// RVA: 0x13902A4
	public float get_totalTimeoutCompletionDone() { }

	// RVA: 0x13902AC
	public void set_totalTimeoutCompletionDone(float value) { }

	// RVA: 0x13902B4
	public float get_totalTimeoutCompletionTimeRemaining() { }

	// RVA: 0x13902BC
	public void set_totalTimeoutCompletionTimeRemaining(float value) { }

	// RVA: 0x13902C4
	public Int64 get_timerMonitorIndex() { }

	// RVA: 0x13902CC
	public void set_timerMonitorIndex(Int64 value) { }

	// RVA: 0x138A83C
	public bool get_isTimerRunning() { }

	// RVA: 0x138D718
	public void set_isTimerRunning(bool value) { }

	// RVA: 0x13902D4
	public InputActionPhase get_phase() { }

	// RVA: 0x138A7B8
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

	// RVA: 0x13902DC
	public int get_controlStartIndex() { }

	// RVA: 0x13902E4
	public void set_controlStartIndex(int value) { }

	// RVA: 0x139037C
	public int get_controlCount() { }

	// RVA: 0x1390384
	public void set_controlCount(int value) { }

	// RVA: 0x13894C0
	public int get_interactionStartIndex() { }

	// RVA: 0x139041C
	public void set_interactionStartIndex(int value) { }

	// RVA: 0x13904C0
	public int get_interactionCount() { }

	// RVA: 0x13904C8
	public void set_interactionCount(int value) { }

	// RVA: 0x138E84C
	public int get_processorStartIndex() { }

	// RVA: 0x1390560
	public void set_processorStartIndex(int value) { }

	// RVA: 0x1390604
	public int get_processorCount() { }

	// RVA: 0x139060C
	public void set_processorCount(int value) { }

	// RVA: 0x138A434
	public int get_actionIndex() { }

	// RVA: 0x13906A4
	public void set_actionIndex(int value) { }

	// RVA: 0x1390748
	public int get_mapIndex() { }

	// RVA: 0x1390750
	public void set_mapIndex(int value) { }

	// RVA: 0x1387B20
	public int get_compositeOrCompositeBindingIndex() { }

	// RVA: 0x13907E8
	public void set_compositeOrCompositeBindingIndex(int value) { }

	// RVA: 0x139088C
	public int get_triggerEventIdForComposite() { }

	// RVA: 0x1390894
	public void set_triggerEventIdForComposite(int value) { }

	// RVA: 0x139089C
	public Double get_pressTime() { }

	// RVA: 0x13908A4
	public void set_pressTime(Double value) { }

	// RVA: 0x13908AC
	public Flags get_flags() { }

	// RVA: 0x13908B4
	public void set_flags(Flags value) { }

	// RVA: 0x13908BC
	public bool get_chainsWithNext() { }

	// RVA: 0x13908C8
	public void set_chainsWithNext(bool value) { }

	// RVA: 0x13908DC
	public bool get_isEndOfChain() { }

	// RVA: 0x13908E8
	public void set_isEndOfChain(bool value) { }

	// RVA: 0x1390908
	public bool get_isPartOfChain() { }

	// RVA: 0x1388A1C
	public bool get_isComposite() { }

	// RVA: 0x1390918
	public void set_isComposite(bool value) { }

	// RVA: 0x1387B14
	public bool get_isPartOfComposite() { }

	// RVA: 0x1390938
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x138BEC0
	public bool get_initialStateCheckPending() { }

	// RVA: 0x138A464
	public void set_initialStateCheckPending(bool value) { }

	// RVA: 0x138A458
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x1390958
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x1390978
	public int get_partIndex() { }

	// RVA: 0x1390980
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

	// RVA: 0x1390988
	public InputActionPhase get_phase() { }

	// RVA: 0x138A42C
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x138A448
	public bool get_isDisabled() { }

	// RVA: 0x1390990
	public bool get_isWaiting() { }

	// RVA: 0x13909A0
	public bool get_isStarted() { }

	// RVA: 0x13909B0
	public bool get_isPerformed() { }

	// RVA: 0x13909C0
	public bool get_isCanceled() { }

	// RVA: 0x13909D0
	public Double get_time() { }

	// RVA: 0x13909D8
	public void set_time(Double value) { }

	// RVA: 0x13909E0
	public Double get_startTime() { }

	// RVA: 0x13909E8
	public void set_startTime(Double value) { }

	// RVA: 0x13909F0
	public float get_magnitude() { }

	// RVA: 0x138A714
	public void set_magnitude(float value) { }

	// RVA: 0x13909F8
	public bool get_haveMagnitude() { }

	// RVA: 0x1390A04
	public int get_mapIndex() { }

	// RVA: 0x138A848
	public void set_mapIndex(int value) { }

	// RVA: 0x13894AC
	public int get_controlIndex() { }

	// RVA: 0x138A698
	public void set_controlIndex(int value) { }

	// RVA: 0x1390A0C
	public int get_bindingIndex() { }

	// RVA: 0x138A3C0
	public void set_bindingIndex(int value) { }

	// RVA: 0x138A728
	public int get_interactionIndex() { }

	// RVA: 0x138A73C
	public void set_interactionIndex(int value) { }

	// RVA: 0x1390A14
	public UInt32 get_lastPerformedInUpdate() { }

	// RVA: 0x1390A1C
	public void set_lastPerformedInUpdate(UInt32 value) { }

	// RVA: 0x1390A24
	public UInt32 get_lastCompletedInUpdate() { }

	// RVA: 0x1390A2C
	public void set_lastCompletedInUpdate(UInt32 value) { }

	// RVA: 0x1390A34
	public UInt32 get_lastCanceledInUpdate() { }

	// RVA: 0x1390A3C
	public void set_lastCanceledInUpdate(UInt32 value) { }

	// RVA: 0x1390A44
	public UInt32 get_pressedInUpdate() { }

	// RVA: 0x1390A4C
	public void set_pressedInUpdate(UInt32 value) { }

	// RVA: 0x1390A54
	public UInt32 get_releasedInUpdate() { }

	// RVA: 0x1390A5C
	public void set_releasedInUpdate(UInt32 value) { }

	// RVA: 0x138AF20
	public bool get_isPassThrough() { }

	// RVA: 0x138C89C
	public void set_isPassThrough(bool value) { }

	// RVA: 0x138C8BC
	public bool get_isButton() { }

	// RVA: 0x138C8C8
	public void set_isButton(bool value) { }

	// RVA: 0x138D61C
	public bool get_isPressed() { }

	// RVA: 0x138B340
	public void set_isPressed(bool value) { }

	// RVA: 0x138D628
	public bool get_mayNeedConflictResolution() { }

	// RVA: 0x1390A64
	public void set_mayNeedConflictResolution(bool value) { }

	// RVA: 0x138D634
	public bool get_hasMultipleConcurrentActuations() { }

	// RVA: 0x138B300
	public void set_hasMultipleConcurrentActuations(bool value) { }

	// RVA: 0x138DFE8
	public bool get_inProcessing() { }

	// RVA: 0x138B320
	public void set_inProcessing(bool value) { }

	// RVA: 0x1390A84
	public Flags get_flags() { }

	// RVA: 0x138DFF4
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

	// RVA: 0x1390A8C
	public bool get_isAllocated() { }

	// RVA: 0x1390A9C
	public int get_sizeInBytes() { }

	// RVA: 0x1390AEC
	public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) { }

	// RVA: 0x13880B4
	public void Dispose() { }

	// RVA: 0x1390C20
	public void CopyDataFrom(UnmanagedMemory memory) { }

	// RVA: 0x13882A4
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

	// RVA: 0x1390D90
	private static void .cctor() { }

	// RVA: 0x1390DFC
	public void .ctor() { }

	// RVA: 0x1390E04
	internal void <SaveAndResetState>b__135_0(GlobalState state) { }

	// RVA: 0x1390E74
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

	// RVA: 0x13875EC
	public int get_totalCompositeCount() { }

	// RVA: 0x13875F4
	public int get_totalMapCount() { }

	// RVA: 0x13875FC
	public int get_totalActionCount() { }

	// RVA: 0x1387604
	public int get_totalBindingCount() { }

	// RVA: 0x138760C
	public int get_totalInteractionCount() { }

	// RVA: 0x1387614
	public int get_totalControlCount() { }

	// RVA: 0x138761C
	public ActionMapIndices* get_mapIndices() { }

	// RVA: 0x1387624
	public TriggerState* get_actionStates() { }

	// RVA: 0x138762C
	public BindingState* get_bindingStates() { }

	// RVA: 0x1387634
	public InteractionState* get_interactionStates() { }

	// RVA: 0x138763C
	public Int32* get_controlIndexToBindingIndex() { }

	// RVA: 0x1387644
	public UInt16* get_controlGroupingAndComplexity() { }

	// RVA: 0x138764C
	public Single* get_controlMagnitudes() { }

	// RVA: 0x1387654
	public UInt32* get_enabledControls() { }

	// RVA: 0x138765C
	public bool get_isProcessingControlStateChange() { }

	// RVA: 0x1387664
	public void Initialize(InputBindingResolver resolver) { }

	// RVA: 0x1387928
	private void ComputeControlGroupingIfNecessary() { }

	// RVA: 0x13877B0
	public void ClaimDataFrom(InputBindingResolver resolver) { }

	// RVA: 0x1387B34
	protected override void Finalize() { }

	// RVA: 0x1387DD4
	public void Dispose() { }

	// RVA: 0x1387C14
	private void Destroy(bool isFinalizing) { }

	// RVA: 0x13880FC
	public InputActionState Clone() { }

	// RVA: 0x1388468
	private object System.ICloneable.Clone() { }

	// RVA: 0x138846C
	private bool IsUsingDevice(InputDevice device) { }

	// RVA: 0x138866C
	private bool CanUseDevice(InputDevice device) { }

	// RVA: 0x13888BC
	public bool HasEnabledActions() { }

	// RVA: 0x138893C
	private void FinishBindingCompositeSetups() { }

	// RVA: 0x1388A34
	internal void PrepareForBindingReResolution(bool needFullResolve, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& activeControls, bool hasEnabledActions) { }

	// RVA: 0x1389914
	public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x13899BC
	private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x138AC5C
	private bool IsActiveControl(int bindingIndex, int controlIndex) { }

	// RVA: 0x138A62C
	private int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	// RVA: 0x138AD08
	private void ResetActionStatesDrivenBy(InputDevice device) { }

	// RVA: 0x138AF2C
	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	// RVA: 0x138960C
	public void ResetActionState(int actionIndex, InputActionPhase toPhase, bool hardReset) { }

	// RVA: 0x138B360
	public TriggerState FetchActionState(InputAction action) { }

	// RVA: 0x138B388
	public ActionMapIndices FetchMapIndices(InputActionMap map) { }

	// RVA: 0x138B3C0
	public void EnableAllActions(InputActionMap map) { }

	// RVA: 0x138B5C4
	private void EnableControls(InputActionMap map) { }

	// RVA: 0x138B608
	public void EnableSingleAction(InputAction action) { }

	// RVA: 0x138B710
	private void EnableControls(InputAction action) { }

	// RVA: 0x138918C
	public void DisableAllActions(InputActionMap map) { }

	// RVA: 0x13897D0
	public void DisableControls(InputActionMap map) { }

	// RVA: 0x138B7D4
	public void DisableSingleAction(InputAction action) { }

	// RVA: 0x138B8D4
	private void DisableControls(InputAction action) { }

	// RVA: 0x138A484
	private void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x1387DDC
	private void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x138BA6C
	public void SetInitialStateCheckPending(int actionIndex, bool value) { }

	// RVA: 0x138B9E4
	private void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) { }

	// RVA: 0x138B998
	private bool IsControlEnabled(int controlIndex) { }

	// RVA: 0x138BA30
	private void SetControlEnabled(int controlIndex, bool state) { }

	// RVA: 0x138AA40
	private void HookOnBeforeUpdate() { }

	// RVA: 0x138BB08
	private void UnhookOnBeforeUpdate() { }

	// RVA: 0x138BB88
	private void OnBeforeInitialUpdate() { }

	// RVA: 0x138BECC
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 mapControlAndBindingIndex) { }

	// RVA: 0x138C540
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 mapControlAndBindingIndex, int interactionIndex) { }

	// RVA: 0x138B9BC
	private Int64 ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x138BEE4
	private void SplitUpMapAndControlAndBindingIndex(Int64 mapControlAndBindingIndex, int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x138C894
	internal static int GetComplexityFromMonitorIndex(Int64 mapControlAndBindingIndex) { }

	// RVA: 0x138BF00
	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x138CF88
	private void ProcessButtonState(TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) { }

	// RVA: 0x138C8E8
	private static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) { }

	// RVA: 0x138CB64
	private bool IsConflictingInput(TriggerState trigger, int actionIndex) { }

	// RVA: 0x138AFEC
	private UInt16 GetActionBindingStartIndexAndCount(int actionIndex, UInt16 bindingCount) { }

	// RVA: 0x138D150
	private void ProcessDefaultInteraction(TriggerState trigger, int actionIndex) { }

	// RVA: 0x138C948
	private void ProcessInteractions(TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	// RVA: 0x138C558
	private void ProcessTimeout(Double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	// RVA: 0x138D72C
	internal void SetTotalTimeoutCompletionTime(float seconds, TriggerState trigger) { }

	// RVA: 0x138A8B4
	internal void StartTimeout(float seconds, TriggerState trigger) { }

	// RVA: 0x138D75C
	private void StopTimeout(int interactionIndex) { }

	// RVA: 0x138D840
	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, TriggerState trigger, InputActionPhase phaseAfterPerformed, InputActionPhase phaseAfterCanceled, bool processNextInteractionOnCancel) { }

	// RVA: 0x138B0BC
	private bool ChangePhaseOfAction(InputActionPhase newPhase, TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled) { }

	// RVA: 0x138DCEC
	private void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, TriggerState trigger, bool isDisablingAction) { }

	// RVA: 0x138DFFC
	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>& listeners, string callbackName) { }

	// RVA: 0x138E200
	private object GetActionOrNoneString(TriggerState trigger) { }

	// RVA: 0x138E300
	internal InputAction GetActionOrNull(int bindingIndex) { }

	// RVA: 0x138E268
	internal InputAction GetActionOrNull(TriggerState trigger) { }

	// RVA: 0x138E398
	internal InputControl GetControl(TriggerState trigger) { }

	// RVA: 0x138E3DC
	private IInputInteraction GetInteractionOrNull(TriggerState trigger) { }

	// RVA: 0x138E42C
	internal int GetBindingIndexInMap(int bindingIndex) { }

	// RVA: 0x138E468
	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	// RVA: 0x138E494
	internal BindingState GetBindingState(int bindingIndex) { }

	// RVA: 0x138E4A4
	internal InputBinding GetBinding(int bindingIndex) { }

	// RVA: 0x138E524
	internal InputActionMap GetActionMap(int bindingIndex) { }

	// RVA: 0x138B00C
	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	// RVA: 0x13894E8
	private void ResetInteractionState(int interactionIndex) { }

	// RVA: 0x138E568
	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	// RVA: 0x138E600
	internal Type GetValueType(int bindingIndex, int controlIndex) { }

	// RVA: 0x138D640
	internal static bool IsActuated(TriggerState trigger, float threshold) { }

	// RVA: 0x138E698
	internal void ReadValue(int bindingIndex, int controlIndex, Void* buffer, int bufferSize, bool ignoreComposites) { }

	// RVA: 0x315B3A8
	internal TValue ReadValue(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x315B3A8
	internal TValue ApplyProcessors(int bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType) { }

	// RVA: 0x138E860
	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	// RVA: 0x138E944
	internal Double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	// RVA: 0x315B3A8
	internal TValue ReadCompositePartValue(int bindingIndex, int partNumber, Boolean* buttonValuePtr, int controlIndex, TComparer comparer) { }

	// RVA: 0x138E9CC
	internal bool ReadCompositePartValue(int bindingIndex, int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x138EBB8
	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	// RVA: 0x138ED84
	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x138EF24
	internal bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	// RVA: 0x138F05C
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x138788C
	private void AddToGlobalList() { }

	// RVA: 0x1387F7C
	private void RemoveMapFromGlobalList() { }

	// RVA: 0x138F298
	private static void CompactGlobalList() { }

	// RVA: 0x1389814
	internal void NotifyListenersOfActionChange(InputActionChange change) { }

	// RVA: 0x138AB5C
	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	// RVA: 0x138F438
	private static void ResetGlobals() { }

	// RVA: 0x138F71C
	internal static int FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result) { }

	// RVA: 0x138FAF4
	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x138FE28
	internal static void DeferredResolutionOfBindings() { }

	// RVA: 0x13900F0
	internal static void DisableAllActions() { }

	// RVA: 0x138F580
	internal static void DestroyAllActionMapStates() { }

	// RVA: 0x138829C
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

	// RVA: 0x1391F38
	private static void .cctor() { }

	// RVA: 0x1391FA4
	public void .ctor() { }

	// RVA: 0x1391FAC
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

	// RVA: 0x1390E78
	public string get_name() { }

	// RVA: 0x1390E80
	public void set_name(string value) { }

	// RVA: 0x1390E88
	public Guid get_id() { }

	// RVA: 0x1390EEC
	public void set_id(Guid value) { }

	// RVA: 0x1390F30
	public string get_path() { }

	// RVA: 0x1390F38
	public void set_path(string value) { }

	// RVA: 0x1390F40
	public string get_overridePath() { }

	// RVA: 0x1390F48
	public void set_overridePath(string value) { }

	// RVA: 0x1390F50
	public string get_interactions() { }

	// RVA: 0x1390F58
	public void set_interactions(string value) { }

	// RVA: 0x1390F60
	public string get_overrideInteractions() { }

	// RVA: 0x1390F68
	public void set_overrideInteractions(string value) { }

	// RVA: 0x1390F70
	public string get_processors() { }

	// RVA: 0x1390F78
	public void set_processors(string value) { }

	// RVA: 0x1390F80
	public string get_overrideProcessors() { }

	// RVA: 0x1390F88
	public void set_overrideProcessors(string value) { }

	// RVA: 0x1390F90
	public string get_groups() { }

	// RVA: 0x1390F98
	public void set_groups(string value) { }

	// RVA: 0x1390FA0
	public string get_action() { }

	// RVA: 0x1390FA8
	public void set_action(string value) { }

	// RVA: 0x1386858
	public bool get_isComposite() { }

	// RVA: 0x1390FB0
	public void set_isComposite(bool value) { }

	// RVA: 0x1386864
	public bool get_isPartOfComposite() { }

	// RVA: 0x1386C9C
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x1390FD0
	public bool get_hasOverrides() { }

	// RVA: 0x1391000
	public void .ctor(string path, string action, string groups, string processors, string interactions, string name) { }

	// RVA: 0x13910D8
	public string GetNameOfComposite() { }

	// RVA: 0x1391128
	internal void GenerateId() { }

	// RVA: 0x1391174
	internal void RemoveOverrides() { }

	// RVA: 0x13911B8
	public static InputBinding MaskByGroup(string group) { }

	// RVA: 0x1391224
	public static InputBinding MaskByGroups(string[] groups) { }

	// RVA: 0x13888A4
	public string get_effectivePath() { }

	// RVA: 0x13913CC
	public string get_effectiveInteractions() { }

	// RVA: 0x13913E4
	public string get_effectiveProcessors() { }

	// RVA: 0x13913FC
	internal bool get_isEmpty() { }

	// RVA: 0x1391468
	public bool Equals(InputBinding other) { }

	// RVA: 0x139158C
	public override bool Equals(object obj) { }

	// RVA: 0x13875AC
	public static bool op_Equality(InputBinding left, InputBinding right) { }

	// RVA: 0x1391644
	public static bool op_Inequality(InputBinding left, InputBinding right) { }

	// RVA: 0x13916AC
	public override int GetHashCode() { }

	// RVA: 0x13917C0
	public override string ToString() { }

	// RVA: 0x1391900
	public string ToDisplayString(DisplayStringOptions options, InputControl control) { }

	// RVA: 0x1391930
	public string ToDisplayString(string deviceLayoutName, string controlPath, DisplayStringOptions options, InputControl control) { }

	// RVA: 0x13867FC
	internal bool TriggersAction(InputAction action) { }

	// RVA: 0x1391D80
	public bool Matches(InputBinding binding) { }

	// RVA: 0x1391D88
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

	// RVA: 0x139235C
	public void .ctor(int <>1__state) { }

	// RVA: 0x13924B8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13924BC
	private bool MoveNext() { }

	// RVA: 0x13926D0
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13926D8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1392718
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1392720
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13927C8
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

	// RVA: 0x1391FCC
	public virtual float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x1391FD4
	protected virtual void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x1388A28
	internal void CallFinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x1391FD8
	internal static Type GetValueType(string composite) { }

	// RVA: 0x1392138
	public static string GetExpectedControlLayoutName(string composite, string part) { }

	// RVA: 0x13922D4
	internal static System.Collections.Generic.IEnumerable<System.String> GetPartNames(string composite) { }

	// RVA: 0x1392394
	internal static string GetDisplayFormatString(string composite) { }

	// RVA: 0x13924B0
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputBindingComposite<T0>
{
	// Methods

	// RVA: 0x30A17DC
	public override Type get_valueType() { }

	// RVA: 0x30A14A4
	public override int get_valueSizeInBytes() { }

	// RVA: -1
	public abstract TValue ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x315B3A8
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x30A188C
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
public struct PartBinding
{
	// Fields
	private int <part>k__BackingField; // 0x10
	private InputControl <control>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1392A40
	public int get_part() { }

	// RVA: 0x1392A48
	public void set_part(int value) { }

	// RVA: 0x1392A50
	public InputControl get_control() { }

	// RVA: 0x1392A58
	public void set_control(InputControl value) { }

}

// Namespace: 
private struct DefaultComparer<T0>
{
	// Methods

	// RVA: 0x315B3A8
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

	// RVA: 0x1392858
	public void .ctor(int <>1__state) { }

	// RVA: 0x1392A60
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1392A64
	private bool MoveNext() { }

	// RVA: 0x1392BAC
	private PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current() { }

	// RVA: 0x1392BB8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1392BF8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1392C60
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() { }

	// RVA: 0x1392D0C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public struct InputBindingCompositeContext
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal int m_BindingIndex; // 0x18

	// Methods

	// RVA: 0x13927CC
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls() { }

	// RVA: 0x1392890
	public float EvaluateMagnitude(int partNumber) { }

	// RVA: 0x315B3A8
	public TValue ReadValue(int partNumber) { }

	// RVA: 0x315B3A8
	public TValue ReadValue(int partNumber, InputControl sourceControl) { }

	// RVA: 0x315B3A8
	public TValue ReadValue(int partNumber, TComparer comparer) { }

	// RVA: 0x315B3A8
	public TValue ReadValue(int partNumber, InputControl sourceControl, TComparer comparer) { }

	// RVA: 0x13928B8
	public bool ReadValueAsButton(int partNumber) { }

	// RVA: 0x1392950
	public void ReadValue(int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x1392974
	public object ReadValueAsObject(int partNumber) { }

	// RVA: 0x139299C
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

	// RVA: 0x1392D10
	public int get_totalMapCount() { }

	// RVA: 0x1392D18
	public int get_totalActionCount() { }

	// RVA: 0x1392D20
	public int get_totalBindingCount() { }

	// RVA: 0x1392D28
	public int get_totalControlCount() { }

	// RVA: 0x1392D30
	public void Dispose() { }

	// RVA: 0x1392D7C
	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

	// RVA: 0x1392F1C
	public void AddActionMap(InputActionMap actionMap) { }

	// RVA: 0x315B3A8
	private int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, TType[] array, int count, InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x13949C0
	private static InputBindingComposite InstantiateBindingComposite(InputBinding binding, InputActionMap actionMap) { }

	// RVA: 0x1394E84
	private static void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, InputActionMap actionMap, InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	// RVA: 0x1394C4C
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

	// RVA: 0x13A7054
	public InputControl get_control() { }

	// RVA: 0x13A70AC
	public InputDevice get_device() { }

	// RVA: 0x13A7110
	public int get_requirementIndex() { }

	// RVA: 0x13A7118
	public DeviceRequirement get_requirement() { }

	// RVA: 0x13A7150
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

	// RVA: 0x13A7198
	public bool MoveNext() { }

	// RVA: 0x13A71C4
	public void Reset() { }

	// RVA: 0x13A71D0
	public Match get_Current() { }

	// RVA: 0x13A728C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13A72F8
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

	// RVA: 0x13A6C58
	public float get_score() { }

	// RVA: 0x13A6C60
	public bool get_isSuccessfulMatch() { }

	// RVA: 0x13A6C70
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x13A6C80
	public bool get_hasMissingOptionalDevices() { }

	// RVA: 0x13A6C90
	public UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13A6DE0
	public Match get_Item(int index) { }

	// RVA: 0x13A6EA0
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator() { }

	// RVA: 0x13A6F40
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13A6FE0
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

	// RVA: 0x13A72FC
	public string get_controlPath() { }

	// RVA: 0x13A7304
	public void set_controlPath(string value) { }

	// RVA: 0x13A718C
	public bool get_isOptional() { }

	// RVA: 0x13A730C
	public void set_isOptional(bool value) { }

	// RVA: 0x13A7320
	public bool get_isAND() { }

	// RVA: 0x13A733C
	public void set_isAND(bool value) { }

	// RVA: 0x13A7330
	public bool get_isOR() { }

	// RVA: 0x13A735C
	public void set_isOR(bool value) { }

	// RVA: 0x13A737C
	public override string ToString() { }

	// RVA: 0x13A7458
	public bool Equals(DeviceRequirement other) { }

	// RVA: 0x13A74E0
	public override bool Equals(object obj) { }

	// RVA: 0x13A75B4
	public override int GetHashCode() { }

	// RVA: 0x13A68A8
	public static bool op_Equality(DeviceRequirement left, DeviceRequirement right) { }

	// RVA: 0x13A76C0
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

	// RVA: 0x13A790C
	public DeviceRequirement ToDeviceEntry() { }

	// RVA: 0x13A7AF4
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

	// RVA: 0x13A7724
	public InputControlScheme ToScheme() { }

	// RVA: 0x13A7960
	public static SchemeJson ToJson(InputControlScheme scheme) { }

	// RVA: 0x13A7B3C
	public static SchemeJson[] ToJson(InputControlScheme[] schemes) { }

	// RVA: 0x13A7C78
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

	// RVA: 0x13A6328
	public string get_name() { }

	// RVA: 0x13A6330
	public string get_bindingGroup() { }

	// RVA: 0x13A6338
	public void set_bindingGroup(string value) { }

	// RVA: 0x13A6340
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements() { }

	// RVA: 0x13A63AC
	public void .ctor(string name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, string bindingGroup) { }

	// RVA: 0x13A64E0
	internal void SetNameAndBindingGroup(string name, string bindingGroup) { }

	// RVA: 0x315B3A8
	public static System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch) { }

	// RVA: 0x315B3A8
	public static bool FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputControlScheme controlScheme, MatchResult matchResult, InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch) { }

	// RVA: 0x315B3A8
	public static System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice(InputDevice device, TSchemes schemes) { }

	// RVA: 0x13A65C4
	public bool SupportsDevice(InputDevice device) { }

	// RVA: 0x315B3A8
	public MatchResult PickDevicesFrom(TDevices devices, InputDevice favorDevice) { }

	// RVA: 0x13A6734
	public bool Equals(InputControlScheme other) { }

	// RVA: 0x13A6910
	public override bool Equals(object obj) { }

	// RVA: 0x13A69B8
	public override int GetHashCode() { }

	// RVA: 0x13A6A50
	public override string ToString() { }

	// RVA: 0x13A6BF4
	public static bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	// RVA: 0x13A6C24
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

	// RVA: 0x13A7D90
	public InputAction get_action() { }

	// RVA: 0x13A7DB8
	public InputControl get_control() { }

	// RVA: 0x13A7DE0
	public InputActionPhase get_phase() { }

	// RVA: 0x13A7DE8
	public Double get_time() { }

	// RVA: 0x13A7DF0
	public Double get_startTime() { }

	// RVA: 0x13A7DF8
	public bool get_timerHasExpired() { }

	// RVA: 0x13A7E04
	internal void set_timerHasExpired(bool value) { }

	// RVA: 0x13A7E24
	public bool get_isWaiting() { }

	// RVA: 0x13A7E34
	public bool get_isStarted() { }

	// RVA: 0x13A7E44
	public float ComputeMagnitude() { }

	// RVA: 0x13A7E4C
	public bool ControlIsActuated(float threshold) { }

	// RVA: 0x13A7E58
	public void Started() { }

	// RVA: 0x13A7E98
	public void Performed() { }

	// RVA: 0x13A7EE0
	public void PerformedAndStayStarted() { }

	// RVA: 0x13A7F28
	public void PerformedAndStayPerformed() { }

	// RVA: 0x13A7F70
	public void Canceled() { }

	// RVA: 0x13A7FB8
	public void Waiting() { }

	// RVA: 0x13A8000
	public void SetTimeout(float seconds) { }

	// RVA: 0x13A8028
	public void SetTotalTimeoutCompletionTime(float seconds) { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x13A80BC
	internal int get_mapIndex() { }

	// RVA: 0x13A80C4
	internal int get_controlIndex() { }

	// RVA: 0x13A80D0
	internal int get_bindingIndex() { }

	// RVA: 0x13A80D8
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

	// RVA: 0x13AE2F4
	private static void .cctor() { }

	// RVA: 0x13AE360
	public void .ctor() { }

	// RVA: 0x13AE368
	internal InputControl <get_onAnyButtonPress>b__79_0(InputEventPtr e) { }

	// RVA: 0x13AE5C4
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

	// RVA: 0x13A80E4
	public static void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13A8224
	public static void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13A8364
	public static void RegisterLayout(Type type, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x315B3A8
	public static void RegisterLayout(string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x13A855C
	public static void RegisterLayout(string json, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x13A86AC
	public static void RegisterLayoutOverride(string json, string name) { }

	// RVA: 0x13A8748
	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x315B3A8
	public static void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x13A87E0
	public static void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x30A7C50
	public static void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x13A899C
	public static void RemoveLayout(string name) { }

	// RVA: 0x13A8A2C
	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x13A8AC8
	public static System.Collections.Generic.IEnumerable<System.String> ListLayouts() { }

	// RVA: 0x13A8B4C
	public static System.Collections.Generic.IEnumerable<System.String> ListLayoutsBasedOn(string baseLayout) { }

	// RVA: 0x13A8C14
	public static InputControlLayout LoadLayout(string name) { }

	// RVA: 0x30A5298
	public static InputControlLayout LoadLayout() { }

	// RVA: 0x13A8D00
	public static string GetNameOfBaseLayout(string layoutName) { }

	// RVA: 0x13A8E30
	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	// RVA: 0x13A8F90
	public static void RegisterProcessor(Type type, string name) { }

	// RVA: 0x30A7C50
	public static void RegisterProcessor(string name) { }

	// RVA: 0x13A9428
	public static Type TryGetProcessor(string name) { }

	// RVA: 0x13A9508
	public static System.Collections.Generic.IEnumerable<System.String> ListProcessors() { }

	// RVA: 0x13A95A0
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13A9620
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices() { }

	// RVA: 0x13A96D8
	public static void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13A985C
	public static void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13A99E0
	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13A9B64
	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13A9CE8
	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13A9E28
	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13A9F68
	public static float get_pollingFrequency() { }

	// RVA: 0x13A9FE8
	public static void set_pollingFrequency(float value) { }

	// RVA: 0x13AA078
	public static InputDevice AddDevice(string layout, string name, string variants) { }

	// RVA: 0x315B3A8
	public static TDevice AddDevice(string name) { }

	// RVA: 0x13AA17C
	public static InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x13AA27C
	public static void AddDevice(InputDevice device) { }

	// RVA: 0x13AA338
	public static void RemoveDevice(InputDevice device) { }

	// RVA: 0x13AA3CC
	public static void FlushDisconnectedDevices() { }

	// RVA: 0x13AA44C
	public static InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x315B3A8
	public static TDevice GetDevice() { }

	// RVA: 0x13AA4DC
	public static InputDevice GetDevice(Type type) { }

	// RVA: 0x315B3A8
	public static TDevice GetDevice(InternedString usage) { }

	// RVA: 0x315B3A8
	public static TDevice GetDevice(string usage) { }

	// RVA: 0x13AA7F4
	public static InputDevice GetDeviceById(int deviceId) { }

	// RVA: 0x13AA884
	public static System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices() { }

	// RVA: 0x13AA990
	public static int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x13AAA20
	public static void EnableDevice(InputDevice device) { }

	// RVA: 0x13AAAB8
	public static void DisableDevice(InputDevice device, bool keepSendingEvents) { }

	// RVA: 0x13AAB54
	public static bool TrySyncDevice(InputDevice device) { }

	// RVA: 0x13AAD18
	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls) { }

	// RVA: 0x13AADB4
	public static bool TryResetDevice(InputDevice device) { }

	// RVA: 0x13AAF08
	public static void PauseHaptics() { }

	// RVA: 0x13AB0C8
	public static void ResumeHaptics() { }

	// RVA: 0x13AB28C
	public static void ResetHaptics() { }

	// RVA: 0x13AB450
	public static void SetDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13AB558
	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13AB600
	public static void AddDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13AB6A4
	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13AB74C
	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13AB7F0
	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13AB898
	public static InputControl FindControl(string path) { }

	// RVA: 0x13ABA18
	public static UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(string path) { }

	// RVA: 0x315B3A8
	public static UnityEngine.InputSystem.InputControlList<TControl> FindControls(string path) { }

	// RVA: 0x30A4874
	public static int FindControls(string path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x13ABAAC
	internal static bool get_isProcessingEvents() { }

	// RVA: 0x13ABB2C
	public static InputEventListener get_onEvent() { }

	// RVA: 0x13ABB34
	public static void set_onEvent(InputEventListener value) { }

	// RVA: 0x13ABB38
	public static System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress() { }

	// RVA: 0x13ABD78
	public static void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x30A7C50
	public static void QueueEvent(TEvent inputEvent) { }

	// RVA: 0x315B3A8
	public static void QueueStateEvent(InputDevice device, TState state, Double time) { }

	// RVA: 0x315B3A8
	public static void QueueDeltaStateEvent(InputControl control, TDelta delta, Double time) { }

	// RVA: 0x13ABE60
	public static void QueueConfigChangeEvent(InputDevice device, Double time) { }

	// RVA: 0x13AC08C
	public static void QueueTextEvent(InputDevice device, Char character, Double time) { }

	// RVA: 0x13AC2C8
	public static void Update() { }

	// RVA: 0x13AC348
	internal static void Update(InputUpdateType updateType) { }

	// RVA: 0x13AC524
	public static void add_onBeforeUpdate(Action value) { }

	// RVA: 0x13AC664
	public static void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x13AC7A4
	public static void add_onAfterUpdate(Action value) { }

	// RVA: 0x13AC8E4
	public static void remove_onAfterUpdate(Action value) { }

	// RVA: 0x13AC4A4
	public static InputSettings get_settings() { }

	// RVA: 0x13ACA24
	public static void set_settings(InputSettings value) { }

	// RVA: 0x13ACBA8
	public static void add_onSettingsChange(Action value) { }

	// RVA: 0x13ACC38
	public static void remove_onSettingsChange(Action value) { }

	// RVA: 0x13ACCC8
	private static void EnableActions() { }

	// RVA: 0x13ACF14
	private static void DisableActions(bool triggerSetupChanged) { }

	// RVA: 0x13ACE88
	public static InputActionAsset get_actions() { }

	// RVA: 0x13AD07C
	public static void set_actions(InputActionAsset value) { }

	// RVA: 0x13AD1F4
	public static void add_onActionsChange(Action value) { }

	// RVA: 0x13AD284
	public static void remove_onActionsChange(Action value) { }

	// RVA: 0x13AD314
	public static void add_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x13AD3CC
	public static void remove_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x13AD484
	public static void RegisterInteraction(Type type, string name) { }

	// RVA: 0x30A7C50
	public static void RegisterInteraction(string name) { }

	// RVA: 0x13AD63C
	public static Type TryGetInteraction(string name) { }

	// RVA: 0x13AD71C
	public static System.Collections.Generic.IEnumerable<System.String> ListInteractions() { }

	// RVA: 0x13AD7B4
	public static void RegisterBindingComposite(Type type, string name) { }

	// RVA: 0x30A7C50
	public static void RegisterBindingComposite(string name) { }

	// RVA: 0x13AD96C
	public static Type TryGetBindingComposite(string name) { }

	// RVA: 0x13ADA4C
	public static void DisableAllEnabledActions() { }

	// RVA: 0x13ADA54
	public static System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions() { }

	// RVA: 0x13ADB44
	public static int ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions) { }

	// RVA: 0x13ADBA4
	public static InputRemoting get_remoting() { }

	// RVA: 0x13ADC20
	public static Version get_version() { }

	// RVA: 0x13ADC98
	public static bool get_runInBackground() { }

	// RVA: 0x13ADD9C
	public static void set_runInBackground(bool value) { }

	// RVA: 0x13ADEA0
	public static InputMetrics get_metrics() { }

	// RVA: 0x13ADF58
	private static void .cctor() { }

	// RVA: 0x13AE144
	private static void RunInitializeInPlayer() { }

	// RVA: 0x13AE1F0
	internal static void EnsureInitialized() { }

	// RVA: 0x13ADF64
	private static void InitializeInPlayer(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x13AE228
	private static void RunInitialUpdate() { }

	// RVA: 0x13AE1F4
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

	// RVA: 0x13AE5D0
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

	// RVA: 0x13AEDD4
	public string get_name() { }

	// RVA: 0x13AEDE4
	public string get_displayName() { }

	// RVA: 0x13AEE8C
	protected void set_displayName(string value) { }

	// RVA: 0x13AEE94
	public string get_shortDisplayName() { }

	// RVA: 0x13AEEF8
	protected void set_shortDisplayName(string value) { }

	// RVA: 0x13AEF00
	public string get_path() { }

	// RVA: 0x13AF100
	public string get_layout() { }

	// RVA: 0x13AF110
	public string get_variants() { }

	// RVA: 0x13AF120
	public InputDevice get_device() { }

	// RVA: 0x13AF128
	public InputControl get_parent() { }

	// RVA: 0x13AF130
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children() { }

	// RVA: 0x13AF1A4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x13AF218
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x13AF28C
	public InputStateBlock get_stateBlock() { }

	// RVA: 0x13AF298
	public bool get_noisy() { }

	// RVA: 0x13AF2A4
	internal void set_noisy(bool value) { }

	// RVA: 0x13AF3DC
	public bool get_synthetic() { }

	// RVA: 0x13AF3E8
	internal void set_synthetic(bool value) { }

	// RVA: 0x13AF408
	public InputControl get_Item(string path) { }

	// RVA: -1
	public abstract Type get_valueType() { }

	// RVA: -1
	public abstract int get_valueSizeInBytes() { }

	// RVA: 0x13AF534
	public float get_magnitude() { }

	// RVA: 0x13AF5A4
	public override string ToString() { }

	// RVA: 0x13AF64C
	private string DebuggerDisplay() { }

	// RVA: 0x13AF56C
	public float EvaluateMagnitude() { }

	// RVA: 0x13AF850
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	// RVA: -1
	public abstract object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: -1
	public abstract object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: -1
	public abstract void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x13AF858
	public virtual void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x13AF8BC
	public virtual void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: -1
	public abstract bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13AF920
	public InputControl TryGetChildControl(string path) { }

	// RVA: 0x315B3A8
	public TControl TryGetChildControl(string path) { }

	// RVA: 0x13AF9D8
	public InputControl GetChildControl(string path) { }

	// RVA: 0x315B3A8
	public TControl GetChildControl(string path) { }

	// RVA: 0x13AFBEC
	protected void .ctor() { }

	// RVA: 0x13AFC7C
	protected virtual void FinishSetup() { }

	// RVA: 0x13AEE4C
	protected void RefreshConfigurationIfNeeded() { }

	// RVA: 0x13AFCA0
	protected virtual void RefreshConfiguration() { }

	// RVA: 0x13AF838
	protected internal Void* get_currentStatePtr() { }

	// RVA: 0x13AFE04
	protected internal Void* get_previousFrameStatePtr() { }

	// RVA: 0x13AFE1C
	protected internal Void* get_defaultStatePtr() { }

	// RVA: 0x13AFE68
	protected internal Void* get_noiseMaskPtr() { }

	// RVA: 0x13AFEB4
	protected internal UInt32 get_stateOffsetRelativeToDeviceRoot() { }

	// RVA: 0x13AFF38
	public FourCC get_optimizedControlDataType() { }

	// RVA: 0x13AFF40
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	// RVA: 0x13AFF48
	public void ApplyParameterChanges() { }

	// RVA: 0x13B0414
	private void SetOptimizedControlDataType() { }

	// RVA: 0x13B04A8
	internal void SetOptimizedControlDataTypeRecursively() { }

	// RVA: 0x13B06D8
	internal void EnsureOptimizationTypeHasNotChanged() { }

	// RVA: 0x13B0B00
	internal bool get_isSetupFinished() { }

	// RVA: 0x13B0B0C
	internal void set_isSetupFinished(bool value) { }

	// RVA: 0x13B0B2C
	internal bool get_isButton() { }

	// RVA: 0x13B0B38
	internal void set_isButton(bool value) { }

	// RVA: 0x13AFC80
	internal bool get_isConfigUpToDate() { }

	// RVA: 0x13AFC8C
	internal void set_isConfigUpToDate(bool value) { }

	// RVA: 0x13B0B58
	internal bool get_dontReset() { }

	// RVA: 0x13B0B64
	internal void set_dontReset(bool value) { }

	// RVA: 0x13B0B84
	internal bool get_usesStateFromOtherControl() { }

	// RVA: 0x13B0B90
	internal void set_usesStateFromOtherControl(bool value) { }

	// RVA: 0x13B0BB0
	internal bool get_hasDefaultState() { }

	// RVA: 0x13B0BD0
	internal void CallFinishSetupRecursive() { }

	// RVA: 0x13AFAF0
	internal string MakeChildPath(string path) { }

	// RVA: 0x13B0CFC
	internal void BakeOffsetIntoStateBlockRecursive(UInt32 offset) { }

	// RVA: 0x13AFCA4
	internal int GetDeviceIndex() { }

	// RVA: 0x13B0E58
	internal bool IsValueConsideredPressed(float value) { }

	// RVA: 0x13B0F0C
	internal virtual void AddProcessor(object first) { }

	// RVA: 0x13B0F10
	internal void MarkAsStale() { }

	// RVA: 0x13B0260
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

	// RVA: 0x30A17DC
	public override Type get_valueType() { }

	// RVA: 0x30A14A4
	public override int get_valueSizeInBytes() { }

	// RVA: 0x30A17DC
	public TValue get_value() { }

	// RVA: 0x30A17DC
	internal TValue get_unprocessedValue() { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x315B3A8
	public TValue ReadValueFromPreviousFrame() { }

	// RVA: 0x315B3A8
	public TValue ReadDefaultValue() { }

	// RVA: 0x315B3A8
	public TValue ReadValueFromState(Void* statePtr) { }

	// RVA: 0x315B3A8
	public TValue ReadValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x315B3A8
	public TValue ReadUnprocessedValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x315B3A8
	public TValue ReadUnprocessedValue() { }

	// RVA: -1
	public abstract TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x315B3A8
	public override object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x315B3A8
	public override void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x315B3A8
	public override void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x315B3A8
	public override void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: 0x315B3A8
	public virtual void WriteValueIntoState(TValue value, Void* statePtr) { }

	// RVA: 0x315B3A8
	public override object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x30A3C14
	private static bool CompareValue(TValue firstValue, TValue secondValue) { }

	// RVA: 0x315B3A8
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x315B3A8
	public TValue ProcessValue(TValue value) { }

	// RVA: 0x30A27C0
	public void ProcessValue(TValue value) { }

	// RVA: 0x315B3A8
	internal TProcessor TryGetProcessor() { }

	// RVA: 0x30A27C0
	internal override void AddProcessor(object processor) { }

	// RVA: 0x30A2378
	protected override void FinishSetup() { }

	// RVA: 0x30A17DC
	internal UnityEngine.InputSystem.InputProcessor<TValue>[] get_processors() { }

	// RVA: 0x30A2378
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

	// RVA: 0x13B3618
	public InputEventPtr get_eventPtr() { }

	// RVA: 0x13B2D94
	public InputEventControlEnumerator GetEnumerator() { }

	// RVA: 0x13B3818
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x13B38C0
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

	// RVA: 0x13B3620
	internal void .ctor(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold) { }

	// RVA: 0x13B3DE4
	private bool CheckDefault(UInt32 numBits) { }

	// RVA: 0x13B3E04
	private bool CheckCurrent(UInt32 numBits) { }

	// RVA: 0x13B2DBC
	public bool MoveNext() { }

	// RVA: 0x13B3968
	public void Reset() { }

	// RVA: 0x13B3E3C
	public void Dispose() { }

	// RVA: 0x13B3E44
	public InputControl get_Current() { }

	// RVA: 0x13B3E4C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ControlBuilder
{
	// Fields
	private InputControl <control>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13B3E54
	public InputControl get_control() { }

	// RVA: 0x13B3E5C
	internal void set_control(InputControl value) { }

	// RVA: 0x13B3E64
	public ControlBuilder At(InputDevice device, int index) { }

	// RVA: 0x13B3FAC
	public ControlBuilder WithParent(InputControl parent) { }

	// RVA: 0x13B3FE0
	public ControlBuilder WithName(string name) { }

	// RVA: 0x13B4038
	public ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x13B4098
	public ControlBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x13B40F8
	public ControlBuilder WithLayout(InternedString layout) { }

	// RVA: 0x13B4130
	public ControlBuilder WithUsages(int startIndex, int count) { }

	// RVA: 0x13B4150
	public ControlBuilder WithAliases(int startIndex, int count) { }

	// RVA: 0x13B4170
	public ControlBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x13B4190
	public ControlBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x13B41B4
	public ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x13B4210
	public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) { }

	// RVA: 0x315B3A8
	public ControlBuilder WithProcessor(TProcessor processor) { }

	// RVA: 0x13B4240
	public ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x13B4270
	public ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x13B42A8
	public ControlBuilder DontReset(bool value) { }

	// RVA: 0x13B4318
	public ControlBuilder IsButton(bool value) { }

	// RVA: 0x13B4350
	public void Finish() { }

}

// Namespace: 
public struct DeviceBuilder
{
	// Fields
	private InputDevice <device>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13B4378
	public InputDevice get_device() { }

	// RVA: 0x13B4380
	internal void set_device(InputDevice value) { }

	// RVA: 0x13B4388
	public DeviceBuilder WithName(string name) { }

	// RVA: 0x13B43E0
	public DeviceBuilder WithDisplayName(string displayName) { }

	// RVA: 0x13B4440
	public DeviceBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x13B44A0
	public DeviceBuilder WithLayout(InternedString layout) { }

	// RVA: 0x13B44D8
	public DeviceBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x13B44F8
	public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x13B451C
	public DeviceBuilder IsNoisy(bool value) { }

	// RVA: 0x13B454C
	public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) { }

	// RVA: 0x13B46CC
	public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) { }

	// RVA: 0x13B4720
	public DeviceBuilder WithStateOffsetToControlIndexMap(UInt32[] map) { }

	// RVA: 0x13B4758
	public DeviceBuilder WithControlTree(Byte[] controlTreeNodes, UInt16[] controlTreeIndicies) { }

	// RVA: 0x13B4A40
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

	// RVA: 0x13B32A8
	public void .ctor(int <>1__state) { }

	// RVA: 0x13B4A68
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13B4A88
	private bool MoveNext() { }

	// RVA: 0x13B4D68
	private void <>m__Finally1() { }

	// RVA: 0x13B4D78
	private InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current() { }

	// RVA: 0x13B4D80
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13B4DC0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13B4DC8
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x13B4E78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputControlExtensions
{
	// Methods

	// RVA: 0x315B3A8
	public static TControl FindInParentChain(InputControl control) { }

	// RVA: 0x13B0F1C
	public static bool IsPressed(InputControl control, float buttonPressPoint) { }

	// RVA: 0x13B107C
	public static bool IsActuated(InputControl control, float threshold) { }

	// RVA: 0x13AF7B4
	public static object ReadValueAsObject(InputControl control) { }

	// RVA: 0x13B1288
	public static void ReadValueIntoBuffer(InputControl control, Void* buffer, int bufferSize) { }

	// RVA: 0x13B1348
	public static object ReadDefaultValueAsObject(InputControl control) { }

	// RVA: 0x315B3A8
	public static TValue ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent) { }

	// RVA: -1
	public static bool ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, TValue value) { }

	// RVA: 0x13B13F0
	public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	// RVA: 0x315B3A8
	public static TValue ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr eventPtr) { }

	// RVA: -1
	public static bool ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, TValue value) { }

	// RVA: 0x13B1544
	public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	// RVA: 0x13B15D8
	public static void WriteValueIntoState(InputControl control, Void* statePtr) { }

	// RVA: 0x315B3A8
	public static void WriteValueIntoState(InputControl control, TValue value, Void* statePtr) { }

	// RVA: 0x315B3A8
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Void* statePtr) { }

	// RVA: 0x315B3A8
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, Void* statePtr) { }

	// RVA: 0x315B3A8
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, TState state) { }

	// RVA: 0x315B3A8
	public static void WriteValueIntoEvent(InputControl control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x315B3A8
	public static void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x13B1760
	public static void CopyState(InputDevice device, Void* buffer, int bufferSizeInBytes) { }

	// RVA: 0x30A8E44
	public static void CopyState(InputDevice device, TState state) { }

	// RVA: 0x13B1208
	public static bool CheckStateIsAtDefault(InputControl control) { }

	// RVA: 0x13B18FC
	public static bool CheckStateIsAtDefault(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x13B1B74
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	// RVA: 0x13B1BF0
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x13B1CC4
	public static bool CompareStateIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x13B19D8
	public static bool CompareState(InputControl control, Void* firstStatePtr, Void* secondStatePtr, Void* maskPtr) { }

	// RVA: 0x13B1DAC
	public static bool CompareState(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x13B1E64
	public static bool HasValueChangeInState(InputControl control, Void* statePtr) { }

	// RVA: 0x13B1F14
	public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13B1480
	public static Void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13B1FF4
	internal static Void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	// RVA: 0x13B231C
	public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x315B3A8
	public static void QueueValueChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x13B24F0
	public static void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<System.Single> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x13B2600
	internal static void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x30A9370
	public static void FindControlsRecursive(InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl,System.Boolean> predicate) { }

	// RVA: 0x13B2714
	internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder) { }

	// RVA: 0x13B2AA8
	public static InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x13B2D34
	public static InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x13B2D78
	public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13AE378
	public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13B3214
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13B32E0
	public static ControlBuilder Setup(InputControl control) { }

	// RVA: 0x13B33C0
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

	// RVA: 0x315B3A8
	public void .ctor(UnityEngine.InputSystem.InputControlList<TControl> list) { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public TControl get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A14A4
	public int get_Capacity() { }

	// RVA: 0x30A24F0
	public void set_Capacity(int value) { }

	// RVA: 0x30A1224
	public bool get_IsReadOnly() { }

	// RVA: 0x315B3A8
	public TControl get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, TControl value) { }

	// RVA: 0x30A2560
	public void .ctor(Allocator allocator, int initialCapacity) { }

	// RVA: 0x30A2828
	public void .ctor(System.Collections.Generic.IEnumerable<TControl> values, Allocator allocator) { }

	// RVA: 0x30A27C0
	public void .ctor(TControl[] values) { }

	// RVA: 0x30A24F0
	public void Resize(int size) { }

	// RVA: 0x315B3A8
	public void Add(TControl item) { }

	// RVA: 0x315B3A8
	public void AddSlice(TList list, int count, int destinationIndex, int sourceIndex) { }

	// RVA: -1
	public void AddRange(System.Collections.Generic.IEnumerable<TControl> list, int count, int destinationIndex) { }

	// RVA: 0x315B3A8
	public bool Remove(TControl item) { }

	// RVA: 0x30A24F0
	public void RemoveAt(int index) { }

	// RVA: 0x30A2828
	public void CopyTo(TControl[] array, int arrayIndex) { }

	// RVA: 0x315B3A8
	public int IndexOf(TControl item) { }

	// RVA: 0x315B3A8
	public int IndexOf(TControl item, int startIndex, int count) { }

	// RVA: 0x315B3A8
	public void Insert(int index, TControl item) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool Contains(TControl item) { }

	// RVA: 0x315B3A8
	public bool Contains(TControl item, int startIndex, int count) { }

	// RVA: 0x30A2560
	public void SwapElements(int index1, int index2) { }

	// RVA: 0x315B3A8
	public void Sort(int startIndex, int count, TCompare comparer) { }

	// RVA: -1
	public TControl[] ToArray(bool dispose) { }

	// RVA: 0x30A2A20
	internal void AppendTo(TControl[] array, int count) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<TControl> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A17DC
	public override string ToString() { }

	// RVA: 0x315B3A8
	private static UInt64 ToIndex(TControl control) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x13B881C
	private static void .cctor() { }

	// RVA: 0x13B8888
	public void .ctor() { }

	// RVA: 0x13B8890
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

	// RVA: 0x13B8454
	public string get_layout() { }

	// RVA: 0x13B845C
	public System.Collections.Generic.IEnumerable<System.String> get_usages() { }

	// RVA: 0x13B85B0
	public string get_name() { }

	// RVA: 0x13B85BC
	public string get_displayName() { }

	// RVA: 0x13B6888
	internal bool get_isWildcard() { }

	// RVA: 0x13B85C8
	internal bool get_isDoubleWildcard() { }

	// RVA: 0x13B5A3C
	internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, string referencedLayoutName, string controlPath, HumanReadableStringOptions options) { }

	// RVA: 0x13B8638
	private static string ToHumanReadableString(Substring substring) { }

	// RVA: 0x13B7A90
	public bool Matches(InputControl control) { }

	// RVA: 0x13B86A0
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

	// RVA: 0x13B7094
	public bool get_isAtEnd() { }

	// RVA: 0x13B56F0
	public void .ctor(string path) { }

	// RVA: 0x13B5744
	public bool MoveToNextComponent() { }

	// RVA: 0x13B88B8
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

	// RVA: 0x13B89B8
	private static void .cctor() { }

	// RVA: 0x13B8A24
	public void .ctor() { }

	// RVA: 0x13B8A2C
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

	// RVA: 0x13B841C
	public void .ctor(int <>1__state) { }

	// RVA: 0x13B8A54
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13B8A58
	private bool MoveNext() { }

	// RVA: 0x13B8BDC
	private ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current() { }

	// RVA: 0x13B8C00
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13B8C40
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13B8CC0
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() { }

	// RVA: 0x13B8D68
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

	// RVA: 0x13B4F28
	internal static string CleanSlashes(string pathComponent) { }

	// RVA: 0x13AEF70
	public static string Combine(InputControl parent, string path) { }

	// RVA: 0x13B4F48
	public static string ToHumanReadableString(string path, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x13B4F78
	public static string ToHumanReadableString(string path, string deviceLayoutName, string controlPath, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x13B6504
	public static string[] TryGetDeviceUsages(string path) { }

	// RVA: 0x13B66CC
	public static string TryGetDeviceLayout(string path) { }

	// RVA: 0x13B68F8
	public static string TryGetControlLayout(string path) { }

	// RVA: 0x13B6C08
	private static string FindControlLayoutRecursive(PathParser parser, string layoutName) { }

	// RVA: 0x13B6D68
	private static string FindControlLayoutRecursive(PathParser parser, InputControlLayout layout) { }

	// RVA: 0x13B6F18
	private static bool ControlLayoutMatchesPathComponent(ControlItem controlItem, PathParser parser) { }

	// RVA: 0x13B70A8
	private static bool StringMatches(Substring str, InternedString matchTo) { }

	// RVA: 0x13A66C8
	public static InputControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13B735C
	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13B74B0
	public static int TryFindControls(InputControl control, string path, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& matches, int indexInPath) { }

	// RVA: 0x315B3A8
	public static TControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x315B3A8
	public static int TryFindControls(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches) { }

	// RVA: 0x13AF4C8
	public static InputControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x315B3A8
	public static TControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13B55FC
	public static bool Matches(string expected, InputControl control) { }

	// RVA: 0x13B759C
	internal static bool MatchControlComponent(ParsedPathComponent expectedControlComponent, ControlItem controlItem, bool matchAlias) { }

	// RVA: 0x13B7970
	public static bool MatchesPrefix(string expected, InputControl control) { }

	// RVA: 0x13B7524
	private static bool MatchesRecursive(PathParser parser, InputControl currentControl, bool prefixOnly) { }

	// RVA: 0x315B3A8
	private static TControl MatchControlsRecursive(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x315B3A8
	private static TControl MatchByUsageAtDeviceRootRecursive(InputDevice device, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x315B3A8
	private static TControl MatchChildrenRecursive(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x13B7FDC
	private static bool MatchPathComponent(string component, string path, int indexInPath, PathComponentType componentType, int startIndexInComponent) { }

	// RVA: 0x13B8298
	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	// RVA: 0x13B8394
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

	// RVA: 0x13B8D6C
	internal static Type GetValueTypeFromType(Type processorType) { }

	// RVA: 0x13B8E88
	public virtual CachingPolicy get_cachingPolicy() { }

	// RVA: 0x13B8E90
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputProcessor<T0>
{
	// Methods

	// RVA: -1
	public abstract TValue Process(TValue value, InputControl control) { }

	// RVA: 0x30A1970
	public override object ProcessAsObject(object value, InputControl control) { }

	// RVA: 0x315B3A8
	public override void Process(Void* buffer, int bufferSize, InputControl control) { }

	// RVA: 0x30A2378
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

	// RVA: 0x13B8E98
	public ButtonControl get_buttonWest() { }

	// RVA: 0x13B8EA0
	protected void set_buttonWest(ButtonControl value) { }

	// RVA: 0x13B8EB0
	public ButtonControl get_buttonNorth() { }

	// RVA: 0x13B8EB8
	protected void set_buttonNorth(ButtonControl value) { }

	// RVA: 0x13B8EC8
	public ButtonControl get_buttonSouth() { }

	// RVA: 0x13B8ED0
	protected void set_buttonSouth(ButtonControl value) { }

	// RVA: 0x13B8EE0
	public ButtonControl get_buttonEast() { }

	// RVA: 0x13B8EE8
	protected void set_buttonEast(ButtonControl value) { }

	// RVA: 0x13B8EF8
	public ButtonControl get_leftStickButton() { }

	// RVA: 0x13B8F00
	protected void set_leftStickButton(ButtonControl value) { }

	// RVA: 0x13B8F10
	public ButtonControl get_rightStickButton() { }

	// RVA: 0x13B8F18
	protected void set_rightStickButton(ButtonControl value) { }

	// RVA: 0x13B8F28
	public ButtonControl get_startButton() { }

	// RVA: 0x13B8F30
	protected void set_startButton(ButtonControl value) { }

	// RVA: 0x13B8F40
	public ButtonControl get_selectButton() { }

	// RVA: 0x13B8F48
	protected void set_selectButton(ButtonControl value) { }

	// RVA: 0x13B8F58
	public DpadControl get_dpad() { }

	// RVA: 0x13B8F60
	protected void set_dpad(DpadControl value) { }

	// RVA: 0x13B8F70
	public ButtonControl get_leftShoulder() { }

	// RVA: 0x13B8F78
	protected void set_leftShoulder(ButtonControl value) { }

	// RVA: 0x13B8F88
	public ButtonControl get_rightShoulder() { }

	// RVA: 0x13B8F90
	protected void set_rightShoulder(ButtonControl value) { }

	// RVA: 0x13B8FA0
	public StickControl get_leftStick() { }

	// RVA: 0x13B8FA8
	protected void set_leftStick(StickControl value) { }

	// RVA: 0x13B8FB8
	public StickControl get_rightStick() { }

	// RVA: 0x13B8FC0
	protected void set_rightStick(StickControl value) { }

	// RVA: 0x13B8FD0
	public ButtonControl get_leftTrigger() { }

	// RVA: 0x13B8FD8
	protected void set_leftTrigger(ButtonControl value) { }

	// RVA: 0x13B8FE8
	public ButtonControl get_rightTrigger() { }

	// RVA: 0x13B8FF0
	protected void set_rightTrigger(ButtonControl value) { }

	// RVA: 0x13B9000
	public ButtonControl get_aButton() { }

	// RVA: 0x13B9008
	public ButtonControl get_bButton() { }

	// RVA: 0x13B9010
	public ButtonControl get_xButton() { }

	// RVA: 0x13B9018
	public ButtonControl get_yButton() { }

	// RVA: 0x13B9020
	public ButtonControl get_triangleButton() { }

	// RVA: 0x13B9028
	public ButtonControl get_squareButton() { }

	// RVA: 0x13B9030
	public ButtonControl get_circleButton() { }

	// RVA: 0x13B9038
	public ButtonControl get_crossButton() { }

	// RVA: 0x13B9040
	public ButtonControl get_Item(GamepadButton button) { }

	// RVA: 0x13B929C
	public static Gamepad get_current() { }

	// RVA: 0x13B92E8
	private static void set_current(Gamepad value) { }

	// RVA: 0x13B934C
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all() { }

	// RVA: 0x13B93D8
	protected override void FinishSetup() { }

	// RVA: 0x13B976C
	public override void MakeCurrent() { }

	// RVA: 0x13B97CC
	protected override void OnAdded() { }

	// RVA: 0x13B9848
	protected override void OnRemoved() { }

	// RVA: 0x13B9974
	public virtual void PauseHaptics() { }

	// RVA: 0x13B9984
	public virtual void ResumeHaptics() { }

	// RVA: 0x13B9994
	public virtual void ResetHaptics() { }

	// RVA: 0x13B99A4
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x13B99B4
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

	// RVA: 0x13BB8B0
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

	// RVA: 0x13B9ABC
	public InputDeviceDescription get_description() { }

	// RVA: 0x13B9AD8
	public bool get_enabled() { }

	// RVA: 0x13B9C74
	public bool get_canRunInBackground() { }

	// RVA: 0x13AAC84
	public bool get_added() { }

	// RVA: 0x13B9D44
	public bool get_remote() { }

	// RVA: 0x13B9D50
	public bool get_native() { }

	// RVA: 0x13B9D5C
	public bool get_updateBeforeRender() { }

	// RVA: 0x13B9D68
	public int get_deviceId() { }

	// RVA: 0x13B9D70
	public Double get_lastUpdateTime() { }

	// RVA: 0x13B9DD0
	public bool get_wasUpdatedThisFrame() { }

	// RVA: 0x13B9E34
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls() { }

	// RVA: 0x13B9EA0
	public override Type get_valueType() { }

	// RVA: 0x13B9F40
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13B9FC8
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all() { }

	// RVA: 0x13B9A38
	public void .ctor() { }

	// RVA: 0x13BA090
	public override object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x13BA0D0
	public override object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x13BA1E4
	public override void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x13BA3A8
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13BA4AC
	internal void NotifyConfigurationChanged() { }

	// RVA: 0x13B97C8
	public virtual void MakeCurrent() { }

	// RVA: 0x13BA51C
	protected virtual void OnAdded() { }

	// RVA: 0x13BA520
	protected virtual void OnRemoved() { }

	// RVA: 0x13BA524
	protected virtual void OnConfigurationChanged() { }

	// RVA: -1
	public Int64 ExecuteCommand(TCommand command) { }

	// RVA: 0x13BA528
	protected virtual Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x13B9BA8
	internal bool QueryEnabledStateFromRuntime() { }

	// RVA: 0x13BA604
	internal bool get_disabledInFrontend() { }

	// RVA: 0x13BA610
	internal void set_disabledInFrontend(bool value) { }

	// RVA: 0x13BA630
	internal bool get_disabledInRuntime() { }

	// RVA: 0x13BA63C
	internal void set_disabledInRuntime(bool value) { }

	// RVA: 0x13BA65C
	internal bool get_disabledWhileInBackground() { }

	// RVA: 0x13BA668
	internal void set_disabledWhileInBackground(bool value) { }

	// RVA: 0x13BA688
	internal static UInt32 EncodeStateOffsetToControlMapEntry(UInt32 controlIndex, UInt32 stateOffsetInBits, UInt32 stateSizeInBits) { }

	// RVA: 0x13B3E20
	internal static void DecodeStateOffsetToControlMapEntry(UInt32 entry, UInt32 controlIndex, UInt32 stateOffset, UInt32 stateSize) { }

	// RVA: 0x13BA694
	internal bool get_hasControlsWithDefaultState() { }

	// RVA: 0x13B41F0
	internal void set_hasControlsWithDefaultState(bool value) { }

	// RVA: 0x13BA6A0
	internal bool get_hasDontResetControls() { }

	// RVA: 0x13B42F8
	internal void set_hasDontResetControls(bool value) { }

	// RVA: 0x13B2310
	internal bool get_hasStateCallbacks() { }

	// RVA: 0x13BA6AC
	internal void set_hasStateCallbacks(bool value) { }

	// RVA: 0x13BA6CC
	internal bool get_hasEventMerger() { }

	// RVA: 0x13BA6D8
	internal void set_hasEventMerger(bool value) { }

	// RVA: 0x13BA6F8
	internal bool get_hasEventPreProcessor() { }

	// RVA: 0x13BA704
	internal void set_hasEventPreProcessor(bool value) { }

	// RVA: 0x13BA724
	internal void AddDeviceUsage(InternedString usage) { }

	// RVA: 0x13BA7E4
	internal void RemoveDeviceUsage(InternedString usage) { }

	// RVA: 0x13BA8E4
	internal void ClearDeviceUsages() { }

	// RVA: 0x13AAC94
	internal bool RequestSync() { }

	// RVA: 0x13AAE84
	internal bool RequestReset() { }

	// RVA: 0x13BA948
	internal bool ExecuteEnableCommand() { }

	// RVA: 0x13BA9CC
	internal bool ExecuteDisableCommand() { }

	// RVA: 0x13BAA44
	internal void NotifyAdded() { }

	// RVA: 0x13BAA54
	internal void NotifyRemoved() { }

	// RVA: 0x315B3A8
	internal static TDevice Build(string layoutName, string layoutVariants, InputDeviceDescription deviceDescription, bool noPrecompiledLayouts) { }

	// RVA: 0x13BAA64
	internal void WriteChangedControlStates(Byte* deviceStateBuffer, Void* statePtr, UInt32 stateSizeInBytes, UInt32 stateOffsetInDevice) { }

	// RVA: 0x13BABC0
	private void WritePartialChangedControlStatesInternal(Void* statePtr, UInt32 stateSizeInBits, UInt32 stateOffsetInDeviceInBits, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x13BB1AC
	private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, UInt32 startOffset, UInt32 sizeInBits, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x13BB634
	private void DumpControlTree(ControlBitRangeNode parentNode, UInt32 startOffset, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x13BB764
	internal string DumpControlTree() { }

	// RVA: 0x13BAE5C
	private void WriteChangedControlStatesInternal(Void* statePtr, UInt32 stateSizeInBits, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x13BB834
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

	// RVA: 0x13BB8C4
	public ButtonControl get_trigger() { }

	// RVA: 0x13BB8CC
	protected void set_trigger(ButtonControl value) { }

	// RVA: 0x13BB8DC
	public StickControl get_stick() { }

	// RVA: 0x13BB8E4
	protected void set_stick(StickControl value) { }

	// RVA: 0x13BB8F4
	public AxisControl get_twist() { }

	// RVA: 0x13BB8FC
	protected void set_twist(AxisControl value) { }

	// RVA: 0x13BB90C
	public Vector2Control get_hatswitch() { }

	// RVA: 0x13BB914
	protected void set_hatswitch(Vector2Control value) { }

	// RVA: 0x13BB924
	public static Joystick get_current() { }

	// RVA: 0x13BB970
	private static void set_current(Joystick value) { }

	// RVA: 0x13BB9D4
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all() { }

	// RVA: 0x13BBA60
	protected override void FinishSetup() { }

	// RVA: 0x13BBBCC
	public override void MakeCurrent() { }

	// RVA: 0x13BBC28
	protected override void OnAdded() { }

	// RVA: 0x13BBCA4
	protected override void OnRemoved() { }

	// RVA: 0x13BBDD0
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

	// RVA: 0x13BBE54
	public void add_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13BBF44
	public void remove_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13BBFA0
	public void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13BC08C
	public void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13BC0E8
	public void SetIMEEnabled(bool enabled) { }

	// RVA: 0x13BC164
	public void SetIMECursorPosition(Vector2 position) { }

	// RVA: 0x13BC218
	public string get_keyboardLayout() { }

	// RVA: 0x13BC260
	protected void set_keyboardLayout(string value) { }

	// RVA: 0x13BC270
	public AnyKeyControl get_anyKey() { }

	// RVA: 0x13BC278
	protected void set_anyKey(AnyKeyControl value) { }

	// RVA: 0x13BC288
	public KeyControl get_spaceKey() { }

	// RVA: 0x13BC38C
	public KeyControl get_enterKey() { }

	// RVA: 0x13BC408
	public KeyControl get_tabKey() { }

	// RVA: 0x13BC484
	public KeyControl get_backquoteKey() { }

	// RVA: 0x13BC500
	public KeyControl get_quoteKey() { }

	// RVA: 0x13BC57C
	public KeyControl get_semicolonKey() { }

	// RVA: 0x13BC5F8
	public KeyControl get_commaKey() { }

	// RVA: 0x13BC674
	public KeyControl get_periodKey() { }

	// RVA: 0x13BC6F0
	public KeyControl get_slashKey() { }

	// RVA: 0x13BC76C
	public KeyControl get_backslashKey() { }

	// RVA: 0x13BC7E8
	public KeyControl get_leftBracketKey() { }

	// RVA: 0x13BC864
	public KeyControl get_rightBracketKey() { }

	// RVA: 0x13BC8E0
	public KeyControl get_minusKey() { }

	// RVA: 0x13BC95C
	public KeyControl get_equalsKey() { }

	// RVA: 0x13BC9D8
	public KeyControl get_aKey() { }

	// RVA: 0x13BCA54
	public KeyControl get_bKey() { }

	// RVA: 0x13BCAD0
	public KeyControl get_cKey() { }

	// RVA: 0x13BCB4C
	public KeyControl get_dKey() { }

	// RVA: 0x13BCBC8
	public KeyControl get_eKey() { }

	// RVA: 0x13BCC44
	public KeyControl get_fKey() { }

	// RVA: 0x13BCCC0
	public KeyControl get_gKey() { }

	// RVA: 0x13BCD3C
	public KeyControl get_hKey() { }

	// RVA: 0x13BCDB8
	public KeyControl get_iKey() { }

	// RVA: 0x13BCE34
	public KeyControl get_jKey() { }

	// RVA: 0x13BCEB0
	public KeyControl get_kKey() { }

	// RVA: 0x13BCF2C
	public KeyControl get_lKey() { }

	// RVA: 0x13BCFA8
	public KeyControl get_mKey() { }

	// RVA: 0x13BD024
	public KeyControl get_nKey() { }

	// RVA: 0x13BD0A0
	public KeyControl get_oKey() { }

	// RVA: 0x13BD11C
	public KeyControl get_pKey() { }

	// RVA: 0x13BD198
	public KeyControl get_qKey() { }

	// RVA: 0x13BD214
	public KeyControl get_rKey() { }

	// RVA: 0x13BD290
	public KeyControl get_sKey() { }

	// RVA: 0x13BD30C
	public KeyControl get_tKey() { }

	// RVA: 0x13BD388
	public KeyControl get_uKey() { }

	// RVA: 0x13BD404
	public KeyControl get_vKey() { }

	// RVA: 0x13BD480
	public KeyControl get_wKey() { }

	// RVA: 0x13BD4FC
	public KeyControl get_xKey() { }

	// RVA: 0x13BD578
	public KeyControl get_yKey() { }

	// RVA: 0x13BD5F4
	public KeyControl get_zKey() { }

	// RVA: 0x13BD670
	public KeyControl get_digit1Key() { }

	// RVA: 0x13BD6EC
	public KeyControl get_digit2Key() { }

	// RVA: 0x13BD768
	public KeyControl get_digit3Key() { }

	// RVA: 0x13BD7E4
	public KeyControl get_digit4Key() { }

	// RVA: 0x13BD860
	public KeyControl get_digit5Key() { }

	// RVA: 0x13BD8DC
	public KeyControl get_digit6Key() { }

	// RVA: 0x13BD958
	public KeyControl get_digit7Key() { }

	// RVA: 0x13BD9D4
	public KeyControl get_digit8Key() { }

	// RVA: 0x13BDA50
	public KeyControl get_digit9Key() { }

	// RVA: 0x13BDACC
	public KeyControl get_digit0Key() { }

	// RVA: 0x13BDB48
	public KeyControl get_leftShiftKey() { }

	// RVA: 0x13BDBC4
	public KeyControl get_rightShiftKey() { }

	// RVA: 0x13BDC40
	public KeyControl get_leftAltKey() { }

	// RVA: 0x13BDCBC
	public KeyControl get_rightAltKey() { }

	// RVA: 0x13BDD38
	public KeyControl get_leftCtrlKey() { }

	// RVA: 0x13BDDB4
	public KeyControl get_rightCtrlKey() { }

	// RVA: 0x13BDE30
	public KeyControl get_leftMetaKey() { }

	// RVA: 0x13BDEAC
	public KeyControl get_rightMetaKey() { }

	// RVA: 0x13BDF28
	public KeyControl get_leftWindowsKey() { }

	// RVA: 0x13BDFA4
	public KeyControl get_rightWindowsKey() { }

	// RVA: 0x13BE020
	public KeyControl get_leftAppleKey() { }

	// RVA: 0x13BE09C
	public KeyControl get_rightAppleKey() { }

	// RVA: 0x13BE118
	public KeyControl get_leftCommandKey() { }

	// RVA: 0x13BE194
	public KeyControl get_rightCommandKey() { }

	// RVA: 0x13BE210
	public KeyControl get_contextMenuKey() { }

	// RVA: 0x13BE28C
	public KeyControl get_escapeKey() { }

	// RVA: 0x13BE308
	public KeyControl get_leftArrowKey() { }

	// RVA: 0x13BE384
	public KeyControl get_rightArrowKey() { }

	// RVA: 0x13BE400
	public KeyControl get_upArrowKey() { }

	// RVA: 0x13BE47C
	public KeyControl get_downArrowKey() { }

	// RVA: 0x13BE4F8
	public KeyControl get_backspaceKey() { }

	// RVA: 0x13BE574
	public KeyControl get_pageDownKey() { }

	// RVA: 0x13BE5F0
	public KeyControl get_pageUpKey() { }

	// RVA: 0x13BE66C
	public KeyControl get_homeKey() { }

	// RVA: 0x13BE6E8
	public KeyControl get_endKey() { }

	// RVA: 0x13BE764
	public KeyControl get_insertKey() { }

	// RVA: 0x13BE7E0
	public KeyControl get_deleteKey() { }

	// RVA: 0x13BE85C
	public KeyControl get_capsLockKey() { }

	// RVA: 0x13BE8D8
	public KeyControl get_scrollLockKey() { }

	// RVA: 0x13BE954
	public KeyControl get_numLockKey() { }

	// RVA: 0x13BE9D0
	public KeyControl get_printScreenKey() { }

	// RVA: 0x13BEA4C
	public KeyControl get_pauseKey() { }

	// RVA: 0x13BEAC8
	public KeyControl get_numpadEnterKey() { }

	// RVA: 0x13BEB44
	public KeyControl get_numpadDivideKey() { }

	// RVA: 0x13BEBC0
	public KeyControl get_numpadMultiplyKey() { }

	// RVA: 0x13BEC3C
	public KeyControl get_numpadMinusKey() { }

	// RVA: 0x13BECB8
	public KeyControl get_numpadPlusKey() { }

	// RVA: 0x13BED34
	public KeyControl get_numpadPeriodKey() { }

	// RVA: 0x13BEDB0
	public KeyControl get_numpadEqualsKey() { }

	// RVA: 0x13BEE2C
	public KeyControl get_numpad0Key() { }

	// RVA: 0x13BEEA8
	public KeyControl get_numpad1Key() { }

	// RVA: 0x13BEF24
	public KeyControl get_numpad2Key() { }

	// RVA: 0x13BEFA0
	public KeyControl get_numpad3Key() { }

	// RVA: 0x13BF01C
	public KeyControl get_numpad4Key() { }

	// RVA: 0x13BF098
	public KeyControl get_numpad5Key() { }

	// RVA: 0x13BF114
	public KeyControl get_numpad6Key() { }

	// RVA: 0x13BF190
	public KeyControl get_numpad7Key() { }

	// RVA: 0x13BF20C
	public KeyControl get_numpad8Key() { }

	// RVA: 0x13BF288
	public KeyControl get_numpad9Key() { }

	// RVA: 0x13BF304
	public KeyControl get_f1Key() { }

	// RVA: 0x13BF380
	public KeyControl get_f2Key() { }

	// RVA: 0x13BF3FC
	public KeyControl get_f3Key() { }

	// RVA: 0x13BF478
	public KeyControl get_f4Key() { }

	// RVA: 0x13BF4F4
	public KeyControl get_f5Key() { }

	// RVA: 0x13BF570
	public KeyControl get_f6Key() { }

	// RVA: 0x13BF5EC
	public KeyControl get_f7Key() { }

	// RVA: 0x13BF668
	public KeyControl get_f8Key() { }

	// RVA: 0x13BF6E4
	public KeyControl get_f9Key() { }

	// RVA: 0x13BF760
	public KeyControl get_f10Key() { }

	// RVA: 0x13BF7DC
	public KeyControl get_f11Key() { }

	// RVA: 0x13BF858
	public KeyControl get_f12Key() { }

	// RVA: 0x13BF8D4
	public KeyControl get_oem1Key() { }

	// RVA: 0x13BF950
	public KeyControl get_oem2Key() { }

	// RVA: 0x13BF9CC
	public KeyControl get_oem3Key() { }

	// RVA: 0x13BFA48
	public KeyControl get_oem4Key() { }

	// RVA: 0x13BFAC4
	public KeyControl get_oem5Key() { }

	// RVA: 0x13BFB40
	public ButtonControl get_shiftKey() { }

	// RVA: 0x13BFB48
	protected void set_shiftKey(ButtonControl value) { }

	// RVA: 0x13BFB58
	public ButtonControl get_ctrlKey() { }

	// RVA: 0x13BFB60
	protected void set_ctrlKey(ButtonControl value) { }

	// RVA: 0x13BFB70
	public ButtonControl get_altKey() { }

	// RVA: 0x13BFB78
	protected void set_altKey(ButtonControl value) { }

	// RVA: 0x13BFB88
	public ButtonControl get_imeSelected() { }

	// RVA: 0x13BFB90
	protected void set_imeSelected(ButtonControl value) { }

	// RVA: 0x13BC304
	public KeyControl get_Item(Key key) { }

	// RVA: 0x13BFBA0
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys() { }

	// RVA: 0x13BFC0C
	public static Keyboard get_current() { }

	// RVA: 0x13BFC58
	private static void set_current(Keyboard value) { }

	// RVA: 0x13BFCBC
	public override void MakeCurrent() { }

	// RVA: 0x13BFD18
	protected override void OnRemoved() { }

	// RVA: 0x13BFDB0
	protected override void FinishSetup() { }

	// RVA: 0x13C1548
	protected override void RefreshConfiguration() { }

	// RVA: 0x13C1628
	public void OnTextInput(Char character) { }

	// RVA: 0x13C16DC
	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	// RVA: 0x13C184C
	public void OnIMECompositionChanged(IMECompositionString compositionString) { }

	// RVA: 0x13C1950
	protected KeyControl[] get_keys() { }

	// RVA: 0x13C1958
	protected void set_keys(KeyControl[] value) { }

	// RVA: 0x13C1968
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

	// RVA: 0x13C19EC
	public DeltaControl get_scroll() { }

	// RVA: 0x13C19F4
	protected void set_scroll(DeltaControl value) { }

	// RVA: 0x13C1A04
	public ButtonControl get_leftButton() { }

	// RVA: 0x13C1A0C
	protected void set_leftButton(ButtonControl value) { }

	// RVA: 0x13C1A1C
	public ButtonControl get_middleButton() { }

	// RVA: 0x13C1A24
	protected void set_middleButton(ButtonControl value) { }

	// RVA: 0x13C1A34
	public ButtonControl get_rightButton() { }

	// RVA: 0x13C1A3C
	protected void set_rightButton(ButtonControl value) { }

	// RVA: 0x13C1A4C
	public ButtonControl get_backButton() { }

	// RVA: 0x13C1A54
	protected void set_backButton(ButtonControl value) { }

	// RVA: 0x13C1A64
	public ButtonControl get_forwardButton() { }

	// RVA: 0x13C1A6C
	protected void set_forwardButton(ButtonControl value) { }

	// RVA: 0x13C1A7C
	public IntegerControl get_clickCount() { }

	// RVA: 0x13C1A84
	protected void set_clickCount(IntegerControl value) { }

	// RVA: 0x13C1A94
	public static Mouse get_current() { }

	// RVA: 0x13C1AE0
	private static void set_current(Mouse value) { }

	// RVA: 0x13C1B44
	public override void MakeCurrent() { }

	// RVA: 0x13C1BA8
	protected override void OnAdded() { }

	// RVA: 0x13C1C24
	protected override void OnRemoved() { }

	// RVA: 0x13C1CC4
	public void WarpCursorPosition(Vector2 position) { }

	// RVA: 0x13C1D78
	protected override void FinishSetup() { }

	// RVA: 0x13C1FAC
	protected void OnNextUpdate() { }

	// RVA: 0x13C2060
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13C20B4
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13C2168
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13C21BC
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

	// RVA: 0x13C21C4
	public ButtonControl get_tip() { }

	// RVA: 0x13C21CC
	protected void set_tip(ButtonControl value) { }

	// RVA: 0x13C21DC
	public ButtonControl get_eraser() { }

	// RVA: 0x13C21E4
	protected void set_eraser(ButtonControl value) { }

	// RVA: 0x13C21F4
	public ButtonControl get_firstBarrelButton() { }

	// RVA: 0x13C21FC
	protected void set_firstBarrelButton(ButtonControl value) { }

	// RVA: 0x13C220C
	public ButtonControl get_secondBarrelButton() { }

	// RVA: 0x13C2214
	protected void set_secondBarrelButton(ButtonControl value) { }

	// RVA: 0x13C2224
	public ButtonControl get_thirdBarrelButton() { }

	// RVA: 0x13C222C
	protected void set_thirdBarrelButton(ButtonControl value) { }

	// RVA: 0x13C223C
	public ButtonControl get_fourthBarrelButton() { }

	// RVA: 0x13C2244
	protected void set_fourthBarrelButton(ButtonControl value) { }

	// RVA: 0x13C2254
	public ButtonControl get_inRange() { }

	// RVA: 0x13C225C
	protected void set_inRange(ButtonControl value) { }

	// RVA: 0x13C226C
	public Vector2Control get_tilt() { }

	// RVA: 0x13C2274
	protected void set_tilt(Vector2Control value) { }

	// RVA: 0x13C2284
	public AxisControl get_twist() { }

	// RVA: 0x13C228C
	protected void set_twist(AxisControl value) { }

	// RVA: 0x13C229C
	public static Pen get_current() { }

	// RVA: 0x13C22E8
	internal static void set_current(Pen value) { }

	// RVA: 0x13C234C
	public ButtonControl get_Item(PenButton button) { }

	// RVA: 0x13C24AC
	public override void MakeCurrent() { }

	// RVA: 0x13C2510
	protected override void OnRemoved() { }

	// RVA: 0x13C25B0
	protected override void FinishSetup() { }

	// RVA: 0x13C2818
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

	// RVA: 0x13C2820
	public Vector2Control get_position() { }

	// RVA: 0x13C2828
	protected void set_position(Vector2Control value) { }

	// RVA: 0x13C2838
	public DeltaControl get_delta() { }

	// RVA: 0x13C2840
	protected void set_delta(DeltaControl value) { }

	// RVA: 0x13C2850
	public Vector2Control get_radius() { }

	// RVA: 0x13C2858
	protected void set_radius(Vector2Control value) { }

	// RVA: 0x13C2868
	public AxisControl get_pressure() { }

	// RVA: 0x13C2870
	protected void set_pressure(AxisControl value) { }

	// RVA: 0x13C2880
	public ButtonControl get_press() { }

	// RVA: 0x13C2888
	protected void set_press(ButtonControl value) { }

	// RVA: 0x13C2898
	public IntegerControl get_displayIndex() { }

	// RVA: 0x13C28A0
	protected void set_displayIndex(IntegerControl value) { }

	// RVA: 0x13C28B0
	public static Pointer get_current() { }

	// RVA: 0x13C28FC
	internal static void set_current(Pointer value) { }

	// RVA: 0x13C2960
	public override void MakeCurrent() { }

	// RVA: 0x13C29C4
	protected override void OnRemoved() { }

	// RVA: 0x13C2A64
	protected override void FinishSetup() { }

	// RVA: 0x13C2C58
	protected void OnNextUpdate() { }

	// RVA: 0x13C2D00
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13C2D58
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13C2E00
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13C2E58
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

	// RVA: 0x13C2E60
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
internal class FastKeyboard
{
	// Fields
	public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard";

	// Methods

	// RVA: 0x13C2E68
	public void .ctor() { }

	// RVA: 0x13C5DC4
	private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) { }

	// RVA: 0x13C5FC4
	private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C61C8
	private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C63C0
	private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C65C4
	private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C67BC
	private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C69B4
	private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C6BAC
	private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C6DA4
	private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C6F9C
	private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C7194
	private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C738C
	private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C7584
	private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C777C
	private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C7974
	private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C7B6C
	private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C7D64
	private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C7F5C
	private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C8154
	private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C834C
	private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C8544
	private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C873C
	private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C8934
	private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C8B2C
	private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C8D24
	private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C8F1C
	private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C9114
	private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C930C
	private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C9504
	private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C96FC
	private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C98F4
	private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C9AEC
	private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C9CE4
	private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13C9EDC
	private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CA0D4
	private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CA2CC
	private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CA4C4
	private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CA6BC
	private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CA8B4
	private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CAAAC
	private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CACA4
	private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CAE9C
	private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CB094
	private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CB28C
	private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CB484
	private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CB67C
	private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CB874
	private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CBA58
	private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CBC3C
	private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CBE20
	private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CC004
	private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CC1E8
	private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CC3CC
	private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CC5B0
	private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CC794
	private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CC978
	private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CCB5C
	private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CCD60
	private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CCF64
	private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13CD188
	private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CD38C
	private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CD590
	private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13CD7B4
	private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CD9B8
	private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CDBBC
	private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13CDDE0
	private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CDFE4
	private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CE1E8
	private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CE3EC
	private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CE5E4
	private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CE7DC
	private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CE9D4
	private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CEBCC
	private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CEDC4
	private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CEFBC
	private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CF1B4
	private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CF3AC
	private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CF5A4
	private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CF79C
	private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CF994
	private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CFB8C
	private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CFD84
	private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13CFF7C
	private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D0174
	private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D036C
	private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D0564
	private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D075C
	private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D0954
	private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D0B4C
	private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D0D44
	private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D0F3C
	private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D1134
	private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D132C
	private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D1524
	private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D171C
	private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D1914
	private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D1B0C
	private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D1D04
	private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D1EFC
	private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D20F4
	private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D22EC
	private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D24E4
	private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D26DC
	private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D28D4
	private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D2ACC
	private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D2CC4
	private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D2EBC
	private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D30B4
	private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D32AC
	private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D34A4
	private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D3688
	private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D386C
	private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D3A50
	private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D3C34
	private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13D3E18
	private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastMouse
{
	// Fields
	public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";

	// Methods

	// RVA: 0x13D4004
	public void .ctor() { }

	// RVA: 0x13D4AD8
	private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D4CC4
	private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13D4E88
	private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13D5038
	private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D5238
	private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D547C
	private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D56C0
	private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D58F8
	private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D5AF0
	private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D5CE8
	private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D5ED4
	private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D609C
	private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	// RVA: 0x13D622C
	private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D63D0
	private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D6588
	private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6794
	private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D69A0
	private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6BA8
	private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6DB8
	private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6FC8
	private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D71D0
	private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D73AC
	private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D7588
	private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D7790
	private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D79A0
	private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D7BB0
	private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D7DB8
	private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D7FAC
	private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D81B4
	private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D8390
	private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D856C
	protected void OnNextUpdate() { }

	// RVA: 0x13D86E0
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13D8888
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13D888C
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13D8890
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x13D89BC
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastTouchscreen
{
	// Fields
	public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer";

	// Methods

	// RVA: 0x13D89C8
	public void .ctor() { }

	// RVA: 0x13DBF80
	private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DC144
	private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13DC32C
	private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13DC4F4
	private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) { }

	// RVA: 0x13DC6E0
	private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13DC8A8
	private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13DCAA8
	private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DCC58
	private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DCE08
	private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DCFB8
	private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DD168
	private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DD318
	private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DD4C8
	private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DD678
	private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DD828
	private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DD9D8
	private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13DDB88
	private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13DDD2C
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13DDF4C
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13DE164
	private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13DE34C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13DE528
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13DE710
	private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13DE900
	private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13DEB24
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13DED00
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13DEEDC
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13DF114
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13DF344
	private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13DF534
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13DF730
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13DF93C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13DFB48
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13DFD50
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13DFF60
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0170
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0378
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0554
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0730
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E090C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0AE8
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0CC4
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E0EA0
	private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E10AC
	private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E12B8
	private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E14C0
	private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E16D0
	private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E18E0
	private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E1AE8
	private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E1CC4
	private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E1EA0
	private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E207C
	private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E2258
	private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E2478
	private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E2690
	private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13E2878
	private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E2A54
	private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E2C3C
	private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13E2E2C
	private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13E3050
	private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E322C
	private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E3408
	private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E3640
	private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E3864
	private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13E3A54
	private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E3C50
	private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E3E5C
	private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4068
	private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4270
	private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4480
	private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4690
	private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4898
	private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4A74
	private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4C50
	private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E4E2C
	private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E5008
	private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E51E4
	private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E53C0
	private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E55E0
	private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E57F8
	private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13E59E0
	private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E5BBC
	private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E5DA4
	private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13E5F94
	private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13E61B8
	private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E6394
	private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E6570
	private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E67A8
	private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E69CC
	private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13E6BBC
	private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E6DB8
	private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E6FC4
	private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E71D0
	private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E73D8
	private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E75E8
	private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E77F8
	private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E7A00
	private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E7BDC
	private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E7DB8
	private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E7F94
	private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E8170
	private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E834C
	private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E8528
	private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E8748
	private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E8960
	private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13E8B48
	private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13E8D24
	private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E8F0C
	private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13E90FC
	private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13E9320
	private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E94FC
	private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13E96D8
	private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E9910
	private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13E9B34
	private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13E9D24
	private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13E9F20
	private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EA12C
	private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EA338
	private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EA540
	private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EA750
	private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EA960
	private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EAB68
	private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EAD44
	private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EAF20
	private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EB0FC
	private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EB2D8
	private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EB4B4
	private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EB690
	private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EB8B0
	private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EBAC8
	private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13EBCB0
	private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EBE8C
	private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EC074
	private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13EC264
	private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13EC488
	private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EC664
	private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EC840
	private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13ECA78
	private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13ECC9C
	private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13ECE8C
	private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13ED088
	private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13ED294
	private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13ED4A0
	private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13ED6A8
	private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13ED8B8
	private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EDAC8
	private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EDCD0
	private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EDEAC
	private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EE088
	private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EE264
	private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EE440
	private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EE61C
	private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EE7F8
	private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EEA18
	private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EEC30
	private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13EEE18
	private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13EEFF4
	private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13EF1DC
	private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13EF3CC
	private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13EF5F0
	private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EF7CC
	private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13EF9A8
	private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13EFBE0
	private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13EFE04
	private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13EFFF4
	private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F01F0
	private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F03FC
	private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0608
	private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0810
	private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0A20
	private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0C30
	private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F0E38
	private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F1014
	private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F11F0
	private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F13CC
	private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F15A8
	private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F1784
	private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F1960
	private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F1B80
	private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F1D98
	private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13F1F80
	private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F215C
	private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F2344
	private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13F2534
	private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13F2758
	private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F2934
	private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F2B10
	private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F2D48
	private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F2F6C
	private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13F315C
	private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F3358
	private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3564
	private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3770
	private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3978
	private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3B88
	private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3D98
	private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F3FA0
	private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F417C
	private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4358
	private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4534
	private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4710
	private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F48EC
	private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F4AC8
	private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F4CE8
	private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F4F00
	private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13F50E8
	private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F52C4
	private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F54AC
	private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13F569C
	private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13F58C0
	private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F5A9C
	private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F5C78
	private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F5EB0
	private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F60D4
	private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13F62C4
	private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F64C0
	private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F66CC
	private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F68D8
	private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6AE0
	private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6CF0
	private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F6F00
	private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F7108
	private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F72E4
	private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F74C0
	private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F769C
	private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F7878
	private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F7A54
	private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F7C30
	private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F7E50
	private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F8068
	private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13F8250
	private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F842C
	private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F8614
	private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13F8804
	private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13F8A28
	private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F8C04
	private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13F8DE0
	private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F9018
	private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13F923C
	private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13F942C
	private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13F9628
	private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9834
	private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9A40
	private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9C48
	private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13F9E58
	private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA068
	private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA270
	private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA44C
	private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA628
	private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA804
	private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FA9E0
	private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FABBC
	private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FAD98
	private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FAFB8
	private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FB1D0
	private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13FB3B8
	private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FB594
	private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FB77C
	private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13FB96C
	private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13FBB90
	private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FBD6C
	private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FBF48
	private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FC180
	private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FC3A4
	private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13FC594
	private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FC790
	private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FC99C
	private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FCBA8
	private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FCDB0
	private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FCFC0
	private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD1D0
	private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD3D8
	private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD5B4
	private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD790
	private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FD96C
	private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FDB48
	private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FDD24
	private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FDF00
	private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FE120
	private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FE338
	private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13FE520
	private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FE6FC
	private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FE8E4
	private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13FEAD4
	private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13FECF8
	private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FEED4
	private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13FF0B0
	private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FF2E8
	private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13FF50C
	private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13FF6FC
	private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13FF8F8
	private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FFB04
	private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FFD10
	private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13FFF18
	private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400128
	private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400338
	private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400540
	private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x140071C
	private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14008F8
	private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400AD4
	private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400CB0
	private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1400E8C
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

	// RVA: 0x1404718
	public void Dispose() { }

	// RVA: 0x14028B4
	public void .ctor() { }

}

// Namespace: 
private static class ConnectMsg
{
	// Methods

	// RVA: 0x1401850
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StartSendingMsg
{
	// Methods

	// RVA: 0x1402784
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StopSendingMsg
{
	// Methods

	// RVA: 0x1402798
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class DisconnectMsg
{
	// Methods

	// RVA: 0x14018A8
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

	// RVA: 0x1402E2C
	public static System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(InputRemoting sender, string layoutName) { }

	// RVA: 0x1401964
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

	// RVA: 0x1405040
	private static void .cctor() { }

	// RVA: 0x14050AC
	public void .ctor() { }

	// RVA: 0x14050B4
	internal string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class NewDeviceMsg
{
	// Methods

	// RVA: 0x14032F4
	public static Message Create(InputDevice device) { }

	// RVA: 0x1401AF0
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class NewEventsMsg
{
	// Methods

	// RVA: 0x1403B60
	public static Message CreateResetEvent(InputDevice device, bool isHardReset) { }

	// RVA: 0x1403570
	public static Message CreateStateEvent(InputDevice device) { }

	// RVA: 0x14036D0
	public static Message Create(InputEvent* events, int eventCount) { }

	// RVA: 0x14020B4
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

	// RVA: 0x14052B4
	private static void .cctor() { }

	// RVA: 0x1405320
	public void .ctor() { }

	// RVA: 0x1405328
	internal string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class ChangeUsageMsg
{
	// Methods

	// RVA: 0x1403970
	public static Message Create(InputDevice device) { }

	// RVA: 0x140231C
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class RemoveDeviceMsg
{
	// Methods

	// RVA: 0x1403920
	public static Message Create(InputDevice device) { }

	// RVA: 0x140268C
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

	// RVA: 0x1401068
	public bool get_sending() { }

	// RVA: 0x1401074
	private void set_sending(bool value) { }

	// RVA: 0x1401088
	internal void .ctor(InputManager manager, bool startSendingOnConnect) { }

	// RVA: 0x1401128
	public void StartSending() { }

	// RVA: 0x1401464
	public void StopSending() { }

	// RVA: 0x140175C
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x14027AC
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x14027B0
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x14027B4
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x1401440
	private void SendInitialMessages() { }

	// RVA: 0x14028BC
	private void SendAllGeneratedLayouts() { }

	// RVA: 0x1402D4C
	private void SendLayout(string layoutName) { }

	// RVA: 0x1402B40
	private void SendAllDevices() { }

	// RVA: 0x140326C
	private void SendDevice(InputDevice device) { }

	// RVA: 0x1403668
	private void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x14037D8
	private void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1403BDC
	private void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	// RVA: 0x14030F4
	private void Send(Message msg) { }

	// RVA: 0x1403D18
	private int FindOrCreateSenderRecord(int senderId) { }

	// RVA: 0x1403DC4
	private static InternedString BuildLayoutNamespace(int senderId) { }

	// RVA: 0x1403E64
	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x1403ED8
	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x140404C
	internal InputManager get_manager() { }

	// RVA: 0x1404054
	public void RemoveRemoteDevices(int participantId) { }

	// RVA: 0x315B3A8
	private static Byte[] SerializeData(TData data) { }

	// RVA: 0x315B3A8
	private static TData DeserializeData(Byte[] data) { }

}

// Namespace: 
private class Subscriber
{
	// Fields
	public RemoteInputPlayerConnection owner; // 0x10
	public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer; // 0x18

	// Methods

	// RVA: 0x14063EC
	public void Dispose() { }

	// RVA: 0x1405CBC
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

	// RVA: 0x1405350
	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	// RVA: 0x1405B08
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x1405A24
	private void OnConnected(int id) { }

	// RVA: 0x1405DF8
	private void OnDisconnected(int id) { }

	// RVA: 0x1405EDC
	private void OnNewDevice(MessageEventArgs args) { }

	// RVA: 0x1405EE8
	private void OnNewLayout(MessageEventArgs args) { }

	// RVA: 0x1405EF4
	private void OnNewEvents(MessageEventArgs args) { }

	// RVA: 0x1405F00
	private void OnRemoveDevice(MessageEventArgs args) { }

	// RVA: 0x1405F0C
	private void OnChangeUsages(MessageEventArgs args) { }

	// RVA: 0x1405F18
	private void OnStartSending(MessageEventArgs args) { }

	// RVA: 0x1405F24
	private void OnStopSending(MessageEventArgs args) { }

	// RVA: 0x1405CC4
	private void SendToSubscribers(MessageType type, MessageEventArgs args) { }

	// RVA: 0x1405F30
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x14061EC
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x14061F0
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x14061F4
	public void .ctor() { }

	// RVA: 0x14061FC
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Sensor
{
	// Methods

	// RVA: 0x1406448
	public float get_samplingFrequency() { }

	// RVA: 0x1406544
	public void set_samplingFrequency(float value) { }

	// RVA: 0x14065F4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Accelerometer
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x170
	private static Accelerometer <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x14065FC
	public Vector3Control get_acceleration() { }

	// RVA: 0x1406604
	protected void set_acceleration(Vector3Control value) { }

	// RVA: 0x1406614
	public static Accelerometer get_current() { }

	// RVA: 0x1406660
	private static void set_current(Accelerometer value) { }

	// RVA: 0x14066C4
	public override void MakeCurrent() { }

	// RVA: 0x1406728
	protected override void OnRemoved() { }

	// RVA: 0x14067C8
	protected override void FinishSetup() { }

	// RVA: 0x1406850
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Gyroscope
{
	// Fields
	private Vector3Control <angularVelocity>k__BackingField; // 0x170
	private static Gyroscope <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1406858
	public Vector3Control get_angularVelocity() { }

	// RVA: 0x1406860
	protected void set_angularVelocity(Vector3Control value) { }

	// RVA: 0x1406870
	public static Gyroscope get_current() { }

	// RVA: 0x14068BC
	private static void set_current(Gyroscope value) { }

	// RVA: 0x1406920
	public override void MakeCurrent() { }

	// RVA: 0x1406984
	protected override void OnRemoved() { }

	// RVA: 0x1406A24
	protected override void FinishSetup() { }

	// RVA: 0x1406AAC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class GravitySensor
{
	// Fields
	private Vector3Control <gravity>k__BackingField; // 0x170
	private static GravitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1406AB4
	public Vector3Control get_gravity() { }

	// RVA: 0x1406ABC
	protected void set_gravity(Vector3Control value) { }

	// RVA: 0x1406ACC
	public static GravitySensor get_current() { }

	// RVA: 0x1406B18
	private static void set_current(GravitySensor value) { }

	// RVA: 0x1406B7C
	protected override void FinishSetup() { }

	// RVA: 0x1406C04
	public override void MakeCurrent() { }

	// RVA: 0x1406C68
	protected override void OnRemoved() { }

	// RVA: 0x1406D08
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AttitudeSensor
{
	// Fields
	private QuaternionControl <attitude>k__BackingField; // 0x170
	private static AttitudeSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1406D10
	public QuaternionControl get_attitude() { }

	// RVA: 0x1406D18
	protected void set_attitude(QuaternionControl value) { }

	// RVA: 0x1406D28
	public static AttitudeSensor get_current() { }

	// RVA: 0x1406D74
	private static void set_current(AttitudeSensor value) { }

	// RVA: 0x1406DD8
	public override void MakeCurrent() { }

	// RVA: 0x1406E3C
	protected override void OnRemoved() { }

	// RVA: 0x1406EDC
	protected override void FinishSetup() { }

	// RVA: 0x1406F64
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LinearAccelerationSensor
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x170
	private static LinearAccelerationSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1406F6C
	public Vector3Control get_acceleration() { }

	// RVA: 0x1406F74
	protected void set_acceleration(Vector3Control value) { }

	// RVA: 0x1406F84
	public static LinearAccelerationSensor get_current() { }

	// RVA: 0x1406FD0
	private static void set_current(LinearAccelerationSensor value) { }

	// RVA: 0x1407034
	public override void MakeCurrent() { }

	// RVA: 0x1407098
	protected override void OnRemoved() { }

	// RVA: 0x1407138
	protected override void FinishSetup() { }

	// RVA: 0x14071C0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class MagneticFieldSensor
{
	// Fields
	private Vector3Control <magneticField>k__BackingField; // 0x170
	private static MagneticFieldSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x14071C8
	public Vector3Control get_magneticField() { }

	// RVA: 0x14071D0
	protected void set_magneticField(Vector3Control value) { }

	// RVA: 0x14071E0
	public static MagneticFieldSensor get_current() { }

	// RVA: 0x140722C
	private static void set_current(MagneticFieldSensor value) { }

	// RVA: 0x1407290
	public override void MakeCurrent() { }

	// RVA: 0x14072F4
	protected override void OnRemoved() { }

	// RVA: 0x1407394
	protected override void FinishSetup() { }

	// RVA: 0x140741C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LightSensor
{
	// Fields
	private AxisControl <lightLevel>k__BackingField; // 0x170
	private static LightSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1407424
	public AxisControl get_lightLevel() { }

	// RVA: 0x140742C
	protected void set_lightLevel(AxisControl value) { }

	// RVA: 0x140743C
	public static LightSensor get_current() { }

	// RVA: 0x1407488
	private static void set_current(LightSensor value) { }

	// RVA: 0x14074EC
	public override void MakeCurrent() { }

	// RVA: 0x1407550
	protected override void OnRemoved() { }

	// RVA: 0x14075F0
	protected override void FinishSetup() { }

	// RVA: 0x1407678
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PressureSensor
{
	// Fields
	private AxisControl <atmosphericPressure>k__BackingField; // 0x170
	private static PressureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1407680
	public AxisControl get_atmosphericPressure() { }

	// RVA: 0x1407688
	protected void set_atmosphericPressure(AxisControl value) { }

	// RVA: 0x1407698
	public static PressureSensor get_current() { }

	// RVA: 0x14076E4
	private static void set_current(PressureSensor value) { }

	// RVA: 0x1407748
	public override void MakeCurrent() { }

	// RVA: 0x14077AC
	protected override void OnRemoved() { }

	// RVA: 0x140784C
	protected override void FinishSetup() { }

	// RVA: 0x14078D4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class ProximitySensor
{
	// Fields
	private AxisControl <distance>k__BackingField; // 0x170
	private static ProximitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x14078DC
	public AxisControl get_distance() { }

	// RVA: 0x14078E4
	protected void set_distance(AxisControl value) { }

	// RVA: 0x14078F4
	public static ProximitySensor get_current() { }

	// RVA: 0x1407940
	private static void set_current(ProximitySensor value) { }

	// RVA: 0x14079A4
	public override void MakeCurrent() { }

	// RVA: 0x1407A08
	protected override void OnRemoved() { }

	// RVA: 0x1407AA8
	protected override void FinishSetup() { }

	// RVA: 0x1407B30
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class HumiditySensor
{
	// Fields
	private AxisControl <relativeHumidity>k__BackingField; // 0x170
	private static HumiditySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1407B38
	public AxisControl get_relativeHumidity() { }

	// RVA: 0x1407B40
	protected void set_relativeHumidity(AxisControl value) { }

	// RVA: 0x1407B50
	public static HumiditySensor get_current() { }

	// RVA: 0x1407B9C
	private static void set_current(HumiditySensor value) { }

	// RVA: 0x1407C00
	public override void MakeCurrent() { }

	// RVA: 0x1407C64
	protected override void OnRemoved() { }

	// RVA: 0x1407D04
	protected override void FinishSetup() { }

	// RVA: 0x1407D8C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AmbientTemperatureSensor
{
	// Fields
	private AxisControl <ambientTemperature>k__BackingField; // 0x170
	private static AmbientTemperatureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1407D94
	public AxisControl get_ambientTemperature() { }

	// RVA: 0x1407D9C
	protected void set_ambientTemperature(AxisControl value) { }

	// RVA: 0x1407DAC
	public static AmbientTemperatureSensor get_current() { }

	// RVA: 0x1407DF8
	private static void set_current(AmbientTemperatureSensor value) { }

	// RVA: 0x1407E5C
	public override void MakeCurrent() { }

	// RVA: 0x1407EC0
	protected override void OnRemoved() { }

	// RVA: 0x1407F60
	protected override void FinishSetup() { }

	// RVA: 0x1407FE8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class StepCounter
{
	// Fields
	private IntegerControl <stepCounter>k__BackingField; // 0x170
	private static StepCounter <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1407FF0
	public IntegerControl get_stepCounter() { }

	// RVA: 0x1407FF8
	protected void set_stepCounter(IntegerControl value) { }

	// RVA: 0x1408008
	public static StepCounter get_current() { }

	// RVA: 0x1408054
	private static void set_current(StepCounter value) { }

	// RVA: 0x14080B8
	public override void MakeCurrent() { }

	// RVA: 0x140811C
	protected override void OnRemoved() { }

	// RVA: 0x14081BC
	protected override void FinishSetup() { }

	// RVA: 0x1408244
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

	// RVA: 0x140824C
	public TouchControl get_primaryTouch() { }

	// RVA: 0x1408254
	protected void set_primaryTouch(TouchControl value) { }

	// RVA: 0x1408264
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches() { }

	// RVA: 0x1408270
	protected void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value) { }

	// RVA: 0x1408284
	protected TouchControl[] get_touchControlArray() { }

	// RVA: 0x140828C
	protected void set_touchControlArray(TouchControl[] value) { }

	// RVA: 0x140830C
	public static Touchscreen get_current() { }

	// RVA: 0x1408358
	internal static void set_current(Touchscreen value) { }

	// RVA: 0x14083BC
	public override void MakeCurrent() { }

	// RVA: 0x1408420
	protected override void OnRemoved() { }

	// RVA: 0x14084C0
	protected override void FinishSetup() { }

	// RVA: 0x1408960
	protected void OnNextUpdate() { }

	// RVA: 0x1408CB4
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1409460
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x1409464
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1409468
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

	// RVA: 0x140975C
	private void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	// RVA: 0x1409C00
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x1409D30
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x1409388
	private static void TriggerTap(TouchControl control, TouchState state, InputEventPtr eventPtr) { }

	// RVA: 0x1409D3C
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

	// RVA: 0x1409D44
	public IntegerControl get_trackingState() { }

	// RVA: 0x1409D4C
	protected void set_trackingState(IntegerControl value) { }

	// RVA: 0x1409D5C
	public ButtonControl get_isTracked() { }

	// RVA: 0x1409D64
	protected void set_isTracked(ButtonControl value) { }

	// RVA: 0x1409D74
	public Vector3Control get_devicePosition() { }

	// RVA: 0x1409D7C
	protected void set_devicePosition(Vector3Control value) { }

	// RVA: 0x1409D8C
	public QuaternionControl get_deviceRotation() { }

	// RVA: 0x1409D94
	protected void set_deviceRotation(QuaternionControl value) { }

	// RVA: 0x1409DA4
	protected override void FinishSetup() { }

	// RVA: 0x1409F1C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputExtensions
{
	// Methods

	// RVA: 0x1409F24
	public static bool IsInProgress(InputActionPhase phase) { }

	// RVA: 0x1409F34
	public static bool IsEndedOrCanceled(TouchPhase phase) { }

	// RVA: 0x1409748
	public static bool IsActive(TouchPhase phase) { }

	// RVA: 0x1409F44
	public static bool IsModifierKey(Key key) { }

	// RVA: 0x1409F54
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

	// RVA: 0x1416E68
	public int get_count() { }

	// RVA: 0x14163BC
	public void Add(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x1416714
	public void Remove(IInputStateChangeMonitor monitor, Int64 monitorIndex, bool deferRemoval) { }

	// RVA: 0x1416540
	public void Clear() { }

	// RVA: 0x14162AC
	public void CompactArrays() { }

	// RVA: 0x1416EF0
	private void RemoveAt(int i) { }

	// RVA: 0x1416A98
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

	// RVA: 0x1416FAC
	private static void .cctor() { }

	// RVA: 0x1417018
	public void .ctor() { }

	// RVA: 0x1417020
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
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

	// RVA: 0x140E7B0
	public void .ctor(int <>1__state) { }

	// RVA: 0x1417088
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1417204
	private bool MoveNext() { }

	// RVA: 0x14185E4
	private void <>m__Finally1() { }

	// RVA: 0x1418640
	private void <>m__Finally2() { }

	// RVA: 0x141869C
	private void <>m__Finally3() { }

	// RVA: 0x14186F8
	private void <>m__Finally4() { }

	// RVA: 0x1418754
	private void <>m__Finally5() { }

	// RVA: 0x14187B0
	private void <>m__Finally6() { }

	// RVA: 0x141880C
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x1418814
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1418854
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x141885C
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x1418914
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

	// RVA: 0x14031F8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x1409F78
	public TypeTable get_processors() { }

	// RVA: 0x1409F80
	public TypeTable get_interactions() { }

	// RVA: 0x1409F88
	public TypeTable get_composites() { }

	// RVA: 0x1409F90
	public InputMetrics get_metrics() { }

	// RVA: 0x140A130
	public InputSettings get_settings() { }

	// RVA: 0x140A138
	public void set_settings(InputSettings value) { }

	// RVA: 0x140A890
	public InputActionAsset get_actions() { }

	// RVA: 0x140A898
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x140A95C
	public InputUpdateType get_updateMask() { }

	// RVA: 0x140A964
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x140AB00
	public InputUpdateType get_defaultUpdateType() { }

	// RVA: 0x140AB1C
	public float get_pollingFrequency() { }

	// RVA: 0x140AB24
	public void set_pollingFrequency(float value) { }

	// RVA: 0x1401388
	public void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x14016A4
	public void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x140AC50
	public void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x140ACAC
	public void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x140AD08
	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x140AD64
	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x140ADC0
	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x140B104
	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x14013E4
	public void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x1401700
	public void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x140132C
	public void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1401648
	public void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x140B160
	public void add_onBeforeUpdate(Action value) { }

	// RVA: 0x140B2DC
	public void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x140B338
	public void add_onAfterUpdate(Action value) { }

	// RVA: 0x140B394
	public void remove_onAfterUpdate(Action value) { }

	// RVA: 0x140B3F0
	public void add_onSettingsChange(Action value) { }

	// RVA: 0x140B44C
	public void remove_onSettingsChange(Action value) { }

	// RVA: 0x140B4A8
	public void add_onActionsChange(Action value) { }

	// RVA: 0x140B504
	public void remove_onActionsChange(Action value) { }

	// RVA: 0x140B560
	public bool get_isProcessingEvents() { }

	// RVA: 0x140B568
	private bool get_gameIsPlaying() { }

	// RVA: 0x140B570
	private bool get_gameHasFocus() { }

	// RVA: 0x140B5AC
	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	// RVA: 0x140B5D4
	public void RegisterControlLayout(string name, Type type) { }

	// RVA: 0x1404784
	public void RegisterControlLayout(string json, string name, bool isOverride) { }

	// RVA: 0x140C394
	public void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout) { }

	// RVA: 0x140BD24
	private void PerformLayoutPostRegistration(InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout, bool isOverride) { }

	// RVA: 0x30A27C0
	public void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x140C538
	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout) { }

	// RVA: 0x140C8D8
	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	// RVA: 0x140C7F4
	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	// RVA: 0x140C220
	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x140D1CC
	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	// RVA: 0x140CB78
	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x140C9EC
	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	// RVA: 0x140CDD0
	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	// RVA: 0x140E0BC
	public void RemoveControlLayout(string name) { }

	// RVA: 0x140E2FC
	public InputControlLayout TryLoadControlLayout(Type type) { }

	// RVA: 0x1404774
	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	// RVA: 0x140D420
	public InternedString TryFindMatchingControlLayout(InputDeviceDescription deviceDescription, int deviceId) { }

	// RVA: 0x140E544
	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	// RVA: 0x140E5E8
	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	// RVA: 0x140E714
	public System.Collections.Generic.IEnumerable<System.String> ListControlLayouts(string basedOn) { }

	// RVA: -1
	public int GetControls(string path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x140E7E8
	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x1404E6C
	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x14050E0
	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x140E9DC
	private void NotifyUsageChanged(InputDevice device) { }

	// RVA: 0x140EAA0
	public InputDevice AddDevice(Type type, string name) { }

	// RVA: 0x1404D1C
	public InputDevice AddDevice(string layout, string name, InternedString variants) { }

	// RVA: 0x140DF00
	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName, InputDeviceDescription deviceDescription, DeviceFlags deviceFlags, InternedString variants) { }

	// RVA: 0x140D94C
	public void AddDevice(InputDevice device) { }

	// RVA: 0x140F6CC
	public InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x140F714
	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x140F8E4
	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x1404248
	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices) { }

	// RVA: 0x140FB38
	public void FlushDisconnectedDevices() { }

	// RVA: 0x140FB98
	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls, System.Nullable<System.Boolean> issueResetCommand) { }

	// RVA: 0x1410450
	public InputDevice TryGetDevice(string nameOrLayout) { }

	// RVA: 0x1410578
	public InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x141061C
	public InputDevice TryGetDevice(Type layoutType) { }

	// RVA: 0x1403FC4
	public InputDevice TryGetDeviceById(int id) { }

	// RVA: 0x1410680
	public int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x140F26C
	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope) { }

	// RVA: 0x1410834
	private void QueueEvent(InputEvent* eventPtr) { }

	// RVA: 0x14050DC
	public void QueueEvent(InputEventPtr ptr) { }

	// RVA: 0x30A27C0
	public void QueueEvent(TEvent inputEvent) { }

	// RVA: 0x1410910
	public void Update() { }

	// RVA: 0x14109F0
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x1410AA8
	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x1412A70
	internal void Destroy() { }

	// RVA: 0x1410B44
	private void InitializeActions() { }

	// RVA: 0x1410BF8
	internal void InitializeData() { }

	// RVA: 0x141208C
	internal void InstallRuntime(IInputRuntime runtime) { }

	// RVA: 0x141280C
	internal void InstallGlobals() { }

	// RVA: 0x1412BBC
	internal void UninstallGlobals() { }

	// RVA: 0x140EBB0
	private void MakeDeviceNameUnique(InputDevice device) { }

	// RVA: 0x141300C
	private static void ResetControlPathsRecursive(InputControl control) { }

	// RVA: 0x140ED60
	private void AssignUniqueDeviceId(InputDevice device) { }

	// RVA: 0x140A988
	private void ReallocateStateBuffers() { }

	// RVA: 0x14130CC
	private void InitializeDefaultState(InputDevice device) { }

	// RVA: 0x140EF4C
	private void InitializeDeviceState(InputDevice device) { }

	// RVA: 0x1413288
	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x14136C4
	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	// RVA: 0x140B1C4
	private void InstallBeforeUpdateHookIfNecessary() { }

	// RVA: 0x14136C0
	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	// RVA: 0x14138B0
	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	// RVA: 0x14138B4
	private void OnBeforeUpdate(InputUpdateType updateType) { }

	// RVA: 0x140A274
	internal void ApplySettings() { }

	// RVA: 0x140A900
	internal void ApplyActions() { }

	// RVA: -1
	internal Int64 ExecuteGlobalCommand(TCommand command) { }

	// RVA: 0x140AE24
	internal void AddAvailableDevicesThatAreNowRecognized() { }

	// RVA: 0x140F22C
	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	// RVA: 0x1413A80
	internal void OnFocusChanged(bool focus) { }

	// RVA: 0x1413D64
	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	// RVA: 0x1413D80
	private void OnUpdate(InputUpdateType updateType, InputEventBuffer eventBuffer) { }

	// RVA: 0x1415500
	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	// RVA: 0x14156EC
	internal void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	// RVA: 0x1415578
	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	// RVA: 0x14101A0
	internal bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, UInt32 stateOffsetInDevice, UInt32 stateSize, Double internalTime, InputEventPtr eventPtr) { }

	// RVA: 0x1415A98
	private void WriteStateChange(DoubleBuffers buffers, int deviceIndex, InputStateBlock deviceStateBlock, UInt32 stateOffsetInDevice, Void* statePtr, UInt32 stateSizeInBytes, bool flippedBuffers) { }

	// RVA: 0x14159D0
	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	// RVA: 0x1416134
	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x140F9C8
	private void RemoveStateChangeMonitors(InputDevice device) { }

	// RVA: 0x14165B4
	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x1416890
	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1416970
	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x14156F4
	private void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	// RVA: 0x1416BF0
	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	// RVA: 0x1416D1C
	public void FireStateChangeNotifications() { }

	// RVA: 0x1415748
	private bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, UInt32 newStateSizeInBytes, UInt32 newStateOffsetInBytes) { }

	// RVA: 0x1415C7C
	internal void FireStateChangeNotifications(int deviceIndex, Double internalTime, InputEvent* eventPtr) { }

	// RVA: 0x1415234
	private void ProcessStateChangeMonitorTimeouts() { }

	// RVA: 0x1416E70
	public void .ctor() { }

	// RVA: 0x1416E78
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

	// RVA: 0x1419348
	public PrivacyDataUsage get_motionUsage() { }

	// RVA: 0x1419350
	public void set_motionUsage(PrivacyDataUsage value) { }

	// RVA: 0x14192D0
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

	// RVA: 0x1418918
	public UpdateMode get_updateMode() { }

	// RVA: 0x1418920
	public void set_updateMode(UpdateMode value) { }

	// RVA: 0x1418A50
	public bool get_compensateForScreenOrientation() { }

	// RVA: 0x1418A58
	public void set_compensateForScreenOrientation(bool value) { }

	// RVA: 0x1418A70
	public bool get_filterNoiseOnCurrent() { }

	// RVA: 0x1418A78
	public void set_filterNoiseOnCurrent(bool value) { }

	// RVA: 0x1418A7C
	public float get_defaultDeadzoneMin() { }

	// RVA: 0x1418A84
	public void set_defaultDeadzoneMin(float value) { }

	// RVA: 0x1418A9C
	public float get_defaultDeadzoneMax() { }

	// RVA: 0x1418AA4
	public void set_defaultDeadzoneMax(float value) { }

	// RVA: 0x1418ABC
	public float get_defaultButtonPressPoint() { }

	// RVA: 0x1418AC4
	public void set_defaultButtonPressPoint(float value) { }

	// RVA: 0x1418B00
	public float get_buttonReleaseThreshold() { }

	// RVA: 0x1418B08
	public void set_buttonReleaseThreshold(float value) { }

	// RVA: 0x1418B20
	public float get_defaultTapTime() { }

	// RVA: 0x1418B28
	public void set_defaultTapTime(float value) { }

	// RVA: 0x1418B40
	public float get_defaultSlowTapTime() { }

	// RVA: 0x1418B48
	public void set_defaultSlowTapTime(float value) { }

	// RVA: 0x1418B60
	public float get_defaultHoldTime() { }

	// RVA: 0x1418B68
	public void set_defaultHoldTime(float value) { }

	// RVA: 0x1418B80
	public float get_tapRadius() { }

	// RVA: 0x1418B88
	public void set_tapRadius(float value) { }

	// RVA: 0x1418BA0
	public float get_multiTapDelayTime() { }

	// RVA: 0x1418BA8
	public void set_multiTapDelayTime(float value) { }

	// RVA: 0x1418BC0
	public BackgroundBehavior get_backgroundBehavior() { }

	// RVA: 0x1418BC8
	public void set_backgroundBehavior(BackgroundBehavior value) { }

	// RVA: 0x1418BE0
	public EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	// RVA: 0x1418BE8
	public void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	// RVA: 0x1418C00
	public InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	// RVA: 0x1418C08
	public void set_inputActionPropertyDrawerMode(InputActionPropertyDrawerMode value) { }

	// RVA: 0x1418C20
	public int get_maxEventBytesPerUpdate() { }

	// RVA: 0x1418C28
	public void set_maxEventBytesPerUpdate(int value) { }

	// RVA: 0x1418C40
	public int get_maxQueuedEventsPerUpdate() { }

	// RVA: 0x1418C48
	public void set_maxQueuedEventsPerUpdate(int value) { }

	// RVA: 0x1418C60
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> get_supportedDevices() { }

	// RVA: 0x1418CCC
	public void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> value) { }

	// RVA: 0x1418E54
	public bool get_disableRedundantEventsMerging() { }

	// RVA: 0x1418E5C
	public void set_disableRedundantEventsMerging(bool value) { }

	// RVA: 0x1418E74
	public bool get_shortcutKeysConsumeInput() { }

	// RVA: 0x1418E7C
	public void set_shortcutKeysConsumeInput(bool value) { }

	// RVA: 0x1418E94
	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

	// RVA: 0x1419134
	internal bool IsFeatureEnabled(string featureName) { }

	// RVA: 0x1418938
	internal void OnChange() { }

	// RVA: 0x14191C0
	public iOSSettings get_iOS() { }

	// RVA: 0x14191C8
	public void .ctor() { }

}

// Namespace: 
public struct PlayerActions
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x1419EE8
	public void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x1419EF0
	public InputAction get_Move() { }

	// RVA: 0x1419F10
	public InputAction get_Look() { }

	// RVA: 0x1419F30
	public InputAction get_Fire() { }

	// RVA: 0x1419F50
	public InputActionMap Get() { }

	// RVA: 0x1419F70
	public void Enable() { }

	// RVA: 0x1419F98
	public void Disable() { }

	// RVA: 0x1419FC0
	public bool get_enabled() { }

	// RVA: 0x1419FE8
	public static InputActionMap op_Implicit(PlayerActions set) { }

	// RVA: 0x141A004
	public void SetCallbacks(IPlayerActions instance) { }

}

// Namespace: 
public struct UIActions
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x141AC9C
	public void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x141ACA4
	public InputAction get_Navigate() { }

	// RVA: 0x141ACC4
	public InputAction get_Submit() { }

	// RVA: 0x141ACE4
	public InputAction get_Cancel() { }

	// RVA: 0x141AD04
	public InputAction get_Point() { }

	// RVA: 0x141AD24
	public InputAction get_Click() { }

	// RVA: 0x141AD44
	public InputAction get_ScrollWheel() { }

	// RVA: 0x141AD64
	public InputAction get_MiddleClick() { }

	// RVA: 0x141AD84
	public InputAction get_RightClick() { }

	// RVA: 0x141ADA4
	public InputAction get_TrackedDevicePosition() { }

	// RVA: 0x141ADC4
	public InputAction get_TrackedDeviceOrientation() { }

	// RVA: 0x141ADE4
	public InputActionMap Get() { }

	// RVA: 0x141AE04
	public void Enable() { }

	// RVA: 0x141AE2C
	public void Disable() { }

	// RVA: 0x141AE54
	public bool get_enabled() { }

	// RVA: 0x141AE7C
	public static InputActionMap op_Implicit(UIActions set) { }

	// RVA: 0x141AE98
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

	// RVA: 0x1419358
	public InputActionAsset get_asset() { }

	// RVA: 0x1419360
	public void .ctor() { }

	// RVA: 0x14197A0
	public void Dispose() { }

	// RVA: 0x1419830
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x1419870
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x14198B8
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x1419904
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x1419944
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x1419964
	public bool Contains(InputAction action) { }

	// RVA: 0x1419984
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x14199A4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14199C4
	public void Enable() { }

	// RVA: 0x14199E4
	public void Disable() { }

	// RVA: 0x1419A04
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1419A24
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1419A44
	public int FindBinding(InputBinding bindingMask, InputAction action) { }

	// RVA: 0x1419A94
	public PlayerActions get_Player() { }

	// RVA: 0x1419AC0
	public UIActions get_UI() { }

	// RVA: 0x1419AEC
	public InputControlScheme get_KeyboardMouseScheme() { }

	// RVA: 0x1419BB8
	public InputControlScheme get_GamepadScheme() { }

	// RVA: 0x1419C84
	public InputControlScheme get_TouchScheme() { }

	// RVA: 0x1419D50
	public InputControlScheme get_JoystickScheme() { }

	// RVA: 0x1419E1C
	public InputControlScheme get_XRScheme() { }

}

// Namespace: UnityEngine.InputSystem
public class InputValue
{
	// Fields
	internal System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext> m_Context; // 0x10

	// Methods

	// RVA: 0x141D768
	public object Get() { }

	// RVA: 0x315B3A8
	public TValue Get() { }

	// RVA: 0x141D7E0
	public bool get_isPressed() { }

	// RVA: 0x141D870
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

	// RVA: 0x142609C
	public string get_actionId() { }

	// RVA: 0x14260A4
	public string get_actionName() { }

	// RVA: 0x14260AC
	public void .ctor() { }

	// RVA: 0x1426100
	public void .ctor(InputAction action) { }

	// RVA: 0x14262E4
	public void .ctor(Guid actionGUID, string name) { }

}

// Namespace: 
[Serializable]
public class DeviceLostEvent
{
	// Methods

	// RVA: 0x141F7A8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DeviceRegainedEvent
{
	// Methods

	// RVA: 0x141F8BC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ControlsChangedEvent
{
	// Methods

	// RVA: 0x141F9D0
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

	// RVA: 0x141D878
	public bool get_inputIsActive() { }

	// RVA: 0x141D880
	public bool get_active() { }

	// RVA: 0x141D888
	public int get_playerIndex() { }

	// RVA: 0x141D890
	public int get_splitScreenIndex() { }

	// RVA: 0x141D898
	public InputActionAsset get_actions() { }

	// RVA: 0x141DE90
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x141EEE4
	public string get_currentControlScheme() { }

	// RVA: 0x141F240
	public string get_defaultControlScheme() { }

	// RVA: 0x141F248
	public void set_defaultControlScheme(string value) { }

	// RVA: 0x141F250
	public bool get_neverAutoSwitchControlSchemes() { }

	// RVA: 0x141F258
	public void set_neverAutoSwitchControlSchemes(bool value) { }

	// RVA: 0x141F510
	public InputActionMap get_currentActionMap() { }

	// RVA: 0x141F518
	public void set_currentActionMap(InputActionMap value) { }

	// RVA: 0x141F590
	public string get_defaultActionMap() { }

	// RVA: 0x141F598
	public void set_defaultActionMap(string value) { }

	// RVA: 0x141F5A0
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x141F5A8
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x141F604
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents() { }

	// RVA: 0x141F658
	public void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value) { }

	// RVA: 0x141F6E8
	public DeviceLostEvent get_deviceLostEvent() { }

	// RVA: 0x141F7FC
	public DeviceRegainedEvent get_deviceRegainedEvent() { }

	// RVA: 0x141F910
	public ControlsChangedEvent get_controlsChangedEvent() { }

	// RVA: 0x141FA24
	public void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x141FACC
	public void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x141FB74
	public void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x141FC1C
	public void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x141FCC4
	public void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x141FD6C
	public void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x141FE14
	public void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x141FEBC
	public void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x141FF64
	public Camera get_camera() { }

	// RVA: 0x141FF6C
	public void set_camera(Camera value) { }

	// RVA: 0x141FF74
	public InputSystemUIInputModule get_uiInputModule() { }

	// RVA: 0x141FF7C
	public void set_uiInputModule(InputSystemUIInputModule value) { }

	// RVA: 0x14203F0
	public InputUser get_user() { }

	// RVA: 0x14203F8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x1420564
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x1420704
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all() { }

	// RVA: 0x1420798
	public static bool get_isSinglePlayer() { }

	// RVA: 0x315B3A8
	public TDevice GetDevice() { }

	// RVA: 0x141EE14
	public void ActivateInput() { }

	// RVA: 0x1420AF4
	public void DeactivateInput() { }

	// RVA: 0x1420B24
	public void PassivateInput() { }

	// RVA: 0x1420B54
	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	// RVA: 0x1421240
	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	// RVA: 0x1420904
	public void SwitchCurrentActionMap(string mapNameOrId) { }

	// RVA: 0x14213E0
	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	// RVA: 0x14214F4
	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	// RVA: 0x1421710
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice pairWithDevice) { }

	// RVA: 0x1421B8C
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice[] pairWithDevices) { }

	// RVA: 0x14218A0
	private static PlayerInput DoInstantiate(GameObject prefab) { }

	// RVA: 0x141D8F8
	private void InitializeActions() { }

	// RVA: 0x141DFEC
	private void UninitializeActions() { }

	// RVA: 0x1421D70
	private void InstallOnActionTriggeredHook() { }

	// RVA: 0x1422344
	private void UninstallOnActionTriggeredHook() { }

	// RVA: 0x14224C4
	private void OnActionTriggered(CallbackContext context) { }

	// RVA: 0x1421F64
	private void CacheMessageNames() { }

	// RVA: 0x141E1E0
	private void ClearCaches() { }

	// RVA: 0x141E1E4
	private void AssignUserAndDevices() { }

	// RVA: 0x1422F70
	private bool HaveBindingForDevice(InputDevice device) { }

	// RVA: 0x1423430
	private void UnassignUserAndDevices() { }

	// RVA: 0x1422B90
	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	// RVA: 0x14239CC
	private void AssignPlayerIndex() { }

	// RVA: 0x1423C20
	private void OnEnable() { }

	// RVA: 0x141F318
	private void StartListeningForUnpairedDeviceActivity() { }

	// RVA: 0x141F494
	private void StopListeningForUnpairedDeviceActivity() { }

	// RVA: 0x14241E4
	private void StartListeningForDeviceChanges() { }

	// RVA: 0x1424A00
	private void StopListeningForDeviceChanges() { }

	// RVA: 0x1424A70
	private void OnDisable() { }

	// RVA: 0x1424FD4
	public void DebugLogAction(CallbackContext context) { }

	// RVA: 0x142504C
	private void HandleDeviceLost() { }

	// RVA: 0x1425174
	private void HandleDeviceRegained() { }

	// RVA: 0x14242F0
	private void HandleControlsChanged() { }

	// RVA: 0x142529C
	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	// RVA: 0x1425428
	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	// RVA: 0x14255F0
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1425E28
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1420DB0
	private void SwitchControlSchemeInternal(InputControlScheme controlScheme, InputDevice[] devices) { }

	// RVA: 0x1426038
	public void .ctor() { }

	// RVA: 0x142604C
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class PlayerJoinedEvent
{
	// Methods

	// RVA: 0x14272C0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class PlayerLeftEvent
{
	// Methods

	// RVA: 0x14273D4
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

	// RVA: 0x1426378
	public bool get_splitScreen() { }

	// RVA: 0x1426380
	public void set_splitScreen(bool value) { }

	// RVA: 0x1426CC0
	public bool get_maintainAspectRatioInSplitScreen() { }

	// RVA: 0x1426CC8
	public int get_fixedNumberOfSplitScreens() { }

	// RVA: 0x1426CD0
	public Rect get_splitScreenArea() { }

	// RVA: 0x1426CDC
	public int get_playerCount() { }

	// RVA: 0x1426D58
	public int get_maxPlayerCount() { }

	// RVA: 0x1426D60
	public bool get_joiningEnabled() { }

	// RVA: 0x1426D68
	public PlayerJoinBehavior get_joinBehavior() { }

	// RVA: 0x1426D70
	public void set_joinBehavior(PlayerJoinBehavior value) { }

	// RVA: 0x1427104
	public InputActionProperty get_joinAction() { }

	// RVA: 0x1427118
	public void set_joinAction(InputActionProperty value) { }

	// RVA: 0x14271F0
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x14271F8
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x1427200
	public PlayerJoinedEvent get_playerJoinedEvent() { }

	// RVA: 0x1427314
	public PlayerLeftEvent get_playerLeftEvent() { }

	// RVA: 0x1427428
	public void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x14274D0
	public void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x1427578
	public void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x1427620
	public void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x14276C8
	public GameObject get_playerPrefab() { }

	// RVA: 0x14276D0
	public void set_playerPrefab(GameObject value) { }

	// RVA: 0x14276D8
	public static PlayerInputManager get_instance() { }

	// RVA: 0x1427724
	private static void set_instance(PlayerInputManager value) { }

	// RVA: 0x1426EB8
	public void EnableJoining() { }

	// RVA: 0x1426DC4
	public void DisableJoining() { }

	// RVA: 0x142778C
	internal void JoinPlayerFromUI() { }

	// RVA: 0x1427B10
	public void JoinPlayerFromAction(CallbackContext context) { }

	// RVA: 0x1427CA4
	public void JoinPlayerFromActionIfNotAlreadyJoined(CallbackContext context) { }

	// RVA: 0x1427BD4
	public PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice pairWithDevice) { }

	// RVA: 0x1427E08
	public PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice[] pairWithDevices) { }

	// RVA: 0x1427ED8
	internal static string[] get_messages() { }

	// RVA: 0x14277E4
	private bool CheckIfPlayerCanJoin(int playerIndex) { }

	// RVA: 0x1427F98
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1428540
	private void OnEnable() { }

	// RVA: 0x1428970
	private void OnDisable() { }

	// RVA: 0x1426650
	private void UpdateSplitScreen() { }

	// RVA: 0x14280B8
	private bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	// RVA: 0x1427788
	private void ValidateInputActionAsset() { }

	// RVA: 0x1424418
	internal void NotifyPlayerJoined(PlayerInput player) { }

	// RVA: 0x1424E88
	internal void NotifyPlayerLeft(PlayerInput player) { }

	// RVA: 0x1428A88
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

	// RVA: 0x1428AB0
	public void SetLength(int newLength) { }

	// RVA: 0x1428B48
	public void SetBit(int bitIndex) { }

	// RVA: 0x1428C08
	public bool TestBit(int bitIndex) { }

	// RVA: 0x1428C8C
	public void ClearBit(int bitIndex) { }

	// RVA: 0x1428B30
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

	// RVA: 0x1428D4C
	public TrackingType get_trackingType() { }

	// RVA: 0x1428D54
	public void set_trackingType(TrackingType value) { }

	// RVA: 0x1428D5C
	public UpdateType get_updateType() { }

	// RVA: 0x1428D64
	public void set_updateType(UpdateType value) { }

	// RVA: 0x1428D6C
	public bool get_ignoreTrackingState() { }

	// RVA: 0x1428D74
	public void set_ignoreTrackingState(bool value) { }

	// RVA: 0x1428D7C
	public InputActionProperty get_positionInput() { }

	// RVA: 0x1428D90
	public void set_positionInput(InputActionProperty value) { }

	// RVA: 0x1429194
	public InputActionProperty get_rotationInput() { }

	// RVA: 0x14291A8
	public void set_rotationInput(InputActionProperty value) { }

	// RVA: 0x14295AC
	public InputActionProperty get_trackingStateInput() { }

	// RVA: 0x14295C0
	public void set_trackingStateInput(InputActionProperty value) { }

	// RVA: 0x14299C4
	private void BindActions() { }

	// RVA: 0x14299F0
	private void UnbindActions() { }

	// RVA: 0x1428FE8
	private void BindPosition() { }

	// RVA: 0x1429400
	private void BindRotation() { }

	// RVA: 0x1429818
	private void BindTrackingState() { }

	// RVA: 0x1428E8C
	private void UnbindPosition() { }

	// RVA: 0x14292A4
	private void UnbindRotation() { }

	// RVA: 0x14296BC
	private void UnbindTrackingState() { }

	// RVA: 0x1429A1C
	private void OnPositionPerformed(CallbackContext context) { }

	// RVA: 0x1429A94
	private void OnPositionCanceled(CallbackContext context) { }

	// RVA: 0x1429AF0
	private void OnRotationPerformed(CallbackContext context) { }

	// RVA: 0x1429B60
	private void OnRotationCanceled(CallbackContext context) { }

	// RVA: 0x1429BB4
	private void OnTrackingStatePerformed(CallbackContext context) { }

	// RVA: 0x1429C24
	private void OnTrackingStateCanceled(CallbackContext context) { }

	// RVA: 0x1429C2C
	protected void Reset() { }

	// RVA: 0x1429E30
	protected virtual void Awake() { }

	// RVA: 0x1429E34
	protected void OnEnable() { }

	// RVA: 0x1429F08
	protected void OnDisable() { }

	// RVA: 0x1429FD0
	protected virtual void OnDestroy() { }

	// RVA: 0x1429FD4
	protected void UpdateCallback() { }

	// RVA: 0x142A128
	private void ReadTrackingState() { }

	// RVA: 0x142A270
	protected virtual void OnUpdate() { }

	// RVA: 0x142A28C
	protected virtual void OnBeforeRender() { }

	// RVA: 0x142A2AC
	protected virtual void PerformUpdate() { }

	// RVA: 0x142A2C8
	protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	// RVA: 0x142A44C
	private bool HasStereoCamera(Camera cameraComponent) { }

	// RVA: 0x142A4D0
	public InputAction get_positionAction() { }

	// RVA: 0x142A4DC
	public void set_positionAction(InputAction value) { }

	// RVA: 0x142A530
	public InputAction get_rotationAction() { }

	// RVA: 0x142A53C
	public void set_rotationAction(InputAction value) { }

	// RVA: 0x142A590
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x142A594
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x142A670
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

	// RVA: 0x142A71C
	public ButtonControl get_menu() { }

	// RVA: 0x142A724
	protected void set_menu(ButtonControl value) { }

	// RVA: 0x142A734
	public ButtonControl get_view() { }

	// RVA: 0x142A73C
	protected void set_view(ButtonControl value) { }

	// RVA: 0x142A74C
	public DeviceSubType get_subType() { }

	// RVA: 0x142A894
	public DeviceFlags get_flags() { }

	// RVA: 0x142A934
	protected override void FinishSetup() { }

	// RVA: 0x142A7EC
	private void ParseCapabilities() { }

	// RVA: 0x142A974
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.XInput
internal static class XInputSupport
{
	// Methods

	// RVA: 0x142A97C
	public static void Initialize() { }

}

// Namespace: 
public struct ControlSchemeChangeSyntax
{
	// Fields
	internal int m_UserIndex; // 0x10

	// Methods

	// RVA: 0x1423910
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

	// RVA: 0x1430294
	public int Compare(InputDevice x, InputDevice y) { }

	// RVA: 0x14308D8
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

	// RVA: 0x14308E4
	private static void .cctor() { }

	// RVA: 0x1430950
	public void .ctor() { }

	// RVA: 0x1430958
	internal void <SaveAndResetState>b__86_0(GlobalState state) { }

	// RVA: 0x14309C8
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

	// RVA: 0x141F108
	public bool get_valid() { }

	// RVA: 0x142A9F0
	public int get_index() { }

	// RVA: 0x142ABF8
	public UInt32 get_id() { }

	// RVA: 0x142AC00
	public System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle() { }

	// RVA: 0x142AC94
	public string get_platformUserAccountName() { }

	// RVA: 0x142AD18
	public string get_platformUserAccountId() { }

	// RVA: 0x14204AC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices() { }

	// RVA: 0x142AD9C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices() { }

	// RVA: 0x142AE54
	public IInputActionCollection get_actions() { }

	// RVA: 0x141F1B0
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme() { }

	// RVA: 0x142AED8
	public MatchResult get_controlSchemeMatch() { }

	// RVA: 0x142067C
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x142AF7C
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all() { }

	// RVA: 0x142412C
	public static void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1424DD0
	public static void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1424564
	public static void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1424848
	public static void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1424640
	public static void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x1424948
	public static void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x14246F8
	public static int get_listenForUnpairedDeviceActivity() { }

	// RVA: 0x1424744
	public static void set_listenForUnpairedDeviceActivity(int value) { }

	// RVA: 0x142B1FC
	public override string ToString() { }

	// RVA: 0x14230B8
	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	// RVA: 0x142393C
	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	// RVA: 0x142BA88
	private bool TryFindControlScheme(string schemeName, InputControlScheme scheme) { }

	// RVA: 0x1421320
	internal void FindControlScheme(string schemeName, InputControlScheme scheme) { }

	// RVA: 0x142365C
	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	// RVA: 0x142B6A0
	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	// RVA: 0x1425F5C
	public void UnpairDevice(InputDevice device) { }

	// RVA: 0x14226E8
	public void UnpairDevices() { }

	// RVA: 0x142CA94
	private static void RemoveLostDevicesForUser(int userIndex) { }

	// RVA: 0x14235BC
	public void UnpairDevicesAndRemoveUser() { }

	// RVA: 0x1422EF0
	public static UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() { }

	// RVA: 0x142D4B4
	public static int GetUnpairedInputDevices(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>& list) { }

	// RVA: 0x142D6C0
	public static System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(InputDevice device) { }

	// RVA: 0x142D8DC
	public static System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	// RVA: 0x14235EC
	public static InputUser CreateUserWithoutPairedDevices() { }

	// RVA: 0x142295C
	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user, InputUserPairingOptions options) { }

	// RVA: 0x142DF00
	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	// RVA: 0x142ECC8
	public bool Equals(InputUser other) { }

	// RVA: 0x142ECD8
	public override bool Equals(object obj) { }

	// RVA: 0x142ED68
	public override int GetHashCode() { }

	// RVA: 0x142541C
	public static bool op_Equality(InputUser left, InputUser right) { }

	// RVA: 0x142DEF4
	public static bool op_Inequality(InputUser left, InputUser right) { }

	// RVA: 0x142DDF8
	private static int AddUser() { }

	// RVA: 0x142D128
	private static void RemoveUser(int userIndex) { }

	// RVA: 0x142BD20
	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	// RVA: 0x142AB58
	private static int TryFindUserIndex(UInt32 userId) { }

	// RVA: 0x142DB8C
	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	// RVA: 0x142D7D8
	private static int TryFindUserIndex(InputDevice device) { }

	// RVA: 0x142E048
	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice, bool dontUpdateControlScheme) { }

	// RVA: 0x142CBD8
	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice) { }

	// RVA: 0x142C034
	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing) { }

	// RVA: 0x142E4C8
	private static Int64 UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

	// RVA: 0x142EED8
	private static Int64 QueryPairedPlatformUserAccount(InputDevice device, System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>& platformAccountHandle, string platformAccountName, string platformAccountId) { }

	// RVA: 0x142EACC
	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	// RVA: 0x142F200
	private static void OnActionChange(object obj, InputActionChange change) { }

	// RVA: 0x142F328
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x142F808
	private static int FindLostDevice(InputDevice device, int startIndex) { }

	// RVA: 0x142F8D4
	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x142FDF4
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x142B564
	private static void HookIntoActionChange() { }

	// RVA: 0x142EE00
	private static void UnhookFromActionChange() { }

	// RVA: 0x142EB94
	private static void HookIntoDeviceChange() { }

	// RVA: 0x142ED70
	private static void UnhookFromDeviceChange() { }

	// RVA: 0x142B008
	private static void HookIntoEvents() { }

	// RVA: 0x142B150
	private static void UnhookFromDeviceStateChange() { }

	// RVA: 0x1430044
	private static void DisposeAndResetGlobalState() { }

	// RVA: 0x1430130
	internal static void ResetGlobals() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUserAccountHandle
{
	// Fields
	private string m_ApiName; // 0x10
	private UInt64 m_Handle; // 0x18

	// Methods

	// RVA: 0x1430AB4
	public string get_apiName() { }

	// RVA: 0x1430ABC
	public UInt64 get_handle() { }

	// RVA: 0x142F168
	public void .ctor(string apiName, UInt64 handle) { }

	// RVA: 0x1430AC4
	public override string ToString() { }

	// RVA: 0x1430BA0
	public bool Equals(InputUserAccountHandle other) { }

	// RVA: 0x1430C70
	public override bool Equals(object obj) { }

	// RVA: 0x142DAB0
	public static bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x142F098
	public static bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x1430DA4
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

	// RVA: 0x1430E04
	public string get_customBindings() { }

	// RVA: 0x1430E0C
	public void set_customBindings(string value) { }

	// RVA: 0x1430E14
	public bool get_invertMouseX() { }

	// RVA: 0x1430E1C
	public void set_invertMouseX(bool value) { }

	// RVA: 0x1430E24
	public bool get_invertMouseY() { }

	// RVA: 0x1430E2C
	public void set_invertMouseY(bool value) { }

	// RVA: 0x1430E34
	public System.Nullable<System.Single> get_mouseSmoothing() { }

	// RVA: 0x1430E3C
	public void set_mouseSmoothing(System.Nullable<System.Single> value) { }

	// RVA: 0x1430E44
	public System.Nullable<System.Single> get_mouseSensitivity() { }

	// RVA: 0x1430E4C
	public void set_mouseSensitivity(System.Nullable<System.Single> value) { }

	// RVA: 0x1430E54
	public bool get_invertStickX() { }

	// RVA: 0x1430E5C
	public void set_invertStickX(bool value) { }

	// RVA: 0x1430E64
	public bool get_invertStickY() { }

	// RVA: 0x1430E6C
	public void set_invertStickY(bool value) { }

	// RVA: 0x1430E74
	public bool get_swapSticks() { }

	// RVA: 0x1430E7C
	public void set_swapSticks(bool value) { }

	// RVA: 0x1430E84
	public bool get_swapBumpers() { }

	// RVA: 0x1430E8C
	public void set_swapBumpers(bool value) { }

	// RVA: 0x1430E94
	public bool get_swapTriggers() { }

	// RVA: 0x1430E9C
	public void set_swapTriggers(bool value) { }

	// RVA: 0x1430EA4
	public bool get_swapDpadAndLeftStick() { }

	// RVA: 0x1430EAC
	public void set_swapDpadAndLeftStick(bool value) { }

	// RVA: 0x1430EB4
	public float get_vibrationStrength() { }

	// RVA: 0x1430EBC
	public void set_vibrationStrength(float value) { }

	// RVA: 0x1430EC4
	public virtual void Apply(IInputActionCollection actions) { }

	// RVA: 0x1430EC8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class BaseInputOverride
{
	// Fields
	private readonly string <compositionString>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1430ED0
	public override string get_compositionString() { }

	// RVA: 0x1430ED8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class ExtendedAxisEventData
{
	// Methods

	// RVA: 0x1430EE0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1430EE8
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

	// RVA: 0x1430FAC
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1430FB4
	public InputControl get_control() { }

	// RVA: 0x1430FBC
	public void set_control(InputControl value) { }

	// RVA: 0x1430FCC
	public InputDevice get_device() { }

	// RVA: 0x1430FD4
	public void set_device(InputDevice value) { }

	// RVA: 0x1430FE4
	public int get_touchId() { }

	// RVA: 0x1430FEC
	public void set_touchId(int value) { }

	// RVA: 0x1430FF4
	public UIPointerType get_pointerType() { }

	// RVA: 0x1430FFC
	public void set_pointerType(UIPointerType value) { }

	// RVA: 0x1431004
	public int get_uiToolkitPointerId() { }

	// RVA: 0x143100C
	public void set_uiToolkitPointerId(int value) { }

	// RVA: 0x1431014
	public Vector3 get_trackedDevicePosition() { }

	// RVA: 0x1431024
	public void set_trackedDevicePosition(Vector3 value) { }

	// RVA: 0x1431034
	public Quaternion get_trackedDeviceOrientation() { }

	// RVA: 0x1431048
	public void set_trackedDeviceOrientation(Quaternion value) { }

	// RVA: 0x143105C
	public override string ToString() { }

	// RVA: 0x14315CC
	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	// RVA: 0x14315D4
	internal static int TouchIdFromPointerId(int pointerId) { }

	// RVA: 0x14315DC
	internal void ReadDeviceState() { }

	// RVA: 0x1431910
	private static int GetPenPointerId(Pen pen) { }

	// RVA: 0x1431B50
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

	// RVA: 0x1431C48
	public bool get_deselectOnBackgroundClick() { }

	// RVA: 0x1431C50
	public void set_deselectOnBackgroundClick(bool value) { }

	// RVA: 0x1431C58
	public UIPointerBehavior get_pointerBehavior() { }

	// RVA: 0x1431C60
	public void set_pointerBehavior(UIPointerBehavior value) { }

	// RVA: 0x1431C68
	public CursorLockBehavior get_cursorLockBehavior() { }

	// RVA: 0x1431C70
	public void set_cursorLockBehavior(CursorLockBehavior value) { }

	// RVA: 0x1431C78
	internal GameObject get_localMultiPlayerRoot() { }

	// RVA: 0x1431C80
	internal void set_localMultiPlayerRoot(GameObject value) { }

	// RVA: 0x1431C90
	public override void ActivateModule() { }

	// RVA: 0x1431D6C
	public override bool IsPointerOverGameObject(int pointerOrTouchId) { }

	// RVA: 0x1432070
	public RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	// RVA: 0x1432148
	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	// RVA: 0x1432428
	private void ProcessPointer(PointerModel state) { }

	// RVA: 0x1433888
	private bool PointerShouldIgnoreTransform(Transform t) { }

	// RVA: 0x143289C
	private void ProcessPointerMovement(PointerModel pointer, ExtendedPointerEventData eventData) { }

	// RVA: 0x14339A4
	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	// RVA: 0x14328F8
	private void ProcessPointerButton(ButtonState button, PointerEventData eventData) { }

	// RVA: 0x1433304
	private void ProcessPointerButtonDrag(ButtonState button, ExtendedPointerEventData eventData) { }

	// RVA: 0x14336D4
	private static void ProcessPointerScroll(PointerModel pointer, PointerEventData eventData) { }

	// RVA: 0x1434188
	internal void ProcessNavigation(NavigationModel navigationState) { }

	// RVA: 0x1434854
	private bool IsMoveAllowed(AxisEventData eventData) { }

	// RVA: 0x1434B90
	public float get_moveRepeatDelay() { }

	// RVA: 0x1434B98
	public void set_moveRepeatDelay(float value) { }

	// RVA: 0x1434BA0
	public float get_moveRepeatRate() { }

	// RVA: 0x1434BA8
	public void set_moveRepeatRate(float value) { }

	// RVA: 0x1434BB0
	private bool get_explictlyIgnoreFocus() { }

	// RVA: 0x1434C34
	private bool get_shouldIgnoreFocus() { }

	// RVA: 0x1434D94
	public float get_repeatRate() { }

	// RVA: 0x1434D9C
	public void set_repeatRate(float value) { }

	// RVA: 0x1434DA4
	public float get_repeatDelay() { }

	// RVA: 0x1434DAC
	public void set_repeatDelay(float value) { }

	// RVA: 0x1434DB4
	public Transform get_xrTrackingOrigin() { }

	// RVA: 0x1434DBC
	public void set_xrTrackingOrigin(Transform value) { }

	// RVA: 0x1434DC4
	public float get_trackedDeviceDragThresholdMultiplier() { }

	// RVA: 0x1434DCC
	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	// RVA: 0x1434DD4
	private void SwapAction(InputActionReference property, InputActionReference newValue, bool actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback) { }

	// RVA: 0x1435440
	public InputActionReference get_point() { }

	// RVA: 0x1435448
	public void set_point(InputActionReference value) { }

	// RVA: 0x143545C
	public InputActionReference get_scrollWheel() { }

	// RVA: 0x1435464
	public void set_scrollWheel(InputActionReference value) { }

	// RVA: 0x1435478
	public InputActionReference get_leftClick() { }

	// RVA: 0x1435480
	public void set_leftClick(InputActionReference value) { }

	// RVA: 0x1435494
	public InputActionReference get_middleClick() { }

	// RVA: 0x143549C
	public void set_middleClick(InputActionReference value) { }

	// RVA: 0x14354B0
	public InputActionReference get_rightClick() { }

	// RVA: 0x14354B8
	public void set_rightClick(InputActionReference value) { }

	// RVA: 0x14354CC
	public InputActionReference get_move() { }

	// RVA: 0x14354D4
	public void set_move(InputActionReference value) { }

	// RVA: 0x14354E8
	public InputActionReference get_submit() { }

	// RVA: 0x14354F0
	public void set_submit(InputActionReference value) { }

	// RVA: 0x1435504
	public InputActionReference get_cancel() { }

	// RVA: 0x143550C
	public void set_cancel(InputActionReference value) { }

	// RVA: 0x1435520
	public InputActionReference get_trackedDeviceOrientation() { }

	// RVA: 0x1435528
	public void set_trackedDeviceOrientation(InputActionReference value) { }

	// RVA: 0x143553C
	public InputActionReference get_trackedDevicePosition() { }

	// RVA: 0x1435544
	public void set_trackedDevicePosition(InputActionReference value) { }

	// RVA: 0x1435558
	public void AssignDefaultActions() { }

	// RVA: 0x143594C
	public void UnassignActions() { }

	// RVA: 0x1435B50
	public InputActionReference get_trackedDeviceSelect() { }

	// RVA: 0x1435B90
	public void set_trackedDeviceSelect(InputActionReference value) { }

	// RVA: 0x1435BD0
	protected override void Awake() { }

	// RVA: 0x1435BFC
	protected override void OnDestroy() { }

	// RVA: 0x1435C50
	protected override void OnEnable() { }

	// RVA: 0x14363B4
	protected override void OnDisable() { }

	// RVA: 0x1435FA0
	private void ResetPointers() { }

	// RVA: 0x1435D88
	private bool HasNoActions() { }

	// RVA: 0x143634C
	private void EnableAllActions() { }

	// RVA: 0x143647C
	private void DisableAllActions() { }

	// RVA: 0x14352BC
	private void EnableInputAction(InputActionReference inputActionReference) { }

	// RVA: 0x143510C
	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling) { }

	// RVA: 0x1431F2C
	private int GetPointerStateIndexFor(int pointerOrTouchId) { }

	// RVA: 0x1436620
	private PointerModel GetPointerStateForIndex(int index) { }

	// RVA: 0x143666C
	private int GetDisplayIndexFor(InputControl control) { }

	// RVA: 0x1436734
	private int GetPointerStateIndexFor(CallbackContext context) { }

	// RVA: 0x143684C
	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists) { }

	// RVA: 0x1437208
	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl) { }

	// RVA: 0x1436530
	private void SendPointerExitEventsAndRemovePointer(int index) { }

	// RVA: 0x1437400
	private void RemovePointerAtIndex(int index) { }

	// RVA: 0x143766C
	private void PurgeStalePointers() { }

	// RVA: 0x1437130
	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	// RVA: 0x1437804
	private void OnPointCallback(CallbackContext context) { }

	// RVA: 0x143794C
	private bool IgnoreNextClick(CallbackContext context, bool wasPressed) { }

	// RVA: 0x1437B14
	private void OnLeftClickCallback(CallbackContext context) { }

	// RVA: 0x1437BEC
	private void OnRightClickCallback(CallbackContext context) { }

	// RVA: 0x1437CC4
	private void OnMiddleClickCallback(CallbackContext context) { }

	// RVA: 0x14367DC
	private bool CheckForRemovedDevice(CallbackContext context) { }

	// RVA: 0x1437D9C
	private void OnScrollCallback(CallbackContext context) { }

	// RVA: 0x1437E8C
	private void OnMoveCallback(CallbackContext context) { }

	// RVA: 0x1437EFC
	private void OnTrackedDeviceOrientationCallback(CallbackContext context) { }

	// RVA: 0x1437FDC
	private void OnTrackedDevicePositionCallback(CallbackContext context) { }

	// RVA: 0x14380BC
	private void OnControlsChanged(object obj) { }

	// RVA: 0x14380C8
	private void FilterPointerStatesByType() { }

	// RVA: 0x143831C
	public override void Process() { }

	// RVA: 0x14384D8
	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x1435FE8
	private void HookActions() { }

	// RVA: 0x1435C3C
	private void UnhookActions() { }

	// RVA: 0x14385C4
	private void SetActionCallbacks(bool install) { }

	// RVA: 0x14386B4
	private static void SetActionCallback(InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x14387B4
	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

	// RVA: 0x1438840
	public InputActionAsset get_actionsAsset() { }

	// RVA: 0x1420178
	public void set_actionsAsset(InputActionAsset value) { }

	// RVA: 0x1438848
	public void .ctor() { }

	// RVA: 0x1438874
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
public class MultiplayerEventSystem
{
	// Fields
	private GameObject m_PlayerRoot; // 0x60

	// Methods

	// RVA: 0x1438EF0
	public GameObject get_playerRoot() { }

	// RVA: 0x1438EF8
	public void set_playerRoot(GameObject value) { }

	// RVA: 0x1439050
	protected override void OnEnable() { }

	// RVA: 0x1439078
	protected override void OnDisable() { }

	// RVA: 0x1438F20
	private void InitializePlayerRoot() { }

	// RVA: 0x1439080
	protected override void Update() { }

	// RVA: 0x1439190
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

	// RVA: 0x1439218
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

	// RVA: 0x14396FC
	public bool get_isPressed() { }

	// RVA: 0x1439704
	public void set_isPressed(bool value) { }

	// RVA: 0x1439754
	public bool get_ignoreNextClick() { }

	// RVA: 0x143975C
	public void set_ignoreNextClick(bool value) { }

	// RVA: 0x1439764
	public float get_pressTime() { }

	// RVA: 0x143976C
	public void set_pressTime(float value) { }

	// RVA: 0x1439774
	public bool get_clickedOnSameGameObject() { }

	// RVA: 0x143977C
	public void set_clickedOnSameGameObject(bool value) { }

	// RVA: 0x1439784
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x1439794
	public bool get_wasReleasedThisFrame() { }

	// RVA: 0x14397A8
	public void CopyPressStateTo(PointerEventData eventData) { }

	// RVA: 0x143986C
	public void CopyPressStateFrom(PointerEventData eventData) { }

	// RVA: 0x14395A0
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

	// RVA: 0x143926C
	public UIPointerType get_pointerType() { }

	// RVA: 0x143928C
	public Vector2 get_screenPosition() { }

	// RVA: 0x1439298
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x14392DC
	public Vector3 get_worldPosition() { }

	// RVA: 0x14392EC
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x1439344
	public Quaternion get_worldOrientation() { }

	// RVA: 0x1439358
	public void set_worldOrientation(Quaternion value) { }

	// RVA: 0x14393B4
	public Vector2 get_scrollDelta() { }

	// RVA: 0x14393C0
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x1439404
	public float get_pressure() { }

	// RVA: 0x143940C
	public void set_pressure(float value) { }

	// RVA: 0x143942C
	public float get_azimuthAngle() { }

	// RVA: 0x1439434
	public void set_azimuthAngle(float value) { }

	// RVA: 0x1439454
	public float get_altitudeAngle() { }

	// RVA: 0x143945C
	public void set_altitudeAngle(float value) { }

	// RVA: 0x143947C
	public float get_twist() { }

	// RVA: 0x1439484
	public void set_twist(float value) { }

	// RVA: 0x14394A4
	public Vector2 get_radius() { }

	// RVA: 0x14394B0
	public void set_radius(Vector2 value) { }

	// RVA: 0x14394F4
	public void .ctor(ExtendedPointerEventData eventData) { }

	// RVA: 0x14395AC
	public void OnFrameFinished() { }

	// RVA: 0x14395F8
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

	// RVA: 0x143AC34
	public void .ctor(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) { }

	// RVA: 0x143ADBC
	public Graphic get_graphic() { }

	// RVA: 0x143ADC4
	public Vector3 get_worldHitPosition() { }

	// RVA: 0x143ADD0
	public Vector2 get_screenPosition() { }

	// RVA: 0x143ADD8
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

	// RVA: 0x143ADE0
	private static void .cctor() { }

	// RVA: 0x143AE4C
	public void .ctor() { }

	// RVA: 0x143AE54
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

	// RVA: 0x1439920
	public override Camera get_eventCamera() { }

	// RVA: 0x1439AE4
	public LayerMask get_blockingMask() { }

	// RVA: 0x1439AEC
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x1439AF4
	public bool get_checkFor3DOcclusion() { }

	// RVA: 0x1439AFC
	public void set_checkFor3DOcclusion(bool value) { }

	// RVA: 0x1439B04
	public bool get_checkFor2DOcclusion() { }

	// RVA: 0x1439B0C
	public void set_checkFor2DOcclusion(bool value) { }

	// RVA: 0x1439B14
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x1439B1C
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1439B24
	public float get_maxDistance() { }

	// RVA: 0x1439B2C
	public void set_maxDistance(float value) { }

	// RVA: 0x1439B34
	protected override void OnEnable() { }

	// RVA: 0x1439BC4
	protected override void OnDisable() { }

	// RVA: 0x1439CBC
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1439D68
	internal void PerformRaycast(ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x143A32C
	private void SortedRaycastGraphics(Canvas canvas, Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results) { }

	// RVA: 0x143A83C
	private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, Vector3 worldPosition, float distance) { }

	// RVA: 0x14399EC
	private Canvas get_canvas() { }

	// RVA: 0x143AC94
	public void .ctor() { }

	// RVA: 0x143AD28
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

	// RVA: 0x143AEB0
	public RectTransform get_cursorTransform() { }

	// RVA: 0x143AEB8
	public void set_cursorTransform(RectTransform value) { }

	// RVA: 0x143AEC0
	public float get_cursorSpeed() { }

	// RVA: 0x143AEC8
	public void set_cursorSpeed(float value) { }

	// RVA: 0x143AED0
	public CursorMode get_cursorMode() { }

	// RVA: 0x143AED8
	public void set_cursorMode(CursorMode value) { }

	// RVA: 0x143B2B8
	public Graphic get_cursorGraphic() { }

	// RVA: 0x143B2C0
	public void set_cursorGraphic(Graphic value) { }

	// RVA: 0x143B3C8
	public float get_scrollSpeed() { }

	// RVA: 0x143B3D0
	public void set_scrollSpeed(float value) { }

	// RVA: 0x143B3D8
	public Mouse get_virtualMouse() { }

	// RVA: 0x143B3E0
	public InputActionProperty get_stickAction() { }

	// RVA: 0x143B3F4
	public void set_stickAction(InputActionProperty value) { }

	// RVA: 0x143B580
	public InputActionProperty get_leftButtonAction() { }

	// RVA: 0x143B594
	public void set_leftButtonAction(InputActionProperty value) { }

	// RVA: 0x143B6F8
	public InputActionProperty get_rightButtonAction() { }

	// RVA: 0x143B70C
	public void set_rightButtonAction(InputActionProperty value) { }

	// RVA: 0x143B7EC
	public InputActionProperty get_middleButtonAction() { }

	// RVA: 0x143B800
	public void set_middleButtonAction(InputActionProperty value) { }

	// RVA: 0x143B8E0
	public InputActionProperty get_forwardButtonAction() { }

	// RVA: 0x143B8F4
	public void set_forwardButtonAction(InputActionProperty value) { }

	// RVA: 0x143B9D4
	public InputActionProperty get_backButtonAction() { }

	// RVA: 0x143B9E8
	public void set_backButtonAction(InputActionProperty value) { }

	// RVA: 0x143BAC8
	public InputActionProperty get_scrollWheelAction() { }

	// RVA: 0x143BADC
	public void set_scrollWheelAction(InputActionProperty value) { }

	// RVA: 0x143BB10
	protected void OnEnable() { }

	// RVA: 0x143C09C
	protected void OnDisable() { }

	// RVA: 0x143B350
	private void TryFindCanvas() { }

	// RVA: 0x143AFF4
	private void TryEnableHardwareCursor() { }

	// RVA: 0x143C3A8
	private void UpdateMotion() { }

	// RVA: 0x143C764
	private void OnButtonActionTriggered(CallbackContext context) { }

	// RVA: 0x143B674
	private static void SetActionCallback(InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x143B428
	private static void SetAction(InputActionProperty field, InputActionProperty value) { }

	// RVA: 0x143C9DC
	private void OnAfterInputUpdate() { }

	// RVA: 0x143C9E0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
public class OnScreenButton
{
	// Fields
	private string m_ControlPath; // 0x38

	// Methods

	// RVA: 0x143C9F4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x143CA5C
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x143CAC8
	protected override string get_controlPathInternal() { }

	// RVA: 0x143CAD0
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x143CAD8
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

	// RVA: 0x143D440
	public OnScreenDeviceInfo AddControl(OnScreenControl control) { }

	// RVA: 0x143D82C
	public OnScreenDeviceInfo RemoveControl(OnScreenControl control) { }

	// RVA: 0x143D384
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

	// RVA: 0x143CAE8
	public string get_controlPath() { }

	// RVA: 0x143CAF4
	public void set_controlPath(string value) { }

	// RVA: 0x143D37C
	public InputControl get_control() { }

	// RVA: -1
	protected abstract string get_controlPathInternal() { }

	// RVA: -1
	protected abstract void set_controlPathInternal(string value) { }

	// RVA: 0x143CB3C
	private void SetupInputControl() { }

	// RVA: 0x315B3A8
	protected void SendValueToControl(TValue value) { }

	// RVA: 0x143D4A8
	protected void SentDefaultValueToControl() { }

	// RVA: 0x143D5F8
	protected virtual void OnEnable() { }

	// RVA: 0x143D5FC
	protected virtual void OnDisable() { }

	// RVA: 0x143CAE0
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

	// RVA: 0x143D98C
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x143DCE8
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x143E168
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x143E260
	private void Start() { }

	// RVA: 0x143DA38
	private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x143DD94
	private void MoveStick(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x143E178
	private void EndInteraction() { }

	// RVA: 0x143E900
	private void OnPointerDown(CallbackContext ctx) { }

	// RVA: 0x143EFEC
	private void OnPointerMove(CallbackContext ctx) { }

	// RVA: 0x143F0D8
	private void OnPointerUp(CallbackContext ctx) { }

	// RVA: 0x143ECCC
	private Camera GetCameraFromCanvas() { }

	// RVA: 0x143F174
	private void OnDrawGizmosSelected() { }

	// RVA: 0x143F48C
	private void DrawGizmoCircle(Vector2 center, float radius) { }

	// RVA: 0x143F554
	private void UpdateDynamicOriginClickableArea() { }

	// RVA: 0x143F65C
	public float get_movementRange() { }

	// RVA: 0x143F664
	public void set_movementRange(float value) { }

	// RVA: 0x143F66C
	public float get_dynamicOriginRange() { }

	// RVA: 0x143F674
	public void set_dynamicOriginRange(float value) { }

	// RVA: 0x143F68C
	public bool get_useIsolatedInputActions() { }

	// RVA: 0x143F694
	public void set_useIsolatedInputActions(bool value) { }

	// RVA: 0x143F69C
	protected override string get_controlPathInternal() { }

	// RVA: 0x143F6A4
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x143F6AC
	public Behaviour get_behaviour() { }

	// RVA: 0x143F6B4
	public void set_behaviour(Behaviour value) { }

	// RVA: 0x143F6BC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
internal static class OnScreenSupport
{
	// Methods

	// RVA: 0x143F6D0
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

	// RVA: 0x143F6D4
	public bool get_enabled() { }

	// RVA: 0x143F6DC
	public void set_enabled(bool value) { }

	// RVA: 0x143F6E4
	public string get_usageDescription() { }

	// RVA: 0x143F6EC
	public void set_usageDescription(string value) { }

	// RVA: 0x143F6F4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class iOSGameController
{
	// Methods

	// RVA: 0x143F6FC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class XboxOneGampadiOS
{
	// Methods

	// RVA: 0x143F704
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualShock4GampadiOS
{
	// Methods

	// RVA: 0x143F70C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualSenseGampadiOS
{
	// Methods

	// RVA: 0x143F71C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
internal static class iOSSupport
{
	// Methods

	// RVA: 0x143F724
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

	// RVA: 0x143FC7C
	public FourCC get_format() { }

	// RVA: 0x143FCF8
	public iOSGameControllerState WithButton(iOSButton button, bool value, float rawValue) { }

	// RVA: 0x143FD44
	public iOSGameControllerState WithAxis(iOSAxis axis, float value) { }

	// RVA: 0x143FD70
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

	// RVA: 0x143FDE8
	public FourCC get_format() { }

	// RVA: 0x143FE64
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDataReceivedDelegate
{
	// Methods

	// RVA: 0x1440498
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14405C0
	public virtual void Invoke(int deviceId, int numberOfSteps) { }

	// RVA: 0x14405D4
	public virtual IAsyncResult BeginInvoke(int deviceId, int numberOfSteps, AsyncCallback callback, object object) { }

	// RVA: 0x14406A0
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

	// RVA: 0x143FFE0
	private static extern int _iOSStepCounterEnable(int deviceId, iOSStepCounterCallbacks callbacks, int sizeOfCallbacks) { }

	// RVA: 0x144009C
	private static extern int _iOSStepCounterDisable(int deviceId) { }

	// RVA: 0x14400A0
	private static extern int _iOSStepCounterIsEnabled(int deviceId) { }

	// RVA: 0x14400A4
	private static extern int _iOSStepCounterIsAvailable() { }

	// RVA: 0x14400A8
	private static extern int _iOSStepCounterGetAuthorizationStatus() { }

	// RVA: 0x143FEDC
	private static void OnDataReceived(int deviceId, int numberOfSteps) { }

	// RVA: 0x14400AC
	protected override Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x143FC60
	public static bool IsAvailable() { }

	// RVA: 0x14405B4
	public static MotionAuthorizationStatus get_AuthorizationStatus() { }

	// RVA: 0x14405B8
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

	// RVA: 0x1446130
	private static void .cctor() { }

	// RVA: 0x144619C
	public void .ctor() { }

	// RVA: 0x14461A4
	internal bool <Build>b__4_0(HIDElementDescriptor element) { }

	// RVA: 0x14461C8
	internal bool <Build>b__4_1(HIDElementDescriptor element) { }

	// RVA: 0x14461EC
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

	// RVA: 0x144421C
	public InputControlLayout Build() { }

	// RVA: 0x1441A88
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

	// RVA: 0x14461F8
	public bool get_hasNullState() { }

	// RVA: 0x1446204
	public bool get_hasPreferredState() { }

	// RVA: 0x1446214
	public bool get_isArray() { }

	// RVA: 0x1446224
	public bool get_isNonLinear() { }

	// RVA: 0x1446230
	public bool get_isRelative() { }

	// RVA: 0x144623C
	public bool get_isConstant() { }

	// RVA: 0x1446248
	public bool get_isWrapping() { }

	// RVA: 0x14450D0
	internal bool get_isSigned() { }

	// RVA: 0x1446254
	internal float get_minFloatValue() { }

	// RVA: 0x14462EC
	internal float get_maxFloatValue() { }

	// RVA: 0x1445230
	public bool Is(UsagePage usagePage, int usage) { }

	// RVA: 0x1445374
	internal string DetermineName() { }

	// RVA: 0x14455AC
	internal string DetermineDisplayName() { }

	// RVA: 0x1441A48
	internal bool IsUsableElement() { }

	// RVA: 0x1445254
	internal string DetermineLayout() { }

	// RVA: 0x14456CC
	internal FourCC DetermineFormat() { }

	// RVA: 0x14458C8
	internal InternedString[] DetermineUsages() { }

	// RVA: 0x1444F74
	internal string DetermineParameters() { }

	// RVA: 0x144638C
	private string DetermineAxisNormalizationParameters() { }

	// RVA: 0x14451B4
	internal string DetermineProcessors() { }

	// RVA: 0x14450DC
	internal PrimitiveValue DetermineDefaultState() { }

	// RVA: 0x1445AC0
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

	// RVA: 0x1444048
	public string ToJson() { }

	// RVA: 0x1441A90
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

	// RVA: 0x1446660
	public void .ctor(UsagePage usagePage, int usage) { }

	// RVA: 0x1446678
	public void .ctor(GenericDesktop usage) { }

	// RVA: 0x1446694
	public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId) { }

	// RVA: 0x14466BC
	public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) { }

	// RVA: 0x1446A74
	public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) { }

	// RVA: 0x1446AC8
	public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) { }

	// RVA: 0x1446C38
	public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) { }

	// RVA: 0x1446D94
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

	// RVA: 0x144117C
	public void .ctor() { }

	// RVA: 0x1446E90
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

	// RVA: 0x14406AC
	public static FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	// RVA: 0x14406E8
	public static FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	// RVA: 0x1440724
	public static FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	// RVA: 0x1440760
	public HIDDeviceDescriptor get_hidDescriptor() { }

	// RVA: 0x144081C
	internal static string OnFindLayoutForDevice(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x1441184
	internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	// RVA: 0x14440C4
	public static string UsagePageToString(UsagePage usagePage) { }

	// RVA: 0x1444160
	public static string UsageToString(UsagePage usagePage, int usage) { }

	// RVA: 0x1444214
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

	// RVA: 0x14474B4
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

	// RVA: 0x14473E4
	public static void Reset(HIDItemStateLocal state) { }

	// RVA: 0x1446F8C
	public void SetUsage(int value) { }

	// RVA: 0x14471F0
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

	// RVA: 0x1447108
	public UsagePage GetUsagePage(int index, HIDItemStateLocal localItemState) { }

	// RVA: 0x144764C
	public int GetPhysicalMin() { }

	// RVA: 0x14477AC
	public int GetPhysicalMax() { }

}

// Namespace: UnityEngine.InputSystem.HID
internal static class HIDParser
{
	// Methods

	// RVA: 0x1446EAC
	public static bool ParseReportDescriptor(Byte[] buffer, HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x144297C
	public static bool ParseReportDescriptor(Byte* bufferPtr, int bufferLength, HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x1446F24
	private static int ReadData(int itemSize, Byte* currentPtr, Byte* endPtr) { }

}

// Namespace: 
public struct HIDPageUsage
{
	// Fields
	public UsagePage page; // 0x10
	public int usage; // 0x14

	// Methods

	// RVA: 0x1441A40
	public void .ctor(UsagePage page, int usage) { }

	// RVA: 0x1447D90
	public void .ctor(GenericDesktop usage) { }

}

// Namespace: UnityEngine.InputSystem.HID
public static class HIDSupport
{
	// Fields
	private static HIDPageUsage[] s_SupportedHIDUsages; // 0x0

	// Methods

	// RVA: 0x14419D4
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages() { }

	// RVA: 0x144790C
	public static void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value) { }

	// RVA: 0x1447C2C
	internal static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public static class EnhancedTouchSupport
{
	// Fields
	private static int s_Enabled; // 0x0
	private static UpdateMode s_UpdateMode; // 0x4

	// Methods

	// RVA: 0x1447D9C
	public static bool get_enabled() { }

	// RVA: 0x1447DF0
	public static void Enable() { }

	// RVA: 0x1448168
	public static void Disable() { }

	// RVA: 0x1448554
	internal static void Reset() { }

	// RVA: 0x1447F70
	private static void SetUpState() { }

	// RVA: 0x144831C
	internal static void TearDownState() { }

	// RVA: 0x1448688
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x14489B8
	private static void OnSettingsChange() { }

	// RVA: 0x1448A6C
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

	// RVA: 0x1448B08
	public Touchscreen get_screen() { }

	// RVA: 0x1448B10
	public int get_index() { }

	// RVA: 0x1448B18
	public bool get_isActive() { }

	// RVA: 0x1448EEC
	public Vector2 get_screenPosition() { }

	// RVA: 0x144910C
	public Touch get_lastTouch() { }

	// RVA: 0x1448BE0
	public Touch get_currentTouch() { }

	// RVA: 0x1449494
	public TouchHistory get_touchHistory() { }

	// RVA: 0x14495A0
	internal void .ctor(Touchscreen screen, int index, InputUpdateType updateMask) { }

	// RVA: 0x14499DC
	private static bool ShouldRecordTouch(InputControl control, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x1449AB8
	private void OnTouchRecorded(Record record) { }

	// RVA: 0x1449D80
	private Touch FindTouch(UInt32 uniqueId) { }

	// RVA: 0x144A0C4
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

	// RVA: 0x144CC8C
	public void AddFingers(Touchscreen screen) { }

	// RVA: 0x144CDA4
	public void RemoveFingers(Touchscreen screen) { }

	// RVA: 0x14485F8
	public void Destroy() { }

	// RVA: 0x144BDF8
	public void UpdateActiveFingers() { }

	// RVA: 0x144B570
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

	// RVA: 0x144D35C
	private static void .cctor() { }

	// RVA: 0x144D3C8
	public void .ctor() { }

	// RVA: 0x144D3D0
	internal void <SaveAndResetState>b__80_0(GlobalState state) { }

	// RVA: 0x144D468
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

	// RVA: 0x1448E98
	public bool get_valid() { }

	// RVA: 0x144A6EC
	public Finger get_finger() { }

	// RVA: 0x144A634
	public TouchPhase get_phase() { }

	// RVA: 0x144A748
	public bool get_began() { }

	// RVA: 0x144A850
	public bool get_inProgress() { }

	// RVA: 0x144AAC8
	public bool get_ended() { }

	// RVA: 0x144A57C
	public int get_touchId() { }

	// RVA: 0x144AC84
	public float get_pressure() { }

	// RVA: 0x144AD3C
	public Vector2 get_radius() { }

	// RVA: 0x144ADF4
	public Double get_startTime() { }

	// RVA: 0x144AEAC
	public Double get_time() { }

	// RVA: 0x144AF00
	public Touchscreen get_screen() { }

	// RVA: 0x14491D4
	public Vector2 get_screenPosition() { }

	// RVA: 0x144AF80
	public Vector2 get_startScreenPosition() { }

	// RVA: 0x144B038
	public Vector2 get_delta() { }

	// RVA: 0x144B0F0
	public int get_tapCount() { }

	// RVA: 0x144B1A8
	public bool get_isTap() { }

	// RVA: 0x144B260
	public int get_displayIndex() { }

	// RVA: 0x14492CC
	public bool get_isInProgress() { }

	// RVA: 0x14493DC
	internal UInt32 get_updateStepCount() { }

	// RVA: 0x144A4C4
	internal UInt32 get_uniqueId() { }

	// RVA: 0x144A6F4
	private TouchState get_state() { }

	// RVA: 0x144B318
	private ExtraDataPerTouchState get_extraData() { }

	// RVA: 0x144B36C
	public TouchHistory get_history() { }

	// RVA: 0x144B4CC
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches() { }

	// RVA: 0x144BCC0
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers() { }

	// RVA: 0x144BD54
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers() { }

	// RVA: 0x144BF78
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens() { }

	// RVA: 0x144C010
	public static void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x144C0E0
	public static void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x144C1B0
	public static void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x144C280
	public static void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x144C350
	public static void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x144C420
	public static void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1449960
	public static int get_maxHistoryLengthPerFinger() { }

	// RVA: 0x144928C
	internal void .ctor(Finger finger, Record touchRecord) { }

	// RVA: 0x144C4F0
	public override string ToString() { }

	// RVA: 0x144CA7C
	public bool Equals(Touch other) { }

	// RVA: 0x144CAFC
	public override bool Equals(object obj) { }

	// RVA: 0x144CC0C
	public override int GetHashCode() { }

	// RVA: 0x144883C
	internal static void AddTouchscreen(Touchscreen screen) { }

	// RVA: 0x14488D4
	internal static void RemoveTouchscreen(Touchscreen screen) { }

	// RVA: 0x144CEE4
	internal static void BeginUpdate() { }

	// RVA: 0x144CF90
	private static GlobalState CreateGlobalState() { }

	// RVA: 0x144CFF0
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x144D2A8
	private static void .cctor() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private readonly TouchHistory m_Owner; // 0x10
	private int m_Index; // 0x30

	// Methods

	// RVA: 0x144D4FC
	internal void .ctor(TouchHistory owner) { }

	// RVA: 0x144D7F0
	public bool MoveNext() { }

	// RVA: 0x144D818
	public void Reset() { }

	// RVA: 0x144D824
	public Touch get_Current() { }

	// RVA: 0x144D870
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x144D8F8
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

	// RVA: 0x1449500
	internal void .ctor(Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex, int count) { }

	// RVA: 0x144D46C
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator() { }

	// RVA: 0x144D540
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x144D5D0
	public int get_Count() { }

	// RVA: 0x144D5D8
	public Touch get_Item(int index) { }

	// RVA: 0x144D750
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

	// RVA: 0x144D8FC
	public Touchscreen get_simulatedTouchscreen() { }

	// RVA: 0x144D904
	private void set_simulatedTouchscreen(Touchscreen value) { }

	// RVA: 0x144D90C
	public static TouchSimulation get_instance() { }

	// RVA: 0x144D958
	public static void Enable() { }

	// RVA: 0x144DB50
	public static void Disable() { }

	// RVA: 0x144DC4C
	public static void Destroy() { }

	// RVA: 0x144DD54
	protected void AddPointer(Pointer pointer) { }

	// RVA: 0x144DEC8
	protected void RemovePointer(Pointer pointer) { }

	// RVA: 0x144E4E0
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x144EB08
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x144EC58
	protected void OnEnable() { }

	// RVA: 0x144F178
	protected void OnDisable() { }

	// RVA: 0x144E0BC
	private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr) { }

	// RVA: 0x144F2EC
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x144F2F0
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x144F2F4
	protected void InstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x144F2F8
	protected void OnSourceControlChangedValue(InputControl control, Double time, InputEventPtr eventPtr, Int64 sourceDeviceAndButtonIndex) { }

	// RVA: 0x144F2FC
	protected void UninstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x144F300
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

	// RVA: 0x144F310
	public ButtonControl get_touchpadButton() { }

	// RVA: 0x144F318
	protected void set_touchpadButton(ButtonControl value) { }

	// RVA: 0x144F328
	public ButtonControl get_optionsButton() { }

	// RVA: 0x144F330
	protected void set_optionsButton(ButtonControl value) { }

	// RVA: 0x144F340
	public ButtonControl get_shareButton() { }

	// RVA: 0x144F348
	protected void set_shareButton(ButtonControl value) { }

	// RVA: 0x144F358
	public ButtonControl get_L1() { }

	// RVA: 0x144F360
	protected void set_L1(ButtonControl value) { }

	// RVA: 0x144F370
	public ButtonControl get_R1() { }

	// RVA: 0x144F378
	protected void set_R1(ButtonControl value) { }

	// RVA: 0x144F388
	public ButtonControl get_L2() { }

	// RVA: 0x144F390
	protected void set_L2(ButtonControl value) { }

	// RVA: 0x144F3A0
	public ButtonControl get_R2() { }

	// RVA: 0x144F3A8
	protected void set_R2(ButtonControl value) { }

	// RVA: 0x144F3B8
	public ButtonControl get_L3() { }

	// RVA: 0x144F3C0
	protected void set_L3(ButtonControl value) { }

	// RVA: 0x144F3D0
	public ButtonControl get_R3() { }

	// RVA: 0x144F3D8
	protected void set_R3(ButtonControl value) { }

	// RVA: 0x144F3E8
	public static DualShockGamepad get_current() { }

	// RVA: 0x144F434
	private static void set_current(DualShockGamepad value) { }

	// RVA: 0x144F498
	public override void MakeCurrent() { }

	// RVA: 0x144F4FC
	protected override void OnRemoved() { }

	// RVA: 0x144F59C
	protected override void FinishSetup() { }

	// RVA: 0x144F6A4
	public virtual void SetLightBarColor(Color color) { }

	// RVA: 0x143F714
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
internal static class DualShockSupport
{
	// Methods

	// RVA: 0x144F6A8
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

	// RVA: 0x144F71C
	public float get_lowFrequencyMotorSpeed() { }

	// RVA: 0x144F724
	private void set_lowFrequencyMotorSpeed(float value) { }

	// RVA: 0x144F72C
	public float get_highFrequencyMotorSpeed() { }

	// RVA: 0x144F734
	private void set_highFrequencyMotorSpeed(float value) { }

	// RVA: 0x144F73C
	public bool get_isRumbling() { }

	// RVA: 0x144F824
	public void PauseHaptics(InputDevice device) { }

	// RVA: 0x144F9D0
	public void ResumeHaptics(InputDevice device) { }

	// RVA: 0x144FC44
	public void ResetHaptics(InputDevice device) { }

	// RVA: 0x144FB1C
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

	// RVA: 0x144053C
	public static FourCC get_Type() { }

	// RVA: 0x144FD94
	public FourCC get_typeStatic() { }

	// RVA: 0x144FDD0
	public static DisableDeviceCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct EnableDeviceCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x144045C
	public static FourCC get_Type() { }

	// RVA: 0x144FE10
	public FourCC get_typeStatic() { }

	// RVA: 0x144FE4C
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

	// RVA: 0x144FE8C
	public static FourCC get_Type() { }

	// RVA: 0x144FEC8
	public bool get_imeEnabled() { }

	// RVA: 0x144FED8
	public FourCC get_typeStatic() { }

	// RVA: 0x144FF14
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

	// RVA: 0x144FF70
	public static FourCC get_Type() { }

	// RVA: 0x144FFAC
	public FourCC get_typeStatic() { }

	// RVA: 0x144FFE8
	public static InitiateUserAccountPairingCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceCommandDelegate
{
	// Methods

	// RVA: 0x1450028
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145014C
	public virtual System.Nullable<System.Int64> Invoke(InputDevice device, InputDeviceCommand* command) { }

	// RVA: 0x1450160
	public virtual IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	// RVA: 0x14501BC
	public virtual System.Nullable<System.Int64> EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceExecuteCommandDelegate
{
	// Methods

	// RVA: 0x14501EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14502A0
	public virtual Int64 Invoke(InputDeviceCommand command) { }

	// RVA: 0x14502B4
	public virtual IAsyncResult BeginInvoke(InputDeviceCommand command, AsyncCallback callback, object object) { }

	// RVA: 0x1450370
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

	// RVA: 0x14503D4
	public int get_payloadSizeInBytes() { }

	// RVA: 0x1442974
	public Void* get_payloadPtr() { }

	// RVA: 0x14428B0
	public void .ctor(FourCC type, int sizeInBytes) { }

	// RVA: 0x14428B8
	public static Unity.Collections.NativeArray<System.Byte> AllocateNative(FourCC type, int payloadSize) { }

	// RVA: 0x14503E0
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

	// RVA: 0x1440578
	public static FourCC get_Type() { }

	// RVA: 0x14503E8
	public FourCC get_typeStatic() { }

	// RVA: 0x1450424
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

	// RVA: 0x145046C
	public static FourCC get_Type() { }

	// RVA: 0x14504A8
	public FourCC get_typeStatic() { }

	// RVA: 0x14504E4
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

	// RVA: 0x1440420
	public static FourCC get_Type() { }

	// RVA: 0x1450528
	public FourCC get_typeStatic() { }

	// RVA: 0x1450564
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

	// RVA: 0x14505AC
	public static FourCC get_Type() { }

	// RVA: 0x14505E8
	public string ReadLayoutName() { }

	// RVA: 0x14505F8
	public void WriteLayoutName(string name) { }

	// RVA: 0x1450620
	public FourCC get_typeStatic() { }

	// RVA: 0x145065C
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

	// RVA: 0x14506F4
	public static FourCC get_Type() { }

	// RVA: 0x1450730
	public string ReadKeyName() { }

	// RVA: 0x1450740
	public FourCC get_typeStatic() { }

	// RVA: 0x145077C
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

	// RVA: 0x145081C
	public static FourCC get_Type() { }

	// RVA: 0x1450858
	public string get_id() { }

	// RVA: 0x1450868
	public void set_id(string value) { }

	// RVA: 0x1450984
	public string get_name() { }

	// RVA: 0x1450994
	public void set_name(string value) { }

	// RVA: 0x1450AB0
	public FourCC get_typeStatic() { }

	// RVA: 0x1450AEC
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

	// RVA: 0x1450B4C
	public static FourCC get_Type() { }

	// RVA: 0x1450B88
	public FourCC get_typeStatic() { }

	// RVA: 0x1450BC4
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

	// RVA: 0x1450C1C
	public static FourCC get_Type() { }

	// RVA: 0x1450C58
	public string ReadId() { }

	// RVA: 0x1450C68
	public FourCC get_typeStatic() { }

	// RVA: 0x1450CA4
	public static QueryUserIdCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestResetCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1450D6C
	public static FourCC get_Type() { }

	// RVA: 0x1450DA8
	public FourCC get_typeStatic() { }

	// RVA: 0x1450DE4
	public static RequestResetCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestSyncCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1450E38
	public static FourCC get_Type() { }

	// RVA: 0x1450E74
	public FourCC get_typeStatic() { }

	// RVA: 0x1450EB0
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

	// RVA: 0x1450F04
	public static FourCC get_Type() { }

	// RVA: 0x1450F40
	public Vector2 get_position() { }

	// RVA: 0x1450F48
	public FourCC get_typeStatic() { }

	// RVA: 0x1450F84
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

	// RVA: 0x1450FF4
	public static FourCC get_Type() { }

	// RVA: 0x1451030
	public FourCC get_typeStatic() { }

	// RVA: 0x145106C
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

	// RVA: 0x14510D0
	public static FourCC get_Type() { }

	// RVA: 0x145110C
	public FourCC get_typeStatic() { }

	// RVA: 0x1451148
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

	// RVA: 0x14511AC
	public static FourCC get_Type() { }

	// RVA: 0x14511E8
	public FourCC get_typeStatic() { }

	// RVA: 0x1451224
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

	// RVA: 0x1451294
	public static FourCC get_Format() { }

	// RVA: 0x14512D0
	public FourCC get_format() { }

	// RVA: 0x145130C
	public void .ctor(GamepadButton[] buttons) { }

	// RVA: 0x14513B8
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

	// RVA: 0x14513EC
	public static FourCC get_Type() { }

	// RVA: 0x1451428
	public FourCC get_typeStatic() { }

	// RVA: 0x1451464
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

	// RVA: 0x14514D4
	public static FourCC get_kFormat() { }

	// RVA: 0x1451510
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

	// RVA: 0x145154C
	public static FourCC get_Format() { }

	// RVA: 0x1451588
	public void .ctor(Key[] pressedKeys) { }

	// RVA: 0x1451640
	public void Set(Key key, bool state) { }

	// RVA: 0x1451648
	public void Press(Key key) { }

	// RVA: 0x1451654
	public void Release(Key key) { }

	// RVA: 0x1451660
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

	// RVA: 0x145169C
	public static FourCC get_Format() { }

	// RVA: 0x14516D8
	public MouseState WithButton(MouseButton button, bool state) { }

	// RVA: 0x145170C
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

	// RVA: 0x1451748
	public static FourCC get_Format() { }

	// RVA: 0x1451784
	public PenState WithButton(PenButton button, bool state) { }

	// RVA: 0x14517B8
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

	// RVA: 0x14517F4
	public static FourCC get_kFormat() { }

	// RVA: 0x1451830
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AccelerometerState
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x145186C
	public static FourCC get_kFormat() { }

	// RVA: 0x14518A8
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GyroscopeState
{
	// Fields
	public Vector3 angularVelocity; // 0x10

	// Methods

	// RVA: 0x14518E4
	public static FourCC get_kFormat() { }

	// RVA: 0x1451920
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GravityState
{
	// Fields
	public Vector3 gravity; // 0x10

	// Methods

	// RVA: 0x145195C
	public static FourCC get_kFormat() { }

	// RVA: 0x1451998
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AttitudeState
{
	// Fields
	public Quaternion attitude; // 0x10

	// Methods

	// RVA: 0x14519D4
	public static FourCC get_kFormat() { }

	// RVA: 0x1451A10
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct LinearAccelerationState
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x1451A4C
	public static FourCC get_kFormat() { }

	// RVA: 0x1451A88
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

	// RVA: 0x1451AC4
	public static FourCC get_Format() { }

	// RVA: 0x1451B00
	public TouchPhase get_phase() { }

	// RVA: 0x1451B08
	public void set_phase(TouchPhase value) { }

	// RVA: 0x1451B10
	public bool get_isNoneEndedOrCanceled() { }

	// RVA: 0x1451B2C
	public bool get_isInProgress() { }

	// RVA: 0x1451B48
	public bool get_isPrimaryTouch() { }

	// RVA: 0x1451B54
	public void set_isPrimaryTouch(bool value) { }

	// RVA: 0x1451B74
	internal bool get_isOrphanedPrimaryTouch() { }

	// RVA: 0x1451B80
	internal void set_isOrphanedPrimaryTouch(bool value) { }

	// RVA: 0x1451BA0
	public bool get_isIndirectTouch() { }

	// RVA: 0x1451BAC
	public void set_isIndirectTouch(bool value) { }

	// RVA: 0x1451BC0
	public bool get_isTap() { }

	// RVA: 0x1451BD8
	public void set_isTap(bool value) { }

	// RVA: 0x1451BCC
	internal bool get_isTapPress() { }

	// RVA: 0x1451BF8
	internal void set_isTapPress(bool value) { }

	// RVA: 0x1451C18
	internal bool get_isTapRelease() { }

	// RVA: 0x1451C24
	internal void set_isTapRelease(bool value) { }

	// RVA: 0x1451C44
	internal bool get_beganInSameFrame() { }

	// RVA: 0x1451C50
	internal void set_beganInSameFrame(bool value) { }

	// RVA: 0x1451C6C
	public FourCC get_format() { }

	// RVA: 0x1451CA8
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

	// RVA: 0x1451FC8
	public static FourCC get_Format() { }

	// RVA: 0x1452004
	public TouchState* get_primaryTouch() { }

	// RVA: 0x1452008
	public TouchState* get_touches() { }

	// RVA: 0x1452010
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

	// RVA: 0x145204C
	public static FourCC get_Type() { }

	// RVA: 0x1452088
	public Double get_startTime() { }

	// RVA: 0x1452090
	public void set_startTime(Double value) { }

	// RVA: 0x1452098
	public InputActionPhase get_phase() { }

	// RVA: 0x14520A0
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x14520A8
	public Byte* get_valueData() { }

	// RVA: 0x14520B0
	public int get_valueSizeInBytes() { }

	// RVA: 0x14520C4
	public int get_stateIndex() { }

	// RVA: 0x14520CC
	public void set_stateIndex(int value) { }

	// RVA: 0x1452138
	public int get_controlIndex() { }

	// RVA: 0x1452140
	public void set_controlIndex(int value) { }

	// RVA: 0x14521AC
	public int get_bindingIndex() { }

	// RVA: 0x14521B4
	public void set_bindingIndex(int value) { }

	// RVA: 0x1452220
	public int get_interactionIndex() { }

	// RVA: 0x1452234
	public void set_interactionIndex(int value) { }

	// RVA: 0x14522B0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x14522B4
	public FourCC get_typeStatic() { }

	// RVA: 0x14522F0
	public static int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	// RVA: 0x14522F8
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

	// RVA: 0x1452454
	public UInt32 get_deltaStateSizeInBytes() { }

	// RVA: 0x1452460
	public Void* get_deltaState() { }

	// RVA: 0x1452468
	public FourCC get_typeStatic() { }

	// RVA: 0x1452474
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1452478
	public static DeltaStateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x14525AC
	internal static DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x14525B0
	public static Unity.Collections.NativeArray<System.Byte> From(InputControl control, InputEventPtr eventPtr, Allocator allocator) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceConfigurationEvent
{
	// Fields
	public const int Type = 1145259591;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x1452B50
	public FourCC get_typeStatic() { }

	// RVA: 0x1452B5C
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1452B60
	public static DeviceConfigurationEvent Create(int deviceId, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceRemoveEvent
{
	// Fields
	public const int Type = 1146242381;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x1452C6C
	public FourCC get_typeStatic() { }

	// RVA: 0x1452C78
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1452C7C
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

	// RVA: 0x1452D88
	public FourCC get_typeStatic() { }

	// RVA: 0x1452D94
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

	// RVA: 0x1452EBC
	public FourCC get_typeStatic() { }

	// RVA: 0x1452EC8
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

	// RVA: 0x14532A4
	public void .ctor(IMECompositionString compositionString) { }

	// RVA: 0x1453390
	public bool MoveNext() { }

	// RVA: 0x14533C0
	public void Reset() { }

	// RVA: 0x14533CC
	public void Dispose() { }

	// RVA: 0x14533D0
	public Char get_Current() { }

	// RVA: 0x14533D8
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

	// RVA: 0x1453150
	public int get_Count() { }

	// RVA: 0x1453158
	public Char get_Item(int index) { }

	// RVA: 0x14530C0
	public void .ctor(string characters) { }

	// RVA: 0x14531D0
	public override string ToString() { }

	// RVA: 0x14531E8
	public System.Collections.Generic.IEnumerator<System.Char> GetEnumerator() { }

	// RVA: 0x14532D4
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

	// RVA: 0x1453440
	public FourCC get_type() { }

	// RVA: 0x1453448
	public void set_type(FourCC value) { }

	// RVA: 0x14520BC
	public UInt32 get_sizeInBytes() { }

	// RVA: 0x1453450
	public void set_sizeInBytes(UInt32 value) { }

	// RVA: 0x14534FC
	public int get_eventId() { }

	// RVA: 0x1453508
	public void set_eventId(int value) { }

	// RVA: 0x145351C
	public int get_deviceId() { }

	// RVA: 0x1453524
	public void set_deviceId(int value) { }

	// RVA: 0x145352C
	public Double get_time() { }

	// RVA: 0x145358C
	public void set_time(Double value) { }

	// RVA: 0x14535F8
	internal Double get_internalTime() { }

	// RVA: 0x1453600
	internal void set_internalTime(Double value) { }

	// RVA: 0x1452A40
	public void .ctor(FourCC type, int sizeInBytes, int deviceId, Double time) { }

	// RVA: 0x1453608
	public bool get_handled() { }

	// RVA: 0x1453614
	public void set_handled(bool value) { }

	// RVA: 0x1453630
	public override string ToString() { }

	// RVA: 0x14538DC
	internal static InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	// RVA: 0x14538F8
	internal static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, InputEventBuffer buffer) { }

	// RVA: 0x1453AD0
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

	// RVA: 0x1454400
	public void .ctor(InputEventBuffer buffer) { }

	// RVA: 0x14546DC
	public bool MoveNext() { }

	// RVA: 0x145474C
	public void Reset() { }

	// RVA: 0x1454758
	public void Dispose() { }

	// RVA: 0x145475C
	public InputEventPtr get_Current() { }

	// RVA: 0x1454764
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

	// RVA: 0x1453B34
	public int get_eventCount() { }

	// RVA: 0x1453B3C
	public Int64 get_sizeInBytes() { }

	// RVA: 0x1453B44
	public Int64 get_capacityInBytes() { }

	// RVA: 0x1453B9C
	public Unity.Collections.NativeArray<System.Byte> get_data() { }

	// RVA: 0x1453BA8
	public InputEventPtr get_bufferPtr() { }

	// RVA: 0x1453C00
	public void .ctor(InputEvent* eventPtr, int eventCount, int sizeInBytes, int capacityInBytes) { }

	// RVA: 0x1453DC4
	public void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, int eventCount, int sizeInBytes, bool transferNativeArrayOwnership) { }

	// RVA: 0x1453F00
	public void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x1453F80
	public InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x1453A38
	public bool Contains(InputEvent* eventPtr) { }

	// RVA: 0x145426C
	public void Reset() { }

	// RVA: 0x1454284
	internal void AdvanceToNextEvent(InputEvent* currentReadPos, InputEvent* currentWritePos, int numEventsRetainedInBuffer, int numRemainingEvents, bool leaveEventInBuffer) { }

	// RVA: 0x1454344
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x1454470
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x145452C
	public void Dispose() { }

	// RVA: 0x1454590
	public InputEventBuffer Clone() { }

	// RVA: 0x145466C
	private object System.ICloneable.Clone() { }

}

// Namespace: 
internal class ObserverState
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers; // 0x10
	public System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28

	// Methods

	// RVA: 0x1454CD4
	public void .ctor() { }

	// RVA: 0x1454D70
	private void <.ctor>b__2_0(InputEventPtr eventPtr, InputDevice device) { }

}

// Namespace: 
private class DisposableObserver
{
	// Fields
	public System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer; // 0x10

	// Methods

	// RVA: 0x1454E84
	public void Dispose() { }

	// RVA: 0x1454D68
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventListener
{
	// Fields
	internal static ObserverState s_ObserverState; // 0x0

	// Methods

	// RVA: 0x14547CC
	public static InputEventListener op_Addition(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x1454954
	public static InputEventListener op_Subtraction(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x1454ADC
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventPtr
{
	// Fields
	private readonly InputEvent* m_EventPtr; // 0x10

	// Methods

	// RVA: 0x1454FDC
	public void .ctor(InputEvent* eventPtr) { }

	// RVA: 0x145242C
	public bool get_valid() { }

	// RVA: 0x1454FE4
	public bool get_handled() { }

	// RVA: 0x1455000
	public void set_handled(bool value) { }

	// RVA: 0x1455080
	public int get_id() { }

	// RVA: 0x145509C
	public void set_id(int value) { }

	// RVA: 0x145243C
	public FourCC get_type() { }

	// RVA: 0x1455114
	public UInt32 get_sizeInBytes() { }

	// RVA: 0x145512C
	public int get_deviceId() { }

	// RVA: 0x1455144
	public void set_deviceId(int value) { }

	// RVA: 0x14551B0
	public Double get_time() { }

	// RVA: 0x1455228
	public void set_time(Double value) { }

	// RVA: 0x14552E0
	internal Double get_internalTime() { }

	// RVA: 0x14552F8
	internal void set_internalTime(Double value) { }

	// RVA: 0x1455364
	public InputEvent* get_data() { }

	// RVA: 0x145536C
	internal FourCC get_stateFormat() { }

	// RVA: 0x14554D4
	internal UInt32 get_stateSizeInBytes() { }

	// RVA: 0x1455728
	internal UInt32 get_stateOffset() { }

	// RVA: 0x30A1224
	public bool IsA() { }

	// RVA: 0x1455808
	public InputEventPtr Next() { }

	// RVA: 0x1455420
	public override string ToString() { }

	// RVA: 0x1455834
	public InputEvent* ToPointer() { }

	// RVA: 0x145583C
	public bool Equals(InputEventPtr other) { }

	// RVA: 0x14558AC
	public override bool Equals(object obj) { }

	// RVA: 0x1455994
	public override int GetHashCode() { }

	// RVA: 0x145599C
	public static bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x14559A8
	public static bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x1453BFC
	public static InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	// RVA: 0x14559B4
	public static InputEventPtr From(InputEvent* eventPtr) { }

	// RVA: 0x14546D8
	public static InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	// RVA: 0x14559B8
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

	// RVA: 0x14559BC
	public bool get_isOpen() { }

	// RVA: 0x14559C4
	public int get_remainingEventCount() { }

	// RVA: 0x14559D4
	public int get_numEventsRetainedInBuffer() { }

	// RVA: 0x14559DC
	public InputEvent* get_currentEventPtr() { }

	// RVA: 0x1455A14
	public UInt32 get_numBytesRetainedInBuffer() { }

	// RVA: 0x1455A74
	public void .ctor(InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	// RVA: 0x1455B0C
	public void Close(InputEventBuffer eventBuffer) { }

	// RVA: 0x1455C70
	public void CleanUpAfterException() { }

	// RVA: 0x1455D28
	public void Write(InputEvent* eventPtr) { }

	// RVA: 0x1455F0C
	public InputEvent* Advance(bool leaveEventInBuffer) { }

	// RVA: 0x1456048
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

	// RVA: 0x14581A8
	public void .ctor(InputEventTrace trace) { }

	// RVA: 0x1458B40
	public void Dispose() { }

	// RVA: 0x1458B70
	public bool MoveNext() { }

	// RVA: 0x1458CAC
	public void Reset() { }

	// RVA: 0x1458CD4
	public InputEventPtr get_Current() { }

	// RVA: 0x1458CDC
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

	// RVA: 0x145A7C8
	private static void .cctor() { }

	// RVA: 0x145A834
	public void .ctor() { }

	// RVA: 0x145A83C
	internal int <PlayAllEventsAccordingToTimestamps>b__38_0(InputEventPtr a, InputEventPtr b) { }

}

// Namespace: 
private sealed class <>c__DisplayClass43_0
{
	// Fields
	public int originalDeviceId; // 0x10

	// Methods

	// RVA: 0x145A7C0
	public void .ctor() { }

	// RVA: 0x145A904
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

	// RVA: 0x1458D44
	public InputEventTrace get_trace() { }

	// RVA: 0x1458D4C
	public bool get_finished() { }

	// RVA: 0x1458D54
	private void set_finished(bool value) { }

	// RVA: 0x1458D5C
	public bool get_paused() { }

	// RVA: 0x1458D64
	public void set_paused(bool value) { }

	// RVA: 0x1458D6C
	public int get_position() { }

	// RVA: 0x1458D74
	private void set_position(int value) { }

	// RVA: 0x1458D7C
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices() { }

	// RVA: 0x1457C50
	internal void .ctor(InputEventTrace trace) { }

	// RVA: 0x1458DEC
	public void Dispose() { }

	// RVA: 0x14590F0
	public ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice) { }

	// RVA: 0x1459180
	public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) { }

	// RVA: 0x14593BC
	public ReplayController WithAllDevicesMappedToNewInstances() { }

	// RVA: 0x14593C8
	public ReplayController OnFinished(Action action) { }

	// RVA: 0x14593F0
	public ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action) { }

	// RVA: 0x1459418
	public ReplayController PlayOneEvent() { }

	// RVA: 0x1459A7C
	public ReplayController Rewind() { }

	// RVA: 0x1459AC4
	public ReplayController PlayAllFramesOneByOne() { }

	// RVA: 0x1459B80
	public ReplayController PlayAllEvents() { }

	// RVA: 0x1459C30
	public ReplayController PlayAllEventsAccordingToTimestamps() { }

	// RVA: 0x1459ECC
	private void OnBeginFrame() { }

	// RVA: 0x145A1A4
	private void Finished() { }

	// RVA: 0x1459844
	private void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x14594A8
	private bool MoveNext(bool skipFrameEvents, InputEventPtr eventPtr) { }

	// RVA: 0x145A29C
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

	// RVA: 0x145A918
	public int get_deviceId() { }

	// RVA: 0x145A920
	public void set_deviceId(int value) { }

	// RVA: 0x145A928
	public string get_layout() { }

	// RVA: 0x145A930
	public void set_layout(string value) { }

	// RVA: 0x145A938
	public FourCC get_stateFormat() { }

	// RVA: 0x145A940
	public void set_stateFormat(FourCC value) { }

	// RVA: 0x145A948
	public int get_stateSizeInBytes() { }

	// RVA: 0x145A950
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

	// RVA: 0x14560A8
	public static FourCC get_FrameMarkerEvent() { }

	// RVA: 0x14560E4
	public int get_deviceId() { }

	// RVA: 0x14560EC
	public void set_deviceId(int value) { }

	// RVA: 0x14560F4
	public bool get_enabled() { }

	// RVA: 0x14560FC
	public bool get_recordFrameMarkers() { }

	// RVA: 0x1456104
	public void set_recordFrameMarkers(bool value) { }

	// RVA: 0x145622C
	public Int64 get_eventCount() { }

	// RVA: 0x1456234
	public Int64 get_totalEventSizeInBytes() { }

	// RVA: 0x145623C
	public Int64 get_allocatedSizeInBytes() { }

	// RVA: 0x145625C
	public Int64 get_maxSizeInBytes() { }

	// RVA: 0x1456264
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos() { }

	// RVA: 0x14562B8
	public System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> get_onFilterEvent() { }

	// RVA: 0x14562C0
	public void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> value) { }

	// RVA: 0x14562C8
	public void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1456324
	public void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1456380
	public void .ctor(InputDevice device, Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x1456458
	public void .ctor(Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x14564F4
	public void WriteTo(string filePath) { }

	// RVA: 0x1456680
	public void WriteTo(Stream stream) { }

	// RVA: 0x1456E5C
	public void ReadFrom(string filePath) { }

	// RVA: 0x1456FE8
	public void ReadFrom(Stream stream) { }

	// RVA: 0x14577D4
	public static InputEventTrace LoadFrom(string filePath) { }

	// RVA: 0x1457994
	public static InputEventTrace LoadFrom(Stream stream) { }

	// RVA: 0x1457AC4
	public ReplayController Replay() { }

	// RVA: 0x1457CD0
	public bool Resize(Int64 newBufferSize, Int64 newMaxBufferSize) { }

	// RVA: 0x1457FC8
	public void Clear() { }

	// RVA: 0x1457FE8
	public void Enable() { }

	// RVA: 0x1457B30
	public void Disable() { }

	// RVA: 0x1457F50
	public bool GetNextEvent(InputEventPtr current) { }

	// RVA: 0x1456DD8
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x14581F0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1458274
	public void Dispose() { }

	// RVA: 0x1456254
	private Byte* get_m_EventBuffer() { }

	// RVA: 0x14577BC
	private void set_m_EventBuffer(Byte* value) { }

	// RVA: 0x1457F48
	private Byte* get_m_EventBufferHead() { }

	// RVA: 0x14577C4
	private void set_m_EventBufferHead(Byte* value) { }

	// RVA: 0x14581A0
	private Byte* get_m_EventBufferTail() { }

	// RVA: 0x14577CC
	private void set_m_EventBufferTail(Byte* value) { }

	// RVA: 0x145816C
	private void Allocate() { }

	// RVA: 0x14582D4
	private void Release() { }

	// RVA: 0x1458330
	private void OnBeforeUpdate() { }

	// RVA: 0x14584EC
	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	// RVA: 0x1456D9C
	private static FourCC get_kFileFormat() { }

	// RVA: 0x1458AF0
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

	// RVA: 0x145571C
	public UInt32 get_stateSizeInBytes() { }

	// RVA: 0x145A958
	public Void* get_state() { }

	// RVA: 0x145A960
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x145A964
	public FourCC get_typeStatic() { }

	// RVA: 0x315B3A8
	public TState GetState() { }

	// RVA: 0x315B3A8
	public static TState GetState(InputEventPtr ptr) { }

	// RVA: 0x30A3FD0
	public static int GetEventSizeWithPayload() { }

	// RVA: 0x14555E8
	public static StateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x145541C
	internal static StateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x145A970
	public static Unity.Collections.NativeArray<System.Byte> From(InputDevice device, InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x145AD90
	public static Unity.Collections.NativeArray<System.Byte> FromDefaultStateFor(InputDevice device, InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x145A978
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

	// RVA: 0x145AD98
	public FourCC get_typeStatic() { }

	// RVA: 0x145ADA4
	public static TextEvent* From(InputEventPtr eventPtr) { }

	// RVA: 0x145AED8
	public static TextEvent Create(int deviceId, Char character, Double time) { }

	// RVA: 0x145AFE8
	public static TextEvent Create(int deviceId, int character, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal sealed class InputUpdateDelegate
{
	// Methods

	// RVA: 0x145B0F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145B19C
	public virtual void Invoke(InputUpdateType updateType, InputEventBuffer eventBuffer) { }

	// RVA: 0x145B1B0
	public virtual IAsyncResult BeginInvoke(InputUpdateType updateType, InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	// RVA: 0x145B29C
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

	// RVA: 0x315B3A8
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

	// RVA: 0x145B2F0
	public int get_maxNumDevices() { }

	// RVA: 0x145B2F8
	public void set_maxNumDevices(int value) { }

	// RVA: 0x145B300
	public int get_currentNumDevices() { }

	// RVA: 0x145B308
	public void set_currentNumDevices(int value) { }

	// RVA: 0x145B310
	public int get_maxStateSizeInBytes() { }

	// RVA: 0x145B318
	public void set_maxStateSizeInBytes(int value) { }

	// RVA: 0x145B320
	public int get_currentStateSizeInBytes() { }

	// RVA: 0x145B328
	public void set_currentStateSizeInBytes(int value) { }

	// RVA: 0x145B330
	public int get_currentControlCount() { }

	// RVA: 0x145B338
	public void set_currentControlCount(int value) { }

	// RVA: 0x145B340
	public int get_currentLayoutCount() { }

	// RVA: 0x145B348
	public void set_currentLayoutCount(int value) { }

	// RVA: 0x145B350
	public int get_totalEventBytes() { }

	// RVA: 0x145B358
	public void set_totalEventBytes(int value) { }

	// RVA: 0x145B360
	public int get_totalEventCount() { }

	// RVA: 0x145B368
	public void set_totalEventCount(int value) { }

	// RVA: 0x145B370
	public int get_totalUpdateCount() { }

	// RVA: 0x145B378
	public void set_totalUpdateCount(int value) { }

	// RVA: 0x145B380
	public Double get_totalEventProcessingTime() { }

	// RVA: 0x145B388
	public void set_totalEventProcessingTime(Double value) { }

	// RVA: 0x145B390
	public Double get_totalEventLagTime() { }

	// RVA: 0x145B398
	public void set_totalEventLagTime(Double value) { }

	// RVA: 0x145B3A0
	public float get_averageEventBytesPerFrame() { }

	// RVA: 0x145B3B8
	public Double get_averageProcessingTimePerEvent() { }

	// RVA: 0x145B3D0
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

	// RVA: 0x145B67C
	public UInt32 get_value() { }

	// RVA: 0x145B684
	private void set_value(UInt32 value) { }

	// RVA: 0x145B474
	public void OnBeforeUpdate() { }

	// RVA: 0x145B520
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

	// RVA: 0x145B3E8
	internal static void OnBeforeUpdate(InputUpdateType type) { }

	// RVA: 0x145B48C
	internal static void OnUpdate(InputUpdateType type) { }

	// RVA: 0x145B544
	public static SerializedState Save() { }

	// RVA: 0x145B5AC
	public static void Restore(SerializedState state) { }

	// RVA: 0x145B654
	public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	// RVA: 0x145B670
	public static bool IsPlayerUpdate(InputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value; // 0x10

	// Methods

	// RVA: 0x145BB84
	public void .ctor() { }

	// RVA: 0x145C500
	internal void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value; // 0x10

	// Methods

	// RVA: 0x145BCD0
	public void .ctor() { }

	// RVA: 0x145C53C
	internal bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public InputUpdateDelegate value; // 0x10

	// Methods

	// RVA: 0x145BA38
	public void .ctor() { }

	// RVA: 0x145C580
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

	// RVA: 0x145B68C
	public int AllocateDeviceId() { }

	// RVA: 0x145B6FC
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x145B784
	public void QueueEvent(InputEvent* ptr) { }

	// RVA: 0x145B810
	public Int64 DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: 0x145B8FC
	public InputUpdateDelegate get_onUpdate() { }

	// RVA: 0x145B904
	public void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: 0x145BA40
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }

	// RVA: 0x145BA48
	public void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }

	// RVA: 0x145BB8C
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }

	// RVA: 0x145BB94
	public void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }

	// RVA: 0x145BCD8
	public System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x145BD48
	public void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x145BDD0
	public Action get_onShutdown() { }

	// RVA: 0x145BDD8
	public void set_onShutdown(Action value) { }

	// RVA: 0x145BEF4
	public System.Action<System.Boolean> get_onPlayerFocusChanged() { }

	// RVA: 0x145BEFC
	public void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x145C018
	public bool get_isPlayerFocused() { }

	// RVA: 0x145C088
	public float get_pollingFrequency() { }

	// RVA: 0x145C090
	public void set_pollingFrequency(float value) { }

	// RVA: 0x145C104
	public Double get_currentTime() { }

	// RVA: 0x145C174
	public Double get_currentTimeForFixedUpdate() { }

	// RVA: 0x145C1E8
	public Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x145C258
	public float get_unscaledGameTime() { }

	// RVA: 0x145C260
	public bool get_runInBackground() { }

	// RVA: 0x145C300
	public void set_runInBackground(bool value) { }

	// RVA: 0x145C308
	private void OnShutdown() { }

	// RVA: 0x145C330
	private bool OnWantsToShutdown() { }

	// RVA: 0x145C38C
	private void OnFocusChanged(bool focus) { }

	// RVA: 0x145C3C8
	public Vector2 get_screenSize() { }

	// RVA: 0x145C3FC
	public ScreenOrientation get_screenOrientation() { }

	// RVA: 0x145C404
	public bool get_isInBatchMode() { }

	// RVA: 0x145C474
	public void RegisterAnalyticsEvent(string name, int maxPerHour, int maxPropertiesPerEvent) { }

	// RVA: 0x145C478
	public void SendAnalyticsEvent(string name, object data) { }

	// RVA: 0x145C47C
	public void .ctor() { }

	// RVA: 0x145C48C
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

	// RVA: 0x145D42C
	public void NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x145D478
	public void NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x145D164
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public static class InputState
{
	// Methods

	// RVA: 0x145C790
	public static InputUpdateType get_currentUpdateType() { }

	// RVA: 0x145C7DC
	public static UInt32 get_updateCount() { }

	// RVA: 0x145C828
	public static Double get_currentTime() { }

	// RVA: 0x145C8FC
	public static void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x145C98C
	public static void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x145CA1C
	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType) { }

	// RVA: 0x315B3A8
	public static void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x315B3A8
	public static void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x145CCA4
	public static bool IsIntegerFormat(FourCC format) { }

	// RVA: 0x145CEF4
	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x145D064
	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback, int monitorIndex, System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback) { }

	// RVA: 0x145D16C
	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x145D264
	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x145D358
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

	// RVA: 0x145D4C0
	public static int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	// RVA: 0x145D91C
	public static FourCC GetPrimitiveFormatFromType(Type type) { }

	// RVA: 0x145DF9C
	public FourCC get_format() { }

	// RVA: 0x145DFA4
	public void set_format(FourCC value) { }

	// RVA: 0x145DFAC
	public UInt32 get_byteOffset() { }

	// RVA: 0x145DFB4
	public void set_byteOffset(UInt32 value) { }

	// RVA: 0x145DFBC
	public UInt32 get_bitOffset() { }

	// RVA: 0x145DFC4
	public void set_bitOffset(UInt32 value) { }

	// RVA: 0x145DFCC
	public UInt32 get_sizeInBits() { }

	// RVA: 0x145DFD4
	public void set_sizeInBits(UInt32 value) { }

	// RVA: 0x14529D8
	internal UInt32 get_alignedSizeInBytes() { }

	// RVA: 0x145DFDC
	internal UInt32 get_effectiveByteOffset() { }

	// RVA: 0x145E064
	internal UInt32 get_effectiveBitOffset() { }

	// RVA: 0x145E0EC
	public int ReadInt(Void* statePtr) { }

	// RVA: 0x145E424
	public void WriteInt(Void* statePtr, int value) { }

	// RVA: 0x145E734
	public float ReadFloat(Void* statePtr) { }

	// RVA: 0x145EBD8
	public void WriteFloat(Void* statePtr, float value) { }

	// RVA: 0x145F1AC
	internal PrimitiveValue FloatToPrimitiveValue(float value) { }

	// RVA: 0x145F7B0
	public Double ReadDouble(Void* statePtr) { }

	// RVA: 0x145FC64
	public void WriteDouble(Void* statePtr, Double value) { }

	// RVA: 0x1460250
	public void Write(Void* statePtr, PrimitiveValue value) { }

	// RVA: 0x146066C
	public void CopyToFrom(Void* toStatePtr, Void* fromStatePtr) { }

	// RVA: 0x14607D8
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
internal struct DoubleBuffers
{
	// Fields
	public Void** deviceToBufferMapping; // 0x10

	// Methods

	// RVA: 0x146174C
	public bool get_valid() { }

	// RVA: 0x1461020
	public void SetFrontBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x1461030
	public void SetBackBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x1460D24
	public Void* GetFrontBuffer(int deviceIndex) { }

	// RVA: 0x1460D98
	public Void* GetBackBuffer(int deviceIndex) { }

	// RVA: 0x146175C
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

	// RVA: 0x1460BEC
	public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	// RVA: 0x1460CC4
	public static Void* GetFrontBufferForDevice(int deviceIndex) { }

	// RVA: 0x1460D34
	public static Void* GetBackBufferForDevice(int deviceIndex) { }

	// RVA: 0x1460DAC
	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

	// RVA: 0x1460E14
	public void AllocateAll(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x1460FC4
	private static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, Byte* bufferPtr, UInt32 sizePerBuffer, UInt32 mappingTableSizePerBuffer) { }

	// RVA: 0x1461044
	public void FreeAll() { }

	// RVA: 0x1461144
	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	// RVA: 0x14612CC
	private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) { }

	// RVA: 0x14614A8
	private static void MigrateSingleBuffer(Void* newBuffer, InputDevice[] devices, int deviceCount, Void* oldBuffer) { }

	// RVA: 0x1460F48
	private static UInt32 ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x14615FC
	private static UInt32 NextDeviceOffset(UInt32 currentOffset, InputDevice device) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly InputStateHistory m_History; // 0x10
	private int m_Index; // 0x18

	// Methods

	// RVA: 0x146353C
	public void .ctor(InputStateHistory history) { }

	// RVA: 0x1463CF8
	public bool MoveNext() { }

	// RVA: 0x1463D34
	public void Reset() { }

	// RVA: 0x1463D40
	public Record get_Current() { }

	// RVA: 0x1463D64
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1463DD4
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

	// RVA: 0x14634B4
	public Byte* get_statePtrWithControlIndex() { }

	// RVA: 0x14634AC
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

	// RVA: 0x1463DD8
	internal RecordHeader* get_header() { }

	// RVA: 0x1463E00
	internal int get_recordIndex() { }

	// RVA: 0x1463E0C
	internal UInt32 get_version() { }

	// RVA: 0x1463E14
	public bool get_valid() { }

	// RVA: 0x1463E70
	public InputStateHistory get_owner() { }

	// RVA: 0x1463E78
	public int get_index() { }

	// RVA: 0x1463F74
	public Double get_time() { }

	// RVA: 0x1463FB4
	public InputControl get_control() { }

	// RVA: 0x14640D0
	public Record get_next() { }

	// RVA: 0x146419C
	public Record get_previous() { }

	// RVA: 0x1461F08
	internal void .ctor(InputStateHistory owner, int index, RecordHeader* header) { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x1464260
	public object ReadValueAsObject() { }

	// RVA: 0x14642A4
	public Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x14642C8
	internal Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x14643B8
	public Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x14643DC
	internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x14620AC
	public void CopyFrom(Record record) { }

	// RVA: 0x1463EC0
	internal void CheckValid() { }

	// RVA: 0x14644C0
	public bool Equals(Record other) { }

	// RVA: 0x14644F4
	public override bool Equals(object obj) { }

	// RVA: 0x14645A4
	public override int GetHashCode() { }

	// RVA: 0x14645F8
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

	// RVA: 0x146178C
	public int get_Count() { }

	// RVA: 0x1461794
	public UInt32 get_version() { }

	// RVA: 0x146179C
	public int get_historyDepth() { }

	// RVA: 0x14617A4
	public void set_historyDepth(int value) { }

	// RVA: 0x146188C
	public int get_extraMemoryPerRecord() { }

	// RVA: 0x1461894
	public void set_extraMemoryPerRecord(int value) { }

	// RVA: 0x146197C
	public InputUpdateType get_updateMask() { }

	// RVA: 0x1461AF0
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x1461BC8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x1461C3C
	public Record get_Item(int index) { }

	// RVA: 0x1461F54
	public void set_Item(int index, Record value) { }

	// RVA: 0x14624D0
	public System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded() { }

	// RVA: 0x14624D8
	public void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value) { }

	// RVA: 0x14624E0
	public System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> get_onShouldRecordStateChange() { }

	// RVA: 0x14624E8
	public void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x14624F0
	public void .ctor(int maxStateSizeInBytes) { }

	// RVA: 0x1462598
	public void .ctor(string path) { }

	// RVA: 0x1462700
	public void .ctor(InputControl control) { }

	// RVA: 0x146281C
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls) { }

	// RVA: 0x14628B8
	protected override void Finalize() { }

	// RVA: 0x1462A48
	public void Clear() { }

	// RVA: 0x1462A5C
	public Record AddRecord(Record record) { }

	// RVA: 0x1462C04
	public void StartRecording() { }

	// RVA: 0x1462DA0
	public void StopRecording() { }

	// RVA: 0x1462F38
	public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1463140
	public Record RecordStateChange(InputControl control, Void* statePtr, Double time) { }

	// RVA: 0x14634BC
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator() { }

	// RVA: 0x1463568
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1462948
	public void Dispose() { }

	// RVA: 0x14635E8
	protected void Destroy() { }

	// RVA: 0x1463650
	private void Allocate() { }

	// RVA: 0x14639A8
	protected internal int RecordIndexToUserIndex(int index) { }

	// RVA: 0x1461D70
	protected internal int UserIndexToRecordIndex(int index) { }

	// RVA: 0x1461D88
	protected internal RecordHeader* GetRecord(int index) { }

	// RVA: 0x14639C4
	internal RecordHeader* GetRecordUnchecked(int index) { }

	// RVA: 0x1462AEC
	protected internal RecordHeader* AllocateRecord(int index) { }

	// RVA: 0x315B3A8
	protected TValue ReadValue(RecordHeader* data) { }

	// RVA: 0x1463A78
	protected object ReadValueAsObject(RecordHeader* data) { }

	// RVA: 0x1463C10
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x1463CF4
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1463954
	internal int get_bytesPerRecord() { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history) { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public Record get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
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

	// RVA: 0x315B3A8
	internal RecordHeader* get_header() { }

	// RVA: 0x30A14A4
	internal int get_recordIndex() { }

	// RVA: 0x30A1224
	public bool get_valid() { }

	// RVA: 0x30A17DC
	public UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner() { }

	// RVA: 0x30A14A4
	public int get_index() { }

	// RVA: -1
	public Double get_time() { }

	// RVA: 0x30A17DC
	public UnityEngine.InputSystem.InputControl<TValue> get_control() { }

	// RVA: 0x315B3A8
	public Record get_next() { }

	// RVA: 0x315B3A8
	public Record get_previous() { }

	// RVA: 0x315B3A8
	internal void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, RecordHeader* header) { }

	// RVA: 0x30A2828
	internal void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index) { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x315B3A8
	public Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x315B3A8
	internal Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x315B3A8
	public Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x315B3A8
	internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x315B3A8
	public void CopyFrom(Record record) { }

	// RVA: 0x30A2378
	private void CheckValid() { }

	// RVA: 0x315B3A8
	public bool Equals(Record other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x30A17DC
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public class InputStateHistory<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(System.Nullable<System.Int32> maxStateSizeInBytes) { }

	// RVA: 0x30A27C0
	public void .ctor(UnityEngine.InputSystem.InputControl<TValue> control) { }

	// RVA: 0x30A27C0
	public void .ctor(string path) { }

	// RVA: 0x30A2378
	protected override void Finalize() { }

	// RVA: 0x315B3A8
	public Record AddRecord(Record record) { }

	// RVA: 0x315B3A8
	public Record RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public Record get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, Record value) { }

}

// Namespace: 
private class Select
{
	// Fields
	private UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x30A2378
	public void OnCompleted() { }

	// RVA: 0x30A27C0
	public void OnError(Exception error) { }

	// RVA: 0x315B3A8
	public void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal class SelectObservable<T0, T1>
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,TResult> m_Filter; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x30A188C
	public IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class AxisDeadzoneProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x1464744
	private float get_minOrDefault() { }

	// RVA: 0x14647B8
	private float get_maxOrDefault() { }

	// RVA: 0x146482C
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1464940
	public override string ToString() { }

	// RVA: 0x1464AB0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ClampProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x1464B04
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1464B1C
	public override string ToString() { }

	// RVA: 0x1464BC4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateDirectionProcessor
{
	// Methods

	// RVA: 0x1464C18
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x1464E44
	public override string ToString() { }

	// RVA: 0x1464E88
	public override CachingPolicy get_cachingPolicy() { }

	// RVA: 0x1464E90
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateRotationProcessor
{
	// Methods

	// RVA: 0x1464EE4
	public override Quaternion Process(Quaternion value, InputControl control) { }

	// RVA: 0x1465130
	public override string ToString() { }

	// RVA: 0x1465174
	public override CachingPolicy get_cachingPolicy() { }

	// RVA: 0x146517C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertProcessor
{
	// Methods

	// RVA: 0x14651D0
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14651D8
	public override string ToString() { }

	// RVA: 0x146521C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertVector2Processor
{
	// Fields
	public bool invertX; // 0x10
	public bool invertY; // 0x11

	// Methods

	// RVA: 0x1465270
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x1465294
	public override string ToString() { }

	// RVA: 0x146533C
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

	// RVA: 0x1465398
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14653CC
	public override string ToString() { }

	// RVA: 0x1465498
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

	// RVA: 0x14654FC
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14655EC
	public static float Normalize(float value, float min, float max, float zero) { }

	// RVA: 0x14656DC
	internal static float Denormalize(float value, float min, float max, float zero) { }

	// RVA: 0x1465720
	public override string ToString() { }

	// RVA: 0x14657EC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector2Processor
{
	// Methods

	// RVA: 0x1465840
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x1465928
	public override string ToString() { }

	// RVA: 0x146596C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector3Processor
{
	// Methods

	// RVA: 0x14659C0
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x1465AC8
	public override string ToString() { }

	// RVA: 0x1465B0C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleProcessor
{
	// Fields
	public float factor; // 0x10

	// Methods

	// RVA: 0x1465B60
	public override float Process(float value, InputControl control) { }

	// RVA: 0x1465B6C
	public override string ToString() { }

	// RVA: 0x1465BF8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleVector2Processor
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14

	// Methods

	// RVA: 0x1465C54
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x1465C64
	public override string ToString() { }

	// RVA: 0x1465D0C
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

	// RVA: 0x1465D68
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x1465D80
	public override string ToString() { }

	// RVA: 0x1465E4C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class StickDeadzoneProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x1465EB0
	private float get_minOrDefault() { }

	// RVA: 0x1465F24
	private float get_maxOrDefault() { }

	// RVA: 0x1465F98
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x1466094
	private float GetDeadZoneAdjustedValue(float value) { }

	// RVA: 0x14661A8
	public override string ToString() { }

	// RVA: 0x1466318
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

	// RVA: 0x146636C
	public string get_layout() { }

	// RVA: 0x1466374
	public void set_layout(string value) { }

	// RVA: 0x146637C
	public string get_variants() { }

	// RVA: 0x1466384
	public void set_variants(string value) { }

	// RVA: 0x146638C
	public string get_name() { }

	// RVA: 0x1466394
	public void set_name(string value) { }

	// RVA: 0x146639C
	public string get_format() { }

	// RVA: 0x14663A4
	public void set_format(string value) { }

	// RVA: 0x14663AC
	public string get_usage() { }

	// RVA: 0x14663B4
	public void set_usage(string value) { }

	// RVA: 0x14663BC
	public string[] get_usages() { }

	// RVA: 0x14663C4
	public void set_usages(string[] value) { }

	// RVA: 0x14663CC
	public string get_parameters() { }

	// RVA: 0x14663D4
	public void set_parameters(string value) { }

	// RVA: 0x14663DC
	public string get_processors() { }

	// RVA: 0x14663E4
	public void set_processors(string value) { }

	// RVA: 0x14663EC
	public string get_alias() { }

	// RVA: 0x14663F4
	public void set_alias(string value) { }

	// RVA: 0x14663FC
	public string[] get_aliases() { }

	// RVA: 0x1466404
	public void set_aliases(string[] value) { }

	// RVA: 0x146640C
	public string get_useStateFrom() { }

	// RVA: 0x1466414
	public void set_useStateFrom(string value) { }

	// RVA: 0x146641C
	public UInt32 get_bit() { }

	// RVA: 0x1466424
	public void set_bit(UInt32 value) { }

	// RVA: 0x146642C
	public UInt32 get_offset() { }

	// RVA: 0x1466434
	public void set_offset(UInt32 value) { }

	// RVA: 0x146643C
	public UInt32 get_sizeInBits() { }

	// RVA: 0x1466444
	public void set_sizeInBits(UInt32 value) { }

	// RVA: 0x146644C
	public int get_arraySize() { }

	// RVA: 0x1466454
	public void set_arraySize(int value) { }

	// RVA: 0x146645C
	public string get_displayName() { }

	// RVA: 0x1466464
	public void set_displayName(string value) { }

	// RVA: 0x146646C
	public string get_shortDisplayName() { }

	// RVA: 0x1466474
	public void set_shortDisplayName(string value) { }

	// RVA: 0x146647C
	public bool get_noisy() { }

	// RVA: 0x1466484
	public void set_noisy(bool value) { }

	// RVA: 0x146648C
	public bool get_synthetic() { }

	// RVA: 0x1466494
	public void set_synthetic(bool value) { }

	// RVA: 0x146649C
	public bool get_dontReset() { }

	// RVA: 0x14664A4
	public void set_dontReset(bool value) { }

	// RVA: 0x14664AC
	public object get_defaultState() { }

	// RVA: 0x14664B4
	public void set_defaultState(object value) { }

	// RVA: 0x14664BC
	public object get_minValue() { }

	// RVA: 0x14664C4
	public void set_minValue(object value) { }

	// RVA: 0x14664CC
	public object get_maxValue() { }

	// RVA: 0x14664D4
	public void set_maxValue(object value) { }

	// RVA: 0x14664DC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public sealed class InputDeviceFindControlLayoutDelegate
{
	// Methods

	// RVA: 0x14664EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14665A8
	public virtual string Invoke(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x14665BC
	public virtual IAsyncResult BeginInvoke(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	// RVA: 0x146668C
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

	// RVA: 0x146C064
	public InternedString get_name() { }

	// RVA: 0x146C070
	internal void set_name(InternedString value) { }

	// RVA: 0x146C07C
	public InternedString get_layout() { }

	// RVA: 0x146C088
	internal void set_layout(InternedString value) { }

	// RVA: 0x146C094
	public InternedString get_variants() { }

	// RVA: 0x146C0A0
	internal void set_variants(InternedString value) { }

	// RVA: 0x146C0AC
	public string get_useStateFrom() { }

	// RVA: 0x146C0B4
	internal void set_useStateFrom(string value) { }

	// RVA: 0x146C0BC
	public string get_displayName() { }

	// RVA: 0x146C0C4
	internal void set_displayName(string value) { }

	// RVA: 0x146C0CC
	public string get_shortDisplayName() { }

	// RVA: 0x146C0D4
	internal void set_shortDisplayName(string value) { }

	// RVA: 0x146C0DC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x146C0E8
	internal void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x146C0F4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x146C100
	internal void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x146C10C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x146C118
	internal void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x146C124
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors() { }

	// RVA: 0x146C130
	internal void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value) { }

	// RVA: 0x146C13C
	public UInt32 get_offset() { }

	// RVA: 0x146C144
	internal void set_offset(UInt32 value) { }

	// RVA: 0x146C14C
	public UInt32 get_bit() { }

	// RVA: 0x146C154
	internal void set_bit(UInt32 value) { }

	// RVA: 0x146C15C
	public UInt32 get_sizeInBits() { }

	// RVA: 0x146C164
	internal void set_sizeInBits(UInt32 value) { }

	// RVA: 0x146C16C
	public FourCC get_format() { }

	// RVA: 0x146C174
	internal void set_format(FourCC value) { }

	// RVA: 0x146C17C
	private Flags get_flags() { }

	// RVA: 0x146C184
	private void set_flags(Flags value) { }

	// RVA: 0x146C18C
	public int get_arraySize() { }

	// RVA: 0x146C194
	internal void set_arraySize(int value) { }

	// RVA: 0x146C19C
	public PrimitiveValue get_defaultState() { }

	// RVA: 0x146C1A8
	internal void set_defaultState(PrimitiveValue value) { }

	// RVA: 0x146C1B0
	public PrimitiveValue get_minValue() { }

	// RVA: 0x146C1BC
	internal void set_minValue(PrimitiveValue value) { }

	// RVA: 0x146C1C4
	public PrimitiveValue get_maxValue() { }

	// RVA: 0x146C1D0
	internal void set_maxValue(PrimitiveValue value) { }

	// RVA: 0x146C1D8
	public bool get_isModifyingExistingControl() { }

	// RVA: 0x146C1E4
	internal void set_isModifyingExistingControl(bool value) { }

	// RVA: 0x146C1F8
	public bool get_isNoisy() { }

	// RVA: 0x146C204
	internal void set_isNoisy(bool value) { }

	// RVA: 0x146C224
	public bool get_isSynthetic() { }

	// RVA: 0x146C230
	internal void set_isSynthetic(bool value) { }

	// RVA: 0x146C250
	public bool get_dontReset() { }

	// RVA: 0x146C25C
	internal void set_dontReset(bool value) { }

	// RVA: 0x146C27C
	public bool get_isFirstDefinedInThisLayout() { }

	// RVA: 0x146C288
	internal void set_isFirstDefinedInThisLayout(bool value) { }

	// RVA: 0x146C2A8
	public bool get_isArray() { }

	// RVA: 0x146C2B8
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

	// RVA: 0x146D790
	private static void .cctor() { }

	// RVA: 0x146D7FC
	public void .ctor() { }

	// RVA: 0x146D804
	internal InternedString <WithUsages>b__14_0(string x) { }

}

// Namespace: 
public struct ControlBuilder
{
	// Fields
	internal Builder builder; // 0x10
	internal int index; // 0x18

	// Methods

	// RVA: 0x146CD04
	public ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x146CD5C
	public ControlBuilder WithLayout(string layout) { }

	// RVA: 0x146CE50
	public ControlBuilder WithFormat(FourCC format) { }

	// RVA: 0x146CE9C
	public ControlBuilder WithFormat(string format) { }

	// RVA: 0x146CF0C
	public ControlBuilder WithByteOffset(UInt32 offset) { }

	// RVA: 0x146CF58
	public ControlBuilder WithBitOffset(UInt32 bit) { }

	// RVA: 0x146CFA4
	public ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x146D008
	public ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x146D06C
	public ControlBuilder DontReset(bool value) { }

	// RVA: 0x146D0D0
	public ControlBuilder WithSizeInBits(UInt32 sizeInBits) { }

	// RVA: 0x146D11C
	public ControlBuilder WithRange(float minValue, float maxValue) { }

	// RVA: 0x146D1C4
	public ControlBuilder WithUsages(InternedString[] usages) { }

	// RVA: 0x146D398
	public ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<System.String> usages) { }

	// RVA: 0x146D4D0
	public ControlBuilder WithUsages(string[] usages) { }

	// RVA: 0x146D4D4
	public ControlBuilder WithParameters(string parameters) { }

	// RVA: 0x146D5A0
	public ControlBuilder WithProcessors(string processors) { }

	// RVA: 0x146D688
	public ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x146D6D4
	public ControlBuilder UsingStateFrom(string path) { }

	// RVA: 0x146D744
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

	// RVA: 0x146C724
	public string get_name() { }

	// RVA: 0x146C72C
	public void set_name(string value) { }

	// RVA: 0x146C734
	public string get_displayName() { }

	// RVA: 0x146C73C
	public void set_displayName(string value) { }

	// RVA: 0x146C744
	public Type get_type() { }

	// RVA: 0x146C74C
	public void set_type(Type value) { }

	// RVA: 0x146C754
	public FourCC get_stateFormat() { }

	// RVA: 0x146C75C
	public void set_stateFormat(FourCC value) { }

	// RVA: 0x146C764
	public int get_stateSizeInBytes() { }

	// RVA: 0x146C76C
	public void set_stateSizeInBytes(int value) { }

	// RVA: 0x146C774
	public string get_extendsLayout() { }

	// RVA: 0x146C77C
	public void set_extendsLayout(string value) { }

	// RVA: 0x146C7B8
	public System.Nullable<System.Boolean> get_updateBeforeRender() { }

	// RVA: 0x146C7C0
	public void set_updateBeforeRender(System.Nullable<System.Boolean> value) { }

	// RVA: 0x146C7C8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x146C83C
	public ControlBuilder AddControl(string name) { }

	// RVA: 0x146C9D4
	public Builder WithName(string name) { }

	// RVA: 0x146C9FC
	public Builder WithDisplayName(string displayName) { }

	// RVA: 0x30A17DC
	public Builder WithType() { }

	// RVA: 0x146CA24
	public Builder WithFormat(FourCC format) { }

	// RVA: 0x146CA2C
	public Builder WithFormat(string format) { }

	// RVA: 0x146CA6C
	public Builder WithSizeInBytes(int sizeInBytes) { }

	// RVA: 0x146CA74
	public Builder Extend(string baseLayoutName) { }

	// RVA: 0x146CAB8
	public InputControlLayout Build() { }

	// RVA: 0x146CCFC
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

	// RVA: 0x146F4E8
	private static void .cctor() { }

	// RVA: 0x146F554
	public void .ctor() { }

	// RVA: 0x146F55C
	internal InternedString <ToLayout>b__14_0(string x) { }

	// RVA: 0x146F588
	internal string <FromLayout>b__15_0(InternedString x) { }

	// RVA: 0x146F5B0
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

	// RVA: 0x146D830
	public InputControlLayout ToLayout() { }

	// RVA: 0x146E908
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

	// RVA: 0x146F604
	private static void .cctor() { }

	// RVA: 0x146F670
	public void .ctor() { }

	// RVA: 0x146F678
	internal InternedString <ToLayout>b__24_0(string x) { }

	// RVA: 0x146F6A4
	internal InternedString <ToLayout>b__24_1(string x) { }

	// RVA: 0x146F6D0
	internal string <FromControlItems>b__25_0(NamedValue x) { }

	// RVA: 0x146F6DC
	internal string <FromControlItems>b__25_1(NameAndParameters x) { }

	// RVA: 0x146F6E8
	internal string <FromControlItems>b__25_2(InternedString x) { }

	// RVA: 0x146F710
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

	// RVA: 0x146F5D8
	public void .ctor() { }

	// RVA: 0x146E22C
	public ControlItem ToLayout() { }

	// RVA: 0x146ED74
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

	// RVA: 0x14716F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x1471A1C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1471A20
	private bool MoveNext() { }

	// RVA: 0x1471B28
	private InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current() { }

	// RVA: 0x1471B34
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1471B74
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1471BDC
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator() { }

	// RVA: 0x1471CAC
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

	// RVA: 0x146F738
	public void Allocate() { }

	// RVA: 0x146F9E4
	public InternedString TryFindLayoutForType(Type layoutType) { }

	// RVA: 0x146FD48
	public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x147054C
	public bool HasLayout(InternedString name) { }

	// RVA: 0x1470654
	private InputControlLayout TryLoadLayoutInternal(InternedString name) { }

	// RVA: 0x1470878
	public InputControlLayout TryLoadLayout(InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table) { }

	// RVA: 0x1470D00
	public InternedString GetBaseLayoutName(InternedString layoutName) { }

	// RVA: 0x1470D90
	public InternedString GetRootLayoutName(InternedString layoutName) { }

	// RVA: 0x1470E28
	public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, int distance) { }

	// RVA: 0x1471014
	public InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache) { }

	// RVA: 0x1471314
	public Type GetControlTypeForLayout(InternedString layoutName) { }

	// RVA: 0x1471478
	public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType) { }

	// RVA: 0x14715B8
	public bool IsGeneratedLayout(InternedString layout) { }

	// RVA: 0x1471630
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(InternedString layout, bool includeSelf) { }

	// RVA: 0x1471728
	public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) { }

	// RVA: 0x14717E0
	public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) { }

}

// Namespace: 
public class LayoutNotFoundException
{
	// Fields
	private readonly string <layout>k__BackingField; // 0x90

	// Methods

	// RVA: 0x1471CB0
	public string get_layout() { }

	// RVA: 0x1471CB8
	public void .ctor() { }

	// RVA: 0x1471D40
	public void .ctor(string name, string message) { }

	// RVA: 0x1470C3C
	public void .ctor(string name) { }

	// RVA: 0x1471DC8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1471E44
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
internal struct Cache
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table; // 0x10

	// Methods

	// RVA: 0x1471EC8
	public void Clear() { }

	// RVA: 0x14711D0
	public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound) { }

}

// Namespace: 
internal struct CacheRefInstance
{
	// Fields
	public bool valid; // 0x10

	// Methods

	// RVA: 0x1471ED4
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

	// RVA: 0x1471F8C
	private static void .cctor() { }

	// RVA: 0x1471FF8
	public void .ctor() { }

	// RVA: 0x1472000
	internal InternedString <FromType>b__52_0(string x) { }

	// RVA: 0x147202C
	internal InternedString <CreateControlItemFromMember>b__75_0(string x) { }

	// RVA: 0x1472058
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

	// RVA: 0x14666E0
	public static InternedString get_DefaultVariant() { }

	// RVA: 0x146675C
	public InternedString get_name() { }

	// RVA: 0x1466768
	public string get_displayName() { }

	// RVA: 0x1466788
	public Type get_type() { }

	// RVA: 0x1466790
	public InternedString get_variants() { }

	// RVA: 0x146679C
	public FourCC get_stateFormat() { }

	// RVA: 0x14667A4
	public int get_stateSizeInBytes() { }

	// RVA: 0x14667AC
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts() { }

	// RVA: 0x1466818
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides() { }

	// RVA: 0x1466884
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages() { }

	// RVA: 0x14668F0
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x146695C
	public bool get_updateBeforeRender() { }

	// RVA: 0x1466A34
	public bool get_isDeviceLayout() { }

	// RVA: 0x1466AEC
	public bool get_isControlLayout() { }

	// RVA: 0x1466BAC
	public bool get_isOverride() { }

	// RVA: 0x1466BB8
	internal void set_isOverride(bool value) { }

	// RVA: 0x1466BD8
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x1466BE4
	internal void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x1466BF8
	public bool get_hideInUI() { }

	// RVA: 0x1466C04
	internal void set_hideInUI(bool value) { }

	// RVA: 0x1466C24
	public bool get_isNoisy() { }

	// RVA: 0x1466C30
	internal void set_isNoisy(bool value) { }

	// RVA: 0x1466C50
	public System.Nullable<System.Boolean> get_canRunInBackground() { }

	// RVA: 0x1466CD8
	internal void set_canRunInBackground(System.Nullable<System.Boolean> value) { }

	// RVA: 0x1466DCC
	public ControlItem get_Item(string path) { }

	// RVA: 0x1466F74
	public System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(InternedString path) { }

	// RVA: 0x146717C
	public System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, int arrayIndex) { }

	// RVA: 0x14675A8
	public Type GetValueType() { }

	// RVA: 0x146763C
	public static InputControlLayout FromType(string name, Type type) { }

	// RVA: 0x1458A44
	public string ToJson() { }

	// RVA: 0x1467D04
	public static InputControlLayout FromJson(string json) { }

	// RVA: 0x1467C90
	private void .ctor(string name, Type type) { }

	// RVA: 0x1467B4C
	private static void AddControlItems(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x1467DAC
	private static void AddControlItemsFromFields(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x1467E40
	private static void AddControlItemsFromProperties(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x1467ED4
	private static void AddControlItemsFromMembers(MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName) { }

	// RVA: 0x146846C
	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems) { }

	// RVA: 0x14686A0
	private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	// RVA: 0x146901C
	private static string InferLayoutFromValueType(Type type) { }

	// RVA: 0x14691F8
	public void MergeLayout(InputControlLayout other) { }

	// RVA: 0x146B5CC
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, System.Collections.Generic.List<System.String> variants) { }

	// RVA: 0x146BBDC
	internal static bool VariantsMatch(InternedString expected, InternedString actual) { }

	// RVA: 0x146BA8C
	internal static bool VariantsMatch(string expected, string actual) { }

	// RVA: 0x146BC68
	internal static void ParseHeaderFieldsFromJson(string json, InternedString name, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>& baseLayouts, InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x146BE04
	internal static Cache get_cache() { }

	// RVA: 0x146BE80
	internal static CacheRefInstance CacheRef() { }

	// RVA: 0x146BEE8
	private static void .cctor() { }

	// RVA: 0x146BF80
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

	// RVA: 0x1472084
	public Type get_stateType() { }

	// RVA: 0x147208C
	public void set_stateType(Type value) { }

	// RVA: 0x1472094
	public string get_stateFormat() { }

	// RVA: 0x147209C
	public void set_stateFormat(string value) { }

	// RVA: 0x14720A4
	public string[] get_commonUsages() { }

	// RVA: 0x14720AC
	public void set_commonUsages(string[] value) { }

	// RVA: 0x14720B4
	public string get_variants() { }

	// RVA: 0x14720BC
	public void set_variants(string value) { }

	// RVA: 0x14720C4
	public bool get_isNoisy() { }

	// RVA: 0x14720CC
	public void set_isNoisy(bool value) { }

	// RVA: 0x14720D4
	public bool get_canRunInBackground() { }

	// RVA: 0x147213C
	public void set_canRunInBackground(bool value) { }

	// RVA: 0x14721B4
	public bool get_updateBeforeRender() { }

	// RVA: 0x147221C
	public void set_updateBeforeRender(bool value) { }

	// RVA: 0x1472294
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x147229C
	public void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x14722A4
	public string get_displayName() { }

	// RVA: 0x14722AC
	public void set_displayName(string value) { }

	// RVA: 0x14722B4
	public string get_description() { }

	// RVA: 0x14722BC
	public void set_description(string value) { }

	// RVA: 0x14722C4
	public bool get_hideInUI() { }

	// RVA: 0x14722CC
	public void set_hideInUI(bool value) { }

	// RVA: 0x14722D4
	public void .ctor() { }

}

// Namespace: 
internal struct RefInstance
{
	// Methods

	// RVA: 0x1476D38
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

	// RVA: 0x14722DC
	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription) { }

	// RVA: 0x14727E8
	public InputDevice Finish() { }

	// RVA: 0x14728DC
	public void Dispose() { }

	// RVA: 0x147280C
	private void Reset() { }

	// RVA: 0x1472484
	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x1472A00
	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x1473218
	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls) { }

	// RVA: 0x1474718
	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem, int childIndex, string nameOverride) { }

	// RVA: 0x1474458
	private void InsertChildControlOverride(InputControl parent, ControlItem controlItem) { }

	// RVA: 0x1475110
	private string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	// RVA: 0x1475054
	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem) { }

	// RVA: 0x14754BC
	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem) { }

	// RVA: 0x147425C
	private static void ApplyUseStateFrom(InputControl parent, ControlItem controlItem, InputControlLayout layout) { }

	// RVA: 0x1475838
	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

	// RVA: 0x14758A4
	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	// RVA: 0x1475B0C
	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	// RVA: 0x147528C
	private static void AddProcessors(InputControl control, ControlItem controlItem, string layoutName) { }

	// RVA: 0x14751A4
	private static void SetFormat(InputControl control, ControlItem controlItem) { }

	// RVA: 0x1472994
	private static InputControlLayout FindOrLoadLayout(string name) { }

	// RVA: 0x147392C
	private static void ComputeStateLayout(InputControl control) { }

	// RVA: 0x1472550
	private void FinalizeControlHierarchy() { }

	// RVA: 0x1475BC8
	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, int controlIndiciesNextFreeIndex) { }

	// RVA: 0x1476014
	private void InsertControlBitRangeNode(ControlBitRangeNode parent, InputControl control, int controlIndiciesNextFreeIndex, UInt16 startOffset) { }

	// RVA: 0x14763D8
	private UInt16 GetBestMidPoint(ControlBitRangeNode parent, UInt16 startOffset) { }

	// RVA: 0x1476A9C
	private void AddControlToNode(InputControl control, int controlIndiciesNextFreeIndex, int nodeIndex) { }

	// RVA: 0x1476978
	private void AddChildren(ControlBitRangeNode parent, ControlBitRangeNode left, ControlBitRangeNode right) { }

	// RVA: 0x1476BE4
	private UInt16 GetControlIndex(InputControl control) { }

	// RVA: 0x1476C98
	internal static InputDeviceBuilder get_instance() { }

	// RVA: 0x1476CE0
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

	// RVA: 0x1476E6C
	public string get_interfaceName() { }

	// RVA: 0x1476E74
	public void set_interfaceName(string value) { }

	// RVA: 0x1476E7C
	public string get_deviceClass() { }

	// RVA: 0x1476E84
	public void set_deviceClass(string value) { }

	// RVA: 0x1476E8C
	public string get_manufacturer() { }

	// RVA: 0x1476E94
	public void set_manufacturer(string value) { }

	// RVA: 0x1476E9C
	public string get_product() { }

	// RVA: 0x1476EA4
	public void set_product(string value) { }

	// RVA: 0x1476EAC
	public string get_serial() { }

	// RVA: 0x1476EB4
	public void set_serial(string value) { }

	// RVA: 0x1476EBC
	public string get_version() { }

	// RVA: 0x1476EC4
	public void set_version(string value) { }

	// RVA: 0x1476ECC
	public string get_capabilities() { }

	// RVA: 0x1476ED4
	public void set_capabilities(string value) { }

	// RVA: 0x1476EDC
	public bool get_empty() { }

	// RVA: 0x1476F70
	public override string ToString() { }

	// RVA: 0x1477228
	public bool Equals(InputDeviceDescription other) { }

	// RVA: 0x14772DC
	public override bool Equals(object obj) { }

	// RVA: 0x147738C
	public override int GetHashCode() { }

	// RVA: 0x14774E4
	public static bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x147751C
	public static bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x1477558
	public string ToJson() { }

	// RVA: 0x1477664
	public static InputDeviceDescription FromJson(string json) { }

	// RVA: 0x14777DC
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

	// RVA: 0x1478DF4
	public static MatcherJson FromMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x14792FC
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

	// RVA: 0x1479A14
	private static void .cctor() { }

	// RVA: 0x1479A80
	public void .ctor() { }

	// RVA: 0x1479A88
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

	// RVA: 0x1477920
	public void .ctor(int <>1__state) { }

	// RVA: 0x1479B54
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1479B58
	private bool MoveNext() { }

	// RVA: 0x1479DC8
	private System.Collections.Generic.KeyValuePair<System.String,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	// RVA: 0x1479DD4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1479E14
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1479E7C
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1479F28
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

	// RVA: 0x1477884
	public bool get_empty() { }

	// RVA: 0x1477894
	public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> get_patterns() { }

	// RVA: 0x1477958
	public InputDeviceMatcher WithInterface(string pattern, bool supportRegex) { }

	// RVA: 0x1477BFC
	public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex) { }

	// RVA: 0x1477C80
	public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex) { }

	// RVA: 0x1477D04
	public InputDeviceMatcher WithProduct(string pattern, bool supportRegex) { }

	// RVA: 0x1477D88
	public InputDeviceMatcher WithVersion(string pattern, bool supportRegex) { }

	// RVA: 0x315B3A8
	public InputDeviceMatcher WithCapability(string path, TValue value) { }

	// RVA: 0x14779DC
	private InputDeviceMatcher With(InternedString key, object value, bool supportRegex) { }

	// RVA: 0x146FF30
	public float MatchPercentage(InputDeviceDescription deviceDescription) { }

	// RVA: 0x1477E0C
	private static bool MatchSingleProperty(object pattern, string value) { }

	// RVA: 0x1477EF8
	private static int GetNumPropertiesIn(InputDeviceDescription description) { }

	// RVA: 0x1477FA0
	public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	// RVA: 0x1478330
	public override string ToString() { }

	// RVA: 0x1478704
	public bool Equals(InputDeviceMatcher other) { }

	// RVA: 0x1478A88
	public override bool Equals(object obj) { }

	// RVA: 0x14719A8
	public static bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x1478B3C
	public static bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x1478C14
	public override int GetHashCode() { }

	// RVA: 0x1478C2C
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class AnyKeyControl
{
	// Methods

	// RVA: 0x1479F2C
	public void .ctor() { }

	// RVA: 0x147A0C8
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

	// RVA: 0x147A0F4
	protected float Preprocess(float value) { }

	// RVA: 0x147A1C4
	private float Unpreprocess(float value) { }

	// RVA: 0x147A21C
	public void .ctor() { }

	// RVA: 0x147A2A8
	protected override void FinishSetup() { }

	// RVA: 0x147A398
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147A530
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x147A674
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x147A780
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x147A7F8
	private float EvaluateMagnitude(float value) { }

	// RVA: 0x147A8D4
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

	// RVA: 0x147AA50
	public float get_pressPointOrDefault() { }

	// RVA: 0x1479FA8
	public void .ctor() { }

	// RVA: 0x147AAC4
	public bool IsValueConsideredPressed(float value) { }

	// RVA: 0x147AB58
	public bool get_isPressed() { }

	// RVA: 0x147AC04
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x147AD60
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

	// RVA: 0x147AEBC
	public AxisControl get_up() { }

	// RVA: 0x147AEC4
	public void set_up(AxisControl value) { }

	// RVA: 0x147AED4
	public AxisControl get_down() { }

	// RVA: 0x147AEDC
	public void set_down(AxisControl value) { }

	// RVA: 0x147AEEC
	public AxisControl get_left() { }

	// RVA: 0x147AEF4
	public void set_left(AxisControl value) { }

	// RVA: 0x147AF04
	public AxisControl get_right() { }

	// RVA: 0x147AF0C
	public void set_right(AxisControl value) { }

	// RVA: 0x147AF1C
	protected override void FinishSetup() { }

	// RVA: 0x147B124
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

	// RVA: 0x147B23C
	protected override void FinishSetup() { }

	// RVA: 0x147B36C
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147B504
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x147B664
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class DoubleControl
{
	// Methods

	// RVA: 0x147B668
	public void .ctor() { }

	// RVA: 0x147B6F4
	public override Double ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147B760
	public override void WriteValueIntoState(Double value, Void* statePtr) { }

}

// Namespace: 
public class DpadAxisControl
{
	// Fields
	private int <component>k__BackingField; // 0x12C

	// Methods

	// RVA: 0x147BF48
	public int get_component() { }

	// RVA: 0x147BF50
	public void set_component(int value) { }

	// RVA: 0x147BF58
	protected override void FinishSetup() { }

	// RVA: 0x147BFE4
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147C0DC
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

	// RVA: 0x147B7DC
	public ButtonControl get_up() { }

	// RVA: 0x147B7E4
	public void set_up(ButtonControl value) { }

	// RVA: 0x147B7F4
	public ButtonControl get_down() { }

	// RVA: 0x147B7FC
	public void set_down(ButtonControl value) { }

	// RVA: 0x147B80C
	public ButtonControl get_left() { }

	// RVA: 0x147B814
	public void set_left(ButtonControl value) { }

	// RVA: 0x147B824
	public ButtonControl get_right() { }

	// RVA: 0x147B82C
	public void set_right(ButtonControl value) { }

	// RVA: 0x147B83C
	public void .ctor() { }

	// RVA: 0x147B93C
	protected override void FinishSetup() { }

	// RVA: 0x147BA6C
	public override Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147BD70
	public override void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x147BD10
	public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize) { }

	// RVA: 0x147BF38
	public static Vector2 MakeDpadVector(float up, float down, float left, float right) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class IntegerControl
{
	// Methods

	// RVA: 0x147C168
	public void .ctor() { }

	// RVA: 0x147C1F4
	public override int ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147C2B8
	public override void WriteValueIntoState(int value, Void* statePtr) { }

	// RVA: 0x147C384
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class KeyControl
{
	// Fields
	private Key <keyCode>k__BackingField; // 0x130
	private int m_ScanCode; // 0x134

	// Methods

	// RVA: 0x147C4A8
	public Key get_keyCode() { }

	// RVA: 0x147C4B0
	public void set_keyCode(Key value) { }

	// RVA: 0x147C4B8
	public int get_scanCode() { }

	// RVA: 0x147C4E0
	protected override void RefreshConfiguration() { }

	// RVA: 0x147C66C
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

	// RVA: 0x147C670
	public AxisControl get_x() { }

	// RVA: 0x147C678
	public void set_x(AxisControl value) { }

	// RVA: 0x147C688
	public AxisControl get_y() { }

	// RVA: 0x147C690
	public void set_y(AxisControl value) { }

	// RVA: 0x147C6A0
	public AxisControl get_z() { }

	// RVA: 0x147C6A8
	public void set_z(AxisControl value) { }

	// RVA: 0x147C6B8
	public AxisControl get_w() { }

	// RVA: 0x147C6C0
	public void set_w(AxisControl value) { }

	// RVA: 0x147C6D0
	public void .ctor() { }

	// RVA: 0x147C764
	protected override void FinishSetup() { }

	// RVA: 0x147C8AC
	public override Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147C9F4
	public override void WriteValueIntoState(Quaternion value, Void* statePtr) { }

	// RVA: 0x147CB30
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

	// RVA: 0x147CDB8
	public ButtonControl get_up() { }

	// RVA: 0x147CDC0
	public void set_up(ButtonControl value) { }

	// RVA: 0x147CDD0
	public ButtonControl get_down() { }

	// RVA: 0x147CDD8
	public void set_down(ButtonControl value) { }

	// RVA: 0x147CDE8
	public ButtonControl get_left() { }

	// RVA: 0x147CDF0
	public void set_left(ButtonControl value) { }

	// RVA: 0x147CE00
	public ButtonControl get_right() { }

	// RVA: 0x147CE08
	public void set_right(ButtonControl value) { }

	// RVA: 0x147CE18
	protected override void FinishSetup() { }

	// RVA: 0x147CF48
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

	// RVA: 0x147CFD4
	public TouchPressControl get_press() { }

	// RVA: 0x147CFDC
	public void set_press(TouchPressControl value) { }

	// RVA: 0x147CFEC
	public IntegerControl get_displayIndex() { }

	// RVA: 0x147CFF4
	public void set_displayIndex(IntegerControl value) { }

	// RVA: 0x147D004
	public IntegerControl get_touchId() { }

	// RVA: 0x147D00C
	public void set_touchId(IntegerControl value) { }

	// RVA: 0x147D01C
	public Vector2Control get_position() { }

	// RVA: 0x147D024
	public void set_position(Vector2Control value) { }

	// RVA: 0x147D034
	public DeltaControl get_delta() { }

	// RVA: 0x147D03C
	public void set_delta(DeltaControl value) { }

	// RVA: 0x147D04C
	public AxisControl get_pressure() { }

	// RVA: 0x147D054
	public void set_pressure(AxisControl value) { }

	// RVA: 0x147D064
	public Vector2Control get_radius() { }

	// RVA: 0x147D06C
	public void set_radius(Vector2Control value) { }

	// RVA: 0x147D07C
	public TouchPhaseControl get_phase() { }

	// RVA: 0x147D084
	public void set_phase(TouchPhaseControl value) { }

	// RVA: 0x147D094
	public ButtonControl get_indirectTouch() { }

	// RVA: 0x147D09C
	public void set_indirectTouch(ButtonControl value) { }

	// RVA: 0x147D0AC
	public ButtonControl get_tap() { }

	// RVA: 0x147D0B4
	public void set_tap(ButtonControl value) { }

	// RVA: 0x147D0C4
	public IntegerControl get_tapCount() { }

	// RVA: 0x147D0CC
	public void set_tapCount(IntegerControl value) { }

	// RVA: 0x147D0DC
	public DoubleControl get_startTime() { }

	// RVA: 0x147D0E4
	public void set_startTime(DoubleControl value) { }

	// RVA: 0x147D0F4
	public Vector2Control get_startPosition() { }

	// RVA: 0x147D0FC
	public void set_startPosition(Vector2Control value) { }

	// RVA: 0x147D10C
	public bool get_isInProgress() { }

	// RVA: 0x147D178
	public void .ctor() { }

	// RVA: 0x147D224
	protected override void FinishSetup() { }

	// RVA: 0x147D5D4
	public override TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147D660
	public override void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPhaseControl
{
	// Methods

	// RVA: 0x147D738
	public void .ctor() { }

	// RVA: 0x147D7C4
	public override TouchPhase ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147D844
	public override void WriteValueIntoState(TouchPhase value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPressControl
{
	// Methods

	// RVA: 0x147D8B8
	protected override void FinishSetup() { }

	// RVA: 0x147D9E8
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147DB74
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x147DBB4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class Vector2Control
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x110
	private AxisControl <y>k__BackingField; // 0x118

	// Methods

	// RVA: 0x147DBB8
	public AxisControl get_x() { }

	// RVA: 0x147DBC0
	public void set_x(AxisControl value) { }

	// RVA: 0x147DBD0
	public AxisControl get_y() { }

	// RVA: 0x147DBD8
	public void set_y(AxisControl value) { }

	// RVA: 0x147B1B0
	public void .ctor() { }

	// RVA: 0x147B04C
	protected override void FinishSetup() { }

	// RVA: 0x147DBE8
	public override Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147DCD0
	public override void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x147DDB4
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x147DE8C
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

	// RVA: 0x147E044
	public AxisControl get_x() { }

	// RVA: 0x147E04C
	public void set_x(AxisControl value) { }

	// RVA: 0x147E05C
	public AxisControl get_y() { }

	// RVA: 0x147E064
	public void set_y(AxisControl value) { }

	// RVA: 0x147E074
	public AxisControl get_z() { }

	// RVA: 0x147E07C
	public void set_z(AxisControl value) { }

	// RVA: 0x147E08C
	public void .ctor() { }

	// RVA: 0x147E118
	protected override void FinishSetup() { }

	// RVA: 0x147E22C
	public override Vector3 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x147E338
	public override void WriteValueIntoState(Vector3 value, Void* statePtr) { }

	// RVA: 0x147E450
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x147E53C
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

	// RVA: 0x147E73C
	private float get_durationOrDefault() { }

	// RVA: 0x147E7B0
	private float get_pressPointOrDefault() { }

	// RVA: 0x147E824
	public void Process(InputInteractionContext context) { }

	// RVA: 0x147EACC
	public void Reset() { }

	// RVA: 0x147EAD4
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

	// RVA: 0x147EADC
	private float get_tapTimeOrDefault() { }

	// RVA: 0x147EB50
	internal float get_tapDelayOrDefault() { }

	// RVA: 0x147EBC4
	private float get_pressPointOrDefault() { }

	// RVA: 0x147EC38
	private float get_releasePointOrDefault() { }

	// RVA: 0x147ED00
	public void Process(InputInteractionContext context) { }

	// RVA: 0x147F1AC
	public void Reset() { }

	// RVA: 0x147F1B8
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

	// RVA: 0x147F1C8
	private float get_pressPointOrDefault() { }

	// RVA: 0x147F23C
	private float get_releasePointOrDefault() { }

	// RVA: 0x147F304
	public void Process(InputInteractionContext context) { }

	// RVA: 0x147F890
	public void Reset() { }

	// RVA: 0x147F898
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

	// RVA: 0x147F8A0
	private float get_durationOrDefault() { }

	// RVA: 0x147F914
	private float get_pressPointOrDefault() { }

	// RVA: 0x147F988
	public void Process(InputInteractionContext context) { }

	// RVA: 0x147FB88
	public void Reset() { }

	// RVA: 0x147FB90
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

	// RVA: 0x147FB98
	private float get_durationOrDefault() { }

	// RVA: 0x147FC0C
	private float get_pressPointOrDefault() { }

	// RVA: 0x147FC80
	private float get_releasePointOrDefault() { }

	// RVA: 0x147FD48
	public void Process(InputInteractionContext context) { }

	// RVA: 0x1480018
	public void Reset() { }

	// RVA: 0x1480020
	public void .ctor() { }

}

// Namespace: 
public struct ActionEventPtr
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal ActionEvent* m_Ptr; // 0x18

	// Methods

	// RVA: 0x13954A8
	public InputAction get_action() { }

	// RVA: 0x13954D4
	public InputActionPhase get_phase() { }

	// RVA: 0x13954E0
	public InputControl get_control() { }

	// RVA: 0x1395524
	public IInputInteraction get_interaction() { }

	// RVA: 0x1395590
	public Double get_time() { }

	// RVA: 0x13955B0
	public Double get_startTime() { }

	// RVA: 0x13955BC
	public Double get_duration() { }

	// RVA: 0x13955F8
	public int get_valueSizeInBytes() { }

	// RVA: 0x1395604
	public object ReadValueAsObject() { }

	// RVA: 0x1395860
	public void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x315B3A8
	public TValue ReadValue() { }

	// RVA: 0x139596C
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

	// RVA: 0x1395D90
	public void .ctor(InputActionTrace trace) { }

	// RVA: 0x1395DE0
	public bool MoveNext() { }

	// RVA: 0x1395E70
	public void Reset() { }

	// RVA: 0x1395E7C
	public void Dispose() { }

	// RVA: 0x1395E80
	public ActionEventPtr get_Current() { }

	// RVA: 0x1395F08
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

	// RVA: 0x1480028
	public InputEventBuffer get_buffer() { }

	// RVA: 0x1480038
	public int get_count() { }

	// RVA: 0x1480040
	public void .ctor() { }

	// RVA: 0x1480048
	public void .ctor(InputAction action) { }

	// RVA: 0x1480208
	public void .ctor(InputActionMap actionMap) { }

	// RVA: 0x14803A8
	public void SubscribeToAll() { }

	// RVA: 0x14807D4
	public void UnsubscribeFromAll() { }

	// RVA: 0x14800C4
	public void SubscribeTo(InputAction action) { }

	// RVA: 0x1480284
	public void SubscribeTo(InputActionMap actionMap) { }

	// RVA: 0x14805AC
	public void UnsubscribeFrom(InputAction action) { }

	// RVA: 0x14806D0
	public void UnsubscribeFrom(InputActionMap actionMap) { }

	// RVA: 0x1480984
	public void RecordAction(CallbackContext context) { }

	// RVA: 0x1480B54
	public void Clear() { }

	// RVA: 0x1480BB4
	protected override void Finalize() { }

	// RVA: 0x1480D64
	public override string ToString() { }

	// RVA: 0x148118C
	public void Dispose() { }

	// RVA: 0x1480C44
	private void DisposeInternal() { }

	// RVA: 0x1481100
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator() { }

	// RVA: 0x14811B0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14804A0
	private void HookOnActionChange() { }

	// RVA: 0x1480914
	private void UnhookOnActionChange() { }

	// RVA: 0x148123C
	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	// RVA: 0x14814B8
	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0<T0>
{
	// Fields
	public TValue secondValue; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal bool <Merge>b__0(TValue x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0<T0>
{
	// Fields
	public System.Collections.Generic.IEqualityComparer<TValue> comparer; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1<T0>
{
	// Fields
	public TValue secondValue; // 0x0
	public UnityEngine.InputSystem.Utilities.ArrayHelpers.<>c__DisplayClass34_0<TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal bool <Merge>b__0(TValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ArrayHelpers
{
	// Methods

	// RVA: 0x30A4388
	public static int LengthSafe(TValue[] array) { }

	// RVA: 0x30A7C50
	public static void Clear(TValue[] array) { }

	// RVA: 0x30A7F58
	public static void Clear(TValue[] array, int count) { }

	// RVA: 0x30A8E44
	public static void Clear(TValue[] array, int count) { }

	// RVA: -1
	public static void EnsureCapacity(TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: -1
	public static void DuplicateWithCapacity(TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: 0x315B3A8
	public static bool Contains(TValue[] array, TValue value) { }

	// RVA: 0x315B3A8
	public static bool ContainsReference(TValue[] array, TValue value) { }

	// RVA: 0x315B3A8
	public static bool ContainsReference(TFirst[] array, int count, TSecond value) { }

	// RVA: 0x315B3A8
	public static bool ContainsReference(TFirst[] array, int startIndex, int count, TSecond value) { }

	// RVA: -1
	public static bool HaveDuplicateReferences(TFirst[] first, int index, int count) { }

	// RVA: 0x30A3C7C
	public static bool HaveEqualElements(TValue[] first, TValue[] second, int count) { }

	// RVA: 0x315B3A8
	public static int IndexOf(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x30A4874
	public static int IndexOf(TValue[] array, System.Predicate<TValue> predicate) { }

	// RVA: 0x30A48DC
	public static int IndexOf(TValue[] array, System.Predicate<TValue> predicate, int startIndex, int count) { }

	// RVA: 0x315B3A8
	public static int IndexOfReference(TFirst[] array, TSecond value, int count) { }

	// RVA: 0x315B3A8
	public static int IndexOfReference(TFirst[] array, TSecond value, int startIndex, int count) { }

	// RVA: 0x315B3A8
	public static int IndexOfValue(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x30A8040
	public static void Resize(Unity.Collections.NativeArray<TValue>& array, int newSize, Allocator allocator) { }

	// RVA: 0x315B3A8
	public static int Append(TValue[] array, TValue value) { }

	// RVA: 0x30A4874
	public static int Append(TValue[] array, System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x30A4874
	public static int AppendToImmutable(TValue[] array, TValue[] values) { }

	// RVA: 0x315B3A8
	public static int AppendWithCapacity(TValue[] array, int count, TValue value, int capacityIncrement) { }

	// RVA: 0x315B3A8
	public static int AppendListWithCapacity(TValue[] array, int length, TValues values, int capacityIncrement) { }

	// RVA: 0x315B3A8
	public static int AppendWithCapacity(Unity.Collections.NativeArray<TValue>& array, int count, TValue value, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x315B3A8
	public static void InsertAt(TValue[] array, int index, TValue value) { }

	// RVA: 0x315B3A8
	public static void InsertAtWithCapacity(TValue[] array, int count, int index, TValue value, int capacityIncrement) { }

	// RVA: 0x30A839C
	public static void PutAtIfNotSet(TValue[] array, int index, System.Func<TValue> valueFn) { }

	// RVA: -1
	public static int GrowBy(TValue[] array, int count) { }

	// RVA: 0x30A43EC
	public static int GrowBy(Unity.Collections.NativeArray<TValue>& array, int count, Allocator allocator) { }

	// RVA: 0x30A48DC
	public static int GrowWithCapacity(TValue[] array, int count, int growBy, int capacityIncrement) { }

	// RVA: -1
	public static int GrowWithCapacity(Unity.Collections.NativeArray<TValue>& array, int count, int growBy, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x315B3A8
	public static TValue[] Join(TValue value, TValue[] values) { }

	// RVA: 0x30A53B0
	public static TValue[] Merge(TValue[] first, TValue[] second) { }

	// RVA: 0x30A550C
	public static TValue[] Merge(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x30A7F58
	public static void EraseAt(TValue[] array, int index) { }

	// RVA: 0x30A900C
	public static void EraseAtWithCapacity(TValue[] array, int count, int index) { }

	// RVA: 0x315B3A8
	public static void EraseAtWithCapacity(Unity.Collections.NativeArray<TValue> array, int count, int index) { }

	// RVA: 0x315B3A8
	public static bool Erase(TValue[] array, TValue value) { }

	// RVA: 0x30A900C
	public static void EraseAtByMovingTail(TValue[] array, int count, int index) { }

	// RVA: 0x30A52D0
	public static TValue[] Copy(TValue[] array) { }

	// RVA: 0x30A52D0
	public static TValue[] Clone(TValue[] array) { }

	// RVA: 0x30A53B0
	public static TNew[] Select(TOld[] array, System.Func<TOld,TNew> converter) { }

	// RVA: 0x30A8E44
	private static void Swap(TValue first, TValue second) { }

	// RVA: -1
	public static void MoveSlice(TValue[] array, int sourceIndex, int destinationIndex, int count) { }

	// RVA: 0x30A9080
	public static void EraseSliceWithCapacity(TValue[] array, int length, int index, int count) { }

	// RVA: 0x30A8040
	public static void SwapElements(TValue[] array, int index1, int index2) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A14A4
	public int get_length() { }

	// RVA: 0x315B3A8
	public TDelegate get_Item(int index) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public void AddCallback(TDelegate dlg) { }

	// RVA: 0x315B3A8
	public void RemoveCallback(TDelegate dlg) { }

	// RVA: 0x30A2378
	public void LockForChanges() { }

	// RVA: 0x30A2378
	public void UnlockForChanges() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector2MagnitudeComparer
{
	// Methods

	// RVA: 0x1395FDC
	public int Compare(Vector2 x, Vector2 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector3MagnitudeComparer
{
	// Methods

	// RVA: 0x1396004
	public int Compare(Vector3 x, Vector3 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class CSharpCodeHelpers
{
	// Methods

	// RVA: 0x139603C
	public static bool IsProperIdentifier(string name) { }

	// RVA: 0x1396170
	public static bool IsEmptyOrProperIdentifier(string name) { }

	// RVA: 0x13961AC
	public static bool IsEmptyOrProperNamespaceName(string name) { }

	// RVA: 0x1396280
	public static string MakeIdentifier(string name, string suffix) { }

	// RVA: 0x139652C
	public static string MakeTypeName(string name, string suffix) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class DelegateHelpers
{
	// Methods

	// RVA: 0x1396658
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>& callbacks, string callbackName, object context) { }

	// RVA: 0x315B3A8
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x315B3A8
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1,TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x315B3A8
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1,TValue2,System.Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x315B3A8
	public static void InvokeCallbacksSafe_AndInvokeReturnedActions(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,System.Action>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x315B3A8
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,TReturn>>& callbacks, TValue argument, string callbackName, object context) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public class DisplayStringFormatAttribute
{
	// Fields
	private string <formatString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1396954
	public string get_formatString() { }

	// RVA: 0x139695C
	public void set_formatString(string value) { }

	// RVA: 0x1396964
	public void .ctor(string formatString) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ExceptionHelpers
{
	// Methods

	// RVA: 0x1396998
	public static bool IsExceptionIndicatingBugInCode(Exception exception) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct FourCC
{
	// Fields
	private int m_Code; // 0x10

	// Methods

	// RVA: 0x1396A94
	public void .ctor(int code) { }

	// RVA: 0x1396A9C
	public void .ctor(Char a, Char b, Char c, Char d) { }

	// RVA: 0x1396AB4
	public void .ctor(string str) { }

	// RVA: 0x1396C34
	public static int op_Implicit(FourCC fourCC) { }

	// RVA: 0x1396C38
	public static FourCC op_Implicit(int i) { }

	// RVA: 0x1396C3C
	public override string ToString() { }

	// RVA: 0x1396E1C
	public bool Equals(FourCC other) { }

	// RVA: 0x1396E2C
	public override bool Equals(object obj) { }

	// RVA: 0x1396EBC
	public override int GetHashCode() { }

	// RVA: 0x1396EC4
	public static bool op_Equality(FourCC left, FourCC right) { }

	// RVA: 0x1396ED0
	public static bool op_Inequality(FourCC left, FourCC right) { }

	// RVA: 0x1396EDC
	public static FourCC FromInt32(int i) { }

	// RVA: 0x1396EE0
	public static int ToInt32(FourCC fourCC) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public TValue get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A14A4
	public int get_Capacity() { }

	// RVA: 0x315B3A8
	public void .ctor(TValue value) { }

	// RVA: 0x315B3A8
	public void .ctor(TValue firstValue, TValue[] additionalValues) { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x315B3A8
	public TValue get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, TValue value) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x30A2378
	public void ClearWithCapacity() { }

	// RVA: 0x315B3A8
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone() { }

	// RVA: 0x30A24F0
	public void SetLength(int size) { }

	// RVA: 0x30A17DC
	public TValue[] ToArray() { }

	// RVA: 0x30A188C
	public TOther[] ToArray(System.Func<TValue,TOther> mapFunction) { }

	// RVA: 0x315B3A8
	public int IndexOf(TValue value) { }

	// RVA: 0x315B3A8
	public int Append(TValue value) { }

	// RVA: 0x315B3A8
	public int AppendWithCapacity(TValue value, int capacityIncrement) { }

	// RVA: 0x315B3A8
	public void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values) { }

	// RVA: 0x30A27C0
	public void Append(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x315B3A8
	public void Remove(TValue value) { }

	// RVA: 0x30A24F0
	public void RemoveAtWithCapacity(int index) { }

	// RVA: 0x30A24F0
	public void RemoveAt(int index) { }

	// RVA: 0x30A24F0
	public void RemoveAtByMovingTailWithCapacity(int index) { }

	// RVA: 0x315B3A8
	public bool RemoveByMovingTailWithCapacity(TValue value) { }

	// RVA: 0x315B3A8
	public bool Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x315B3A8
	public void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class InputArrayExtensions
{
	// Methods

	// RVA: 0x315B3A8
	public static int IndexOfReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x315B3A8
	public static bool Contains(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x315B3A8
	public static bool ContainsReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct InternedString
{
	// Fields
	private readonly string m_StringOriginalCase; // 0x10
	private readonly string m_StringLowerCase; // 0x18

	// Methods

	// RVA: 0x1396EE4
	public int get_length() { }

	// RVA: 0x1396EFC
	public void .ctor(string text) { }

	// RVA: 0x1396FE8
	public bool IsEmpty() { }

	// RVA: 0x1396FF8
	public string ToLower() { }

	// RVA: 0x1397000
	public override bool Equals(object obj) { }

	// RVA: 0x1397128
	public bool Equals(InternedString other) { }

	// RVA: 0x1397138
	public int CompareTo(InternedString other) { }

	// RVA: 0x139714C
	public override int GetHashCode() { }

	// RVA: 0x1397164
	public override string ToString() { }

	// RVA: 0x13971D0
	public static bool op_Equality(InternedString a, InternedString b) { }

	// RVA: 0x13971DC
	public static bool op_Inequality(InternedString a, InternedString b) { }

	// RVA: 0x13971E8
	public static bool op_Equality(InternedString a, string b) { }

	// RVA: 0x139729C
	public static bool op_Inequality(InternedString a, string b) { }

	// RVA: 0x1397350
	public static bool op_Equality(string a, InternedString b) { }

	// RVA: 0x1397400
	public static bool op_Inequality(string a, InternedString b) { }

	// RVA: 0x13974B0
	public static bool op_LessThan(InternedString left, InternedString right) { }

	// RVA: 0x13974D8
	public static bool op_GreaterThan(InternedString left, InternedString right) { }

	// RVA: 0x1397504
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

	// RVA: 0x13990E8
	public override string ToString() { }

	// RVA: 0x139934C
	public bool Equals(JsonString other) { }

	// RVA: 0x1399514
	public override bool Equals(object obj) { }

	// RVA: 0x13995BC
	public override int GetHashCode() { }

	// RVA: 0x1399778
	public static bool op_Equality(JsonString left, JsonString right) { }

	// RVA: 0x13997A8
	public static bool op_Inequality(JsonString left, JsonString right) { }

	// RVA: 0x13997DC
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

	// RVA: 0x139B108
	private static void .cctor() { }

	// RVA: 0x139B174
	public void .ctor() { }

	// RVA: 0x139B17C
	internal string <ToString>b__11_0(JsonValue x) { }

	// RVA: 0x139B184
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

	// RVA: 0x13998B8
	public bool ToBoolean() { }

	// RVA: 0x1399FA0
	public Int64 ToInteger() { }

	// RVA: 0x139A09C
	public Double ToDouble() { }

	// RVA: 0x1399B08
	public override string ToString() { }

	// RVA: 0x13990B0
	public static JsonValue op_Implicit(bool val) { }

	// RVA: 0x1398FA4
	public static JsonValue op_Implicit(Int64 val) { }

	// RVA: 0x1398FCC
	public static JsonValue op_Implicit(Double val) { }

	// RVA: 0x139A188
	public static JsonValue op_Implicit(string str) { }

	// RVA: 0x1398EC4
	public static JsonValue op_Implicit(JsonString str) { }

	// RVA: 0x1398F3C
	public static JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array) { }

	// RVA: 0x139A240
	public static JsonValue op_Implicit(System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj) { }

	// RVA: 0x139A2A4
	public static JsonValue op_Implicit(Enum val) { }

	// RVA: 0x139A308
	public bool Equals(JsonValue other) { }

	// RVA: 0x139A580
	private static bool Equals(object obj, JsonValue value) { }

	// RVA: 0x139AEC4
	public override bool Equals(object obj) { }

	// RVA: 0x139AF74
	public override int GetHashCode() { }

	// RVA: 0x1398158
	public static bool op_Equality(JsonValue left, JsonValue right) { }

	// RVA: 0x139B0CC
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

	// RVA: 0x1397570
	public void .ctor(string json) { }

	// RVA: 0x13975F4
	public void Reset() { }

	// RVA: 0x1397600
	public override string ToString() { }

	// RVA: 0x1397700
	public bool NavigateToProperty(string path) { }

	// RVA: 0x1397E04
	public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) { }

	// RVA: 0x1397C44
	public bool ParseToken(Char token) { }

	// RVA: 0x1397DD4
	public bool ParseValue() { }

	// RVA: 0x1397FAC
	public bool ParseValue(JsonValue result) { }

	// RVA: 0x1398190
	public bool ParseStringValue(JsonValue result) { }

	// RVA: 0x1398350
	public bool ParseArrayValue(JsonValue result) { }

	// RVA: 0x1398694
	public bool ParseObjectValue(JsonValue result) { }

	// RVA: 0x1398A10
	public bool ParseNumber(JsonValue result) { }

	// RVA: 0x139889C
	public bool ParseBooleanValue(JsonValue result) { }

	// RVA: 0x13989A8
	public bool ParseNullValue(JsonValue result) { }

	// RVA: 0x1397D64
	public bool SkipToValue() { }

	// RVA: 0x1398FEC
	private bool SkipString(string text) { }

	// RVA: 0x1397CC0
	private void SkipWhitespace() { }

	// RVA: 0x13990D8
	public bool get_isAtEnd() { }

}

// Namespace: 
public struct BitRegion
{
	// Fields
	public UInt32 bitOffset; // 0x10
	public UInt32 sizeInBits; // 0x14

	// Methods

	// RVA: 0x139BEB8
	public bool get_isEmpty() { }

	// RVA: 0x139BEC8
	public void .ctor(UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x139BED0
	public void .ctor(UInt32 byteOffset, UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x139BEDC
	public BitRegion Overlap(BitRegion other) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MemoryHelpers
{
	// Methods

	// RVA: 0x139B34C
	public static bool Compare(Void* ptr1, Void* ptr2, BitRegion region) { }

	// RVA: 0x139B530
	public static UInt32 ComputeFollowingByteOffset(UInt32 byteOffset, UInt32 sizeInBits) { }

	// RVA: 0x139B540
	public static void WriteSingleBit(Void* ptr, UInt32 bitOffset, bool value) { }

	// RVA: 0x139B390
	public static bool ReadSingleBit(Void* ptr, UInt32 bitOffset) { }

	// RVA: 0x139B570
	public static void MemCpyBitRegion(Void* destination, Void* source, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x139B3AC
	public static bool MemCmpBitRegion(Void* ptr1, Void* ptr2, UInt32 bitOffset, UInt32 bitCount, Void* mask) { }

	// RVA: 0x139B668
	public static void MemSet(Void* destination, int numBytes, Byte value) { }

	// RVA: 0x139B740
	public static void MemCpyMasked(Void* destination, Void* source, int numBytes, Void* mask) { }

	// RVA: 0x139B7D4
	public static UInt32 ReadMultipleBitsAsUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x139B968
	public static void WriteUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, UInt32 value) { }

	// RVA: 0x139BB4C
	public static int ReadTwosComplementMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x139BB50
	public static void WriteIntAsTwosComplementMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x139BB54
	public static int ReadExcessKMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x139BB84
	public static void WriteIntAsExcessKMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x139BB98
	public static float ReadMultipleBitsAsNormalizedUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x139BBF4
	public static void WriteNormalizedUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, float value) { }

	// RVA: 0x139BC44
	public static void SetBitsInBuffer(Void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	// RVA: 0x30A8E44
	public static void Swap(TValue a, TValue b) { }

	// RVA: 0x139BE30
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

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x30A2378
	private void <>m__Finally1() { }

	// RVA: 0x315B3A8
	private TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MiscHelpers
{
	// Methods

	// RVA: 0x315B3A8
	public static TValue GetValueOrDefault(System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key) { }

	// RVA: -1
	public static System.Collections.Generic.IEnumerable<TValue> EveryNth(System.Collections.Generic.IEnumerable<TValue> enumerable, int n, int start) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x139CB70
	private static void .cctor() { }

	// RVA: 0x139CBDC
	public void .ctor() { }

	// RVA: 0x139CBE4
	internal string <ToString>b__8_0(NamedValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct NameAndParameters
{
	// Fields
	private string <name>k__BackingField; // 0x10
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0x139BFB4
	public string get_name() { }

	// RVA: 0x139BFBC
	public void set_name(string value) { }

	// RVA: 0x139BFC4
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x139BFD0
	public void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x139BFDC
	public override string ToString() { }

	// RVA: 0x139C1EC
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text) { }

	// RVA: 0x139C304
	internal static bool ParseMultiple(string text, System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>& list) { }

	// RVA: 0x139C874
	internal static string ParseName(string text) { }

	// RVA: 0x139C8F8
	public static NameAndParameters Parse(string text) { }

	// RVA: 0x139C4B4
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

	// RVA: 0x139CD0C
	public string get_name() { }

	// RVA: 0x139CD14
	public void set_name(string value) { }

	// RVA: 0x139CD1C
	public PrimitiveValue get_value() { }

	// RVA: 0x139CD28
	public void set_value(PrimitiveValue value) { }

	// RVA: 0x139CD30
	public TypeCode get_type() { }

	// RVA: 0x139CD38
	public NamedValue ConvertTo(TypeCode type) { }

	// RVA: 0x315B3A8
	public static NamedValue From(string name, TValue value) { }

	// RVA: 0x139CC78
	public override string ToString() { }

	// RVA: 0x139D544
	public bool Equals(NamedValue other) { }

	// RVA: 0x139D63C
	public override bool Equals(object obj) { }

	// RVA: 0x139D73C
	public override int GetHashCode() { }

	// RVA: 0x139D810
	public static bool op_Equality(NamedValue left, NamedValue right) { }

	// RVA: 0x139D8B0
	public static bool op_Inequality(NamedValue left, NamedValue right) { }

	// RVA: 0x139C98C
	public static NamedValue[] ParseMultiple(string parameterString) { }

	// RVA: 0x139DD54
	public static NamedValue Parse(string str) { }

	// RVA: 0x139D9DC
	private static NamedValue ParseParameter(string parameterString, int index) { }

	// RVA: 0x139E104
	public void ApplyToObject(object instance) { }

	// RVA: 0x315B3A8
	public static void ApplyAllToObject(object instance, TParameterList parameters) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class NumberHelpers
{
	// Methods

	// RVA: 0x139E588
	public static int AlignToMultipleOf(int number, int alignment) { }

	// RVA: 0x139E5A4
	public static Int64 AlignToMultipleOf(Int64 number, Int64 alignment) { }

	// RVA: 0x139E5C0
	public static UInt32 AlignToMultipleOf(UInt32 number, UInt32 alignment) { }

	// RVA: 0x139E5DC
	public static bool Approximately(Double a, Double b) { }

	// RVA: 0x139E67C
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	// RVA: 0x139E6B4
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	// RVA: 0x139E704
	public static float UIntToNormalizedFloat(UInt32 value, UInt32 minValue, UInt32 maxValue) { }

	// RVA: 0x139E73C
	public static UInt32 NormalizedFloatToUInt(float value, UInt32 uintMinValue, UInt32 uintMaxValue) { }

	// RVA: 0x139E784
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

	// RVA: 0x139E978
	public void .ctor(Type deviceType, InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

	// RVA: 0x139E9DC
	public void OnCompleted() { }

	// RVA: 0x139E9E0
	public void OnError(Exception error) { }

	// RVA: 0x139EA68
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

	// RVA: 0x139E7FC
	public void .ctor(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, Type deviceType, InputDevice device) { }

	// RVA: 0x139E860
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public IDisposable subscription; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	internal void <CallOnce>b__0() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class Observable
{
	// Methods

	// RVA: 0x30A53B0
	public static System.IObservable<TValue> Where(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x30A53B0
	public static System.IObservable<TResult> Select(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x30A53B0
	public static System.IObservable<TResult> SelectMany(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: -1
	public static System.IObservable<TValue> Take(System.IObservable<TValue> source, int count) { }

	// RVA: 0x139EC40
	public static System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, InputDevice device) { }

	// RVA: 0x30A52D0
	public static System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source) { }

	// RVA: 0x30A53B0
	public static IDisposable CallOnce(System.IObservable<TValue> source, System.Action<TValue> action) { }

	// RVA: 0x30A53B0
	public static IDisposable Call(System.IObservable<TValue> source, System.Action<TValue> action) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class Observer<T0>
{
	// Fields
	private System.Action<TValue> m_OnNext; // 0x0
	private Action m_OnCompleted; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(System.Action<TValue> onNext, Action onCompleted) { }

	// RVA: 0x30A2378
	public void OnCompleted() { }

	// RVA: 0x30A27C0
	public void OnError(Exception error) { }

	// RVA: 0x315B3A8
	public void OnNext(TValue evt) { }

}

// Namespace: 
private class Select
{
	// Fields
	private UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x30A2378
	public void OnCompleted() { }

	// RVA: 0x30A27C0
	public void OnError(Exception error) { }

	// RVA: 0x315B3A8
	public void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class SelectManyObservable<T0, T1>
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> m_Filter; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: 0x30A188C
	public IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: 
private class Take
{
	// Fields
	private System.IObserver<TValue> m_Observer; // 0x0
	private int m_Remaining; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x30A2378
	public void OnCompleted() { }

	// RVA: 0x30A27C0
	public void OnError(Exception error) { }

	// RVA: 0x315B3A8
	public void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class TakeNObservable<T0>
{
	// Fields
	private System.IObservable<TValue> m_Source; // 0x0
	private int m_Count; // 0x0

	// Methods

	// RVA: 0x30A2828
	public void .ctor(System.IObservable<TValue> source, int count) { }

	// RVA: 0x30A188C
	public IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Where
{
	// Fields
	private UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable; // 0x0
	private readonly System.IObserver<TValue> m_Observer; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x30A2378
	public void OnCompleted() { }

	// RVA: 0x30A27C0
	public void OnError(Exception error) { }

	// RVA: 0x315B3A8
	public void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class WhereObservable<T0>
{
	// Fields
	private readonly System.IObservable<TValue> m_Source; // 0x0
	private readonly System.Func<TValue,System.Boolean> m_Predicate; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x30A188C
	public IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	internal int m_Index; // 0x0
	internal UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> m_List; // 0x0

	// Methods

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public TValue get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x315B3A8
	public TValue get_Item(int index) { }

	// RVA: 0x315B3A8
	public void .ctor(TValue single) { }

	// RVA: 0x315B3A8
	public void .ctor(TList multiple) { }

	// RVA: 0x315B3A8
	public static UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TValue single) { }

	// RVA: 0x315B3A8
	public static UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TList multiple) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct PredictiveParser
{
	// Fields
	private int m_Position; // 0x10

	// Methods

	// RVA: 0x139ED24
	public void ExpectSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x139EE30
	public int ExpectInt(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x139EF54
	public System.ReadOnlySpan<System.Char> ExpectString(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x139F19C
	public bool AcceptSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x139F1D8
	public bool AcceptString(System.ReadOnlySpan<System.Char> input, System.ReadOnlySpan<System.Char>& output) { }

	// RVA: 0x139F344
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

	// RVA: 0x139F3A4
	internal Byte* get_valuePtr() { }

	// RVA: 0x139F3AC
	public TypeCode get_type() { }

	// RVA: 0x139F3B4
	public bool get_isEmpty() { }

	// RVA: 0x139F3C4
	public void .ctor(bool value) { }

	// RVA: 0x139F3DC
	public void .ctor(Char value) { }

	// RVA: 0x139F3F4
	public void .ctor(Byte value) { }

	// RVA: 0x139F40C
	public void .ctor(SByte value) { }

	// RVA: 0x139F424
	public void .ctor(Int16 value) { }

	// RVA: 0x139F43C
	public void .ctor(UInt16 value) { }

	// RVA: 0x139F454
	public void .ctor(int value) { }

	// RVA: 0x139F464
	public void .ctor(UInt32 value) { }

	// RVA: 0x139F474
	public void .ctor(Int64 value) { }

	// RVA: 0x139F488
	public void .ctor(UInt64 value) { }

	// RVA: 0x139F49C
	public void .ctor(float value) { }

	// RVA: 0x139F4B0
	public void .ctor(Double value) { }

	// RVA: 0x139CDA4
	public PrimitiveValue ConvertTo(TypeCode type) { }

	// RVA: 0x139FD74
	public bool Equals(PrimitiveValue other) { }

	// RVA: 0x139FDCC
	public override bool Equals(object obj) { }

	// RVA: 0x139D5E0
	public static bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x13A0578
	public static bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x139D7C4
	public override int GetHashCode() { }

	// RVA: 0x13A05D4
	public override string ToString() { }

	// RVA: 0x139DDB4
	public static PrimitiveValue FromString(string value) { }

	// RVA: 0x13A0A30
	public TypeCode GetTypeCode() { }

	// RVA: 0x139F4C4
	public bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x139F714
	public Byte ToByte(IFormatProvider provider) { }

	// RVA: 0x139F690
	public Char ToChar(IFormatProvider provider) { }

	// RVA: 0x13A0A38
	public DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x13A0A8C
	public Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x139FC90
	public Double ToDouble(IFormatProvider provider) { }

	// RVA: 0x139F890
	public Int16 ToInt16(IFormatProvider provider) { }

	// RVA: 0x139F95C
	public int ToInt32(IFormatProvider provider) { }

	// RVA: 0x139FA0C
	public Int64 ToInt64(IFormatProvider provider) { }

	// RVA: 0x139F7D0
	public SByte ToSByte(IFormatProvider provider) { }

	// RVA: 0x139FB84
	public float ToSingle(IFormatProvider provider) { }

	// RVA: 0x13A0BA8
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x13A0BAC
	public object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x13A0BEC
	public UInt16 ToUInt16(IFormatProvider provider) { }

	// RVA: 0x13A0C94
	public UInt32 ToUInt32(IFormatProvider provider) { }

	// RVA: 0x139FAD0
	public UInt64 ToUInt64(IFormatProvider provider) { }

	// RVA: 0x139E38C
	public object ToObject() { }

	// RVA: 0x315B3A8
	public static PrimitiveValue From(TValue value) { }

	// RVA: 0x13A0028
	public static PrimitiveValue FromObject(object value) { }

	// RVA: 0x139DD98
	public static PrimitiveValue op_Implicit(bool value) { }

	// RVA: 0x139F704
	public static PrimitiveValue op_Implicit(Char value) { }

	// RVA: 0x139F7C0
	public static PrimitiveValue op_Implicit(Byte value) { }

	// RVA: 0x139F87C
	public static PrimitiveValue op_Implicit(SByte value) { }

	// RVA: 0x139F948
	public static PrimitiveValue op_Implicit(Int16 value) { }

	// RVA: 0x13A0D24
	public static PrimitiveValue op_Implicit(UInt16 value) { }

	// RVA: 0x139F9FC
	public static PrimitiveValue op_Implicit(int value) { }

	// RVA: 0x13A0D34
	public static PrimitiveValue op_Implicit(UInt32 value) { }

	// RVA: 0x139FAB4
	public static PrimitiveValue op_Implicit(Int64 value) { }

	// RVA: 0x139FB68
	public static PrimitiveValue op_Implicit(UInt64 value) { }

	// RVA: 0x139FC7C
	public static PrimitiveValue op_Implicit(float value) { }

	// RVA: 0x139FD58
	public static PrimitiveValue op_Implicit(Double value) { }

	// RVA: 0x13A0D44
	public static PrimitiveValue FromBoolean(bool value) { }

	// RVA: 0x13A0D60
	public static PrimitiveValue FromChar(Char value) { }

	// RVA: 0x13A0D70
	public static PrimitiveValue FromByte(Byte value) { }

	// RVA: 0x13A0D80
	public static PrimitiveValue FromSByte(SByte value) { }

	// RVA: 0x13A0D94
	public static PrimitiveValue FromInt16(Int16 value) { }

	// RVA: 0x13A0DA8
	public static PrimitiveValue FromUInt16(UInt16 value) { }

	// RVA: 0x13A0DB8
	public static PrimitiveValue FromInt32(int value) { }

	// RVA: 0x13A0DC8
	public static PrimitiveValue FromUInt32(UInt32 value) { }

	// RVA: 0x13A0DD8
	public static PrimitiveValue FromInt64(Int64 value) { }

	// RVA: 0x13A0DF4
	public static PrimitiveValue FromUInt64(UInt64 value) { }

	// RVA: 0x13A0E10
	public static PrimitiveValue FromSingle(float value) { }

	// RVA: 0x13A0E24
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

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public TValue get_Current() { }

	// RVA: 0x30A17DC
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

	// RVA: 0x30A27C0
	public void .ctor(TValue[] array) { }

	// RVA: -1
	public void .ctor(TValue[] array, int index, int length) { }

	// RVA: 0x30A17DC
	public TValue[] ToArray() { }

	// RVA: 0x30A15D4
	public int IndexOf(System.Predicate<TValue> predicate) { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x315B3A8
	public TValue get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class ReadOnlyArrayExtensions
{
	// Methods

	// RVA: 0x315B3A8
	public static bool Contains(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x315B3A8
	public static bool ContainsReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x315B3A8
	public static int IndexOfReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A27C0
	public virtual void Invoke(T state) { }

	// RVA: 0x30A19E0
	public virtual IAsyncResult BeginInvoke(T state, AsyncCallback callback, object object) { }

	// RVA: 0x30A2A20
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

	// RVA: 0x30A2BF4
	internal void .ctor(T state, TypedRestore restoreAction, Action staticDisposeCurrentState) { }

	// RVA: 0x30A2378
	public void StaticDisposeCurrentState() { }

	// RVA: 0x30A2378
	public void RestoreSavedState() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class SpriteUtilities
{
	// Methods

	// RVA: 0x13A0E40
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

	// RVA: 0x13A1C04
	public void .ctor(int <>1__state) { }

	// RVA: 0x13A2834
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13A2838
	private bool MoveNext() { }

	// RVA: 0x13A29A8
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13A29B0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13A29F0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13A29F8
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13A2AB0
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

	// RVA: 0x13A1B30
	public void .ctor(int <>1__state) { }

	// RVA: 0x13A2AB4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13A2AB8
	private bool MoveNext() { }

	// RVA: 0x13A2D6C
	private Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current() { }

	// RVA: 0x13A2D78
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13A2DB8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13A2E20
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator() { }

	// RVA: 0x13A2EC8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class StringHelpers
{
	// Methods

	// RVA: 0x13A106C
	public static string Escape(string str, string chars, string replacements) { }

	// RVA: 0x13A1288
	public static string Unescape(string str, string chars, string replacements) { }

	// RVA: 0x13A157C
	public static bool Contains(string str, Char ch) { }

	// RVA: 0x13A15A0
	public static bool Contains(string str, string text, StringComparison comparison) { }

	// RVA: 0x13A15C4
	public static string GetPlural(string str) { }

	// RVA: 0x13A1790
	public static string NicifyMemorySize(Int64 numBytes) { }

	// RVA: 0x13A1914
	public static bool FromNicifiedMemorySize(string text, Int64 result, Int64 defaultMultiplier) { }

	// RVA: 0x139D958
	public static int CountOccurrences(string str, Char ch) { }

	// RVA: 0x13A1AA8
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(string str) { }

	// RVA: 0x13A1B68
	public static System.Collections.Generic.IEnumerable<System.String> Split(string str, System.Func<System.Char,System.Boolean> predicate) { }

	// RVA: 0x30A53B0
	public static string Join(string separator, TValue[] values) { }

	// RVA: 0x30A53B0
	public static string Join(System.Collections.Generic.IEnumerable<TValue> values, string separator) { }

	// RVA: 0x30A550C
	public static string MakeUniqueName(string baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting,System.String> getNameFunc) { }

	// RVA: 0x13A1C3C
	public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, Char separator) { }

	// RVA: 0x13A1F78
	public static int ParseInt(string str, int pos) { }

	// RVA: 0x13A201C
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) { }

	// RVA: 0x13A2040
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, UInt32 offset) { }

	// RVA: 0x13A220C
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) { }

	// RVA: 0x13A2230
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, UInt32 offset) { }

	// RVA: 0x13A2368
	public static bool IsPrintable(Char ch) { }

	// RVA: 0x13A2424
	public static string WithAllWhitespaceStripped(string str) { }

	// RVA: 0x13A2590
	public static bool InvariantEqualsIgnoreCase(string left, string right) { }

	// RVA: 0x13A25E0
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

	// RVA: 0x13A2ECC
	public bool get_isEmpty() { }

	// RVA: 0x13A2EDC
	public void .ctor(string str) { }

	// RVA: 0x1398E8C
	public void .ctor(string str, int index, int length) { }

	// RVA: 0x13A2F28
	public void .ctor(string str, int index) { }

	// RVA: 0x13A2F74
	public override bool Equals(object obj) { }

	// RVA: 0x13A30B0
	public bool Equals(string other) { }

	// RVA: 0x13A3060
	public bool Equals(Substring other) { }

	// RVA: 0x13A31C0
	public bool Equals(InternedString other) { }

	// RVA: 0x13A3188
	public int CompareTo(Substring other) { }

	// RVA: 0x13994EC
	public static int Compare(Substring left, Substring right, StringComparison comparison) { }

	// RVA: 0x13A3290
	public bool StartsWith(string str) { }

	// RVA: 0x13A333C
	public string Substr(int index, int length) { }

	// RVA: 0x1399254
	public override string ToString() { }

	// RVA: 0x13996CC
	public override int GetHashCode() { }

	// RVA: 0x13A3374
	public static bool op_Equality(Substring a, Substring b) { }

	// RVA: 0x13A33B0
	public static bool op_Inequality(Substring a, Substring b) { }

	// RVA: 0x13A33EC
	public static bool op_Equality(Substring a, InternedString b) { }

	// RVA: 0x13A34B8
	public static bool op_Inequality(Substring a, InternedString b) { }

	// RVA: 0x13A3584
	public static bool op_Equality(InternedString a, Substring b) { }

	// RVA: 0x13A3650
	public static bool op_Inequality(InternedString a, Substring b) { }

	// RVA: 0x1399854
	public static Substring op_Implicit(string s) { }

	// RVA: 0x13A371C
	public int get_length() { }

	// RVA: 0x13A3724
	public int get_index() { }

	// RVA: 0x13992C0
	public Char get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class TypeHelpers
{
	// Methods

	// RVA: 0x315B3A8
	public static TObject As(object obj) { }

	// RVA: 0x13A372C
	public static bool IsInt(TypeCode type) { }

	// RVA: 0x13A373C
	public static Type GetValueType(MemberInfo member) { }

	// RVA: 0x13A394C
	public static string GetNiceTypeName(Type type) { }

	// RVA: 0x13A3E8C
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

	// RVA: 0x13A4B14
	private static void .cctor() { }

	// RVA: 0x13A4B80
	public void .ctor() { }

	// RVA: 0x13A4B88
	internal string <get_names>b__2_0(InternedString x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct TypeTable
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table; // 0x10

	// Methods

	// RVA: 0x13A4280
	public System.Collections.Generic.IEnumerable<System.String> get_names() { }

	// RVA: 0x13A43C8
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames() { }

	// RVA: 0x13A441C
	public void Initialize() { }

	// RVA: 0x13A449C
	public InternedString FindNameForType(Type type) { }

	// RVA: 0x13A4894
	public void AddTypeRegistration(string name, Type type) { }

	// RVA: 0x13A4A10
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

	// RVA: 0x13A4BF4
	public float get_midPoint() { }

	// RVA: 0x13A4C08
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13A4D4C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A4DA4
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

	// RVA: 0x13A4E04
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13A4ECC
	private bool ModifierIsPressed(InputBindingCompositeContext context) { }

	// RVA: 0x13A4F50
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A4F5C
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13A4FE0
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

	// RVA: 0x13A5034
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13A5130
	private bool ModifiersArePressed(InputBindingCompositeContext context) { }

	// RVA: 0x13A51E4
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A51F0
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13A5274
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

	// RVA: 0x13A52C8
	public override Type get_valueType() { }

	// RVA: 0x13A52D0
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13A52D8
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A5410
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x13A5370
	private bool ModifierIsPressed(InputBindingCompositeContext context) { }

	// RVA: 0x13A54CC
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13A5A24
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13A5578
	internal static void DetermineValueTypeAndSize(InputBindingCompositeContext context, int part, Type valueType, int valueSizeInBytes, bool isButton) { }

	// RVA: 0x13A5A74
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

	// RVA: 0x13A5A7C
	public override Type get_valueType() { }

	// RVA: 0x13A5A84
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13A5A8C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A5BA0
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x13A5AD0
	private bool ModifiersArePressed(InputBindingCompositeContext context) { }

	// RVA: 0x13A5C08
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13A5CB4
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13A5D18
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

	// RVA: 0x13A5D20
	public override Vector2 ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13A5E9C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A5F30
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

	// RVA: 0x13A5F8C
	public override Vector3 ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13A622C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13A62D4
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


