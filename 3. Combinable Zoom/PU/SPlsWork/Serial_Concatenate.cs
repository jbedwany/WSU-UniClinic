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

namespace UserModule_SERIAL_CONCATENATE
{
    public class UserModuleClass_SERIAL_CONCATENATE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIINPUTSTRING;
        Crestron.Logos.SplusObjects.StringOutput SOOUTPUT;
        object SIINPUTSTRING_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 105;
                SOOUTPUT  .UpdateValue ( SIINPUTSTRING [ 0 ] + SIINPUTSTRING [ 1 ] + SIINPUTSTRING [ 2 ] + SIINPUTSTRING [ 3 ] + SIINPUTSTRING [ 4 ] + SIINPUTSTRING [ 5 ] + SIINPUTSTRING [ 6 ] + SIINPUTSTRING [ 7 ]  ) ; 
                
                
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
            
            __context__.SourceCodeLine = 152;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SIINPUTSTRING = new InOutArray<StringInput>( 8, this );
        for( uint i = 0; i < 8; i++ )
        {
            SIINPUTSTRING[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIINPUTSTRING__AnalogSerialInput__ + i, SIINPUTSTRING__AnalogSerialInput__, 128, this );
            m_StringInputList.Add( SIINPUTSTRING__AnalogSerialInput__ + i, SIINPUTSTRING[i+1] );
        }
        
        SOOUTPUT = new Crestron.Logos.SplusObjects.StringOutput( SOOUTPUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( SOOUTPUT__AnalogSerialOutput__, SOOUTPUT );
        
        
        for( uint i = 0; i < 8; i++ )
            SIINPUTSTRING[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( SIINPUTSTRING_OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SERIAL_CONCATENATE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SIINPUTSTRING__AnalogSerialInput__ = 0;
    const uint SOOUTPUT__AnalogSerialOutput__ = 0;
    
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
