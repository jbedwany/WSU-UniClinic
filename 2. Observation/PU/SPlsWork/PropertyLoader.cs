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

namespace UserModule_PROPERTYLOADER
{
    public class UserModuleClass_PROPERTYLOADER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput DIREADFILE;
        Crestron.Logos.SplusObjects.DigitalInput DIWRITEFILE;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIPROPERTYVALUE;
        Crestron.Logos.SplusObjects.DigitalOutput DOFILEOPERATIONSUCCESSFUL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOPROPERTYVALUE;
        StringParameter SPFILEPATH;
        StringParameter SPFILEEXTENSION;
        StringParameter SPDELIMETER;
        StringParameter SPEOLDELIMETER;
        ushort GIRAWDATASIZE = 0;
        CrestronString GSINSTANCENAME;
        CrestronString GSDEBUGPREFIX;
        CrestronString GSFILENAME;
        CrestronString [] GSPROPERTYNAMES;
        CrestronString [] GSCURRENTVALUES;
        private void FPARSERAWDATA (  SplusExecutionContext __context__, CrestronString ARAWDATA ) 
            { 
            ushort LIFIRSTDELIMETERINDEX = 0;
            
            ushort LISECONDDELIMETERINDEX = 0;
            
            ushort LIEOLDELIMETERINDEX = 0;
            
            ushort I = 0;
            
            CrestronString S;
            S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 149;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)100; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 150;
                LIFIRSTDELIMETERINDEX = (ushort) ( Functions.Find( SPDELIMETER  , ARAWDATA ) ) ; 
                __context__.SourceCodeLine = 151;
                LISECONDDELIMETERINDEX = (ushort) ( Functions.Find( SPDELIMETER  , ARAWDATA , (LIFIRSTDELIMETERINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 152;
                LIEOLDELIMETERINDEX = (ushort) ( Functions.Find( SPEOLDELIMETER  , ARAWDATA , (LISECONDDELIMETERINDEX + 1) ) ) ; 
                __context__.SourceCodeLine = 154;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( LIFIRSTDELIMETERINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LISECONDDELIMETERINDEX > LIFIRSTDELIMETERINDEX ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LIEOLDELIMETERINDEX > LISECONDDELIMETERINDEX ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 155;
                    GSPROPERTYNAMES [ I ]  .UpdateValue ( Functions.Mid ( ARAWDATA ,  (int) ( (LIFIRSTDELIMETERINDEX + 1) ) ,  (int) ( ((LISECONDDELIMETERINDEX - LIFIRSTDELIMETERINDEX) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 156;
                    GSCURRENTVALUES [ I ]  .UpdateValue ( Functions.Mid ( ARAWDATA ,  (int) ( (LISECONDDELIMETERINDEX + 1) ) ,  (int) ( ((LIEOLDELIMETERINDEX - LISECONDDELIMETERINDEX) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 157;
                    SOPROPERTYVALUE [ I]  .UpdateValue ( GSCURRENTVALUES [ I ]  ) ; 
                    __context__.SourceCodeLine = 158;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 159;
                        Trace( "{0} : Property {1:d} loaded.", GSDEBUGPREFIX , (ushort)I) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 162;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 163;
                        Trace( "{0} : Insufficient delimeters detected to populate next property. Skipping.", GSDEBUGPREFIX ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 165;
                    continue ; 
                    } 
                
                __context__.SourceCodeLine = 168;
                S  .UpdateValue ( Functions.Remove ( SPEOLDELIMETER , ARAWDATA )  ) ; 
                __context__.SourceCodeLine = 149;
                } 
            
            
            }
            
        private CrestronString FCONSTRUCTSTRING (  SplusExecutionContext __context__, CrestronString APROPERTYNAME , CrestronString ANEWVALUE ) 
            { 
            CrestronString RETURNSTRING;
            RETURNSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 252, this );
            
            
            __context__.SourceCodeLine = 174;
            RETURNSTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 175;
            RETURNSTRING  .UpdateValue ( APROPERTYNAME + SPDELIMETER + ANEWVALUE + SPEOLDELIMETER + "\r\n"  ) ; 
            __context__.SourceCodeLine = 176;
            return ( RETURNSTRING ) ; 
            
            }
            
        object ENABLE_DEBUG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 185;
                _SplusNVRAM.GIDEBUG = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 186;
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
            
            __context__.SourceCodeLine = 193;
            _SplusNVRAM.GIDEBUG = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 194;
            Trace( "{0} : Disabling debug.\r\n", GSDEBUGPREFIX ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DIWRITEFILE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short LSIFILEHANDLE = 0;
        
        ushort I = 0;
        
        ushort NUMBYTES = 0;
        
        CrestronString STRINGTOWRITE;
        STRINGTOWRITE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
        
        
        __context__.SourceCodeLine = 204;
        StartFileOperations ( ) ; 
        __context__.SourceCodeLine = 205;
        STRINGTOWRITE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 206;
        LSIFILEHANDLE = (short) ( FileOpenShared( GSFILENAME ,(ushort) (((1 | 16384) | 256) | 512) ) ) ; 
        __context__.SourceCodeLine = 208;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LSIFILEHANDLE < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 209;
            Trace( "{0} : Error opening file.\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 211;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 212;
                Trace( "{0} : Successfully opened file.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            __context__.SourceCodeLine = 215;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)100; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 216;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIPROPERTYVALUE[ I ] != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 217;
                    SOPROPERTYVALUE [ I]  .UpdateValue ( SIPROPERTYVALUE [ I ]  ) ; 
                    __context__.SourceCodeLine = 218;
                    STRINGTOWRITE  .UpdateValue ( Functions.ItoA (  (int) ( I ) ) + SPDELIMETER + FCONSTRUCTSTRING (  __context__ , GSPROPERTYNAMES[ I ], SIPROPERTYVALUE[ I ])  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 220;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCURRENTVALUES[ I ] != ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 221;
                        STRINGTOWRITE  .UpdateValue ( Functions.ItoA (  (int) ( I ) ) + SPDELIMETER + FCONSTRUCTSTRING (  __context__ , GSPROPERTYNAMES[ I ], GSCURRENTVALUES[ I ])  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 223;
                        STRINGTOWRITE  .UpdateValue ( Functions.ItoA (  (int) ( I ) ) + SPDELIMETER + SPDELIMETER + SPEOLDELIMETER + "\r\n"  ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 226;
                NUMBYTES = (ushort) ( (Functions.Length( STRINGTOWRITE ) + 1) ) ; 
                __context__.SourceCodeLine = 228;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FileWrite( (short)( LSIFILEHANDLE ) , STRINGTOWRITE , (ushort)( NUMBYTES ) ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 229;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 230;
                        Trace( "{0} : Successfully wrote property {1:d} to file.", GSDEBUGPREFIX , (short)I) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 233;
                STRINGTOWRITE  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 215;
                } 
            
            __context__.SourceCodeLine = 236;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( LSIFILEHANDLE ) ) != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 237;
                Trace( "{0} : Error closing file. File use will have issues until closed or system rebooted.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 239;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 240;
                    Trace( "{0} : Successfully closed file.\r\n", GSDEBUGPREFIX ) ; 
                    } 
                
                } 
            
            } 
        
        __context__.SourceCodeLine = 244;
        EndFileOperations ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIREADFILE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short LSIFILEHANDLE = 0;
        
        ushort I = 0;
        
        CrestronString LSRAWDATA;
        LSRAWDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25600, this );
        
        
        __context__.SourceCodeLine = 253;
        LSRAWDATA  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 255;
        StartFileOperations ( ) ; 
        __context__.SourceCodeLine = 257;
        LSIFILEHANDLE = (short) ( FileOpenShared( GSFILENAME ,(ushort) (2 | 16384) ) ) ; 
        __context__.SourceCodeLine = 259;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LSIFILEHANDLE < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 260;
            Trace( "{0} : Error opening file.\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 262;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 263;
                Trace( "{0} : Successfully opened file.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            __context__.SourceCodeLine = 266;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FileRead( (short)( LSIFILEHANDLE ) , LSRAWDATA , (ushort)( 8192 ) ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 267;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 268;
                    Trace( "{0} : Read from file: {1}\r\n", GSDEBUGPREFIX , LSRAWDATA ) ; 
                    } 
                
                __context__.SourceCodeLine = 270;
                FPARSERAWDATA (  __context__ , LSRAWDATA) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 271;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileRead( (short)( LSIFILEHANDLE ) , LSRAWDATA , (ushort)( 8192 ) ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 272;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 273;
                        Trace( "{0} : No data found in file.\r\n", GSDEBUGPREFIX ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 276;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 277;
                        Trace( "{0} : Error reading data from file.\r\n", GSDEBUGPREFIX ) ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 281;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 282;
                Trace( "{0} : File read successful.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            __context__.SourceCodeLine = 284;
            DOFILEOPERATIONSUCCESSFUL  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 285;
            Functions.Delay (  (int) ( 100 ) ) ; 
            __context__.SourceCodeLine = 286;
            DOFILEOPERATIONSUCCESSFUL  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 289;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( LSIFILEHANDLE ) ) != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 290;
            Trace( "{0} : Error closing file. File use will have issues until closed or system rebooted.\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 292;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 293;
                Trace( "{0} : Successfully closed file.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 296;
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
        
        __context__.SourceCodeLine = 305;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 306;
        GSINSTANCENAME  .UpdateValue ( GetSymbolInstanceName ( )  ) ; 
        __context__.SourceCodeLine = 307;
        MakeString ( GSDEBUGPREFIX , "Debug {0}-{1}\r\n", GSINSTANCENAME , "Property Loader" ) ; 
        __context__.SourceCodeLine = 308;
        MakeString ( GSFILENAME , "\\NVRAM\\{0}{1}\r\n", SPFILEPATH , SPFILEEXTENSION ) ; 
        __context__.SourceCodeLine = 310;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CheckForNVRAMDisk() != 1))  ) ) 
            { 
            __context__.SourceCodeLine = 311;
            Trace( "{0} : No NVRAM disk found!\r\n", GSDEBUGPREFIX ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 313;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 314;
                Trace( "{0} : NVRAM disk found.\r\n", GSDEBUGPREFIX ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 318;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.GIDEBUG == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 319;
            Trace( "{0} : S+ Module Started\r\n", GSDEBUGPREFIX ) ; 
            __context__.SourceCodeLine = 320;
            Trace( "{0} : Parameters parsed. Config filename is {1}{2}, property delimeter is {3}, EOL delimeter is {4}.\r\n", GSDEBUGPREFIX , SPFILEPATH , SPFILEEXTENSION , SPDELIMETER , SPEOLDELIMETER ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    GSINSTANCENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    GSDEBUGPREFIX  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    GSFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    GSPROPERTYNAMES  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        GSPROPERTYNAMES [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    GSCURRENTVALUES  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        GSCURRENTVALUES [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, this );
    
    ENABLE_DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_DEBUG__DigitalInput__, ENABLE_DEBUG );
    
    DIREADFILE = new Crestron.Logos.SplusObjects.DigitalInput( DIREADFILE__DigitalInput__, this );
    m_DigitalInputList.Add( DIREADFILE__DigitalInput__, DIREADFILE );
    
    DIWRITEFILE = new Crestron.Logos.SplusObjects.DigitalInput( DIWRITEFILE__DigitalInput__, this );
    m_DigitalInputList.Add( DIWRITEFILE__DigitalInput__, DIWRITEFILE );
    
    DOFILEOPERATIONSUCCESSFUL = new Crestron.Logos.SplusObjects.DigitalOutput( DOFILEOPERATIONSUCCESSFUL__DigitalOutput__, this );
    m_DigitalOutputList.Add( DOFILEOPERATIONSUCCESSFUL__DigitalOutput__, DOFILEOPERATIONSUCCESSFUL );
    
    SIPROPERTYVALUE = new InOutArray<StringInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        SIPROPERTYVALUE[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIPROPERTYVALUE__AnalogSerialInput__ + i, SIPROPERTYVALUE__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( SIPROPERTYVALUE__AnalogSerialInput__ + i, SIPROPERTYVALUE[i+1] );
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
    DIWRITEFILE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIWRITEFILE_OnPush_2, false ) );
    DIREADFILE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIREADFILE_OnPush_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PROPERTYLOADER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE_DEBUG__DigitalInput__ = 0;
const uint DIREADFILE__DigitalInput__ = 1;
const uint DIWRITEFILE__DigitalInput__ = 2;
const uint SIPROPERTYVALUE__AnalogSerialInput__ = 0;
const uint DOFILEOPERATIONSUCCESSFUL__DigitalOutput__ = 0;
const uint SOPROPERTYVALUE__AnalogSerialOutput__ = 0;
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
