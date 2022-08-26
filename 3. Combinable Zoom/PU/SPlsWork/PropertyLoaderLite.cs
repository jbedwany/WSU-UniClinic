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

namespace UserModule_PROPERTYLOADERLITE
{
    public class UserModuleClass_PROPERTYLOADERLITE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput DIREADFILE;
        Crestron.Logos.SplusObjects.DigitalOutput DOFILEREADSUCCESSFUL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOPROPERTYNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOPROPERTYVALUE;
        StringParameter SPFILEPATH;
        StringParameter SPFILEEXTENSION;
        StringParameter SPDELIMETER;
        StringParameter SPEOLDELIMETER;
        CrestronString GSINSTANCENAME;
        CrestronString GSDEBUGPREFIX;
        CrestronString GSFILENAME;
        private void FPARSERAWDATA (  SplusExecutionContext __context__, CrestronString ARAWDATA ) 
            { 
            ushort LIFIRSTDELIMETERINDEX = 0;
            
            ushort LISECONDDELIMETERINDEX = 0;
            
            ushort LIEOLDELIMETERINDEX = 0;
            
            ushort I = 0;
            
            CrestronString S;
            S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 146;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)100; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 147;
                LIFIRSTDELIMETERINDEX = (ushort) ( Functions.Find( SPDELIMETER  , ARAWDATA ) ) ; 
                __context__.SourceCodeLine = 148;
                LISECONDDELIMETERINDEX = (ushort) ( Functions.Find( SPDELIMETER  , ARAWDATA , (LIFIRSTDELIMETERINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 149;
                LIEOLDELIMETERINDEX = (ushort) ( Functions.Find( SPEOLDELIMETER  , ARAWDATA , (LISECONDDELIMETERINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 151;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( LIFIRSTDELIMETERINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LISECONDDELIMETERINDEX > LIFIRSTDELIMETERINDEX ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LIEOLDELIMETERINDEX > LISECONDDELIMETERINDEX ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 152;
                    SOPROPERTYNAME [ I]  .UpdateValue ( Functions.Mid ( ARAWDATA ,  (int) ( (LIFIRSTDELIMETERINDEX + 1) ) ,  (int) ( ((LISECONDDELIMETERINDEX - LIFIRSTDELIMETERINDEX) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 153;
                    SOPROPERTYVALUE [ I]  .UpdateValue ( Functions.Mid ( ARAWDATA ,  (int) ( (LISECONDDELIMETERINDEX + 1) ) ,  (int) ( ((LIEOLDELIMETERINDEX - LISECONDDELIMETERINDEX) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 154;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 155;
                        Trace( "{0} : Property {1:d} loaded.", GSDEBUGPREFIX , (ushort)I) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 158;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 159;
                        Trace( "{0} : Insufficient delimeters detected to populate next property. Skipping.", GSDEBUGPREFIX ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 161;
                    continue ; 
                    } 
                
                __context__.SourceCodeLine = 164;
                S  .UpdateValue ( Functions.Remove ( SPEOLDELIMETER , ARAWDATA )  ) ; 
                __context__.SourceCodeLine = 146;
                } 
            
            
            }
            
        object ENABLE_DEBUG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 174;
                _SplusNVRAM.GIDEBUG = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 175;
                Trace( "{0} : Enabling debug.\r\n", GSDEBUGPREFIX ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ENABLE_DEBUG_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 182;
            _SplusNVRAM.GIDEBUG = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 183;
            Trace( "{0} : Disabling debug.\r\n", GSDEBUGPREFIX ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DIREADFILE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short LSIFILEHANDLE = 0;
        
        short LSISTRINGREADERROR = 0;
        
        ushort I = 0;
        
        CrestronString LSRAWDATA;
        LSRAWDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8192, this );
        
        
        __context__.SourceCodeLine = 195;
        LSRAWDATA  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 197;
        StartFileOperations ( ) ; 
        __context__.SourceCodeLine = 199;
        LSIFILEHANDLE = (short) ( FileOpenShared( GSFILENAME ,(ushort) (2 | 16384) ) ) ; 
        __context__.SourceCodeLine = 201;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LSIFILEHANDLE < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 202;
            Trace( "{0} : Error opening file.\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 204;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 205;
                Trace( "{0} : Successfully opened file.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            __context__.SourceCodeLine = 207;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FileRead( (short)( LSIFILEHANDLE ) , LSRAWDATA , (ushort)( 8192 ) ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 208;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 209;
                    Trace( "{0} : Read from file: {1}\r\n", GSDEBUGPREFIX , LSRAWDATA ) ; 
                    } 
                
                __context__.SourceCodeLine = 211;
                FPARSERAWDATA (  __context__ , LSRAWDATA) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 212;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileRead( (short)( LSIFILEHANDLE ) , LSRAWDATA , (ushort)( 8192 ) ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 213;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 214;
                        Trace( "{0} : No data found in file.\r\n", GSDEBUGPREFIX ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 217;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 218;
                        Trace( "{0} : Error reading data from file.\r\n", GSDEBUGPREFIX ) ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 222;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 223;
                Trace( "{0} : File read successful.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            __context__.SourceCodeLine = 225;
            DOFILEREADSUCCESSFUL  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 226;
            Functions.Delay (  (int) ( 100 ) ) ; 
            __context__.SourceCodeLine = 227;
            DOFILEREADSUCCESSFUL  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 230;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( LSIFILEHANDLE ) ) != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 231;
            Trace( "{0} : Error closing file. File use will have issues until closed or system rebooted.\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 233;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 234;
                Trace( "{0} : Successfully closed file.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 237;
        EndFileOperations ( ) ; 
        
        
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
        
        __context__.SourceCodeLine = 246;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 247;
        GSINSTANCENAME  .UpdateValue ( GetSymbolInstanceName ( )  ) ; 
        __context__.SourceCodeLine = 248;
        MakeString ( GSDEBUGPREFIX , "Debug {0}-{1}\r\n", GSINSTANCENAME , "Property Loader Lite" ) ; 
        __context__.SourceCodeLine = 249;
        MakeString ( GSFILENAME , "\\NVRAM\\{0}{1}\r\n", SPFILEPATH , SPFILEEXTENSION ) ; 
        __context__.SourceCodeLine = 251;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CheckForNVRAMDisk() != 1))  ) ) 
            { 
            __context__.SourceCodeLine = 252;
            Trace( "{0} : No NVRAM disk found!\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 254;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 255;
                Trace( "{0} : NVRAM disk found.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 259;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 260;
            Trace( "{0} : S+ Module Started\r\n", GSDEBUGPREFIX ) ; 
            __context__.SourceCodeLine = 261;
            Trace( "{0} : Parameters parsed. Config filename is {1}{2}, property delimeter is {3}, EOL delimeter is {4}.\r\n", GSDEBUGPREFIX , SPFILEPATH , SPFILEEXTENSION , SPDELIMETER , SPEOLDELIMETER ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    GSINSTANCENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    GSDEBUGPREFIX  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    GSFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ENABLE_DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_DEBUG__DigitalInput__, ENABLE_DEBUG );
    
    DIREADFILE = new Crestron.Logos.SplusObjects.DigitalInput( DIREADFILE__DigitalInput__, this );
    m_DigitalInputList.Add( DIREADFILE__DigitalInput__, DIREADFILE );
    
    DOFILEREADSUCCESSFUL = new Crestron.Logos.SplusObjects.DigitalOutput( DOFILEREADSUCCESSFUL__DigitalOutput__, this );
    m_DigitalOutputList.Add( DOFILEREADSUCCESSFUL__DigitalOutput__, DOFILEREADSUCCESSFUL );
    
    SOPROPERTYNAME = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOPROPERTYNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOPROPERTYNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOPROPERTYNAME__AnalogSerialOutput__ + i, SOPROPERTYNAME[i+1] );
    }
    
    SOPROPERTYVALUE = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SOPROPERTYVALUE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOPROPERTYVALUE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOPROPERTYVALUE__AnalogSerialOutput__ + i, SOPROPERTYVALUE[i+1] );
    }
    
    SPFILEPATH = new StringParameter( SPFILEPATH__Parameter__, this );
    m_ParameterList.Add( SPFILEPATH__Parameter__, SPFILEPATH );
    
    SPFILEEXTENSION = new StringParameter( SPFILEEXTENSION__Parameter__, this );
    m_ParameterList.Add( SPFILEEXTENSION__Parameter__, SPFILEEXTENSION );
    
    SPDELIMETER = new StringParameter( SPDELIMETER__Parameter__, this );
    m_ParameterList.Add( SPDELIMETER__Parameter__, SPDELIMETER );
    
    SPEOLDELIMETER = new StringParameter( SPEOLDELIMETER__Parameter__, this );
    m_ParameterList.Add( SPEOLDELIMETER__Parameter__, SPEOLDELIMETER );
    
    
    ENABLE_DEBUG.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_DEBUG_OnPush_0, false ) );
    ENABLE_DEBUG.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_DEBUG_OnRelease_1, false ) );
    DIREADFILE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIREADFILE_OnPush_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PROPERTYLOADERLITE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE_DEBUG__DigitalInput__ = 0;
const uint DIREADFILE__DigitalInput__ = 1;
const uint DOFILEREADSUCCESSFUL__DigitalOutput__ = 0;
const uint SOPROPERTYNAME__AnalogSerialOutput__ = 0;
const uint SOPROPERTYVALUE__AnalogSerialOutput__ = 100;
const uint SPFILEPATH__Parameter__ = 10;
const uint SPFILEEXTENSION__Parameter__ = 11;
const uint SPDELIMETER__Parameter__ = 12;
const uint SPEOLDELIMETER__Parameter__ = 13;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort GIDEBUG = 0;
            
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
