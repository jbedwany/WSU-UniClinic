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

namespace UserModule_PANASONIC_AW_UE70_V2
{
    public class UserModuleClass_PANASONIC_AW_UE70_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput PAN_UP;
        Crestron.Logos.SplusObjects.DigitalInput PAN_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput PAN_LEFT;
        Crestron.Logos.SplusObjects.DigitalInput PAN_RIGHT;
        Crestron.Logos.SplusObjects.DigitalInput PAN_UPRIGHT;
        Crestron.Logos.SplusObjects.DigitalInput PAN_UPLEFT;
        Crestron.Logos.SplusObjects.DigitalInput PAN_DNRIGHT;
        Crestron.Logos.SplusObjects.DigitalInput PAN_DNLEFT;
        Crestron.Logos.SplusObjects.DigitalInput ZOOM_IN;
        Crestron.Logos.SplusObjects.DigitalInput ZOOM_OUT;
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET_1;
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET_2;
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET_3;
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET_4;
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET_5;
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET_6;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_PRESET_1;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_PRESET_2;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_PRESET_3;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_PRESET_4;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_PRESET_5;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_PRESET_6;
        StringParameter IP_ADDRESS;
        StringParameter USERNAME;
        StringParameter PASSWORD;
        UShortParameter LEFT_RIGHT_SPEED;
        UShortParameter UP_DOWN_SPEED;
        UShortParameter ZOOM_SPEED;
        UShortParameter AUTHENTICATION;
        ushort [] CODES;
        ushort IUP = 0;
        ushort IDN = 0;
        ushort ILEFT = 0;
        ushort IRIGHT = 0;
        ushort IZOOM = 0;
        CrestronString GSQUEUE;
        CrestronString GSDATA;
        CrestronString GICOMMAND;
        SplusTcpClient CAMERA;
        private CrestronString GETCHAR (  SplusExecutionContext __context__, short INT ) 
            { 
            
            __context__.SourceCodeLine = 136;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INT >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 138;
                return ( Functions.Mid ( "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=" ,  (int) ( (INT + 1) ) ,  (int) ( 1 ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 142;
                return ( "" ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private CrestronString BASE64_ENCODE (  SplusExecutionContext __context__, CrestronString INPUT ) 
            { 
            short ENC1 = 0;
            short ENC2 = 0;
            short ENC3 = 0;
            short ENC4 = 0;
            
            short CHR1 = 0;
            short CHR2 = 0;
            short CHR3 = 0;
            
            CrestronString RESULT;
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            ushort N = 0;
            
            
            __context__.SourceCodeLine = 152;
            RESULT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 153;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( INPUT ); 
            int __FN_FORSTEP_VAL__1 = (int)3; 
            for ( N  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (N  >= __FN_FORSTART_VAL__1) && (N  <= __FN_FOREND_VAL__1) ) : ( (N  <= __FN_FORSTART_VAL__1) && (N  >= __FN_FOREND_VAL__1) ) ; N  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 155;
                CHR1 = (short) ( Byte( INPUT , (int)( N ) ) ) ; 
                __context__.SourceCodeLine = 156;
                CHR2 = (short) ( Byte( INPUT , (int)( (N + 1) ) ) ) ; 
                __context__.SourceCodeLine = 157;
                CHR3 = (short) ( Byte( INPUT , (int)( (N + 2) ) ) ) ; 
                __context__.SourceCodeLine = 158;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHR2 == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    { 
                    __context__.SourceCodeLine = 158;
                    CHR2 = (short) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 159;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHR3 == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    { 
                    __context__.SourceCodeLine = 159;
                    CHR3 = (short) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 161;
                ENC1 = (short) ( (CHR1 >> 2) ) ; 
                __context__.SourceCodeLine = 162;
                ENC2 = (short) ( (((CHR1 & 3) << 4) | (CHR2 >> 4)) ) ; 
                __context__.SourceCodeLine = 163;
                ENC3 = (short) ( (((CHR2 & 15) << 2) | (CHR3 >> 6)) ) ; 
                __context__.SourceCodeLine = 164;
                ENC4 = (short) ( (CHR3 & 63) ) ; 
                __context__.SourceCodeLine = 165;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHR2 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 165;
                    ENC3 = (short) ( 64 ) ; 
                    __context__.SourceCodeLine = 165;
                    ENC4 = (short) ( 64 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 166;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHR3 == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 166;
                        ENC4 = (short) ( 64 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 168;
                RESULT  .UpdateValue ( RESULT + GETCHAR (  __context__ , (short)( ENC1 )) + GETCHAR (  __context__ , (short)( ENC2 )) + GETCHAR (  __context__ , (short)( ENC3 )) + GETCHAR (  __context__ , (short)( ENC4 ))  ) ; 
                __context__.SourceCodeLine = 153;
                } 
            
            __context__.SourceCodeLine = 170;
            return ( RESULT ) ; 
            
            }
            
        private void SENDCOMMAND (  SplusExecutionContext __context__, CrestronString COMMAND ) 
            { 
            short ERROR = 0;
            
            
            __context__.SourceCodeLine = 181;
            GSQUEUE  .UpdateValue ( COMMAND  ) ; 
            __context__.SourceCodeLine = 184;
            ERROR = (short) ( Functions.SocketConnectClient( CAMERA , IP_ADDRESS  , (ushort)( 80 ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 185;
            Trace( "Connecting TCP Client: {0:d}", (short)ERROR) ; 
            __context__.SourceCodeLine = 186;
            Trace( "{0}", GSQUEUE ) ; 
            
            }
            
        private void SENDKEY (  SplusExecutionContext __context__ ) 
            { 
            CrestronString AUTH;
            CrestronString BASIC;
            AUTH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            BASIC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            CrestronString DATA;
            CrestronString P;
            DATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            P  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            
            __context__.SourceCodeLine = 193;
            P  .UpdateValue ( Functions.Chr (  (int) ( 37 ) )  ) ; 
            __context__.SourceCodeLine = 195;
            BASIC  .UpdateValue ( USERNAME + ":" + PASSWORD  ) ; 
            __context__.SourceCodeLine = 196;
            AUTH  .UpdateValue ( BASE64_ENCODE (  __context__ , BASIC)  ) ; 
            __context__.SourceCodeLine = 198;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AUTHENTICATION  .Value == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 201;
                MakeString ( DATA , "GET /cgi-bin/aw_ptz?cmd={0}23{1}&res=1 HTTP/1.1\r\nHost: {2}\r\nAuthorization: Basic {3}\r\n\r\n ", P , GICOMMAND , IP_ADDRESS , AUTH ) ; 
                __context__.SourceCodeLine = 203;
                SENDCOMMAND (  __context__ , DATA) ; 
                } 
            
            __context__.SourceCodeLine = 206;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AUTHENTICATION  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 209;
                MakeString ( DATA , "GET /cgi-bin/aw_ptz?cmd={0}23{1}&res=1 HTTP/1.1\r\nHost: {2}\r\n\r\n", P , GICOMMAND , IP_ADDRESS ) ; 
                __context__.SourceCodeLine = 212;
                SENDCOMMAND (  __context__ , DATA) ; 
                } 
            
            
            }
            
        object POWER_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 220;
                GICOMMAND  .UpdateValue ( "O1"  ) ; 
                __context__.SourceCodeLine = 221;
                SENDKEY (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POWER_OFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 226;
            GICOMMAND  .UpdateValue ( "O0"  ) ; 
            __context__.SourceCodeLine = 227;
            SENDKEY (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object PAN_UP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 233;
        GICOMMAND  .UpdateValue ( "T" + Functions.ItoA (  (int) ( IUP ) )  ) ; 
        __context__.SourceCodeLine = 234;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 239;
        GICOMMAND  .UpdateValue ( "T" + Functions.ItoA (  (int) ( IDN ) )  ) ; 
        __context__.SourceCodeLine = 240;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_LEFT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 245;
        GICOMMAND  .UpdateValue ( "P" + Functions.ItoA (  (int) ( ILEFT ) )  ) ; 
        __context__.SourceCodeLine = 246;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_RIGHT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 251;
        GICOMMAND  .UpdateValue ( "P" + Functions.ItoA (  (int) ( IRIGHT ) )  ) ; 
        __context__.SourceCodeLine = 252;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_DNRIGHT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 257;
        GICOMMAND  .UpdateValue ( "PTS" + Functions.ItoA (  (int) ( IRIGHT ) ) + Functions.ItoA (  (int) ( IDN ) )  ) ; 
        __context__.SourceCodeLine = 258;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_UPLEFT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 263;
        GICOMMAND  .UpdateValue ( "PTS" + Functions.ItoA (  (int) ( ILEFT ) ) + Functions.ItoA (  (int) ( IUP ) )  ) ; 
        __context__.SourceCodeLine = 264;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_UPRIGHT_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 269;
        GICOMMAND  .UpdateValue ( "PTS" + Functions.ItoA (  (int) ( IRIGHT ) ) + Functions.ItoA (  (int) ( IUP ) )  ) ; 
        __context__.SourceCodeLine = 270;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_DNLEFT_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 275;
        GICOMMAND  .UpdateValue ( "PTS" + Functions.ItoA (  (int) ( ILEFT ) ) + Functions.ItoA (  (int) ( IDN ) )  ) ; 
        __context__.SourceCodeLine = 276;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_PRESET_1_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 283;
        GICOMMAND  .UpdateValue ( "R00"  ) ; 
        __context__.SourceCodeLine = 284;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_PRESET_2_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 289;
        GICOMMAND  .UpdateValue ( "R01"  ) ; 
        __context__.SourceCodeLine = 290;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_PRESET_3_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 294;
        GICOMMAND  .UpdateValue ( "R02"  ) ; 
        __context__.SourceCodeLine = 295;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_PRESET_4_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 300;
        GICOMMAND  .UpdateValue ( "R03"  ) ; 
        __context__.SourceCodeLine = 301;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_PRESET_5_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 305;
        GICOMMAND  .UpdateValue ( "R04"  ) ; 
        __context__.SourceCodeLine = 306;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_PRESET_6_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 311;
        GICOMMAND  .UpdateValue ( "R05"  ) ; 
        __context__.SourceCodeLine = 312;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_1_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 319;
        GICOMMAND  .UpdateValue ( "M00"  ) ; 
        __context__.SourceCodeLine = 320;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_2_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 325;
        GICOMMAND  .UpdateValue ( "M01"  ) ; 
        __context__.SourceCodeLine = 326;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_3_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 330;
        GICOMMAND  .UpdateValue ( "M02"  ) ; 
        __context__.SourceCodeLine = 331;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_4_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 336;
        GICOMMAND  .UpdateValue ( "M03"  ) ; 
        __context__.SourceCodeLine = 337;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_5_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 341;
        GICOMMAND  .UpdateValue ( "M04"  ) ; 
        __context__.SourceCodeLine = 342;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_6_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 347;
        GICOMMAND  .UpdateValue ( "M05"  ) ; 
        __context__.SourceCodeLine = 348;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OUT_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 353;
        GICOMMAND  .UpdateValue ( "Z" + Functions.ItoA (  (int) ( ZOOM_SPEED  .Value ) )  ) ; 
        __context__.SourceCodeLine = 354;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_IN_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 360;
        GICOMMAND  .UpdateValue ( "Z" + Functions.ItoA (  (int) ( IZOOM ) )  ) ; 
        __context__.SourceCodeLine = 361;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_PRESET_6_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 367;
        GICOMMAND  .UpdateValue ( "M05"  ) ; 
        __context__.SourceCodeLine = 368;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_LEFT_OnRelease_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 377;
        GICOMMAND  .UpdateValue ( "P" + Functions.ItoA (  (int) ( 50 ) )  ) ; 
        __context__.SourceCodeLine = 378;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_UP_OnRelease_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 384;
        GICOMMAND  .UpdateValue ( "T" + Functions.ItoA (  (int) ( 50 ) )  ) ; 
        __context__.SourceCodeLine = 385;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_UPRIGHT_OnRelease_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 391;
        GICOMMAND  .UpdateValue ( "PTS5050"  ) ; 
        __context__.SourceCodeLine = 392;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_IN_OnRelease_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 399;
        GICOMMAND  .UpdateValue ( "Z50"  ) ; 
        __context__.SourceCodeLine = 400;
        SENDKEY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CAMERA_OnSocketConnect_29 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short ERROR = 0;
        
        
        __context__.SourceCodeLine = 409;
        ERROR = (short) ( Functions.SocketSend( CAMERA , GSQUEUE ) ) ; 
        __context__.SourceCodeLine = 410;
        Trace( "Sent to TCP Client: {0:d}", (short)ERROR) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object CAMERA_OnSocketReceive_30 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short ERROR = 0;
        
        
        __context__.SourceCodeLine = 417;
        GSDATA  .UpdateValue ( CAMERA .  SocketRxBuf  ) ; 
        __context__.SourceCodeLine = 418;
        Functions.ClearBuffer ( CAMERA .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 419;
        Functions.SocketDisconnectClient ( CAMERA ) ; 
        __context__.SourceCodeLine = 420;
        Trace( "Recieved From TCP Client: {0}", GSDATA ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 426;
        Functions.SetArray (  ref CODES , (ushort)255) ; 
        __context__.SourceCodeLine = 427;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=" ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 427;
            CODES [ Byte( "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=" , (int)( I ) )] = (ushort) ( (I - 1) ) ; 
            __context__.SourceCodeLine = 427;
            }
        
        __context__.SourceCodeLine = 428;
        IUP = (ushort) ( (100 - UP_DOWN_SPEED  .Value) ) ; 
        __context__.SourceCodeLine = 429;
        IDN = (ushort) ( UP_DOWN_SPEED  .Value ) ; 
        __context__.SourceCodeLine = 430;
        ILEFT = (ushort) ( LEFT_RIGHT_SPEED  .Value ) ; 
        __context__.SourceCodeLine = 431;
        IRIGHT = (ushort) ( (100 - LEFT_RIGHT_SPEED  .Value) ) ; 
        __context__.SourceCodeLine = 432;
        IZOOM = (ushort) ( (100 - ZOOM_SPEED  .Value) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    CODES  = new ushort[ 256 ];
    GSQUEUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    GSDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    GICOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    CAMERA  = new SplusTcpClient ( 100, this );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON__DigitalInput__, POWER_ON );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF__DigitalInput__, POWER_OFF );
    
    PAN_UP = new Crestron.Logos.SplusObjects.DigitalInput( PAN_UP__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_UP__DigitalInput__, PAN_UP );
    
    PAN_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( PAN_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_DOWN__DigitalInput__, PAN_DOWN );
    
    PAN_LEFT = new Crestron.Logos.SplusObjects.DigitalInput( PAN_LEFT__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_LEFT__DigitalInput__, PAN_LEFT );
    
    PAN_RIGHT = new Crestron.Logos.SplusObjects.DigitalInput( PAN_RIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_RIGHT__DigitalInput__, PAN_RIGHT );
    
    PAN_UPRIGHT = new Crestron.Logos.SplusObjects.DigitalInput( PAN_UPRIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_UPRIGHT__DigitalInput__, PAN_UPRIGHT );
    
    PAN_UPLEFT = new Crestron.Logos.SplusObjects.DigitalInput( PAN_UPLEFT__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_UPLEFT__DigitalInput__, PAN_UPLEFT );
    
    PAN_DNRIGHT = new Crestron.Logos.SplusObjects.DigitalInput( PAN_DNRIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_DNRIGHT__DigitalInput__, PAN_DNRIGHT );
    
    PAN_DNLEFT = new Crestron.Logos.SplusObjects.DigitalInput( PAN_DNLEFT__DigitalInput__, this );
    m_DigitalInputList.Add( PAN_DNLEFT__DigitalInput__, PAN_DNLEFT );
    
    ZOOM_IN = new Crestron.Logos.SplusObjects.DigitalInput( ZOOM_IN__DigitalInput__, this );
    m_DigitalInputList.Add( ZOOM_IN__DigitalInput__, ZOOM_IN );
    
    ZOOM_OUT = new Crestron.Logos.SplusObjects.DigitalInput( ZOOM_OUT__DigitalInput__, this );
    m_DigitalInputList.Add( ZOOM_OUT__DigitalInput__, ZOOM_OUT );
    
    RECALL_PRESET_1 = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET_1__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL_PRESET_1__DigitalInput__, RECALL_PRESET_1 );
    
    RECALL_PRESET_2 = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET_2__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL_PRESET_2__DigitalInput__, RECALL_PRESET_2 );
    
    RECALL_PRESET_3 = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET_3__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL_PRESET_3__DigitalInput__, RECALL_PRESET_3 );
    
    RECALL_PRESET_4 = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET_4__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL_PRESET_4__DigitalInput__, RECALL_PRESET_4 );
    
    RECALL_PRESET_5 = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET_5__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL_PRESET_5__DigitalInput__, RECALL_PRESET_5 );
    
    RECALL_PRESET_6 = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET_6__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL_PRESET_6__DigitalInput__, RECALL_PRESET_6 );
    
    SAVE_PRESET_1 = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_PRESET_1__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_PRESET_1__DigitalInput__, SAVE_PRESET_1 );
    
    SAVE_PRESET_2 = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_PRESET_2__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_PRESET_2__DigitalInput__, SAVE_PRESET_2 );
    
    SAVE_PRESET_3 = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_PRESET_3__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_PRESET_3__DigitalInput__, SAVE_PRESET_3 );
    
    SAVE_PRESET_4 = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_PRESET_4__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_PRESET_4__DigitalInput__, SAVE_PRESET_4 );
    
    SAVE_PRESET_5 = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_PRESET_5__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_PRESET_5__DigitalInput__, SAVE_PRESET_5 );
    
    SAVE_PRESET_6 = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_PRESET_6__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_PRESET_6__DigitalInput__, SAVE_PRESET_6 );
    
    LEFT_RIGHT_SPEED = new UShortParameter( LEFT_RIGHT_SPEED__Parameter__, this );
    m_ParameterList.Add( LEFT_RIGHT_SPEED__Parameter__, LEFT_RIGHT_SPEED );
    
    UP_DOWN_SPEED = new UShortParameter( UP_DOWN_SPEED__Parameter__, this );
    m_ParameterList.Add( UP_DOWN_SPEED__Parameter__, UP_DOWN_SPEED );
    
    ZOOM_SPEED = new UShortParameter( ZOOM_SPEED__Parameter__, this );
    m_ParameterList.Add( ZOOM_SPEED__Parameter__, ZOOM_SPEED );
    
    AUTHENTICATION = new UShortParameter( AUTHENTICATION__Parameter__, this );
    m_ParameterList.Add( AUTHENTICATION__Parameter__, AUTHENTICATION );
    
    IP_ADDRESS = new StringParameter( IP_ADDRESS__Parameter__, this );
    m_ParameterList.Add( IP_ADDRESS__Parameter__, IP_ADDRESS );
    
    USERNAME = new StringParameter( USERNAME__Parameter__, this );
    m_ParameterList.Add( USERNAME__Parameter__, USERNAME );
    
    PASSWORD = new StringParameter( PASSWORD__Parameter__, this );
    m_ParameterList.Add( PASSWORD__Parameter__, PASSWORD );
    
    
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_0, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_1, false ) );
    PAN_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_UP_OnPush_2, false ) );
    PAN_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_DOWN_OnPush_3, false ) );
    PAN_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_LEFT_OnPush_4, false ) );
    PAN_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_RIGHT_OnPush_5, false ) );
    PAN_DNRIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_DNRIGHT_OnPush_6, false ) );
    PAN_UPLEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_UPLEFT_OnPush_7, false ) );
    PAN_UPRIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_UPRIGHT_OnPush_8, false ) );
    PAN_DNLEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_DNLEFT_OnPush_9, false ) );
    RECALL_PRESET_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_1_OnPush_10, false ) );
    RECALL_PRESET_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_2_OnPush_11, false ) );
    RECALL_PRESET_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_3_OnPush_12, false ) );
    RECALL_PRESET_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_4_OnPush_13, false ) );
    RECALL_PRESET_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_5_OnPush_14, false ) );
    RECALL_PRESET_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_6_OnPush_15, false ) );
    SAVE_PRESET_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_1_OnPush_16, false ) );
    SAVE_PRESET_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_2_OnPush_17, false ) );
    SAVE_PRESET_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_3_OnPush_18, false ) );
    SAVE_PRESET_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_4_OnPush_19, false ) );
    SAVE_PRESET_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_5_OnPush_20, false ) );
    SAVE_PRESET_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_6_OnPush_21, false ) );
    ZOOM_OUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ZOOM_OUT_OnPush_22, false ) );
    ZOOM_IN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ZOOM_IN_OnPush_23, false ) );
    SAVE_PRESET_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_PRESET_6_OnPush_24, false ) );
    PAN_LEFT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_LEFT_OnRelease_25, false ) );
    PAN_RIGHT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_LEFT_OnRelease_25, false ) );
    PAN_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_UP_OnRelease_26, false ) );
    PAN_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_UP_OnRelease_26, false ) );
    PAN_UPRIGHT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_UPRIGHT_OnRelease_27, false ) );
    PAN_DNRIGHT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_UPRIGHT_OnRelease_27, false ) );
    PAN_UPLEFT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_UPRIGHT_OnRelease_27, false ) );
    PAN_DNLEFT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_UPRIGHT_OnRelease_27, false ) );
    ZOOM_IN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ZOOM_IN_OnRelease_28, false ) );
    ZOOM_OUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ZOOM_IN_OnRelease_28, false ) );
    CAMERA.OnSocketConnect.Add( new SocketHandlerWrapper( CAMERA_OnSocketConnect_29, false ) );
    CAMERA.OnSocketReceive.Add( new SocketHandlerWrapper( CAMERA_OnSocketReceive_30, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PANASONIC_AW_UE70_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POWER_ON__DigitalInput__ = 0;
const uint POWER_OFF__DigitalInput__ = 1;
const uint PAN_UP__DigitalInput__ = 2;
const uint PAN_DOWN__DigitalInput__ = 3;
const uint PAN_LEFT__DigitalInput__ = 4;
const uint PAN_RIGHT__DigitalInput__ = 5;
const uint PAN_UPRIGHT__DigitalInput__ = 6;
const uint PAN_UPLEFT__DigitalInput__ = 7;
const uint PAN_DNRIGHT__DigitalInput__ = 8;
const uint PAN_DNLEFT__DigitalInput__ = 9;
const uint ZOOM_IN__DigitalInput__ = 10;
const uint ZOOM_OUT__DigitalInput__ = 11;
const uint RECALL_PRESET_1__DigitalInput__ = 12;
const uint RECALL_PRESET_2__DigitalInput__ = 13;
const uint RECALL_PRESET_3__DigitalInput__ = 14;
const uint RECALL_PRESET_4__DigitalInput__ = 15;
const uint RECALL_PRESET_5__DigitalInput__ = 16;
const uint RECALL_PRESET_6__DigitalInput__ = 17;
const uint SAVE_PRESET_1__DigitalInput__ = 18;
const uint SAVE_PRESET_2__DigitalInput__ = 19;
const uint SAVE_PRESET_3__DigitalInput__ = 20;
const uint SAVE_PRESET_4__DigitalInput__ = 21;
const uint SAVE_PRESET_5__DigitalInput__ = 22;
const uint SAVE_PRESET_6__DigitalInput__ = 23;
const uint IP_ADDRESS__Parameter__ = 10;
const uint USERNAME__Parameter__ = 11;
const uint PASSWORD__Parameter__ = 12;
const uint LEFT_RIGHT_SPEED__Parameter__ = 13;
const uint UP_DOWN_SPEED__Parameter__ = 14;
const uint ZOOM_SPEED__Parameter__ = 15;
const uint AUTHENTICATION__Parameter__ = 16;

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
