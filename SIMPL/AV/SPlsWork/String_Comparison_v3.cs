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

namespace UserModule_STRING_COMPARISON_V3
{
    public class UserModuleClass_STRING_COMPARISON_V3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput STRING_TO_COMPARE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LAST_SUCCESSFUL_STRING__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput CHANGED;
        Crestron.Logos.SplusObjects.DigitalOutput NOT_CHANGED;
        CrestronString NEW_STRING__DOLLAR__;
        CrestronString OLD_STRING__DOLLAR__;
        object STRING_TO_COMPARE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 33;
                OLD_STRING__DOLLAR__  .UpdateValue ( LAST_SUCCESSFUL_STRING__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 34;
                NEW_STRING__DOLLAR__  .UpdateValue ( STRING_TO_COMPARE__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 35;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OLD_STRING__DOLLAR__ != NEW_STRING__DOLLAR__))  ) ) 
                    { 
                    __context__.SourceCodeLine = 37;
                    CHANGED  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 38;
                    NOT_CHANGED  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 39;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 40;
                    CHANGED  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 44;
                    CHANGED  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 45;
                    NOT_CHANGED  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 46;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 47;
                    NOT_CHANGED  .Value = (ushort) ( 0 ) ; 
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
            
            __context__.SourceCodeLine = 53;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_11__" , 3000 , __SPLS_TMPVAR__WAITLABEL_11___Callback ) ;
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_11___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 55;
            LAST_SUCCESSFUL_STRING__DOLLAR__  .UpdateValue ( "Processor Rebooted"  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    NEW_STRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    OLD_STRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    CHANGED = new Crestron.Logos.SplusObjects.DigitalOutput( CHANGED__DigitalOutput__, this );
    m_DigitalOutputList.Add( CHANGED__DigitalOutput__, CHANGED );
    
    NOT_CHANGED = new Crestron.Logos.SplusObjects.DigitalOutput( NOT_CHANGED__DigitalOutput__, this );
    m_DigitalOutputList.Add( NOT_CHANGED__DigitalOutput__, NOT_CHANGED );
    
    STRING_TO_COMPARE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( STRING_TO_COMPARE__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( STRING_TO_COMPARE__DOLLAR____AnalogSerialInput__, STRING_TO_COMPARE__DOLLAR__ );
    
    LAST_SUCCESSFUL_STRING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LAST_SUCCESSFUL_STRING__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( LAST_SUCCESSFUL_STRING__DOLLAR____AnalogSerialInput__, LAST_SUCCESSFUL_STRING__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_11___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_11___CallbackFn );
    
    STRING_TO_COMPARE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( STRING_TO_COMPARE__DOLLAR___OnChange_0, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_STRING_COMPARISON_V3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_11___Callback;


const uint STRING_TO_COMPARE__DOLLAR____AnalogSerialInput__ = 0;
const uint LAST_SUCCESSFUL_STRING__DOLLAR____AnalogSerialInput__ = 1;
const uint CHANGED__DigitalOutput__ = 0;
const uint NOT_CHANGED__DigitalOutput__ = 1;

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
