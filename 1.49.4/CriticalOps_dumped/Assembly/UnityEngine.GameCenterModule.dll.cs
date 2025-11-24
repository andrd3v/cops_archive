// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class Social
{
	// Methods

	// RVA: 0x160A8CC
	public static ISocialPlatform get_Active() { }

	// RVA: 0x160A9AC
	public static ILocalUser get_localUser() { }

}

// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform
{
	// Fields
	private static ISocialPlatform _active; // 0x0

	// Methods

	// RVA: 0x160A8D0
	internal static ISocialPlatform get_Instance() { }

	// RVA: 0x160AA60
	private static ISocialPlatform SelectSocialPlatform() { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ISocialPlatform
{
	// Methods

	// RVA: -1
	public abstract ILocalUser get_localUser() { }

	// RVA: -1
	public abstract void Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: -1
	public abstract void Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: -1
	public abstract void LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ILocalUser
{
	// Methods

	// RVA: -1
	public abstract void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: -1
	public abstract bool get_authenticated() { }

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

	// RVA: 0x160AAC0
	public void .ctor(int fromValue, int valueCount) { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ILeaderboard
{
	// Methods

	// RVA: -1
	public abstract string get_id() { }

	// RVA: -1
	public abstract UserScope get_userScope() { }

	// RVA: -1
	public abstract Range get_range() { }

	// RVA: -1
	public abstract TimeScope get_timeScope() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class LocalUser
{
	// Fields
	private IUserProfile[] m_Friends; // 0x40
	private bool m_Authenticated; // 0x48
	private bool m_Underage; // 0x49

	// Methods

	// RVA: 0x160AAC8
	public void .ctor() { }

	// RVA: 0x160AC28
	public void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x160ACE8
	public void SetFriends(IUserProfile[] friends) { }

	// RVA: 0x160ACF0
	public void SetAuthenticated(bool value) { }

	// RVA: 0x160ACF8
	public void SetUnderage(bool value) { }

	// RVA: 0x160AD00
	public bool get_authenticated() { }

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

	// RVA: 0x160AB3C
	public void .ctor() { }

	// RVA: 0x160AD08
	public void .ctor(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image) { }

	// RVA: 0x160ADA0
	public override string ToString() { }

	// RVA: 0x160AF98
	public void SetUserName(string name) { }

	// RVA: 0x160AFA0
	public void SetUserID(string id) { }

	// RVA: 0x160AFA8
	public void SetLegacyUserID(string id) { }

	// RVA: 0x160AFB0
	public void SetUserGameID(string id) { }

	// RVA: 0x160AFB8
	public void SetImage(Texture2D image) { }

	// RVA: 0x160AF80
	public string get_userName() { }

	// RVA: 0x160AF78
	public string get_id() { }

	// RVA: 0x160AF88
	public bool get_isFriend() { }

	// RVA: 0x160AF90
	public UserState get_state() { }

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

	// RVA: 0x160AFC0
	public void .ctor(string id, Double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate) { }

	// RVA: 0x160B030
	public void .ctor(string id, Double percent) { }

	// RVA: 0x160B0D4
	public void .ctor() { }

	// RVA: 0x160B194
	public override string ToString() { }

	// RVA: 0x160B3E8
	public string get_id() { }

	// RVA: 0x160B3F0
	public void set_id(string value) { }

	// RVA: 0x160B3F8
	public Double get_percentCompleted() { }

	// RVA: 0x160B400
	public void set_percentCompleted(Double value) { }

	// RVA: 0x160B3D0
	public bool get_completed() { }

	// RVA: 0x160B3D8
	public bool get_hidden() { }

	// RVA: 0x160B3E0
	public DateTime get_lastReportedDate() { }

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

	// RVA: 0x160B408
	public void .ctor(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points) { }

	// RVA: 0x160B4B8
	public override string ToString() { }

	// RVA: 0x160B718
	public void SetImage(Texture2D image) { }

	// RVA: 0x160B720
	public string get_id() { }

	// RVA: 0x160B728
	public void set_id(string value) { }

	// RVA: 0x160B6F0
	public string get_title() { }

	// RVA: 0x160B6F8
	public string get_achievedDescription() { }

	// RVA: 0x160B700
	public string get_unachievedDescription() { }

	// RVA: 0x160B710
	public bool get_hidden() { }

	// RVA: 0x160B708
	public int get_points() { }

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

	// RVA: 0x160B730
	public void .ctor(string leaderboardID, Int64 value) { }

	// RVA: 0x160B824
	public void .ctor(string leaderboardID, Int64 value, string userID, DateTime date, string formattedValue, int rank) { }

	// RVA: 0x160B8B4
	public override string ToString() { }

	// RVA: 0x160BB1C
	public string get_leaderboardID() { }

	// RVA: 0x160BB24
	public void set_leaderboardID(string value) { }

	// RVA: 0x160BB2C
	public Int64 get_value() { }

	// RVA: 0x160BB34
	public void set_value(Int64 value) { }

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

	// RVA: 0x160BB3C
	public void .ctor() { }

	// RVA: 0x160BC74
	public override string ToString() { }

	// RVA: 0x160C138
	public void SetLocalUserScore(IScore score) { }

	// RVA: 0x160C140
	public void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x160C148
	public void SetScores(IScore[] scores) { }

	// RVA: 0x160C150
	public void SetTitle(string title) { }

	// RVA: 0x160C158
	public string[] GetUserFilter() { }

	// RVA: 0x160C160
	public string get_id() { }

	// RVA: 0x160C168
	public void set_id(string value) { }

	// RVA: 0x160C170
	public UserScope get_userScope() { }

	// RVA: 0x160C178
	public void set_userScope(UserScope value) { }

	// RVA: 0x160C180
	public Range get_range() { }

	// RVA: 0x160C188
	public void set_range(Range value) { }

	// RVA: 0x160C190
	public TimeScope get_timeScope() { }

	// RVA: 0x160C198
	public void set_timeScope(TimeScope value) { }

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

	// RVA: 0x160C1A0
	public UserProfile ToUserProfile() { }

	// RVA: 0x160C270
	public void AddToArray(UserProfile[] array, int number) { }

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

	// RVA: 0x160C368
	public AchievementDescription ToAchievementDescription() { }

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

	// RVA: 0x160C454
	public Achievement ToAchievement() { }

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

	// RVA: 0x160C57C
	public Score ToScore() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public System.Action<System.Boolean> callback; // 0x10

	// Methods

	// RVA: 0x160D9D4
	public void .ctor() { }

	// RVA: 0x160FA28
	internal void <UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate>b__0(bool success, string error) { }

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

	// RVA: 0x160C6C8
	private static void ClearAchievementDescriptions(int size) { }

	// RVA: 0x160C7D0
	private static void SetAchievementDescription(GcAchievementDescriptionData data, int number) { }

	// RVA: 0x160C8B0
	private static void SetAchievementDescriptionImage(Texture2D texture, int number) { }

	// RVA: 0x160C9E0
	private static void TriggerAchievementDescriptionCallback(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x160CB00
	private static void AuthenticateCallbackWrapper(int result, string error) { }

	// RVA: 0x160CE4C
	private static void ClearFriends(int size) { }

	// RVA: 0x160CFD0
	private static void SetFriends(GcUserProfileData data, int number) { }

	// RVA: 0x160D044
	private static void SetFriendImage(Texture2D texture, int number) { }

	// RVA: 0x160D1F8
	private static void TriggerFriendsCallbackWrapper(System.Action<System.Boolean> callback, int result) { }

	// RVA: 0x160D2E0
	private static void AchievementCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback, GcAchievementData[] result) { }

	// RVA: 0x160D480
	private static void ProgressCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x160D4B8
	private static void ScoreCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x160D4F0
	private static void ScoreLoaderCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IScore[]> callback, GcScoreData[] result) { }

	// RVA: 0x160D628
	private void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x160D88C
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x160D9DC
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x160DAC0
	public ILocalUser get_localUser() { }

	// RVA: 0x160CC20
	private static void PopulateLocalUser() { }

	// RVA: 0x160DE80
	public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x160DFE0
	public void ReportProgress(string id, Double progress, System.Action<System.Boolean> callback) { }

	// RVA: 0x160E140
	public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback) { }

	// RVA: 0x160E2A0
	public void ReportScore(Int64 score, string board, System.Action<System.Boolean> callback) { }

	// RVA: 0x160E3F8
	public void LoadScores(string category, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback) { }

	// RVA: 0x160E57C
	public void LoadScores(ILeaderboard board, System.Action<System.Boolean> callback) { }

	// RVA: 0x160EA1C
	private static void LeaderboardCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x160EA54
	public bool GetLoading(ILeaderboard board) { }

	// RVA: 0x160D720
	private bool VerifyAuthentication() { }

	// RVA: 0x160EE34
	public void ShowAchievementsUI() { }

	// RVA: 0x160EF20
	public void ShowLeaderboardUI() { }

	// RVA: 0x160F00C
	private static void ClearUsers(int size) { }

	// RVA: 0x160F104
	private static void SetUser(GcUserProfileData data, int number) { }

	// RVA: 0x160F178
	private static void SetUserImage(Texture2D texture, int number) { }

	// RVA: 0x160F1EC
	private static void TriggerUsersCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x160F268
	public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x160D0B8
	private static void SafeSetUserImage(UserProfile[] array, Texture2D texture, int number) { }

	// RVA: 0x160CF44
	private static void SafeClearArray(UserProfile[] array, int size) { }

	// RVA: 0x160F3EC
	public ILeaderboard CreateLeaderboard() { }

	// RVA: 0x160F440
	public IAchievement CreateAchievement() { }

	// RVA: 0x160F534
	private static void TriggerResetAchievementCallback(bool result) { }

	// RVA: 0x160DA80
	internal static void Authenticate() { }

	// RVA: 0x160DCC0
	internal static bool GetAuthenticated() { }

	// RVA: 0x160DD00
	internal static string Internal_UserName() { }

	// RVA: 0x160DD40
	internal static string Internal_UserID() { }

	// RVA: 0x160DD80
	internal static string Internal_UserGameID() { }

	// RVA: 0x160DDC0
	internal static string Internal_LegacyUserID() { }

	// RVA: 0x160DE00
	internal static bool GetIsUnderage() { }

	// RVA: 0x160DE40
	internal static Texture2D GetUserImage() { }

	// RVA: 0x160D83C
	internal static void LoadFriends(object callback) { }

	// RVA: 0x160DF90
	internal static void InternalLoadAchievementDescriptions(object callback) { }

	// RVA: 0x160E250
	internal static void InternalLoadAchievements(object callback) { }

	// RVA: 0x160E0E0
	internal static void InternalReportProgress(string id, Double progress, object callback) { }

	// RVA: 0x160E3A0
	internal static void InternalReportScore(Int64 score, string category, object callback) { }

	// RVA: 0x160E514
	internal static void InternalLoadScores(string category, object callback) { }

	// RVA: 0x160EEE0
	internal static void Internal_ShowAchievementsUI() { }

	// RVA: 0x160EFCC
	internal static void Internal_ShowLeaderboardUI() { }

	// RVA: 0x160F384
	internal static void Internal_LoadUsers(string[] userIds, object callback) { }

	// RVA: 0x160F60C
	internal static void ResetAllAchievements() { }

	// RVA: 0x160F64C
	internal static void ShowDefaultAchievementBanner(bool value) { }

	// RVA: 0x160F69C
	public static void ResetAllAchievements(System.Action<System.Boolean> callback) { }

	// RVA: 0x160F738
	public static void ShowDefaultAchievementCompletionBanner(bool value) { }

	// RVA: 0x160F7E4
	public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope) { }

	// RVA: 0x160F89C
	internal static void ShowSpecificLeaderboardUI(string leaderboardID, int timeScope) { }

	// RVA: 0x160AAB8
	public void .ctor() { }

	// RVA: 0x160F904
	private static void .cctor() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal class GcLeaderboard
{
	// Fields
	private IntPtr m_InternalLeaderboard; // 0x10
	private Leaderboard m_GenericLeaderboard; // 0x18

	// Methods

	// RVA: 0x160E948
	internal void .ctor(Leaderboard board) { }

	// RVA: 0x160FA64
	protected override void Finalize() { }

	// RVA: 0x160EDD4
	internal bool Contains(Leaderboard board) { }

	// RVA: 0x160FB80
	internal void SetScores(GcScoreData[] scoreDatas) { }

	// RVA: 0x160FCBC
	internal void SetLocalScore(GcScoreData scoreData) { }

	// RVA: 0x160FCFC
	internal void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x160FD0C
	internal void SetTitle(string title) { }

	// RVA: 0x160E97C
	internal void Internal_LoadScores(string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x160FD20
	private static IntPtr GcLeaderboard_LoadScores(object self, string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x160EDE4
	internal bool Loading() { }

	// RVA: 0x160FDB8
	private static bool GcLeaderboard_Loading(IntPtr leaderboard) { }

	// RVA: 0x160FB2C
	internal void Dispose() { }

	// RVA: 0x160FE08
	private static void GcLeaderboard_Dispose(IntPtr leaderboard) { }

}


