// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class Social
{
	// Methods

	// RVA: 0x1619B3C
	public static ISocialPlatform get_Active() { }

	// RVA: 0x1619C1C
	public static ILocalUser get_localUser() { }

}

// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform
{
	// Fields
	private static ISocialPlatform _active; // 0x0

	// Methods

	// RVA: 0x1619B40
	internal static ISocialPlatform get_Instance() { }

	// RVA: 0x1619CD0
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

	// RVA: 0x1619D30
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

	// RVA: 0x1619D38
	public void .ctor() { }

	// RVA: 0x1619E98
	public void Authenticate(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x1619F58
	public void SetFriends(IUserProfile[] friends) { }

	// RVA: 0x1619F60
	public void SetAuthenticated(bool value) { }

	// RVA: 0x1619F68
	public void SetUnderage(bool value) { }

	// RVA: 0x1619F70
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

	// RVA: 0x1619DAC
	public void .ctor() { }

	// RVA: 0x1619F78
	public void .ctor(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image) { }

	// RVA: 0x161A010
	public override string ToString() { }

	// RVA: 0x161A208
	public void SetUserName(string name) { }

	// RVA: 0x161A210
	public void SetUserID(string id) { }

	// RVA: 0x161A218
	public void SetLegacyUserID(string id) { }

	// RVA: 0x161A220
	public void SetUserGameID(string id) { }

	// RVA: 0x161A228
	public void SetImage(Texture2D image) { }

	// RVA: 0x161A1F0
	public string get_userName() { }

	// RVA: 0x161A1E8
	public string get_id() { }

	// RVA: 0x161A1F8
	public bool get_isFriend() { }

	// RVA: 0x161A200
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

	// RVA: 0x161A230
	public void .ctor(string id, Double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate) { }

	// RVA: 0x161A2A0
	public void .ctor(string id, Double percent) { }

	// RVA: 0x161A344
	public void .ctor() { }

	// RVA: 0x161A404
	public override string ToString() { }

	// RVA: 0x161A658
	public string get_id() { }

	// RVA: 0x161A660
	public void set_id(string value) { }

	// RVA: 0x161A668
	public Double get_percentCompleted() { }

	// RVA: 0x161A670
	public void set_percentCompleted(Double value) { }

	// RVA: 0x161A640
	public bool get_completed() { }

	// RVA: 0x161A648
	public bool get_hidden() { }

	// RVA: 0x161A650
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

	// RVA: 0x161A678
	public void .ctor(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points) { }

	// RVA: 0x161A728
	public override string ToString() { }

	// RVA: 0x161A988
	public void SetImage(Texture2D image) { }

	// RVA: 0x161A990
	public string get_id() { }

	// RVA: 0x161A998
	public void set_id(string value) { }

	// RVA: 0x161A960
	public string get_title() { }

	// RVA: 0x161A968
	public string get_achievedDescription() { }

	// RVA: 0x161A970
	public string get_unachievedDescription() { }

	// RVA: 0x161A980
	public bool get_hidden() { }

	// RVA: 0x161A978
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

	// RVA: 0x161A9A0
	public void .ctor(string leaderboardID, Int64 value) { }

	// RVA: 0x161AA94
	public void .ctor(string leaderboardID, Int64 value, string userID, DateTime date, string formattedValue, int rank) { }

	// RVA: 0x161AB24
	public override string ToString() { }

	// RVA: 0x161AD8C
	public string get_leaderboardID() { }

	// RVA: 0x161AD94
	public void set_leaderboardID(string value) { }

	// RVA: 0x161AD9C
	public Int64 get_value() { }

	// RVA: 0x161ADA4
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

	// RVA: 0x161ADAC
	public void .ctor() { }

	// RVA: 0x161AEE4
	public override string ToString() { }

	// RVA: 0x161B3A8
	public void SetLocalUserScore(IScore score) { }

	// RVA: 0x161B3B0
	public void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x161B3B8
	public void SetScores(IScore[] scores) { }

	// RVA: 0x161B3C0
	public void SetTitle(string title) { }

	// RVA: 0x161B3C8
	public string[] GetUserFilter() { }

	// RVA: 0x161B3D0
	public string get_id() { }

	// RVA: 0x161B3D8
	public void set_id(string value) { }

	// RVA: 0x161B3E0
	public UserScope get_userScope() { }

	// RVA: 0x161B3E8
	public void set_userScope(UserScope value) { }

	// RVA: 0x161B3F0
	public Range get_range() { }

	// RVA: 0x161B3F8
	public void set_range(Range value) { }

	// RVA: 0x161B400
	public TimeScope get_timeScope() { }

	// RVA: 0x161B408
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

	// RVA: 0x161B410
	public UserProfile ToUserProfile() { }

	// RVA: 0x161B4E0
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

	// RVA: 0x161B5D8
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

	// RVA: 0x161B6C4
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

	// RVA: 0x161B7EC
	public Score ToScore() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public System.Action<System.Boolean> callback; // 0x10

	// Methods

	// RVA: 0x161CC44
	public void .ctor() { }

	// RVA: 0x161EC98
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

	// RVA: 0x161B938
	private static void ClearAchievementDescriptions(int size) { }

	// RVA: 0x161BA40
	private static void SetAchievementDescription(GcAchievementDescriptionData data, int number) { }

	// RVA: 0x161BB20
	private static void SetAchievementDescriptionImage(Texture2D texture, int number) { }

	// RVA: 0x161BC50
	private static void TriggerAchievementDescriptionCallback(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x161BD70
	private static void AuthenticateCallbackWrapper(int result, string error) { }

	// RVA: 0x161C0BC
	private static void ClearFriends(int size) { }

	// RVA: 0x161C240
	private static void SetFriends(GcUserProfileData data, int number) { }

	// RVA: 0x161C2B4
	private static void SetFriendImage(Texture2D texture, int number) { }

	// RVA: 0x161C468
	private static void TriggerFriendsCallbackWrapper(System.Action<System.Boolean> callback, int result) { }

	// RVA: 0x161C550
	private static void AchievementCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback, GcAchievementData[] result) { }

	// RVA: 0x161C6F0
	private static void ProgressCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x161C728
	private static void ScoreCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x161C760
	private static void ScoreLoaderCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IScore[]> callback, GcScoreData[] result) { }

	// RVA: 0x161C898
	private void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x161CAFC
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean> callback) { }

	// RVA: 0x161CC4C
	private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x161CD30
	public ILocalUser get_localUser() { }

	// RVA: 0x161BE90
	private static void PopulateLocalUser() { }

	// RVA: 0x161D0F0
	public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback) { }

	// RVA: 0x161D250
	public void ReportProgress(string id, Double progress, System.Action<System.Boolean> callback) { }

	// RVA: 0x161D3B0
	public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback) { }

	// RVA: 0x161D510
	public void ReportScore(Int64 score, string board, System.Action<System.Boolean> callback) { }

	// RVA: 0x161D668
	public void LoadScores(string category, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback) { }

	// RVA: 0x161D7EC
	public void LoadScores(ILeaderboard board, System.Action<System.Boolean> callback) { }

	// RVA: 0x161DC8C
	private static void LeaderboardCallbackWrapper(System.Action<System.Boolean> callback, bool success) { }

	// RVA: 0x161DCC4
	public bool GetLoading(ILeaderboard board) { }

	// RVA: 0x161C990
	private bool VerifyAuthentication() { }

	// RVA: 0x161E0A4
	public void ShowAchievementsUI() { }

	// RVA: 0x161E190
	public void ShowLeaderboardUI() { }

	// RVA: 0x161E27C
	private static void ClearUsers(int size) { }

	// RVA: 0x161E374
	private static void SetUser(GcUserProfileData data, int number) { }

	// RVA: 0x161E3E8
	private static void SetUserImage(Texture2D texture, int number) { }

	// RVA: 0x161E45C
	private static void TriggerUsersCallbackWrapper(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x161E4D8
	public void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback) { }

	// RVA: 0x161C328
	private static void SafeSetUserImage(UserProfile[] array, Texture2D texture, int number) { }

	// RVA: 0x161C1B4
	private static void SafeClearArray(UserProfile[] array, int size) { }

	// RVA: 0x161E65C
	public ILeaderboard CreateLeaderboard() { }

	// RVA: 0x161E6B0
	public IAchievement CreateAchievement() { }

	// RVA: 0x161E7A4
	private static void TriggerResetAchievementCallback(bool result) { }

	// RVA: 0x161CCF0
	internal static void Authenticate() { }

	// RVA: 0x161CF30
	internal static bool GetAuthenticated() { }

	// RVA: 0x161CF70
	internal static string Internal_UserName() { }

	// RVA: 0x161CFB0
	internal static string Internal_UserID() { }

	// RVA: 0x161CFF0
	internal static string Internal_UserGameID() { }

	// RVA: 0x161D030
	internal static string Internal_LegacyUserID() { }

	// RVA: 0x161D070
	internal static bool GetIsUnderage() { }

	// RVA: 0x161D0B0
	internal static Texture2D GetUserImage() { }

	// RVA: 0x161CAAC
	internal static void LoadFriends(object callback) { }

	// RVA: 0x161D200
	internal static void InternalLoadAchievementDescriptions(object callback) { }

	// RVA: 0x161D4C0
	internal static void InternalLoadAchievements(object callback) { }

	// RVA: 0x161D350
	internal static void InternalReportProgress(string id, Double progress, object callback) { }

	// RVA: 0x161D610
	internal static void InternalReportScore(Int64 score, string category, object callback) { }

	// RVA: 0x161D784
	internal static void InternalLoadScores(string category, object callback) { }

	// RVA: 0x161E150
	internal static void Internal_ShowAchievementsUI() { }

	// RVA: 0x161E23C
	internal static void Internal_ShowLeaderboardUI() { }

	// RVA: 0x161E5F4
	internal static void Internal_LoadUsers(string[] userIds, object callback) { }

	// RVA: 0x161E87C
	internal static void ResetAllAchievements() { }

	// RVA: 0x161E8BC
	internal static void ShowDefaultAchievementBanner(bool value) { }

	// RVA: 0x161E90C
	public static void ResetAllAchievements(System.Action<System.Boolean> callback) { }

	// RVA: 0x161E9A8
	public static void ShowDefaultAchievementCompletionBanner(bool value) { }

	// RVA: 0x161EA54
	public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope) { }

	// RVA: 0x161EB0C
	internal static void ShowSpecificLeaderboardUI(string leaderboardID, int timeScope) { }

	// RVA: 0x1619D28
	public void .ctor() { }

	// RVA: 0x161EB74
	private static void .cctor() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal class GcLeaderboard
{
	// Fields
	private IntPtr m_InternalLeaderboard; // 0x10
	private Leaderboard m_GenericLeaderboard; // 0x18

	// Methods

	// RVA: 0x161DBB8
	internal void .ctor(Leaderboard board) { }

	// RVA: 0x161ECD4
	protected override void Finalize() { }

	// RVA: 0x161E044
	internal bool Contains(Leaderboard board) { }

	// RVA: 0x161EDF0
	internal void SetScores(GcScoreData[] scoreDatas) { }

	// RVA: 0x161EF2C
	internal void SetLocalScore(GcScoreData scoreData) { }

	// RVA: 0x161EF6C
	internal void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0x161EF7C
	internal void SetTitle(string title) { }

	// RVA: 0x161DBEC
	internal void Internal_LoadScores(string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x161EF90
	private static IntPtr GcLeaderboard_LoadScores(object self, string category, int from, int count, string[] userIDs, int playerScope, int timeScope, object callback) { }

	// RVA: 0x161E054
	internal bool Loading() { }

	// RVA: 0x161F028
	private static bool GcLeaderboard_Loading(IntPtr leaderboard) { }

	// RVA: 0x161ED9C
	internal void Dispose() { }

	// RVA: 0x161F078
	private static void GcLeaderboard_Dispose(IntPtr leaderboard) { }

}


