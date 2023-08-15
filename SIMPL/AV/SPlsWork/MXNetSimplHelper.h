namespace Janus.Crestron.AVProEdge.Mxnet;
        // class declarations
         class MXNetSerialComms;
         class SerialDataEventArgs;
         class SimplSharpHelper;
     class MXNetSerialComms 
    {
        // class delegates

        // class events
        EventHandler DataToSend ( MXNetSerialComms sender, SerialDataEventArgs e );
        EventHandler onReceiveData ( MXNetSerialComms sender, SerialDataEventArgs e );

        // class functions
        FUNCTION id ();
        FUNCTION DataReceived ( STRING direction , INTEGER id , STRING data , INTEGER rawData[] );
        FUNCTION SendData ( STRING direction , INTEGER id , STRING data );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        MXNetSerialComms Get;
    };

     class SerialDataEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Id;
        STRING Direction[];
        STRING Data[];
        INTEGER RawData[];
        SIGNED_LONG_INTEGER RawDataLen;
    };

     class SimplSharpHelper 
    {
        // class delegates

        // class events
        EventHandler DataToSend ( SimplSharpHelper sender, SerialDataEventArgs e );

        // class functions
        FUNCTION SendData ( STRING direction , INTEGER id , STRING data );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        Janus.Crestron.AVProEdge.Mxnet.MXNetSerialComms SerialComms;

        // class properties
    };

