namespace Crestron.Panopto.Common.Enums;
        // class declarations
         class TransportTypes;
         class CommandAction;
         class CommonFeatureSupport;
         class UserAttributeType;
         class CommonCommandGroupType;
         class DevicePropertyRenderHint;
         class TransportType;
         class FeedbackSupportEnum;
         class DownloadManagerErrorType;
         class DevicePropertyType;
         class eStringEncoding;
         class AuthenticationStatusType;
         class UserAttributeDataType;
         class CommunicationType;
         class DeviceTypes;
         class VideoServerStateObjects;
         class AutoAnswerModes;
         class UserAttributeRequiredForConnectionType;
         class eTransportAdjustableProperties;
         class DisplayStateObjects;
         class StandardFeedback;
         class PowerStatesFeedback;
         class MuteStatesFeedback;
         class MicMuteStatesFeedback;
         class StandbyStatesFeedback;
         class SelfviewStatesFeedback;
         class TunerFrequencyBandStatesFeedback;
         class ResourceStatusFeedback;
         class CompatibleFeedback;
         class AuthorizationFeedback;
         class InputTypesFeeback;
         class CallDirectionFeedback;
         class CallStateFeedback;
         class CallProtocolFeedback;
         class CallTypeFeedback;
         class AllowFarEndControlOfNearEndCameraFeedback;
         class MuteMicsOnAutoAnswerFeedback;
         class AutoAnswerFeedback;
         class DoNotDisturbFeedback;
         class EncryptionFeedback;
         class EnergyStarFeedback;
         class VideoMuteStatesFeedback;
         class OnScreenDisplayFeedback;
         class DevicePropertyUnit;
         class MessageType;
         class EndPointLocation;
         class ErrorState;
         class ethernetProtocol;
         class SurroundModeType;
         class DevicePropertyAttributes;
         class StandardCommandsEnum;
         class VideoConnections;
         class StateSeverity;
         class StateType;
         class DevicePropertyStates;
         class VideoConnectionTypes;
         class PresetEvent;
    static class TransportTypes // enum
    {
        static SIGNED_LONG_INTEGER Ir;
        static SIGNED_LONG_INTEGER Comport;
        static SIGNED_LONG_INTEGER Tcp;
        static SIGNED_LONG_INTEGER SSL;
        static SIGNED_LONG_INTEGER Telnet;
        static SIGNED_LONG_INTEGER Http;
        static SIGNED_LONG_INTEGER Https;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class CommandAction // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Hold;
        static SIGNED_LONG_INTEGER Release;
    };

    static class CommonFeatureSupport // enum
    {
        static SIGNED_LONG_INTEGER SupportsArrowKeys;
        static SIGNED_LONG_INTEGER SupportsAsterisk;
        static SIGNED_LONG_INTEGER SupportsBack;
        static SIGNED_LONG_INTEGER SupportsChangeChannel;
        static SIGNED_LONG_INTEGER SupportsChangeVolume;
        static SIGNED_LONG_INTEGER SupportsChannelFeedback;
        static SIGNED_LONG_INTEGER SupportsClear;
        static SIGNED_LONG_INTEGER SupportsColorButtons;
        static SIGNED_LONG_INTEGER SupportsCoolDownTime;
        static SIGNED_LONG_INTEGER SupportsDash;
        static SIGNED_LONG_INTEGER SupportsDisconnect;
        static SIGNED_LONG_INTEGER SupportsDiscreteMute;
        static SIGNED_LONG_INTEGER SupportsDiscretePower;
        static SIGNED_LONG_INTEGER SupportsDvrCommand;
        static SIGNED_LONG_INTEGER SupportsEnter;
        static SIGNED_LONG_INTEGER SupportsExit;
        static SIGNED_LONG_INTEGER SupportsFavorite;
        static SIGNED_LONG_INTEGER SupportsForwardScan;
        static SIGNED_LONG_INTEGER SupportsForwardSkip;
        static SIGNED_LONG_INTEGER SupportsGuide;
        static SIGNED_LONG_INTEGER SupportsHome;
        static SIGNED_LONG_INTEGER SupportsInfo;
        static SIGNED_LONG_INTEGER SupportsKeypadBackSpace;
        static SIGNED_LONG_INTEGER SupportsKeypadNumber;
        static SIGNED_LONG_INTEGER SupportsLast;
        static SIGNED_LONG_INTEGER SupportsLetterKeys;
        static SIGNED_LONG_INTEGER SupportsLive;
        static SIGNED_LONG_INTEGER SupportsMenu;
        static SIGNED_LONG_INTEGER SupportsMute;
        static SIGNED_LONG_INTEGER SupportsMuteFeedback;
        static SIGNED_LONG_INTEGER SupportsPageChange;
        static SIGNED_LONG_INTEGER SupportsPause;
        static SIGNED_LONG_INTEGER SupportsPeriod;
        static SIGNED_LONG_INTEGER SupportsPlay;
        static SIGNED_LONG_INTEGER SupportsPound;
        static SIGNED_LONG_INTEGER SupportsPowerFeedback;
        static SIGNED_LONG_INTEGER SupportsReconnect;
        static SIGNED_LONG_INTEGER SupportsRecord;
        static SIGNED_LONG_INTEGER SupportsRepeat;
        static SIGNED_LONG_INTEGER SupportsReplay;
        static SIGNED_LONG_INTEGER SupportsReturn;
        static SIGNED_LONG_INTEGER SupportsReverseScan;
        static SIGNED_LONG_INTEGER SupportsReverseSkip;
        static SIGNED_LONG_INTEGER SupportsSetChannel;
        static SIGNED_LONG_INTEGER SupportsSetVolume;
        static SIGNED_LONG_INTEGER SupportsSpeedSlow;
        static SIGNED_LONG_INTEGER SupportsStop;
        static SIGNED_LONG_INTEGER SupportsThumbsDown;
        static SIGNED_LONG_INTEGER SupportsThumbsUp;
        static SIGNED_LONG_INTEGER SupportsTogglePower;
        static SIGNED_LONG_INTEGER SupportsVolumePercentFeedback;
        static SIGNED_LONG_INTEGER SupportsWarmUpTime;
        static SIGNED_LONG_INTEGER SupportsFeedback;
        static SIGNED_LONG_INTEGER SupportsPlayBackStatusFeedback;
        static SIGNED_LONG_INTEGER SupportsTrackFeedback;
        static SIGNED_LONG_INTEGER SupportsChapterFeedback;
        static SIGNED_LONG_INTEGER SupportsTrackElapsedTimeFeedback;
        static SIGNED_LONG_INTEGER SupportsTrackRemainingTimeFeedback;
        static SIGNED_LONG_INTEGER SupportsChapterElapsedTimeFeedback;
        static SIGNED_LONG_INTEGER SupportsChapterRemainingTimeFeedback;
        static SIGNED_LONG_INTEGER SupportsTotalElapsedTimeFeedback;
        static SIGNED_LONG_INTEGER SupportsTotalRemainingTimeFeedback;
        static SIGNED_LONG_INTEGER SupportsAudio;
        static SIGNED_LONG_INTEGER SupportsDisplay;
        static SIGNED_LONG_INTEGER SupportsEject;
        static SIGNED_LONG_INTEGER SupportsOptions;
        static SIGNED_LONG_INTEGER SupportsSubtitle;
        static SIGNED_LONG_INTEGER SupportsInputFeedback;
        static SIGNED_LONG_INTEGER SupportsLampHours;
        static SIGNED_LONG_INTEGER SupportsSetInputSource;
        static SIGNED_LONG_INTEGER SupportsPanAndTilt;
        static SIGNED_LONG_INTEGER SupportsZoom;
        static SIGNED_LONG_INTEGER SupportsManualFocus;
        static SIGNED_LONG_INTEGER SupportsAutoFocus;
        static SIGNED_LONG_INTEGER SupportsIrRemoteEmulation;
        static SIGNED_LONG_INTEGER SupportsMeetings;
        static SIGNED_LONG_INTEGER SupportsSelfView;
        static SIGNED_LONG_INTEGER SupportsSelfViewPosition;
        static SIGNED_LONG_INTEGER SupportsDualVideo;
        static SIGNED_LONG_INTEGER SupportsPresentationPip;
        static SIGNED_LONG_INTEGER SupportsPictureMode;
        static SIGNED_LONG_INTEGER SupportsLocality;
        static SIGNED_LONG_INTEGER SupportsToggleVideoMute;
        static SIGNED_LONG_INTEGER SupportsSwitching;
        static SIGNED_LONG_INTEGER SupportsToggleEnergyStar;
        static SIGNED_LONG_INTEGER SupportsDiscreteEnergyStar;
        static SIGNED_LONG_INTEGER SupportsEnergyStarFeedback;
        static SIGNED_LONG_INTEGER SupportsDiscreteVideoMute;
        static SIGNED_LONG_INTEGER SupportsVideoMuteFeedback;
        static SIGNED_LONG_INTEGER SupportsOnScreenDisplayFeedback;
        static SIGNED_LONG_INTEGER SupportsFarEndCameraPresetStore;
        static SIGNED_LONG_INTEGER SupportsInput4Connector;
        static SIGNED_LONG_INTEGER SupportsFarEndPresentationSourceSelect;
        static SIGNED_LONG_INTEGER SupportsMultipointControl;
        static SIGNED_LONG_INTEGER SupportsIREmulation;
        static SIGNED_LONG_INTEGER SupportsMonitorPresentation;
        static SIGNED_LONG_INTEGER SupportsPictureLayout;
        static SIGNED_LONG_INTEGER SupportsPan;
        static SIGNED_LONG_INTEGER SupportsTilt;
        static SIGNED_LONG_INTEGER SupportsMicMute;
        static SIGNED_LONG_INTEGER SupportsRecentCallsDialing;
        static SIGNED_LONG_INTEGER SupportsPopUpMenu;
        static SIGNED_LONG_INTEGER SupportsTopMenu;
        static SIGNED_LONG_INTEGER SupportsSelect;
        static SIGNED_LONG_INTEGER SupportsToneControlFeedback;
        static SIGNED_LONG_INTEGER SupportsDiscreteToneControl;
        static SIGNED_LONG_INTEGER SupportsToggleToneControl;
        static SIGNED_LONG_INTEGER SupportsBassFeedback;
        static SIGNED_LONG_INTEGER SupportsBassDbFeedback;
        static SIGNED_LONG_INTEGER SupportsTrebleFeedback;
        static SIGNED_LONG_INTEGER SupportsTrebleDbFeedback;
        static SIGNED_LONG_INTEGER SupportsSetBass;
        static SIGNED_LONG_INTEGER SupportsChangeBass;
        static SIGNED_LONG_INTEGER SupportsSetTreble;
        static SIGNED_LONG_INTEGER SupportsChangeTreble;
        static SIGNED_LONG_INTEGER SupportsLoudnessFeedback;
        static SIGNED_LONG_INTEGER SupportsDiscreteLoudness;
        static SIGNED_LONG_INTEGER SupportsToggleLoudness;
        static SIGNED_LONG_INTEGER SupportsSurroundModeFeedback;
        static SIGNED_LONG_INTEGER SupportsSurroundModeCycle;
        static SIGNED_LONG_INTEGER SupportsTunerFeedback;
        static SIGNED_LONG_INTEGER SupportsChangeFrequency;
        static SIGNED_LONG_INTEGER SupportsSetFrequency;
        static SIGNED_LONG_INTEGER SupportsAutoFrequency;
        static SIGNED_LONG_INTEGER SupportsFrequencyBand;
        static SIGNED_LONG_INTEGER SupportsDiscreteFrequencyBand;
        static SIGNED_LONG_INTEGER SupportsPresetRecall;
        static SIGNED_LONG_INTEGER SupportsPresetStore;
        static SIGNED_LONG_INTEGER SupportsSearch;
        static SIGNED_LONG_INTEGER SupportsSetAudioInputSource;
        static SIGNED_LONG_INTEGER SupportsSetVideoInputSource;
        static SIGNED_LONG_INTEGER SupportsAudioInputFeedback;
        static SIGNED_LONG_INTEGER SupportsVideoInputFeedback;
        static SIGNED_LONG_INTEGER SupportsSetAudioOutputSource;
        static SIGNED_LONG_INTEGER SupportsSetVideoOutputSource;
        static SIGNED_LONG_INTEGER SupportsAudioOutputFeedback;
        static SIGNED_LONG_INTEGER SupportsVideoOutputFeedback;
        static SIGNED_LONG_INTEGER SupportsUsername;
        static SIGNED_LONG_INTEGER SupportsPassword;
        static SIGNED_LONG_INTEGER SupportsSirius;
        static SIGNED_LONG_INTEGER SupportsXm;
        static SIGNED_LONG_INTEGER SupportsSiriusXm;
        static SIGNED_LONG_INTEGER SupportsHdRadio;
        static SIGNED_LONG_INTEGER SupportsInternetRadio;
        static SIGNED_LONG_INTEGER SupportsLastFm;
        static SIGNED_LONG_INTEGER SupportsPandora;
        static SIGNED_LONG_INTEGER SupportsRhapsody;
        static SIGNED_LONG_INTEGER SupportsChangePreset;
        static SIGNED_LONG_INTEGER SupportsPlayPause;
        static SIGNED_LONG_INTEGER SupportsSpotify;
        static SIGNED_LONG_INTEGER SupportsYouTube;
        static SIGNED_LONG_INTEGER SupportsYouTubeTv;
        static SIGNED_LONG_INTEGER SupportsNetflix;
        static SIGNED_LONG_INTEGER SupportsHulu;
        static SIGNED_LONG_INTEGER SupportsDirectvNow;
        static SIGNED_LONG_INTEGER SupportsAmazonVideo;
        static SIGNED_LONG_INTEGER SupportsPlaystationVue;
        static SIGNED_LONG_INTEGER SupportsSlingTv;
        static SIGNED_LONG_INTEGER SupportsAirplay;
        static SIGNED_LONG_INTEGER SupportsGoogleCast;
        static SIGNED_LONG_INTEGER SupportsDlna;
        static SIGNED_LONG_INTEGER SupportsTidal;
        static SIGNED_LONG_INTEGER SupportsDeezer;
        static SIGNED_LONG_INTEGER SupportsCrackle;
        static SIGNED_LONG_INTEGER SupportsOnDemand;
        static SIGNED_LONG_INTEGER SupportsGooglePlay;
        static SIGNED_LONG_INTEGER SupportsBluetooth;
        static SIGNED_LONG_INTEGER SupportsTivo;
        static SIGNED_LONG_INTEGER SupportsRSkip;
        static SIGNED_LONG_INTEGER SupportsFSkip;
        static SIGNED_LONG_INTEGER SupportsKeypadEmulation;
        static SIGNED_LONG_INTEGER SupportsLogin;
        static SIGNED_LONG_INTEGER SupportsUDLLogin;
        static SIGNED_LONG_INTEGER SupportsRequestSoftwareVersion;
        static SIGNED_LONG_INTEGER SupportsRequestSoftwareVersionDifferences;
        static SIGNED_LONG_INTEGER SupportsRequestResourceStatus;
        static SIGNED_LONG_INTEGER SupportsRequestSystemStatus;
        static SIGNED_LONG_INTEGER SupportsRequestResourceName;
        static SIGNED_LONG_INTEGER SupportsRequestResourcePermission;
        static SIGNED_LONG_INTEGER SupportsBypassResource;
        static SIGNED_LONG_INTEGER SupportsUnbypassResource;
        static SIGNED_LONG_INTEGER SupportsResourceArmAway;
        static SIGNED_LONG_INTEGER SupportsResourceArmAwayInstant;
        static SIGNED_LONG_INTEGER SupportsResourceArmAwayDelayed;
        static SIGNED_LONG_INTEGER SupportsResourceArmDelayed;
        static SIGNED_LONG_INTEGER SupportsResourceArmInstant;
        static SIGNED_LONG_INTEGER SupportsResourceArmStay;
        static SIGNED_LONG_INTEGER SupportsResourceArmStayInstant;
        static SIGNED_LONG_INTEGER SupportsResourceArmStayDelayed;
        static SIGNED_LONG_INTEGER SupportsDisarm;
        static SIGNED_LONG_INTEGER SupportsDisarmResource;
        static SIGNED_LONG_INTEGER SupportsRequestLog;
        static SIGNED_LONG_INTEGER SupportsRequestLogSetAmount;
        static SIGNED_LONG_INTEGER SupportsRequestFeatures;
        static SIGNED_LONG_INTEGER SupportsRequestSetup;
        static SIGNED_LONG_INTEGER SupportsRequestAreaInfo;
        static SIGNED_LONG_INTEGER SupportsRequestZoneInfo;
        static SIGNED_LONG_INTEGER SupportsRequestOutputInfo;
        static SIGNED_LONG_INTEGER SupportsRequestDoorInfo;
        static SIGNED_LONG_INTEGER SupportsRequestDeviceInfo;
        static SIGNED_LONG_INTEGER SupportsRequestAreaCount;
        static SIGNED_LONG_INTEGER SupportsRequestZoneCount;
        static SIGNED_LONG_INTEGER SupportsRequestOutputCount;
        static SIGNED_LONG_INTEGER SupportsRequestDoorCount;
        static SIGNED_LONG_INTEGER SupportsRequestDeviceCount;
        static SIGNED_LONG_INTEGER SupportsRequestAreaResourceStatus;
        static SIGNED_LONG_INTEGER SupportsRequestZoneResourceStatus;
        static SIGNED_LONG_INTEGER SupportsRequestOutputResourceStatus;
        static SIGNED_LONG_INTEGER SupportsRequestDoorResourceStatus;
        static SIGNED_LONG_INTEGER SupportsRequestDeviceResourceStatus;
        static SIGNED_LONG_INTEGER SupportsSetResourceState;
        static SIGNED_LONG_INTEGER SupportsRequestBypassedResources;
        static SIGNED_LONG_INTEGER SupportsSilenceBells;
        static SIGNED_LONG_INTEGER SupportsResetSensors;
        static SIGNED_LONG_INTEGER SupportsSubscribeResourceOnOffState;
        static SIGNED_LONG_INTEGER SupportsSubscribeResourceReadyState;
        static SIGNED_LONG_INTEGER SupportsSubscribeResourceGeneralState;
        static SIGNED_LONG_INTEGER SupportsSubscribeDeviceMessages;
        static SIGNED_LONG_INTEGER SupportsSubscribeDeviceLogging;
        static SIGNED_LONG_INTEGER SupportsSubscribeDeviceConfigurationChange;
        static SIGNED_LONG_INTEGER SupportsSubscribe;
        static SIGNED_LONG_INTEGER SupportsRequestAlarm;
        static SIGNED_LONG_INTEGER SupportsRequestAreasNotReadyToArm;
        static SIGNED_LONG_INTEGER SupportsArmAll;
        static SIGNED_LONG_INTEGER SupportsDisarmAll;
        static SIGNED_LONG_INTEGER SupportsBypassAll;
        static SIGNED_LONG_INTEGER SupportsUnbypassAll;
        static SIGNED_LONG_INTEGER SupportsKeypadStatusText;
        static SIGNED_LONG_INTEGER SupportsUpDown;
        static SIGNED_LONG_INTEGER SupportsLeftRight;
        static SIGNED_LONG_INTEGER SupportsRequestUsers;
        static SIGNED_LONG_INTEGER SupportsRequestAreaAlarm;
        static SIGNED_LONG_INTEGER SupportsRequestZoneAlarm;
        static SIGNED_LONG_INTEGER SupportsRequestTamper;
        static SIGNED_LONG_INTEGER SupportsRequestAlarmMemory;
        static SIGNED_LONG_INTEGER SupportsRequestAreaAlarmMemory;
        static SIGNED_LONG_INTEGER SupportsRequestZoneAlarmMemory;
        static SIGNED_LONG_INTEGER SupportsRequestFireAlarm;
        static SIGNED_LONG_INTEGER SupportsRequestFireAlarmMemory;
        static SIGNED_LONG_INTEGER SupportsArm;
        static SIGNED_LONG_INTEGER SupportsRequestResourceExitTime;
    };

    static class UserAttributeType // enum
    {
        static SIGNED_LONG_INTEGER DeviceId;
        static SIGNED_LONG_INTEGER OnScreenId;
        static SIGNED_LONG_INTEGER MessageBox;
        static SIGNED_LONG_INTEGER Custom;
    };

    static class CommonCommandGroupType // enum
    {
        static SIGNED_LONG_INTEGER Volume;
        static SIGNED_LONG_INTEGER Mute;
        static SIGNED_LONG_INTEGER MicMute;
        static SIGNED_LONG_INTEGER ConferenceCall;
        static SIGNED_LONG_INTEGER DisplayName;
        static SIGNED_LONG_INTEGER RemoteNumber;
        static SIGNED_LONG_INTEGER CallbackNumber;
        static SIGNED_LONG_INTEGER CallType;
        static SIGNED_LONG_INTEGER CallSpeed;
        static SIGNED_LONG_INTEGER CallDirection;
        static SIGNED_LONG_INTEGER CallStatus;
        static SIGNED_LONG_INTEGER Camera;
        static SIGNED_LONG_INTEGER Input;
        static SIGNED_LONG_INTEGER Selfview;
        static SIGNED_LONG_INTEGER Dial;
        static SIGNED_LONG_INTEGER Phonebook;
        static SIGNED_LONG_INTEGER Video;
        static SIGNED_LONG_INTEGER Booking;
        static SIGNED_LONG_INTEGER Other;
        static SIGNED_LONG_INTEGER SystemName;
        static SIGNED_LONG_INTEGER SystemH323Id;
        static SIGNED_LONG_INTEGER SystemE164Alias;
        static SIGNED_LONG_INTEGER SystemSoftwareVersion;
        static SIGNED_LONG_INTEGER SystemSerialNumber;
        static SIGNED_LONG_INTEGER SystemInfo;
        static SIGNED_LONG_INTEGER AllowFecc;
        static SIGNED_LONG_INTEGER MuteMicsAutoAnswer;
        static SIGNED_LONG_INTEGER DoNotDisturb;
        static SIGNED_LONG_INTEGER AutoAnswer;
        static SIGNED_LONG_INTEGER Standby;
        static SIGNED_LONG_INTEGER Encryption;
        static SIGNED_LONG_INTEGER Notification;
        static SIGNED_LONG_INTEGER NotificationButtonOneText;
        static SIGNED_LONG_INTEGER NotificationButtonTwoText;
        static SIGNED_LONG_INTEGER NotificationButtonThreeText;
        static SIGNED_LONG_INTEGER NotificationButtonFourText;
        static SIGNED_LONG_INTEGER NotificationButtonFiveText;
        static SIGNED_LONG_INTEGER NotificationType;
        static SIGNED_LONG_INTEGER NotificationText;
        static SIGNED_LONG_INTEGER NotificationTitle;
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Presentation;
        static SIGNED_LONG_INTEGER SystemIpAddress;
        static SIGNED_LONG_INTEGER SystemSipUri;
        static SIGNED_LONG_INTEGER NotificationClear;
        static SIGNED_LONG_INTEGER NotificationDuration;
        static SIGNED_LONG_INTEGER Multipoint;
        static SIGNED_LONG_INTEGER MonitorPresentationSetting;
        static SIGNED_LONG_INTEGER IrRemoteEmulation;
        static SIGNED_LONG_INTEGER VideoMute;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER LampHours;
        static SIGNED_LONG_INTEGER EnergyStar;
        static SIGNED_LONG_INTEGER OnScreenDisplay;
        static SIGNED_LONG_INTEGER Arrow;
        static SIGNED_LONG_INTEGER Keypad;
        static SIGNED_LONG_INTEGER Channel;
        static SIGNED_LONG_INTEGER Page;
        static SIGNED_LONG_INTEGER PlayBackStatus;
        static SIGNED_LONG_INTEGER TrackFeedback;
        static SIGNED_LONG_INTEGER ChapterFeedback;
        static SIGNED_LONG_INTEGER TrackElapsedTime;
        static SIGNED_LONG_INTEGER TrackRemainingTime;
        static SIGNED_LONG_INTEGER ChapterElapsedTime;
        static SIGNED_LONG_INTEGER ChapterRemainingTime;
        static SIGNED_LONG_INTEGER TotalElapsedTime;
        static SIGNED_LONG_INTEGER TotalRemainingTime;
        static SIGNED_LONG_INTEGER Connection;
        static SIGNED_LONG_INTEGER AckNak;
        static SIGNED_LONG_INTEGER Reboot;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER SurroundMode;
        static SIGNED_LONG_INTEGER Tuner;
        static SIGNED_LONG_INTEGER Output;
        static SIGNED_LONG_INTEGER Bass;
        static SIGNED_LONG_INTEGER Treble;
        static SIGNED_LONG_INTEGER Loudness;
        static SIGNED_LONG_INTEGER ToneControl;
        static SIGNED_LONG_INTEGER ToneState;
        static SIGNED_LONG_INTEGER TunerFrequency;
        static SIGNED_LONG_INTEGER TunerFrequencyBand;
        static SIGNED_LONG_INTEGER AudioInput;
        static SIGNED_LONG_INTEGER Arm;
        static SIGNED_LONG_INTEGER Disarm;
        static SIGNED_LONG_INTEGER Bypass;
        static SIGNED_LONG_INTEGER Unbypass;
        static SIGNED_LONG_INTEGER Login;
        static SIGNED_LONG_INTEGER SoftwareVersionDifferences;
        static SIGNED_LONG_INTEGER MonitoringDeviceInfo;
        static SIGNED_LONG_INTEGER MonitoringResourceStatus;
        static SIGNED_LONG_INTEGER MonitoringResourceName;
        static SIGNED_LONG_INTEGER MonitoringResourcePermissionArea;
        static SIGNED_LONG_INTEGER MonitoringResourcePermissionZone;
        static SIGNED_LONG_INTEGER MonitoringResourcePermissionOutput;
        static SIGNED_LONG_INTEGER MonitoringResourcePermissionDevice;
        static SIGNED_LONG_INTEGER MonitoringResourcePermissionDoor;
        static SIGNED_LONG_INTEGER MonitoringLog;
        static SIGNED_LONG_INTEGER Heartbeat;
        static SIGNED_LONG_INTEGER MonitoringSystemStatus;
        static SIGNED_LONG_INTEGER MonitoringSystemFeatures;
        static SIGNED_LONG_INTEGER MonitoringSystemSetup;
        static SIGNED_LONG_INTEGER MonitoringAreaInfo;
        static SIGNED_LONG_INTEGER MonitoringZoneInfo;
        static SIGNED_LONG_INTEGER MonitoringOutputInfo;
        static SIGNED_LONG_INTEGER MonitoringDoorInfo;
        static SIGNED_LONG_INTEGER MonitoringAreaCount;
        static SIGNED_LONG_INTEGER MonitoringZoneCount;
        static SIGNED_LONG_INTEGER MonitoringOutputCount;
        static SIGNED_LONG_INTEGER MonitoringDoorCount;
        static SIGNED_LONG_INTEGER MonitoringDeviceCount;
        static SIGNED_LONG_INTEGER MonitoringAreaResourceStatus;
        static SIGNED_LONG_INTEGER MonitoringZoneResourceStatus;
        static SIGNED_LONG_INTEGER MonitoringOutputResourceStatus;
        static SIGNED_LONG_INTEGER MonitoringDoorResourceStatus;
        static SIGNED_LONG_INTEGER MonitoringDeviceResourceStatus;
        static SIGNED_LONG_INTEGER MonitoringInfo;
        static SIGNED_LONG_INTEGER SetResourceState;
        static SIGNED_LONG_INTEGER MonitoringBypassedResources;
        static SIGNED_LONG_INTEGER SilenceSensors;
        static SIGNED_LONG_INTEGER ResetSensors;
        static SIGNED_LONG_INTEGER SubscribeResourceOnOffState;
        static SIGNED_LONG_INTEGER SubscribeResourceReadyState;
        static SIGNED_LONG_INTEGER SubscribeResourceGeneralState;
        static SIGNED_LONG_INTEGER SubscribeDeviceMessages;
        static SIGNED_LONG_INTEGER SubscribeDeviceLogging;
        static SIGNED_LONG_INTEGER SubscribeDeviceConfigurationChange;
        static SIGNED_LONG_INTEGER Subscribe;
        static SIGNED_LONG_INTEGER MonitoringAlarm;
        static SIGNED_LONG_INTEGER MonitoringAreasNotReadyToArm;
        static SIGNED_LONG_INTEGER ArmAll;
        static SIGNED_LONG_INTEGER DisarmAll;
        static SIGNED_LONG_INTEGER MediaService;
        static SIGNED_LONG_INTEGER MediaServicePlaybackState;
        static SIGNED_LONG_INTEGER MediaServiceSubscriptionState;
        static SIGNED_LONG_INTEGER ArtworkMode;
        static SIGNED_LONG_INTEGER DisplayMode;
        static SIGNED_LONG_INTEGER MonitoringUsers;
        static SIGNED_LONG_INTEGER MonitoringAreaAlarm;
        static SIGNED_LONG_INTEGER MonitoringZoneAlarm;
        static SIGNED_LONG_INTEGER MonitoringTamper;
        static SIGNED_LONG_INTEGER MonitoringAlarmMemory;
        static SIGNED_LONG_INTEGER MonitoringAreaAlarmMemory;
        static SIGNED_LONG_INTEGER MonitoringZoneAlarmMemory;
        static SIGNED_LONG_INTEGER MonitoringFireAlarm;
        static SIGNED_LONG_INTEGER MonitoringFireAlarmMemory;
        static SIGNED_LONG_INTEGER MonitoringResourceExitTime;
        static SIGNED_LONG_INTEGER MonitoringSoftwareVersion;
        static SIGNED_LONG_INTEGER AvrZone1;
        static SIGNED_LONG_INTEGER AvrZone2;
        static SIGNED_LONG_INTEGER AvrZone3;
        static SIGNED_LONG_INTEGER AvrZone4;
        static SIGNED_LONG_INTEGER AvrZone5;
    };

    static class DevicePropertyRenderHint // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER OnOff;
        static SIGNED_LONG_INTEGER OnOffValues;
        static SIGNED_LONG_INTEGER SetpointTarget;
        static SIGNED_LONG_INTEGER SetpointActual;
        static SIGNED_LONG_INTEGER Slider;
        static SIGNED_LONG_INTEGER Status;
    };

    static class TransportType // enum
    {
        static SIGNED_LONG_INTEGER Serial;
        static SIGNED_LONG_INTEGER Ir;
    };

    static class FeedbackSupportEnum // enum
    {
        static SIGNED_LONG_INTEGER NoSupport;
        static SIGNED_LONG_INTEGER HeaderOnly;
        static SIGNED_LONG_INTEGER FullSupport;
    };

    static class DownloadManagerErrorType // enum
    {
        static SIGNED_LONG_INTEGER Search;
        static SIGNED_LONG_INTEGER Download;
    };

    static class DevicePropertyType // enum
    {
        static SIGNED_LONG_INTEGER Uninitialized;
        static SIGNED_LONG_INTEGER Boolean;
        static SIGNED_LONG_INTEGER String;
        static SIGNED_LONG_INTEGER Int16;
        static SIGNED_LONG_INTEGER UInt16;
        static SIGNED_LONG_INTEGER Int32;
        static SIGNED_LONG_INTEGER UInt32;
        static SIGNED_LONG_INTEGER Int64;
        static SIGNED_LONG_INTEGER UInt64;
        static SIGNED_LONG_INTEGER Float;
        static SIGNED_LONG_INTEGER Double;
        static SIGNED_LONG_INTEGER LocalizedString;
    };

    static class eStringEncoding // enum
    {
        static SIGNED_LONG_INTEGER eEncodingUnknown;
        static SIGNED_LONG_INTEGER eEncodingASCII;
        static SIGNED_LONG_INTEGER eEncodingUTF16;
    };

    static class AuthenticationStatusType // enum
    {
        static SIGNED_LONG_INTEGER NotAuthenticated;
        static SIGNED_LONG_INTEGER Authenticated;
        static SIGNED_LONG_INTEGER Failed;
    };

    static class UserAttributeDataType // enum
    {
        static SIGNED_LONG_INTEGER String;
        static SIGNED_LONG_INTEGER Number;
        static SIGNED_LONG_INTEGER Boolean;
        static SIGNED_LONG_INTEGER Hex;
    };

    static class CommunicationType // enum
    {
        static SIGNED_LONG_INTEGER Serial;
        static SIGNED_LONG_INTEGER Ip;
        static SIGNED_LONG_INTEGER Ir;
        static SIGNED_LONG_INTEGER Cec;
        static SIGNED_LONG_INTEGER CrestronConnected;
        static SIGNED_LONG_INTEGER CloudConnected;
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER NotSpecified;
    };

    static class DeviceTypes // enum
    {
        static SIGNED_LONG_INTEGER FlatPanelDisplay;
        static SIGNED_LONG_INTEGER BlurayPlayer;
        static SIGNED_LONG_INTEGER CableBox;
        static SIGNED_LONG_INTEGER VideoServer;
        static SIGNED_LONG_INTEGER VideoConferenceCodec;
        static SIGNED_LONG_INTEGER AlarmSystem;
        static SIGNED_LONG_INTEGER PtzCamera;
        static SIGNED_LONG_INTEGER AvReceiver;
        static SIGNED_LONG_INTEGER Projector;
        static SIGNED_LONG_INTEGER SecuritySystem;
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER PoolController;
    };

    static class VideoServerStateObjects // enum
    {
        static SIGNED_LONG_INTEGER Connection;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER Authentication;
        static SIGNED_LONG_INTEGER WarmingUp;
        static SIGNED_LONG_INTEGER WarmedUp;
        static SIGNED_LONG_INTEGER CoolingDown;
        static SIGNED_LONG_INTEGER CooledDown;
        static SIGNED_LONG_INTEGER PoweredOn;
        static SIGNED_LONG_INTEGER PoweredOff;
        static SIGNED_LONG_INTEGER ActiveMediaService;
        static SIGNED_LONG_INTEGER ActiveMediaServicePlaybackState;
        static SIGNED_LONG_INTEGER Channel;
    };

    static class AutoAnswerModes // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class UserAttributeRequiredForConnectionType // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Before;
        static SIGNED_LONG_INTEGER After;
    };

    static class eTransportAdjustableProperties // enum
    {
        static SIGNED_LONG_INTEGER ComspecAdjustableBaud;
        static SIGNED_LONG_INTEGER ComspecAdjustableParity;
        static SIGNED_LONG_INTEGER ComspecAdjustableDataBits;
        static SIGNED_LONG_INTEGER ComspecAdjustableStopBits;
        static SIGNED_LONG_INTEGER ComspecAdjustableHardwareHandshaking;
        static SIGNED_LONG_INTEGER ComspecAdjustableSoftwareHandshaking;
        static SIGNED_LONG_INTEGER ComspecAdjustableDeviceId;
        static SIGNED_LONG_INTEGER EthernetAdjustablePort;
        static SIGNED_LONG_INTEGER EthernetAdjustableDeviceId;
    };

    static class DisplayStateObjects // enum
    {
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER Input;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER Connection;
        static SIGNED_LONG_INTEGER LampHours;
        static SIGNED_LONG_INTEGER EnergyStar;
        static SIGNED_LONG_INTEGER VideoMute;
        static SIGNED_LONG_INTEGER Volume;
        static SIGNED_LONG_INTEGER Mute;
        static SIGNED_LONG_INTEGER Authentication;
        static SIGNED_LONG_INTEGER AudioInput;
        static SIGNED_LONG_INTEGER VideoInput;
        static SIGNED_LONG_INTEGER WarmingUp;
        static SIGNED_LONG_INTEGER WarmedUp;
        static SIGNED_LONG_INTEGER CoolingDown;
        static SIGNED_LONG_INTEGER CooledDown;
        static SIGNED_LONG_INTEGER PoweredOn;
        static SIGNED_LONG_INTEGER PoweredOff;
        static SIGNED_LONG_INTEGER ActiveMediaService;
        static SIGNED_LONG_INTEGER ActiveMediaServicePlaybackState;
        static SIGNED_LONG_INTEGER Channel;
    };

     class StandardFeedback 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class PowerStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class MuteStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class MicMuteStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class StandbyStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class SelfviewStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER Auto;
    };

    static class TunerFrequencyBandStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER Am;
        static SIGNED_LONG_INTEGER Fm;
    };

    static class ResourceStatusFeedback // enum
    {
        static SIGNED_LONG_INTEGER Name;
        static SIGNED_LONG_INTEGER Unassigned;
        static SIGNED_LONG_INTEGER ArmedStay;
        static SIGNED_LONG_INTEGER ArmedAway;
        static SIGNED_LONG_INTEGER Disarmed;
        static SIGNED_LONG_INTEGER Bypassed;
        static SIGNED_LONG_INTEGER Unbypassed;
        static SIGNED_LONG_INTEGER Short;
        static SIGNED_LONG_INTEGER Missing;
        static SIGNED_LONG_INTEGER Error;
    };

    static class CompatibleFeedback // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Yes;
        static SIGNED_LONG_INTEGER No;
    };

    static class AuthorizationFeedback // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Authorized;
        static SIGNED_LONG_INTEGER Unauthorized;
    };

    static class InputTypesFeeback // enum
    {
        static SIGNED_LONG_INTEGER Vga1;
        static SIGNED_LONG_INTEGER Vga2;
        static SIGNED_LONG_INTEGER Vga3;
        static SIGNED_LONG_INTEGER Vga4;
        static SIGNED_LONG_INTEGER Vga5;
        static SIGNED_LONG_INTEGER Vga6;
        static SIGNED_LONG_INTEGER Vga7;
        static SIGNED_LONG_INTEGER Vga8;
        static SIGNED_LONG_INTEGER Vga9;
        static SIGNED_LONG_INTEGER Vga10;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER Hdmi7;
        static SIGNED_LONG_INTEGER Hdmi8;
        static SIGNED_LONG_INTEGER Hdmi9;
        static SIGNED_LONG_INTEGER Hdmi10;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER Dvi2;
        static SIGNED_LONG_INTEGER Dvi3;
        static SIGNED_LONG_INTEGER Dvi4;
        static SIGNED_LONG_INTEGER Dvi5;
        static SIGNED_LONG_INTEGER Dvi6;
        static SIGNED_LONG_INTEGER Dvi7;
        static SIGNED_LONG_INTEGER Dvi8;
        static SIGNED_LONG_INTEGER Dvi9;
        static SIGNED_LONG_INTEGER Dvi10;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Component3;
        static SIGNED_LONG_INTEGER Component4;
        static SIGNED_LONG_INTEGER Component5;
        static SIGNED_LONG_INTEGER Component6;
        static SIGNED_LONG_INTEGER Component7;
        static SIGNED_LONG_INTEGER Component8;
        static SIGNED_LONG_INTEGER Component9;
        static SIGNED_LONG_INTEGER Component10;
        static SIGNED_LONG_INTEGER Composite1;
        static SIGNED_LONG_INTEGER Composite2;
        static SIGNED_LONG_INTEGER Composite3;
        static SIGNED_LONG_INTEGER Composite4;
        static SIGNED_LONG_INTEGER Composite5;
        static SIGNED_LONG_INTEGER Composite6;
        static SIGNED_LONG_INTEGER Composite7;
        static SIGNED_LONG_INTEGER Composite8;
        static SIGNED_LONG_INTEGER Composite9;
        static SIGNED_LONG_INTEGER Composite10;
        static SIGNED_LONG_INTEGER DisplayPort1;
        static SIGNED_LONG_INTEGER DisplayPort2;
        static SIGNED_LONG_INTEGER DisplayPort3;
        static SIGNED_LONG_INTEGER DisplayPort4;
        static SIGNED_LONG_INTEGER DisplayPort5;
        static SIGNED_LONG_INTEGER DisplayPort6;
        static SIGNED_LONG_INTEGER DisplayPort7;
        static SIGNED_LONG_INTEGER DisplayPort8;
        static SIGNED_LONG_INTEGER DisplayPort9;
        static SIGNED_LONG_INTEGER DisplayPort10;
        static SIGNED_LONG_INTEGER Usb1;
        static SIGNED_LONG_INTEGER Usb2;
        static SIGNED_LONG_INTEGER Usb3;
        static SIGNED_LONG_INTEGER Usb4;
        static SIGNED_LONG_INTEGER Usb5;
        static SIGNED_LONG_INTEGER Antenna1;
        static SIGNED_LONG_INTEGER Antenna2;
        static SIGNED_LONG_INTEGER Network1;
        static SIGNED_LONG_INTEGER Network2;
        static SIGNED_LONG_INTEGER Network3;
        static SIGNED_LONG_INTEGER Network4;
        static SIGNED_LONG_INTEGER Network5;
        static SIGNED_LONG_INTEGER Network6;
        static SIGNED_LONG_INTEGER Network7;
        static SIGNED_LONG_INTEGER Network8;
        static SIGNED_LONG_INTEGER Network9;
        static SIGNED_LONG_INTEGER Network10;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Aux1;
        static SIGNED_LONG_INTEGER Aux2;
        static SIGNED_LONG_INTEGER Dvd1;
        static SIGNED_LONG_INTEGER Sat1;
        static SIGNED_LONG_INTEGER Tv;
        static SIGNED_LONG_INTEGER Dss1;
    };

    static class CallDirectionFeedback // enum
    {
        static SIGNED_LONG_INTEGER Incoming;
        static SIGNED_LONG_INTEGER Outgoing;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class CallStateFeedback // enum
    {
        static SIGNED_LONG_INTEGER Dialing;
        static SIGNED_LONG_INTEGER Ringing;
        static SIGNED_LONG_INTEGER Connecting;
        static SIGNED_LONG_INTEGER Connected;
        static SIGNED_LONG_INTEGER Disconnecting;
        static SIGNED_LONG_INTEGER OnHold;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class CallProtocolFeedback // enum
    {
        static SIGNED_LONG_INTEGER H320;
        static SIGNED_LONG_INTEGER H323;
        static SIGNED_LONG_INTEGER SIP;
        static SIGNED_LONG_INTEGER Spark;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class CallTypeFeedback // enum
    {
        static SIGNED_LONG_INTEGER Video;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class AllowFarEndControlOfNearEndCameraFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class MuteMicsOnAutoAnswerFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class AutoAnswerFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class DoNotDisturbFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class EncryptionFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class EnergyStarFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class VideoMuteStatesFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class OnScreenDisplayFeedback // enum
    {
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
    };

    static class DevicePropertyUnit // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Celsius;
        static SIGNED_LONG_INTEGER Fahrenheit;
        static SIGNED_LONG_INTEGER Percentage;
        static SIGNED_LONG_INTEGER Millivolts;
        static SIGNED_LONG_INTEGER PartsPerMillion;
        static SIGNED_LONG_INTEGER GramsPerLiter;
        static SIGNED_LONG_INTEGER Hours;
        static SIGNED_LONG_INTEGER Minutes;
        static SIGNED_LONG_INTEGER Seconds;
        static SIGNED_LONG_INTEGER Milliseconds;
    };

    static class MessageType // enum
    {
        static SIGNED_LONG_INTEGER Popup;
        static SIGNED_LONG_INTEGER Alert;
        static SIGNED_LONG_INTEGER IncomingCall;
    };

    static class EndPointLocation // enum
    {
        static SIGNED_LONG_INTEGER NearEnd;
        static SIGNED_LONG_INTEGER FarEnd;
    };

    static class ErrorState // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Nominal;
        static SIGNED_LONG_INTEGER Generic;
        static SIGNED_LONG_INTEGER Missing;
        static SIGNED_LONG_INTEGER Unassigned;
    };

    static class ethernetProtocol // enum
    {
        static SIGNED_LONG_INTEGER Tcp;
        static SIGNED_LONG_INTEGER NotSpecified;
    };

    static class SurroundModeType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Movie;
        static SIGNED_LONG_INTEGER Music;
        static SIGNED_LONG_INTEGER Game;
        static SIGNED_LONG_INTEGER Direct;
        static SIGNED_LONG_INTEGER PureDirect;
        static SIGNED_LONG_INTEGER Stereo;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER DolbyDigital;
        static SIGNED_LONG_INTEGER DtsSurround;
        static SIGNED_LONG_INTEGER Thx;
    };

    static class DevicePropertyAttributes // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER ReadOnly;
        static SIGNED_LONG_INTEGER MinValue;
        static SIGNED_LONG_INTEGER MaxValue;
        static SIGNED_LONG_INTEGER StepSize;
    };

    static class StandardCommandsEnum // enum
    {
        static SIGNED_LONG_INTEGER NotAStandardCommand;
        static SIGNED_LONG_INTEGER Vga1;
        static SIGNED_LONG_INTEGER Vga2;
        static SIGNED_LONG_INTEGER Vga3;
        static SIGNED_LONG_INTEGER Vga4;
        static SIGNED_LONG_INTEGER Vga5;
        static SIGNED_LONG_INTEGER Vga6;
        static SIGNED_LONG_INTEGER Vga7;
        static SIGNED_LONG_INTEGER Vga8;
        static SIGNED_LONG_INTEGER Vga9;
        static SIGNED_LONG_INTEGER Vga10;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER Hdmi7;
        static SIGNED_LONG_INTEGER Hdmi8;
        static SIGNED_LONG_INTEGER Hdmi9;
        static SIGNED_LONG_INTEGER Hdmi10;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER Dvi2;
        static SIGNED_LONG_INTEGER Dvi3;
        static SIGNED_LONG_INTEGER Dvi4;
        static SIGNED_LONG_INTEGER Dvi5;
        static SIGNED_LONG_INTEGER Dvi6;
        static SIGNED_LONG_INTEGER Dvi7;
        static SIGNED_LONG_INTEGER Dvi8;
        static SIGNED_LONG_INTEGER Dvi9;
        static SIGNED_LONG_INTEGER Dvi10;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Component3;
        static SIGNED_LONG_INTEGER Component4;
        static SIGNED_LONG_INTEGER Component5;
        static SIGNED_LONG_INTEGER Component6;
        static SIGNED_LONG_INTEGER Component7;
        static SIGNED_LONG_INTEGER Component8;
        static SIGNED_LONG_INTEGER Component9;
        static SIGNED_LONG_INTEGER Component10;
        static SIGNED_LONG_INTEGER Composite1;
        static SIGNED_LONG_INTEGER Composite2;
        static SIGNED_LONG_INTEGER Composite3;
        static SIGNED_LONG_INTEGER Composite4;
        static SIGNED_LONG_INTEGER Composite5;
        static SIGNED_LONG_INTEGER Composite6;
        static SIGNED_LONG_INTEGER Composite7;
        static SIGNED_LONG_INTEGER Composite8;
        static SIGNED_LONG_INTEGER Composite9;
        static SIGNED_LONG_INTEGER Composite10;
        static SIGNED_LONG_INTEGER DisplayPort1;
        static SIGNED_LONG_INTEGER DisplayPort2;
        static SIGNED_LONG_INTEGER DisplayPort3;
        static SIGNED_LONG_INTEGER DisplayPort4;
        static SIGNED_LONG_INTEGER DisplayPort5;
        static SIGNED_LONG_INTEGER DisplayPort6;
        static SIGNED_LONG_INTEGER DisplayPort7;
        static SIGNED_LONG_INTEGER DisplayPort8;
        static SIGNED_LONG_INTEGER DisplayPort9;
        static SIGNED_LONG_INTEGER DisplayPort10;
        static SIGNED_LONG_INTEGER Usb1;
        static SIGNED_LONG_INTEGER Usb2;
        static SIGNED_LONG_INTEGER Usb3;
        static SIGNED_LONG_INTEGER Usb4;
        static SIGNED_LONG_INTEGER Usb5;
        static SIGNED_LONG_INTEGER Antenna1;
        static SIGNED_LONG_INTEGER Antenna2;
        static SIGNED_LONG_INTEGER Network1;
        static SIGNED_LONG_INTEGER Network2;
        static SIGNED_LONG_INTEGER Network3;
        static SIGNED_LONG_INTEGER Network4;
        static SIGNED_LONG_INTEGER Network5;
        static SIGNED_LONG_INTEGER Network6;
        static SIGNED_LONG_INTEGER Network7;
        static SIGNED_LONG_INTEGER Network8;
        static SIGNED_LONG_INTEGER Network9;
        static SIGNED_LONG_INTEGER Network10;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Input11;
        static SIGNED_LONG_INTEGER Input12;
        static SIGNED_LONG_INTEGER Input13;
        static SIGNED_LONG_INTEGER Input14;
        static SIGNED_LONG_INTEGER Input15;
        static SIGNED_LONG_INTEGER InputPoll;
        static SIGNED_LONG_INTEGER AspectSideBar;
        static SIGNED_LONG_INTEGER AspectStrech;
        static SIGNED_LONG_INTEGER AspectNormal;
        static SIGNED_LONG_INTEGER AspectDotByDot;
        static SIGNED_LONG_INTEGER AspectFullScreen;
        static SIGNED_LONG_INTEGER AspectAuto;
        static SIGNED_LONG_INTEGER AspectOriginal;
        static SIGNED_LONG_INTEGER Aspect16By9;
        static SIGNED_LONG_INTEGER AspectWideZoom;
        static SIGNED_LONG_INTEGER Aspect4By3;
        static SIGNED_LONG_INTEGER AspectSubTitle;
        static SIGNED_LONG_INTEGER AspectJust;
        static SIGNED_LONG_INTEGER AspectZoom;
        static SIGNED_LONG_INTEGER AspectZoom2;
        static SIGNED_LONG_INTEGER AspectZoom3;
        static SIGNED_LONG_INTEGER AspectRatio1;
        static SIGNED_LONG_INTEGER AspectRatio2;
        static SIGNED_LONG_INTEGER AspectRatio3;
        static SIGNED_LONG_INTEGER AspectRatio4;
        static SIGNED_LONG_INTEGER AspectRatio5;
        static SIGNED_LONG_INTEGER AspectRatio6;
        static SIGNED_LONG_INTEGER AspectRatio7;
        static SIGNED_LONG_INTEGER AspectRatio8;
        static SIGNED_LONG_INTEGER AspectRatio9;
        static SIGNED_LONG_INTEGER AspectRatio10;
        static SIGNED_LONG_INTEGER AspectRatio11;
        static SIGNED_LONG_INTEGER AspectRatioPoll;
        static SIGNED_LONG_INTEGER AvAuto;
        static SIGNED_LONG_INTEGER AvGame;
        static SIGNED_LONG_INTEGER AvGame3D;
        static SIGNED_LONG_INTEGER AvDynamic;
        static SIGNED_LONG_INTEGER AvDynamicFixed;
        static SIGNED_LONG_INTEGER AvMovie;
        static SIGNED_LONG_INTEGER AvMovie3D;
        static SIGNED_LONG_INTEGER AvPc;
        static SIGNED_LONG_INTEGER AvPoll;
        static SIGNED_LONG_INTEGER AvUser;
        static SIGNED_LONG_INTEGER AvVintageMovie;
        static SIGNED_LONG_INTEGER AvStandard;
        static SIGNED_LONG_INTEGER AvStandard3D;
        static SIGNED_LONG_INTEGER AvXvColor;
        static SIGNED_LONG_INTEGER AllLampsOff;
        static SIGNED_LONG_INTEGER AllLampsOn;
        static SIGNED_LONG_INTEGER Antenna;
        static SIGNED_LONG_INTEGER Asterisk;
        static SIGNED_LONG_INTEGER Mute;
        static SIGNED_LONG_INTEGER MuteOff;
        static SIGNED_LONG_INTEGER MuteOn;
        static SIGNED_LONG_INTEGER MutePoll;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER Aux1;
        static SIGNED_LONG_INTEGER Aux2;
        static SIGNED_LONG_INTEGER DigitalChannel;
        static SIGNED_LONG_INTEGER AnalogChannel;
        static SIGNED_LONG_INTEGER Channel;
        static SIGNED_LONG_INTEGER ChannelUp;
        static SIGNED_LONG_INTEGER ChannelDown;
        static SIGNED_LONG_INTEGER ChannelPoll;
        static SIGNED_LONG_INTEGER Tune;
        static SIGNED_LONG_INTEGER Eject;
        static SIGNED_LONG_INTEGER OnScreenDisplay;
        static SIGNED_LONG_INTEGER OnScreenDisplayOff;
        static SIGNED_LONG_INTEGER OnScreenDisplayOn;
        static SIGNED_LONG_INTEGER OnScreenDisplayPoll;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER PowerOff;
        static SIGNED_LONG_INTEGER PowerOn;
        static SIGNED_LONG_INTEGER PowerPoll;
        static SIGNED_LONG_INTEGER Vol;
        static SIGNED_LONG_INTEGER VolMinus;
        static SIGNED_LONG_INTEGER VolPlus;
        static SIGNED_LONG_INTEGER VolumePoll;
        static SIGNED_LONG_INTEGER _0;
        static SIGNED_LONG_INTEGER _1;
        static SIGNED_LONG_INTEGER _2;
        static SIGNED_LONG_INTEGER _3;
        static SIGNED_LONG_INTEGER _4;
        static SIGNED_LONG_INTEGER _5;
        static SIGNED_LONG_INTEGER _6;
        static SIGNED_LONG_INTEGER _7;
        static SIGNED_LONG_INTEGER _8;
        static SIGNED_LONG_INTEGER _9;
        static SIGNED_LONG_INTEGER Octothorpe;
        static SIGNED_LONG_INTEGER Nop;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER DownArrow;
        static SIGNED_LONG_INTEGER LeftArrow;
        static SIGNED_LONG_INTEGER RightArrow;
        static SIGNED_LONG_INTEGER UpArrow;
        static SIGNED_LONG_INTEGER Select;
        static SIGNED_LONG_INTEGER Enter;
        static SIGNED_LONG_INTEGER Home;
        static SIGNED_LONG_INTEGER Clear;
        static SIGNED_LONG_INTEGER Display;
        static SIGNED_LONG_INTEGER Exit;
        static SIGNED_LONG_INTEGER Blue;
        static SIGNED_LONG_INTEGER Green;
        static SIGNED_LONG_INTEGER Red;
        static SIGNED_LONG_INTEGER Yellow;
        static SIGNED_LONG_INTEGER Options;
        static SIGNED_LONG_INTEGER ForwardScan;
        static SIGNED_LONG_INTEGER ReverseScan;
        static SIGNED_LONG_INTEGER Pause;
        static SIGNED_LONG_INTEGER Play;
        static SIGNED_LONG_INTEGER PlayPause;
        static SIGNED_LONG_INTEGER Repeat;
        static SIGNED_LONG_INTEGER Return;
        static SIGNED_LONG_INTEGER Stop;
        static SIGNED_LONG_INTEGER Subtitle;
        static SIGNED_LONG_INTEGER TopMenu;
        static SIGNED_LONG_INTEGER ForwardSkip;
        static SIGNED_LONG_INTEGER ReverseSkip;
        static SIGNED_LONG_INTEGER PopUpMenu;
        static SIGNED_LONG_INTEGER Menu;
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER A;
        static SIGNED_LONG_INTEGER B;
        static SIGNED_LONG_INTEGER C;
        static SIGNED_LONG_INTEGER D;
        static SIGNED_LONG_INTEGER Back;
        static SIGNED_LONG_INTEGER Dvr;
        static SIGNED_LONG_INTEGER Favorite;
        static SIGNED_LONG_INTEGER Guide;
        static SIGNED_LONG_INTEGER Last;
        static SIGNED_LONG_INTEGER Live;
        static SIGNED_LONG_INTEGER PageDown;
        static SIGNED_LONG_INTEGER PageUp;
        static SIGNED_LONG_INTEGER Record;
        static SIGNED_LONG_INTEGER Replay;
        static SIGNED_LONG_INTEGER SpeedSlow;
        static SIGNED_LONG_INTEGER LampHoursPoll;
        static SIGNED_LONG_INTEGER KeypadBackSpace;
        static SIGNED_LONG_INTEGER PlayBackStatusPoll;
        static SIGNED_LONG_INTEGER TrackPoll;
        static SIGNED_LONG_INTEGER ChapterPoll;
        static SIGNED_LONG_INTEGER TrackElapsedTimePoll;
        static SIGNED_LONG_INTEGER ChapterElapsedTimePoll;
        static SIGNED_LONG_INTEGER TotalElapsedTimePoll;
        static SIGNED_LONG_INTEGER TrackRemainingTimePoll;
        static SIGNED_LONG_INTEGER ChapterRemainingTimePoll;
        static SIGNED_LONG_INTEGER TotalRemainingTimePoll;
        static SIGNED_LONG_INTEGER ThumbsUp;
        static SIGNED_LONG_INTEGER ThumbsDown;
        static SIGNED_LONG_INTEGER Dash;
        static SIGNED_LONG_INTEGER Period;
        static SIGNED_LONG_INTEGER EnergyStar;
        static SIGNED_LONG_INTEGER EnergyStarOn;
        static SIGNED_LONG_INTEGER EnergyStarOff;
        static SIGNED_LONG_INTEGER EnergyStarPoll;
        static SIGNED_LONG_INTEGER VideoMute;
        static SIGNED_LONG_INTEGER VideoMuteOn;
        static SIGNED_LONG_INTEGER VideoMuteOff;
        static SIGNED_LONG_INTEGER VideoMutePoll;
        static SIGNED_LONG_INTEGER CustomCommand;
        static SIGNED_LONG_INTEGER FunctionButton1;
        static SIGNED_LONG_INTEGER FunctionButton2;
        static SIGNED_LONG_INTEGER FunctionButton3;
        static SIGNED_LONG_INTEGER FunctionButton4;
        static SIGNED_LONG_INTEGER FunctionButton5;
        static SIGNED_LONG_INTEGER FunctionButton6;
        static SIGNED_LONG_INTEGER FunctionButton7;
        static SIGNED_LONG_INTEGER FunctionButton8;
        static SIGNED_LONG_INTEGER SetSystemStateToArmAway;
        static SIGNED_LONG_INTEGER SetSystemStateToArmInstant;
        static SIGNED_LONG_INTEGER SetSystemStateToArmStay;
        static SIGNED_LONG_INTEGER SetSystemStateToDisarmed;
        static SIGNED_LONG_INTEGER MicMute;
        static SIGNED_LONG_INTEGER MicMuteOn;
        static SIGNED_LONG_INTEGER MicMuteOff;
        static SIGNED_LONG_INTEGER MicMutePoll;
        static SIGNED_LONG_INTEGER DialMeeting;
        static SIGNED_LONG_INTEGER DialAddressBook;
        static SIGNED_LONG_INTEGER DialManual;
        static SIGNED_LONG_INTEGER SelfView;
        static SIGNED_LONG_INTEGER SelfViewOn;
        static SIGNED_LONG_INTEGER SelfViewOff;
        static SIGNED_LONG_INTEGER SelfViewAuto;
        static SIGNED_LONG_INTEGER SelfViewPoll;
        static SIGNED_LONG_INTEGER SelfViewPipLocation;
        static SIGNED_LONG_INTEGER SelfViewMonitor;
        static SIGNED_LONG_INTEGER SelfViewFullScreenOn;
        static SIGNED_LONG_INTEGER SelfViewFullScreenOff;
        static SIGNED_LONG_INTEGER PictureMode;
        static SIGNED_LONG_INTEGER PresentationStart;
        static SIGNED_LONG_INTEGER PresentationStop;
        static SIGNED_LONG_INTEGER PipLocation;
        static SIGNED_LONG_INTEGER PipLocationPoll;
        static SIGNED_LONG_INTEGER MainVideoSource;
        static SIGNED_LONG_INTEGER MainVideoSourcePoll;
        static SIGNED_LONG_INTEGER CameraFarEndPanLeft;
        static SIGNED_LONG_INTEGER CameraFarEndPanRight;
        static SIGNED_LONG_INTEGER CameraFarEndTiltUp;
        static SIGNED_LONG_INTEGER CameraFarEndTiltDown;
        static SIGNED_LONG_INTEGER CameraFarEndZoomIn;
        static SIGNED_LONG_INTEGER CameraFarEndZoomOut;
        static SIGNED_LONG_INTEGER CameraFarEndFocusNear;
        static SIGNED_LONG_INTEGER CameraFarEndFocusFar;
        static SIGNED_LONG_INTEGER CameraFarEndStop;
        static SIGNED_LONG_INTEGER CameraFarEndStopPan;
        static SIGNED_LONG_INTEGER CameraFarEndStopTilt;
        static SIGNED_LONG_INTEGER CameraFarEndStopZoom;
        static SIGNED_LONG_INTEGER CameraFarEndStopFocus;
        static SIGNED_LONG_INTEGER CameraFarEndAutoFocus;
        static SIGNED_LONG_INTEGER CameraFarEndStorePreset;
        static SIGNED_LONG_INTEGER CameraFarEndRecallPreset;
        static SIGNED_LONG_INTEGER CameraNearEndPanLeft;
        static SIGNED_LONG_INTEGER CameraNearEndPanRight;
        static SIGNED_LONG_INTEGER CameraNearEndTiltUp;
        static SIGNED_LONG_INTEGER CameraNearEndTiltDown;
        static SIGNED_LONG_INTEGER CameraNearEndZoomIn;
        static SIGNED_LONG_INTEGER CameraNearEndZoomOut;
        static SIGNED_LONG_INTEGER CameraNearEndFocusNear;
        static SIGNED_LONG_INTEGER CameraNearEndFocusFar;
        static SIGNED_LONG_INTEGER CameraNearEndStop;
        static SIGNED_LONG_INTEGER CameraNearEndStopPan;
        static SIGNED_LONG_INTEGER CameraNearEndStopTilt;
        static SIGNED_LONG_INTEGER CameraNearEndStopZoom;
        static SIGNED_LONG_INTEGER CameraNearEndStopFocus;
        static SIGNED_LONG_INTEGER CameraNearEndAutoFocus;
        static SIGNED_LONG_INTEGER CameraNearEndResetPosition;
        static SIGNED_LONG_INTEGER CameraNearEndRecallPreset;
        static SIGNED_LONG_INTEGER CameraNearEndStorePreset;
        static SIGNED_LONG_INTEGER CameraTrackingOn;
        static SIGNED_LONG_INTEGER CameraTrackingOff;
        static SIGNED_LONG_INTEGER CameraRecallTrackingPreset;
        static SIGNED_LONG_INTEGER CameraStoreTrackingPreset;
        static SIGNED_LONG_INTEGER Answer;
        static SIGNED_LONG_INTEGER Dtmf;
        static SIGNED_LONG_INTEGER HangUp;
        static SIGNED_LONG_INTEGER Hold;
        static SIGNED_LONG_INTEGER Join;
        static SIGNED_LONG_INTEGER Reject;
        static SIGNED_LONG_INTEGER Resume;
        static SIGNED_LONG_INTEGER Transfer;
        static SIGNED_LONG_INTEGER AllowFecc;
        static SIGNED_LONG_INTEGER DoNotAllowFecc;
        static SIGNED_LONG_INTEGER MuteMicsAutoAnswerOn;
        static SIGNED_LONG_INTEGER MuteMicsAutoAnswerOff;
        static SIGNED_LONG_INTEGER DoNotDisturbOn;
        static SIGNED_LONG_INTEGER DoNotDisturbOff;
        static SIGNED_LONG_INTEGER AutoAnswerOn;
        static SIGNED_LONG_INTEGER AutoAnswerOff;
        static SIGNED_LONG_INTEGER StandbyOn;
        static SIGNED_LONG_INTEGER StandbyOff;
        static SIGNED_LONG_INTEGER EncryptionOn;
        static SIGNED_LONG_INTEGER EncryptionOff;
        static SIGNED_LONG_INTEGER Reboot;
        static SIGNED_LONG_INTEGER MessageResponse;
        static SIGNED_LONG_INTEGER MessageClear;
        static SIGNED_LONG_INTEGER AlertClear;
        static SIGNED_LONG_INTEGER Input4Dvi;
        static SIGNED_LONG_INTEGER Input4SVideoComposite;
        static SIGNED_LONG_INTEGER FarEndPresentationSource;
        static SIGNED_LONG_INTEGER MultipointAutoAnswerOn;
        static SIGNED_LONG_INTEGER MultipointAutoAnswerOff;
        static SIGNED_LONG_INTEGER MultipointAutoAnswerDoNotDisturb;
        static SIGNED_LONG_INTEGER MultipointModeAuto;
        static SIGNED_LONG_INTEGER MultipointModePresentation;
        static SIGNED_LONG_INTEGER MultipointModeDiscussion;
        static SIGNED_LONG_INTEGER MultipointModeFullScreen;
        static SIGNED_LONG_INTEGER Monitor1PresentationFar;
        static SIGNED_LONG_INTEGER Monitor1PresentationNearOrFar;
        static SIGNED_LONG_INTEGER Monitor1PresentationContentOrFar;
        static SIGNED_LONG_INTEGER Monitor1PresentationAll;
        static SIGNED_LONG_INTEGER Monitor2PresentationNear;
        static SIGNED_LONG_INTEGER Monitor2PresentationFar;
        static SIGNED_LONG_INTEGER Monitor2PresentationContent;
        static SIGNED_LONG_INTEGER Monitor2PresentationNearOrFar;
        static SIGNED_LONG_INTEGER Monitor2PresentationContentOrNear;
        static SIGNED_LONG_INTEGER Monitor2PresentationContentOrFar;
        static SIGNED_LONG_INTEGER Monitor2PresentationAll;
        static SIGNED_LONG_INTEGER Monitor3PresentationNear;
        static SIGNED_LONG_INTEGER Monitor3PresentationFar;
        static SIGNED_LONG_INTEGER Monitor3PresentationContent;
        static SIGNED_LONG_INTEGER Monitor3PresentationRecordNearOrFar;
        static SIGNED_LONG_INTEGER Monitor3PresentationRecordAll;
        static SIGNED_LONG_INTEGER IrRemoteEmulationKeyPress;
        static SIGNED_LONG_INTEGER IrRemoteEmulationKeyRelease;
        static SIGNED_LONG_INTEGER IrRemoteEmulationKeyClick;
        static SIGNED_LONG_INTEGER PhoneBookRequest;
        static SIGNED_LONG_INTEGER RecentCallsRequest;
        static SIGNED_LONG_INTEGER TunerFrequencyDown;
        static SIGNED_LONG_INTEGER TunerFrequencyUp;
        static SIGNED_LONG_INTEGER TunerFrequency;
        static SIGNED_LONG_INTEGER TunerAutoFrequencyDown;
        static SIGNED_LONG_INTEGER TunerAutoFrequencyUp;
        static SIGNED_LONG_INTEGER TunerFrequencyBand;
        static SIGNED_LONG_INTEGER TunerFrequencyBandAm;
        static SIGNED_LONG_INTEGER TunerFrequencyBandFm;
        static SIGNED_LONG_INTEGER TunerPresetRecall;
        static SIGNED_LONG_INTEGER TunerPresetStore;
        static SIGNED_LONG_INTEGER TunerFrequencyPoll;
        static SIGNED_LONG_INTEGER TunerPresetUp;
        static SIGNED_LONG_INTEGER TunerPresetDown;
        static SIGNED_LONG_INTEGER ToneControlOn;
        static SIGNED_LONG_INTEGER ToneControlOff;
        static SIGNED_LONG_INTEGER ToneSetBass;
        static SIGNED_LONG_INTEGER ToneBassLevelUp;
        static SIGNED_LONG_INTEGER ToneBassLevelDown;
        static SIGNED_LONG_INTEGER ToneSetTreble;
        static SIGNED_LONG_INTEGER ToneTrebleLevelUp;
        static SIGNED_LONG_INTEGER ToneTrebleLevelDown;
        static SIGNED_LONG_INTEGER LoudnessOn;
        static SIGNED_LONG_INTEGER LoudnessOff;
        static SIGNED_LONG_INTEGER LoudnessToggle;
        static SIGNED_LONG_INTEGER ToneStatePoll;
        static SIGNED_LONG_INTEGER ToneBassPoll;
        static SIGNED_LONG_INTEGER ToneTreblePoll;
        static SIGNED_LONG_INTEGER LoudnessPoll;
        static SIGNED_LONG_INTEGER ToneControlToggle;
        static SIGNED_LONG_INTEGER ToneBassReset;
        static SIGNED_LONG_INTEGER ToneTrebleReset;
        static SIGNED_LONG_INTEGER SurroundModeChange;
        static SIGNED_LONG_INTEGER SurroundModeCycle;
        static SIGNED_LONG_INTEGER SurroundModePoll;
        static SIGNED_LONG_INTEGER SurroundModeAuto;
        static SIGNED_LONG_INTEGER SurroundModeDirect;
        static SIGNED_LONG_INTEGER SurroundModeDolbyDigital;
        static SIGNED_LONG_INTEGER SurroundModeDtsSurround;
        static SIGNED_LONG_INTEGER SurroundModeGame;
        static SIGNED_LONG_INTEGER SurroundModeMovie;
        static SIGNED_LONG_INTEGER SurroundModeMusic;
        static SIGNED_LONG_INTEGER SurroundModePureDirect;
        static SIGNED_LONG_INTEGER SurroundModeStereo;
        static SIGNED_LONG_INTEGER InternetRadio;
        static SIGNED_LONG_INTEGER Sirius;
        static SIGNED_LONG_INTEGER Xm;
        static SIGNED_LONG_INTEGER SiriusXm;
        static SIGNED_LONG_INTEGER Pandora;
        static SIGNED_LONG_INTEGER LastFm;
        static SIGNED_LONG_INTEGER Rhapsody;
        static SIGNED_LONG_INTEGER HdRadio;
        static SIGNED_LONG_INTEGER Speaker1;
        static SIGNED_LONG_INTEGER Speaker2;
        static SIGNED_LONG_INTEGER Speaker3;
        static SIGNED_LONG_INTEGER Speaker4;
        static SIGNED_LONG_INTEGER Speaker5;
        static SIGNED_LONG_INTEGER Speaker6;
        static SIGNED_LONG_INTEGER Speaker7;
        static SIGNED_LONG_INTEGER Speaker8;
        static SIGNED_LONG_INTEGER Speaker9;
        static SIGNED_LONG_INTEGER Speaker10;
        static SIGNED_LONG_INTEGER Speaker11;
        static SIGNED_LONG_INTEGER Speaker12;
        static SIGNED_LONG_INTEGER Speaker13;
        static SIGNED_LONG_INTEGER Speaker14;
        static SIGNED_LONG_INTEGER Speaker15;
        static SIGNED_LONG_INTEGER Search;
        static SIGNED_LONG_INTEGER Optical1;
        static SIGNED_LONG_INTEGER Optical2;
        static SIGNED_LONG_INTEGER Optical3;
        static SIGNED_LONG_INTEGER Optical4;
        static SIGNED_LONG_INTEGER Optical5;
        static SIGNED_LONG_INTEGER Optical6;
        static SIGNED_LONG_INTEGER Optical7;
        static SIGNED_LONG_INTEGER Optical8;
        static SIGNED_LONG_INTEGER Optical9;
        static SIGNED_LONG_INTEGER Optical10;
        static SIGNED_LONG_INTEGER Coax1;
        static SIGNED_LONG_INTEGER Coax2;
        static SIGNED_LONG_INTEGER Coax3;
        static SIGNED_LONG_INTEGER Coax4;
        static SIGNED_LONG_INTEGER Coax5;
        static SIGNED_LONG_INTEGER Coax6;
        static SIGNED_LONG_INTEGER Coax7;
        static SIGNED_LONG_INTEGER Coax8;
        static SIGNED_LONG_INTEGER Coax9;
        static SIGNED_LONG_INTEGER Coax10;
        static SIGNED_LONG_INTEGER AnalogAudio1;
        static SIGNED_LONG_INTEGER AnalogAudio2;
        static SIGNED_LONG_INTEGER AnalogAudio3;
        static SIGNED_LONG_INTEGER AnalogAudio4;
        static SIGNED_LONG_INTEGER AnalogAudio5;
        static SIGNED_LONG_INTEGER AnalogAudio6;
        static SIGNED_LONG_INTEGER AnalogAudio7;
        static SIGNED_LONG_INTEGER AnalogAudio8;
        static SIGNED_LONG_INTEGER AnalogAudio9;
        static SIGNED_LONG_INTEGER AnalogAudio10;
        static SIGNED_LONG_INTEGER DVD;
        static SIGNED_LONG_INTEGER SAT;
        static SIGNED_LONG_INTEGER TV;
        static SIGNED_LONG_INTEGER CD;
        static SIGNED_LONG_INTEGER Tuner;
        static SIGNED_LONG_INTEGER Phono;
        static SIGNED_LONG_INTEGER DSS;
        static SIGNED_LONG_INTEGER AudioInputPoll;
        static SIGNED_LONG_INTEGER Spotify;
        static SIGNED_LONG_INTEGER YouTube;
        static SIGNED_LONG_INTEGER YouTubeTv;
        static SIGNED_LONG_INTEGER Netflix;
        static SIGNED_LONG_INTEGER Hulu;
        static SIGNED_LONG_INTEGER DirecTvNow;
        static SIGNED_LONG_INTEGER AmazonVideo;
        static SIGNED_LONG_INTEGER PlayStationVue;
        static SIGNED_LONG_INTEGER SlingTv;
        static SIGNED_LONG_INTEGER AirPlay;
        static SIGNED_LONG_INTEGER GoogleCast;
        static SIGNED_LONG_INTEGER Dlna;
        static SIGNED_LONG_INTEGER Tidal;
        static SIGNED_LONG_INTEGER Deezer;
        static SIGNED_LONG_INTEGER Crackle;
        static SIGNED_LONG_INTEGER OnDemand;
        static SIGNED_LONG_INTEGER GooglePlay;
        static SIGNED_LONG_INTEGER Bluetooth;
        static SIGNED_LONG_INTEGER Tivo;
        static SIGNED_LONG_INTEGER RSkip;
        static SIGNED_LONG_INTEGER FSkip;
        static SIGNED_LONG_INTEGER Bd1;
        static SIGNED_LONG_INTEGER Catv1;
        static SIGNED_LONG_INTEGER Game1;
        static SIGNED_LONG_INTEGER Pc1;
        static SIGNED_LONG_INTEGER Bluetooth1;
        static SIGNED_LONG_INTEGER MediaPlayer1;
        static SIGNED_LONG_INTEGER Ipod1;
        static SIGNED_LONG_INTEGER RequestSoftwareVersion;
        static SIGNED_LONG_INTEGER RequestSoftwareVersionDifferences;
        static SIGNED_LONG_INTEGER RequestEventLog;
        static SIGNED_LONG_INTEGER RequestAreasNotReadyToArm;
        static SIGNED_LONG_INTEGER Login;
        static SIGNED_LONG_INTEGER UDLLogin;
        static SIGNED_LONG_INTEGER Arm;
        static SIGNED_LONG_INTEGER ArmResource;
        static SIGNED_LONG_INTEGER Disarm;
        static SIGNED_LONG_INTEGER DisarmResource;
        static SIGNED_LONG_INTEGER RequestResourceStatus;
        static SIGNED_LONG_INTEGER BypassResource;
        static SIGNED_LONG_INTEGER UnbypassResource;
        static SIGNED_LONG_INTEGER RequestPermissionOutput;
        static SIGNED_LONG_INTEGER RequestPermissionArea;
        static SIGNED_LONG_INTEGER RequestPermissionZone;
        static SIGNED_LONG_INTEGER RequestPermissionDevice;
        static SIGNED_LONG_INTEGER RequestPermissionDoor;
        static SIGNED_LONG_INTEGER RequestName;
        static SIGNED_LONG_INTEGER Heartbeat;
        static SIGNED_LONG_INTEGER RequestSystemStatus;
        static SIGNED_LONG_INTEGER RequestSystemFeatureStatus;
        static SIGNED_LONG_INTEGER RequestSystemSetup;
        static SIGNED_LONG_INTEGER RequestAreaInformation;
        static SIGNED_LONG_INTEGER RequestZoneInformation;
        static SIGNED_LONG_INTEGER RequestOutputInformation;
        static SIGNED_LONG_INTEGER RequestDeviceInformation;
        static SIGNED_LONG_INTEGER RequestDoorInformation;
        static SIGNED_LONG_INTEGER RequestAreaCount;
        static SIGNED_LONG_INTEGER RequestZoneCount;
        static SIGNED_LONG_INTEGER RequestOutputCount;
        static SIGNED_LONG_INTEGER RequestDoorCount;
        static SIGNED_LONG_INTEGER RequestDeviceCount;
        static SIGNED_LONG_INTEGER RequestAreaResourceStatus;
        static SIGNED_LONG_INTEGER RequestZoneResourceStatus;
        static SIGNED_LONG_INTEGER RequestOutputResourceStatus;
        static SIGNED_LONG_INTEGER RequestDoorResourceStatus;
        static SIGNED_LONG_INTEGER RequestDeviceResourceStatus;
        static SIGNED_LONG_INTEGER SetResourceState;
        static SIGNED_LONG_INTEGER RequestBypassedResources;
        static SIGNED_LONG_INTEGER SilenceBells;
        static SIGNED_LONG_INTEGER ResetSensors;
        static SIGNED_LONG_INTEGER SubscribeResourceOnOffState;
        static SIGNED_LONG_INTEGER SubscribeResourceReadyState;
        static SIGNED_LONG_INTEGER SubscribeResourceGeneralState;
        static SIGNED_LONG_INTEGER SubscribeDeviceMessages;
        static SIGNED_LONG_INTEGER SubscribeDeviceLogging;
        static SIGNED_LONG_INTEGER SubscribeDeviceConfigurationChange;
        static SIGNED_LONG_INTEGER Subscribe;
        static SIGNED_LONG_INTEGER RequestAlarm;
        static SIGNED_LONG_INTEGER ArmAll;
        static SIGNED_LONG_INTEGER DisarmAll;
        static SIGNED_LONG_INTEGER BypassAll;
        static SIGNED_LONG_INTEGER UnbypassAll;
        static SIGNED_LONG_INTEGER KeypadAsterisk;
        static SIGNED_LONG_INTEGER KeypadDash;
        static SIGNED_LONG_INTEGER KeypadEnter;
        static SIGNED_LONG_INTEGER KeypadNumber;
        static SIGNED_LONG_INTEGER KeypadPeriod;
        static SIGNED_LONG_INTEGER KeypadPound;
        static SIGNED_LONG_INTEGER KeypadSendString;
        static SIGNED_LONG_INTEGER KeypadAux;
        static SIGNED_LONG_INTEGER RequestUsers;
        static SIGNED_LONG_INTEGER RequestAreaAlarm;
        static SIGNED_LONG_INTEGER RequestZoneAlarm;
        static SIGNED_LONG_INTEGER RequestTamper;
        static SIGNED_LONG_INTEGER RequestAlarmMemory;
        static SIGNED_LONG_INTEGER RequestAreaAlarmMemory;
        static SIGNED_LONG_INTEGER RequestZoneAlarmMemory;
        static SIGNED_LONG_INTEGER RequestFireAlarm;
        static SIGNED_LONG_INTEGER RequestFireAlarmMemory;
        static SIGNED_LONG_INTEGER RequestResourceExitTime;
    };

    static class VideoConnections // enum
    {
        static SIGNED_LONG_INTEGER Vga1;
        static SIGNED_LONG_INTEGER Vga2;
        static SIGNED_LONG_INTEGER Vga3;
        static SIGNED_LONG_INTEGER Vga4;
        static SIGNED_LONG_INTEGER Vga5;
        static SIGNED_LONG_INTEGER Vga6;
        static SIGNED_LONG_INTEGER Vga7;
        static SIGNED_LONG_INTEGER Vga8;
        static SIGNED_LONG_INTEGER Vga9;
        static SIGNED_LONG_INTEGER Vga10;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER Hdmi7;
        static SIGNED_LONG_INTEGER Hdmi8;
        static SIGNED_LONG_INTEGER Hdmi9;
        static SIGNED_LONG_INTEGER Hdmi10;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER Dvi2;
        static SIGNED_LONG_INTEGER Dvi3;
        static SIGNED_LONG_INTEGER Dvi4;
        static SIGNED_LONG_INTEGER Dvi5;
        static SIGNED_LONG_INTEGER Dvi6;
        static SIGNED_LONG_INTEGER Dvi7;
        static SIGNED_LONG_INTEGER Dvi8;
        static SIGNED_LONG_INTEGER Dvi9;
        static SIGNED_LONG_INTEGER Dvi10;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Component3;
        static SIGNED_LONG_INTEGER Component4;
        static SIGNED_LONG_INTEGER Component5;
        static SIGNED_LONG_INTEGER Component6;
        static SIGNED_LONG_INTEGER Component7;
        static SIGNED_LONG_INTEGER Component8;
        static SIGNED_LONG_INTEGER Component9;
        static SIGNED_LONG_INTEGER Component10;
        static SIGNED_LONG_INTEGER Composite1;
        static SIGNED_LONG_INTEGER Composite2;
        static SIGNED_LONG_INTEGER Composite3;
        static SIGNED_LONG_INTEGER Composite4;
        static SIGNED_LONG_INTEGER Composite5;
        static SIGNED_LONG_INTEGER Composite6;
        static SIGNED_LONG_INTEGER Composite7;
        static SIGNED_LONG_INTEGER Composite8;
        static SIGNED_LONG_INTEGER Composite9;
        static SIGNED_LONG_INTEGER Composite10;
        static SIGNED_LONG_INTEGER DisplayPort1;
        static SIGNED_LONG_INTEGER DisplayPort2;
        static SIGNED_LONG_INTEGER DisplayPort3;
        static SIGNED_LONG_INTEGER DisplayPort4;
        static SIGNED_LONG_INTEGER DisplayPort5;
        static SIGNED_LONG_INTEGER DisplayPort6;
        static SIGNED_LONG_INTEGER DisplayPort7;
        static SIGNED_LONG_INTEGER DisplayPort8;
        static SIGNED_LONG_INTEGER DisplayPort9;
        static SIGNED_LONG_INTEGER DisplayPort10;
        static SIGNED_LONG_INTEGER Usb1;
        static SIGNED_LONG_INTEGER Usb2;
        static SIGNED_LONG_INTEGER Usb3;
        static SIGNED_LONG_INTEGER Usb4;
        static SIGNED_LONG_INTEGER Usb5;
        static SIGNED_LONG_INTEGER Antenna1;
        static SIGNED_LONG_INTEGER Antenna2;
        static SIGNED_LONG_INTEGER Network1;
        static SIGNED_LONG_INTEGER Network2;
        static SIGNED_LONG_INTEGER Network3;
        static SIGNED_LONG_INTEGER Network4;
        static SIGNED_LONG_INTEGER Network5;
        static SIGNED_LONG_INTEGER Network6;
        static SIGNED_LONG_INTEGER Network7;
        static SIGNED_LONG_INTEGER Network8;
        static SIGNED_LONG_INTEGER Network9;
        static SIGNED_LONG_INTEGER Network10;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Input11;
        static SIGNED_LONG_INTEGER Input12;
        static SIGNED_LONG_INTEGER Input13;
        static SIGNED_LONG_INTEGER Input14;
        static SIGNED_LONG_INTEGER Input15;
        static SIGNED_LONG_INTEGER Aux1;
        static SIGNED_LONG_INTEGER Aux2;
        static SIGNED_LONG_INTEGER MediaInternetRadio;
        static SIGNED_LONG_INTEGER MediaSiriusRadio;
        static SIGNED_LONG_INTEGER MediaXmRadio;
        static SIGNED_LONG_INTEGER MediaSiriusXmRadio;
        static SIGNED_LONG_INTEGER MediaPandoraRadio;
        static SIGNED_LONG_INTEGER MediaLastFmRadio;
        static SIGNED_LONG_INTEGER MediaRhapsodyRadio;
        static SIGNED_LONG_INTEGER MediaHdRadio;
        static SIGNED_LONG_INTEGER Dvd1;
        static SIGNED_LONG_INTEGER Sat1;
        static SIGNED_LONG_INTEGER Tv1;
        static SIGNED_LONG_INTEGER Cd1;
        static SIGNED_LONG_INTEGER Tuner1;
        static SIGNED_LONG_INTEGER Phono1;
        static SIGNED_LONG_INTEGER Dss1;
        static SIGNED_LONG_INTEGER Spotify;
        static SIGNED_LONG_INTEGER YouTube;
        static SIGNED_LONG_INTEGER YouTubeTv;
        static SIGNED_LONG_INTEGER Netflix;
        static SIGNED_LONG_INTEGER Hulu;
        static SIGNED_LONG_INTEGER DirectvNow;
        static SIGNED_LONG_INTEGER AmazonVideo;
        static SIGNED_LONG_INTEGER PlaystationVue;
        static SIGNED_LONG_INTEGER SlingTv;
        static SIGNED_LONG_INTEGER Airplay;
        static SIGNED_LONG_INTEGER GoogleCast;
        static SIGNED_LONG_INTEGER DLNA;
        static SIGNED_LONG_INTEGER Tidal;
        static SIGNED_LONG_INTEGER Deezer;
        static SIGNED_LONG_INTEGER Crackle;
        static SIGNED_LONG_INTEGER OnDemand;
        static SIGNED_LONG_INTEGER Bd1;
        static SIGNED_LONG_INTEGER Catv1;
        static SIGNED_LONG_INTEGER Game1;
        static SIGNED_LONG_INTEGER Pc1;
        static SIGNED_LONG_INTEGER Bluetooth1;
        static SIGNED_LONG_INTEGER MediaPlayer1;
        static SIGNED_LONG_INTEGER Ipod1;
        static SIGNED_LONG_INTEGER Uncontrolled;
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER None;
    };

    static class StateSeverity // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Alarm;
        static SIGNED_LONG_INTEGER Error;
        static SIGNED_LONG_INTEGER Warning;
        static SIGNED_LONG_INTEGER Notice;
    };

    static class StateType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Inactive;
        static SIGNED_LONG_INTEGER Active;
    };

    static class DevicePropertyStates // enum
    {
        static SIGNED_LONG_INTEGER Default;
        static SIGNED_LONG_INTEGER Disabled;
        static SIGNED_LONG_INTEGER ValueNotAvailable;
    };

    static class VideoConnectionTypes // enum
    {
        static SIGNED_LONG_INTEGER Vga;
        static SIGNED_LONG_INTEGER Hdmi;
        static SIGNED_LONG_INTEGER Component;
        static SIGNED_LONG_INTEGER Composite;
        static SIGNED_LONG_INTEGER DisplayPort;
        static SIGNED_LONG_INTEGER Network;
        static SIGNED_LONG_INTEGER Antenna;
        static SIGNED_LONG_INTEGER Usb;
        static SIGNED_LONG_INTEGER Dvi;
        static SIGNED_LONG_INTEGER SVideo;
        static SIGNED_LONG_INTEGER Other;
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER HdBaseT;
        static SIGNED_LONG_INTEGER Universal;
        static SIGNED_LONG_INTEGER GenericAV;
        static SIGNED_LONG_INTEGER GenericVideo;
        static SIGNED_LONG_INTEGER None;
    };

    static class PresetEvent // enum
    {
        static SIGNED_LONG_INTEGER Saved;
        static SIGNED_LONG_INTEGER Recalled;
        static SIGNED_LONG_INTEGER Cleared;
    };

namespace Crestron.Panopto.Common;
        // class declarations
         class ACommunication;
         class EmptyCommunication;
         class Authentication2;
         class Authentication;
         class DatFileRootObject;
         class AuthenticationTypes;
         class Parameters;
         class PadDirections;
         class Types;
         class Commands;
         class SurroundProfile;
         class UserAttribute;
         class UserAttributeData;
         class DatFileInput;
         class GeneralInformation;
         class AuthenticationNode;
         class SupportedCommand;
         class DatFileMultiPowerOff;
         class ADeviceProperty;
         class PowerWaitPeriod;
         class DatACommunicationJsonConverter;
         class CommandAckNak;
         class DatFileFeature;
         class ADevicePreset;
         class UsernamePasswordAuthentication;
         class StandardCommandConverter;
         class EthernetDefaults;
         class CustomCommand;
         class Communication;
         class NoAuthentication;
         class CustomState;
         class CrestronDataStoreWrapper;
         class AuthenticationJsonConverter;
     class ACommunication 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING Type[];
        Crestron.Panopto.Common.AuthenticationNode authentication;

        // class properties
    };

     class EmptyCommunication 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING Type[];
        Crestron.Panopto.Common.AuthenticationNode authentication;

        // class properties
    };

     class DatFileRootObject 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING manufacturer[];
        STRING driverId[];
        Crestron.Panopto.Common.PowerWaitPeriod power;
        STRING deviceType[];
        Crestron.Panopto.Common.Enums.DeviceTypes deviceTypeId;
        STRING sdkVersion[];
        STRING driverVersion[];
        STRING description[];
        STRING baseModel[];
        Crestron.Panopto.Common.ACommunication communication;
        STRING driverVersionDate[];
        Crestron.Panopto.Common.DatFileMultiPowerOff multiPowerOff;

        // class properties
    };

    static class AuthenticationTypes 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING NONE[];
        static STRING USERNAME_PASSWORD[];

        // class properties
    };

     class Parameters 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Crestron.Panopto.Common.Parameters Type;
        STRING PadCharacter[];
        Crestron.Panopto.Common.Parameters PadDirection;

        // class properties
        STRING Id[];
        SIGNED_INTEGER Max;
        SIGNED_INTEGER Min;
        SIGNED_INTEGER StaticDataWidth;
        STRING value[];
    };

    static class PadDirections // enum
    {
        static SIGNED_LONG_INTEGER Left;
        static SIGNED_LONG_INTEGER Right;
    };

    static class Types // enum
    {
        static SIGNED_LONG_INTEGER String;
        static SIGNED_LONG_INTEGER AsciiToHex;
        static SIGNED_LONG_INTEGER DecimalToHex;
        static SIGNED_LONG_INTEGER HexString;
    };

     class Commands 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StandardCommandsEnum StandardCommand;
        STRING Command[];
    };

     class SurroundProfile 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Crestron.Panopto.Common.Enums.SurroundModeType ProfileEnum;
        STRING SurroundProfileName[];

        // class properties
    };

     class UserAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING TypeName[];
        STRING ParameterId[];
        STRING Label[];
        STRING Description[];
        STRING RequiredForConnection[];
        UserAttributeData Data;
    };

     class UserAttributeData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DataType[];
        STRING Mask[];
        STRING DefaultValue[];
    };

     class DatFileInput 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING inputDescription[];
        STRING inputConnector[];
        STRING inputType[];
        SIGNED_LONG_INTEGER index;

        // class properties
    };

     class GeneralInformation 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DeviceType[];
        STRING Manufacturer[];
        STRING BaseModel[];
        STRING DriverVersion[];
        STRING SdkVersion[];
        STRING Description[];
    };

     class AuthenticationNode 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

     class DatFileMultiPowerOff 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ADeviceProperty 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Key[];
        SIGNED_LONG_INTEGER LocalizedNameId;
        DevicePropertyAttributes Attributes;
        DevicePropertyType Type;
        DevicePropertyUnit Units;
        DevicePropertyRenderHint RenderHint;
        STRING ParentPropertyKey[];
        DevicePropertyStates State;
    };

     class PowerWaitPeriod 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LONG_INTEGER WarmUpTime;
        LONG_INTEGER CoolDownTime;
    };

     class DatACommunicationJsonConverter 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CommandAckNak 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Ack[];
        STRING Nak[];
    };

     class DatFileFeature 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING displayName[];
        STRING id[];

        // class properties
    };

     class ADevicePreset 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Id[];
        STRING Name[];
    };

     class UsernamePasswordAuthentication 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING UsernameMask[];
        STRING PasswordMask[];
        STRING DefaultUsername[];
        STRING DefaultPassword[];
    };

     class StandardCommandConverter 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class EthernetDefaults 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ethernetProtocol EthernetProtocol;
    };

     class CustomCommand 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Command[];
    };

     class Communication 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommunicationType CommunicationType;
        SIGNED_LONG_INTEGER Port;
        LONG_INTEGER TimeBetweenCommands;
        LONG_INTEGER ResponseTimeout;
        ethernetProtocol IpProtocol;
        AuthenticationNode Authentication;
        SIGNED_LONG_INTEGER DeviceId;
    };

     class NoAuthentication 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
    };

     class CustomState 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrestronDataStoreWrapper 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class AuthenticationJsonConverter 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.Panopto.Common.BasicDriver;
        // class declarations
         class TimelineEventHandler;
         class ABasicDriver;
         class CommandSet;
         class CommandPriority;
         class ValidatedRxData;
         class BaseRootObject;
         class CrestronSerialDeviceApi;
         class Api;
         class Feedback;
         class DriverClock;
         class ABaseDriverProtocol;
         class PowerState;
     class TimelineEventHandler 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ( SIGNED_LONG_INTEGER dueAt );
        FUNCTION Stop ();
        FUNCTION HandleTimelineEvent ( SIGNED_LONG_INTEGER currentTick );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DueAt;
        SIGNED_LONG_INTEGER EventInterval;
    };

     class ABasicDriver 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION OverrideUsername ( STRING username );
        FUNCTION OverridePassword ( STRING password );
        FUNCTION SetUserAttribute ( STRING attributeId , STRING attributeValue );
        FUNCTION SendCustomCommandByName ( STRING commandName , CommandAction action );
        FUNCTION ConvertJsonFileToDriverData ( STRING jsonString );
        FUNCTION Initialize ( BaseRootObject driverData );
        FUNCTION SendCustomCommand ( STRING command );
        FUNCTION SendCustomCommandValue ( STRING commandValue );
        FUNCTION Dispose ();
        FUNCTION Disconnect ();
        FUNCTION Reconnect ();
        FUNCTION Connect ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Port;
        STRING Description[];
        STRING Manufacturer[];
        STRING BaseModel[];
        STRING DriverVersion[];
        STRING UsernameMask[];
        STRING UsernameKey[];
        STRING PasswordMask[];
        STRING PasswordKey[];
        STRING DefaultUsername[];
        STRING DefaultPassword[];
        LONG_INTEGER MinimumResponseTime;
        LONG_INTEGER MaximumResponseTime;
    };

    static class CommandPriority // enum
    {
        static SIGNED_LONG_INTEGER Special;
        static SIGNED_LONG_INTEGER Highest;
        static SIGNED_LONG_INTEGER High;
        static SIGNED_LONG_INTEGER Normal;
        static SIGNED_LONG_INTEGER Low;
        static SIGNED_LONG_INTEGER Lowest;
    };

     class BaseRootObject 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CrestronSerialDeviceApi CrestronSerialDeviceApi;
    };

     class CrestronSerialDeviceApi 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        GeneralInformation GeneralInformation;
        Api Api;
    };

     class Api 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        Communication Communication;
        PowerWaitPeriod PowerWaitPeriod;
        Feedback Feedback;
    };

     class Feedback 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommandAckNak CommandAckNak;
        STRING Header[];
        LONG_INTEGER MinimumResponseTime;
        LONG_INTEGER MaximumResponseTime;
        STRING ConnectedStatePollCommand[];
    };

    static class DriverClock 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class PowerState // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER WarmingUp;
        static SIGNED_LONG_INTEGER CoolingDown;
    };

namespace Crestron.Panopto.Common.Helpers;
        // class declarations
         class CommonFeatureSupportHelper;
         class ParameterHelper;
         class OsHelper;
         class UserAttributeHelper;
         class AttributeTypeDefaults;
         class AttributeDetails;
         class AttributeField;
         class FieldAccessibility;
         class CommandHelper;
         class SendCommandResult;
         class SendCommandVariables;
         class WarmupCallbackVariables;
         class CoolingCallbackVariables;
    static class CommonFeatureSupportHelper 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GetDescription ( CommonFeatureSupport supportEnum );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class ParameterHelper 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION ReplaceParameter ( STRING Command , STRING Parameter , STRING NewValue );
        static STRING_FUNCTION FormatValue ( INTEGER Value , Parameters Parameter );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING IDParameter[];
        static STRING DataFormattingFlag[];
        static STRING DataTypeFlag[];

        // class properties
    };

    static class OsHelper 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION ConvertPathBasedOnOs ( STRING path );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class UserAttributeHelper 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class AttributeTypeDefaults 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        UserAttributeType AttributeType;
    };

    static class AttributeField // enum
    {
        static SIGNED_LONG_INTEGER AttributeType;
        static SIGNED_LONG_INTEGER ParameterId;
        static SIGNED_LONG_INTEGER Label;
        static SIGNED_LONG_INTEGER Description;
        static SIGNED_LONG_INTEGER DataType;
        static SIGNED_LONG_INTEGER DataMask;
        static SIGNED_LONG_INTEGER DefaultValue;
    };

    static class FieldAccessibility // enum
    {
        static SIGNED_LONG_INTEGER NotVisible;
        static SIGNED_LONG_INTEGER Editable;
        static SIGNED_LONG_INTEGER ReadOnly;
    };

    static class CommandHelper 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SendCommandResult 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SendCommandVariables 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CommandSet PendingRequest;
    };

     class WarmupCallbackVariables 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CoolingCallbackVariables 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.Panopto.Common.Transports;
        // class declarations
         class ComPortSpec;
         class ATransportDriver;
         class TcpTransport;
         class HttpsTransport;
         class SimplTransport;
         class HttpTransport;
         class DataObjects;
         class DriverMetadata;
         class TelnetTransport;
         class TcpSSLTransport;
         class RestTransport;
         class IrFileReader;
     class ComPortSpec 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ATransportDriver 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class TcpTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class HttpsTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING HttpsUserName[];
        STRING HttpsPassword[];

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class SimplTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        FUNCTION ReceiveData ( STRING data );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class HttpTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class DataObjects 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DriverMetadata 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DeviceType[];
        STRING Manufacturer[];
        STRING DeviceModel[];
    };

     class TelnetTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class TcpSSLTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class RestTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
        TransportType TransportType;
    };

     class IrFileReader 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION LoadIrFile ( STRING irFileName );
        FUNCTION TriggerFunctionRelease ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING Manufacturer[];
        STRING Model[];
        STRING DeviceType[];

        // class properties
    };

namespace Crestron.Panopto.Common.ExtensionMethods;
        // class declarations
         class ExtensionMethods;
    static class ExtensionMethods 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION PadCharacter ( STRING inputString , Parameters parameter );
        static STRING_FUNCTION GetSafeCommandString ( STRING commandString );
        static STRING_FUNCTION Unescape ( STRING inputString );
        static STRING_FUNCTION Escape ( STRING inputString );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.Panopto.Common.Events;
        // class declarations
         class DevicePropertyValueEventArgs;
         class DevicePropertyStateEventArgs;
         class DeviceSceneStateEventArgs;
         class ListChangedAction;
         class DevicePresetStateEventArgs;
         class AuthenticationEventArgs;
     class DevicePropertyValueEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Key[];
    };

    static class ListChangedAction // enum
    {
        static SIGNED_LONG_INTEGER Added;
        static SIGNED_LONG_INTEGER Removed;
        static SIGNED_LONG_INTEGER Replaced;
        static SIGNED_LONG_INTEGER Reset;
    };

namespace Crestron.Panopto.Common.Interfaces;
        // class declarations
         class DisplayMessageEnum;
         class StateConsts;
         class RecorderState;
         class SessionState;
         class CurrentPage;
         class PanoptoSession;
         class ConnectionFeedback;
         class PanoptoFeedback;
         class PreviewData;
    static class DisplayMessageEnum // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER LoggingIn;
        static SIGNED_LONG_INTEGER AbleToAccessRemoteRecorder;
        static SIGNED_LONG_INTEGER AccessingRemoteRecorder;
        static SIGNED_LONG_INTEGER SchedulingSession;
        static SIGNED_LONG_INTEGER UnableToScheduleSession;
        static SIGNED_LONG_INTEGER AbleToScheduleSession;
        static SIGNED_LONG_INTEGER StartingSessionEarly;
        static SIGNED_LONG_INTEGER UnableToStartSessionEarly;
        static SIGNED_LONG_INTEGER ExtendingSession;
        static SIGNED_LONG_INTEGER UnableToExtendSession;
        static SIGNED_LONG_INTEGER BeginningPreview;
        static SIGNED_LONG_INTEGER BeginningPause;
        static SIGNED_LONG_INTEGER Recording;
        static SIGNED_LONG_INTEGER Resuming;
        static SIGNED_LONG_INTEGER Stopping;
        static SIGNED_LONG_INTEGER UnableToStop;
        static SIGNED_LONG_INTEGER UnableToAccessRemoteRecorder;
        static SIGNED_LONG_INTEGER UnableToLogIn;
        static SIGNED_LONG_INTEGER NoNewSessions;
        static SIGNED_LONG_INTEGER UnableToResume;
        static SIGNED_LONG_INTEGER NewVideoPreview;
        static SIGNED_LONG_INTEGER NewAudioPreview;
        static SIGNED_LONG_INTEGER Processing;
        static SIGNED_LONG_INTEGER Uploading;
        static SIGNED_LONG_INTEGER InvalidRecordingName;
    };

    static class StateConsts 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING InitialState[];
        static STRING IdleState[];
        static STRING PreviewState[];
        static STRING BroadcastState[];
        static STRING RecordingState[];
        static STRING PauseState[];

        // class properties
    };

    static class RecorderState // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Previewing;
        static SIGNED_LONG_INTEGER Scheduled;
        static SIGNED_LONG_INTEGER Recording;
        static SIGNED_LONG_INTEGER Uploading;
        static SIGNED_LONG_INTEGER Processing;
        static SIGNED_LONG_INTEGER Complete;
        static SIGNED_LONG_INTEGER Stopped;
    };

    static class SessionState // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Created;
        static SIGNED_LONG_INTEGER Scheduled;
        static SIGNED_LONG_INTEGER Recording;
        static SIGNED_LONG_INTEGER Broadcasting;
        static SIGNED_LONG_INTEGER Processing;
        static SIGNED_LONG_INTEGER Uploading;
        static SIGNED_LONG_INTEGER Complete;
    };

    static class CurrentPage // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER AvailableAllDay;
        static SIGNED_LONG_INTEGER AvailableUpcomingMeeting;
        static SIGNED_LONG_INTEGER NowRecording;
        static SIGNED_LONG_INTEGER PreviewSelection;
        static SIGNED_LONG_INTEGER PausedRecording;
        static SIGNED_LONG_INTEGER RecordNow;
        static SIGNED_LONG_INTEGER RecorderLoading;
        static SIGNED_LONG_INTEGER PreviewEarly;
        static SIGNED_LONG_INTEGER MainPage;
        static SIGNED_LONG_INTEGER InitializationPage;
        static SIGNED_LONG_INTEGER Offline;
        static SIGNED_LONG_INTEGER ConflictingSessions;
    };

     class PanoptoSession 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Description[];
        SessionState State;
        STRING Name[];
    };

     class ConnectionFeedback 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PanoptoFeedback 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DriverState[];
        CurrentPage SetPageTo;
        CurrentPage SetSubpageTo;
        DisplayMessageEnum FeedbackMessageValue;
        PanoptoSession SessionInfo;
    };

     class PreviewData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AudioHistogramPreviewUrl[];
        STRING VideoPreviewUrl[];
    };

namespace PreEmptive.Dotfuscator.ObfuscationAttributes;
        // class declarations
         class ObfuscationAttribute;
     class ObfuscationAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Feature[];
    };

namespace Crestron.Panopto.Common.Attributes;
        // class declarations
         class RelatesToTypeAttribute;

namespace Crestron.Panopto.Common.StandardCommands;
        // class declarations
         class IrCommandConstants;
         class IrStandardCommandIds;
         class StandardCommand;
         class StandardCommands;
     class IrCommandConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING AllLampsOff[];
        static STRING AllLampsOn[];
        static STRING Antenna[];
        static STRING ArrowDown[];
        static STRING ArrowLeft[];
        static STRING ArrowRight[];
        static STRING ArrowUp[];
        static STRING Aspect1[];
        static STRING Aspect2[];
        static STRING Aspect3[];
        static STRING Aspect4[];
        static STRING Aspect5[];
        static STRING Aspect6[];
        static STRING Aspect7[];
        static STRING Aspect8[];
        static STRING Asterisk[];
        static STRING Auto[];
        static STRING Aux1[];
        static STRING Aux2[];
        static STRING ChannelUp[];
        static STRING ChannelDown[];
        static STRING ChannelPoll[];
        static STRING ChannelTune[];
        static STRING Eject[];
        static STRING Enter[];
        static STRING Home[];
        static STRING Info[];
        static STRING Input1[];
        static STRING Input10[];
        static STRING Input2[];
        static STRING Input3[];
        static STRING Input4[];
        static STRING Input5[];
        static STRING Input6[];
        static STRING Input7[];
        static STRING Input8[];
        static STRING Input9[];
        static STRING Input11[];
        static STRING Input12[];
        static STRING Input13[];
        static STRING Input14[];
        static STRING Input15[];
        static STRING Mute[];
        static STRING MuteOff[];
        static STRING MuteOn[];
        static STRING Osd[];
        static STRING OsdOff[];
        static STRING OsdOn[];
        static STRING OsdPoll[];
        static STRING Power[];
        static STRING PowerOff[];
        static STRING PowerOn[];
        static STRING Select[];
        static STRING VolMinus[];
        static STRING VolPlus[];
        static STRING Vol[];
        static STRING _0[];
        static STRING _1[];
        static STRING _2[];
        static STRING _3[];
        static STRING _4[];
        static STRING _5[];
        static STRING _6[];
        static STRING _7[];
        static STRING _8[];
        static STRING _9[];
        static STRING Octothorpe[];
        static STRING KeypadBackSpace[];
        static STRING Vga1[];
        static STRING Vga10[];
        static STRING Vga2[];
        static STRING Vga3[];
        static STRING Vga4[];
        static STRING Vga5[];
        static STRING Vga6[];
        static STRING Vga7[];
        static STRING Vga8[];
        static STRING Vga9[];
        static STRING Hdmi1[];
        static STRING Hdmi10[];
        static STRING Hdmi2[];
        static STRING Hdmi3[];
        static STRING Hdmi4[];
        static STRING Hdmi5[];
        static STRING Hdmi6[];
        static STRING Hdmi7[];
        static STRING Hdmi8[];
        static STRING Hdmi9[];
        static STRING Dvi1[];
        static STRING Dvi10[];
        static STRING Dvi2[];
        static STRING Dvi3[];
        static STRING Dvi4[];
        static STRING Dvi5[];
        static STRING Dvi6[];
        static STRING Dvi7[];
        static STRING Dvi8[];
        static STRING Dvi9[];
        static STRING Component1[];
        static STRING Component10[];
        static STRING Component2[];
        static STRING Component3[];
        static STRING Component4[];
        static STRING Component5[];
        static STRING Component6[];
        static STRING Component7[];
        static STRING Component8[];
        static STRING Component9[];
        static STRING Composite1[];
        static STRING Composite10[];
        static STRING Composite2[];
        static STRING Composite3[];
        static STRING Composite4[];
        static STRING Composite5[];
        static STRING Composite6[];
        static STRING Composite7[];
        static STRING Composite8[];
        static STRING Composite9[];
        static STRING DisplayPort1[];
        static STRING DisplayPort10[];
        static STRING DisplayPort2[];
        static STRING DisplayPort3[];
        static STRING DisplayPort4[];
        static STRING DisplayPort5[];
        static STRING DisplayPort6[];
        static STRING DisplayPort7[];
        static STRING DisplayPort8[];
        static STRING DisplayPort9[];
        static STRING Usb1[];
        static STRING Usb2[];
        static STRING Usb3[];
        static STRING Usb4[];
        static STRING Usb5[];
        static STRING Antenna1[];
        static STRING Antenna2[];
        static STRING Network1[];
        static STRING Network10[];
        static STRING Network2[];
        static STRING Network3[];
        static STRING Network4[];
        static STRING Network5[];
        static STRING Network6[];
        static STRING Network7[];
        static STRING Network8[];
        static STRING Network9[];
        static STRING Dvd1[];
        static STRING Sat1[];
        static STRING Tv[];
        static STRING Cd[];
        static STRING Tuner[];
        static STRING Phono[];
        static STRING Dss[];
        static STRING EnergyStarOn[];
        static STRING EnergyStarOff[];
        static STRING EnergyStar[];
        static STRING VideoMuteOn[];
        static STRING VideoMuteOff[];
        static STRING VideoMute[];
        static STRING Audio[];
        static STRING Blue[];
        static STRING Clear[];
        static STRING Display[];
        static STRING DownArrow[];
        static STRING UpArrow[];
        static STRING LeftArrow[];
        static STRING RightArrow[];
        static STRING Exit[];
        static STRING ForwardScan[];
        static STRING ReverseScan[];
        static STRING Green[];
        static STRING Options[];
        static STRING Pause[];
        static STRING Play[];
        static STRING PlayPause[];
        static STRING Red[];
        static STRING Repeat[];
        static STRING Return[];
        static STRING Stop[];
        static STRING Subtitle[];
        static STRING TopMenu[];
        static STRING ForwardSkip[];
        static STRING ReverseSkip[];
        static STRING Yellow[];
        static STRING PopUpMenu[];
        static STRING Menu[];
        static STRING A[];
        static STRING B[];
        static STRING C[];
        static STRING D[];
        static STRING Back[];
        static STRING Dvr[];
        static STRING Favorite[];
        static STRING Guide[];
        static STRING Last[];
        static STRING Live[];
        static STRING PageDown[];
        static STRING PageUp[];
        static STRING Record[];
        static STRING Replay[];
        static STRING SpeedSlow[];
        static STRING ThumbsUp[];
        static STRING ThumbsDown[];
        static STRING Channel[];
        static STRING Dash[];
        static STRING Period[];
        static STRING XmRadio[];
        static STRING InternetRadio[];
        static STRING Sirius[];
        static STRING SiriusXm[];
        static STRING Pandora[];
        static STRING LastFm[];
        static STRING Rhapsody[];
        static STRING HdRadio[];
        static STRING Spotify[];
        static STRING YouTube[];
        static STRING YouTubeTv[];
        static STRING Netflix[];
        static STRING Hulu[];
        static STRING DirecTvNow[];
        static STRING AmazonVideo[];
        static STRING PlaystationVue[];
        static STRING SlingTv[];
        static STRING Airplay[];
        static STRING GoogleCast[];
        static STRING DLNA[];
        static STRING Tidal[];
        static STRING Deezer[];
        static STRING Crackle[];
        static STRING OnDemand[];
        static STRING GooglePlay[];
        static STRING Bluetooth[];
        static STRING TuneUp[];
        static STRING TuneDown[];
        static STRING Tivo[];
        static STRING RSkip[];
        static STRING FSkip[];
        static STRING Settings[];
        static STRING Optical1[];
        static STRING Optical2[];
        static STRING Optical3[];
        static STRING Optical4[];
        static STRING Optical5[];
        static STRING Optical6[];
        static STRING Optical7[];
        static STRING Optical8[];
        static STRING Optical9[];
        static STRING Optical10[];
        static STRING Coax1[];
        static STRING Coax2[];
        static STRING Coax3[];
        static STRING Coax4[];
        static STRING Coax5[];
        static STRING Coax6[];
        static STRING Coax7[];
        static STRING Coax8[];
        static STRING Coax9[];
        static STRING Coax10[];
        static STRING AnalogAudio1[];
        static STRING AnalogAudio2[];
        static STRING AnalogAudio3[];
        static STRING AnalogAudio4[];
        static STRING AnalogAudio5[];
        static STRING AnalogAudio6[];
        static STRING AnalogAudio7[];
        static STRING AnalogAudio8[];
        static STRING AnalogAudio9[];
        static STRING AnalogAudio10[];
        static STRING Search[];
        static STRING Bd1[];
        static STRING Catv1[];
        static STRING Game1[];
        static STRING Pc1[];
        static STRING Bluetooth1[];
        static STRING MediaPlayer1[];
        static STRING Ipod1[];
        static STRING TunerPresetUp[];
        static STRING TunerPresetDown[];
        static STRING AutoFrequencyUp[];
        static STRING AutoFrequencyDown[];
        static STRING BandAm[];
        static STRING BandFm[];
        static STRING BassLevelUp[];
        static STRING BassLevelDown[];
        static STRING TrebleLevelUp[];
        static STRING TrebleLevelDown[];
        static STRING LoudnessOn[];
        static STRING LoudnessOff[];
        static STRING LoudnessToggle[];
        static STRING ToneControlOn[];
        static STRING ToneControlOff[];
        static STRING ToneControlToggle[];
        static STRING SurroundModeCycle[];

        // class properties
    };

    static class IrStandardCommandIds // enum
    {
        static SIGNED_LONG_INTEGER Octothorpe;
        static SIGNED_LONG_INTEGER Asterisk;
        static SIGNED_LONG_INTEGER _0;
        static SIGNED_LONG_INTEGER _1;
        static SIGNED_LONG_INTEGER _2;
        static SIGNED_LONG_INTEGER _3;
        static SIGNED_LONG_INTEGER _4;
        static SIGNED_LONG_INTEGER _5;
        static SIGNED_LONG_INTEGER _6;
        static SIGNED_LONG_INTEGER _7;
        static SIGNED_LONG_INTEGER _8;
        static SIGNED_LONG_INTEGER _9;
        static SIGNED_LONG_INTEGER AUX1;
        static SIGNED_LONG_INTEGER AUX2;
        static SIGNED_LONG_INTEGER CD;
        static SIGNED_LONG_INTEGER ChannelDown;
        static SIGNED_LONG_INTEGER ChannelUp;
        static SIGNED_LONG_INTEGER Clear;
        static SIGNED_LONG_INTEGER DownArrow;
        static SIGNED_LONG_INTEGER DSS;
        static SIGNED_LONG_INTEGER Eject;
        static SIGNED_LONG_INTEGER Enter;
        static SIGNED_LONG_INTEGER Exit;
        static SIGNED_LONG_INTEGER Favorite;
        static SIGNED_LONG_INTEGER ForwardScan;
        static SIGNED_LONG_INTEGER Guide;
        static SIGNED_LONG_INTEGER Home;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER Last;
        static SIGNED_LONG_INTEGER LeftArrow;
        static SIGNED_LONG_INTEGER Menu;
        static SIGNED_LONG_INTEGER Mute;
        static SIGNED_LONG_INTEGER MuteOff;
        static SIGNED_LONG_INTEGER MuteOn;
        static SIGNED_LONG_INTEGER Pause;
        static SIGNED_LONG_INTEGER Play;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER PowerOff;
        static SIGNED_LONG_INTEGER PowerOn;
        static SIGNED_LONG_INTEGER PresetMinus;
        static SIGNED_LONG_INTEGER PresetPlus;
        static SIGNED_LONG_INTEGER Record;
        static SIGNED_LONG_INTEGER Repeat;
        static SIGNED_LONG_INTEGER Return;
        static SIGNED_LONG_INTEGER RightArrow;
        static SIGNED_LONG_INTEGER ReverseScan;
        static SIGNED_LONG_INTEGER ReverseSkip;
        static SIGNED_LONG_INTEGER ForwardSkip;
        static SIGNED_LONG_INTEGER TUNER;
        static SIGNED_LONG_INTEGER UpArrow;
        static SIGNED_LONG_INTEGER VolMinus;
        static SIGNED_LONG_INTEGER VolPlus;
        static SIGNED_LONG_INTEGER PageUp;
        static SIGNED_LONG_INTEGER PageDown;
        static SIGNED_LONG_INTEGER PHONO;
        static SIGNED_LONG_INTEGER HangUp;
        static SIGNED_LONG_INTEGER NearEndZoomPlus;
        static SIGNED_LONG_INTEGER NearEndZoomMinus;
        static SIGNED_LONG_INTEGER NearEndFocusPlus;
        static SIGNED_LONG_INTEGER NearEndFocusMinus;
        static SIGNED_LONG_INTEGER NearEndPanLeft;
        static SIGNED_LONG_INTEGER NearEndPanRight;
        static SIGNED_LONG_INTEGER NearEndTiltUp;
        static SIGNED_LONG_INTEGER NearEndTiltDown;
        static SIGNED_LONG_INTEGER FarEndZoomPlus;
        static SIGNED_LONG_INTEGER FarEndZoomMinus;
        static SIGNED_LONG_INTEGER FarEndFocusPlus;
        static SIGNED_LONG_INTEGER FarEndFocusMinus;
        static SIGNED_LONG_INTEGER FarEndPanLeft;
        static SIGNED_LONG_INTEGER FarEndPanRight;
        static SIGNED_LONG_INTEGER FarEndTiltUp;
        static SIGNED_LONG_INTEGER FarEndTiltDown;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER OnScreenDisplay;
        static SIGNED_LONG_INTEGER OnScreenDisplayOn;
        static SIGNED_LONG_INTEGER OnScreenDisplayOff;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER PictureMute;
        static SIGNED_LONG_INTEGER PictureMuteOn;
        static SIGNED_LONG_INTEGER PictureMuteOff;
        static SIGNED_LONG_INTEGER DVD;
        static SIGNED_LONG_INTEGER TV;
        static SIGNED_LONG_INTEGER SAT;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER A;
        static SIGNED_LONG_INTEGER B;
        static SIGNED_LONG_INTEGER C;
        static SIGNED_LONG_INTEGER Replay;
        static SIGNED_LONG_INTEGER Live;
        static SIGNED_LONG_INTEGER Dvr;
        static SIGNED_LONG_INTEGER Dash;
        static SIGNED_LONG_INTEGER TUNE_TOGGLE;
        static SIGNED_LONG_INTEGER XmRadio;
        static SIGNED_LONG_INTEGER TopMenu;
        static SIGNED_LONG_INTEGER PopUpMenu;
        static SIGNED_LONG_INTEGER Red;
        static SIGNED_LONG_INTEGER Green;
        static SIGNED_LONG_INTEGER Blue;
        static SIGNED_LONG_INTEGER Yellow;
        static SIGNED_LONG_INTEGER Back;
        static SIGNED_LONG_INTEGER Search;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER KeypadBackSpace;
        static SIGNED_LONG_INTEGER Select;
        static SIGNED_LONG_INTEGER PLAY_PAUSE;
        static SIGNED_LONG_INTEGER VGA_1;
        static SIGNED_LONG_INTEGER VGA_2;
        static SIGNED_LONG_INTEGER VGA_3;
        static SIGNED_LONG_INTEGER VGA_4;
        static SIGNED_LONG_INTEGER VGA_5;
        static SIGNED_LONG_INTEGER DVI_1;
        static SIGNED_LONG_INTEGER DVI_2;
        static SIGNED_LONG_INTEGER DVI_3;
        static SIGNED_LONG_INTEGER DVI_4;
        static SIGNED_LONG_INTEGER DVI_5;
        static SIGNED_LONG_INTEGER DISPLAY_PORT_1;
        static SIGNED_LONG_INTEGER DISPLAY_PORT_2;
        static SIGNED_LONG_INTEGER DISPLAY_PORT_3;
        static SIGNED_LONG_INTEGER DISPLAY_PORT_4;
        static SIGNED_LONG_INTEGER DISPLAY_PORT_5;
        static SIGNED_LONG_INTEGER NETWORK_1;
        static SIGNED_LONG_INTEGER NETWORK_2;
        static SIGNED_LONG_INTEGER NETWORK_3;
        static SIGNED_LONG_INTEGER NETWORK_4;
        static SIGNED_LONG_INTEGER NETWORK_5;
        static SIGNED_LONG_INTEGER NETWORK_6;
        static SIGNED_LONG_INTEGER NETWORK_7;
        static SIGNED_LONG_INTEGER NETWORK_8;
        static SIGNED_LONG_INTEGER NETWORK_9;
        static SIGNED_LONG_INTEGER NETWORK_10;
        static SIGNED_LONG_INTEGER HDMI_7;
        static SIGNED_LONG_INTEGER HDMI_8;
        static SIGNED_LONG_INTEGER HDMI_9;
        static SIGNED_LONG_INTEGER HDMI_10;
        static SIGNED_LONG_INTEGER D;
        static SIGNED_LONG_INTEGER AUDIO;
        static SIGNED_LONG_INTEGER INTERNET_RADIO;
        static SIGNED_LONG_INTEGER SIRIUS;
        static SIGNED_LONG_INTEGER SIRIUS_XM;
        static SIGNED_LONG_INTEGER PANDORA;
        static SIGNED_LONG_INTEGER LAST_FM;
        static SIGNED_LONG_INTEGER RHAPSODY;
        static SIGNED_LONG_INTEGER HD_RADIO;
        static SIGNED_LONG_INTEGER SPOTIFY;
        static SIGNED_LONG_INTEGER YOUTUBE;
        static SIGNED_LONG_INTEGER YOUTUBE_TV;
        static SIGNED_LONG_INTEGER NETFLIX;
        static SIGNED_LONG_INTEGER HULU;
        static SIGNED_LONG_INTEGER DIRECTV_NOW;
        static SIGNED_LONG_INTEGER AMAZON_VIDEO;
        static SIGNED_LONG_INTEGER PLAYSTATION_VUE;
        static SIGNED_LONG_INTEGER SLING_TV;
        static SIGNED_LONG_INTEGER THUMBS_UP;
        static SIGNED_LONG_INTEGER THUMBS_DOWN;
        static SIGNED_LONG_INTEGER PERIOD;
        static SIGNED_LONG_INTEGER OPTIONS;
        static SIGNED_LONG_INTEGER SUBTITLE;
        static SIGNED_LONG_INTEGER TUNE_PLUS;
        static SIGNED_LONG_INTEGER TUNE_MINUS;
        static SIGNED_LONG_INTEGER AIRPLAY;
        static SIGNED_LONG_INTEGER GOOGLECAST;
        static SIGNED_LONG_INTEGER DLNA;
        static SIGNED_LONG_INTEGER TIDAL;
        static SIGNED_LONG_INTEGER DEEZER;
        static SIGNED_LONG_INTEGER CRACKLE;
        static SIGNED_LONG_INTEGER TIVO;
        static SIGNED_LONG_INTEGER ON_DEMAND;
        static SIGNED_LONG_INTEGER R_SKIP;
        static SIGNED_LONG_INTEGER F_SKIP;
        static SIGNED_LONG_INTEGER OPTICAL_1;
        static SIGNED_LONG_INTEGER OPTICAL_2;
        static SIGNED_LONG_INTEGER OPTICAL_3;
        static SIGNED_LONG_INTEGER OPTICAL_4;
        static SIGNED_LONG_INTEGER OPTICAL_5;
        static SIGNED_LONG_INTEGER OPTICAL_6;
        static SIGNED_LONG_INTEGER OPTICAL_7;
        static SIGNED_LONG_INTEGER OPTICAL_8;
        static SIGNED_LONG_INTEGER OPTICAL_9;
        static SIGNED_LONG_INTEGER OPTICAL_10;
        static SIGNED_LONG_INTEGER COAX_1;
        static SIGNED_LONG_INTEGER COAX_2;
        static SIGNED_LONG_INTEGER COAX_3;
        static SIGNED_LONG_INTEGER COAX_4;
        static SIGNED_LONG_INTEGER COAX_5;
        static SIGNED_LONG_INTEGER COAX_6;
        static SIGNED_LONG_INTEGER COAX_7;
        static SIGNED_LONG_INTEGER COAX_8;
        static SIGNED_LONG_INTEGER COAX_9;
        static SIGNED_LONG_INTEGER COAX_10;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_1;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_2;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_3;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_4;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_5;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_6;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_7;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_8;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_9;
        static SIGNED_LONG_INTEGER ANALOGAUDIO_10;
        static SIGNED_LONG_INTEGER USB_1;
        static SIGNED_LONG_INTEGER USB_2;
        static SIGNED_LONG_INTEGER USB_3;
        static SIGNED_LONG_INTEGER USB_4;
        static SIGNED_LONG_INTEGER USB_5;
        static SIGNED_LONG_INTEGER Bd1;
        static SIGNED_LONG_INTEGER Catv1;
        static SIGNED_LONG_INTEGER Game1;
        static SIGNED_LONG_INTEGER Pc1;
        static SIGNED_LONG_INTEGER Bluetooth1;
        static SIGNED_LONG_INTEGER MediaPlayer1;
        static SIGNED_LONG_INTEGER Ipod1;
    };

     class StandardCommand 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING StandardCommandString[];
        STRING Description[];
    };

    static class StandardCommands 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION PrintDictionary ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace Crestron.Panopto.Common.Logging;
        // class declarations
         class LoggingLevel;
         class Logger;
    static class LoggingLevel // enum
    {
        static SIGNED_LONG_INTEGER Error;
        static SIGNED_LONG_INTEGER Warning;
        static SIGNED_LONG_INTEGER Debug;
    };
