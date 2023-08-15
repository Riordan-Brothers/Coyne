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

namespace UserModule_CHANGEIP_ADDRESS_EXTRACTOR_V2
{
    public class UserModuleClass_CHANGEIP_ADDRESS_EXTRACTOR_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.BufferInput CHANGEIP_INPUT_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IP_ADDRESS__DOLLAR__;
        object CHANGEIP_INPUT_RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 44;
                if ( Functions.TestForTrue  ( ( Functions.Not( _SplusNVRAM.GI_BUSY ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 46;
                    _SplusNVRAM.GI_BUSY = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 47;
                    _SplusNVRAM.GS_CHANGEIP_TEMP__DOLLAR__  .UpdateValue ( Functions.Gather ( "-->" , CHANGEIP_INPUT_RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 49;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPADDR=" , _SplusNVRAM.GS_CHANGEIP_TEMP__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 51;
                        _SplusNVRAM.JUNK__DOLLAR__  .UpdateValue ( Functions.Remove ( "IPADDR=" , _SplusNVRAM.GS_CHANGEIP_TEMP__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 52;
                        _SplusNVRAM.GS_IPADDRESS__DOLLAR__  .UpdateValue ( Functions.Left ( _SplusNVRAM.GS_CHANGEIP_TEMP__DOLLAR__ ,  (int) ( (Functions.Length( _SplusNVRAM.GS_CHANGEIP_TEMP__DOLLAR__ ) - 3) ) )  ) ; 
                        __context__.SourceCodeLine = 54;
                        IP_ADDRESS__DOLLAR__  .UpdateValue ( _SplusNVRAM.GS_IPADDRESS__DOLLAR__  ) ; 
                        __context__.SourceCodeLine = 55;
                        Functions.ClearBuffer ( CHANGEIP_INPUT_RX__DOLLAR__ ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 57;
                    _SplusNVRAM.GI_BUSY = (ushort) ( 0 ) ; 
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
            
            __context__.SourceCodeLine = 63;
            Functions.ClearBuffer ( CHANGEIP_INPUT_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 64;
            if ( Functions.TestForTrue  ( ( Functions.Length( _SplusNVRAM.GS_IPADDRESS__DOLLAR__ ))  ) ) 
                {
                __context__.SourceCodeLine = 65;
                IP_ADDRESS__DOLLAR__  .UpdateValue ( _SplusNVRAM.GS_IPADDRESS__DOLLAR__  ) ; 
                }
            
            __context__.SourceCodeLine = 66;
            _SplusNVRAM.GI_BUSY = (ushort) ( 0 ) ; 
            
            
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
        _SplusNVRAM.GS_CHANGEIP_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
        _SplusNVRAM.GS_IPADDRESS__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        _SplusNVRAM.JUNK__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
        
        IP_ADDRESS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IP_ADDRESS__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( IP_ADDRESS__DOLLAR____AnalogSerialOutput__, IP_ADDRESS__DOLLAR__ );
        
        CHANGEIP_INPUT_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CHANGEIP_INPUT_RX__DOLLAR____AnalogSerialInput__, 2000, this );
        m_StringInputList.Add( CHANGEIP_INPUT_RX__DOLLAR____AnalogSerialInput__, CHANGEIP_INPUT_RX__DOLLAR__ );
        
        
        CHANGEIP_INPUT_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CHANGEIP_INPUT_RX__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_CHANGEIP_ADDRESS_EXTRACTOR_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint CHANGEIP_INPUT_RX__DOLLAR____AnalogSerialInput__ = 0;
    const uint IP_ADDRESS__DOLLAR____AnalogSerialOutput__ = 0;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        [SplusStructAttribute(0, false, true)]
            public ushort GI_BUSY = 0;
            [SplusStructAttribute(1, false, true)]
            public CrestronString GS_CHANGEIP_TEMP__DOLLAR__;
            [SplusStructAttribute(2, false, true)]
            public CrestronString GS_IPADDRESS__DOLLAR__;
            [SplusStructAttribute(3, false, true)]
            public CrestronString JUNK__DOLLAR__;
            
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
