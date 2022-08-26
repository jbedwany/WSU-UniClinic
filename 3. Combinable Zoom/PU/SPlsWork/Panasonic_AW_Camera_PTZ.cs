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

namespace UserModule_PANASONIC_AW_CAMERA_PTZ
{
    public class UserModuleClass_PANASONIC_AW_CAMERA_PTZ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PTZ_LEFT;
        Crestron.Logos.SplusObjects.DigitalInput PTZ_RIGHT;
        Crestron.Logos.SplusObjects.DigitalInput PTZ_UP;
        Crestron.Logos.SplusObjects.DigitalInput PTZ_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ZOOM_IN;
        Crestron.Logos.SplusObjects.DigitalInput ZOOM_OUT;
        Crestron.Logos.SplusObjects.DigitalInput FOCUS_NEAR;
        Crestron.Logos.SplusObjects.DigitalInput FOCUS_FAR;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_FOCUS;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_1;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_2;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_3;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_4;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_5;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_1_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_2_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_3_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_4_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput PRESET_5_SAVE;
        Crestron.Logos.SplusObjects.AnalogInput PT_SPEED;
        Crestron.Logos.SplusObjects.StringInput RESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput PT_SPEED_FB;
        Crestron.Logos.SplusObjects.StringOutput COMMAND__DOLLAR__;
        ushort NPANNING = 0;
        ushort NTILTING = 0;
        ushort NZOOMING = 0;
        ushort NFOCUSSING = 0;
        ushort NAUTOFOCUS = 0;
        ushort NVELOCITY = 0;
        CrestronString COMMANDTOSEND__DOLLAR__;
        object PTZ_LEFT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort NSPEED = 0;
                
                
                __context__.SourceCodeLine = 138;
                NSPEED = (ushort) ( (50 - NVELOCITY) ) ; 
                __context__.SourceCodeLine = 139;
                NPANNING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 140;
                MakeString ( COMMANDTOSEND__DOLLAR__ , "P{0:d2}", (short)NSPEED) ; 
                __context__.SourceCodeLine = 141;
                COMMAND__DOLLAR__  .UpdateValue ( COMMANDTOSEND__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PTZ_LEFT_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 146;
            if ( Functions.TestForTrue  ( ( NPANNING)  ) ) 
                { 
                __context__.SourceCodeLine = 148;
                COMMAND__DOLLAR__  .UpdateValue ( "P50"  ) ; 
                __context__.SourceCodeLine = 149;
                NPANNING = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object PTZ_RIGHT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NSPEED = 0;
        
        
        __context__.SourceCodeLine = 157;
        NSPEED = (ushort) ( (NVELOCITY + 50) ) ; 
        __context__.SourceCodeLine = 158;
        NPANNING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 159;
        MakeString ( COMMANDTOSEND__DOLLAR__ , "P{0:d2}", (short)NSPEED) ; 
        __context__.SourceCodeLine = 160;
        COMMAND__DOLLAR__  .UpdateValue ( COMMANDTOSEND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZ_RIGHT_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 165;
        if ( Functions.TestForTrue  ( ( NPANNING)  ) ) 
            { 
            __context__.SourceCodeLine = 167;
            COMMAND__DOLLAR__  .UpdateValue ( "P50"  ) ; 
            __context__.SourceCodeLine = 168;
            NPANNING = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZ_DOWN_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NSPEED = 0;
        
        
        __context__.SourceCodeLine = 177;
        NSPEED = (ushort) ( (50 - NVELOCITY) ) ; 
        __context__.SourceCodeLine = 178;
        NTILTING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 179;
        MakeString ( COMMANDTOSEND__DOLLAR__ , "T{0:d2}", (short)NSPEED) ; 
        __context__.SourceCodeLine = 180;
        COMMAND__DOLLAR__  .UpdateValue ( COMMANDTOSEND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZ_DOWN_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 185;
        if ( Functions.TestForTrue  ( ( NTILTING)  ) ) 
            { 
            __context__.SourceCodeLine = 187;
            COMMAND__DOLLAR__  .UpdateValue ( "T50"  ) ; 
            __context__.SourceCodeLine = 188;
            NTILTING = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZ_UP_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NSPEED = 0;
        
        
        __context__.SourceCodeLine = 196;
        NSPEED = (ushort) ( (NVELOCITY + 50) ) ; 
        __context__.SourceCodeLine = 197;
        NTILTING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 198;
        MakeString ( COMMANDTOSEND__DOLLAR__ , "T{0:d2}", (short)NSPEED) ; 
        __context__.SourceCodeLine = 199;
        COMMAND__DOLLAR__  .UpdateValue ( COMMANDTOSEND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PTZ_UP_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 204;
        if ( Functions.TestForTrue  ( ( NTILTING)  ) ) 
            { 
            __context__.SourceCodeLine = 206;
            COMMAND__DOLLAR__  .UpdateValue ( "T50"  ) ; 
            __context__.SourceCodeLine = 207;
            NTILTING = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_IN_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 213;
        NZOOMING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 214;
        COMMAND__DOLLAR__  .UpdateValue ( "Z90"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_IN_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 219;
        if ( Functions.TestForTrue  ( ( NZOOMING)  ) ) 
            { 
            __context__.SourceCodeLine = 221;
            NZOOMING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 222;
            COMMAND__DOLLAR__  .UpdateValue ( "Z50"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OUT_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 228;
        NZOOMING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 229;
        COMMAND__DOLLAR__  .UpdateValue ( "Z10"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OUT_OnRelease_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 234;
        if ( Functions.TestForTrue  ( ( NZOOMING)  ) ) 
            { 
            __context__.SourceCodeLine = 236;
            NZOOMING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 237;
            COMMAND__DOLLAR__  .UpdateValue ( "Z50"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOCUS_FAR_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 243;
        NFOCUSSING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 244;
        COMMAND__DOLLAR__  .UpdateValue ( "F75"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOCUS_FAR_OnRelease_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 249;
        if ( Functions.TestForTrue  ( ( NFOCUSSING)  ) ) 
            { 
            __context__.SourceCodeLine = 251;
            NFOCUSSING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 252;
            COMMAND__DOLLAR__  .UpdateValue ( "F50"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOCUS_NEAR_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 258;
        NFOCUSSING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 259;
        COMMAND__DOLLAR__  .UpdateValue ( "F25"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOCUS_NEAR_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 264;
        if ( Functions.TestForTrue  ( ( NFOCUSSING)  ) ) 
            { 
            __context__.SourceCodeLine = 266;
            NFOCUSSING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 267;
            COMMAND__DOLLAR__  .UpdateValue ( "F50"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_FOCUS_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 273;
        NAUTOFOCUS = (ushort) ( Functions.Not( NAUTOFOCUS ) ) ; 
        __context__.SourceCodeLine = 274;
        MakeString ( COMMANDTOSEND__DOLLAR__ , "D1{0:d}", (short)NAUTOFOCUS) ; 
        __context__.SourceCodeLine = 275;
        COMMAND__DOLLAR__  .UpdateValue ( COMMANDTOSEND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_1_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 280;
        COMMAND__DOLLAR__  .UpdateValue ( "R01"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_2_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 285;
        COMMAND__DOLLAR__  .UpdateValue ( "R02"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_3_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 290;
        COMMAND__DOLLAR__  .UpdateValue ( "R03"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_4_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 295;
        COMMAND__DOLLAR__  .UpdateValue ( "R04"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_5_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 300;
        COMMAND__DOLLAR__  .UpdateValue ( "R05"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_1_SAVE_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 305;
        COMMAND__DOLLAR__  .UpdateValue ( "M01"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_2_SAVE_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 310;
        COMMAND__DOLLAR__  .UpdateValue ( "M02"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_3_SAVE_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 315;
        COMMAND__DOLLAR__  .UpdateValue ( "M03"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_4_SAVE_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 320;
        COMMAND__DOLLAR__  .UpdateValue ( "M04"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_5_SAVE_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 325;
        COMMAND__DOLLAR__  .UpdateValue ( "M05"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PT_SPEED_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        uint LVELOCITY = 0;
        
        
        __context__.SourceCodeLine = 331;
        LVELOCITY = (uint) ( ((PT_SPEED  .UintValue * 49) / 65535) ) ; 
        __context__.SourceCodeLine = 332;
        NVELOCITY = (ushort) ( Functions.LowWord( (uint)( LVELOCITY ) ) ) ; 
        __context__.SourceCodeLine = 333;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVELOCITY > 49 ))  ) ) 
            {
            __context__.SourceCodeLine = 333;
            NVELOCITY = (ushort) ( 49 ) ; 
            }
        
        __context__.SourceCodeLine = 334;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVELOCITY < 1 ))  ) ) 
            {
            __context__.SourceCodeLine = 334;
            NVELOCITY = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 335;
        PT_SPEED_FB  .Value = (ushort) ( PT_SPEED  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 349;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 350;
        COMMAND__DOLLAR__  .UpdateValue ( "UPVS999"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    COMMANDTOSEND__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    PTZ_LEFT = new Crestron.Logos.SplusObjects.DigitalInput( PTZ_LEFT__DigitalInput__, this );
    m_DigitalInputList.Add( PTZ_LEFT__DigitalInput__, PTZ_LEFT );
    
    PTZ_RIGHT = new Crestron.Logos.SplusObjects.DigitalInput( PTZ_RIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( PTZ_RIGHT__DigitalInput__, PTZ_RIGHT );
    
    PTZ_UP = new Crestron.Logos.SplusObjects.DigitalInput( PTZ_UP__DigitalInput__, this );
    m_DigitalInputList.Add( PTZ_UP__DigitalInput__, PTZ_UP );
    
    PTZ_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( PTZ_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PTZ_DOWN__DigitalInput__, PTZ_DOWN );
    
    ZOOM_IN = new Crestron.Logos.SplusObjects.DigitalInput( ZOOM_IN__DigitalInput__, this );
    m_DigitalInputList.Add( ZOOM_IN__DigitalInput__, ZOOM_IN );
    
    ZOOM_OUT = new Crestron.Logos.SplusObjects.DigitalInput( ZOOM_OUT__DigitalInput__, this );
    m_DigitalInputList.Add( ZOOM_OUT__DigitalInput__, ZOOM_OUT );
    
    FOCUS_NEAR = new Crestron.Logos.SplusObjects.DigitalInput( FOCUS_NEAR__DigitalInput__, this );
    m_DigitalInputList.Add( FOCUS_NEAR__DigitalInput__, FOCUS_NEAR );
    
    FOCUS_FAR = new Crestron.Logos.SplusObjects.DigitalInput( FOCUS_FAR__DigitalInput__, this );
    m_DigitalInputList.Add( FOCUS_FAR__DigitalInput__, FOCUS_FAR );
    
    AUTO_FOCUS = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_FOCUS__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_FOCUS__DigitalInput__, AUTO_FOCUS );
    
    PRESET_1 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_1__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_1__DigitalInput__, PRESET_1 );
    
    PRESET_2 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_2__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_2__DigitalInput__, PRESET_2 );
    
    PRESET_3 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_3__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_3__DigitalInput__, PRESET_3 );
    
    PRESET_4 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_4__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_4__DigitalInput__, PRESET_4 );
    
    PRESET_5 = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_5__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_5__DigitalInput__, PRESET_5 );
    
    PRESET_1_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_1_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_1_SAVE__DigitalInput__, PRESET_1_SAVE );
    
    PRESET_2_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_2_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_2_SAVE__DigitalInput__, PRESET_2_SAVE );
    
    PRESET_3_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_3_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_3_SAVE__DigitalInput__, PRESET_3_SAVE );
    
    PRESET_4_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_4_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_4_SAVE__DigitalInput__, PRESET_4_SAVE );
    
    PRESET_5_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_5_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PRESET_5_SAVE__DigitalInput__, PRESET_5_SAVE );
    
    PT_SPEED = new Crestron.Logos.SplusObjects.AnalogInput( PT_SPEED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PT_SPEED__AnalogSerialInput__, PT_SPEED );
    
    PT_SPEED_FB = new Crestron.Logos.SplusObjects.AnalogOutput( PT_SPEED_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PT_SPEED_FB__AnalogSerialOutput__, PT_SPEED_FB );
    
    RESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RESPONSE__DOLLAR____AnalogSerialInput__, 10, this );
    m_StringInputList.Add( RESPONSE__DOLLAR____AnalogSerialInput__, RESPONSE__DOLLAR__ );
    
    COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( COMMAND__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMMAND__DOLLAR____AnalogSerialOutput__, COMMAND__DOLLAR__ );
    
    
    PTZ_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZ_LEFT_OnPush_0, false ) );
    PTZ_LEFT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZ_LEFT_OnRelease_1, false ) );
    PTZ_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZ_RIGHT_OnPush_2, false ) );
    PTZ_RIGHT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZ_RIGHT_OnRelease_3, false ) );
    PTZ_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZ_DOWN_OnPush_4, false ) );
    PTZ_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZ_DOWN_OnRelease_5, false ) );
    PTZ_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PTZ_UP_OnPush_6, false ) );
    PTZ_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PTZ_UP_OnRelease_7, false ) );
    ZOOM_IN.OnDigitalPush.Add( new InputChangeHandlerWrapper( ZOOM_IN_OnPush_8, false ) );
    ZOOM_IN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ZOOM_IN_OnRelease_9, false ) );
    ZOOM_OUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ZOOM_OUT_OnPush_10, false ) );
    ZOOM_OUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ZOOM_OUT_OnRelease_11, false ) );
    FOCUS_FAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( FOCUS_FAR_OnPush_12, false ) );
    FOCUS_FAR.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FOCUS_FAR_OnRelease_13, false ) );
    FOCUS_NEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( FOCUS_NEAR_OnPush_14, false ) );
    FOCUS_NEAR.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FOCUS_NEAR_OnRelease_15, false ) );
    AUTO_FOCUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_FOCUS_OnPush_16, false ) );
    PRESET_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_1_OnPush_17, false ) );
    PRESET_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_2_OnPush_18, false ) );
    PRESET_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_3_OnPush_19, false ) );
    PRESET_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_4_OnPush_20, false ) );
    PRESET_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_5_OnPush_21, false ) );
    PRESET_1_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_1_SAVE_OnPush_22, false ) );
    PRESET_2_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_2_SAVE_OnPush_23, false ) );
    PRESET_3_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_3_SAVE_OnPush_24, false ) );
    PRESET_4_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_4_SAVE_OnPush_25, false ) );
    PRESET_5_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_5_SAVE_OnPush_26, false ) );
    PT_SPEED.OnAnalogChange.Add( new InputChangeHandlerWrapper( PT_SPEED_OnChange_27, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PANASONIC_AW_CAMERA_PTZ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PTZ_LEFT__DigitalInput__ = 0;
const uint PTZ_RIGHT__DigitalInput__ = 1;
const uint PTZ_UP__DigitalInput__ = 2;
const uint PTZ_DOWN__DigitalInput__ = 3;
const uint ZOOM_IN__DigitalInput__ = 4;
const uint ZOOM_OUT__DigitalInput__ = 5;
const uint FOCUS_NEAR__DigitalInput__ = 6;
const uint FOCUS_FAR__DigitalInput__ = 7;
const uint AUTO_FOCUS__DigitalInput__ = 8;
const uint PRESET_1__DigitalInput__ = 9;
const uint PRESET_2__DigitalInput__ = 10;
const uint PRESET_3__DigitalInput__ = 11;
const uint PRESET_4__DigitalInput__ = 12;
const uint PRESET_5__DigitalInput__ = 13;
const uint PRESET_1_SAVE__DigitalInput__ = 14;
const uint PRESET_2_SAVE__DigitalInput__ = 15;
const uint PRESET_3_SAVE__DigitalInput__ = 16;
const uint PRESET_4_SAVE__DigitalInput__ = 17;
const uint PRESET_5_SAVE__DigitalInput__ = 18;
const uint PT_SPEED__AnalogSerialInput__ = 0;
const uint RESPONSE__DOLLAR____AnalogSerialInput__ = 1;
const uint PT_SPEED_FB__AnalogSerialOutput__ = 0;
const uint COMMAND__DOLLAR____AnalogSerialOutput__ = 1;

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
