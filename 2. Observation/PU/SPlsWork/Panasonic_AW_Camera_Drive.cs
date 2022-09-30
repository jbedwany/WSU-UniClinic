using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_PANASONIC_AW_CAMERA_DRIVE
{
    public class UserModuleClass_PANASONIC_AW_CAMERA_DRIVE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput DOCLIENTCONNECTED;
        Crestron.Logos.SplusObjects.AnalogOutput AOCLIENTSTATUS;
        Crestron.Logos.SplusObjects.StringOutput RESPONSE__DOLLAR__;
        SplusTcpClient MYCLIENT;
        UShortParameter HTTP_PORTNUMBER;
        StringParameter SERVER_IP_ADDRESS;
        UShortParameter CLIENTRECONNECTENABLE;
        StringParameter RESOURCE_STRING;
        StringParameter POSTAMBLE_STRING;
        CrestronString SCLIENTRX__DOLLAR__;
        CrestronString COMMANDVALUE__DOLLAR__;
        CrestronString REPLYERR__DOLLAR__;
        CrestronString REPLYVALUE__DOLLAR__;
        CrestronString RNDM__DOLLAR__;
        CrestronString COMMANDLIST;
        CrestronString RXCOMMAND;
        CrestronString NEXTCOMMAND;
        CrestronString REPLYOK;
        ushort [] HEX_TAB;
        ushort RXVALUE = 0;
        ushort ISTARTCLIENT = 0;
        ushort RXOK = 0;
        ushort PROCESSINGCOMMANDS = 0;
        ushort REPLYACK = 0;
        ushort HELPRX = 0;
        ushort QUERY = 0;
        int CHRSZ = 0;
        int [] BIN;
        int [] BINARRAY;
        private ushort FSTARTCLIENT (  SplusExecutionContext __context__ ) 
            { 
            short ISTATUS = 0;
            
            
            __context__.SourceCodeLine = 179;
            ISTARTCLIENT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 180;
            ISTATUS = (short) ( Functions.SocketConnectClient( MYCLIENT , SERVER_IP_ADDRESS  , (ushort)( HTTP_PORTNUMBER  .Value ) , (ushort)( CLIENTRECONNECTENABLE  .Value ) ) ) ; 
            __context__.SourceCodeLine = 181;
            return (ushort)( ISTATUS) ; 
            
            }
            
        private ushort FSTOPCLIENT (  SplusExecutionContext __context__ ) 
            { 
            short ISTATUS = 0;
            
            
            __context__.SourceCodeLine = 188;
            Functions.Delay (  (int) ( 5 ) ) ; 
            __context__.SourceCodeLine = 189;
            ISTARTCLIENT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 190;
            ISTATUS = (short) ( Functions.SocketDisconnectClient( MYCLIENT ) ) ; 
            __context__.SourceCodeLine = 191;
            Trace( "Disconnect Status: {0:d}\r\n", (short)ISTATUS) ; 
            __context__.SourceCodeLine = 192;
            return (ushort)( ISTATUS) ; 
            
            }
            
        private ushort FCLIENTTX (  SplusExecutionContext __context__, CrestronString CLIENTTX__DOLLAR__ ) 
            { 
            short ISTATUS = 0;
            
            
            __context__.SourceCodeLine = 199;
            ISTATUS = (short) ( Functions.SocketSend( MYCLIENT , CLIENTTX__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 200;
            return (ushort)( ISTATUS) ; 
            
            }
            
        private CrestronString GETNEXTCOMMAND (  SplusExecutionContext __context__ ) 
            { 
            CrestronString TEMPSTRING;
            TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 206;
            TEMPSTRING  .UpdateValue ( Functions.Remove ( "\r" , COMMANDLIST )  ) ; 
            __context__.SourceCodeLine = 207;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMPSTRING ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 209;
                NEXTCOMMAND  .UpdateValue ( Functions.Remove ( (Functions.Length( TEMPSTRING ) - 1), TEMPSTRING )  ) ; 
                __context__.SourceCodeLine = 210;
                REPLYOK  .UpdateValue ( NEXTCOMMAND  ) ; 
                __context__.SourceCodeLine = 211;
                return ( NEXTCOMMAND ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void SENDCOMMAND (  SplusExecutionContext __context__ ) 
            { 
            CrestronString COMMANDTOSEND__DOLLAR__;
            COMMANDTOSEND__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 219;
            MakeString ( COMMANDTOSEND__DOLLAR__ , "GET {0}{1}{2} HTTP/1.0\r\n", RESOURCE_STRING , GETNEXTCOMMAND (  __context__  ) , POSTAMBLE_STRING ) ; 
            __context__.SourceCodeLine = 220;
            FCLIENTTX (  __context__ , COMMANDTOSEND__DOLLAR__) ; 
            __context__.SourceCodeLine = 221;
            MakeString ( COMMANDTOSEND__DOLLAR__ , "Host: {0}\r\n", SERVER_IP_ADDRESS ) ; 
            __context__.SourceCodeLine = 222;
            FCLIENTTX (  __context__ , COMMANDTOSEND__DOLLAR__) ; 
            __context__.SourceCodeLine = 226;
            FCLIENTTX (  __context__ , "\r\n") ; 
            
            }
            
        private void PROCESSCOMMANDS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 232;
            PROCESSINGCOMMANDS = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 233;
            while ( Functions.TestForTrue  ( ( Functions.Length( COMMANDLIST ))  ) ) 
                { 
                __context__.SourceCodeLine = 235;
                Trace( "ReplyAck: {0:d}", (short)REPLYACK) ; 
                __context__.SourceCodeLine = 236;
                if ( Functions.TestForTrue  ( ( REPLYACK)  ) ) 
                    { 
                    __context__.SourceCodeLine = 238;
                    REPLYACK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 239;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AOCLIENTSTATUS  .Value != 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 241;
                        FSTARTCLIENT (  __context__  ) ; 
                        __context__.SourceCodeLine = 242;
                        Trace( "fStartClient") ; 
                        } 
                    
                    __context__.SourceCodeLine = 244;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (AOCLIENTSTATUS  .Value != 2))  ) ) 
                        {
                        __context__.SourceCodeLine = 244;
                        ; 
                        __context__.SourceCodeLine = 244;
                        }
                    
                    __context__.SourceCodeLine = 245;
                    SENDCOMMAND (  __context__  ) ; 
                    __context__.SourceCodeLine = 246;
                    CreateWait ( "WAITER" , 200 , WAITER_Callback ) ;
                    } 
                
                __context__.SourceCodeLine = 255;
                Functions.Delay (  (int) ( 50 ) ) ; 
                __context__.SourceCodeLine = 233;
                } 
            
            __context__.SourceCodeLine = 257;
            PROCESSINGCOMMANDS = (ushort) ( 0 ) ; 
            
            }
            
        public void WAITER_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 248;
            REPLYACK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 249;
            PROCESSINGCOMMANDS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 250;
            Trace( "No Ack received on transmission") ; 
            __context__.SourceCodeLine = 251;
            FSTOPCLIENT (  __context__  ) ; 
            __context__.SourceCodeLine = 252;
            Functions.ClearBuffer ( COMMANDLIST ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object COMMAND__DOLLAR___OnChange_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 269;
            COMMANDLIST  .UpdateValue ( COMMAND__DOLLAR__ + "\r"  ) ; 
            __context__.SourceCodeLine = 271;
            Trace( "Command List: {0}\r\n", COMMANDLIST ) ; 
            __context__.SourceCodeLine = 272;
            Trace( "ProcessingCommands: {0:d}", (short)PROCESSINGCOMMANDS) ; 
            __context__.SourceCodeLine = 273;
            if ( Functions.TestForTrue  ( ( Functions.Not( PROCESSINGCOMMANDS ))  ) ) 
                { 
                __context__.SourceCodeLine = 275;
                Trace( "ProcessCommands") ; 
                __context__.SourceCodeLine = 276;
                PROCESSCOMMANDS (  __context__  ) ; 
                __context__.SourceCodeLine = 277;
                CreateWait ( "WAITER2" , 200 , WAITER2_Callback ) ;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public void WAITER2_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 279;
            REPLYACK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 280;
            PROCESSINGCOMMANDS = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object MYCLIENT_OnSocketConnect_1 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        int PORTNUMBER = 0;
        
        short LOCALSTATUS = 0;
        
        CrestronString REMOTEIPADDRESS;
        REMOTEIPADDRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        
        CrestronString REQUESTEDADDRESS;
        REQUESTEDADDRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
        
        
        __context__.SourceCodeLine = 297;
        DOCLIENTCONNECTED  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 298;
        LOCALSTATUS = (short) ( Functions.SocketGetAddressAsRequested( MYCLIENT , ref REQUESTEDADDRESS ) ) ; 
        __context__.SourceCodeLine = 299;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LOCALSTATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 300;
            Trace( "Client: Error getting remote ip address. {0:d}\r\n", (short)LOCALSTATUS) ; 
            }
        
        __context__.SourceCodeLine = 302;
        PORTNUMBER = (int) ( Functions.SocketGetPortNumber( MYCLIENT ) ) ; 
        __context__.SourceCodeLine = 303;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PORTNUMBER < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 304;
            Trace( "Client: Error getting client port number. {0:d}\r\n", (int)PORTNUMBER) ; 
            }
        
        __context__.SourceCodeLine = 306;
        LOCALSTATUS = (short) ( Functions.SocketGetRemoteIPAddress( MYCLIENT , ref REMOTEIPADDRESS ) ) ; 
        __context__.SourceCodeLine = 307;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LOCALSTATUS < 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 308;
            Trace( "Client: Error getting remote ip address. {0:d}\r\n", (short)LOCALSTATUS) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object MYCLIENT_OnSocketDisconnect_2 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 313;
        REPLYACK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 314;
        DOCLIENTCONNECTED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 315;
        if ( Functions.TestForTrue  ( ( ISTARTCLIENT)  ) ) 
            { 
            __context__.SourceCodeLine = 317;
            Trace( "Client: Socket disconnected remotely") ; 
            __context__.SourceCodeLine = 318;
            ISTARTCLIENT = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object MYCLIENT_OnSocketStatus_3 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 326;
        STATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 327;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATUS == 2))  ) ) 
            { 
            __context__.SourceCodeLine = 329;
            CreateWait ( "AUTODISCONNECT" , 1000 , AUTODISCONNECT_Callback ) ;
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 336;
            CancelWait ( "AUTODISCONNECT" ) ; 
            } 
        
        __context__.SourceCodeLine = 338;
        AOCLIENTSTATUS  .Value = (ushort) ( STATUS ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public void AUTODISCONNECT_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 331;
            FSTOPCLIENT (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object MYCLIENT_OnSocketReceive_4 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        ushort REPLYERRLEN = 0;
        ushort REPLYVALUELEN = 0;
        
        ushort NITERATION = 0;
        
        
        __context__.SourceCodeLine = 345;
        CancelWait ( "WAITER" ) ; 
        __context__.SourceCodeLine = 346;
        CancelWait ( "WAITER2" ) ; 
        __context__.SourceCodeLine = 348;
        if ( Functions.TestForTrue  ( ( RXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 350;
            RXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 351;
            NITERATION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 352;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , MYCLIENT.SocketRxBuf ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 354;
                NITERATION = (ushort) ( (NITERATION + 1) ) ; 
                __context__.SourceCodeLine = 355;
                RXCOMMAND  .UpdateValue ( Functions.Remove ( "\r\n" , MYCLIENT .  SocketRxBuf )  ) ; 
                __context__.SourceCodeLine = 356;
                Trace( "{0:d} - {1}\r\n", (short)NITERATION, RXCOMMAND ) ; 
                __context__.SourceCodeLine = 357;
                REPLYACK = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 352;
                } 
            
            __context__.SourceCodeLine = 359;
            NITERATION = (ushort) ( (NITERATION + 1) ) ; 
            __context__.SourceCodeLine = 360;
            RXCOMMAND  .UpdateValue ( MYCLIENT .  SocketRxBuf  ) ; 
            __context__.SourceCodeLine = 361;
            Functions.ClearBuffer ( MYCLIENT .  SocketRxBuf ) ; 
            __context__.SourceCodeLine = 362;
            Trace( "{0:d} - {1}\r\n", (short)NITERATION, RXCOMMAND ) ; 
            __context__.SourceCodeLine = 363;
            RESPONSE__DOLLAR__  .UpdateValue ( RXCOMMAND  ) ; 
            __context__.SourceCodeLine = 364;
            REPLYACK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 365;
            RXOK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 366;
            FSTOPCLIENT (  __context__  ) ; 
            } 
        
        __context__.SourceCodeLine = 368;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( MYCLIENT.SocketRxBuf ) > 1000 ))  ) ) 
            { 
            __context__.SourceCodeLine = 370;
            Functions.ClearBuffer ( MYCLIENT .  SocketRxBuf ) ; 
            __context__.SourceCodeLine = 371;
            Trace( "****Buffer Emergency Clear!****\r\n") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 389;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 390;
        CHRSZ = (int) ( 8 ) ; 
        __context__.SourceCodeLine = 391;
        RXOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 392;
        PROCESSINGCOMMANDS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 393;
        QUERY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 394;
        REPLYACK = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    HEX_TAB  = new ushort[ 17 ];
    BIN  = new int[ 2001 ];
    BINARRAY  = new int[ 5 ];
    SCLIENTRX__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    COMMANDVALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    REPLYERR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    REPLYVALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    RNDM__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    COMMANDLIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
    RXCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
    NEXTCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    REPLYOK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    MYCLIENT  = new SplusTcpClient ( 1024, this );
    
    DOCLIENTCONNECTED = new Crestron.Logos.SplusObjects.DigitalOutput( DOCLIENTCONNECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DOCLIENTCONNECTED__DigitalOutput__, DOCLIENTCONNECTED );
    
    AOCLIENTSTATUS = new Crestron.Logos.SplusObjects.AnalogOutput( AOCLIENTSTATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AOCLIENTSTATUS__AnalogSerialOutput__, AOCLIENTSTATUS );
    
    COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( COMMAND__DOLLAR____AnalogSerialInput__, 15, this );
    m_StringInputList.Add( COMMAND__DOLLAR____AnalogSerialInput__, COMMAND__DOLLAR__ );
    
    RESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESPONSE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESPONSE__DOLLAR____AnalogSerialOutput__, RESPONSE__DOLLAR__ );
    
    HTTP_PORTNUMBER = new UShortParameter( HTTP_PORTNUMBER__Parameter__, this );
    m_ParameterList.Add( HTTP_PORTNUMBER__Parameter__, HTTP_PORTNUMBER );
    
    CLIENTRECONNECTENABLE = new UShortParameter( CLIENTRECONNECTENABLE__Parameter__, this );
    m_ParameterList.Add( CLIENTRECONNECTENABLE__Parameter__, CLIENTRECONNECTENABLE );
    
    SERVER_IP_ADDRESS = new StringParameter( SERVER_IP_ADDRESS__Parameter__, this );
    m_ParameterList.Add( SERVER_IP_ADDRESS__Parameter__, SERVER_IP_ADDRESS );
    
    RESOURCE_STRING = new StringParameter( RESOURCE_STRING__Parameter__, this );
    m_ParameterList.Add( RESOURCE_STRING__Parameter__, RESOURCE_STRING );
    
    POSTAMBLE_STRING = new StringParameter( POSTAMBLE_STRING__Parameter__, this );
    m_ParameterList.Add( POSTAMBLE_STRING__Parameter__, POSTAMBLE_STRING );
    
    WAITER_Callback = new WaitFunction( WAITER_CallbackFn );
    WAITER2_Callback = new WaitFunction( WAITER2_CallbackFn );
    AUTODISCONNECT_Callback = new WaitFunction( AUTODISCONNECT_CallbackFn );
    
    COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( COMMAND__DOLLAR___OnChange_0, false ) );
    MYCLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( MYCLIENT_OnSocketConnect_1, false ) );
    MYCLIENT.OnSocketDisconnect.Add( new SocketHandlerWrapper( MYCLIENT_OnSocketDisconnect_2, false ) );
    MYCLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( MYCLIENT_OnSocketStatus_3, false ) );
    MYCLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( MYCLIENT_OnSocketReceive_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PANASONIC_AW_CAMERA_DRIVE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAITER_Callback;
private WaitFunction WAITER2_Callback;
private WaitFunction AUTODISCONNECT_Callback;


const uint COMMAND__DOLLAR____AnalogSerialInput__ = 0;
const uint DOCLIENTCONNECTED__DigitalOutput__ = 0;
const uint AOCLIENTSTATUS__AnalogSerialOutput__ = 0;
const uint RESPONSE__DOLLAR____AnalogSerialOutput__ = 1;
const uint HTTP_PORTNUMBER__Parameter__ = 10;
const uint SERVER_IP_ADDRESS__Parameter__ = 11;
const uint CLIENTRECONNECTENABLE__Parameter__ = 12;
const uint RESOURCE_STRING__Parameter__ = 13;
const uint POSTAMBLE_STRING__Parameter__ = 14;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
