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

namespace UserModule_AVPROEDGE_MXNET_IRSEND_1_6_7
{
    public class UserModuleClass_AVPROEDGE_MXNET_IRSEND_1_6_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> IR_TX;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> IR_RX;
        Crestron.Logos.SplusObjects.StringOutput IR;
        object IR_TX_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                CrestronString CMD;
                CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
                
                
                __context__.SourceCodeLine = 13;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 14;
                MakeString ( CMD , "IR_TX {0:d} {1};", (short)I, IR_TX [ I ] ) ; 
                __context__.SourceCodeLine = 15;
                IR  .UpdateValue ( CMD  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object IR_RX_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            CrestronString CMD;
            CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            
            __context__.SourceCodeLine = 22;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 23;
            MakeString ( CMD , "IR_RX {0:d} {1};", (short)I, IR_RX [ I ] ) ; 
            __context__.SourceCodeLine = 24;
            IR  .UpdateValue ( CMD  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    IR_TX = new InOutArray<StringInput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        IR_TX[i+1] = new Crestron.Logos.SplusObjects.StringInput( IR_TX__AnalogSerialInput__ + i, IR_TX__AnalogSerialInput__, 500, this );
        m_StringInputList.Add( IR_TX__AnalogSerialInput__ + i, IR_TX[i+1] );
    }
    
    IR_RX = new InOutArray<StringInput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        IR_RX[i+1] = new Crestron.Logos.SplusObjects.StringInput( IR_RX__AnalogSerialInput__ + i, IR_RX__AnalogSerialInput__, 500, this );
        m_StringInputList.Add( IR_RX__AnalogSerialInput__ + i, IR_RX[i+1] );
    }
    
    IR = new Crestron.Logos.SplusObjects.StringOutput( IR__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IR__AnalogSerialOutput__, IR );
    
    
    for( uint i = 0; i < 200; i++ )
        IR_TX[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( IR_TX_OnChange_0, false ) );
        
    for( uint i = 0; i < 200; i++ )
        IR_RX[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( IR_RX_OnChange_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_AVPROEDGE_MXNET_IRSEND_1_6_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint IR_TX__AnalogSerialInput__ = 0;
const uint IR_RX__AnalogSerialInput__ = 200;
const uint IR__AnalogSerialOutput__ = 0;

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
