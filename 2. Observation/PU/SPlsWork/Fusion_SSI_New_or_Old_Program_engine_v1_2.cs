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
using Fusion_System_Info;

namespace CrestronModule_FUSION_SSI_NEW_OR_OLD_PROGRAM_ENGINE_V1_2
{
    public class CrestronModuleClass_FUSION_SSI_NEW_OR_OLD_PROGRAM_ENGINE_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput TRIGGER;
        Crestron.Logos.SplusObjects.BufferInput CONSOLE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput NEWPROGRAM;
        Crestron.Logos.SplusObjects.DigitalOutput EXISTINGPROGRAM;
        Crestron.Logos.SplusObjects.DigitalOutput DIFFERENTPROGRAM;
        Crestron.Logos.SplusObjects.DigitalOutput DIFFERENTCOMPILEDONDATE;
        Crestron.Logos.SplusObjects.StringOutput CONSOLE_TX__DOLLAR__;
        CrestronString TEMPSOURCEFILE;
        CrestronString TEMPCOMPILEDON;
        Fusion_System_Info.FusionSystemInfo FUSIONSYSTEMINFO;
        private void VC4CHECKPROGRAM (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 31;
            TEMPSOURCEFILE  .UpdateValue ( FUSIONSYSTEMINFO . GetProgramFileName ( )  ) ; 
            __context__.SourceCodeLine = 33;
            TEMPCOMPILEDON  .UpdateValue ( FUSIONSYSTEMINFO . GetCompileDate ( )  ) ; 
            __context__.SourceCodeLine = 35;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSOURCEFILE != _SplusNVRAM.SOURCEFILE))  ) ) 
                { 
                __context__.SourceCodeLine = 37;
                _SplusNVRAM.SOURCEFILE  .UpdateValue ( TEMPSOURCEFILE  ) ; 
                __context__.SourceCodeLine = 38;
                DIFFERENTPROGRAM  .Value = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 41;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPCOMPILEDON != _SplusNVRAM.COMPILEDON[ 1 ]))  ) ) 
                { 
                __context__.SourceCodeLine = 43;
                _SplusNVRAM.COMPILEDON [ 1 ]  .UpdateValue ( TEMPCOMPILEDON  ) ; 
                __context__.SourceCodeLine = 44;
                DIFFERENTCOMPILEDONDATE  .Value = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DIFFERENTPROGRAM  .Value ) || Functions.TestForTrue ( DIFFERENTCOMPILEDONDATE  .Value )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 49;
                NEWPROGRAM  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 53;
                EXISTINGPROGRAM  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        private void GETINFO (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 60;
            NEWPROGRAM  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 61;
            EXISTINGPROGRAM  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 62;
            DIFFERENTPROGRAM  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 63;
            DIFFERENTCOMPILEDONDATE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 66;
            Functions.ClearBuffer ( CONSOLE_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 67;
            Functions.ClearBuffer ( TEMPSOURCEFILE ) ; 
            __context__.SourceCodeLine = 68;
            Functions.ClearBuffer ( TEMPCOMPILEDON ) ; 
            __context__.SourceCodeLine = 70;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.GetSeries() == 3) ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.GetSeries() == 4) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 72;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUSIONSYSTEMINFO.DevicePlatform() == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 74;
                    VC4CHECKPROGRAM (  __context__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 78;
                    MakeString ( CONSOLE_TX__DOLLAR__ , "PROGCOMMENTS:{0:d}\r\n", (short)GetProgramNumber()) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 81;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetSeries() == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 83;
                    MakeString ( CONSOLE_TX__DOLLAR__ , "PROGCOMMENTS\r\n") ; 
                    } 
                
                }
            
            
            }
            
        object CONSOLE_RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort POS1 = 0;
                ushort POS2 = 0;
                
                CrestronString TEMP;
                TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2000, this );
                
                
                __context__.SourceCodeLine = 92;
                TEMP  .UpdateValue ( Functions.Gather ( ">" , CONSOLE_RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 94;
                POS1 = (ushort) ( Functions.Find( "\u000D\u000ASource File:  " , TEMP ) ) ; 
                __context__.SourceCodeLine = 95;
                POS2 = (ushort) ( Functions.Find( "\u000D" , TEMP , (POS1 + 1) ) ) ; 
                __context__.SourceCodeLine = 97;
                TEMPSOURCEFILE  .UpdateValue ( Functions.Mid ( TEMP ,  (int) ( (POS1 + 16) ) ,  (int) ( (POS2 - (POS1 + 16)) ) )  ) ; 
                __context__.SourceCodeLine = 99;
                POS1 = (ushort) ( Functions.Find( "\u000D\u000ACompiled On:  " , TEMP ) ) ; 
                __context__.SourceCodeLine = 100;
                POS2 = (ushort) ( Functions.Find( "\u000D" , TEMP , (POS1 + 1) ) ) ; 
                __context__.SourceCodeLine = 102;
                TEMPCOMPILEDON  .UpdateValue ( Functions.Mid ( TEMP ,  (int) ( (POS1 + 16) ) ,  (int) ( (POS2 - (POS1 + 16)) ) )  ) ; 
                __context__.SourceCodeLine = 104;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSOURCEFILE != _SplusNVRAM.SOURCEFILE))  ) ) 
                    { 
                    __context__.SourceCodeLine = 106;
                    _SplusNVRAM.SOURCEFILE  .UpdateValue ( TEMPSOURCEFILE  ) ; 
                    __context__.SourceCodeLine = 107;
                    DIFFERENTPROGRAM  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 110;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPCOMPILEDON != _SplusNVRAM.COMPILEDON[ 1 ]))  ) ) 
                    { 
                    __context__.SourceCodeLine = 112;
                    _SplusNVRAM.COMPILEDON [ 1 ]  .UpdateValue ( TEMPCOMPILEDON  ) ; 
                    __context__.SourceCodeLine = 113;
                    DIFFERENTCOMPILEDONDATE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DIFFERENTPROGRAM  .Value ) || Functions.TestForTrue ( DIFFERENTCOMPILEDONDATE  .Value )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 118;
                    NEWPROGRAM  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 122;
                    EXISTINGPROGRAM  .Value = (ushort) ( 1 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object TRIGGER_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 129;
            GETINFO (  __context__  ) ; 
            
            
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
        
        __context__.SourceCodeLine = 136;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.COMPILEDON[ 0 ] != "RaZoR"))  ) ) 
            { 
            __context__.SourceCodeLine = 138;
            _SplusNVRAM.SOURCEFILE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 139;
            _SplusNVRAM.COMPILEDON [ 1 ]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 140;
            _SplusNVRAM.COMPILEDON [ 0 ]  .UpdateValue ( "RaZoR"  ) ; 
            } 
        
        __context__.SourceCodeLine = 143;
        FUSIONSYSTEMINFO . Initialize ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.SOURCEFILE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
    TEMPSOURCEFILE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
    TEMPCOMPILEDON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    _SplusNVRAM.COMPILEDON  = new CrestronString[ 2 ];
    for( uint i = 0; i < 2; i++ )
        _SplusNVRAM.COMPILEDON [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    
    TRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( TRIGGER__DigitalInput__, this );
    m_DigitalInputList.Add( TRIGGER__DigitalInput__, TRIGGER );
    
    NEWPROGRAM = new Crestron.Logos.SplusObjects.DigitalOutput( NEWPROGRAM__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEWPROGRAM__DigitalOutput__, NEWPROGRAM );
    
    EXISTINGPROGRAM = new Crestron.Logos.SplusObjects.DigitalOutput( EXISTINGPROGRAM__DigitalOutput__, this );
    m_DigitalOutputList.Add( EXISTINGPROGRAM__DigitalOutput__, EXISTINGPROGRAM );
    
    DIFFERENTPROGRAM = new Crestron.Logos.SplusObjects.DigitalOutput( DIFFERENTPROGRAM__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIFFERENTPROGRAM__DigitalOutput__, DIFFERENTPROGRAM );
    
    DIFFERENTCOMPILEDONDATE = new Crestron.Logos.SplusObjects.DigitalOutput( DIFFERENTCOMPILEDONDATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIFFERENTCOMPILEDONDATE__DigitalOutput__, DIFFERENTCOMPILEDONDATE );
    
    CONSOLE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, CONSOLE_TX__DOLLAR__ );
    
    CONSOLE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CONSOLE_RX__DOLLAR____AnalogSerialInput__, 3000, this );
    m_StringInputList.Add( CONSOLE_RX__DOLLAR____AnalogSerialInput__, CONSOLE_RX__DOLLAR__ );
    
    
    CONSOLE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLE_RX__DOLLAR___OnChange_0, true ) );
    TRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRIGGER_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    FUSIONSYSTEMINFO  = new Fusion_System_Info.FusionSystemInfo();
    
    
}

public CrestronModuleClass_FUSION_SSI_NEW_OR_OLD_PROGRAM_ENGINE_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TRIGGER__DigitalInput__ = 0;
const uint CONSOLE_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint NEWPROGRAM__DigitalOutput__ = 0;
const uint EXISTINGPROGRAM__DigitalOutput__ = 1;
const uint DIFFERENTPROGRAM__DigitalOutput__ = 2;
const uint DIFFERENTCOMPILEDONDATE__DigitalOutput__ = 3;
const uint CONSOLE_TX__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public CrestronString SOURCEFILE;
            [SplusStructAttribute(1, false, true)]
            public CrestronString [] COMPILEDON;
            
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
