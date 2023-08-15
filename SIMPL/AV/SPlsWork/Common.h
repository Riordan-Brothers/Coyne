namespace Janus.Crestron.AVProEdge.Mxnet;
        // class declarations
         class UserAttributesEventArgs;
         class GenericTransport;
     class UserAttributesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING attributeId[];
        STRING stringAttributeValue[];
        INTEGER intAttributeValue;
    };

     class GenericTransport 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DriverID;
        LONG_INTEGER TimeOut;
    };

