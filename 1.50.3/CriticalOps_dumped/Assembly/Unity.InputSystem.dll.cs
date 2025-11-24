// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class UISupport
{
	// Methods

	// RVA: 0x1392E9C
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

	// RVA: 0x1392F14
	private static MonoScriptData Get() { }

	// RVA: 0x1393018
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

	// RVA: 0x1393020
	public static Type GetValueType(Type interactionType) { }

	// RVA: 0x139313C
	public static string GetDisplayName(string interaction) { }

	// RVA: 0x139325C
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

	// RVA: 0x1396230
	private int get_actionIndex() { }

	// RVA: 0x1396238
	private int get_bindingIndex() { }

	// RVA: 0x1396278
	private int get_controlIndex() { }

	// RVA: 0x13962B8
	private int get_interactionIndex() { }

	// RVA: 0x13962F8
	public InputActionPhase get_phase() { }

	// RVA: 0x1396334
	public bool get_started() { }

	// RVA: 0x1396378
	public bool get_performed() { }

	// RVA: 0x13963BC
	public bool get_canceled() { }

	// RVA: 0x1396400
	public InputAction get_action() { }

	// RVA: 0x1396458
	public InputControl get_control() { }

	// RVA: 0x13964BC
	public IInputInteraction get_interaction() { }

	// RVA: 0x1396540
	public Double get_time() { }

	// RVA: 0x139658C
	public Double get_startTime() { }

	// RVA: 0x13965D8
	public Double get_duration() { }

	// RVA: 0x139665C
	public Type get_valueType() { }

	// RVA: 0x13966F0
	public int get_valueSizeInBytes() { }

	// RVA: 0x1396784
	public void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x1396A38
	public bool ReadValueAsButton() { }

	// RVA: 0x1396AF8
	public object ReadValueAsObject() { }

	// RVA: 0x1396BBC
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
public sealed class InputAction
{
	// Fields
	private static readonly ProfilerMarker k_InputActionEnableProfilerMarker; // 0x0
	private static readonly ProfilerMarker k_InputActionDisableProfilerMarker; // 0x8
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

	// RVA: 0x1393414
	public string get_name() { }

	// RVA: 0x139341C
	public InputActionType get_type() { }

	// RVA: 0x1393424
	public Guid get_id() { }

	// RVA: 0x13934F8
	internal Guid get_idDontGenerate() { }

	// RVA: 0x139355C
	public string get_expectedControlType() { }

	// RVA: 0x1393564
	public void set_expectedControlType(string value) { }

	// RVA: 0x139356C
	public string get_processors() { }

	// RVA: 0x1393574
	public string get_interactions() { }

	// RVA: 0x139357C
	public InputActionMap get_actionMap() { }

	// RVA: 0x13935BC
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x13935D8
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1393B20
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1393C54
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x1393DF0
	public InputActionPhase get_phase() { }

	// RVA: 0x1393EB8
	public bool get_inProgress() { }

	// RVA: 0x1393F0C
	public bool get_enabled() { }

	// RVA: 0x1393F60
	public void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1393FBC
	public void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1394018
	public void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1394074
	public void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13940D0
	public void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x139412C
	public void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1394188
	public bool get_triggered() { }

	// RVA: 0x13942B8
	public InputControl get_activeControl() { }

	// RVA: 0x1394350
	public Type get_activeValueType() { }

	// RVA: 0x13943DC
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x13943F8
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x139440C
	public void .ctor() { }

	// RVA: 0x1394468
	public void .ctor(string name, InputActionType type, string binding, string interactions, string processors, string expectedControlType) { }

	// RVA: 0x1394680
	public void Dispose() { }

	// RVA: 0x139469C
	public override string ToString() { }

	// RVA: 0x13949E0
	public void Enable() { }

	// RVA: 0x1394BAC
	public void Disable() { }

	// RVA: 0x1394D58
	public InputAction Clone() { }

	// RVA: 0x1394E6C
	private object System.ICloneable.Clone() { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x1394E70
	public object ReadValueAsObject() { }

	// RVA: 0x1394F10
	public float GetControlMagnitude() { }

	// RVA: 0x1394F88
	public void Reset() { }

	// RVA: 0x1395020
	public bool IsPressed() { }

	// RVA: 0x1395084
	public bool IsInProgress() { }

	// RVA: 0x13950EC
	private int ExpectedFrame() { }

	// RVA: 0x139517C
	public bool WasPressedThisFrame() { }

	// RVA: 0x1395214
	public bool WasPressedThisDynamicUpdate() { }

	// RVA: 0x13952F0
	public bool WasReleasedThisFrame() { }

	// RVA: 0x1395388
	public bool WasReleasedThisDynamicUpdate() { }

	// RVA: 0x1394220
	public bool WasPerformedThisFrame() { }

	// RVA: 0x1395464
	public bool WasPerformedThisDynamicUpdate() { }

	// RVA: 0x1395540
	public bool WasCompletedThisFrame() { }

	// RVA: 0x13955D8
	public bool WasCompletedThisDynamicUpdate() { }

	// RVA: 0x13956B4
	public float GetTimeoutCompletionPercentage() { }

	// RVA: 0x139359C
	internal bool get_isSingletonAction() { }

	// RVA: 0x1393E3C
	private TriggerState get_currentState() { }

	// RVA: 0x1393498
	internal string MakeSureIdIsInPlace() { }

	// RVA: 0x1395800
	internal void GenerateId() { }

	// RVA: 0x13939B0
	internal InputActionMap GetOrCreateActionMap() { }

	// RVA: 0x139584C
	private void CreateInternalActionMapForSingletonAction() { }

	// RVA: 0x13959FC
	internal void RequestInitialStateCheckOnEnabledAction() { }

	// RVA: 0x1395A48
	internal bool ActiveControlIsValid(InputControl control) { }

	// RVA: 0x1395D80
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask() { }

	// RVA: 0x1395F00
	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	// RVA: 0x13960A8
	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

	// RVA: 0x1396178
	private static void .cctor() { }

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

	// RVA: 0x13982C8
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

	// RVA: 0x139966C
	public void .ctor(int <>1__state) { }

	// RVA: 0x139B024
	private void System.IDisposable.Dispose() { }

	// RVA: 0x139B028
	private bool MoveNext() { }

	// RVA: 0x139B23C
	private InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

	// RVA: 0x139B244
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x139B284
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

	// RVA: 0x139726C
	public void .ctor(int <>1__state) { }

	// RVA: 0x139B28C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x139B290
	private bool MoveNext() { }

	// RVA: 0x139B42C
	private InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

	// RVA: 0x139B458
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x139B498
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x139B520
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

	// RVA: 0x139B5D4
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

	// RVA: 0x1396F58
	public bool get_enabled() { }

	// RVA: 0x13970FC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps() { }

	// RVA: 0x1397178
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x13971E4
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x13972A4
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x13972CC
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1397608
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x13977A0
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x13979D0
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x1397D78
	public string ToJson() { }

	// RVA: 0x13981EC
	public void LoadFromJson(string json) { }

	// RVA: 0x139839C
	public static InputActionAsset FromJson(string json) { }

	// RVA: 0x1397A54
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1398584
	public int FindBinding(InputBinding mask, InputAction action) { }

	// RVA: 0x139884C
	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound) { }

	// RVA: 0x1398A94
	public InputActionMap FindActionMap(Guid id) { }

	// RVA: 0x1398B54
	public InputAction FindAction(Guid guid) { }

	// RVA: 0x1398C70
	public int FindControlSchemeIndex(string name) { }

	// RVA: 0x1398D40
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(string name) { }

	// RVA: 0x1398E78
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x139911C
	public void Enable() { }

	// RVA: 0x1399370
	public void Disable() { }

	// RVA: 0x1399558
	public bool Contains(InputAction action) { }

	// RVA: 0x13995F4
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x1399698
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1399710
	internal void MarkAsDirty() { }

	// RVA: 0x1399714
	internal bool IsEmpty() { }

	// RVA: 0x1399810
	internal void OnWantToChangeSetup() { }

	// RVA: 0x1399B88
	internal void OnSetupChanged() { }

	// RVA: 0x13975C8
	private void ReResolveIfNecessary(bool fullResolve) { }

	// RVA: 0x1399E90
	internal void ResolveBindingsIfNecessary() { }

	// RVA: 0x1399F4C
	private void OnDestroy() { }

	// RVA: 0x1399F94
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

	// RVA: 0x139E3A8
	public int IndexOf(InputDevice device) { }

	// RVA: 0x139E408
	public bool Remove(InputDevice device) { }

	// RVA: 0x13976D4
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get() { }

	// RVA: 0x1397814
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

	// RVA: 0x139E4BC
	public static BindingOverrideJson FromBinding(InputBinding binding, string actionName) { }

	// RVA: 0x139E5D4
	public static BindingOverrideJson FromBinding(InputBinding binding) { }

	// RVA: 0x139E63C
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

	// RVA: 0x139E748
	public InputBinding ToBinding() { }

	// RVA: 0x139E8D4
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

	// RVA: 0x139E9C0
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

	// RVA: 0x139EC6C
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

	// RVA: 0x139ED94
	public static WriteMapJson FromMap(InputActionMap map) { }

}

// Namespace: 
[Serializable]
internal struct WriteFileJson
{
	// Fields
	public WriteMapJson[] maps; // 0x10

	// Methods

	// RVA: 0x139E100
	public static WriteFileJson FromMap(InputActionMap map) { }

	// RVA: 0x1397E50
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

	// RVA: 0x1399F9C
	public InputActionMap[] ToMaps() { }

}

// Namespace: UnityEngine.InputSystem
[Serializable]
public sealed class InputActionMap
{
	// Fields
	private static readonly ProfilerMarker k_ResolveBindingsProfilerMarker; // 0x0
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
	internal static int s_DeferBindingResolution; // 0x8
	internal static bool s_NeedToResolveBindings; // 0xC

	// Methods

	// RVA: 0x139B5D8
	public string get_name() { }

	// RVA: 0x139B5E0
	public InputActionAsset get_asset() { }

	// RVA: 0x139B5E8
	public Guid get_id() { }

	// RVA: 0x1398A30
	internal Guid get_idDontGenerate() { }

	// RVA: 0x1397168
	public bool get_enabled() { }

	// RVA: 0x139B1D0
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions() { }

	// RVA: 0x139B6A8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x139B714
	private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

	// RVA: 0x139B7B8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x139B88C
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x139B8B4
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1395B88
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x139BB8C
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x139BBDC
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x139BCBC
	public void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x139BD18
	public void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x139597C
	public void .ctor() { }

	// RVA: 0x139BD74
	public void .ctor(string name) { }

	// RVA: 0x139BE04
	public void Dispose() { }

	// RVA: 0x139BE18
	internal int FindActionIndex(string nameOrId) { }

	// RVA: 0x139C024
	private void SetUpActionLookupTable() { }

	// RVA: 0x139C1AC
	internal void ClearActionLookupTable() { }

	// RVA: 0x139C208
	private int FindActionIndex(Guid id) { }

	// RVA: 0x1398458
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1398C14
	public InputAction FindAction(Guid id) { }

	// RVA: 0x1399008
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x13992FC
	public void Enable() { }

	// RVA: 0x1399520
	public void Disable() { }

	// RVA: 0x139C2E0
	public InputActionMap Clone() { }

	// RVA: 0x139C5C8
	private object System.ICloneable.Clone() { }

	// RVA: 0x139C5CC
	public bool Contains(InputAction action) { }

	// RVA: 0x139C5F8
	public override string ToString() { }

	// RVA: 0x139C700
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x139C7E0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x139C7E4
	private bool get_needToResolveBindings() { }

	// RVA: 0x139C7F0
	private void set_needToResolveBindings(bool value) { }

	// RVA: 0x139C804
	private bool get_bindingResolutionNeedsFullReResolve() { }

	// RVA: 0x139C810
	private void set_bindingResolutionNeedsFullReResolve(bool value) { }

	// RVA: 0x139C830
	private bool get_controlsForEachActionInitialized() { }

	// RVA: 0x139C83C
	private void set_controlsForEachActionInitialized(bool value) { }

	// RVA: 0x139C85C
	private bool get_bindingsForEachActionInitialized() { }

	// RVA: 0x139C868
	private void set_bindingsForEachActionInitialized(bool value) { }

	// RVA: 0x1393BBC
	internal UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(InputAction action) { }

	// RVA: 0x1393D58
	internal UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(InputAction action) { }

	// RVA: 0x139C888
	private void SetUpPerActionControlAndBindingArrays() { }

	// RVA: 0x13998A0
	internal void OnWantToChangeSetup() { }

	// RVA: 0x1399C24
	internal void OnSetupChanged() { }

	// RVA: 0x139D02C
	internal void OnBindingModified() { }

	// RVA: 0x139CFC4
	internal void ClearCachedActionData(bool onlyControls) { }

	// RVA: 0x139B65C
	internal void GenerateId() { }

	// RVA: 0x13939EC
	internal bool LazyResolveBindings(bool fullResolve) { }

	// RVA: 0x1393D10
	internal bool ResolveBindingsIfNecessary() { }

	// RVA: 0x139D094
	internal void ResolveBindings() { }

	// RVA: 0x139867C
	public int FindBinding(InputBinding mask, InputAction action) { }

	// RVA: 0x139DE50
	internal int FindBindingRelativeToMap(InputBinding mask) { }

	// RVA: 0x139DF14
	public static InputActionMap[] FromJson(string json) { }

	// RVA: 0x139DFCC
	public static string ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

	// RVA: 0x139E088
	public string ToJson() { }

	// RVA: 0x139E1B0
	public void OnBeforeSerialize() { }

	// RVA: 0x139E1B4
	public void OnAfterDeserialize() { }

	// RVA: 0x139E328
	private static void .cctor() { }

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

	// RVA: 0x139F598
	public void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x139F5F0
	public ParameterEnumerator GetEnumerator() { }

	// RVA: 0x13A5C54
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }

	// RVA: 0x13A5D48
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

	// RVA: 0x13A5948
	public void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x13A5FF8
	private bool MoveToNextBinding() { }

	// RVA: 0x13A61C8
	private bool MoveToNextInteraction() { }

	// RVA: 0x13A6388
	private bool MoveToNextProcessor() { }

	// RVA: 0x13A624C
	private bool FindParameter(object instance) { }

	// RVA: 0x139F6E0
	public bool MoveNext() { }

	// RVA: 0x13A5F00
	public void Reset() { }

	// RVA: 0x139F66C
	public Parameter get_Current() { }

	// RVA: 0x13A640C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13A64B0
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

	// RVA: 0x13A5E3C
	public Type get_objectType() { }

	// RVA: 0x139F1B8
	public void .ctor(string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x13A64B4
	public void .ctor(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x13A09DC
	public static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(InputActionMap actionMap, InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x13A652C
	private static System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(ParameterOverride[] overrides, int overrideCount, InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x13A67EC
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

	// RVA: 0x13A726C
	public void .ctor() { }

	// RVA: 0x13A95A4
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

	// RVA: 0x13A6C14
	public InputAction get_action() { }

	// RVA: 0x13A6C1C
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x13A6C44
	public UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates() { }

	// RVA: 0x13A6C58
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_scores() { }

	// RVA: 0x13A6CD8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_magnitudes() { }

	// RVA: 0x13A6D58
	public InputControl get_selectedControl() { }

	// RVA: 0x13A6DCC
	public bool get_started() { }

	// RVA: 0x13A6DD8
	public bool get_completed() { }

	// RVA: 0x13A6DE4
	public bool get_canceled() { }

	// RVA: 0x13A6DF0
	public Double get_startTime() { }

	// RVA: 0x13A6DF8
	public float get_timeout() { }

	// RVA: 0x13A5284
	public string get_expectedControlType() { }

	// RVA: 0x13A4ED8
	public RebindingOperation WithAction(InputAction action) { }

	// RVA: 0x13A5204
	public RebindingOperation WithMatchingEventsBeingSuppressed(bool value) { }

	// RVA: 0x13A5294
	public RebindingOperation WithCancelingThrough(string binding) { }

	// RVA: 0x13A6F04
	public RebindingOperation WithCancelingThrough(InputControl control) { }

	// RVA: 0x13A6E68
	public RebindingOperation WithExpectedControlType(string layoutName) { }

	// RVA: 0x13A6FE4
	public RebindingOperation WithExpectedControlType(Type type) { }

	// RVA: 0x30D3CF0
	public RebindingOperation WithExpectedControlType() { }

	// RVA: 0x13A530C
	public RebindingOperation WithTargetBinding(int bindingIndex) { }

	// RVA: 0x13A73E4
	public RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask) { }

	// RVA: 0x13A741C
	public RebindingOperation WithBindingGroup(string group) { }

	// RVA: 0x13A7518
	public RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

	// RVA: 0x13A7528
	public RebindingOperation WithRebindAddingNewBinding(string group) { }

	// RVA: 0x13A755C
	public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

	// RVA: 0x13A765C
	public RebindingOperation WithoutIgnoringNoisyControls() { }

	// RVA: 0x13A7274
	public RebindingOperation WithControlsHavingToMatchPath(string path) { }

	// RVA: 0x13A5094
	public RebindingOperation WithControlsExcluding(string path) { }

	// RVA: 0x13A76CC
	public RebindingOperation WithTimeout(float timeInSeconds) { }

	// RVA: 0x13A76D4
	public RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x13A7700
	public RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x13A772C
	public RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x13A7758
	public RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl,System.String> callback) { }

	// RVA: 0x13A7784
	public RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> callback) { }

	// RVA: 0x13A77B0
	public RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> callback) { }

	// RVA: 0x13A508C
	public RebindingOperation OnMatchWaitForAnother(float seconds) { }

	// RVA: 0x13A77DC
	public RebindingOperation Start() { }

	// RVA: 0x13A7B60
	public void Cancel() { }

	// RVA: 0x13A7C00
	public void Complete() { }

	// RVA: 0x13A7FFC
	public void AddCandidate(InputControl control, float score, float magnitude) { }

	// RVA: 0x13A82C8
	public void RemoveCandidate(InputControl control) { }

	// RVA: 0x13A83EC
	public void Dispose() { }

	// RVA: 0x13A8674
	protected override void Finalize() { }

	// RVA: 0x13A8704
	public RebindingOperation Reset() { }

	// RVA: 0x13A7A44
	private void HookOnEvent() { }

	// RVA: 0x13A8548
	private void UnhookOnEvent() { }

	// RVA: 0x13A8818
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x13A8184
	private void SortCandidatesByScore() { }

	// RVA: 0x13A906C
	private static bool HavePathMatch(InputControl control, string[] paths, int pathCount) { }

	// RVA: 0x13A793C
	private void HookOnAfterUpdate() { }

	// RVA: 0x13A85E8
	private void UnhookOnAfterUpdate() { }

	// RVA: 0x13A9114
	private void OnAfterUpdate() { }

	// RVA: 0x13A7C10
	private void OnComplete() { }

	// RVA: 0x13A7BB8
	private void OnCancel() { }

	// RVA: 0x13A93F4
	private void ResetAfterMatchCompleted() { }

	// RVA: 0x13A6E00
	private void ThrowIfRebindInProgress() { }

	// RVA: 0x13A91F4
	private string GeneratePathForControl(InputControl control) { }

	// RVA: 0x13A4E38
	public void .ctor() { }

}

// Namespace: 
internal class DeferBindingResolutionWrapper
{
	// Methods

	// RVA: 0x13A58E4
	public void Acquire() { }

	// RVA: 0x13A95CC
	public void Dispose() { }

	// RVA: 0x13A58DC
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

	// RVA: 0x13A1D50
	public void .ctor() { }

	// RVA: 0x13A96F4
	internal string <GetBindingDisplayString>b__0(string fragment) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionRebindingExtensions
{
	// Fields
	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x0

	// Methods

	// RVA: 0x139F064
	public static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask) { }

	// RVA: 0x139F29C
	private static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, ParameterOverride parameterOverride) { }

	// RVA: 0x139F9F8
	public static System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	// RVA: 0x318DB98
	public static System.Nullable<TValue> GetParameterValue(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask) { }

	// RVA: 0x318DB98
	public static void ApplyParameterOverride(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x318DB98
	public static void ApplyParameterOverride(InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x318DB98
	public static void ApplyParameterOverride(InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x318DB98
	private static ParameterOverride ExtractParameterOverride(System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x139FC60
	public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x13A03E4
	public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x13A05C0
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x13A0778
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	// RVA: 0x139FDF0
	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ParameterOverride[] parameterOverrides, int parameterOverridesCount, ParameterOverride parameterOverride) { }

	// RVA: 0x13A0BD4
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x13A0D08
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x13A0E74
	public static int GetBindingIndex(InputAction action, string group, string path) { }

	// RVA: 0x13A0F48
	public static System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	// RVA: 0x13A10CC
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	// RVA: 0x13A12A4
	public static string GetBindingDisplayString(InputAction action, DisplayStringOptions options, string group) { }

	// RVA: 0x13A1444
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options) { }

	// RVA: 0x13A1680
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options) { }

	// RVA: 0x13A1700
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, string deviceLayoutName, string controlPath, DisplayStringOptions options) { }

	// RVA: 0x13A1D58
	public static void ApplyBindingOverride(InputAction action, string newPath, string group, string path) { }

	// RVA: 0x13A1E54
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	// RVA: 0x13A2160
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x13A2438
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	// RVA: 0x13A1FB8
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	// RVA: 0x13A2234
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x13A2518
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	// RVA: 0x13A25A0
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x13A2680
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x13A2760
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	// RVA: 0x13A2C4C
	public static void RemoveAllBindingOverrides(InputAction action) { }

	// RVA: 0x13A2DFC
	public static void ApplyBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x13A3170
	public static void RemoveBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x13A34E4
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	// RVA: 0x13A3644
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	// RVA: 0x13A37B0
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	// RVA: 0x13A3E28
	public static string SaveBindingOverridesAsJson(InputAction action) { }

	// RVA: 0x13A3C68
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, InputAction action) { }

	// RVA: 0x13A41F8
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting) { }

	// RVA: 0x13A47DC
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting) { }

	// RVA: 0x13A4388
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	// RVA: 0x13A4980
	public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex) { }

	// RVA: 0x139DD48
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

	// RVA: 0x13A987C
	public InputAction get_action() { }

	// RVA: 0x13A99F4
	public InputActionReference get_reference() { }

	// RVA: 0x13A9A0C
	internal InputAction get_serializedAction() { }

	// RVA: 0x13A9A14
	internal InputActionReference get_serializedReference() { }

	// RVA: 0x13A9A1C
	public void .ctor(InputAction action) { }

	// RVA: 0x13A9A50
	public void .ctor(InputActionReference reference) { }

	// RVA: 0x13A9A90
	public bool Equals(InputActionProperty other) { }

	// RVA: 0x13A9B8C
	public bool Equals(InputAction other) { }

	// RVA: 0x13A9C48
	public bool Equals(InputActionReference other) { }

	// RVA: 0x13A9CB8
	public override bool Equals(object obj) { }

	// RVA: 0x13A9E80
	public override int GetHashCode() { }

	// RVA: 0x13A9F3C
	public static bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	// RVA: 0x13AA02C
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

	// RVA: 0x13AA10C
	public InputActionAsset get_asset() { }

	// RVA: 0x13A9914
	public InputAction get_action() { }

	// RVA: 0x13AA114
	public void Set(InputAction action) { }

	// RVA: 0x13AA444
	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	// RVA: 0x13AA230
	private void SetInternal(InputActionAsset asset, InputAction action) { }

	// RVA: 0x13AA758
	public override string ToString() { }

	// RVA: 0x13AA678
	internal static string GetDisplayName(InputAction action) { }

	// RVA: 0x13AAAC8
	internal string ToDisplayName() { }

	// RVA: 0x13AAB14
	public static InputAction op_Implicit(InputActionReference reference) { }

	// RVA: 0x13AAB20
	public static InputActionReference Create(InputAction action) { }

	// RVA: 0x13AAB9C
	internal static void ResetCachedAction() { }

	// RVA: 0x13AACE8
	public InputAction ToInputAction() { }

	// RVA: 0x13AACEC
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

	// RVA: 0x13AE0B8
	public bool get_valid() { }

	// RVA: 0x13AE130
	public int get_bindingIndex() { }

	// RVA: 0x13AE1D0
	public InputBinding get_binding() { }

	// RVA: 0x13AE2DC
	internal void .ctor(InputActionMap map, int bindingIndexInMap, InputAction action) { }

	// RVA: 0x13AE320
	public BindingSyntax WithName(string name) { }

	// RVA: 0x13AE43C
	public BindingSyntax WithPath(string path) { }

	// RVA: 0x13AE558
	public BindingSyntax WithGroup(string group) { }

	// RVA: 0x13AE754
	public BindingSyntax WithGroups(string groups) { }

	// RVA: 0x13AE978
	public BindingSyntax WithInteraction(string interaction) { }

	// RVA: 0x13AEB74
	public BindingSyntax WithInteractions(string interactions) { }

	// RVA: 0x318DB98
	public BindingSyntax WithInteraction() { }

	// RVA: 0x13AED98
	public BindingSyntax WithProcessor(string processor) { }

	// RVA: 0x13AEF94
	public BindingSyntax WithProcessors(string processors) { }

	// RVA: 0x318DB98
	public BindingSyntax WithProcessor() { }

	// RVA: 0x13AF1B8
	public BindingSyntax Triggering(InputAction action) { }

	// RVA: 0x13AF398
	public BindingSyntax To(InputBinding binding) { }

	// RVA: 0x13AF504
	public BindingSyntax NextBinding() { }

	// RVA: 0x13AF6A8
	public BindingSyntax PreviousBinding() { }

	// RVA: 0x13AF6E8
	public BindingSyntax NextPartBinding(string partName) { }

	// RVA: 0x13AF998
	public BindingSyntax PreviousPartBinding(string partName) { }

	// RVA: 0x13AFA48
	public BindingSyntax NextCompositeBinding(string compositeName) { }

	// RVA: 0x13AFC5C
	public BindingSyntax PreviousCompositeBinding(string compositeName) { }

	// RVA: 0x13AF544
	private BindingSyntax Iterate(bool next) { }

	// RVA: 0x13AFA8C
	private BindingSyntax IterateCompositeBinding(bool next, string compositeName) { }

	// RVA: 0x13AF798
	private BindingSyntax IteratePartBinding(bool next, string partName) { }

	// RVA: 0x13AFD14
	public void Erase() { }

	// RVA: 0x13AFF1C
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

	// RVA: 0x13B0184
	public int get_bindingIndex() { }

	// RVA: 0x13B01B4
	internal void .ctor(InputActionMap map, InputAction action, int compositeIndex) { }

	// RVA: 0x13B0200
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

	// RVA: 0x13B0454
	internal void .ctor(InputActionAsset asset, int index) { }

	// RVA: 0x13B0488
	internal void .ctor(InputControlScheme controlScheme) { }

	// RVA: 0x13B04D4
	public ControlSchemeSyntax WithBindingGroup(string bindingGroup) { }

	// RVA: 0x318DB98
	public ControlSchemeSyntax WithRequiredDevice() { }

	// RVA: 0x318DB98
	public ControlSchemeSyntax WithOptionalDevice() { }

	// RVA: 0x318DB98
	public ControlSchemeSyntax OrWithRequiredDevice() { }

	// RVA: 0x318DB98
	public ControlSchemeSyntax OrWithOptionalDevice() { }

	// RVA: 0x13B0614
	public ControlSchemeSyntax WithRequiredDevice(string controlPath) { }

	// RVA: 0x13B0878
	public ControlSchemeSyntax WithOptionalDevice(string controlPath) { }

	// RVA: 0x13B08B0
	public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) { }

	// RVA: 0x13B08E8
	public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) { }

	// RVA: 0x30D3CF0
	private string DeviceTypeToControlPath() { }

	// RVA: 0x13B0920
	public InputControlScheme Done() { }

	// RVA: 0x13B064C
	private void AddDeviceEntry(string controlPath, Flags flags) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public InputBinding binding; // 0x10

	// Methods

	// RVA: 0x13B0A08
	public void .ctor() { }

	// RVA: 0x13B0A10
	internal bool <RemoveAction>b__0(InputBinding b) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionSetupExtensions
{
	// Methods

	// RVA: 0x13AACF4
	public static InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	// RVA: 0x13AAF54
	public static void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x13AB1EC
	public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x13AB398
	public static void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x13AB4CC
	public static InputAction AddAction(InputActionMap map, string name, InputActionType type, string binding, string interactions, string processors, string groups, string expectedControlLayout) { }

	// RVA: 0x13AB910
	public static void RemoveAction(InputAction action) { }

	// RVA: 0x13ABC98
	public static void RemoveAction(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x13A9310
	public static BindingSyntax AddBinding(InputAction action, string path, string interactions, string processors, string groups) { }

	// RVA: 0x13ABEB8
	public static BindingSyntax AddBinding(InputAction action, InputControl control) { }

	// RVA: 0x13ABDC4
	public static BindingSyntax AddBinding(InputAction action, InputBinding binding) { }

	// RVA: 0x13AC1DC
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions, string groups, string action, string processors) { }

	// RVA: 0x13AC464
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions, string groups) { }

	// RVA: 0x13AC5D4
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions, string groups) { }

	// RVA: 0x13AC340
	public static BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x13AC6D4
	public static CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions, string processors) { }

	// RVA: 0x13ABFE4
	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex) { }

	// RVA: 0x13A71C4
	public static BindingSyntax ChangeBinding(InputAction action, int index) { }

	// RVA: 0x13AC8D0
	public static BindingSyntax ChangeBinding(InputAction action, string name) { }

	// RVA: 0x13ACC80
	public static BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	// RVA: 0x13ACD9C
	public static BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	// RVA: 0x13ACE74
	public static BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	// RVA: 0x13ACF48
	public static BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	// RVA: 0x13AD020
	public static BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	// RVA: 0x13AC968
	public static BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	// RVA: 0x13AD0F8
	public static BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	// RVA: 0x13AD320
	public static void Rename(InputAction action, string newName) { }

	// RVA: 0x13AD604
	public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	// RVA: 0x13AD924
	public static ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x13ADAF4
	public static void RemoveControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x13ADC4C
	public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	// RVA: 0x13ADCF8
	public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	// RVA: 0x13ADE08
	public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x13ADEB4
	public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x13ADF60
	public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x13AE00C
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

	// RVA: 0x13B2878
	public int get_triggerControlIndex() { }

	// RVA: 0x13B3B5C
	public void set_triggerControlIndex(int value) { }

	// RVA: 0x13B9B38
	public Double get_startTime() { }

	// RVA: 0x13B9B40
	public void set_startTime(Double value) { }

	// RVA: 0x13B9B48
	public Double get_performedTime() { }

	// RVA: 0x13B9B50
	public void set_performedTime(Double value) { }

	// RVA: 0x13B9B58
	public Double get_timerStartTime() { }

	// RVA: 0x13B9B60
	public void set_timerStartTime(Double value) { }

	// RVA: 0x13B9B68
	public float get_timerDuration() { }

	// RVA: 0x13B9B70
	public void set_timerDuration(float value) { }

	// RVA: 0x13B9B78
	public float get_totalTimeoutCompletionDone() { }

	// RVA: 0x13B9B80
	public void set_totalTimeoutCompletionDone(float value) { }

	// RVA: 0x13B9B88
	public float get_totalTimeoutCompletionTimeRemaining() { }

	// RVA: 0x13B9B90
	public void set_totalTimeoutCompletionTimeRemaining(float value) { }

	// RVA: 0x13B9B98
	public Int64 get_timerMonitorIndex() { }

	// RVA: 0x13B9BA0
	public void set_timerMonitorIndex(Int64 value) { }

	// RVA: 0x13B3BD8
	public bool get_isTimerRunning() { }

	// RVA: 0x13B6A7C
	public void set_isTimerRunning(bool value) { }

	// RVA: 0x13B9BA8
	public InputActionPhase get_phase() { }

	// RVA: 0x13B3B54
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

	// RVA: 0x13B9BB0
	public int get_controlStartIndex() { }

	// RVA: 0x13B9BB8
	public void set_controlStartIndex(int value) { }

	// RVA: 0x13B9C50
	public int get_controlCount() { }

	// RVA: 0x13B9C58
	public void set_controlCount(int value) { }

	// RVA: 0x13B2864
	public int get_interactionStartIndex() { }

	// RVA: 0x13B9CF0
	public void set_interactionStartIndex(int value) { }

	// RVA: 0x13B9D94
	public int get_interactionCount() { }

	// RVA: 0x13B9D9C
	public void set_interactionCount(int value) { }

	// RVA: 0x13B7CE0
	public int get_processorStartIndex() { }

	// RVA: 0x13B9E34
	public void set_processorStartIndex(int value) { }

	// RVA: 0x13B9ED8
	public int get_processorCount() { }

	// RVA: 0x13B9EE0
	public void set_processorCount(int value) { }

	// RVA: 0x13B37D0
	public int get_actionIndex() { }

	// RVA: 0x13B9F78
	public void set_actionIndex(int value) { }

	// RVA: 0x13BA01C
	public int get_mapIndex() { }

	// RVA: 0x13BA024
	public void set_mapIndex(int value) { }

	// RVA: 0x13B0F90
	public int get_compositeOrCompositeBindingIndex() { }

	// RVA: 0x13BA0BC
	public void set_compositeOrCompositeBindingIndex(int value) { }

	// RVA: 0x13BA160
	public int get_triggerEventIdForComposite() { }

	// RVA: 0x13BA168
	public void set_triggerEventIdForComposite(int value) { }

	// RVA: 0x13BA170
	public Double get_pressTime() { }

	// RVA: 0x13BA178
	public void set_pressTime(Double value) { }

	// RVA: 0x13BA180
	public Flags get_flags() { }

	// RVA: 0x13BA188
	public void set_flags(Flags value) { }

	// RVA: 0x13BA190
	public bool get_chainsWithNext() { }

	// RVA: 0x13BA19C
	public void set_chainsWithNext(bool value) { }

	// RVA: 0x13BA1B0
	public bool get_isEndOfChain() { }

	// RVA: 0x13BA1BC
	public void set_isEndOfChain(bool value) { }

	// RVA: 0x13BA1DC
	public bool get_isPartOfChain() { }

	// RVA: 0x13B1EF0
	public bool get_isComposite() { }

	// RVA: 0x13BA1EC
	public void set_isComposite(bool value) { }

	// RVA: 0x13B0F84
	public bool get_isPartOfComposite() { }

	// RVA: 0x13BA20C
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x13B514C
	public bool get_initialStateCheckPending() { }

	// RVA: 0x13B3800
	public void set_initialStateCheckPending(bool value) { }

	// RVA: 0x13B37F4
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x13BA22C
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x13BA24C
	public int get_partIndex() { }

	// RVA: 0x13BA254
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
	internal int framePerformed; // 0x44
	internal int framePressed; // 0x48
	internal int frameReleased; // 0x4C
	internal int frameCompleted; // 0x50

	// Methods

	// RVA: 0x13BA25C
	public InputActionPhase get_phase() { }

	// RVA: 0x13B37C8
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x13B37E4
	public bool get_isDisabled() { }

	// RVA: 0x13BA264
	public bool get_isWaiting() { }

	// RVA: 0x13BA274
	public bool get_isStarted() { }

	// RVA: 0x13B70B0
	public bool get_isPerformed() { }

	// RVA: 0x13BA284
	public bool get_isCanceled() { }

	// RVA: 0x13BA294
	public Double get_time() { }

	// RVA: 0x13BA29C
	public void set_time(Double value) { }

	// RVA: 0x13BA2A4
	public Double get_startTime() { }

	// RVA: 0x13BA2AC
	public void set_startTime(Double value) { }

	// RVA: 0x13BA2B4
	public float get_magnitude() { }

	// RVA: 0x13B3AB0
	public void set_magnitude(float value) { }

	// RVA: 0x13BA2BC
	public bool get_haveMagnitude() { }

	// RVA: 0x13BA2C8
	public int get_mapIndex() { }

	// RVA: 0x13B3BE4
	public void set_mapIndex(int value) { }

	// RVA: 0x13B2850
	public int get_controlIndex() { }

	// RVA: 0x13B3A34
	public void set_controlIndex(int value) { }

	// RVA: 0x13BA2D0
	public int get_bindingIndex() { }

	// RVA: 0x13B375C
	public void set_bindingIndex(int value) { }

	// RVA: 0x13B3AC4
	public int get_interactionIndex() { }

	// RVA: 0x13B3AD8
	public void set_interactionIndex(int value) { }

	// RVA: 0x13BA2D8
	public UInt32 get_lastPerformedInUpdate() { }

	// RVA: 0x13BA2E0
	public void set_lastPerformedInUpdate(UInt32 value) { }

	// RVA: 0x13BA2E8
	public UInt32 get_lastCompletedInUpdate() { }

	// RVA: 0x13BA2F0
	public void set_lastCompletedInUpdate(UInt32 value) { }

	// RVA: 0x13BA2F8
	public UInt32 get_lastCanceledInUpdate() { }

	// RVA: 0x13BA300
	public void set_lastCanceledInUpdate(UInt32 value) { }

	// RVA: 0x13BA308
	public UInt32 get_pressedInUpdate() { }

	// RVA: 0x13BA310
	public void set_pressedInUpdate(UInt32 value) { }

	// RVA: 0x13BA318
	public UInt32 get_releasedInUpdate() { }

	// RVA: 0x13BA320
	public void set_releasedInUpdate(UInt32 value) { }

	// RVA: 0x13B42E0
	public bool get_isPassThrough() { }

	// RVA: 0x13B5B74
	public void set_isPassThrough(bool value) { }

	// RVA: 0x13B5B94
	public bool get_isButton() { }

	// RVA: 0x13B5BA0
	public void set_isButton(bool value) { }

	// RVA: 0x13B6980
	public bool get_isPressed() { }

	// RVA: 0x13B4700
	public void set_isPressed(bool value) { }

	// RVA: 0x13B698C
	public bool get_mayNeedConflictResolution() { }

	// RVA: 0x13BA328
	public void set_mayNeedConflictResolution(bool value) { }

	// RVA: 0x13B6998
	public bool get_hasMultipleConcurrentActuations() { }

	// RVA: 0x13B46C0
	public void set_hasMultipleConcurrentActuations(bool value) { }

	// RVA: 0x13B742C
	public bool get_inProcessing() { }

	// RVA: 0x13B46E0
	public void set_inProcessing(bool value) { }

	// RVA: 0x13BA348
	public Flags get_flags() { }

	// RVA: 0x13B7438
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

	// RVA: 0x13BA350
	public bool get_isAllocated() { }

	// RVA: 0x13BA360
	public int get_sizeInBytes() { }

	// RVA: 0x13BA3B0
	public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) { }

	// RVA: 0x13B1588
	public void Dispose() { }

	// RVA: 0x13BA4E4
	public void CopyDataFrom(UnmanagedMemory memory) { }

	// RVA: 0x13B1778
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
	public static TypedRestore <>9__140_0; // 0x8
	public static Action <>9__140_1; // 0x10

	// Methods

	// RVA: 0x13BA654
	private static void .cctor() { }

	// RVA: 0x13BA6C0
	public void .ctor() { }

	// RVA: 0x13BA6C8
	internal void <SaveAndResetState>b__140_0(GlobalState state) { }

	// RVA: 0x13BA7C4
	internal void <SaveAndResetState>b__140_1() { }

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
	private static readonly ProfilerMarker k_InputInitialActionStateCheckMarker; // 0x0
	private static readonly ProfilerMarker k_InputActionResolveConflictMarker; // 0x8
	private static readonly ProfilerMarker k_InputActionCallbackMarker; // 0x10
	private static readonly ProfilerMarker k_InputOnActionChangeMarker; // 0x18
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; // 0x20
	internal static GlobalState s_GlobalState; // 0x28

	// Methods

	// RVA: 0x13B0AB4
	public int get_totalCompositeCount() { }

	// RVA: 0x13B0ABC
	public int get_totalMapCount() { }

	// RVA: 0x13B0AC4
	public int get_totalActionCount() { }

	// RVA: 0x13B0ACC
	public int get_totalBindingCount() { }

	// RVA: 0x13B0AD4
	public int get_totalInteractionCount() { }

	// RVA: 0x13B0ADC
	public int get_totalControlCount() { }

	// RVA: 0x13B0AE4
	public ActionMapIndices* get_mapIndices() { }

	// RVA: 0x13B0AEC
	public TriggerState* get_actionStates() { }

	// RVA: 0x13B0AF4
	public BindingState* get_bindingStates() { }

	// RVA: 0x13B0AFC
	public InteractionState* get_interactionStates() { }

	// RVA: 0x13B0B04
	public Int32* get_controlIndexToBindingIndex() { }

	// RVA: 0x13B0B0C
	public UInt16* get_controlGroupingAndComplexity() { }

	// RVA: 0x13B0B14
	public Single* get_controlMagnitudes() { }

	// RVA: 0x13B0B1C
	public UInt32* get_enabledControls() { }

	// RVA: 0x13B0B24
	public bool get_isProcessingControlStateChange() { }

	// RVA: 0x13B0B2C
	public void Initialize(InputBindingResolver resolver) { }

	// RVA: 0x13B0D98
	private void ComputeControlGroupingIfNecessary() { }

	// RVA: 0x13B0C0C
	public void ClaimDataFrom(InputBindingResolver resolver) { }

	// RVA: 0x13B0FA4
	protected override void Finalize() { }

	// RVA: 0x13B1244
	public void Dispose() { }

	// RVA: 0x13B1084
	private void Destroy(bool isFinalizing) { }

	// RVA: 0x13B15D0
	public InputActionState Clone() { }

	// RVA: 0x13B193C
	private object System.ICloneable.Clone() { }

	// RVA: 0x13B1940
	private bool IsUsingDevice(InputDevice device) { }

	// RVA: 0x13B1B40
	private bool CanUseDevice(InputDevice device) { }

	// RVA: 0x13B1D90
	public bool HasEnabledActions() { }

	// RVA: 0x13B1E10
	private void FinishBindingCompositeSetups() { }

	// RVA: 0x13B1F08
	internal void PrepareForBindingReResolution(bool needFullResolve, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& activeControls, bool hasEnabledActions) { }

	// RVA: 0x13B2D14
	public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x13B2DBC
	private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x13B401C
	private bool IsActiveControl(int bindingIndex, int controlIndex) { }

	// RVA: 0x13B39C8
	private int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	// RVA: 0x13B40C8
	private void ResetActionStatesDrivenBy(InputDevice device) { }

	// RVA: 0x13B42EC
	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	// RVA: 0x13B29B0
	public void ResetActionState(int actionIndex, InputActionPhase toPhase, bool hardReset) { }

	// RVA: 0x13B4720
	public TriggerState FetchActionState(InputAction action) { }

	// RVA: 0x13B4748
	public ActionMapIndices FetchMapIndices(InputActionMap map) { }

	// RVA: 0x13B4780
	public void EnableAllActions(InputActionMap map) { }

	// RVA: 0x13B48D4
	private void EnableControls(InputActionMap map) { }

	// RVA: 0x13B4918
	public void EnableSingleAction(InputAction action) { }

	// RVA: 0x13B49E0
	private void EnableControls(InputAction action) { }

	// RVA: 0x13B2660
	public void DisableAllActions(InputActionMap map) { }

	// RVA: 0x13B2B74
	public void DisableControls(InputActionMap map) { }

	// RVA: 0x13B4AA4
	public void DisableSingleAction(InputAction action) { }

	// RVA: 0x13B4B60
	private void DisableControls(InputAction action) { }

	// RVA: 0x13B3820
	private void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x13B124C
	private void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x13B4CF8
	public void SetInitialStateCheckPending(int actionIndex, bool value) { }

	// RVA: 0x13B4C70
	private void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) { }

	// RVA: 0x13B4C24
	private bool IsControlEnabled(int controlIndex) { }

	// RVA: 0x13B4CBC
	private void SetControlEnabled(int controlIndex, bool state) { }

	// RVA: 0x13B3DDC
	private void HookOnBeforeUpdate() { }

	// RVA: 0x13B4D94
	private void UnhookOnBeforeUpdate() { }

	// RVA: 0x13B4E14
	private void OnBeforeInitialUpdate() { }

	// RVA: 0x13B5158
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 mapControlAndBindingIndex) { }

	// RVA: 0x13B57FC
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 mapControlAndBindingIndex, int interactionIndex) { }

	// RVA: 0x13B4C48
	private Int64 ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x13B5170
	private void SplitUpMapAndControlAndBindingIndex(Int64 mapControlAndBindingIndex, int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x13B5B6C
	internal static int GetComplexityFromMonitorIndex(Int64 mapControlAndBindingIndex) { }

	// RVA: 0x13B518C
	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x13B6278
	private void ProcessButtonState(TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) { }

	// RVA: 0x13B5BC0
	private static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) { }

	// RVA: 0x13B5E54
	private bool IsConflictingInput(TriggerState trigger, int actionIndex) { }

	// RVA: 0x13B43AC
	private UInt16 GetActionBindingStartIndexAndCount(int actionIndex, UInt16 bindingCount) { }

	// RVA: 0x13B6460
	private void ProcessDefaultInteraction(TriggerState trigger, int actionIndex) { }

	// RVA: 0x13B5C20
	private void ProcessInteractions(TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	// RVA: 0x13B5814
	private void ProcessTimeout(Double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	// RVA: 0x13B6A90
	internal void SetTotalTimeoutCompletionTime(float seconds, TriggerState trigger) { }

	// RVA: 0x13B3C50
	internal void StartTimeout(float seconds, TriggerState trigger) { }

	// RVA: 0x13B6AC0
	private void StopTimeout(int interactionIndex) { }

	// RVA: 0x13B6BA4
	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, TriggerState trigger, InputActionPhase phaseAfterPerformed, InputActionPhase phaseAfterCanceled, bool processNextInteractionOnCancel) { }

	// RVA: 0x13B447C
	private bool ChangePhaseOfAction(InputActionPhase newPhase, TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled) { }

	// RVA: 0x13B70C0
	private void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, TriggerState trigger, bool isDisablingAction) { }

	// RVA: 0x13B7440
	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>& listeners, string callbackName) { }

	// RVA: 0x13B7694
	private object GetActionOrNoneString(TriggerState trigger) { }

	// RVA: 0x13B7794
	internal InputAction GetActionOrNull(int bindingIndex) { }

	// RVA: 0x13B76FC
	internal InputAction GetActionOrNull(TriggerState trigger) { }

	// RVA: 0x13B782C
	internal InputControl GetControl(TriggerState trigger) { }

	// RVA: 0x13B7870
	private IInputInteraction GetInteractionOrNull(TriggerState trigger) { }

	// RVA: 0x13B78C0
	internal int GetBindingIndexInMap(int bindingIndex) { }

	// RVA: 0x13B78FC
	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	// RVA: 0x13B7928
	internal BindingState GetBindingState(int bindingIndex) { }

	// RVA: 0x13B7938
	internal InputBinding GetBinding(int bindingIndex) { }

	// RVA: 0x13B79B8
	internal InputActionMap GetActionMap(int bindingIndex) { }

	// RVA: 0x13B43CC
	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	// RVA: 0x13B288C
	private void ResetInteractionState(int interactionIndex) { }

	// RVA: 0x13B79FC
	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	// RVA: 0x13B7A94
	internal Type GetValueType(int bindingIndex, int controlIndex) { }

	// RVA: 0x13B69A4
	internal static bool IsActuated(TriggerState trigger, float threshold) { }

	// RVA: 0x13B7B2C
	internal void ReadValue(int bindingIndex, int controlIndex, Void* buffer, int bufferSize, bool ignoreComposites) { }

	// RVA: 0x318DB98
	internal TValue ReadValue(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x318DB98
	internal TValue ApplyProcessors(int bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType) { }

	// RVA: 0x13B7CF4
	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	// RVA: 0x13B7DD8
	internal Double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	// RVA: 0x318DB98
	internal TValue ReadCompositePartValue(int bindingIndex, int partNumber, Boolean* buttonValuePtr, int controlIndex, TComparer comparer) { }

	// RVA: 0x13B7E60
	internal bool ReadCompositePartValue(int bindingIndex, int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x13B804C
	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	// RVA: 0x13B8218
	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x13B83B8
	internal bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	// RVA: 0x13B84F0
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x13B0CE8
	private void AddToGlobalList() { }

	// RVA: 0x13B13F0
	private void RemoveMapFromGlobalList() { }

	// RVA: 0x13B8774
	private static void CompactGlobalList() { }

	// RVA: 0x13B2BB8
	internal void NotifyListenersOfActionChange(InputActionChange change) { }

	// RVA: 0x13B3EF8
	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	// RVA: 0x13B89B4
	private static void ResetGlobals() { }

	// RVA: 0x13B8D2C
	internal static int FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result) { }

	// RVA: 0x13B915C
	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x13B94D0
	internal static void DeferredResolutionOfBindings() { }

	// RVA: 0x13B9840
	internal static void DisableAllActions() { }

	// RVA: 0x13B8B48
	internal static void DestroyAllActionMapStates() { }

	// RVA: 0x13B1770
	public void .ctor() { }

	// RVA: 0x13B99C8
	private static void .cctor() { }

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

	// RVA: 0x13BB8EC
	private static void .cctor() { }

	// RVA: 0x13BB958
	public void .ctor() { }

	// RVA: 0x13BB960
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

	// RVA: 0x13BA82C
	public string get_name() { }

	// RVA: 0x13BA834
	public void set_name(string value) { }

	// RVA: 0x13BA83C
	public Guid get_id() { }

	// RVA: 0x13BA8A0
	public void set_id(Guid value) { }

	// RVA: 0x13BA8E4
	public string get_path() { }

	// RVA: 0x13BA8EC
	public void set_path(string value) { }

	// RVA: 0x13BA8F4
	public string get_overridePath() { }

	// RVA: 0x13BA8FC
	public void set_overridePath(string value) { }

	// RVA: 0x13BA904
	public string get_interactions() { }

	// RVA: 0x13BA90C
	public void set_interactions(string value) { }

	// RVA: 0x13BA914
	public string get_overrideInteractions() { }

	// RVA: 0x13BA91C
	public void set_overrideInteractions(string value) { }

	// RVA: 0x13BA924
	public string get_processors() { }

	// RVA: 0x13BA92C
	public void set_processors(string value) { }

	// RVA: 0x13BA934
	public string get_overrideProcessors() { }

	// RVA: 0x13BA93C
	public void set_overrideProcessors(string value) { }

	// RVA: 0x13BA944
	public string get_groups() { }

	// RVA: 0x13BA94C
	public void set_groups(string value) { }

	// RVA: 0x13BA954
	public string get_action() { }

	// RVA: 0x13BA95C
	public void set_action(string value) { }

	// RVA: 0x13AFCFC
	public bool get_isComposite() { }

	// RVA: 0x13BA964
	public void set_isComposite(bool value) { }

	// RVA: 0x13AFD08
	public bool get_isPartOfComposite() { }

	// RVA: 0x13B0164
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x13BA984
	public bool get_hasOverrides() { }

	// RVA: 0x13BA9B4
	public void .ctor(string path, string action, string groups, string processors, string interactions, string name) { }

	// RVA: 0x13BAA8C
	public string GetNameOfComposite() { }

	// RVA: 0x13BAADC
	internal void GenerateId() { }

	// RVA: 0x13BAB28
	internal void RemoveOverrides() { }

	// RVA: 0x13BAB6C
	public static InputBinding MaskByGroup(string group) { }

	// RVA: 0x13BABD8
	public static InputBinding MaskByGroups(string[] groups) { }

	// RVA: 0x13B1D78
	public string get_effectivePath() { }

	// RVA: 0x13BAD80
	public string get_effectiveInteractions() { }

	// RVA: 0x13BAD98
	public string get_effectiveProcessors() { }

	// RVA: 0x13BADB0
	internal bool get_isEmpty() { }

	// RVA: 0x13BAE1C
	public bool Equals(InputBinding other) { }

	// RVA: 0x13BAF40
	public override bool Equals(object obj) { }

	// RVA: 0x13B0A74
	public static bool op_Equality(InputBinding left, InputBinding right) { }

	// RVA: 0x13BAFF8
	public static bool op_Inequality(InputBinding left, InputBinding right) { }

	// RVA: 0x13BB060
	public override int GetHashCode() { }

	// RVA: 0x13BB174
	public override string ToString() { }

	// RVA: 0x13BB2B4
	public string ToDisplayString(DisplayStringOptions options, InputControl control) { }

	// RVA: 0x13BB2E4
	public string ToDisplayString(string deviceLayoutName, string controlPath, DisplayStringOptions options, InputControl control) { }

	// RVA: 0x13AFCA0
	internal bool TriggersAction(InputAction action) { }

	// RVA: 0x13BB734
	public bool Matches(InputBinding binding) { }

	// RVA: 0x13BB73C
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

	// RVA: 0x13BBD10
	public void .ctor(int <>1__state) { }

	// RVA: 0x13BBE6C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13BBE70
	private bool MoveNext() { }

	// RVA: 0x13BC084
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13BC08C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13BC0CC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13BC0D4
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13BC17C
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

	// RVA: 0x13BB980
	public virtual float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13BB988
	protected virtual void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13B1EFC
	internal void CallFinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13BB98C
	internal static Type GetValueType(string composite) { }

	// RVA: 0x13BBAEC
	public static string GetExpectedControlLayoutName(string composite, string part) { }

	// RVA: 0x13BBC88
	internal static System.Collections.Generic.IEnumerable<System.String> GetPartNames(string composite) { }

	// RVA: 0x13BBD48
	internal static string GetDisplayFormatString(string composite) { }

	// RVA: 0x13BBE64
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputBindingComposite<T0>
{
	// Methods

	// RVA: 0x30D3CF0
	public override Type get_valueType() { }

	// RVA: 0x30D39B8
	public override int get_valueSizeInBytes() { }

	// RVA: -1
	public abstract TValue ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x318DB98
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x30D3DA0
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
public struct PartBinding
{
	// Fields
	private int <part>k__BackingField; // 0x10
	private InputControl <control>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13BC3F4
	public int get_part() { }

	// RVA: 0x13BC3FC
	public void set_part(int value) { }

	// RVA: 0x13BC404
	public InputControl get_control() { }

	// RVA: 0x13BC40C
	public void set_control(InputControl value) { }

}

// Namespace: 
private struct DefaultComparer<T0>
{
	// Methods

	// RVA: 0x318DB98
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

	// RVA: 0x13BC20C
	public void .ctor(int <>1__state) { }

	// RVA: 0x13BC414
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13BC418
	private bool MoveNext() { }

	// RVA: 0x13BC560
	private PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current() { }

	// RVA: 0x13BC56C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13BC5AC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13BC614
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() { }

	// RVA: 0x13BC6C0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public struct InputBindingCompositeContext
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal int m_BindingIndex; // 0x18

	// Methods

	// RVA: 0x13BC180
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls() { }

	// RVA: 0x13BC244
	public float EvaluateMagnitude(int partNumber) { }

	// RVA: 0x318DB98
	public TValue ReadValue(int partNumber) { }

	// RVA: 0x318DB98
	public TValue ReadValue(int partNumber, InputControl sourceControl) { }

	// RVA: 0x318DB98
	public TValue ReadValue(int partNumber, TComparer comparer) { }

	// RVA: 0x318DB98
	public TValue ReadValue(int partNumber, InputControl sourceControl, TComparer comparer) { }

	// RVA: 0x13BC26C
	public bool ReadValueAsButton(int partNumber) { }

	// RVA: 0x13BC304
	public void ReadValue(int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x13BC328
	public object ReadValueAsObject(int partNumber) { }

	// RVA: 0x13BC350
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

	// RVA: 0x13BC6C4
	public int get_totalMapCount() { }

	// RVA: 0x13BC6CC
	public int get_totalActionCount() { }

	// RVA: 0x13BC6D4
	public int get_totalBindingCount() { }

	// RVA: 0x13BC6DC
	public int get_totalControlCount() { }

	// RVA: 0x13BC6E4
	public void Dispose() { }

	// RVA: 0x13BC730
	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

	// RVA: 0x13BC8D0
	public void AddActionMap(InputActionMap actionMap) { }

	// RVA: 0x318DB98
	private int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, TType[] array, int count, InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x13BE3C8
	private static InputBindingComposite InstantiateBindingComposite(InputBinding binding, InputActionMap actionMap) { }

	// RVA: 0x13BE88C
	private static void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, InputActionMap actionMap, InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	// RVA: 0x13BE654
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

	// RVA: 0x13DBDF0
	public InputControl get_control() { }

	// RVA: 0x13DBE48
	public InputDevice get_device() { }

	// RVA: 0x13DBEAC
	public int get_requirementIndex() { }

	// RVA: 0x13DBEB4
	public DeviceRequirement get_requirement() { }

	// RVA: 0x13DBEEC
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

	// RVA: 0x13DBF34
	public bool MoveNext() { }

	// RVA: 0x13DBF60
	public void Reset() { }

	// RVA: 0x13DBF6C
	public Match get_Current() { }

	// RVA: 0x13DC028
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13DC094
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

	// RVA: 0x13DB9F4
	public float get_score() { }

	// RVA: 0x13DB9FC
	public bool get_isSuccessfulMatch() { }

	// RVA: 0x13DBA0C
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x13DBA1C
	public bool get_hasMissingOptionalDevices() { }

	// RVA: 0x13DBA2C
	public UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13DBB7C
	public Match get_Item(int index) { }

	// RVA: 0x13DBC3C
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator() { }

	// RVA: 0x13DBCDC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13DBD7C
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

	// RVA: 0x13DC098
	public string get_controlPath() { }

	// RVA: 0x13DC0A0
	public void set_controlPath(string value) { }

	// RVA: 0x13DBF28
	public bool get_isOptional() { }

	// RVA: 0x13DC0A8
	public void set_isOptional(bool value) { }

	// RVA: 0x13DC0BC
	public bool get_isAND() { }

	// RVA: 0x13DC0D8
	public void set_isAND(bool value) { }

	// RVA: 0x13DC0CC
	public bool get_isOR() { }

	// RVA: 0x13DC0F8
	public void set_isOR(bool value) { }

	// RVA: 0x13DC118
	public override string ToString() { }

	// RVA: 0x13DC1F4
	public bool Equals(DeviceRequirement other) { }

	// RVA: 0x13DC27C
	public override bool Equals(object obj) { }

	// RVA: 0x13DC350
	public override int GetHashCode() { }

	// RVA: 0x13DB644
	public static bool op_Equality(DeviceRequirement left, DeviceRequirement right) { }

	// RVA: 0x13DC45C
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

	// RVA: 0x13DC6A8
	public DeviceRequirement ToDeviceEntry() { }

	// RVA: 0x13DC890
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

	// RVA: 0x13DC4C0
	public InputControlScheme ToScheme() { }

	// RVA: 0x13DC6FC
	public static SchemeJson ToJson(InputControlScheme scheme) { }

	// RVA: 0x13DC8D8
	public static SchemeJson[] ToJson(InputControlScheme[] schemes) { }

	// RVA: 0x13DCA14
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

	// RVA: 0x13DB0C4
	public string get_name() { }

	// RVA: 0x13DB0CC
	public string get_bindingGroup() { }

	// RVA: 0x13DB0D4
	public void set_bindingGroup(string value) { }

	// RVA: 0x13DB0DC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements() { }

	// RVA: 0x13DB148
	public void .ctor(string name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, string bindingGroup) { }

	// RVA: 0x13DB27C
	internal void SetNameAndBindingGroup(string name, string bindingGroup) { }

	// RVA: 0x318DB98
	public static System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch) { }

	// RVA: 0x318DB98
	public static bool FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputControlScheme controlScheme, MatchResult matchResult, InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch) { }

	// RVA: 0x318DB98
	public static System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice(InputDevice device, TSchemes schemes) { }

	// RVA: 0x13DB360
	public bool SupportsDevice(InputDevice device) { }

	// RVA: 0x318DB98
	public MatchResult PickDevicesFrom(TDevices devices, InputDevice favorDevice) { }

	// RVA: 0x13DB4D0
	public bool Equals(InputControlScheme other) { }

	// RVA: 0x13DB6AC
	public override bool Equals(object obj) { }

	// RVA: 0x13DB754
	public override int GetHashCode() { }

	// RVA: 0x13DB7EC
	public override string ToString() { }

	// RVA: 0x13DB990
	public static bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	// RVA: 0x13DB9C0
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

	// RVA: 0x13DCB2C
	public InputAction get_action() { }

	// RVA: 0x13DCB54
	public InputControl get_control() { }

	// RVA: 0x13DCB7C
	public InputActionPhase get_phase() { }

	// RVA: 0x13DCB84
	public Double get_time() { }

	// RVA: 0x13DCB8C
	public Double get_startTime() { }

	// RVA: 0x13DCB94
	public bool get_timerHasExpired() { }

	// RVA: 0x13DCBA0
	internal void set_timerHasExpired(bool value) { }

	// RVA: 0x13DCBC0
	public bool get_isWaiting() { }

	// RVA: 0x13DCBD0
	public bool get_isStarted() { }

	// RVA: 0x13DCBE0
	public float ComputeMagnitude() { }

	// RVA: 0x13DCBE8
	public bool ControlIsActuated(float threshold) { }

	// RVA: 0x13DCC5C
	public void Started() { }

	// RVA: 0x13DCC9C
	public void Performed() { }

	// RVA: 0x13DCCE4
	public void PerformedAndStayStarted() { }

	// RVA: 0x13DCD2C
	public void PerformedAndStayPerformed() { }

	// RVA: 0x13DCD74
	public void Canceled() { }

	// RVA: 0x13DCDBC
	public void Waiting() { }

	// RVA: 0x13DCE04
	public void SetTimeout(float seconds) { }

	// RVA: 0x13DCE2C
	public void SetTotalTimeoutCompletionTime(float seconds) { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x13DCEC0
	internal int get_mapIndex() { }

	// RVA: 0x13DCEC8
	internal int get_controlIndex() { }

	// RVA: 0x13DCED4
	internal int get_bindingIndex() { }

	// RVA: 0x13DCEDC
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
	public static System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputControl> <>9__80_0; // 0x8
	public static System.Func<UnityEngine.InputSystem.InputControl,System.Boolean> <>9__80_1; // 0x10

	// Methods

	// RVA: 0x13E3210
	private static void .cctor() { }

	// RVA: 0x13E327C
	public void .ctor() { }

	// RVA: 0x13E3284
	internal InputControl <get_onAnyButtonPress>b__80_0(InputEventPtr e) { }

	// RVA: 0x13E34E0
	internal bool <get_onAnyButtonPress>b__80_1(InputControl c) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputSystem
{
	// Fields
	internal const string kAssemblyVersion = "1.14.0";
	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14";
	private static readonly ProfilerMarker k_InputResetMarker; // 0x0
	internal const float scrollWheelDeltaPerTick = 1;
	internal static InputManager s_Manager; // 0x8
	internal static InputRemoting s_Remote; // 0x10

	// Methods

	// RVA: 0x13DCEE8
	public static void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13DD028
	public static void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13DD168
	public static void RegisterLayout(Type type, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x318DB98
	public static void RegisterLayout(string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x13DD360
	public static void RegisterLayout(string json, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x13DD4B0
	public static void RegisterLayoutOverride(string json, string name) { }

	// RVA: 0x13DD54C
	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x318DB98
	public static void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x13DD5E4
	public static void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x30DA164
	public static void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x13DD7A0
	public static void RemoveLayout(string name) { }

	// RVA: 0x13DD830
	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x13DD8CC
	public static System.Collections.Generic.IEnumerable<System.String> ListLayouts() { }

	// RVA: 0x13DD950
	public static System.Collections.Generic.IEnumerable<System.String> ListLayoutsBasedOn(string baseLayout) { }

	// RVA: 0x13DDA18
	public static InputControlLayout LoadLayout(string name) { }

	// RVA: 0x30D77AC
	public static InputControlLayout LoadLayout() { }

	// RVA: 0x13DDB04
	public static string GetNameOfBaseLayout(string layoutName) { }

	// RVA: 0x13DDC34
	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	// RVA: 0x13DDD94
	public static void RegisterProcessor(Type type, string name) { }

	// RVA: 0x30DA164
	public static void RegisterProcessor(string name) { }

	// RVA: 0x13DE22C
	public static Type TryGetProcessor(string name) { }

	// RVA: 0x13DE30C
	public static System.Collections.Generic.IEnumerable<System.String> ListProcessors() { }

	// RVA: 0x13DE3A4
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13DE424
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices() { }

	// RVA: 0x13DE4DC
	public static void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13DE660
	public static void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13DE7E4
	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13DE968
	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13DEAEC
	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13DEC2C
	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13DED6C
	public static float get_pollingFrequency() { }

	// RVA: 0x13DEDEC
	public static void set_pollingFrequency(float value) { }

	// RVA: 0x13DEE7C
	public static InputDevice AddDevice(string layout, string name, string variants) { }

	// RVA: 0x318DB98
	public static TDevice AddDevice(string name) { }

	// RVA: 0x13DEF80
	public static InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x13DF080
	public static void AddDevice(InputDevice device) { }

	// RVA: 0x13DF13C
	public static void RemoveDevice(InputDevice device) { }

	// RVA: 0x13DF1D0
	public static void FlushDisconnectedDevices() { }

	// RVA: 0x13DF250
	public static InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x318DB98
	public static TDevice GetDevice() { }

	// RVA: 0x13DF2E0
	public static InputDevice GetDevice(Type type) { }

	// RVA: 0x318DB98
	public static TDevice GetDevice(InternedString usage) { }

	// RVA: 0x318DB98
	public static TDevice GetDevice(string usage) { }

	// RVA: 0x13DF5F8
	public static InputDevice GetDeviceById(int deviceId) { }

	// RVA: 0x13DF688
	public static System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices() { }

	// RVA: 0x13DF794
	public static int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x13DF824
	public static void EnableDevice(InputDevice device) { }

	// RVA: 0x13DF8BC
	public static void DisableDevice(InputDevice device, bool keepSendingEvents) { }

	// RVA: 0x13DF958
	public static bool TrySyncDevice(InputDevice device) { }

	// RVA: 0x13DFB1C
	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls) { }

	// RVA: 0x13DFBB8
	public static bool TryResetDevice(InputDevice device) { }

	// RVA: 0x13DFD0C
	public static void PauseHaptics() { }

	// RVA: 0x13DFECC
	public static void ResumeHaptics() { }

	// RVA: 0x13E0090
	public static void ResetHaptics() { }

	// RVA: 0x13E0254
	public static void SetDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13E035C
	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13E0404
	public static void AddDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13E04A8
	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13E0550
	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x13E05F4
	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13E069C
	public static InputControl FindControl(string path) { }

	// RVA: 0x13E081C
	public static UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(string path) { }

	// RVA: 0x318DB98
	public static UnityEngine.InputSystem.InputControlList<TControl> FindControls(string path) { }

	// RVA: 0x30D6D88
	public static int FindControls(string path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x13E08B0
	internal static bool get_isProcessingEvents() { }

	// RVA: 0x13E0930
	public static InputEventListener get_onEvent() { }

	// RVA: 0x13E0938
	public static void set_onEvent(InputEventListener value) { }

	// RVA: 0x13E093C
	public static System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress() { }

	// RVA: 0x13E0B7C
	public static void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x30DA164
	public static void QueueEvent(TEvent inputEvent) { }

	// RVA: 0x318DB98
	public static void QueueStateEvent(InputDevice device, TState state, Double time) { }

	// RVA: 0x318DB98
	public static void QueueDeltaStateEvent(InputControl control, TDelta delta, Double time) { }

	// RVA: 0x13E0C64
	public static void QueueConfigChangeEvent(InputDevice device, Double time) { }

	// RVA: 0x13E0E90
	public static void QueueTextEvent(InputDevice device, Char character, Double time) { }

	// RVA: 0x13E10CC
	public static void Update() { }

	// RVA: 0x13E114C
	internal static void Update(InputUpdateType updateType) { }

	// RVA: 0x13E1328
	public static void add_onBeforeUpdate(Action value) { }

	// RVA: 0x13E1468
	public static void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x13E15A8
	public static void add_onAfterUpdate(Action value) { }

	// RVA: 0x13E16E8
	public static void remove_onAfterUpdate(Action value) { }

	// RVA: 0x13E12A8
	public static InputSettings get_settings() { }

	// RVA: 0x13E1828
	public static void set_settings(InputSettings value) { }

	// RVA: 0x13E19AC
	public static void add_onSettingsChange(Action value) { }

	// RVA: 0x13E1A3C
	public static void remove_onSettingsChange(Action value) { }

	// RVA: 0x13E1ACC
	private static void EnableActions() { }

	// RVA: 0x13E1D18
	private static void DisableActions(bool triggerSetupChanged) { }

	// RVA: 0x13E1C8C
	public static InputActionAsset get_actions() { }

	// RVA: 0x13E1E80
	public static void set_actions(InputActionAsset value) { }

	// RVA: 0x13E1FF8
	public static void add_onActionsChange(Action value) { }

	// RVA: 0x13E2088
	public static void remove_onActionsChange(Action value) { }

	// RVA: 0x13E2118
	public static void add_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x13E21E8
	public static void remove_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x13E22B8
	public static void RegisterInteraction(Type type, string name) { }

	// RVA: 0x30DA164
	public static void RegisterInteraction(string name) { }

	// RVA: 0x13E2470
	public static Type TryGetInteraction(string name) { }

	// RVA: 0x13E2550
	public static System.Collections.Generic.IEnumerable<System.String> ListInteractions() { }

	// RVA: 0x13E25E8
	public static void RegisterBindingComposite(Type type, string name) { }

	// RVA: 0x30DA164
	public static void RegisterBindingComposite(string name) { }

	// RVA: 0x13E27A0
	public static Type TryGetBindingComposite(string name) { }

	// RVA: 0x13E2880
	public static void DisableAllEnabledActions() { }

	// RVA: 0x13E28F0
	public static System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions() { }

	// RVA: 0x13E2990
	public static int ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions) { }

	// RVA: 0x13E2A4C
	public static InputRemoting get_remoting() { }

	// RVA: 0x13E2AC8
	public static Version get_version() { }

	// RVA: 0x13E2B40
	public static bool get_runInBackground() { }

	// RVA: 0x13E2C44
	public static void set_runInBackground(bool value) { }

	// RVA: 0x13E2D48
	public static InputMetrics get_metrics() { }

	// RVA: 0x13E2E00
	private static void .cctor() { }

	// RVA: 0x13E3060
	private static void RunInitializeInPlayer() { }

	// RVA: 0x13E310C
	internal static void EnsureInitialized() { }

	// RVA: 0x13E2E88
	private static void InitializeInPlayer(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x13E3144
	private static void RunInitialUpdate() { }

	// RVA: 0x13E3110
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

	// RVA: 0x13E34EC
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

	// RVA: 0x13E3CF0
	public string get_name() { }

	// RVA: 0x13E3D00
	public string get_displayName() { }

	// RVA: 0x13E3DA8
	protected void set_displayName(string value) { }

	// RVA: 0x13E3DB0
	public string get_shortDisplayName() { }

	// RVA: 0x13E3E14
	protected void set_shortDisplayName(string value) { }

	// RVA: 0x13E3E1C
	public string get_path() { }

	// RVA: 0x13E401C
	public string get_layout() { }

	// RVA: 0x13E402C
	public string get_variants() { }

	// RVA: 0x13E403C
	public InputDevice get_device() { }

	// RVA: 0x13E4044
	public InputControl get_parent() { }

	// RVA: 0x13E404C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children() { }

	// RVA: 0x13E40C0
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x13E4134
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x13E41A8
	public InputStateBlock get_stateBlock() { }

	// RVA: 0x13E41B4
	public bool get_noisy() { }

	// RVA: 0x13E41C0
	internal void set_noisy(bool value) { }

	// RVA: 0x13E42F8
	public bool get_synthetic() { }

	// RVA: 0x13E4304
	internal void set_synthetic(bool value) { }

	// RVA: 0x13E4324
	public InputControl get_Item(string path) { }

	// RVA: -1
	public abstract Type get_valueType() { }

	// RVA: -1
	public abstract int get_valueSizeInBytes() { }

	// RVA: 0x13E4450
	public float get_magnitude() { }

	// RVA: 0x13E44C0
	public override string ToString() { }

	// RVA: 0x13E4568
	private string DebuggerDisplay() { }

	// RVA: 0x13E4488
	public float EvaluateMagnitude() { }

	// RVA: 0x13E476C
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	// RVA: -1
	public abstract object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: -1
	public abstract object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: -1
	public abstract void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x13E4774
	public virtual void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x13E47D8
	public virtual void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: -1
	public abstract bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13E483C
	public InputControl TryGetChildControl(string path) { }

	// RVA: 0x318DB98
	public TControl TryGetChildControl(string path) { }

	// RVA: 0x13E48F4
	public InputControl GetChildControl(string path) { }

	// RVA: 0x318DB98
	public TControl GetChildControl(string path) { }

	// RVA: 0x13E4B08
	protected void .ctor() { }

	// RVA: 0x13E4B98
	protected virtual void FinishSetup() { }

	// RVA: 0x13E3D68
	protected void RefreshConfigurationIfNeeded() { }

	// RVA: 0x13E4BBC
	protected virtual void RefreshConfiguration() { }

	// RVA: 0x13E4754
	protected internal Void* get_currentStatePtr() { }

	// RVA: 0x13E4D20
	protected internal Void* get_previousFrameStatePtr() { }

	// RVA: 0x13E4D38
	protected internal Void* get_defaultStatePtr() { }

	// RVA: 0x13E4D84
	protected internal Void* get_noiseMaskPtr() { }

	// RVA: 0x13E4DD0
	protected internal UInt32 get_stateOffsetRelativeToDeviceRoot() { }

	// RVA: 0x13E4E54
	public FourCC get_optimizedControlDataType() { }

	// RVA: 0x13E4E5C
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	// RVA: 0x13E4E64
	public void ApplyParameterChanges() { }

	// RVA: 0x13E53C8
	private void SetOptimizedControlDataType() { }

	// RVA: 0x13E5490
	internal void SetOptimizedControlDataTypeRecursively() { }

	// RVA: 0x13E56E4
	internal void EnsureOptimizationTypeHasNotChanged() { }

	// RVA: 0x13E5B48
	internal bool get_isSetupFinished() { }

	// RVA: 0x13E5B54
	internal void set_isSetupFinished(bool value) { }

	// RVA: 0x13E5B74
	internal bool get_isButton() { }

	// RVA: 0x13E5B80
	internal void set_isButton(bool value) { }

	// RVA: 0x13E4B9C
	internal bool get_isConfigUpToDate() { }

	// RVA: 0x13E4BA8
	internal void set_isConfigUpToDate(bool value) { }

	// RVA: 0x13E5BA0
	internal bool get_dontReset() { }

	// RVA: 0x13E5BAC
	internal void set_dontReset(bool value) { }

	// RVA: 0x13E5BCC
	internal bool get_usesStateFromOtherControl() { }

	// RVA: 0x13E5BD8
	internal void set_usesStateFromOtherControl(bool value) { }

	// RVA: 0x13E5BF8
	internal bool get_hasDefaultState() { }

	// RVA: 0x13E5C18
	internal void CallFinishSetupRecursive() { }

	// RVA: 0x13E4A0C
	internal string MakeChildPath(string path) { }

	// RVA: 0x13E5D44
	internal void BakeOffsetIntoStateBlockRecursive(UInt32 offset) { }

	// RVA: 0x13E4BC0
	internal int GetDeviceIndex() { }

	// RVA: 0x13E5EA0
	internal bool IsValueConsideredPressed(float value) { }

	// RVA: 0x13E5F54
	internal virtual void AddProcessor(object first) { }

	// RVA: 0x13E5F58
	internal void MarkAsStale() { }

	// RVA: 0x13E51C8
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

	// RVA: 0x30D3CF0
	public override Type get_valueType() { }

	// RVA: 0x30D39B8
	public override int get_valueSizeInBytes() { }

	// RVA: 0x30D3CF0
	public TValue get_value() { }

	// RVA: 0x30D3CF0
	internal TValue get_unprocessedValue() { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x318DB98
	public TValue ReadValueFromPreviousFrame() { }

	// RVA: 0x318DB98
	public TValue ReadDefaultValue() { }

	// RVA: 0x318DB98
	public TValue ReadValueFromState(Void* statePtr) { }

	// RVA: 0x318DB98
	public TValue ReadValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x318DB98
	public TValue ReadUnprocessedValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x318DB98
	public TValue ReadUnprocessedValue() { }

	// RVA: -1
	public abstract TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x318DB98
	public override object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x318DB98
	public override void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x318DB98
	public override void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x318DB98
	public override void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: 0x318DB98
	public virtual void WriteValueIntoState(TValue value, Void* statePtr) { }

	// RVA: 0x318DB98
	public override object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x30D6128
	private static bool CompareValue(TValue firstValue, TValue secondValue) { }

	// RVA: 0x318DB98
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x318DB98
	public TValue ProcessValue(TValue value) { }

	// RVA: 0x30D4CD4
	public void ProcessValue(TValue value) { }

	// RVA: 0x318DB98
	internal TProcessor TryGetProcessor() { }

	// RVA: 0x30D4CD4
	internal override void AddProcessor(object processor) { }

	// RVA: 0x30D488C
	protected override void FinishSetup() { }

	// RVA: 0x30D3CF0
	internal UnityEngine.InputSystem.InputProcessor<TValue>[] get_processors() { }

	// RVA: 0x30D488C
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

	// RVA: 0x13E8660
	public InputEventPtr get_eventPtr() { }

	// RVA: 0x13E7DDC
	public InputEventControlEnumerator GetEnumerator() { }

	// RVA: 0x13E8860
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x13E8908
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

	// RVA: 0x13E8668
	internal void .ctor(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold) { }

	// RVA: 0x13E8E2C
	private bool CheckDefault(UInt32 numBits) { }

	// RVA: 0x13E8E4C
	private bool CheckCurrent(UInt32 numBits) { }

	// RVA: 0x13E7E04
	public bool MoveNext() { }

	// RVA: 0x13E89B0
	public void Reset() { }

	// RVA: 0x13E8E84
	public void Dispose() { }

	// RVA: 0x13E8E8C
	public InputControl get_Current() { }

	// RVA: 0x13E8E94
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ControlBuilder
{
	// Fields
	private InputControl <control>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13E8E9C
	public InputControl get_control() { }

	// RVA: 0x13E8EA4
	internal void set_control(InputControl value) { }

	// RVA: 0x13E8EAC
	public ControlBuilder At(InputDevice device, int index) { }

	// RVA: 0x13E8FF4
	public ControlBuilder WithParent(InputControl parent) { }

	// RVA: 0x13E9028
	public ControlBuilder WithName(string name) { }

	// RVA: 0x13E9080
	public ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x13E90E0
	public ControlBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x13E9140
	public ControlBuilder WithLayout(InternedString layout) { }

	// RVA: 0x13E9178
	public ControlBuilder WithUsages(int startIndex, int count) { }

	// RVA: 0x13E9198
	public ControlBuilder WithAliases(int startIndex, int count) { }

	// RVA: 0x13E91B8
	public ControlBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x13E91D8
	public ControlBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x13E91FC
	public ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x13E9258
	public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) { }

	// RVA: 0x318DB98
	public ControlBuilder WithProcessor(TProcessor processor) { }

	// RVA: 0x13E9288
	public ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x13E92B8
	public ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x13E92F0
	public ControlBuilder DontReset(bool value) { }

	// RVA: 0x13E9360
	public ControlBuilder IsButton(bool value) { }

	// RVA: 0x13E9398
	public void Finish() { }

}

// Namespace: 
public struct DeviceBuilder
{
	// Fields
	private InputDevice <device>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13E93C0
	public InputDevice get_device() { }

	// RVA: 0x13E93C8
	internal void set_device(InputDevice value) { }

	// RVA: 0x13E93D0
	public DeviceBuilder WithName(string name) { }

	// RVA: 0x13E9428
	public DeviceBuilder WithDisplayName(string displayName) { }

	// RVA: 0x13E9488
	public DeviceBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x13E94E8
	public DeviceBuilder WithLayout(InternedString layout) { }

	// RVA: 0x13E9520
	public DeviceBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x13E9540
	public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x13E9564
	public DeviceBuilder IsNoisy(bool value) { }

	// RVA: 0x13E9594
	public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) { }

	// RVA: 0x13E9714
	public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) { }

	// RVA: 0x13E9768
	public DeviceBuilder WithStateOffsetToControlIndexMap(UInt32[] map) { }

	// RVA: 0x13E97A0
	public DeviceBuilder WithControlTree(Byte[] controlTreeNodes, UInt16[] controlTreeIndicies) { }

	// RVA: 0x13E9A88
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

	// RVA: 0x13E82F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x13EA04C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13EA06C
	private bool MoveNext() { }

	// RVA: 0x13EA34C
	private void <>m__Finally1() { }

	// RVA: 0x13EA35C
	private InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current() { }

	// RVA: 0x13EA364
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13EA3A4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13EA3AC
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x13EA45C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputControlExtensions
{
	// Methods

	// RVA: 0x318DB98
	public static TControl FindInParentChain(InputControl control) { }

	// RVA: 0x13E5F64
	public static bool IsPressed(InputControl control, float buttonPressPoint) { }

	// RVA: 0x13E60C4
	public static bool IsActuated(InputControl control, float threshold) { }

	// RVA: 0x13E46D0
	public static object ReadValueAsObject(InputControl control) { }

	// RVA: 0x13E62D0
	public static void ReadValueIntoBuffer(InputControl control, Void* buffer, int bufferSize) { }

	// RVA: 0x13E6390
	public static object ReadDefaultValueAsObject(InputControl control) { }

	// RVA: 0x318DB98
	public static TValue ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent) { }

	// RVA: -1
	public static bool ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, TValue value) { }

	// RVA: 0x13E6438
	public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	// RVA: 0x318DB98
	public static TValue ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr eventPtr) { }

	// RVA: -1
	public static bool ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, TValue value) { }

	// RVA: 0x13E658C
	public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	// RVA: 0x13E6620
	public static void WriteValueIntoState(InputControl control, Void* statePtr) { }

	// RVA: 0x318DB98
	public static void WriteValueIntoState(InputControl control, TValue value, Void* statePtr) { }

	// RVA: 0x318DB98
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Void* statePtr) { }

	// RVA: 0x318DB98
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, Void* statePtr) { }

	// RVA: 0x318DB98
	public static void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, TState state) { }

	// RVA: 0x318DB98
	public static void WriteValueIntoEvent(InputControl control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x318DB98
	public static void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x13E67A8
	public static void CopyState(InputDevice device, Void* buffer, int bufferSizeInBytes) { }

	// RVA: 0x30DB358
	public static void CopyState(InputDevice device, TState state) { }

	// RVA: 0x13E6250
	public static bool CheckStateIsAtDefault(InputControl control) { }

	// RVA: 0x13E6944
	public static bool CheckStateIsAtDefault(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x13E6BBC
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	// RVA: 0x13E6C38
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x13E6D0C
	public static bool CompareStateIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x13E6A20
	public static bool CompareState(InputControl control, Void* firstStatePtr, Void* secondStatePtr, Void* maskPtr) { }

	// RVA: 0x13E6DF4
	public static bool CompareState(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x13E6EAC
	public static bool HasValueChangeInState(InputControl control, Void* statePtr) { }

	// RVA: 0x13E6F5C
	public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13E64C8
	public static Void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13E703C
	internal static Void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	// RVA: 0x13E7364
	public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x318DB98
	public static void QueueValueChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x13E7538
	public static void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<System.Single> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x13E7648
	internal static void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x30DB884
	public static void FindControlsRecursive(InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl,System.Boolean> predicate) { }

	// RVA: 0x13E775C
	internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder) { }

	// RVA: 0x13E7AF0
	public static InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x13E7D7C
	public static InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x13E7DC0
	public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13E3294
	public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13E825C
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x13E8328
	public static ControlBuilder Setup(InputControl control) { }

	// RVA: 0x13E8408
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

	// RVA: 0x318DB98
	public void .ctor(UnityEngine.InputSystem.InputControlList<TControl> list) { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x318DB98
	public TControl get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D39B8
	public int get_Capacity() { }

	// RVA: 0x30D4A04
	public void set_Capacity(int value) { }

	// RVA: 0x30D3738
	public bool get_IsReadOnly() { }

	// RVA: 0x318DB98
	public TControl get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, TControl value) { }

	// RVA: 0x30D4A74
	public void .ctor(Allocator allocator, int initialCapacity) { }

	// RVA: 0x30D4D3C
	public void .ctor(System.Collections.Generic.IEnumerable<TControl> values, Allocator allocator) { }

	// RVA: 0x30D4CD4
	public void .ctor(TControl[] values) { }

	// RVA: 0x30D4A04
	public void Resize(int size) { }

	// RVA: 0x318DB98
	public void Add(TControl item) { }

	// RVA: 0x318DB98
	public void AddSlice(TList list, int count, int destinationIndex, int sourceIndex) { }

	// RVA: -1
	public void AddRange(System.Collections.Generic.IEnumerable<TControl> list, int count, int destinationIndex) { }

	// RVA: 0x318DB98
	public bool Remove(TControl item) { }

	// RVA: 0x30D4A04
	public void RemoveAt(int index) { }

	// RVA: 0x30D4D3C
	public void CopyTo(TControl[] array, int arrayIndex) { }

	// RVA: 0x318DB98
	public int IndexOf(TControl item) { }

	// RVA: 0x318DB98
	public int IndexOf(TControl item, int startIndex, int count) { }

	// RVA: 0x318DB98
	public void Insert(int index, TControl item) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool Contains(TControl item) { }

	// RVA: 0x318DB98
	public bool Contains(TControl item, int startIndex, int count) { }

	// RVA: 0x30D4A74
	public void SwapElements(int index1, int index2) { }

	// RVA: 0x318DB98
	public void Sort(int startIndex, int count, TCompare comparer) { }

	// RVA: -1
	public TControl[] ToArray(bool dispose) { }

	// RVA: 0x30D4F34
	internal void AppendTo(TControl[] array, int count) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<TControl> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

	// RVA: 0x318DB98
	private static UInt64 ToIndex(TControl control) { }

	// RVA: 0x318DB98
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

	// RVA: 0x13EDE00
	private static void .cctor() { }

	// RVA: 0x13EDE6C
	public void .ctor() { }

	// RVA: 0x13EDE74
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

	// RVA: 0x13EDA38
	public string get_layout() { }

	// RVA: 0x13EDA40
	public System.Collections.Generic.IEnumerable<System.String> get_usages() { }

	// RVA: 0x13EDB94
	public string get_name() { }

	// RVA: 0x13EDBA0
	public string get_displayName() { }

	// RVA: 0x13EBE6C
	internal bool get_isWildcard() { }

	// RVA: 0x13EDBAC
	internal bool get_isDoubleWildcard() { }

	// RVA: 0x13EB020
	internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, string referencedLayoutName, string controlPath, HumanReadableStringOptions options) { }

	// RVA: 0x13EDC1C
	private static string ToHumanReadableString(Substring substring) { }

	// RVA: 0x13ED074
	public bool Matches(InputControl control) { }

	// RVA: 0x13EDC84
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

	// RVA: 0x13EC678
	public bool get_isAtEnd() { }

	// RVA: 0x13EACD4
	public void .ctor(string path) { }

	// RVA: 0x13EAD28
	public bool MoveToNextComponent() { }

	// RVA: 0x13EDE9C
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

	// RVA: 0x13EDF9C
	private static void .cctor() { }

	// RVA: 0x13EE008
	public void .ctor() { }

	// RVA: 0x13EE010
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

	// RVA: 0x13EDA00
	public void .ctor(int <>1__state) { }

	// RVA: 0x13EE038
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13EE03C
	private bool MoveNext() { }

	// RVA: 0x13EE1C0
	private ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current() { }

	// RVA: 0x13EE1E4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13EE224
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13EE2A4
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() { }

	// RVA: 0x13EE34C
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

	// RVA: 0x13EA50C
	internal static string CleanSlashes(string pathComponent) { }

	// RVA: 0x13E3E8C
	public static string Combine(InputControl parent, string path) { }

	// RVA: 0x13EA52C
	public static string ToHumanReadableString(string path, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x13EA55C
	public static string ToHumanReadableString(string path, string deviceLayoutName, string controlPath, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x13EBAE8
	public static string[] TryGetDeviceUsages(string path) { }

	// RVA: 0x13EBCB0
	public static string TryGetDeviceLayout(string path) { }

	// RVA: 0x13EBEDC
	public static string TryGetControlLayout(string path) { }

	// RVA: 0x13EC1EC
	private static string FindControlLayoutRecursive(PathParser parser, string layoutName) { }

	// RVA: 0x13EC34C
	private static string FindControlLayoutRecursive(PathParser parser, InputControlLayout layout) { }

	// RVA: 0x13EC4FC
	private static bool ControlLayoutMatchesPathComponent(ControlItem controlItem, PathParser parser) { }

	// RVA: 0x13EC68C
	private static bool StringMatches(Substring str, InternedString matchTo) { }

	// RVA: 0x13DB464
	public static InputControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13EC940
	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13ECA94
	public static int TryFindControls(InputControl control, string path, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& matches, int indexInPath) { }

	// RVA: 0x318DB98
	public static TControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x318DB98
	public static int TryFindControls(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches) { }

	// RVA: 0x13E43E4
	public static InputControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x318DB98
	public static TControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x13EABE0
	public static bool Matches(string expected, InputControl control) { }

	// RVA: 0x13ECB80
	internal static bool MatchControlComponent(ParsedPathComponent expectedControlComponent, ControlItem controlItem, bool matchAlias) { }

	// RVA: 0x13ECF54
	public static bool MatchesPrefix(string expected, InputControl control) { }

	// RVA: 0x13ECB08
	private static bool MatchesRecursive(PathParser parser, InputControl currentControl, bool prefixOnly) { }

	// RVA: 0x318DB98
	private static TControl MatchControlsRecursive(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x318DB98
	private static TControl MatchByUsageAtDeviceRootRecursive(InputDevice device, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x318DB98
	private static TControl MatchChildrenRecursive(InputControl control, string path, int indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x13ED5C0
	private static bool MatchPathComponent(string component, string path, int indexInPath, PathComponentType componentType, int startIndexInComponent) { }

	// RVA: 0x13ED87C
	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	// RVA: 0x13ED978
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

	// RVA: 0x13EE350
	internal static Type GetValueTypeFromType(Type processorType) { }

	// RVA: 0x13EE46C
	public virtual CachingPolicy get_cachingPolicy() { }

	// RVA: 0x13EE474
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputProcessor<T0>
{
	// Methods

	// RVA: -1
	public abstract TValue Process(TValue value, InputControl control) { }

	// RVA: 0x30D3E84
	public override object ProcessAsObject(object value, InputControl control) { }

	// RVA: 0x318DB98
	public override void Process(Void* buffer, int bufferSize, InputControl control) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Gamepad
{
	// Fields
	private ButtonControl <buttonWest>k__BackingField; // 0x188
	private ButtonControl <buttonNorth>k__BackingField; // 0x190
	private ButtonControl <buttonSouth>k__BackingField; // 0x198
	private ButtonControl <buttonEast>k__BackingField; // 0x1A0
	private ButtonControl <leftStickButton>k__BackingField; // 0x1A8
	private ButtonControl <rightStickButton>k__BackingField; // 0x1B0
	private ButtonControl <startButton>k__BackingField; // 0x1B8
	private ButtonControl <selectButton>k__BackingField; // 0x1C0
	private DpadControl <dpad>k__BackingField; // 0x1C8
	private ButtonControl <leftShoulder>k__BackingField; // 0x1D0
	private ButtonControl <rightShoulder>k__BackingField; // 0x1D8
	private StickControl <leftStick>k__BackingField; // 0x1E0
	private StickControl <rightStick>k__BackingField; // 0x1E8
	private ButtonControl <leftTrigger>k__BackingField; // 0x1F0
	private ButtonControl <rightTrigger>k__BackingField; // 0x1F8
	private static Gamepad <current>k__BackingField; // 0x0
	private DualMotorRumble m_Rumble; // 0x200
	private static int s_GamepadCount; // 0x8
	private static Gamepad[] s_Gamepads; // 0x10

	// Methods

	// RVA: 0x13EE47C
	public ButtonControl get_buttonWest() { }

	// RVA: 0x13EE484
	protected void set_buttonWest(ButtonControl value) { }

	// RVA: 0x13EE494
	public ButtonControl get_buttonNorth() { }

	// RVA: 0x13EE49C
	protected void set_buttonNorth(ButtonControl value) { }

	// RVA: 0x13EE4AC
	public ButtonControl get_buttonSouth() { }

	// RVA: 0x13EE4B4
	protected void set_buttonSouth(ButtonControl value) { }

	// RVA: 0x13EE4C4
	public ButtonControl get_buttonEast() { }

	// RVA: 0x13EE4CC
	protected void set_buttonEast(ButtonControl value) { }

	// RVA: 0x13EE4DC
	public ButtonControl get_leftStickButton() { }

	// RVA: 0x13EE4E4
	protected void set_leftStickButton(ButtonControl value) { }

	// RVA: 0x13EE4F4
	public ButtonControl get_rightStickButton() { }

	// RVA: 0x13EE4FC
	protected void set_rightStickButton(ButtonControl value) { }

	// RVA: 0x13EE50C
	public ButtonControl get_startButton() { }

	// RVA: 0x13EE514
	protected void set_startButton(ButtonControl value) { }

	// RVA: 0x13EE524
	public ButtonControl get_selectButton() { }

	// RVA: 0x13EE52C
	protected void set_selectButton(ButtonControl value) { }

	// RVA: 0x13EE53C
	public DpadControl get_dpad() { }

	// RVA: 0x13EE544
	protected void set_dpad(DpadControl value) { }

	// RVA: 0x13EE554
	public ButtonControl get_leftShoulder() { }

	// RVA: 0x13EE55C
	protected void set_leftShoulder(ButtonControl value) { }

	// RVA: 0x13EE56C
	public ButtonControl get_rightShoulder() { }

	// RVA: 0x13EE574
	protected void set_rightShoulder(ButtonControl value) { }

	// RVA: 0x13EE584
	public StickControl get_leftStick() { }

	// RVA: 0x13EE58C
	protected void set_leftStick(StickControl value) { }

	// RVA: 0x13EE59C
	public StickControl get_rightStick() { }

	// RVA: 0x13EE5A4
	protected void set_rightStick(StickControl value) { }

	// RVA: 0x13EE5B4
	public ButtonControl get_leftTrigger() { }

	// RVA: 0x13EE5BC
	protected void set_leftTrigger(ButtonControl value) { }

	// RVA: 0x13EE5CC
	public ButtonControl get_rightTrigger() { }

	// RVA: 0x13EE5D4
	protected void set_rightTrigger(ButtonControl value) { }

	// RVA: 0x13EE5E4
	public ButtonControl get_aButton() { }

	// RVA: 0x13EE5EC
	public ButtonControl get_bButton() { }

	// RVA: 0x13EE5F4
	public ButtonControl get_xButton() { }

	// RVA: 0x13EE5FC
	public ButtonControl get_yButton() { }

	// RVA: 0x13EE604
	public ButtonControl get_triangleButton() { }

	// RVA: 0x13EE60C
	public ButtonControl get_squareButton() { }

	// RVA: 0x13EE614
	public ButtonControl get_circleButton() { }

	// RVA: 0x13EE61C
	public ButtonControl get_crossButton() { }

	// RVA: 0x13EE624
	public ButtonControl get_Item(GamepadButton button) { }

	// RVA: 0x13EE880
	public static Gamepad get_current() { }

	// RVA: 0x13EE8CC
	private static void set_current(Gamepad value) { }

	// RVA: 0x13EE930
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all() { }

	// RVA: 0x13EE9BC
	protected override void FinishSetup() { }

	// RVA: 0x13EED50
	public override void MakeCurrent() { }

	// RVA: 0x13EEDB0
	protected override void OnAdded() { }

	// RVA: 0x13EEE2C
	protected override void OnRemoved() { }

	// RVA: 0x13EEF58
	public virtual void PauseHaptics() { }

	// RVA: 0x13EEF68
	public virtual void ResumeHaptics() { }

	// RVA: 0x13EEF78
	public virtual void ResetHaptics() { }

	// RVA: 0x13EEF88
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x13EEF98
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

	// RVA: 0x13F10DC
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
	internal UInt32 m_CurrentProcessedEventBytesOnUpdate; // 0xEC
	internal InputDeviceDescription m_Description; // 0xF0
	internal Double m_LastUpdateTimeInternal; // 0x128
	internal UInt32 m_CurrentUpdateStepCount; // 0x130
	internal InternedString[] m_AliasesForEachControl; // 0x138
	internal InternedString[] m_UsagesForEachControl; // 0x140
	internal InputControl[] m_UsageToControl; // 0x148
	internal InputControl[] m_ChildrenForEachControl; // 0x150
	internal System.Collections.Generic.HashSet<System.Int32> m_UpdatedButtons; // 0x158
	internal System.Collections.Generic.List<UnityEngine.InputSystem.Controls.ButtonControl> m_ButtonControlsCheckingPressState; // 0x160
	internal bool m_UseCachePathForButtonPresses; // 0x168
	internal UInt32[] m_StateOffsetToControlMap; // 0x170
	internal ControlBitRangeNode[] m_ControlTreeNodes; // 0x178
	internal UInt16[] m_ControlTreeIndices; // 0x180
	internal const int kControlIndexBits = 10;
	internal const int kStateOffsetBits = 13;
	internal const int kStateSizeBits = 9;

	// Methods

	// RVA: 0x13EF0A0
	public InputDeviceDescription get_description() { }

	// RVA: 0x13EF0BC
	public bool get_enabled() { }

	// RVA: 0x13EF258
	public bool get_canRunInBackground() { }

	// RVA: 0x13EF328
	internal bool get_canDeviceRunInBackground() { }

	// RVA: 0x13DFA88
	public bool get_added() { }

	// RVA: 0x13EF3F8
	public bool get_remote() { }

	// RVA: 0x13EF404
	public bool get_native() { }

	// RVA: 0x13EF410
	public bool get_updateBeforeRender() { }

	// RVA: 0x13EF41C
	public int get_deviceId() { }

	// RVA: 0x13EF424
	public Double get_lastUpdateTime() { }

	// RVA: 0x13EF484
	public bool get_wasUpdatedThisFrame() { }

	// RVA: 0x13E9D38
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls() { }

	// RVA: 0x13EF4E8
	public override Type get_valueType() { }

	// RVA: 0x13EF588
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13EF610
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all() { }

	// RVA: 0x13EF01C
	public void .ctor() { }

	// RVA: 0x13EF6D8
	public override object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x13EF718
	public override object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x13EF82C
	public override void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x13EF9F0
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13EFAF4
	internal void NotifyConfigurationChanged() { }

	// RVA: 0x13EEDAC
	public virtual void MakeCurrent() { }

	// RVA: 0x13EFB64
	protected virtual void OnAdded() { }

	// RVA: 0x13EFB68
	protected virtual void OnRemoved() { }

	// RVA: 0x13EFB6C
	protected virtual void OnConfigurationChanged() { }

	// RVA: -1
	public Int64 ExecuteCommand(TCommand command) { }

	// RVA: 0x13EFB70
	protected virtual Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x13EF18C
	internal bool QueryEnabledStateFromRuntime() { }

	// RVA: 0x13EFC4C
	internal bool get_disabledInFrontend() { }

	// RVA: 0x13EFC58
	internal void set_disabledInFrontend(bool value) { }

	// RVA: 0x13EFC78
	internal bool get_disabledInRuntime() { }

	// RVA: 0x13EFC84
	internal void set_disabledInRuntime(bool value) { }

	// RVA: 0x13EFCA4
	internal bool get_disabledWhileInBackground() { }

	// RVA: 0x13EFCB0
	internal void set_disabledWhileInBackground(bool value) { }

	// RVA: 0x13EFCD0
	internal static UInt32 EncodeStateOffsetToControlMapEntry(UInt32 controlIndex, UInt32 stateOffsetInBits, UInt32 stateSizeInBits) { }

	// RVA: 0x13E8E68
	internal static void DecodeStateOffsetToControlMapEntry(UInt32 entry, UInt32 controlIndex, UInt32 stateOffset, UInt32 stateSize) { }

	// RVA: 0x13EFCDC
	internal bool get_hasControlsWithDefaultState() { }

	// RVA: 0x13E9238
	internal void set_hasControlsWithDefaultState(bool value) { }

	// RVA: 0x13EFCE8
	internal bool get_hasDontResetControls() { }

	// RVA: 0x13E9340
	internal void set_hasDontResetControls(bool value) { }

	// RVA: 0x13E7358
	internal bool get_hasStateCallbacks() { }

	// RVA: 0x13EFCF4
	internal void set_hasStateCallbacks(bool value) { }

	// RVA: 0x13EFD14
	internal bool get_hasEventMerger() { }

	// RVA: 0x13EFD20
	internal void set_hasEventMerger(bool value) { }

	// RVA: 0x13EFD40
	internal bool get_hasEventPreProcessor() { }

	// RVA: 0x13EFD4C
	internal void set_hasEventPreProcessor(bool value) { }

	// RVA: 0x13EFD6C
	internal void AddDeviceUsage(InternedString usage) { }

	// RVA: 0x13EFE2C
	internal void RemoveDeviceUsage(InternedString usage) { }

	// RVA: 0x13EFF2C
	internal void ClearDeviceUsages() { }

	// RVA: 0x13DFA98
	internal bool RequestSync() { }

	// RVA: 0x13DFC88
	internal bool RequestReset() { }

	// RVA: 0x13EFF90
	internal bool ExecuteEnableCommand() { }

	// RVA: 0x13F0014
	internal bool ExecuteDisableCommand() { }

	// RVA: 0x13F008C
	internal void NotifyAdded() { }

	// RVA: 0x13F009C
	internal void NotifyRemoved() { }

	// RVA: 0x318DB98
	internal static TDevice Build(string layoutName, string layoutVariants, InputDeviceDescription deviceDescription, bool noPrecompiledLayouts) { }

	// RVA: 0x13F00AC
	internal void WriteChangedControlStates(Byte* deviceStateBuffer, Void* statePtr, UInt32 stateSizeInBytes, UInt32 stateOffsetInDevice) { }

	// RVA: 0x13F0220
	private void WritePartialChangedControlStatesInternal(UInt32 stateSizeInBits, UInt32 stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x13F09D8
	private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, UInt32 startOffset, UInt32 sizeInBits, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x13F0E60
	private void DumpControlTree(ControlBitRangeNode parentNode, UInt32 startOffset, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x13F0F90
	internal string DumpControlTree() { }

	// RVA: 0x13F05AC
	private void WriteChangedControlStatesInternal(Void* statePtr, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x13F1060
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
	private ButtonControl <trigger>k__BackingField; // 0x188
	private StickControl <stick>k__BackingField; // 0x190
	private AxisControl <twist>k__BackingField; // 0x198
	private Vector2Control <hatswitch>k__BackingField; // 0x1A0
	private static Joystick <current>k__BackingField; // 0x0
	private static int s_JoystickCount; // 0x8
	private static Joystick[] s_Joysticks; // 0x10

	// Methods

	// RVA: 0x13F10F0
	public ButtonControl get_trigger() { }

	// RVA: 0x13F10F8
	protected void set_trigger(ButtonControl value) { }

	// RVA: 0x13F1108
	public StickControl get_stick() { }

	// RVA: 0x13F1110
	protected void set_stick(StickControl value) { }

	// RVA: 0x13F1120
	public AxisControl get_twist() { }

	// RVA: 0x13F1128
	protected void set_twist(AxisControl value) { }

	// RVA: 0x13F1138
	public Vector2Control get_hatswitch() { }

	// RVA: 0x13F1140
	protected void set_hatswitch(Vector2Control value) { }

	// RVA: 0x13F1150
	public static Joystick get_current() { }

	// RVA: 0x13F119C
	private static void set_current(Joystick value) { }

	// RVA: 0x13F1200
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all() { }

	// RVA: 0x13F128C
	protected override void FinishSetup() { }

	// RVA: 0x13F13F8
	public override void MakeCurrent() { }

	// RVA: 0x13F1454
	protected override void OnAdded() { }

	// RVA: 0x13F14D0
	protected override void OnRemoved() { }

	// RVA: 0x13F15FC
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
	public const Key F13 = 112;
	public const Key F14 = 113;
	public const Key F15 = 114;
	public const Key F16 = 115;
	public const Key F17 = 116;
	public const Key F18 = 117;
	public const Key F19 = 118;
	public const Key F20 = 119;
	public const Key F21 = 120;
	public const Key F22 = 121;
	public const Key F23 = 122;
	public const Key F24 = 123;
}

// Namespace: UnityEngine.InputSystem
internal static class KeyEx
{
	// Fields
	internal const Key IMESelected = 111;
	internal const Key RemappedIMESelected = 127;
}

// Namespace: UnityEngine.InputSystem
public class Keyboard
{
	// Fields
	public const int KeyCount = 110;
	internal const int ExtendedKeyCount = 123;
	private AnyKeyControl <anyKey>k__BackingField; // 0x188
	private ButtonControl <shiftKey>k__BackingField; // 0x190
	private ButtonControl <ctrlKey>k__BackingField; // 0x198
	private ButtonControl <altKey>k__BackingField; // 0x1A0
	private ButtonControl <imeSelected>k__BackingField; // 0x1A8
	private static Keyboard <current>k__BackingField; // 0x0
	private UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<System.Char>> m_TextInputListeners; // 0x1B0
	private string m_KeyboardLayoutName; // 0x1C8
	private KeyControl[] m_Keys; // 0x1D0
	private UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString>> m_ImeCompositionListeners; // 0x1D8

	// Methods

	// RVA: 0x13F1680
	public void add_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13F176C
	public void remove_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13F17C8
	public void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13F18B8
	public void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13F1914
	public void SetIMEEnabled(bool enabled) { }

	// RVA: 0x13F1990
	public void SetIMECursorPosition(Vector2 position) { }

	// RVA: 0x13F1A44
	public string get_keyboardLayout() { }

	// RVA: 0x13F1A8C
	protected void set_keyboardLayout(string value) { }

	// RVA: 0x13F1A9C
	public AnyKeyControl get_anyKey() { }

	// RVA: 0x13F1AA4
	protected void set_anyKey(AnyKeyControl value) { }

	// RVA: 0x13F1AB4
	public KeyControl get_spaceKey() { }

	// RVA: 0x13F1BB8
	public KeyControl get_enterKey() { }

	// RVA: 0x13F1C34
	public KeyControl get_tabKey() { }

	// RVA: 0x13F1CB0
	public KeyControl get_backquoteKey() { }

	// RVA: 0x13F1D2C
	public KeyControl get_quoteKey() { }

	// RVA: 0x13F1DA8
	public KeyControl get_semicolonKey() { }

	// RVA: 0x13F1E24
	public KeyControl get_commaKey() { }

	// RVA: 0x13F1EA0
	public KeyControl get_periodKey() { }

	// RVA: 0x13F1F1C
	public KeyControl get_slashKey() { }

	// RVA: 0x13F1F98
	public KeyControl get_backslashKey() { }

	// RVA: 0x13F2014
	public KeyControl get_leftBracketKey() { }

	// RVA: 0x13F2090
	public KeyControl get_rightBracketKey() { }

	// RVA: 0x13F210C
	public KeyControl get_minusKey() { }

	// RVA: 0x13F2188
	public KeyControl get_equalsKey() { }

	// RVA: 0x13F2204
	public KeyControl get_aKey() { }

	// RVA: 0x13F2280
	public KeyControl get_bKey() { }

	// RVA: 0x13F22FC
	public KeyControl get_cKey() { }

	// RVA: 0x13F2378
	public KeyControl get_dKey() { }

	// RVA: 0x13F23F4
	public KeyControl get_eKey() { }

	// RVA: 0x13F2470
	public KeyControl get_fKey() { }

	// RVA: 0x13F24EC
	public KeyControl get_gKey() { }

	// RVA: 0x13F2568
	public KeyControl get_hKey() { }

	// RVA: 0x13F25E4
	public KeyControl get_iKey() { }

	// RVA: 0x13F2660
	public KeyControl get_jKey() { }

	// RVA: 0x13F26DC
	public KeyControl get_kKey() { }

	// RVA: 0x13F2758
	public KeyControl get_lKey() { }

	// RVA: 0x13F27D4
	public KeyControl get_mKey() { }

	// RVA: 0x13F2850
	public KeyControl get_nKey() { }

	// RVA: 0x13F28CC
	public KeyControl get_oKey() { }

	// RVA: 0x13F2948
	public KeyControl get_pKey() { }

	// RVA: 0x13F29C4
	public KeyControl get_qKey() { }

	// RVA: 0x13F2A40
	public KeyControl get_rKey() { }

	// RVA: 0x13F2ABC
	public KeyControl get_sKey() { }

	// RVA: 0x13F2B38
	public KeyControl get_tKey() { }

	// RVA: 0x13F2BB4
	public KeyControl get_uKey() { }

	// RVA: 0x13F2C30
	public KeyControl get_vKey() { }

	// RVA: 0x13F2CAC
	public KeyControl get_wKey() { }

	// RVA: 0x13F2D28
	public KeyControl get_xKey() { }

	// RVA: 0x13F2DA4
	public KeyControl get_yKey() { }

	// RVA: 0x13F2E20
	public KeyControl get_zKey() { }

	// RVA: 0x13F2E9C
	public KeyControl get_digit1Key() { }

	// RVA: 0x13F2F18
	public KeyControl get_digit2Key() { }

	// RVA: 0x13F2F94
	public KeyControl get_digit3Key() { }

	// RVA: 0x13F3010
	public KeyControl get_digit4Key() { }

	// RVA: 0x13F308C
	public KeyControl get_digit5Key() { }

	// RVA: 0x13F3108
	public KeyControl get_digit6Key() { }

	// RVA: 0x13F3184
	public KeyControl get_digit7Key() { }

	// RVA: 0x13F3200
	public KeyControl get_digit8Key() { }

	// RVA: 0x13F327C
	public KeyControl get_digit9Key() { }

	// RVA: 0x13F32F8
	public KeyControl get_digit0Key() { }

	// RVA: 0x13F3374
	public KeyControl get_leftShiftKey() { }

	// RVA: 0x13F33F0
	public KeyControl get_rightShiftKey() { }

	// RVA: 0x13F346C
	public KeyControl get_leftAltKey() { }

	// RVA: 0x13F34E8
	public KeyControl get_rightAltKey() { }

	// RVA: 0x13F3564
	public KeyControl get_leftCtrlKey() { }

	// RVA: 0x13F35E0
	public KeyControl get_rightCtrlKey() { }

	// RVA: 0x13F365C
	public KeyControl get_leftMetaKey() { }

	// RVA: 0x13F36D8
	public KeyControl get_rightMetaKey() { }

	// RVA: 0x13F3754
	public KeyControl get_leftWindowsKey() { }

	// RVA: 0x13F37D0
	public KeyControl get_rightWindowsKey() { }

	// RVA: 0x13F384C
	public KeyControl get_leftAppleKey() { }

	// RVA: 0x13F38C8
	public KeyControl get_rightAppleKey() { }

	// RVA: 0x13F3944
	public KeyControl get_leftCommandKey() { }

	// RVA: 0x13F39C0
	public KeyControl get_rightCommandKey() { }

	// RVA: 0x13F3A3C
	public KeyControl get_contextMenuKey() { }

	// RVA: 0x13F3AB8
	public KeyControl get_escapeKey() { }

	// RVA: 0x13F3B34
	public KeyControl get_leftArrowKey() { }

	// RVA: 0x13F3BB0
	public KeyControl get_rightArrowKey() { }

	// RVA: 0x13F3C2C
	public KeyControl get_upArrowKey() { }

	// RVA: 0x13F3CA8
	public KeyControl get_downArrowKey() { }

	// RVA: 0x13F3D24
	public KeyControl get_backspaceKey() { }

	// RVA: 0x13F3DA0
	public KeyControl get_pageDownKey() { }

	// RVA: 0x13F3E1C
	public KeyControl get_pageUpKey() { }

	// RVA: 0x13F3E98
	public KeyControl get_homeKey() { }

	// RVA: 0x13F3F14
	public KeyControl get_endKey() { }

	// RVA: 0x13F3F90
	public KeyControl get_insertKey() { }

	// RVA: 0x13F400C
	public KeyControl get_deleteKey() { }

	// RVA: 0x13F4088
	public KeyControl get_capsLockKey() { }

	// RVA: 0x13F4104
	public KeyControl get_scrollLockKey() { }

	// RVA: 0x13F4180
	public KeyControl get_numLockKey() { }

	// RVA: 0x13F41FC
	public KeyControl get_printScreenKey() { }

	// RVA: 0x13F4278
	public KeyControl get_pauseKey() { }

	// RVA: 0x13F42F4
	public KeyControl get_numpadEnterKey() { }

	// RVA: 0x13F4370
	public KeyControl get_numpadDivideKey() { }

	// RVA: 0x13F43EC
	public KeyControl get_numpadMultiplyKey() { }

	// RVA: 0x13F4468
	public KeyControl get_numpadMinusKey() { }

	// RVA: 0x13F44E4
	public KeyControl get_numpadPlusKey() { }

	// RVA: 0x13F4560
	public KeyControl get_numpadPeriodKey() { }

	// RVA: 0x13F45DC
	public KeyControl get_numpadEqualsKey() { }

	// RVA: 0x13F4658
	public KeyControl get_numpad0Key() { }

	// RVA: 0x13F46D4
	public KeyControl get_numpad1Key() { }

	// RVA: 0x13F4750
	public KeyControl get_numpad2Key() { }

	// RVA: 0x13F47CC
	public KeyControl get_numpad3Key() { }

	// RVA: 0x13F4848
	public KeyControl get_numpad4Key() { }

	// RVA: 0x13F48C4
	public KeyControl get_numpad5Key() { }

	// RVA: 0x13F4940
	public KeyControl get_numpad6Key() { }

	// RVA: 0x13F49BC
	public KeyControl get_numpad7Key() { }

	// RVA: 0x13F4A38
	public KeyControl get_numpad8Key() { }

	// RVA: 0x13F4AB4
	public KeyControl get_numpad9Key() { }

	// RVA: 0x13F4B30
	public KeyControl get_f1Key() { }

	// RVA: 0x13F4BAC
	public KeyControl get_f2Key() { }

	// RVA: 0x13F4C28
	public KeyControl get_f3Key() { }

	// RVA: 0x13F4CA4
	public KeyControl get_f4Key() { }

	// RVA: 0x13F4D20
	public KeyControl get_f5Key() { }

	// RVA: 0x13F4D9C
	public KeyControl get_f6Key() { }

	// RVA: 0x13F4E18
	public KeyControl get_f7Key() { }

	// RVA: 0x13F4E94
	public KeyControl get_f8Key() { }

	// RVA: 0x13F4F10
	public KeyControl get_f9Key() { }

	// RVA: 0x13F4F8C
	public KeyControl get_f10Key() { }

	// RVA: 0x13F5008
	public KeyControl get_f11Key() { }

	// RVA: 0x13F5084
	public KeyControl get_f12Key() { }

	// RVA: 0x13F5100
	public KeyControl get_oem1Key() { }

	// RVA: 0x13F517C
	public KeyControl get_oem2Key() { }

	// RVA: 0x13F51F8
	public KeyControl get_oem3Key() { }

	// RVA: 0x13F5274
	public KeyControl get_oem4Key() { }

	// RVA: 0x13F52F0
	public KeyControl get_oem5Key() { }

	// RVA: 0x13F536C
	public KeyControl get_f13Key() { }

	// RVA: 0x13F53E8
	public KeyControl get_f14Key() { }

	// RVA: 0x13F5464
	public KeyControl get_f15Key() { }

	// RVA: 0x13F54E0
	public KeyControl get_f16Key() { }

	// RVA: 0x13F555C
	public KeyControl get_f17Key() { }

	// RVA: 0x13F55D8
	public KeyControl get_f18Key() { }

	// RVA: 0x13F5654
	public KeyControl get_f19Key() { }

	// RVA: 0x13F56D0
	public KeyControl get_f20Key() { }

	// RVA: 0x13F574C
	public KeyControl get_f21Key() { }

	// RVA: 0x13F57C8
	public KeyControl get_f22Key() { }

	// RVA: 0x13F5844
	public KeyControl get_f23Key() { }

	// RVA: 0x13F58C0
	public KeyControl get_f24Key() { }

	// RVA: 0x13F593C
	public ButtonControl get_shiftKey() { }

	// RVA: 0x13F5944
	protected void set_shiftKey(ButtonControl value) { }

	// RVA: 0x13F5954
	public ButtonControl get_ctrlKey() { }

	// RVA: 0x13F595C
	protected void set_ctrlKey(ButtonControl value) { }

	// RVA: 0x13F596C
	public ButtonControl get_altKey() { }

	// RVA: 0x13F5974
	protected void set_altKey(ButtonControl value) { }

	// RVA: 0x13F5984
	public ButtonControl get_imeSelected() { }

	// RVA: 0x13F598C
	protected void set_imeSelected(ButtonControl value) { }

	// RVA: 0x13F1B30
	public KeyControl get_Item(Key key) { }

	// RVA: 0x13F599C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys() { }

	// RVA: 0x13F5A08
	public static Keyboard get_current() { }

	// RVA: 0x13F5A54
	private static void set_current(Keyboard value) { }

	// RVA: 0x13F5AB8
	public override void MakeCurrent() { }

	// RVA: 0x13F5B14
	protected override void OnRemoved() { }

	// RVA: 0x13F5BAC
	protected override void FinishSetup() { }

	// RVA: 0x13F75B4
	protected override void RefreshConfiguration() { }

	// RVA: 0x13F7694
	public void OnTextInput(Char character) { }

	// RVA: 0x13F7748
	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	// RVA: 0x13F78B8
	public void OnIMECompositionChanged(IMECompositionString compositionString) { }

	// RVA: 0x13F79BC
	private bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr) { }

	// RVA: 0x13F7A6C
	protected KeyControl[] get_keys() { }

	// RVA: 0x13F7A74
	protected void set_keys(KeyControl[] value) { }

	// RVA: 0x13F7A84
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Mouse
{
	// Fields
	private DeltaControl <scroll>k__BackingField; // 0x1B8
	private ButtonControl <leftButton>k__BackingField; // 0x1C0
	private ButtonControl <middleButton>k__BackingField; // 0x1C8
	private ButtonControl <rightButton>k__BackingField; // 0x1D0
	private ButtonControl <backButton>k__BackingField; // 0x1D8
	private ButtonControl <forwardButton>k__BackingField; // 0x1E0
	private IntegerControl <clickCount>k__BackingField; // 0x1E8
	private static Mouse <current>k__BackingField; // 0x0
	internal static Mouse s_PlatformMouseDevice; // 0x8

	// Methods

	// RVA: 0x13F7B08
	public DeltaControl get_scroll() { }

	// RVA: 0x13F7B10
	protected void set_scroll(DeltaControl value) { }

	// RVA: 0x13F7B20
	public ButtonControl get_leftButton() { }

	// RVA: 0x13F7B28
	protected void set_leftButton(ButtonControl value) { }

	// RVA: 0x13F7B38
	public ButtonControl get_middleButton() { }

	// RVA: 0x13F7B40
	protected void set_middleButton(ButtonControl value) { }

	// RVA: 0x13F7B50
	public ButtonControl get_rightButton() { }

	// RVA: 0x13F7B58
	protected void set_rightButton(ButtonControl value) { }

	// RVA: 0x13F7B68
	public ButtonControl get_backButton() { }

	// RVA: 0x13F7B70
	protected void set_backButton(ButtonControl value) { }

	// RVA: 0x13F7B80
	public ButtonControl get_forwardButton() { }

	// RVA: 0x13F7B88
	protected void set_forwardButton(ButtonControl value) { }

	// RVA: 0x13F7B98
	public IntegerControl get_clickCount() { }

	// RVA: 0x13F7BA0
	protected void set_clickCount(IntegerControl value) { }

	// RVA: 0x13F7BB0
	public static Mouse get_current() { }

	// RVA: 0x13F7BFC
	private static void set_current(Mouse value) { }

	// RVA: 0x13F7C60
	public override void MakeCurrent() { }

	// RVA: 0x13F7CC4
	protected override void OnAdded() { }

	// RVA: 0x13F7D40
	protected override void OnRemoved() { }

	// RVA: 0x13F7DE0
	public void WarpCursorPosition(Vector2 position) { }

	// RVA: 0x13F7E94
	protected override void FinishSetup() { }

	// RVA: 0x13F80C8
	protected void OnNextUpdate() { }

	// RVA: 0x13F817C
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13F81D0
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13F8284
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13F82D8
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
	private ButtonControl <tip>k__BackingField; // 0x1B8
	private ButtonControl <eraser>k__BackingField; // 0x1C0
	private ButtonControl <firstBarrelButton>k__BackingField; // 0x1C8
	private ButtonControl <secondBarrelButton>k__BackingField; // 0x1D0
	private ButtonControl <thirdBarrelButton>k__BackingField; // 0x1D8
	private ButtonControl <fourthBarrelButton>k__BackingField; // 0x1E0
	private ButtonControl <inRange>k__BackingField; // 0x1E8
	private Vector2Control <tilt>k__BackingField; // 0x1F0
	private AxisControl <twist>k__BackingField; // 0x1F8
	private static Pen <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13F82E0
	public ButtonControl get_tip() { }

	// RVA: 0x13F82E8
	protected void set_tip(ButtonControl value) { }

	// RVA: 0x13F82F8
	public ButtonControl get_eraser() { }

	// RVA: 0x13F8300
	protected void set_eraser(ButtonControl value) { }

	// RVA: 0x13F8310
	public ButtonControl get_firstBarrelButton() { }

	// RVA: 0x13F8318
	protected void set_firstBarrelButton(ButtonControl value) { }

	// RVA: 0x13F8328
	public ButtonControl get_secondBarrelButton() { }

	// RVA: 0x13F8330
	protected void set_secondBarrelButton(ButtonControl value) { }

	// RVA: 0x13F8340
	public ButtonControl get_thirdBarrelButton() { }

	// RVA: 0x13F8348
	protected void set_thirdBarrelButton(ButtonControl value) { }

	// RVA: 0x13F8358
	public ButtonControl get_fourthBarrelButton() { }

	// RVA: 0x13F8360
	protected void set_fourthBarrelButton(ButtonControl value) { }

	// RVA: 0x13F8370
	public ButtonControl get_inRange() { }

	// RVA: 0x13F8378
	protected void set_inRange(ButtonControl value) { }

	// RVA: 0x13F8388
	public Vector2Control get_tilt() { }

	// RVA: 0x13F8390
	protected void set_tilt(Vector2Control value) { }

	// RVA: 0x13F83A0
	public AxisControl get_twist() { }

	// RVA: 0x13F83A8
	protected void set_twist(AxisControl value) { }

	// RVA: 0x13F83B8
	public static Pen get_current() { }

	// RVA: 0x13F8404
	internal static void set_current(Pen value) { }

	// RVA: 0x13F8468
	public ButtonControl get_Item(PenButton button) { }

	// RVA: 0x13F85C8
	public override void MakeCurrent() { }

	// RVA: 0x13F86D4
	protected override void OnRemoved() { }

	// RVA: 0x13F88A4
	protected override void FinishSetup() { }

	// RVA: 0x13F8D44
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Pointer
{
	// Fields
	private Vector2Control <position>k__BackingField; // 0x188
	private DeltaControl <delta>k__BackingField; // 0x190
	private Vector2Control <radius>k__BackingField; // 0x198
	private AxisControl <pressure>k__BackingField; // 0x1A0
	private ButtonControl <press>k__BackingField; // 0x1A8
	private IntegerControl <displayIndex>k__BackingField; // 0x1B0
	private static Pointer <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13F8D54
	public Vector2Control get_position() { }

	// RVA: 0x13F8D5C
	protected void set_position(Vector2Control value) { }

	// RVA: 0x13F8D6C
	public DeltaControl get_delta() { }

	// RVA: 0x13F8D74
	protected void set_delta(DeltaControl value) { }

	// RVA: 0x13F8D84
	public Vector2Control get_radius() { }

	// RVA: 0x13F8D8C
	protected void set_radius(Vector2Control value) { }

	// RVA: 0x13F8D9C
	public AxisControl get_pressure() { }

	// RVA: 0x13F8DA4
	protected void set_pressure(AxisControl value) { }

	// RVA: 0x13F8DB4
	public ButtonControl get_press() { }

	// RVA: 0x13F8DBC
	protected void set_press(ButtonControl value) { }

	// RVA: 0x13F8DCC
	public IntegerControl get_displayIndex() { }

	// RVA: 0x13F8DD4
	protected void set_displayIndex(IntegerControl value) { }

	// RVA: 0x13F8DE4
	public static Pointer get_current() { }

	// RVA: 0x13F8E30
	internal static void set_current(Pointer value) { }

	// RVA: 0x13F8670
	public override void MakeCurrent() { }

	// RVA: 0x13F8804
	protected override void OnRemoved() { }

	// RVA: 0x13F8B50
	protected override void FinishSetup() { }

	// RVA: 0x13F8E94
	protected void OnNextUpdate() { }

	// RVA: 0x13F8F3C
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13F8F94
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13F903C
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13F9094
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

	// RVA: 0x13F8D4C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
internal class FastKeyboard
{
	// Fields
	public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard";

	// Methods

	// RVA: 0x13F909C
	public void .ctor() { }

	// RVA: 0x13FC3FC
	private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) { }

	// RVA: 0x13FC5FC
	private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FC800
	private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FC9F8
	private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FCBFC
	private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FCDF4
	private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FCFEC
	private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FD1E4
	private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FD3DC
	private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FD5D4
	private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FD7CC
	private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FD9C4
	private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FDBBC
	private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FDDB4
	private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FDFAC
	private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FE1A4
	private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FE39C
	private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FE594
	private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FE78C
	private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FE984
	private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FEB7C
	private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FED74
	private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FEF6C
	private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FF164
	private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FF35C
	private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FF554
	private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FF74C
	private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FF944
	private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FFB3C
	private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FFD34
	private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13FFF2C
	private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1400124
	private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140031C
	private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1400514
	private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140070C
	private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1400904
	private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1400AFC
	private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1400CF4
	private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1400EEC
	private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14010E4
	private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14012DC
	private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14014D4
	private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14016CC
	private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14018C4
	private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1401ABC
	private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1401CB4
	private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1401EAC
	private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402090
	private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402274
	private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402458
	private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140263C
	private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402820
	private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402A04
	private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402BE8
	private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402DCC
	private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1402FB0
	private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1403194
	private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1403398
	private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140359C
	private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x14037C0
	private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14039C4
	private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1403BC8
	private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x1403DEC
	private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1403FF0
	private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14041F4
	private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x1404418
	private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140461C
	private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1404820
	private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1404A24
	private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1404C1C
	private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1404E14
	private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140500C
	private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1405204
	private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14053FC
	private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14055F4
	private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14057EC
	private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14059E4
	private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1405BDC
	private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1405DD4
	private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1405FCC
	private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14061C4
	private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14063BC
	private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14065B4
	private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14067AC
	private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14069A4
	private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1406B9C
	private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1406D94
	private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1406F8C
	private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1407184
	private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140737C
	private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1407574
	private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140776C
	private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1407964
	private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1407B5C
	private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1407D54
	private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1407F4C
	private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1408144
	private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140833C
	private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1408534
	private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140872C
	private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1408924
	private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1408B1C
	private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1408D14
	private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1408F0C
	private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1409104
	private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14092FC
	private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14094F4
	private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14096EC
	private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x14098E4
	private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1409ADC
	private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1409CC0
	private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x1409EA4
	private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140A088
	private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140A26C
	private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140A450
	private KeyControl Initialize_ctrlKeyboardf13(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140A648
	private KeyControl Initialize_ctrlKeyboardf14(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140A840
	private KeyControl Initialize_ctrlKeyboardf15(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140AA38
	private KeyControl Initialize_ctrlKeyboardf16(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140AC30
	private KeyControl Initialize_ctrlKeyboardf17(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140AE28
	private KeyControl Initialize_ctrlKeyboardf18(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140B020
	private KeyControl Initialize_ctrlKeyboardf19(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140B218
	private KeyControl Initialize_ctrlKeyboardf20(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140B410
	private KeyControl Initialize_ctrlKeyboardf21(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140B608
	private KeyControl Initialize_ctrlKeyboardf22(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140B800
	private KeyControl Initialize_ctrlKeyboardf23(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140B9F8
	private KeyControl Initialize_ctrlKeyboardf24(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x140BBF0
	private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastMouse
{
	// Fields
	public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";

	// Methods

	// RVA: 0x14344C4
	public void .ctor() { }

	// RVA: 0x1434F90
	private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x143517C
	private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1435340
	private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x14354F0
	private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14356F0
	private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1435934
	private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1435B78
	private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1435DB0
	private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1435FA8
	private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14361A0
	private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143638C
	private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1436554
	private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	// RVA: 0x14366E4
	private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1436888
	private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1436A40
	private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1436C4C
	private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1436E58
	private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437060
	private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437270
	private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437480
	private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437688
	private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437864
	private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437A40
	private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437C48
	private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1437E58
	private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1438068
	private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1438270
	private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1438464
	private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143866C
	private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1438848
	private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1438A24
	protected void OnNextUpdate() { }

	// RVA: 0x1438B98
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1438D40
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x1438D44
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1438D48
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x1438E74
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastTouchscreen
{
	// Fields
	public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer";

	// Methods

	// RVA: 0x140BDDC
	public void .ctor() { }

	// RVA: 0x140F3DC
	private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x140F5A0
	private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140F788
	private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x140F950
	private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) { }

	// RVA: 0x140FB3C
	private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x140FD04
	private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x140FF04
	private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x14100A8
	private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410258
	private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410408
	private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x14105B8
	private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410768
	private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410918
	private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410AC8
	private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410C78
	private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410E28
	private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1410FD8
	private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x1411188
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x14113A8
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14115C0
	private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x14117A8
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1411984
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1411B6C
	private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1411D5C
	private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1411F80
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141215C
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1412338
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1412570
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14127A0
	private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x1412990
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1412B8C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1412D98
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1412FA4
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14131AC
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14133BC
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14135CC
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14137D4
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14139B0
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1413B8C
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1413D68
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1413F44
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1414120
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14142FC
	private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1414508
	private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1414714
	private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141491C
	private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1414B2C
	private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1414D3C
	private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1414F44
	private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1415120
	private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14152FC
	private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14154D8
	private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14156B4
	private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x14158D4
	private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1415AEC
	private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1415CD4
	private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1415EB0
	private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1416098
	private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1416288
	private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x14164AC
	private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1416688
	private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1416864
	private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1416A9C
	private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1416CC0
	private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x1416EB0
	private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14170AC
	private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14172B8
	private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14174C4
	private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14176CC
	private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14178DC
	private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1417AEC
	private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1417CF4
	private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1417ED0
	private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14180AC
	private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1418288
	private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1418464
	private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1418640
	private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141881C
	private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1418A3C
	private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1418C54
	private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1418E3C
	private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1419018
	private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1419200
	private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x14193F0
	private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1419614
	private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x14197F0
	private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x14199CC
	private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1419C04
	private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1419E28
	private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x141A018
	private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x141A214
	private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141A420
	private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141A62C
	private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141A834
	private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141AA44
	private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141AC54
	private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141AE5C
	private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141B038
	private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141B214
	private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141B3F0
	private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141B5CC
	private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141B7A8
	private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141B984
	private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141BBA4
	private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x141BDBC
	private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x141BFA4
	private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141C180
	private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x141C368
	private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x141C558
	private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x141C77C
	private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141C958
	private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141CB34
	private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x141CD6C
	private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x141CF90
	private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x141D180
	private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x141D37C
	private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141D588
	private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141D794
	private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141D99C
	private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141DBAC
	private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141DDBC
	private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141DFC4
	private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141E1A0
	private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141E37C
	private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141E558
	private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141E734
	private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141E910
	private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141EAEC
	private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141ED0C
	private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x141EF24
	private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x141F10C
	private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x141F2E8
	private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x141F4D0
	private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x141F6C0
	private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x141F8E4
	private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141FAC0
	private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x141FC9C
	private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x141FED4
	private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14200F8
	private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x14202E8
	private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14204E4
	private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14206F0
	private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14208FC
	private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1420B04
	private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1420D14
	private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1420F24
	private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142112C
	private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1421308
	private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14214E4
	private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14216C0
	private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142189C
	private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1421A78
	private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1421C54
	private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1421E74
	private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142208C
	private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1422274
	private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1422450
	private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1422638
	private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1422828
	private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1422A4C
	private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1422C28
	private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1422E04
	private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x142303C
	private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1423260
	private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x1423450
	private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142364C
	private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1423858
	private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1423A64
	private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1423C6C
	private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1423E7C
	private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142408C
	private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1424294
	private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1424470
	private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142464C
	private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1424828
	private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1424A04
	private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1424BE0
	private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1424DBC
	private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1424FDC
	private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14251F4
	private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x14253DC
	private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14255B8
	private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14257A0
	private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1425990
	private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1425BB4
	private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1425D90
	private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1425F6C
	private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14261A4
	private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x14263C8
	private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x14265B8
	private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x14267B4
	private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14269C0
	private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1426BCC
	private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1426DD4
	private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1426FE4
	private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14271F4
	private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14273FC
	private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14275D8
	private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14277B4
	private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1427990
	private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1427B6C
	private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1427D48
	private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1427F24
	private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1428144
	private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142835C
	private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x1428544
	private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1428720
	private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1428908
	private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1428AF8
	private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1428D1C
	private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1428EF8
	private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x14290D4
	private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x142930C
	private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1429530
	private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x1429720
	private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142991C
	private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1429B28
	private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1429D34
	private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1429F3C
	private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142A14C
	private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142A35C
	private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142A564
	private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142A740
	private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142A91C
	private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142AAF8
	private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142ACD4
	private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142AEB0
	private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142B08C
	private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x142B2AC
	private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142B4C4
	private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x142B6AC
	private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142B888
	private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142BA70
	private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x142BC60
	private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x142BE84
	private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x142C060
	private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x142C23C
	private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x142C474
	private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x142C698
	private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x142C888
	private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142CA84
	private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142CC90
	private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142CE9C
	private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142D0A4
	private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142D2B4
	private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142D4C4
	private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142D6CC
	private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142D8A8
	private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142DA84
	private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142DC60
	private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142DE3C
	private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142E018
	private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142E1F4
	private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x142E414
	private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142E62C
	private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x142E814
	private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142E9F0
	private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142EBD8
	private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x142EDC8
	private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x142EFEC
	private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x142F1C8
	private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x142F3A4
	private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x142F5DC
	private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x142F800
	private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x142F9F0
	private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x142FBEC
	private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x142FDF8
	private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1430004
	private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143020C
	private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143041C
	private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143062C
	private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1430834
	private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1430A10
	private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1430BEC
	private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1430DC8
	private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1430FA4
	private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1431180
	private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143135C
	private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x143157C
	private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1431794
	private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x143197C
	private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1431B58
	private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1431D40
	private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x1431F30
	private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x1432154
	private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x1432330
	private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x143250C
	private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1432744
	private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x1432968
	private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x1432B58
	private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x1432D54
	private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1432F60
	private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143316C
	private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1433374
	private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1433584
	private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1433794
	private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143399C
	private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1433B78
	private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1433D54
	private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x1433F30
	private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x143410C
	private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x14342E8
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

	// RVA: 0x143C588
	public void Dispose() { }

	// RVA: 0x143A6CC
	public void .ctor() { }

}

// Namespace: 
private static class ConnectMsg
{
	// Methods

	// RVA: 0x1439668
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StartSendingMsg
{
	// Methods

	// RVA: 0x143A59C
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StopSendingMsg
{
	// Methods

	// RVA: 0x143A5B0
	public static void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class DisconnectMsg
{
	// Methods

	// RVA: 0x14396C0
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

	// RVA: 0x143AC44
	public static System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(InputRemoting sender, string layoutName) { }

	// RVA: 0x143977C
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

	// RVA: 0x143CE30
	private static void .cctor() { }

	// RVA: 0x143CE9C
	public void .ctor() { }

	// RVA: 0x143CEA4
	internal string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class NewDeviceMsg
{
	// Methods

	// RVA: 0x143B10C
	public static Message Create(InputDevice device) { }

	// RVA: 0x1439908
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class NewEventsMsg
{
	// Methods

	// RVA: 0x143B978
	public static Message CreateResetEvent(InputDevice device, bool isHardReset) { }

	// RVA: 0x143B388
	public static Message CreateStateEvent(InputDevice device) { }

	// RVA: 0x143B4E8
	public static Message Create(InputEvent* events, int eventCount) { }

	// RVA: 0x1439ECC
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

	// RVA: 0x143D024
	private static void .cctor() { }

	// RVA: 0x143D090
	public void .ctor() { }

	// RVA: 0x143D098
	internal string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class ChangeUsageMsg
{
	// Methods

	// RVA: 0x143B788
	public static Message Create(InputDevice device) { }

	// RVA: 0x143A134
	public static void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class RemoveDeviceMsg
{
	// Methods

	// RVA: 0x143B738
	public static Message Create(InputDevice device) { }

	// RVA: 0x143A4A4
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

	// RVA: 0x1438E80
	public bool get_sending() { }

	// RVA: 0x1438E8C
	private void set_sending(bool value) { }

	// RVA: 0x1438EA0
	internal void .ctor(InputManager manager, bool startSendingOnConnect) { }

	// RVA: 0x1438F40
	public void StartSending() { }

	// RVA: 0x143927C
	public void StopSending() { }

	// RVA: 0x1439574
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x143A5C4
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x143A5C8
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x143A5CC
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x1439258
	private void SendInitialMessages() { }

	// RVA: 0x143A6D4
	private void SendAllGeneratedLayouts() { }

	// RVA: 0x143AB64
	private void SendLayout(string layoutName) { }

	// RVA: 0x143A958
	private void SendAllDevices() { }

	// RVA: 0x143B084
	private void SendDevice(InputDevice device) { }

	// RVA: 0x143B480
	private void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x143B5F0
	private void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x143B9F4
	private void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	// RVA: 0x143AF0C
	private void Send(Message msg) { }

	// RVA: 0x143BB30
	private int FindOrCreateSenderRecord(int senderId) { }

	// RVA: 0x143BBDC
	private static InternedString BuildLayoutNamespace(int senderId) { }

	// RVA: 0x143BC7C
	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x143BCF0
	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x143BE64
	internal InputManager get_manager() { }

	// RVA: 0x143BE6C
	public void RemoveRemoteDevices(int participantId) { }

	// RVA: 0x318DB98
	private static Byte[] SerializeData(TData data) { }

	// RVA: 0x318DB98
	private static TData DeserializeData(Byte[] data) { }

}

// Namespace: 
private class Subscriber
{
	// Fields
	public RemoteInputPlayerConnection owner; // 0x10
	public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer; // 0x18

	// Methods

	// RVA: 0x143E15C
	public void Dispose() { }

	// RVA: 0x143DA2C
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

	// RVA: 0x143D0C0
	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	// RVA: 0x143D878
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x143D794
	private void OnConnected(int id) { }

	// RVA: 0x143DB68
	private void OnDisconnected(int id) { }

	// RVA: 0x143DC4C
	private void OnNewDevice(MessageEventArgs args) { }

	// RVA: 0x143DC58
	private void OnNewLayout(MessageEventArgs args) { }

	// RVA: 0x143DC64
	private void OnNewEvents(MessageEventArgs args) { }

	// RVA: 0x143DC70
	private void OnRemoveDevice(MessageEventArgs args) { }

	// RVA: 0x143DC7C
	private void OnChangeUsages(MessageEventArgs args) { }

	// RVA: 0x143DC88
	private void OnStartSending(MessageEventArgs args) { }

	// RVA: 0x143DC94
	private void OnStopSending(MessageEventArgs args) { }

	// RVA: 0x143DA34
	private void SendToSubscribers(MessageType type, MessageEventArgs args) { }

	// RVA: 0x143DCA0
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x143DF5C
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x143DF60
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x143DF64
	public void .ctor() { }

	// RVA: 0x143DF6C
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Sensor
{
	// Methods

	// RVA: 0x143E1B8
	public float get_samplingFrequency() { }

	// RVA: 0x143E2B4
	public void set_samplingFrequency(float value) { }

	// RVA: 0x143E364
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Accelerometer
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x188
	private static Accelerometer <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143E36C
	public Vector3Control get_acceleration() { }

	// RVA: 0x143E374
	protected void set_acceleration(Vector3Control value) { }

	// RVA: 0x143E384
	public static Accelerometer get_current() { }

	// RVA: 0x143E3D0
	private static void set_current(Accelerometer value) { }

	// RVA: 0x143E434
	public override void MakeCurrent() { }

	// RVA: 0x143E498
	protected override void OnRemoved() { }

	// RVA: 0x143E538
	protected override void FinishSetup() { }

	// RVA: 0x143E5C0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Gyroscope
{
	// Fields
	private Vector3Control <angularVelocity>k__BackingField; // 0x188
	private static Gyroscope <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143E5C8
	public Vector3Control get_angularVelocity() { }

	// RVA: 0x143E5D0
	protected void set_angularVelocity(Vector3Control value) { }

	// RVA: 0x143E5E0
	public static Gyroscope get_current() { }

	// RVA: 0x143E62C
	private static void set_current(Gyroscope value) { }

	// RVA: 0x143E690
	public override void MakeCurrent() { }

	// RVA: 0x143E6F4
	protected override void OnRemoved() { }

	// RVA: 0x143E794
	protected override void FinishSetup() { }

	// RVA: 0x143E81C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class GravitySensor
{
	// Fields
	private Vector3Control <gravity>k__BackingField; // 0x188
	private static GravitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143E824
	public Vector3Control get_gravity() { }

	// RVA: 0x143E82C
	protected void set_gravity(Vector3Control value) { }

	// RVA: 0x143E83C
	public static GravitySensor get_current() { }

	// RVA: 0x143E888
	private static void set_current(GravitySensor value) { }

	// RVA: 0x143E8EC
	protected override void FinishSetup() { }

	// RVA: 0x143E974
	public override void MakeCurrent() { }

	// RVA: 0x143E9D8
	protected override void OnRemoved() { }

	// RVA: 0x143EA78
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AttitudeSensor
{
	// Fields
	private QuaternionControl <attitude>k__BackingField; // 0x188
	private static AttitudeSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143EA80
	public QuaternionControl get_attitude() { }

	// RVA: 0x143EA88
	protected void set_attitude(QuaternionControl value) { }

	// RVA: 0x143EA98
	public static AttitudeSensor get_current() { }

	// RVA: 0x143EAE4
	private static void set_current(AttitudeSensor value) { }

	// RVA: 0x143EB48
	public override void MakeCurrent() { }

	// RVA: 0x143EBAC
	protected override void OnRemoved() { }

	// RVA: 0x143EC4C
	protected override void FinishSetup() { }

	// RVA: 0x143ECD4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LinearAccelerationSensor
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x188
	private static LinearAccelerationSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143ECDC
	public Vector3Control get_acceleration() { }

	// RVA: 0x143ECE4
	protected void set_acceleration(Vector3Control value) { }

	// RVA: 0x143ECF4
	public static LinearAccelerationSensor get_current() { }

	// RVA: 0x143ED40
	private static void set_current(LinearAccelerationSensor value) { }

	// RVA: 0x143EDA4
	public override void MakeCurrent() { }

	// RVA: 0x143EE08
	protected override void OnRemoved() { }

	// RVA: 0x143EEA8
	protected override void FinishSetup() { }

	// RVA: 0x143EF30
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class MagneticFieldSensor
{
	// Fields
	private Vector3Control <magneticField>k__BackingField; // 0x188
	private static MagneticFieldSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143EF38
	public Vector3Control get_magneticField() { }

	// RVA: 0x143EF40
	protected void set_magneticField(Vector3Control value) { }

	// RVA: 0x143EF50
	public static MagneticFieldSensor get_current() { }

	// RVA: 0x143EF9C
	private static void set_current(MagneticFieldSensor value) { }

	// RVA: 0x143F000
	public override void MakeCurrent() { }

	// RVA: 0x143F064
	protected override void OnRemoved() { }

	// RVA: 0x143F104
	protected override void FinishSetup() { }

	// RVA: 0x143F18C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LightSensor
{
	// Fields
	private AxisControl <lightLevel>k__BackingField; // 0x188
	private static LightSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143F194
	public AxisControl get_lightLevel() { }

	// RVA: 0x143F19C
	protected void set_lightLevel(AxisControl value) { }

	// RVA: 0x143F1AC
	public static LightSensor get_current() { }

	// RVA: 0x143F1F8
	private static void set_current(LightSensor value) { }

	// RVA: 0x143F25C
	public override void MakeCurrent() { }

	// RVA: 0x143F2C0
	protected override void OnRemoved() { }

	// RVA: 0x143F360
	protected override void FinishSetup() { }

	// RVA: 0x143F3E8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PressureSensor
{
	// Fields
	private AxisControl <atmosphericPressure>k__BackingField; // 0x188
	private static PressureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143F3F0
	public AxisControl get_atmosphericPressure() { }

	// RVA: 0x143F3F8
	protected void set_atmosphericPressure(AxisControl value) { }

	// RVA: 0x143F408
	public static PressureSensor get_current() { }

	// RVA: 0x143F454
	private static void set_current(PressureSensor value) { }

	// RVA: 0x143F4B8
	public override void MakeCurrent() { }

	// RVA: 0x143F51C
	protected override void OnRemoved() { }

	// RVA: 0x143F5BC
	protected override void FinishSetup() { }

	// RVA: 0x143F644
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class ProximitySensor
{
	// Fields
	private AxisControl <distance>k__BackingField; // 0x188
	private static ProximitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143F64C
	public AxisControl get_distance() { }

	// RVA: 0x143F654
	protected void set_distance(AxisControl value) { }

	// RVA: 0x143F664
	public static ProximitySensor get_current() { }

	// RVA: 0x143F6B0
	private static void set_current(ProximitySensor value) { }

	// RVA: 0x143F714
	public override void MakeCurrent() { }

	// RVA: 0x143F778
	protected override void OnRemoved() { }

	// RVA: 0x143F818
	protected override void FinishSetup() { }

	// RVA: 0x143F8A0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class HumiditySensor
{
	// Fields
	private AxisControl <relativeHumidity>k__BackingField; // 0x188
	private static HumiditySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143F8A8
	public AxisControl get_relativeHumidity() { }

	// RVA: 0x143F8B0
	protected void set_relativeHumidity(AxisControl value) { }

	// RVA: 0x143F8C0
	public static HumiditySensor get_current() { }

	// RVA: 0x143F90C
	private static void set_current(HumiditySensor value) { }

	// RVA: 0x143F970
	public override void MakeCurrent() { }

	// RVA: 0x143F9D4
	protected override void OnRemoved() { }

	// RVA: 0x143FA74
	protected override void FinishSetup() { }

	// RVA: 0x143FAFC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AmbientTemperatureSensor
{
	// Fields
	private AxisControl <ambientTemperature>k__BackingField; // 0x188
	private static AmbientTemperatureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143FB04
	public AxisControl get_ambientTemperature() { }

	// RVA: 0x143FB0C
	protected void set_ambientTemperature(AxisControl value) { }

	// RVA: 0x143FB1C
	public static AmbientTemperatureSensor get_current() { }

	// RVA: 0x143FB68
	private static void set_current(AmbientTemperatureSensor value) { }

	// RVA: 0x143FBCC
	public override void MakeCurrent() { }

	// RVA: 0x143FC30
	protected override void OnRemoved() { }

	// RVA: 0x143FCD0
	protected override void FinishSetup() { }

	// RVA: 0x143FD58
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class StepCounter
{
	// Fields
	private IntegerControl <stepCounter>k__BackingField; // 0x188
	private static StepCounter <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143FD60
	public IntegerControl get_stepCounter() { }

	// RVA: 0x143FD68
	protected void set_stepCounter(IntegerControl value) { }

	// RVA: 0x143FD78
	public static StepCounter get_current() { }

	// RVA: 0x143FDC4
	private static void set_current(StepCounter value) { }

	// RVA: 0x143FE28
	public override void MakeCurrent() { }

	// RVA: 0x143FE8C
	protected override void OnRemoved() { }

	// RVA: 0x143FF2C
	protected override void FinishSetup() { }

	// RVA: 0x143FFB4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class HingeAngle
{
	// Fields
	private AxisControl <angle>k__BackingField; // 0x188
	private static HingeAngle <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x143FFBC
	public AxisControl get_angle() { }

	// RVA: 0x143FFC4
	protected void set_angle(AxisControl value) { }

	// RVA: 0x143FFD4
	public static HingeAngle get_current() { }

	// RVA: 0x1440020
	private static void set_current(HingeAngle value) { }

	// RVA: 0x1440084
	public override void MakeCurrent() { }

	// RVA: 0x14400E8
	protected override void OnRemoved() { }

	// RVA: 0x1440188
	protected override void FinishSetup() { }

	// RVA: 0x1440210
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
	private TouchControl <primaryTouch>k__BackingField; // 0x1B8
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> <touches>k__BackingField; // 0x1C0
	private static readonly ProfilerMarker k_TouchscreenUpdateMarker; // 0x0
	private static readonly ProfilerMarker k_TouchAllocateMarker; // 0x8
	private static Touchscreen <current>k__BackingField; // 0x10
	internal static float s_TapTime; // 0x18
	internal static float s_TapDelayTime; // 0x1C
	internal static float s_TapRadiusSquared; // 0x20

	// Methods

	// RVA: 0x1440218
	public TouchControl get_primaryTouch() { }

	// RVA: 0x1440220
	protected void set_primaryTouch(TouchControl value) { }

	// RVA: 0x1440230
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches() { }

	// RVA: 0x144023C
	protected void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value) { }

	// RVA: 0x1440250
	protected TouchControl[] get_touchControlArray() { }

	// RVA: 0x1440258
	protected void set_touchControlArray(TouchControl[] value) { }

	// RVA: 0x14402D8
	public static Touchscreen get_current() { }

	// RVA: 0x1440354
	internal static void set_current(Touchscreen value) { }

	// RVA: 0x14403C0
	public override void MakeCurrent() { }

	// RVA: 0x144049C
	protected override void OnRemoved() { }

	// RVA: 0x1440600
	protected override void FinishSetup() { }

	// RVA: 0x1440A84
	protected void OnNextUpdate() { }

	// RVA: 0x1440DFC
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1441620
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x1441624
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1441628
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, UInt32 offset) { }

	// RVA: 0x1441918
	private void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	// RVA: 0x1441DB8
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x1441EE8
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x1441548
	private static void TriggerTap(TouchControl control, TouchState state, InputEventPtr eventPtr) { }

	// RVA: 0x1441F74
	public void .ctor() { }

	// RVA: 0x1441F7C
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem
public class TrackedDevice
{
	// Fields
	private IntegerControl <trackingState>k__BackingField; // 0x188
	private ButtonControl <isTracked>k__BackingField; // 0x190
	private Vector3Control <devicePosition>k__BackingField; // 0x198
	private QuaternionControl <deviceRotation>k__BackingField; // 0x1A0

	// Methods

	// RVA: 0x1442034
	public IntegerControl get_trackingState() { }

	// RVA: 0x144203C
	protected void set_trackingState(IntegerControl value) { }

	// RVA: 0x144204C
	public ButtonControl get_isTracked() { }

	// RVA: 0x1442054
	protected void set_isTracked(ButtonControl value) { }

	// RVA: 0x1442064
	public Vector3Control get_devicePosition() { }

	// RVA: 0x144206C
	protected void set_devicePosition(Vector3Control value) { }

	// RVA: 0x144207C
	public QuaternionControl get_deviceRotation() { }

	// RVA: 0x1442084
	protected void set_deviceRotation(QuaternionControl value) { }

	// RVA: 0x1442094
	protected override void FinishSetup() { }

	// RVA: 0x144220C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputExtensions
{
	// Methods

	// RVA: 0x1442214
	public static bool IsInProgress(InputActionPhase phase) { }

	// RVA: 0x1442224
	public static bool IsEndedOrCanceled(TouchPhase phase) { }

	// RVA: 0x1441904
	public static bool IsActive(TouchPhase phase) { }

	// RVA: 0x1442234
	public static bool IsModifierKey(Key key) { }

	// RVA: 0x1442244
	public static bool IsTextInputKey(Key key) { }

}

// Namespace: UnityEngine.InputSystem
internal static class InputFeatureNames
{
	// Fields
	public const string kRunPlayerUpdatesInEditMode = "RUN_PLAYER_UPDATES_IN_EDIT_MODE";
	public const string kDisableUnityRemoteSupport = "DISABLE_UNITY_REMOTE_SUPPORT";
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

	// RVA: 0x14504E0
	public int get_count() { }

	// RVA: 0x14504E8
	public void Add(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x1450738
	public void Remove(IInputStateChangeMonitor monitor, Int64 monitorIndex, bool deferRemoval) { }

	// RVA: 0x1450A68
	public void Clear() { }

	// RVA: 0x1450B30
	public void CompactArrays() { }

	// RVA: 0x1450960
	private void RemoveAt(int i) { }

	// RVA: 0x1450BB8
	public void SortMonitorsByIndex() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputManager.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.InputDevice,System.String> <>9__184_0; // 0x8

	// Methods

	// RVA: 0x1450D30
	private static void .cctor() { }

	// RVA: 0x1450D9C
	public void .ctor() { }

	// RVA: 0x1450DA4
	internal string <MakeDeviceNameUnique>b__184_0(InputDevice x) { }

}

// Namespace: 
[Serializable]
private sealed class <>c__82<T0>
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputManager.<>c__82<TDevice> <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.InputDevice> <>9__82_0; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
	internal InputDevice <RegisterPrecompiledLayout>b__82_0() { }

}

// Namespace: 
private sealed class <ListControlLayouts>d__97
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

	// RVA: 0x1450E0C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1450E44
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1450FC0
	private bool MoveNext() { }

	// RVA: 0x14523A0
	private void <>m__Finally1() { }

	// RVA: 0x14523FC
	private void <>m__Finally2() { }

	// RVA: 0x1452458
	private void <>m__Finally3() { }

	// RVA: 0x14524B4
	private void <>m__Finally4() { }

	// RVA: 0x1452510
	private void <>m__Finally5() { }

	// RVA: 0x145256C
	private void <>m__Finally6() { }

	// RVA: 0x14525C8
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x14525D0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1452610
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1452618
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x14526D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
internal class InputManager
{
	// Fields
	private static readonly ProfilerMarker k_InputUpdateProfilerMarker; // 0x0
	private static readonly ProfilerMarker k_InputTryFindMatchingControllerMarker; // 0x8
	private static readonly ProfilerMarker k_InputAddDeviceMarker; // 0x10
	private static readonly ProfilerMarker k_InputRestoreDevicesAfterReloadMarker; // 0x18
	private static readonly ProfilerMarker k_InputRegisterCustomTypesMarker; // 0x20
	private static readonly ProfilerMarker k_InputOnBeforeUpdateMarker; // 0x28
	private static readonly ProfilerMarker k_InputOnAfterUpdateMarker; // 0x30
	private static readonly ProfilerMarker k_InputOnSettingsChangeMarker; // 0x38
	private static readonly ProfilerMarker k_InputOnDeviceSettingsChangeMarker; // 0x40
	private static readonly ProfilerMarker k_InputOnEventMarker; // 0x48
	private static readonly ProfilerMarker k_InputOnLayoutChangeMarker; // 0x50
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; // 0x58
	private static readonly ProfilerMarker k_InputOnActionsChangeMarker; // 0x60
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
	private ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0xE8
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>> m_DeviceChangeListeners; // 0xF0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_DeviceStateChangeListeners; // 0x140
	private UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; // 0x190
	internal UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate> m_DeviceCommandCallbacks; // 0x1E0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange>> m_LayoutChangeListeners; // 0x230
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>> m_EventListeners; // 0x280
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_BeforeUpdateListeners; // 0x2D0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_AfterUpdateListeners; // 0x320
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_SettingsChangedListeners; // 0x370
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_ActionsChangedListeners; // 0x3C0
	private bool m_NativeBeforeUpdateHooked; // 0x410
	private bool m_HaveDevicesWithStateCallbackReceivers; // 0x411
	private bool m_HasFocus; // 0x412
	private InputEventStream m_InputEventStream; // 0x418
	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; // 0x490
	private int m_DeviceFindExecuteCommandDeviceId; // 0x498
	internal IInputRuntime m_Runtime; // 0x4A0
	internal InputMetrics m_Metrics; // 0x4A8
	internal InputSettings m_Settings; // 0x4E0
	private bool m_OptimizedControlsFeatureEnabled; // 0x4E8
	private bool m_ReadValueCachingFeatureEnabled; // 0x4E9
	private bool m_ParanoidReadValueCachingChecksEnabled; // 0x4EA
	private InputActionAsset m_Actions; // 0x4F0
	private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; // 0x4F8
	internal StateChangeMonitorsForDevice[] m_StateChangeMonitors; // 0x500
	private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; // 0x508

	// Methods

	// RVA: 0x143B010
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x1442268
	public TypeTable get_processors() { }

	// RVA: 0x1442270
	public TypeTable get_interactions() { }

	// RVA: 0x1442278
	public TypeTable get_composites() { }

	// RVA: 0x1442280
	public InputMetrics get_metrics() { }

	// RVA: 0x1442420
	public InputSettings get_settings() { }

	// RVA: 0x1442428
	public void set_settings(InputSettings value) { }

	// RVA: 0x1442BD0
	public InputActionAsset get_actions() { }

	// RVA: 0x1442BD8
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x1442D04
	public InputUpdateType get_updateMask() { }

	// RVA: 0x1442D0C
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x1442EDC
	public InputUpdateType get_defaultUpdateType() { }

	// RVA: 0x1442EF8
	public ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	// RVA: 0x1442F00
	public void set_scrollDeltaBehavior(ScrollDeltaBehavior value) { }

	// RVA: 0x1442F14
	public float get_pollingFrequency() { }

	// RVA: 0x1442F1C
	public void set_pollingFrequency(float value) { }

	// RVA: 0x14391A0
	public void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x14394BC
	public void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x1443048
	public void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x14430A4
	public void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1443100
	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x144315C
	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x14431B8
	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x14434FC
	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x14391FC
	public void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x1439518
	public void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x1439144
	public void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1439460
	public void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x1443558
	public void add_onBeforeUpdate(Action value) { }

	// RVA: 0x14436D4
	public void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x1443730
	public void add_onAfterUpdate(Action value) { }

	// RVA: 0x144378C
	public void remove_onAfterUpdate(Action value) { }

	// RVA: 0x14437E8
	public void add_onSettingsChange(Action value) { }

	// RVA: 0x1443844
	public void remove_onSettingsChange(Action value) { }

	// RVA: 0x14438A0
	public void add_onActionsChange(Action value) { }

	// RVA: 0x14438FC
	public void remove_onActionsChange(Action value) { }

	// RVA: 0x1443958
	public bool get_isProcessingEvents() { }

	// RVA: 0x1443960
	private bool get_gameIsPlaying() { }

	// RVA: 0x1443968
	private bool get_gameHasFocus() { }

	// RVA: 0x14439A4
	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	// RVA: 0x14439CC
	public void RegisterControlLayout(string name, Type type) { }

	// RVA: 0x143C5F4
	public void RegisterControlLayout(string json, string name, bool isOverride) { }

	// RVA: 0x14447C0
	public void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout) { }

	// RVA: 0x144411C
	private void PerformLayoutPostRegistration(InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout, bool isOverride) { }

	// RVA: 0x30D4CD4
	public void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x1444964
	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout) { }

	// RVA: 0x1444D04
	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	// RVA: 0x1444C20
	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	// RVA: 0x144464C
	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x14455F8
	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	// RVA: 0x1444FA4
	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x1444E18
	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	// RVA: 0x14451FC
	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	// RVA: 0x1446540
	public void RemoveControlLayout(string name) { }

	// RVA: 0x14467BC
	public InputControlLayout TryLoadControlLayout(Type type) { }

	// RVA: 0x143C5E4
	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	// RVA: 0x144584C
	public InternedString TryFindMatchingControlLayout(InputDeviceDescription deviceDescription, int deviceId) { }

	// RVA: 0x1446A04
	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	// RVA: 0x1446AA8
	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	// RVA: 0x1446BD4
	public System.Collections.Generic.IEnumerable<System.String> ListControlLayouts(string basedOn) { }

	// RVA: -1
	public int GetControls(string path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x1446C68
	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x143CCDC
	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x143CED0
	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x1446DE4
	private void NotifyUsageChanged(InputDevice device) { }

	// RVA: 0x1446F00
	public InputDevice AddDevice(Type type, string name) { }

	// RVA: 0x143CB8C
	public InputDevice AddDevice(string layout, string name, InternedString variants) { }

	// RVA: 0x1446384
	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName, InputDeviceDescription deviceDescription, DeviceFlags deviceFlags, InternedString variants) { }

	// RVA: 0x1445D78
	public void AddDevice(InputDevice device) { }

	// RVA: 0x1447B84
	public InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x1447BCC
	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x1447D9C
	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x143C060
	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices) { }

	// RVA: 0x1447FA8
	public void FlushDisconnectedDevices() { }

	// RVA: 0x1448008
	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls, System.Nullable<System.Boolean> issueResetCommand) { }

	// RVA: 0x1448D60
	public InputDevice TryGetDevice(string nameOrLayout) { }

	// RVA: 0x1448E88
	public InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x1448F2C
	public InputDevice TryGetDevice(Type layoutType) { }

	// RVA: 0x143BDDC
	public InputDevice TryGetDeviceById(int id) { }

	// RVA: 0x1448F90
	public int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x14476F0
	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope) { }

	// RVA: 0x1449144
	private void QueueEvent(InputEvent* eventPtr) { }

	// RVA: 0x143CECC
	public void QueueEvent(InputEventPtr ptr) { }

	// RVA: 0x30D4CD4
	public void QueueEvent(TEvent inputEvent) { }

	// RVA: 0x1449220
	public void Update() { }

	// RVA: 0x1449300
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x14493B8
	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x144B3C8
	internal void Destroy() { }

	// RVA: 0x1449488
	private void InitializeActions() { }

	// RVA: 0x144953C
	internal void InitializeData() { }

	// RVA: 0x144BBDC
	private void RegisterCustomTypes(Type[] types) { }

	// RVA: 0x144B964
	private void RegisterCustomTypes() { }

	// RVA: 0x144A9DC
	internal void InstallRuntime(IInputRuntime runtime) { }

	// RVA: 0x144B15C
	internal void InstallGlobals() { }

	// RVA: 0x144B514
	internal void UninstallGlobals() { }

	// RVA: 0x144BE20
	internal bool get_optimizedControlsFeatureEnabled() { }

	// RVA: 0x144BE28
	internal void set_optimizedControlsFeatureEnabled(bool value) { }

	// RVA: 0x144BE30
	internal bool get_readValueCachingFeatureEnabled() { }

	// RVA: 0x144BE38
	internal void set_readValueCachingFeatureEnabled(bool value) { }

	// RVA: 0x144BE40
	internal bool get_paranoidReadValueCachingChecksEnabled() { }

	// RVA: 0x144BE48
	internal void set_paranoidReadValueCachingChecksEnabled(bool value) { }

	// RVA: 0x1447010
	private void MakeDeviceNameUnique(InputDevice device) { }

	// RVA: 0x144BE50
	private static void ResetControlPathsRecursive(InputControl control) { }

	// RVA: 0x14471E4
	private void AssignUniqueDeviceId(InputDevice device) { }

	// RVA: 0x1442D30
	private void ReallocateStateBuffers() { }

	// RVA: 0x144BF48
	private void InitializeDefaultState(InputDevice device) { }

	// RVA: 0x14473D0
	private void InitializeDeviceState(InputDevice device) { }

	// RVA: 0x144C104
	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x144C834
	private JsonString MakeEscapedJsonString(string theString) { }

	// RVA: 0x144C578
	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	// RVA: 0x14435BC
	private void InstallBeforeUpdateHookIfNecessary() { }

	// RVA: 0x144C574
	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	// RVA: 0x144C9F0
	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	// RVA: 0x144C9F4
	private void OnBeforeUpdate(InputUpdateType updateType) { }

	// RVA: 0x1442564
	internal void ApplySettings() { }

	// RVA: 0x1442C74
	internal void ApplyActions() { }

	// RVA: -1
	internal Int64 ExecuteGlobalCommand(TCommand command) { }

	// RVA: 0x144321C
	internal void AddAvailableDevicesThatAreNowRecognized() { }

	// RVA: 0x14476B0
	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	// RVA: 0x144CBFC
	internal void OnFocusChanged(bool focus) { }

	// RVA: 0x144CEE0
	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	// RVA: 0x144CEFC
	private void OnUpdate(InputUpdateType updateType, InputEventBuffer eventBuffer) { }

	// RVA: 0x144E860
	private bool AreMaximumEventBytesPerUpdateExceeded(UInt32 totalEventBytesProcessed) { }

	// RVA: 0x144EA74
	private string MakeStringWithEventsProcessedByDevice() { }

	// RVA: 0x144E99C
	private void ResetCurrentProcessedEventBytesForDevices() { }

	// RVA: 0x144ECD8
	private void CheckAllDevicesOptimizedControlsHaveValidState() { }

	// RVA: 0x144E638
	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	// RVA: 0x144EEC0
	internal void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	// RVA: 0x144E6EC
	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	// RVA: 0x144867C
	internal bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, UInt32 stateOffsetInDevice, UInt32 stateSize, Double internalTime, InputEventPtr eventPtr) { }

	// RVA: 0x144F288
	private void WriteStateChange(DoubleBuffers buffers, int deviceIndex, InputStateBlock deviceStateBlock, UInt32 stateOffsetInDevice, Void* statePtr, UInt32 stateSizeInBytes, bool flippedBuffers) { }

	// RVA: 0x144F1C0
	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	// RVA: 0x144F9C0
	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x1447E80
	private void RemoveStateChangeMonitors(InputDevice device) { }

	// RVA: 0x144FB40
	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x144FCA4
	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x144FD84
	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x144EEC8
	private void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	// RVA: 0x144FEAC
	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	// RVA: 0x144FFDC
	public void FireStateChangeNotifications() { }

	// RVA: 0x144EF20
	private bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, UInt32 newStateSizeInBytes, UInt32 newStateOffsetInBytes) { }

	// RVA: 0x144F4B0
	internal void FireStateChangeNotifications(int deviceIndex, Double internalTime, InputEvent* eventPtr) { }

	// RVA: 0x144E36C
	private void ProcessStateChangeMonitorTimeouts() { }

	// RVA: 0x1450128
	public void .ctor() { }

	// RVA: 0x1450130
	private static void .cctor() { }

	// RVA: 0x1450468
	private Int64 <TryFindMatchingControlLayout>b__94_0(InputDeviceCommand commandRef) { }

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
public enum ScrollDeltaBehavior
{
	// Fields
	public int value__; // 0x10
	public const ScrollDeltaBehavior UniformAcrossAllPlatforms = 0;
	public const ScrollDeltaBehavior KeepPlatformSpecificInputRange = 1;
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

	// RVA: 0x1453474
	public PrivacyDataUsage get_motionUsage() { }

	// RVA: 0x145347C
	public void set_motionUsage(PrivacyDataUsage value) { }

	// RVA: 0x14533FC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class InputSettings
{
	// Fields
	private string[] m_SupportedDevices; // 0x18
	private UpdateMode m_UpdateMode; // 0x20
	private ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0x24
	private int m_MaxEventBytesPerUpdate; // 0x28
	private int m_MaxQueuedEventsPerUpdate; // 0x2C
	private bool m_CompensateForScreenOrientation; // 0x30
	private BackgroundBehavior m_BackgroundBehavior; // 0x34
	private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; // 0x38
	private InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; // 0x3C
	private float m_DefaultDeadzoneMin; // 0x40
	private float m_DefaultDeadzoneMax; // 0x44
	private float m_DefaultButtonPressPoint; // 0x48
	private float m_ButtonReleaseThreshold; // 0x4C
	private float m_DefaultTapTime; // 0x50
	private float m_DefaultSlowTapTime; // 0x54
	private float m_DefaultHoldTime; // 0x58
	private float m_TapRadius; // 0x5C
	private float m_MultiTapDelayTime; // 0x60
	private bool m_DisableRedundantEventsMerging; // 0x64
	private bool m_ShortcutKeysConsumeInputs; // 0x65
	internal System.Collections.Generic.HashSet<System.String> m_FeatureFlags; // 0x68
	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;
	private iOSSettings m_iOSSettings; // 0x70

	// Methods

	// RVA: 0x14526D4
	public UpdateMode get_updateMode() { }

	// RVA: 0x14526DC
	public void set_updateMode(UpdateMode value) { }

	// RVA: 0x145280C
	public ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	// RVA: 0x1452814
	public void set_scrollDeltaBehavior(ScrollDeltaBehavior value) { }

	// RVA: 0x145282C
	public bool get_compensateForScreenOrientation() { }

	// RVA: 0x1452834
	public void set_compensateForScreenOrientation(bool value) { }

	// RVA: 0x145284C
	public bool get_filterNoiseOnCurrent() { }

	// RVA: 0x1452854
	public void set_filterNoiseOnCurrent(bool value) { }

	// RVA: 0x1452858
	public float get_defaultDeadzoneMin() { }

	// RVA: 0x1452860
	public void set_defaultDeadzoneMin(float value) { }

	// RVA: 0x1452878
	public float get_defaultDeadzoneMax() { }

	// RVA: 0x1452880
	public void set_defaultDeadzoneMax(float value) { }

	// RVA: 0x1452898
	public float get_defaultButtonPressPoint() { }

	// RVA: 0x14528A0
	public void set_defaultButtonPressPoint(float value) { }

	// RVA: 0x14528DC
	public float get_buttonReleaseThreshold() { }

	// RVA: 0x14528E4
	public void set_buttonReleaseThreshold(float value) { }

	// RVA: 0x14528FC
	public float get_defaultTapTime() { }

	// RVA: 0x1452904
	public void set_defaultTapTime(float value) { }

	// RVA: 0x145291C
	public float get_defaultSlowTapTime() { }

	// RVA: 0x1452924
	public void set_defaultSlowTapTime(float value) { }

	// RVA: 0x145293C
	public float get_defaultHoldTime() { }

	// RVA: 0x1452944
	public void set_defaultHoldTime(float value) { }

	// RVA: 0x145295C
	public float get_tapRadius() { }

	// RVA: 0x1452964
	public void set_tapRadius(float value) { }

	// RVA: 0x145297C
	public float get_multiTapDelayTime() { }

	// RVA: 0x1452984
	public void set_multiTapDelayTime(float value) { }

	// RVA: 0x145299C
	public BackgroundBehavior get_backgroundBehavior() { }

	// RVA: 0x14529A4
	public void set_backgroundBehavior(BackgroundBehavior value) { }

	// RVA: 0x14529BC
	public EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	// RVA: 0x14529C4
	public void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	// RVA: 0x14529DC
	public InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	// RVA: 0x14529E4
	public void set_inputActionPropertyDrawerMode(InputActionPropertyDrawerMode value) { }

	// RVA: 0x14529FC
	public int get_maxEventBytesPerUpdate() { }

	// RVA: 0x1452A04
	public void set_maxEventBytesPerUpdate(int value) { }

	// RVA: 0x1452A1C
	public int get_maxQueuedEventsPerUpdate() { }

	// RVA: 0x1452A24
	public void set_maxQueuedEventsPerUpdate(int value) { }

	// RVA: 0x1452A3C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> get_supportedDevices() { }

	// RVA: 0x1452AA8
	public void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> value) { }

	// RVA: 0x1452C30
	public bool get_disableRedundantEventsMerging() { }

	// RVA: 0x1452C38
	public void set_disableRedundantEventsMerging(bool value) { }

	// RVA: 0x1452C50
	public bool get_shortcutKeysConsumeInput() { }

	// RVA: 0x1452C58
	public void set_shortcutKeysConsumeInput(bool value) { }

	// RVA: 0x1452C70
	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

	// RVA: 0x1452E08
	internal bool IsFeatureEnabled(string featureName) { }

	// RVA: 0x14526F4
	internal void OnChange() { }

	// RVA: 0x1452E94
	private static bool CompareFloats(float a, float b) { }

	// RVA: 0x318DB98
	private static bool CompareSets(UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> a, UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> b) { }

	// RVA: 0x1452EAC
	private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName) { }

	// RVA: 0x1452F94
	internal static bool AreEqual(InputSettings a, InputSettings b) { }

	// RVA: 0x14532F4
	public iOSSettings get_iOS() { }

	// RVA: 0x14532FC
	public void .ctor() { }

}

// Namespace: 
public struct PlayerActions
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x1454014
	public void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x145401C
	public InputAction get_Move() { }

	// RVA: 0x145403C
	public InputAction get_Look() { }

	// RVA: 0x145405C
	public InputAction get_Fire() { }

	// RVA: 0x145407C
	public InputActionMap Get() { }

	// RVA: 0x145409C
	public void Enable() { }

	// RVA: 0x14540C4
	public void Disable() { }

	// RVA: 0x14540EC
	public bool get_enabled() { }

	// RVA: 0x1454114
	public static InputActionMap op_Implicit(PlayerActions set) { }

	// RVA: 0x1454130
	public void SetCallbacks(IPlayerActions instance) { }

}

// Namespace: 
public struct UIActions
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x1454DC8
	public void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x1454DD0
	public InputAction get_Navigate() { }

	// RVA: 0x1454DF0
	public InputAction get_Submit() { }

	// RVA: 0x1454E10
	public InputAction get_Cancel() { }

	// RVA: 0x1454E30
	public InputAction get_Point() { }

	// RVA: 0x1454E50
	public InputAction get_Click() { }

	// RVA: 0x1454E70
	public InputAction get_ScrollWheel() { }

	// RVA: 0x1454E90
	public InputAction get_MiddleClick() { }

	// RVA: 0x1454EB0
	public InputAction get_RightClick() { }

	// RVA: 0x1454ED0
	public InputAction get_TrackedDevicePosition() { }

	// RVA: 0x1454EF0
	public InputAction get_TrackedDeviceOrientation() { }

	// RVA: 0x1454F10
	public InputActionMap Get() { }

	// RVA: 0x1454F30
	public void Enable() { }

	// RVA: 0x1454F58
	public void Disable() { }

	// RVA: 0x1454F80
	public bool get_enabled() { }

	// RVA: 0x1454FA8
	public static InputActionMap op_Implicit(UIActions set) { }

	// RVA: 0x1454FC4
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

	// RVA: 0x1453484
	public InputActionAsset get_asset() { }

	// RVA: 0x145348C
	public void .ctor() { }

	// RVA: 0x14538CC
	public void Dispose() { }

	// RVA: 0x145395C
	public System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x145399C
	public void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x14539E4
	public System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x1453A30
	public void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x1453A70
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x1453A90
	public bool Contains(InputAction action) { }

	// RVA: 0x1453AB0
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x1453AD0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1453AF0
	public void Enable() { }

	// RVA: 0x1453B10
	public void Disable() { }

	// RVA: 0x1453B30
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1453B50
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1453B70
	public int FindBinding(InputBinding bindingMask, InputAction action) { }

	// RVA: 0x1453BC0
	public PlayerActions get_Player() { }

	// RVA: 0x1453BEC
	public UIActions get_UI() { }

	// RVA: 0x1453C18
	public InputControlScheme get_KeyboardMouseScheme() { }

	// RVA: 0x1453CE4
	public InputControlScheme get_GamepadScheme() { }

	// RVA: 0x1453DB0
	public InputControlScheme get_TouchScheme() { }

	// RVA: 0x1453E7C
	public InputControlScheme get_JoystickScheme() { }

	// RVA: 0x1453F48
	public InputControlScheme get_XRScheme() { }

}

// Namespace: UnityEngine.InputSystem
public class InputValue
{
	// Fields
	internal System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext> m_Context; // 0x10

	// Methods

	// RVA: 0x1457894
	public object Get() { }

	// RVA: 0x318DB98
	public TValue Get() { }

	// RVA: 0x145790C
	public bool get_isPressed() { }

	// RVA: 0x145799C
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

	// RVA: 0x1460D30
	public string get_actionId() { }

	// RVA: 0x1460D38
	public string get_actionName() { }

	// RVA: 0x1460D40
	public void .ctor() { }

	// RVA: 0x1460D94
	public void .ctor(InputAction action) { }

	// RVA: 0x1460F78
	public void .ctor(Guid actionGUID, string name) { }

}

// Namespace: 
[Serializable]
public class DeviceLostEvent
{
	// Methods

	// RVA: 0x1459BB0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DeviceRegainedEvent
{
	// Methods

	// RVA: 0x1459CC4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ControlsChangedEvent
{
	// Methods

	// RVA: 0x1459DD8
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PlayerInput
{
	// Fields
	public const string DeviceLostMessage = "OnDeviceLost";
	public const string DeviceRegainedMessage = "OnDeviceRegained";
	public const string ControlsChangedMessage = "OnControlsChanged";
	private int m_AllMapsHashCode; // 0x20
	internal InputActionAsset m_Actions; // 0x28
	internal PlayerNotifications m_NotificationBehavior; // 0x30
	internal InputSystemUIInputModule m_UIInputModule; // 0x38
	internal DeviceLostEvent m_DeviceLostEvent; // 0x40
	internal DeviceRegainedEvent m_DeviceRegainedEvent; // 0x48
	internal ControlsChangedEvent m_ControlsChangedEvent; // 0x50
	internal ActionEvent[] m_ActionEvents; // 0x58
	internal bool m_NeverAutoSwitchControlSchemes; // 0x60
	internal string m_DefaultControlScheme; // 0x68
	internal string m_DefaultActionMap; // 0x70
	internal int m_SplitScreenIndex; // 0x78
	internal Camera m_Camera; // 0x80
	private InputValue m_InputValueObject; // 0x88
	internal InputActionMap m_CurrentActionMap; // 0x90
	private int m_PlayerIndex; // 0x98
	private bool m_InputActive; // 0x9C
	private bool m_Enabled; // 0x9D
	internal bool m_ActionsInitialized; // 0x9E
	private System.Collections.Generic.Dictionary<System.String,System.String> m_ActionMessageNames; // 0xA0
	private InputUser m_InputUser; // 0xA8
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ActionTriggeredDelegate; // 0xB0
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceLostCallbacks; // 0xB8
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceRegainedCallbacks; // 0x108
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_ControlsChangedCallbacks; // 0x158
	private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionTriggeredCallbacks; // 0x1A8
	private System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x1F8
	private System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> m_PreFilterUnpairedDeviceUsedDelegate; // 0x200
	private bool m_OnUnpairedDeviceUsedHooked; // 0x208
	private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> m_DeviceChangeDelegate; // 0x210
	private bool m_OnDeviceChangeHooked; // 0x218
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

	// RVA: 0x14579A4
	public bool get_inputIsActive() { }

	// RVA: 0x14579AC
	public bool get_active() { }

	// RVA: 0x14579B4
	public int get_playerIndex() { }

	// RVA: 0x14579BC
	public int get_splitScreenIndex() { }

	// RVA: 0x14579C4
	public InputActionAsset get_actions() { }

	// RVA: 0x1457DBC
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x1459288
	public string get_currentControlScheme() { }

	// RVA: 0x1459648
	public string get_defaultControlScheme() { }

	// RVA: 0x1459650
	public void set_defaultControlScheme(string value) { }

	// RVA: 0x1459658
	public bool get_neverAutoSwitchControlSchemes() { }

	// RVA: 0x1459660
	public void set_neverAutoSwitchControlSchemes(bool value) { }

	// RVA: 0x1459918
	public InputActionMap get_currentActionMap() { }

	// RVA: 0x1459920
	public void set_currentActionMap(InputActionMap value) { }

	// RVA: 0x1459998
	public string get_defaultActionMap() { }

	// RVA: 0x14599A0
	public void set_defaultActionMap(string value) { }

	// RVA: 0x14599A8
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x14599B0
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x1459A0C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents() { }

	// RVA: 0x1459A60
	public void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value) { }

	// RVA: 0x1459AF0
	public DeviceLostEvent get_deviceLostEvent() { }

	// RVA: 0x1459C04
	public DeviceRegainedEvent get_deviceRegainedEvent() { }

	// RVA: 0x1459D18
	public ControlsChangedEvent get_controlsChangedEvent() { }

	// RVA: 0x1459E2C
	public void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1459ED4
	public void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1459F7C
	public void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x145A024
	public void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x145A0CC
	public void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x145A174
	public void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x145A21C
	public void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x145A2C4
	public void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x145A36C
	public Camera get_camera() { }

	// RVA: 0x145A374
	public void set_camera(Camera value) { }

	// RVA: 0x145A37C
	public InputSystemUIInputModule get_uiInputModule() { }

	// RVA: 0x145A384
	public void set_uiInputModule(InputSystemUIInputModule value) { }

	// RVA: 0x145A588
	public InputUser get_user() { }

	// RVA: 0x145A590
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x145A734
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x145A8B8
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all() { }

	// RVA: 0x145A94C
	public static bool get_isSinglePlayer() { }

	// RVA: 0x318DB98
	public TDevice GetDevice() { }

	// RVA: 0x14591B0
	public void ActivateInput() { }

	// RVA: 0x145AAB8
	private void UpdateDelegates() { }

	// RVA: 0x145B4A8
	public void DeactivateInput() { }

	// RVA: 0x145B4D8
	public void PassivateInput() { }

	// RVA: 0x145B508
	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	// RVA: 0x145BCDC
	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	// RVA: 0x145ACE4
	public void SwitchCurrentActionMap(string mapNameOrId) { }

	// RVA: 0x145BF34
	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	// RVA: 0x145C048
	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	// RVA: 0x145C268
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice pairWithDevice) { }

	// RVA: 0x145C738
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice[] pairWithDevices) { }

	// RVA: 0x145C3F8
	private static PlayerInput DoInstantiate(GameObject prefab) { }

	// RVA: 0x1457A24
	private void InitializeActions() { }

	// RVA: 0x1458180
	private void CopyActionAssetAndApplyBindingOverrides() { }

	// RVA: 0x1457F8C
	private void UninitializeActions() { }

	// RVA: 0x145AED4
	private void InstallOnActionTriggeredHook() { }

	// RVA: 0x145C91C
	private void UninstallOnActionTriggeredHook() { }

	// RVA: 0x145CA9C
	private void OnActionTriggered(CallbackContext context) { }

	// RVA: 0x145B0C8
	private void CacheMessageNames() { }

	// RVA: 0x14583F0
	private void ClearCaches() { }

	// RVA: 0x145844C
	private void AssignUserAndDevices() { }

	// RVA: 0x145D6D8
	private bool HaveBindingForDevice(InputDevice device) { }

	// RVA: 0x145DC0C
	private void UnassignUserAndDevices() { }

	// RVA: 0x145D2E0
	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	// RVA: 0x145E2B0
	private void AssignPlayerIndex() { }

	// RVA: 0x145E504
	private void Awake() { }

	// RVA: 0x145E5B0
	private void OnEnable() { }

	// RVA: 0x1459694
	private void StartListeningForUnpairedDeviceActivity() { }

	// RVA: 0x1459858
	private void StopListeningForUnpairedDeviceActivity() { }

	// RVA: 0x145EBCC
	private void StartListeningForDeviceChanges() { }

	// RVA: 0x145F510
	private void StopListeningForDeviceChanges() { }

	// RVA: 0x145F580
	private void OnDisable() { }

	// RVA: 0x145FAE8
	public void DebugLogAction(CallbackContext context) { }

	// RVA: 0x145FB60
	private void HandleDeviceLost() { }

	// RVA: 0x145FC88
	private void HandleDeviceRegained() { }

	// RVA: 0x145ECD8
	private void HandleControlsChanged() { }

	// RVA: 0x145FDB0
	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	// RVA: 0x145FFA4
	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	// RVA: 0x14601D4
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1460A44
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x145B764
	private void SwitchControlSchemeInternal(InputControlScheme controlScheme, InputDevice[] devices) { }

	// RVA: 0x1460CCC
	public void .ctor() { }

	// RVA: 0x1460CE0
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class PlayerJoinedEvent
{
	// Methods

	// RVA: 0x1461FF0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class PlayerLeftEvent
{
	// Methods

	// RVA: 0x1462104
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

	// RVA: 0x146100C
	public bool get_splitScreen() { }

	// RVA: 0x1461014
	public void set_splitScreen(bool value) { }

	// RVA: 0x1461954
	public bool get_maintainAspectRatioInSplitScreen() { }

	// RVA: 0x146195C
	public int get_fixedNumberOfSplitScreens() { }

	// RVA: 0x1461964
	public Rect get_splitScreenArea() { }

	// RVA: 0x1461970
	public int get_playerCount() { }

	// RVA: 0x14619EC
	public int get_maxPlayerCount() { }

	// RVA: 0x14619F4
	public bool get_joiningEnabled() { }

	// RVA: 0x14619FC
	public PlayerJoinBehavior get_joinBehavior() { }

	// RVA: 0x1461A04
	public void set_joinBehavior(PlayerJoinBehavior value) { }

	// RVA: 0x1461E34
	public InputActionProperty get_joinAction() { }

	// RVA: 0x1461E48
	public void set_joinAction(InputActionProperty value) { }

	// RVA: 0x1461F20
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x1461F28
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x1461F30
	public PlayerJoinedEvent get_playerJoinedEvent() { }

	// RVA: 0x1462044
	public PlayerLeftEvent get_playerLeftEvent() { }

	// RVA: 0x1462158
	public void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x1462200
	public void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x14622A8
	public void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x1462350
	public void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x14623F8
	public GameObject get_playerPrefab() { }

	// RVA: 0x1462400
	public void set_playerPrefab(GameObject value) { }

	// RVA: 0x1462408
	public static PlayerInputManager get_instance() { }

	// RVA: 0x1462454
	private static void set_instance(PlayerInputManager value) { }

	// RVA: 0x1461BB8
	public void EnableJoining() { }

	// RVA: 0x1461A58
	public void DisableJoining() { }

	// RVA: 0x14624BC
	internal void JoinPlayerFromUI() { }

	// RVA: 0x1462840
	public void JoinPlayerFromAction(CallbackContext context) { }

	// RVA: 0x14629D4
	public void JoinPlayerFromActionIfNotAlreadyJoined(CallbackContext context) { }

	// RVA: 0x1462904
	public PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice pairWithDevice) { }

	// RVA: 0x1462B38
	public PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice[] pairWithDevices) { }

	// RVA: 0x1462C08
	internal static string[] get_messages() { }

	// RVA: 0x1462514
	private bool CheckIfPlayerCanJoin(int playerIndex) { }

	// RVA: 0x1462CC8
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x14632B8
	private void OnEnable() { }

	// RVA: 0x14636E8
	private void OnDisable() { }

	// RVA: 0x14612E4
	private void UpdateSplitScreen() { }

	// RVA: 0x1462DE8
	private bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	// RVA: 0x14624B8
	private void ValidateInputActionAsset() { }

	// RVA: 0x145EE00
	internal void NotifyPlayerJoined(PlayerInput player) { }

	// RVA: 0x145F99C
	internal void NotifyPlayerLeft(PlayerInput player) { }

	// RVA: 0x1463800
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

	// RVA: 0x14506B8
	public void SetLength(int newLength) { }

	// RVA: 0x1463840
	public void SetBit(int bitIndex) { }

	// RVA: 0x1463900
	public bool TestBit(int bitIndex) { }

	// RVA: 0x14508A0
	public void ClearBit(int bitIndex) { }

	// RVA: 0x1463984
	public bool AnyBitIsSet() { }

	// RVA: 0x1463828
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

	// RVA: 0x1463A20
	public TrackingType get_trackingType() { }

	// RVA: 0x1463A28
	public void set_trackingType(TrackingType value) { }

	// RVA: 0x1463A30
	public UpdateType get_updateType() { }

	// RVA: 0x1463A38
	public void set_updateType(UpdateType value) { }

	// RVA: 0x1463A40
	public bool get_ignoreTrackingState() { }

	// RVA: 0x1463A48
	public void set_ignoreTrackingState(bool value) { }

	// RVA: 0x1463A50
	public InputActionProperty get_positionInput() { }

	// RVA: 0x1463A64
	public void set_positionInput(InputActionProperty value) { }

	// RVA: 0x1463E68
	public InputActionProperty get_rotationInput() { }

	// RVA: 0x1463E7C
	public void set_rotationInput(InputActionProperty value) { }

	// RVA: 0x1464280
	public InputActionProperty get_trackingStateInput() { }

	// RVA: 0x1464294
	public void set_trackingStateInput(InputActionProperty value) { }

	// RVA: 0x1464698
	private void BindActions() { }

	// RVA: 0x14646C4
	private void UnbindActions() { }

	// RVA: 0x1463CBC
	private void BindPosition() { }

	// RVA: 0x14640D4
	private void BindRotation() { }

	// RVA: 0x14644EC
	private void BindTrackingState() { }

	// RVA: 0x14646F0
	private static void RenameAndEnable(InputAction action, string name) { }

	// RVA: 0x1463B60
	private void UnbindPosition() { }

	// RVA: 0x1463F78
	private void UnbindRotation() { }

	// RVA: 0x1464390
	private void UnbindTrackingState() { }

	// RVA: 0x1464724
	private void OnPositionPerformed(CallbackContext context) { }

	// RVA: 0x146479C
	private void OnPositionCanceled(CallbackContext context) { }

	// RVA: 0x14647F8
	private void OnRotationPerformed(CallbackContext context) { }

	// RVA: 0x1464868
	private void OnRotationCanceled(CallbackContext context) { }

	// RVA: 0x14648BC
	private void OnTrackingStatePerformed(CallbackContext context) { }

	// RVA: 0x146492C
	private void OnTrackingStateCanceled(CallbackContext context) { }

	// RVA: 0x1464934
	protected void Reset() { }

	// RVA: 0x1464B38
	protected virtual void Awake() { }

	// RVA: 0x1464B3C
	protected void OnEnable() { }

	// RVA: 0x1464C10
	protected void OnDisable() { }

	// RVA: 0x1464CD8
	protected virtual void OnDestroy() { }

	// RVA: 0x1464CDC
	protected void UpdateCallback() { }

	// RVA: 0x1464F6C
	private void ReadTrackingState(bool hasResolvedPositionInputControl, bool hasResolvedRotationInputControl) { }

	// RVA: 0x14650A8
	protected virtual void OnUpdate() { }

	// RVA: 0x14650C4
	protected virtual void OnBeforeRender() { }

	// RVA: 0x14650E4
	protected virtual void PerformUpdate() { }

	// RVA: 0x1465100
	protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	// RVA: 0x1465284
	private bool HasStereoCamera(Camera cameraComponent) { }

	// RVA: 0x1464E90
	private static bool HasResolvedControl(InputAction action) { }

	// RVA: 0x1465308
	public InputAction get_positionAction() { }

	// RVA: 0x1465314
	public void set_positionAction(InputAction value) { }

	// RVA: 0x1465368
	public InputAction get_rotationAction() { }

	// RVA: 0x1465374
	public void set_rotationAction(InputAction value) { }

	// RVA: 0x14653C8
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x14653CC
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x14654A8
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
	private ButtonControl <menu>k__BackingField; // 0x208
	private ButtonControl <view>k__BackingField; // 0x210
	private bool m_HaveParsedCapabilities; // 0x218
	private DeviceSubType m_SubType; // 0x21C
	private DeviceFlags m_Flags; // 0x220

	// Methods

	// RVA: 0x1465554
	public ButtonControl get_menu() { }

	// RVA: 0x146555C
	protected void set_menu(ButtonControl value) { }

	// RVA: 0x146556C
	public ButtonControl get_view() { }

	// RVA: 0x1465574
	protected void set_view(ButtonControl value) { }

	// RVA: 0x1465584
	public DeviceSubType get_subType() { }

	// RVA: 0x14656CC
	public DeviceFlags get_flags() { }

	// RVA: 0x146576C
	protected override void FinishSetup() { }

	// RVA: 0x1465624
	private void ParseCapabilities() { }

	// RVA: 0x14657AC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.XInput
internal static class XInputSupport
{
	// Methods

	// RVA: 0x14657B4
	public static void Initialize() { }

}

// Namespace: 
public struct ControlSchemeChangeSyntax
{
	// Fields
	internal int m_UserIndex; // 0x10

	// Methods

	// RVA: 0x146BDD0
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

	// RVA: 0x146BE44
	public int Compare(InputDevice x, InputDevice y) { }

	// RVA: 0x146C488
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
	public static TypedRestore <>9__88_0; // 0x8
	public static Action <>9__88_1; // 0x10

	// Methods

	// RVA: 0x146C570
	private static void .cctor() { }

	// RVA: 0x146C5DC
	public void .ctor() { }

	// RVA: 0x146C5E4
	internal void <SaveAndResetState>b__88_0(GlobalState state) { }

	// RVA: 0x146C680
	internal void <SaveAndResetState>b__88_1() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUser
{
	// Fields
	public const UInt32 InvalidId = 0;
	private static readonly ProfilerMarker k_InputUserOnChangeMarker; // 0x0
	private static readonly ProfilerMarker k_InputCheckForUnpairMarker; // 0x8
	private UInt32 m_Id; // 0x10
	private static GlobalState s_GlobalState; // 0x10

	// Methods

	// RVA: 0x14594B8
	public bool get_valid() { }

	// RVA: 0x1465828
	public int get_index() { }

	// RVA: 0x1465A24
	public UInt32 get_id() { }

	// RVA: 0x1465A2C
	public System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle() { }

	// RVA: 0x1465AF0
	public string get_platformUserAccountName() { }

	// RVA: 0x1465BA4
	public string get_platformUserAccountId() { }

	// RVA: 0x145A648
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices() { }

	// RVA: 0x1465C58
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices() { }

	// RVA: 0x1465D44
	public IInputActionCollection get_actions() { }

	// RVA: 0x1459588
	public System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme() { }

	// RVA: 0x1465DF8
	public MatchResult get_controlSchemeMatch() { }

	// RVA: 0x145A800
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x1465ECC
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all() { }

	// RVA: 0x145EAFC
	public static void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x145F8CC
	public static void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x145EF4C
	public static void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x145F310
	public static void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x145F060
	public static void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x145F440
	public static void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x145F130
	public static int get_listenForUnpairedDeviceActivity() { }

	// RVA: 0x145F1AC
	public static void set_listenForUnpairedDeviceActivity(int value) { }

	// RVA: 0x1466224
	public override string ToString() { }

	// RVA: 0x145D820
	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	// RVA: 0x145E1E8
	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	// RVA: 0x1466C10
	private bool TryFindControlScheme(string schemeName, InputControlScheme scheme) { }

	// RVA: 0x145BDF4
	internal void FindControlScheme(string schemeName, InputControlScheme scheme) { }

	// RVA: 0x145DECC
	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	// RVA: 0x146674C
	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	// RVA: 0x1460BB0
	public void UnpairDevice(InputDevice device) { }

	// RVA: 0x145CCC0
	public void UnpairDevices() { }

	// RVA: 0x1467D4C
	private static void RemoveLostDevicesForUser(int userIndex) { }

	// RVA: 0x145DDB8
	public void UnpairDevicesAndRemoveUser() { }

	// RVA: 0x145D634
	public static UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() { }

	// RVA: 0x14689D0
	public static int GetUnpairedInputDevices(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>& list) { }

	// RVA: 0x1468BEC
	public static System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(InputDevice device) { }

	// RVA: 0x1468EAC
	public static System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	// RVA: 0x145DE2C
	public static InputUser CreateUserWithoutPairedDevices() { }

	// RVA: 0x145CFB4
	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user, InputUserPairingOptions options) { }

	// RVA: 0x146936C
	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	// RVA: 0x146A4E0
	public bool Equals(InputUser other) { }

	// RVA: 0x146A4F0
	public override bool Equals(object obj) { }

	// RVA: 0x146A5C0
	public override int GetHashCode() { }

	// RVA: 0x145FF98
	public static bool op_Equality(InputUser left, InputUser right) { }

	// RVA: 0x1469360
	public static bool op_Inequality(InputUser left, InputUser right) { }

	// RVA: 0x1469254
	private static int AddUser() { }

	// RVA: 0x14685F4
	private static void RemoveUser(int userIndex) { }

	// RVA: 0x1466ED8
	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	// RVA: 0x1465958
	private static int TryFindUserIndex(UInt32 userId) { }

	// RVA: 0x146903C
	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	// RVA: 0x1468D38
	private static int TryFindUserIndex(InputDevice device) { }

	// RVA: 0x1469524
	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice, bool dontUpdateControlScheme) { }

	// RVA: 0x1467F30
	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice) { }

	// RVA: 0x1467264
	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing) { }

	// RVA: 0x1469BF0
	private static Int64 UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

	// RVA: 0x146A810
	private static Int64 QueryPairedPlatformUserAccount(InputDevice device, System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>& platformAccountHandle, string platformAccountName, string platformAccountId) { }

	// RVA: 0x146A2A0
	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	// RVA: 0x146A9D4
	private static void OnActionChange(object obj, InputActionChange change) { }

	// RVA: 0x146AB54
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x146B218
	private static int FindLostDevice(InputDevice device, int startIndex) { }

	// RVA: 0x146B2FC
	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x146B8FC
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x146658C
	private static void HookIntoActionChange() { }

	// RVA: 0x146A6C0
	private static void UnhookFromActionChange() { }

	// RVA: 0x146A368
	private static void HookIntoDeviceChange() { }

	// RVA: 0x146A5C8
	private static void UnhookFromDeviceChange() { }

	// RVA: 0x1465F60
	private static void HookIntoEvents() { }

	// RVA: 0x1466114
	private static void UnhookFromDeviceStateChange() { }

	// RVA: 0x146BB80
	private static void DisposeAndResetGlobalState() { }

	// RVA: 0x146BC98
	internal static void ResetGlobals() { }

	// RVA: 0x146BD18
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUserAccountHandle
{
	// Fields
	private string m_ApiName; // 0x10
	private UInt64 m_Handle; // 0x18

	// Methods

	// RVA: 0x146C6F0
	public string get_apiName() { }

	// RVA: 0x146C6F8
	public UInt64 get_handle() { }

	// RVA: 0x146C700
	public void .ctor(string apiName, UInt64 handle) { }

	// RVA: 0x146C798
	public override string ToString() { }

	// RVA: 0x146C874
	public bool Equals(InputUserAccountHandle other) { }

	// RVA: 0x146C944
	public override bool Equals(object obj) { }

	// RVA: 0x146C494
	public static bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x146CA78
	public static bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x146CB48
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

	// RVA: 0x146CBA8
	public string get_customBindings() { }

	// RVA: 0x146CBB0
	public void set_customBindings(string value) { }

	// RVA: 0x146CBB8
	public bool get_invertMouseX() { }

	// RVA: 0x146CBC0
	public void set_invertMouseX(bool value) { }

	// RVA: 0x146CBC8
	public bool get_invertMouseY() { }

	// RVA: 0x146CBD0
	public void set_invertMouseY(bool value) { }

	// RVA: 0x146CBD8
	public System.Nullable<System.Single> get_mouseSmoothing() { }

	// RVA: 0x146CBE0
	public void set_mouseSmoothing(System.Nullable<System.Single> value) { }

	// RVA: 0x146CBE8
	public System.Nullable<System.Single> get_mouseSensitivity() { }

	// RVA: 0x146CBF0
	public void set_mouseSensitivity(System.Nullable<System.Single> value) { }

	// RVA: 0x146CBF8
	public bool get_invertStickX() { }

	// RVA: 0x146CC00
	public void set_invertStickX(bool value) { }

	// RVA: 0x146CC08
	public bool get_invertStickY() { }

	// RVA: 0x146CC10
	public void set_invertStickY(bool value) { }

	// RVA: 0x146CC18
	public bool get_swapSticks() { }

	// RVA: 0x146CC20
	public void set_swapSticks(bool value) { }

	// RVA: 0x146CC28
	public bool get_swapBumpers() { }

	// RVA: 0x146CC30
	public void set_swapBumpers(bool value) { }

	// RVA: 0x146CC38
	public bool get_swapTriggers() { }

	// RVA: 0x146CC40
	public void set_swapTriggers(bool value) { }

	// RVA: 0x146CC48
	public bool get_swapDpadAndLeftStick() { }

	// RVA: 0x146CC50
	public void set_swapDpadAndLeftStick(bool value) { }

	// RVA: 0x146CC58
	public float get_vibrationStrength() { }

	// RVA: 0x146CC60
	public void set_vibrationStrength(float value) { }

	// RVA: 0x146CC68
	public virtual void Apply(IInputActionCollection actions) { }

	// RVA: 0x146CC6C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class BaseInputOverride
{
	// Fields
	private readonly string <compositionString>k__BackingField; // 0x20

	// Methods

	// RVA: 0x146CC74
	public override string get_compositionString() { }

	// RVA: 0x146CC7C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class ExtendedAxisEventData
{
	// Fields
	private InputDevice <device>k__BackingField; // 0x30

	// Methods

	// RVA: 0x146CC84
	public InputDevice get_device() { }

	// RVA: 0x146CC8C
	public void set_device(InputDevice value) { }

	// RVA: 0x146CC94
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x146CC9C
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

	// RVA: 0x146CD60
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x146CD68
	public InputControl get_control() { }

	// RVA: 0x146CD70
	public void set_control(InputControl value) { }

	// RVA: 0x146CD80
	public InputDevice get_device() { }

	// RVA: 0x146CD88
	public void set_device(InputDevice value) { }

	// RVA: 0x146CD98
	public int get_touchId() { }

	// RVA: 0x146CDA0
	public void set_touchId(int value) { }

	// RVA: 0x146CDA8
	public UIPointerType get_pointerType() { }

	// RVA: 0x146CDB0
	public void set_pointerType(UIPointerType value) { }

	// RVA: 0x146CDB8
	public int get_uiToolkitPointerId() { }

	// RVA: 0x146CDC0
	public void set_uiToolkitPointerId(int value) { }

	// RVA: 0x146CDC8
	public Vector3 get_trackedDevicePosition() { }

	// RVA: 0x146CDD8
	public void set_trackedDevicePosition(Vector3 value) { }

	// RVA: 0x146CDE8
	public Quaternion get_trackedDeviceOrientation() { }

	// RVA: 0x146CDFC
	public void set_trackedDeviceOrientation(Quaternion value) { }

	// RVA: 0x146CE10
	public override string ToString() { }

	// RVA: 0x146D380
	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	// RVA: 0x146D388
	internal static int TouchIdFromPointerId(int pointerId) { }

	// RVA: 0x146D390
	internal void ReadDeviceState() { }

	// RVA: 0x146D6C4
	private static int GetPenPointerId(Pen pen) { }

	// RVA: 0x146D904
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

// Namespace: UnityEngine.InputSystem.UI
internal class ExtendedSubmitCancelEventData
{
	// Fields
	private InputDevice <device>k__BackingField; // 0x20

	// Methods

	// RVA: 0x146D9FC
	public InputDevice get_device() { }

	// RVA: 0x146DA04
	public void set_device(InputDevice value) { }

	// RVA: 0x146DA0C
	public void .ctor(EventSystem eventSystem) { }

}

// Namespace: UnityEngine.InputSystem.UI
internal interface INavigationEventData
{
	// Methods

	// RVA: -1
	public abstract InputDevice get_device() { }

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
	private float m_ScrollDeltaPerTick; // 0xD4
	private static System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputAction,UnityEngine.InputSystem.UI.InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts; // 0x8
	private bool m_ActionsHooked; // 0xD8
	private bool m_NeedToPurgeStalePointers; // 0xD9
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnPointDelegate; // 0xE0
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMoveDelegate; // 0xE8
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnSubmitCancelDelegate; // 0xF0
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnLeftClickDelegate; // 0xF8
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnRightClickDelegate; // 0x100
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMiddleClickDelegate; // 0x108
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnScrollWheelDelegate; // 0x110
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate; // 0x118
	private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate; // 0x120
	private System.Action<System.Object> m_OnControlsChangedDelegate; // 0x128
	private int m_CurrentPointerId; // 0x130
	private int m_CurrentPointerIndex; // 0x134
	internal UIPointerType m_CurrentPointerType; // 0x138
	internal UnityEngine.InputSystem.Utilities.InlinedArray<System.Int32> m_PointerIds; // 0x140
	internal UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.PointerModel> m_PointerStates; // 0x150
	private NavigationModel m_NavigationState; // 0x380
	private SubmitCancelModel m_SubmitCancelState; // 0x3A8
	private GameObject m_LocalMultiPlayerRoot; // 0x3B8

	// Methods

	// RVA: 0x146DA14
	public bool get_deselectOnBackgroundClick() { }

	// RVA: 0x146DA1C
	public void set_deselectOnBackgroundClick(bool value) { }

	// RVA: 0x146DA24
	public UIPointerBehavior get_pointerBehavior() { }

	// RVA: 0x146DA2C
	public void set_pointerBehavior(UIPointerBehavior value) { }

	// RVA: 0x146DA34
	public CursorLockBehavior get_cursorLockBehavior() { }

	// RVA: 0x146DA3C
	public void set_cursorLockBehavior(CursorLockBehavior value) { }

	// RVA: 0x146DA44
	internal GameObject get_localMultiPlayerRoot() { }

	// RVA: 0x146DA4C
	internal void set_localMultiPlayerRoot(GameObject value) { }

	// RVA: 0x146DA5C
	public float get_scrollDeltaPerTick() { }

	// RVA: 0x146DA64
	public void set_scrollDeltaPerTick(float value) { }

	// RVA: 0x146DA6C
	public override void ActivateModule() { }

	// RVA: 0x146DB48
	public override bool IsPointerOverGameObject(int pointerOrTouchId) { }

	// RVA: 0x146DE4C
	public RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	// RVA: 0x146DF24
	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	// RVA: 0x146E7C4
	private void ProcessPointer(PointerModel state) { }

	// RVA: 0x146FCFC
	private bool PointerShouldIgnoreTransform(Transform t) { }

	// RVA: 0x146ED04
	private void ProcessPointerMovement(PointerModel pointer, ExtendedPointerEventData eventData) { }

	// RVA: 0x146FE2C
	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	// RVA: 0x146ED80
	private void ProcessPointerButton(ButtonState button, PointerEventData eventData) { }

	// RVA: 0x146F77C
	private void ProcessPointerButtonDrag(ButtonState button, ExtendedPointerEventData eventData) { }

	// RVA: 0x146FB48
	private static void ProcessPointerScroll(PointerModel pointer, PointerEventData eventData) { }

	// RVA: 0x147087C
	internal void ProcessNavigation(NavigationModel navigationState) { }

	// RVA: 0x1471010
	private bool IsMoveAllowed(AxisEventData eventData) { }

	// RVA: 0x147134C
	public float get_moveRepeatDelay() { }

	// RVA: 0x1471354
	public void set_moveRepeatDelay(float value) { }

	// RVA: 0x147135C
	public float get_moveRepeatRate() { }

	// RVA: 0x1471364
	public void set_moveRepeatRate(float value) { }

	// RVA: 0x147136C
	private bool get_explictlyIgnoreFocus() { }

	// RVA: 0x14713F0
	private bool get_shouldIgnoreFocus() { }

	// RVA: 0x1471550
	public float get_repeatRate() { }

	// RVA: 0x1471558
	public void set_repeatRate(float value) { }

	// RVA: 0x1471560
	public float get_repeatDelay() { }

	// RVA: 0x1471568
	public void set_repeatDelay(float value) { }

	// RVA: 0x1471570
	public Transform get_xrTrackingOrigin() { }

	// RVA: 0x1471578
	public void set_xrTrackingOrigin(Transform value) { }

	// RVA: 0x1471580
	public float get_trackedDeviceDragThresholdMultiplier() { }

	// RVA: 0x1471588
	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	// RVA: 0x1471590
	private void SwapAction(InputActionReference property, InputActionReference newValue, bool actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback) { }

	// RVA: 0x1471BFC
	public InputActionReference get_point() { }

	// RVA: 0x1471C04
	public void set_point(InputActionReference value) { }

	// RVA: 0x1471C18
	public InputActionReference get_scrollWheel() { }

	// RVA: 0x1471C20
	public void set_scrollWheel(InputActionReference value) { }

	// RVA: 0x1471C34
	public InputActionReference get_leftClick() { }

	// RVA: 0x1471C3C
	public void set_leftClick(InputActionReference value) { }

	// RVA: 0x1471C50
	public InputActionReference get_middleClick() { }

	// RVA: 0x1471C58
	public void set_middleClick(InputActionReference value) { }

	// RVA: 0x1471C6C
	public InputActionReference get_rightClick() { }

	// RVA: 0x1471C74
	public void set_rightClick(InputActionReference value) { }

	// RVA: 0x1471C88
	public InputActionReference get_move() { }

	// RVA: 0x1471C90
	public void set_move(InputActionReference value) { }

	// RVA: 0x1471CA4
	public InputActionReference get_submit() { }

	// RVA: 0x1471CAC
	public void set_submit(InputActionReference value) { }

	// RVA: 0x1471CC0
	public InputActionReference get_cancel() { }

	// RVA: 0x1471CC8
	public void set_cancel(InputActionReference value) { }

	// RVA: 0x1471CDC
	public InputActionReference get_trackedDeviceOrientation() { }

	// RVA: 0x1471CE4
	public void set_trackedDeviceOrientation(InputActionReference value) { }

	// RVA: 0x1471CF8
	public InputActionReference get_trackedDevicePosition() { }

	// RVA: 0x1471D00
	public void set_trackedDevicePosition(InputActionReference value) { }

	// RVA: 0x1471D14
	public void AssignDefaultActions() { }

	// RVA: 0x1472384
	public void UnassignActions() { }

	// RVA: 0x147253C
	public InputActionReference get_trackedDeviceSelect() { }

	// RVA: 0x147257C
	public void set_trackedDeviceSelect(InputActionReference value) { }

	// RVA: 0x14725BC
	protected override void Awake() { }

	// RVA: 0x147266C
	protected override void OnDestroy() { }

	// RVA: 0x14726C0
	protected override void OnEnable() { }

	// RVA: 0x1472EBC
	protected override void OnDisable() { }

	// RVA: 0x1472A40
	private void ResetPointers() { }

	// RVA: 0x1472828
	private bool HasNoActions() { }

	// RVA: 0x1472E54
	private void EnableAllActions() { }

	// RVA: 0x1472FAC
	private void DisableAllActions() { }

	// RVA: 0x1471A78
	private void EnableInputAction(InputActionReference inputActionReference) { }

	// RVA: 0x14718C8
	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling) { }

	// RVA: 0x146DD08
	private int GetPointerStateIndexFor(int pointerOrTouchId) { }

	// RVA: 0x1473150
	private PointerModel GetPointerStateForIndex(int index) { }

	// RVA: 0x147319C
	private int GetDisplayIndexFor(InputControl control) { }

	// RVA: 0x1473264
	private int GetPointerStateIndexFor(CallbackContext context) { }

	// RVA: 0x147337C
	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists) { }

	// RVA: 0x1473CE4
	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl) { }

	// RVA: 0x1473060
	private bool SendPointerExitEventsAndRemovePointer(int index) { }

	// RVA: 0x147406C
	private bool RemovePointerAtIndex(int index) { }

	// RVA: 0x1474324
	private void PurgeStalePointers() { }

	// RVA: 0x1473C0C
	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	// RVA: 0x14744BC
	private void OnPointCallback(CallbackContext context) { }

	// RVA: 0x1474638
	private bool IgnoreNextClick(CallbackContext context, bool wasPressed) { }

	// RVA: 0x1474800
	private void OnLeftClickCallback(CallbackContext context) { }

	// RVA: 0x147495C
	private void OnRightClickCallback(CallbackContext context) { }

	// RVA: 0x1474A68
	private void OnMiddleClickCallback(CallbackContext context) { }

	// RVA: 0x147330C
	private bool CheckForRemovedDevice(CallbackContext context) { }

	// RVA: 0x1474B74
	private void OnScrollCallback(CallbackContext context) { }

	// RVA: 0x1474CD4
	private void OnMoveCallback(CallbackContext context) { }

	// RVA: 0x1474D68
	private void OnSubmitCancelCallback(CallbackContext context) { }

	// RVA: 0x1474DB4
	private void OnTrackedDeviceOrientationCallback(CallbackContext context) { }

	// RVA: 0x1474F3C
	private void OnTrackedDevicePositionCallback(CallbackContext context) { }

	// RVA: 0x14750BC
	private void OnControlsChanged(object obj) { }

	// RVA: 0x14750C8
	private void FilterPointerStatesByType() { }

	// RVA: 0x14756A8
	public override void Process() { }

	// RVA: 0x14758D4
	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x1472A98
	private void HookActions() { }

	// RVA: 0x14726AC
	private void UnhookActions() { }

	// RVA: 0x14759C0
	private void SetActionCallbacks(bool install) { }

	// RVA: 0x1475AD0
	private static void SetActionCallback(InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x1475BD0
	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

	// RVA: 0x1475C5C
	public InputActionAsset get_actionsAsset() { }

	// RVA: 0x147210C
	public void set_actionsAsset(InputActionAsset value) { }

	// RVA: 0x14707B0
	private bool get_sendPointerHoverToParent() { }

	// RVA: 0x1475C64
	public void .ctor() { }

	// RVA: 0x1475C98
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
public class MultiplayerEventSystem
{
	// Fields
	private GameObject m_PlayerRoot; // 0x60

	// Methods

	// RVA: 0x1475D2C
	public GameObject get_playerRoot() { }

	// RVA: 0x1475D34
	public void set_playerRoot(GameObject value) { }

	// RVA: 0x1475E8C
	protected override void OnEnable() { }

	// RVA: 0x1475EB4
	protected override void OnDisable() { }

	// RVA: 0x1475D5C
	private void InitializePlayerRoot() { }

	// RVA: 0x1475EBC
	protected override void Update() { }

	// RVA: 0x1475FCC
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
	public InputDevice device; // 0x30

	// Methods

	// RVA: 0x1472618
	public void Reset() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal struct SubmitCancelModel
{
	// Fields
	public BaseEventData eventData; // 0x10
	public InputDevice device; // 0x18
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

	// RVA: 0x1476180
	public bool get_isPressed() { }

	// RVA: 0x147490C
	public void set_isPressed(bool value) { }

	// RVA: 0x1476188
	public bool get_ignoreNextClick() { }

	// RVA: 0x1476190
	public void set_ignoreNextClick(bool value) { }

	// RVA: 0x1476198
	public float get_pressTime() { }

	// RVA: 0x14761A0
	public void set_pressTime(float value) { }

	// RVA: 0x14761A8
	public bool get_clickedOnSameGameObject() { }

	// RVA: 0x14761B0
	public void set_clickedOnSameGameObject(bool value) { }

	// RVA: 0x14707B8
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x146FE18
	public bool get_wasReleasedThisFrame() { }

	// RVA: 0x146EC40
	public void CopyPressStateTo(PointerEventData eventData) { }

	// RVA: 0x14707C8
	public void CopyPressStateFrom(PointerEventData eventData) { }

	// RVA: 0x1473F70
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

	// RVA: 0x146ED60
	public UIPointerType get_pointerType() { }

	// RVA: 0x1476054
	public Vector2 get_screenPosition() { }

	// RVA: 0x1473F7C
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x1476060
	public Vector3 get_worldPosition() { }

	// RVA: 0x1475064
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x1476070
	public Quaternion get_worldOrientation() { }

	// RVA: 0x1474EE0
	public void set_worldOrientation(Quaternion value) { }

	// RVA: 0x1476084
	public Vector2 get_scrollDelta() { }

	// RVA: 0x1474C90
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x1476090
	public float get_pressure() { }

	// RVA: 0x1476098
	public void set_pressure(float value) { }

	// RVA: 0x14760B8
	public float get_azimuthAngle() { }

	// RVA: 0x14760C0
	public void set_azimuthAngle(float value) { }

	// RVA: 0x14760E0
	public float get_altitudeAngle() { }

	// RVA: 0x14760E8
	public void set_altitudeAngle(float value) { }

	// RVA: 0x1476108
	public float get_twist() { }

	// RVA: 0x1476110
	public void set_twist(float value) { }

	// RVA: 0x1476130
	public Vector2 get_radius() { }

	// RVA: 0x147613C
	public void set_radius(Vector2 value) { }

	// RVA: 0x1473FC0
	public void .ctor(ExtendedPointerEventData eventData) { }

	// RVA: 0x1475888
	public void OnFrameFinished() { }

	// RVA: 0x14755A4
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

	// RVA: 0x1476F08
	public void .ctor(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) { }

	// RVA: 0x1477090
	public Graphic get_graphic() { }

	// RVA: 0x1477098
	public Vector3 get_worldHitPosition() { }

	// RVA: 0x14770A4
	public Vector2 get_screenPosition() { }

	// RVA: 0x14770AC
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

	// RVA: 0x14770B4
	private static void .cctor() { }

	// RVA: 0x1477120
	public void .ctor() { }

	// RVA: 0x1477128
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

	// RVA: 0x14761B8
	public override Camera get_eventCamera() { }

	// RVA: 0x147637C
	public LayerMask get_blockingMask() { }

	// RVA: 0x1476384
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x147638C
	public bool get_checkFor3DOcclusion() { }

	// RVA: 0x1476394
	public void set_checkFor3DOcclusion(bool value) { }

	// RVA: 0x147639C
	public bool get_checkFor2DOcclusion() { }

	// RVA: 0x14763A4
	public void set_checkFor2DOcclusion(bool value) { }

	// RVA: 0x14763AC
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x14763B4
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x14763BC
	public float get_maxDistance() { }

	// RVA: 0x14763C4
	public void set_maxDistance(float value) { }

	// RVA: 0x14763CC
	protected override void OnEnable() { }

	// RVA: 0x147645C
	protected override void OnDisable() { }

	// RVA: 0x1476554
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x146E200
	internal void PerformRaycast(ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1476600
	private void SortedRaycastGraphics(Canvas canvas, Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results) { }

	// RVA: 0x1476B10
	private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, Vector3 worldPosition, float distance) { }

	// RVA: 0x1476284
	private Canvas get_canvas() { }

	// RVA: 0x1476F68
	public void .ctor() { }

	// RVA: 0x1476FFC
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

	// RVA: 0x1477184
	public RectTransform get_cursorTransform() { }

	// RVA: 0x147718C
	public void set_cursorTransform(RectTransform value) { }

	// RVA: 0x1477194
	public float get_cursorSpeed() { }

	// RVA: 0x147719C
	public void set_cursorSpeed(float value) { }

	// RVA: 0x14771A4
	public CursorMode get_cursorMode() { }

	// RVA: 0x14771AC
	public void set_cursorMode(CursorMode value) { }

	// RVA: 0x147758C
	public Graphic get_cursorGraphic() { }

	// RVA: 0x1477594
	public void set_cursorGraphic(Graphic value) { }

	// RVA: 0x147769C
	public float get_scrollSpeed() { }

	// RVA: 0x14776A4
	public void set_scrollSpeed(float value) { }

	// RVA: 0x14776AC
	public Mouse get_virtualMouse() { }

	// RVA: 0x14776B4
	public InputActionProperty get_stickAction() { }

	// RVA: 0x14776C8
	public void set_stickAction(InputActionProperty value) { }

	// RVA: 0x1477854
	public InputActionProperty get_leftButtonAction() { }

	// RVA: 0x1477868
	public void set_leftButtonAction(InputActionProperty value) { }

	// RVA: 0x14779CC
	public InputActionProperty get_rightButtonAction() { }

	// RVA: 0x14779E0
	public void set_rightButtonAction(InputActionProperty value) { }

	// RVA: 0x1477AC0
	public InputActionProperty get_middleButtonAction() { }

	// RVA: 0x1477AD4
	public void set_middleButtonAction(InputActionProperty value) { }

	// RVA: 0x1477BB4
	public InputActionProperty get_forwardButtonAction() { }

	// RVA: 0x1477BC8
	public void set_forwardButtonAction(InputActionProperty value) { }

	// RVA: 0x1477CA8
	public InputActionProperty get_backButtonAction() { }

	// RVA: 0x1477CBC
	public void set_backButtonAction(InputActionProperty value) { }

	// RVA: 0x1477D9C
	public InputActionProperty get_scrollWheelAction() { }

	// RVA: 0x1477DB0
	public void set_scrollWheelAction(InputActionProperty value) { }

	// RVA: 0x1477DE4
	protected void OnEnable() { }

	// RVA: 0x1478370
	protected void OnDisable() { }

	// RVA: 0x1477624
	private void TryFindCanvas() { }

	// RVA: 0x14772C8
	private void TryEnableHardwareCursor() { }

	// RVA: 0x147867C
	private void UpdateMotion() { }

	// RVA: 0x1478A38
	private void OnButtonActionTriggered(CallbackContext context) { }

	// RVA: 0x1477948
	private static void SetActionCallback(InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x14776FC
	private static void SetAction(InputActionProperty field, InputActionProperty value) { }

	// RVA: 0x1478CB0
	private void OnAfterInputUpdate() { }

	// RVA: 0x1478CB4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
public class OnScreenButton
{
	// Fields
	private string m_ControlPath; // 0x38

	// Methods

	// RVA: 0x1478CC8
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1478D30
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1478D9C
	protected override string get_controlPathInternal() { }

	// RVA: 0x1478DA4
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x1478DAC
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

	// RVA: 0x1479734
	public OnScreenDeviceInfo AddControl(OnScreenControl control) { }

	// RVA: 0x1479E3C
	public OnScreenDeviceInfo RemoveControl(OnScreenControl control) { }

	// RVA: 0x1479678
	public void Destroy() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
public abstract class OnScreenControl
{
	// Fields
	private InputControl m_Control; // 0x20
	private OnScreenControl m_NextControlOnDevice; // 0x28
	private InputEventPtr m_InputEventPtr; // 0x30
	private static int s_nbActiveInstances; // 0x0
	private static UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices; // 0x8

	// Methods

	// RVA: 0x1478DBC
	public string get_controlPath() { }

	// RVA: 0x1478DC8
	public void set_controlPath(string value) { }

	// RVA: 0x1479670
	public InputControl get_control() { }

	// RVA: -1
	protected abstract string get_controlPathInternal() { }

	// RVA: -1
	protected abstract void set_controlPathInternal(string value) { }

	// RVA: 0x1478E10
	private void SetupInputControl() { }

	// RVA: 0x318DB98
	protected void SendValueToControl(TValue value) { }

	// RVA: 0x147979C
	protected void SentDefaultValueToControl() { }

	// RVA: 0x14798EC
	internal static bool get_HasAnyActive() { }

	// RVA: 0x1479940
	protected virtual void OnEnable() { }

	// RVA: 0x1479BF0
	protected virtual void OnDisable() { }

	// RVA: 0x1479F9C
	internal string GetWarningMessage() { }

	// RVA: 0x1478DB4
	protected void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
internal static class UGUIOnScreenControlUtils
{
	// Methods

	// RVA: 0x147A000
	public static RectTransform GetCanvasRectTransform(Transform transform) { }

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
	private TouchControl m_TouchControl; // 0x88
	private bool m_IsIsolationActive; // 0x90

	// Methods

	// RVA: 0x147A0CC
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x147A414
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x147A8A0
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x147A998
	private void Start() { }

	// RVA: 0x147B050
	private void OnDestroy() { }

	// RVA: 0x147A178
	private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x147A4C0
	private void MoveStick(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x147A8B0
	private void EndInteraction() { }

	// RVA: 0x147B0FC
	private void OnPointerDown(CallbackContext ctx) { }

	// RVA: 0x147B90C
	private void OnPointerChanged(CallbackContext ctx) { }

	// RVA: 0x147BA74
	private void OnPointerMove(CallbackContext ctx) { }

	// RVA: 0x147B974
	private void OnPointerUp(CallbackContext ctx) { }

	// RVA: 0x147B5EC
	private Camera GetCameraFromCanvas() { }

	// RVA: 0x147BB88
	private void OnDrawGizmosSelected() { }

	// RVA: 0x147BEE8
	private void DrawGizmoCircle(Vector2 center, float radius) { }

	// RVA: 0x147BFB0
	private void UpdateDynamicOriginClickableArea() { }

	// RVA: 0x147C0B8
	public float get_movementRange() { }

	// RVA: 0x147C0C0
	public void set_movementRange(float value) { }

	// RVA: 0x147C0C8
	public float get_dynamicOriginRange() { }

	// RVA: 0x147C0D0
	public void set_dynamicOriginRange(float value) { }

	// RVA: 0x147C0E8
	public bool get_useIsolatedInputActions() { }

	// RVA: 0x147C0F0
	public void set_useIsolatedInputActions(bool value) { }

	// RVA: 0x147C0F8
	protected override string get_controlPathInternal() { }

	// RVA: 0x147C100
	protected override void set_controlPathInternal(string value) { }

	// RVA: 0x147C108
	public Behaviour get_behaviour() { }

	// RVA: 0x147C110
	public void set_behaviour(Behaviour value) { }

	// RVA: 0x147C118
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
internal static class OnScreenSupport
{
	// Methods

	// RVA: 0x147C12C
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

	// RVA: 0x147C130
	public bool get_enabled() { }

	// RVA: 0x147C138
	public void set_enabled(bool value) { }

	// RVA: 0x147C140
	public string get_usageDescription() { }

	// RVA: 0x147C148
	public void set_usageDescription(string value) { }

	// RVA: 0x147C150
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class iOSGameController
{
	// Methods

	// RVA: 0x147C158
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class XboxOneGampadiOS
{
	// Methods

	// RVA: 0x147C160
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualShock4GampadiOS
{
	// Methods

	// RVA: 0x147C168
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualSenseGampadiOS
{
	// Methods

	// RVA: 0x147C170
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
internal static class iOSSupport
{
	// Methods

	// RVA: 0x147C178
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

	// RVA: 0x147C6D0
	public FourCC get_format() { }

	// RVA: 0x147C74C
	public iOSGameControllerState WithButton(iOSButton button, bool value, float rawValue) { }

	// RVA: 0x147C798
	public iOSGameControllerState WithAxis(iOSAxis axis, float value) { }

	// RVA: 0x147C7C4
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

	// RVA: 0x147C83C
	public FourCC get_format() { }

	// RVA: 0x147C8B8
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDataReceivedDelegate
{
	// Methods

	// RVA: 0x147CE04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x147CEB4
	public virtual void Invoke(int deviceId, int numberOfSteps) { }

	// RVA: 0x147CEC8
	public virtual IAsyncResult BeginInvoke(int deviceId, int numberOfSteps, AsyncCallback callback, object object) { }

	// RVA: 0x147CF94
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

	// RVA: 0x147CA34
	private static extern int _iOSStepCounterEnable(int deviceId, iOSStepCounterCallbacks callbacks, int sizeOfCallbacks) { }

	// RVA: 0x147CAF0
	private static extern int _iOSStepCounterDisable(int deviceId) { }

	// RVA: 0x147CAF4
	private static extern int _iOSStepCounterIsEnabled(int deviceId) { }

	// RVA: 0x147CAF8
	private static extern int _iOSStepCounterIsAvailable() { }

	// RVA: 0x147CAFC
	private static extern int _iOSStepCounterGetAuthorizationStatus() { }

	// RVA: 0x147C930
	private static void OnDataReceived(int deviceId, int numberOfSteps) { }

	// RVA: 0x147CB00
	protected override Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x147C6B4
	public static bool IsAvailable() { }

	// RVA: 0x147CEA8
	public static MotionAuthorizationStatus get_AuthorizationStatus() { }

	// RVA: 0x147CEAC
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

	// RVA: 0x1480344
	private static void .cctor() { }

	// RVA: 0x14803B0
	public void .ctor() { }

	// RVA: 0x14803B8
	internal bool <Build>b__4_0(HIDElementDescriptor element) { }

	// RVA: 0x14803DC
	internal bool <Build>b__4_1(HIDElementDescriptor element) { }

	// RVA: 0x1480400
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

	// RVA: 0x147E430
	public InputControlLayout Build() { }

	// RVA: 0x147E250
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

	// RVA: 0x148040C
	public bool get_hasNullState() { }

	// RVA: 0x1480418
	public bool get_hasPreferredState() { }

	// RVA: 0x1480428
	public bool get_isArray() { }

	// RVA: 0x1480438
	public bool get_isNonLinear() { }

	// RVA: 0x1480444
	public bool get_isRelative() { }

	// RVA: 0x1480450
	public bool get_isConstant() { }

	// RVA: 0x148045C
	public bool get_isWrapping() { }

	// RVA: 0x147F2E4
	internal bool get_isSigned() { }

	// RVA: 0x1480468
	internal float get_minFloatValue() { }

	// RVA: 0x1480500
	internal float get_maxFloatValue() { }

	// RVA: 0x147F444
	public bool Is(UsagePage usagePage, int usage) { }

	// RVA: 0x147F588
	internal string DetermineName() { }

	// RVA: 0x147F7C0
	internal string DetermineDisplayName() { }

	// RVA: 0x147E210
	internal bool IsUsableElement() { }

	// RVA: 0x147F468
	internal string DetermineLayout() { }

	// RVA: 0x147F8E0
	internal FourCC DetermineFormat() { }

	// RVA: 0x147FADC
	internal InternedString[] DetermineUsages() { }

	// RVA: 0x147F188
	internal string DetermineParameters() { }

	// RVA: 0x14805A0
	private string DetermineAxisNormalizationParameters() { }

	// RVA: 0x147F3C8
	internal string DetermineProcessors() { }

	// RVA: 0x147F2F0
	internal PrimitiveValue DetermineDefaultState() { }

	// RVA: 0x147FCD4
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

	// RVA: 0x1480E5C
	public string ToJson() { }

	// RVA: 0x1480ED8
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

	// RVA: 0x1481CCC
	public void .ctor(UsagePage usagePage, int usage) { }

	// RVA: 0x1481CE4
	public void .ctor(GenericDesktop usage) { }

	// RVA: 0x1481D00
	public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId) { }

	// RVA: 0x1481D28
	public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) { }

	// RVA: 0x14820E0
	public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) { }

	// RVA: 0x1482134
	public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) { }

	// RVA: 0x14822A4
	public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) { }

	// RVA: 0x1482400
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
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public HIDLayoutBuilder layout; // 0x10

	// Methods

	// RVA: 0x14824FC
	public void .ctor() { }

	// RVA: 0x1482504
	internal InputControlLayout <OnFindLayoutForDevice>b__0() { }

}

// Namespace: UnityEngine.InputSystem.HID
public class HID
{
	// Fields
	internal const string kHIDInterface = "HID";
	internal const string kHIDNamespace = "HID";
	private bool m_HaveParsedHIDDescriptor; // 0x188
	private HIDDeviceDescriptor m_HIDDescriptor; // 0x190
	private static readonly ProfilerMarker k_HIDParseDescriptorFallback; // 0x0

	// Methods

	// RVA: 0x147CFA0
	public static FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	// RVA: 0x147CFDC
	public static FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	// RVA: 0x147D018
	public static FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	// RVA: 0x147D054
	public HIDDeviceDescriptor get_hidDescriptor() { }

	// RVA: 0x147D108
	internal static string OnFindLayoutForDevice(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x147DA5C
	internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	// RVA: 0x147E258
	public static string UsagePageToString(UsagePage usagePage) { }

	// RVA: 0x147E2F4
	public static string UsageToString(UsagePage usagePage, int usage) { }

	// RVA: 0x147E3A8
	public void .ctor() { }

	// RVA: 0x147E3B0
	private static void .cctor() { }

}

// Namespace: 
private struct HIDReportData
{
	// Fields
	public int reportId; // 0x10
	public HIDReportType reportType; // 0x14
	public int currentBitOffset; // 0x18

	// Methods

	// RVA: 0x14841F8
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

	// RVA: 0x1484128
	public static void Reset(HIDItemStateLocal state) { }

	// RVA: 0x1483CD0
	public void SetUsage(int value) { }

	// RVA: 0x1483F34
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

	// RVA: 0x1483E4C
	public UsagePage GetUsagePage(int index, HIDItemStateLocal localItemState) { }

	// RVA: 0x1484390
	public int GetPhysicalMin() { }

	// RVA: 0x14844F0
	public int GetPhysicalMax() { }

}

// Namespace: UnityEngine.InputSystem.HID
internal static class HIDParser
{
	// Methods

	// RVA: 0x1482524
	public static bool ParseReportDescriptor(Byte[] buffer, HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x148259C
	public static bool ParseReportDescriptor(Byte* bufferPtr, int bufferLength, HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x1483C68
	private static int ReadData(int itemSize, Byte* currentPtr, Byte* endPtr) { }

}

// Namespace: 
public struct HIDPageUsage
{
	// Fields
	public UsagePage page; // 0x10
	public int usage; // 0x14

	// Methods

	// RVA: 0x148490C
	public void .ctor(UsagePage page, int usage) { }

	// RVA: 0x1484A78
	public void .ctor(GenericDesktop usage) { }

}

// Namespace: UnityEngine.InputSystem.HID
public static class HIDSupport
{
	// Fields
	private static HIDPageUsage[] s_SupportedHIDUsages; // 0x0

	// Methods

	// RVA: 0x1484650
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages() { }

	// RVA: 0x14846BC
	public static void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value) { }

	// RVA: 0x1484914
	internal static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public static class EnhancedTouchSupport
{
	// Fields
	private static int s_Enabled; // 0x0
	private static UpdateMode s_UpdateMode; // 0x4

	// Methods

	// RVA: 0x1484A84
	public static bool get_enabled() { }

	// RVA: 0x1484AD8
	public static void Enable() { }

	// RVA: 0x1484E50
	public static void Disable() { }

	// RVA: 0x148523C
	internal static void Reset() { }

	// RVA: 0x1484C58
	private static void SetUpState() { }

	// RVA: 0x1485004
	internal static void TearDownState() { }

	// RVA: 0x1485370
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x14856A0
	private static void OnSettingsChange() { }

	// RVA: 0x1485754
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

	// RVA: 0x14857F0
	public Touchscreen get_screen() { }

	// RVA: 0x14857F8
	public int get_index() { }

	// RVA: 0x1485800
	public bool get_isActive() { }

	// RVA: 0x1485BD4
	public Vector2 get_screenPosition() { }

	// RVA: 0x1485DF4
	public Touch get_lastTouch() { }

	// RVA: 0x14858C8
	public Touch get_currentTouch() { }

	// RVA: 0x148617C
	public TouchHistory get_touchHistory() { }

	// RVA: 0x1486288
	internal void .ctor(Touchscreen screen, int index, InputUpdateType updateMask) { }

	// RVA: 0x14866C0
	private static bool ShouldRecordTouch(InputControl control, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x14867B8
	private void OnTouchRecorded(Record record) { }

	// RVA: 0x1486AB4
	private Touch FindTouch(UInt32 uniqueId) { }

	// RVA: 0x1486DF8
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

	// RVA: 0x1489990
	public void AddFingers(Touchscreen screen) { }

	// RVA: 0x1489AA8
	public void RemoveFingers(Touchscreen screen) { }

	// RVA: 0x14852E0
	public void Destroy() { }

	// RVA: 0x1488AFC
	public void UpdateActiveFingers() { }

	// RVA: 0x14882B4
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

	// RVA: 0x148A068
	private static void .cctor() { }

	// RVA: 0x148A0D4
	public void .ctor() { }

	// RVA: 0x148A0DC
	internal void <SaveAndResetState>b__80_0(GlobalState state) { }

	// RVA: 0x148A174
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

	// RVA: 0x1485B80
	public bool get_valid() { }

	// RVA: 0x1487420
	public Finger get_finger() { }

	// RVA: 0x1487368
	public TouchPhase get_phase() { }

	// RVA: 0x148747C
	public bool get_began() { }

	// RVA: 0x1487584
	public bool get_inProgress() { }

	// RVA: 0x14877FC
	public bool get_ended() { }

	// RVA: 0x14872B0
	public int get_touchId() { }

	// RVA: 0x14879B8
	public float get_pressure() { }

	// RVA: 0x1487A70
	public Vector2 get_radius() { }

	// RVA: 0x1487B28
	public Double get_startTime() { }

	// RVA: 0x1487BE0
	public Double get_time() { }

	// RVA: 0x1487C34
	public Touchscreen get_screen() { }

	// RVA: 0x1485EBC
	public Vector2 get_screenPosition() { }

	// RVA: 0x1487CB4
	public Vector2 get_startScreenPosition() { }

	// RVA: 0x1487D6C
	public Vector2 get_delta() { }

	// RVA: 0x1487E24
	public int get_tapCount() { }

	// RVA: 0x1487EDC
	public bool get_isTap() { }

	// RVA: 0x1487FA4
	public int get_displayIndex() { }

	// RVA: 0x1485FB4
	public bool get_isInProgress() { }

	// RVA: 0x14860C4
	internal UInt32 get_updateStepCount() { }

	// RVA: 0x14871F8
	internal UInt32 get_uniqueId() { }

	// RVA: 0x1487428
	private TouchState get_state() { }

	// RVA: 0x148805C
	private ExtraDataPerTouchState get_extraData() { }

	// RVA: 0x14880B0
	public TouchHistory get_history() { }

	// RVA: 0x1488210
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches() { }

	// RVA: 0x14889C4
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers() { }

	// RVA: 0x1488A58
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers() { }

	// RVA: 0x1488C7C
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens() { }

	// RVA: 0x1488D14
	public static void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1488DE4
	public static void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1488EB4
	public static void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1488F84
	public static void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1489054
	public static void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1489124
	public static void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1486644
	public static int get_maxHistoryLengthPerFinger() { }

	// RVA: 0x1485F74
	internal void .ctor(Finger finger, Record touchRecord) { }

	// RVA: 0x14891F4
	public override string ToString() { }

	// RVA: 0x1489780
	public bool Equals(Touch other) { }

	// RVA: 0x1489800
	public override bool Equals(object obj) { }

	// RVA: 0x1489910
	public override int GetHashCode() { }

	// RVA: 0x1485524
	internal static void AddTouchscreen(Touchscreen screen) { }

	// RVA: 0x14855BC
	internal static void RemoveTouchscreen(Touchscreen screen) { }

	// RVA: 0x1489BE8
	internal static void BeginUpdate() { }

	// RVA: 0x1489C94
	private static GlobalState CreateGlobalState() { }

	// RVA: 0x1489CF4
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x1489FAC
	private static void .cctor() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private readonly TouchHistory m_Owner; // 0x10
	private int m_Index; // 0x30

	// Methods

	// RVA: 0x148A208
	internal void .ctor(TouchHistory owner) { }

	// RVA: 0x148A4FC
	public bool MoveNext() { }

	// RVA: 0x148A524
	public void Reset() { }

	// RVA: 0x148A530
	public Touch get_Current() { }

	// RVA: 0x148A57C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x148A604
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

	// RVA: 0x14861E8
	internal void .ctor(Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex, int count) { }

	// RVA: 0x148A178
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator() { }

	// RVA: 0x148A24C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x148A2DC
	public int get_Count() { }

	// RVA: 0x148A2E4
	public Touch get_Item(int index) { }

	// RVA: 0x148A45C
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
	private int[] m_TouchIds; // 0x50
	private int m_LastTouchId; // 0x58
	private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> m_OnDeviceChange; // 0x60
	private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEvent; // 0x68
	internal static TouchSimulation s_Instance; // 0x0

	// Methods

	// RVA: 0x148A608
	public Touchscreen get_simulatedTouchscreen() { }

	// RVA: 0x148A610
	private void set_simulatedTouchscreen(Touchscreen value) { }

	// RVA: 0x148A618
	public static TouchSimulation get_instance() { }

	// RVA: 0x148A664
	public static void Enable() { }

	// RVA: 0x148A85C
	public static void Disable() { }

	// RVA: 0x148A958
	public static void Destroy() { }

	// RVA: 0x148AA60
	protected void AddPointer(Pointer pointer) { }

	// RVA: 0x148ABD4
	protected void RemovePointer(Pointer pointer) { }

	// RVA: 0x148B02C
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x148B6DC
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x148B82C
	protected void OnEnable() { }

	// RVA: 0x148BF1C
	protected void OnDisable() { }

	// RVA: 0x148ADC8
	private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr) { }

	// RVA: 0x148C284
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x148C288
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x148C28C
	protected void InstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x148C290
	protected void OnSourceControlChangedValue(InputControl control, Double time, InputEventPtr eventPtr, Int64 sourceDeviceAndButtonIndex) { }

	// RVA: 0x148C294
	protected void UninstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x148C298
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
public class DualShockGamepad
{
	// Fields
	private ButtonControl <touchpadButton>k__BackingField; // 0x208
	private ButtonControl <optionsButton>k__BackingField; // 0x210
	private ButtonControl <shareButton>k__BackingField; // 0x218
	private ButtonControl <L1>k__BackingField; // 0x220
	private ButtonControl <R1>k__BackingField; // 0x228
	private ButtonControl <L2>k__BackingField; // 0x230
	private ButtonControl <R2>k__BackingField; // 0x238
	private ButtonControl <L3>k__BackingField; // 0x240
	private ButtonControl <R3>k__BackingField; // 0x248
	private static DualShockGamepad <current>k__BackingField; // 0x0
	private HIDDeviceDescriptor <hidDescriptor>k__BackingField; // 0x250

	// Methods

	// RVA: 0x148C2A0
	public ButtonControl get_touchpadButton() { }

	// RVA: 0x148C2A8
	protected void set_touchpadButton(ButtonControl value) { }

	// RVA: 0x148C2B8
	public ButtonControl get_optionsButton() { }

	// RVA: 0x148C2C0
	protected void set_optionsButton(ButtonControl value) { }

	// RVA: 0x148C2D0
	public ButtonControl get_shareButton() { }

	// RVA: 0x148C2D8
	protected void set_shareButton(ButtonControl value) { }

	// RVA: 0x148C2E8
	public ButtonControl get_L1() { }

	// RVA: 0x148C2F0
	protected void set_L1(ButtonControl value) { }

	// RVA: 0x148C300
	public ButtonControl get_R1() { }

	// RVA: 0x148C308
	protected void set_R1(ButtonControl value) { }

	// RVA: 0x148C318
	public ButtonControl get_L2() { }

	// RVA: 0x148C320
	protected void set_L2(ButtonControl value) { }

	// RVA: 0x148C330
	public ButtonControl get_R2() { }

	// RVA: 0x148C338
	protected void set_R2(ButtonControl value) { }

	// RVA: 0x148C348
	public ButtonControl get_L3() { }

	// RVA: 0x148C350
	protected void set_L3(ButtonControl value) { }

	// RVA: 0x148C360
	public ButtonControl get_R3() { }

	// RVA: 0x148C368
	protected void set_R3(ButtonControl value) { }

	// RVA: 0x148C378
	public static DualShockGamepad get_current() { }

	// RVA: 0x148C3C4
	private static void set_current(DualShockGamepad value) { }

	// RVA: 0x148C428
	internal HIDDeviceDescriptor get_hidDescriptor() { }

	// RVA: 0x148C43C
	private void set_hidDescriptor(HIDDeviceDescriptor value) { }

	// RVA: 0x148C458
	public override void MakeCurrent() { }

	// RVA: 0x148C4BC
	protected override void OnRemoved() { }

	// RVA: 0x148C55C
	protected override void FinishSetup() { }

	// RVA: 0x148C6D8
	public virtual void SetLightBarColor(Color color) { }

	// RVA: 0x148C6DC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
internal static class DualShockSupport
{
	// Methods

	// RVA: 0x148C6E4
	public static void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
public interface IDualShockHaptics
{
	// Methods

	// RVA: -1
	public abstract void SetLightBarColor(Color color) { }

}

// Namespace: UnityEngine.InputSystem.Editor
internal struct SampleFrequencyCalculator
{
	// Fields
	private Double m_LastUpdateTime; // 0x10
	private int m_SampleCount; // 0x18
	private float <targetFrequency>k__BackingField; // 0x1C
	private float <frequency>k__BackingField; // 0x20

	// Methods

	// RVA: 0x148C758
	public void .ctor(float targetFrequency, Double realtimeSinceStartup) { }

	// RVA: 0x148C76C
	public float get_targetFrequency() { }

	// RVA: 0x148C774
	private void set_targetFrequency(float value) { }

	// RVA: 0x148C77C
	public float get_frequency() { }

	// RVA: 0x148C784
	private void set_frequency(float value) { }

	// RVA: 0x148C78C
	public void ProcessSample(InputEventPtr eventPtr) { }

	// RVA: 0x148C7B0
	public bool Update() { }

	// RVA: 0x148C810
	public bool Update(Double realtimeSinceStartup) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
internal struct DualMotorRumble
{
	// Fields
	private float <lowFrequencyMotorSpeed>k__BackingField; // 0x10
	private float <highFrequencyMotorSpeed>k__BackingField; // 0x14

	// Methods

	// RVA: 0x148C850
	public float get_lowFrequencyMotorSpeed() { }

	// RVA: 0x148C858
	private void set_lowFrequencyMotorSpeed(float value) { }

	// RVA: 0x148C860
	public float get_highFrequencyMotorSpeed() { }

	// RVA: 0x148C868
	private void set_highFrequencyMotorSpeed(float value) { }

	// RVA: 0x148C870
	public bool get_isRumbling() { }

	// RVA: 0x148C958
	public void PauseHaptics(InputDevice device) { }

	// RVA: 0x148CB78
	public void ResumeHaptics(InputDevice device) { }

	// RVA: 0x148CE18
	public void ResetHaptics(InputDevice device) { }

	// RVA: 0x148CCC4
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

	// RVA: 0x148CF68
	public static FourCC get_Type() { }

	// RVA: 0x148CFA4
	public FourCC get_typeStatic() { }

	// RVA: 0x148CFE0
	public static DisableDeviceCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct EnableDeviceCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x148D028
	public static FourCC get_Type() { }

	// RVA: 0x148D064
	public FourCC get_typeStatic() { }

	// RVA: 0x148D0A0
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

	// RVA: 0x148D0E0
	public static FourCC get_Type() { }

	// RVA: 0x148D11C
	public bool get_imeEnabled() { }

	// RVA: 0x148D12C
	public FourCC get_typeStatic() { }

	// RVA: 0x148D168
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

	// RVA: 0x148D1C4
	public static FourCC get_Type() { }

	// RVA: 0x148D200
	public FourCC get_typeStatic() { }

	// RVA: 0x148D23C
	public static InitiateUserAccountPairingCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceCommandDelegate
{
	// Methods

	// RVA: 0x148D27C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x148D3A0
	public virtual System.Nullable<System.Int64> Invoke(InputDevice device, InputDeviceCommand* command) { }

	// RVA: 0x148D3B4
	public virtual IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	// RVA: 0x148D410
	public virtual System.Nullable<System.Int64> EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceExecuteCommandDelegate
{
	// Methods

	// RVA: 0x148D440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x148D4F4
	public virtual Int64 Invoke(InputDeviceCommand command) { }

	// RVA: 0x148D508
	public virtual IAsyncResult BeginInvoke(InputDeviceCommand command, AsyncCallback callback, object object) { }

	// RVA: 0x148D5C4
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

	// RVA: 0x148D628
	public int get_payloadSizeInBytes() { }

	// RVA: 0x148D634
	public Void* get_payloadPtr() { }

	// RVA: 0x148D020
	public void .ctor(FourCC type, int sizeInBytes) { }

	// RVA: 0x148D63C
	public static Unity.Collections.NativeArray<System.Byte> AllocateNative(FourCC type, int payloadSize) { }

	// RVA: 0x148D6F8
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

	// RVA: 0x148D700
	public static FourCC get_Type() { }

	// RVA: 0x148D73C
	public FourCC get_typeStatic() { }

	// RVA: 0x148D778
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

	// RVA: 0x148D7C0
	public static FourCC get_Type() { }

	// RVA: 0x148D7FC
	public FourCC get_typeStatic() { }

	// RVA: 0x148D838
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

	// RVA: 0x148D87C
	public static FourCC get_Type() { }

	// RVA: 0x148D8B8
	public FourCC get_typeStatic() { }

	// RVA: 0x148D8F4
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

	// RVA: 0x148D93C
	public static FourCC get_Type() { }

	// RVA: 0x148D978
	public string ReadLayoutName() { }

	// RVA: 0x148D988
	public void WriteLayoutName(string name) { }

	// RVA: 0x148D9B0
	public FourCC get_typeStatic() { }

	// RVA: 0x148D9EC
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

	// RVA: 0x148DA84
	public static FourCC get_Type() { }

	// RVA: 0x148DAC0
	public string ReadKeyName() { }

	// RVA: 0x148DAD0
	public FourCC get_typeStatic() { }

	// RVA: 0x148DB0C
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

	// RVA: 0x148DBAC
	public static FourCC get_Type() { }

	// RVA: 0x148DBE8
	public string get_id() { }

	// RVA: 0x148DBF8
	public void set_id(string value) { }

	// RVA: 0x148DD14
	public string get_name() { }

	// RVA: 0x148DD24
	public void set_name(string value) { }

	// RVA: 0x148DE40
	public FourCC get_typeStatic() { }

	// RVA: 0x148DE7C
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

	// RVA: 0x148DEDC
	public static FourCC get_Type() { }

	// RVA: 0x148DF18
	public FourCC get_typeStatic() { }

	// RVA: 0x148DF54
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

	// RVA: 0x148DF98
	public static FourCC get_Type() { }

	// RVA: 0x148DFD4
	public string ReadId() { }

	// RVA: 0x148DFE4
	public FourCC get_typeStatic() { }

	// RVA: 0x148E020
	public static QueryUserIdCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestResetCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x148E0D8
	public static FourCC get_Type() { }

	// RVA: 0x148E114
	public FourCC get_typeStatic() { }

	// RVA: 0x148E150
	public static RequestResetCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestSyncCommand
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x148E190
	public static FourCC get_Type() { }

	// RVA: 0x148E1CC
	public FourCC get_typeStatic() { }

	// RVA: 0x148E208
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

	// RVA: 0x148E248
	public static FourCC get_Type() { }

	// RVA: 0x148E284
	public Vector2 get_position() { }

	// RVA: 0x148E28C
	public FourCC get_typeStatic() { }

	// RVA: 0x148E2C8
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

	// RVA: 0x148E324
	public static FourCC get_Type() { }

	// RVA: 0x148E360
	public FourCC get_typeStatic() { }

	// RVA: 0x148E39C
	public static SetSamplingFrequencyCommand Create(float frequency) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct WarpMousePositionCommand
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	public Vector2 warpPositionInPlayerDisplaySpace; // 0x18

	// Methods

	// RVA: 0x148E3EC
	public static FourCC get_Type() { }

	// RVA: 0x148E428
	public FourCC get_typeStatic() { }

	// RVA: 0x148E464
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

	// RVA: 0x148E4C0
	public static FourCC get_Format() { }

	// RVA: 0x148E4FC
	public FourCC get_format() { }

	// RVA: 0x148E538
	public void .ctor(GamepadButton[] buttons) { }

	// RVA: 0x148E5E4
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

	// RVA: 0x148E618
	public static FourCC get_Type() { }

	// RVA: 0x148E654
	public FourCC get_typeStatic() { }

	// RVA: 0x148CB1C
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

	// RVA: 0x148E690
	public static FourCC get_kFormat() { }

	// RVA: 0x148E6CC
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
	private const int kSizeInBits = 123;
	internal const int kSizeInBytes = 16;
	public UnityEngine.InputSystem.LowLevel.KeyboardState.<keys>e__FixedBuffer keys; // 0x10

	// Methods

	// RVA: 0x148E708
	public static FourCC get_Format() { }

	// RVA: 0x148E744
	public void .ctor(Key[] pressedKeys) { }

	// RVA: 0x148E750
	public void .ctor(bool IMESelected, Key[] pressedKeys) { }

	// RVA: 0x148E824
	public void Set(Key key, bool state) { }

	// RVA: 0x148E82C
	internal bool Get(Key key) { }

	// RVA: 0x148E834
	public void Press(Key key) { }

	// RVA: 0x148E840
	public void Release(Key key) { }

	// RVA: 0x148E84C
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

	// RVA: 0x148E888
	public static FourCC get_Format() { }

	// RVA: 0x148E8C4
	public MouseState WithButton(MouseButton button, bool state) { }

	// RVA: 0x148E8F8
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

	// RVA: 0x148E934
	public static FourCC get_Format() { }

	// RVA: 0x148E970
	public PenState WithButton(PenButton button, bool state) { }

	// RVA: 0x148E9A4
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

	// RVA: 0x148E9E0
	public static FourCC get_kFormat() { }

	// RVA: 0x148EA1C
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AccelerometerState
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x148EA58
	public static FourCC get_kFormat() { }

	// RVA: 0x148EA94
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GyroscopeState
{
	// Fields
	public Vector3 angularVelocity; // 0x10

	// Methods

	// RVA: 0x148EAD0
	public static FourCC get_kFormat() { }

	// RVA: 0x148EB0C
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GravityState
{
	// Fields
	public Vector3 gravity; // 0x10

	// Methods

	// RVA: 0x148EB48
	public static FourCC get_kFormat() { }

	// RVA: 0x148EB84
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AttitudeState
{
	// Fields
	public Quaternion attitude; // 0x10

	// Methods

	// RVA: 0x148EBC0
	public static FourCC get_kFormat() { }

	// RVA: 0x148EBFC
	public FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct LinearAccelerationState
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x148EC38
	public static FourCC get_kFormat() { }

	// RVA: 0x148EC74
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

	// RVA: 0x148ECB0
	public static FourCC get_Format() { }

	// RVA: 0x148ECEC
	public TouchPhase get_phase() { }

	// RVA: 0x148A060
	public void set_phase(TouchPhase value) { }

	// RVA: 0x148ECF4
	public bool get_isNoneEndedOrCanceled() { }

	// RVA: 0x148ED10
	public bool get_isInProgress() { }

	// RVA: 0x148ED2C
	public bool get_isPrimaryTouch() { }

	// RVA: 0x148ED38
	public void set_isPrimaryTouch(bool value) { }

	// RVA: 0x148ED58
	internal bool get_isOrphanedPrimaryTouch() { }

	// RVA: 0x148ED64
	internal void set_isOrphanedPrimaryTouch(bool value) { }

	// RVA: 0x148ED84
	public bool get_isIndirectTouch() { }

	// RVA: 0x148ED90
	public void set_isIndirectTouch(bool value) { }

	// RVA: 0x1487F98
	public bool get_isTap() { }

	// RVA: 0x148EDB0
	public void set_isTap(bool value) { }

	// RVA: 0x148EDA4
	internal bool get_isTapPress() { }

	// RVA: 0x148EDD0
	internal void set_isTapPress(bool value) { }

	// RVA: 0x14867AC
	internal bool get_isTapRelease() { }

	// RVA: 0x148EDF0
	internal void set_isTapRelease(bool value) { }

	// RVA: 0x1486A8C
	internal bool get_beganInSameFrame() { }

	// RVA: 0x1486A98
	internal void set_beganInSameFrame(bool value) { }

	// RVA: 0x148EE10
	public FourCC get_format() { }

	// RVA: 0x148EE4C
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

	// RVA: 0x148F16C
	public static FourCC get_Format() { }

	// RVA: 0x148F1A8
	public TouchState* get_primaryTouch() { }

	// RVA: 0x148F1AC
	public TouchState* get_touches() { }

	// RVA: 0x148F1B4
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

	// RVA: 0x148F1F0
	public static FourCC get_Type() { }

	// RVA: 0x148F22C
	public Double get_startTime() { }

	// RVA: 0x148F234
	public void set_startTime(Double value) { }

	// RVA: 0x148F23C
	public InputActionPhase get_phase() { }

	// RVA: 0x148F244
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x148F24C
	public Byte* get_valueData() { }

	// RVA: 0x148F254
	public int get_valueSizeInBytes() { }

	// RVA: 0x148F268
	public int get_stateIndex() { }

	// RVA: 0x148F270
	public void set_stateIndex(int value) { }

	// RVA: 0x148F2DC
	public int get_controlIndex() { }

	// RVA: 0x148F2E4
	public void set_controlIndex(int value) { }

	// RVA: 0x148F350
	public int get_bindingIndex() { }

	// RVA: 0x148F358
	public void set_bindingIndex(int value) { }

	// RVA: 0x148F3C4
	public int get_interactionIndex() { }

	// RVA: 0x148F3D8
	public void set_interactionIndex(int value) { }

	// RVA: 0x148F454
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x148F458
	public FourCC get_typeStatic() { }

	// RVA: 0x148F494
	public static int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	// RVA: 0x148F49C
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

	// RVA: 0x148F5D0
	public UInt32 get_deltaStateSizeInBytes() { }

	// RVA: 0x148F5DC
	public Void* get_deltaState() { }

	// RVA: 0x148F5E4
	public FourCC get_typeStatic() { }

	// RVA: 0x148F5F0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x148F5F4
	public static DeltaStateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x148F728
	internal static DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x148F72C
	public static Unity.Collections.NativeArray<System.Byte> From(InputControl control, InputEventPtr eventPtr, Allocator allocator) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceConfigurationEvent
{
	// Fields
	public const int Type = 1145259591;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x148FC28
	public FourCC get_typeStatic() { }

	// RVA: 0x148FC34
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x148FC38
	public static DeviceConfigurationEvent Create(int deviceId, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceRemoveEvent
{
	// Fields
	public const int Type = 1146242381;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x148FD44
	public FourCC get_typeStatic() { }

	// RVA: 0x148FD50
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x148FD54
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

	// RVA: 0x148FE60
	public FourCC get_typeStatic() { }

	// RVA: 0x148FE6C
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

	// RVA: 0x148FF94
	public FourCC get_typeStatic() { }

	// RVA: 0x148FFA0
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

	// RVA: 0x149037C
	public void .ctor(IMECompositionString compositionString) { }

	// RVA: 0x1490468
	public bool MoveNext() { }

	// RVA: 0x1490498
	public void Reset() { }

	// RVA: 0x14904A4
	public void Dispose() { }

	// RVA: 0x14904A8
	public Char get_Current() { }

	// RVA: 0x14904B0
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

	// RVA: 0x1490228
	public int get_Count() { }

	// RVA: 0x1490230
	public Char get_Item(int index) { }

	// RVA: 0x1490198
	public void .ctor(string characters) { }

	// RVA: 0x14902A8
	public override string ToString() { }

	// RVA: 0x14902C0
	public System.Collections.Generic.IEnumerator<System.Char> GetEnumerator() { }

	// RVA: 0x14903AC
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

	// RVA: 0x1490518
	public FourCC get_type() { }

	// RVA: 0x1490520
	public void set_type(FourCC value) { }

	// RVA: 0x148F260
	public UInt32 get_sizeInBytes() { }

	// RVA: 0x1490528
	public void set_sizeInBytes(UInt32 value) { }

	// RVA: 0x14905D4
	public int get_eventId() { }

	// RVA: 0x14905E0
	public void set_eventId(int value) { }

	// RVA: 0x14905F4
	public int get_deviceId() { }

	// RVA: 0x14905FC
	public void set_deviceId(int value) { }

	// RVA: 0x1490604
	public Double get_time() { }

	// RVA: 0x1490664
	public void set_time(Double value) { }

	// RVA: 0x14906D0
	internal Double get_internalTime() { }

	// RVA: 0x14906D8
	internal void set_internalTime(Double value) { }

	// RVA: 0x148FB18
	public void .ctor(FourCC type, int sizeInBytes, int deviceId, Double time) { }

	// RVA: 0x14906E0
	public bool get_handled() { }

	// RVA: 0x14906EC
	public void set_handled(bool value) { }

	// RVA: 0x1490708
	public override string ToString() { }

	// RVA: 0x14909B4
	internal static InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	// RVA: 0x14909D0
	internal static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, InputEventBuffer buffer) { }

	// RVA: 0x1490BA8
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

	// RVA: 0x14914D4
	public void .ctor(InputEventBuffer buffer) { }

	// RVA: 0x14917B0
	public bool MoveNext() { }

	// RVA: 0x1491820
	public void Reset() { }

	// RVA: 0x149182C
	public void Dispose() { }

	// RVA: 0x1491830
	public InputEventPtr get_Current() { }

	// RVA: 0x1491838
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

	// RVA: 0x1490C0C
	public int get_eventCount() { }

	// RVA: 0x1490C14
	public Int64 get_sizeInBytes() { }

	// RVA: 0x1490C1C
	public Int64 get_capacityInBytes() { }

	// RVA: 0x1490C74
	public Unity.Collections.NativeArray<System.Byte> get_data() { }

	// RVA: 0x1490C80
	public InputEventPtr get_bufferPtr() { }

	// RVA: 0x1490CD4
	public void .ctor(InputEvent* eventPtr, int eventCount, int sizeInBytes, int capacityInBytes) { }

	// RVA: 0x1490E98
	public void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, int eventCount, int sizeInBytes, bool transferNativeArrayOwnership) { }

	// RVA: 0x1490FD4
	public void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x1491054
	public InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x1490B10
	public bool Contains(InputEvent* eventPtr) { }

	// RVA: 0x1491340
	public void Reset() { }

	// RVA: 0x1491358
	internal void AdvanceToNextEvent(InputEvent* currentReadPos, InputEvent* currentWritePos, int numEventsRetainedInBuffer, int numRemainingEvents, bool leaveEventInBuffer) { }

	// RVA: 0x1491418
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x1491544
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1491600
	public void Dispose() { }

	// RVA: 0x1491664
	public InputEventBuffer Clone() { }

	// RVA: 0x1491740
	private object System.ICloneable.Clone() { }

}

// Namespace: 
internal class ObserverState
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers; // 0x10
	public System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28

	// Methods

	// RVA: 0x1491A98
	public void .ctor() { }

	// RVA: 0x1491B34
	private void <.ctor>b__2_0(InputEventPtr eventPtr, InputDevice device) { }

}

// Namespace: 
private class DisposableObserver
{
	// Fields
	public System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer; // 0x10

	// Methods

	// RVA: 0x1491C48
	public void Dispose() { }

	// RVA: 0x1491B2C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventListener
{
	// Fields
	internal static ObserverState s_ObserverState; // 0x0

	// Methods

	// RVA: 0x148BD94
	public static InputEventListener op_Addition(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x148C084
	public static InputEventListener op_Subtraction(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x14918A0
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventPtr
{
	// Fields
	private readonly InputEvent* m_EventPtr; // 0x10

	// Methods

	// RVA: 0x1491DA0
	public void .ctor(InputEvent* eventPtr) { }

	// RVA: 0x1486784
	public bool get_valid() { }

	// RVA: 0x1491DA8
	public bool get_handled() { }

	// RVA: 0x148B65C
	public void set_handled(bool value) { }

	// RVA: 0x1491DC4
	public int get_id() { }

	// RVA: 0x1491DE0
	public void set_id(int value) { }

	// RVA: 0x1486794
	public FourCC get_type() { }

	// RVA: 0x1491E58
	public UInt32 get_sizeInBytes() { }

	// RVA: 0x1491E70
	public int get_deviceId() { }

	// RVA: 0x1491E88
	public void set_deviceId(int value) { }

	// RVA: 0x148C20C
	public Double get_time() { }

	// RVA: 0x1491EF4
	public void set_time(Double value) { }

	// RVA: 0x1491FAC
	internal Double get_internalTime() { }

	// RVA: 0x1491FC4
	internal void set_internalTime(Double value) { }

	// RVA: 0x1492030
	public InputEvent* get_data() { }

	// RVA: 0x1492038
	internal FourCC get_stateFormat() { }

	// RVA: 0x14921A0
	internal UInt32 get_stateSizeInBytes() { }

	// RVA: 0x14923F4
	internal UInt32 get_stateOffset() { }

	// RVA: 0x30D3738
	public bool IsA() { }

	// RVA: 0x14924D4
	public InputEventPtr Next() { }

	// RVA: 0x14920EC
	public override string ToString() { }

	// RVA: 0x1492500
	public InputEvent* ToPointer() { }

	// RVA: 0x1492508
	public bool Equals(InputEventPtr other) { }

	// RVA: 0x1492578
	public override bool Equals(object obj) { }

	// RVA: 0x1492660
	public override int GetHashCode() { }

	// RVA: 0x1492668
	public static bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x148C7A4
	public static bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x148C7A0
	public static InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	// RVA: 0x1492674
	public static InputEventPtr From(InputEvent* eventPtr) { }

	// RVA: 0x14917AC
	public static InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	// RVA: 0x1492678
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

	// RVA: 0x149267C
	public bool get_isOpen() { }

	// RVA: 0x1492684
	public int get_remainingEventCount() { }

	// RVA: 0x1492694
	public int get_numEventsRetainedInBuffer() { }

	// RVA: 0x149269C
	public InputEvent* get_currentEventPtr() { }

	// RVA: 0x14926D4
	public UInt32 get_numBytesRetainedInBuffer() { }

	// RVA: 0x1492734
	public void .ctor(InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	// RVA: 0x14927CC
	public void Close(InputEventBuffer eventBuffer) { }

	// RVA: 0x1492930
	public void CleanUpAfterException() { }

	// RVA: 0x14929E8
	public void Write(InputEvent* eventPtr) { }

	// RVA: 0x1492BCC
	public InputEvent* Advance(bool leaveEventInBuffer) { }

	// RVA: 0x1492D08
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

	// RVA: 0x1494E68
	public void .ctor(InputEventTrace trace) { }

	// RVA: 0x149574C
	public void Dispose() { }

	// RVA: 0x149577C
	public bool MoveNext() { }

	// RVA: 0x14958B8
	public void Reset() { }

	// RVA: 0x14958E0
	public InputEventPtr get_Current() { }

	// RVA: 0x14958E8
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

	// RVA: 0x14973D4
	private static void .cctor() { }

	// RVA: 0x1497440
	public void .ctor() { }

	// RVA: 0x1497448
	internal int <PlayAllEventsAccordingToTimestamps>b__38_0(InputEventPtr a, InputEventPtr b) { }

}

// Namespace: 
private sealed class <>c__DisplayClass43_0
{
	// Fields
	public int originalDeviceId; // 0x10

	// Methods

	// RVA: 0x14973CC
	public void .ctor() { }

	// RVA: 0x1497510
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

	// RVA: 0x1495950
	public InputEventTrace get_trace() { }

	// RVA: 0x1495958
	public bool get_finished() { }

	// RVA: 0x1495960
	private void set_finished(bool value) { }

	// RVA: 0x1495968
	public bool get_paused() { }

	// RVA: 0x1495970
	public void set_paused(bool value) { }

	// RVA: 0x1495978
	public int get_position() { }

	// RVA: 0x1495980
	private void set_position(int value) { }

	// RVA: 0x1495988
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices() { }

	// RVA: 0x1494910
	internal void .ctor(InputEventTrace trace) { }

	// RVA: 0x14959F8
	public void Dispose() { }

	// RVA: 0x1495CFC
	public ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice) { }

	// RVA: 0x1495D8C
	public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) { }

	// RVA: 0x1495FC8
	public ReplayController WithAllDevicesMappedToNewInstances() { }

	// RVA: 0x1495FD4
	public ReplayController OnFinished(Action action) { }

	// RVA: 0x1495FFC
	public ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action) { }

	// RVA: 0x1496024
	public ReplayController PlayOneEvent() { }

	// RVA: 0x1496688
	public ReplayController Rewind() { }

	// RVA: 0x14966D0
	public ReplayController PlayAllFramesOneByOne() { }

	// RVA: 0x149678C
	public ReplayController PlayAllEvents() { }

	// RVA: 0x149683C
	public ReplayController PlayAllEventsAccordingToTimestamps() { }

	// RVA: 0x1496AD8
	private void OnBeginFrame() { }

	// RVA: 0x1496DB0
	private void Finished() { }

	// RVA: 0x1496450
	private void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x14960B4
	private bool MoveNext(bool skipFrameEvents, InputEventPtr eventPtr) { }

	// RVA: 0x1496EA8
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

	// RVA: 0x1497524
	public int get_deviceId() { }

	// RVA: 0x149752C
	public void set_deviceId(int value) { }

	// RVA: 0x1497534
	public string get_layout() { }

	// RVA: 0x149753C
	public void set_layout(string value) { }

	// RVA: 0x1497544
	public FourCC get_stateFormat() { }

	// RVA: 0x149754C
	public void set_stateFormat(FourCC value) { }

	// RVA: 0x1497554
	public int get_stateSizeInBytes() { }

	// RVA: 0x149755C
	public void set_stateSizeInBytes(int value) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
[Serializable]
public sealed class InputEventTrace
{
	// Fields
	private const int kDefaultBufferSize = 1048576;
	private static readonly ProfilerMarker k_InputEvenTraceMarker; // 0x0
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
	private static int kFileVersion; // 0x8

	// Methods

	// RVA: 0x1492D68
	public static FourCC get_FrameMarkerEvent() { }

	// RVA: 0x1492DA4
	public int get_deviceId() { }

	// RVA: 0x1492DAC
	public void set_deviceId(int value) { }

	// RVA: 0x1492DB4
	public bool get_enabled() { }

	// RVA: 0x1492DBC
	public bool get_recordFrameMarkers() { }

	// RVA: 0x1492DC4
	public void set_recordFrameMarkers(bool value) { }

	// RVA: 0x1492EEC
	public Int64 get_eventCount() { }

	// RVA: 0x1492EF4
	public Int64 get_totalEventSizeInBytes() { }

	// RVA: 0x1492EFC
	public Int64 get_allocatedSizeInBytes() { }

	// RVA: 0x1492F1C
	public Int64 get_maxSizeInBytes() { }

	// RVA: 0x1492F24
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos() { }

	// RVA: 0x1492F78
	public System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> get_onFilterEvent() { }

	// RVA: 0x1492F80
	public void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> value) { }

	// RVA: 0x1492F88
	public void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1492FE4
	public void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1493040
	public void .ctor(InputDevice device, Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x1493118
	public void .ctor(Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x14931B4
	public void WriteTo(string filePath) { }

	// RVA: 0x1493340
	public void WriteTo(Stream stream) { }

	// RVA: 0x1493B1C
	public void ReadFrom(string filePath) { }

	// RVA: 0x1493CA8
	public void ReadFrom(Stream stream) { }

	// RVA: 0x1494494
	public static InputEventTrace LoadFrom(string filePath) { }

	// RVA: 0x1494654
	public static InputEventTrace LoadFrom(Stream stream) { }

	// RVA: 0x1494784
	public ReplayController Replay() { }

	// RVA: 0x1494990
	public bool Resize(Int64 newBufferSize, Int64 newMaxBufferSize) { }

	// RVA: 0x1494C88
	public void Clear() { }

	// RVA: 0x1494CA8
	public void Enable() { }

	// RVA: 0x14947F0
	public void Disable() { }

	// RVA: 0x1494C10
	public bool GetNextEvent(InputEventPtr current) { }

	// RVA: 0x1493A98
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x1494EB0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1494F34
	public void Dispose() { }

	// RVA: 0x1492F14
	private Byte* get_m_EventBuffer() { }

	// RVA: 0x149447C
	private void set_m_EventBuffer(Byte* value) { }

	// RVA: 0x1494C08
	private Byte* get_m_EventBufferHead() { }

	// RVA: 0x1494484
	private void set_m_EventBufferHead(Byte* value) { }

	// RVA: 0x1494E60
	private Byte* get_m_EventBufferTail() { }

	// RVA: 0x149448C
	private void set_m_EventBufferTail(Byte* value) { }

	// RVA: 0x1494E2C
	private void Allocate() { }

	// RVA: 0x1494F94
	private void Release() { }

	// RVA: 0x1494FF0
	private void OnBeforeUpdate() { }

	// RVA: 0x14951AC
	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	// RVA: 0x1493A5C
	private static FourCC get_kFileFormat() { }

	// RVA: 0x14956C4
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

	// RVA: 0x14923E8
	public UInt32 get_stateSizeInBytes() { }

	// RVA: 0x1497564
	public Void* get_state() { }

	// RVA: 0x149756C
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x1497570
	public FourCC get_typeStatic() { }

	// RVA: 0x318DB98
	public TState GetState() { }

	// RVA: 0x318DB98
	public static TState GetState(InputEventPtr ptr) { }

	// RVA: 0x30D64E4
	public static int GetEventSizeWithPayload() { }

	// RVA: 0x14922B4
	public static StateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x14920E8
	internal static StateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x149757C
	public static Unity.Collections.NativeArray<System.Byte> From(InputDevice device, InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x1497950
	public static Unity.Collections.NativeArray<System.Byte> FromDefaultStateFor(InputDevice device, InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x1497584
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

	// RVA: 0x1497958
	public FourCC get_typeStatic() { }

	// RVA: 0x1497964
	public static TextEvent* From(InputEventPtr eventPtr) { }

	// RVA: 0x1497A98
	public static TextEvent Create(int deviceId, Char character, Double time) { }

	// RVA: 0x1497BA8
	public static TextEvent Create(int deviceId, int character, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal sealed class InputUpdateDelegate
{
	// Methods

	// RVA: 0x1497CB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1497D5C
	public virtual void Invoke(InputUpdateType updateType, InputEventBuffer eventBuffer) { }

	// RVA: 0x1497D70
	public virtual IAsyncResult BeginInvoke(InputUpdateType updateType, InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	// RVA: 0x1497E5C
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

	// RVA: 0x318DB98
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

	// RVA: 0x1497EB0
	public int get_maxNumDevices() { }

	// RVA: 0x1497EB8
	public void set_maxNumDevices(int value) { }

	// RVA: 0x1497EC0
	public int get_currentNumDevices() { }

	// RVA: 0x1497EC8
	public void set_currentNumDevices(int value) { }

	// RVA: 0x1497ED0
	public int get_maxStateSizeInBytes() { }

	// RVA: 0x1497ED8
	public void set_maxStateSizeInBytes(int value) { }

	// RVA: 0x1497EE0
	public int get_currentStateSizeInBytes() { }

	// RVA: 0x1497EE8
	public void set_currentStateSizeInBytes(int value) { }

	// RVA: 0x1497EF0
	public int get_currentControlCount() { }

	// RVA: 0x1497EF8
	public void set_currentControlCount(int value) { }

	// RVA: 0x1497F00
	public int get_currentLayoutCount() { }

	// RVA: 0x1497F08
	public void set_currentLayoutCount(int value) { }

	// RVA: 0x1497F10
	public int get_totalEventBytes() { }

	// RVA: 0x1497F18
	public void set_totalEventBytes(int value) { }

	// RVA: 0x1497F20
	public int get_totalEventCount() { }

	// RVA: 0x1497F28
	public void set_totalEventCount(int value) { }

	// RVA: 0x1497F30
	public int get_totalUpdateCount() { }

	// RVA: 0x1497F38
	public void set_totalUpdateCount(int value) { }

	// RVA: 0x1497F40
	public Double get_totalEventProcessingTime() { }

	// RVA: 0x1497F48
	public void set_totalEventProcessingTime(Double value) { }

	// RVA: 0x1497F50
	public Double get_totalEventLagTime() { }

	// RVA: 0x1497F58
	public void set_totalEventLagTime(Double value) { }

	// RVA: 0x1497F60
	public float get_averageEventBytesPerFrame() { }

	// RVA: 0x1497F78
	public Double get_averageProcessingTimePerEvent() { }

	// RVA: 0x1497F90
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

	// RVA: 0x149823C
	public UInt32 get_value() { }

	// RVA: 0x1498244
	private void set_value(UInt32 value) { }

	// RVA: 0x1498034
	public void OnBeforeUpdate() { }

	// RVA: 0x14980E0
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

	// RVA: 0x1497FA8
	internal static void OnBeforeUpdate(InputUpdateType type) { }

	// RVA: 0x149804C
	internal static void OnUpdate(InputUpdateType type) { }

	// RVA: 0x1498104
	public static SerializedState Save() { }

	// RVA: 0x149816C
	public static void Restore(SerializedState state) { }

	// RVA: 0x1498214
	public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	// RVA: 0x1498230
	public static bool IsPlayerUpdate(InputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value; // 0x10

	// Methods

	// RVA: 0x1499078
	public void .ctor() { }

	// RVA: 0x1499080
	internal void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value; // 0x10

	// Methods

	// RVA: 0x14990BC
	public void .ctor() { }

	// RVA: 0x14990C4
	internal bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public InputUpdateDelegate value; // 0x10

	// Methods

	// RVA: 0x1499108
	public void .ctor() { }

	// RVA: 0x1499110
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

	// RVA: 0x149824C
	public int AllocateDeviceId() { }

	// RVA: 0x14982BC
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x1498344
	public void QueueEvent(InputEvent* ptr) { }

	// RVA: 0x14983D0
	public Int64 DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: 0x1498494
	public InputUpdateDelegate get_onUpdate() { }

	// RVA: 0x149849C
	public void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: 0x14985D0
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }

	// RVA: 0x14985D8
	public void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }

	// RVA: 0x1498714
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }

	// RVA: 0x149871C
	public void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }

	// RVA: 0x1498858
	public System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x14988C8
	public void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x1498950
	public Action get_onShutdown() { }

	// RVA: 0x1498958
	public void set_onShutdown(Action value) { }

	// RVA: 0x1498A74
	public System.Action<System.Boolean> get_onPlayerFocusChanged() { }

	// RVA: 0x1498A7C
	public void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x1498B98
	public bool get_isPlayerFocused() { }

	// RVA: 0x1498C08
	public float get_pollingFrequency() { }

	// RVA: 0x1498C10
	public void set_pollingFrequency(float value) { }

	// RVA: 0x1498C84
	public Double get_currentTime() { }

	// RVA: 0x1498CF4
	public Double get_currentTimeForFixedUpdate() { }

	// RVA: 0x1498D68
	public Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x1498DD8
	public float get_unscaledGameTime() { }

	// RVA: 0x1498DE0
	public bool get_runInBackground() { }

	// RVA: 0x1498E80
	public void set_runInBackground(bool value) { }

	// RVA: 0x1498E88
	private void OnShutdown() { }

	// RVA: 0x1498EB0
	private bool OnWantsToShutdown() { }

	// RVA: 0x1498F0C
	private void OnFocusChanged(bool focus) { }

	// RVA: 0x1498F48
	public Vector2 get_screenSize() { }

	// RVA: 0x1498F7C
	public ScreenOrientation get_screenOrientation() { }

	// RVA: 0x1498F84
	public bool get_isInBatchMode() { }

	// RVA: 0x1498FF4
	public void .ctor() { }

	// RVA: 0x1499004
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

	// RVA: 0x1499FD8
	public void NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x149A024
	public void NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1499D10
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public static class InputState
{
	// Methods

	// RVA: 0x149931C
	public static InputUpdateType get_currentUpdateType() { }

	// RVA: 0x1499368
	public static UInt32 get_updateCount() { }

	// RVA: 0x14993B4
	public static Double get_currentTime() { }

	// RVA: 0x1499488
	public static void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1499518
	public static void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x14995A8
	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType) { }

	// RVA: 0x318DB98
	public static void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x318DB98
	public static void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x1499850
	public static bool IsIntegerFormat(FourCC format) { }

	// RVA: 0x1499AA0
	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x1499C10
	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback, int monitorIndex, System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback) { }

	// RVA: 0x1499D18
	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x1499E10
	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1499F04
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

	// RVA: 0x149A06C
	public static int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	// RVA: 0x149A4C8
	public static FourCC GetPrimitiveFormatFromType(Type type) { }

	// RVA: 0x149AB48
	public FourCC get_format() { }

	// RVA: 0x149AB50
	public void set_format(FourCC value) { }

	// RVA: 0x149AB58
	public UInt32 get_byteOffset() { }

	// RVA: 0x149AB60
	public void set_byteOffset(UInt32 value) { }

	// RVA: 0x149AB68
	public UInt32 get_bitOffset() { }

	// RVA: 0x149AB70
	public void set_bitOffset(UInt32 value) { }

	// RVA: 0x149AB78
	public UInt32 get_sizeInBits() { }

	// RVA: 0x149AB80
	public void set_sizeInBits(UInt32 value) { }

	// RVA: 0x149AB88
	internal UInt32 get_alignedSizeInBytes() { }

	// RVA: 0x149ABF0
	internal UInt32 get_effectiveByteOffset() { }

	// RVA: 0x149AC78
	internal UInt32 get_effectiveBitOffset() { }

	// RVA: 0x149AD00
	public int ReadInt(Void* statePtr) { }

	// RVA: 0x149B038
	public void WriteInt(Void* statePtr, int value) { }

	// RVA: 0x149B348
	public float ReadFloat(Void* statePtr) { }

	// RVA: 0x149B7EC
	public void WriteFloat(Void* statePtr, float value) { }

	// RVA: 0x149BDC0
	internal PrimitiveValue FloatToPrimitiveValue(float value) { }

	// RVA: 0x149C3C4
	public Double ReadDouble(Void* statePtr) { }

	// RVA: 0x149C878
	public void WriteDouble(Void* statePtr, Double value) { }

	// RVA: 0x149CE64
	public void Write(Void* statePtr, PrimitiveValue value) { }

	// RVA: 0x149D280
	public void CopyToFrom(Void* toStatePtr, Void* fromStatePtr) { }

	// RVA: 0x149D3EC
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
internal struct DoubleBuffers
{
	// Fields
	public Void** deviceToBufferMapping; // 0x10
	public int deviceCount; // 0x18

	// Methods

	// RVA: 0x149E444
	public bool get_valid() { }

	// RVA: 0x149DCA4
	public void SetFrontBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x149DCC0
	public void SetBackBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x149D95C
	public Void* GetFrontBuffer(int deviceIndex) { }

	// RVA: 0x149DA04
	public Void* GetBackBuffer(int deviceIndex) { }

	// RVA: 0x149E454
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

	// RVA: 0x149D800
	public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	// RVA: 0x149D8DC
	public static Void* GetFrontBufferForDevice(int deviceIndex) { }

	// RVA: 0x149D980
	public static Void* GetBackBufferForDevice(int deviceIndex) { }

	// RVA: 0x149DA2C
	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

	// RVA: 0x149DA94
	public void AllocateAll(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x149DC44
	private static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, Byte* bufferPtr, UInt32 sizePerBuffer, UInt32 mappingTableSizePerBuffer) { }

	// RVA: 0x149DCE0
	public void FreeAll() { }

	// RVA: 0x149DDE0
	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	// RVA: 0x149DF68
	private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) { }

	// RVA: 0x149E1A0
	private static void MigrateSingleBuffer(Void* newBuffer, InputDevice[] devices, int deviceCount, Void* oldBuffer) { }

	// RVA: 0x149DBC8
	private static UInt32 ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x149E2F4
	private static UInt32 NextDeviceOffset(UInt32 currentOffset, InputDevice device) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly InputStateHistory m_History; // 0x10
	private int m_Index; // 0x18

	// Methods

	// RVA: 0x14A01F4
	public void .ctor(InputStateHistory history) { }

	// RVA: 0x14A09B0
	public bool MoveNext() { }

	// RVA: 0x14A09EC
	public void Reset() { }

	// RVA: 0x14A09F8
	public Record get_Current() { }

	// RVA: 0x14A0A1C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x14A0A8C
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

	// RVA: 0x14A016C
	public Byte* get_statePtrWithControlIndex() { }

	// RVA: 0x14A0164
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

	// RVA: 0x14A0A90
	internal RecordHeader* get_header() { }

	// RVA: 0x14A0AB8
	internal int get_recordIndex() { }

	// RVA: 0x14A0AC4
	internal UInt32 get_version() { }

	// RVA: 0x14A0ACC
	public bool get_valid() { }

	// RVA: 0x14A0B28
	public InputStateHistory get_owner() { }

	// RVA: 0x14A0B30
	public int get_index() { }

	// RVA: 0x14A0C2C
	public Double get_time() { }

	// RVA: 0x14A0C6C
	public InputControl get_control() { }

	// RVA: 0x14A0D88
	public Record get_next() { }

	// RVA: 0x14A0E54
	public Record get_previous() { }

	// RVA: 0x149EC0C
	internal void .ctor(InputStateHistory owner, int index, RecordHeader* header) { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x14A0F18
	public object ReadValueAsObject() { }

	// RVA: 0x14A0F5C
	public Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x14A0F80
	internal Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x14A1070
	public Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x14A1094
	internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x149EDB0
	public void CopyFrom(Record record) { }

	// RVA: 0x14A0B78
	internal void CheckValid() { }

	// RVA: 0x14A1178
	public bool Equals(Record other) { }

	// RVA: 0x14A11AC
	public override bool Equals(object obj) { }

	// RVA: 0x14A125C
	public override int GetHashCode() { }

	// RVA: 0x14A12B0
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

	// RVA: 0x149E490
	public int get_Count() { }

	// RVA: 0x149E498
	public UInt32 get_version() { }

	// RVA: 0x149E4A0
	public int get_historyDepth() { }

	// RVA: 0x149E4A8
	public void set_historyDepth(int value) { }

	// RVA: 0x149E590
	public int get_extraMemoryPerRecord() { }

	// RVA: 0x149E598
	public void set_extraMemoryPerRecord(int value) { }

	// RVA: 0x149E680
	public InputUpdateType get_updateMask() { }

	// RVA: 0x149E7F4
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x149E8CC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x149E940
	public Record get_Item(int index) { }

	// RVA: 0x149EC58
	public void set_Item(int index, Record value) { }

	// RVA: 0x149F1D4
	public System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded() { }

	// RVA: 0x149F1DC
	public void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value) { }

	// RVA: 0x149F1E4
	public System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> get_onShouldRecordStateChange() { }

	// RVA: 0x149F1EC
	public void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x149F1F4
	public void .ctor(int maxStateSizeInBytes) { }

	// RVA: 0x149F29C
	public void .ctor(string path) { }

	// RVA: 0x149F404
	public void .ctor(InputControl control) { }

	// RVA: 0x149F520
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls) { }

	// RVA: 0x149F5BC
	protected override void Finalize() { }

	// RVA: 0x149F74C
	public void Clear() { }

	// RVA: 0x149F760
	public Record AddRecord(Record record) { }

	// RVA: 0x149F908
	public void StartRecording() { }

	// RVA: 0x149FAA4
	public void StopRecording() { }

	// RVA: 0x149FC3C
	public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x149FDF8
	public Record RecordStateChange(InputControl control, Void* statePtr, Double time) { }

	// RVA: 0x14A0174
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator() { }

	// RVA: 0x14A0220
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x149F64C
	public void Dispose() { }

	// RVA: 0x14A02A0
	protected void Destroy() { }

	// RVA: 0x14A0308
	private void Allocate() { }

	// RVA: 0x14A0660
	protected internal int RecordIndexToUserIndex(int index) { }

	// RVA: 0x149EA74
	protected internal int UserIndexToRecordIndex(int index) { }

	// RVA: 0x149EA8C
	protected internal RecordHeader* GetRecord(int index) { }

	// RVA: 0x14A067C
	internal RecordHeader* GetRecordUnchecked(int index) { }

	// RVA: 0x149F7F0
	protected internal RecordHeader* AllocateRecord(int index) { }

	// RVA: 0x318DB98
	protected TValue ReadValue(RecordHeader* data) { }

	// RVA: 0x14A0730
	protected object ReadValueAsObject(RecordHeader* data) { }

	// RVA: 0x14A08C8
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x14A09AC
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x14A060C
	internal int get_bytesPerRecord() { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history) { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x318DB98
	public Record get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
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

	// RVA: 0x318DB98
	internal RecordHeader* get_header() { }

	// RVA: 0x30D39B8
	internal int get_recordIndex() { }

	// RVA: 0x30D3738
	public bool get_valid() { }

	// RVA: 0x30D3CF0
	public UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner() { }

	// RVA: 0x30D39B8
	public int get_index() { }

	// RVA: -1
	public Double get_time() { }

	// RVA: 0x30D3CF0
	public UnityEngine.InputSystem.InputControl<TValue> get_control() { }

	// RVA: 0x318DB98
	public Record get_next() { }

	// RVA: 0x318DB98
	public Record get_previous() { }

	// RVA: 0x318DB98
	internal void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, RecordHeader* header) { }

	// RVA: 0x30D4D3C
	internal void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index) { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x318DB98
	public Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x318DB98
	internal Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x318DB98
	public Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x318DB98
	internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x318DB98
	public void CopyFrom(Record record) { }

	// RVA: 0x30D488C
	private void CheckValid() { }

	// RVA: 0x318DB98
	public bool Equals(Record other) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public class InputStateHistory<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(System.Nullable<System.Int32> maxStateSizeInBytes) { }

	// RVA: 0x30D4CD4
	public void .ctor(UnityEngine.InputSystem.InputControl<TValue> control) { }

	// RVA: 0x30D4CD4
	public void .ctor(string path) { }

	// RVA: 0x30D488C
	protected override void Finalize() { }

	// RVA: 0x318DB98
	public Record AddRecord(Record record) { }

	// RVA: 0x318DB98
	public Record RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	public Record get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, Record value) { }

}

// Namespace: 
private class Select
{
	// Fields
	private UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x30D488C
	public void OnCompleted() { }

	// RVA: 0x30D4CD4
	public void OnError(Exception error) { }

	// RVA: 0x318DB98
	public void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal class SelectObservable<T0, T1>
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,TResult> m_Filter; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x30D3DA0
	public IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class AxisDeadzoneProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x14A13FC
	private float get_minOrDefault() { }

	// RVA: 0x14A1470
	private float get_maxOrDefault() { }

	// RVA: 0x14A14E4
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14A15F8
	public override string ToString() { }

	// RVA: 0x14A1768
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ClampProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x14A17BC
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14A17D4
	public override string ToString() { }

	// RVA: 0x14A187C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateDirectionProcessor
{
	// Methods

	// RVA: 0x14A18D0
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14A1AFC
	public override string ToString() { }

	// RVA: 0x14A1B40
	public override CachingPolicy get_cachingPolicy() { }

	// RVA: 0x14A1B48
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateRotationProcessor
{
	// Methods

	// RVA: 0x14A1B9C
	public override Quaternion Process(Quaternion value, InputControl control) { }

	// RVA: 0x14A1DE8
	public override string ToString() { }

	// RVA: 0x14A1E2C
	public override CachingPolicy get_cachingPolicy() { }

	// RVA: 0x14A1E34
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertProcessor
{
	// Methods

	// RVA: 0x14A1E88
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14A1E90
	public override string ToString() { }

	// RVA: 0x14A1ED4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertVector2Processor
{
	// Fields
	public bool invertX; // 0x10
	public bool invertY; // 0x11

	// Methods

	// RVA: 0x14A1F28
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x14A1F4C
	public override string ToString() { }

	// RVA: 0x14A1FF4
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

	// RVA: 0x14A2050
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14A2084
	public override string ToString() { }

	// RVA: 0x14A2150
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

	// RVA: 0x14A21B4
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14A22A4
	public static float Normalize(float value, float min, float max, float zero) { }

	// RVA: 0x14A2394
	internal static float Denormalize(float value, float min, float max, float zero) { }

	// RVA: 0x14A23D8
	public override string ToString() { }

	// RVA: 0x14A24A4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector2Processor
{
	// Methods

	// RVA: 0x14A24F8
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x14A25E0
	public override string ToString() { }

	// RVA: 0x14A2624
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector3Processor
{
	// Methods

	// RVA: 0x14A2678
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14A2780
	public override string ToString() { }

	// RVA: 0x14A27C4
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleProcessor
{
	// Fields
	public float factor; // 0x10

	// Methods

	// RVA: 0x14A2818
	public override float Process(float value, InputControl control) { }

	// RVA: 0x14A2824
	public override string ToString() { }

	// RVA: 0x14A28B0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleVector2Processor
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14

	// Methods

	// RVA: 0x14A290C
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x14A291C
	public override string ToString() { }

	// RVA: 0x14A29C4
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

	// RVA: 0x14A2A20
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x14A2A38
	public override string ToString() { }

	// RVA: 0x14A2B04
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class StickDeadzoneProcessor
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x14A2B68
	private float get_minOrDefault() { }

	// RVA: 0x14A2BDC
	private float get_maxOrDefault() { }

	// RVA: 0x14A2C50
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x14A2D4C
	private float GetDeadZoneAdjustedValue(float value) { }

	// RVA: 0x14A2E60
	public override string ToString() { }

	// RVA: 0x14A2FD0
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

	// RVA: 0x14A3024
	public string get_layout() { }

	// RVA: 0x14A302C
	public void set_layout(string value) { }

	// RVA: 0x14A3034
	public string get_variants() { }

	// RVA: 0x14A303C
	public void set_variants(string value) { }

	// RVA: 0x14A3044
	public string get_name() { }

	// RVA: 0x14A304C
	public void set_name(string value) { }

	// RVA: 0x14A3054
	public string get_format() { }

	// RVA: 0x14A305C
	public void set_format(string value) { }

	// RVA: 0x14A3064
	public string get_usage() { }

	// RVA: 0x14A306C
	public void set_usage(string value) { }

	// RVA: 0x14A3074
	public string[] get_usages() { }

	// RVA: 0x14A307C
	public void set_usages(string[] value) { }

	// RVA: 0x14A3084
	public string get_parameters() { }

	// RVA: 0x14A308C
	public void set_parameters(string value) { }

	// RVA: 0x14A3094
	public string get_processors() { }

	// RVA: 0x14A309C
	public void set_processors(string value) { }

	// RVA: 0x14A30A4
	public string get_alias() { }

	// RVA: 0x14A30AC
	public void set_alias(string value) { }

	// RVA: 0x14A30B4
	public string[] get_aliases() { }

	// RVA: 0x14A30BC
	public void set_aliases(string[] value) { }

	// RVA: 0x14A30C4
	public string get_useStateFrom() { }

	// RVA: 0x14A30CC
	public void set_useStateFrom(string value) { }

	// RVA: 0x14A30D4
	public UInt32 get_bit() { }

	// RVA: 0x14A30DC
	public void set_bit(UInt32 value) { }

	// RVA: 0x14A30E4
	public UInt32 get_offset() { }

	// RVA: 0x14A30EC
	public void set_offset(UInt32 value) { }

	// RVA: 0x14A30F4
	public UInt32 get_sizeInBits() { }

	// RVA: 0x14A30FC
	public void set_sizeInBits(UInt32 value) { }

	// RVA: 0x14A3104
	public int get_arraySize() { }

	// RVA: 0x14A310C
	public void set_arraySize(int value) { }

	// RVA: 0x14A3114
	public string get_displayName() { }

	// RVA: 0x14A311C
	public void set_displayName(string value) { }

	// RVA: 0x14A3124
	public string get_shortDisplayName() { }

	// RVA: 0x14A312C
	public void set_shortDisplayName(string value) { }

	// RVA: 0x14A3134
	public bool get_noisy() { }

	// RVA: 0x14A313C
	public void set_noisy(bool value) { }

	// RVA: 0x14A3144
	public bool get_synthetic() { }

	// RVA: 0x14A314C
	public void set_synthetic(bool value) { }

	// RVA: 0x14A3154
	public bool get_dontReset() { }

	// RVA: 0x14A315C
	public void set_dontReset(bool value) { }

	// RVA: 0x14A3164
	public object get_defaultState() { }

	// RVA: 0x14A316C
	public void set_defaultState(object value) { }

	// RVA: 0x14A3174
	public object get_minValue() { }

	// RVA: 0x14A317C
	public void set_minValue(object value) { }

	// RVA: 0x14A3184
	public object get_maxValue() { }

	// RVA: 0x14A318C
	public void set_maxValue(object value) { }

	// RVA: 0x14A3194
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public sealed class InputDeviceFindControlLayoutDelegate
{
	// Methods

	// RVA: 0x14A31A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A3260
	public virtual string Invoke(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x14A3274
	public virtual IAsyncResult BeginInvoke(InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	// RVA: 0x14A3344
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

	// RVA: 0x14AA194
	public InternedString get_name() { }

	// RVA: 0x14AA1A0
	internal void set_name(InternedString value) { }

	// RVA: 0x14AA1AC
	public InternedString get_layout() { }

	// RVA: 0x14AA1B8
	internal void set_layout(InternedString value) { }

	// RVA: 0x14AA1C4
	public InternedString get_variants() { }

	// RVA: 0x14AA1D0
	internal void set_variants(InternedString value) { }

	// RVA: 0x14AA1DC
	public string get_useStateFrom() { }

	// RVA: 0x14AA1E4
	internal void set_useStateFrom(string value) { }

	// RVA: 0x14AA1EC
	public string get_displayName() { }

	// RVA: 0x14AA1F4
	internal void set_displayName(string value) { }

	// RVA: 0x14AA1FC
	public string get_shortDisplayName() { }

	// RVA: 0x14AA204
	internal void set_shortDisplayName(string value) { }

	// RVA: 0x14AA20C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x14AA218
	internal void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x14AA224
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x14AA230
	internal void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x14AA23C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x14AA248
	internal void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x14AA254
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors() { }

	// RVA: 0x14AA260
	internal void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value) { }

	// RVA: 0x14AA26C
	public UInt32 get_offset() { }

	// RVA: 0x14AA274
	internal void set_offset(UInt32 value) { }

	// RVA: 0x14AA27C
	public UInt32 get_bit() { }

	// RVA: 0x14AA284
	internal void set_bit(UInt32 value) { }

	// RVA: 0x14AA28C
	public UInt32 get_sizeInBits() { }

	// RVA: 0x14AA294
	internal void set_sizeInBits(UInt32 value) { }

	// RVA: 0x14AA29C
	public FourCC get_format() { }

	// RVA: 0x14AA2A4
	internal void set_format(FourCC value) { }

	// RVA: 0x14AA2AC
	private Flags get_flags() { }

	// RVA: 0x14AA2B4
	private void set_flags(Flags value) { }

	// RVA: 0x14AA2BC
	public int get_arraySize() { }

	// RVA: 0x14AA2C4
	internal void set_arraySize(int value) { }

	// RVA: 0x14AA2CC
	public PrimitiveValue get_defaultState() { }

	// RVA: 0x14AA2D8
	internal void set_defaultState(PrimitiveValue value) { }

	// RVA: 0x14AA2E0
	public PrimitiveValue get_minValue() { }

	// RVA: 0x14AA2EC
	internal void set_minValue(PrimitiveValue value) { }

	// RVA: 0x14AA2F4
	public PrimitiveValue get_maxValue() { }

	// RVA: 0x14AA300
	internal void set_maxValue(PrimitiveValue value) { }

	// RVA: 0x14AA308
	public bool get_isModifyingExistingControl() { }

	// RVA: 0x14A6D34
	internal void set_isModifyingExistingControl(bool value) { }

	// RVA: 0x14AA314
	public bool get_isNoisy() { }

	// RVA: 0x14A6D68
	internal void set_isNoisy(bool value) { }

	// RVA: 0x14AA320
	public bool get_isSynthetic() { }

	// RVA: 0x14A6DA8
	internal void set_isSynthetic(bool value) { }

	// RVA: 0x14AA32C
	public bool get_dontReset() { }

	// RVA: 0x14A6D88
	internal void set_dontReset(bool value) { }

	// RVA: 0x14AA338
	public bool get_isFirstDefinedInThisLayout() { }

	// RVA: 0x14A6D48
	internal void set_isFirstDefinedInThisLayout(bool value) { }

	// RVA: 0x14A423C
	public bool get_isArray() { }

	// RVA: 0x14A9748
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

	// RVA: 0x14AB3D4
	private static void .cctor() { }

	// RVA: 0x14AB440
	public void .ctor() { }

	// RVA: 0x14AB448
	internal InternedString <WithUsages>b__14_0(string x) { }

}

// Namespace: 
public struct ControlBuilder
{
	// Fields
	internal Builder builder; // 0x10
	internal int index; // 0x18

	// Methods

	// RVA: 0x14AA948
	public ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x14AA9A0
	public ControlBuilder WithLayout(string layout) { }

	// RVA: 0x14AAA94
	public ControlBuilder WithFormat(FourCC format) { }

	// RVA: 0x14AAAE0
	public ControlBuilder WithFormat(string format) { }

	// RVA: 0x14AAB50
	public ControlBuilder WithByteOffset(UInt32 offset) { }

	// RVA: 0x14AAB9C
	public ControlBuilder WithBitOffset(UInt32 bit) { }

	// RVA: 0x14AABE8
	public ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x14AAC4C
	public ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x14AACB0
	public ControlBuilder DontReset(bool value) { }

	// RVA: 0x14AAD14
	public ControlBuilder WithSizeInBits(UInt32 sizeInBits) { }

	// RVA: 0x14AAD60
	public ControlBuilder WithRange(float minValue, float maxValue) { }

	// RVA: 0x14AAE08
	public ControlBuilder WithUsages(InternedString[] usages) { }

	// RVA: 0x14AAFDC
	public ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<System.String> usages) { }

	// RVA: 0x14AB114
	public ControlBuilder WithUsages(string[] usages) { }

	// RVA: 0x14AB118
	public ControlBuilder WithParameters(string parameters) { }

	// RVA: 0x14AB1E4
	public ControlBuilder WithProcessors(string processors) { }

	// RVA: 0x14AB2CC
	public ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x14AB318
	public ControlBuilder UsingStateFrom(string path) { }

	// RVA: 0x14AB388
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

	// RVA: 0x14AA344
	public string get_name() { }

	// RVA: 0x14AA34C
	public void set_name(string value) { }

	// RVA: 0x14AA354
	public string get_displayName() { }

	// RVA: 0x14AA35C
	public void set_displayName(string value) { }

	// RVA: 0x14AA364
	public Type get_type() { }

	// RVA: 0x14AA36C
	public void set_type(Type value) { }

	// RVA: 0x14AA374
	public FourCC get_stateFormat() { }

	// RVA: 0x14AA37C
	public void set_stateFormat(FourCC value) { }

	// RVA: 0x14AA384
	public int get_stateSizeInBytes() { }

	// RVA: 0x14AA38C
	public void set_stateSizeInBytes(int value) { }

	// RVA: 0x14AA394
	public string get_extendsLayout() { }

	// RVA: 0x14AA39C
	public void set_extendsLayout(string value) { }

	// RVA: 0x14AA3D8
	public System.Nullable<System.Boolean> get_updateBeforeRender() { }

	// RVA: 0x14AA3E0
	public void set_updateBeforeRender(System.Nullable<System.Boolean> value) { }

	// RVA: 0x14AA3E8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x14AA45C
	public ControlBuilder AddControl(string name) { }

	// RVA: 0x14AA5F4
	public Builder WithName(string name) { }

	// RVA: 0x14AA61C
	public Builder WithDisplayName(string displayName) { }

	// RVA: 0x30D3CF0
	public Builder WithType() { }

	// RVA: 0x14AA644
	public Builder WithFormat(FourCC format) { }

	// RVA: 0x14AA64C
	public Builder WithFormat(string format) { }

	// RVA: 0x14AA68C
	public Builder WithSizeInBytes(int sizeInBytes) { }

	// RVA: 0x14AA694
	public Builder Extend(string baseLayoutName) { }

	// RVA: 0x14AA6D8
	public InputControlLayout Build() { }

	// RVA: 0x14AA940
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

	// RVA: 0x14AC2C4
	private static void .cctor() { }

	// RVA: 0x14AC330
	public void .ctor() { }

	// RVA: 0x14AC338
	internal InternedString <ToLayout>b__14_0(string x) { }

	// RVA: 0x14AC364
	internal string <FromLayout>b__15_0(InternedString x) { }

	// RVA: 0x14AC38C
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

	// RVA: 0x14A4F24
	public InputControlLayout ToLayout() { }

	// RVA: 0x14A4A20
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

	// RVA: 0x14AC3E0
	private static void .cctor() { }

	// RVA: 0x14AC44C
	public void .ctor() { }

	// RVA: 0x14AC454
	internal InternedString <ToLayout>b__24_0(string x) { }

	// RVA: 0x14AC480
	internal InternedString <ToLayout>b__24_1(string x) { }

	// RVA: 0x14AC4AC
	internal string <FromControlItems>b__25_0(NamedValue x) { }

	// RVA: 0x14AC4B8
	internal string <FromControlItems>b__25_1(NameAndParameters x) { }

	// RVA: 0x14AC4C4
	internal string <FromControlItems>b__25_2(InternedString x) { }

	// RVA: 0x14AC4EC
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

	// RVA: 0x14AC3B4
	public void .ctor() { }

	// RVA: 0x14AB474
	public ControlItem ToLayout() { }

	// RVA: 0x14ABB50
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

	// RVA: 0x14ADAB8
	public void .ctor(int <>1__state) { }

	// RVA: 0x14ADD10
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14ADD14
	private bool MoveNext() { }

	// RVA: 0x14ADE1C
	private InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current() { }

	// RVA: 0x14ADE28
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x14ADE68
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x14ADED0
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator() { }

	// RVA: 0x14ADFA0
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

	// RVA: 0x14AC514
	public void Allocate() { }

	// RVA: 0x14A6DC8
	public InternedString TryFindLayoutForType(Type layoutType) { }

	// RVA: 0x14AC7C0
	public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x14A712C
	public bool HasLayout(InternedString name) { }

	// RVA: 0x14AC9B0
	private InputControlLayout TryLoadLayoutInternal(InternedString name) { }

	// RVA: 0x14ACC58
	public InputControlLayout TryLoadLayout(InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table) { }

	// RVA: 0x14AD0CC
	public InternedString GetBaseLayoutName(InternedString layoutName) { }

	// RVA: 0x14AD15C
	public InternedString GetRootLayoutName(InternedString layoutName) { }

	// RVA: 0x14AD1F4
	public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, int distance) { }

	// RVA: 0x14AD3E0
	public InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache) { }

	// RVA: 0x14AD6DC
	public Type GetControlTypeForLayout(InternedString layoutName) { }

	// RVA: 0x14AD840
	public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType) { }

	// RVA: 0x14AD980
	public bool IsGeneratedLayout(InternedString layout) { }

	// RVA: 0x14AD9F8
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(InternedString layout, bool includeSelf) { }

	// RVA: 0x14ADAF0
	public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) { }

	// RVA: 0x14ADBA8
	public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) { }

}

// Namespace: 
public class LayoutNotFoundException
{
	// Fields
	private readonly string <layout>k__BackingField; // 0x90

	// Methods

	// RVA: 0x14ADFA4
	public string get_layout() { }

	// RVA: 0x14ADFAC
	public void .ctor() { }

	// RVA: 0x14AE034
	public void .ctor(string name, string message) { }

	// RVA: 0x14AD008
	public void .ctor(string name) { }

	// RVA: 0x14AE0BC
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x14AE138
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
internal struct Cache
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table; // 0x10

	// Methods

	// RVA: 0x14AE1BC
	public void Clear() { }

	// RVA: 0x14AD598
	public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound) { }

}

// Namespace: 
internal struct CacheRefInstance
{
	// Fields
	public bool valid; // 0x10

	// Methods

	// RVA: 0x14AE1C8
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

	// RVA: 0x14AE280
	private static void .cctor() { }

	// RVA: 0x14AE2EC
	public void .ctor() { }

	// RVA: 0x14AE2F4
	internal InternedString <FromType>b__52_0(string x) { }

	// RVA: 0x14AE320
	internal InternedString <CreateControlItemFromMember>b__75_0(string x) { }

	// RVA: 0x14AE34C
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

	// RVA: 0x14A3398
	public static InternedString get_DefaultVariant() { }

	// RVA: 0x14A3414
	public InternedString get_name() { }

	// RVA: 0x14A3420
	public string get_displayName() { }

	// RVA: 0x14A3440
	public Type get_type() { }

	// RVA: 0x14A3448
	public InternedString get_variants() { }

	// RVA: 0x14A3454
	public FourCC get_stateFormat() { }

	// RVA: 0x14A345C
	public int get_stateSizeInBytes() { }

	// RVA: 0x14A3464
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts() { }

	// RVA: 0x14A34D0
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides() { }

	// RVA: 0x14A353C
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages() { }

	// RVA: 0x14A35A8
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x14A3614
	public bool get_updateBeforeRender() { }

	// RVA: 0x14A36EC
	public bool get_isDeviceLayout() { }

	// RVA: 0x14A37A4
	public bool get_isControlLayout() { }

	// RVA: 0x14A3864
	public bool get_isOverride() { }

	// RVA: 0x14A3870
	internal void set_isOverride(bool value) { }

	// RVA: 0x14A3890
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x14A389C
	internal void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x14A38B0
	public bool get_hideInUI() { }

	// RVA: 0x14A38BC
	internal void set_hideInUI(bool value) { }

	// RVA: 0x14A38DC
	public bool get_isNoisy() { }

	// RVA: 0x14A38E8
	internal void set_isNoisy(bool value) { }

	// RVA: 0x14A3908
	public System.Nullable<System.Boolean> get_canRunInBackground() { }

	// RVA: 0x14A3990
	internal void set_canRunInBackground(System.Nullable<System.Boolean> value) { }

	// RVA: 0x14A3A84
	public ControlItem get_Item(string path) { }

	// RVA: 0x14A3C2C
	public System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(InternedString path) { }

	// RVA: 0x14A3E34
	public System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, int arrayIndex) { }

	// RVA: 0x14A424C
	public Type GetValueType() { }

	// RVA: 0x14A42E0
	public static InputControlLayout FromType(string name, Type type) { }

	// RVA: 0x14A49A8
	public string ToJson() { }

	// RVA: 0x14A4E80
	public static InputControlLayout FromJson(string json) { }

	// RVA: 0x14A4934
	private void .ctor(string name, Type type) { }

	// RVA: 0x14A47F0
	private static void AddControlItems(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x14A5944
	private static void AddControlItemsFromFields(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x14A59D8
	private static void AddControlItemsFromProperties(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x14A5A6C
	private static void AddControlItemsFromMembers(MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName) { }

	// RVA: 0x14A6004
	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems) { }

	// RVA: 0x14A6238
	private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	// RVA: 0x14A6B68
	private static string InferLayoutFromValueType(Type type) { }

	// RVA: 0x14A7234
	public void MergeLayout(InputControlLayout other) { }

	// RVA: 0x14A9288
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, System.Collections.Generic.List<System.String> variants) { }

	// RVA: 0x14A9D04
	internal static bool VariantsMatch(InternedString expected, InternedString actual) { }

	// RVA: 0x14A9BB4
	internal static bool VariantsMatch(string expected, string actual) { }

	// RVA: 0x14A9D90
	internal static void ParseHeaderFieldsFromJson(string json, InternedString name, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>& baseLayouts, InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x14A9F34
	internal static Cache get_cache() { }

	// RVA: 0x14A9FB0
	internal static CacheRefInstance CacheRef() { }

	// RVA: 0x14AA018
	private static void .cctor() { }

	// RVA: 0x14AA0B0
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

	// RVA: 0x14AE378
	public Type get_stateType() { }

	// RVA: 0x14AE380
	public void set_stateType(Type value) { }

	// RVA: 0x14AE388
	public string get_stateFormat() { }

	// RVA: 0x14AE390
	public void set_stateFormat(string value) { }

	// RVA: 0x14AE398
	public string[] get_commonUsages() { }

	// RVA: 0x14AE3A0
	public void set_commonUsages(string[] value) { }

	// RVA: 0x14AE3A8
	public string get_variants() { }

	// RVA: 0x14AE3B0
	public void set_variants(string value) { }

	// RVA: 0x14AE3B8
	public bool get_isNoisy() { }

	// RVA: 0x14AE3C0
	public void set_isNoisy(bool value) { }

	// RVA: 0x14AE3C8
	public bool get_canRunInBackground() { }

	// RVA: 0x14AE430
	public void set_canRunInBackground(bool value) { }

	// RVA: 0x14AE4A8
	public bool get_updateBeforeRender() { }

	// RVA: 0x14AE510
	public void set_updateBeforeRender(bool value) { }

	// RVA: 0x14AE588
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x14AE590
	public void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x14AE598
	public string get_displayName() { }

	// RVA: 0x14AE5A0
	public void set_displayName(string value) { }

	// RVA: 0x14AE5A8
	public string get_description() { }

	// RVA: 0x14AE5B0
	public void set_description(string value) { }

	// RVA: 0x14AE5B8
	public bool get_hideInUI() { }

	// RVA: 0x14AE5C0
	public void set_hideInUI(bool value) { }

	// RVA: 0x14AE5C8
	public void .ctor() { }

}

// Namespace: 
internal struct RefInstance
{
	// Methods

	// RVA: 0x13BEEB0
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

	// RVA: 0x14AE5D0
	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription) { }

	// RVA: 0x14AEB54
	public InputDevice Finish() { }

	// RVA: 0x14AEE60
	public void Dispose() { }

	// RVA: 0x14AED90
	private void Reset() { }

	// RVA: 0x14AE794
	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x14AEFE0
	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x14AF8C4
	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls) { }

	// RVA: 0x14B0E54
	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem, int childIndex, string nameOverride) { }

	// RVA: 0x14B0B94
	private void InsertChildControlOverride(InputControl parent, ControlItem controlItem) { }

	// RVA: 0x14B187C
	private string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	// RVA: 0x14B17C0
	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem) { }

	// RVA: 0x14B1C24
	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem) { }

	// RVA: 0x14B0998
	private static void ApplyUseStateFrom(InputControl parent, ControlItem controlItem, InputControlLayout layout) { }

	// RVA: 0x14B1FA0
	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

	// RVA: 0x14B200C
	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	// RVA: 0x14B2274
	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	// RVA: 0x14B19F4
	private static void AddProcessors(InputControl control, ControlItem controlItem, string layoutName) { }

	// RVA: 0x14B1910
	private static void SetFormat(InputControl control, ControlItem controlItem) { }

	// RVA: 0x14AEF18
	private static InputControlLayout FindOrLoadLayout(string name) { }

	// RVA: 0x14B0040
	private static void ComputeStateLayout(InputControl control) { }

	// RVA: 0x14AE8BC
	private void FinalizeControlHierarchy() { }

	// RVA: 0x14B2330
	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, int controlIndiciesNextFreeIndex) { }

	// RVA: 0x14B2818
	private void InsertControlBitRangeNode(ControlBitRangeNode parent, InputControl control, int controlIndiciesNextFreeIndex, UInt16 startOffset) { }

	// RVA: 0x14B2DA8
	private UInt16 GetBestMidPoint(ControlBitRangeNode parent, UInt16 startOffset) { }

	// RVA: 0x14B3808
	private void AddControlToNode(InputControl control, int controlIndiciesNextFreeIndex, int nodeIndex) { }

	// RVA: 0x14B36E4
	private void AddChildren(ControlBitRangeNode parent, ControlBitRangeNode left, ControlBitRangeNode right) { }

	// RVA: 0x14B3950
	private UInt16 GetControlIndex(InputControl control) { }

	// RVA: 0x14B3A04
	internal static InputDeviceBuilder get_instance() { }

	// RVA: 0x14B3A4C
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

	// RVA: 0x13BEF44
	public string get_interfaceName() { }

	// RVA: 0x13BEF4C
	public void set_interfaceName(string value) { }

	// RVA: 0x13BEF54
	public string get_deviceClass() { }

	// RVA: 0x13BEF5C
	public void set_deviceClass(string value) { }

	// RVA: 0x13BEF64
	public string get_manufacturer() { }

	// RVA: 0x13BEF6C
	public void set_manufacturer(string value) { }

	// RVA: 0x13BEF74
	public string get_product() { }

	// RVA: 0x13BEF7C
	public void set_product(string value) { }

	// RVA: 0x13BEF84
	public string get_serial() { }

	// RVA: 0x13BEF8C
	public void set_serial(string value) { }

	// RVA: 0x13BEF94
	public string get_version() { }

	// RVA: 0x13BEF9C
	public void set_version(string value) { }

	// RVA: 0x13BEFA4
	public string get_capabilities() { }

	// RVA: 0x13BEFAC
	public void set_capabilities(string value) { }

	// RVA: 0x13BEFB4
	public bool get_empty() { }

	// RVA: 0x13BF048
	public override string ToString() { }

	// RVA: 0x13BF300
	public bool Equals(InputDeviceDescription other) { }

	// RVA: 0x13BF3B4
	public override bool Equals(object obj) { }

	// RVA: 0x13BF464
	public override int GetHashCode() { }

	// RVA: 0x13BF5BC
	public static bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x13BF5F4
	public static bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x13BF630
	public string ToJson() { }

	// RVA: 0x13BF73C
	public static InputDeviceDescription FromJson(string json) { }

	// RVA: 0x13BF8B4
	internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonString propertyValue, string deviceDescriptor) { }

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
	public string manufacturerContains; // 0x38
	public string[] manufacturers; // 0x40
	public string product; // 0x48
	public string[] products; // 0x50
	public string version; // 0x58
	public string[] versions; // 0x60
	public Capability[] capabilities; // 0x68

	// Methods

	// RVA: 0x13C20D4
	public static MatcherJson FromMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x13C2658
	public InputDeviceMatcher ToMatcher() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputDeviceMatcher.<>c <>9; // 0x0
	public static System.Func<System.Char,System.Boolean> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x13C2E20
	private static void .cctor() { }

	// RVA: 0x13C2E8C
	public void .ctor() { }

	// RVA: 0x13C2E94
	internal bool <With>b__12_0(Char ch) { }

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

	// RVA: 0x13C01FC
	public void .ctor(int <>1__state) { }

	// RVA: 0x13C2F60
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C2F64
	private bool MoveNext() { }

	// RVA: 0x13C3204
	private System.Collections.Generic.KeyValuePair<System.String,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	// RVA: 0x13C3210
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13C3250
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13C32B8
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x13C3364
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
	private static readonly InternedString kManufacturerContainsKey; // 0x30
	private static readonly InternedString kProductKey; // 0x40
	private static readonly InternedString kVersionKey; // 0x50

	// Methods

	// RVA: 0x13C0160
	public bool get_empty() { }

	// RVA: 0x13C0170
	public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> get_patterns() { }

	// RVA: 0x13C0234
	public InputDeviceMatcher WithInterface(string pattern, bool supportRegex) { }

	// RVA: 0x13C04D8
	public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex) { }

	// RVA: 0x13C055C
	public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex) { }

	// RVA: 0x13C05E0
	public InputDeviceMatcher WithManufacturerContains(string noRegExPattern) { }

	// RVA: 0x13C0658
	public InputDeviceMatcher WithProduct(string pattern, bool supportRegex) { }

	// RVA: 0x13C06DC
	public InputDeviceMatcher WithVersion(string pattern, bool supportRegex) { }

	// RVA: 0x318DB98
	public InputDeviceMatcher WithCapability(string path, TValue value) { }

	// RVA: 0x13C02B8
	private InputDeviceMatcher With(InternedString key, object value, bool supportRegex) { }

	// RVA: 0x13C0760
	public float MatchPercentage(InputDeviceDescription deviceDescription) { }

	// RVA: 0x13C0E68
	private static bool MatchSingleProperty(object pattern, string value) { }

	// RVA: 0x13C0F54
	private static bool MatchSinglePropertyContains(object pattern, string value) { }

	// RVA: 0x13C1050
	private static int GetNumPropertiesIn(InputDeviceDescription description) { }

	// RVA: 0x13C10F8
	public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	// RVA: 0x13C1488
	public override string ToString() { }

	// RVA: 0x13C185C
	public bool Equals(InputDeviceMatcher other) { }

	// RVA: 0x13C1BD8
	public override bool Equals(object obj) { }

	// RVA: 0x13C1C8C
	public static bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x13C1D00
	public static bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x13C1DD8
	public override int GetHashCode() { }

	// RVA: 0x13C1DF0
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class AnyKeyControl
{
	// Methods

	// RVA: 0x13C3368
	public void .ctor() { }

	// RVA: 0x13C3504
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

	// RVA: 0x13C3530
	protected float Preprocess(float value) { }

	// RVA: 0x13C3600
	private float Unpreprocess(float value) { }

	// RVA: 0x13C3658
	public void .ctor() { }

	// RVA: 0x13C36E4
	protected override void FinishSetup() { }

	// RVA: 0x13C37D4
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C396C
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x13C3AB0
	public override bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x13C3C54
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x13C3CCC
	private float EvaluateMagnitude(float value) { }

	// RVA: 0x13C3FA4
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class ButtonControl
{
	// Fields
	private bool m_NeedsToCheckFramePress; // 0x12C
	private UInt32 m_UpdateCountLastPressed; // 0x130
	private UInt32 m_UpdateCountLastReleased; // 0x134
	private bool m_LastUpdateWasPress; // 0x138
	private bool <needsToCheckFramePress>k__BackingField; // 0x139
	public float pressPoint; // 0x13C
	internal static float s_GlobalDefaultButtonPressPoint; // 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x4
	internal const float kMinButtonPressPoint = 0.0001;

	// Methods

	// RVA: 0x13C4120
	internal bool get_needsToCheckFramePress() { }

	// RVA: 0x13C4128
	private void set_needsToCheckFramePress(bool value) { }

	// RVA: 0x13C4130
	public float get_pressPointOrDefault() { }

	// RVA: 0x13C33E4
	public void .ctor() { }

	// RVA: 0x13C41B8
	public bool IsValueConsideredPressed(float value) { }

	// RVA: 0x13C424C
	public bool get_isPressed() { }

	// RVA: 0x13C4314
	private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) { }

	// RVA: 0x13C43D4
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x13C456C
	public bool get_wasReleasedThisFrame() { }

	// RVA: 0x13C4704
	internal void UpdateWasPressed() { }

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

	// RVA: 0x13C4834
	public AxisControl get_up() { }

	// RVA: 0x13C483C
	public void set_up(AxisControl value) { }

	// RVA: 0x13C484C
	public AxisControl get_down() { }

	// RVA: 0x13C4854
	public void set_down(AxisControl value) { }

	// RVA: 0x13C4864
	public AxisControl get_left() { }

	// RVA: 0x13C486C
	public void set_left(AxisControl value) { }

	// RVA: 0x13C487C
	public AxisControl get_right() { }

	// RVA: 0x13C4884
	public void set_right(AxisControl value) { }

	// RVA: 0x13C4894
	protected override void FinishSetup() { }

	// RVA: 0x13C4A9C
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
	public int minValue; // 0x140
	public int maxValue; // 0x144
	public int wrapAtValue; // 0x148
	public int nullValue; // 0x14C
	public WriteMode writeMode; // 0x150

	// Methods

	// RVA: 0x13C4BB4
	protected override void FinishSetup() { }

	// RVA: 0x13C4CE4
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C4E7C
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x13C4FDC
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class DoubleControl
{
	// Methods

	// RVA: 0x13C4FE0
	public void .ctor() { }

	// RVA: 0x13C506C
	public override Double ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C50D8
	public override void WriteValueIntoState(Double value, Void* statePtr) { }

}

// Namespace: 
public class DpadAxisControl
{
	// Fields
	private int <component>k__BackingField; // 0x12C

	// Methods

	// RVA: 0x13C58C0
	public int get_component() { }

	// RVA: 0x13C58C8
	public void set_component(int value) { }

	// RVA: 0x13C58D0
	protected override void FinishSetup() { }

	// RVA: 0x13C595C
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C5A54
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

	// RVA: 0x13C5154
	public ButtonControl get_up() { }

	// RVA: 0x13C515C
	public void set_up(ButtonControl value) { }

	// RVA: 0x13C516C
	public ButtonControl get_down() { }

	// RVA: 0x13C5174
	public void set_down(ButtonControl value) { }

	// RVA: 0x13C5184
	public ButtonControl get_left() { }

	// RVA: 0x13C518C
	public void set_left(ButtonControl value) { }

	// RVA: 0x13C519C
	public ButtonControl get_right() { }

	// RVA: 0x13C51A4
	public void set_right(ButtonControl value) { }

	// RVA: 0x13C51B4
	public void .ctor() { }

	// RVA: 0x13C52B4
	protected override void FinishSetup() { }

	// RVA: 0x13C53E4
	public override Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C56E8
	public override void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x13C5688
	public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize) { }

	// RVA: 0x13C58B0
	public static Vector2 MakeDpadVector(float up, float down, float left, float right) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class IntegerControl
{
	// Methods

	// RVA: 0x13C5AE0
	public void .ctor() { }

	// RVA: 0x13C5B6C
	public override int ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C5C30
	public override void WriteValueIntoState(int value, Void* statePtr) { }

	// RVA: 0x13C5CFC
	protected override FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class KeyControl
{
	// Fields
	private Key <keyCode>k__BackingField; // 0x140
	private int m_ScanCode; // 0x144

	// Methods

	// RVA: 0x13C5E20
	public Key get_keyCode() { }

	// RVA: 0x13C5E28
	public void set_keyCode(Key value) { }

	// RVA: 0x13C5E30
	public int get_scanCode() { }

	// RVA: 0x13C5E58
	protected override void RefreshConfiguration() { }

	// RVA: 0x13C5FE4
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

	// RVA: 0x13C5FE8
	public AxisControl get_x() { }

	// RVA: 0x13C5FF0
	public void set_x(AxisControl value) { }

	// RVA: 0x13C6000
	public AxisControl get_y() { }

	// RVA: 0x13C6008
	public void set_y(AxisControl value) { }

	// RVA: 0x13C6018
	public AxisControl get_z() { }

	// RVA: 0x13C6020
	public void set_z(AxisControl value) { }

	// RVA: 0x13C6030
	public AxisControl get_w() { }

	// RVA: 0x13C6038
	public void set_w(AxisControl value) { }

	// RVA: 0x13C6048
	public void .ctor() { }

	// RVA: 0x13C60DC
	protected override void FinishSetup() { }

	// RVA: 0x13C6224
	public override Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C636C
	public override void WriteValueIntoState(Quaternion value, Void* statePtr) { }

	// RVA: 0x13C64A8
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

	// RVA: 0x13C6730
	public ButtonControl get_up() { }

	// RVA: 0x13C6738
	public void set_up(ButtonControl value) { }

	// RVA: 0x13C6748
	public ButtonControl get_down() { }

	// RVA: 0x13C6750
	public void set_down(ButtonControl value) { }

	// RVA: 0x13C6760
	public ButtonControl get_left() { }

	// RVA: 0x13C6768
	public void set_left(ButtonControl value) { }

	// RVA: 0x13C6778
	public ButtonControl get_right() { }

	// RVA: 0x13C6780
	public void set_right(ButtonControl value) { }

	// RVA: 0x13C6790
	protected override void FinishSetup() { }

	// RVA: 0x13C68C0
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

	// RVA: 0x13C694C
	public TouchPressControl get_press() { }

	// RVA: 0x13C6954
	public void set_press(TouchPressControl value) { }

	// RVA: 0x13C6964
	public IntegerControl get_displayIndex() { }

	// RVA: 0x13C696C
	public void set_displayIndex(IntegerControl value) { }

	// RVA: 0x13C697C
	public IntegerControl get_touchId() { }

	// RVA: 0x13C6984
	public void set_touchId(IntegerControl value) { }

	// RVA: 0x13C6994
	public Vector2Control get_position() { }

	// RVA: 0x13C699C
	public void set_position(Vector2Control value) { }

	// RVA: 0x13C69AC
	public DeltaControl get_delta() { }

	// RVA: 0x13C69B4
	public void set_delta(DeltaControl value) { }

	// RVA: 0x13C69C4
	public AxisControl get_pressure() { }

	// RVA: 0x13C69CC
	public void set_pressure(AxisControl value) { }

	// RVA: 0x13C69DC
	public Vector2Control get_radius() { }

	// RVA: 0x13C69E4
	public void set_radius(Vector2Control value) { }

	// RVA: 0x13C69F4
	public TouchPhaseControl get_phase() { }

	// RVA: 0x13C69FC
	public void set_phase(TouchPhaseControl value) { }

	// RVA: 0x13C6A0C
	public ButtonControl get_indirectTouch() { }

	// RVA: 0x13C6A14
	public void set_indirectTouch(ButtonControl value) { }

	// RVA: 0x13C6A24
	public ButtonControl get_tap() { }

	// RVA: 0x13C6A2C
	public void set_tap(ButtonControl value) { }

	// RVA: 0x13C6A3C
	public IntegerControl get_tapCount() { }

	// RVA: 0x13C6A44
	public void set_tapCount(IntegerControl value) { }

	// RVA: 0x13C6A54
	public DoubleControl get_startTime() { }

	// RVA: 0x13C6A5C
	public void set_startTime(DoubleControl value) { }

	// RVA: 0x13C6A6C
	public Vector2Control get_startPosition() { }

	// RVA: 0x13C6A74
	public void set_startPosition(Vector2Control value) { }

	// RVA: 0x13C6A84
	public bool get_isInProgress() { }

	// RVA: 0x13C6AF0
	public void .ctor() { }

	// RVA: 0x13C6B90
	protected override void FinishSetup() { }

	// RVA: 0x13C6F40
	public override TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C6FCC
	public override void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPhaseControl
{
	// Methods

	// RVA: 0x13C70A4
	public void .ctor() { }

	// RVA: 0x13C7130
	public override TouchPhase ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C71B0
	public override void WriteValueIntoState(TouchPhase value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPressControl
{
	// Methods

	// RVA: 0x13C7224
	protected override void FinishSetup() { }

	// RVA: 0x13C7354
	public override float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C7670
	public override void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x13C76B0
	public void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class Vector2Control
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x110
	private AxisControl <y>k__BackingField; // 0x118

	// Methods

	// RVA: 0x13C76B4
	public AxisControl get_x() { }

	// RVA: 0x13C76BC
	public void set_x(AxisControl value) { }

	// RVA: 0x13C76CC
	public AxisControl get_y() { }

	// RVA: 0x13C76D4
	public void set_y(AxisControl value) { }

	// RVA: 0x13C4B28
	public void .ctor() { }

	// RVA: 0x13C49C4
	protected override void FinishSetup() { }

	// RVA: 0x13C76E4
	public override Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C77CC
	public override void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x13C78B0
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x13C7988
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

	// RVA: 0x13C7B40
	public AxisControl get_x() { }

	// RVA: 0x13C7B48
	public void set_x(AxisControl value) { }

	// RVA: 0x13C7B58
	public AxisControl get_y() { }

	// RVA: 0x13C7B60
	public void set_y(AxisControl value) { }

	// RVA: 0x13C7B70
	public AxisControl get_z() { }

	// RVA: 0x13C7B78
	public void set_z(AxisControl value) { }

	// RVA: 0x13C7B88
	public void .ctor() { }

	// RVA: 0x13C7C14
	protected override void FinishSetup() { }

	// RVA: 0x13C7D28
	public override Vector3 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x13C7E34
	public override void WriteValueIntoState(Vector3 value, Void* statePtr) { }

	// RVA: 0x13C7F4C
	public override float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x13C8038
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

	// RVA: 0x13C8238
	private float get_durationOrDefault() { }

	// RVA: 0x13C82AC
	private float get_pressPointOrDefault() { }

	// RVA: 0x13C8320
	public void Process(InputInteractionContext context) { }

	// RVA: 0x13C85C8
	public void Reset() { }

	// RVA: 0x13C85D0
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

	// RVA: 0x13C85D8
	private float get_tapTimeOrDefault() { }

	// RVA: 0x13C864C
	internal float get_tapDelayOrDefault() { }

	// RVA: 0x13C86C0
	private float get_pressPointOrDefault() { }

	// RVA: 0x13C8734
	private float get_releasePointOrDefault() { }

	// RVA: 0x13C87FC
	public void Process(InputInteractionContext context) { }

	// RVA: 0x13C8CA8
	public void Reset() { }

	// RVA: 0x13C8CB4
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

	// RVA: 0x13C8CC4
	private float get_pressPointOrDefault() { }

	// RVA: 0x13C8D38
	private float get_releasePointOrDefault() { }

	// RVA: 0x13C8E00
	public void Process(InputInteractionContext context) { }

	// RVA: 0x13C938C
	public void Reset() { }

	// RVA: 0x13C9394
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

	// RVA: 0x13C939C
	private float get_durationOrDefault() { }

	// RVA: 0x13C9410
	private float get_pressPointOrDefault() { }

	// RVA: 0x13C9484
	public void Process(InputInteractionContext context) { }

	// RVA: 0x13C9684
	public void Reset() { }

	// RVA: 0x13C968C
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

	// RVA: 0x13C9694
	private float get_durationOrDefault() { }

	// RVA: 0x13C9708
	private float get_pressPointOrDefault() { }

	// RVA: 0x13C977C
	private float get_releasePointOrDefault() { }

	// RVA: 0x13C9844
	public void Process(InputInteractionContext context) { }

	// RVA: 0x13C9B14
	public void Reset() { }

	// RVA: 0x13C9B1C
	public void .ctor() { }

}

// Namespace: 
public struct ActionEventPtr
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal ActionEvent* m_Ptr; // 0x18

	// Methods

	// RVA: 0x13CB578
	public InputAction get_action() { }

	// RVA: 0x13CB5A4
	public InputActionPhase get_phase() { }

	// RVA: 0x13CB5B0
	public InputControl get_control() { }

	// RVA: 0x13CB5F4
	public IInputInteraction get_interaction() { }

	// RVA: 0x13CB660
	public Double get_time() { }

	// RVA: 0x13CB680
	public Double get_startTime() { }

	// RVA: 0x13CB68C
	public Double get_duration() { }

	// RVA: 0x13CB6C8
	public int get_valueSizeInBytes() { }

	// RVA: 0x13CB6D4
	public object ReadValueAsObject() { }

	// RVA: 0x13CB930
	public void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x318DB98
	public TValue ReadValue() { }

	// RVA: 0x13CACC4
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

	// RVA: 0x13CB10C
	public void .ctor(InputActionTrace trace) { }

	// RVA: 0x13CBA3C
	public bool MoveNext() { }

	// RVA: 0x13CBACC
	public void Reset() { }

	// RVA: 0x13CBAD8
	public void Dispose() { }

	// RVA: 0x13CBADC
	public ActionEventPtr get_Current() { }

	// RVA: 0x13CBB64
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

	// RVA: 0x13C9B24
	public InputEventBuffer get_buffer() { }

	// RVA: 0x13C9B34
	public int get_count() { }

	// RVA: 0x13C9B3C
	public void .ctor() { }

	// RVA: 0x13C9B44
	public void .ctor(InputAction action) { }

	// RVA: 0x13C9D04
	public void .ctor(InputActionMap actionMap) { }

	// RVA: 0x13C9EA4
	public void SubscribeToAll() { }

	// RVA: 0x13CA2D0
	public void UnsubscribeFromAll() { }

	// RVA: 0x13C9BC0
	public void SubscribeTo(InputAction action) { }

	// RVA: 0x13C9D80
	public void SubscribeTo(InputActionMap actionMap) { }

	// RVA: 0x13CA0A8
	public void UnsubscribeFrom(InputAction action) { }

	// RVA: 0x13CA1CC
	public void UnsubscribeFrom(InputActionMap actionMap) { }

	// RVA: 0x13CA480
	public void RecordAction(CallbackContext context) { }

	// RVA: 0x13CA650
	public void Clear() { }

	// RVA: 0x13CA6B0
	protected override void Finalize() { }

	// RVA: 0x13CA860
	public override string ToString() { }

	// RVA: 0x13CB0E8
	public void Dispose() { }

	// RVA: 0x13CA740
	private void DisposeInternal() { }

	// RVA: 0x13CAC18
	public System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator() { }

	// RVA: 0x13CB15C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13C9F9C
	private void HookOnActionChange() { }

	// RVA: 0x13CA410
	private void UnhookOnActionChange() { }

	// RVA: 0x13CB208
	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	// RVA: 0x13CB484
	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0<T0>
{
	// Fields
	public TValue secondValue; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal bool <Merge>b__0(TValue x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0<T0>
{
	// Fields
	public System.Collections.Generic.IEqualityComparer<TValue> comparer; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1<T0>
{
	// Fields
	public TValue secondValue; // 0x0
	public UnityEngine.InputSystem.Utilities.ArrayHelpers.<>c__DisplayClass34_0<TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal bool <Merge>b__0(TValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ArrayHelpers
{
	// Methods

	// RVA: 0x30D689C
	public static int LengthSafe(TValue[] array) { }

	// RVA: 0x30DA164
	public static void Clear(TValue[] array) { }

	// RVA: 0x30DA46C
	public static void Clear(TValue[] array, int count) { }

	// RVA: 0x30DB358
	public static void Clear(TValue[] array, int count) { }

	// RVA: -1
	public static void EnsureCapacity(TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: -1
	public static void DuplicateWithCapacity(TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: 0x318DB98
	public static bool Contains(TValue[] array, TValue value) { }

	// RVA: 0x318DB98
	public static bool ContainsReference(TValue[] array, TValue value) { }

	// RVA: 0x318DB98
	public static bool ContainsReference(TFirst[] array, int count, TSecond value) { }

	// RVA: 0x318DB98
	public static bool ContainsReference(TFirst[] array, int startIndex, int count, TSecond value) { }

	// RVA: -1
	public static bool HaveDuplicateReferences(TFirst[] first, int index, int count) { }

	// RVA: 0x30D6190
	public static bool HaveEqualElements(TValue[] first, TValue[] second, int count) { }

	// RVA: 0x318DB98
	public static int IndexOf(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x30D6D88
	public static int IndexOf(TValue[] array, System.Predicate<TValue> predicate) { }

	// RVA: 0x30D6DF0
	public static int IndexOf(TValue[] array, System.Predicate<TValue> predicate, int startIndex, int count) { }

	// RVA: 0x318DB98
	public static int IndexOfReference(TFirst[] array, TSecond value, int count) { }

	// RVA: 0x318DB98
	public static int IndexOfReference(TFirst[] array, TSecond value, int startIndex, int count) { }

	// RVA: 0x318DB98
	public static int IndexOfValue(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x30DA554
	public static void Resize(Unity.Collections.NativeArray<TValue>& array, int newSize, Allocator allocator) { }

	// RVA: 0x318DB98
	public static int Append(TValue[] array, TValue value) { }

	// RVA: 0x30D6D88
	public static int Append(TValue[] array, System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x30D6D88
	public static int AppendToImmutable(TValue[] array, TValue[] values) { }

	// RVA: 0x318DB98
	public static int AppendWithCapacity(TValue[] array, int count, TValue value, int capacityIncrement) { }

	// RVA: 0x318DB98
	public static int AppendListWithCapacity(TValue[] array, int length, TValues values, int capacityIncrement) { }

	// RVA: 0x318DB98
	public static int AppendWithCapacity(Unity.Collections.NativeArray<TValue>& array, int count, TValue value, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x318DB98
	public static void InsertAt(TValue[] array, int index, TValue value) { }

	// RVA: 0x318DB98
	public static void InsertAtWithCapacity(TValue[] array, int count, int index, TValue value, int capacityIncrement) { }

	// RVA: 0x30DA8B0
	public static void PutAtIfNotSet(TValue[] array, int index, System.Func<TValue> valueFn) { }

	// RVA: -1
	public static int GrowBy(TValue[] array, int count) { }

	// RVA: 0x30D6900
	public static int GrowBy(Unity.Collections.NativeArray<TValue>& array, int count, Allocator allocator) { }

	// RVA: 0x30D6DF0
	public static int GrowWithCapacity(TValue[] array, int count, int growBy, int capacityIncrement) { }

	// RVA: -1
	public static int GrowWithCapacity(Unity.Collections.NativeArray<TValue>& array, int count, int growBy, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x318DB98
	public static TValue[] Join(TValue value, TValue[] values) { }

	// RVA: 0x30D78C4
	public static TValue[] Merge(TValue[] first, TValue[] second) { }

	// RVA: 0x30D7A20
	public static TValue[] Merge(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x30DA46C
	public static void EraseAt(TValue[] array, int index) { }

	// RVA: 0x30DB520
	public static void EraseAtWithCapacity(TValue[] array, int count, int index) { }

	// RVA: 0x318DB98
	public static void EraseAtWithCapacity(Unity.Collections.NativeArray<TValue> array, int count, int index) { }

	// RVA: 0x318DB98
	public static bool Erase(TValue[] array, TValue value) { }

	// RVA: 0x30DB520
	public static void EraseAtByMovingTail(TValue[] array, int count, int index) { }

	// RVA: 0x30D77E4
	public static TValue[] Copy(TValue[] array) { }

	// RVA: 0x30D77E4
	public static TValue[] Clone(TValue[] array) { }

	// RVA: 0x30D78C4
	public static TNew[] Select(TOld[] array, System.Func<TOld,TNew> converter) { }

	// RVA: 0x30DB358
	private static void Swap(TValue first, TValue second) { }

	// RVA: -1
	public static void MoveSlice(TValue[] array, int sourceIndex, int destinationIndex, int count) { }

	// RVA: 0x30DB594
	public static void EraseSliceWithCapacity(TValue[] array, int length, int index, int count) { }

	// RVA: 0x30DA554
	public static void SwapElements(TValue[] array, int index1, int index2) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D39B8
	public int get_length() { }

	// RVA: 0x318DB98
	public TDelegate get_Item(int index) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public void AddCallback(TDelegate dlg) { }

	// RVA: 0x318DB98
	public void RemoveCallback(TDelegate dlg) { }

	// RVA: 0x30D488C
	public void LockForChanges() { }

	// RVA: 0x30D488C
	public void UnlockForChanges() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector2MagnitudeComparer
{
	// Methods

	// RVA: 0x13CBC38
	public int Compare(Vector2 x, Vector2 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector3MagnitudeComparer
{
	// Methods

	// RVA: 0x13CBC60
	public int Compare(Vector3 x, Vector3 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class CSharpCodeHelpers
{
	// Methods

	// RVA: 0x13CBC98
	public static bool IsProperIdentifier(string name) { }

	// RVA: 0x13CBDCC
	public static bool IsEmptyOrProperIdentifier(string name) { }

	// RVA: 0x13CBE08
	public static bool IsEmptyOrProperNamespaceName(string name) { }

	// RVA: 0x13CBEDC
	public static string MakeIdentifier(string name, string suffix) { }

	// RVA: 0x13CC188
	public static string MakeTypeName(string name, string suffix) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class DelegateHelpers
{
	// Methods

	// RVA: 0x13CC2B4
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>& callbacks, ProfilerMarker marker, string callbackName, object context) { }

	// RVA: 0x318DB98
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x318DB98
	public static void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1,TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, ProfilerMarker marker, string callbackName, object context) { }

	// RVA: 0x318DB98
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1,TValue2,System.Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x318DB98
	public static void InvokeCallbacksSafe_AndInvokeReturnedActions(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,System.Action>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x318DB98
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,TReturn>>& callbacks, TValue argument, string callbackName, object context) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public class DisplayStringFormatAttribute
{
	// Fields
	private string <formatString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13CC5B0
	public string get_formatString() { }

	// RVA: 0x13CC5B8
	public void set_formatString(string value) { }

	// RVA: 0x13CC5C0
	public void .ctor(string formatString) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ExceptionHelpers
{
	// Methods

	// RVA: 0x13CC5F4
	public static bool IsExceptionIndicatingBugInCode(Exception exception) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct FourCC
{
	// Fields
	private int m_Code; // 0x10

	// Methods

	// RVA: 0x13CC6F0
	public void .ctor(int code) { }

	// RVA: 0x13C6B78
	public void .ctor(Char a, Char b, Char c, Char d) { }

	// RVA: 0x13CC6F8
	public void .ctor(string str) { }

	// RVA: 0x13CC878
	public static int op_Implicit(FourCC fourCC) { }

	// RVA: 0x13CC87C
	public static FourCC op_Implicit(int i) { }

	// RVA: 0x13CC880
	public override string ToString() { }

	// RVA: 0x13CCA60
	public bool Equals(FourCC other) { }

	// RVA: 0x13CCA70
	public override bool Equals(object obj) { }

	// RVA: 0x13CCB00
	public override int GetHashCode() { }

	// RVA: 0x13CCB08
	public static bool op_Equality(FourCC left, FourCC right) { }

	// RVA: 0x13CCB14
	public static bool op_Inequality(FourCC left, FourCC right) { }

	// RVA: 0x13CCB20
	public static FourCC FromInt32(int i) { }

	// RVA: 0x13CCB24
	public static int ToInt32(FourCC fourCC) { }

}

// Namespace: 
private struct Enumerator
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x318DB98
	public TValue get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D39B8
	public int get_Capacity() { }

	// RVA: 0x318DB98
	public void .ctor(TValue value) { }

	// RVA: 0x318DB98
	public void .ctor(TValue firstValue, TValue[] additionalValues) { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x318DB98
	public TValue get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, TValue value) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x30D488C
	public void ClearWithCapacity() { }

	// RVA: 0x318DB98
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone() { }

	// RVA: 0x30D4A04
	public void SetLength(int size) { }

	// RVA: 0x30D3CF0
	public TValue[] ToArray() { }

	// RVA: 0x30D3DA0
	public TOther[] ToArray(System.Func<TValue,TOther> mapFunction) { }

	// RVA: 0x318DB98
	public int IndexOf(TValue value) { }

	// RVA: 0x318DB98
	public int Append(TValue value) { }

	// RVA: 0x318DB98
	public int AppendWithCapacity(TValue value, int capacityIncrement) { }

	// RVA: 0x318DB98
	public void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values) { }

	// RVA: 0x30D4CD4
	public void Append(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x318DB98
	public void Remove(TValue value) { }

	// RVA: 0x30D4A04
	public void RemoveAtWithCapacity(int index) { }

	// RVA: 0x30D4A04
	public void RemoveAt(int index) { }

	// RVA: 0x30D4A04
	public void RemoveAtByMovingTailWithCapacity(int index) { }

	// RVA: 0x318DB98
	public bool RemoveByMovingTailWithCapacity(TValue value) { }

	// RVA: 0x318DB98
	public bool Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x318DB98
	public void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class InputArrayExtensions
{
	// Methods

	// RVA: 0x318DB98
	public static int IndexOfReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x318DB98
	public static bool Contains(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x318DB98
	public static bool ContainsReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct InternedString
{
	// Fields
	private readonly string m_StringOriginalCase; // 0x10
	private readonly string m_StringLowerCase; // 0x18

	// Methods

	// RVA: 0x13CCB28
	public int get_length() { }

	// RVA: 0x13C1FE8
	public void .ctor(string text) { }

	// RVA: 0x13CCB40
	public bool IsEmpty() { }

	// RVA: 0x13CCB50
	public string ToLower() { }

	// RVA: 0x13CCB58
	public override bool Equals(object obj) { }

	// RVA: 0x13CCC80
	public bool Equals(InternedString other) { }

	// RVA: 0x13CCC90
	public int CompareTo(InternedString other) { }

	// RVA: 0x13CCCA4
	public override int GetHashCode() { }

	// RVA: 0x13C0FE4
	public override string ToString() { }

	// RVA: 0x13C0E5C
	public static bool op_Equality(InternedString a, InternedString b) { }

	// RVA: 0x13C1BCC
	public static bool op_Inequality(InternedString a, InternedString b) { }

	// RVA: 0x13CCCBC
	public static bool op_Equality(InternedString a, string b) { }

	// RVA: 0x13CCD70
	public static bool op_Inequality(InternedString a, string b) { }

	// RVA: 0x13CCE24
	public static bool op_Equality(string a, InternedString b) { }

	// RVA: 0x13CCED4
	public static bool op_Inequality(string a, InternedString b) { }

	// RVA: 0x13CCF84
	public static bool op_LessThan(InternedString left, InternedString right) { }

	// RVA: 0x13CCFAC
	public static bool op_GreaterThan(InternedString left, InternedString right) { }

	// RVA: 0x13C25EC
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

	// RVA: 0x13CE334
	public override string ToString() { }

	// RVA: 0x13CE464
	public bool Equals(JsonString other) { }

	// RVA: 0x13CE5FC
	public override bool Equals(object obj) { }

	// RVA: 0x13CE6A4
	public override int GetHashCode() { }

	// RVA: 0x13CE728
	public static bool op_Equality(JsonString left, JsonString right) { }

	// RVA: 0x13CE758
	public static bool op_Inequality(JsonString left, JsonString right) { }

	// RVA: 0x13CE78C
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

	// RVA: 0x13CFFDC
	private static void .cctor() { }

	// RVA: 0x13D0048
	public void .ctor() { }

	// RVA: 0x13D0050
	internal string <ToString>b__11_0(JsonValue x) { }

	// RVA: 0x13D0058
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

	// RVA: 0x13CE7DC
	public bool ToBoolean() { }

	// RVA: 0x13CEEC4
	public Int64 ToInteger() { }

	// RVA: 0x13CEFC0
	public Double ToDouble() { }

	// RVA: 0x13CEA2C
	public override string ToString() { }

	// RVA: 0x13CE2FC
	public static JsonValue op_Implicit(bool val) { }

	// RVA: 0x13CE1F0
	public static JsonValue op_Implicit(Int64 val) { }

	// RVA: 0x13CE218
	public static JsonValue op_Implicit(Double val) { }

	// RVA: 0x13CF0AC
	public static JsonValue op_Implicit(string str) { }

	// RVA: 0x13BFF40
	public static JsonValue op_Implicit(JsonString str) { }

	// RVA: 0x13CE188
	public static JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array) { }

	// RVA: 0x13CF13C
	public static JsonValue op_Implicit(System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj) { }

	// RVA: 0x13CF1A0
	public static JsonValue op_Implicit(Enum val) { }

	// RVA: 0x13CF204
	public bool Equals(JsonValue other) { }

	// RVA: 0x13CF47C
	private static bool Equals(object obj, JsonValue value) { }

	// RVA: 0x13CFD28
	public override bool Equals(object obj) { }

	// RVA: 0x13CFDD8
	public override int GetHashCode() { }

	// RVA: 0x13CD450
	public static bool op_Equality(JsonValue left, JsonValue right) { }

	// RVA: 0x13CFFA0
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

	// RVA: 0x13BF978
	public void .ctor(string json) { }

	// RVA: 0x13CCFD8
	public void Reset() { }

	// RVA: 0x13CCFE4
	public override string ToString() { }

	// RVA: 0x13BF9FC
	public bool NavigateToProperty(string path) { }

	// RVA: 0x13BFFB8
	public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) { }

	// RVA: 0x13CD0E4
	public bool ParseToken(Char token) { }

	// RVA: 0x13CD274
	public bool ParseValue() { }

	// RVA: 0x13CD2A4
	public bool ParseValue(JsonValue result) { }

	// RVA: 0x13CD488
	public bool ParseStringValue(JsonValue result) { }

	// RVA: 0x13CD64C
	public bool ParseArrayValue(JsonValue result) { }

	// RVA: 0x13CD990
	public bool ParseObjectValue(JsonValue result) { }

	// RVA: 0x13CDD0C
	public bool ParseNumber(JsonValue result) { }

	// RVA: 0x13CDB98
	public bool ParseBooleanValue(JsonValue result) { }

	// RVA: 0x13CDCA4
	public bool ParseNullValue(JsonValue result) { }

	// RVA: 0x13CD204
	public bool SkipToValue() { }

	// RVA: 0x13CE238
	private bool SkipString(string text) { }

	// RVA: 0x13CD160
	private void SkipWhitespace() { }

	// RVA: 0x13CE324
	public bool get_isAtEnd() { }

}

// Namespace: 
public struct BitRegion
{
	// Fields
	public UInt32 bitOffset; // 0x10
	public UInt32 sizeInBits; // 0x14

	// Methods

	// RVA: 0x13D0BF0
	public bool get_isEmpty() { }

	// RVA: 0x13D0C00
	public void .ctor(UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x13D0C08
	public void .ctor(UInt32 byteOffset, UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x13D0C14
	public BitRegion Overlap(BitRegion other) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MemoryHelpers
{
	// Methods

	// RVA: 0x13D0220
	public static bool Compare(Void* ptr1, Void* ptr2, BitRegion region) { }

	// RVA: 0x13D0404
	public static UInt32 ComputeFollowingByteOffset(UInt32 byteOffset, UInt32 sizeInBits) { }

	// RVA: 0x13D0414
	public static void WriteSingleBit(Void* ptr, UInt32 bitOffset, bool value) { }

	// RVA: 0x13D0264
	public static bool ReadSingleBit(Void* ptr, UInt32 bitOffset) { }

	// RVA: 0x13D0444
	public static void MemCpyBitRegion(Void* destination, Void* source, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13D0280
	public static bool MemCmpBitRegion(Void* ptr1, Void* ptr2, UInt32 bitOffset, UInt32 bitCount, Void* mask) { }

	// RVA: 0x13D053C
	public static void MemSet(Void* destination, int numBytes, Byte value) { }

	// RVA: 0x13D0614
	public static void MemCpyMasked(Void* destination, Void* source, int numBytes, Void* mask) { }

	// RVA: 0x13C74DC
	public static UInt32 ReadMultipleBitsAsUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13D06A8
	public static void WriteUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, UInt32 value) { }

	// RVA: 0x13C4E78
	public static int ReadTwosComplementMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13C4FD8
	public static void WriteIntAsTwosComplementMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x13D088C
	public static int ReadExcessKMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13D08BC
	public static void WriteIntAsExcessKMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x13D08D0
	public static float ReadMultipleBitsAsNormalizedUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13D092C
	public static void WriteNormalizedUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, float value) { }

	// RVA: 0x13D097C
	public static void SetBitsInBuffer(Void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	// RVA: 0x30DB358
	public static void Swap(TValue a, TValue b) { }

	// RVA: 0x13D0B68
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

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x30D488C
	private void <>m__Finally1() { }

	// RVA: 0x318DB98
	private TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MiscHelpers
{
	// Methods

	// RVA: 0x318DB98
	public static TValue GetValueOrDefault(System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key) { }

	// RVA: -1
	public static System.Collections.Generic.IEnumerable<TValue> EveryNth(System.Collections.Generic.IEnumerable<TValue> enumerable, int n, int start) { }

	// RVA: 0x318DB98
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

	// RVA: 0x13D1870
	private static void .cctor() { }

	// RVA: 0x13D18DC
	public void .ctor() { }

	// RVA: 0x13D18E4
	internal string <ToString>b__8_0(NamedValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct NameAndParameters
{
	// Fields
	private string <name>k__BackingField; // 0x10
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13D0CEC
	public string get_name() { }

	// RVA: 0x13D0CF4
	public void set_name(string value) { }

	// RVA: 0x13D0CFC
	public UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x13D0D08
	public void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x13D0D14
	public override string ToString() { }

	// RVA: 0x13D0F24
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text) { }

	// RVA: 0x13D103C
	internal static bool ParseMultiple(string text, System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>& list) { }

	// RVA: 0x13D15AC
	internal static string ParseName(string text) { }

	// RVA: 0x13D1630
	public static NameAndParameters Parse(string text) { }

	// RVA: 0x13D11EC
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

	// RVA: 0x13D1A0C
	public string get_name() { }

	// RVA: 0x13D1A14
	public void set_name(string value) { }

	// RVA: 0x13D1A1C
	public PrimitiveValue get_value() { }

	// RVA: 0x13D1A28
	public void set_value(PrimitiveValue value) { }

	// RVA: 0x13D1A30
	public TypeCode get_type() { }

	// RVA: 0x13D1A38
	public NamedValue ConvertTo(TypeCode type) { }

	// RVA: 0x318DB98
	public static NamedValue From(string name, TValue value) { }

	// RVA: 0x13D1978
	public override string ToString() { }

	// RVA: 0x13D2244
	public bool Equals(NamedValue other) { }

	// RVA: 0x13D233C
	public override bool Equals(object obj) { }

	// RVA: 0x13D243C
	public override int GetHashCode() { }

	// RVA: 0x13D2510
	public static bool op_Equality(NamedValue left, NamedValue right) { }

	// RVA: 0x13D25B0
	public static bool op_Inequality(NamedValue left, NamedValue right) { }

	// RVA: 0x13D16C4
	public static NamedValue[] ParseMultiple(string parameterString) { }

	// RVA: 0x13D29D0
	public static NamedValue Parse(string str) { }

	// RVA: 0x13D2658
	private static NamedValue ParseParameter(string parameterString, int index) { }

	// RVA: 0x13D2D80
	public void ApplyToObject(object instance) { }

	// RVA: 0x318DB98
	public static void ApplyAllToObject(object instance, TParameterList parameters) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class NumberHelpers
{
	// Methods

	// RVA: 0x13D3204
	public static int AlignToMultipleOf(int number, int alignment) { }

	// RVA: 0x13D3220
	public static Int64 AlignToMultipleOf(Int64 number, Int64 alignment) { }

	// RVA: 0x13D323C
	public static UInt32 AlignToMultipleOf(UInt32 number, UInt32 alignment) { }

	// RVA: 0x13D3258
	public static bool Approximately(Double a, Double b) { }

	// RVA: 0x13D32F8
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	// RVA: 0x13D3330
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	// RVA: 0x13D3380
	public static float UIntToNormalizedFloat(UInt32 value, UInt32 minValue, UInt32 maxValue) { }

	// RVA: 0x13D33B8
	public static UInt32 NormalizedFloatToUInt(float value, UInt32 uintMinValue, UInt32 uintMaxValue) { }

	// RVA: 0x13D3400
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

	// RVA: 0x13D35F4
	public void .ctor(Type deviceType, InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

	// RVA: 0x13D3658
	public void OnCompleted() { }

	// RVA: 0x13D365C
	public void OnError(Exception error) { }

	// RVA: 0x13D36E4
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

	// RVA: 0x13D3478
	public void .ctor(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, Type deviceType, InputDevice device) { }

	// RVA: 0x13D34DC
	public IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public IDisposable subscription; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D488C
	internal void <CallOnce>b__0() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class Observable
{
	// Methods

	// RVA: 0x30D78C4
	public static System.IObservable<TValue> Where(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x30D78C4
	public static System.IObservable<TResult> Select(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x30D78C4
	public static System.IObservable<TResult> SelectMany(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: -1
	public static System.IObservable<TValue> Take(System.IObservable<TValue> source, int count) { }

	// RVA: 0x13D38BC
	public static System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, InputDevice device) { }

	// RVA: 0x30D77E4
	public static System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source) { }

	// RVA: 0x30D78C4
	public static IDisposable CallOnce(System.IObservable<TValue> source, System.Action<TValue> action) { }

	// RVA: 0x30D78C4
	public static IDisposable Call(System.IObservable<TValue> source, System.Action<TValue> action) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class Observer<T0>
{
	// Fields
	private System.Action<TValue> m_OnNext; // 0x0
	private Action m_OnCompleted; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(System.Action<TValue> onNext, Action onCompleted) { }

	// RVA: 0x30D488C
	public void OnCompleted() { }

	// RVA: 0x30D4CD4
	public void OnError(Exception error) { }

	// RVA: 0x318DB98
	public void OnNext(TValue evt) { }

}

// Namespace: 
private class Select
{
	// Fields
	private UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x30D488C
	public void OnCompleted() { }

	// RVA: 0x30D4CD4
	public void OnError(Exception error) { }

	// RVA: 0x318DB98
	public void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class SelectManyObservable<T0, T1>
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> m_Filter; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: 0x30D3DA0
	public IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: 
private class Take
{
	// Fields
	private System.IObserver<TValue> m_Observer; // 0x0
	private int m_Remaining; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x30D488C
	public void OnCompleted() { }

	// RVA: 0x30D4CD4
	public void OnError(Exception error) { }

	// RVA: 0x318DB98
	public void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class TakeNObservable<T0>
{
	// Fields
	private System.IObservable<TValue> m_Source; // 0x0
	private int m_Count; // 0x0

	// Methods

	// RVA: 0x30D4D3C
	public void .ctor(System.IObservable<TValue> source, int count) { }

	// RVA: 0x30D3DA0
	public IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Where
{
	// Fields
	private UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable; // 0x0
	private readonly System.IObserver<TValue> m_Observer; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x30D488C
	public void OnCompleted() { }

	// RVA: 0x30D4CD4
	public void OnError(Exception error) { }

	// RVA: 0x318DB98
	public void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class WhereObservable<T0>
{
	// Fields
	private readonly System.IObservable<TValue> m_Source; // 0x0
	private readonly System.Func<TValue,System.Boolean> m_Predicate; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x30D3DA0
	public IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	internal int m_Index; // 0x0
	internal UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> m_List; // 0x0

	// Methods

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x318DB98
	public TValue get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x318DB98
	public TValue get_Item(int index) { }

	// RVA: 0x318DB98
	public void .ctor(TValue single) { }

	// RVA: 0x318DB98
	public void .ctor(TList multiple) { }

	// RVA: 0x318DB98
	public static UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TValue single) { }

	// RVA: 0x318DB98
	public static UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TList multiple) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct PredictiveParser
{
	// Fields
	private int m_Position; // 0x10

	// Methods

	// RVA: 0x13D39A0
	public void ExpectSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x13D3AAC
	public int ExpectInt(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x13D3BD0
	public System.ReadOnlySpan<System.Char> ExpectString(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x13D3E18
	public bool AcceptSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x13D3E54
	public bool AcceptString(System.ReadOnlySpan<System.Char> input, System.ReadOnlySpan<System.Char>& output) { }

	// RVA: 0x13D3FC0
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

	// RVA: 0x13D4020
	internal Byte* get_valuePtr() { }

	// RVA: 0x13D4028
	public TypeCode get_type() { }

	// RVA: 0x13C3E9C
	public bool get_isEmpty() { }

	// RVA: 0x13D4030
	public void .ctor(bool value) { }

	// RVA: 0x13D4048
	public void .ctor(Char value) { }

	// RVA: 0x13D4060
	public void .ctor(Byte value) { }

	// RVA: 0x13D4078
	public void .ctor(SByte value) { }

	// RVA: 0x13D4090
	public void .ctor(Int16 value) { }

	// RVA: 0x13D40A8
	public void .ctor(UInt16 value) { }

	// RVA: 0x13D40C0
	public void .ctor(int value) { }

	// RVA: 0x13D40D0
	public void .ctor(UInt32 value) { }

	// RVA: 0x13D40E0
	public void .ctor(Int64 value) { }

	// RVA: 0x13D40F4
	public void .ctor(UInt64 value) { }

	// RVA: 0x13D4108
	public void .ctor(float value) { }

	// RVA: 0x13D411C
	public void .ctor(Double value) { }

	// RVA: 0x13D1AA4
	public PrimitiveValue ConvertTo(TypeCode type) { }

	// RVA: 0x13D48D4
	public bool Equals(PrimitiveValue other) { }

	// RVA: 0x13D492C
	public override bool Equals(object obj) { }

	// RVA: 0x13D22E0
	public static bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x13D50D8
	public static bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x13D24C4
	public override int GetHashCode() { }

	// RVA: 0x13D5134
	public override string ToString() { }

	// RVA: 0x13D2A30
	public static PrimitiveValue FromString(string value) { }

	// RVA: 0x13D5590
	public TypeCode GetTypeCode() { }

	// RVA: 0x13D4130
	public bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x13D4380
	public Byte ToByte(IFormatProvider provider) { }

	// RVA: 0x13D42FC
	public Char ToChar(IFormatProvider provider) { }

	// RVA: 0x13D5598
	public DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x13D55EC
	public Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x13D47F0
	public Double ToDouble(IFormatProvider provider) { }

	// RVA: 0x13D44FC
	public Int16 ToInt16(IFormatProvider provider) { }

	// RVA: 0x13D45C8
	public int ToInt32(IFormatProvider provider) { }

	// RVA: 0x13D4678
	public Int64 ToInt64(IFormatProvider provider) { }

	// RVA: 0x13D443C
	public SByte ToSByte(IFormatProvider provider) { }

	// RVA: 0x13C3EAC
	public float ToSingle(IFormatProvider provider) { }

	// RVA: 0x13D5708
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x13D570C
	public object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x13D574C
	public UInt16 ToUInt16(IFormatProvider provider) { }

	// RVA: 0x13D57F4
	public UInt32 ToUInt32(IFormatProvider provider) { }

	// RVA: 0x13D473C
	public UInt64 ToUInt64(IFormatProvider provider) { }

	// RVA: 0x13D3008
	public object ToObject() { }

	// RVA: 0x318DB98
	public static PrimitiveValue From(TValue value) { }

	// RVA: 0x13D4B88
	public static PrimitiveValue FromObject(object value) { }

	// RVA: 0x13D2A14
	public static PrimitiveValue op_Implicit(bool value) { }

	// RVA: 0x13D4370
	public static PrimitiveValue op_Implicit(Char value) { }

	// RVA: 0x13D442C
	public static PrimitiveValue op_Implicit(Byte value) { }

	// RVA: 0x13D44E8
	public static PrimitiveValue op_Implicit(SByte value) { }

	// RVA: 0x13D45B4
	public static PrimitiveValue op_Implicit(Int16 value) { }

	// RVA: 0x13D5884
	public static PrimitiveValue op_Implicit(UInt16 value) { }

	// RVA: 0x13D4668
	public static PrimitiveValue op_Implicit(int value) { }

	// RVA: 0x13D5894
	public static PrimitiveValue op_Implicit(UInt32 value) { }

	// RVA: 0x13D4720
	public static PrimitiveValue op_Implicit(Int64 value) { }

	// RVA: 0x13D47D4
	public static PrimitiveValue op_Implicit(UInt64 value) { }

	// RVA: 0x13C41A4
	public static PrimitiveValue op_Implicit(float value) { }

	// RVA: 0x13D48B8
	public static PrimitiveValue op_Implicit(Double value) { }

	// RVA: 0x13D58A4
	public static PrimitiveValue FromBoolean(bool value) { }

	// RVA: 0x13D58C0
	public static PrimitiveValue FromChar(Char value) { }

	// RVA: 0x13D58D0
	public static PrimitiveValue FromByte(Byte value) { }

	// RVA: 0x13D58E0
	public static PrimitiveValue FromSByte(SByte value) { }

	// RVA: 0x13D58F4
	public static PrimitiveValue FromInt16(Int16 value) { }

	// RVA: 0x13D5908
	public static PrimitiveValue FromUInt16(UInt16 value) { }

	// RVA: 0x13D5918
	public static PrimitiveValue FromInt32(int value) { }

	// RVA: 0x13D5928
	public static PrimitiveValue FromUInt32(UInt32 value) { }

	// RVA: 0x13D5938
	public static PrimitiveValue FromInt64(Int64 value) { }

	// RVA: 0x13D5954
	public static PrimitiveValue FromUInt64(UInt64 value) { }

	// RVA: 0x13D5970
	public static PrimitiveValue FromSingle(float value) { }

	// RVA: 0x13D5984
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

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x318DB98
	public TValue get_Current() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x30D4CD4
	public void .ctor(TValue[] array) { }

	// RVA: -1
	public void .ctor(TValue[] array, int index, int length) { }

	// RVA: 0x30D3CF0
	public TValue[] ToArray() { }

	// RVA: 0x30D3AE8
	public int IndexOf(System.Predicate<TValue> predicate) { }

	// RVA: 0x318DB98
	public Enumerator GetEnumerator() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	public static UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x318DB98
	public TValue get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class ReadOnlyArrayExtensions
{
	// Methods

	// RVA: 0x318DB98
	public static bool Contains(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x318DB98
	public static bool ContainsReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x318DB98
	public static int IndexOfReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D4CD4
	public virtual void Invoke(T state) { }

	// RVA: 0x30D3EF4
	public virtual IAsyncResult BeginInvoke(T state, AsyncCallback callback, object object) { }

	// RVA: 0x30D4F34
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

	// RVA: 0x30D5108
	internal void .ctor(T state, TypedRestore restoreAction, Action staticDisposeCurrentState) { }

	// RVA: 0x30D488C
	public void StaticDisposeCurrentState() { }

	// RVA: 0x30D488C
	public void RestoreSavedState() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class SpriteUtilities
{
	// Methods

	// RVA: 0x13D59A0
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

	// RVA: 0x13D67E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x13D7418
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13D741C
	private bool MoveNext() { }

	// RVA: 0x13D758C
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13D7594
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13D75D4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13D75DC
	private System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13D7694
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

	// RVA: 0x13D6714
	public void .ctor(int <>1__state) { }

	// RVA: 0x13D7698
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13D769C
	private bool MoveNext() { }

	// RVA: 0x13D7988
	private Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current() { }

	// RVA: 0x13D7994
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13D79D4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13D7A3C
	private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator() { }

	// RVA: 0x13D7AE4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class StringHelpers
{
	// Methods

	// RVA: 0x13D5BCC
	public static string Escape(string str, string chars, string replacements) { }

	// RVA: 0x13D5DE8
	public static string Unescape(string str, string chars, string replacements) { }

	// RVA: 0x13D60DC
	public static bool Contains(string str, Char ch) { }

	// RVA: 0x13D6100
	public static bool Contains(string str, string text, StringComparison comparison) { }

	// RVA: 0x13D6124
	public static string GetPlural(string str) { }

	// RVA: 0x13D62F0
	public static string NicifyMemorySize(Int64 numBytes) { }

	// RVA: 0x13D6474
	public static bool FromNicifiedMemorySize(string text, Int64 result, Int64 defaultMultiplier) { }

	// RVA: 0x13D6608
	public static int CountOccurrences(string str, Char ch) { }

	// RVA: 0x13D668C
	public static System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(string str) { }

	// RVA: 0x13D674C
	public static System.Collections.Generic.IEnumerable<System.String> Split(string str, System.Func<System.Char,System.Boolean> predicate) { }

	// RVA: 0x30D78C4
	public static string Join(string separator, TValue[] values) { }

	// RVA: 0x30D78C4
	public static string Join(System.Collections.Generic.IEnumerable<TValue> values, string separator) { }

	// RVA: 0x30D7A20
	public static string MakeUniqueName(string baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting,System.String> getNameFunc) { }

	// RVA: 0x13D6820
	public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, Char separator) { }

	// RVA: 0x13D6B5C
	public static int ParseInt(string str, int pos) { }

	// RVA: 0x13D6C00
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) { }

	// RVA: 0x13D6C24
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, UInt32 offset) { }

	// RVA: 0x13D6DF0
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) { }

	// RVA: 0x13D6E14
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, UInt32 offset) { }

	// RVA: 0x13D6F4C
	public static bool IsPrintable(Char ch) { }

	// RVA: 0x13D7008
	public static string WithAllWhitespaceStripped(string str) { }

	// RVA: 0x13D7174
	public static bool InvariantEqualsIgnoreCase(string left, string right) { }

	// RVA: 0x13D71C4
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

	// RVA: 0x13D7AE8
	public bool get_isEmpty() { }

	// RVA: 0x13D7AF8
	public void .ctor(string str) { }

	// RVA: 0x13D7950
	public void .ctor(string str, int index, int length) { }

	// RVA: 0x13D7B44
	public void .ctor(string str, int index) { }

	// RVA: 0x13D7B90
	public override bool Equals(object obj) { }

	// RVA: 0x13D7CCC
	public bool Equals(string other) { }

	// RVA: 0x13D7C7C
	public bool Equals(Substring other) { }

	// RVA: 0x13D7DDC
	public bool Equals(InternedString other) { }

	// RVA: 0x13D7DA4
	public int CompareTo(Substring other) { }

	// RVA: 0x13D7E78
	public static int Compare(Substring left, Substring right, StringComparison comparison) { }

	// RVA: 0x13D7EA0
	public bool StartsWith(string str) { }

	// RVA: 0x13D7F4C
	public string Substr(int index, int length) { }

	// RVA: 0x13D7F84
	public override string ToString() { }

	// RVA: 0x13D7FF0
	public override int GetHashCode() { }

	// RVA: 0x13D809C
	public static bool op_Equality(Substring a, Substring b) { }

	// RVA: 0x13D80D8
	public static bool op_Inequality(Substring a, Substring b) { }

	// RVA: 0x13D8114
	public static bool op_Equality(Substring a, InternedString b) { }

	// RVA: 0x13D81AC
	public static bool op_Inequality(Substring a, InternedString b) { }

	// RVA: 0x13D8244
	public static bool op_Equality(InternedString a, Substring b) { }

	// RVA: 0x13D82DC
	public static bool op_Inequality(InternedString a, Substring b) { }

	// RVA: 0x13D8374
	public static Substring op_Implicit(string s) { }

	// RVA: 0x13D83D8
	public int get_length() { }

	// RVA: 0x13D83E0
	public int get_index() { }

	// RVA: 0x13D83E8
	public Char get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class TypeHelpers
{
	// Methods

	// RVA: 0x318DB98
	public static TObject As(object obj) { }

	// RVA: 0x13D8474
	public static bool IsInt(TypeCode type) { }

	// RVA: 0x13D8484
	public static Type GetValueType(MemberInfo member) { }

	// RVA: 0x13D8694
	public static string GetNiceTypeName(Type type) { }

	// RVA: 0x13D8BD4
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

	// RVA: 0x13D9864
	private static void .cctor() { }

	// RVA: 0x13D98D0
	public void .ctor() { }

	// RVA: 0x13D98D8
	internal string <get_names>b__2_0(InternedString x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct TypeTable
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table; // 0x10

	// Methods

	// RVA: 0x13D8FC8
	public System.Collections.Generic.IEnumerable<System.String> get_names() { }

	// RVA: 0x13D9110
	public System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames() { }

	// RVA: 0x13D9164
	public void Initialize() { }

	// RVA: 0x13D91E4
	public InternedString FindNameForType(Type type) { }

	// RVA: 0x13D95DC
	public void AddTypeRegistration(string name, Type type) { }

	// RVA: 0x13D975C
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

	// RVA: 0x13D9900
	public float get_midPoint() { }

	// RVA: 0x13D9914
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13D9A58
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13D9AB0
	public void .ctor() { }

}

// Namespace: 
public enum ModifiersOrder
{
	// Fields
	public int value__; // 0x10
	public const ModifiersOrder Default = 0;
	public const ModifiersOrder Ordered = 1;
	public const ModifiersOrder Unordered = 2;
}

// Namespace: UnityEngine.InputSystem.Composites
public class ButtonWithOneModifier
{
	// Fields
	public int modifier; // 0x10
	public int button; // 0x14
	public bool overrideModifiersNeedToBePressedFirst; // 0x18
	public ModifiersOrder modifiersOrder; // 0x1C

	// Methods

	// RVA: 0x13D9B10
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13D9BDC
	private bool ModifierIsPressed(InputBindingCompositeContext context) { }

	// RVA: 0x13D9C64
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13D9C70
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13D9D18
	public void .ctor() { }

}

// Namespace: 
public enum ModifiersOrder
{
	// Fields
	public int value__; // 0x10
	public const ModifiersOrder Default = 0;
	public const ModifiersOrder Ordered = 1;
	public const ModifiersOrder Unordered = 2;
}

// Namespace: UnityEngine.InputSystem.Composites
public class ButtonWithTwoModifiers
{
	// Fields
	public int modifier1; // 0x10
	public int modifier2; // 0x14
	public int button; // 0x18
	public bool overrideModifiersNeedToBePressedFirst; // 0x1C
	public ModifiersOrder modifiersOrder; // 0x20

	// Methods

	// RVA: 0x13D9D6C
	public override float ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13D9E6C
	private bool ModifiersArePressed(InputBindingCompositeContext context) { }

	// RVA: 0x13D9F24
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13D9F30
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13D9FD8
	public void .ctor() { }

}

// Namespace: 
public enum ModifiersOrder
{
	// Fields
	public int value__; // 0x10
	public const ModifiersOrder Default = 0;
	public const ModifiersOrder Ordered = 1;
	public const ModifiersOrder Unordered = 2;
}

// Namespace: UnityEngine.InputSystem.Composites
public class OneModifierComposite
{
	// Fields
	public int modifier; // 0x10
	public int binding; // 0x14
	public bool overrideModifiersNeedToBePressedFirst; // 0x18
	public ModifiersOrder modifiersOrder; // 0x1C
	private int m_ValueSizeInBytes; // 0x20
	private Type m_ValueType; // 0x28
	private bool m_BindingIsButton; // 0x30

	// Methods

	// RVA: 0x13DA02C
	public override Type get_valueType() { }

	// RVA: 0x13DA034
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13DA03C
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13DA168
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x13DA0D8
	private bool ModifierIsPressed(InputBindingCompositeContext context) { }

	// RVA: 0x13DA228
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13DA7A8
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13DA2FC
	internal static void DetermineValueTypeAndSize(InputBindingCompositeContext context, int part, Type valueType, int valueSizeInBytes, bool isButton) { }

	// RVA: 0x13DA7F8
	public void .ctor() { }

}

// Namespace: 
public enum ModifiersOrder
{
	// Fields
	public int value__; // 0x10
	public const ModifiersOrder Default = 0;
	public const ModifiersOrder Ordered = 1;
	public const ModifiersOrder Unordered = 2;
}

// Namespace: UnityEngine.InputSystem.Composites
public class TwoModifiersComposite
{
	// Fields
	public int modifier1; // 0x10
	public int modifier2; // 0x14
	public int binding; // 0x18
	public bool overrideModifiersNeedToBePressedFirst; // 0x1C
	public ModifiersOrder modifiersOrder; // 0x20
	private int m_ValueSizeInBytes; // 0x24
	private Type m_ValueType; // 0x28
	private bool m_BindingIsButton; // 0x30

	// Methods

	// RVA: 0x13DA800
	public override Type get_valueType() { }

	// RVA: 0x13DA808
	public override int get_valueSizeInBytes() { }

	// RVA: 0x13DA810
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13DA914
	public override void ReadValue(InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x13DA854
	private bool ModifiersArePressed(InputBindingCompositeContext context) { }

	// RVA: 0x13DA97C
	protected override void FinishSetup(InputBindingCompositeContext context) { }

	// RVA: 0x13DAA50
	public override object ReadValueAsObject(InputBindingCompositeContext context) { }

	// RVA: 0x13DAAB4
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

	// RVA: 0x13DAABC
	public override Vector2 ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13DAC38
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13DACCC
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

	// RVA: 0x13DAD28
	public override Vector3 ReadValue(InputBindingCompositeContext context) { }

	// RVA: 0x13DAFC8
	public override float EvaluateMagnitude(InputBindingCompositeContext context) { }

	// RVA: 0x13DB070
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=84
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=104
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=262
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=371
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=508
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=976
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1036
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1799
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=3983
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=23174
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=23276
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=262 1D0F855A98F398E261D1E4C657C33BD47F11A47FD9CF90F160D467BC8C7FEBE3; // 0x0
	internal static readonly __StaticArrayInitTypeSize=508 1E9B4B805C18CBD7D7326E392008A12FBD20465C53E9C60AEBEA427165641632; // 0x106
	internal static readonly __StaticArrayInitTypeSize=976 286DD866DF46AD63DA3C6198BE2F9CDB96A5223055FDC3E0287B7CCA9F45AFB4; // 0x302
	internal static readonly __StaticArrayInitTypeSize=23276 2C6CEDFC67BA44F1861E65CFB214D2A9AB92D97A801E842924361719B8CDFB3D; // 0x6D2
	internal static readonly __StaticArrayInitTypeSize=23174 835E1706ECCC851CB6ADBE1F9C2E4BF28F3633DB7AC581000CE3E87FD62F7283; // 0x61BE
	internal static readonly __StaticArrayInitTypeSize=371 BD3331923AE2D87F6296377CB80C86CE12BF445ED38D4485D28FACFEC06BFF5B; // 0xBC44
	internal static readonly __StaticArrayInitTypeSize=3983 CB22D97D4BE9F7A4259E5E355F9F66F2C2D11559A9EA0634CFF23EAA93DA62AE; // 0xBDB7
	internal static readonly __StaticArrayInitTypeSize=1036 D4ADEDA8D4E42C7133AFF7B673F4893FEA7C6A101764B0179449453A7E7F516F; // 0xCD46
	internal static readonly __StaticArrayInitTypeSize=84 D9D05356900CBD90C107CDBD184BC94526EC3F9228772F900FC7C60E3FE82B5A; // 0xD152
	internal static readonly __StaticArrayInitTypeSize=1799 E90C194F8229C7E8552701BC1D1F1BD2537F77555B9151B4B09FF9D1BA956FE6; // 0xD1A6
	internal static readonly __StaticArrayInitTypeSize=104 FFCB0A1E90587D61767DBCE765CBEC8743DC4A67B865900B464ED065E4625BD5; // 0xD8AD
}


