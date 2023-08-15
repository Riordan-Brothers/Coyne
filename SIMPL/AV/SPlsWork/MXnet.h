namespace Janus.MessageHandler;
        // class declarations
         class MessageHandlerBase;
         class MessageHandler;
         class BlockTagsType;
         class MessageItem;
         class MessageHandlerHTTP;
     class MessageHandlerBase 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ();
        FUNCTION OpenComms ();
        FUNCTION CloseComms ();
        FUNCTION AddMessageSequence ( MessageItem msgItems[] , STRING blockTag );
        FUNCTION AddMessage ( MessageItem msgItm );
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER NOT_CONNECTED;
        static SIGNED_LONG_INTEGER CREATING_CONNECTION;
        static SIGNED_LONG_INTEGER CONNECTED;
        static SIGNED_LONG_INTEGER FIRST_DERIVED_CONNECTION_STATE;
        static SIGNED_LONG_INTEGER OPERATIONAL;
        static SIGNED_LONG_INTEGER OPERATIONAL_CONFIRMED;
        static SIGNED_LONG_INTEGER EXPECT_NO_RESPONSE;

        // class properties
    };

     class MessageHandler 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ();
        FUNCTION OpenComms ();
        FUNCTION CloseComms ();
        FUNCTION AddMessageSequence ( MessageItem msgItems[] , STRING blockTag );
        FUNCTION AddMessage ( MessageItem msgItm );
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER NOT_CONNECTED;
        static SIGNED_LONG_INTEGER CREATING_CONNECTION;
        static SIGNED_LONG_INTEGER CONNECTED;
        static SIGNED_LONG_INTEGER FIRST_DERIVED_CONNECTION_STATE;
        static SIGNED_LONG_INTEGER OPERATIONAL;
        static SIGNED_LONG_INTEGER OPERATIONAL_CONFIRMED;
        static SIGNED_LONG_INTEGER EXPECT_NO_RESPONSE;

        // class properties
    };

    static class BlockTagsType // enum
    {
        static SIGNED_LONG_INTEGER SINGLE;
        static SIGNED_LONG_INTEGER BLOCKSTART;
        static SIGNED_LONG_INTEGER BLOCKEND;
        static SIGNED_LONG_INTEGER INBLOCK;
        static SIGNED_LONG_INTEGER NONE;
    };

     class MessageItem 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION markAsQueued ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        SIGNED_LONG_INTEGER Retries;

        // class properties
        STRING Tag[];
        SIGNED_LONG_INTEGER Timeout;
        BlockTagsType TagBlock;
        SIGNED_LONG_INTEGER Priority;
    };

     class MessageHandlerHTTP 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ();
        FUNCTION OpenComms ();
        FUNCTION CloseComms ();
        FUNCTION AddMessageSequence ( MessageItem msgItems[] , STRING blockTag );
        FUNCTION AddMessage ( MessageItem msgItm );
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER NOT_CONNECTED;
        static SIGNED_LONG_INTEGER CREATING_CONNECTION;
        static SIGNED_LONG_INTEGER CONNECTED;
        static SIGNED_LONG_INTEGER FIRST_DERIVED_CONNECTION_STATE;
        static SIGNED_LONG_INTEGER OPERATIONAL;
        static SIGNED_LONG_INTEGER OPERATIONAL_CONFIRMED;
        static SIGNED_LONG_INTEGER EXPECT_NO_RESPONSE;

        // class properties
    };

namespace Janus.Persist;
        // class declarations
         class DataStore;

namespace Janus.Utils;
        // class declarations
         class IP;
         class CryptoRijndaelManaged;
         class Maths;
         class Sync;
         class Locker;
         class StringHelpers;
         class Email;
     class IP 
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

     class CryptoRijndaelManaged 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Test ();
        static FUNCTION PrintLog ( STRING msg );
        static FUNCTION ConsoleTest ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class Maths 
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

     class Sync 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Lock ();
        FUNCTION Unlock ();
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class Locker 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class StringHelpers 
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

     class Email 
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

namespace Janus.Comms;
        // class declarations
         class J_SocketStatus;
         class HTTPClientBase;
         class HTTPSClient;
         class CrestronClientHTTPS;
         class CrestronClientRequestHTTPS;
         class CrestronClientResponseHTTPS;
         class HTTPReq;
         class HTTPCommsRequest;
         class HTTPCommsResponse;
         class HTTPServer;
         class Comms;
         class HTTPClient;
         class CrestronClientHTTP;
         class CrestronClientRequestHTTP;
         class CrestronClientResponseHTTP;
    static class J_SocketStatus // enum
    {
        static SIGNED_LONG_INTEGER DISCONNECTED;
        static SIGNED_LONG_INTEGER CONNECTING;
        static SIGNED_LONG_INTEGER CONNECTED;
    };

     class HTTPClientBase 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialise ( STRING userName , STRING password );
        FUNCTION SendRequest ( HTTPReq request , SIGNED_LONG_INTEGER timeout );
        STRING_FUNCTION PostRequest ( STRING url , STRING postData );
        STRING_FUNCTION PutRequest ( STRING url , STRING postData );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class HTTPSClient 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialise ( STRING userName , STRING password );
        FUNCTION SendRequest ( HTTPReq request , SIGNED_LONG_INTEGER timeout );
        STRING_FUNCTION PostRequest ( STRING url , STRING postData );
        STRING_FUNCTION PutRequest ( STRING url , STRING postData );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrestronClientHTTPS 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING UserName[];
        STRING Password[];
        STRING UserAgent[];
        STRING Accept[];
        SIGNED_LONG_INTEGER Timeout;
    };

     class CrestronClientRequestHTTPS 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetHeaderValue ( STRING key , STRING value );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING RequestType[];
        STRING ContentString[];
        STRING ContentType[];
    };

     class HTTPReq 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING GET[];
        static STRING POST[];
        static STRING PUT[];
        static STRING DELETE[];

        // class properties
        STRING Url[];
        STRING Method[];
        STRING Body[];
    };

     class HTTPServer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION StopListener ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class Comms 
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

     class HTTPClient 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialise ( STRING userName , STRING password );
        FUNCTION SendRequest ( HTTPReq request , SIGNED_LONG_INTEGER timeout );
        STRING_FUNCTION PostRequest ( STRING url , STRING postData );
        STRING_FUNCTION PutRequest ( STRING url , STRING postData );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CrestronClientHTTP 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION _debug ( STRING str );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING UserName[];
        STRING Password[];
        STRING UserAgent[];
        STRING Accept[];
        SIGNED_LONG_INTEGER Timeout;
    };

     class CrestronClientRequestHTTP 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetHeaderValue ( STRING key , STRING value );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING RequestType[];
        STRING ContentString[];
        STRING ContentType[];
    };

namespace Janus.Crestron.AVProEdge.Mxnet;
        // class declarations
         class VwDisplay;
         class AVSwitcherInstanceManager;
         class VwLayout;
         class SwitchEventArgs;
         class Favourites;
         class VwWall;
         class Mxnet;
     class AVSwitcherInstanceManager 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ConsoleCommand ( SIMPLSHARPSTRING cmd );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVSwitcherInstanceManager Get;
    };

     class VwLayout 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Cols;
        SIGNED_LONG_INTEGER Rows;
    };

     class Favourites 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialise ( STRING pathToFile );
        FUNCTION AddToFavourites ( SIGNED_LONG_INTEGER key , STRING favourite );
        STRING_FUNCTION RecallFavourite ( SIGNED_LONG_INTEGER favouriteKey );
        FUNCTION ClearAllFavourites ();
        FUNCTION DeleteFile ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class VwWall 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Cols;
        SIGNED_LONG_INTEGER Rows;
    };

     class Mxnet 
    {
        // class delegates
        delegate FUNCTION StringParamDelegate ( SIMPLSHARPSTRING str );
        delegate FUNCTION IntParamDelegate ( INTEGER value );
        delegate FUNCTION IntAndStringDelegate ( INTEGER value , SIMPLSHARPSTRING str );
        delegate FUNCTION TwoStringParamDelegate ( SIMPLSHARPSTRING str1 , SIMPLSHARPSTRING str2 );

        // class events
        EventHandler SwitchDone ( Mxnet sender, SwitchEventArgs e );
        EventHandler ConnectionChanged ( Mxnet sender, EventArgs e );
        EventHandler WallsUpdated ( Mxnet sender, EventArgs e );
        EventHandler TestEvent ( Mxnet sender, EventArgs e );

        // class functions
        FUNCTION VideoWall_ChangeInput ( STRING wallId , STRING layout , STRING input );
        FUNCTION VideoWall_Remove ( STRING wallId );
        FUNCTION VideoWall_RecallLayout ( STRING wallId , STRING layout );
        FUNCTION VideoWall_RecallMosaic ( STRING wallId , STRING layout );
        FUNCTION VideoWall_SetBezel ( STRING wallId , STRING layout , SIGNED_LONG_INTEGER vw , SIGNED_LONG_INTEGER ow , SIGNED_LONG_INTEGER vh , SIGNED_LONG_INTEGER oh );
        FUNCTION TestFunction ();
        FUNCTION CreateTCPConnection ( STRING Ip_Address , INTEGER Port , LONG_INTEGER pollTime );
        FUNCTION SendHeartbeatEvent ();
        FUNCTION GetDeviceStatus ();
        FUNCTION GetDeviceList ();
        FUNCTION Reinitialise ();
        FUNCTION RebootAllDevices ();
        FUNCTION SetStreamControl ( INTEGER enabled );
        FUNCTION AutoConfigureAliases ();
        FUNCTION ProcessHotPlug ( STRING msg );
        FUNCTION GetVideoWallList ();
        FUNCTION AddTobuffer ( SIMPLSHARPSTRING cmd , SIMPLSHARPSTRING type );
        STRING_FUNCTION ExtractInputAndOutputForSwitch ( STRING buffer , STRING type );
        FUNCTION ExtractOutputForCEC ( SIMPLSHARPSTRING outputs , SIMPLSHARPSTRING cmd );
        FUNCTION ExtractInputsForCEC ( SIMPLSHARPSTRING inputs , SIMPLSHARPSTRING cmd );
        FUNCTION ExtractOutputForAudio ( SIMPLSHARPSTRING outputs , SIMPLSHARPSTRING cmd );
        STRING_FUNCTION VideoWall ( STRING inputBuffer );
        FUNCTION SerialSettingsChg ( SIMPLSHARPSTRING inputBuffer );
        FUNCTION SerialChg ( SIMPLSHARPSTRING inputBuffer );
        FUNCTION IRChg ( SIMPLSHARPSTRING inputBuffer );
        STRING_FUNCTION OneWayCommand ( STRING inputBuffer );
        FUNCTION Favourites ( SIMPLSHARPSTRING cmd );
        FUNCTION ExtractStatus ();
        FUNCTION ConsoleCommand ( SIMPLSHARPSTRING cmd );
        FUNCTION DisplayImage ( STRING inputBuffer );
        FUNCTION CustomCommand ( STRING inputBuffer );
        STRING_FUNCTION GetVideoWallDisplayPortString ( STRING wallId );
        STRING_FUNCTION GetInputNameByPort ( SIGNED_LONG_INTEGER port );
        FUNCTION OnOperational ();
        FUNCTION VideoWall_Create ( STRING wallId , SIGNED_LONG_INTEGER rows , SIGNED_LONG_INTEGER cols );
        FUNCTION VideoWall_CreateLayout ( STRING wallId , STRING layout );
        FUNCTION VideoWall_SetLayout ( STRING wallId , STRING layout , SIGNED_LONG_INTEGER rows , SIGNED_LONG_INTEGER cols , STRING outputList , SIGNED_LONG_INTEGER input , SIGNED_LONG_INTEGER rotation );
        FUNCTION VideoWall_UpdateLayout ( STRING wallId , STRING layout );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING IntegrationID[];

        // class properties
        DelegateProperty StringParamDelegate ConnectionStatusDelegate;
        DelegateProperty IntParamDelegate ConnectionStateDelegate;
        DelegateProperty StringParamDelegate ConfigurationStatusDelegate;
        DelegateProperty IntAndStringDelegate AliasExtractInDelegate;
        DelegateProperty IntAndStringDelegate AliasExtractOutDelegate;
        DelegateProperty TwoStringParamDelegate SwitchFeedbackDelegate;
        DelegateProperty StringParamDelegate VideoSwitchFeedbackDelegate;
        DelegateProperty StringParamDelegate AudioSwitchFeedbackDelegate;
        DelegateProperty StringParamDelegate UsbSwitchFeedbackDelegate;
        DelegateProperty StringParamDelegate HotPlugFeedbackDelegate;
    };

namespace Janus.ProjectInfo;
        // class declarations
         class ProjectInfo;
     class ProjectInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static Janus.ProjectInfo.ProjectInfo ProgInfo;

        // class properties
        STRING version[];
    };

namespace Janus.Discovery;
        // class declarations
         class UpnpDevice;
         class SDDPDiscoverer;
         class UpnpDiscoverer;
         class SDDPDevice;
     class UpnpDevice 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DeviceType[];
        STRING FriendlyName[];
        STRING Manufacturer[];
        STRING ManufacturerUrl[];
        STRING ModelDescription[];
        STRING ModelName[];
        STRING ModelNumber[];
        STRING SerialNumber[];
        STRING Udn[];
        STRING Ip[];
    };

     class SDDPDiscoverer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION StartDiscovery ();
        FUNCTION StopDiscovery ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class UpnpDiscoverer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION StartDiscovery ();
        FUNCTION StopDiscovery ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SDDPDevice 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Ip[];
        STRING HostName[];
        LONG_INTEGER MaxAge;
        STRING ProductType[];
        STRING PrimaryProxy[];
        STRING Proxies[];
        STRING Manufacturer[];
        STRING Model[];
        STRING Driver[];
        STRING ConfigURL[];
    };

namespace Janus.Crestron;
        // class declarations
         class Processor;
    static class Processor 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION ReturnSubnetmask ( STRING ipaddress );
        static LONG_INTEGER_FUNCTION ReturnFirstOctet ( STRING ipAddress );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING MacAddress[];
        STRING IAddress[];
        STRING MacAddressRaw[];
    };

namespace Janus.Debug;
        // class declarations
         class Debug;
     class Debug 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION ConsoleOut ( STRING msg );
        static FUNCTION PrintSoftwareVersion ();
        STRING_FUNCTION SafeString ( STRING str );
        FUNCTION msg ( STRING msgText );
        FUNCTION e ( STRING msgText );
        FUNCTION w ( STRING msgText );
        FUNCTION i ( STRING msgText );
        FUNCTION d ( STRING msgText );
        FUNCTION v ( STRING msgText );
        static FUNCTION setSubsystems ( STRING subsystems );
        static FUNCTION setLevel ( LONG_INTEGER level );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static Janus.Debug.Debug DBG;
        static LONG_INTEGER LEVEL_ERROR;
        static LONG_INTEGER LEVEL_WARNING;
        static LONG_INTEGER LEVEL_INFO;
        static LONG_INTEGER LEVEL_DEBUG;
        static LONG_INTEGER LEVEL_VERBOSE;
        static LONG_INTEGER LEVEL_MAX;

        // class properties
        LONG_INTEGER Level;
        STRING SubSystems[];
    };

namespace Janus.Components;
        // class declarations
         class LevelHandler;

namespace Janus.Timer;
        // class declarations
         class AsyncTimer;
     class AsyncTimer 
    {
        // class delegates
        delegate FUNCTION TimerCallback ( AsyncTimer firedBy );

        // class events

        // class functions
        FUNCTION Dispose ();
        FUNCTION Start ( SIGNED_LONG_INTEGER time );
        FUNCTION CreateTimerWithRepeat ( SIGNED_LONG_INTEGER time , SIGNED_LONG_INTEGER repeat );
        FUNCTION CreateTimer ( SIGNED_LONG_INTEGER time );
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER StartDelay;
        SIGNED_LONG_INTEGER Repeat;
        DelegateProperty TimerCallback Callback;
        STRING Name[];
    };

namespace Janus.ThreadSafe;
        // class declarations

