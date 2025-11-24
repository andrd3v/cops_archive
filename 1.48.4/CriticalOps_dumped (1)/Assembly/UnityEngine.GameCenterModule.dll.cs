// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public static class Social 
{
	// Methods

	// RVA: 0x15260C0
	ISocialPlatform get_Active() { }

	// RVA: 0x15261A0
	ILocalUser get_localUser() { }

}

// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform 
{
	// Fields
	private static ISocialPlatform _active; // 0x0

	// Methods

	// RVA: 0x15260C4
	ISocialPlatform get_Instance() { }

	// RVA: 0x1526254
	ISocialPlatform SelectSocialPlatform() { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ISocialPlatform 
{
	// Methods

	// RVA: 0x2FE360C
	ILocalUser get_localUser() { }

	// RVA: 0x2FE47D4
	void Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x2FE47D4
	void Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x2FE47D4
	void LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ILocalUser 
{
	// Methods

	// RVA: 0x2FE4574
	void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x2FE3054
	bool get_authenticated() { }

}

// Namespace: UnityEngine.SocialPlatforms
public enum UserState 
{
	// Fields
	public int value__; // 0x10
	public const UserState Online = 0;
	public const UserState OnlineAndAway = 1;
	public const UserState OnlineAndBusy = 2;
	public const UserState Offline = 3;
	public const UserState Playing = 4;
}

// Namespace: UnityEngine.SocialPlatforms
public interface IUserProfile 
{}

// Namespace: UnityEngine.SocialPlatforms
public interface IAchievement 
{}

// Namespace: UnityEngine.SocialPlatforms
public interface IAchievementDescription 
{}

// Namespace: UnityEngine.SocialPlatforms
public interface IScore 
{}

// Namespace: UnityEngine.SocialPlatforms
public enum UserScope 
{
	// Fields
	public int value__; // 0x10
	public const UserScope Global = 0;
	public const UserScope FriendsOnly = 1;
}

// Namespace: UnityEngine.SocialPlatforms
public enum TimeScope 
{
	// Fields
	public int value__; // 0x10
	public const TimeScope Today = 0;
	public const TimeScope Week = 1;
	public const TimeScope AllTime = 2;
}

// Namespace: UnityEngine.SocialPlatforms
public struct Range 
{
	// Fields
	public int from; // 0x10
	public int count; // 0x14

	// Methods

	// RVA: 0x15262B4
	void .ctor(int fromValue, int valueCount) { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ILeaderboard 
{
	// Methods

	// RVA: 0x2FE360C
	string get_id() { }

	// RVA: 0x2FE32D4
	UserScope get_userScope() { }

	// RVA: -1
	Range get_range() { }

	// RVA: 0x2FE32D4
	TimeScope get_timeScope() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class LocalUser 
{
	// Fields
	private IUserProfile[] m_Friends; // 0x40
	private bool m_Authenticated; // 0x48
	private bool m_Underage; // 0x49

	// Methods

	// RVA: 0x15262BC
	void .ctor() { }

	// RVA: 0x152641C
	void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x15264DC
	void SetFriends(IUserProfile[] friends) { }

	// RVA: 0x15264E4
	void SetAuthenticated(bool value) { }

	// RVA: 0x15264EC
	void SetUnderage(bool value) { }

	// RVA: 0x15264F4
	bool get_authenticated() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class UserProfile 
{
	// Fields
	protected string m_UserName; // 0x10
	protected string m_ID; // 0x18
	private string m_legacyID; // 0x20
	protected bool m_IsFriend; // 0x28
	protected UserState m_State; // 0x2C
	protected Texture2D m_Image; // 0x30
	private string m_gameID; // 0x38

	// Methods

	// RVA: 0x1526330
	void .ctor() { }

	// RVA: 0x15264FC
	void .ctor(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image) { }

	// RVA: 0x1526594
	string ToString() { }

	// RVA: 0x152678C
	void SetUserName(string name) { }

	// RVA: 0x1526794
	void SetUserID(string id) { }

	// RVA: 0x152679C
	void SetLegacyUserID(string id) { }

	// RVA: 0x15267A4
	void SetUserGameID(string id) { }

	// RVA: 0x15267AC
	void SetImage(Texture2D image) { }

	// RVA: 0x1526774
	string get_userName() { }

	// RVA: 0x152676C
	string get_id() { }

	// RVA: 0x152677C
	bool get_isFriend() { }

	// RVA: 0x1526784
	UserState get_state() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class Achievement 
{
	// Fields
	private bool m_Completed; // 0x10
	private bool m_Hidden; // 0x11
	private DateTime m_LastReportedDate; // 0x18
	private string <id>k__BackingField; // 0x20
	private Double <percentCompleted>k__BackingField; // 0x28

	// Methods

	// RVA: 0x15267B4
	void .ctor(string id, Double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate) { }

	// RVA: 0x1526824
	void .ctor(string id, Double percent) { }

	// RVA: 0x15268C8
	void .ctor() { }

	// RVA: 0x1526988
	string ToString() { }

	// RVA: 0x1526BDC
	string get_id() { }

	// RVA: 0x1526BE4
	void set_id(string value) { }

	// RVA: 0x1526BEC
	Double get_percentCompleted() { }

	// RVA: 0x1526BF4
	void set_percentCompleted(Double value) { }

	// RVA: 0x1526BC4
	bool get_completed() { }

	// RVA: 0x1526BCC
	bool get_hidden() { }

	// RVA: 0x1526BD4
	DateTime get_lastReportedDate() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class AchievementDescription 
{
	// Fields
	private string m_Title; // 0x10
	private Texture2D m_Image; // 0x18
	private string m_AchievedDescription; // 0x20
	private string m_UnachievedDescription; // 0x28
	private bool m_Hidden; // 0x30
	private int m_Points; // 0x34
	private string <id>k__BackingField; // 0x38

	// Methods

	// RVA: 0x1526BFC
	void .ctor(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points) { }

	// RVA: 0x1526CAC
	string ToString() { }

	// RVA: 0x1526F0C
	void SetImage(Texture2D image) { }

	// RVA: 0x1526F14
	string get_id() { }

	// RVA: 0x1526F1C
	void set_id(string value) { }

	// RVA: 0x1526EE4
	string get_title() { }

	// RVA: 0x1526EEC
	string get_achievedDescription() { }

	// RVA: 0x1526EF4
	string get_unachievedDescription() { }

	// RVA: 0x1526F04
	bool get_hidden() { }

	// RVA: 0x1526EFC
	int get_points() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class Score 
{
	// Fields
	private DateTime m_Date; // 0x10
	private string m_FormattedValue; // 0x18
	private string m_UserID; // 0x20
	private int m_Rank; // 0x28
	private string <leaderboardID>k__BackingField; // 0x30
	private Int64 <value>k__BackingField; // 0x38

	// Methods

	// RVA: 0x1526F24
	void .ctor(string leaderboardID, Int64 value) { }

	// RVA: 0x1527018
	void .ctor(string leaderboardID, Int64 value, string userID, DateTime date, string formattedValue, int rank) { }

	// RVA: 0x15270A8
	string ToString() { }

	// RVA: 0x1527310
	string get_leaderboardID() { }

	// RVA: 0x1527318
	void set_leaderboardID(string value) { }

	// RVA: 0x1527320
	Int64 get_value() { }

	// RVA: 0x1527328
	void set_value(Int64 value) { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class Leaderboard 
{
	// Fields
	private bool m_Loading; // 0x10
	private IScore m_LocalUserScore; // 0x18
	private UInt32 m_MaxRange; // 0x20
	private IScore[] m_Scores; // 0x28
	private string m_Title; // 0x30
	private string[] m_UserIDs; // 0x38
	private string <id>k__BackingField; // 0x40
	private UserScope <userScope>k__BackingField; // 0x48
	private Range <range>k__BackingField; // 0x4C
	private TimeScope <timeScope>k__BackingField; // 0x54

	// Methods

	// RVA: 0x1527330
	void .ctor() { }

	// RVA: 0x1527468
	string ToString() { }

	// RVA: 0x152792C
	void SetLocalUserScore(IScore score) { }

	// RVA: 0x1527934
	void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x152793C
	void SetScores(IScore[] scores) { }

	// RVA: 0x1527944
	void SetTitle(string title) { }

	// RVA: 0x152794C
	string[] GetUserFilter() { }

	// RVA: 0x1527954
	string get_id() { }

	// RVA: 0x152795C
	void set_id(string value) { }

	// RVA: 0x1527964
	UserScope get_userScope() { }

	// RVA: 0x152796C
	void set_userScope(UserScope value) { }

	// RVA: 0x1527974
	Range get_range() { }

	// RVA: 0x152797C
	void set_range(Range value) { }

	// RVA: 0x1527984
	TimeScope get_timeScope() { }

	// RVA: 0x152798C
	void set_timeScope(TimeScope value) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcUserProfileData 
{
	// Fields
	public string userName; // 0x10
	public string teamID; // 0x18
	public string gameID; // 0x20
	public int isFriend; // 0x28
	public Texture2D image; // 0x30

	// Methods

	// RVA: 0x1527994
	UserProfile ToUserProfile() { }

	// RVA: 0x1527A64
	void AddToArray(ref UserProfile[] array, int number) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcAchievementDescriptionData 
{
	// Fields
	public string m_Identifier; // 0x10
	public string m_Title; // 0x18
	public Texture2D m_Image; // 0x20
	public string m_AchievedDescription; // 0x28
	public string m_UnachievedDescription; // 0x30
	public int m_Hidden; // 0x38
	public int m_Points; // 0x3C

	// Methods

	// RVA: 0x1527B5C
	AchievementDescription ToAchievementDescription() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcAchievementData 
{
	// Fields
	public string m_Identifier; // 0x10
	public Double m_PercentCompleted; // 0x18
	public int m_Completed; // 0x20
	public int m_Hidden; // 0x24
	public int m_LastReportedDate; // 0x28

	// Methods

	// RVA: 0x1527C48
	Achievement ToAchievement() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcScoreData 
{
	// Fields
	public string m_Category; // 0x10
	public UInt32 m_ValueLow; // 0x18
	public int m_ValueHigh; // 0x1C
	public int m_Date; // 0x20
	public string m_FormattedValue; // 0x28
	public string m_PlayerID; // 0x30
	public int m_Rank; // 0x38

	// Methods

	// RVA: 0x1527D70
	Score ToScore() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0 
{
	// Fields
	public System.Action<System.Boolean> callback; // 0x10

	// Methods

	// RVA: 0x15291C8
	void .ctor() { }

	// RVA: 0x152B21C
	void <UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate>b__0(bool success, string error) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
public class GameCenterPlatform 
{
	// Fields
	private static System.Action<System.Boolean,System.String> s_AuthenticateCallback; // 0x0
	private static AchievementDescription[] s_adCache; // 0x8
	private static UserProfile[] s_friends; // 0x10
	private static UserProfile[] s_users; // 0x18
	private static System.Action<System.Boolean> s_ResetAchievements; // 0x20
	private static LocalUser m_LocalUser; // 0x28
	private static System.Collections.Generic.List<UnityEngine.SocialPlatforms.GameCenter.GcLeaderboard> m_GcBoards; // 0x30

	// Methods

	// RVA: 0x1527EBC
	void ClearAchievementDescriptions(int size) { }

	// RVA: 0x1527FC4
	void SetAchievementDescription(GcAchievementDescriptionData data, int number) { }

	// RVA: 0x15280A4
	void SetAchievementDescriptionImage(Texture2D texture, int number) { }

	// RVA: 0x15281D4
	void TriggerAchievementDescriptionCallback(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x15282F4
	void AuthenticateCallbackWrapper(int result, string error) { }

	// RVA: 0x1528640
	void ClearFriends(int size) { }

	// RVA: 0x15287C4
	void SetFriends(GcUserProfileData data, int number) { }

	// RVA: 0x1528838
	void SetFriendImage(Texture2D texture, int number) { }

	// RVA: 0x15289EC
	void TriggerFriendsCallbackWrapper(System.Action<System.Boolean> callback, int result) { }

	// RVA: 0x1528AD4
	void AchievementCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback, GcAchievementData[] result) { }

	// RVA: 0x1528C74
	void ProgressCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x1528CAC
	void ScoreCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x1528CE4
	void ScoreLoaderCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IScore[]> callback, GcScoreData[] result) { }

	// RVA: 0x1528E1C
	void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x1529080
	void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x15291D0
	void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x15292B4
	ILocalUser get_localUser() { }

	// RVA: 0x1528414
	void PopulateLocalUser() { }

	// RVA: 0x1529674
	void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x15297D4
	void ReportProgress(string id, Double progress, System.Action<System.Boolean> callback) { }

	// RVA: 0x1529934
	void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback) { }

	// RVA: 0x1529A94
	void ReportScore(Int64 score, string board, System.Action<System.Boolean> callback) { }

	// RVA: 0x1529BEC
	void LoadScores(string category, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback) { }

	// RVA: 0x1529D70
	void LoadScores(ILeaderboard board, System.Action<System.Boolean> callback) { }

	// RVA: 0x152A210
	void LeaderboardCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x152A248
	bool GetLoading(ILeaderboard board) { }

	// RVA: 0x1528F14
	bool VerifyAuthentication() { }

	// RVA: 0x152A628
	void ShowAchievementsUI() { }

	// RVA: 0x152A714
	void ShowLeaderboardUI() { }

	// RVA: 0x152A800
	void ClearUsers(int size) { }

	// RVA: 0x152A8F8
	void SetUser(GcUserProfileData data, int number) { }

	// RVA: 0x152A96C
	void SetUserImage(Texture2D texture, int number) { }

	// RVA: 0x152A9E0
	void TriggerUsersCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x152AA5C
	void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x15288AC
	void SafeSetUserImage(ref UserProfile[] array, Texture2D texture, int number) { }

	// RVA: 0x1528738
	void SafeClearArray(ref UserProfile[] array, int size) { }

	// RVA: 0x152ABE0
	ILeaderboard CreateLeaderboard() { }

	// RVA: 0x152AC34
	IAchievement CreateAchievement() { }

	// RVA: 0x152AD28
	void TriggerResetAchievementCallback(bool result) { }

	// RVA: 0x1529274
	void Authenticate() { }

	// RVA: 0x15294B4
	bool GetAuthenticated() { }

	// RVA: 0x15294F4
	string Internal_UserName() { }

	// RVA: 0x1529534
	string Internal_UserID() { }

	// RVA: 0x1529574
	string Internal_UserGameID() { }

	// RVA: 0x15295B4
	string Internal_LegacyUserID() { }

	// RVA: 0x15295F4
	bool GetIsUnderage() { }

	// RVA: 0x1529634
	Texture2D GetUserImage() { }

	// RVA: 0x1529030
	void LoadFriends(object callback) { }

	// RVA: 0x1529784
	void InternalLoadAchievementDescriptions(object callback) { }

	// RVA: 0x1529A44
	void InternalLoadAchievements(object callback) { }

	// RVA: 0x15298D4
	void InternalReportProgress(string id, Double progress, object callback) { }

	// RVA: 0x1529B94
	void InternalReportScore(Int64 score, string category, object callback) { }

	// RVA: 0x1529D08
	void InternalLoadScores(string category, object callback) { }

	// RVA: 0x152A6D4
	void Internal_ShowAchievementsUI() { }

	// RVA: 0x152A7C0
	void Internal_ShowLeaderboardUI() { }

	// RVA: 0x152AB78
	void Internal_LoadUsers(string[] userIds, object callback) { }

	// RVA: 0x152AE00
	void ResetAllAchievements() { }

	// RVA: 0x152AE40
	void ShowDefaultAchievementBanner(bool value) { }

	// RVA: 0x152AE90
	void ResetAllAchievements(System.Action<System.Boolean> callback) { }

	// RVA: 0x152AF2C
	void ShowDefaultAchievementCompletionBanner(bool value) { }

	// RVA: 0x152AFD8
	void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope) { }

	// RVA: 0x152B090
	void ShowSpecificLeaderboardUI(string leaderboardID, int timeScope) { }

	// RVA: 0x15262AC
	void .ctor() { }

	// RVA: 0x152B0F8
	void .cctor() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal class GcLeaderboard 
{
	// Fields
	private IntPtr m_InternalLeaderboard; // 0x10
	private Leaderboard m_GenericLeaderboard; // 0x18

	// Methods

	// RVA: 0x152A13C
	void .ctor(Leaderboard board) { }

	// RVA: 0x152B258
	void Finalize() { }

	// RVA: 0x152A5C8
	bool Contains(Leaderboard board) { }

	// RVA: 0x152B374
	void SetScores(GcScoreData[] scoreDatas) { }

	// RVA: 0x152B4B0
	void SetLocalScore(GcScoreData scoreData) { }

	// RVA: 0x152B4F0
	void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x152B500
	void SetTitle(string title) { }

	// RVA: 0x152A170
	void Internal_LoadScores(string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x152B514
	IntPtr GcLeaderboard_LoadScores(object self, string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x152A5D8
	bool Loading() { }

	// RVA: 0x152B5AC
	bool GcLeaderboard_Loading(IntPtr leaderboard) { }

	// RVA: 0x152B320
	void Dispose() { }

	// RVA: 0x152B5FC
	void GcLeaderboard_Dispose(IntPtr leaderboard) { }

}


