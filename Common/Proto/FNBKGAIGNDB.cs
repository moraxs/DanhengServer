// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FNBKGAIGNDB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FNBKGAIGNDB.proto</summary>
  public static partial class FNBKGAIGNDBReflection {

    #region Descriptor
    /// <summary>File descriptor for FNBKGAIGNDB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FNBKGAIGNDBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGTkJLR0FJR05EQi5wcm90bxoRTFBQQ0VGQ0dKSU8ucHJvdG8aEUNMTUxE",
            "TERHSEJFLnByb3RvGhFIR0RGUEJMS0xEQy5wcm90bxoRUEZOSE9IT09FTkQu",
            "cHJvdG8aEUFEUE1HSEFJSlBCLnByb3RvIsoBCgtGTkJLR0FJR05EQhIlCg9y",
            "b2d1ZV9idWZmX2luZm8YDyABKAsyDC5DTE1MRExER0hCRRInChFnYW1lX21p",
            "cmFjbGVfaW5mbxgHIAEoCzIMLlBGTkhPSE9PRU5EEiEKC0dBTkhNQUVJRklC",
            "GAQgASgLMgwuTFBQQ0VGQ0dKSU8SJQoPcm9ndWVfYWVvbl9pbmZvGAggASgL",
            "MgwuQURQTUdIQUlKUEISIQoLUENPSU5HQU1PTUwYCSABKAsyDC5IR0RGUEJM",
            "S0xEQ0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LPPCEFCGJIOReflection.Descriptor, global::EggLink.DanhengServer.Proto.CLMLDLDGHBEReflection.Descriptor, global::EggLink.DanhengServer.Proto.HGDFPBLKLDCReflection.Descriptor, global::EggLink.DanhengServer.Proto.PFNHOHOOENDReflection.Descriptor, global::EggLink.DanhengServer.Proto.ADPMGHAIJPBReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FNBKGAIGNDB), global::EggLink.DanhengServer.Proto.FNBKGAIGNDB.Parser, new[]{ "RogueBuffInfo", "GameMiracleInfo", "GANHMAEIFIB", "RogueAeonInfo", "PCOINGAMOML" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FNBKGAIGNDB : pb::IMessage<FNBKGAIGNDB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FNBKGAIGNDB> _parser = new pb::MessageParser<FNBKGAIGNDB>(() => new FNBKGAIGNDB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FNBKGAIGNDB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FNBKGAIGNDBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FNBKGAIGNDB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FNBKGAIGNDB(FNBKGAIGNDB other) : this() {
      rogueBuffInfo_ = other.rogueBuffInfo_ != null ? other.rogueBuffInfo_.Clone() : null;
      gameMiracleInfo_ = other.gameMiracleInfo_ != null ? other.gameMiracleInfo_.Clone() : null;
      gANHMAEIFIB_ = other.gANHMAEIFIB_ != null ? other.gANHMAEIFIB_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      pCOINGAMOML_ = other.pCOINGAMOML_ != null ? other.pCOINGAMOML_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FNBKGAIGNDB Clone() {
      return new FNBKGAIGNDB(this);
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.CLMLDLDGHBE rogueBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CLMLDLDGHBE RogueBuffInfo {
      get { return rogueBuffInfo_; }
      set {
        rogueBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.PFNHOHOOEND gameMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PFNHOHOOEND GameMiracleInfo {
      get { return gameMiracleInfo_; }
      set {
        gameMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "GANHMAEIFIB" field.</summary>
    public const int GANHMAEIFIBFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.LPPCEFCGJIO gANHMAEIFIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LPPCEFCGJIO GANHMAEIFIB {
      get { return gANHMAEIFIB_; }
      set {
        gANHMAEIFIB_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ADPMGHAIJPB rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ADPMGHAIJPB RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "PCOINGAMOML" field.</summary>
    public const int PCOINGAMOMLFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.HGDFPBLKLDC pCOINGAMOML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HGDFPBLKLDC PCOINGAMOML {
      get { return pCOINGAMOML_; }
      set {
        pCOINGAMOML_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FNBKGAIGNDB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FNBKGAIGNDB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (!object.Equals(GANHMAEIFIB, other.GANHMAEIFIB)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(PCOINGAMOML, other.PCOINGAMOML)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueBuffInfo_ != null) hash ^= RogueBuffInfo.GetHashCode();
      if (gameMiracleInfo_ != null) hash ^= GameMiracleInfo.GetHashCode();
      if (gANHMAEIFIB_ != null) hash ^= GANHMAEIFIB.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (pCOINGAMOML_ != null) hash ^= PCOINGAMOML.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (gANHMAEIFIB_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GANHMAEIFIB);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(GameMiracleInfo);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueAeonInfo);
      }
      if (pCOINGAMOML_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PCOINGAMOML);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueBuffInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (gANHMAEIFIB_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GANHMAEIFIB);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(GameMiracleInfo);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueAeonInfo);
      }
      if (pCOINGAMOML_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PCOINGAMOML);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueBuffInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (rogueBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (gameMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (gANHMAEIFIB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GANHMAEIFIB);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (pCOINGAMOML_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PCOINGAMOML);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FNBKGAIGNDB other) {
      if (other == null) {
        return;
      }
      if (other.rogueBuffInfo_ != null) {
        if (rogueBuffInfo_ == null) {
          RogueBuffInfo = new global::EggLink.DanhengServer.Proto.CLMLDLDGHBE();
        }
        RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
      }
      if (other.gameMiracleInfo_ != null) {
        if (gameMiracleInfo_ == null) {
          GameMiracleInfo = new global::EggLink.DanhengServer.Proto.PFNHOHOOEND();
        }
        GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
      }
      if (other.gANHMAEIFIB_ != null) {
        if (gANHMAEIFIB_ == null) {
          GANHMAEIFIB = new global::EggLink.DanhengServer.Proto.LPPCEFCGJIO();
        }
        GANHMAEIFIB.MergeFrom(other.GANHMAEIFIB);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ADPMGHAIJPB();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.pCOINGAMOML_ != null) {
        if (pCOINGAMOML_ == null) {
          PCOINGAMOML = new global::EggLink.DanhengServer.Proto.HGDFPBLKLDC();
        }
        PCOINGAMOML.MergeFrom(other.PCOINGAMOML);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 34: {
            if (gANHMAEIFIB_ == null) {
              GANHMAEIFIB = new global::EggLink.DanhengServer.Proto.LPPCEFCGJIO();
            }
            input.ReadMessage(GANHMAEIFIB);
            break;
          }
          case 58: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.PFNHOHOOEND();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 66: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ADPMGHAIJPB();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (pCOINGAMOML_ == null) {
              PCOINGAMOML = new global::EggLink.DanhengServer.Proto.HGDFPBLKLDC();
            }
            input.ReadMessage(PCOINGAMOML);
            break;
          }
          case 122: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.CLMLDLDGHBE();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 34: {
            if (gANHMAEIFIB_ == null) {
              GANHMAEIFIB = new global::EggLink.DanhengServer.Proto.LPPCEFCGJIO();
            }
            input.ReadMessage(GANHMAEIFIB);
            break;
          }
          case 58: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.PFNHOHOOEND();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 66: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ADPMGHAIJPB();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (pCOINGAMOML_ == null) {
              PCOINGAMOML = new global::EggLink.DanhengServer.Proto.HGDFPBLKLDC();
            }
            input.ReadMessage(PCOINGAMOML);
            break;
          }
          case 122: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.CLMLDLDGHBE();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
