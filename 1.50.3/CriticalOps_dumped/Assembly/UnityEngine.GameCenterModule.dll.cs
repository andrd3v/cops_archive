// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class Social
{
	// Methods

	// RVA: 0x163CCC0
	public static ISocialPlatform get_Active() { }

	// RVA: 0x163CDA0
	public static ILocalUser get_localUser() { }

}

// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform
{
	// Fields
	private static ISocialPlatform _active; // 0x0

	// Methods

	// RVA: 0x163CCC4
	internal static ISocialPlatform get_Instance() { }

	// RVA: 0x163CE54
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

	// RVA: 0x163CEB4
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

	// RVA: 0x163CEBC
	public void .ctor() { }

	// RVA: 0x163D01C
	public void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x163D0DC
	public void SetFriends(IUserProfile[] friends) { }

	// RVA: 0x163D0E4
	public void SetAuthenticated(bool value) { }

	// RVA: 0x163D0EC
	public void SetUnderage(bool value) { }

	// RVA: 0x163D0F4
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

	// RVA: 0x163CF30
	public void .ctor() { }

	// RVA: 0x163D0FC
	public void .ctor(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image) { }

	// RVA: 0x163D194
	public override string ToString() { }

	// RVA: 0x163D38C
	public void SetUserName(string name) { }

	// RVA: 0x163D394
	public void SetUserID(string id) { }

	// RVA: 0x163D39C
	public void SetLegacyUserID(string id) { }

	// RVA: 0x163D3A4
	public void SetUserGameID(string id) { }

	// RVA: 0x163D3AC
	public void SetImage(Texture2D image) { }

	// RVA: 0x163D374
	public string get_userName() { }

	// RVA: 0x163D36C
	public string get_id() { }

	// RVA: 0x163D37C
	public bool get_isFriend() { }

	// RVA: 0x163D384
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

	// RVA: 0x163D3B4
	public void .ctor(string id, Double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate) { }

	// RVA: 0x163D424
	public void .ctor(string id, Double percent) { }

	// RVA: 0x163D4C8
	public void .ctor() { }

	// RVA: 0x163D588
	public override string ToString() { }

	// RVA: 0x163D7DC
	public string get_id() { }

	// RVA: 0x163D7E4
	public void set_id(string value) { }

	// RVA: 0x163D7EC
	public Double get_percentCompleted() { }

	// RVA: 0x163D7F4
	public void set_percentCompleted(Double value) { }

	// RVA: 0x163D7C4
	public bool get_completed() { }

	// RVA: 0x163D7CC
	public bool get_hidden() { }

	// RVA: 0x163D7D4
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

	// RVA: 0x163D7FC
	public void .ctor(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points) { }

	// RVA: 0x163D8AC
	public override string ToString() { }

	// RVA: 0x163DB0C
	public void SetImage(Texture2D image) { }

	// RVA: 0x163DB14
	public string get_id() { }

	// RVA: 0x163DB1C
	public void set_id(string value) { }

	// RVA: 0x163DAE4
	public string get_title() { }

	// RVA: 0x163DAEC
	public string get_achievedDescription() { }

	// RVA: 0x163DAF4
	public string get_unachievedDescription() { }

	// RVA: 0x163DB04
	public bool get_hidden() { }

	// RVA: 0x163DAFC
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

	// RVA: 0x163DB24
	public void .ctor(string leaderboardID, Int64 value) { }

	// RVA: 0x163DC18
	public void .ctor(string leaderboardID, Int64 value, string userID, DateTime date, string formattedValue, int rank) { }

	// RVA: 0x163DCA8
	public override string ToString() { }

	// RVA: 0x163DF10
	public string get_leaderboardID() { }

	// RVA: 0x163DF18
	public void set_leaderboardID(string value) { }

	// RVA: 0x163DF20
	public Int64 get_value() { }

	// RVA: 0x163DF28
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

	// RVA: 0x163DF30
	public void .ctor() { }

	// RVA: 0x163E068
	public override string ToString() { }

	// RVA: 0x163E52C
	public void SetLocalUserScore(IScore score) { }

	// RVA: 0x163E534
	public void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x163E53C
	public void SetScores(IScore[] scores) { }

	// RVA: 0x163E544
	public void SetTitle(string title) { }

	// RVA: 0x163E54C
	public string[] GetUserFilter() { }

	// RVA: 0x163E554
	public string get_id() { }

	// RVA: 0x163E55C
	public void set_id(string value) { }

	// RVA: 0x163E564
	public UserScope get_userScope() { }

	// RVA: 0x163E56C
	public void set_userScope(UserScope value) { }

	// RVA: 0x163E574
	public Range get_range() { }

	// RVA: 0x163E57C
	public void set_range(Range value) { }

	// RVA: 0x163E584
	public TimeScope get_timeScope() { }

	// RVA: 0x163E58C
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

	// RVA: 0x163E594
	public UserProfile ToUserProfile() { }

	// RVA: 0x163E664
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

	// RVA: 0x163E75C
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

	// RVA: 0x163E848
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

	// RVA: 0x163E970
	public Score ToScore() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public System.Action<System.Boolean> callback; // 0x10

	// Methods

	// RVA: 0x163FDC8
	public void .ctor() { }

	// RVA: 0x1641E1C
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

	// RVA: 0x163EABC
	private static void ClearAchievementDescriptions(int size) { }

	// RVA: 0x163EBC4
	private static void SetAchievementDescription(GcAchievementDescriptionData data, int number) { }

	// RVA: 0x163ECA4
	private static void SetAchievementDescriptionImage(Texture2D texture, int number) { }

	// RVA: 0x163EDD4
	private static void TriggerAchievementDescriptionCallback(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x163EEF4
	private static void AuthenticateCallbackWrapper(int result, string error) { }

	// RVA: 0x163F240
	private static void ClearFriends(int size) { }

	// RVA: 0x163F3C4
	private static void SetFriends(GcUserProfileData data, int number) { }

	// RVA: 0x163F438
	private static void SetFriendImage(Texture2D texture, int number) { }

	// RVA: 0x163F5EC
	private static void TriggerFriendsCallbackWrapper(System.Action<System.Boolean> callback, int result) { }

	// RVA: 0x163F6D4
	private static void AchievementCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback, GcAchievementData[] result) { }

	// RVA: 0x163F874
	private static void ProgressCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x163F8AC
	private static void ScoreCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x163F8E4
	private static void ScoreLoaderCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IScore[]> callback, GcScoreData[] result) { }

	// RVA: 0x163FA1C
	private void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x163FC80
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x163FDD0
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x163FEB4
	public ILocalUser get_localUser() { }

	// RVA: 0x163F014
	private static void PopulateLocalUser() { }

	// RVA: 0x1640274
	public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x16403D4
	public void ReportProgress(string id, Double progress, System.Action<System.Boolean> callback) { }

	// RVA: 0x1640534
	public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback) { }

	// RVA: 0x1640694
	public void ReportScore(Int64 score, string board, System.Action<System.Boolean> callback) { }

	// RVA: 0x16407EC
	public void LoadScores(string category, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback) { }

	// RVA: 0x1640970
	public void LoadScores(ILeaderboard board, System.Action<System.Boolean> callback) { }

	// RVA: 0x1640E10
	private static void LeaderboardCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x1640E48
	public bool GetLoading(ILeaderboard board) { }

	// RVA: 0x163FB14
	private bool VerifyAuthentication() { }

	// RVA: 0x1641228
	public void ShowAchievementsUI() { }

	// RVA: 0x1641314
	public void ShowLeaderboardUI() { }

	// RVA: 0x1641400
	private static void ClearUsers(int size) { }

	// RVA: 0x16414F8
	private static void SetUser(GcUserProfileData data, int number) { }

	// RVA: 0x164156C
	private static void SetUserImage(Texture2D texture, int number) { }

	// RVA: 0x16415E0
	private static void TriggerUsersCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x164165C
	public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x163F4AC
	private static void SafeSetUserImage(UserProfile[] array, Texture2D texture, int number) { }

	// RVA: 0x163F338
	private static void SafeClearArray(UserProfile[] array, int size) { }

	// RVA: 0x16417E0
	public ILeaderboard CreateLeaderboard() { }

	// RVA: 0x1641834
	public IAchievement CreateAchievement() { }

	// RVA: 0x1641928
	private static void TriggerResetAchievementCallback(bool result) { }

	// RVA: 0x163FE74
	internal static void Authenticate() { }

	// RVA: 0x16400B4
	internal static bool GetAuthenticated() { }

	// RVA: 0x16400F4
	internal static string Internal_UserName() { }

	// RVA: 0x1640134
	internal static string Internal_UserID() { }

	// RVA: 0x1640174
	internal static string Internal_UserGameID() { }

	// RVA: 0x16401B4
	internal static string Internal_LegacyUserID() { }

	// RVA: 0x16401F4
	internal static bool GetIsUnderage() { }

	// RVA: 0x1640234
	internal static Texture2D GetUserImage() { }

	// RVA: 0x163FC30
	internal static void LoadFriends(object callback) { }

	// RVA: 0x1640384
	internal static void InternalLoadAchievementDescriptions(object callback) { }

	// RVA: 0x1640644
	internal static void InternalLoadAchievements(object callback) { }

	// RVA: 0x16404D4
	internal static void InternalReportProgress(string id, Double progress, object callback) { }

	// RVA: 0x1640794
	internal static void InternalReportScore(Int64 score, string category, object callback) { }

	// RVA: 0x1640908
	internal static void InternalLoadScores(string category, object callback) { }

	// RVA: 0x16412D4
	internal static void Internal_ShowAchievementsUI() { }

	// RVA: 0x16413C0
	internal static void Internal_ShowLeaderboardUI() { }

	// RVA: 0x1641778
	internal static void Internal_LoadUsers(string[] userIds, object callback) { }

	// RVA: 0x1641A00
	internal static void ResetAllAchievements() { }

	// RVA: 0x1641A40
	internal static void ShowDefaultAchievementBanner(bool value) { }

	// RVA: 0x1641A90
	public static void ResetAllAchievements(System.Action<System.Boolean> callback) { }

	// RVA: 0x1641B2C
	public static void ShowDefaultAchievementCompletionBanner(bool value) { }

	// RVA: 0x1641BD8
	public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope) { }

	// RVA: 0x1641C90
	internal static void ShowSpecificLeaderboardUI(string leaderboardID, int timeScope) { }

	// RVA: 0x163CEAC
	public void .ctor() { }

	// RVA: 0x1641CF8
	private static void .cctor() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal class GcLeaderboard
{
	// Fields
	private IntPtr m_InternalLeaderboard; // 0x10
	private Leaderboard m_GenericLeaderboard; // 0x18

	// Methods

	// RVA: 0x1640D3C
	internal void .ctor(Leaderboard board) { }

	// RVA: 0x1641E58
	protected override void Finalize() { }

	// RVA: 0x16411C8
	internal bool Contains(Leaderboard board) { }

	// RVA: 0x1641F74
	internal void SetScores(GcScoreData[] scoreDatas) { }

	// RVA: 0x16420B0
	internal void SetLocalScore(GcScoreData scoreData) { }

	// RVA: 0x16420F0
	internal void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x1642100
	internal void SetTitle(string title) { }

	// RVA: 0x1640D70
	internal void Internal_LoadScores(string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x1642114
	private static IntPtr GcLeaderboard_LoadScores(object self, string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x16411D8
	internal bool Loading() { }

	// RVA: 0x16421AC
	private static bool GcLeaderboard_Loading(IntPtr leaderboard) { }

	// RVA: 0x1641F20
	internal void Dispose() { }

	// RVA: 0x16421FC
	private static void GcLeaderboard_Dispose(IntPtr leaderboard) { }

}


