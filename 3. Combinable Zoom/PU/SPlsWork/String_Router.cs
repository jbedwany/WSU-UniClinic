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

namespace UserModule_STRING_ROUTER
{
    public class UserModuleClass_STRING_ROUTER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput AISELECT;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIINPUT;
        Crestron.Logos.SplusObjects.AnalogOutput AISELECTFB;
        Crestron.Logos.SplusObjects.StringOutput SOOUTPUT;
        object AISELECT_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 54;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( AISELECT  .UshortValue < 12 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 55;
                    SOOUTPUT  .UpdateValue ( SIINPUT [ AISELECT  .UshortValue ]  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 56;
                    SOOUTPUT  .UpdateValue ( ""  ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        AISELECT = new Crestron.Logos.SplusObjects.AnalogInput( AISELECT__AnalogSerialInput__, this );
        m_AnalogInputList.Add( AISELECT__AnalogSerialInput__, AISELECT );
        
        AISELECTFB = new Crestron.Logos.SplusObjects.AnalogOutput( AISELECTFB__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( AISELECTFB__AnalogSerialOutput__, AISELECTFB );
        
        SIINPUT = new InOutArray<StringInput>( 12, this );
        for( uint i = 0; i < 12; i++ )
        {
            SIINPUT[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIINPUT__AnalogSerialInput__ + i, SIINPUT__AnalogSerialInput__, 255, this );
            m_StringInputList.Add( SIINPUT__AnalogSerialInput__ + i, SIINPUT[i+1] );
        }
        
        SOOUTPUT = new Crestron.Logos.SplusObjects.StringOutput( SOOUTPUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( SOOUTPUT__AnalogSerialOutput__, SOOUTPUT );
        
        
        AISELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( AISELECT_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_STRING_ROUTER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint AISELECT__AnalogSerialInput__ = 0;
    const uint SIINPUT__AnalogSerialInput__ = 1;
    const uint AISELECTFB__AnalogSerialOutput__ = 0;
    const uint SOOUTPUT__AnalogSerialOutput__ = 1;
    
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
