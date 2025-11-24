// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal static class UISupport 
{
	// Methods

	// RVA: 0x1342F4C
	void Initialize() { }

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

	// RVA: 0x1342FC4
	MonoScriptData Get() { }

	// RVA: 0x13430C8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputActionCollection 
{
	// Methods

	// RVA: 0x309AF8C
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: -1
	void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x309AF8C
	System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: -1
	void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: -1
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x2FE3174
	bool Contains(InputAction action) { }

	// RVA: 0x2FE41A8
	void Enable() { }

	// RVA: 0x2FE41A8
	void Disable() { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputActionCollection2 
{
	// Methods

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: -1
	InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: -1
	int FindBinding(InputBinding mask, out InputAction action) { }

}

// Namespace: UnityEngine.InputSystem
public interface IInputInteraction 
{
	// Methods

	// RVA: 0x2FE4574
	void Process(ref InputInteractionContext context) { }

	// RVA: 0x2FE41A8
	void Reset() { }

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

	// RVA: 0x13430D0
	Type GetValueType(Type interactionType) { }

	// RVA: 0x13431EC
	string GetDisplayName(string interaction) { }

	// RVA: 0x134330C
	string GetDisplayName(Type interactionType) { }

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

	// RVA: 0x1345B34
	int get_actionIndex() { }

	// RVA: 0x1345B3C
	int get_bindingIndex() { }

	// RVA: 0x1345B7C
	int get_controlIndex() { }

	// RVA: 0x1345BBC
	int get_interactionIndex() { }

	// RVA: 0x1345BFC
	InputActionPhase get_phase() { }

	// RVA: 0x1345C38
	bool get_started() { }

	// RVA: 0x1345C7C
	bool get_performed() { }

	// RVA: 0x1345CC0
	bool get_canceled() { }

	// RVA: 0x1345D04
	InputAction get_action() { }

	// RVA: 0x1345D5C
	InputControl get_control() { }

	// RVA: 0x1345DC0
	IInputInteraction get_interaction() { }

	// RVA: 0x1345E44
	Double get_time() { }

	// RVA: 0x1345E90
	Double get_startTime() { }

	// RVA: 0x1345EDC
	Double get_duration() { }

	// RVA: 0x1345F60
	Type get_valueType() { }

	// RVA: 0x1345FF4
	int get_valueSizeInBytes() { }

	// RVA: 0x1346088
	void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x134633C
	bool ReadValueAsButton() { }

	// RVA: 0x13463FC
	object ReadValueAsObject() { }

	// RVA: 0x13464C0
	string ToString() { }

}

// Namespace: UnityEngine.InputSystem
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

	// RVA: 0x13434C4
	string get_name() { }

	// RVA: 0x13434CC
	InputActionType get_type() { }

	// RVA: 0x13434D4
	Guid get_id() { }

	// RVA: 0x13435A8
	Guid get_idDontGenerate() { }

	// RVA: 0x134360C
	string get_expectedControlType() { }

	// RVA: 0x1343614
	void set_expectedControlType(string value) { }

	// RVA: 0x134361C
	string get_processors() { }

	// RVA: 0x1343624
	string get_interactions() { }

	// RVA: 0x134362C
	InputActionMap get_actionMap() { }

	// RVA: 0x134366C
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x1343688
	void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1343BF0
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1343D24
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x1343EC0
	InputActionPhase get_phase() { }

	// RVA: 0x1343F88
	bool get_inProgress() { }

	// RVA: 0x1343FDC
	bool get_enabled() { }

	// RVA: 0x1344030
	void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x134408C
	void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13440E8
	void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1344144
	void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13441A0
	void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13441FC
	void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x1344258
	bool get_triggered() { }

	// RVA: 0x1344388
	InputControl get_activeControl() { }

	// RVA: 0x1344420
	Type get_activeValueType() { }

	// RVA: 0x13444AC
	bool get_wantsInitialStateCheck() { }

	// RVA: 0x13444C8
	void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x13444DC
	void .ctor() { }

	// RVA: 0x1344538
	void .ctor(string name, InputActionType type, string binding, string interactions, string processors, string expectedControlType) { }

	// RVA: 0x1344750
	void Dispose() { }

	// RVA: 0x134476C
	string ToString() { }

	// RVA: 0x1344AB0
	void Enable() { }

	// RVA: 0x1344B54
	void Disable() { }

	// RVA: 0x1344BC8
	InputAction Clone() { }

	// RVA: 0x1344CDC
	object System.ICloneable.Clone() { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x1344CE0
	object ReadValueAsObject() { }

	// RVA: 0x1344D80
	float GetControlMagnitude() { }

	// RVA: 0x1344DF8
	void Reset() { }

	// RVA: 0x1344E90
	bool IsPressed() { }

	// RVA: 0x1344EF4
	bool IsInProgress() { }

	// RVA: 0x1344F5C
	bool WasPressedThisFrame() { }

	// RVA: 0x1344FF4
	bool WasReleasedThisFrame() { }

	// RVA: 0x13442F0
	bool WasPerformedThisFrame() { }

	// RVA: 0x134508C
	bool WasCompletedThisFrame() { }

	// RVA: 0x1345124
	float GetTimeoutCompletionPercentage() { }

	// RVA: 0x134364C
	bool get_isSingletonAction() { }

	// RVA: 0x1343F0C
	TriggerState get_currentState() { }

	// RVA: 0x1343548
	string MakeSureIdIsInPlace() { }

	// RVA: 0x1345270
	void GenerateId() { }

	// RVA: 0x1343AD0
	InputActionMap GetOrCreateActionMap() { }

	// RVA: 0x13452BC
	void CreateInternalActionMapForSingletonAction() { }

	// RVA: 0x13453B8
	void RequestInitialStateCheckOnEnabledAction() { }

	// RVA: 0x1345404
	bool ActiveControlIsValid(InputControl control) { }

	// RVA: 0x134573C
	System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask() { }

	// RVA: 0x13458BC
	int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	// RVA: 0x1345A64
	int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

}

// Namespace: 
internal struct WriteFileJson 
{
	// Fields
	public string name; // 0x10
	public WriteMapJson[] maps; // 0x18
	public SchemeJson[] controlSchemes; // 0x20
}

// Namespace: 
internal struct WriteFileJsonNoName 
{
	// Fields
	public WriteMapJson[] maps; // 0x10
	public SchemeJson[] controlSchemes; // 0x18
}

// Namespace: 
internal struct ReadFileJson 
{
	// Fields
	public string name; // 0x10
	public ReadMapJson[] maps; // 0x18
	public SchemeJson[] controlSchemes; // 0x20

	// Methods

	// RVA: 0x1347C2C
	void ToAsset(InputActionAsset asset) { }

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

	// RVA: 0x1348FD0
	void .ctor(int <>1__state) { }

	// RVA: 0x134A978
	void System.IDisposable.Dispose() { }

	// RVA: 0x134A97C
	bool MoveNext() { }

	// RVA: 0x134AB90
	InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

	// RVA: 0x134AB98
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x134ABD8
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x1346B70
	void .ctor(int <>1__state) { }

	// RVA: 0x134ABE0
	void System.IDisposable.Dispose() { }

	// RVA: 0x134ABE4
	bool MoveNext() { }

	// RVA: 0x134AD80
	InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

	// RVA: 0x134ADAC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x134ADEC
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x134AE74
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

	// RVA: 0x134AF28
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public class InputActionAsset 
{
	// Fields
	public const string Extension = 5730681920;
	internal const string kDefaultAssetLayoutJson = 5736712832;
	internal InputActionMap[] m_ActionMaps; // 0x18
	internal InputControlScheme[] m_ControlSchemes; // 0x20
	internal bool m_IsProjectWide; // 0x28
	internal InputActionState m_SharedStateForAllMaps; // 0x30
	internal System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x38
	internal int m_ParameterOverridesCount; // 0x98
	internal ParameterOverride[] m_ParameterOverrides; // 0xA0
	internal DeviceArray m_Devices; // 0xA8

	// Methods

	// RVA: 0x134685C
	bool get_enabled() { }

	// RVA: 0x1346A00
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps() { }

	// RVA: 0x1346A7C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x1346AE8
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x1346BA8
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x1346BD0
	void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1346F90
	System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x1347128
	void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x1347334
	InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x13476DC
	string ToJson() { }

	// RVA: 0x1347B50
	void LoadFromJson(string json) { }

	// RVA: 0x1347D00
	InputActionAsset FromJson(string json) { }

	// RVA: 0x13473B8
	InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1347EE8
	int FindBinding(InputBinding mask, out InputAction action) { }

	// RVA: 0x13481B0
	InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound) { }

	// RVA: 0x13483F8
	InputActionMap FindActionMap(Guid id) { }

	// RVA: 0x13484B8
	InputAction FindAction(Guid guid) { }

	// RVA: 0x13485D4
	int FindControlSchemeIndex(string name) { }

	// RVA: 0x13486A4
	System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(string name) { }

	// RVA: 0x13487DC
	bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x1348A80
	void Enable() { }

	// RVA: 0x1348CD4
	void Disable() { }

	// RVA: 0x1348EBC
	bool Contains(InputAction action) { }

	// RVA: 0x1348F58
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x1348FFC
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1349074
	void MarkAsDirty() { }

	// RVA: 0x1349078
	bool IsEmpty() { }

	// RVA: 0x1349174
	void OnWantToChangeSetup() { }

	// RVA: 0x13494EC
	void OnSetupChanged() { }

	// RVA: 0x1346EA8
	void ReResolveIfNecessary(bool fullResolve) { }

	// RVA: 0x1349874
	void ResolveBindingsIfNecessary() { }

	// RVA: 0x1349930
	void OnDestroy() { }

	// RVA: 0x1349978
	void .ctor() { }

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

	// RVA: 0x134DBFC
	int IndexOf(InputDevice device) { }

	// RVA: 0x134DC5C
	bool Remove(InputDevice device) { }

	// RVA: 0x134705C
	System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get() { }

	// RVA: 0x1347178
	bool Set(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> devices) { }

}

// Namespace: 
internal struct BindingOverrideListJson 
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> bindings; // 0x10
}

// Namespace: 
internal struct BindingOverrideJson 
{
	// Fields
	public string action; // 0x10
	public string id; // 0x18
	public string path; // 0x20
	public string interactions; // 0x28
	public string processors; // 0x30

	// Methods

	// RVA: 0x134DD10
	BindingOverrideJson FromBinding(InputBinding binding, string actionName) { }

	// RVA: 0x134DE28
	BindingOverrideJson FromBinding(InputBinding binding) { }

	// RVA: 0x134DE90
	InputBinding ToBinding(BindingOverrideJson bindingOverride) { }

}

// Namespace: 
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

	// RVA: 0x134DF9C
	InputBinding ToBinding() { }

	// RVA: 0x134E128
	BindingJson FromBinding(ref InputBinding binding) { }

}

// Namespace: 
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

	// RVA: 0x134E214
	InputAction ToAction(string actionName) { }

}

// Namespace: 
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

	// RVA: 0x134E4C0
	WriteActionJson FromAction(InputAction action) { }

}

// Namespace: 
internal struct ReadMapJson 
{
	// Fields
	public string name; // 0x10
	public string id; // 0x18
	public ReadActionJson[] actions; // 0x20
	public BindingJson[] bindings; // 0x28
}

// Namespace: 
internal struct WriteMapJson 
{
	// Fields
	public string name; // 0x10
	public string id; // 0x18
	public WriteActionJson[] actions; // 0x20
	public BindingJson[] bindings; // 0x28

	// Methods

	// RVA: 0x134E5E8
	WriteMapJson FromMap(InputActionMap map) { }

}

// Namespace: 
internal struct WriteFileJson 
{
	// Fields
	public WriteMapJson[] maps; // 0x10

	// Methods

	// RVA: 0x134DA1C
	WriteFileJson FromMap(InputActionMap map) { }

	// RVA: 0x13477B4
	WriteFileJson FromMaps(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

}

// Namespace: 
internal struct ReadFileJson 
{
	// Fields
	public ReadActionJson[] actions; // 0x10
	public ReadMapJson[] maps; // 0x18

	// Methods

	// RVA: 0x1349980
	InputActionMap[] ToMaps() { }

}

// Namespace: UnityEngine.InputSystem
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

	// RVA: 0x134AF2C
	string get_name() { }

	// RVA: 0x134AF34
	InputActionAsset get_asset() { }

	// RVA: 0x134AF3C
	Guid get_id() { }

	// RVA: 0x1348394
	Guid get_idDontGenerate() { }

	// RVA: 0x1346A6C
	bool get_enabled() { }

	// RVA: 0x134AB24
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions() { }

	// RVA: 0x134AFFC
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x134B068
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

	// RVA: 0x134B10C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x134B1E0
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x134B208
	void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x1345544
	System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x134B564
	void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x134B62C
	InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x134B70C
	void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x134B768
	void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13453A8
	void .ctor() { }

	// RVA: 0x134B7C4
	void .ctor(string name) { }

	// RVA: 0x134B800
	void Dispose() { }

	// RVA: 0x134B814
	int FindActionIndex(string nameOrId) { }

	// RVA: 0x134BA20
	void SetUpActionLookupTable() { }

	// RVA: 0x134BBA8
	void ClearActionLookupTable() { }

	// RVA: 0x134BC04
	int FindActionIndex(Guid id) { }

	// RVA: 0x1347DBC
	InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x1348578
	InputAction FindAction(Guid id) { }

	// RVA: 0x134896C
	bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x1348C60
	void Enable() { }

	// RVA: 0x1348E84
	void Disable() { }

	// RVA: 0x134BCDC
	InputActionMap Clone() { }

	// RVA: 0x134BF80
	object System.ICloneable.Clone() { }

	// RVA: 0x134BF84
	bool Contains(InputAction action) { }

	// RVA: 0x134BFB0
	string ToString() { }

	// RVA: 0x134C0B8
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x134C198
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x134C19C
	bool get_needToResolveBindings() { }

	// RVA: 0x134C1A8
	void set_needToResolveBindings(bool value) { }

	// RVA: 0x134C1BC
	bool get_bindingResolutionNeedsFullReResolve() { }

	// RVA: 0x134C1C8
	void set_bindingResolutionNeedsFullReResolve(bool value) { }

	// RVA: 0x134C1E8
	bool get_controlsForEachActionInitialized() { }

	// RVA: 0x134C1F4
	void set_controlsForEachActionInitialized(bool value) { }

	// RVA: 0x134C214
	bool get_bindingsForEachActionInitialized() { }

	// RVA: 0x134C220
	void set_bindingsForEachActionInitialized(bool value) { }

	// RVA: 0x1343C8C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(InputAction action) { }

	// RVA: 0x1343E28
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(InputAction action) { }

	// RVA: 0x134C240
	void SetUpPerActionControlAndBindingArrays() { }

	// RVA: 0x1349204
	void OnWantToChangeSetup() { }

	// RVA: 0x1349588
	void OnSetupChanged() { }

	// RVA: 0x134C9E4
	void OnBindingModified() { }

	// RVA: 0x134C97C
	void ClearCachedActionData(bool onlyControls) { }

	// RVA: 0x134AFB0
	void GenerateId() { }

	// RVA: 0x1343B0C
	bool LazyResolveBindings(bool fullResolve) { }

	// RVA: 0x1343DE0
	bool ResolveBindingsIfNecessary() { }

	// RVA: 0x134CAD0
	void ResolveBindings() { }

	// RVA: 0x1347FE0
	int FindBinding(InputBinding mask, out InputAction action) { }

	// RVA: 0x134D76C
	int FindBindingRelativeToMap(InputBinding mask) { }

	// RVA: 0x134D830
	InputActionMap[] FromJson(string json) { }

	// RVA: 0x134D8E8
	string ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

	// RVA: 0x134D9A4
	string ToJson() { }

	// RVA: 0x134DACC
	void OnBeforeSerialize() { }

	// RVA: 0x134DAD0
	void OnAfterDeserialize() { }

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

	// RVA: 0x134EDEC
	void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x134EE44
	ParameterEnumerator GetEnumerator() { }

	// RVA: 0x1355374
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }

	// RVA: 0x1355468
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x1355068
	void .ctor(InputActionState state, ParameterOverride parameter, int mapIndex) { }

	// RVA: 0x1355718
	bool MoveToNextBinding() { }

	// RVA: 0x13558E8
	bool MoveToNextInteraction() { }

	// RVA: 0x1355AA8
	bool MoveToNextProcessor() { }

	// RVA: 0x135596C
	bool FindParameter(object instance) { }

	// RVA: 0x134EF34
	bool MoveNext() { }

	// RVA: 0x1355620
	void Reset() { }

	// RVA: 0x134EEC0
	Parameter get_Current() { }

	// RVA: 0x1355B2C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1355BD0
	void Dispose() { }

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

	// RVA: 0x135555C
	Type get_objectType() { }

	// RVA: 0x134EA0C
	void .ctor(string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x1355BD4
	void .ctor(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x1350230
	System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x1355C4C
	System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(ParameterOverride[] overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName) { }

	// RVA: 0x1355F0C
	System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> PickMoreSpecificOne(System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> first, System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> second) { }

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

	// RVA: 0x135698C
	void .ctor() { }

	// RVA: 0x1358CC4
	bool <WithTargetBinding>b__0(InputControlScheme x) { }

}

// Namespace: 
public sealed class RebindingOperation 
{
	// Fields
	public const float kDefaultMagnitudeThreshold = 1045220557;
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

	// RVA: 0x1356334
	InputAction get_action() { }

	// RVA: 0x135633C
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x1356364
	UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates() { }

	// RVA: 0x1356378
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_scores() { }

	// RVA: 0x13563F8
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_magnitudes() { }

	// RVA: 0x1356478
	InputControl get_selectedControl() { }

	// RVA: 0x13564EC
	bool get_started() { }

	// RVA: 0x13564F8
	bool get_completed() { }

	// RVA: 0x1356504
	bool get_canceled() { }

	// RVA: 0x1356510
	Double get_startTime() { }

	// RVA: 0x1356518
	float get_timeout() { }

	// RVA: 0x13549B4
	string get_expectedControlType() { }

	// RVA: 0x1354608
	RebindingOperation WithAction(InputAction action) { }

	// RVA: 0x1354934
	RebindingOperation WithMatchingEventsBeingSuppressed(bool value) { }

	// RVA: 0x13549C4
	RebindingOperation WithCancelingThrough(string binding) { }

	// RVA: 0x1356624
	RebindingOperation WithCancelingThrough(InputControl control) { }

	// RVA: 0x1356588
	RebindingOperation WithExpectedControlType(string layoutName) { }

	// RVA: 0x1356704
	RebindingOperation WithExpectedControlType(Type type) { }

	// RVA: 0x2FE360C
	RebindingOperation WithExpectedControlType() { }

	// RVA: 0x1354A3C
	RebindingOperation WithTargetBinding(int bindingIndex) { }

	// RVA: 0x1356B04
	RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask) { }

	// RVA: 0x1356B3C
	RebindingOperation WithBindingGroup(string group) { }

	// RVA: 0x1356C38
	RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

	// RVA: 0x1356C48
	RebindingOperation WithRebindAddingNewBinding(string group) { }

	// RVA: 0x1356C7C
	RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

	// RVA: 0x1356D7C
	RebindingOperation WithoutIgnoringNoisyControls() { }

	// RVA: 0x1356994
	RebindingOperation WithControlsHavingToMatchPath(string path) { }

	// RVA: 0x13547C4
	RebindingOperation WithControlsExcluding(string path) { }

	// RVA: 0x1356DEC
	RebindingOperation WithTimeout(float timeInSeconds) { }

	// RVA: 0x1356DF4
	RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x1356E20
	RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x1356E4C
	RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }

	// RVA: 0x1356E78
	RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl,System.String> callback) { }

	// RVA: 0x1356EA4
	RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> callback) { }

	// RVA: 0x1356ED0
	RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> callback) { }

	// RVA: 0x13547BC
	RebindingOperation OnMatchWaitForAnother(float seconds) { }

	// RVA: 0x1356EFC
	RebindingOperation Start() { }

	// RVA: 0x1357280
	void Cancel() { }

	// RVA: 0x1357320
	void Complete() { }

	// RVA: 0x135771C
	void AddCandidate(InputControl control, float score, float magnitude) { }

	// RVA: 0x13579E8
	void RemoveCandidate(InputControl control) { }

	// RVA: 0x1357B0C
	void Dispose() { }

	// RVA: 0x1357D94
	void Finalize() { }

	// RVA: 0x1357E24
	RebindingOperation Reset() { }

	// RVA: 0x1357164
	void HookOnEvent() { }

	// RVA: 0x1357C68
	void UnhookOnEvent() { }

	// RVA: 0x1357F38
	void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x13578A4
	void SortCandidatesByScore() { }

	// RVA: 0x135878C
	bool HavePathMatch(InputControl control, string[] paths, int pathCount) { }

	// RVA: 0x135705C
	void HookOnAfterUpdate() { }

	// RVA: 0x1357D08
	void UnhookOnAfterUpdate() { }

	// RVA: 0x1358834
	void OnAfterUpdate() { }

	// RVA: 0x1357330
	void OnComplete() { }

	// RVA: 0x13572D8
	void OnCancel() { }

	// RVA: 0x1358B14
	void ResetAfterMatchCompleted() { }

	// RVA: 0x1356520
	void ThrowIfRebindInProgress() { }

	// RVA: 0x1358914
	string GeneratePathForControl(InputControl control) { }

	// RVA: 0x1354568
	void .ctor() { }

}

// Namespace: 
internal class DeferBindingResolutionWrapper 
{
	// Methods

	// RVA: 0x1355014
	void Acquire() { }

	// RVA: 0x1358CEC
	void Dispose() { }

	// RVA: 0x135500C
	void .ctor() { }

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

	// RVA: 0x13515A4
	void .ctor() { }

	// RVA: 0x1358D5C
	string <GetBindingDisplayString>b__0(string fragment) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionRebindingExtensions 
{
	// Fields
	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x0

	// Methods

	// RVA: 0x134E8B8
	System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask) { }

	// RVA: 0x134EAF0
	System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, ParameterOverride parameterOverride) { }

	// RVA: 0x134F24C
	System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	// RVA: 0x309AF8C
	System.Nullable<TValue> GetParameterValue(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask) { }

	// RVA: 0x309AF8C
	void ApplyParameterOverride(InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x309AF8C
	void ApplyParameterOverride(InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x309AF8C
	void ApplyParameterOverride(InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, InputBinding bindingMask) { }

	// RVA: 0x309AF8C
	ParameterOverride ExtractParameterOverride(System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, InputBinding bindingMask, PrimitiveValue value) { }

	// RVA: 0x134F4B4
	void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x134FC38
	void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x134FE14
	void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask) { }

	// RVA: 0x134FFCC
	void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	// RVA: 0x134F644
	void ApplyParameterOverride(InputActionState state, int mapIndex, ref ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride) { }

	// RVA: 0x1350428
	int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x135055C
	int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x13506C8
	int GetBindingIndex(InputAction action, string group, string path) { }

	// RVA: 0x135079C
	System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	// RVA: 0x1350920
	int GetBindingIndexForControl(InputAction action, InputControl control) { }

	// RVA: 0x1350AF8
	string GetBindingDisplayString(InputAction action, DisplayStringOptions options, string group) { }

	// RVA: 0x1350C98
	string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options) { }

	// RVA: 0x1350ED4
	string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options) { }

	// RVA: 0x1350F54
	string GetBindingDisplayString(InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, DisplayStringOptions options) { }

	// RVA: 0x13515AC
	void ApplyBindingOverride(InputAction action, string newPath, string group, string path) { }

	// RVA: 0x13516A8
	void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	// RVA: 0x1351968
	void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x1351BF4
	void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	// RVA: 0x135180C
	int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	// RVA: 0x1351A3C
	void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	// RVA: 0x1351CD4
	void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	// RVA: 0x1351D5C
	void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	// RVA: 0x1351E3C
	void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	// RVA: 0x1351F1C
	void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	// RVA: 0x13523C8
	void RemoveAllBindingOverrides(InputAction action) { }

	// RVA: 0x135252C
	void ApplyBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x13528A0
	void RemoveBindingOverrides(InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }

	// RVA: 0x1352C14
	int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	// RVA: 0x1352D74
	int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	// RVA: 0x1352EE0
	string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	// RVA: 0x1353558
	string SaveBindingOverridesAsJson(InputAction action) { }

	// RVA: 0x1353398
	void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, InputAction action) { }

	// RVA: 0x1353928
	void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting) { }

	// RVA: 0x1353F0C
	void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting) { }

	// RVA: 0x1353AB8
	void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	// RVA: 0x13540B0
	RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex) { }

	// RVA: 0x134D674
	DeferBindingResolutionWrapper DeferBindingResolution() { }

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
public struct InputActionProperty 
{
	// Fields
	private bool m_UseReference; // 0x10
	private InputAction m_Action; // 0x18
	private InputActionReference m_Reference; // 0x20

	// Methods

	// RVA: 0x1358EE4
	InputAction get_action() { }

	// RVA: 0x135905C
	InputActionReference get_reference() { }

	// RVA: 0x1359074
	InputAction get_serializedAction() { }

	// RVA: 0x135907C
	InputActionReference get_serializedReference() { }

	// RVA: 0x1359084
	void .ctor(InputAction action) { }

	// RVA: 0x13590B8
	void .ctor(InputActionReference reference) { }

	// RVA: 0x13590F8
	bool Equals(InputActionProperty other) { }

	// RVA: 0x13591F4
	bool Equals(InputAction other) { }

	// RVA: 0x13592B0
	bool Equals(InputActionReference other) { }

	// RVA: 0x1359320
	bool Equals(object obj) { }

	// RVA: 0x13594E8
	int GetHashCode() { }

	// RVA: 0x13595A4
	bool op_Equality(InputActionProperty left, InputActionProperty right) { }

	// RVA: 0x1359694
	bool op_Inequality(InputActionProperty left, InputActionProperty right) { }

}

// Namespace: UnityEngine.InputSystem
public class InputActionReference 
{
	// Fields
	internal InputActionAsset m_Asset; // 0x18
	internal string m_ActionId; // 0x20
	private InputAction m_Action; // 0x28

	// Methods

	// RVA: 0x1359774
	InputActionAsset get_asset() { }

	// RVA: 0x1358F7C
	InputAction get_action() { }

	// RVA: 0x135977C
	void Set(InputAction action) { }

	// RVA: 0x1359AAC
	void Set(InputActionAsset asset, string mapName, string actionName) { }

	// RVA: 0x1359898
	void SetInternal(InputActionAsset asset, InputAction action) { }

	// RVA: 0x1359DC0
	string ToString() { }

	// RVA: 0x1359CE0
	string GetDisplayName(InputAction action) { }

	// RVA: 0x135A130
	string ToDisplayName() { }

	// RVA: 0x135A17C
	InputAction op_Implicit(InputActionReference reference) { }

	// RVA: 0x135A188
	InputActionReference Create(InputAction action) { }

	// RVA: 0x135A204
	InputAction ToInputAction() { }

	// RVA: 0x135A208
	void .ctor() { }

}

// Namespace: 
public struct BindingSyntax 
{
	// Fields
	private readonly InputActionMap m_ActionMap; // 0x10
	private readonly InputAction m_Action; // 0x18
	internal readonly int m_BindingIndexInMap; // 0x20

	// Methods

	// RVA: 0x135D53C
	bool get_valid() { }

	// RVA: 0x135D5B4
	int get_bindingIndex() { }

	// RVA: 0x135D654
	InputBinding get_binding() { }

	// RVA: 0x135D760
	void .ctor(InputActionMap map, int bindingIndexInMap, InputAction action) { }

	// RVA: 0x135D7A4
	BindingSyntax WithName(string name) { }

	// RVA: 0x135D8C0
	BindingSyntax WithPath(string path) { }

	// RVA: 0x135D9DC
	BindingSyntax WithGroup(string group) { }

	// RVA: 0x135DBD8
	BindingSyntax WithGroups(string groups) { }

	// RVA: 0x135DDFC
	BindingSyntax WithInteraction(string interaction) { }

	// RVA: 0x135DFF8
	BindingSyntax WithInteractions(string interactions) { }

	// RVA: 0x309AF8C
	BindingSyntax WithInteraction() { }

	// RVA: 0x135E21C
	BindingSyntax WithProcessor(string processor) { }

	// RVA: 0x135E418
	BindingSyntax WithProcessors(string processors) { }

	// RVA: 0x309AF8C
	BindingSyntax WithProcessor() { }

	// RVA: 0x135E63C
	BindingSyntax Triggering(InputAction action) { }

	// RVA: 0x135E81C
	BindingSyntax To(InputBinding binding) { }

	// RVA: 0x135E988
	BindingSyntax NextBinding() { }

	// RVA: 0x135EB2C
	BindingSyntax PreviousBinding() { }

	// RVA: 0x135EB6C
	BindingSyntax NextPartBinding(string partName) { }

	// RVA: 0x135EE1C
	BindingSyntax PreviousPartBinding(string partName) { }

	// RVA: 0x135EECC
	BindingSyntax NextCompositeBinding(string compositeName) { }

	// RVA: 0x135F0E0
	BindingSyntax PreviousCompositeBinding(string compositeName) { }

	// RVA: 0x135E9C8
	BindingSyntax Iterate(bool next) { }

	// RVA: 0x135EF10
	BindingSyntax IterateCompositeBinding(bool next, string compositeName) { }

	// RVA: 0x135EC1C
	BindingSyntax IteratePartBinding(bool next, string partName) { }

	// RVA: 0x135F198
	void Erase() { }

	// RVA: 0x135F3A0
	BindingSyntax InsertPartBinding(string partName, string path) { }

}

// Namespace: 
public struct CompositeSyntax 
{
	// Fields
	private readonly InputAction m_Action; // 0x10
	private readonly InputActionMap m_ActionMap; // 0x18
	private int m_BindingIndexInMap; // 0x20

	// Methods

	// RVA: 0x135F5E4
	int get_bindingIndex() { }

	// RVA: 0x135F614
	void .ctor(InputActionMap map, InputAction action, int compositeIndex) { }

	// RVA: 0x135F660
	CompositeSyntax With(string name, string binding, string groups, string processors) { }

}

// Namespace: 
public struct ControlSchemeSyntax 
{
	// Fields
	private readonly InputActionAsset m_Asset; // 0x10
	private readonly int m_ControlSchemeIndex; // 0x18
	private InputControlScheme m_ControlScheme; // 0x20

	// Methods

	// RVA: 0x135F8B4
	void .ctor(InputActionAsset asset, int index) { }

	// RVA: 0x135F8E8
	void .ctor(InputControlScheme controlScheme) { }

	// RVA: 0x135F934
	ControlSchemeSyntax WithBindingGroup(string bindingGroup) { }

	// RVA: 0x309AF8C
	ControlSchemeSyntax WithRequiredDevice() { }

	// RVA: 0x309AF8C
	ControlSchemeSyntax WithOptionalDevice() { }

	// RVA: 0x309AF8C
	ControlSchemeSyntax OrWithRequiredDevice() { }

	// RVA: 0x309AF8C
	ControlSchemeSyntax OrWithOptionalDevice() { }

	// RVA: 0x135FA74
	ControlSchemeSyntax WithRequiredDevice(string controlPath) { }

	// RVA: 0x135FCD8
	ControlSchemeSyntax WithOptionalDevice(string controlPath) { }

	// RVA: 0x135FD10
	ControlSchemeSyntax OrWithRequiredDevice(string controlPath) { }

	// RVA: 0x135FD48
	ControlSchemeSyntax OrWithOptionalDevice(string controlPath) { }

	// RVA: 0x2FE360C
	string DeviceTypeToControlPath() { }

	// RVA: 0x135FD80
	InputControlScheme Done() { }

	// RVA: 0x135FAAC
	void AddDeviceEntry(string controlPath, Flags flags) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public InputBinding binding; // 0x10

	// Methods

	// RVA: 0x135FE68
	void .ctor() { }

	// RVA: 0x135FE70
	bool <RemoveAction>b__0(InputBinding b) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputActionSetupExtensions 
{
	// Methods

	// RVA: 0x135A210
	InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	// RVA: 0x135A424
	void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x135A6BC
	void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	// RVA: 0x135A868
	void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x135A99C
	InputAction AddAction(InputActionMap map, string name, InputActionType type, string binding, string interactions, string processors, string groups, string expectedControlLayout) { }

	// RVA: 0x135ADE0
	void RemoveAction(InputAction action) { }

	// RVA: 0x135B168
	void RemoveAction(InputActionAsset asset, string nameOrId) { }

	// RVA: 0x1358A30
	BindingSyntax AddBinding(InputAction action, string path, string interactions, string processors, string groups) { }

	// RVA: 0x135B388
	BindingSyntax AddBinding(InputAction action, InputControl control) { }

	// RVA: 0x135B294
	BindingSyntax AddBinding(InputAction action, InputBinding binding) { }

	// RVA: 0x135B660
	BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions, string groups, string action, string processors) { }

	// RVA: 0x135B8E8
	BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions, string groups) { }

	// RVA: 0x135BA58
	BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions, string groups) { }

	// RVA: 0x135B7C4
	BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	// RVA: 0x135BB58
	CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions, string processors) { }

	// RVA: 0x135B4B4
	int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex) { }

	// RVA: 0x13568E4
	BindingSyntax ChangeBinding(InputAction action, int index) { }

	// RVA: 0x135BD54
	BindingSyntax ChangeBinding(InputAction action, string name) { }

	// RVA: 0x135C104
	BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	// RVA: 0x135C220
	BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	// RVA: 0x135C2F8
	BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	// RVA: 0x135C3CC
	BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	// RVA: 0x135C4A4
	BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	// RVA: 0x135BDEC
	BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	// RVA: 0x135C57C
	BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	// RVA: 0x135C7A4
	void Rename(InputAction action, string newName) { }

	// RVA: 0x135CA88
	void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	// RVA: 0x135CDA8
	ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x135CF78
	void RemoveControlScheme(InputActionAsset asset, string name) { }

	// RVA: 0x135D0D0
	InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	// RVA: 0x135D17C
	InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	// RVA: 0x135D28C
	InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x135D338
	InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x135D3E4
	InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	// RVA: 0x135D490
	InputControlScheme OrWithOptionalDevice(InputControlScheme scheme, string controlPath) { }

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

	// RVA: 0x1361DFC
	int get_triggerControlIndex() { }

	// RVA: 0x13630E8
	void set_triggerControlIndex(int value) { }

	// RVA: 0x1368B8C
	Double get_startTime() { }

	// RVA: 0x1368B94
	void set_startTime(Double value) { }

	// RVA: 0x1368B9C
	Double get_performedTime() { }

	// RVA: 0x1368BA4
	void set_performedTime(Double value) { }

	// RVA: 0x1368BAC
	Double get_timerStartTime() { }

	// RVA: 0x1368BB4
	void set_timerStartTime(Double value) { }

	// RVA: 0x1368BBC
	float get_timerDuration() { }

	// RVA: 0x1368BC4
	void set_timerDuration(float value) { }

	// RVA: 0x1368BCC
	float get_totalTimeoutCompletionDone() { }

	// RVA: 0x1368BD4
	void set_totalTimeoutCompletionDone(float value) { }

	// RVA: 0x1368BDC
	float get_totalTimeoutCompletionTimeRemaining() { }

	// RVA: 0x1368BE4
	void set_totalTimeoutCompletionTimeRemaining(float value) { }

	// RVA: 0x1368BEC
	Int64 get_timerMonitorIndex() { }

	// RVA: 0x1368BF4
	void set_timerMonitorIndex(Int64 value) { }

	// RVA: 0x1363164
	bool get_isTimerRunning() { }

	// RVA: 0x1366040
	void set_isTimerRunning(bool value) { }

	// RVA: 0x1368BFC
	InputActionPhase get_phase() { }

	// RVA: 0x13630E0
	void set_phase(InputActionPhase value) { }

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

	// RVA: 0x1368C04
	int get_controlStartIndex() { }

	// RVA: 0x1368C0C
	void set_controlStartIndex(int value) { }

	// RVA: 0x1368CA4
	int get_controlCount() { }

	// RVA: 0x1368CAC
	void set_controlCount(int value) { }

	// RVA: 0x1361DE8
	int get_interactionStartIndex() { }

	// RVA: 0x1368D44
	void set_interactionStartIndex(int value) { }

	// RVA: 0x1368DE8
	int get_interactionCount() { }

	// RVA: 0x1368DF0
	void set_interactionCount(int value) { }

	// RVA: 0x1367174
	int get_processorStartIndex() { }

	// RVA: 0x1368E88
	void set_processorStartIndex(int value) { }

	// RVA: 0x1368F2C
	int get_processorCount() { }

	// RVA: 0x1368F34
	void set_processorCount(int value) { }

	// RVA: 0x1362D5C
	int get_actionIndex() { }

	// RVA: 0x1368FCC
	void set_actionIndex(int value) { }

	// RVA: 0x1369070
	int get_mapIndex() { }

	// RVA: 0x1369078
	void set_mapIndex(int value) { }

	// RVA: 0x1360448
	int get_compositeOrCompositeBindingIndex() { }

	// RVA: 0x1369110
	void set_compositeOrCompositeBindingIndex(int value) { }

	// RVA: 0x13691B4
	int get_triggerEventIdForComposite() { }

	// RVA: 0x13691BC
	void set_triggerEventIdForComposite(int value) { }

	// RVA: 0x13691C4
	Double get_pressTime() { }

	// RVA: 0x13691CC
	void set_pressTime(Double value) { }

	// RVA: 0x13691D4
	Flags get_flags() { }

	// RVA: 0x13691DC
	void set_flags(Flags value) { }

	// RVA: 0x13691E4
	bool get_chainsWithNext() { }

	// RVA: 0x13691F0
	void set_chainsWithNext(bool value) { }

	// RVA: 0x1369204
	bool get_isEndOfChain() { }

	// RVA: 0x1369210
	void set_isEndOfChain(bool value) { }

	// RVA: 0x1369230
	bool get_isPartOfChain() { }

	// RVA: 0x1361344
	bool get_isComposite() { }

	// RVA: 0x1369240
	void set_isComposite(bool value) { }

	// RVA: 0x136043C
	bool get_isPartOfComposite() { }

	// RVA: 0x1369260
	void set_isPartOfComposite(bool value) { }

	// RVA: 0x13647E8
	bool get_initialStateCheckPending() { }

	// RVA: 0x1362D8C
	void set_initialStateCheckPending(bool value) { }

	// RVA: 0x1362D80
	bool get_wantsInitialStateCheck() { }

	// RVA: 0x1369280
	void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x13692A0
	int get_partIndex() { }

	// RVA: 0x13692A8
	void set_partIndex(int value) { }

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

	// RVA: 0x13692B0
	InputActionPhase get_phase() { }

	// RVA: 0x1362D54
	void set_phase(InputActionPhase value) { }

	// RVA: 0x1362D70
	bool get_isDisabled() { }

	// RVA: 0x13692B8
	bool get_isWaiting() { }

	// RVA: 0x13692C8
	bool get_isStarted() { }

	// RVA: 0x13692D8
	bool get_isPerformed() { }

	// RVA: 0x13692E8
	bool get_isCanceled() { }

	// RVA: 0x13692F8
	Double get_time() { }

	// RVA: 0x1369300
	void set_time(Double value) { }

	// RVA: 0x1369308
	Double get_startTime() { }

	// RVA: 0x1369310
	void set_startTime(Double value) { }

	// RVA: 0x1369318
	float get_magnitude() { }

	// RVA: 0x136303C
	void set_magnitude(float value) { }

	// RVA: 0x1369320
	bool get_haveMagnitude() { }

	// RVA: 0x136932C
	int get_mapIndex() { }

	// RVA: 0x1363170
	void set_mapIndex(int value) { }

	// RVA: 0x1361DD4
	int get_controlIndex() { }

	// RVA: 0x1362FC0
	void set_controlIndex(int value) { }

	// RVA: 0x1369334
	int get_bindingIndex() { }

	// RVA: 0x1362CE8
	void set_bindingIndex(int value) { }

	// RVA: 0x1363050
	int get_interactionIndex() { }

	// RVA: 0x1363064
	void set_interactionIndex(int value) { }

	// RVA: 0x136933C
	UInt32 get_lastPerformedInUpdate() { }

	// RVA: 0x1369344
	void set_lastPerformedInUpdate(UInt32 value) { }

	// RVA: 0x136934C
	UInt32 get_lastCompletedInUpdate() { }

	// RVA: 0x1369354
	void set_lastCompletedInUpdate(UInt32 value) { }

	// RVA: 0x136935C
	UInt32 get_lastCanceledInUpdate() { }

	// RVA: 0x1369364
	void set_lastCanceledInUpdate(UInt32 value) { }

	// RVA: 0x136936C
	UInt32 get_pressedInUpdate() { }

	// RVA: 0x1369374
	void set_pressedInUpdate(UInt32 value) { }

	// RVA: 0x136937C
	UInt32 get_releasedInUpdate() { }

	// RVA: 0x1369384
	void set_releasedInUpdate(UInt32 value) { }

	// RVA: 0x1363848
	bool get_isPassThrough() { }

	// RVA: 0x13651C4
	void set_isPassThrough(bool value) { }

	// RVA: 0x13651E4
	bool get_isButton() { }

	// RVA: 0x13651F0
	void set_isButton(bool value) { }

	// RVA: 0x1365F44
	bool get_isPressed() { }

	// RVA: 0x1363C68
	void set_isPressed(bool value) { }

	// RVA: 0x1365F50
	bool get_mayNeedConflictResolution() { }

	// RVA: 0x136938C
	void set_mayNeedConflictResolution(bool value) { }

	// RVA: 0x1365F5C
	bool get_hasMultipleConcurrentActuations() { }

	// RVA: 0x1363C28
	void set_hasMultipleConcurrentActuations(bool value) { }

	// RVA: 0x1366910
	bool get_inProcessing() { }

	// RVA: 0x1363C48
	void set_inProcessing(bool value) { }

	// RVA: 0x13693AC
	Flags get_flags() { }

	// RVA: 0x136691C
	void set_flags(Flags value) { }

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

	// RVA: 0x13693B4
	bool get_isAllocated() { }

	// RVA: 0x13693C4
	int get_sizeInBytes() { }

	// RVA: 0x1369414
	void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) { }

	// RVA: 0x13609DC
	void Dispose() { }

	// RVA: 0x1369548
	void CopyDataFrom(UnmanagedMemory memory) { }

	// RVA: 0x1360BCC
	UnmanagedMemory Clone() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputActionState.<>c <>9; // 0x0
	public static TypedRestore <>9__135_0; // 0x8
	public static Action <>9__135_1; // 0x10

	// Methods

	// RVA: 0x13696B8
	void .cctor() { }

	// RVA: 0x1369724
	void .ctor() { }

	// RVA: 0x136972C
	void <SaveAndResetState>b__135_0(ref GlobalState state) { }

	// RVA: 0x136979C
	void <SaveAndResetState>b__135_1() { }

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

	// RVA: 0x135FF14
	int get_totalCompositeCount() { }

	// RVA: 0x135FF1C
	int get_totalMapCount() { }

	// RVA: 0x135FF24
	int get_totalActionCount() { }

	// RVA: 0x135FF2C
	int get_totalBindingCount() { }

	// RVA: 0x135FF34
	int get_totalInteractionCount() { }

	// RVA: 0x135FF3C
	int get_totalControlCount() { }

	// RVA: 0x135FF44
	ActionMapIndices* get_mapIndices() { }

	// RVA: 0x135FF4C
	TriggerState* get_actionStates() { }

	// RVA: 0x135FF54
	BindingState* get_bindingStates() { }

	// RVA: 0x135FF5C
	InteractionState* get_interactionStates() { }

	// RVA: 0x135FF64
	Int32* get_controlIndexToBindingIndex() { }

	// RVA: 0x135FF6C
	UInt16* get_controlGroupingAndComplexity() { }

	// RVA: 0x135FF74
	Single* get_controlMagnitudes() { }

	// RVA: 0x135FF7C
	UInt32* get_enabledControls() { }

	// RVA: 0x135FF84
	bool get_isProcessingControlStateChange() { }

	// RVA: 0x135FF8C
	void Initialize(InputBindingResolver resolver) { }

	// RVA: 0x1360250
	void ComputeControlGroupingIfNecessary() { }

	// RVA: 0x13600D8
	void ClaimDataFrom(InputBindingResolver resolver) { }

	// RVA: 0x136045C
	void Finalize() { }

	// RVA: 0x13606FC
	void Dispose() { }

	// RVA: 0x136053C
	void Destroy(bool isFinalizing) { }

	// RVA: 0x1360A24
	InputActionState Clone() { }

	// RVA: 0x1360D90
	object System.ICloneable.Clone() { }

	// RVA: 0x1360D94
	bool IsUsingDevice(InputDevice device) { }

	// RVA: 0x1360F94
	bool CanUseDevice(InputDevice device) { }

	// RVA: 0x13611E4
	bool HasEnabledActions() { }

	// RVA: 0x1361264
	void FinishBindingCompositeSetups() { }

	// RVA: 0x136135C
	void PrepareForBindingReResolution(bool needFullResolve, ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& activeControls, ref bool hasEnabledActions) { }

	// RVA: 0x136223C
	void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x13622E4
	void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x1363584
	bool IsActiveControl(int bindingIndex, int controlIndex) { }

	// RVA: 0x1362F54
	int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	// RVA: 0x1363630
	void ResetActionStatesDrivenBy(InputDevice device) { }

	// RVA: 0x1363854
	bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	// RVA: 0x1361F34
	void ResetActionState(int actionIndex, InputActionPhase toPhase, bool hardReset) { }

	// RVA: 0x1363C88
	ref TriggerState FetchActionState(InputAction action) { }

	// RVA: 0x1363CB0
	ActionMapIndices FetchMapIndices(InputActionMap map) { }

	// RVA: 0x1363CE8
	void EnableAllActions(InputActionMap map) { }

	// RVA: 0x1363EEC
	void EnableControls(InputActionMap map) { }

	// RVA: 0x1363F30
	void EnableSingleAction(InputAction action) { }

	// RVA: 0x1364038
	void EnableControls(InputAction action) { }

	// RVA: 0x1361AB4
	void DisableAllActions(InputActionMap map) { }

	// RVA: 0x13620F8
	void DisableControls(InputActionMap map) { }

	// RVA: 0x13640FC
	void DisableSingleAction(InputAction action) { }

	// RVA: 0x13641FC
	void DisableControls(InputAction action) { }

	// RVA: 0x1362DAC
	void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x1360704
	void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x1364394
	void SetInitialStateCheckPending(int actionIndex, bool value) { }

	// RVA: 0x136430C
	void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) { }

	// RVA: 0x13642C0
	bool IsControlEnabled(int controlIndex) { }

	// RVA: 0x1364358
	void SetControlEnabled(int controlIndex, bool state) { }

	// RVA: 0x1363368
	void HookOnBeforeUpdate() { }

	// RVA: 0x1364430
	void UnhookOnBeforeUpdate() { }

	// RVA: 0x13644B0
	void OnBeforeInitialUpdate() { }

	// RVA: 0x13647F4
	void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 mapControlAndBindingIndex) { }

	// RVA: 0x1364E68
	void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 mapControlAndBindingIndex, int interactionIndex) { }

	// RVA: 0x13642E4
	Int64 ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x136480C
	void SplitUpMapAndControlAndBindingIndex(Int64 mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex) { }

	// RVA: 0x13651BC
	int GetComplexityFromMonitorIndex(Int64 mapControlAndBindingIndex) { }

	// RVA: 0x1364828
	void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x13658B0
	void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) { }

	// RVA: 0x1365210
	bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) { }

	// RVA: 0x136548C
	bool IsConflictingInput(ref TriggerState trigger, int actionIndex) { }

	// RVA: 0x1363914
	UInt16 GetActionBindingStartIndexAndCount(int actionIndex, out UInt16 bindingCount) { }

	// RVA: 0x1365A78
	void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex) { }

	// RVA: 0x1365270
	void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	// RVA: 0x1364E80
	void ProcessTimeout(Double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	// RVA: 0x1366054
	void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger) { }

	// RVA: 0x13631DC
	void StartTimeout(float seconds, ref TriggerState trigger) { }

	// RVA: 0x1366084
	void StopTimeout(int interactionIndex) { }

	// RVA: 0x1366168
	void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed, InputActionPhase phaseAfterCanceled, bool processNextInteractionOnCancel) { }

	// RVA: 0x13639E4
	bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled) { }

	// RVA: 0x1366614
	void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction) { }

	// RVA: 0x1366924
	void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>& listeners, string callbackName) { }

	// RVA: 0x1366B28
	object GetActionOrNoneString(ref TriggerState trigger) { }

	// RVA: 0x1366C28
	InputAction GetActionOrNull(int bindingIndex) { }

	// RVA: 0x1366B90
	InputAction GetActionOrNull(ref TriggerState trigger) { }

	// RVA: 0x1366CC0
	InputControl GetControl(ref TriggerState trigger) { }

	// RVA: 0x1366D04
	IInputInteraction GetInteractionOrNull(ref TriggerState trigger) { }

	// RVA: 0x1366D54
	int GetBindingIndexInMap(int bindingIndex) { }

	// RVA: 0x1366D90
	int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	// RVA: 0x1366DBC
	ref BindingState GetBindingState(int bindingIndex) { }

	// RVA: 0x1366DCC
	ref InputBinding GetBinding(int bindingIndex) { }

	// RVA: 0x1366E4C
	InputActionMap GetActionMap(int bindingIndex) { }

	// RVA: 0x1363934
	void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	// RVA: 0x1361E10
	void ResetInteractionState(int interactionIndex) { }

	// RVA: 0x1366E90
	int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	// RVA: 0x1366F28
	Type GetValueType(int bindingIndex, int controlIndex) { }

	// RVA: 0x1365F68
	bool IsActuated(ref TriggerState trigger, float threshold) { }

	// RVA: 0x1366FC0
	void ReadValue(int bindingIndex, int controlIndex, Void* buffer, int bufferSize, bool ignoreComposites) { }

	// RVA: 0x309AF8C
	TValue ReadValue(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x309AF8C
	TValue ApplyProcessors(int bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType) { }

	// RVA: 0x1367188
	float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	// RVA: 0x136726C
	Double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	// RVA: 0x309AF8C
	TValue ReadCompositePartValue(int bindingIndex, int partNumber, Boolean* buttonValuePtr, out int controlIndex, TComparer comparer) { }

	// RVA: 0x13672F4
	bool ReadCompositePartValue(int bindingIndex, int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x13674E0
	object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	// RVA: 0x13676AC
	object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites) { }

	// RVA: 0x136784C
	bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	// RVA: 0x1367984
	ISavedState SaveAndResetState() { }

	// RVA: 0x13601B4
	void AddToGlobalList() { }

	// RVA: 0x13608A4
	void RemoveMapFromGlobalList() { }

	// RVA: 0x1367BC0
	void CompactGlobalList() { }

	// RVA: 0x136213C
	void NotifyListenersOfActionChange(InputActionChange change) { }

	// RVA: 0x1363484
	void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	// RVA: 0x1367D60
	void ResetGlobals() { }

	// RVA: 0x1368044
	int FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result) { }

	// RVA: 0x136841C
	void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1368750
	void DeferredResolutionOfBindings() { }

	// RVA: 0x1368A18
	void DisableAllActions() { }

	// RVA: 0x1367EA8
	void DestroyAllActionMapStates() { }

	// RVA: 0x1360BC4
	void .ctor() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputBinding.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean> <>9__45_0; // 0x8

	// Methods

	// RVA: 0x136A860
	void .cctor() { }

	// RVA: 0x136A8CC
	void .ctor() { }

	// RVA: 0x136A8D4
	bool <MaskByGroups>b__45_0(string x) { }

}

// Namespace: UnityEngine.InputSystem
public struct InputBinding 
{
	// Fields
	public const Char Separator = 59;
	internal const string kSeparatorString = 5736712768;
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

	// RVA: 0x13697A0
	string get_name() { }

	// RVA: 0x13697A8
	void set_name(string value) { }

	// RVA: 0x13697B0
	Guid get_id() { }

	// RVA: 0x1369814
	void set_id(Guid value) { }

	// RVA: 0x1369858
	string get_path() { }

	// RVA: 0x1369860
	void set_path(string value) { }

	// RVA: 0x1369868
	string get_overridePath() { }

	// RVA: 0x1369870
	void set_overridePath(string value) { }

	// RVA: 0x1369878
	string get_interactions() { }

	// RVA: 0x1369880
	void set_interactions(string value) { }

	// RVA: 0x1369888
	string get_overrideInteractions() { }

	// RVA: 0x1369890
	void set_overrideInteractions(string value) { }

	// RVA: 0x1369898
	string get_processors() { }

	// RVA: 0x13698A0
	void set_processors(string value) { }

	// RVA: 0x13698A8
	string get_overrideProcessors() { }

	// RVA: 0x13698B0
	void set_overrideProcessors(string value) { }

	// RVA: 0x13698B8
	string get_groups() { }

	// RVA: 0x13698C0
	void set_groups(string value) { }

	// RVA: 0x13698C8
	string get_action() { }

	// RVA: 0x13698D0
	void set_action(string value) { }

	// RVA: 0x135F180
	bool get_isComposite() { }

	// RVA: 0x13698D8
	void set_isComposite(bool value) { }

	// RVA: 0x135F18C
	bool get_isPartOfComposite() { }

	// RVA: 0x135F5C4
	void set_isPartOfComposite(bool value) { }

	// RVA: 0x13698F8
	bool get_hasOverrides() { }

	// RVA: 0x1369928
	void .ctor(string path, string action, string groups, string processors, string interactions, string name) { }

	// RVA: 0x1369A00
	string GetNameOfComposite() { }

	// RVA: 0x1369A50
	void GenerateId() { }

	// RVA: 0x1369A9C
	void RemoveOverrides() { }

	// RVA: 0x1369AE0
	InputBinding MaskByGroup(string group) { }

	// RVA: 0x1369B4C
	InputBinding MaskByGroups(string[] groups) { }

	// RVA: 0x13611CC
	string get_effectivePath() { }

	// RVA: 0x1369CF4
	string get_effectiveInteractions() { }

	// RVA: 0x1369D0C
	string get_effectiveProcessors() { }

	// RVA: 0x1369D24
	bool get_isEmpty() { }

	// RVA: 0x1369D90
	bool Equals(InputBinding other) { }

	// RVA: 0x1369EB4
	bool Equals(object obj) { }

	// RVA: 0x135FED4
	bool op_Equality(InputBinding left, InputBinding right) { }

	// RVA: 0x1369F6C
	bool op_Inequality(InputBinding left, InputBinding right) { }

	// RVA: 0x1369FD4
	int GetHashCode() { }

	// RVA: 0x136A0E8
	string ToString() { }

	// RVA: 0x136A228
	string ToDisplayString(DisplayStringOptions options, InputControl control) { }

	// RVA: 0x136A258
	string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options, InputControl control) { }

	// RVA: 0x135F124
	bool TriggersAction(InputAction action) { }

	// RVA: 0x136A6A8
	bool Matches(InputBinding binding) { }

	// RVA: 0x136A6B0
	bool Matches(ref InputBinding binding, MatchOptions options) { }

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

	// RVA: 0x136AC84
	void .ctor(int <>1__state) { }

	// RVA: 0x136ADE0
	void System.IDisposable.Dispose() { }

	// RVA: 0x136ADE4
	bool MoveNext() { }

	// RVA: 0x136AFF8
	string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x136B000
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x136B040
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x136B048
	System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x136B0F0
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputBindingComposite 
{
	// Fields
	internal static TypeTable s_Composites; // 0x0

	// Methods

	// RVA: 0x2FE360C
	Type get_valueType() { }

	// RVA: 0x2FE32D4
	int get_valueSizeInBytes() { }

	// RVA: 0x309AF8C
	void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x2FE36BC
	object ReadValueAsObject(ref InputBindingCompositeContext context) { }

	// RVA: 0x136A8F4
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x136A8FC
	void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x1361350
	void CallFinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x136A900
	Type GetValueType(string composite) { }

	// RVA: 0x136AA60
	string GetExpectedControlLayoutName(string composite, string part) { }

	// RVA: 0x136ABFC
	System.Collections.Generic.IEnumerable<System.String> GetPartNames(string composite) { }

	// RVA: 0x136ACBC
	string GetDisplayFormatString(string composite) { }

	// RVA: 0x136ADD8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputBindingComposite<T0> 
{
	// Methods

	// RVA: 0x2FE360C
	Type get_valueType() { }

	// RVA: 0x2FE32D4
	int get_valueSizeInBytes() { }

	// RVA: 0x309AF8C
	TValue ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x309AF8C
	void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x2FE36BC
	object ReadValueAsObject(ref InputBindingCompositeContext context) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
public struct PartBinding 
{
	// Fields
	private int <part>k__BackingField; // 0x10
	private InputControl <control>k__BackingField; // 0x18

	// Methods

	// RVA: 0x136B368
	int get_part() { }

	// RVA: 0x136B370
	void set_part(int value) { }

	// RVA: 0x136B378
	InputControl get_control() { }

	// RVA: 0x136B380
	void set_control(InputControl value) { }

}

// Namespace: 
private struct DefaultComparer<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	int Compare(TValue x, TValue y) { }

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

	// RVA: 0x136B180
	void .ctor(int <>1__state) { }

	// RVA: 0x136B388
	void System.IDisposable.Dispose() { }

	// RVA: 0x136B38C
	bool MoveNext() { }

	// RVA: 0x136B4D4
	PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current() { }

	// RVA: 0x136B4E0
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x136B520
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x136B588
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() { }

	// RVA: 0x136B634
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public struct InputBindingCompositeContext 
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal int m_BindingIndex; // 0x18

	// Methods

	// RVA: 0x136B0F4
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls() { }

	// RVA: 0x136B1B8
	float EvaluateMagnitude(int partNumber) { }

	// RVA: 0x309AF8C
	TValue ReadValue(int partNumber) { }

	// RVA: 0x309AF8C
	TValue ReadValue(int partNumber, out InputControl sourceControl) { }

	// RVA: 0x309AF8C
	TValue ReadValue(int partNumber, TComparer comparer) { }

	// RVA: 0x309AF8C
	TValue ReadValue(int partNumber, out InputControl sourceControl, TComparer comparer) { }

	// RVA: 0x136B1E0
	bool ReadValueAsButton(int partNumber) { }

	// RVA: 0x136B278
	void ReadValue(int partNumber, Void* buffer, int bufferSize) { }

	// RVA: 0x136B29C
	object ReadValueAsObject(int partNumber) { }

	// RVA: 0x136B2C4
	Double GetPressTime(int partNumber) { }

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

	// RVA: 0x136B638
	int get_totalMapCount() { }

	// RVA: 0x136B640
	int get_totalActionCount() { }

	// RVA: 0x136B648
	int get_totalBindingCount() { }

	// RVA: 0x136B650
	int get_totalControlCount() { }

	// RVA: 0x136B658
	void Dispose() { }

	// RVA: 0x136B6A4
	void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

	// RVA: 0x136B844
	void AddActionMap(InputActionMap actionMap) { }

	// RVA: 0x309AF8C
	int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) { }

	// RVA: 0x136D2E8
	InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) { }

	// RVA: 0x136D7AC
	void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	// RVA: 0x136D574
	int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) { }

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

	// RVA: 0x137F97C
	InputControl get_control() { }

	// RVA: 0x137F9D4
	InputDevice get_device() { }

	// RVA: 0x137FA38
	int get_requirementIndex() { }

	// RVA: 0x137FA40
	DeviceRequirement get_requirement() { }

	// RVA: 0x137FA78
	bool get_isOptional() { }

}

// Namespace: 
private struct Enumerator 
{
	// Fields
	internal int m_Index; // 0x10
	internal DeviceRequirement[] m_Requirements; // 0x18
	internal UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls; // 0x20

	// Methods

	// RVA: 0x137FAC0
	bool MoveNext() { }

	// RVA: 0x137FAEC
	void Reset() { }

	// RVA: 0x137FAF8
	Match get_Current() { }

	// RVA: 0x137FBB4
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x137FC20
	void Dispose() { }

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

	// RVA: 0x137F580
	float get_score() { }

	// RVA: 0x137F588
	bool get_isSuccessfulMatch() { }

	// RVA: 0x137F598
	bool get_hasMissingRequiredDevices() { }

	// RVA: 0x137F5A8
	bool get_hasMissingOptionalDevices() { }

	// RVA: 0x137F5B8
	UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x137F708
	Match get_Item(int index) { }

	// RVA: 0x137F7C8
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator() { }

	// RVA: 0x137F868
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x137F908
	void Dispose() { }

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
public struct DeviceRequirement 
{
	// Fields
	internal string m_ControlPath; // 0x10
	internal Flags m_Flags; // 0x18

	// Methods

	// RVA: 0x137FC24
	string get_controlPath() { }

	// RVA: 0x137FC2C
	void set_controlPath(string value) { }

	// RVA: 0x137FAB4
	bool get_isOptional() { }

	// RVA: 0x137FC34
	void set_isOptional(bool value) { }

	// RVA: 0x137FC48
	bool get_isAND() { }

	// RVA: 0x137FC64
	void set_isAND(bool value) { }

	// RVA: 0x137FC58
	bool get_isOR() { }

	// RVA: 0x137FC84
	void set_isOR(bool value) { }

	// RVA: 0x137FCA4
	string ToString() { }

	// RVA: 0x137FD80
	bool Equals(DeviceRequirement other) { }

	// RVA: 0x137FE08
	bool Equals(object obj) { }

	// RVA: 0x137FEDC
	int GetHashCode() { }

	// RVA: 0x137F1D0
	bool op_Equality(DeviceRequirement left, DeviceRequirement right) { }

	// RVA: 0x137FFE8
	bool op_Inequality(DeviceRequirement left, DeviceRequirement right) { }

}

// Namespace: 
public struct DeviceJson 
{
	// Fields
	public string devicePath; // 0x10
	public bool isOptional; // 0x18
	public bool isOR; // 0x19

	// Methods

	// RVA: 0x1380234
	DeviceRequirement ToDeviceEntry() { }

	// RVA: 0x138041C
	DeviceJson From(DeviceRequirement requirement) { }

}

// Namespace: 
internal struct SchemeJson 
{
	// Fields
	public string name; // 0x10
	public string bindingGroup; // 0x18
	public DeviceJson[] devices; // 0x20

	// Methods

	// RVA: 0x138004C
	InputControlScheme ToScheme() { }

	// RVA: 0x1380288
	SchemeJson ToJson(InputControlScheme scheme) { }

	// RVA: 0x1380464
	SchemeJson[] ToJson(InputControlScheme[] schemes) { }

	// RVA: 0x13805A0
	InputControlScheme[] ToSchemes(SchemeJson[] schemes) { }

}

// Namespace: UnityEngine.InputSystem
public struct InputControlScheme 
{
	// Fields
	internal string m_Name; // 0x10
	internal string m_BindingGroup; // 0x18
	internal DeviceRequirement[] m_DeviceRequirements; // 0x20

	// Methods

	// RVA: 0x137EC50
	string get_name() { }

	// RVA: 0x137EC58
	string get_bindingGroup() { }

	// RVA: 0x137EC60
	void set_bindingGroup(string value) { }

	// RVA: 0x137EC68
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements() { }

	// RVA: 0x137ECD4
	void .ctor(string name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, string bindingGroup) { }

	// RVA: 0x137EE08
	void SetNameAndBindingGroup(string name, string bindingGroup) { }

	// RVA: 0x309AF8C
	System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch) { }

	// RVA: 0x309AF8C
	bool FindControlSchemeForDevices(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch) { }

	// RVA: 0x309AF8C
	System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice(InputDevice device, TSchemes schemes) { }

	// RVA: 0x137EEEC
	bool SupportsDevice(InputDevice device) { }

	// RVA: 0x309AF8C
	MatchResult PickDevicesFrom(TDevices devices, InputDevice favorDevice) { }

	// RVA: 0x137F05C
	bool Equals(InputControlScheme other) { }

	// RVA: 0x137F238
	bool Equals(object obj) { }

	// RVA: 0x137F2E0
	int GetHashCode() { }

	// RVA: 0x137F378
	string ToString() { }

	// RVA: 0x137F51C
	bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	// RVA: 0x137F54C
	bool op_Inequality(InputControlScheme left, InputControlScheme right) { }

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

	// RVA: 0x13806B8
	InputAction get_action() { }

	// RVA: 0x13806E0
	InputControl get_control() { }

	// RVA: 0x1380708
	InputActionPhase get_phase() { }

	// RVA: 0x1380710
	Double get_time() { }

	// RVA: 0x1380718
	Double get_startTime() { }

	// RVA: 0x1380720
	bool get_timerHasExpired() { }

	// RVA: 0x138072C
	void set_timerHasExpired(bool value) { }

	// RVA: 0x138074C
	bool get_isWaiting() { }

	// RVA: 0x138075C
	bool get_isStarted() { }

	// RVA: 0x138076C
	float ComputeMagnitude() { }

	// RVA: 0x1380774
	bool ControlIsActuated(float threshold) { }

	// RVA: 0x1380780
	void Started() { }

	// RVA: 0x13807C0
	void Performed() { }

	// RVA: 0x1380808
	void PerformedAndStayStarted() { }

	// RVA: 0x1380850
	void PerformedAndStayPerformed() { }

	// RVA: 0x1380898
	void Canceled() { }

	// RVA: 0x13808E0
	void Waiting() { }

	// RVA: 0x1380928
	void SetTimeout(float seconds) { }

	// RVA: 0x1380950
	void SetTotalTimeoutCompletionTime(float seconds) { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x13809E4
	int get_mapIndex() { }

	// RVA: 0x13809EC
	int get_controlIndex() { }

	// RVA: 0x13809F8
	int get_bindingIndex() { }

	// RVA: 0x1380A00
	int get_interactionIndex() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputSystem.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputControl> <>9__79_0; // 0x8
	public static System.Func<UnityEngine.InputSystem.InputControl,System.Boolean> <>9__79_1; // 0x10

	// Methods

	// RVA: 0x1386C1C
	void .cctor() { }

	// RVA: 0x1386C88
	void .ctor() { }

	// RVA: 0x1386C90
	InputControl <get_onAnyButtonPress>b__79_0(InputEventPtr e) { }

	// RVA: 0x1386EEC
	bool <get_onAnyButtonPress>b__79_1(InputControl c) { }

}

// Namespace: UnityEngine.InputSystem
public static class InputSystem 
{
	// Fields
	internal const string kAssemblyVersion = 5736731536;
	internal const string kDocUrl = 5475814528;
	internal static InputManager s_Manager; // 0x0
	internal static InputRemoting s_Remote; // 0x8

	// Methods

	// RVA: 0x1380A0C
	void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x1380B4C
	void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x1380C8C
	void RegisterLayout(Type type, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x309AF8C
	void RegisterLayout(string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x1380E84
	void RegisterLayout(string json, string name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x1380FD4
	void RegisterLayoutOverride(string json, string name) { }

	// RVA: 0x1381070
	void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x309AF8C
	void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x1381108
	void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }

	// RVA: 0x2FE9A04
	void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x13812C4
	void RemoveLayout(string name) { }

	// RVA: 0x1381354
	string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x13813F0
	System.Collections.Generic.IEnumerable<System.String> ListLayouts() { }

	// RVA: 0x1381474
	System.Collections.Generic.IEnumerable<System.String> ListLayoutsBasedOn(string baseLayout) { }

	// RVA: 0x138153C
	InputControlLayout LoadLayout(string name) { }

	// RVA: 0x2FE704C
	InputControlLayout LoadLayout() { }

	// RVA: 0x1381628
	string GetNameOfBaseLayout(string layoutName) { }

	// RVA: 0x1381758
	bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	// RVA: 0x13818B8
	void RegisterProcessor(Type type, string name) { }

	// RVA: 0x2FE9A04
	void RegisterProcessor(string name) { }

	// RVA: 0x1381D50
	Type TryGetProcessor(string name) { }

	// RVA: 0x1381E30
	System.Collections.Generic.IEnumerable<System.String> ListProcessors() { }

	// RVA: 0x1381EC8
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x1381F48
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices() { }

	// RVA: 0x1382000
	void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x1382184
	void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x1382308
	void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x138248C
	void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x1382610
	void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x1382750
	void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x1382890
	float get_pollingFrequency() { }

	// RVA: 0x1382910
	void set_pollingFrequency(float value) { }

	// RVA: 0x13829A0
	InputDevice AddDevice(string layout, string name, string variants) { }

	// RVA: 0x309AF8C
	TDevice AddDevice(string name) { }

	// RVA: 0x1382AA4
	InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x1382BA4
	void AddDevice(InputDevice device) { }

	// RVA: 0x1382C60
	void RemoveDevice(InputDevice device) { }

	// RVA: 0x1382CF4
	void FlushDisconnectedDevices() { }

	// RVA: 0x1382D74
	InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x309AF8C
	TDevice GetDevice() { }

	// RVA: 0x1382E04
	InputDevice GetDevice(Type type) { }

	// RVA: 0x309AF8C
	TDevice GetDevice(InternedString usage) { }

	// RVA: 0x309AF8C
	TDevice GetDevice(string usage) { }

	// RVA: 0x138311C
	InputDevice GetDeviceById(int deviceId) { }

	// RVA: 0x13831AC
	System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices() { }

	// RVA: 0x13832B8
	int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x1383348
	void EnableDevice(InputDevice device) { }

	// RVA: 0x13833E0
	void DisableDevice(InputDevice device, bool keepSendingEvents) { }

	// RVA: 0x138347C
	bool TrySyncDevice(InputDevice device) { }

	// RVA: 0x1383640
	void ResetDevice(InputDevice device, bool alsoResetDontResetControls) { }

	// RVA: 0x13836DC
	bool TryResetDevice(InputDevice device) { }

	// RVA: 0x1383830
	void PauseHaptics() { }

	// RVA: 0x13839F0
	void ResumeHaptics() { }

	// RVA: 0x1383BB4
	void ResetHaptics() { }

	// RVA: 0x1383D78
	void SetDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x1383E80
	void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x1383F28
	void AddDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x1383FCC
	void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x1384074
	void RemoveDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x1384118
	void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13841C0
	InputControl FindControl(string path) { }

	// RVA: 0x1384340
	UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(string path) { }

	// RVA: 0x309AF8C
	UnityEngine.InputSystem.InputControlList<TControl> FindControls(string path) { }

	// RVA: 0x2FE6628
	int FindControls(string path, ref UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x13843D4
	bool get_isProcessingEvents() { }

	// RVA: 0x1384454
	InputEventListener get_onEvent() { }

	// RVA: 0x138445C
	void set_onEvent(InputEventListener value) { }

	// RVA: 0x1384460
	System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress() { }

	// RVA: 0x13846A0
	void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x2FE9A04
	void QueueEvent(ref TEvent inputEvent) { }

	// RVA: 0x309AF8C
	void QueueStateEvent(InputDevice device, TState state, Double time) { }

	// RVA: 0x309AF8C
	void QueueDeltaStateEvent(InputControl control, TDelta delta, Double time) { }

	// RVA: 0x1384788
	void QueueConfigChangeEvent(InputDevice device, Double time) { }

	// RVA: 0x13849B4
	void QueueTextEvent(InputDevice device, Char character, Double time) { }

	// RVA: 0x1384BF0
	void Update() { }

	// RVA: 0x1384C70
	void Update(InputUpdateType updateType) { }

	// RVA: 0x1384E4C
	void add_onBeforeUpdate(Action value) { }

	// RVA: 0x1384F8C
	void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x13850CC
	void add_onAfterUpdate(Action value) { }

	// RVA: 0x138520C
	void remove_onAfterUpdate(Action value) { }

	// RVA: 0x1384DCC
	InputSettings get_settings() { }

	// RVA: 0x138534C
	void set_settings(InputSettings value) { }

	// RVA: 0x13854D0
	void add_onSettingsChange(Action value) { }

	// RVA: 0x1385560
	void remove_onSettingsChange(Action value) { }

	// RVA: 0x13855F0
	void EnableActions() { }

	// RVA: 0x138583C
	void DisableActions(bool triggerSetupChanged) { }

	// RVA: 0x13857B0
	InputActionAsset get_actions() { }

	// RVA: 0x13859A4
	void set_actions(InputActionAsset value) { }

	// RVA: 0x1385B1C
	void add_onActionsChange(Action value) { }

	// RVA: 0x1385BAC
	void remove_onActionsChange(Action value) { }

	// RVA: 0x1385C3C
	void add_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x1385CF4
	void remove_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }

	// RVA: 0x1385DAC
	void RegisterInteraction(Type type, string name) { }

	// RVA: 0x2FE9A04
	void RegisterInteraction(string name) { }

	// RVA: 0x1385F64
	Type TryGetInteraction(string name) { }

	// RVA: 0x1386044
	System.Collections.Generic.IEnumerable<System.String> ListInteractions() { }

	// RVA: 0x13860DC
	void RegisterBindingComposite(Type type, string name) { }

	// RVA: 0x2FE9A04
	void RegisterBindingComposite(string name) { }

	// RVA: 0x1386294
	Type TryGetBindingComposite(string name) { }

	// RVA: 0x1386374
	void DisableAllEnabledActions() { }

	// RVA: 0x138637C
	System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions() { }

	// RVA: 0x138646C
	int ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions) { }

	// RVA: 0x13864CC
	InputRemoting get_remoting() { }

	// RVA: 0x1386548
	Version get_version() { }

	// RVA: 0x13865C0
	bool get_runInBackground() { }

	// RVA: 0x13866C4
	void set_runInBackground(bool value) { }

	// RVA: 0x13867C8
	InputMetrics get_metrics() { }

	// RVA: 0x1386880
	void .cctor() { }

	// RVA: 0x1386A6C
	void RunInitializeInPlayer() { }

	// RVA: 0x1386B18
	void EnsureInitialized() { }

	// RVA: 0x138688C
	void InitializeInPlayer(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x1386B50
	void RunInitialUpdate() { }

	// RVA: 0x1386B1C
	void PerformDefaultPluginInitialization() { }

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

	// RVA: 0x1386EF8
	void .cctor() { }

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

	// RVA: 0x13876FC
	string get_name() { }

	// RVA: 0x138770C
	string get_displayName() { }

	// RVA: 0x13877B4
	void set_displayName(string value) { }

	// RVA: 0x13877BC
	string get_shortDisplayName() { }

	// RVA: 0x1387820
	void set_shortDisplayName(string value) { }

	// RVA: 0x1387828
	string get_path() { }

	// RVA: 0x1387A28
	string get_layout() { }

	// RVA: 0x1387A38
	string get_variants() { }

	// RVA: 0x1387A48
	InputDevice get_device() { }

	// RVA: 0x1387A50
	InputControl get_parent() { }

	// RVA: 0x1387A58
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children() { }

	// RVA: 0x1387ACC
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x1387B40
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x1387BB4
	InputStateBlock get_stateBlock() { }

	// RVA: 0x1387BC0
	bool get_noisy() { }

	// RVA: 0x1387BCC
	void set_noisy(bool value) { }

	// RVA: 0x1387D04
	bool get_synthetic() { }

	// RVA: 0x1387D10
	void set_synthetic(bool value) { }

	// RVA: 0x1387D30
	InputControl get_Item(string path) { }

	// RVA: 0x2FE360C
	Type get_valueType() { }

	// RVA: 0x2FE32D4
	int get_valueSizeInBytes() { }

	// RVA: 0x1387E5C
	float get_magnitude() { }

	// RVA: 0x1387ECC
	string ToString() { }

	// RVA: 0x1387F74
	string DebuggerDisplay() { }

	// RVA: 0x1387E94
	float EvaluateMagnitude() { }

	// RVA: 0x1388178
	float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x309AF8C
	object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x309AF8C
	object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x309AF8C
	void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x1388180
	void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x13881E4
	void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: 0x309AF8C
	bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x1388248
	InputControl TryGetChildControl(string path) { }

	// RVA: 0x309AF8C
	TControl TryGetChildControl(string path) { }

	// RVA: 0x1388300
	InputControl GetChildControl(string path) { }

	// RVA: 0x309AF8C
	TControl GetChildControl(string path) { }

	// RVA: 0x1388514
	void .ctor() { }

	// RVA: 0x13885A4
	void FinishSetup() { }

	// RVA: 0x1387774
	void RefreshConfigurationIfNeeded() { }

	// RVA: 0x13885C8
	void RefreshConfiguration() { }

	// RVA: 0x1388160
	Void* get_currentStatePtr() { }

	// RVA: 0x138872C
	Void* get_previousFrameStatePtr() { }

	// RVA: 0x1388744
	Void* get_defaultStatePtr() { }

	// RVA: 0x1388790
	Void* get_noiseMaskPtr() { }

	// RVA: 0x13887DC
	UInt32 get_stateOffsetRelativeToDeviceRoot() { }

	// RVA: 0x1388860
	FourCC get_optimizedControlDataType() { }

	// RVA: 0x1388868
	FourCC CalculateOptimizedControlDataType() { }

	// RVA: 0x1388870
	void ApplyParameterChanges() { }

	// RVA: 0x1388D3C
	void SetOptimizedControlDataType() { }

	// RVA: 0x1388DD0
	void SetOptimizedControlDataTypeRecursively() { }

	// RVA: 0x1389000
	void EnsureOptimizationTypeHasNotChanged() { }

	// RVA: 0x1389428
	bool get_isSetupFinished() { }

	// RVA: 0x1389434
	void set_isSetupFinished(bool value) { }

	// RVA: 0x1389454
	bool get_isButton() { }

	// RVA: 0x1389460
	void set_isButton(bool value) { }

	// RVA: 0x13885A8
	bool get_isConfigUpToDate() { }

	// RVA: 0x13885B4
	void set_isConfigUpToDate(bool value) { }

	// RVA: 0x1389480
	bool get_dontReset() { }

	// RVA: 0x138948C
	void set_dontReset(bool value) { }

	// RVA: 0x13894AC
	bool get_usesStateFromOtherControl() { }

	// RVA: 0x13894B8
	void set_usesStateFromOtherControl(bool value) { }

	// RVA: 0x13894D8
	bool get_hasDefaultState() { }

	// RVA: 0x13894F8
	void CallFinishSetupRecursive() { }

	// RVA: 0x1388418
	string MakeChildPath(string path) { }

	// RVA: 0x1389624
	void BakeOffsetIntoStateBlockRecursive(UInt32 offset) { }

	// RVA: 0x13885CC
	int GetDeviceIndex() { }

	// RVA: 0x1389780
	bool IsValueConsideredPressed(float value) { }

	// RVA: 0x1389834
	void AddProcessor(object first) { }

	// RVA: 0x1389838
	void MarkAsStale() { }

	// RVA: 0x1388B88
	void MarkAsStaleRecursively() { }

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

	// RVA: 0x2FE360C
	Type get_valueType() { }

	// RVA: 0x2FE32D4
	int get_valueSizeInBytes() { }

	// RVA: 0x2FE360C
	ref TValue get_value() { }

	// RVA: 0x2FE360C
	ref TValue get_unprocessedValue() { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x309AF8C
	TValue ReadValueFromPreviousFrame() { }

	// RVA: 0x309AF8C
	TValue ReadDefaultValue() { }

	// RVA: 0x309AF8C
	TValue ReadValueFromState(Void* statePtr) { }

	// RVA: 0x309AF8C
	TValue ReadValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x309AF8C
	TValue ReadUnprocessedValueFromStateWithCaching(Void* statePtr) { }

	// RVA: 0x309AF8C
	TValue ReadUnprocessedValue() { }

	// RVA: 0x309AF8C
	TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x309AF8C
	object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x309AF8C
	void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x309AF8C
	void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	// RVA: 0x309AF8C
	void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	// RVA: 0x309AF8C
	void WriteValueIntoState(TValue value, Void* statePtr) { }

	// RVA: 0x309AF8C
	object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x2FE59C8
	bool CompareValue(ref TValue firstValue, ref TValue secondValue) { }

	// RVA: 0x309AF8C
	bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x309AF8C
	TValue ProcessValue(TValue value) { }

	// RVA: 0x2FE4574
	void ProcessValue(ref TValue value) { }

	// RVA: 0x309AF8C
	TProcessor TryGetProcessor() { }

	// RVA: 0x2FE4574
	void AddProcessor(object processor) { }

	// RVA: 0x2FE41A8
	void FinishSetup() { }

	// RVA: 0x2FE360C
	UnityEngine.InputSystem.InputProcessor<TValue>[] get_processors() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

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

	// RVA: 0x138BF40
	InputEventPtr get_eventPtr() { }

	// RVA: 0x138B6BC
	InputEventControlEnumerator GetEnumerator() { }

	// RVA: 0x138C140
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x138C1E8
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x138BF48
	void .ctor(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold) { }

	// RVA: 0x138C70C
	bool CheckDefault(UInt32 numBits) { }

	// RVA: 0x138C72C
	bool CheckCurrent(UInt32 numBits) { }

	// RVA: 0x138B6E4
	bool MoveNext() { }

	// RVA: 0x138C290
	void Reset() { }

	// RVA: 0x138C764
	void Dispose() { }

	// RVA: 0x138C76C
	InputControl get_Current() { }

	// RVA: 0x138C774
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ControlBuilder 
{
	// Fields
	private InputControl <control>k__BackingField; // 0x10

	// Methods

	// RVA: 0x138C77C
	InputControl get_control() { }

	// RVA: 0x138C784
	void set_control(InputControl value) { }

	// RVA: 0x138C78C
	ControlBuilder At(InputDevice device, int index) { }

	// RVA: 0x138C8D4
	ControlBuilder WithParent(InputControl parent) { }

	// RVA: 0x138C908
	ControlBuilder WithName(string name) { }

	// RVA: 0x138C960
	ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x138C9C0
	ControlBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x138CA20
	ControlBuilder WithLayout(InternedString layout) { }

	// RVA: 0x138CA58
	ControlBuilder WithUsages(int startIndex, int count) { }

	// RVA: 0x138CA78
	ControlBuilder WithAliases(int startIndex, int count) { }

	// RVA: 0x138CA98
	ControlBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x138CAB8
	ControlBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x138CADC
	ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x138CB38
	ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) { }

	// RVA: 0x309AF8C
	ControlBuilder WithProcessor(TProcessor processor) { }

	// RVA: 0x138CB68
	ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x138CB98
	ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x138CBD0
	ControlBuilder DontReset(bool value) { }

	// RVA: 0x138CC40
	ControlBuilder IsButton(bool value) { }

	// RVA: 0x138CC78
	void Finish() { }

}

// Namespace: 
public struct DeviceBuilder 
{
	// Fields
	private InputDevice <device>k__BackingField; // 0x10

	// Methods

	// RVA: 0x138CCA0
	InputDevice get_device() { }

	// RVA: 0x138CCA8
	void set_device(InputDevice value) { }

	// RVA: 0x138CCB0
	DeviceBuilder WithName(string name) { }

	// RVA: 0x138CD08
	DeviceBuilder WithDisplayName(string displayName) { }

	// RVA: 0x138CD68
	DeviceBuilder WithShortDisplayName(string shortDisplayName) { }

	// RVA: 0x138CDC8
	DeviceBuilder WithLayout(InternedString layout) { }

	// RVA: 0x138CE00
	DeviceBuilder WithChildren(int startIndex, int count) { }

	// RVA: 0x138CE20
	DeviceBuilder WithStateBlock(InputStateBlock stateBlock) { }

	// RVA: 0x138CE44
	DeviceBuilder IsNoisy(bool value) { }

	// RVA: 0x138CE74
	DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) { }

	// RVA: 0x138CFF4
	DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) { }

	// RVA: 0x138D048
	DeviceBuilder WithStateOffsetToControlIndexMap(UInt32[] map) { }

	// RVA: 0x138D080
	DeviceBuilder WithControlTree(Byte[] controlTreeNodes, UInt16[] controlTreeIndicies) { }

	// RVA: 0x138D368
	void Finish() { }

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

	// RVA: 0x138BBD0
	void .ctor(int <>1__state) { }

	// RVA: 0x138D390
	void System.IDisposable.Dispose() { }

	// RVA: 0x138D3B0
	bool MoveNext() { }

	// RVA: 0x138D690
	void <>m__Finally1() { }

	// RVA: 0x138D6A0
	InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current() { }

	// RVA: 0x138D6A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x138D6E8
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x138D6F0
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

	// RVA: 0x138D7A0
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputControlExtensions 
{
	// Methods

	// RVA: 0x309AF8C
	TControl FindInParentChain(InputControl control) { }

	// RVA: 0x1389844
	bool IsPressed(InputControl control, float buttonPressPoint) { }

	// RVA: 0x13899A4
	bool IsActuated(InputControl control, float threshold) { }

	// RVA: 0x13880DC
	object ReadValueAsObject(InputControl control) { }

	// RVA: 0x1389BB0
	void ReadValueIntoBuffer(InputControl control, Void* buffer, int bufferSize) { }

	// RVA: 0x1389C70
	object ReadDefaultValueAsObject(InputControl control) { }

	// RVA: 0x309AF8C
	TValue ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent) { }

	// RVA: -1
	bool ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }

	// RVA: 0x1389D18
	object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	// RVA: 0x309AF8C
	TValue ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr eventPtr) { }

	// RVA: -1
	bool ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }

	// RVA: 0x1389E6C
	void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	// RVA: 0x1389F00
	void WriteValueIntoState(InputControl control, Void* statePtr) { }

	// RVA: 0x309AF8C
	void WriteValueIntoState(InputControl control, TValue value, Void* statePtr) { }

	// RVA: 0x309AF8C
	void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Void* statePtr) { }

	// RVA: 0x309AF8C
	void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, Void* statePtr) { }

	// RVA: 0x309AF8C
	void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, ref TState state) { }

	// RVA: 0x309AF8C
	void WriteValueIntoEvent(InputControl control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x309AF8C
	void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }

	// RVA: 0x138A088
	void CopyState(InputDevice device, Void* buffer, int bufferSizeInBytes) { }

	// RVA: 0x2FEAB7C
	void CopyState(InputDevice device, out TState state) { }

	// RVA: 0x1389B30
	bool CheckStateIsAtDefault(InputControl control) { }

	// RVA: 0x138A224
	bool CheckStateIsAtDefault(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x138A49C
	bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	// RVA: 0x138A518
	bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x138A5EC
	bool CompareStateIgnoringNoise(InputControl control, Void* statePtr) { }

	// RVA: 0x138A300
	bool CompareState(InputControl control, Void* firstStatePtr, Void* secondStatePtr, Void* maskPtr) { }

	// RVA: 0x138A6D4
	bool CompareState(InputControl control, Void* statePtr, Void* maskPtr) { }

	// RVA: 0x138A78C
	bool HasValueChangeInState(InputControl control, Void* statePtr) { }

	// RVA: 0x138A83C
	bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1389DA8
	Void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x138A91C
	Void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	// RVA: 0x138AC44
	bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x309AF8C
	void QueueValueChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x138AE18
	void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<System.Single> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x138AF28
	void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, Void* currentStatePtr, InputEventPtr newState) { }

	// RVA: 0x2FEB028
	void FindControlsRecursive(InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl,System.Boolean> predicate) { }

	// RVA: 0x138B03C
	string BuildPath(InputControl control, string deviceLayout, StringBuilder builder) { }

	// RVA: 0x138B3D0
	InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x138B65C
	InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device, float magnitudeThreshold) { }

	// RVA: 0x138B6A0
	bool HasButtonPress(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x1386CA0
	InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x138BB3C
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude, bool buttonControlsOnly) { }

	// RVA: 0x138BC08
	ControlBuilder Setup(InputControl control) { }

	// RVA: 0x138BCE8
	DeviceBuilder Setup(InputDevice device, int controlCount, int usageCount, int aliasCount) { }

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

	// RVA: 0x309AF8C
	void .ctor(UnityEngine.InputSystem.InputControlList<TControl> list) { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	TControl get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

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

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE32D4
	int get_Capacity() { }

	// RVA: 0x2FE42A4
	void set_Capacity(int value) { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x309AF8C
	TControl get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, TControl value) { }

	// RVA: 0x2FE4314
	void .ctor(Allocator allocator, int initialCapacity) { }

	// RVA: 0x2FE45DC
	void .ctor(System.Collections.Generic.IEnumerable<TControl> values, Allocator allocator) { }

	// RVA: 0x2FE4574
	void .ctor(TControl[] values) { }

	// RVA: 0x2FE42A4
	void Resize(int size) { }

	// RVA: 0x309AF8C
	void Add(TControl item) { }

	// RVA: 0x309AF8C
	void AddSlice(TList list, int count, int destinationIndex, int sourceIndex) { }

	// RVA: -1
	void AddRange(System.Collections.Generic.IEnumerable<TControl> list, int count, int destinationIndex) { }

	// RVA: 0x309AF8C
	bool Remove(TControl item) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int index) { }

	// RVA: 0x2FE45DC
	void CopyTo(TControl[] array, int arrayIndex) { }

	// RVA: 0x309AF8C
	int IndexOf(TControl item) { }

	// RVA: 0x309AF8C
	int IndexOf(TControl item, int startIndex, int count) { }

	// RVA: 0x309AF8C
	void Insert(int index, TControl item) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(TControl item) { }

	// RVA: 0x309AF8C
	bool Contains(TControl item, int startIndex, int count) { }

	// RVA: 0x2FE4314
	void SwapElements(int index1, int index2) { }

	// RVA: 0x309AF8C
	void Sort(int startIndex, int count, TCompare comparer) { }

	// RVA: -1
	TControl[] ToArray(bool dispose) { }

	// RVA: 0x2FE47D4
	void AppendTo(ref TControl[] array, ref int count) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TControl> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE360C
	string ToString() { }

	// RVA: 0x309AF8C
	UInt64 ToIndex(TControl control) { }

	// RVA: 0x309AF8C
	TControl FromIndex(UInt64 index) { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputControlPath.ParsedPathComponent.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.Substring,System.String> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x1391144
	void .cctor() { }

	// RVA: 0x13911B0
	void .ctor() { }

	// RVA: 0x13911B8
	string <get_usages>b__7_0(Substring x) { }

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

	// RVA: 0x1390D7C
	string get_layout() { }

	// RVA: 0x1390D84
	System.Collections.Generic.IEnumerable<System.String> get_usages() { }

	// RVA: 0x1390ED8
	string get_name() { }

	// RVA: 0x1390EE4
	string get_displayName() { }

	// RVA: 0x138F1B0
	bool get_isWildcard() { }

	// RVA: 0x1390EF0
	bool get_isDoubleWildcard() { }

	// RVA: 0x138E364
	string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options) { }

	// RVA: 0x1390F60
	string ToHumanReadableString(Substring substring) { }

	// RVA: 0x13903B8
	bool Matches(InputControl control) { }

	// RVA: 0x1390FC8
	bool ComparePathElementToString(Substring pathElement, string element) { }

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

	// RVA: 0x138F9BC
	bool get_isAtEnd() { }

	// RVA: 0x138E018
	void .ctor(string path) { }

	// RVA: 0x138E06C
	bool MoveToNextComponent() { }

	// RVA: 0x13911E0
	Substring ParseComponentPart(Char terminator) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputControlPath.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.Substring,System.String> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x13912E0
	void .cctor() { }

	// RVA: 0x139134C
	void .ctor() { }

	// RVA: 0x1391354
	string <TryGetDeviceUsages>b__9_0(Substring x) { }

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

	// RVA: 0x1390D44
	void .ctor(int <>1__state) { }

	// RVA: 0x139137C
	void System.IDisposable.Dispose() { }

	// RVA: 0x1391380
	bool MoveNext() { }

	// RVA: 0x1391504
	ParsedPathComponent System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.get_Current() { }

	// RVA: 0x1391528
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1391568
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13915E8
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent>.GetEnumerator() { }

	// RVA: 0x1391690
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputControlPath 
{
	// Fields
	public const string Wildcard = 5736712672;
	public const string DoubleWildcard = 5736712640;
	public const Char Separator = 47;
	internal const Char SeparatorReplacement = 32;

	// Methods

	// RVA: 0x138D850
	string CleanSlashes(string pathComponent) { }

	// RVA: 0x1387898
	string Combine(InputControl parent, string path) { }

	// RVA: 0x138D870
	string ToHumanReadableString(string path, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x138D8A0
	string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options, InputControl control) { }

	// RVA: 0x138EE2C
	string[] TryGetDeviceUsages(string path) { }

	// RVA: 0x138EFF4
	string TryGetDeviceLayout(string path) { }

	// RVA: 0x138F220
	string TryGetControlLayout(string path) { }

	// RVA: 0x138F530
	string FindControlLayoutRecursive(ref PathParser parser, string layoutName) { }

	// RVA: 0x138F690
	string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout) { }

	// RVA: 0x138F840
	bool ControlLayoutMatchesPathComponent(ref ControlItem controlItem, ref PathParser parser) { }

	// RVA: 0x138F9D0
	bool StringMatches(Substring str, InternedString matchTo) { }

	// RVA: 0x137EFF0
	InputControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x138FC84
	InputControl[] TryFindControls(InputControl control, string path, int indexInPath) { }

	// RVA: 0x138FDD8
	int TryFindControls(InputControl control, string path, ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& matches, int indexInPath) { }

	// RVA: 0x309AF8C
	TControl TryFindControl(InputControl control, string path, int indexInPath) { }

	// RVA: 0x309AF8C
	int TryFindControls(InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl>& matches) { }

	// RVA: 0x1387DF0
	InputControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x309AF8C
	TControl TryFindChild(InputControl control, string path, int indexInPath) { }

	// RVA: 0x138DF24
	bool Matches(string expected, InputControl control) { }

	// RVA: 0x138FEC4
	bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref ControlItem controlItem, bool matchAlias) { }

	// RVA: 0x1390298
	bool MatchesPrefix(string expected, InputControl control) { }

	// RVA: 0x138FE4C
	bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly) { }

	// RVA: 0x309AF8C
	TControl MatchControlsRecursive(InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x309AF8C
	TControl MatchByUsageAtDeviceRootRecursive(InputDevice device, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x309AF8C
	TControl MatchChildrenRecursive(InputControl control, string path, int indexInPath, ref UnityEngine.InputSystem.InputControlList<TControl>& matches, bool matchMultiple) { }

	// RVA: 0x1390904
	bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent) { }

	// RVA: 0x1390BC0
	bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	// RVA: 0x1390CBC
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(string path) { }

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

	// RVA: 0x2FE37A0
	object ProcessAsObject(object value, InputControl control) { }

	// RVA: 0x309AF8C
	void Process(Void* buffer, int bufferSize, InputControl control) { }

	// RVA: 0x1391694
	Type GetValueTypeFromType(Type processorType) { }

	// RVA: 0x13917B0
	CachingPolicy get_cachingPolicy() { }

	// RVA: 0x13917B8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public abstract class InputProcessor<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	TValue Process(TValue value, InputControl control) { }

	// RVA: 0x2FE37A0
	object ProcessAsObject(object value, InputControl control) { }

	// RVA: 0x309AF8C
	void Process(Void* buffer, int bufferSize, InputControl control) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

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

	// RVA: 0x13917C0
	ButtonControl get_buttonWest() { }

	// RVA: 0x13917C8
	void set_buttonWest(ButtonControl value) { }

	// RVA: 0x13917D8
	ButtonControl get_buttonNorth() { }

	// RVA: 0x13917E0
	void set_buttonNorth(ButtonControl value) { }

	// RVA: 0x13917F0
	ButtonControl get_buttonSouth() { }

	// RVA: 0x13917F8
	void set_buttonSouth(ButtonControl value) { }

	// RVA: 0x1391808
	ButtonControl get_buttonEast() { }

	// RVA: 0x1391810
	void set_buttonEast(ButtonControl value) { }

	// RVA: 0x1391820
	ButtonControl get_leftStickButton() { }

	// RVA: 0x1391828
	void set_leftStickButton(ButtonControl value) { }

	// RVA: 0x1391838
	ButtonControl get_rightStickButton() { }

	// RVA: 0x1391840
	void set_rightStickButton(ButtonControl value) { }

	// RVA: 0x1391850
	ButtonControl get_startButton() { }

	// RVA: 0x1391858
	void set_startButton(ButtonControl value) { }

	// RVA: 0x1391868
	ButtonControl get_selectButton() { }

	// RVA: 0x1391870
	void set_selectButton(ButtonControl value) { }

	// RVA: 0x1391880
	DpadControl get_dpad() { }

	// RVA: 0x1391888
	void set_dpad(DpadControl value) { }

	// RVA: 0x1391898
	ButtonControl get_leftShoulder() { }

	// RVA: 0x13918A0
	void set_leftShoulder(ButtonControl value) { }

	// RVA: 0x13918B0
	ButtonControl get_rightShoulder() { }

	// RVA: 0x13918B8
	void set_rightShoulder(ButtonControl value) { }

	// RVA: 0x13918C8
	StickControl get_leftStick() { }

	// RVA: 0x13918D0
	void set_leftStick(StickControl value) { }

	// RVA: 0x13918E0
	StickControl get_rightStick() { }

	// RVA: 0x13918E8
	void set_rightStick(StickControl value) { }

	// RVA: 0x13918F8
	ButtonControl get_leftTrigger() { }

	// RVA: 0x1391900
	void set_leftTrigger(ButtonControl value) { }

	// RVA: 0x1391910
	ButtonControl get_rightTrigger() { }

	// RVA: 0x1391918
	void set_rightTrigger(ButtonControl value) { }

	// RVA: 0x1391928
	ButtonControl get_aButton() { }

	// RVA: 0x1391930
	ButtonControl get_bButton() { }

	// RVA: 0x1391938
	ButtonControl get_xButton() { }

	// RVA: 0x1391940
	ButtonControl get_yButton() { }

	// RVA: 0x1391948
	ButtonControl get_triangleButton() { }

	// RVA: 0x1391950
	ButtonControl get_squareButton() { }

	// RVA: 0x1391958
	ButtonControl get_circleButton() { }

	// RVA: 0x1391960
	ButtonControl get_crossButton() { }

	// RVA: 0x1391968
	ButtonControl get_Item(GamepadButton button) { }

	// RVA: 0x1391BC4
	Gamepad get_current() { }

	// RVA: 0x1391C10
	void set_current(Gamepad value) { }

	// RVA: 0x1391C74
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all() { }

	// RVA: 0x1391D00
	void FinishSetup() { }

	// RVA: 0x1392094
	void MakeCurrent() { }

	// RVA: 0x13920F4
	void OnAdded() { }

	// RVA: 0x1392170
	void OnRemoved() { }

	// RVA: 0x139229C
	void PauseHaptics() { }

	// RVA: 0x13922AC
	void ResumeHaptics() { }

	// RVA: 0x13922BC
	void ResetHaptics() { }

	// RVA: 0x13922CC
	void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x13922DC
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x13941D8
	void .ctor(UInt16 endOffset) { }

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

	// RVA: 0x13923E4
	InputDeviceDescription get_description() { }

	// RVA: 0x1392400
	bool get_enabled() { }

	// RVA: 0x139259C
	bool get_canRunInBackground() { }

	// RVA: 0x13835AC
	bool get_added() { }

	// RVA: 0x139266C
	bool get_remote() { }

	// RVA: 0x1392678
	bool get_native() { }

	// RVA: 0x1392684
	bool get_updateBeforeRender() { }

	// RVA: 0x1392690
	int get_deviceId() { }

	// RVA: 0x1392698
	Double get_lastUpdateTime() { }

	// RVA: 0x13926F8
	bool get_wasUpdatedThisFrame() { }

	// RVA: 0x139275C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls() { }

	// RVA: 0x13927C8
	Type get_valueType() { }

	// RVA: 0x1392868
	int get_valueSizeInBytes() { }

	// RVA: 0x13928F0
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all() { }

	// RVA: 0x1392360
	void .ctor() { }

	// RVA: 0x13929B8
	object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	// RVA: 0x13929F8
	object ReadValueFromStateAsObject(Void* statePtr) { }

	// RVA: 0x1392B0C
	void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	// RVA: 0x1392CD0
	bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x1392DD4
	void NotifyConfigurationChanged() { }

	// RVA: 0x13920F0
	void MakeCurrent() { }

	// RVA: 0x1392E44
	void OnAdded() { }

	// RVA: 0x1392E48
	void OnRemoved() { }

	// RVA: 0x1392E4C
	void OnConfigurationChanged() { }

	// RVA: -1
	Int64 ExecuteCommand(ref TCommand command) { }

	// RVA: 0x1392E50
	Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x13924D0
	bool QueryEnabledStateFromRuntime() { }

	// RVA: 0x1392F2C
	bool get_disabledInFrontend() { }

	// RVA: 0x1392F38
	void set_disabledInFrontend(bool value) { }

	// RVA: 0x1392F58
	bool get_disabledInRuntime() { }

	// RVA: 0x1392F64
	void set_disabledInRuntime(bool value) { }

	// RVA: 0x1392F84
	bool get_disabledWhileInBackground() { }

	// RVA: 0x1392F90
	void set_disabledWhileInBackground(bool value) { }

	// RVA: 0x1392FB0
	UInt32 EncodeStateOffsetToControlMapEntry(UInt32 controlIndex, UInt32 stateOffsetInBits, UInt32 stateSizeInBits) { }

	// RVA: 0x138C748
	void DecodeStateOffsetToControlMapEntry(UInt32 entry, out UInt32 controlIndex, out UInt32 stateOffset, out UInt32 stateSize) { }

	// RVA: 0x1392FBC
	bool get_hasControlsWithDefaultState() { }

	// RVA: 0x138CB18
	void set_hasControlsWithDefaultState(bool value) { }

	// RVA: 0x1392FC8
	bool get_hasDontResetControls() { }

	// RVA: 0x138CC20
	void set_hasDontResetControls(bool value) { }

	// RVA: 0x138AC38
	bool get_hasStateCallbacks() { }

	// RVA: 0x1392FD4
	void set_hasStateCallbacks(bool value) { }

	// RVA: 0x1392FF4
	bool get_hasEventMerger() { }

	// RVA: 0x1393000
	void set_hasEventMerger(bool value) { }

	// RVA: 0x1393020
	bool get_hasEventPreProcessor() { }

	// RVA: 0x139302C
	void set_hasEventPreProcessor(bool value) { }

	// RVA: 0x139304C
	void AddDeviceUsage(InternedString usage) { }

	// RVA: 0x139310C
	void RemoveDeviceUsage(InternedString usage) { }

	// RVA: 0x139320C
	void ClearDeviceUsages() { }

	// RVA: 0x13835BC
	bool RequestSync() { }

	// RVA: 0x13837AC
	bool RequestReset() { }

	// RVA: 0x1393270
	bool ExecuteEnableCommand() { }

	// RVA: 0x13932F4
	bool ExecuteDisableCommand() { }

	// RVA: 0x139336C
	void NotifyAdded() { }

	// RVA: 0x139337C
	void NotifyRemoved() { }

	// RVA: 0x309AF8C
	TDevice Build(string layoutName, string layoutVariants, InputDeviceDescription deviceDescription, bool noPrecompiledLayouts) { }

	// RVA: 0x139338C
	void WriteChangedControlStates(Byte* deviceStateBuffer, Void* statePtr, UInt32 stateSizeInBytes, UInt32 stateOffsetInDevice) { }

	// RVA: 0x13934E8
	void WritePartialChangedControlStatesInternal(Void* statePtr, UInt32 stateSizeInBits, UInt32 stateOffsetInDeviceInBits, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x1393AD4
	void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, UInt32 startOffset, UInt32 sizeInBits, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x1393F5C
	void DumpControlTree(ControlBitRangeNode parentNode, UInt32 startOffset, System.Collections.Generic.List<System.String> output) { }

	// RVA: 0x139408C
	string DumpControlTree() { }

	// RVA: 0x1393784
	void WriteChangedControlStatesInternal(Void* statePtr, UInt32 stateSizeInBits, Byte* deviceStatePtr, ControlBitRangeNode parentNode, UInt32 startOffset) { }

	// RVA: 0x139415C
	bool HasDataChangedInRange(Byte* deviceStatePtr, Void* statePtr, UInt32 startOffset, UInt32 sizeInBits) { }

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

	// RVA: 0x13941EC
	ButtonControl get_trigger() { }

	// RVA: 0x13941F4
	void set_trigger(ButtonControl value) { }

	// RVA: 0x1394204
	StickControl get_stick() { }

	// RVA: 0x139420C
	void set_stick(StickControl value) { }

	// RVA: 0x139421C
	AxisControl get_twist() { }

	// RVA: 0x1394224
	void set_twist(AxisControl value) { }

	// RVA: 0x1394234
	Vector2Control get_hatswitch() { }

	// RVA: 0x139423C
	void set_hatswitch(Vector2Control value) { }

	// RVA: 0x139424C
	Joystick get_current() { }

	// RVA: 0x1394298
	void set_current(Joystick value) { }

	// RVA: 0x13942FC
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all() { }

	// RVA: 0x1394388
	void FinishSetup() { }

	// RVA: 0x13944F4
	void MakeCurrent() { }

	// RVA: 0x1394550
	void OnAdded() { }

	// RVA: 0x13945CC
	void OnRemoved() { }

	// RVA: 0x13946F8
	void .ctor() { }

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

	// RVA: 0x139477C
	void add_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x139486C
	void remove_onTextInput(System.Action<System.Char> value) { }

	// RVA: 0x13948C8
	void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x13949B4
	void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }

	// RVA: 0x1394A10
	void SetIMEEnabled(bool enabled) { }

	// RVA: 0x1394A8C
	void SetIMECursorPosition(Vector2 position) { }

	// RVA: 0x1394B40
	string get_keyboardLayout() { }

	// RVA: 0x1394B88
	void set_keyboardLayout(string value) { }

	// RVA: 0x1394B98
	AnyKeyControl get_anyKey() { }

	// RVA: 0x1394BA0
	void set_anyKey(AnyKeyControl value) { }

	// RVA: 0x1394BB0
	KeyControl get_spaceKey() { }

	// RVA: 0x1394CB4
	KeyControl get_enterKey() { }

	// RVA: 0x1394D30
	KeyControl get_tabKey() { }

	// RVA: 0x1394DAC
	KeyControl get_backquoteKey() { }

	// RVA: 0x1394E28
	KeyControl get_quoteKey() { }

	// RVA: 0x1394EA4
	KeyControl get_semicolonKey() { }

	// RVA: 0x1394F20
	KeyControl get_commaKey() { }

	// RVA: 0x1394F9C
	KeyControl get_periodKey() { }

	// RVA: 0x1395018
	KeyControl get_slashKey() { }

	// RVA: 0x1395094
	KeyControl get_backslashKey() { }

	// RVA: 0x1395110
	KeyControl get_leftBracketKey() { }

	// RVA: 0x139518C
	KeyControl get_rightBracketKey() { }

	// RVA: 0x1395208
	KeyControl get_minusKey() { }

	// RVA: 0x1395284
	KeyControl get_equalsKey() { }

	// RVA: 0x1395300
	KeyControl get_aKey() { }

	// RVA: 0x139537C
	KeyControl get_bKey() { }

	// RVA: 0x13953F8
	KeyControl get_cKey() { }

	// RVA: 0x1395474
	KeyControl get_dKey() { }

	// RVA: 0x13954F0
	KeyControl get_eKey() { }

	// RVA: 0x139556C
	KeyControl get_fKey() { }

	// RVA: 0x13955E8
	KeyControl get_gKey() { }

	// RVA: 0x1395664
	KeyControl get_hKey() { }

	// RVA: 0x13956E0
	KeyControl get_iKey() { }

	// RVA: 0x139575C
	KeyControl get_jKey() { }

	// RVA: 0x13957D8
	KeyControl get_kKey() { }

	// RVA: 0x1395854
	KeyControl get_lKey() { }

	// RVA: 0x13958D0
	KeyControl get_mKey() { }

	// RVA: 0x139594C
	KeyControl get_nKey() { }

	// RVA: 0x13959C8
	KeyControl get_oKey() { }

	// RVA: 0x1395A44
	KeyControl get_pKey() { }

	// RVA: 0x1395AC0
	KeyControl get_qKey() { }

	// RVA: 0x1395B3C
	KeyControl get_rKey() { }

	// RVA: 0x1395BB8
	KeyControl get_sKey() { }

	// RVA: 0x1395C34
	KeyControl get_tKey() { }

	// RVA: 0x1395CB0
	KeyControl get_uKey() { }

	// RVA: 0x1395D2C
	KeyControl get_vKey() { }

	// RVA: 0x1395DA8
	KeyControl get_wKey() { }

	// RVA: 0x1395E24
	KeyControl get_xKey() { }

	// RVA: 0x1395EA0
	KeyControl get_yKey() { }

	// RVA: 0x1395F1C
	KeyControl get_zKey() { }

	// RVA: 0x1395F98
	KeyControl get_digit1Key() { }

	// RVA: 0x1396014
	KeyControl get_digit2Key() { }

	// RVA: 0x1396090
	KeyControl get_digit3Key() { }

	// RVA: 0x139610C
	KeyControl get_digit4Key() { }

	// RVA: 0x1396188
	KeyControl get_digit5Key() { }

	// RVA: 0x1396204
	KeyControl get_digit6Key() { }

	// RVA: 0x1396280
	KeyControl get_digit7Key() { }

	// RVA: 0x13962FC
	KeyControl get_digit8Key() { }

	// RVA: 0x1396378
	KeyControl get_digit9Key() { }

	// RVA: 0x13963F4
	KeyControl get_digit0Key() { }

	// RVA: 0x1396470
	KeyControl get_leftShiftKey() { }

	// RVA: 0x13964EC
	KeyControl get_rightShiftKey() { }

	// RVA: 0x1396568
	KeyControl get_leftAltKey() { }

	// RVA: 0x13965E4
	KeyControl get_rightAltKey() { }

	// RVA: 0x1396660
	KeyControl get_leftCtrlKey() { }

	// RVA: 0x13966DC
	KeyControl get_rightCtrlKey() { }

	// RVA: 0x1396758
	KeyControl get_leftMetaKey() { }

	// RVA: 0x13967D4
	KeyControl get_rightMetaKey() { }

	// RVA: 0x1396850
	KeyControl get_leftWindowsKey() { }

	// RVA: 0x13968CC
	KeyControl get_rightWindowsKey() { }

	// RVA: 0x1396948
	KeyControl get_leftAppleKey() { }

	// RVA: 0x13969C4
	KeyControl get_rightAppleKey() { }

	// RVA: 0x1396A40
	KeyControl get_leftCommandKey() { }

	// RVA: 0x1396ABC
	KeyControl get_rightCommandKey() { }

	// RVA: 0x1396B38
	KeyControl get_contextMenuKey() { }

	// RVA: 0x1396BB4
	KeyControl get_escapeKey() { }

	// RVA: 0x1396C30
	KeyControl get_leftArrowKey() { }

	// RVA: 0x1396CAC
	KeyControl get_rightArrowKey() { }

	// RVA: 0x1396D28
	KeyControl get_upArrowKey() { }

	// RVA: 0x1396DA4
	KeyControl get_downArrowKey() { }

	// RVA: 0x1396E20
	KeyControl get_backspaceKey() { }

	// RVA: 0x1396E9C
	KeyControl get_pageDownKey() { }

	// RVA: 0x1396F18
	KeyControl get_pageUpKey() { }

	// RVA: 0x1396F94
	KeyControl get_homeKey() { }

	// RVA: 0x1397010
	KeyControl get_endKey() { }

	// RVA: 0x139708C
	KeyControl get_insertKey() { }

	// RVA: 0x1397108
	KeyControl get_deleteKey() { }

	// RVA: 0x1397184
	KeyControl get_capsLockKey() { }

	// RVA: 0x1397200
	KeyControl get_scrollLockKey() { }

	// RVA: 0x139727C
	KeyControl get_numLockKey() { }

	// RVA: 0x13972F8
	KeyControl get_printScreenKey() { }

	// RVA: 0x1397374
	KeyControl get_pauseKey() { }

	// RVA: 0x13973F0
	KeyControl get_numpadEnterKey() { }

	// RVA: 0x139746C
	KeyControl get_numpadDivideKey() { }

	// RVA: 0x13974E8
	KeyControl get_numpadMultiplyKey() { }

	// RVA: 0x1397564
	KeyControl get_numpadMinusKey() { }

	// RVA: 0x13975E0
	KeyControl get_numpadPlusKey() { }

	// RVA: 0x139765C
	KeyControl get_numpadPeriodKey() { }

	// RVA: 0x13976D8
	KeyControl get_numpadEqualsKey() { }

	// RVA: 0x1397754
	KeyControl get_numpad0Key() { }

	// RVA: 0x13977D0
	KeyControl get_numpad1Key() { }

	// RVA: 0x139784C
	KeyControl get_numpad2Key() { }

	// RVA: 0x13978C8
	KeyControl get_numpad3Key() { }

	// RVA: 0x1397944
	KeyControl get_numpad4Key() { }

	// RVA: 0x13979C0
	KeyControl get_numpad5Key() { }

	// RVA: 0x1397A3C
	KeyControl get_numpad6Key() { }

	// RVA: 0x1397AB8
	KeyControl get_numpad7Key() { }

	// RVA: 0x1397B34
	KeyControl get_numpad8Key() { }

	// RVA: 0x1397BB0
	KeyControl get_numpad9Key() { }

	// RVA: 0x1397C2C
	KeyControl get_f1Key() { }

	// RVA: 0x1397CA8
	KeyControl get_f2Key() { }

	// RVA: 0x1397D24
	KeyControl get_f3Key() { }

	// RVA: 0x1397DA0
	KeyControl get_f4Key() { }

	// RVA: 0x1397E1C
	KeyControl get_f5Key() { }

	// RVA: 0x1397E98
	KeyControl get_f6Key() { }

	// RVA: 0x1397F14
	KeyControl get_f7Key() { }

	// RVA: 0x1397F90
	KeyControl get_f8Key() { }

	// RVA: 0x139800C
	KeyControl get_f9Key() { }

	// RVA: 0x1398088
	KeyControl get_f10Key() { }

	// RVA: 0x1398104
	KeyControl get_f11Key() { }

	// RVA: 0x1398180
	KeyControl get_f12Key() { }

	// RVA: 0x13981FC
	KeyControl get_oem1Key() { }

	// RVA: 0x1398278
	KeyControl get_oem2Key() { }

	// RVA: 0x13982F4
	KeyControl get_oem3Key() { }

	// RVA: 0x1398370
	KeyControl get_oem4Key() { }

	// RVA: 0x13983EC
	KeyControl get_oem5Key() { }

	// RVA: 0x1398468
	ButtonControl get_shiftKey() { }

	// RVA: 0x1398470
	void set_shiftKey(ButtonControl value) { }

	// RVA: 0x1398480
	ButtonControl get_ctrlKey() { }

	// RVA: 0x1398488
	void set_ctrlKey(ButtonControl value) { }

	// RVA: 0x1398498
	ButtonControl get_altKey() { }

	// RVA: 0x13984A0
	void set_altKey(ButtonControl value) { }

	// RVA: 0x13984B0
	ButtonControl get_imeSelected() { }

	// RVA: 0x13984B8
	void set_imeSelected(ButtonControl value) { }

	// RVA: 0x1394C2C
	KeyControl get_Item(Key key) { }

	// RVA: 0x13984C8
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys() { }

	// RVA: 0x1398534
	Keyboard get_current() { }

	// RVA: 0x1398580
	void set_current(Keyboard value) { }

	// RVA: 0x13985E4
	void MakeCurrent() { }

	// RVA: 0x1398640
	void OnRemoved() { }

	// RVA: 0x13986D8
	void FinishSetup() { }

	// RVA: 0x1399E70
	void RefreshConfiguration() { }

	// RVA: 0x1399F50
	void OnTextInput(Char character) { }

	// RVA: 0x139A004
	KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	// RVA: 0x139A174
	void OnIMECompositionChanged(IMECompositionString compositionString) { }

	// RVA: 0x139A278
	KeyControl[] get_keys() { }

	// RVA: 0x139A280
	void set_keys(KeyControl[] value) { }

	// RVA: 0x139A290
	void .ctor() { }

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

	// RVA: 0x139A314
	DeltaControl get_scroll() { }

	// RVA: 0x139A31C
	void set_scroll(DeltaControl value) { }

	// RVA: 0x139A32C
	ButtonControl get_leftButton() { }

	// RVA: 0x139A334
	void set_leftButton(ButtonControl value) { }

	// RVA: 0x139A344
	ButtonControl get_middleButton() { }

	// RVA: 0x139A34C
	void set_middleButton(ButtonControl value) { }

	// RVA: 0x139A35C
	ButtonControl get_rightButton() { }

	// RVA: 0x139A364
	void set_rightButton(ButtonControl value) { }

	// RVA: 0x139A374
	ButtonControl get_backButton() { }

	// RVA: 0x139A37C
	void set_backButton(ButtonControl value) { }

	// RVA: 0x139A38C
	ButtonControl get_forwardButton() { }

	// RVA: 0x139A394
	void set_forwardButton(ButtonControl value) { }

	// RVA: 0x139A3A4
	IntegerControl get_clickCount() { }

	// RVA: 0x139A3AC
	void set_clickCount(IntegerControl value) { }

	// RVA: 0x139A3BC
	Mouse get_current() { }

	// RVA: 0x139A408
	void set_current(Mouse value) { }

	// RVA: 0x139A46C
	void MakeCurrent() { }

	// RVA: 0x139A4D0
	void OnAdded() { }

	// RVA: 0x139A54C
	void OnRemoved() { }

	// RVA: 0x139A5EC
	void WarpCursorPosition(Vector2 position) { }

	// RVA: 0x139A6A0
	void FinishSetup() { }

	// RVA: 0x139A8D4
	void OnNextUpdate() { }

	// RVA: 0x139A988
	void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x139A9DC
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x139AA90
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x139AAE4
	void .ctor() { }

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

	// RVA: 0x139AAEC
	ButtonControl get_tip() { }

	// RVA: 0x139AAF4
	void set_tip(ButtonControl value) { }

	// RVA: 0x139AB04
	ButtonControl get_eraser() { }

	// RVA: 0x139AB0C
	void set_eraser(ButtonControl value) { }

	// RVA: 0x139AB1C
	ButtonControl get_firstBarrelButton() { }

	// RVA: 0x139AB24
	void set_firstBarrelButton(ButtonControl value) { }

	// RVA: 0x139AB34
	ButtonControl get_secondBarrelButton() { }

	// RVA: 0x139AB3C
	void set_secondBarrelButton(ButtonControl value) { }

	// RVA: 0x139AB4C
	ButtonControl get_thirdBarrelButton() { }

	// RVA: 0x139AB54
	void set_thirdBarrelButton(ButtonControl value) { }

	// RVA: 0x139AB64
	ButtonControl get_fourthBarrelButton() { }

	// RVA: 0x139AB6C
	void set_fourthBarrelButton(ButtonControl value) { }

	// RVA: 0x139AB7C
	ButtonControl get_inRange() { }

	// RVA: 0x139AB84
	void set_inRange(ButtonControl value) { }

	// RVA: 0x139AB94
	Vector2Control get_tilt() { }

	// RVA: 0x139AB9C
	void set_tilt(Vector2Control value) { }

	// RVA: 0x139ABAC
	AxisControl get_twist() { }

	// RVA: 0x139ABB4
	void set_twist(AxisControl value) { }

	// RVA: 0x139ABC4
	Pen get_current() { }

	// RVA: 0x139AC10
	void set_current(Pen value) { }

	// RVA: 0x139AC74
	ButtonControl get_Item(PenButton button) { }

	// RVA: 0x139ADD4
	void MakeCurrent() { }

	// RVA: 0x139AE38
	void OnRemoved() { }

	// RVA: 0x139AED8
	void FinishSetup() { }

	// RVA: 0x139B140
	void .ctor() { }

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

	// RVA: 0x139B148
	Vector2Control get_position() { }

	// RVA: 0x139B150
	void set_position(Vector2Control value) { }

	// RVA: 0x139B160
	DeltaControl get_delta() { }

	// RVA: 0x139B168
	void set_delta(DeltaControl value) { }

	// RVA: 0x139B178
	Vector2Control get_radius() { }

	// RVA: 0x139B180
	void set_radius(Vector2Control value) { }

	// RVA: 0x139B190
	AxisControl get_pressure() { }

	// RVA: 0x139B198
	void set_pressure(AxisControl value) { }

	// RVA: 0x139B1A8
	ButtonControl get_press() { }

	// RVA: 0x139B1B0
	void set_press(ButtonControl value) { }

	// RVA: 0x139B1C0
	IntegerControl get_displayIndex() { }

	// RVA: 0x139B1C8
	void set_displayIndex(IntegerControl value) { }

	// RVA: 0x139B1D8
	Pointer get_current() { }

	// RVA: 0x139B224
	void set_current(Pointer value) { }

	// RVA: 0x139B288
	void MakeCurrent() { }

	// RVA: 0x139B2EC
	void OnRemoved() { }

	// RVA: 0x139B38C
	void FinishSetup() { }

	// RVA: 0x139B580
	void OnNextUpdate() { }

	// RVA: 0x139B628
	void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x139B680
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x139B728
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x139B780
	bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref UInt32 offset) { }

	// RVA: 0x139B788
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
internal class FastKeyboard 
{
	// Fields
	public const string metadata = 5708574080;

	// Methods

	// RVA: 0x139B790
	void .ctor() { }

	// RVA: 0x139E6EC
	AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) { }

	// RVA: 0x139E8EC
	KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139EAF0
	KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139ECE8
	KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139EEEC
	KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139F0E4
	KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139F2DC
	KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139F4D4
	KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139F6CC
	KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139F8C4
	KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139FABC
	KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139FCB4
	KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x139FEAC
	KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A00A4
	KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A029C
	KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A0494
	KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A068C
	KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A0884
	KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A0A7C
	KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A0C74
	KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A0E6C
	KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A1064
	KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A125C
	KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A1454
	KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A164C
	KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A1844
	KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A1A3C
	KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A1C34
	KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A1E2C
	KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A2024
	KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A221C
	KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A2414
	KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A260C
	KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A2804
	KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A29FC
	KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A2BF4
	KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A2DEC
	KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A2FE4
	KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A31DC
	KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A33D4
	KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A35CC
	KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A37C4
	KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A39BC
	KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A3BB4
	KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A3DAC
	KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A3FA4
	KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A419C
	KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A4380
	KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A4564
	KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A4748
	KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A492C
	KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A4B10
	KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A4CF4
	KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A4ED8
	KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A50BC
	KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A52A0
	KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A5484
	KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A5688
	KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A588C
	DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13A5AB0
	KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A5CB4
	KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A5EB8
	DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13A60DC
	KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A62E0
	KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A64E4
	DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) { }

	// RVA: 0x13A6708
	KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A690C
	KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A6B10
	KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A6D14
	KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A6F0C
	KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A7104
	KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A72FC
	KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A74F4
	KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A76EC
	KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A78E4
	KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A7ADC
	KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A7CD4
	KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A7ECC
	KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A80C4
	KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A82BC
	KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A84B4
	KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A86AC
	KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A88A4
	KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A8A9C
	KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A8C94
	KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A8E8C
	KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A9084
	KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A927C
	KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A9474
	KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A966C
	KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A9864
	KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A9A5C
	KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A9C54
	KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13A9E4C
	KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AA044
	KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AA23C
	KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AA434
	KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AA62C
	KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AA824
	KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AAA1C
	KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AAC14
	KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AAE0C
	KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AB004
	KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AB1FC
	KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AB3F4
	KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AB5EC
	KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AB7E4
	KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AB9DC
	KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13ABBD4
	KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13ABDCC
	KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13ABFB0
	KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AC194
	KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AC378
	KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AC55C
	KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) { }

	// RVA: 0x13AC740
	ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastMouse 
{
	// Fields
	public const string metadata = 5705178560;

	// Methods

	// RVA: 0x13AC92C
	void .ctor() { }

	// RVA: 0x13AD400
	Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13AD5EC
	DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13AD7B0
	DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13AD960
	ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13ADB60
	ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13ADDA4
	ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13ADFE8
	ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13AE220
	ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13AE418
	ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13AE610
	AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AE7FC
	Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13AE9C4
	IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	// RVA: 0x13AEB54
	IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13AECF8
	IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13AEEB0
	AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AF0BC
	AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AF2C8
	AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AF4D0
	AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AF6E0
	AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AF8F0
	AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AFAF8
	AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AFCD4
	AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13AFEB0
	AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B00B8
	AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B02C8
	AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B04D8
	AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B06E0
	AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B08D4
	AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B0ADC
	AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B0CB8
	AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B0E94
	void OnNextUpdate() { }

	// RVA: 0x13B1008
	void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13B11B0
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13B11B4
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13B11B8
	bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x13B12E4
	bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

// Namespace: UnityEngine.InputSystem
internal class FastTouchscreen 
{
	// Fields
	public const string metadata = 5418185984;

	// Methods

	// RVA: 0x13B12F0
	void .ctor() { }

	// RVA: 0x13B48A8
	TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B4A6C
	Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13B4C54
	DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13B4E1C
	AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) { }

	// RVA: 0x13B5008
	Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13B51D0
	TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13B53D0
	TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B5580
	TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B5730
	TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B58E0
	TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B5A90
	TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B5C40
	TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B5DF0
	TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B5FA0
	TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B6150
	TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B6300
	TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) { }

	// RVA: 0x13B64B0
	IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13B6654
	IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13B6874
	Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13B6A8C
	DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13B6C74
	AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B6E50
	Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13B7038
	TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13B7228
	TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13B744C
	IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13B7628
	IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13B7804
	ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13B7A3C
	ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13B7C6C
	DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13B7E5C
	Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13B8058
	AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8264
	AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8470
	AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8678
	AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8888
	AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8A98
	AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8CA0
	AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B8E7C
	AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B9058
	AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B9234
	AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B9410
	AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B95EC
	AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B97C8
	AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B99D4
	AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B9BE0
	AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B9DE8
	AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13B9FF8
	AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BA208
	AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BA410
	AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BA5EC
	AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BA7C8
	AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BA9A4
	AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BAB80
	IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13BADA0
	Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13BAFB8
	DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13BB1A0
	AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BB37C
	Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13BB564
	TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13BB754
	TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13BB978
	IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13BBB54
	IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13BBD30
	ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13BBF68
	ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13BC18C
	DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13BC37C
	Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13BC578
	AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BC784
	AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BC990
	AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BCB98
	AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BCDA8
	AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BCFB8
	AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BD1C0
	AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BD39C
	AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BD578
	AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BD754
	AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BD930
	AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BDB0C
	AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BDCE8
	IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13BDF08
	Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13BE120
	DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13BE308
	AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BE4E4
	Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13BE6CC
	TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13BE8BC
	TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13BEAE0
	IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13BECBC
	IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13BEE98
	ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13BF0D0
	ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13BF2F4
	DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13BF4E4
	Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13BF6E0
	AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BF8EC
	AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BFAF8
	AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BFD00
	AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13BFF10
	AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C0120
	AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C0328
	AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C0504
	AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C06E0
	AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C08BC
	AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C0A98
	AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C0C74
	AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C0E50
	IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C1070
	Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C1288
	DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13C1470
	AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C164C
	Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C1834
	TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13C1A24
	TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13C1C48
	IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C1E24
	IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C2000
	ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13C2238
	ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13C245C
	DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13C264C
	Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C2848
	AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C2A54
	AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C2C60
	AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C2E68
	AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3078
	AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3288
	AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3490
	AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C366C
	AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3848
	AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3A24
	AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3C00
	AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3DDC
	AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C3FB8
	IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C41D8
	Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C43F0
	DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13C45D8
	AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C47B4
	Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C499C
	TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13C4B8C
	TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13C4DB0
	IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C4F8C
	IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C5168
	ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13C53A0
	ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13C55C4
	DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13C57B4
	Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C59B0
	AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C5BBC
	AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C5DC8
	AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C5FD0
	AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C61E0
	AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C63F0
	AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C65F8
	AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C67D4
	AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C69B0
	AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C6B8C
	AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C6D68
	AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C6F44
	AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C7120
	IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C7340
	Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C7558
	DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13C7740
	AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C791C
	Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C7B04
	TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13C7CF4
	TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13C7F18
	IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C80F4
	IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13C82D0
	ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13C8508
	ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13C872C
	DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13C891C
	Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13C8B18
	AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C8D24
	AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C8F30
	AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9138
	AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9348
	AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9558
	AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9760
	AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C993C
	AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9B18
	AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9CF4
	AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13C9ED0
	AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CA0AC
	AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CA288
	IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13CA4A8
	Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13CA6C0
	DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13CA8A8
	AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CAA84
	Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13CAC6C
	TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13CAE5C
	TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13CB080
	IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13CB25C
	IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13CB438
	ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13CB670
	ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13CB894
	DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13CBA84
	Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13CBC80
	AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CBE8C
	AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CC098
	AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CC2A0
	AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CC4B0
	AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CC6C0
	AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CC8C8
	AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CCAA4
	AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CCC80
	AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CCE5C
	AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CD038
	AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CD214
	AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CD3F0
	IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13CD610
	Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13CD828
	DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13CDA10
	AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CDBEC
	Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13CDDD4
	TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13CDFC4
	TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13CE1E8
	IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13CE3C4
	IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13CE5A0
	ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13CE7D8
	ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13CE9FC
	DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13CEBEC
	Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13CEDE8
	AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CEFF4
	AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CF200
	AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CF408
	AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CF618
	AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CF828
	AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CFA30
	AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CFC0C
	AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CFDE8
	AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13CFFC4
	AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D01A0
	AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D037C
	AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D0558
	IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D0778
	Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D0990
	DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13D0B78
	AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D0D54
	Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D0F3C
	TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13D112C
	TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13D1350
	IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D152C
	IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D1708
	ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D1940
	ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D1B64
	DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13D1D54
	Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D1F50
	AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D215C
	AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2368
	AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2570
	AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2780
	AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2990
	AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2B98
	AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2D74
	AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D2F50
	AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D312C
	AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D3308
	AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D34E4
	AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D36C0
	IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D38E0
	Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D3AF8
	DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13D3CE0
	AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D3EBC
	Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D40A4
	TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13D4294
	TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13D44B8
	IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D4694
	IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D4870
	ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D4AA8
	ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D4CCC
	DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13D4EBC
	Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D50B8
	AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D52C4
	AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D54D0
	AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D56D8
	AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D58E8
	AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D5AF8
	AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D5D00
	AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D5EDC
	AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D60B8
	AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6294
	AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6470
	AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D664C
	AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D6828
	IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D6A48
	Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D6C60
	DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x13D6E48
	AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D7024
	Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D720C
	TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	// RVA: 0x13D73FC
	TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) { }

	// RVA: 0x13D7620
	IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D77FC
	IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x13D79D8
	ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D7C10
	ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x13D7E34
	DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) { }

	// RVA: 0x13D8024
	Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x13D8220
	AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D842C
	AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D8638
	AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D8840
	AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D8A50
	AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D8C60
	AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D8E68
	AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D9044
	AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D9220
	AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D93FC
	AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D95D8
	AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x13D97B4
	AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent) { }

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
internal struct RemoteSender 
{
	// Fields
	public int senderId; // 0x10
	public InternedString[] layouts; // 0x18
	public RemoteInputDevice[] devices; // 0x20
}

// Namespace: 
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

	// RVA: 0x13DD040
	void Dispose() { }

	// RVA: 0x13DB1DC
	void .ctor() { }

}

// Namespace: 
private static class ConnectMsg 
{
	// Methods

	// RVA: 0x13DA178
	void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StartSendingMsg 
{
	// Methods

	// RVA: 0x13DB0AC
	void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class StopSendingMsg 
{
	// Methods

	// RVA: 0x13DB0C0
	void Process(InputRemoting receiver) { }

}

// Namespace: 
private static class DisconnectMsg 
{
	// Methods

	// RVA: 0x13DA1D0
	void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
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

	// RVA: 0x13DB754
	System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(InputRemoting sender, string layoutName) { }

	// RVA: 0x13DA28C
	void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputRemoting.NewDeviceMsg.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x13DD968
	void .cctor() { }

	// RVA: 0x13DD9D4
	void .ctor() { }

	// RVA: 0x13DD9DC
	string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class NewDeviceMsg 
{
	// Methods

	// RVA: 0x13DBC1C
	Message Create(InputDevice device) { }

	// RVA: 0x13DA418
	void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class NewEventsMsg 
{
	// Methods

	// RVA: 0x13DC488
	Message CreateResetEvent(InputDevice device, bool isHardReset) { }

	// RVA: 0x13DBE98
	Message CreateStateEvent(InputDevice device) { }

	// RVA: 0x13DBFF8
	Message Create(InputEvent* events, int eventCount) { }

	// RVA: 0x13DA9DC
	void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
public struct Data 
{
	// Fields
	public int deviceId; // 0x10
	public string[] usages; // 0x18
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputRemoting.ChangeUsageMsg.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x13DDBDC
	void .cctor() { }

	// RVA: 0x13DDC48
	void .ctor() { }

	// RVA: 0x13DDC50
	string <Create>b__1_0(InternedString x) { }

}

// Namespace: 
private static class ChangeUsageMsg 
{
	// Methods

	// RVA: 0x13DC298
	Message Create(InputDevice device) { }

	// RVA: 0x13DAC44
	void Process(InputRemoting receiver, Message msg) { }

}

// Namespace: 
private static class RemoveDeviceMsg 
{
	// Methods

	// RVA: 0x13DC248
	Message Create(InputDevice device) { }

	// RVA: 0x13DAFB4
	void Process(InputRemoting receiver, Message msg) { }

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

	// RVA: 0x13D9990
	bool get_sending() { }

	// RVA: 0x13D999C
	void set_sending(bool value) { }

	// RVA: 0x13D99B0
	void .ctor(InputManager manager, bool startSendingOnConnect) { }

	// RVA: 0x13D9A50
	void StartSending() { }

	// RVA: 0x13D9D8C
	void StopSending() { }

	// RVA: 0x13DA084
	void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x13DB0D4
	void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x13DB0D8
	void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x13DB0DC
	IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x13D9D68
	void SendInitialMessages() { }

	// RVA: 0x13DB1E4
	void SendAllGeneratedLayouts() { }

	// RVA: 0x13DB674
	void SendLayout(string layoutName) { }

	// RVA: 0x13DB468
	void SendAllDevices() { }

	// RVA: 0x13DBB94
	void SendDevice(InputDevice device) { }

	// RVA: 0x13DBF90
	void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x13DC100
	void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x13DC504
	void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	// RVA: 0x13DBA1C
	void Send(Message msg) { }

	// RVA: 0x13DC640
	int FindOrCreateSenderRecord(int senderId) { }

	// RVA: 0x13DC6EC
	InternedString BuildLayoutNamespace(int senderId) { }

	// RVA: 0x13DC78C
	int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x13DC800
	InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x13DC974
	InputManager get_manager() { }

	// RVA: 0x13DC97C
	void RemoveRemoteDevices(int participantId) { }

	// RVA: 0x309AF8C
	Byte[] SerializeData(TData data) { }

	// RVA: 0x309AF8C
	TData DeserializeData(Byte[] data) { }

}

// Namespace: 
private class Subscriber 
{
	// Fields
	public RemoteInputPlayerConnection owner; // 0x10
	public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer; // 0x18

	// Methods

	// RVA: 0x13DED14
	void Dispose() { }

	// RVA: 0x13DE5E4
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
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

	// RVA: 0x13DDC78
	void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	// RVA: 0x13DE430
	IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }

	// RVA: 0x13DE34C
	void OnConnected(int id) { }

	// RVA: 0x13DE720
	void OnDisconnected(int id) { }

	// RVA: 0x13DE804
	void OnNewDevice(MessageEventArgs args) { }

	// RVA: 0x13DE810
	void OnNewLayout(MessageEventArgs args) { }

	// RVA: 0x13DE81C
	void OnNewEvents(MessageEventArgs args) { }

	// RVA: 0x13DE828
	void OnRemoveDevice(MessageEventArgs args) { }

	// RVA: 0x13DE834
	void OnChangeUsages(MessageEventArgs args) { }

	// RVA: 0x13DE840
	void OnStartSending(MessageEventArgs args) { }

	// RVA: 0x13DE84C
	void OnStopSending(MessageEventArgs args) { }

	// RVA: 0x13DE5EC
	void SendToSubscribers(MessageType type, MessageEventArgs args) { }

	// RVA: 0x13DE858
	void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	// RVA: 0x13DEB14
	void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x13DEB18
	void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x13DEB1C
	void .ctor() { }

	// RVA: 0x13DEB24
	void .cctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Sensor 
{
	// Methods

	// RVA: 0x13DED70
	float get_samplingFrequency() { }

	// RVA: 0x13DEE6C
	void set_samplingFrequency(float value) { }

	// RVA: 0x13DEF1C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Accelerometer 
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x170
	private static Accelerometer <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DEF24
	Vector3Control get_acceleration() { }

	// RVA: 0x13DEF2C
	void set_acceleration(Vector3Control value) { }

	// RVA: 0x13DEF3C
	Accelerometer get_current() { }

	// RVA: 0x13DEF88
	void set_current(Accelerometer value) { }

	// RVA: 0x13DEFEC
	void MakeCurrent() { }

	// RVA: 0x13DF050
	void OnRemoved() { }

	// RVA: 0x13DF0F0
	void FinishSetup() { }

	// RVA: 0x13DF178
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class Gyroscope 
{
	// Fields
	private Vector3Control <angularVelocity>k__BackingField; // 0x170
	private static Gyroscope <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DF180
	Vector3Control get_angularVelocity() { }

	// RVA: 0x13DF188
	void set_angularVelocity(Vector3Control value) { }

	// RVA: 0x13DF198
	Gyroscope get_current() { }

	// RVA: 0x13DF1E4
	void set_current(Gyroscope value) { }

	// RVA: 0x13DF248
	void MakeCurrent() { }

	// RVA: 0x13DF2AC
	void OnRemoved() { }

	// RVA: 0x13DF34C
	void FinishSetup() { }

	// RVA: 0x13DF3D4
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class GravitySensor 
{
	// Fields
	private Vector3Control <gravity>k__BackingField; // 0x170
	private static GravitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DF3DC
	Vector3Control get_gravity() { }

	// RVA: 0x13DF3E4
	void set_gravity(Vector3Control value) { }

	// RVA: 0x13DF3F4
	GravitySensor get_current() { }

	// RVA: 0x13DF440
	void set_current(GravitySensor value) { }

	// RVA: 0x13DF4A4
	void FinishSetup() { }

	// RVA: 0x13DF52C
	void MakeCurrent() { }

	// RVA: 0x13DF590
	void OnRemoved() { }

	// RVA: 0x13DF630
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AttitudeSensor 
{
	// Fields
	private QuaternionControl <attitude>k__BackingField; // 0x170
	private static AttitudeSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DF638
	QuaternionControl get_attitude() { }

	// RVA: 0x13DF640
	void set_attitude(QuaternionControl value) { }

	// RVA: 0x13DF650
	AttitudeSensor get_current() { }

	// RVA: 0x13DF69C
	void set_current(AttitudeSensor value) { }

	// RVA: 0x13DF700
	void MakeCurrent() { }

	// RVA: 0x13DF764
	void OnRemoved() { }

	// RVA: 0x13DF804
	void FinishSetup() { }

	// RVA: 0x13DF88C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LinearAccelerationSensor 
{
	// Fields
	private Vector3Control <acceleration>k__BackingField; // 0x170
	private static LinearAccelerationSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DF894
	Vector3Control get_acceleration() { }

	// RVA: 0x13DF89C
	void set_acceleration(Vector3Control value) { }

	// RVA: 0x13DF8AC
	LinearAccelerationSensor get_current() { }

	// RVA: 0x13DF8F8
	void set_current(LinearAccelerationSensor value) { }

	// RVA: 0x13DF95C
	void MakeCurrent() { }

	// RVA: 0x13DF9C0
	void OnRemoved() { }

	// RVA: 0x13DFA60
	void FinishSetup() { }

	// RVA: 0x13DFAE8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class MagneticFieldSensor 
{
	// Fields
	private Vector3Control <magneticField>k__BackingField; // 0x170
	private static MagneticFieldSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DFAF0
	Vector3Control get_magneticField() { }

	// RVA: 0x13DFAF8
	void set_magneticField(Vector3Control value) { }

	// RVA: 0x13DFB08
	MagneticFieldSensor get_current() { }

	// RVA: 0x13DFB54
	void set_current(MagneticFieldSensor value) { }

	// RVA: 0x13DFBB8
	void MakeCurrent() { }

	// RVA: 0x13DFC1C
	void OnRemoved() { }

	// RVA: 0x13DFCBC
	void FinishSetup() { }

	// RVA: 0x13DFD44
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class LightSensor 
{
	// Fields
	private AxisControl <lightLevel>k__BackingField; // 0x170
	private static LightSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DFD4C
	AxisControl get_lightLevel() { }

	// RVA: 0x13DFD54
	void set_lightLevel(AxisControl value) { }

	// RVA: 0x13DFD64
	LightSensor get_current() { }

	// RVA: 0x13DFDB0
	void set_current(LightSensor value) { }

	// RVA: 0x13DFE14
	void MakeCurrent() { }

	// RVA: 0x13DFE78
	void OnRemoved() { }

	// RVA: 0x13DFF18
	void FinishSetup() { }

	// RVA: 0x13DFFA0
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PressureSensor 
{
	// Fields
	private AxisControl <atmosphericPressure>k__BackingField; // 0x170
	private static PressureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13DFFA8
	AxisControl get_atmosphericPressure() { }

	// RVA: 0x13DFFB0
	void set_atmosphericPressure(AxisControl value) { }

	// RVA: 0x13DFFC0
	PressureSensor get_current() { }

	// RVA: 0x13E000C
	void set_current(PressureSensor value) { }

	// RVA: 0x13E0070
	void MakeCurrent() { }

	// RVA: 0x13E00D4
	void OnRemoved() { }

	// RVA: 0x13E0174
	void FinishSetup() { }

	// RVA: 0x13E01FC
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class ProximitySensor 
{
	// Fields
	private AxisControl <distance>k__BackingField; // 0x170
	private static ProximitySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13E0204
	AxisControl get_distance() { }

	// RVA: 0x13E020C
	void set_distance(AxisControl value) { }

	// RVA: 0x13E021C
	ProximitySensor get_current() { }

	// RVA: 0x13E0268
	void set_current(ProximitySensor value) { }

	// RVA: 0x13E02CC
	void MakeCurrent() { }

	// RVA: 0x13E0330
	void OnRemoved() { }

	// RVA: 0x13E03D0
	void FinishSetup() { }

	// RVA: 0x13E0458
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class HumiditySensor 
{
	// Fields
	private AxisControl <relativeHumidity>k__BackingField; // 0x170
	private static HumiditySensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13E0460
	AxisControl get_relativeHumidity() { }

	// RVA: 0x13E0468
	void set_relativeHumidity(AxisControl value) { }

	// RVA: 0x13E0478
	HumiditySensor get_current() { }

	// RVA: 0x13E04C4
	void set_current(HumiditySensor value) { }

	// RVA: 0x13E0528
	void MakeCurrent() { }

	// RVA: 0x13E058C
	void OnRemoved() { }

	// RVA: 0x13E062C
	void FinishSetup() { }

	// RVA: 0x13E06B4
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class AmbientTemperatureSensor 
{
	// Fields
	private AxisControl <ambientTemperature>k__BackingField; // 0x170
	private static AmbientTemperatureSensor <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13E06BC
	AxisControl get_ambientTemperature() { }

	// RVA: 0x13E06C4
	void set_ambientTemperature(AxisControl value) { }

	// RVA: 0x13E06D4
	AmbientTemperatureSensor get_current() { }

	// RVA: 0x13E0720
	void set_current(AmbientTemperatureSensor value) { }

	// RVA: 0x13E0784
	void MakeCurrent() { }

	// RVA: 0x13E07E8
	void OnRemoved() { }

	// RVA: 0x13E0888
	void FinishSetup() { }

	// RVA: 0x13E0910
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class StepCounter 
{
	// Fields
	private IntegerControl <stepCounter>k__BackingField; // 0x170
	private static StepCounter <current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x13E0918
	IntegerControl get_stepCounter() { }

	// RVA: 0x13E0920
	void set_stepCounter(IntegerControl value) { }

	// RVA: 0x13E0930
	StepCounter get_current() { }

	// RVA: 0x13E097C
	void set_current(StepCounter value) { }

	// RVA: 0x13E09E0
	void MakeCurrent() { }

	// RVA: 0x13E0A44
	void OnRemoved() { }

	// RVA: 0x13E0AE4
	void FinishSetup() { }

	// RVA: 0x13E0B6C
	void .ctor() { }

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

	// RVA: 0x13E0B74
	TouchControl get_primaryTouch() { }

	// RVA: 0x13E0B7C
	void set_primaryTouch(TouchControl value) { }

	// RVA: 0x13E0B8C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches() { }

	// RVA: 0x13E0B98
	void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value) { }

	// RVA: 0x13E0BAC
	TouchControl[] get_touchControlArray() { }

	// RVA: 0x13E0BB4
	void set_touchControlArray(TouchControl[] value) { }

	// RVA: 0x13E0C34
	Touchscreen get_current() { }

	// RVA: 0x13E0C80
	void set_current(Touchscreen value) { }

	// RVA: 0x13E0CE4
	void MakeCurrent() { }

	// RVA: 0x13E0D48
	void OnRemoved() { }

	// RVA: 0x13E0DE8
	void FinishSetup() { }

	// RVA: 0x13E1288
	void OnNextUpdate() { }

	// RVA: 0x13E15DC
	void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13E1D88
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x13E1D8C
	void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x13E1D90
	bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref UInt32 offset) { }

	// RVA: 0x13E2084
	void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	// RVA: 0x13E2528
	bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x13E2658
	bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x13E1CB0
	void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	// RVA: 0x13E2664
	void .ctor() { }

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

	// RVA: 0x13E266C
	IntegerControl get_trackingState() { }

	// RVA: 0x13E2674
	void set_trackingState(IntegerControl value) { }

	// RVA: 0x13E2684
	ButtonControl get_isTracked() { }

	// RVA: 0x13E268C
	void set_isTracked(ButtonControl value) { }

	// RVA: 0x13E269C
	Vector3Control get_devicePosition() { }

	// RVA: 0x13E26A4
	void set_devicePosition(Vector3Control value) { }

	// RVA: 0x13E26B4
	QuaternionControl get_deviceRotation() { }

	// RVA: 0x13E26BC
	void set_deviceRotation(QuaternionControl value) { }

	// RVA: 0x13E26CC
	void FinishSetup() { }

	// RVA: 0x13E2844
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public static class InputExtensions 
{
	// Methods

	// RVA: 0x13E284C
	bool IsInProgress(InputActionPhase phase) { }

	// RVA: 0x13E285C
	bool IsEndedOrCanceled(TouchPhase phase) { }

	// RVA: 0x13E2070
	bool IsActive(TouchPhase phase) { }

	// RVA: 0x13E286C
	bool IsModifierKey(Key key) { }

	// RVA: 0x13E287C
	bool IsTextInputKey(Key key) { }

}

// Namespace: UnityEngine.InputSystem
internal static class InputFeatureNames 
{
	// Fields
	public const string kRunPlayerUpdatesInEditMode = 5708592832;
	public const string kDisableUnityRemoteSupport = 5708592640;
	public const string kUseWindowsGamingInputBackend = 5708592544;
	public const string kUseOptimizedControls = 5714673824;
	public const string kUseReadValueCaching = 5714673744;
	public const string kParanoidReadValueCachingChecks = 5708592352;
	public const string kUseIMGUIEditorForAssets = 5708592256;
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

	// RVA: 0x13EF790
	int get_count() { }

	// RVA: 0x13EECE4
	void Add(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x13EF03C
	void Remove(IInputStateChangeMonitor monitor, Int64 monitorIndex, bool deferRemoval) { }

	// RVA: 0x13EEE68
	void Clear() { }

	// RVA: 0x13EEBD4
	void CompactArrays() { }

	// RVA: 0x13EF818
	void RemoveAt(int i) { }

	// RVA: 0x13EF3C0
	void SortMonitorsByIndex() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputManager.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.InputDevice,System.String> <>9__153_0; // 0x8

	// Methods

	// RVA: 0x13EF8D4
	void .cctor() { }

	// RVA: 0x13EF940
	void .ctor() { }

	// RVA: 0x13EF948
	string <MakeDeviceNameUnique>b__153_0(InputDevice x) { }

}

// Namespace: 
private sealed class <>c__66<T0> 
{
	// Fields
	public static readonly UnityEngine.InputSystem.InputManager.<>c__66<TDevice> <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.InputDevice> <>9__66_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	InputDevice <RegisterPrecompiledLayout>b__66_0() { }

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

	// RVA: 0x13E70D8
	void .ctor(int <>1__state) { }

	// RVA: 0x13EF9B0
	void System.IDisposable.Dispose() { }

	// RVA: 0x13EFB2C
	bool MoveNext() { }

	// RVA: 0x13F0F0C
	void <>m__Finally1() { }

	// RVA: 0x13F0F68
	void <>m__Finally2() { }

	// RVA: 0x13F0FC4
	void <>m__Finally3() { }

	// RVA: 0x13F1020
	void <>m__Finally4() { }

	// RVA: 0x13F107C
	void <>m__Finally5() { }

	// RVA: 0x13F10D8
	void <>m__Finally6() { }

	// RVA: 0x13F1134
	string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x13F113C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13F117C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13F1184
	System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x13F123C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x13DBB20
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13E28A0
	TypeTable get_processors() { }

	// RVA: 0x13E28A8
	TypeTable get_interactions() { }

	// RVA: 0x13E28B0
	TypeTable get_composites() { }

	// RVA: 0x13E28B8
	InputMetrics get_metrics() { }

	// RVA: 0x13E2A58
	InputSettings get_settings() { }

	// RVA: 0x13E2A60
	void set_settings(InputSettings value) { }

	// RVA: 0x13E31B8
	InputActionAsset get_actions() { }

	// RVA: 0x13E31C0
	void set_actions(InputActionAsset value) { }

	// RVA: 0x13E3284
	InputUpdateType get_updateMask() { }

	// RVA: 0x13E328C
	void set_updateMask(InputUpdateType value) { }

	// RVA: 0x13E3428
	InputUpdateType get_defaultUpdateType() { }

	// RVA: 0x13E3444
	float get_pollingFrequency() { }

	// RVA: 0x13E344C
	void set_pollingFrequency(float value) { }

	// RVA: 0x13D9CB0
	void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13D9FCC
	void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }

	// RVA: 0x13E3578
	void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x13E35D4
	void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x13E3630
	void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13E368C
	void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x13E36E8
	void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13E3A2C
	void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x13D9D0C
	void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13DA028
	void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }

	// RVA: 0x13D9C54
	void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x13D9F70
	void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x13E3A88
	void add_onBeforeUpdate(Action value) { }

	// RVA: 0x13E3C04
	void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x13E3C60
	void add_onAfterUpdate(Action value) { }

	// RVA: 0x13E3CBC
	void remove_onAfterUpdate(Action value) { }

	// RVA: 0x13E3D18
	void add_onSettingsChange(Action value) { }

	// RVA: 0x13E3D74
	void remove_onSettingsChange(Action value) { }

	// RVA: 0x13E3DD0
	void add_onActionsChange(Action value) { }

	// RVA: 0x13E3E2C
	void remove_onActionsChange(Action value) { }

	// RVA: 0x13E3E88
	bool get_isProcessingEvents() { }

	// RVA: 0x13E3E90
	bool get_gameIsPlaying() { }

	// RVA: 0x13E3E98
	bool get_gameHasFocus() { }

	// RVA: 0x13E3ED4
	bool get_gameShouldGetInputRegardlessOfFocus() { }

	// RVA: 0x13E3EFC
	void RegisterControlLayout(string name, Type type) { }

	// RVA: 0x13DD0AC
	void RegisterControlLayout(string json, string name, bool isOverride) { }

	// RVA: 0x13E4CBC
	void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout) { }

	// RVA: 0x13E464C
	void PerformLayoutPostRegistration(InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout, bool isOverride) { }

	// RVA: 0x2FE4574
	void RegisterPrecompiledLayout(string metadata) { }

	// RVA: 0x13E4E60
	void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout) { }

	// RVA: 0x13E5200
	bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	// RVA: 0x13E511C
	bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	// RVA: 0x13E4B48
	void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x13E5AF4
	void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	// RVA: 0x13E54A0
	void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x13E5314
	void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	// RVA: 0x13E56F8
	void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	// RVA: 0x13E69E4
	void RemoveControlLayout(string name) { }

	// RVA: 0x13E6C24
	InputControlLayout TryLoadControlLayout(Type type) { }

	// RVA: 0x13DD09C
	InputControlLayout TryLoadControlLayout(InternedString name) { }

	// RVA: 0x13E5D48
	InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId) { }

	// RVA: 0x13E6E6C
	InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	// RVA: 0x13E6F10
	bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	// RVA: 0x13E703C
	System.Collections.Generic.IEnumerable<System.String> ListControlLayouts(string basedOn) { }

	// RVA: -1
	int GetControls(string path, ref UnityEngine.InputSystem.InputControlList<TControl>& controls) { }

	// RVA: 0x13E7110
	void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13DD794
	void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13DDA08
	void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x13E7304
	void NotifyUsageChanged(InputDevice device) { }

	// RVA: 0x13E73C8
	InputDevice AddDevice(Type type, string name) { }

	// RVA: 0x13DD644
	InputDevice AddDevice(string layout, string name, InternedString variants) { }

	// RVA: 0x13E6828
	InputDevice AddDevice(InternedString layout, int deviceId, string deviceName, InputDeviceDescription deviceDescription, DeviceFlags deviceFlags, InternedString variants) { }

	// RVA: 0x13E6274
	void AddDevice(InputDevice device) { }

	// RVA: 0x13E7FF4
	InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x13E803C
	InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x13E820C
	InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName, int deviceId, DeviceFlags deviceFlags) { }

	// RVA: 0x13DCB70
	void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices) { }

	// RVA: 0x13E8460
	void FlushDisconnectedDevices() { }

	// RVA: 0x13E84C0
	void ResetDevice(InputDevice device, bool alsoResetDontResetControls, System.Nullable<System.Boolean> issueResetCommand) { }

	// RVA: 0x13E8D78
	InputDevice TryGetDevice(string nameOrLayout) { }

	// RVA: 0x13E8EA0
	InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x13E8F44
	InputDevice TryGetDevice(Type layoutType) { }

	// RVA: 0x13DC8EC
	InputDevice TryGetDeviceById(int id) { }

	// RVA: 0x13E8FA8
	int GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }

	// RVA: 0x13E7B94
	void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope) { }

	// RVA: 0x13E915C
	void QueueEvent(InputEvent* eventPtr) { }

	// RVA: 0x13DDA04
	void QueueEvent(InputEventPtr ptr) { }

	// RVA: 0x2FE4574
	void QueueEvent(ref TEvent inputEvent) { }

	// RVA: 0x13E9238
	void Update() { }

	// RVA: 0x13E9318
	void Update(InputUpdateType updateType) { }

	// RVA: 0x13E93D0
	void Initialize(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x13EB398
	void Destroy() { }

	// RVA: 0x13E946C
	void InitializeActions() { }

	// RVA: 0x13E9520
	void InitializeData() { }

	// RVA: 0x13EA9B4
	void InstallRuntime(IInputRuntime runtime) { }

	// RVA: 0x13EB134
	void InstallGlobals() { }

	// RVA: 0x13EB4E4
	void UninstallGlobals() { }

	// RVA: 0x13E74D8
	void MakeDeviceNameUnique(InputDevice device) { }

	// RVA: 0x13EB934
	void ResetControlPathsRecursive(InputControl control) { }

	// RVA: 0x13E7688
	void AssignUniqueDeviceId(InputDevice device) { }

	// RVA: 0x13E32B0
	void ReallocateStateBuffers() { }

	// RVA: 0x13EB9F4
	void InitializeDefaultState(InputDevice device) { }

	// RVA: 0x13E7874
	void InitializeDeviceState(InputDevice device) { }

	// RVA: 0x13EBBB0
	void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x13EBFEC
	InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	// RVA: 0x13E3AEC
	void InstallBeforeUpdateHookIfNecessary() { }

	// RVA: 0x13EBFE8
	void RestoreDevicesAfterDomainReloadIfNecessary() { }

	// RVA: 0x13EC1D8
	void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	// RVA: 0x13EC1DC
	void OnBeforeUpdate(InputUpdateType updateType) { }

	// RVA: 0x13E2B9C
	void ApplySettings() { }

	// RVA: 0x13E3228
	void ApplyActions() { }

	// RVA: -1
	Int64 ExecuteGlobalCommand(ref TCommand command) { }

	// RVA: 0x13E374C
	void AddAvailableDevicesThatAreNowRecognized() { }

	// RVA: 0x13E7B54
	bool ShouldRunDeviceInBackground(InputDevice device) { }

	// RVA: 0x13EC3A8
	void OnFocusChanged(bool focus) { }

	// RVA: 0x13EC68C
	bool ShouldRunUpdate(InputUpdateType updateType) { }

	// RVA: 0x13EC6A8
	void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	// RVA: 0x13EDE28
	void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	// RVA: 0x13EE014
	void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	// RVA: 0x13EDEA0
	bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	// RVA: 0x13E8AC8
	bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, UInt32 stateOffsetInDevice, UInt32 stateSize, Double internalTime, InputEventPtr eventPtr) { }

	// RVA: 0x13EE3C0
	void WriteStateChange(DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, UInt32 stateOffsetInDevice, Void* statePtr, UInt32 stateSizeInBytes, bool flippedBuffers) { }

	// RVA: 0x13EE2F8
	bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	// RVA: 0x13EEA5C
	void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x13E82F0
	void RemoveStateChangeMonitors(InputDevice device) { }

	// RVA: 0x13EEEDC
	void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x13EF1B8
	void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x13EF298
	void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x13EE01C
	void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	// RVA: 0x13EF518
	void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	// RVA: 0x13EF644
	void FireStateChangeNotifications() { }

	// RVA: 0x13EE070
	bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, UInt32 newStateSizeInBytes, UInt32 newStateOffsetInBytes) { }

	// RVA: 0x13EE5A4
	void FireStateChangeNotifications(int deviceIndex, Double internalTime, InputEvent* eventPtr) { }

	// RVA: 0x13EDB5C
	void ProcessStateChangeMonitorTimeouts() { }

	// RVA: 0x13EF798
	void .ctor() { }

	// RVA: 0x13EF7A0
	Int64 <TryFindMatchingControlLayout>b__78_0(ref InputDeviceCommand commandRef) { }

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
public class iOSSettings 
{
	// Fields
	private PrivacyDataUsage m_MotionUsage; // 0x10

	// Methods

	// RVA: 0x13F1C70
	PrivacyDataUsage get_motionUsage() { }

	// RVA: 0x13F1C78
	void set_motionUsage(PrivacyDataUsage value) { }

	// RVA: 0x13F1BF8
	void .ctor() { }

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

	// RVA: 0x13F1240
	UpdateMode get_updateMode() { }

	// RVA: 0x13F1248
	void set_updateMode(UpdateMode value) { }

	// RVA: 0x13F1378
	bool get_compensateForScreenOrientation() { }

	// RVA: 0x13F1380
	void set_compensateForScreenOrientation(bool value) { }

	// RVA: 0x13F1398
	bool get_filterNoiseOnCurrent() { }

	// RVA: 0x13F13A0
	void set_filterNoiseOnCurrent(bool value) { }

	// RVA: 0x13F13A4
	float get_defaultDeadzoneMin() { }

	// RVA: 0x13F13AC
	void set_defaultDeadzoneMin(float value) { }

	// RVA: 0x13F13C4
	float get_defaultDeadzoneMax() { }

	// RVA: 0x13F13CC
	void set_defaultDeadzoneMax(float value) { }

	// RVA: 0x13F13E4
	float get_defaultButtonPressPoint() { }

	// RVA: 0x13F13EC
	void set_defaultButtonPressPoint(float value) { }

	// RVA: 0x13F1428
	float get_buttonReleaseThreshold() { }

	// RVA: 0x13F1430
	void set_buttonReleaseThreshold(float value) { }

	// RVA: 0x13F1448
	float get_defaultTapTime() { }

	// RVA: 0x13F1450
	void set_defaultTapTime(float value) { }

	// RVA: 0x13F1468
	float get_defaultSlowTapTime() { }

	// RVA: 0x13F1470
	void set_defaultSlowTapTime(float value) { }

	// RVA: 0x13F1488
	float get_defaultHoldTime() { }

	// RVA: 0x13F1490
	void set_defaultHoldTime(float value) { }

	// RVA: 0x13F14A8
	float get_tapRadius() { }

	// RVA: 0x13F14B0
	void set_tapRadius(float value) { }

	// RVA: 0x13F14C8
	float get_multiTapDelayTime() { }

	// RVA: 0x13F14D0
	void set_multiTapDelayTime(float value) { }

	// RVA: 0x13F14E8
	BackgroundBehavior get_backgroundBehavior() { }

	// RVA: 0x13F14F0
	void set_backgroundBehavior(BackgroundBehavior value) { }

	// RVA: 0x13F1508
	EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	// RVA: 0x13F1510
	void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	// RVA: 0x13F1528
	InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	// RVA: 0x13F1530
	void set_inputActionPropertyDrawerMode(InputActionPropertyDrawerMode value) { }

	// RVA: 0x13F1548
	int get_maxEventBytesPerUpdate() { }

	// RVA: 0x13F1550
	void set_maxEventBytesPerUpdate(int value) { }

	// RVA: 0x13F1568
	int get_maxQueuedEventsPerUpdate() { }

	// RVA: 0x13F1570
	void set_maxQueuedEventsPerUpdate(int value) { }

	// RVA: 0x13F1588
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> get_supportedDevices() { }

	// RVA: 0x13F15F4
	void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> value) { }

	// RVA: 0x13F177C
	bool get_disableRedundantEventsMerging() { }

	// RVA: 0x13F1784
	void set_disableRedundantEventsMerging(bool value) { }

	// RVA: 0x13F179C
	bool get_shortcutKeysConsumeInput() { }

	// RVA: 0x13F17A4
	void set_shortcutKeysConsumeInput(bool value) { }

	// RVA: 0x13F17BC
	void SetInternalFeatureFlag(string featureName, bool enabled) { }

	// RVA: 0x13F1A5C
	bool IsFeatureEnabled(string featureName) { }

	// RVA: 0x13F1260
	void OnChange() { }

	// RVA: 0x13F1AE8
	iOSSettings get_iOS() { }

	// RVA: 0x13F1AF0
	void .ctor() { }

}

// Namespace: 
public struct PlayerActions 
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x13F2810
	void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x13F2818
	InputAction get_Move() { }

	// RVA: 0x13F2838
	InputAction get_Look() { }

	// RVA: 0x13F2858
	InputAction get_Fire() { }

	// RVA: 0x13F2878
	InputActionMap Get() { }

	// RVA: 0x13F2898
	void Enable() { }

	// RVA: 0x13F28C0
	void Disable() { }

	// RVA: 0x13F28E8
	bool get_enabled() { }

	// RVA: 0x13F2910
	InputActionMap op_Implicit(PlayerActions set) { }

	// RVA: 0x13F292C
	void SetCallbacks(IPlayerActions instance) { }

}

// Namespace: 
public struct UIActions 
{
	// Fields
	private DefaultInputActions m_Wrapper; // 0x10

	// Methods

	// RVA: 0x13F35C4
	void .ctor(DefaultInputActions wrapper) { }

	// RVA: 0x13F35CC
	InputAction get_Navigate() { }

	// RVA: 0x13F35EC
	InputAction get_Submit() { }

	// RVA: 0x13F360C
	InputAction get_Cancel() { }

	// RVA: 0x13F362C
	InputAction get_Point() { }

	// RVA: 0x13F364C
	InputAction get_Click() { }

	// RVA: 0x13F366C
	InputAction get_ScrollWheel() { }

	// RVA: 0x13F368C
	InputAction get_MiddleClick() { }

	// RVA: 0x13F36AC
	InputAction get_RightClick() { }

	// RVA: 0x13F36CC
	InputAction get_TrackedDevicePosition() { }

	// RVA: 0x13F36EC
	InputAction get_TrackedDeviceOrientation() { }

	// RVA: 0x13F370C
	InputActionMap Get() { }

	// RVA: 0x13F372C
	void Enable() { }

	// RVA: 0x13F3754
	void Disable() { }

	// RVA: 0x13F377C
	bool get_enabled() { }

	// RVA: 0x13F37A4
	InputActionMap op_Implicit(UIActions set) { }

	// RVA: 0x13F37C0
	void SetCallbacks(IUIActions instance) { }

}

// Namespace: 
public interface IPlayerActions 
{
	// Methods

	// RVA: 0x309AF8C
	void OnMove(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnLook(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnFire(CallbackContext context) { }

}

// Namespace: 
public interface IUIActions 
{
	// Methods

	// RVA: 0x309AF8C
	void OnNavigate(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnSubmit(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnCancel(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnPoint(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnClick(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnScrollWheel(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnMiddleClick(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnRightClick(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnTrackedDevicePosition(CallbackContext context) { }

	// RVA: 0x309AF8C
	void OnTrackedDeviceOrientation(CallbackContext context) { }

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

	// RVA: 0x13F1C80
	InputActionAsset get_asset() { }

	// RVA: 0x13F1C88
	void .ctor() { }

	// RVA: 0x13F20C8
	void Dispose() { }

	// RVA: 0x13F2158
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }

	// RVA: 0x13F2198
	void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }

	// RVA: 0x13F21E0
	System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }

	// RVA: 0x13F222C
	void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }

	// RVA: 0x13F226C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }

	// RVA: 0x13F228C
	bool Contains(InputAction action) { }

	// RVA: 0x13F22AC
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }

	// RVA: 0x13F22CC
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13F22EC
	void Enable() { }

	// RVA: 0x13F230C
	void Disable() { }

	// RVA: 0x13F232C
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }

	// RVA: 0x13F234C
	InputAction FindAction(string actionNameOrId, bool throwIfNotFound) { }

	// RVA: 0x13F236C
	int FindBinding(InputBinding bindingMask, out InputAction action) { }

	// RVA: 0x13F23BC
	PlayerActions get_Player() { }

	// RVA: 0x13F23E8
	UIActions get_UI() { }

	// RVA: 0x13F2414
	InputControlScheme get_KeyboardMouseScheme() { }

	// RVA: 0x13F24E0
	InputControlScheme get_GamepadScheme() { }

	// RVA: 0x13F25AC
	InputControlScheme get_TouchScheme() { }

	// RVA: 0x13F2678
	InputControlScheme get_JoystickScheme() { }

	// RVA: 0x13F2744
	InputControlScheme get_XRScheme() { }

}

// Namespace: UnityEngine.InputSystem
public class InputValue 
{
	// Fields
	internal System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext> m_Context; // 0x10

	// Methods

	// RVA: 0x13F6090
	object Get() { }

	// RVA: 0x309AF8C
	TValue Get() { }

	// RVA: 0x13F6108
	bool get_isPressed() { }

	// RVA: 0x13F6198
	void .ctor() { }

}

// Namespace: 
public class ActionEvent 
{
	// Fields
	private string m_ActionId; // 0x30
	private string m_ActionName; // 0x38

	// Methods

	// RVA: 0x13FE9C4
	string get_actionId() { }

	// RVA: 0x13FE9CC
	string get_actionName() { }

	// RVA: 0x13FE9D4
	void .ctor() { }

	// RVA: 0x13FEA28
	void .ctor(InputAction action) { }

	// RVA: 0x13FEC0C
	void .ctor(Guid actionGUID, string name) { }

}

// Namespace: 
public class DeviceLostEvent 
{
	// Methods

	// RVA: 0x13F80D0
	void .ctor() { }

}

// Namespace: 
public class DeviceRegainedEvent 
{
	// Methods

	// RVA: 0x13F81E4
	void .ctor() { }

}

// Namespace: 
public class ControlsChangedEvent 
{
	// Methods

	// RVA: 0x13F82F8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PlayerInput 
{
	// Fields
	public const string DeviceLostMessage = 5730681600;
	public const string DeviceRegainedMessage = 5730681472;
	public const string ControlsChangedMessage = 5730681408;
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

	// RVA: 0x13F61A0
	bool get_inputIsActive() { }

	// RVA: 0x13F61A8
	bool get_active() { }

	// RVA: 0x13F61B0
	int get_playerIndex() { }

	// RVA: 0x13F61B8
	int get_splitScreenIndex() { }

	// RVA: 0x13F61C0
	InputActionAsset get_actions() { }

	// RVA: 0x13F67B8
	void set_actions(InputActionAsset value) { }

	// RVA: 0x13F780C
	string get_currentControlScheme() { }

	// RVA: 0x13F7B68
	string get_defaultControlScheme() { }

	// RVA: 0x13F7B70
	void set_defaultControlScheme(string value) { }

	// RVA: 0x13F7B78
	bool get_neverAutoSwitchControlSchemes() { }

	// RVA: 0x13F7B80
	void set_neverAutoSwitchControlSchemes(bool value) { }

	// RVA: 0x13F7E38
	InputActionMap get_currentActionMap() { }

	// RVA: 0x13F7E40
	void set_currentActionMap(InputActionMap value) { }

	// RVA: 0x13F7EB8
	string get_defaultActionMap() { }

	// RVA: 0x13F7EC0
	void set_defaultActionMap(string value) { }

	// RVA: 0x13F7EC8
	PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x13F7ED0
	void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x13F7F2C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents() { }

	// RVA: 0x13F7F80
	void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value) { }

	// RVA: 0x13F8010
	DeviceLostEvent get_deviceLostEvent() { }

	// RVA: 0x13F8124
	DeviceRegainedEvent get_deviceRegainedEvent() { }

	// RVA: 0x13F8238
	ControlsChangedEvent get_controlsChangedEvent() { }

	// RVA: 0x13F834C
	void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13F83F4
	void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }

	// RVA: 0x13F849C
	void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13F8544
	void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13F85EC
	void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13F8694
	void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13F873C
	void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13F87E4
	void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13F888C
	Camera get_camera() { }

	// RVA: 0x13F8894
	void set_camera(Camera value) { }

	// RVA: 0x13F889C
	InputSystemUIInputModule get_uiInputModule() { }

	// RVA: 0x13F88A4
	void set_uiInputModule(InputSystemUIInputModule value) { }

	// RVA: 0x13F8D18
	InputUser get_user() { }

	// RVA: 0x13F8D20
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }

	// RVA: 0x13F8E8C
	bool get_hasMissingRequiredDevices() { }

	// RVA: 0x13F902C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all() { }

	// RVA: 0x13F90C0
	bool get_isSinglePlayer() { }

	// RVA: 0x309AF8C
	TDevice GetDevice() { }

	// RVA: 0x13F773C
	void ActivateInput() { }

	// RVA: 0x13F941C
	void DeactivateInput() { }

	// RVA: 0x13F944C
	void PassivateInput() { }

	// RVA: 0x13F947C
	bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	// RVA: 0x13F9B68
	void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	// RVA: 0x13F922C
	void SwitchCurrentActionMap(string mapNameOrId) { }

	// RVA: 0x13F9D08
	PlayerInput GetPlayerByIndex(int playerIndex) { }

	// RVA: 0x13F9E1C
	PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	// RVA: 0x13FA038
	PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice pairWithDevice) { }

	// RVA: 0x13FA4B4
	PlayerInput Instantiate(GameObject prefab, int playerIndex, string controlScheme, int splitScreenIndex, InputDevice[] pairWithDevices) { }

	// RVA: 0x13FA1C8
	PlayerInput DoInstantiate(GameObject prefab) { }

	// RVA: 0x13F6220
	void InitializeActions() { }

	// RVA: 0x13F6914
	void UninitializeActions() { }

	// RVA: 0x13FA698
	void InstallOnActionTriggeredHook() { }

	// RVA: 0x13FAC6C
	void UninstallOnActionTriggeredHook() { }

	// RVA: 0x13FADEC
	void OnActionTriggered(CallbackContext context) { }

	// RVA: 0x13FA88C
	void CacheMessageNames() { }

	// RVA: 0x13F6B08
	void ClearCaches() { }

	// RVA: 0x13F6B0C
	void AssignUserAndDevices() { }

	// RVA: 0x13FB898
	bool HaveBindingForDevice(InputDevice device) { }

	// RVA: 0x13FBD58
	void UnassignUserAndDevices() { }

	// RVA: 0x13FB4B8
	bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	// RVA: 0x13FC2F4
	void AssignPlayerIndex() { }

	// RVA: 0x13FC548
	void OnEnable() { }

	// RVA: 0x13F7C40
	void StartListeningForUnpairedDeviceActivity() { }

	// RVA: 0x13F7DBC
	void StopListeningForUnpairedDeviceActivity() { }

	// RVA: 0x13FCB0C
	void StartListeningForDeviceChanges() { }

	// RVA: 0x13FD328
	void StopListeningForDeviceChanges() { }

	// RVA: 0x13FD398
	void OnDisable() { }

	// RVA: 0x13FD8FC
	void DebugLogAction(CallbackContext context) { }

	// RVA: 0x13FD974
	void HandleDeviceLost() { }

	// RVA: 0x13FDA9C
	void HandleDeviceRegained() { }

	// RVA: 0x13FCC18
	void HandleControlsChanged() { }

	// RVA: 0x13FDBC4
	void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	// RVA: 0x13FDD50
	bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	// RVA: 0x13FDF18
	void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x13FE750
	void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x13F96D8
	void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, InputDevice[] devices) { }

	// RVA: 0x13FE960
	void .ctor() { }

	// RVA: 0x13FE974
	void .cctor() { }

}

// Namespace: 
public class PlayerJoinedEvent 
{
	// Methods

	// RVA: 0x13FFBE8
	void .ctor() { }

}

// Namespace: 
public class PlayerLeftEvent 
{
	// Methods

	// RVA: 0x13FFCFC
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem
public class PlayerInputManager 
{
	// Fields
	public const string PlayerJoinedMessage = 5730681216;
	public const string PlayerLeftMessage = 5730681152;
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

	// RVA: 0x13FECA0
	bool get_splitScreen() { }

	// RVA: 0x13FECA8
	void set_splitScreen(bool value) { }

	// RVA: 0x13FF5E8
	bool get_maintainAspectRatioInSplitScreen() { }

	// RVA: 0x13FF5F0
	int get_fixedNumberOfSplitScreens() { }

	// RVA: 0x13FF5F8
	Rect get_splitScreenArea() { }

	// RVA: 0x13FF604
	int get_playerCount() { }

	// RVA: 0x13FF680
	int get_maxPlayerCount() { }

	// RVA: 0x13FF688
	bool get_joiningEnabled() { }

	// RVA: 0x13FF690
	PlayerJoinBehavior get_joinBehavior() { }

	// RVA: 0x13FF698
	void set_joinBehavior(PlayerJoinBehavior value) { }

	// RVA: 0x13FFA2C
	InputActionProperty get_joinAction() { }

	// RVA: 0x13FFA40
	void set_joinAction(InputActionProperty value) { }

	// RVA: 0x13FFB18
	PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x13FFB20
	void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x13FFB28
	PlayerJoinedEvent get_playerJoinedEvent() { }

	// RVA: 0x13FFC3C
	PlayerLeftEvent get_playerLeftEvent() { }

	// RVA: 0x13FFD50
	void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13FFDF8
	void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13FFEA0
	void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13FFF48
	void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }

	// RVA: 0x13FFFF0
	GameObject get_playerPrefab() { }

	// RVA: 0x13FFFF8
	void set_playerPrefab(GameObject value) { }

	// RVA: 0x1400000
	PlayerInputManager get_instance() { }

	// RVA: 0x140004C
	void set_instance(PlayerInputManager value) { }

	// RVA: 0x13FF7E0
	void EnableJoining() { }

	// RVA: 0x13FF6EC
	void DisableJoining() { }

	// RVA: 0x14000B4
	void JoinPlayerFromUI() { }

	// RVA: 0x1400438
	void JoinPlayerFromAction(CallbackContext context) { }

	// RVA: 0x14005CC
	void JoinPlayerFromActionIfNotAlreadyJoined(CallbackContext context) { }

	// RVA: 0x14004FC
	PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice pairWithDevice) { }

	// RVA: 0x1400730
	PlayerInput JoinPlayer(int playerIndex, int splitScreenIndex, string controlScheme, InputDevice[] pairWithDevices) { }

	// RVA: 0x1400800
	string[] get_messages() { }

	// RVA: 0x140010C
	bool CheckIfPlayerCanJoin(int playerIndex) { }

	// RVA: 0x14008C0
	void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x1400E68
	void OnEnable() { }

	// RVA: 0x1401298
	void OnDisable() { }

	// RVA: 0x13FEF78
	void UpdateSplitScreen() { }

	// RVA: 0x14009E0
	bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	// RVA: 0x14000B0
	void ValidateInputActionAsset() { }

	// RVA: 0x13FCD40
	void NotifyPlayerJoined(PlayerInput player) { }

	// RVA: 0x13FD7B0
	void NotifyPlayerLeft(PlayerInput player) { }

	// RVA: 0x14013B0
	void .ctor() { }

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

	// RVA: 0x14013D8
	void SetLength(int newLength) { }

	// RVA: 0x1401470
	void SetBit(int bitIndex) { }

	// RVA: 0x1401530
	bool TestBit(int bitIndex) { }

	// RVA: 0x14015B4
	void ClearBit(int bitIndex) { }

	// RVA: 0x1401458
	int BitCountToULongCount(int bitCount) { }

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

	// RVA: 0x1401674
	TrackingType get_trackingType() { }

	// RVA: 0x140167C
	void set_trackingType(TrackingType value) { }

	// RVA: 0x1401684
	UpdateType get_updateType() { }

	// RVA: 0x140168C
	void set_updateType(UpdateType value) { }

	// RVA: 0x1401694
	bool get_ignoreTrackingState() { }

	// RVA: 0x140169C
	void set_ignoreTrackingState(bool value) { }

	// RVA: 0x14016A4
	InputActionProperty get_positionInput() { }

	// RVA: 0x14016B8
	void set_positionInput(InputActionProperty value) { }

	// RVA: 0x1401ABC
	InputActionProperty get_rotationInput() { }

	// RVA: 0x1401AD0
	void set_rotationInput(InputActionProperty value) { }

	// RVA: 0x1401ED4
	InputActionProperty get_trackingStateInput() { }

	// RVA: 0x1401EE8
	void set_trackingStateInput(InputActionProperty value) { }

	// RVA: 0x14022EC
	void BindActions() { }

	// RVA: 0x1402318
	void UnbindActions() { }

	// RVA: 0x1401910
	void BindPosition() { }

	// RVA: 0x1401D28
	void BindRotation() { }

	// RVA: 0x1402140
	void BindTrackingState() { }

	// RVA: 0x14017B4
	void UnbindPosition() { }

	// RVA: 0x1401BCC
	void UnbindRotation() { }

	// RVA: 0x1401FE4
	void UnbindTrackingState() { }

	// RVA: 0x1402344
	void OnPositionPerformed(CallbackContext context) { }

	// RVA: 0x14023BC
	void OnPositionCanceled(CallbackContext context) { }

	// RVA: 0x1402418
	void OnRotationPerformed(CallbackContext context) { }

	// RVA: 0x1402488
	void OnRotationCanceled(CallbackContext context) { }

	// RVA: 0x14024DC
	void OnTrackingStatePerformed(CallbackContext context) { }

	// RVA: 0x140254C
	void OnTrackingStateCanceled(CallbackContext context) { }

	// RVA: 0x1402554
	void Reset() { }

	// RVA: 0x1402758
	void Awake() { }

	// RVA: 0x140275C
	void OnEnable() { }

	// RVA: 0x1402830
	void OnDisable() { }

	// RVA: 0x14028F8
	void OnDestroy() { }

	// RVA: 0x14028FC
	void UpdateCallback() { }

	// RVA: 0x1402A50
	void ReadTrackingState() { }

	// RVA: 0x1402B98
	void OnUpdate() { }

	// RVA: 0x1402BB4
	void OnBeforeRender() { }

	// RVA: 0x1402BD4
	void PerformUpdate() { }

	// RVA: 0x1402BF0
	void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	// RVA: 0x1402D74
	bool HasStereoCamera(out Camera cameraComponent) { }

	// RVA: 0x1402DF8
	InputAction get_positionAction() { }

	// RVA: 0x1402E04
	void set_positionAction(InputAction value) { }

	// RVA: 0x1402E58
	InputAction get_rotationAction() { }

	// RVA: 0x1402E64
	void set_rotationAction(InputAction value) { }

	// RVA: 0x1402EB8
	void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1402EBC
	void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1402F98
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.XInput
public interface IXboxOneRumble 
{
	// Methods

	// RVA: -1
	void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger) { }

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

	// RVA: 0x1403044
	ButtonControl get_menu() { }

	// RVA: 0x140304C
	void set_menu(ButtonControl value) { }

	// RVA: 0x140305C
	ButtonControl get_view() { }

	// RVA: 0x1403064
	void set_view(ButtonControl value) { }

	// RVA: 0x1403074
	DeviceSubType get_subType() { }

	// RVA: 0x14031BC
	DeviceFlags get_flags() { }

	// RVA: 0x140325C
	void FinishSetup() { }

	// RVA: 0x1403114
	void ParseCapabilities() { }

	// RVA: 0x140329C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.XInput
internal static class XInputSupport 
{
	// Methods

	// RVA: 0x14032A4
	void Initialize() { }

}

// Namespace: 
public struct ControlSchemeChangeSyntax 
{
	// Fields
	internal int m_UserIndex; // 0x10

	// Methods

	// RVA: 0x13FC238
	ControlSchemeChangeSyntax AndPairRemainingDevices() { }

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

	// RVA: 0x1408BBC
	int Compare(InputDevice x, InputDevice y) { }

	// RVA: 0x1409200
	System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> GetUserAccountHandleForDevice(InputDevice device) { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Users.InputUser.<>c <>9; // 0x0
	public static TypedRestore <>9__86_0; // 0x8
	public static Action <>9__86_1; // 0x10

	// Methods

	// RVA: 0x140920C
	void .cctor() { }

	// RVA: 0x1409278
	void .ctor() { }

	// RVA: 0x1409280
	void <SaveAndResetState>b__86_0(ref GlobalState state) { }

	// RVA: 0x14092F0
	void <SaveAndResetState>b__86_1() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUser 
{
	// Fields
	public const UInt32 InvalidId = 0;
	private UInt32 m_Id; // 0x10
	private static GlobalState s_GlobalState; // 0x0

	// Methods

	// RVA: 0x13F7A30
	bool get_valid() { }

	// RVA: 0x1403318
	int get_index() { }

	// RVA: 0x1403520
	UInt32 get_id() { }

	// RVA: 0x1403528
	System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle() { }

	// RVA: 0x14035BC
	string get_platformUserAccountName() { }

	// RVA: 0x1403640
	string get_platformUserAccountId() { }

	// RVA: 0x13F8DD4
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices() { }

	// RVA: 0x14036C4
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices() { }

	// RVA: 0x140377C
	IInputActionCollection get_actions() { }

	// RVA: 0x13F7AD8
	System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme() { }

	// RVA: 0x1403800
	MatchResult get_controlSchemeMatch() { }

	// RVA: 0x13F8FA4
	bool get_hasMissingRequiredDevices() { }

	// RVA: 0x14038A4
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all() { }

	// RVA: 0x13FCA54
	void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x13FD6F8
	void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }

	// RVA: 0x13FCE8C
	void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x13FD170
	void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x13FCF68
	void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x13FD270
	void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x13FD020
	int get_listenForUnpairedDeviceActivity() { }

	// RVA: 0x13FD06C
	void set_listenForUnpairedDeviceActivity(int value) { }

	// RVA: 0x1403B24
	string ToString() { }

	// RVA: 0x13FB9E0
	void AssociateActionsWithUser(IInputActionCollection actions) { }

	// RVA: 0x13FC264
	ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	// RVA: 0x14043B0
	bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) { }

	// RVA: 0x13F9C48
	void FindControlScheme(string schemeName, out InputControlScheme scheme) { }

	// RVA: 0x13FBF84
	ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	// RVA: 0x1403FC8
	void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	// RVA: 0x13FE884
	void UnpairDevice(InputDevice device) { }

	// RVA: 0x13FB010
	void UnpairDevices() { }

	// RVA: 0x14053BC
	void RemoveLostDevicesForUser(int userIndex) { }

	// RVA: 0x13FBEE4
	void UnpairDevicesAndRemoveUser() { }

	// RVA: 0x13FB818
	UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() { }

	// RVA: 0x1405DDC
	int GetUnpairedInputDevices(ref UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>& list) { }

	// RVA: 0x1405FE8
	System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(InputDevice device) { }

	// RVA: 0x1406204
	System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	// RVA: 0x13FBF14
	InputUser CreateUserWithoutPairedDevices() { }

	// RVA: 0x13FB284
	InputUser PerformPairingWithDevice(InputDevice device, InputUser user, InputUserPairingOptions options) { }

	// RVA: 0x1406828
	bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	// RVA: 0x14075F0
	bool Equals(InputUser other) { }

	// RVA: 0x1407600
	bool Equals(object obj) { }

	// RVA: 0x1407690
	int GetHashCode() { }

	// RVA: 0x13FDD44
	bool op_Equality(InputUser left, InputUser right) { }

	// RVA: 0x140681C
	bool op_Inequality(InputUser left, InputUser right) { }

	// RVA: 0x1406720
	int AddUser() { }

	// RVA: 0x1405A50
	void RemoveUser(int userIndex) { }

	// RVA: 0x1404648
	void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	// RVA: 0x1403480
	int TryFindUserIndex(UInt32 userId) { }

	// RVA: 0x14064B4
	int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	// RVA: 0x1406100
	int TryFindUserIndex(InputDevice device) { }

	// RVA: 0x1406970
	void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice, bool dontUpdateControlScheme) { }

	// RVA: 0x1405500
	void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice) { }

	// RVA: 0x140495C
	void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing) { }

	// RVA: 0x1406DF0
	Int64 UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

	// RVA: 0x1407800
	Int64 QueryPairedPlatformUserAccount(InputDevice device, out System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>& platformAccountHandle, out string platformAccountName, out string platformAccountId) { }

	// RVA: 0x14073F4
	bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	// RVA: 0x1407B28
	void OnActionChange(object obj, InputActionChange change) { }

	// RVA: 0x1407C50
	void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1408130
	int FindLostDevice(InputDevice device, int startIndex) { }

	// RVA: 0x14081FC
	void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x140871C
	ISavedState SaveAndResetState() { }

	// RVA: 0x1403E8C
	void HookIntoActionChange() { }

	// RVA: 0x1407728
	void UnhookFromActionChange() { }

	// RVA: 0x14074BC
	void HookIntoDeviceChange() { }

	// RVA: 0x1407698
	void UnhookFromDeviceChange() { }

	// RVA: 0x1403930
	void HookIntoEvents() { }

	// RVA: 0x1403A78
	void UnhookFromDeviceStateChange() { }

	// RVA: 0x140896C
	void DisposeAndResetGlobalState() { }

	// RVA: 0x1408A58
	void ResetGlobals() { }

}

// Namespace: UnityEngine.InputSystem.Users
public struct InputUserAccountHandle 
{
	// Fields
	private string m_ApiName; // 0x10
	private UInt64 m_Handle; // 0x18

	// Methods

	// RVA: 0x14093DC
	string get_apiName() { }

	// RVA: 0x14093E4
	UInt64 get_handle() { }

	// RVA: 0x1407A90
	void .ctor(string apiName, UInt64 handle) { }

	// RVA: 0x14093EC
	string ToString() { }

	// RVA: 0x14094C8
	bool Equals(InputUserAccountHandle other) { }

	// RVA: 0x1409598
	bool Equals(object obj) { }

	// RVA: 0x14063D8
	bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x14079C0
	bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	// RVA: 0x14096CC
	int GetHashCode() { }

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

	// RVA: 0x140972C
	string get_customBindings() { }

	// RVA: 0x1409734
	void set_customBindings(string value) { }

	// RVA: 0x140973C
	bool get_invertMouseX() { }

	// RVA: 0x1409744
	void set_invertMouseX(bool value) { }

	// RVA: 0x140974C
	bool get_invertMouseY() { }

	// RVA: 0x1409754
	void set_invertMouseY(bool value) { }

	// RVA: 0x140975C
	System.Nullable<System.Single> get_mouseSmoothing() { }

	// RVA: 0x1409764
	void set_mouseSmoothing(System.Nullable<System.Single> value) { }

	// RVA: 0x140976C
	System.Nullable<System.Single> get_mouseSensitivity() { }

	// RVA: 0x1409774
	void set_mouseSensitivity(System.Nullable<System.Single> value) { }

	// RVA: 0x140977C
	bool get_invertStickX() { }

	// RVA: 0x1409784
	void set_invertStickX(bool value) { }

	// RVA: 0x140978C
	bool get_invertStickY() { }

	// RVA: 0x1409794
	void set_invertStickY(bool value) { }

	// RVA: 0x140979C
	bool get_swapSticks() { }

	// RVA: 0x14097A4
	void set_swapSticks(bool value) { }

	// RVA: 0x14097AC
	bool get_swapBumpers() { }

	// RVA: 0x14097B4
	void set_swapBumpers(bool value) { }

	// RVA: 0x14097BC
	bool get_swapTriggers() { }

	// RVA: 0x14097C4
	void set_swapTriggers(bool value) { }

	// RVA: 0x14097CC
	bool get_swapDpadAndLeftStick() { }

	// RVA: 0x14097D4
	void set_swapDpadAndLeftStick(bool value) { }

	// RVA: 0x14097DC
	float get_vibrationStrength() { }

	// RVA: 0x14097E4
	void set_vibrationStrength(float value) { }

	// RVA: 0x14097EC
	void Apply(IInputActionCollection actions) { }

	// RVA: 0x14097F0
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class BaseInputOverride 
{
	// Fields
	private readonly string <compositionString>k__BackingField; // 0x20

	// Methods

	// RVA: 0x14097F8
	string get_compositionString() { }

	// RVA: 0x1409800
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
internal class ExtendedAxisEventData 
{
	// Methods

	// RVA: 0x1409808
	void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1409810
	string ToString() { }

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

	// RVA: 0x14098D4
	void .ctor(EventSystem eventSystem) { }

	// RVA: 0x14098DC
	InputControl get_control() { }

	// RVA: 0x14098E4
	void set_control(InputControl value) { }

	// RVA: 0x14098F4
	InputDevice get_device() { }

	// RVA: 0x14098FC
	void set_device(InputDevice value) { }

	// RVA: 0x140990C
	int get_touchId() { }

	// RVA: 0x1409914
	void set_touchId(int value) { }

	// RVA: 0x140991C
	UIPointerType get_pointerType() { }

	// RVA: 0x1409924
	void set_pointerType(UIPointerType value) { }

	// RVA: 0x140992C
	int get_uiToolkitPointerId() { }

	// RVA: 0x1409934
	void set_uiToolkitPointerId(int value) { }

	// RVA: 0x140993C
	Vector3 get_trackedDevicePosition() { }

	// RVA: 0x140994C
	void set_trackedDevicePosition(Vector3 value) { }

	// RVA: 0x140995C
	Quaternion get_trackedDeviceOrientation() { }

	// RVA: 0x1409970
	void set_trackedDeviceOrientation(Quaternion value) { }

	// RVA: 0x1409984
	string ToString() { }

	// RVA: 0x1409EF4
	int MakePointerIdForTouch(int deviceId, int touchId) { }

	// RVA: 0x1409EFC
	int TouchIdFromPointerId(int pointerId) { }

	// RVA: 0x1409F04
	void ReadDeviceState() { }

	// RVA: 0x140A238
	int GetPenPointerId(Pen pen) { }

	// RVA: 0x140A478
	int GetTouchPointerId(TouchControl touchControl) { }

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
	private const float kClickSpeed = 1050253722;
	private float m_MoveRepeatDelay; // 0x58
	private float m_MoveRepeatRate; // 0x5C
	private float m_TrackedDeviceDragThresholdMultiplier; // 0x60
	private Transform m_XRTrackingOrigin; // 0x68
	private static DefaultInputActions defaultActions; // 0x0
	internal const float kPixelPerLine = 1101004800;
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

	// RVA: 0x140A570
	bool get_deselectOnBackgroundClick() { }

	// RVA: 0x140A578
	void set_deselectOnBackgroundClick(bool value) { }

	// RVA: 0x140A580
	UIPointerBehavior get_pointerBehavior() { }

	// RVA: 0x140A588
	void set_pointerBehavior(UIPointerBehavior value) { }

	// RVA: 0x140A590
	CursorLockBehavior get_cursorLockBehavior() { }

	// RVA: 0x140A598
	void set_cursorLockBehavior(CursorLockBehavior value) { }

	// RVA: 0x140A5A0
	GameObject get_localMultiPlayerRoot() { }

	// RVA: 0x140A5A8
	void set_localMultiPlayerRoot(GameObject value) { }

	// RVA: 0x140A5B8
	void ActivateModule() { }

	// RVA: 0x140A694
	bool IsPointerOverGameObject(int pointerOrTouchId) { }

	// RVA: 0x140A998
	RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	// RVA: 0x140AA70
	RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	// RVA: 0x140AD50
	void ProcessPointer(ref PointerModel state) { }

	// RVA: 0x140C1B0
	bool PointerShouldIgnoreTransform(Transform t) { }

	// RVA: 0x140B1C4
	void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData) { }

	// RVA: 0x140C2CC
	void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	// RVA: 0x140B220
	void ProcessPointerButton(ref ButtonState button, PointerEventData eventData) { }

	// RVA: 0x140BC2C
	void ProcessPointerButtonDrag(ref ButtonState button, ExtendedPointerEventData eventData) { }

	// RVA: 0x140BFFC
	void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData) { }

	// RVA: 0x140CAB0
	void ProcessNavigation(ref NavigationModel navigationState) { }

	// RVA: 0x140D17C
	bool IsMoveAllowed(AxisEventData eventData) { }

	// RVA: 0x140D4B8
	float get_moveRepeatDelay() { }

	// RVA: 0x140D4C0
	void set_moveRepeatDelay(float value) { }

	// RVA: 0x140D4C8
	float get_moveRepeatRate() { }

	// RVA: 0x140D4D0
	void set_moveRepeatRate(float value) { }

	// RVA: 0x140D4D8
	bool get_explictlyIgnoreFocus() { }

	// RVA: 0x140D55C
	bool get_shouldIgnoreFocus() { }

	// RVA: 0x140D6BC
	float get_repeatRate() { }

	// RVA: 0x140D6C4
	void set_repeatRate(float value) { }

	// RVA: 0x140D6CC
	float get_repeatDelay() { }

	// RVA: 0x140D6D4
	void set_repeatDelay(float value) { }

	// RVA: 0x140D6DC
	Transform get_xrTrackingOrigin() { }

	// RVA: 0x140D6E4
	void set_xrTrackingOrigin(Transform value) { }

	// RVA: 0x140D6EC
	float get_trackedDeviceDragThresholdMultiplier() { }

	// RVA: 0x140D6F4
	void set_trackedDeviceDragThresholdMultiplier(float value) { }

	// RVA: 0x140D6FC
	void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback) { }

	// RVA: 0x140DD68
	InputActionReference get_point() { }

	// RVA: 0x140DD70
	void set_point(InputActionReference value) { }

	// RVA: 0x140DD84
	InputActionReference get_scrollWheel() { }

	// RVA: 0x140DD8C
	void set_scrollWheel(InputActionReference value) { }

	// RVA: 0x140DDA0
	InputActionReference get_leftClick() { }

	// RVA: 0x140DDA8
	void set_leftClick(InputActionReference value) { }

	// RVA: 0x140DDBC
	InputActionReference get_middleClick() { }

	// RVA: 0x140DDC4
	void set_middleClick(InputActionReference value) { }

	// RVA: 0x140DDD8
	InputActionReference get_rightClick() { }

	// RVA: 0x140DDE0
	void set_rightClick(InputActionReference value) { }

	// RVA: 0x140DDF4
	InputActionReference get_move() { }

	// RVA: 0x140DDFC
	void set_move(InputActionReference value) { }

	// RVA: 0x140DE10
	InputActionReference get_submit() { }

	// RVA: 0x140DE18
	void set_submit(InputActionReference value) { }

	// RVA: 0x140DE2C
	InputActionReference get_cancel() { }

	// RVA: 0x140DE34
	void set_cancel(InputActionReference value) { }

	// RVA: 0x140DE48
	InputActionReference get_trackedDeviceOrientation() { }

	// RVA: 0x140DE50
	void set_trackedDeviceOrientation(InputActionReference value) { }

	// RVA: 0x140DE64
	InputActionReference get_trackedDevicePosition() { }

	// RVA: 0x140DE6C
	void set_trackedDevicePosition(InputActionReference value) { }

	// RVA: 0x140DE80
	void AssignDefaultActions() { }

	// RVA: 0x140E274
	void UnassignActions() { }

	// RVA: 0x140E478
	InputActionReference get_trackedDeviceSelect() { }

	// RVA: 0x140E4B8
	void set_trackedDeviceSelect(InputActionReference value) { }

	// RVA: 0x140E4F8
	void Awake() { }

	// RVA: 0x140E524
	void OnDestroy() { }

	// RVA: 0x140E578
	void OnEnable() { }

	// RVA: 0x140ECDC
	void OnDisable() { }

	// RVA: 0x140E8C8
	void ResetPointers() { }

	// RVA: 0x140E6B0
	bool HasNoActions() { }

	// RVA: 0x140EC74
	void EnableAllActions() { }

	// RVA: 0x140EDA4
	void DisableAllActions() { }

	// RVA: 0x140DBE4
	void EnableInputAction(InputActionReference inputActionReference) { }

	// RVA: 0x140DA34
	void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling) { }

	// RVA: 0x140A854
	int GetPointerStateIndexFor(int pointerOrTouchId) { }

	// RVA: 0x140EF48
	ref PointerModel GetPointerStateForIndex(int index) { }

	// RVA: 0x140EF94
	int GetDisplayIndexFor(InputControl control) { }

	// RVA: 0x140F05C
	int GetPointerStateIndexFor(ref CallbackContext context) { }

	// RVA: 0x140F174
	int GetPointerStateIndexFor(InputControl control, bool createIfNotExists) { }

	// RVA: 0x140FB30
	int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl) { }

	// RVA: 0x140EE58
	void SendPointerExitEventsAndRemovePointer(int index) { }

	// RVA: 0x140FD28
	void RemovePointerAtIndex(int index) { }

	// RVA: 0x140FF94
	void PurgeStalePointers() { }

	// RVA: 0x140FA58
	bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	// RVA: 0x141012C
	void OnPointCallback(CallbackContext context) { }

	// RVA: 0x1410274
	bool IgnoreNextClick(ref CallbackContext context, bool wasPressed) { }

	// RVA: 0x141043C
	void OnLeftClickCallback(CallbackContext context) { }

	// RVA: 0x1410514
	void OnRightClickCallback(CallbackContext context) { }

	// RVA: 0x14105EC
	void OnMiddleClickCallback(CallbackContext context) { }

	// RVA: 0x140F104
	bool CheckForRemovedDevice(ref CallbackContext context) { }

	// RVA: 0x14106C4
	void OnScrollCallback(CallbackContext context) { }

	// RVA: 0x14107B4
	void OnMoveCallback(CallbackContext context) { }

	// RVA: 0x1410824
	void OnTrackedDeviceOrientationCallback(CallbackContext context) { }

	// RVA: 0x1410904
	void OnTrackedDevicePositionCallback(CallbackContext context) { }

	// RVA: 0x14109E4
	void OnControlsChanged(object obj) { }

	// RVA: 0x14109F0
	void FilterPointerStatesByType() { }

	// RVA: 0x1410C44
	void Process() { }

	// RVA: 0x1410E00
	int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x140E910
	void HookActions() { }

	// RVA: 0x140E564
	void UnhookActions() { }

	// RVA: 0x1410EEC
	void SetActionCallbacks(bool install) { }

	// RVA: 0x1410FDC
	void SetActionCallback(InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x14110DC
	InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

	// RVA: 0x1411168
	InputActionAsset get_actionsAsset() { }

	// RVA: 0x13F8AA0
	void set_actionsAsset(InputActionAsset value) { }

	// RVA: 0x1411170
	void .ctor() { }

	// RVA: 0x141119C
	void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.UI
public class MultiplayerEventSystem 
{
	// Fields
	private GameObject m_PlayerRoot; // 0x60

	// Methods

	// RVA: 0x1411818
	GameObject get_playerRoot() { }

	// RVA: 0x1411820
	void set_playerRoot(GameObject value) { }

	// RVA: 0x1411978
	void OnEnable() { }

	// RVA: 0x14119A0
	void OnDisable() { }

	// RVA: 0x1411848
	void InitializePlayerRoot() { }

	// RVA: 0x14119A8
	void Update() { }

	// RVA: 0x1411AB8
	void .ctor() { }

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

	// RVA: 0x1411B40
	void Reset() { }

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

	// RVA: 0x1412024
	bool get_isPressed() { }

	// RVA: 0x141202C
	void set_isPressed(bool value) { }

	// RVA: 0x141207C
	bool get_ignoreNextClick() { }

	// RVA: 0x1412084
	void set_ignoreNextClick(bool value) { }

	// RVA: 0x141208C
	float get_pressTime() { }

	// RVA: 0x1412094
	void set_pressTime(float value) { }

	// RVA: 0x141209C
	bool get_clickedOnSameGameObject() { }

	// RVA: 0x14120A4
	void set_clickedOnSameGameObject(bool value) { }

	// RVA: 0x14120AC
	bool get_wasPressedThisFrame() { }

	// RVA: 0x14120BC
	bool get_wasReleasedThisFrame() { }

	// RVA: 0x14120D0
	void CopyPressStateTo(PointerEventData eventData) { }

	// RVA: 0x1412194
	void CopyPressStateFrom(PointerEventData eventData) { }

	// RVA: 0x1411EC8
	void OnEndFrame() { }

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

	// RVA: 0x1411B94
	UIPointerType get_pointerType() { }

	// RVA: 0x1411BB4
	Vector2 get_screenPosition() { }

	// RVA: 0x1411BC0
	void set_screenPosition(Vector2 value) { }

	// RVA: 0x1411C04
	Vector3 get_worldPosition() { }

	// RVA: 0x1411C14
	void set_worldPosition(Vector3 value) { }

	// RVA: 0x1411C6C
	Quaternion get_worldOrientation() { }

	// RVA: 0x1411C80
	void set_worldOrientation(Quaternion value) { }

	// RVA: 0x1411CDC
	Vector2 get_scrollDelta() { }

	// RVA: 0x1411CE8
	void set_scrollDelta(Vector2 value) { }

	// RVA: 0x1411D2C
	float get_pressure() { }

	// RVA: 0x1411D34
	void set_pressure(float value) { }

	// RVA: 0x1411D54
	float get_azimuthAngle() { }

	// RVA: 0x1411D5C
	void set_azimuthAngle(float value) { }

	// RVA: 0x1411D7C
	float get_altitudeAngle() { }

	// RVA: 0x1411D84
	void set_altitudeAngle(float value) { }

	// RVA: 0x1411DA4
	float get_twist() { }

	// RVA: 0x1411DAC
	void set_twist(float value) { }

	// RVA: 0x1411DCC
	Vector2 get_radius() { }

	// RVA: 0x1411DD8
	void set_radius(Vector2 value) { }

	// RVA: 0x1411E1C
	void .ctor(ExtendedPointerEventData eventData) { }

	// RVA: 0x1411ED4
	void OnFrameFinished() { }

	// RVA: 0x1411F20
	void CopyTouchOrPenStateFrom(PointerEventData eventData) { }

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

	// RVA: 0x141355C
	void .ctor(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) { }

	// RVA: 0x14136E4
	Graphic get_graphic() { }

	// RVA: 0x14136EC
	Vector3 get_worldHitPosition() { }

	// RVA: 0x14136F8
	Vector2 get_screenPosition() { }

	// RVA: 0x1413700
	float get_distance() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> <>9__25_0; // 0x8

	// Methods

	// RVA: 0x1413708
	void .cctor() { }

	// RVA: 0x1413774
	void .ctor() { }

	// RVA: 0x141377C
	int <SortedRaycastGraphics>b__25_0(RaycastHitData g1, RaycastHitData g2) { }

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

	// RVA: 0x1412248
	Camera get_eventCamera() { }

	// RVA: 0x141240C
	LayerMask get_blockingMask() { }

	// RVA: 0x1412414
	void set_blockingMask(LayerMask value) { }

	// RVA: 0x141241C
	bool get_checkFor3DOcclusion() { }

	// RVA: 0x1412424
	void set_checkFor3DOcclusion(bool value) { }

	// RVA: 0x141242C
	bool get_checkFor2DOcclusion() { }

	// RVA: 0x1412434
	void set_checkFor2DOcclusion(bool value) { }

	// RVA: 0x141243C
	bool get_ignoreReversedGraphics() { }

	// RVA: 0x1412444
	void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x141244C
	float get_maxDistance() { }

	// RVA: 0x1412454
	void set_maxDistance(float value) { }

	// RVA: 0x141245C
	void OnEnable() { }

	// RVA: 0x14124EC
	void OnDisable() { }

	// RVA: 0x14125E4
	void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1412690
	void PerformRaycast(ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1412C54
	void SortedRaycastGraphics(Canvas canvas, Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results) { }

	// RVA: 0x1413164
	bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance) { }

	// RVA: 0x1412314
	Canvas get_canvas() { }

	// RVA: 0x14135BC
	void .ctor() { }

	// RVA: 0x1413650
	void .cctor() { }

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

	// RVA: 0x14137D8
	RectTransform get_cursorTransform() { }

	// RVA: 0x14137E0
	void set_cursorTransform(RectTransform value) { }

	// RVA: 0x14137E8
	float get_cursorSpeed() { }

	// RVA: 0x14137F0
	void set_cursorSpeed(float value) { }

	// RVA: 0x14137F8
	CursorMode get_cursorMode() { }

	// RVA: 0x1413800
	void set_cursorMode(CursorMode value) { }

	// RVA: 0x1413BE0
	Graphic get_cursorGraphic() { }

	// RVA: 0x1413BE8
	void set_cursorGraphic(Graphic value) { }

	// RVA: 0x1413CF0
	float get_scrollSpeed() { }

	// RVA: 0x1413CF8
	void set_scrollSpeed(float value) { }

	// RVA: 0x1413D00
	Mouse get_virtualMouse() { }

	// RVA: 0x1413D08
	InputActionProperty get_stickAction() { }

	// RVA: 0x1413D1C
	void set_stickAction(InputActionProperty value) { }

	// RVA: 0x1413EA8
	InputActionProperty get_leftButtonAction() { }

	// RVA: 0x1413EBC
	void set_leftButtonAction(InputActionProperty value) { }

	// RVA: 0x1414020
	InputActionProperty get_rightButtonAction() { }

	// RVA: 0x1414034
	void set_rightButtonAction(InputActionProperty value) { }

	// RVA: 0x1414114
	InputActionProperty get_middleButtonAction() { }

	// RVA: 0x1414128
	void set_middleButtonAction(InputActionProperty value) { }

	// RVA: 0x1414208
	InputActionProperty get_forwardButtonAction() { }

	// RVA: 0x141421C
	void set_forwardButtonAction(InputActionProperty value) { }

	// RVA: 0x14142FC
	InputActionProperty get_backButtonAction() { }

	// RVA: 0x1414310
	void set_backButtonAction(InputActionProperty value) { }

	// RVA: 0x14143F0
	InputActionProperty get_scrollWheelAction() { }

	// RVA: 0x1414404
	void set_scrollWheelAction(InputActionProperty value) { }

	// RVA: 0x1414438
	void OnEnable() { }

	// RVA: 0x14149C4
	void OnDisable() { }

	// RVA: 0x1413C78
	void TryFindCanvas() { }

	// RVA: 0x141391C
	void TryEnableHardwareCursor() { }

	// RVA: 0x1414CD0
	void UpdateMotion() { }

	// RVA: 0x141508C
	void OnButtonActionTriggered(CallbackContext context) { }

	// RVA: 0x1413F9C
	void SetActionCallback(InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install) { }

	// RVA: 0x1413D50
	void SetAction(ref InputActionProperty field, InputActionProperty value) { }

	// RVA: 0x1415304
	void OnAfterInputUpdate() { }

	// RVA: 0x1415308
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
public class OnScreenButton 
{
	// Fields
	private string m_ControlPath; // 0x38

	// Methods

	// RVA: 0x141531C
	void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1415384
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x14153F0
	string get_controlPathInternal() { }

	// RVA: 0x14153F8
	void set_controlPathInternal(string value) { }

	// RVA: 0x1415400
	void .ctor() { }

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

	// RVA: 0x1415D68
	OnScreenDeviceInfo AddControl(OnScreenControl control) { }

	// RVA: 0x1416154
	OnScreenDeviceInfo RemoveControl(OnScreenControl control) { }

	// RVA: 0x1415CAC
	void Destroy() { }

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

	// RVA: 0x1415410
	string get_controlPath() { }

	// RVA: 0x141541C
	void set_controlPath(string value) { }

	// RVA: 0x1415CA4
	InputControl get_control() { }

	// RVA: 0x2FE360C
	string get_controlPathInternal() { }

	// RVA: 0x2FE4574
	void set_controlPathInternal(string value) { }

	// RVA: 0x1415464
	void SetupInputControl() { }

	// RVA: 0x309AF8C
	void SendValueToControl(TValue value) { }

	// RVA: 0x1415DD0
	void SentDefaultValueToControl() { }

	// RVA: 0x1415F20
	void OnEnable() { }

	// RVA: 0x1415F24
	void OnDisable() { }

	// RVA: 0x1415408
	void .ctor() { }

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
	private const string kDynamicOriginClickable = 5714689952;
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

	// RVA: 0x14162B4
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1416610
	void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1416A90
	void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1416B88
	void Start() { }

	// RVA: 0x1416360
	void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x14166BC
	void MoveStick(Vector2 pointerPosition, Camera uiCamera) { }

	// RVA: 0x1416AA0
	void EndInteraction() { }

	// RVA: 0x1417228
	void OnPointerDown(CallbackContext ctx) { }

	// RVA: 0x1417914
	void OnPointerMove(CallbackContext ctx) { }

	// RVA: 0x1417A00
	void OnPointerUp(CallbackContext ctx) { }

	// RVA: 0x14175F4
	Camera GetCameraFromCanvas() { }

	// RVA: 0x1417A9C
	void OnDrawGizmosSelected() { }

	// RVA: 0x1417DB4
	void DrawGizmoCircle(Vector2 center, float radius) { }

	// RVA: 0x1417E7C
	void UpdateDynamicOriginClickableArea() { }

	// RVA: 0x1417F84
	float get_movementRange() { }

	// RVA: 0x1417F8C
	void set_movementRange(float value) { }

	// RVA: 0x1417F94
	float get_dynamicOriginRange() { }

	// RVA: 0x1417F9C
	void set_dynamicOriginRange(float value) { }

	// RVA: 0x1417FB4
	bool get_useIsolatedInputActions() { }

	// RVA: 0x1417FBC
	void set_useIsolatedInputActions(bool value) { }

	// RVA: 0x1417FC4
	string get_controlPathInternal() { }

	// RVA: 0x1417FCC
	void set_controlPathInternal(string value) { }

	// RVA: 0x1417FD4
	Behaviour get_behaviour() { }

	// RVA: 0x1417FDC
	void set_behaviour(Behaviour value) { }

	// RVA: 0x1417FE4
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.OnScreen
internal static class OnScreenSupport 
{
	// Methods

	// RVA: 0x1417FF8
	void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class PrivacyDataUsage 
{
	// Fields
	private bool m_Enabled; // 0x10
	private string m_Description; // 0x18

	// Methods

	// RVA: 0x1417FFC
	bool get_enabled() { }

	// RVA: 0x1418004
	void set_enabled(bool value) { }

	// RVA: 0x141800C
	string get_usageDescription() { }

	// RVA: 0x1418014
	void set_usageDescription(string value) { }

	// RVA: 0x141801C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class iOSGameController 
{
	// Methods

	// RVA: 0x1418024
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class XboxOneGampadiOS 
{
	// Methods

	// RVA: 0x141802C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualShock4GampadiOS 
{
	// Methods

	// RVA: 0x1418034
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
public class DualSenseGampadiOS 
{
	// Methods

	// RVA: 0x1418044
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.iOS
internal static class iOSSupport 
{
	// Methods

	// RVA: 0x141804C
	void Initialize() { }

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

	// RVA: 0x14185A4
	FourCC get_format() { }

	// RVA: 0x1418620
	iOSGameControllerState WithButton(iOSButton button, bool value, float rawValue) { }

	// RVA: 0x141866C
	iOSGameControllerState WithAxis(iOSAxis axis, float value) { }

	// RVA: 0x1418698
	void .cctor() { }

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

	// RVA: 0x1418710
	FourCC get_format() { }

	// RVA: 0x141878C
	void .cctor() { }

}

// Namespace: 
internal sealed class OnDataReceivedDelegate 
{
	// Methods

	// RVA: 0x1418DC0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1418EE8
	internal void Invoke(int deviceId, int numberOfSteps) { }

	// RVA: 0x1418EFC
	internal IAsyncResult BeginInvoke(int deviceId, int numberOfSteps, AsyncCallback callback, object object) { }

	// RVA: 0x1418FC8
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x1418908
	int _iOSStepCounterEnable(int deviceId, ref iOSStepCounterCallbacks callbacks, int sizeOfCallbacks) { }

	// RVA: 0x14189C4
	int _iOSStepCounterDisable(int deviceId) { }

	// RVA: 0x14189C8
	int _iOSStepCounterIsEnabled(int deviceId) { }

	// RVA: 0x14189CC
	int _iOSStepCounterIsAvailable() { }

	// RVA: 0x14189D0
	int _iOSStepCounterGetAuthorizationStatus() { }

	// RVA: 0x1418804
	void OnDataReceived(int deviceId, int numberOfSteps) { }

	// RVA: 0x14189D4
	Int64 ExecuteCommand(InputDeviceCommand* commandPtr) { }

	// RVA: 0x1418588
	bool IsAvailable() { }

	// RVA: 0x1418EDC
	MotionAuthorizationStatus get_AuthorizationStatus() { }

	// RVA: 0x1418EE0
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.HID.HID.HIDLayoutBuilder.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_0; // 0x8
	public static System.Predicate<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> <>9__4_1; // 0x10
	public static System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem,System.String> <>9__4_2; // 0x18

	// Methods

	// RVA: 0x141EA58
	void .cctor() { }

	// RVA: 0x141EAC4
	void .ctor() { }

	// RVA: 0x141EACC
	bool <Build>b__4_0(HIDElementDescriptor element) { }

	// RVA: 0x141EAF0
	bool <Build>b__4_1(HIDElementDescriptor element) { }

	// RVA: 0x141EB14
	string <Build>b__4_2(ControlItem x) { }

}

// Namespace: 
private class HIDLayoutBuilder 
{
	// Fields
	public string displayName; // 0x10
	public HIDDeviceDescriptor hidDescriptor; // 0x18
	public string parentLayout; // 0x48
	public Type deviceType; // 0x50

	// Methods

	// RVA: 0x141CB44
	InputControlLayout Build() { }

	// RVA: 0x141A3B0
	void .ctor() { }

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

	// RVA: 0x141EB20
	bool get_hasNullState() { }

	// RVA: 0x141EB2C
	bool get_hasPreferredState() { }

	// RVA: 0x141EB3C
	bool get_isArray() { }

	// RVA: 0x141EB4C
	bool get_isNonLinear() { }

	// RVA: 0x141EB58
	bool get_isRelative() { }

	// RVA: 0x141EB64
	bool get_isConstant() { }

	// RVA: 0x141EB70
	bool get_isWrapping() { }

	// RVA: 0x141D9F8
	bool get_isSigned() { }

	// RVA: 0x141EB7C
	float get_minFloatValue() { }

	// RVA: 0x141EC14
	float get_maxFloatValue() { }

	// RVA: 0x141DB58
	bool Is(UsagePage usagePage, int usage) { }

	// RVA: 0x141DC9C
	string DetermineName() { }

	// RVA: 0x141DED4
	string DetermineDisplayName() { }

	// RVA: 0x141A370
	bool IsUsableElement() { }

	// RVA: 0x141DB7C
	string DetermineLayout() { }

	// RVA: 0x141DFF4
	FourCC DetermineFormat() { }

	// RVA: 0x141E1F0
	InternedString[] DetermineUsages() { }

	// RVA: 0x141D89C
	string DetermineParameters() { }

	// RVA: 0x141ECB4
	string DetermineAxisNormalizationParameters() { }

	// RVA: 0x141DADC
	string DetermineProcessors() { }

	// RVA: 0x141DA04
	PrimitiveValue DetermineDefaultState() { }

	// RVA: 0x141E3E8
	void AddChildControls(ref HIDElementDescriptor element, string controlName, ref Builder builder) { }

}

// Namespace: 
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

	// RVA: 0x141C970
	string ToJson() { }

	// RVA: 0x141A3B8
	HIDDeviceDescriptor FromJson(string json) { }

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

	// RVA: 0x141EF88
	void .ctor(UsagePage usagePage, int usage) { }

	// RVA: 0x141EFA0
	void .ctor(GenericDesktop usage) { }

	// RVA: 0x141EFBC
	HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId) { }

	// RVA: 0x141EFE4
	HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) { }

	// RVA: 0x141F39C
	HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) { }

	// RVA: 0x141F3F0
	HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) { }

	// RVA: 0x141F560
	HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) { }

	// RVA: 0x141F6BC
	HIDDeviceDescriptor Finish() { }

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

	// RVA: 0x1419AA4
	void .ctor() { }

	// RVA: 0x141F7B8
	InputControlLayout <OnFindLayoutForDevice>b__0() { }

}

// Namespace: UnityEngine.InputSystem.HID
public class HID 
{
	// Fields
	internal const string kHIDInterface = 5736731008;
	internal const string kHIDNamespace = 5736730960;
	private bool m_HaveParsedHIDDescriptor; // 0x170
	private HIDDeviceDescriptor m_HIDDescriptor; // 0x178

	// Methods

	// RVA: 0x1418FD4
	FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	// RVA: 0x1419010
	FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	// RVA: 0x141904C
	FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	// RVA: 0x1419088
	HIDDeviceDescriptor get_hidDescriptor() { }

	// RVA: 0x1419144
	string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x1419AAC
	HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	// RVA: 0x141C9EC
	string UsagePageToString(UsagePage usagePage) { }

	// RVA: 0x141CA88
	string UsageToString(UsagePage usagePage, int usage) { }

	// RVA: 0x141CB3C
	void .ctor() { }

}

// Namespace: 
private struct HIDReportData 
{
	// Fields
	public int reportId; // 0x10
	public HIDReportType reportType; // 0x14
	public int currentBitOffset; // 0x18

	// Methods

	// RVA: 0x141FDDC
	int FindOrAddReport(System.Nullable<System.Int32> reportId, HIDReportType reportType, System.Collections.Generic.List<UnityEngine.InputSystem.HID.HIDParser.HIDReportData> reports) { }

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

	// RVA: 0x141FD0C
	void Reset(ref HIDItemStateLocal state) { }

	// RVA: 0x141F8B4
	void SetUsage(int value) { }

	// RVA: 0x141FB18
	int GetUsage(int index) { }

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

	// RVA: 0x141FA30
	UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState) { }

	// RVA: 0x141FF74
	int GetPhysicalMin() { }

	// RVA: 0x14200D4
	int GetPhysicalMax() { }

}

// Namespace: UnityEngine.InputSystem.HID
internal static class HIDParser 
{
	// Methods

	// RVA: 0x141F7D4
	bool ParseReportDescriptor(Byte[] buffer, ref HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x141B2A4
	bool ParseReportDescriptor(Byte* bufferPtr, int bufferLength, ref HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x141F84C
	int ReadData(int itemSize, Byte* currentPtr, Byte* endPtr) { }

}

// Namespace: 
public struct HIDPageUsage 
{
	// Fields
	public UsagePage page; // 0x10
	public int usage; // 0x14

	// Methods

	// RVA: 0x141A368
	void .ctor(UsagePage page, int usage) { }

	// RVA: 0x14206B8
	void .ctor(GenericDesktop usage) { }

}

// Namespace: UnityEngine.InputSystem.HID
public static class HIDSupport 
{
	// Fields
	private static HIDPageUsage[] s_SupportedHIDUsages; // 0x0

	// Methods

	// RVA: 0x141A2FC
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages() { }

	// RVA: 0x1420234
	void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value) { }

	// RVA: 0x1420554
	void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public static class EnhancedTouchSupport 
{
	// Fields
	private static int s_Enabled; // 0x0
	private static UpdateMode s_UpdateMode; // 0x4

	// Methods

	// RVA: 0x14206C4
	bool get_enabled() { }

	// RVA: 0x1420718
	void Enable() { }

	// RVA: 0x1420A90
	void Disable() { }

	// RVA: 0x1420E7C
	void Reset() { }

	// RVA: 0x1420898
	void SetUpState() { }

	// RVA: 0x1420C44
	void TearDownState() { }

	// RVA: 0x1420FB0
	void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x14212E0
	void OnSettingsChange() { }

	// RVA: 0x1421394
	void CheckEnabled() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public class Finger 
{
	// Fields
	private readonly Touchscreen <screen>k__BackingField; // 0x10
	private readonly int <index>k__BackingField; // 0x18
	internal readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory; // 0x20

	// Methods

	// RVA: 0x1421430
	Touchscreen get_screen() { }

	// RVA: 0x1421438
	int get_index() { }

	// RVA: 0x1421440
	bool get_isActive() { }

	// RVA: 0x1421814
	Vector2 get_screenPosition() { }

	// RVA: 0x1421A34
	Touch get_lastTouch() { }

	// RVA: 0x1421508
	Touch get_currentTouch() { }

	// RVA: 0x1421DBC
	TouchHistory get_touchHistory() { }

	// RVA: 0x1421EC8
	void .ctor(Touchscreen screen, int index, InputUpdateType updateMask) { }

	// RVA: 0x1422304
	bool ShouldRecordTouch(InputControl control, Double time, InputEventPtr eventPtr) { }

	// RVA: 0x14223E0
	void OnTouchRecorded(Record record) { }

	// RVA: 0x14226A8
	Touch FindTouch(UInt32 uniqueId) { }

	// RVA: 0x14229EC
	TouchHistory GetTouchHistory(Touch touch) { }

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

	// RVA: 0x14255B4
	void AddFingers(Touchscreen screen) { }

	// RVA: 0x14256CC
	void RemoveFingers(Touchscreen screen) { }

	// RVA: 0x1420F20
	void Destroy() { }

	// RVA: 0x1424720
	void UpdateActiveFingers() { }

	// RVA: 0x1423E98
	void UpdateActiveTouches() { }

}

// Namespace: 
internal struct ExtraDataPerTouchState 
{
	// Fields
	public Vector2 accumulatedDelta; // 0x10
	public UInt32 uniqueId; // 0x18
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.EnhancedTouch.Touch.<>c <>9; // 0x0
	public static TypedRestore <>9__80_0; // 0x8
	public static Action <>9__80_1; // 0x10

	// Methods

	// RVA: 0x1425C84
	void .cctor() { }

	// RVA: 0x1425CF0
	void .ctor() { }

	// RVA: 0x1425CF8
	void <SaveAndResetState>b__80_0(ref GlobalState state) { }

	// RVA: 0x1425D90
	void <SaveAndResetState>b__80_1() { }

}

// Namespace: UnityEngine.InputSystem.EnhancedTouch
public struct Touch 
{
	// Fields
	private readonly Finger m_Finger; // 0x10
	internal Record m_TouchRecord; // 0x18
	internal static GlobalState s_GlobalState; // 0x0

	// Methods

	// RVA: 0x14217C0
	bool get_valid() { }

	// RVA: 0x1423014
	Finger get_finger() { }

	// RVA: 0x1422F5C
	TouchPhase get_phase() { }

	// RVA: 0x1423070
	bool get_began() { }

	// RVA: 0x1423178
	bool get_inProgress() { }

	// RVA: 0x14233F0
	bool get_ended() { }

	// RVA: 0x1422EA4
	int get_touchId() { }

	// RVA: 0x14235AC
	float get_pressure() { }

	// RVA: 0x1423664
	Vector2 get_radius() { }

	// RVA: 0x142371C
	Double get_startTime() { }

	// RVA: 0x14237D4
	Double get_time() { }

	// RVA: 0x1423828
	Touchscreen get_screen() { }

	// RVA: 0x1421AFC
	Vector2 get_screenPosition() { }

	// RVA: 0x14238A8
	Vector2 get_startScreenPosition() { }

	// RVA: 0x1423960
	Vector2 get_delta() { }

	// RVA: 0x1423A18
	int get_tapCount() { }

	// RVA: 0x1423AD0
	bool get_isTap() { }

	// RVA: 0x1423B88
	int get_displayIndex() { }

	// RVA: 0x1421BF4
	bool get_isInProgress() { }

	// RVA: 0x1421D04
	UInt32 get_updateStepCount() { }

	// RVA: 0x1422DEC
	UInt32 get_uniqueId() { }

	// RVA: 0x142301C
	ref TouchState get_state() { }

	// RVA: 0x1423C40
	ref ExtraDataPerTouchState get_extraData() { }

	// RVA: 0x1423C94
	TouchHistory get_history() { }

	// RVA: 0x1423DF4
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches() { }

	// RVA: 0x14245E8
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers() { }

	// RVA: 0x142467C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers() { }

	// RVA: 0x14248A0
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens() { }

	// RVA: 0x1424938
	void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1424A08
	void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1424AD8
	void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1424BA8
	void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1424C78
	void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1424D48
	void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }

	// RVA: 0x1422288
	int get_maxHistoryLengthPerFinger() { }

	// RVA: 0x1421BB4
	void .ctor(Finger finger, Record touchRecord) { }

	// RVA: 0x1424E18
	string ToString() { }

	// RVA: 0x14253A4
	bool Equals(Touch other) { }

	// RVA: 0x1425424
	bool Equals(object obj) { }

	// RVA: 0x1425534
	int GetHashCode() { }

	// RVA: 0x1421164
	void AddTouchscreen(Touchscreen screen) { }

	// RVA: 0x14211FC
	void RemoveTouchscreen(Touchscreen screen) { }

	// RVA: 0x142580C
	void BeginUpdate() { }

	// RVA: 0x14258B8
	GlobalState CreateGlobalState() { }

	// RVA: 0x1425918
	ISavedState SaveAndResetState() { }

	// RVA: 0x1425BD0
	void .cctor() { }

}

// Namespace: 
private class Enumerator 
{
	// Fields
	private readonly TouchHistory m_Owner; // 0x10
	private int m_Index; // 0x30

	// Methods

	// RVA: 0x1425E24
	void .ctor(TouchHistory owner) { }

	// RVA: 0x1426118
	bool MoveNext() { }

	// RVA: 0x1426140
	void Reset() { }

	// RVA: 0x142614C
	Touch get_Current() { }

	// RVA: 0x1426198
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1426220
	void Dispose() { }

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

	// RVA: 0x1421E28
	void .ctor(Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, int startIndex, int count) { }

	// RVA: 0x1425D94
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator() { }

	// RVA: 0x1425E68
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1425EF8
	int get_Count() { }

	// RVA: 0x1425F00
	Touch get_Item(int index) { }

	// RVA: 0x1426078
	void CheckValid() { }

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

	// RVA: 0x1426224
	Touchscreen get_simulatedTouchscreen() { }

	// RVA: 0x142622C
	void set_simulatedTouchscreen(Touchscreen value) { }

	// RVA: 0x1426234
	TouchSimulation get_instance() { }

	// RVA: 0x1426280
	void Enable() { }

	// RVA: 0x1426478
	void Disable() { }

	// RVA: 0x1426574
	void Destroy() { }

	// RVA: 0x142667C
	void AddPointer(Pointer pointer) { }

	// RVA: 0x14267F0
	void RemovePointer(Pointer pointer) { }

	// RVA: 0x1426E08
	void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x1427430
	void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x1427580
	void OnEnable() { }

	// RVA: 0x1427AA0
	void OnDisable() { }

	// RVA: 0x14269E4
	void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr) { }

	// RVA: 0x1427C14
	void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x1427C18
	void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1427C1C
	void InstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x1427C20
	void OnSourceControlChangedValue(InputControl control, Double time, InputEventPtr eventPtr, Int64 sourceDeviceAndButtonIndex) { }

	// RVA: 0x1427C24
	void UninstallStateChangeMonitors(int startIndex) { }

	// RVA: 0x1427C28
	void .ctor() { }

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

	// RVA: 0x1427C38
	ButtonControl get_touchpadButton() { }

	// RVA: 0x1427C40
	void set_touchpadButton(ButtonControl value) { }

	// RVA: 0x1427C50
	ButtonControl get_optionsButton() { }

	// RVA: 0x1427C58
	void set_optionsButton(ButtonControl value) { }

	// RVA: 0x1427C68
	ButtonControl get_shareButton() { }

	// RVA: 0x1427C70
	void set_shareButton(ButtonControl value) { }

	// RVA: 0x1427C80
	ButtonControl get_L1() { }

	// RVA: 0x1427C88
	void set_L1(ButtonControl value) { }

	// RVA: 0x1427C98
	ButtonControl get_R1() { }

	// RVA: 0x1427CA0
	void set_R1(ButtonControl value) { }

	// RVA: 0x1427CB0
	ButtonControl get_L2() { }

	// RVA: 0x1427CB8
	void set_L2(ButtonControl value) { }

	// RVA: 0x1427CC8
	ButtonControl get_R2() { }

	// RVA: 0x1427CD0
	void set_R2(ButtonControl value) { }

	// RVA: 0x1427CE0
	ButtonControl get_L3() { }

	// RVA: 0x1427CE8
	void set_L3(ButtonControl value) { }

	// RVA: 0x1427CF8
	ButtonControl get_R3() { }

	// RVA: 0x1427D00
	void set_R3(ButtonControl value) { }

	// RVA: 0x1427D10
	DualShockGamepad get_current() { }

	// RVA: 0x1427D5C
	void set_current(DualShockGamepad value) { }

	// RVA: 0x1427DC0
	void MakeCurrent() { }

	// RVA: 0x1427E24
	void OnRemoved() { }

	// RVA: 0x1427EC4
	void FinishSetup() { }

	// RVA: 0x1427FCC
	void SetLightBarColor(Color color) { }

	// RVA: 0x141803C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
internal static class DualShockSupport 
{
	// Methods

	// RVA: 0x1427FD0
	void Initialize() { }

}

// Namespace: UnityEngine.InputSystem.DualShock
public interface IDualShockHaptics 
{
	// Methods

	// RVA: -1
	void SetLightBarColor(Color color) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
internal struct DualMotorRumble 
{
	// Fields
	private float <lowFrequencyMotorSpeed>k__BackingField; // 0x10
	private float <highFrequencyMotorSpeed>k__BackingField; // 0x14

	// Methods

	// RVA: 0x1428044
	float get_lowFrequencyMotorSpeed() { }

	// RVA: 0x142804C
	void set_lowFrequencyMotorSpeed(float value) { }

	// RVA: 0x1428054
	float get_highFrequencyMotorSpeed() { }

	// RVA: 0x142805C
	void set_highFrequencyMotorSpeed(float value) { }

	// RVA: 0x1428064
	bool get_isRumbling() { }

	// RVA: 0x142814C
	void PauseHaptics(InputDevice device) { }

	// RVA: 0x14282F8
	void ResumeHaptics(InputDevice device) { }

	// RVA: 0x142856C
	void ResetHaptics(InputDevice device) { }

	// RVA: 0x1428444
	void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
public interface IDualMotorRumble 
{
	// Methods

	// RVA: -1
	void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

}

// Namespace: UnityEngine.InputSystem.Haptics
public interface IHaptics 
{
	// Methods

	// RVA: 0x2FE41A8
	void PauseHaptics() { }

	// RVA: 0x2FE41A8
	void ResumeHaptics() { }

	// RVA: 0x2FE41A8
	void ResetHaptics() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DisableDeviceCommand 
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1418E64
	FourCC get_Type() { }

	// RVA: 0x14286BC
	FourCC get_typeStatic() { }

	// RVA: 0x14286F8
	DisableDeviceCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct EnableDeviceCommand 
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1418D84
	FourCC get_Type() { }

	// RVA: 0x1428738
	FourCC get_typeStatic() { }

	// RVA: 0x1428774
	EnableDeviceCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct EnableIMECompositionCommand 
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x10
	private Byte m_ImeEnabled; // 0x18

	// Methods

	// RVA: 0x14287B4
	FourCC get_Type() { }

	// RVA: 0x14287F0
	bool get_imeEnabled() { }

	// RVA: 0x1428800
	FourCC get_typeStatic() { }

	// RVA: 0x142883C
	EnableIMECompositionCommand Create(bool enabled) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputDeviceCommandInfo 
{
	// Methods

	// RVA: -1
	FourCC get_typeStatic() { }

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

	// RVA: 0x1428898
	FourCC get_Type() { }

	// RVA: 0x14288D4
	FourCC get_typeStatic() { }

	// RVA: 0x1428910
	InitiateUserAccountPairingCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceCommandDelegate 
{
	// Methods

	// RVA: 0x1428950
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1428A74
	internal System.Nullable<System.Int64> Invoke(InputDevice device, InputDeviceCommand* command) { }

	// RVA: 0x1428A88
	internal IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	// RVA: 0x1428AE4
	internal System.Nullable<System.Int64> EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public sealed class InputDeviceExecuteCommandDelegate 
{
	// Methods

	// RVA: 0x1428B14
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1428BC8
	internal Int64 Invoke(ref InputDeviceCommand command) { }

	// RVA: 0x1428BDC
	internal IAsyncResult BeginInvoke(ref InputDeviceCommand command, AsyncCallback callback, object object) { }

	// RVA: 0x1428C98
	internal Int64 EndInvoke(ref InputDeviceCommand command, IAsyncResult result) { }

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

	// RVA: 0x1428CFC
	int get_payloadSizeInBytes() { }

	// RVA: 0x141B29C
	Void* get_payloadPtr() { }

	// RVA: 0x141B1D8
	void .ctor(FourCC type, int sizeInBytes) { }

	// RVA: 0x141B1E0
	Unity.Collections.NativeArray<System.Byte> AllocateNative(FourCC type, int payloadSize) { }

	// RVA: 0x1428D08
	FourCC get_typeStatic() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryCanRunInBackground 
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x10
	public bool canRunInBackground; // 0x18

	// Methods

	// RVA: 0x1418EA0
	FourCC get_Type() { }

	// RVA: 0x1428D10
	FourCC get_typeStatic() { }

	// RVA: 0x1428D4C
	QueryCanRunInBackground Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryDimensionsCommand 
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	public Vector2 outDimensions; // 0x18

	// Methods

	// RVA: 0x1428D94
	FourCC get_Type() { }

	// RVA: 0x1428DD0
	FourCC get_typeStatic() { }

	// RVA: 0x1428E0C
	QueryDimensionsCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct QueryEnabledStateCommand 
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x10
	public bool isEnabled; // 0x18

	// Methods

	// RVA: 0x1418D48
	FourCC get_Type() { }

	// RVA: 0x1428E50
	FourCC get_typeStatic() { }

	// RVA: 0x1428E8C
	QueryEnabledStateCommand Create() { }

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

	// RVA: 0x1428ED4
	FourCC get_Type() { }

	// RVA: 0x1428F10
	string ReadLayoutName() { }

	// RVA: 0x1428F20
	void WriteLayoutName(string name) { }

	// RVA: 0x1428F48
	FourCC get_typeStatic() { }

	// RVA: 0x1428F84
	QueryKeyboardLayoutCommand Create() { }

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

	// RVA: 0x142901C
	FourCC get_Type() { }

	// RVA: 0x1429058
	string ReadKeyName() { }

	// RVA: 0x1429068
	FourCC get_typeStatic() { }

	// RVA: 0x14290A4
	QueryKeyNameCommand Create(Key key) { }

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

	// RVA: 0x1429144
	FourCC get_Type() { }

	// RVA: 0x1429180
	string get_id() { }

	// RVA: 0x1429190
	void set_id(string value) { }

	// RVA: 0x14292AC
	string get_name() { }

	// RVA: 0x14292BC
	void set_name(string value) { }

	// RVA: 0x14293D8
	FourCC get_typeStatic() { }

	// RVA: 0x1429414
	QueryPairedUserAccountCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct QuerySamplingFrequencyCommand 
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x10
	public float frequency; // 0x18

	// Methods

	// RVA: 0x1429474
	FourCC get_Type() { }

	// RVA: 0x14294B0
	FourCC get_typeStatic() { }

	// RVA: 0x14294EC
	QuerySamplingFrequencyCommand Create() { }

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

	// RVA: 0x1429544
	FourCC get_Type() { }

	// RVA: 0x1429580
	string ReadId() { }

	// RVA: 0x1429590
	FourCC get_typeStatic() { }

	// RVA: 0x14295CC
	QueryUserIdCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestResetCommand 
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1429694
	FourCC get_Type() { }

	// RVA: 0x14296D0
	FourCC get_typeStatic() { }

	// RVA: 0x142970C
	RequestResetCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct RequestSyncCommand 
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x10

	// Methods

	// RVA: 0x1429760
	FourCC get_Type() { }

	// RVA: 0x142979C
	FourCC get_typeStatic() { }

	// RVA: 0x14297D8
	RequestSyncCommand Create() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct SetIMECursorPositionCommand 
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	private Vector2 m_Position; // 0x18

	// Methods

	// RVA: 0x142982C
	FourCC get_Type() { }

	// RVA: 0x1429868
	Vector2 get_position() { }

	// RVA: 0x1429870
	FourCC get_typeStatic() { }

	// RVA: 0x14298AC
	SetIMECursorPositionCommand Create(Vector2 cursorPosition) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct SetSamplingFrequencyCommand 
{
	// Fields
	internal const int kSize = 12;
	public InputDeviceCommand baseCommand; // 0x10
	public float frequency; // 0x18

	// Methods

	// RVA: 0x142991C
	FourCC get_Type() { }

	// RVA: 0x1429958
	FourCC get_typeStatic() { }

	// RVA: 0x1429994
	SetSamplingFrequencyCommand Create(float frequency) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct UseWindowsGamingInputCommand 
{
	// Fields
	internal const int kSize = 9;
	public InputDeviceCommand baseCommand; // 0x10
	public Byte enable; // 0x18

	// Methods

	// RVA: 0x14299F8
	FourCC get_Type() { }

	// RVA: 0x1429A34
	FourCC get_typeStatic() { }

	// RVA: 0x1429A70
	UseWindowsGamingInputCommand Create(bool enable) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct WarpMousePositionCommand 
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x10
	public Vector2 warpPositionInPlayerDisplaySpace; // 0x18

	// Methods

	// RVA: 0x1429AD4
	FourCC get_Type() { }

	// RVA: 0x1429B10
	FourCC get_typeStatic() { }

	// RVA: 0x1429B4C
	WarpMousePositionCommand Create(Vector2 position) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct GamepadState 
{
	// Fields
	internal const string ButtonSouthShortDisplayName = 5736712480;
	internal const string ButtonNorthShortDisplayName = 5736712448;
	internal const string ButtonWestShortDisplayName = 5736712416;
	internal const string ButtonEastShortDisplayName = 5736712384;
	public UInt32 buttons; // 0x10
	public Vector2 leftStick; // 0x14
	public Vector2 rightStick; // 0x1C
	public float leftTrigger; // 0x24
	public float rightTrigger; // 0x28

	// Methods

	// RVA: 0x1429BBC
	FourCC get_Format() { }

	// RVA: 0x1429BF8
	FourCC get_format() { }

	// RVA: 0x1429C34
	void .ctor(GamepadButton[] buttons) { }

	// RVA: 0x1429CE0
	GamepadState WithButton(GamepadButton button, bool value) { }

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

	// RVA: 0x1429D14
	FourCC get_Type() { }

	// RVA: 0x1429D50
	FourCC get_typeStatic() { }

	// RVA: 0x1429D8C
	DualMotorRumbleCommand Create(float lowFrequency, float highFrequency) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface ICustomDeviceReset 
{
	// Methods

	// RVA: 0x2FE41A8
	void Reset() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface IEventMerger 
{
	// Methods

	// RVA: -1
	bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface IEventPreProcessor 
{
	// Methods

	// RVA: -1
	bool PreProcessEvent(InputEventPtr currentEventPtr) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputUpdateCallbackReceiver 
{
	// Methods

	// RVA: 0x2FE41A8
	void OnUpdate() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface ITextInputReceiver 
{
	// Methods

	// RVA: -1
	void OnTextInput(Char character) { }

	// RVA: -1
	void OnIMECompositionChanged(IMECompositionString compositionString) { }

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

	// RVA: 0x1429DFC
	FourCC get_kFormat() { }

	// RVA: 0x1429E38
	FourCC get_format() { }

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

	// RVA: 0x1429E74
	FourCC get_Format() { }

	// RVA: 0x1429EB0
	void .ctor(Key[] pressedKeys) { }

	// RVA: 0x1429F68
	void Set(Key key, bool state) { }

	// RVA: 0x1429F70
	void Press(Key key) { }

	// RVA: 0x1429F7C
	void Release(Key key) { }

	// RVA: 0x1429F88
	FourCC get_format() { }

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

	// RVA: 0x1429FC4
	FourCC get_Format() { }

	// RVA: 0x142A000
	MouseState WithButton(MouseButton button, bool state) { }

	// RVA: 0x142A034
	FourCC get_format() { }

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

	// RVA: 0x142A070
	FourCC get_Format() { }

	// RVA: 0x142A0AC
	PenState WithButton(PenButton button, bool state) { }

	// RVA: 0x142A0E0
	FourCC get_format() { }

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

	// RVA: 0x142A11C
	FourCC get_kFormat() { }

	// RVA: 0x142A158
	FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AccelerometerState 
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x142A194
	FourCC get_kFormat() { }

	// RVA: 0x142A1D0
	FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GyroscopeState 
{
	// Fields
	public Vector3 angularVelocity; // 0x10

	// Methods

	// RVA: 0x142A20C
	FourCC get_kFormat() { }

	// RVA: 0x142A248
	FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct GravityState 
{
	// Fields
	public Vector3 gravity; // 0x10

	// Methods

	// RVA: 0x142A284
	FourCC get_kFormat() { }

	// RVA: 0x142A2C0
	FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct AttitudeState 
{
	// Fields
	public Quaternion attitude; // 0x10

	// Methods

	// RVA: 0x142A2FC
	FourCC get_kFormat() { }

	// RVA: 0x142A338
	FourCC get_format() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal struct LinearAccelerationState 
{
	// Fields
	public Vector3 acceleration; // 0x10

	// Methods

	// RVA: 0x142A374
	FourCC get_kFormat() { }

	// RVA: 0x142A3B0
	FourCC get_format() { }

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

	// RVA: 0x142A3EC
	FourCC get_Format() { }

	// RVA: 0x142A428
	TouchPhase get_phase() { }

	// RVA: 0x142A430
	void set_phase(TouchPhase value) { }

	// RVA: 0x142A438
	bool get_isNoneEndedOrCanceled() { }

	// RVA: 0x142A454
	bool get_isInProgress() { }

	// RVA: 0x142A470
	bool get_isPrimaryTouch() { }

	// RVA: 0x142A47C
	void set_isPrimaryTouch(bool value) { }

	// RVA: 0x142A49C
	bool get_isOrphanedPrimaryTouch() { }

	// RVA: 0x142A4A8
	void set_isOrphanedPrimaryTouch(bool value) { }

	// RVA: 0x142A4C8
	bool get_isIndirectTouch() { }

	// RVA: 0x142A4D4
	void set_isIndirectTouch(bool value) { }

	// RVA: 0x142A4E8
	bool get_isTap() { }

	// RVA: 0x142A500
	void set_isTap(bool value) { }

	// RVA: 0x142A4F4
	bool get_isTapPress() { }

	// RVA: 0x142A520
	void set_isTapPress(bool value) { }

	// RVA: 0x142A540
	bool get_isTapRelease() { }

	// RVA: 0x142A54C
	void set_isTapRelease(bool value) { }

	// RVA: 0x142A56C
	bool get_beganInSameFrame() { }

	// RVA: 0x142A578
	void set_beganInSameFrame(bool value) { }

	// RVA: 0x142A594
	FourCC get_format() { }

	// RVA: 0x142A5D0
	string ToString() { }

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

	// RVA: 0x142A8F0
	FourCC get_Format() { }

	// RVA: 0x142A92C
	TouchState* get_primaryTouch() { }

	// RVA: 0x142A930
	TouchState* get_touches() { }

	// RVA: 0x142A938
	FourCC get_format() { }

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

	// RVA: 0x142A974
	FourCC get_Type() { }

	// RVA: 0x142A9B0
	Double get_startTime() { }

	// RVA: 0x142A9B8
	void set_startTime(Double value) { }

	// RVA: 0x142A9C0
	InputActionPhase get_phase() { }

	// RVA: 0x142A9C8
	void set_phase(InputActionPhase value) { }

	// RVA: 0x142A9D0
	Byte* get_valueData() { }

	// RVA: 0x142A9D8
	int get_valueSizeInBytes() { }

	// RVA: 0x142A9EC
	int get_stateIndex() { }

	// RVA: 0x142A9F4
	void set_stateIndex(int value) { }

	// RVA: 0x142AA60
	int get_controlIndex() { }

	// RVA: 0x142AA68
	void set_controlIndex(int value) { }

	// RVA: 0x142AAD4
	int get_bindingIndex() { }

	// RVA: 0x142AADC
	void set_bindingIndex(int value) { }

	// RVA: 0x142AB48
	int get_interactionIndex() { }

	// RVA: 0x142AB5C
	void set_interactionIndex(int value) { }

	// RVA: 0x142ABD8
	InputEventPtr ToEventPtr() { }

	// RVA: 0x142ABDC
	FourCC get_typeStatic() { }

	// RVA: 0x142AC18
	int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	// RVA: 0x142AC20
	ActionEvent* From(InputEventPtr ptr) { }

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

	// RVA: 0x142AD7C
	UInt32 get_deltaStateSizeInBytes() { }

	// RVA: 0x142AD88
	Void* get_deltaState() { }

	// RVA: 0x142AD90
	FourCC get_typeStatic() { }

	// RVA: 0x142AD9C
	InputEventPtr ToEventPtr() { }

	// RVA: 0x142ADA0
	DeltaStateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x142AED4
	DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x142AED8
	Unity.Collections.NativeArray<System.Byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceConfigurationEvent 
{
	// Fields
	public const int Type = 1145259591;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x142B478
	FourCC get_typeStatic() { }

	// RVA: 0x142B484
	InputEventPtr ToEventPtr() { }

	// RVA: 0x142B488
	DeviceConfigurationEvent Create(int deviceId, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceRemoveEvent 
{
	// Fields
	public const int Type = 1146242381;
	public InputEvent baseEvent; // 0x10

	// Methods

	// RVA: 0x142B594
	FourCC get_typeStatic() { }

	// RVA: 0x142B5A0
	InputEventPtr ToEventPtr() { }

	// RVA: 0x142B5A4
	DeviceRemoveEvent Create(int deviceId, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct DeviceResetEvent 
{
	// Fields
	public const int Type = 1146245972;
	public InputEvent baseEvent; // 0x10
	public bool hardReset; // 0x18

	// Methods

	// RVA: 0x142B6B0
	FourCC get_typeStatic() { }

	// RVA: 0x142B6BC
	DeviceResetEvent Create(int deviceId, bool hardReset, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputEventTypeInfo 
{
	// Methods

	// RVA: -1
	FourCC get_typeStatic() { }

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

	// RVA: 0x142B7E4
	FourCC get_typeStatic() { }

	// RVA: 0x142B7F0
	IMECompositionEvent Create(int deviceId, string compositionString, Double time) { }

}

// Namespace: 
internal struct Enumerator 
{
	// Fields
	private IMECompositionString m_CompositionString; // 0x10
	private Char m_CurrentCharacter; // 0x94
	private int m_CurrentIndex; // 0x98

	// Methods

	// RVA: 0x142BBCC
	void .ctor(IMECompositionString compositionString) { }

	// RVA: 0x142BCB8
	bool MoveNext() { }

	// RVA: 0x142BCE8
	void Reset() { }

	// RVA: 0x142BCF4
	void Dispose() { }

	// RVA: 0x142BCF8
	Char get_Current() { }

	// RVA: 0x142BD00
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x142BA78
	int get_Count() { }

	// RVA: 0x142BA80
	Char get_Item(int index) { }

	// RVA: 0x142B9E8
	void .ctor(string characters) { }

	// RVA: 0x142BAF8
	string ToString() { }

	// RVA: 0x142BB10
	System.Collections.Generic.IEnumerator<System.Char> GetEnumerator() { }

	// RVA: 0x142BBFC
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x142BD68
	FourCC get_type() { }

	// RVA: 0x142BD70
	void set_type(FourCC value) { }

	// RVA: 0x142A9E4
	UInt32 get_sizeInBytes() { }

	// RVA: 0x142BD78
	void set_sizeInBytes(UInt32 value) { }

	// RVA: 0x142BE24
	int get_eventId() { }

	// RVA: 0x142BE30
	void set_eventId(int value) { }

	// RVA: 0x142BE44
	int get_deviceId() { }

	// RVA: 0x142BE4C
	void set_deviceId(int value) { }

	// RVA: 0x142BE54
	Double get_time() { }

	// RVA: 0x142BEB4
	void set_time(Double value) { }

	// RVA: 0x142BF20
	Double get_internalTime() { }

	// RVA: 0x142BF28
	void set_internalTime(Double value) { }

	// RVA: 0x142B368
	void .ctor(FourCC type, int sizeInBytes, int deviceId, Double time) { }

	// RVA: 0x142BF30
	bool get_handled() { }

	// RVA: 0x142BF3C
	void set_handled(bool value) { }

	// RVA: 0x142BF58
	string ToString() { }

	// RVA: 0x142C204
	InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	// RVA: 0x142C220
	InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer) { }

	// RVA: 0x142C3F8
	bool Equals(InputEvent* first, InputEvent* second) { }

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

	// RVA: 0x142CD28
	void .ctor(InputEventBuffer buffer) { }

	// RVA: 0x142D004
	bool MoveNext() { }

	// RVA: 0x142D074
	void Reset() { }

	// RVA: 0x142D080
	void Dispose() { }

	// RVA: 0x142D084
	InputEventPtr get_Current() { }

	// RVA: 0x142D08C
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x142C45C
	int get_eventCount() { }

	// RVA: 0x142C464
	Int64 get_sizeInBytes() { }

	// RVA: 0x142C46C
	Int64 get_capacityInBytes() { }

	// RVA: 0x142C4C4
	Unity.Collections.NativeArray<System.Byte> get_data() { }

	// RVA: 0x142C4D0
	InputEventPtr get_bufferPtr() { }

	// RVA: 0x142C528
	void .ctor(InputEvent* eventPtr, int eventCount, int sizeInBytes, int capacityInBytes) { }

	// RVA: 0x142C6EC
	void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, int eventCount, int sizeInBytes, bool transferNativeArrayOwnership) { }

	// RVA: 0x142C828
	void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x142C8A8
	InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes, Allocator allocator) { }

	// RVA: 0x142C360
	bool Contains(InputEvent* eventPtr) { }

	// RVA: 0x142CB94
	void Reset() { }

	// RVA: 0x142CBAC
	void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer) { }

	// RVA: 0x142CC6C
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x142CD98
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x142CE54
	void Dispose() { }

	// RVA: 0x142CEB8
	InputEventBuffer Clone() { }

	// RVA: 0x142CF94
	object System.ICloneable.Clone() { }

}

// Namespace: 
internal class ObserverState 
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers; // 0x10
	public System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28

	// Methods

	// RVA: 0x142D5FC
	void .ctor() { }

	// RVA: 0x142D698
	void <.ctor>b__2_0(InputEventPtr eventPtr, InputDevice device) { }

}

// Namespace: 
private class DisposableObserver 
{
	// Fields
	public System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer; // 0x10

	// Methods

	// RVA: 0x142D7AC
	void Dispose() { }

	// RVA: 0x142D690
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventListener 
{
	// Fields
	internal static ObserverState s_ObserverState; // 0x0

	// Methods

	// RVA: 0x142D0F4
	InputEventListener op_Addition(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x142D27C
	InputEventListener op_Subtraction(InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }

	// RVA: 0x142D404
	IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct InputEventPtr 
{
	// Fields
	private readonly InputEvent* m_EventPtr; // 0x10

	// Methods

	// RVA: 0x142D904
	void .ctor(InputEvent* eventPtr) { }

	// RVA: 0x142AD54
	bool get_valid() { }

	// RVA: 0x142D90C
	bool get_handled() { }

	// RVA: 0x142D928
	void set_handled(bool value) { }

	// RVA: 0x142D9A8
	int get_id() { }

	// RVA: 0x142D9C4
	void set_id(int value) { }

	// RVA: 0x142AD64
	FourCC get_type() { }

	// RVA: 0x142DA3C
	UInt32 get_sizeInBytes() { }

	// RVA: 0x142DA54
	int get_deviceId() { }

	// RVA: 0x142DA6C
	void set_deviceId(int value) { }

	// RVA: 0x142DAD8
	Double get_time() { }

	// RVA: 0x142DB50
	void set_time(Double value) { }

	// RVA: 0x142DC08
	Double get_internalTime() { }

	// RVA: 0x142DC20
	void set_internalTime(Double value) { }

	// RVA: 0x142DC8C
	InputEvent* get_data() { }

	// RVA: 0x142DC94
	FourCC get_stateFormat() { }

	// RVA: 0x142DDFC
	UInt32 get_stateSizeInBytes() { }

	// RVA: 0x142E050
	UInt32 get_stateOffset() { }

	// RVA: 0x2FE3054
	bool IsA() { }

	// RVA: 0x142E130
	InputEventPtr Next() { }

	// RVA: 0x142DD48
	string ToString() { }

	// RVA: 0x142E15C
	InputEvent* ToPointer() { }

	// RVA: 0x142E164
	bool Equals(InputEventPtr other) { }

	// RVA: 0x142E1D4
	bool Equals(object obj) { }

	// RVA: 0x142E2BC
	int GetHashCode() { }

	// RVA: 0x142E2C4
	bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x142E2D0
	bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0x142C524
	InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	// RVA: 0x142E2DC
	InputEventPtr From(InputEvent* eventPtr) { }

	// RVA: 0x142D000
	InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	// RVA: 0x142E2E0
	InputEvent* FromInputEventPtr(InputEventPtr eventPtr) { }

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

	// RVA: 0x142E2E4
	bool get_isOpen() { }

	// RVA: 0x142E2EC
	int get_remainingEventCount() { }

	// RVA: 0x142E2FC
	int get_numEventsRetainedInBuffer() { }

	// RVA: 0x142E304
	InputEvent* get_currentEventPtr() { }

	// RVA: 0x142E33C
	UInt32 get_numBytesRetainedInBuffer() { }

	// RVA: 0x142E39C
	void .ctor(ref InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	// RVA: 0x142E434
	void Close(ref InputEventBuffer eventBuffer) { }

	// RVA: 0x142E598
	void CleanUpAfterException() { }

	// RVA: 0x142E650
	void Write(InputEvent* eventPtr) { }

	// RVA: 0x142E834
	InputEvent* Advance(bool leaveEventInBuffer) { }

	// RVA: 0x142E970
	InputEvent* Peek() { }

}

// Namespace: 
private class Enumerator 
{
	// Fields
	private InputEventTrace m_Trace; // 0x10
	private int m_ChangeCounter; // 0x18
	internal InputEventPtr m_Current; // 0x20

	// Methods

	// RVA: 0x1430AD0
	void .ctor(InputEventTrace trace) { }

	// RVA: 0x1431468
	void Dispose() { }

	// RVA: 0x1431498
	bool MoveNext() { }

	// RVA: 0x14315D4
	void Reset() { }

	// RVA: 0x14315FC
	InputEventPtr get_Current() { }

	// RVA: 0x1431604
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private enum FileFlags 
{
	// Fields
	public int value__; // 0x10
	public const FileFlags FixedUpdate = 1;
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.InputSystem.LowLevel.InputEventPtr> <>9__38_0; // 0x8

	// Methods

	// RVA: 0x14330F0
	void .cctor() { }

	// RVA: 0x143315C
	void .ctor() { }

	// RVA: 0x1433164
	int <PlayAllEventsAccordingToTimestamps>b__38_0(InputEventPtr a, InputEventPtr b) { }

}

// Namespace: 
private sealed class <>c__DisplayClass43_0 
{
	// Fields
	public int originalDeviceId; // 0x10

	// Methods

	// RVA: 0x14330E8
	void .ctor() { }

	// RVA: 0x143322C
	bool <ApplyDeviceMapping>b__0(DeviceInfo x) { }

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

	// RVA: 0x143166C
	InputEventTrace get_trace() { }

	// RVA: 0x1431674
	bool get_finished() { }

	// RVA: 0x143167C
	void set_finished(bool value) { }

	// RVA: 0x1431684
	bool get_paused() { }

	// RVA: 0x143168C
	void set_paused(bool value) { }

	// RVA: 0x1431694
	int get_position() { }

	// RVA: 0x143169C
	void set_position(int value) { }

	// RVA: 0x14316A4
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices() { }

	// RVA: 0x1430578
	void .ctor(InputEventTrace trace) { }

	// RVA: 0x1431714
	void Dispose() { }

	// RVA: 0x1431A18
	ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice) { }

	// RVA: 0x1431AA8
	ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) { }

	// RVA: 0x1431CE4
	ReplayController WithAllDevicesMappedToNewInstances() { }

	// RVA: 0x1431CF0
	ReplayController OnFinished(Action action) { }

	// RVA: 0x1431D18
	ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action) { }

	// RVA: 0x1431D40
	ReplayController PlayOneEvent() { }

	// RVA: 0x14323A4
	ReplayController Rewind() { }

	// RVA: 0x14323EC
	ReplayController PlayAllFramesOneByOne() { }

	// RVA: 0x14324A8
	ReplayController PlayAllEvents() { }

	// RVA: 0x1432558
	ReplayController PlayAllEventsAccordingToTimestamps() { }

	// RVA: 0x14327F4
	void OnBeginFrame() { }

	// RVA: 0x1432ACC
	void Finished() { }

	// RVA: 0x143216C
	void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: 0x1431DD0
	bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr) { }

	// RVA: 0x1432BC4
	int ApplyDeviceMapping(int originalDeviceId) { }

}

// Namespace: 
public struct DeviceInfo 
{
	// Fields
	internal int m_DeviceId; // 0x10
	internal string m_Layout; // 0x18
	internal FourCC m_StateFormat; // 0x20
	internal int m_StateSizeInBytes; // 0x24
	internal string m_FullLayoutJson; // 0x28

	// Methods

	// RVA: 0x1433240
	int get_deviceId() { }

	// RVA: 0x1433248
	void set_deviceId(int value) { }

	// RVA: 0x1433250
	string get_layout() { }

	// RVA: 0x1433258
	void set_layout(string value) { }

	// RVA: 0x1433260
	FourCC get_stateFormat() { }

	// RVA: 0x1433268
	void set_stateFormat(FourCC value) { }

	// RVA: 0x1433270
	int get_stateSizeInBytes() { }

	// RVA: 0x1433278
	void set_stateSizeInBytes(int value) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
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

	// RVA: 0x142E9D0
	FourCC get_FrameMarkerEvent() { }

	// RVA: 0x142EA0C
	int get_deviceId() { }

	// RVA: 0x142EA14
	void set_deviceId(int value) { }

	// RVA: 0x142EA1C
	bool get_enabled() { }

	// RVA: 0x142EA24
	bool get_recordFrameMarkers() { }

	// RVA: 0x142EA2C
	void set_recordFrameMarkers(bool value) { }

	// RVA: 0x142EB54
	Int64 get_eventCount() { }

	// RVA: 0x142EB5C
	Int64 get_totalEventSizeInBytes() { }

	// RVA: 0x142EB64
	Int64 get_allocatedSizeInBytes() { }

	// RVA: 0x142EB84
	Int64 get_maxSizeInBytes() { }

	// RVA: 0x142EB8C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos() { }

	// RVA: 0x142EBE0
	System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> get_onFilterEvent() { }

	// RVA: 0x142EBE8
	void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> value) { }

	// RVA: 0x142EBF0
	void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x142EC4C
	void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x142ECA8
	void .ctor(InputDevice device, Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x142ED80
	void .ctor(Int64 bufferSizeInBytes, bool growBuffer, Int64 maxBufferSizeInBytes, Int64 growIncrementSizeInBytes) { }

	// RVA: 0x142EE1C
	void WriteTo(string filePath) { }

	// RVA: 0x142EFA8
	void WriteTo(Stream stream) { }

	// RVA: 0x142F784
	void ReadFrom(string filePath) { }

	// RVA: 0x142F910
	void ReadFrom(Stream stream) { }

	// RVA: 0x14300FC
	InputEventTrace LoadFrom(string filePath) { }

	// RVA: 0x14302BC
	InputEventTrace LoadFrom(Stream stream) { }

	// RVA: 0x14303EC
	ReplayController Replay() { }

	// RVA: 0x14305F8
	bool Resize(Int64 newBufferSize, Int64 newMaxBufferSize) { }

	// RVA: 0x14308F0
	void Clear() { }

	// RVA: 0x1430910
	void Enable() { }

	// RVA: 0x1430458
	void Disable() { }

	// RVA: 0x1430878
	bool GetNextEvent(ref InputEventPtr current) { }

	// RVA: 0x142F700
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }

	// RVA: 0x1430B18
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1430B9C
	void Dispose() { }

	// RVA: 0x142EB7C
	Byte* get_m_EventBuffer() { }

	// RVA: 0x14300E4
	void set_m_EventBuffer(Byte* value) { }

	// RVA: 0x1430870
	Byte* get_m_EventBufferHead() { }

	// RVA: 0x14300EC
	void set_m_EventBufferHead(Byte* value) { }

	// RVA: 0x1430AC8
	Byte* get_m_EventBufferTail() { }

	// RVA: 0x14300F4
	void set_m_EventBufferTail(Byte* value) { }

	// RVA: 0x1430A94
	void Allocate() { }

	// RVA: 0x1430BFC
	void Release() { }

	// RVA: 0x1430C58
	void OnBeforeUpdate() { }

	// RVA: 0x1430E14
	void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	// RVA: 0x142F6C4
	FourCC get_kFileFormat() { }

	// RVA: 0x1431418
	void .cctor() { }

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

	// RVA: 0x142E044
	UInt32 get_stateSizeInBytes() { }

	// RVA: 0x1433280
	Void* get_state() { }

	// RVA: 0x1433288
	InputEventPtr ToEventPtr() { }

	// RVA: 0x143328C
	FourCC get_typeStatic() { }

	// RVA: 0x309AF8C
	TState GetState() { }

	// RVA: 0x309AF8C
	TState GetState(InputEventPtr ptr) { }

	// RVA: 0x2FE5D84
	int GetEventSizeWithPayload() { }

	// RVA: 0x142DF10
	StateEvent* From(InputEventPtr ptr) { }

	// RVA: 0x142DD44
	StateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x1433298
	Unity.Collections.NativeArray<System.Byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x14336B8
	Unity.Collections.NativeArray<System.Byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator) { }

	// RVA: 0x14332A0
	Unity.Collections.NativeArray<System.Byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public struct TextEvent 
{
	// Fields
	public const int Type = 1413830740;
	public InputEvent baseEvent; // 0x10
	public int character; // 0x24

	// Methods

	// RVA: 0x14336C0
	FourCC get_typeStatic() { }

	// RVA: 0x14336CC
	TextEvent* From(InputEventPtr eventPtr) { }

	// RVA: 0x1433800
	TextEvent Create(int deviceId, Char character, Double time) { }

	// RVA: 0x1433910
	TextEvent Create(int deviceId, int character, Double time) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal sealed class InputUpdateDelegate 
{
	// Methods

	// RVA: 0x1433A20
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1433AC4
	internal void Invoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	// RVA: 0x1433AD8
	internal IAsyncResult BeginInvoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	// RVA: 0x1433BC4
	internal void EndInvoke(ref InputEventBuffer eventBuffer, IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal interface IInputRuntime 
{
	// Methods

	// RVA: 0x2FE32D4
	int AllocateDeviceId() { }

	// RVA: 0x2FE42A4
	void Update(InputUpdateType type) { }

	// RVA: 0x309AF8C
	void QueueEvent(InputEvent* ptr) { }

	// RVA: 0x309AF8C
	Int64 DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: 0x2FE360C
	InputUpdateDelegate get_onUpdate() { }

	// RVA: 0x2FE4574
	void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: 0x2FE360C
	System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }

	// RVA: 0x2FE4574
	void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }

	// RVA: 0x2FE360C
	System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }

	// RVA: 0x2FE4574
	void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }

	// RVA: 0x2FE360C
	System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x2FE4574
	void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x2FE360C
	System.Action<System.Boolean> get_onPlayerFocusChanged() { }

	// RVA: 0x2FE4574
	void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x2FE3054
	bool get_isPlayerFocused() { }

	// RVA: 0x2FE360C
	Action get_onShutdown() { }

	// RVA: 0x2FE4574
	void set_onShutdown(Action value) { }

	// RVA: -1
	float get_pollingFrequency() { }

	// RVA: -1
	void set_pollingFrequency(float value) { }

	// RVA: -1
	Double get_currentTime() { }

	// RVA: -1
	Double get_currentTimeForFixedUpdate() { }

	// RVA: -1
	float get_unscaledGameTime() { }

	// RVA: -1
	Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x2FE3054
	bool get_runInBackground() { }

	// RVA: 0x2FE4234
	void set_runInBackground(bool value) { }

	// RVA: -1
	Vector2 get_screenSize() { }

	// RVA: 0x2FE32D4
	ScreenOrientation get_screenOrientation() { }

	// RVA: 0x2FE3054
	bool get_isInBatchMode() { }

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

	// RVA: 0x309AF8C
	Int64 DeviceCommand(IInputRuntime runtime, int deviceId, ref TCommand command) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
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

	// RVA: 0x1433C18
	int get_maxNumDevices() { }

	// RVA: 0x1433C20
	void set_maxNumDevices(int value) { }

	// RVA: 0x1433C28
	int get_currentNumDevices() { }

	// RVA: 0x1433C30
	void set_currentNumDevices(int value) { }

	// RVA: 0x1433C38
	int get_maxStateSizeInBytes() { }

	// RVA: 0x1433C40
	void set_maxStateSizeInBytes(int value) { }

	// RVA: 0x1433C48
	int get_currentStateSizeInBytes() { }

	// RVA: 0x1433C50
	void set_currentStateSizeInBytes(int value) { }

	// RVA: 0x1433C58
	int get_currentControlCount() { }

	// RVA: 0x1433C60
	void set_currentControlCount(int value) { }

	// RVA: 0x1433C68
	int get_currentLayoutCount() { }

	// RVA: 0x1433C70
	void set_currentLayoutCount(int value) { }

	// RVA: 0x1433C78
	int get_totalEventBytes() { }

	// RVA: 0x1433C80
	void set_totalEventBytes(int value) { }

	// RVA: 0x1433C88
	int get_totalEventCount() { }

	// RVA: 0x1433C90
	void set_totalEventCount(int value) { }

	// RVA: 0x1433C98
	int get_totalUpdateCount() { }

	// RVA: 0x1433CA0
	void set_totalUpdateCount(int value) { }

	// RVA: 0x1433CA8
	Double get_totalEventProcessingTime() { }

	// RVA: 0x1433CB0
	void set_totalEventProcessingTime(Double value) { }

	// RVA: 0x1433CB8
	Double get_totalEventLagTime() { }

	// RVA: 0x1433CC0
	void set_totalEventLagTime(Double value) { }

	// RVA: 0x1433CC8
	float get_averageEventBytesPerFrame() { }

	// RVA: 0x1433CE0
	Double get_averageProcessingTimePerEvent() { }

	// RVA: 0x1433CF8
	Double get_averageLagTimePerEvent() { }

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
public struct UpdateStepCount 
{
	// Fields
	private bool m_WasUpdated; // 0x10
	private UInt32 <value>k__BackingField; // 0x14

	// Methods

	// RVA: 0x1433FA4
	UInt32 get_value() { }

	// RVA: 0x1433FAC
	void set_value(UInt32 value) { }

	// RVA: 0x1433D9C
	void OnBeforeUpdate() { }

	// RVA: 0x1433E48
	void OnUpdate() { }

}

// Namespace: 
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

	// RVA: 0x1433D10
	void OnBeforeUpdate(InputUpdateType type) { }

	// RVA: 0x1433DB4
	void OnUpdate(InputUpdateType type) { }

	// RVA: 0x1433E6C
	SerializedState Save() { }

	// RVA: 0x1433ED4
	void Restore(SerializedState state) { }

	// RVA: 0x1433F7C
	InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	// RVA: 0x1433F98
	bool IsPlayerUpdate(InputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value; // 0x10

	// Methods

	// RVA: 0x14344AC
	void .ctor() { }

	// RVA: 0x1434E28
	void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value; // 0x10

	// Methods

	// RVA: 0x14345F8
	void .ctor() { }

	// RVA: 0x1434E64
	bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public InputUpdateDelegate value; // 0x10

	// Methods

	// RVA: 0x1434360
	void .ctor() { }

	// RVA: 0x1434EA8
	void <set_onUpdate>b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr) { }

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

	// RVA: 0x1433FB4
	int AllocateDeviceId() { }

	// RVA: 0x1434024
	void Update(InputUpdateType updateType) { }

	// RVA: 0x14340AC
	void QueueEvent(InputEvent* ptr) { }

	// RVA: 0x1434138
	Int64 DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	// RVA: 0x1434224
	InputUpdateDelegate get_onUpdate() { }

	// RVA: 0x143422C
	void set_onUpdate(InputUpdateDelegate value) { }

	// RVA: 0x1434368
	System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }

	// RVA: 0x1434370
	void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }

	// RVA: 0x14344B4
	System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }

	// RVA: 0x14344BC
	void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }

	// RVA: 0x1434600
	System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x1434670
	void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x14346F8
	Action get_onShutdown() { }

	// RVA: 0x1434700
	void set_onShutdown(Action value) { }

	// RVA: 0x143481C
	System.Action<System.Boolean> get_onPlayerFocusChanged() { }

	// RVA: 0x1434824
	void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x1434940
	bool get_isPlayerFocused() { }

	// RVA: 0x14349B0
	float get_pollingFrequency() { }

	// RVA: 0x14349B8
	void set_pollingFrequency(float value) { }

	// RVA: 0x1434A2C
	Double get_currentTime() { }

	// RVA: 0x1434A9C
	Double get_currentTimeForFixedUpdate() { }

	// RVA: 0x1434B10
	Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x1434B80
	float get_unscaledGameTime() { }

	// RVA: 0x1434B88
	bool get_runInBackground() { }

	// RVA: 0x1434C28
	void set_runInBackground(bool value) { }

	// RVA: 0x1434C30
	void OnShutdown() { }

	// RVA: 0x1434C58
	bool OnWantsToShutdown() { }

	// RVA: 0x1434CB4
	void OnFocusChanged(bool focus) { }

	// RVA: 0x1434CF0
	Vector2 get_screenSize() { }

	// RVA: 0x1434D24
	ScreenOrientation get_screenOrientation() { }

	// RVA: 0x1434D2C
	bool get_isInBatchMode() { }

	// RVA: 0x1434D9C
	void RegisterAnalyticsEvent(string name, int maxPerHour, int maxPropertiesPerEvent) { }

	// RVA: 0x1434DA0
	void SendAnalyticsEvent(string name, object data) { }

	// RVA: 0x1434DA4
	void .ctor() { }

	// RVA: 0x1434DB4
	void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputStateCallbackReceiver 
{
	// Methods

	// RVA: 0x2FE41A8
	void OnNextUpdate() { }

	// RVA: -1
	void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: -1
	bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref UInt32 offset) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputStateChangeMonitor 
{
	// Methods

	// RVA: -1
	void NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: -1
	void NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public interface IInputStateTypeInfo 
{
	// Methods

	// RVA: -1
	FourCC get_format() { }

}

// Namespace: 
private class StateChangeMonitorDelegate 
{
	// Fields
	public System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback; // 0x10
	public System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback; // 0x18

	// Methods

	// RVA: 0x1435D54
	void NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x1435DA0
	void NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1435A8C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public static class InputState 
{
	// Methods

	// RVA: 0x14350B8
	InputUpdateType get_currentUpdateType() { }

	// RVA: 0x1435104
	UInt32 get_updateCount() { }

	// RVA: 0x1435150
	Double get_currentTime() { }

	// RVA: 0x1435224
	void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x14352B4
	void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }

	// RVA: 0x1435344
	void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType) { }

	// RVA: 0x309AF8C
	void Change(InputControl control, TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x309AF8C
	void Change(InputControl control, ref TState state, InputUpdateType updateType, InputEventPtr eventPtr) { }

	// RVA: 0x14355CC
	bool IsIntegerFormat(FourCC format) { }

	// RVA: 0x143581C
	void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex, UInt32 groupIndex) { }

	// RVA: 0x143598C
	IInputStateChangeMonitor AddChangeMonitor(InputControl control, System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback, int monitorIndex, System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback) { }

	// RVA: 0x1435A94
	void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, Int64 monitorIndex) { }

	// RVA: 0x1435B8C
	void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x1435C80
	void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, Int64 monitorIndex, int timerIndex) { }

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

	// RVA: 0x1435DE8
	int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	// RVA: 0x1436244
	FourCC GetPrimitiveFormatFromType(Type type) { }

	// RVA: 0x14368C4
	FourCC get_format() { }

	// RVA: 0x14368CC
	void set_format(FourCC value) { }

	// RVA: 0x14368D4
	UInt32 get_byteOffset() { }

	// RVA: 0x14368DC
	void set_byteOffset(UInt32 value) { }

	// RVA: 0x14368E4
	UInt32 get_bitOffset() { }

	// RVA: 0x14368EC
	void set_bitOffset(UInt32 value) { }

	// RVA: 0x14368F4
	UInt32 get_sizeInBits() { }

	// RVA: 0x14368FC
	void set_sizeInBits(UInt32 value) { }

	// RVA: 0x142B300
	UInt32 get_alignedSizeInBytes() { }

	// RVA: 0x1436904
	UInt32 get_effectiveByteOffset() { }

	// RVA: 0x143698C
	UInt32 get_effectiveBitOffset() { }

	// RVA: 0x1436A14
	int ReadInt(Void* statePtr) { }

	// RVA: 0x1436D4C
	void WriteInt(Void* statePtr, int value) { }

	// RVA: 0x143705C
	float ReadFloat(Void* statePtr) { }

	// RVA: 0x1437500
	void WriteFloat(Void* statePtr, float value) { }

	// RVA: 0x1437AD4
	PrimitiveValue FloatToPrimitiveValue(float value) { }

	// RVA: 0x14380D8
	Double ReadDouble(Void* statePtr) { }

	// RVA: 0x143858C
	void WriteDouble(Void* statePtr, Double value) { }

	// RVA: 0x1438B78
	void Write(Void* statePtr, PrimitiveValue value) { }

	// RVA: 0x1438F94
	void CopyToFrom(Void* toStatePtr, Void* fromStatePtr) { }

	// RVA: 0x1439100
	void .cctor() { }

}

// Namespace: 
internal struct DoubleBuffers 
{
	// Fields
	public Void** deviceToBufferMapping; // 0x10

	// Methods

	// RVA: 0x143A074
	bool get_valid() { }

	// RVA: 0x1439948
	void SetFrontBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x1439958
	void SetBackBuffer(int deviceIndex, Void* ptr) { }

	// RVA: 0x143964C
	Void* GetFrontBuffer(int deviceIndex) { }

	// RVA: 0x14396C0
	Void* GetBackBuffer(int deviceIndex) { }

	// RVA: 0x143A084
	void SwapBuffers(int deviceIndex) { }

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

	// RVA: 0x1439514
	DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	// RVA: 0x14395EC
	Void* GetFrontBufferForDevice(int deviceIndex) { }

	// RVA: 0x143965C
	Void* GetBackBufferForDevice(int deviceIndex) { }

	// RVA: 0x14396D4
	void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

	// RVA: 0x143973C
	void AllocateAll(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x14398EC
	DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref Byte* bufferPtr, UInt32 sizePerBuffer, UInt32 mappingTableSizePerBuffer) { }

	// RVA: 0x143996C
	void FreeAll() { }

	// RVA: 0x1439A6C
	void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	// RVA: 0x1439BF4
	void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) { }

	// RVA: 0x1439DD0
	void MigrateSingleBuffer(Void* newBuffer, InputDevice[] devices, int deviceCount, Void* oldBuffer) { }

	// RVA: 0x1439870
	UInt32 ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x1439F24
	UInt32 NextDeviceOffset(UInt32 currentOffset, InputDevice device) { }

}

// Namespace: 
private struct Enumerator 
{
	// Fields
	private readonly InputStateHistory m_History; // 0x10
	private int m_Index; // 0x18

	// Methods

	// RVA: 0x143BE64
	void .ctor(InputStateHistory history) { }

	// RVA: 0x143C620
	bool MoveNext() { }

	// RVA: 0x143C65C
	void Reset() { }

	// RVA: 0x143C668
	Record get_Current() { }

	// RVA: 0x143C68C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x143C6FC
	void Dispose() { }

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

	// RVA: 0x143BDDC
	Byte* get_statePtrWithControlIndex() { }

	// RVA: 0x143BDD4
	Byte* get_statePtrWithoutControlIndex() { }

}

// Namespace: 
public struct Record 
{
	// Fields
	private readonly InputStateHistory m_Owner; // 0x10
	private readonly int m_IndexPlusOne; // 0x18
	private UInt32 m_Version; // 0x1C

	// Methods

	// RVA: 0x143C700
	RecordHeader* get_header() { }

	// RVA: 0x143C728
	int get_recordIndex() { }

	// RVA: 0x143C734
	UInt32 get_version() { }

	// RVA: 0x143C73C
	bool get_valid() { }

	// RVA: 0x143C798
	InputStateHistory get_owner() { }

	// RVA: 0x143C7A0
	int get_index() { }

	// RVA: 0x143C89C
	Double get_time() { }

	// RVA: 0x143C8DC
	InputControl get_control() { }

	// RVA: 0x143C9F8
	Record get_next() { }

	// RVA: 0x143CAC4
	Record get_previous() { }

	// RVA: 0x143A830
	void .ctor(InputStateHistory owner, int index, RecordHeader* header) { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x143CB88
	object ReadValueAsObject() { }

	// RVA: 0x143CBCC
	Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x143CBF0
	Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x143CCE0
	Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x143CD04
	Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x143A9D4
	void CopyFrom(Record record) { }

	// RVA: 0x143C7E8
	void CheckValid() { }

	// RVA: 0x143CDE8
	bool Equals(Record other) { }

	// RVA: 0x143CE1C
	bool Equals(object obj) { }

	// RVA: 0x143CECC
	int GetHashCode() { }

	// RVA: 0x143CF20
	string ToString() { }

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

	// RVA: 0x143A0B4
	int get_Count() { }

	// RVA: 0x143A0BC
	UInt32 get_version() { }

	// RVA: 0x143A0C4
	int get_historyDepth() { }

	// RVA: 0x143A0CC
	void set_historyDepth(int value) { }

	// RVA: 0x143A1B4
	int get_extraMemoryPerRecord() { }

	// RVA: 0x143A1BC
	void set_extraMemoryPerRecord(int value) { }

	// RVA: 0x143A2A4
	InputUpdateType get_updateMask() { }

	// RVA: 0x143A418
	void set_updateMask(InputUpdateType value) { }

	// RVA: 0x143A4F0
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }

	// RVA: 0x143A564
	Record get_Item(int index) { }

	// RVA: 0x143A87C
	void set_Item(int index, Record value) { }

	// RVA: 0x143ADF8
	System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded() { }

	// RVA: 0x143AE00
	void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value) { }

	// RVA: 0x143AE08
	System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> get_onShouldRecordStateChange() { }

	// RVA: 0x143AE10
	void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }

	// RVA: 0x143AE18
	void .ctor(int maxStateSizeInBytes) { }

	// RVA: 0x143AEC0
	void .ctor(string path) { }

	// RVA: 0x143B028
	void .ctor(InputControl control) { }

	// RVA: 0x143B144
	void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls) { }

	// RVA: 0x143B1E0
	void Finalize() { }

	// RVA: 0x143B370
	void Clear() { }

	// RVA: 0x143B384
	Record AddRecord(Record record) { }

	// RVA: 0x143B52C
	void StartRecording() { }

	// RVA: 0x143B6C8
	void StopRecording() { }

	// RVA: 0x143B860
	Record RecordStateChange(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x143BA68
	Record RecordStateChange(InputControl control, Void* statePtr, Double time) { }

	// RVA: 0x143BDE4
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator() { }

	// RVA: 0x143BE90
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x143B270
	void Dispose() { }

	// RVA: 0x143BF10
	void Destroy() { }

	// RVA: 0x143BF78
	void Allocate() { }

	// RVA: 0x143C2D0
	int RecordIndexToUserIndex(int index) { }

	// RVA: 0x143A698
	int UserIndexToRecordIndex(int index) { }

	// RVA: 0x143A6B0
	RecordHeader* GetRecord(int index) { }

	// RVA: 0x143C2EC
	RecordHeader* GetRecordUnchecked(int index) { }

	// RVA: 0x143B414
	RecordHeader* AllocateRecord(out int index) { }

	// RVA: 0x309AF8C
	TValue ReadValue(RecordHeader* data) { }

	// RVA: 0x143C3A0
	object ReadValueAsObject(RecordHeader* data) { }

	// RVA: 0x143C538
	void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, Double time, InputEventPtr eventPtr, Int64 monitorIndex) { }

	// RVA: 0x143C61C
	void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, Double time, Int64 monitorIndex, int timerIndex) { }

	// RVA: 0x143C27C
	int get_bytesPerRecord() { }

}

// Namespace: 
private struct Enumerator 
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history) { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	Record get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

}

// Namespace: 
public struct Record 
{
	// Fields
	private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_Owner; // 0x0
	private readonly int m_IndexPlusOne; // 0x0
	private UInt32 m_Version; // 0x0

	// Methods

	// RVA: 0x309AF8C
	RecordHeader* get_header() { }

	// RVA: 0x2FE32D4
	int get_recordIndex() { }

	// RVA: 0x2FE3054
	bool get_valid() { }

	// RVA: 0x2FE360C
	UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner() { }

	// RVA: 0x2FE32D4
	int get_index() { }

	// RVA: -1
	Double get_time() { }

	// RVA: 0x2FE360C
	UnityEngine.InputSystem.InputControl<TValue> get_control() { }

	// RVA: 0x309AF8C
	Record get_next() { }

	// RVA: 0x309AF8C
	Record get_previous() { }

	// RVA: 0x309AF8C
	void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, RecordHeader* header) { }

	// RVA: 0x2FE45DC
	void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index) { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x309AF8C
	Void* GetUnsafeMemoryPtr() { }

	// RVA: 0x309AF8C
	Void* GetUnsafeMemoryPtrUnchecked() { }

	// RVA: 0x309AF8C
	Void* GetUnsafeExtraMemoryPtr() { }

	// RVA: 0x309AF8C
	Void* GetUnsafeExtraMemoryPtrUnchecked() { }

	// RVA: 0x309AF8C
	void CopyFrom(Record record) { }

	// RVA: 0x2FE41A8
	void CheckValid() { }

	// RVA: 0x309AF8C
	bool Equals(Record other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x2FE360C
	string ToString() { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
public class InputStateHistory<T0> 
{
	// Methods

	// RVA: -1
	void .ctor(System.Nullable<System.Int32> maxStateSizeInBytes) { }

	// RVA: 0x2FE4574
	void .ctor(UnityEngine.InputSystem.InputControl<TValue> control) { }

	// RVA: 0x2FE4574
	void .ctor(string path) { }

	// RVA: 0x2FE41A8
	void Finalize() { }

	// RVA: 0x309AF8C
	Record AddRecord(Record record) { }

	// RVA: 0x309AF8C
	Record RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, Double time) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	Record get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, Record value) { }

}

// Namespace: 
private class Select 
{
	// Fields
	private UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x2FE41A8
	void OnCompleted() { }

	// RVA: 0x2FE4574
	void OnError(Exception error) { }

	// RVA: 0x309AF8C
	void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.LowLevel
internal class SelectObservable<T0, T1> 
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,TResult> m_Filter; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x2FE36BC
	IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class AxisDeadzoneProcessor 
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x143D06C
	float get_minOrDefault() { }

	// RVA: 0x143D0E0
	float get_maxOrDefault() { }

	// RVA: 0x143D154
	float Process(float value, InputControl control) { }

	// RVA: 0x143D268
	string ToString() { }

	// RVA: 0x143D3D8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ClampProcessor 
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x143D42C
	float Process(float value, InputControl control) { }

	// RVA: 0x143D444
	string ToString() { }

	// RVA: 0x143D4EC
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateDirectionProcessor 
{
	// Methods

	// RVA: 0x143D540
	Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x143D76C
	string ToString() { }

	// RVA: 0x143D7B0
	CachingPolicy get_cachingPolicy() { }

	// RVA: 0x143D7B8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
internal class CompensateRotationProcessor 
{
	// Methods

	// RVA: 0x143D80C
	Quaternion Process(Quaternion value, InputControl control) { }

	// RVA: 0x143DA58
	string ToString() { }

	// RVA: 0x143DA9C
	CachingPolicy get_cachingPolicy() { }

	// RVA: 0x143DAA4
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertProcessor 
{
	// Methods

	// RVA: 0x143DAF8
	float Process(float value, InputControl control) { }

	// RVA: 0x143DB00
	string ToString() { }

	// RVA: 0x143DB44
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertVector2Processor 
{
	// Fields
	public bool invertX; // 0x10
	public bool invertY; // 0x11

	// Methods

	// RVA: 0x143DB98
	Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x143DBBC
	string ToString() { }

	// RVA: 0x143DC64
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class InvertVector3Processor 
{
	// Fields
	public bool invertX; // 0x10
	public bool invertY; // 0x11
	public bool invertZ; // 0x12

	// Methods

	// RVA: 0x143DCC0
	Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x143DCF4
	string ToString() { }

	// RVA: 0x143DDC0
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeProcessor 
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14
	public float zero; // 0x18

	// Methods

	// RVA: 0x143DE24
	float Process(float value, InputControl control) { }

	// RVA: 0x143DF14
	float Normalize(float value, float min, float max, float zero) { }

	// RVA: 0x143E004
	float Denormalize(float value, float min, float max, float zero) { }

	// RVA: 0x143E048
	string ToString() { }

	// RVA: 0x143E114
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector2Processor 
{
	// Methods

	// RVA: 0x143E168
	Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x143E250
	string ToString() { }

	// RVA: 0x143E294
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class NormalizeVector3Processor 
{
	// Methods

	// RVA: 0x143E2E8
	Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x143E3F0
	string ToString() { }

	// RVA: 0x143E434
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleProcessor 
{
	// Fields
	public float factor; // 0x10

	// Methods

	// RVA: 0x143E488
	float Process(float value, InputControl control) { }

	// RVA: 0x143E494
	string ToString() { }

	// RVA: 0x143E520
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleVector2Processor 
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14

	// Methods

	// RVA: 0x143E57C
	Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x143E58C
	string ToString() { }

	// RVA: 0x143E634
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class ScaleVector3Processor 
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x143E690
	Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x143E6A8
	string ToString() { }

	// RVA: 0x143E774
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Processors
public class StickDeadzoneProcessor 
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x143E7D8
	float get_minOrDefault() { }

	// RVA: 0x143E84C
	float get_maxOrDefault() { }

	// RVA: 0x143E8C0
	Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x143E9BC
	float GetDeadZoneAdjustedValue(float value) { }

	// RVA: 0x143EAD0
	string ToString() { }

	// RVA: 0x143EC40
	void .ctor() { }

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

	// RVA: 0x143EC94
	string get_layout() { }

	// RVA: 0x143EC9C
	void set_layout(string value) { }

	// RVA: 0x143ECA4
	string get_variants() { }

	// RVA: 0x143ECAC
	void set_variants(string value) { }

	// RVA: 0x143ECB4
	string get_name() { }

	// RVA: 0x143ECBC
	void set_name(string value) { }

	// RVA: 0x143ECC4
	string get_format() { }

	// RVA: 0x143ECCC
	void set_format(string value) { }

	// RVA: 0x143ECD4
	string get_usage() { }

	// RVA: 0x143ECDC
	void set_usage(string value) { }

	// RVA: 0x143ECE4
	string[] get_usages() { }

	// RVA: 0x143ECEC
	void set_usages(string[] value) { }

	// RVA: 0x143ECF4
	string get_parameters() { }

	// RVA: 0x143ECFC
	void set_parameters(string value) { }

	// RVA: 0x143ED04
	string get_processors() { }

	// RVA: 0x143ED0C
	void set_processors(string value) { }

	// RVA: 0x143ED14
	string get_alias() { }

	// RVA: 0x143ED1C
	void set_alias(string value) { }

	// RVA: 0x143ED24
	string[] get_aliases() { }

	// RVA: 0x143ED2C
	void set_aliases(string[] value) { }

	// RVA: 0x143ED34
	string get_useStateFrom() { }

	// RVA: 0x143ED3C
	void set_useStateFrom(string value) { }

	// RVA: 0x143ED44
	UInt32 get_bit() { }

	// RVA: 0x143ED4C
	void set_bit(UInt32 value) { }

	// RVA: 0x143ED54
	UInt32 get_offset() { }

	// RVA: 0x143ED5C
	void set_offset(UInt32 value) { }

	// RVA: 0x143ED64
	UInt32 get_sizeInBits() { }

	// RVA: 0x143ED6C
	void set_sizeInBits(UInt32 value) { }

	// RVA: 0x143ED74
	int get_arraySize() { }

	// RVA: 0x143ED7C
	void set_arraySize(int value) { }

	// RVA: 0x143ED84
	string get_displayName() { }

	// RVA: 0x143ED8C
	void set_displayName(string value) { }

	// RVA: 0x143ED94
	string get_shortDisplayName() { }

	// RVA: 0x143ED9C
	void set_shortDisplayName(string value) { }

	// RVA: 0x143EDA4
	bool get_noisy() { }

	// RVA: 0x143EDAC
	void set_noisy(bool value) { }

	// RVA: 0x143EDB4
	bool get_synthetic() { }

	// RVA: 0x143EDBC
	void set_synthetic(bool value) { }

	// RVA: 0x143EDC4
	bool get_dontReset() { }

	// RVA: 0x143EDCC
	void set_dontReset(bool value) { }

	// RVA: 0x143EDD4
	object get_defaultState() { }

	// RVA: 0x143EDDC
	void set_defaultState(object value) { }

	// RVA: 0x143EDE4
	object get_minValue() { }

	// RVA: 0x143EDEC
	void set_minValue(object value) { }

	// RVA: 0x143EDF4
	object get_maxValue() { }

	// RVA: 0x143EDFC
	void set_maxValue(object value) { }

	// RVA: 0x143EE04
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public sealed class InputDeviceFindControlLayoutDelegate 
{
	// Methods

	// RVA: 0x143EE14
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x143EED0
	internal string Invoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x143EEE4
	internal IAsyncResult BeginInvoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	// RVA: 0x143EFB4
	internal string EndInvoke(ref InputDeviceDescription description, IAsyncResult result) { }

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

	// RVA: 0x144498C
	InternedString get_name() { }

	// RVA: 0x1444998
	void set_name(InternedString value) { }

	// RVA: 0x14449A4
	InternedString get_layout() { }

	// RVA: 0x14449B0
	void set_layout(InternedString value) { }

	// RVA: 0x14449BC
	InternedString get_variants() { }

	// RVA: 0x14449C8
	void set_variants(InternedString value) { }

	// RVA: 0x14449D4
	string get_useStateFrom() { }

	// RVA: 0x14449DC
	void set_useStateFrom(string value) { }

	// RVA: 0x14449E4
	string get_displayName() { }

	// RVA: 0x14449EC
	void set_displayName(string value) { }

	// RVA: 0x14449F4
	string get_shortDisplayName() { }

	// RVA: 0x14449FC
	void set_shortDisplayName(string value) { }

	// RVA: 0x1444A04
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }

	// RVA: 0x1444A10
	void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x1444A1C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }

	// RVA: 0x1444A28
	void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }

	// RVA: 0x1444A34
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x1444A40
	void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x1444A4C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors() { }

	// RVA: 0x1444A58
	void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value) { }

	// RVA: 0x1444A64
	UInt32 get_offset() { }

	// RVA: 0x1444A6C
	void set_offset(UInt32 value) { }

	// RVA: 0x1444A74
	UInt32 get_bit() { }

	// RVA: 0x1444A7C
	void set_bit(UInt32 value) { }

	// RVA: 0x1444A84
	UInt32 get_sizeInBits() { }

	// RVA: 0x1444A8C
	void set_sizeInBits(UInt32 value) { }

	// RVA: 0x1444A94
	FourCC get_format() { }

	// RVA: 0x1444A9C
	void set_format(FourCC value) { }

	// RVA: 0x1444AA4
	Flags get_flags() { }

	// RVA: 0x1444AAC
	void set_flags(Flags value) { }

	// RVA: 0x1444AB4
	int get_arraySize() { }

	// RVA: 0x1444ABC
	void set_arraySize(int value) { }

	// RVA: 0x1444AC4
	PrimitiveValue get_defaultState() { }

	// RVA: 0x1444AD0
	void set_defaultState(PrimitiveValue value) { }

	// RVA: 0x1444AD8
	PrimitiveValue get_minValue() { }

	// RVA: 0x1444AE4
	void set_minValue(PrimitiveValue value) { }

	// RVA: 0x1444AEC
	PrimitiveValue get_maxValue() { }

	// RVA: 0x1444AF8
	void set_maxValue(PrimitiveValue value) { }

	// RVA: 0x1444B00
	bool get_isModifyingExistingControl() { }

	// RVA: 0x1444B0C
	void set_isModifyingExistingControl(bool value) { }

	// RVA: 0x1444B20
	bool get_isNoisy() { }

	// RVA: 0x1444B2C
	void set_isNoisy(bool value) { }

	// RVA: 0x1444B4C
	bool get_isSynthetic() { }

	// RVA: 0x1444B58
	void set_isSynthetic(bool value) { }

	// RVA: 0x1444B78
	bool get_dontReset() { }

	// RVA: 0x1444B84
	void set_dontReset(bool value) { }

	// RVA: 0x1444BA4
	bool get_isFirstDefinedInThisLayout() { }

	// RVA: 0x1444BB0
	void set_isFirstDefinedInThisLayout(bool value) { }

	// RVA: 0x1444BD0
	bool get_isArray() { }

	// RVA: 0x1444BE0
	ControlItem Merge(ControlItem other) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x14460B8
	void .cctor() { }

	// RVA: 0x1446124
	void .ctor() { }

	// RVA: 0x144612C
	InternedString <WithUsages>b__14_0(string x) { }

}

// Namespace: 
public struct ControlBuilder 
{
	// Fields
	internal Builder builder; // 0x10
	internal int index; // 0x18

	// Methods

	// RVA: 0x144562C
	ControlBuilder WithDisplayName(string displayName) { }

	// RVA: 0x1445684
	ControlBuilder WithLayout(string layout) { }

	// RVA: 0x1445778
	ControlBuilder WithFormat(FourCC format) { }

	// RVA: 0x14457C4
	ControlBuilder WithFormat(string format) { }

	// RVA: 0x1445834
	ControlBuilder WithByteOffset(UInt32 offset) { }

	// RVA: 0x1445880
	ControlBuilder WithBitOffset(UInt32 bit) { }

	// RVA: 0x14458CC
	ControlBuilder IsSynthetic(bool value) { }

	// RVA: 0x1445930
	ControlBuilder IsNoisy(bool value) { }

	// RVA: 0x1445994
	ControlBuilder DontReset(bool value) { }

	// RVA: 0x14459F8
	ControlBuilder WithSizeInBits(UInt32 sizeInBits) { }

	// RVA: 0x1445A44
	ControlBuilder WithRange(float minValue, float maxValue) { }

	// RVA: 0x1445AEC
	ControlBuilder WithUsages(InternedString[] usages) { }

	// RVA: 0x1445CC0
	ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<System.String> usages) { }

	// RVA: 0x1445DF8
	ControlBuilder WithUsages(string[] usages) { }

	// RVA: 0x1445DFC
	ControlBuilder WithParameters(string parameters) { }

	// RVA: 0x1445EC8
	ControlBuilder WithProcessors(string processors) { }

	// RVA: 0x1445FB0
	ControlBuilder WithDefaultState(PrimitiveValue value) { }

	// RVA: 0x1445FFC
	ControlBuilder UsingStateFrom(string path) { }

	// RVA: 0x144606C
	ControlBuilder AsArrayOfControlsWithSize(int arraySize) { }

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

	// RVA: 0x144504C
	string get_name() { }

	// RVA: 0x1445054
	void set_name(string value) { }

	// RVA: 0x144505C
	string get_displayName() { }

	// RVA: 0x1445064
	void set_displayName(string value) { }

	// RVA: 0x144506C
	Type get_type() { }

	// RVA: 0x1445074
	void set_type(Type value) { }

	// RVA: 0x144507C
	FourCC get_stateFormat() { }

	// RVA: 0x1445084
	void set_stateFormat(FourCC value) { }

	// RVA: 0x144508C
	int get_stateSizeInBytes() { }

	// RVA: 0x1445094
	void set_stateSizeInBytes(int value) { }

	// RVA: 0x144509C
	string get_extendsLayout() { }

	// RVA: 0x14450A4
	void set_extendsLayout(string value) { }

	// RVA: 0x14450E0
	System.Nullable<System.Boolean> get_updateBeforeRender() { }

	// RVA: 0x14450E8
	void set_updateBeforeRender(System.Nullable<System.Boolean> value) { }

	// RVA: 0x14450F0
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x1445164
	ControlBuilder AddControl(string name) { }

	// RVA: 0x14452FC
	Builder WithName(string name) { }

	// RVA: 0x1445324
	Builder WithDisplayName(string displayName) { }

	// RVA: 0x2FE360C
	Builder WithType() { }

	// RVA: 0x144534C
	Builder WithFormat(FourCC format) { }

	// RVA: 0x1445354
	Builder WithFormat(string format) { }

	// RVA: 0x1445394
	Builder WithSizeInBytes(int sizeInBytes) { }

	// RVA: 0x144539C
	Builder Extend(string baseLayoutName) { }

	// RVA: 0x14453E0
	InputControlLayout Build() { }

	// RVA: 0x1445624
	void .ctor() { }

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
internal struct LayoutJsonNameAndDescriptorOnly 
{
	// Fields
	public string name; // 0x10
	public string extend; // 0x18
	public string[] extendMultiple; // 0x20
	public MatcherJson device; // 0x28
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__14_0; // 0x8
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__15_0; // 0x10
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__15_1; // 0x18

	// Methods

	// RVA: 0x1447E10
	void .cctor() { }

	// RVA: 0x1447E7C
	void .ctor() { }

	// RVA: 0x1447E84
	InternedString <ToLayout>b__14_0(string x) { }

	// RVA: 0x1447EB0
	string <FromLayout>b__15_0(InternedString x) { }

	// RVA: 0x1447ED8
	string <FromLayout>b__15_1(InternedString x) { }

}

// Namespace: 
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

	// RVA: 0x1446158
	InputControlLayout ToLayout() { }

	// RVA: 0x1447230
	LayoutJson FromLayout(InputControlLayout layout) { }

}

// Namespace: 
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

	// RVA: 0x1447F2C
	void .cctor() { }

	// RVA: 0x1447F98
	void .ctor() { }

	// RVA: 0x1447FA0
	InternedString <ToLayout>b__24_0(string x) { }

	// RVA: 0x1447FCC
	InternedString <ToLayout>b__24_1(string x) { }

	// RVA: 0x1447FF8
	string <FromControlItems>b__25_0(NamedValue x) { }

	// RVA: 0x1448004
	string <FromControlItems>b__25_1(NameAndParameters x) { }

	// RVA: 0x1448010
	string <FromControlItems>b__25_2(InternedString x) { }

	// RVA: 0x1448038
	string <FromControlItems>b__25_3(InternedString x) { }

}

// Namespace: 
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

	// RVA: 0x1447F00
	void .ctor() { }

	// RVA: 0x1446B54
	ControlItem ToLayout() { }

	// RVA: 0x144769C
	ControlItemJson[] FromControlItems(ControlItem[] items) { }

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

	// RVA: 0x144A018
	void .ctor(int <>1__state) { }

	// RVA: 0x144A344
	void System.IDisposable.Dispose() { }

	// RVA: 0x144A348
	bool MoveNext() { }

	// RVA: 0x144A450
	InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current() { }

	// RVA: 0x144A45C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x144A49C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x144A504
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator() { }

	// RVA: 0x144A5D4
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
internal struct Collection 
{
	// Fields
	public const float kBaseScoreForNonGeneratedLayouts = 1065353216;
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> layoutTypes; // 0x10
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.String> layoutStrings; // 0x18
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>> layoutBuilders; // 0x20
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> baseLayoutTable; // 0x28
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> layoutOverrides; // 0x30
	public System.Collections.Generic.HashSet<UnityEngine.InputSystem.Utilities.InternedString> layoutOverrideNames; // 0x38
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.PrecompiledLayout> precompiledLayouts; // 0x40
	public System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.LayoutMatcher> layoutMatchers; // 0x48

	// Methods

	// RVA: 0x1448060
	void Allocate() { }

	// RVA: 0x144830C
	InternedString TryFindLayoutForType(Type layoutType) { }

	// RVA: 0x1448670
	InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x1448E74
	bool HasLayout(InternedString name) { }

	// RVA: 0x1448F7C
	InputControlLayout TryLoadLayoutInternal(InternedString name) { }

	// RVA: 0x14491A0
	InputControlLayout TryLoadLayout(InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table) { }

	// RVA: 0x1449628
	InternedString GetBaseLayoutName(InternedString layoutName) { }

	// RVA: 0x14496B8
	InternedString GetRootLayoutName(InternedString layoutName) { }

	// RVA: 0x1449750
	bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance) { }

	// RVA: 0x144993C
	InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache) { }

	// RVA: 0x1449C3C
	Type GetControlTypeForLayout(InternedString layoutName) { }

	// RVA: 0x1449DA0
	bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType) { }

	// RVA: 0x1449EE0
	bool IsGeneratedLayout(InternedString layout) { }

	// RVA: 0x1449F58
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(InternedString layout, bool includeSelf) { }

	// RVA: 0x144A050
	bool IsBasedOn(InternedString parentLayout, InternedString childLayout) { }

	// RVA: 0x144A108
	void AddMatcher(InternedString layout, InputDeviceMatcher matcher) { }

}

// Namespace: 
public class LayoutNotFoundException 
{
	// Fields
	private readonly string <layout>k__BackingField; // 0x90

	// Methods

	// RVA: 0x144A5D8
	string get_layout() { }

	// RVA: 0x144A5E0
	void .ctor() { }

	// RVA: 0x144A668
	void .ctor(string name, string message) { }

	// RVA: 0x1449564
	void .ctor(string name) { }

	// RVA: 0x144A6F0
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x144A76C
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
internal struct Cache 
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table; // 0x10

	// Methods

	// RVA: 0x144A7F0
	void Clear() { }

	// RVA: 0x1449AF8
	InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound) { }

}

// Namespace: 
internal struct CacheRefInstance 
{
	// Fields
	public bool valid; // 0x10

	// Methods

	// RVA: 0x144A7FC
	void Dispose() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputControlLayout.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__52_0; // 0x8
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__75_0; // 0x10
	public static System.Func<System.String,UnityEngine.InputSystem.Utilities.InternedString> <>9__75_1; // 0x18

	// Methods

	// RVA: 0x144A8B4
	void .cctor() { }

	// RVA: 0x144A920
	void .ctor() { }

	// RVA: 0x144A928
	InternedString <FromType>b__52_0(string x) { }

	// RVA: 0x144A954
	InternedString <CreateControlItemFromMember>b__75_0(string x) { }

	// RVA: 0x144A980
	InternedString <CreateControlItemFromMember>b__75_1(string x) { }

}

// Namespace: UnityEngine.InputSystem.Layouts
public class InputControlLayout 
{
	// Fields
	private static InternedString s_DefaultVariant; // 0x0
	public const string VariantSeparator = 5736712288;
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

	// RVA: 0x143F008
	InternedString get_DefaultVariant() { }

	// RVA: 0x143F084
	InternedString get_name() { }

	// RVA: 0x143F090
	string get_displayName() { }

	// RVA: 0x143F0B0
	Type get_type() { }

	// RVA: 0x143F0B8
	InternedString get_variants() { }

	// RVA: 0x143F0C4
	FourCC get_stateFormat() { }

	// RVA: 0x143F0CC
	int get_stateSizeInBytes() { }

	// RVA: 0x143F0D4
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts() { }

	// RVA: 0x143F140
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides() { }

	// RVA: 0x143F1AC
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages() { }

	// RVA: 0x143F218
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x143F284
	bool get_updateBeforeRender() { }

	// RVA: 0x143F35C
	bool get_isDeviceLayout() { }

	// RVA: 0x143F414
	bool get_isControlLayout() { }

	// RVA: 0x143F4D4
	bool get_isOverride() { }

	// RVA: 0x143F4E0
	void set_isOverride(bool value) { }

	// RVA: 0x143F500
	bool get_isGenericTypeOfDevice() { }

	// RVA: 0x143F50C
	void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x143F520
	bool get_hideInUI() { }

	// RVA: 0x143F52C
	void set_hideInUI(bool value) { }

	// RVA: 0x143F54C
	bool get_isNoisy() { }

	// RVA: 0x143F558
	void set_isNoisy(bool value) { }

	// RVA: 0x143F578
	System.Nullable<System.Boolean> get_canRunInBackground() { }

	// RVA: 0x143F600
	void set_canRunInBackground(System.Nullable<System.Boolean> value) { }

	// RVA: 0x143F6F4
	ControlItem get_Item(string path) { }

	// RVA: 0x143F89C
	System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(InternedString path) { }

	// RVA: 0x143FAA4
	System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, out int arrayIndex) { }

	// RVA: 0x143FED0
	Type GetValueType() { }

	// RVA: 0x143FF64
	InputControlLayout FromType(string name, Type type) { }

	// RVA: 0x143136C
	string ToJson() { }

	// RVA: 0x144062C
	InputControlLayout FromJson(string json) { }

	// RVA: 0x14405B8
	void .ctor(string name, Type type) { }

	// RVA: 0x1440474
	void AddControlItems(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x14406D4
	void AddControlItemsFromFields(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x1440768
	void AddControlItemsFromProperties(Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x14407FC
	void AddControlItemsFromMembers(MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName) { }

	// RVA: 0x1440D94
	void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems) { }

	// RVA: 0x1440FC8
	ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	// RVA: 0x1441944
	string InferLayoutFromValueType(Type type) { }

	// RVA: 0x1441B20
	void MergeLayout(InputControlLayout other) { }

	// RVA: 0x1443EF4
	System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, System.Collections.Generic.List<System.String> variants) { }

	// RVA: 0x1444504
	bool VariantsMatch(InternedString expected, InternedString actual) { }

	// RVA: 0x14443B4
	bool VariantsMatch(string expected, string actual) { }

	// RVA: 0x1444590
	void ParseHeaderFieldsFromJson(string json, out InternedString name, out UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>& baseLayouts, out InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x144472C
	ref Cache get_cache() { }

	// RVA: 0x14447A8
	CacheRefInstance CacheRef() { }

	// RVA: 0x1444810
	void .cctor() { }

	// RVA: 0x14448A8
	bool <MergeLayout>b__77_0(ControlItem x) { }

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

	// RVA: 0x144A9AC
	Type get_stateType() { }

	// RVA: 0x144A9B4
	void set_stateType(Type value) { }

	// RVA: 0x144A9BC
	string get_stateFormat() { }

	// RVA: 0x144A9C4
	void set_stateFormat(string value) { }

	// RVA: 0x144A9CC
	string[] get_commonUsages() { }

	// RVA: 0x144A9D4
	void set_commonUsages(string[] value) { }

	// RVA: 0x144A9DC
	string get_variants() { }

	// RVA: 0x144A9E4
	void set_variants(string value) { }

	// RVA: 0x144A9EC
	bool get_isNoisy() { }

	// RVA: 0x144A9F4
	void set_isNoisy(bool value) { }

	// RVA: 0x144A9FC
	bool get_canRunInBackground() { }

	// RVA: 0x144AA64
	void set_canRunInBackground(bool value) { }

	// RVA: 0x144AADC
	bool get_updateBeforeRender() { }

	// RVA: 0x144AB44
	void set_updateBeforeRender(bool value) { }

	// RVA: 0x144ABBC
	bool get_isGenericTypeOfDevice() { }

	// RVA: 0x144ABC4
	void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x144ABCC
	string get_displayName() { }

	// RVA: 0x144ABD4
	void set_displayName(string value) { }

	// RVA: 0x144ABDC
	string get_description() { }

	// RVA: 0x144ABE4
	void set_description(string value) { }

	// RVA: 0x144ABEC
	bool get_hideInUI() { }

	// RVA: 0x144ABF4
	void set_hideInUI(bool value) { }

	// RVA: 0x144ABFC
	void .ctor() { }

}

// Namespace: 
internal struct RefInstance 
{
	// Methods

	// RVA: 0x144F660
	void Dispose() { }

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

	// RVA: 0x144AC04
	void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription) { }

	// RVA: 0x144B110
	InputDevice Finish() { }

	// RVA: 0x144B204
	void Dispose() { }

	// RVA: 0x144B134
	void Reset() { }

	// RVA: 0x144ADAC
	InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x144B328
	InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x144BB40
	void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls) { }

	// RVA: 0x144D040
	InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem, int childIndex, string nameOverride) { }

	// RVA: 0x144CD80
	void InsertChildControlOverride(InputControl parent, ref ControlItem controlItem) { }

	// RVA: 0x144DA38
	string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	// RVA: 0x144D97C
	void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref ControlItem controlItem) { }

	// RVA: 0x144DDE4
	InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref ControlItem controlItem) { }

	// RVA: 0x144CB84
	void ApplyUseStateFrom(InputControl parent, ref ControlItem controlItem, InputControlLayout layout) { }

	// RVA: 0x144E160
	void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

	// RVA: 0x144E1CC
	void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	// RVA: 0x144E434
	void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	// RVA: 0x144DBB4
	void AddProcessors(InputControl control, ref ControlItem controlItem, string layoutName) { }

	// RVA: 0x144DACC
	void SetFormat(InputControl control, ControlItem controlItem) { }

	// RVA: 0x144B2BC
	InputControlLayout FindOrLoadLayout(string name) { }

	// RVA: 0x144C254
	void ComputeStateLayout(InputControl control) { }

	// RVA: 0x144AE78
	void FinalizeControlHierarchy() { }

	// RVA: 0x144E4F0
	void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex) { }

	// RVA: 0x144E93C
	void InsertControlBitRangeNode(ref ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, UInt16 startOffset) { }

	// RVA: 0x144ED00
	UInt16 GetBestMidPoint(ControlBitRangeNode parent, UInt16 startOffset) { }

	// RVA: 0x144F3C4
	void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex) { }

	// RVA: 0x144F2A0
	void AddChildren(ref ControlBitRangeNode parent, ControlBitRangeNode left, ControlBitRangeNode right) { }

	// RVA: 0x144F50C
	UInt16 GetControlIndex(InputControl control) { }

	// RVA: 0x144F5C0
	ref InputDeviceBuilder get_instance() { }

	// RVA: 0x144F608
	RefInstance Ref() { }

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

	// RVA: 0x144F794
	string get_interfaceName() { }

	// RVA: 0x144F79C
	void set_interfaceName(string value) { }

	// RVA: 0x144F7A4
	string get_deviceClass() { }

	// RVA: 0x144F7AC
	void set_deviceClass(string value) { }

	// RVA: 0x144F7B4
	string get_manufacturer() { }

	// RVA: 0x144F7BC
	void set_manufacturer(string value) { }

	// RVA: 0x144F7C4
	string get_product() { }

	// RVA: 0x144F7CC
	void set_product(string value) { }

	// RVA: 0x144F7D4
	string get_serial() { }

	// RVA: 0x144F7DC
	void set_serial(string value) { }

	// RVA: 0x144F7E4
	string get_version() { }

	// RVA: 0x144F7EC
	void set_version(string value) { }

	// RVA: 0x144F7F4
	string get_capabilities() { }

	// RVA: 0x144F7FC
	void set_capabilities(string value) { }

	// RVA: 0x144F804
	bool get_empty() { }

	// RVA: 0x144F898
	string ToString() { }

	// RVA: 0x144FB50
	bool Equals(InputDeviceDescription other) { }

	// RVA: 0x144FC04
	bool Equals(object obj) { }

	// RVA: 0x144FCB4
	int GetHashCode() { }

	// RVA: 0x144FE0C
	bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x144FE44
	bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x144FE80
	string ToJson() { }

	// RVA: 0x144FF8C
	InputDeviceDescription FromJson(string json) { }

	// RVA: 0x1450104
	bool ComparePropertyToDeviceDescriptor(string propertyName, string propertyValue, string deviceDescriptor) { }

}

// Namespace: 
public struct Capability 
{
	// Fields
	public string path; // 0x10
	public string value; // 0x18
}

// Namespace: 
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

	// RVA: 0x145171C
	MatcherJson FromMatcher(InputDeviceMatcher matcher) { }

	// RVA: 0x1451C24
	InputDeviceMatcher ToMatcher() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Layouts.InputDeviceMatcher.<>c <>9; // 0x0
	public static System.Func<System.Char,System.Boolean> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x145233C
	void .cctor() { }

	// RVA: 0x14523A8
	void .ctor() { }

	// RVA: 0x14523B0
	bool <With>b__11_0(Char ch) { }

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

	// RVA: 0x1450248
	void .ctor(int <>1__state) { }

	// RVA: 0x145247C
	void System.IDisposable.Dispose() { }

	// RVA: 0x1452480
	bool MoveNext() { }

	// RVA: 0x14526F0
	System.Collections.Generic.KeyValuePair<System.String,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	// RVA: 0x14526FC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x145273C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x14527A4
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1452850
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x14501AC
	bool get_empty() { }

	// RVA: 0x14501BC
	System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> get_patterns() { }

	// RVA: 0x1450280
	InputDeviceMatcher WithInterface(string pattern, bool supportRegex) { }

	// RVA: 0x1450524
	InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex) { }

	// RVA: 0x14505A8
	InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex) { }

	// RVA: 0x145062C
	InputDeviceMatcher WithProduct(string pattern, bool supportRegex) { }

	// RVA: 0x14506B0
	InputDeviceMatcher WithVersion(string pattern, bool supportRegex) { }

	// RVA: 0x309AF8C
	InputDeviceMatcher WithCapability(string path, TValue value) { }

	// RVA: 0x1450304
	InputDeviceMatcher With(InternedString key, object value, bool supportRegex) { }

	// RVA: 0x1448858
	float MatchPercentage(InputDeviceDescription deviceDescription) { }

	// RVA: 0x1450734
	bool MatchSingleProperty(object pattern, string value) { }

	// RVA: 0x1450820
	int GetNumPropertiesIn(InputDeviceDescription description) { }

	// RVA: 0x14508C8
	InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	// RVA: 0x1450C58
	string ToString() { }

	// RVA: 0x145102C
	bool Equals(InputDeviceMatcher other) { }

	// RVA: 0x14513B0
	bool Equals(object obj) { }

	// RVA: 0x144A2D0
	bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x1451464
	bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x145153C
	int GetHashCode() { }

	// RVA: 0x1451554
	void .cctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class AnyKeyControl 
{
	// Methods

	// RVA: 0x1452854
	void .ctor() { }

	// RVA: 0x14529F0
	float ReadUnprocessedValueFromState(Void* statePtr) { }

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

	// RVA: 0x1452A1C
	float Preprocess(float value) { }

	// RVA: 0x1452AEC
	float Unpreprocess(float value) { }

	// RVA: 0x1452B44
	void .ctor() { }

	// RVA: 0x1452BD0
	void FinishSetup() { }

	// RVA: 0x1452CC0
	float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1452E58
	void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x1452F9C
	bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	// RVA: 0x14530A8
	float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x1453120
	float EvaluateMagnitude(float value) { }

	// RVA: 0x14531FC
	FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class ButtonControl 
{
	// Fields
	public float pressPoint; // 0x12C
	internal static float s_GlobalDefaultButtonPressPoint; // 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x4
	internal const float kMinButtonPressPoint = 953267991;

	// Methods

	// RVA: 0x1453378
	float get_pressPointOrDefault() { }

	// RVA: 0x14528D0
	void .ctor() { }

	// RVA: 0x14533EC
	bool IsValueConsideredPressed(float value) { }

	// RVA: 0x1453480
	bool get_isPressed() { }

	// RVA: 0x145352C
	bool get_wasPressedThisFrame() { }

	// RVA: 0x1453688
	bool get_wasReleasedThisFrame() { }

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

	// RVA: 0x14537E4
	AxisControl get_up() { }

	// RVA: 0x14537EC
	void set_up(AxisControl value) { }

	// RVA: 0x14537FC
	AxisControl get_down() { }

	// RVA: 0x1453804
	void set_down(AxisControl value) { }

	// RVA: 0x1453814
	AxisControl get_left() { }

	// RVA: 0x145381C
	void set_left(AxisControl value) { }

	// RVA: 0x145382C
	AxisControl get_right() { }

	// RVA: 0x1453834
	void set_right(AxisControl value) { }

	// RVA: 0x1453844
	void FinishSetup() { }

	// RVA: 0x1453A4C
	void .ctor() { }

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

	// RVA: 0x1453B64
	void FinishSetup() { }

	// RVA: 0x1453C94
	float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1453E2C
	void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x1453F8C
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class DoubleControl 
{
	// Methods

	// RVA: 0x1453F90
	void .ctor() { }

	// RVA: 0x145401C
	Double ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1454088
	void WriteValueIntoState(Double value, Void* statePtr) { }

}

// Namespace: 
public class DpadAxisControl 
{
	// Fields
	private int <component>k__BackingField; // 0x12C

	// Methods

	// RVA: 0x1454870
	int get_component() { }

	// RVA: 0x1454878
	void set_component(int value) { }

	// RVA: 0x1454880
	void FinishSetup() { }

	// RVA: 0x145490C
	float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1454A04
	void .ctor() { }

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

	// RVA: 0x1454104
	ButtonControl get_up() { }

	// RVA: 0x145410C
	void set_up(ButtonControl value) { }

	// RVA: 0x145411C
	ButtonControl get_down() { }

	// RVA: 0x1454124
	void set_down(ButtonControl value) { }

	// RVA: 0x1454134
	ButtonControl get_left() { }

	// RVA: 0x145413C
	void set_left(ButtonControl value) { }

	// RVA: 0x145414C
	ButtonControl get_right() { }

	// RVA: 0x1454154
	void set_right(ButtonControl value) { }

	// RVA: 0x1454164
	void .ctor() { }

	// RVA: 0x1454264
	void FinishSetup() { }

	// RVA: 0x1454394
	Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1454698
	void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x1454638
	Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize) { }

	// RVA: 0x1454860
	Vector2 MakeDpadVector(float up, float down, float left, float right) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class IntegerControl 
{
	// Methods

	// RVA: 0x1454A90
	void .ctor() { }

	// RVA: 0x1454B1C
	int ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1454BE0
	void WriteValueIntoState(int value, Void* statePtr) { }

	// RVA: 0x1454CAC
	FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class KeyControl 
{
	// Fields
	private Key <keyCode>k__BackingField; // 0x130
	private int m_ScanCode; // 0x134

	// Methods

	// RVA: 0x1454DD0
	Key get_keyCode() { }

	// RVA: 0x1454DD8
	void set_keyCode(Key value) { }

	// RVA: 0x1454DE0
	int get_scanCode() { }

	// RVA: 0x1454E08
	void RefreshConfiguration() { }

	// RVA: 0x1454F94
	void .ctor() { }

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

	// RVA: 0x1454F98
	AxisControl get_x() { }

	// RVA: 0x1454FA0
	void set_x(AxisControl value) { }

	// RVA: 0x1454FB0
	AxisControl get_y() { }

	// RVA: 0x1454FB8
	void set_y(AxisControl value) { }

	// RVA: 0x1454FC8
	AxisControl get_z() { }

	// RVA: 0x1454FD0
	void set_z(AxisControl value) { }

	// RVA: 0x1454FE0
	AxisControl get_w() { }

	// RVA: 0x1454FE8
	void set_w(AxisControl value) { }

	// RVA: 0x1454FF8
	void .ctor() { }

	// RVA: 0x145508C
	void FinishSetup() { }

	// RVA: 0x14551D4
	Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x145531C
	void WriteValueIntoState(Quaternion value, Void* statePtr) { }

	// RVA: 0x1455458
	FourCC CalculateOptimizedControlDataType() { }

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

	// RVA: 0x14556E0
	ButtonControl get_up() { }

	// RVA: 0x14556E8
	void set_up(ButtonControl value) { }

	// RVA: 0x14556F8
	ButtonControl get_down() { }

	// RVA: 0x1455700
	void set_down(ButtonControl value) { }

	// RVA: 0x1455710
	ButtonControl get_left() { }

	// RVA: 0x1455718
	void set_left(ButtonControl value) { }

	// RVA: 0x1455728
	ButtonControl get_right() { }

	// RVA: 0x1455730
	void set_right(ButtonControl value) { }

	// RVA: 0x1455740
	void FinishSetup() { }

	// RVA: 0x1455870
	void .ctor() { }

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

	// RVA: 0x14558FC
	TouchPressControl get_press() { }

	// RVA: 0x1455904
	void set_press(TouchPressControl value) { }

	// RVA: 0x1455914
	IntegerControl get_displayIndex() { }

	// RVA: 0x145591C
	void set_displayIndex(IntegerControl value) { }

	// RVA: 0x145592C
	IntegerControl get_touchId() { }

	// RVA: 0x1455934
	void set_touchId(IntegerControl value) { }

	// RVA: 0x1455944
	Vector2Control get_position() { }

	// RVA: 0x145594C
	void set_position(Vector2Control value) { }

	// RVA: 0x145595C
	DeltaControl get_delta() { }

	// RVA: 0x1455964
	void set_delta(DeltaControl value) { }

	// RVA: 0x1455974
	AxisControl get_pressure() { }

	// RVA: 0x145597C
	void set_pressure(AxisControl value) { }

	// RVA: 0x145598C
	Vector2Control get_radius() { }

	// RVA: 0x1455994
	void set_radius(Vector2Control value) { }

	// RVA: 0x14559A4
	TouchPhaseControl get_phase() { }

	// RVA: 0x14559AC
	void set_phase(TouchPhaseControl value) { }

	// RVA: 0x14559BC
	ButtonControl get_indirectTouch() { }

	// RVA: 0x14559C4
	void set_indirectTouch(ButtonControl value) { }

	// RVA: 0x14559D4
	ButtonControl get_tap() { }

	// RVA: 0x14559DC
	void set_tap(ButtonControl value) { }

	// RVA: 0x14559EC
	IntegerControl get_tapCount() { }

	// RVA: 0x14559F4
	void set_tapCount(IntegerControl value) { }

	// RVA: 0x1455A04
	DoubleControl get_startTime() { }

	// RVA: 0x1455A0C
	void set_startTime(DoubleControl value) { }

	// RVA: 0x1455A1C
	Vector2Control get_startPosition() { }

	// RVA: 0x1455A24
	void set_startPosition(Vector2Control value) { }

	// RVA: 0x1455A34
	bool get_isInProgress() { }

	// RVA: 0x1455AA0
	void .ctor() { }

	// RVA: 0x1455B4C
	void FinishSetup() { }

	// RVA: 0x1455EFC
	TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1455F88
	void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPhaseControl 
{
	// Methods

	// RVA: 0x1456060
	void .ctor() { }

	// RVA: 0x14560EC
	TouchPhase ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x145616C
	void WriteValueIntoState(TouchPhase value, Void* statePtr) { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class TouchPressControl 
{
	// Methods

	// RVA: 0x14561E0
	void FinishSetup() { }

	// RVA: 0x1456310
	float ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x145649C
	void WriteValueIntoState(float value, Void* statePtr) { }

	// RVA: 0x14564DC
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class Vector2Control 
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x110
	private AxisControl <y>k__BackingField; // 0x118

	// Methods

	// RVA: 0x14564E0
	AxisControl get_x() { }

	// RVA: 0x14564E8
	void set_x(AxisControl value) { }

	// RVA: 0x14564F8
	AxisControl get_y() { }

	// RVA: 0x1456500
	void set_y(AxisControl value) { }

	// RVA: 0x1453AD8
	void .ctor() { }

	// RVA: 0x1453974
	void FinishSetup() { }

	// RVA: 0x1456510
	Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x14565F8
	void WriteValueIntoState(Vector2 value, Void* statePtr) { }

	// RVA: 0x14566DC
	float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x14567B4
	FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Controls
public class Vector3Control 
{
	// Fields
	private AxisControl <x>k__BackingField; // 0x118
	private AxisControl <y>k__BackingField; // 0x120
	private AxisControl <z>k__BackingField; // 0x128

	// Methods

	// RVA: 0x145696C
	AxisControl get_x() { }

	// RVA: 0x1456974
	void set_x(AxisControl value) { }

	// RVA: 0x1456984
	AxisControl get_y() { }

	// RVA: 0x145698C
	void set_y(AxisControl value) { }

	// RVA: 0x145699C
	AxisControl get_z() { }

	// RVA: 0x14569A4
	void set_z(AxisControl value) { }

	// RVA: 0x14569B4
	void .ctor() { }

	// RVA: 0x1456A40
	void FinishSetup() { }

	// RVA: 0x1456B54
	Vector3 ReadUnprocessedValueFromState(Void* statePtr) { }

	// RVA: 0x1456C60
	void WriteValueIntoState(Vector3 value, Void* statePtr) { }

	// RVA: 0x1456D78
	float EvaluateMagnitude(Void* statePtr) { }

	// RVA: 0x1456E64
	FourCC CalculateOptimizedControlDataType() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public class HoldInteraction 
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private Double m_TimePressed; // 0x18

	// Methods

	// RVA: 0x1457064
	float get_durationOrDefault() { }

	// RVA: 0x14570D8
	float get_pressPointOrDefault() { }

	// RVA: 0x145714C
	void Process(ref InputInteractionContext context) { }

	// RVA: 0x14573F4
	void Reset() { }

	// RVA: 0x14573FC
	void .ctor() { }

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

	// RVA: 0x1457404
	float get_tapTimeOrDefault() { }

	// RVA: 0x1457478
	float get_tapDelayOrDefault() { }

	// RVA: 0x14574EC
	float get_pressPointOrDefault() { }

	// RVA: 0x1457560
	float get_releasePointOrDefault() { }

	// RVA: 0x1457628
	void Process(ref InputInteractionContext context) { }

	// RVA: 0x1457AD4
	void Reset() { }

	// RVA: 0x1457AE0
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public class PressInteraction 
{
	// Fields
	public float pressPoint; // 0x10
	public PressBehavior behavior; // 0x14
	private bool m_WaitingForRelease; // 0x18

	// Methods

	// RVA: 0x1457AF0
	float get_pressPointOrDefault() { }

	// RVA: 0x1457B64
	float get_releasePointOrDefault() { }

	// RVA: 0x1457C2C
	void Process(ref InputInteractionContext context) { }

	// RVA: 0x14581B8
	void Reset() { }

	// RVA: 0x14581C0
	void .ctor() { }

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

	// RVA: 0x14581C8
	float get_durationOrDefault() { }

	// RVA: 0x145823C
	float get_pressPointOrDefault() { }

	// RVA: 0x14582B0
	void Process(ref InputInteractionContext context) { }

	// RVA: 0x14584B0
	void Reset() { }

	// RVA: 0x14584B8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Interactions
public class TapInteraction 
{
	// Fields
	public float duration; // 0x10
	public float pressPoint; // 0x14
	private Double m_TapStartTime; // 0x18

	// Methods

	// RVA: 0x14584C0
	float get_durationOrDefault() { }

	// RVA: 0x1458534
	float get_pressPointOrDefault() { }

	// RVA: 0x14585A8
	float get_releasePointOrDefault() { }

	// RVA: 0x1458670
	void Process(ref InputInteractionContext context) { }

	// RVA: 0x1458940
	void Reset() { }

	// RVA: 0x1458948
	void .ctor() { }

}

// Namespace: 
public struct ActionEventPtr 
{
	// Fields
	internal InputActionState m_State; // 0x10
	internal ActionEvent* m_Ptr; // 0x18

	// Methods

	// RVA: 0x136DDD0
	InputAction get_action() { }

	// RVA: 0x136DDFC
	InputActionPhase get_phase() { }

	// RVA: 0x136DE08
	InputControl get_control() { }

	// RVA: 0x136DE4C
	IInputInteraction get_interaction() { }

	// RVA: 0x136DEB8
	Double get_time() { }

	// RVA: 0x136DED8
	Double get_startTime() { }

	// RVA: 0x136DEE4
	Double get_duration() { }

	// RVA: 0x136DF20
	int get_valueSizeInBytes() { }

	// RVA: 0x136DF2C
	object ReadValueAsObject() { }

	// RVA: 0x136E188
	void ReadValue(Void* buffer, int bufferSize) { }

	// RVA: 0x309AF8C
	TValue ReadValue() { }

	// RVA: 0x136E294
	string ToString() { }

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

	// RVA: 0x136E6B8
	void .ctor(InputActionTrace trace) { }

	// RVA: 0x136E708
	bool MoveNext() { }

	// RVA: 0x136E798
	void Reset() { }

	// RVA: 0x136E7A4
	void Dispose() { }

	// RVA: 0x136E7A8
	ActionEventPtr get_Current() { }

	// RVA: 0x136E830
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x1458950
	InputEventBuffer get_buffer() { }

	// RVA: 0x1458960
	int get_count() { }

	// RVA: 0x1458968
	void .ctor() { }

	// RVA: 0x1458970
	void .ctor(InputAction action) { }

	// RVA: 0x1458B30
	void .ctor(InputActionMap actionMap) { }

	// RVA: 0x1458CD0
	void SubscribeToAll() { }

	// RVA: 0x14590FC
	void UnsubscribeFromAll() { }

	// RVA: 0x14589EC
	void SubscribeTo(InputAction action) { }

	// RVA: 0x1458BAC
	void SubscribeTo(InputActionMap actionMap) { }

	// RVA: 0x1458ED4
	void UnsubscribeFrom(InputAction action) { }

	// RVA: 0x1458FF8
	void UnsubscribeFrom(InputActionMap actionMap) { }

	// RVA: 0x14592AC
	void RecordAction(CallbackContext context) { }

	// RVA: 0x145947C
	void Clear() { }

	// RVA: 0x14594DC
	void Finalize() { }

	// RVA: 0x145968C
	string ToString() { }

	// RVA: 0x1459AB4
	void Dispose() { }

	// RVA: 0x145956C
	void DisposeInternal() { }

	// RVA: 0x1459A28
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator() { }

	// RVA: 0x1459AD8
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1458DC8
	void HookOnActionChange() { }

	// RVA: 0x145923C
	void UnhookOnActionChange() { }

	// RVA: 0x1459B64
	void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	// RVA: 0x1459DE0
	void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0<T0> 
{
	// Fields
	public TValue secondValue; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	bool <Merge>b__0(TValue x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0<T0> 
{
	// Fields
	public System.Collections.Generic.IEqualityComparer<TValue> comparer; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1<T0> 
{
	// Fields
	public TValue secondValue; // 0x0
	public UnityEngine.InputSystem.Utilities.ArrayHelpers.<>c__DisplayClass34_0<TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	bool <Merge>b__0(TValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ArrayHelpers 
{
	// Methods

	// RVA: 0x2FE613C
	int LengthSafe(TValue[] array) { }

	// RVA: 0x2FE9A04
	void Clear(TValue[] array) { }

	// RVA: 0x2FE9C90
	void Clear(TValue[] array, int count) { }

	// RVA: 0x2FEAB7C
	void Clear(TValue[] array, ref int count) { }

	// RVA: -1
	void EnsureCapacity(ref TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: -1
	void DuplicateWithCapacity(ref TValue[] array, int count, int capacity, int capacityIncrement) { }

	// RVA: 0x309AF8C
	bool Contains(TValue[] array, TValue value) { }

	// RVA: 0x309AF8C
	bool ContainsReference(TValue[] array, TValue value) { }

	// RVA: 0x309AF8C
	bool ContainsReference(TFirst[] array, int count, TSecond value) { }

	// RVA: 0x309AF8C
	bool ContainsReference(TFirst[] array, int startIndex, int count, TSecond value) { }

	// RVA: -1
	bool HaveDuplicateReferences(TFirst[] first, int index, int count) { }

	// RVA: 0x2FE5A30
	bool HaveEqualElements(TValue[] first, TValue[] second, int count) { }

	// RVA: 0x309AF8C
	int IndexOf(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x2FE6628
	int IndexOf(TValue[] array, System.Predicate<TValue> predicate) { }

	// RVA: 0x2FE6690
	int IndexOf(TValue[] array, System.Predicate<TValue> predicate, int startIndex, int count) { }

	// RVA: 0x309AF8C
	int IndexOfReference(TFirst[] array, TSecond value, int count) { }

	// RVA: 0x309AF8C
	int IndexOfReference(TFirst[] array, TSecond value, int startIndex, int count) { }

	// RVA: 0x309AF8C
	int IndexOfValue(TValue[] array, TValue value, int startIndex, int count) { }

	// RVA: 0x2FE9D78
	void Resize(ref Unity.Collections.NativeArray<TValue>& array, int newSize, Allocator allocator) { }

	// RVA: 0x309AF8C
	int Append(ref TValue[] array, TValue value) { }

	// RVA: 0x2FE6628
	int Append(ref TValue[] array, System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x2FE6628
	int AppendToImmutable(ref TValue[] array, TValue[] values) { }

	// RVA: 0x309AF8C
	int AppendWithCapacity(ref TValue[] array, ref int count, TValue value, int capacityIncrement) { }

	// RVA: 0x309AF8C
	int AppendListWithCapacity(ref TValue[] array, ref int length, TValues values, int capacityIncrement) { }

	// RVA: 0x309AF8C
	int AppendWithCapacity(ref Unity.Collections.NativeArray<TValue>& array, ref int count, TValue value, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x309AF8C
	void InsertAt(ref TValue[] array, int index, TValue value) { }

	// RVA: 0x309AF8C
	void InsertAtWithCapacity(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement) { }

	// RVA: 0x2FEA0D4
	void PutAtIfNotSet(ref TValue[] array, int index, System.Func<TValue> valueFn) { }

	// RVA: -1
	int GrowBy(ref TValue[] array, int count) { }

	// RVA: 0x2FE61A0
	int GrowBy(ref Unity.Collections.NativeArray<TValue>& array, int count, Allocator allocator) { }

	// RVA: 0x2FE6690
	int GrowWithCapacity(ref TValue[] array, ref int count, int growBy, int capacityIncrement) { }

	// RVA: -1
	int GrowWithCapacity(ref Unity.Collections.NativeArray<TValue>& array, ref int count, int growBy, int capacityIncrement, Allocator allocator) { }

	// RVA: 0x309AF8C
	TValue[] Join(TValue value, TValue[] values) { }

	// RVA: 0x2FE7164
	TValue[] Merge(TValue[] first, TValue[] second) { }

	// RVA: 0x2FE72C0
	TValue[] Merge(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x2FE9C90
	void EraseAt(ref TValue[] array, int index) { }

	// RVA: 0x2FEACC4
	void EraseAtWithCapacity(TValue[] array, ref int count, int index) { }

	// RVA: 0x309AF8C
	void EraseAtWithCapacity(Unity.Collections.NativeArray<TValue> array, ref int count, int index) { }

	// RVA: 0x309AF8C
	bool Erase(ref TValue[] array, TValue value) { }

	// RVA: 0x2FEACC4
	void EraseAtByMovingTail(TValue[] array, ref int count, int index) { }

	// RVA: 0x2FE7084
	TValue[] Copy(TValue[] array) { }

	// RVA: 0x2FE7084
	TValue[] Clone(TValue[] array) { }

	// RVA: 0x2FE7164
	TNew[] Select(TOld[] array, System.Func<TOld,TNew> converter) { }

	// RVA: 0x2FEAB7C
	void Swap(ref TValue first, ref TValue second) { }

	// RVA: -1
	void MoveSlice(TValue[] array, int sourceIndex, int destinationIndex, int count) { }

	// RVA: 0x2FEAD38
	void EraseSliceWithCapacity(ref TValue[] array, ref int length, int index, int count) { }

	// RVA: 0x2FE9D78
	void SwapElements(TValue[] array, int index1, int index2) { }

	// RVA: 0x309AF8C
	void SwapElements(Unity.Collections.NativeArray<TValue> array, int index1, int index2) { }

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

	// RVA: 0x2FE32D4
	int get_length() { }

	// RVA: 0x309AF8C
	TDelegate get_Item(int index) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	void AddCallback(TDelegate dlg) { }

	// RVA: 0x309AF8C
	void RemoveCallback(TDelegate dlg) { }

	// RVA: 0x2FE41A8
	void LockForChanges() { }

	// RVA: 0x2FE41A8
	void UnlockForChanges() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector2MagnitudeComparer 
{
	// Methods

	// RVA: 0x136E904
	int Compare(Vector2 x, Vector2 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct Vector3MagnitudeComparer 
{
	// Methods

	// RVA: 0x136E92C
	int Compare(Vector3 x, Vector3 y) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class CSharpCodeHelpers 
{
	// Methods

	// RVA: 0x136E964
	bool IsProperIdentifier(string name) { }

	// RVA: 0x136EA98
	bool IsEmptyOrProperIdentifier(string name) { }

	// RVA: 0x136EAD4
	bool IsEmptyOrProperNamespaceName(string name) { }

	// RVA: 0x136EBA8
	string MakeIdentifier(string name, string suffix) { }

	// RVA: 0x136EE54
	string MakeTypeName(string name, string suffix) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class DelegateHelpers 
{
	// Methods

	// RVA: 0x136EF80
	void InvokeCallbacksSafe(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>& callbacks, string callbackName, object context) { }

	// RVA: 0x309AF8C
	void InvokeCallbacksSafe(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x309AF8C
	void InvokeCallbacksSafe(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1,TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x309AF8C
	bool InvokeCallbacksSafe_AnyCallbackReturnsTrue(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1,TValue2,System.Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context) { }

	// RVA: 0x309AF8C
	void InvokeCallbacksSafe_AndInvokeReturnedActions(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,System.Action>>& callbacks, TValue argument, string callbackName, object context) { }

	// RVA: 0x309AF8C
	bool InvokeCallbacksSafe_AnyCallbackReturnsObject(ref UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,TReturn>>& callbacks, TValue argument, string callbackName, object context) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public class DisplayStringFormatAttribute 
{
	// Fields
	private string <formatString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x136F27C
	string get_formatString() { }

	// RVA: 0x136F284
	void set_formatString(string value) { }

	// RVA: 0x136F28C
	void .ctor(string formatString) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class ExceptionHelpers 
{
	// Methods

	// RVA: 0x136F2C0
	bool IsExceptionIndicatingBugInCode(Exception exception) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct FourCC 
{
	// Fields
	private int m_Code; // 0x10

	// Methods

	// RVA: 0x136F3BC
	void .ctor(int code) { }

	// RVA: 0x136F3C4
	void .ctor(Char a, Char b, Char c, Char d) { }

	// RVA: 0x136F3DC
	void .ctor(string str) { }

	// RVA: 0x136F55C
	int op_Implicit(FourCC fourCC) { }

	// RVA: 0x136F560
	FourCC op_Implicit(int i) { }

	// RVA: 0x136F564
	string ToString() { }

	// RVA: 0x136F744
	bool Equals(FourCC other) { }

	// RVA: 0x136F754
	bool Equals(object obj) { }

	// RVA: 0x136F7E4
	int GetHashCode() { }

	// RVA: 0x136F7EC
	bool op_Equality(FourCC left, FourCC right) { }

	// RVA: 0x136F7F8
	bool op_Inequality(FourCC left, FourCC right) { }

	// RVA: 0x136F804
	FourCC FromInt32(int i) { }

	// RVA: 0x136F808
	int ToInt32(FourCC fourCC) { }

}

// Namespace: 
private struct Enumerator 
{
	// Fields
	public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	TValue get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct InlinedArray<T0> 
{
	// Fields
	public int length; // 0x0
	public TValue firstValue; // 0x0
	public TValue[] additionalValues; // 0x0

	// Methods

	// RVA: 0x2FE32D4
	int get_Capacity() { }

	// RVA: 0x309AF8C
	void .ctor(TValue value) { }

	// RVA: 0x309AF8C
	void .ctor(TValue firstValue, TValue[] additionalValues) { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x309AF8C
	TValue get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, TValue value) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x2FE41A8
	void ClearWithCapacity() { }

	// RVA: 0x309AF8C
	UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone() { }

	// RVA: 0x2FE42A4
	void SetLength(int size) { }

	// RVA: 0x2FE360C
	TValue[] ToArray() { }

	// RVA: 0x2FE36BC
	TOther[] ToArray(System.Func<TValue,TOther> mapFunction) { }

	// RVA: 0x309AF8C
	int IndexOf(TValue value) { }

	// RVA: 0x309AF8C
	int Append(TValue value) { }

	// RVA: 0x309AF8C
	int AppendWithCapacity(TValue value, int capacityIncrement) { }

	// RVA: 0x309AF8C
	void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values) { }

	// RVA: 0x2FE4574
	void Append(System.Collections.Generic.IEnumerable<TValue> values) { }

	// RVA: 0x309AF8C
	void Remove(TValue value) { }

	// RVA: 0x2FE42A4
	void RemoveAtWithCapacity(int index) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int index) { }

	// RVA: 0x2FE42A4
	void RemoveAtByMovingTailWithCapacity(int index) { }

	// RVA: 0x309AF8C
	bool RemoveByMovingTailWithCapacity(TValue value) { }

	// RVA: 0x309AF8C
	bool Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }

	// RVA: 0x309AF8C
	void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class InputArrayExtensions 
{
	// Methods

	// RVA: 0x309AF8C
	int IndexOfReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x309AF8C
	bool Contains(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

	// RVA: 0x309AF8C
	bool ContainsReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct InternedString 
{
	// Fields
	private readonly string m_StringOriginalCase; // 0x10
	private readonly string m_StringLowerCase; // 0x18

	// Methods

	// RVA: 0x136F80C
	int get_length() { }

	// RVA: 0x136F824
	void .ctor(string text) { }

	// RVA: 0x136F910
	bool IsEmpty() { }

	// RVA: 0x136F920
	string ToLower() { }

	// RVA: 0x136F928
	bool Equals(object obj) { }

	// RVA: 0x136FA50
	bool Equals(InternedString other) { }

	// RVA: 0x136FA60
	int CompareTo(InternedString other) { }

	// RVA: 0x136FA74
	int GetHashCode() { }

	// RVA: 0x136FA8C
	string ToString() { }

	// RVA: 0x136FAF8
	bool op_Equality(InternedString a, InternedString b) { }

	// RVA: 0x136FB04
	bool op_Inequality(InternedString a, InternedString b) { }

	// RVA: 0x136FB10
	bool op_Equality(InternedString a, string b) { }

	// RVA: 0x136FBC4
	bool op_Inequality(InternedString a, string b) { }

	// RVA: 0x136FC78
	bool op_Equality(string a, InternedString b) { }

	// RVA: 0x136FD28
	bool op_Inequality(string a, InternedString b) { }

	// RVA: 0x136FDD8
	bool op_LessThan(InternedString left, InternedString right) { }

	// RVA: 0x136FE00
	bool op_GreaterThan(InternedString left, InternedString right) { }

	// RVA: 0x136FE2C
	string op_Implicit(InternedString str) { }

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

	// RVA: 0x1371A10
	string ToString() { }

	// RVA: 0x1371C74
	bool Equals(JsonString other) { }

	// RVA: 0x1371E3C
	bool Equals(object obj) { }

	// RVA: 0x1371EE4
	int GetHashCode() { }

	// RVA: 0x13720A0
	bool op_Equality(JsonString left, JsonString right) { }

	// RVA: 0x13720D0
	bool op_Inequality(JsonString left, JsonString right) { }

	// RVA: 0x1372104
	JsonString op_Implicit(string str) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Utilities.JsonParser.JsonValue.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue,System.String> <>9__11_0; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>,System.String> <>9__11_1; // 0x10

	// Methods

	// RVA: 0x1373A30
	void .cctor() { }

	// RVA: 0x1373A9C
	void .ctor() { }

	// RVA: 0x1373AA4
	string <ToString>b__11_0(JsonValue x) { }

	// RVA: 0x1373AAC
	string <ToString>b__11_1(System.Collections.Generic.KeyValuePair<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> pair) { }

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

	// RVA: 0x13721E0
	bool ToBoolean() { }

	// RVA: 0x13728C8
	Int64 ToInteger() { }

	// RVA: 0x13729C4
	Double ToDouble() { }

	// RVA: 0x1372430
	string ToString() { }

	// RVA: 0x13719D8
	JsonValue op_Implicit(bool val) { }

	// RVA: 0x13718CC
	JsonValue op_Implicit(Int64 val) { }

	// RVA: 0x13718F4
	JsonValue op_Implicit(Double val) { }

	// RVA: 0x1372AB0
	JsonValue op_Implicit(string str) { }

	// RVA: 0x13717EC
	JsonValue op_Implicit(JsonString str) { }

	// RVA: 0x1371864
	JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array) { }

	// RVA: 0x1372B68
	JsonValue op_Implicit(System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj) { }

	// RVA: 0x1372BCC
	JsonValue op_Implicit(Enum val) { }

	// RVA: 0x1372C30
	bool Equals(JsonValue other) { }

	// RVA: 0x1372EA8
	bool Equals(object obj, JsonValue value) { }

	// RVA: 0x13737EC
	bool Equals(object obj) { }

	// RVA: 0x137389C
	int GetHashCode() { }

	// RVA: 0x1370A80
	bool op_Equality(JsonValue left, JsonValue right) { }

	// RVA: 0x13739F4
	bool op_Inequality(JsonValue left, JsonValue right) { }

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

	// RVA: 0x136FE98
	void .ctor(string json) { }

	// RVA: 0x136FF1C
	void Reset() { }

	// RVA: 0x136FF28
	string ToString() { }

	// RVA: 0x1370028
	bool NavigateToProperty(string path) { }

	// RVA: 0x137072C
	bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) { }

	// RVA: 0x137056C
	bool ParseToken(Char token) { }

	// RVA: 0x13706FC
	bool ParseValue() { }

	// RVA: 0x13708D4
	bool ParseValue(out JsonValue result) { }

	// RVA: 0x1370AB8
	bool ParseStringValue(out JsonValue result) { }

	// RVA: 0x1370C78
	bool ParseArrayValue(out JsonValue result) { }

	// RVA: 0x1370FBC
	bool ParseObjectValue(out JsonValue result) { }

	// RVA: 0x1371338
	bool ParseNumber(out JsonValue result) { }

	// RVA: 0x13711C4
	bool ParseBooleanValue(out JsonValue result) { }

	// RVA: 0x13712D0
	bool ParseNullValue(out JsonValue result) { }

	// RVA: 0x137068C
	bool SkipToValue() { }

	// RVA: 0x1371914
	bool SkipString(string text) { }

	// RVA: 0x13705E8
	void SkipWhitespace() { }

	// RVA: 0x1371A00
	bool get_isAtEnd() { }

}

// Namespace: 
public struct BitRegion 
{
	// Fields
	public UInt32 bitOffset; // 0x10
	public UInt32 sizeInBits; // 0x14

	// Methods

	// RVA: 0x13747E0
	bool get_isEmpty() { }

	// RVA: 0x13747F0
	void .ctor(UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x13747F8
	void .ctor(UInt32 byteOffset, UInt32 bitOffset, UInt32 sizeInBits) { }

	// RVA: 0x1374804
	BitRegion Overlap(BitRegion other) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MemoryHelpers 
{
	// Methods

	// RVA: 0x1373C74
	bool Compare(Void* ptr1, Void* ptr2, BitRegion region) { }

	// RVA: 0x1373E58
	UInt32 ComputeFollowingByteOffset(UInt32 byteOffset, UInt32 sizeInBits) { }

	// RVA: 0x1373E68
	void WriteSingleBit(Void* ptr, UInt32 bitOffset, bool value) { }

	// RVA: 0x1373CB8
	bool ReadSingleBit(Void* ptr, UInt32 bitOffset) { }

	// RVA: 0x1373E98
	void MemCpyBitRegion(Void* destination, Void* source, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x1373CD4
	bool MemCmpBitRegion(Void* ptr1, Void* ptr2, UInt32 bitOffset, UInt32 bitCount, Void* mask) { }

	// RVA: 0x1373F90
	void MemSet(Void* destination, int numBytes, Byte value) { }

	// RVA: 0x1374068
	void MemCpyMasked(Void* destination, Void* source, int numBytes, Void* mask) { }

	// RVA: 0x13740FC
	UInt32 ReadMultipleBitsAsUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x1374290
	void WriteUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, UInt32 value) { }

	// RVA: 0x1374474
	int ReadTwosComplementMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x1374478
	void WriteIntAsTwosComplementMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x137447C
	int ReadExcessKMultipleBitsAsInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x13744AC
	void WriteIntAsExcessKMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, int value) { }

	// RVA: 0x13744C0
	float ReadMultipleBitsAsNormalizedUInt(Void* ptr, UInt32 bitOffset, UInt32 bitCount) { }

	// RVA: 0x137451C
	void WriteNormalizedUIntAsMultipleBits(Void* ptr, UInt32 bitOffset, UInt32 bitCount, float value) { }

	// RVA: 0x137456C
	void SetBitsInBuffer(Void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	// RVA: 0x2FEAB7C
	void Swap(ref TValue a, ref TValue b) { }

	// RVA: 0x1374758
	UInt32 AlignNatural(UInt32 offset, UInt32 sizeInBytes) { }

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

	// RVA: 0x2FE42A4
	void .ctor(int <>1__state) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void <>m__Finally1() { }

	// RVA: 0x309AF8C
	TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class MiscHelpers 
{
	// Methods

	// RVA: 0x309AF8C
	TValue GetValueOrDefault(System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key) { }

	// RVA: -1
	System.Collections.Generic.IEnumerable<TValue> EveryNth(System.Collections.Generic.IEnumerable<TValue> enumerable, int n, int start) { }

	// RVA: 0x309AF8C
	int IndexOf(System.Collections.Generic.IEnumerable<TValue> enumerable, TValue value) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Utilities.NameAndParameters.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.NamedValue,System.String> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x1375498
	void .cctor() { }

	// RVA: 0x1375504
	void .ctor() { }

	// RVA: 0x137550C
	string <ToString>b__8_0(NamedValue x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct NameAndParameters 
{
	// Fields
	private string <name>k__BackingField; // 0x10
	private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13748DC
	string get_name() { }

	// RVA: 0x13748E4
	void set_name(string value) { }

	// RVA: 0x13748EC
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }

	// RVA: 0x13748F8
	void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }

	// RVA: 0x1374904
	string ToString() { }

	// RVA: 0x1374B14
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text) { }

	// RVA: 0x1374C2C
	bool ParseMultiple(string text, ref System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>& list) { }

	// RVA: 0x137519C
	string ParseName(string text) { }

	// RVA: 0x1375220
	NameAndParameters Parse(string text) { }

	// RVA: 0x1374DDC
	NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct NamedValue 
{
	// Fields
	public const string Separator = 5736712224;
	private string <name>k__BackingField; // 0x10
	private PrimitiveValue <value>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1375634
	string get_name() { }

	// RVA: 0x137563C
	void set_name(string value) { }

	// RVA: 0x1375644
	PrimitiveValue get_value() { }

	// RVA: 0x1375650
	void set_value(PrimitiveValue value) { }

	// RVA: 0x1375658
	TypeCode get_type() { }

	// RVA: 0x1375660
	NamedValue ConvertTo(TypeCode type) { }

	// RVA: 0x309AF8C
	NamedValue From(string name, TValue value) { }

	// RVA: 0x13755A0
	string ToString() { }

	// RVA: 0x1375E6C
	bool Equals(NamedValue other) { }

	// RVA: 0x1375F64
	bool Equals(object obj) { }

	// RVA: 0x1376064
	int GetHashCode() { }

	// RVA: 0x1376138
	bool op_Equality(NamedValue left, NamedValue right) { }

	// RVA: 0x13761D8
	bool op_Inequality(NamedValue left, NamedValue right) { }

	// RVA: 0x13752B4
	NamedValue[] ParseMultiple(string parameterString) { }

	// RVA: 0x137667C
	NamedValue Parse(string str) { }

	// RVA: 0x1376304
	NamedValue ParseParameter(string parameterString, ref int index) { }

	// RVA: 0x1376A2C
	void ApplyToObject(object instance) { }

	// RVA: 0x309AF8C
	void ApplyAllToObject(object instance, TParameterList parameters) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class NumberHelpers 
{
	// Methods

	// RVA: 0x1376EB0
	int AlignToMultipleOf(int number, int alignment) { }

	// RVA: 0x1376ECC
	Int64 AlignToMultipleOf(Int64 number, Int64 alignment) { }

	// RVA: 0x1376EE8
	UInt32 AlignToMultipleOf(UInt32 number, UInt32 alignment) { }

	// RVA: 0x1376F04
	bool Approximately(Double a, Double b) { }

	// RVA: 0x1376FA4
	float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	// RVA: 0x1376FDC
	int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	// RVA: 0x137702C
	float UIntToNormalizedFloat(UInt32 value, UInt32 minValue, UInt32 maxValue) { }

	// RVA: 0x1377064
	UInt32 NormalizedFloatToUInt(float value, UInt32 uintMinValue, UInt32 uintMaxValue) { }

	// RVA: 0x13770AC
	UInt32 RemapUIntBitsToNormalizeFloatToUIntBits(UInt32 value, UInt32 inBitSize, UInt32 outBitSize) { }

}

// Namespace: 
private class ForDevice 
{
	// Fields
	private System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer; // 0x10
	private InputDevice m_Device; // 0x18
	private Type m_DeviceType; // 0x20

	// Methods

	// RVA: 0x13772A0
	void .ctor(Type deviceType, InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

	// RVA: 0x1377304
	void OnCompleted() { }

	// RVA: 0x1377308
	void OnError(Exception error) { }

	// RVA: 0x1377390
	void OnNext(InputEventPtr value) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class ForDeviceEventObservable 
{
	// Fields
	private System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source; // 0x10
	private InputDevice m_Device; // 0x18
	private Type m_DeviceType; // 0x20

	// Methods

	// RVA: 0x1377124
	void .ctor(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, Type deviceType, InputDevice device) { }

	// RVA: 0x1377188
	IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0> 
{
	// Fields
	public IDisposable subscription; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void <CallOnce>b__0() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class Observable 
{
	// Methods

	// RVA: 0x2FE7164
	System.IObservable<TValue> Where(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x2FE7164
	System.IObservable<TResult> Select(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }

	// RVA: 0x2FE7164
	System.IObservable<TResult> SelectMany(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: -1
	System.IObservable<TValue> Take(System.IObservable<TValue> source, int count) { }

	// RVA: 0x1377568
	System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, InputDevice device) { }

	// RVA: 0x2FE7084
	System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source) { }

	// RVA: 0x2FE7164
	IDisposable CallOnce(System.IObservable<TValue> source, System.Action<TValue> action) { }

	// RVA: 0x2FE7164
	IDisposable Call(System.IObservable<TValue> source, System.Action<TValue> action) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class Observer<T0> 
{
	// Fields
	private System.Action<TValue> m_OnNext; // 0x0
	private Action m_OnCompleted; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(System.Action<TValue> onNext, Action onCompleted) { }

	// RVA: 0x2FE41A8
	void OnCompleted() { }

	// RVA: 0x2FE4574
	void OnError(Exception error) { }

	// RVA: 0x309AF8C
	void OnNext(TValue evt) { }

}

// Namespace: 
private class Select 
{
	// Fields
	private UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> m_Observable; // 0x0
	private readonly System.IObserver<TResult> m_Observer; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }

	// RVA: 0x2FE41A8
	void OnCompleted() { }

	// RVA: 0x2FE4574
	void OnError(Exception error) { }

	// RVA: 0x309AF8C
	void OnNext(TSource evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class SelectManyObservable<T0, T1> 
{
	// Fields
	private readonly System.IObservable<TSource> m_Source; // 0x0
	private readonly System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> m_Filter; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }

	// RVA: 0x2FE36BC
	IDisposable Subscribe(System.IObserver<TResult> observer) { }

}

// Namespace: 
private class Take 
{
	// Fields
	private System.IObserver<TValue> m_Observer; // 0x0
	private int m_Remaining; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x2FE41A8
	void OnCompleted() { }

	// RVA: 0x2FE4574
	void OnError(Exception error) { }

	// RVA: 0x309AF8C
	void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class TakeNObservable<T0> 
{
	// Fields
	private System.IObservable<TValue> m_Source; // 0x0
	private int m_Count; // 0x0

	// Methods

	// RVA: 0x2FE45DC
	void .ctor(System.IObservable<TValue> source, int count) { }

	// RVA: 0x2FE36BC
	IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Where 
{
	// Fields
	private UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable; // 0x0
	private readonly System.IObserver<TValue> m_Observer; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer) { }

	// RVA: 0x2FE41A8
	void OnCompleted() { }

	// RVA: 0x2FE4574
	void OnError(Exception error) { }

	// RVA: 0x309AF8C
	void OnNext(TValue evt) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal class WhereObservable<T0> 
{
	// Fields
	private readonly System.IObservable<TValue> m_Source; // 0x0
	private readonly System.Func<TValue,System.Boolean> m_Predicate; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }

	// RVA: 0x2FE36BC
	IDisposable Subscribe(System.IObserver<TValue> observer) { }

}

// Namespace: 
private class Enumerator 
{
	// Fields
	internal int m_Index; // 0x0
	internal UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> m_List; // 0x0

	// Methods

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	TValue get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct OneOrMore<T0, T1> 
{
	// Fields
	private readonly bool m_IsSingle; // 0x0
	private readonly TValue m_Single; // 0x0
	private readonly TList m_Multiple; // 0x0

	// Methods

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x309AF8C
	TValue get_Item(int index) { }

	// RVA: 0x309AF8C
	void .ctor(TValue single) { }

	// RVA: 0x309AF8C
	void .ctor(TList multiple) { }

	// RVA: 0x309AF8C
	UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TValue single) { }

	// RVA: 0x309AF8C
	UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TList multiple) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct PredictiveParser 
{
	// Fields
	private int m_Position; // 0x10

	// Methods

	// RVA: 0x137764C
	void ExpectSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x1377758
	int ExpectInt(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x137787C
	System.ReadOnlySpan<System.Char> ExpectString(System.ReadOnlySpan<System.Char> str) { }

	// RVA: 0x1377AC4
	bool AcceptSingleChar(System.ReadOnlySpan<System.Char> str, Char c) { }

	// RVA: 0x1377B00
	bool AcceptString(System.ReadOnlySpan<System.Char> input, out System.ReadOnlySpan<System.Char>& output) { }

	// RVA: 0x1377C6C
	void AcceptInt(System.ReadOnlySpan<System.Char> str) { }

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

	// RVA: 0x1377CCC
	Byte* get_valuePtr() { }

	// RVA: 0x1377CD4
	TypeCode get_type() { }

	// RVA: 0x1377CDC
	bool get_isEmpty() { }

	// RVA: 0x1377CEC
	void .ctor(bool value) { }

	// RVA: 0x1377D04
	void .ctor(Char value) { }

	// RVA: 0x1377D1C
	void .ctor(Byte value) { }

	// RVA: 0x1377D34
	void .ctor(SByte value) { }

	// RVA: 0x1377D4C
	void .ctor(Int16 value) { }

	// RVA: 0x1377D64
	void .ctor(UInt16 value) { }

	// RVA: 0x1377D7C
	void .ctor(int value) { }

	// RVA: 0x1377D8C
	void .ctor(UInt32 value) { }

	// RVA: 0x1377D9C
	void .ctor(Int64 value) { }

	// RVA: 0x1377DB0
	void .ctor(UInt64 value) { }

	// RVA: 0x1377DC4
	void .ctor(float value) { }

	// RVA: 0x1377DD8
	void .ctor(Double value) { }

	// RVA: 0x13756CC
	PrimitiveValue ConvertTo(TypeCode type) { }

	// RVA: 0x137869C
	bool Equals(PrimitiveValue other) { }

	// RVA: 0x13786F4
	bool Equals(object obj) { }

	// RVA: 0x1375F08
	bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x1378EA0
	bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	// RVA: 0x13760EC
	int GetHashCode() { }

	// RVA: 0x1378EFC
	string ToString() { }

	// RVA: 0x13766DC
	PrimitiveValue FromString(string value) { }

	// RVA: 0x1379358
	TypeCode GetTypeCode() { }

	// RVA: 0x1377DEC
	bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x137803C
	Byte ToByte(IFormatProvider provider) { }

	// RVA: 0x1377FB8
	Char ToChar(IFormatProvider provider) { }

	// RVA: 0x1379360
	DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x13793B4
	Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x13785B8
	Double ToDouble(IFormatProvider provider) { }

	// RVA: 0x13781B8
	Int16 ToInt16(IFormatProvider provider) { }

	// RVA: 0x1378284
	int ToInt32(IFormatProvider provider) { }

	// RVA: 0x1378334
	Int64 ToInt64(IFormatProvider provider) { }

	// RVA: 0x13780F8
	SByte ToSByte(IFormatProvider provider) { }

	// RVA: 0x13784AC
	float ToSingle(IFormatProvider provider) { }

	// RVA: 0x13794D0
	string ToString(IFormatProvider provider) { }

	// RVA: 0x13794D4
	object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1379514
	UInt16 ToUInt16(IFormatProvider provider) { }

	// RVA: 0x13795BC
	UInt32 ToUInt32(IFormatProvider provider) { }

	// RVA: 0x13783F8
	UInt64 ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1376CB4
	object ToObject() { }

	// RVA: 0x309AF8C
	PrimitiveValue From(TValue value) { }

	// RVA: 0x1378950
	PrimitiveValue FromObject(object value) { }

	// RVA: 0x13766C0
	PrimitiveValue op_Implicit(bool value) { }

	// RVA: 0x137802C
	PrimitiveValue op_Implicit(Char value) { }

	// RVA: 0x13780E8
	PrimitiveValue op_Implicit(Byte value) { }

	// RVA: 0x13781A4
	PrimitiveValue op_Implicit(SByte value) { }

	// RVA: 0x1378270
	PrimitiveValue op_Implicit(Int16 value) { }

	// RVA: 0x137964C
	PrimitiveValue op_Implicit(UInt16 value) { }

	// RVA: 0x1378324
	PrimitiveValue op_Implicit(int value) { }

	// RVA: 0x137965C
	PrimitiveValue op_Implicit(UInt32 value) { }

	// RVA: 0x13783DC
	PrimitiveValue op_Implicit(Int64 value) { }

	// RVA: 0x1378490
	PrimitiveValue op_Implicit(UInt64 value) { }

	// RVA: 0x13785A4
	PrimitiveValue op_Implicit(float value) { }

	// RVA: 0x1378680
	PrimitiveValue op_Implicit(Double value) { }

	// RVA: 0x137966C
	PrimitiveValue FromBoolean(bool value) { }

	// RVA: 0x1379688
	PrimitiveValue FromChar(Char value) { }

	// RVA: 0x1379698
	PrimitiveValue FromByte(Byte value) { }

	// RVA: 0x13796A8
	PrimitiveValue FromSByte(SByte value) { }

	// RVA: 0x13796BC
	PrimitiveValue FromInt16(Int16 value) { }

	// RVA: 0x13796D0
	PrimitiveValue FromUInt16(UInt16 value) { }

	// RVA: 0x13796E0
	PrimitiveValue FromInt32(int value) { }

	// RVA: 0x13796F0
	PrimitiveValue FromUInt32(UInt32 value) { }

	// RVA: 0x1379700
	PrimitiveValue FromInt64(Int64 value) { }

	// RVA: 0x137971C
	PrimitiveValue FromUInt64(UInt64 value) { }

	// RVA: 0x1379738
	PrimitiveValue FromSingle(float value) { }

	// RVA: 0x137974C
	PrimitiveValue FromDouble(Double value) { }

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
	void .ctor(TValue[] array, int index, int length) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	TValue get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public struct ReadOnlyArray<T0> 
{
	// Fields
	internal TValue[] m_Array; // 0x0
	internal int m_StartIndex; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(TValue[] array) { }

	// RVA: -1
	void .ctor(TValue[] array, int index, int length) { }

	// RVA: 0x2FE360C
	TValue[] ToArray() { }

	// RVA: 0x2FE3404
	int IndexOf(System.Predicate<TValue> predicate) { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x309AF8C
	TValue get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
public static class ReadOnlyArrayExtensions 
{
	// Methods

	// RVA: 0x309AF8C
	bool Contains(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x309AF8C
	bool ContainsReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x309AF8C
	int IndexOfReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }

	// RVA: 0x309AF8C
	bool HaveEqualReferences(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, System.Collections.Generic.IReadOnlyList<TValue> array2, int count) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal interface ISavedState 
{
	// Methods

	// RVA: 0x2FE41A8
	void StaticDisposeCurrentState() { }

	// RVA: 0x2FE41A8
	void RestoreSavedState() { }

}

// Namespace: 
public sealed class TypedRestore 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x2FE4574
	internal void Invoke(ref T state) { }

	// RVA: 0x2FE3810
	internal IAsyncResult BeginInvoke(ref T state, AsyncCallback callback, object object) { }

	// RVA: 0x2FE47D4
	internal void EndInvoke(ref T state, IAsyncResult result) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal sealed class SavedStructState<T0> 
{
	// Fields
	private T m_State; // 0x0
	private TypedRestore m_RestoreAction; // 0x0
	private Action m_StaticDisposeCurrentState; // 0x0

	// Methods

	// RVA: 0x2FE49A8
	void .ctor(ref T state, TypedRestore restoreAction, Action staticDisposeCurrentState) { }

	// RVA: 0x2FE41A8
	void StaticDisposeCurrentState() { }

	// RVA: 0x2FE41A8
	void RestoreSavedState() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class SpriteUtilities 
{
	// Methods

	// RVA: 0x1379768
	Sprite CreateCircleSprite(int radius, Color32 colour) { }

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

	// RVA: 0x137A52C
	void .ctor(int <>1__state) { }

	// RVA: 0x137B15C
	void System.IDisposable.Dispose() { }

	// RVA: 0x137B160
	bool MoveNext() { }

	// RVA: 0x137B2D0
	string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	// RVA: 0x137B2D8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x137B318
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x137B320
	System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x137B3D8
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x137A458
	void .ctor(int <>1__state) { }

	// RVA: 0x137B3DC
	void System.IDisposable.Dispose() { }

	// RVA: 0x137B3E0
	bool MoveNext() { }

	// RVA: 0x137B694
	Substring System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring>.get_Current() { }

	// RVA: 0x137B6A0
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x137B6E0
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x137B748
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.Substring> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring>.GetEnumerator() { }

	// RVA: 0x137B7F0
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class StringHelpers 
{
	// Methods

	// RVA: 0x1379994
	string Escape(string str, string chars, string replacements) { }

	// RVA: 0x1379BB0
	string Unescape(string str, string chars, string replacements) { }

	// RVA: 0x1379EA4
	bool Contains(string str, Char ch) { }

	// RVA: 0x1379EC8
	bool Contains(string str, string text, StringComparison comparison) { }

	// RVA: 0x1379EEC
	string GetPlural(string str) { }

	// RVA: 0x137A0B8
	string NicifyMemorySize(Int64 numBytes) { }

	// RVA: 0x137A23C
	bool FromNicifiedMemorySize(string text, out Int64 result, Int64 defaultMultiplier) { }

	// RVA: 0x1376280
	int CountOccurrences(string str, Char ch) { }

	// RVA: 0x137A3D0
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(string str) { }

	// RVA: 0x137A490
	System.Collections.Generic.IEnumerable<System.String> Split(string str, System.Func<System.Char,System.Boolean> predicate) { }

	// RVA: 0x2FE7164
	string Join(string separator, TValue[] values) { }

	// RVA: 0x2FE7164
	string Join(System.Collections.Generic.IEnumerable<TValue> values, string separator) { }

	// RVA: 0x2FE72C0
	string MakeUniqueName(string baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting,System.String> getNameFunc) { }

	// RVA: 0x137A564
	bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, Char separator) { }

	// RVA: 0x137A8A0
	int ParseInt(string str, int pos) { }

	// RVA: 0x137A944
	bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) { }

	// RVA: 0x137A968
	bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref UInt32 offset) { }

	// RVA: 0x137AB34
	string ReadStringFromBuffer(IntPtr buffer, int bufferSize) { }

	// RVA: 0x137AB58
	string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref UInt32 offset) { }

	// RVA: 0x137AC90
	bool IsPrintable(Char ch) { }

	// RVA: 0x137AD4C
	string WithAllWhitespaceStripped(string str) { }

	// RVA: 0x137AEB8
	bool InvariantEqualsIgnoreCase(string left, string right) { }

	// RVA: 0x137AF08
	string ExpandTemplateString(string template, System.Func<System.String,System.String> mapFunc) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct Substring 
{
	// Fields
	private readonly string m_String; // 0x10
	private readonly int m_Index; // 0x18
	private readonly int m_Length; // 0x1C

	// Methods

	// RVA: 0x137B7F4
	bool get_isEmpty() { }

	// RVA: 0x137B804
	void .ctor(string str) { }

	// RVA: 0x13717B4
	void .ctor(string str, int index, int length) { }

	// RVA: 0x137B850
	void .ctor(string str, int index) { }

	// RVA: 0x137B89C
	bool Equals(object obj) { }

	// RVA: 0x137B9D8
	bool Equals(string other) { }

	// RVA: 0x137B988
	bool Equals(Substring other) { }

	// RVA: 0x137BAE8
	bool Equals(InternedString other) { }

	// RVA: 0x137BAB0
	int CompareTo(Substring other) { }

	// RVA: 0x1371E14
	int Compare(Substring left, Substring right, StringComparison comparison) { }

	// RVA: 0x137BBB8
	bool StartsWith(string str) { }

	// RVA: 0x137BC64
	string Substr(int index, int length) { }

	// RVA: 0x1371B7C
	string ToString() { }

	// RVA: 0x1371FF4
	int GetHashCode() { }

	// RVA: 0x137BC9C
	bool op_Equality(Substring a, Substring b) { }

	// RVA: 0x137BCD8
	bool op_Inequality(Substring a, Substring b) { }

	// RVA: 0x137BD14
	bool op_Equality(Substring a, InternedString b) { }

	// RVA: 0x137BDE0
	bool op_Inequality(Substring a, InternedString b) { }

	// RVA: 0x137BEAC
	bool op_Equality(InternedString a, Substring b) { }

	// RVA: 0x137BF78
	bool op_Inequality(InternedString a, Substring b) { }

	// RVA: 0x137217C
	Substring op_Implicit(string s) { }

	// RVA: 0x137C044
	int get_length() { }

	// RVA: 0x137C04C
	int get_index() { }

	// RVA: 0x1371BE8
	Char get_Item(int index) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal static class TypeHelpers 
{
	// Methods

	// RVA: 0x309AF8C
	TObject As(object obj) { }

	// RVA: 0x137C054
	bool IsInt(TypeCode type) { }

	// RVA: 0x137C064
	Type GetValueType(MemberInfo member) { }

	// RVA: 0x137C274
	string GetNiceTypeName(Type type) { }

	// RVA: 0x137C7B4
	Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.InputSystem.Utilities.TypeTable.<>c <>9; // 0x0
	public static System.Func<UnityEngine.InputSystem.Utilities.InternedString,System.String> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x137D43C
	void .cctor() { }

	// RVA: 0x137D4A8
	void .ctor() { }

	// RVA: 0x137D4B0
	string <get_names>b__2_0(InternedString x) { }

}

// Namespace: UnityEngine.InputSystem.Utilities
internal struct TypeTable 
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table; // 0x10

	// Methods

	// RVA: 0x137CBA8
	System.Collections.Generic.IEnumerable<System.String> get_names() { }

	// RVA: 0x137CCF0
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames() { }

	// RVA: 0x137CD44
	void Initialize() { }

	// RVA: 0x137CDC4
	InternedString FindNameForType(Type type) { }

	// RVA: 0x137D1BC
	void AddTypeRegistration(string name, Type type) { }

	// RVA: 0x137D338
	Type LookupTypeRegistration(string name) { }

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

	// RVA: 0x137D51C
	float get_midPoint() { }

	// RVA: 0x137D530
	float ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x137D674
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137D6CC
	void .ctor() { }

}

// Namespace: UnityEngine.InputSystem.Composites
public class ButtonWithOneModifier 
{
	// Fields
	public int modifier; // 0x10
	public int button; // 0x14
	public bool overrideModifiersNeedToBePressedFirst; // 0x18

	// Methods

	// RVA: 0x137D72C
	float ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x137D7F4
	bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x137D878
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137D884
	void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x137D908
	void .ctor() { }

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

	// RVA: 0x137D95C
	float ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DA58
	bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DB0C
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DB18
	void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DB9C
	void .ctor() { }

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

	// RVA: 0x137DBF0
	Type get_valueType() { }

	// RVA: 0x137DBF8
	int get_valueSizeInBytes() { }

	// RVA: 0x137DC00
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DD38
	void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x137DC98
	bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DDF4
	void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E34C
	object ReadValueAsObject(ref InputBindingCompositeContext context) { }

	// RVA: 0x137DEA0
	void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton) { }

	// RVA: 0x137E39C
	void .ctor() { }

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

	// RVA: 0x137E3A4
	Type get_valueType() { }

	// RVA: 0x137E3AC
	int get_valueSizeInBytes() { }

	// RVA: 0x137E3B4
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E4C8
	void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	// RVA: 0x137E3F8
	bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E530
	void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E5DC
	object ReadValueAsObject(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E640
	void .ctor() { }

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

	// RVA: 0x137E648
	Vector2 ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E7C4
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137E858
	void .ctor() { }

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

	// RVA: 0x137E8B4
	Vector3 ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x137EB54
	float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x137EBFC
	void .ctor() { }

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


