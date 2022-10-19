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

namespace UserModule_GROUPED_SERIAL_OS
{
    public class UserModuleClass_GROUPED_SERIAL_OS : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIIN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput DOCHANGED;
        UShortParameter IPPULSELEN;
        private void TRIG (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 56;
            DOCHANGED  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 57;
            CreateWait ( "PULSEWAIT" , IPPULSELEN  .Value , PULSEWAIT_Callback ) ;
            
            }
            
        public void PULSEWAIT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 58;
            DOCHANGED  .Value = (ushort) ( 0 ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object SIIN__DOLLAR___OnChange_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 80;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DOCHANGED  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 81;
                TRIG (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 83;
                CancelWait ( "PULSEWAIT" ) ; 
                __context__.SourceCodeLine = 84;
                TRIG (  __context__  ) ; 
                } 
            
            
            
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
        
        __context__.SourceCodeLine = 96;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DOCHANGED = new Crestron.Logos.SplusObjects.DigitalOutput( DOCHANGED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DOCHANGED__DigitalOutput__, DOCHANGED );
    
    SIIN__DOLLAR__ = new InOutArray<StringInput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        SIIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIIN__DOLLAR____AnalogSerialInput__ + i, SIIN__DOLLAR____AnalogSerialInput__, 255, this );
        m_StringInputList.Add( SIIN__DOLLAR____AnalogSerialInput__ + i, SIIN__DOLLAR__[i+1] );
    }
    
    IPPULSELEN = new UShortParameter( IPPULSELEN__Parameter__, this );
    m_ParameterList.Add( IPPULSELEN__Parameter__, IPPULSELEN );
    
    PULSEWAIT_Callback = new WaitFunction( PULSEWAIT_CallbackFn );
    
    for( uint i = 0; i < 36; i++ )
        SIIN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( SIIN__DOLLAR___OnChange_0, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_GROUPED_SERIAL_OS ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction PULSEWAIT_Callback;


const uint SIIN__DOLLAR____AnalogSerialInput__ = 0;
const uint DOCHANGED__DigitalOutput__ = 0;
const uint IPPULSELEN__Parameter__ = 10;

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
