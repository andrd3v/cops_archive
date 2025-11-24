// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class Social
{
	// Methods

	// RVA: 0x16BD5C4
	public static ISocialPlatform get_Active() { }

	// RVA: 0x16BD6A4
	public static ILocalUser get_localUser() { }

}

// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform
{
	// Fields
	private static ISocialPlatform _active; // 0x0

	// Methods

	// RVA: 0x16BD5C8
	internal static ISocialPlatform get_Instance() { }

	// RVA: 0x16BD758
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

	// RVA: 0x16BD7B8
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

	// RVA: 0x16BD7C0
	public void .ctor() { }

	// RVA: 0x16BD920
	public void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x16BD9E0
	public void SetFriends(IUserProfile[] friends) { }

	// RVA: 0x16BD9E8
	public void SetAuthenticated(bool value) { }

	// RVA: 0x16BD9F0
	public void SetUnderage(bool value) { }

	// RVA: 0x16BD9F8
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

	// RVA: 0x16BD834
	public void .ctor() { }

	// RVA: 0x16BDA00
	public void .ctor(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image) { }

	// RVA: 0x16BDA98
	public override string ToString() { }

	// RVA: 0x16BDC84
	public void SetUserName(string name) { }

	// RVA: 0x16BDC8C
	public void SetUserID(string id) { }

	// RVA: 0x16BDC94
	public void SetLegacyUserID(string id) { }

	// RVA: 0x16BDC9C
	public void SetUserGameID(string id) { }

	// RVA: 0x16BDCA4
	public void SetImage(Texture2D image) { }

	// RVA: 0x16BDC6C
	public string get_userName() { }

	// RVA: 0x16BDC64
	public string get_id() { }

	// RVA: 0x16BDC74
	public bool get_isFriend() { }

	// RVA: 0x16BDC7C
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

	// RVA: 0x16BDCAC
	public void .ctor(string id, Double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate) { }

	// RVA: 0x16BDD1C
	public void .ctor(string id, Double percent) { }

	// RVA: 0x16BDDC0
	public void .ctor() { }

	// RVA: 0x16BDE80
	public override string ToString() { }

	// RVA: 0x16BE0C8
	public string get_id() { }

	// RVA: 0x16BE0D0
	public void set_id(string value) { }

	// RVA: 0x16BE0D8
	public Double get_percentCompleted() { }

	// RVA: 0x16BE0E0
	public void set_percentCompleted(Double value) { }

	// RVA: 0x16BE0B0
	public bool get_completed() { }

	// RVA: 0x16BE0B8
	public bool get_hidden() { }

	// RVA: 0x16BE0C0
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

	// RVA: 0x16BE0E8
	public void .ctor(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points) { }

	// RVA: 0x16BE198
	public override string ToString() { }

	// RVA: 0x16BE3EC
	public void SetImage(Texture2D image) { }

	// RVA: 0x16BE3F4
	public string get_id() { }

	// RVA: 0x16BE3FC
	public void set_id(string value) { }

	// RVA: 0x16BE3C4
	public string get_title() { }

	// RVA: 0x16BE3CC
	public string get_achievedDescription() { }

	// RVA: 0x16BE3D4
	public string get_unachievedDescription() { }

	// RVA: 0x16BE3E4
	public bool get_hidden() { }

	// RVA: 0x16BE3DC
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

	// RVA: 0x16BE404
	public void .ctor(string leaderboardID, Int64 value) { }

	// RVA: 0x16BE4F8
	public void .ctor(string leaderboardID, Int64 value, string userID, DateTime date, string formattedValue, int rank) { }

	// RVA: 0x16BE588
	public override string ToString() { }

	// RVA: 0x16BE7F0
	public string get_leaderboardID() { }

	// RVA: 0x16BE7F8
	public void set_leaderboardID(string value) { }

	// RVA: 0x16BE800
	public Int64 get_value() { }

	// RVA: 0x16BE808
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

	// RVA: 0x16BE810
	public void .ctor() { }

	// RVA: 0x16BE948
	public override string ToString() { }

	// RVA: 0x16BEE00
	public void SetLocalUserScore(IScore score) { }

	// RVA: 0x16BEE08
	public void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x16BEE10
	public void SetScores(IScore[] scores) { }

	// RVA: 0x16BEE18
	public void SetTitle(string title) { }

	// RVA: 0x16BEE20
	public string[] GetUserFilter() { }

	// RVA: 0x16BEE28
	public string get_id() { }

	// RVA: 0x16BEE30
	public void set_id(string value) { }

	// RVA: 0x16BEE38
	public UserScope get_userScope() { }

	// RVA: 0x16BEE40
	public void set_userScope(UserScope value) { }

	// RVA: 0x16BEE48
	public Range get_range() { }

	// RVA: 0x16BEE50
	public void set_range(Range value) { }

	// RVA: 0x16BEE58
	public TimeScope get_timeScope() { }

	// RVA: 0x16BEE60
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

	// RVA: 0x16BEE68
	public UserProfile ToUserProfile() { }

	// RVA: 0x16BEF38
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

	// RVA: 0x16BF030
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

	// RVA: 0x16BF11C
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

	// RVA: 0x16BF244
	public Score ToScore() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public System.Action<System.Boolean> callback; // 0x10

	// Methods

	// RVA: 0x16C06A0
	public void .ctor() { }

	// RVA: 0x16C31D4
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

	// RVA: 0x16BF390
	private static void ClearAchievementDescriptions(int size) { }

	// RVA: 0x16BF498
	private static void SetAchievementDescription(GcAchievementDescriptionData data, int number) { }

	// RVA: 0x16BF578
	private static void SetAchievementDescriptionImage(Texture2D texture, int number) { }

	// RVA: 0x16BF6A8
	private static void TriggerAchievementDescriptionCallback(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x16BF7C8
	private static void AuthenticateCallbackWrapper(int result, string error) { }

	// RVA: 0x16BFB18
	private static void ClearFriends(int size) { }

	// RVA: 0x16BFC9C
	private static void SetFriends(GcUserProfileData data, int number) { }

	// RVA: 0x16BFD10
	private static void SetFriendImage(Texture2D texture, int number) { }

	// RVA: 0x16BFEC4
	private static void TriggerFriendsCallbackWrapper(System.Action<System.Boolean> callback, int result) { }

	// RVA: 0x16BFFAC
	private static void AchievementCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback, GcAchievementData[] result) { }

	// RVA: 0x16C014C
	private static void ProgressCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x16C0184
	private static void ScoreCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x16C01BC
	private static void ScoreLoaderCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IScore[]> callback, GcScoreData[] result) { }

	// RVA: 0x16C02F4
	private void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x16C0558
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x16C06A8
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x16C078C
	public ILocalUser get_localUser() { }

	// RVA: 0x16BF8E8
	private static void PopulateLocalUser() { }

	// RVA: 0x16C0F28
	public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x16C1088
	public void ReportProgress(string id, Double progress, System.Action<System.Boolean> callback) { }

	// RVA: 0x16C1318
	public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback) { }

	// RVA: 0x16C1478
	public void ReportScore(Int64 score, string board, System.Action<System.Boolean> callback) { }

	// RVA: 0x16C1700
	public void LoadScores(string category, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback) { }

	// RVA: 0x16C19A0
	public void LoadScores(ILeaderboard board, System.Action<System.Boolean> callback) { }

	// RVA: 0x16C1DA4
	private static void LeaderboardCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x16C1DDC
	public bool GetLoading(ILeaderboard board) { }

	// RVA: 0x16C03EC
	private bool VerifyAuthentication() { }

	// RVA: 0x16C21BC
	public void ShowAchievementsUI() { }

	// RVA: 0x16C22A8
	public void ShowLeaderboardUI() { }

	// RVA: 0x16C2394
	private static void ClearUsers(int size) { }

	// RVA: 0x16C248C
	private static void SetUser(GcUserProfileData data, int number) { }

	// RVA: 0x16C2500
	private static void SetUserImage(Texture2D texture, int number) { }

	// RVA: 0x16C2574
	private static void TriggerUsersCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x16C25F0
	public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x16BFD84
	private static void SafeSetUserImage(UserProfile[] array, Texture2D texture, int number) { }

	// RVA: 0x16BFC10
	private static void SafeClearArray(UserProfile[] array, int size) { }

	// RVA: 0x16C2774
	public ILeaderboard CreateLeaderboard() { }

	// RVA: 0x16C27C8
	public IAchievement CreateAchievement() { }

	// RVA: 0x16C28BC
	private static void TriggerResetAchievementCallback(bool result) { }

	// RVA: 0x16C074C
	internal static void Authenticate() { }

	// RVA: 0x16C098C
	internal static bool GetAuthenticated() { }

	// RVA: 0x16C09CC
	internal static string Internal_UserName() { }

	// RVA: 0x16C0AE4
	internal static string Internal_UserID() { }

	// RVA: 0x16C0BFC
	internal static string Internal_UserGameID() { }

	// RVA: 0x16C0D14
	internal static string Internal_LegacyUserID() { }

	// RVA: 0x16C0E2C
	internal static bool GetIsUnderage() { }

	// RVA: 0x16C0E6C
	internal static Texture2D GetUserImage() { }

	// RVA: 0x16C0508
	internal static void LoadFriends(object callback) { }

	// RVA: 0x16C1038
	internal static void InternalLoadAchievementDescriptions(object callback) { }

	// RVA: 0x16C1428
	internal static void InternalLoadAchievements(object callback) { }

	// RVA: 0x16C1158
	internal static void InternalReportProgress(string id, Double progress, object callback) { }

	// RVA: 0x16C1548
	internal static void InternalReportScore(Int64 score, string category, object callback) { }

	// RVA: 0x16C17F0
	internal static void InternalLoadScores(string category, object callback) { }

	// RVA: 0x16C2268
	internal static void Internal_ShowAchievementsUI() { }

	// RVA: 0x16C2354
	internal static void Internal_ShowLeaderboardUI() { }

	// RVA: 0x16C270C
	internal static void Internal_LoadUsers(string[] userIds, object callback) { }

	// RVA: 0x16C2C34
	internal static void ResetAllAchievements() { }

	// RVA: 0x16C2C74
	internal static void ShowDefaultAchievementBanner(bool value) { }

	// RVA: 0x16C2CC4
	public static void ResetAllAchievements(System.Action<System.Boolean> callback) { }

	// RVA: 0x16C2D60
	public static void ShowDefaultAchievementCompletionBanner(bool value) { }

	// RVA: 0x16C2E0C
	public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope) { }

	// RVA: 0x16C2E98
	internal static void ShowSpecificLeaderboardUI(string leaderboardID, int timeScope) { }

	// RVA: 0x16BD7B0
	public void .ctor() { }

	// RVA: 0x16C30B0
	private static void .cctor() { }

	// RVA: 0x16C2994
	private static void Internal_UserName_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16C29E4
	private static void Internal_UserID_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16C2A34
	private static void Internal_UserGameID_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16C2A84
	private static void Internal_LegacyUserID_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16C2AD4
	private static IntPtr GetUserImage_Injected() { }

	// RVA: 0x16C2B14
	private static void InternalReportProgress_Injected(ManagedSpanWrapper id, Double progress, object callback) { }

	// RVA: 0x16C2B74
	private static void InternalReportScore_Injected(Int64 score, ManagedSpanWrapper category, object callback) { }

	// RVA: 0x16C2BCC
	private static void InternalLoadScores_Injected(ManagedSpanWrapper category, object callback) { }

	// RVA: 0x16C3048
	private static void ShowSpecificLeaderboardUI_Injected(ManagedSpanWrapper leaderboardID, int timeScope) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal class GcLeaderboard
{
	// Fields
	private IntPtr m_InternalLeaderboard; // 0x10
	private Leaderboard m_GenericLeaderboard; // 0x18

	// Methods

	// RVA: 0x16C1D44
	internal void .ctor(Leaderboard board) { }

	// RVA: 0x16C3210
	protected override void Finalize() { }

	// RVA: 0x16C215C
	internal bool Contains(Leaderboard board) { }

	// RVA: 0x16C332C
	internal void SetScores(GcScoreData[] scoreDatas) { }

	// RVA: 0x16C3468
	internal void SetLocalScore(GcScoreData scoreData) { }

	// RVA: 0x16C34A8
	internal void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x16C34B8
	internal void SetTitle(string title) { }

	// RVA: 0x16C1D78
	internal void Internal_LoadScores(string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x16C34CC
	private static IntPtr GcLeaderboard_LoadScores(object self, string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x16C216C
	internal bool Loading() { }

	// RVA: 0x16C3738
	private static bool GcLeaderboard_Loading(IntPtr leaderboard) { }

	// RVA: 0x16C32D8
	internal void Dispose() { }

	// RVA: 0x16C3788
	private static void GcLeaderboard_Dispose(IntPtr leaderboard) { }

	// RVA: 0x16C36A0
	private static IntPtr GcLeaderboard_LoadScores_Injected(object self, ManagedSpanWrapper category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

}


