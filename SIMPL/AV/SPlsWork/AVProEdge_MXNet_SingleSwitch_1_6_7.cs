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

namespace UserModule_AVPROEDGE_MXNET_SINGLESWITCH_1_6_7
{
    public class UserModuleClass_AVPROEDGE_MXNET_SINGLESWITCH_1_6_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.BufferInput RX;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> OUTPUT;
        Crestron.Logos.SplusObjects.StringOutput TX;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUTPUT_STATUS;
        __CMutex__ BUFFER_MUTEX;
        object OUTPUT_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                CrestronString CMD;
                CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
                
                
                __context__.SourceCodeLine = 20;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 21;
                MakeString ( CMD , "SW {0:d}={1:d};", (short)I, (short)OUTPUT[ I ] .UshortValue) ; 
                __context__.SourceCodeLine = 22;
                TX  .UpdateValue ( CMD  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object RX_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString SO;
            CrestronString CMD;
            CrestronString SOUTPUTS;
            SO  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SOUTPUTS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort IINPUT = 0;
            ushort IOUTPUT = 0;
            
            
            __context__.SourceCodeLine = 30;
            BUFFER_MUTEX . WaitForMutex ( ) ; 
            __context__.SourceCodeLine = 31;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( RX ) > 5 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( ";" , RX , 1 ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 33;
                CMD  .UpdateValue ( Functions.Gather ( ";" , RX )  ) ; 
                __context__.SourceCodeLine = 34;
                CMD  .UpdateValue ( Functions.Left ( CMD ,  (int) ( (Functions.Length( CMD ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 36;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( CMD ) > 4 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "SW " , CMD , 1 ) > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 38;
                    SOUTPUTS  .UpdateValue ( Functions.Remove ( "SW " , CMD )  ) ; 
                    __context__.SourceCodeLine = 39;
                    SOUTPUTS  .UpdateValue ( Functions.Remove ( "=" , CMD )  ) ; 
                    __context__.SourceCodeLine = 40;
                    IINPUT = (ushort) ( Functions.Atoi( CMD ) ) ; 
                    __context__.SourceCodeLine = 41;
                    SOUTPUTS  .UpdateValue ( Functions.Left ( SOUTPUTS ,  (int) ( (Functions.Length( SOUTPUTS ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 43;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SOUTPUTS ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "," , SOUTPUTS , 1 ) > 0 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 45;
                        SO  .UpdateValue ( Functions.Remove ( "," , SOUTPUTS , 1)  ) ; 
                        __context__.SourceCodeLine = 46;
                        SO  .UpdateValue ( Functions.Left ( SO ,  (int) ( (Functions.Length( SO ) - 1) ) )  ) ; 
                        __context__.SourceCodeLine = 47;
                        IOUTPUT = (ushort) ( Functions.Atoi( SO ) ) ; 
                        __context__.SourceCodeLine = 48;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OUTPUT_STATUS[ IOUTPUT ] .Value != IINPUT))  ) ) 
                            { 
                            __context__.SourceCodeLine = 50;
                            OUTPUT_STATUS [ IOUTPUT]  .Value = (ushort) ( IINPUT ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 43;
                        } 
                    
                    __context__.SourceCodeLine = 54;
                    SO  .UpdateValue ( SOUTPUTS  ) ; 
                    __context__.SourceCodeLine = 55;
                    IOUTPUT = (ushort) ( Functions.Atoi( SO ) ) ; 
                    __context__.SourceCodeLine = 56;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OUTPUT_STATUS[ IOUTPUT ] .Value != IINPUT))  ) ) 
                        { 
                        __context__.SourceCodeLine = 58;
                        OUTPUT_STATUS [ IOUTPUT]  .Value = (ushort) ( IINPUT ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 31;
                } 
            
            __context__.SourceCodeLine = 62;
            BUFFER_MUTEX . ReleaseMutex ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    OUTPUT = new InOutArray<AnalogInput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        OUTPUT[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUT__AnalogSerialInput__ + i, OUTPUT__AnalogSerialInput__, this );
        m_AnalogInputList.Add( OUTPUT__AnalogSerialInput__ + i, OUTPUT[i+1] );
    }
    
    OUTPUT_STATUS = new InOutArray<AnalogOutput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        OUTPUT_STATUS[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_STATUS__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( OUTPUT_STATUS__AnalogSerialOutput__ + i, OUTPUT_STATUS[i+1] );
    }
    
    TX = new Crestron.Logos.SplusObjects.StringOutput( TX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__AnalogSerialOutput__, TX );
    
    RX = new Crestron.Logos.SplusObjects.BufferInput( RX__AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( RX__AnalogSerialInput__, RX );
    
    
    for( uint i = 0; i < 200; i++ )
        OUTPUT[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( OUTPUT_OnChange_0, false ) );
        
    RX.OnSerialChange.Add( new InputChangeHandlerWrapper( RX_OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    BUFFER_MUTEX  = new __CMutex__();
    
    
}

public UserModuleClass_AVPROEDGE_MXNET_SINGLESWITCH_1_6_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RX__AnalogSerialInput__ = 0;
const uint OUTPUT__AnalogSerialInput__ = 1;
const uint TX__AnalogSerialOutput__ = 0;
const uint OUTPUT_STATUS__AnalogSerialOutput__ = 1;

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
