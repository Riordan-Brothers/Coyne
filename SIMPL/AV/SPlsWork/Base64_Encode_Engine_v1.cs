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

namespace UserModule_BASE64_ENCODE_ENGINE_V1
{
    public class UserModuleClass_BASE64_ENCODE_ENGINE_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.BufferInput ASCII_IN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput BASE64_OUT__DOLLAR__;
        ushort [] CB64;
        CrestronString BLOCK_TO_ENCODE;
        CrestronString BLOCK_JUST_ENCODED;
        private CrestronString ENCODEBLOCK (  SplusExecutionContext __context__, CrestronString BLOCK_TO_ENCODE ) 
            { 
            ushort BTE1 = 0;
            ushort BTE2 = 0;
            ushort BTE3 = 0;
            ushort BTE1W = 0;
            ushort BTE2W = 0;
            ushort BTE3W = 0;
            ushort BTE4W = 0;
            ushort BTELEN = 0;
            
            
            __context__.SourceCodeLine = 76;
            BTELEN = (ushort) ( Functions.Length( BLOCK_TO_ENCODE ) ) ; 
            __context__.SourceCodeLine = 77;
            switch ((int)BTELEN)
            
                { 
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 81;
                    BTE1 = (ushort) ( Functions.GetC( BLOCK_TO_ENCODE ) ) ; 
                    __context__.SourceCodeLine = 82;
                    BTE2 = (ushort) ( Functions.GetC( BLOCK_TO_ENCODE ) ) ; 
                    __context__.SourceCodeLine = 83;
                    BTE3 = (ushort) ( Functions.GetC( BLOCK_TO_ENCODE ) ) ; 
                    __context__.SourceCodeLine = 84;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 88;
                    BTE1 = (ushort) ( Functions.GetC( BLOCK_TO_ENCODE ) ) ; 
                    __context__.SourceCodeLine = 89;
                    BTE2 = (ushort) ( Functions.GetC( BLOCK_TO_ENCODE ) ) ; 
                    __context__.SourceCodeLine = 90;
                    BTE3 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 91;
                    break ; 
                    } 
                
                goto case 1 ;
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 95;
                    BTE1 = (ushort) ( Functions.GetC( BLOCK_TO_ENCODE ) ) ; 
                    __context__.SourceCodeLine = 96;
                    BTE2 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 97;
                    BTE3 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 98;
                    break ; 
                    } 
                
                goto case 0 ;
                case 0 : 
                
                    { 
                    __context__.SourceCodeLine = 102;
                    BTE1 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 103;
                    BTE2 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 104;
                    BTE3 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 105;
                    Print( "base64: function encodeblock fed string of zero length\r\n") ; 
                    __context__.SourceCodeLine = 106;
                    break ; 
                    } 
                
                goto default;
                default : 
                
                    { 
                    __context__.SourceCodeLine = 110;
                    Print( "base64: function encodeblock fed string of unexpected length{0:d}\r\n", (short)BTELEN) ; 
                    __context__.SourceCodeLine = 111;
                    break ; 
                    } 
                break;
                
                } 
                
            
            __context__.SourceCodeLine = 115;
            BTE1W = (ushort) ( CB64[ (BTE1 >> 2) ] ) ; 
            __context__.SourceCodeLine = 116;
            BTE2W = (ushort) ( CB64[ (((BTE1 & 3) << 4) | ((BTE2 & 240) >> 4)) ] ) ; 
            __context__.SourceCodeLine = 118;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( BTELEN > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 119;
                BTE3W = (ushort) ( CB64[ (((BTE2 & 15) << 2) | ((BTE3 & 192) >> 6)) ] ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 121;
                BTE3W = (ushort) ( 61 ) ; 
                }
            
            __context__.SourceCodeLine = 123;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( BTELEN > 2 ))  ) ) 
                {
                __context__.SourceCodeLine = 124;
                BTE4W = (ushort) ( CB64[ (BTE3 & 63) ] ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 126;
                BTE4W = (ushort) ( 61 ) ; 
                }
            
            __context__.SourceCodeLine = 128;
            BLOCK_JUST_ENCODED  .UpdateValue ( Functions.Chr (  (int) ( BTE1W ) ) + Functions.Chr (  (int) ( BTE2W ) ) + Functions.Chr (  (int) ( BTE3W ) ) + Functions.Chr (  (int) ( BTE4W ) )  ) ; 
            __context__.SourceCodeLine = 129;
            return ( BLOCK_JUST_ENCODED ) ; 
            
            }
            
        object ASCII_IN__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort AI1 = 0;
                ushort AI2 = 0;
                ushort AI3 = 0;
                
                CrestronString SEND_BLOCK__DOLLAR__;
                CrestronString BASE64_OUT_TEMP__DOLLAR__;
                SEND_BLOCK__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
                BASE64_OUT_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
                
                
                __context__.SourceCodeLine = 136;
                BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 137;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( ASCII_IN__DOLLAR__ ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 139;
                    switch ((int)Functions.Length( ASCII_IN__DOLLAR__ ))
                    
                        { 
                        case 3 : 
                        
                            { 
                            __context__.SourceCodeLine = 143;
                            AI1 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 144;
                            AI2 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 145;
                            AI3 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 146;
                            SEND_BLOCK__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( AI1 ) ) + Functions.Chr (  (int) ( AI2 ) ) + Functions.Chr (  (int) ( AI3 ) )  ) ; 
                            __context__.SourceCodeLine = 147;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__ + ENCODEBLOCK (  __context__ , SEND_BLOCK__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 148;
                            BASE64_OUT__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 149;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 150;
                            break ; 
                            } 
                        
                        goto case 2 ;
                        case 2 : 
                        
                            { 
                            __context__.SourceCodeLine = 154;
                            AI1 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 155;
                            AI2 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 156;
                            SEND_BLOCK__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( AI1 ) ) + Functions.Chr (  (int) ( AI2 ) )  ) ; 
                            __context__.SourceCodeLine = 157;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__ + ENCODEBLOCK (  __context__ , SEND_BLOCK__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 158;
                            BASE64_OUT__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 159;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 160;
                            break ; 
                            } 
                        
                        goto case 1 ;
                        case 1 : 
                        
                            { 
                            __context__.SourceCodeLine = 164;
                            AI1 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 165;
                            SEND_BLOCK__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( AI1 ) )  ) ; 
                            __context__.SourceCodeLine = 166;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__ + ENCODEBLOCK (  __context__ , SEND_BLOCK__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 167;
                            BASE64_OUT__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 168;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 169;
                            break ; 
                            } 
                        
                        goto default;
                        default : 
                        
                            { 
                            __context__.SourceCodeLine = 173;
                            AI1 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 174;
                            AI2 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 175;
                            AI3 = (ushort) ( Functions.GetC( ASCII_IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 176;
                            SEND_BLOCK__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( AI1 ) ) + Functions.Chr (  (int) ( AI2 ) ) + Functions.Chr (  (int) ( AI3 ) )  ) ; 
                            __context__.SourceCodeLine = 177;
                            BASE64_OUT_TEMP__DOLLAR__  .UpdateValue ( BASE64_OUT_TEMP__DOLLAR__ + ENCODEBLOCK (  __context__ , SEND_BLOCK__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 178;
                            break ; 
                            } 
                        break;
                        
                        } 
                        
                    
                    __context__.SourceCodeLine = 137;
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
            
            __context__.SourceCodeLine = 187;
            CB64 [ 0] = (ushort) ( 65 ) ; 
            __context__.SourceCodeLine = 188;
            CB64 [ 1] = (ushort) ( 66 ) ; 
            __context__.SourceCodeLine = 189;
            CB64 [ 2] = (ushort) ( 67 ) ; 
            __context__.SourceCodeLine = 190;
            CB64 [ 3] = (ushort) ( 68 ) ; 
            __context__.SourceCodeLine = 191;
            CB64 [ 4] = (ushort) ( 69 ) ; 
            __context__.SourceCodeLine = 192;
            CB64 [ 5] = (ushort) ( 70 ) ; 
            __context__.SourceCodeLine = 193;
            CB64 [ 6] = (ushort) ( 71 ) ; 
            __context__.SourceCodeLine = 194;
            CB64 [ 7] = (ushort) ( 72 ) ; 
            __context__.SourceCodeLine = 195;
            CB64 [ 8] = (ushort) ( 73 ) ; 
            __context__.SourceCodeLine = 196;
            CB64 [ 9] = (ushort) ( 74 ) ; 
            __context__.SourceCodeLine = 197;
            CB64 [ 10] = (ushort) ( 75 ) ; 
            __context__.SourceCodeLine = 198;
            CB64 [ 11] = (ushort) ( 76 ) ; 
            __context__.SourceCodeLine = 199;
            CB64 [ 12] = (ushort) ( 77 ) ; 
            __context__.SourceCodeLine = 200;
            CB64 [ 13] = (ushort) ( 78 ) ; 
            __context__.SourceCodeLine = 201;
            CB64 [ 14] = (ushort) ( 79 ) ; 
            __context__.SourceCodeLine = 202;
            CB64 [ 15] = (ushort) ( 80 ) ; 
            __context__.SourceCodeLine = 203;
            CB64 [ 16] = (ushort) ( 81 ) ; 
            __context__.SourceCodeLine = 204;
            CB64 [ 17] = (ushort) ( 82 ) ; 
            __context__.SourceCodeLine = 205;
            CB64 [ 18] = (ushort) ( 83 ) ; 
            __context__.SourceCodeLine = 206;
            CB64 [ 19] = (ushort) ( 84 ) ; 
            __context__.SourceCodeLine = 207;
            CB64 [ 20] = (ushort) ( 85 ) ; 
            __context__.SourceCodeLine = 208;
            CB64 [ 21] = (ushort) ( 86 ) ; 
            __context__.SourceCodeLine = 209;
            CB64 [ 22] = (ushort) ( 87 ) ; 
            __context__.SourceCodeLine = 210;
            CB64 [ 23] = (ushort) ( 88 ) ; 
            __context__.SourceCodeLine = 211;
            CB64 [ 24] = (ushort) ( 89 ) ; 
            __context__.SourceCodeLine = 212;
            CB64 [ 25] = (ushort) ( 90 ) ; 
            __context__.SourceCodeLine = 213;
            CB64 [ 26] = (ushort) ( 97 ) ; 
            __context__.SourceCodeLine = 214;
            CB64 [ 27] = (ushort) ( 98 ) ; 
            __context__.SourceCodeLine = 215;
            CB64 [ 28] = (ushort) ( 99 ) ; 
            __context__.SourceCodeLine = 216;
            CB64 [ 29] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 217;
            CB64 [ 30] = (ushort) ( 101 ) ; 
            __context__.SourceCodeLine = 218;
            CB64 [ 31] = (ushort) ( 102 ) ; 
            __context__.SourceCodeLine = 219;
            CB64 [ 32] = (ushort) ( 103 ) ; 
            __context__.SourceCodeLine = 220;
            CB64 [ 33] = (ushort) ( 104 ) ; 
            __context__.SourceCodeLine = 221;
            CB64 [ 34] = (ushort) ( 105 ) ; 
            __context__.SourceCodeLine = 222;
            CB64 [ 35] = (ushort) ( 106 ) ; 
            __context__.SourceCodeLine = 223;
            CB64 [ 36] = (ushort) ( 107 ) ; 
            __context__.SourceCodeLine = 224;
            CB64 [ 37] = (ushort) ( 108 ) ; 
            __context__.SourceCodeLine = 225;
            CB64 [ 38] = (ushort) ( 109 ) ; 
            __context__.SourceCodeLine = 226;
            CB64 [ 39] = (ushort) ( 110 ) ; 
            __context__.SourceCodeLine = 227;
            CB64 [ 40] = (ushort) ( 111 ) ; 
            __context__.SourceCodeLine = 228;
            CB64 [ 41] = (ushort) ( 112 ) ; 
            __context__.SourceCodeLine = 229;
            CB64 [ 42] = (ushort) ( 113 ) ; 
            __context__.SourceCodeLine = 230;
            CB64 [ 43] = (ushort) ( 114 ) ; 
            __context__.SourceCodeLine = 231;
            CB64 [ 44] = (ushort) ( 115 ) ; 
            __context__.SourceCodeLine = 232;
            CB64 [ 45] = (ushort) ( 116 ) ; 
            __context__.SourceCodeLine = 233;
            CB64 [ 46] = (ushort) ( 117 ) ; 
            __context__.SourceCodeLine = 234;
            CB64 [ 47] = (ushort) ( 118 ) ; 
            __context__.SourceCodeLine = 235;
            CB64 [ 48] = (ushort) ( 119 ) ; 
            __context__.SourceCodeLine = 236;
            CB64 [ 49] = (ushort) ( 120 ) ; 
            __context__.SourceCodeLine = 237;
            CB64 [ 50] = (ushort) ( 121 ) ; 
            __context__.SourceCodeLine = 238;
            CB64 [ 51] = (ushort) ( 122 ) ; 
            __context__.SourceCodeLine = 239;
            CB64 [ 52] = (ushort) ( 48 ) ; 
            __context__.SourceCodeLine = 240;
            CB64 [ 53] = (ushort) ( 49 ) ; 
            __context__.SourceCodeLine = 241;
            CB64 [ 54] = (ushort) ( 50 ) ; 
            __context__.SourceCodeLine = 242;
            CB64 [ 55] = (ushort) ( 51 ) ; 
            __context__.SourceCodeLine = 243;
            CB64 [ 56] = (ushort) ( 52 ) ; 
            __context__.SourceCodeLine = 244;
            CB64 [ 57] = (ushort) ( 53 ) ; 
            __context__.SourceCodeLine = 245;
            CB64 [ 58] = (ushort) ( 54 ) ; 
            __context__.SourceCodeLine = 246;
            CB64 [ 59] = (ushort) ( 55 ) ; 
            __context__.SourceCodeLine = 247;
            CB64 [ 60] = (ushort) ( 56 ) ; 
            __context__.SourceCodeLine = 248;
            CB64 [ 61] = (ushort) ( 57 ) ; 
            __context__.SourceCodeLine = 249;
            CB64 [ 62] = (ushort) ( 43 ) ; 
            __context__.SourceCodeLine = 250;
            CB64 [ 63] = (ushort) ( 47 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        CB64  = new ushort[ 65 ];
        BLOCK_TO_ENCODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        BLOCK_JUST_ENCODED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        
        BASE64_OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( BASE64_OUT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( BASE64_OUT__DOLLAR____AnalogSerialOutput__, BASE64_OUT__DOLLAR__ );
        
        ASCII_IN__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( ASCII_IN__DOLLAR____AnalogSerialInput__, 255, this );
        m_StringInputList.Add( ASCII_IN__DOLLAR____AnalogSerialInput__, ASCII_IN__DOLLAR__ );
        
        
        ASCII_IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( ASCII_IN__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_BASE64_ENCODE_ENGINE_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint ASCII_IN__DOLLAR____AnalogSerialInput__ = 0;
    const uint BASE64_OUT__DOLLAR____AnalogSerialOutput__ = 0;
    
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
