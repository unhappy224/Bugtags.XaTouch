using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace Bugtags.XaTouch
{
	// @interface BugtagsOptions : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface BugtagsOptions : INSCopying
	{
		// @property (assign, nonatomic) BOOL trackingCrashes;
		[Export("trackingCrashes")]
		bool TrackingCrashes { get; set; }

		// @property (assign, nonatomic) BOOL trackingUserSteps;
		[Export("trackingUserSteps")]
		bool TrackingUserSteps { get; set; }

		// @property (assign, nonatomic) BOOL trackingConsoleLog;
		[Export("trackingConsoleLog")]
		bool TrackingConsoleLog { get; set; }

		// @property (assign, nonatomic) BOOL trackingUserLocation;
		[Export("trackingUserLocation")]
		bool TrackingUserLocation { get; set; }

		// @property (assign, nonatomic) BOOL trackingNetwork;
		[Export("trackingNetwork")]
		bool TrackingNetwork { get; set; }

		// @property (copy, nonatomic) NSString * trackingNetworkURLFilter;
		[Export("trackingNetworkURLFilter")]
		string TrackingNetworkURLFilter { get; set; }

		// @property (assign, nonatomic) BOOL trackingNetworkContinueWithInvalidCertificate;
		[Export("trackingNetworkContinueWithInvalidCertificate")]
		bool TrackingNetworkContinueWithInvalidCertificate { get; set; }

		// @property (assign, nonatomic) BOOL crashWithScreenshot;
		[Export("crashWithScreenshot")]
		bool CrashWithScreenshot { get; set; }

		// @property (assign, nonatomic) BOOL ignorePIPESignalCrash;
		[Export("ignorePIPESignalCrash")]
		bool IgnorePIPESignalCrash { get; set; }

		// @property (assign, nonatomic) BOOL enableUserSignIn;
		[Export("enableUserSignIn")]
		bool EnableUserSignIn { get; set; }

		// @property (assign, nonatomic) UIInterfaceOrientationMask supportedInterfaceOrientations __attribute__((deprecated("")));
		[Export("supportedInterfaceOrientations", ArgumentSemantic.Assign)]
		UIInterfaceOrientationMask SupportedInterfaceOrientations { get; set; }

		// @property (copy, nonatomic) NSString * version;
		[Export("version")]
		string Version { get; set; }

		// @property (copy, nonatomic) NSString * build;
		[Export("build")]
		string Build { get; set; }
	}

	// @interface Bugtags : NSObject
	[BaseType(typeof(NSObject))]
	interface Bugtags
	{
		// +(void)startWithAppKey:(NSString *)appKey invocationEvent:(BTGInvocationEvent)invocationEvent;
		[Static]
		[Export("startWithAppKey:invocationEvent:")]
		void StartWithAppKey(string appKey, BTGInvocationEvent invocationEvent);

		// +(void)startWithAppKey:(NSString *)appKey invocationEvent:(BTGInvocationEvent)invocationEvent options:(BugtagsOptions *)options;
		[Static]
		[Export("startWithAppKey:invocationEvent:options:")]
		void StartWithAppKey(string appKey, BTGInvocationEvent invocationEvent, BugtagsOptions options);

		// +(void)setInvocationEvent:(BTGInvocationEvent)invocationEvent;
		[Static]
		[Export("setInvocationEvent:")]
		void SetInvocationEvent(BTGInvocationEvent invocationEvent);

		// +(BTGInvocationEvent)currentInvocationEvent;
		[Static]
		[Export("currentInvocationEvent")] 
		BTGInvocationEvent CurrentInvocationEvent { get; }

		// +(void)log:(NSString *)content;
		[Static]
		[Export("log:")]
		void Log(string content);

		// +(void)setTrackingCrashes:(BOOL)trackingCrashes;
		[Static]
		[Export("setTrackingCrashes:")]
		void SetTrackingCrashes(bool trackingCrashes);

		// +(void)setTrackingUserSteps:(BOOL)trackingUserSteps;
		[Static]
		[Export("setTrackingUserSteps:")]
		void SetTrackingUserSteps(bool trackingUserSteps);

		// +(void)setTrackingConsoleLog:(BOOL)trackingConsoleLog;
		[Static]
		[Export("setTrackingConsoleLog:")]
		void SetTrackingConsoleLog(bool trackingConsoleLog);

		// +(void)setTrackingUserLocation:(BOOL)trackingUserLocation;
		[Static]
		[Export("setTrackingUserLocation:")]
		void SetTrackingUserLocation(bool trackingUserLocation);

		// +(void)setTrackingNetwork:(BOOL)trackingNetwork;
		[Static]
		[Export("setTrackingNetwork:")]
		void SetTrackingNetwork(bool trackingNetwork);

		// +(void)setUserData:(NSString *)data forKey:(NSString *)key;
		[Static]
		[Export("setUserData:forKey:")]
		void SetUserData(string data, string key);

		// +(void)removeUserDataForKey:(NSString *)key;
		[Static]
		[Export("removeUserDataForKey:")]
		void RemoveUserDataForKey(string key);

		// +(void)removeAllUserData;
		[Static]
		[Export("removeAllUserData")]
		void RemoveAllUserData();

		// +(void)sendException:(NSException *)exception;
		[Static]
		[Export("sendException:")]
		void SendException(NSException exception);

		// +(void)sendFeedback:(NSString *)content;
		[Static]
		[Export("sendFeedback:")]
		void SendFeedback(string content);

		// +(void)setBeforeSendingCallback:(void (^)(void))callback;
		[Static]
		[Export("setBeforeSendingCallback:")]
		void SetBeforeSendingCallback(Action callback);

		// +(void)setAfterSendingCallback:(void (^)(void))callback;
		[Static]
		[Export("setAfterSendingCallback:")]
		void SetAfterSendingCallback(Action callback);

		// +(void)setUploadDataOnlyViaWiFi:(BOOL)onlyViaWiFi;
		[Static]
		[Export("setUploadDataOnlyViaWiFi:")]
		void SetUploadDataOnlyViaWiFi(bool onlyViaWiFi);

		// +(void)invoke;
		[Static]
		[Export("invoke")]
		void Invoke();

		// +(BOOL)registerPlugin:(id)plugin;
		[Static]
		[Export("registerPlugin:")]
		bool RegisterPlugin(NSObject plugin);

		// +(void)unregisterPlugin:(id)plugin;
		[Static]
		[Export("unregisterPlugin:")]
		void UnregisterPlugin(NSObject plugin);
	}
}

