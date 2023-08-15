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

namespace UserModule_PAD8_PAGING_REV2
{
    public class UserModuleClass_PAD8_PAGING_REV2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PAGE_TRIG;
        Crestron.Logos.SplusObjects.DigitalInput RM1_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM2_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM3_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM4_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM5_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM6_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM7_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM8_PAGE_ENA;
        Crestron.Logos.SplusObjects.DigitalInput RM1_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM2_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM3_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM4_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM5_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM6_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM7_ON;
        Crestron.Logos.SplusObjects.DigitalInput RM8_ON;
        Crestron.Logos.SplusObjects.AnalogInput PAGE_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM1_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM2_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM3_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM4_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM5_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM6_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM7_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM8_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput RM1_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM2_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM3_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM4_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM5_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM6_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM7_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM8_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM1_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM2_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM3_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM4_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM5_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM6_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM7_PG_VOL;
        Crestron.Logos.SplusObjects.AnalogInput RM8_PG_VOL;
        Crestron.Logos.SplusObjects.DigitalOutput RM1_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM2_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM3_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM4_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM5_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM6_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM7_ON_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput RM8_ON_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM1_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM2_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM3_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM4_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM5_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM6_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM7_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM8_SOURCE_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM1_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM2_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM3_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM4_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM5_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM6_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM7_VOL_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RM8_VOL_OUT;
        ushort I = 0;
        ushort PAGE_ACTIVE = 0;
        ushort [] RM_ON;
        ushort [] RM_SOURCE;
        ushort [] RM_VOL;
        private void REVERT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 62;
            RM1_ON_OUT  .Value = (ushort) ( RM_ON[ 1 ] ) ; 
            __context__.SourceCodeLine = 63;
            RM2_ON_OUT  .Value = (ushort) ( RM_ON[ 2 ] ) ; 
            __context__.SourceCodeLine = 64;
            RM3_ON_OUT  .Value = (ushort) ( RM_ON[ 3 ] ) ; 
            __context__.SourceCodeLine = 65;
            RM4_ON_OUT  .Value = (ushort) ( RM_ON[ 4 ] ) ; 
            __context__.SourceCodeLine = 66;
            RM5_ON_OUT  .Value = (ushort) ( RM_ON[ 5 ] ) ; 
            __context__.SourceCodeLine = 67;
            RM6_ON_OUT  .Value = (ushort) ( RM_ON[ 6 ] ) ; 
            __context__.SourceCodeLine = 68;
            RM7_ON_OUT  .Value = (ushort) ( RM_ON[ 7 ] ) ; 
            __context__.SourceCodeLine = 69;
            RM8_ON_OUT  .Value = (ushort) ( RM_ON[ 8 ] ) ; 
            __context__.SourceCodeLine = 71;
            RM1_VOL_OUT  .Value = (ushort) ( RM_VOL[ 1 ] ) ; 
            __context__.SourceCodeLine = 72;
            RM2_VOL_OUT  .Value = (ushort) ( RM_VOL[ 2 ] ) ; 
            __context__.SourceCodeLine = 73;
            RM3_VOL_OUT  .Value = (ushort) ( RM_VOL[ 3 ] ) ; 
            __context__.SourceCodeLine = 74;
            RM4_VOL_OUT  .Value = (ushort) ( RM_VOL[ 4 ] ) ; 
            __context__.SourceCodeLine = 75;
            RM5_VOL_OUT  .Value = (ushort) ( RM_VOL[ 5 ] ) ; 
            __context__.SourceCodeLine = 76;
            RM6_VOL_OUT  .Value = (ushort) ( RM_VOL[ 6 ] ) ; 
            __context__.SourceCodeLine = 77;
            RM7_VOL_OUT  .Value = (ushort) ( RM_VOL[ 7 ] ) ; 
            __context__.SourceCodeLine = 78;
            RM8_VOL_OUT  .Value = (ushort) ( RM_VOL[ 8 ] ) ; 
            __context__.SourceCodeLine = 80;
            RM1_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 1 ] ) ; 
            __context__.SourceCodeLine = 81;
            RM2_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 2 ] ) ; 
            __context__.SourceCodeLine = 82;
            RM3_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 3 ] ) ; 
            __context__.SourceCodeLine = 83;
            RM4_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 4 ] ) ; 
            __context__.SourceCodeLine = 84;
            RM5_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 5 ] ) ; 
            __context__.SourceCodeLine = 85;
            RM6_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 6 ] ) ; 
            __context__.SourceCodeLine = 86;
            RM7_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 7 ] ) ; 
            __context__.SourceCodeLine = 87;
            RM8_SOURCE_OUT  .Value = (ushort) ( RM_SOURCE[ 8 ] ) ; 
            
            }
            
        object PAGE_TRIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 92;
                CancelAllWait ( ) ; 
                __context__.SourceCodeLine = 94;
                PAGE_ACTIVE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 96;
                if ( Functions.TestForTrue  ( ( RM1_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 98;
                    RM1_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 99;
                    RM1_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 100;
                    RM1_VOL_OUT  .Value = (ushort) ( RM1_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 102;
                if ( Functions.TestForTrue  ( ( RM2_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 104;
                    RM2_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 105;
                    RM2_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 106;
                    RM2_VOL_OUT  .Value = (ushort) ( RM2_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( RM3_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    RM3_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 111;
                    RM3_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 112;
                    RM3_VOL_OUT  .Value = (ushort) ( RM3_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 114;
                if ( Functions.TestForTrue  ( ( RM4_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 116;
                    RM4_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 117;
                    RM4_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 118;
                    RM4_VOL_OUT  .Value = (ushort) ( RM4_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 120;
                if ( Functions.TestForTrue  ( ( RM5_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 122;
                    RM5_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 123;
                    RM5_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 124;
                    RM5_VOL_OUT  .Value = (ushort) ( RM5_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 126;
                if ( Functions.TestForTrue  ( ( RM6_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 128;
                    RM6_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 129;
                    RM6_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 130;
                    RM6_VOL_OUT  .Value = (ushort) ( RM6_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( RM7_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 134;
                    RM7_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 135;
                    RM7_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 136;
                    RM7_VOL_OUT  .Value = (ushort) ( RM7_PG_VOL  .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( RM8_PAGE_ENA  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 140;
                    RM8_ON_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 141;
                    RM8_SOURCE_OUT  .Value = (ushort) ( PAGE_SOURCE  .UshortValue ) ; 
                    __context__.SourceCodeLine = 142;
                    RM8_VOL_OUT  .Value = (ushort) ( RM8_PG_VOL  .UshortValue ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PAGE_TRIG_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 148;
            REVERT (  __context__  ) ; 
            __context__.SourceCodeLine = 149;
            PAGE_ACTIVE = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object RM1_SOURCE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 155;
        RM_SOURCE [ 1] = (ushort) ( RM1_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 156;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 157;
            RM1_SOURCE_OUT  .Value = (ushort) ( RM1_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM2_SOURCE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        RM_SOURCE [ 2] = (ushort) ( RM2_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 163;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 164;
            RM2_SOURCE_OUT  .Value = (ushort) ( RM2_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM3_SOURCE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 169;
        RM_SOURCE [ 3] = (ushort) ( RM3_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 170;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 171;
            RM3_SOURCE_OUT  .Value = (ushort) ( RM3_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM4_SOURCE_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 176;
        RM_SOURCE [ 4] = (ushort) ( RM4_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 177;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 178;
            RM4_SOURCE_OUT  .Value = (ushort) ( RM4_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM5_SOURCE_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        RM_SOURCE [ 5] = (ushort) ( RM5_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 184;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 185;
            RM5_SOURCE_OUT  .Value = (ushort) ( RM5_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM6_SOURCE_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 190;
        RM_SOURCE [ 6] = (ushort) ( RM6_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 191;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 192;
            RM6_SOURCE_OUT  .Value = (ushort) ( RM6_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM7_SOURCE_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 197;
        RM_SOURCE [ 7] = (ushort) ( RM7_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 198;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 199;
            RM7_SOURCE_OUT  .Value = (ushort) ( RM7_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM8_SOURCE_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 204;
        RM_SOURCE [ 8] = (ushort) ( RM8_SOURCE  .UshortValue ) ; 
        __context__.SourceCodeLine = 205;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 206;
            RM8_SOURCE_OUT  .Value = (ushort) ( RM8_SOURCE  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM1_VOL_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 211;
        RM_VOL [ 1] = (ushort) ( RM1_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 212;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 213;
            RM1_VOL_OUT  .Value = (ushort) ( RM1_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM2_VOL_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 218;
        RM_VOL [ 2] = (ushort) ( RM2_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 219;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 220;
            RM2_VOL_OUT  .Value = (ushort) ( RM2_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM3_VOL_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 225;
        RM_VOL [ 3] = (ushort) ( RM3_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 226;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 227;
            RM3_VOL_OUT  .Value = (ushort) ( RM3_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM4_VOL_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 232;
        RM_VOL [ 4] = (ushort) ( RM4_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 233;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 234;
            RM4_VOL_OUT  .Value = (ushort) ( RM4_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM5_VOL_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 239;
        RM_VOL [ 5] = (ushort) ( RM5_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 240;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 241;
            RM5_VOL_OUT  .Value = (ushort) ( RM5_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM6_VOL_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 246;
        RM_VOL [ 6] = (ushort) ( RM6_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 247;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 248;
            RM6_VOL_OUT  .Value = (ushort) ( RM6_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM7_VOL_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 253;
        RM_VOL [ 7] = (ushort) ( RM7_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 254;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 255;
            RM7_VOL_OUT  .Value = (ushort) ( RM7_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM8_VOL_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 260;
        RM_VOL [ 8] = (ushort) ( RM8_VOL  .UshortValue ) ; 
        __context__.SourceCodeLine = 261;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 262;
            RM8_VOL_OUT  .Value = (ushort) ( RM8_VOL  .UshortValue ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM1_ON_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 267;
        RM_ON [ 1] = (ushort) ( RM1_ON  .Value ) ; 
        __context__.SourceCodeLine = 268;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 269;
            RM1_ON_OUT  .Value = (ushort) ( RM1_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM2_ON_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 274;
        RM_ON [ 2] = (ushort) ( RM2_ON  .Value ) ; 
        __context__.SourceCodeLine = 275;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 276;
            RM2_ON_OUT  .Value = (ushort) ( RM2_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM3_ON_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 281;
        RM_ON [ 3] = (ushort) ( RM3_ON  .Value ) ; 
        __context__.SourceCodeLine = 282;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 283;
            RM3_ON_OUT  .Value = (ushort) ( RM3_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM4_ON_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 288;
        RM_ON [ 4] = (ushort) ( RM4_ON  .Value ) ; 
        __context__.SourceCodeLine = 289;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 290;
            RM4_ON_OUT  .Value = (ushort) ( RM4_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM5_ON_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 295;
        RM_ON [ 5] = (ushort) ( RM5_ON  .Value ) ; 
        __context__.SourceCodeLine = 296;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 297;
            RM5_ON_OUT  .Value = (ushort) ( RM5_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM6_ON_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 302;
        RM_ON [ 6] = (ushort) ( RM6_ON  .Value ) ; 
        __context__.SourceCodeLine = 303;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 304;
            RM6_ON_OUT  .Value = (ushort) ( RM6_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM7_ON_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 309;
        RM_ON [ 7] = (ushort) ( RM7_ON  .Value ) ; 
        __context__.SourceCodeLine = 310;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 311;
            RM7_ON_OUT  .Value = (ushort) ( RM7_ON  .Value ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RM8_ON_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 316;
        RM_ON [ 8] = (ushort) ( RM8_ON  .Value ) ; 
        __context__.SourceCodeLine = 317;
        if ( Functions.TestForTrue  ( ( Functions.Not( PAGE_ACTIVE ))  ) ) 
            {
            __context__.SourceCodeLine = 318;
            RM8_ON_OUT  .Value = (ushort) ( RM8_ON  .Value ) ; 
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
        
        __context__.SourceCodeLine = 324;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)8; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 326;
            RM_SOURCE [ I] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 327;
            RM_VOL [ I] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 328;
            RM_ON [ I] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 324;
            } 
        
        __context__.SourceCodeLine = 331;
        PAGE_ACTIVE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    RM_ON  = new ushort[ 9 ];
    RM_SOURCE  = new ushort[ 9 ];
    RM_VOL  = new ushort[ 9 ];
    
    PAGE_TRIG = new Crestron.Logos.SplusObjects.DigitalInput( PAGE_TRIG__DigitalInput__, this );
    m_DigitalInputList.Add( PAGE_TRIG__DigitalInput__, PAGE_TRIG );
    
    RM1_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM1_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM1_PAGE_ENA__DigitalInput__, RM1_PAGE_ENA );
    
    RM2_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM2_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM2_PAGE_ENA__DigitalInput__, RM2_PAGE_ENA );
    
    RM3_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM3_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM3_PAGE_ENA__DigitalInput__, RM3_PAGE_ENA );
    
    RM4_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM4_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM4_PAGE_ENA__DigitalInput__, RM4_PAGE_ENA );
    
    RM5_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM5_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM5_PAGE_ENA__DigitalInput__, RM5_PAGE_ENA );
    
    RM6_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM6_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM6_PAGE_ENA__DigitalInput__, RM6_PAGE_ENA );
    
    RM7_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM7_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM7_PAGE_ENA__DigitalInput__, RM7_PAGE_ENA );
    
    RM8_PAGE_ENA = new Crestron.Logos.SplusObjects.DigitalInput( RM8_PAGE_ENA__DigitalInput__, this );
    m_DigitalInputList.Add( RM8_PAGE_ENA__DigitalInput__, RM8_PAGE_ENA );
    
    RM1_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM1_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM1_ON__DigitalInput__, RM1_ON );
    
    RM2_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM2_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM2_ON__DigitalInput__, RM2_ON );
    
    RM3_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM3_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM3_ON__DigitalInput__, RM3_ON );
    
    RM4_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM4_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM4_ON__DigitalInput__, RM4_ON );
    
    RM5_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM5_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM5_ON__DigitalInput__, RM5_ON );
    
    RM6_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM6_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM6_ON__DigitalInput__, RM6_ON );
    
    RM7_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM7_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM7_ON__DigitalInput__, RM7_ON );
    
    RM8_ON = new Crestron.Logos.SplusObjects.DigitalInput( RM8_ON__DigitalInput__, this );
    m_DigitalInputList.Add( RM8_ON__DigitalInput__, RM8_ON );
    
    RM1_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM1_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM1_ON_OUT__DigitalOutput__, RM1_ON_OUT );
    
    RM2_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM2_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM2_ON_OUT__DigitalOutput__, RM2_ON_OUT );
    
    RM3_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM3_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM3_ON_OUT__DigitalOutput__, RM3_ON_OUT );
    
    RM4_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM4_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM4_ON_OUT__DigitalOutput__, RM4_ON_OUT );
    
    RM5_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM5_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM5_ON_OUT__DigitalOutput__, RM5_ON_OUT );
    
    RM6_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM6_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM6_ON_OUT__DigitalOutput__, RM6_ON_OUT );
    
    RM7_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM7_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM7_ON_OUT__DigitalOutput__, RM7_ON_OUT );
    
    RM8_ON_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( RM8_ON_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( RM8_ON_OUT__DigitalOutput__, RM8_ON_OUT );
    
    PAGE_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( PAGE_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PAGE_SOURCE__AnalogSerialInput__, PAGE_SOURCE );
    
    RM1_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM1_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM1_SOURCE__AnalogSerialInput__, RM1_SOURCE );
    
    RM2_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM2_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM2_SOURCE__AnalogSerialInput__, RM2_SOURCE );
    
    RM3_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM3_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM3_SOURCE__AnalogSerialInput__, RM3_SOURCE );
    
    RM4_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM4_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM4_SOURCE__AnalogSerialInput__, RM4_SOURCE );
    
    RM5_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM5_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM5_SOURCE__AnalogSerialInput__, RM5_SOURCE );
    
    RM6_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM6_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM6_SOURCE__AnalogSerialInput__, RM6_SOURCE );
    
    RM7_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM7_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM7_SOURCE__AnalogSerialInput__, RM7_SOURCE );
    
    RM8_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( RM8_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM8_SOURCE__AnalogSerialInput__, RM8_SOURCE );
    
    RM1_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM1_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM1_VOL__AnalogSerialInput__, RM1_VOL );
    
    RM2_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM2_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM2_VOL__AnalogSerialInput__, RM2_VOL );
    
    RM3_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM3_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM3_VOL__AnalogSerialInput__, RM3_VOL );
    
    RM4_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM4_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM4_VOL__AnalogSerialInput__, RM4_VOL );
    
    RM5_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM5_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM5_VOL__AnalogSerialInput__, RM5_VOL );
    
    RM6_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM6_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM6_VOL__AnalogSerialInput__, RM6_VOL );
    
    RM7_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM7_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM7_VOL__AnalogSerialInput__, RM7_VOL );
    
    RM8_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM8_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM8_VOL__AnalogSerialInput__, RM8_VOL );
    
    RM1_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM1_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM1_PG_VOL__AnalogSerialInput__, RM1_PG_VOL );
    
    RM2_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM2_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM2_PG_VOL__AnalogSerialInput__, RM2_PG_VOL );
    
    RM3_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM3_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM3_PG_VOL__AnalogSerialInput__, RM3_PG_VOL );
    
    RM4_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM4_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM4_PG_VOL__AnalogSerialInput__, RM4_PG_VOL );
    
    RM5_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM5_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM5_PG_VOL__AnalogSerialInput__, RM5_PG_VOL );
    
    RM6_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM6_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM6_PG_VOL__AnalogSerialInput__, RM6_PG_VOL );
    
    RM7_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM7_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM7_PG_VOL__AnalogSerialInput__, RM7_PG_VOL );
    
    RM8_PG_VOL = new Crestron.Logos.SplusObjects.AnalogInput( RM8_PG_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RM8_PG_VOL__AnalogSerialInput__, RM8_PG_VOL );
    
    RM1_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM1_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM1_SOURCE_OUT__AnalogSerialOutput__, RM1_SOURCE_OUT );
    
    RM2_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM2_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM2_SOURCE_OUT__AnalogSerialOutput__, RM2_SOURCE_OUT );
    
    RM3_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM3_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM3_SOURCE_OUT__AnalogSerialOutput__, RM3_SOURCE_OUT );
    
    RM4_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM4_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM4_SOURCE_OUT__AnalogSerialOutput__, RM4_SOURCE_OUT );
    
    RM5_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM5_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM5_SOURCE_OUT__AnalogSerialOutput__, RM5_SOURCE_OUT );
    
    RM6_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM6_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM6_SOURCE_OUT__AnalogSerialOutput__, RM6_SOURCE_OUT );
    
    RM7_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM7_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM7_SOURCE_OUT__AnalogSerialOutput__, RM7_SOURCE_OUT );
    
    RM8_SOURCE_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM8_SOURCE_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM8_SOURCE_OUT__AnalogSerialOutput__, RM8_SOURCE_OUT );
    
    RM1_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM1_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM1_VOL_OUT__AnalogSerialOutput__, RM1_VOL_OUT );
    
    RM2_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM2_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM2_VOL_OUT__AnalogSerialOutput__, RM2_VOL_OUT );
    
    RM3_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM3_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM3_VOL_OUT__AnalogSerialOutput__, RM3_VOL_OUT );
    
    RM4_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM4_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM4_VOL_OUT__AnalogSerialOutput__, RM4_VOL_OUT );
    
    RM5_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM5_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM5_VOL_OUT__AnalogSerialOutput__, RM5_VOL_OUT );
    
    RM6_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM6_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM6_VOL_OUT__AnalogSerialOutput__, RM6_VOL_OUT );
    
    RM7_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM7_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM7_VOL_OUT__AnalogSerialOutput__, RM7_VOL_OUT );
    
    RM8_VOL_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RM8_VOL_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RM8_VOL_OUT__AnalogSerialOutput__, RM8_VOL_OUT );
    
    
    PAGE_TRIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGE_TRIG_OnPush_0, false ) );
    PAGE_TRIG.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAGE_TRIG_OnRelease_1, false ) );
    RM1_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM1_SOURCE_OnChange_2, false ) );
    RM2_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM2_SOURCE_OnChange_3, false ) );
    RM3_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM3_SOURCE_OnChange_4, false ) );
    RM4_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM4_SOURCE_OnChange_5, false ) );
    RM5_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM5_SOURCE_OnChange_6, false ) );
    RM6_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM6_SOURCE_OnChange_7, false ) );
    RM7_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM7_SOURCE_OnChange_8, false ) );
    RM8_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM8_SOURCE_OnChange_9, false ) );
    RM1_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM1_VOL_OnChange_10, false ) );
    RM2_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM2_VOL_OnChange_11, false ) );
    RM3_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM3_VOL_OnChange_12, false ) );
    RM4_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM4_VOL_OnChange_13, false ) );
    RM5_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM5_VOL_OnChange_14, false ) );
    RM6_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM6_VOL_OnChange_15, false ) );
    RM7_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM7_VOL_OnChange_16, false ) );
    RM8_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( RM8_VOL_OnChange_17, false ) );
    RM1_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM1_ON_OnChange_18, false ) );
    RM2_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM2_ON_OnChange_19, false ) );
    RM3_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM3_ON_OnChange_20, false ) );
    RM4_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM4_ON_OnChange_21, false ) );
    RM5_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM5_ON_OnChange_22, false ) );
    RM6_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM6_ON_OnChange_23, false ) );
    RM7_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM7_ON_OnChange_24, false ) );
    RM8_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( RM8_ON_OnChange_25, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PAD8_PAGING_REV2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PAGE_TRIG__DigitalInput__ = 0;
const uint RM1_PAGE_ENA__DigitalInput__ = 1;
const uint RM2_PAGE_ENA__DigitalInput__ = 2;
const uint RM3_PAGE_ENA__DigitalInput__ = 3;
const uint RM4_PAGE_ENA__DigitalInput__ = 4;
const uint RM5_PAGE_ENA__DigitalInput__ = 5;
const uint RM6_PAGE_ENA__DigitalInput__ = 6;
const uint RM7_PAGE_ENA__DigitalInput__ = 7;
const uint RM8_PAGE_ENA__DigitalInput__ = 8;
const uint RM1_ON__DigitalInput__ = 9;
const uint RM2_ON__DigitalInput__ = 10;
const uint RM3_ON__DigitalInput__ = 11;
const uint RM4_ON__DigitalInput__ = 12;
const uint RM5_ON__DigitalInput__ = 13;
const uint RM6_ON__DigitalInput__ = 14;
const uint RM7_ON__DigitalInput__ = 15;
const uint RM8_ON__DigitalInput__ = 16;
const uint PAGE_SOURCE__AnalogSerialInput__ = 0;
const uint RM1_SOURCE__AnalogSerialInput__ = 1;
const uint RM2_SOURCE__AnalogSerialInput__ = 2;
const uint RM3_SOURCE__AnalogSerialInput__ = 3;
const uint RM4_SOURCE__AnalogSerialInput__ = 4;
const uint RM5_SOURCE__AnalogSerialInput__ = 5;
const uint RM6_SOURCE__AnalogSerialInput__ = 6;
const uint RM7_SOURCE__AnalogSerialInput__ = 7;
const uint RM8_SOURCE__AnalogSerialInput__ = 8;
const uint RM1_VOL__AnalogSerialInput__ = 9;
const uint RM2_VOL__AnalogSerialInput__ = 10;
const uint RM3_VOL__AnalogSerialInput__ = 11;
const uint RM4_VOL__AnalogSerialInput__ = 12;
const uint RM5_VOL__AnalogSerialInput__ = 13;
const uint RM6_VOL__AnalogSerialInput__ = 14;
const uint RM7_VOL__AnalogSerialInput__ = 15;
const uint RM8_VOL__AnalogSerialInput__ = 16;
const uint RM1_PG_VOL__AnalogSerialInput__ = 17;
const uint RM2_PG_VOL__AnalogSerialInput__ = 18;
const uint RM3_PG_VOL__AnalogSerialInput__ = 19;
const uint RM4_PG_VOL__AnalogSerialInput__ = 20;
const uint RM5_PG_VOL__AnalogSerialInput__ = 21;
const uint RM6_PG_VOL__AnalogSerialInput__ = 22;
const uint RM7_PG_VOL__AnalogSerialInput__ = 23;
const uint RM8_PG_VOL__AnalogSerialInput__ = 24;
const uint RM1_ON_OUT__DigitalOutput__ = 0;
const uint RM2_ON_OUT__DigitalOutput__ = 1;
const uint RM3_ON_OUT__DigitalOutput__ = 2;
const uint RM4_ON_OUT__DigitalOutput__ = 3;
const uint RM5_ON_OUT__DigitalOutput__ = 4;
const uint RM6_ON_OUT__DigitalOutput__ = 5;
const uint RM7_ON_OUT__DigitalOutput__ = 6;
const uint RM8_ON_OUT__DigitalOutput__ = 7;
const uint RM1_SOURCE_OUT__AnalogSerialOutput__ = 0;
const uint RM2_SOURCE_OUT__AnalogSerialOutput__ = 1;
const uint RM3_SOURCE_OUT__AnalogSerialOutput__ = 2;
const uint RM4_SOURCE_OUT__AnalogSerialOutput__ = 3;
const uint RM5_SOURCE_OUT__AnalogSerialOutput__ = 4;
const uint RM6_SOURCE_OUT__AnalogSerialOutput__ = 5;
const uint RM7_SOURCE_OUT__AnalogSerialOutput__ = 6;
const uint RM8_SOURCE_OUT__AnalogSerialOutput__ = 7;
const uint RM1_VOL_OUT__AnalogSerialOutput__ = 8;
const uint RM2_VOL_OUT__AnalogSerialOutput__ = 9;
const uint RM3_VOL_OUT__AnalogSerialOutput__ = 10;
const uint RM4_VOL_OUT__AnalogSerialOutput__ = 11;
const uint RM5_VOL_OUT__AnalogSerialOutput__ = 12;
const uint RM6_VOL_OUT__AnalogSerialOutput__ = 13;
const uint RM7_VOL_OUT__AnalogSerialOutput__ = 14;
const uint RM8_VOL_OUT__AnalogSerialOutput__ = 15;

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
