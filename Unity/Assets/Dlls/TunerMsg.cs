﻿// Classes and structures being serialized

// Generated by ProtocolBuffer

// - a pure c# code generation implementation of protocol buffers

// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT

// This file will be overwritten when CodeGenerator is run.

// To make custom modifications, edit the .proto file and add //:external before the message line

// then write the code and the changes in a separate file.
using System;
using System.Collections.Generic;

namespace TunerMessage
{
    public partial class PBString
    {
        public string StrValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int StrValueFieldID = 1;
    }
    
    public partial class PBBytes
    {
        public byte[] ByteValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int ByteValueFieldID = 1;
    }
    
    public partial class PBInt
    {
        public int IntValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int IntValueFieldID = 1;
    }
    
    public partial class PBUInt
    {
        public uint UintValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int UintValueFieldID = 1;
    }
    
    public partial class PBLong
    {
        public long LongValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int LongValueFieldID = 1;
    }
    
    public partial class PBULong
    {
        public ulong UlongValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int UlongValueFieldID = 1;
    }
    
    public partial class PBFixed32
    {
        public uint IntValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int IntValueFieldID = 1;
    }
    
    public partial class PBFixed64
    {
        public ulong LongValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int LongValueFieldID = 1;
    }
    
    public partial class PBFloat
    {
        public float FloatValue { get; set; }
        
        // ProtocolBuffers wire field id
        public const int FloatValueFieldID = 1;
    }
    
    public partial class PBVector3
    {
        public float X { get; set; }
        
        public float Y { get; set; }
        
        public float Z { get; set; }
        
        // ProtocolBuffers wire field id
        public const int XFieldID = 1;
        public const int YFieldID = 2;
        public const int ZFieldID = 3;
    }
    
    public partial class TMLogin
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        // ProtocolBuffers wire field id
        public const int UsernameFieldID = 1;
        public const int PasswordFieldID = 2;
    }
    
    public partial class TMLoginOut
    {
        public bool Result { get; set; }
        
        public string Nickname { get; set; }
        
        // ProtocolBuffers wire field id
        public const int ResultFieldID = 1;
        public const int NicknameFieldID = 2;
    }
    
}