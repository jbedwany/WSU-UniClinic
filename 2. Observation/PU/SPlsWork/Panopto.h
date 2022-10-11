namespace Crestron.Panopto;
        // class declarations
         class PanoptoState;
         class PreviewState;
         class RecordingConfig;
         class Contributor;
         class HttpsResponseArgs;
         class Device;
         class InitialState;
         class RemoteRecorderPreviewData;
         class Command;
         class CommandType;
         class CommandProtocol;
         class CommandName;
         class ThreadSafeQueue;
         class IdleState;
         class Driver;
         class SessionMetadata;
         class RecordingState;
         class PanoptoSimpl;
         class PausedState;
         class Commands;
     class PanoptoState 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION StopState ();
        FUNCTION HttpDownloadDataHandler ( HttpsResponseArgs args );
        FUNCTION HttpDataHandler ( HttpsResponseArgs args );
        FUNCTION NewRecording ();
        FUNCTION Pause ();
        FUNCTION Resume ();
        FUNCTION Preview ( STRING recordingName );
        FUNCTION RecordEarly ();
        FUNCTION Stop ();
        FUNCTION Extend ();
        FUNCTION Back ();
        FUNCTION SetPreviewRefreshRate ( SIGNED_LONG_INTEGER rate );
        FUNCTION TryAutoConfigure ();
        STRING_FUNCTION GetStateName ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Crestron.Panopto.Driver P;

        // class properties
    };

     class RecordingConfig 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING RecordingName[];
    };

     class Contributor 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Bio[];
        STRING DisplayName[];
        STRING UserKey[];
    };

     class HttpsResponseArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Url[];
        STRING ResponseString[];
        SIGNED_LONG_INTEGER ResponseCode;
        Command Command;
    };

     class Device 
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
        STRING AudioPreviewUrl[];
        STRING VideoPreviewUrl[];
    };

     class InitialState 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION HttpDataHandler ( HttpsResponseArgs args );
        STRING_FUNCTION GetStateName ();
        FUNCTION TryAutoConfigure ();
        FUNCTION StopState ();
        FUNCTION HttpDownloadDataHandler ( HttpsResponseArgs args );
        FUNCTION NewRecording ();
        FUNCTION Pause ();
        FUNCTION Resume ();
        FUNCTION Preview ( STRING recordingName );
        FUNCTION RecordEarly ();
        FUNCTION Stop ();
        FUNCTION Extend ();
        FUNCTION Back ();
        FUNCTION SetPreviewRefreshRate ( SIGNED_LONG_INTEGER rate );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Crestron.Panopto.Driver P;

        // class properties
    };

     class RemoteRecorderPreviewData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ThumbnailRefreshIntervalSeconds;
        SIGNED_LONG_INTEGER RecorderAwakeIntervalSeconds;
    };

    static class CommandType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Control;
        static SIGNED_LONG_INTEGER Poll;
    };

    static class CommandProtocol // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Rest;
        static SIGNED_LONG_INTEGER Soap;
        static SIGNED_LONG_INTEGER Web;
    };

    static class CommandName // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER PreviewVideo;
        static SIGNED_LONG_INTEGER PreviewAudio;
        static SIGNED_LONG_INTEGER Extend;
        static SIGNED_LONG_INTEGER Stop;
        static SIGNED_LONG_INTEGER Pause;
        static SIGNED_LONG_INTEGER Resume;
        static SIGNED_LONG_INTEGER GetPublicSessionId;
        static SIGNED_LONG_INTEGER GetPreviewUrls;
        static SIGNED_LONG_INTEGER LogOnWithPassword;
        static SIGNED_LONG_INTEGER ListRecorders;
        static SIGNED_LONG_INTEGER GetRemoteRecorderById;
        static SIGNED_LONG_INTEGER GetSessionById;
        static SIGNED_LONG_INTEGER GetDefaultFolderForRemoteRecorder;
        static SIGNED_LONG_INTEGER ScheduleRecording;
        static SIGNED_LONG_INTEGER StartSessionEarly;
        static SIGNED_LONG_INTEGER StartSessionEarlyGetSessionById;
        static SIGNED_LONG_INTEGER RescheduleSession;
    };

     class Driver 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Reconfigure ();
        FUNCTION SetPreviewRefreshRate ( SIGNED_LONG_INTEGER rate );
        FUNCTION Preview ( STRING recordingName );
        FUNCTION StartRecordingEarly ();
        FUNCTION NewRecording ();
        FUNCTION Back ();
        FUNCTION StopRecording ();
        FUNCTION Pause ();
        FUNCTION Resume ();
        FUNCTION ExtendRecording ();
        FUNCTION ClearQueue ();
        FUNCTION QueueMessage ( Command command );
        FUNCTION SendResult ( Command command );
        FUNCTION Dispose ();
        STRING_FUNCTION GetRoomStateName ();
        FUNCTION ConnectionNotify ();
        FUNCTION FeedbackNotify ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Crestron.Panopto.Commands API;
        STRING Cookie[];
        SIGNED_LONG_INTEGER RefreshRate;
        STRING RecorderId[];
        STRING PanoptoUrl[];
        STRING UserName[];
        STRING Password[];
        STRING RecorderName[];
        STRING IpAddress[];
        Crestron.Panopto.RecordingConfig RecordingConfig;
        static SIGNED_LONG_INTEGER PollingInterval;
        static SIGNED_LONG_INTEGER PollingTimeoutDueTime;
        static SIGNED_LONG_INTEGER PollingDueTime;

        // class properties
        STRING Description[];
        STRING Manufacturer[];
        STRING BaseModel[];
        STRING DriverVersion[];
    };

     class SessionMetadata 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER AverageRating;
        STRING Duration[];
        STRING Identifier[];
        STRING PublicID[];
        SIGNED_LONG_INTEGER RatingCount;
        STRING SessionAbstract[];
        STRING SessionGroupLongName[];
        STRING SessionGroupPublicID[];
        STRING SessionName[];
        STRING SessionPublicID[];
        STRING SessionStartTime[];
    };

     class PanoptoSimpl 
    {
        // class delegates
        delegate FUNCTION BasicInformationDelegate ( SIMPLSHARPSTRING description , SIMPLSHARPSTRING guid , SIMPLSHARPSTRING manufacturer , SIMPLSHARPSTRING versionDate , INTEGER supportsFeedback );
        delegate FUNCTION PanoptoUpcomingSessionDelegate ( SIMPLSHARPSTRING sessionName , SIMPLSHARPSTRING sessionMinutesToStart , SIMPLSHARPSTRING sessionSpan , SIMPLSHARPSTRING sessionHoursMinutesText , INTEGER sessionIsBroadcast );
        delegate FUNCTION ActiveSessionDelegate ( SIMPLSHARPSTRING sessionName , SIMPLSHARPSTRING sessionSpan , SIMPLSHARPSTRING sessionReservedForTheNext , SIMPLSHARPSTRING sessionHoursMinutesRemaining , INTEGER sessionEnableExtendBtn , INTEGER sessionEnablePauseBtn );
        delegate FUNCTION PanoptoVideoPreviewDelegate ( SIMPLSHARPSTRING videoPreviewUrl );
        delegate FUNCTION PanoptoAudioPreviewDelegate ( SIMPLSHARPSTRING audioPreviewUrl );
        delegate FUNCTION TransitionDelegate ( SIMPLSHARPSTRING transitionText );
        delegate FUNCTION SessionSubPage ( INTEGER pageNumber );
        delegate FUNCTION SessionMainPage ( INTEGER pageNumber );
        delegate FUNCTION FeedbackDelegate ( SIMPLSHARPSTRING message );
        delegate FUNCTION DiagnosticLoggingToggleDelegate ( INTEGER input , SIMPLSHARPSTRING buttonText );

        // class events

        // class functions
        FUNCTION Initialize ();
        FUNCTION EnableLoggingBtn ();
        FUNCTION Log ( SIMPLSHARPSTRING message );
        INTEGER_FUNCTION PanoptoLogin ( SIMPLSHARPSTRING panoptoUrl , SIMPLSHARPSTRING userName , SIMPLSHARPSTRING userPassword , SIMPLSHARPSTRING recorderName , SIMPLSHARPSTRING ipAddress );
        STRING_FUNCTION NormalizeUrl ( STRING text );
        FUNCTION PanelOnline ();
        FUNCTION RecordEarlyBtn ();
        FUNCTION RecordingStopBtn ();
        FUNCTION PreviewBtn ( SIMPLSHARPSTRING recordingName );
        FUNCTION PreviewEarlyBtn ( SIMPLSHARPSTRING recordingName );
        FUNCTION RecordingPauseBtn ();
        FUNCTION RecordingResumeBtn ();
        FUNCTION RecordingExtendBtn ();
        FUNCTION BackBtn ();
        FUNCTION CancelRecordingBtn ();
        FUNCTION NewRecordingBtn ();
        FUNCTION RecordBtn ( SIMPLSHARPSTRING recordingTitle , INTEGER recordingDuration , INTEGER recordingBroadCast );
        FUNCTION RecordUntil ( SIMPLSHARPSTRING recordingName , INTEGER isBroadcast );
        FUNCTION RescheduleConflict ( SIMPLSHARPSTRING recordingTitle , INTEGER recordingDuration , INTEGER recordingBroadCast );
        FUNCTION SetPreviewRefreshRate ( LONG_INTEGER rate );
        FUNCTION Reconfigure ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Crestron.Panopto.Driver MyPanopto;

        // class properties
        DelegateProperty BasicInformationDelegate BasicInformationUpdated;
        DelegateProperty PanoptoUpcomingSessionDelegate PanoptoUpcomingSessionUpdated;
        DelegateProperty ActiveSessionDelegate PanoptoActiveSessionUpdated;
        DelegateProperty PanoptoVideoPreviewDelegate PanoptoVideoPreviewUpdated;
        DelegateProperty PanoptoAudioPreviewDelegate PanoptoAudioPreviewUpdated;
        DelegateProperty TransitionDelegate PanoptoTransitionSessionUpdated;
        DelegateProperty SessionSubPage PanoptoSessionSubPageUpdated;
        DelegateProperty SessionMainPage PanoptoMainPageUpdated;
        DelegateProperty FeedbackDelegate PanoptoFeedbackMessageUpdated;
        DelegateProperty DiagnosticLoggingToggleDelegate LoggingToggled;
    };

     class Commands 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION LogOnWithPassword ( Driver p , STRING userName , STRING password , STRING url , CommandType type , PanoptoState state );
        FUNCTION ListRecorders ( Driver p , SIGNED_LONG_INTEGER page , SIGNED_LONG_INTEGER recordersPerPage , CommandType type , PanoptoState state );
        FUNCTION GetRemoteRecorderById ( Driver p , CommandType type , PanoptoState state );
        FUNCTION StartSessionEarlyGetSessionById ( Driver p , CommandType type , PanoptoState state );
        FUNCTION GetSessionById ( Driver p , CommandType type , PanoptoState state );
        FUNCTION GetDefaultFolderForRemoteRecorder ( Driver p , CommandType type , PanoptoState state );
        FUNCTION ScheduleRecording ( Driver p , CommandType type , PanoptoState state );
        FUNCTION StartSessionEarly ( Driver p , CommandType type , PanoptoState state );
        FUNCTION StopRecording ( Driver p , CommandType type , PanoptoState state );
        FUNCTION ExtendRecording ( Driver p , CommandType type , PanoptoState state );
        FUNCTION RescheduleSession ( Driver p , CommandType type , PanoptoState state );
        FUNCTION GetPublicSessionId ( Driver p , CommandType type , PanoptoState state );
        FUNCTION GetPreviewUrls ( Driver p , CommandType type , PanoptoState state );
        FUNCTION Pause ( Driver p , CommandType type , PanoptoState state );
        FUNCTION Resume ( Driver p , CommandType type , PanoptoState state );
        FUNCTION Download ( Driver p , STRING url , CommandType type , PanoptoState state );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

