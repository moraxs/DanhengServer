// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQueryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQueryScRsp.proto</summary>
  public static partial class ChessRogueQueryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQueryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQueryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaGVzc1JvZ3VlUXVlcnlTY1JzcC5wcm90bxoYQ2hlc3NSb2d1ZUdhbWVJ",
            "bmZvLnByb3RvGiFDaGVzc1JvZ3VlRXhwbG9yZUZpbmlzaEluZm8ucHJvdG8a",
            "FENoZXNzUm9ndWVJbmZvLnByb3RvGhJHYW1lUGxheUluZm8ucHJvdG8aEUpN",
            "S0ZHSU5PQUhLLnByb3RvIvEBChRDaGVzc1JvZ3VlUXVlcnlTY1JzcBIPCgdy",
            "ZXRjb2RlGAwgASgNEiUKDnJvZ3VlX2dldF9pbmZvGAggASgLMg0uR2FtZVBs",
            "YXlJbmZvEh0KBGluZm8YCiABKAsyDy5DaGVzc1JvZ3VlSW5mbxIxCgtFTU5L",
            "SklESEhJRBgJIAEoCzIcLkNoZXNzUm9ndWVFeHBsb3JlRmluaXNoSW5mbxIh",
            "CgtFRk1QRkJDRU1JRxgDIAEoCzIMLkpNS0ZHSU5PQUhLEiwKD3JvZ3VlX2dh",
            "bWVfaW5mbxgHIAEoCzITLkNoZXNzUm9ndWVHYW1lSW5mb0IeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueGameInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GamePlayInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.JMKFGINOAHKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQueryScRsp), global::EggLink.DanhengServer.Proto.ChessRogueQueryScRsp.Parser, new[]{ "Retcode", "RogueGetInfo", "Info", "EMNKJIDHHID", "EFMPFBCEMIG", "RogueGameInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQueryScRsp : pb::IMessage<ChessRogueQueryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQueryScRsp> _parser = new pb::MessageParser<ChessRogueQueryScRsp>(() => new ChessRogueQueryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQueryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQueryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp(ChessRogueQueryScRsp other) : this() {
      retcode_ = other.retcode_;
      rogueGetInfo_ = other.rogueGetInfo_ != null ? other.rogueGetInfo_.Clone() : null;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      eMNKJIDHHID_ = other.eMNKJIDHHID_ != null ? other.eMNKJIDHHID_.Clone() : null;
      eFMPFBCEMIG_ = other.eFMPFBCEMIG_ != null ? other.eFMPFBCEMIG_.Clone() : null;
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp Clone() {
      return new ChessRogueQueryScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_get_info" field.</summary>
    public const int RogueGetInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.GamePlayInfo rogueGetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GamePlayInfo RogueGetInfo {
      get { return rogueGetInfo_; }
      set {
        rogueGetInfo_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ChessRogueInfo info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueInfo Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "EMNKJIDHHID" field.</summary>
    public const int EMNKJIDHHIDFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo eMNKJIDHHID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo EMNKJIDHHID {
      get { return eMNKJIDHHID_; }
      set {
        eMNKJIDHHID_ = value;
      }
    }

    /// <summary>Field number for the "EFMPFBCEMIG" field.</summary>
    public const int EFMPFBCEMIGFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.JMKFGINOAHK eFMPFBCEMIG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JMKFGINOAHK EFMPFBCEMIG {
      get { return eFMPFBCEMIG_; }
      set {
        eFMPFBCEMIG_ = value;
      }
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ChessRogueGameInfo rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGameInfo RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQueryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQueryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RogueGetInfo, other.RogueGetInfo)) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (!object.Equals(EMNKJIDHHID, other.EMNKJIDHHID)) return false;
      if (!object.Equals(EFMPFBCEMIG, other.EFMPFBCEMIG)) return false;
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rogueGetInfo_ != null) hash ^= RogueGetInfo.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (eMNKJIDHHID_ != null) hash ^= EMNKJIDHHID.GetHashCode();
      if (eFMPFBCEMIG_ != null) hash ^= EFMPFBCEMIG.GetHashCode();
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
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
      if (eFMPFBCEMIG_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EFMPFBCEMIG);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RogueGameInfo);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueGetInfo);
      }
      if (eMNKJIDHHID_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EMNKJIDHHID);
      }
      if (info_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Info);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (eFMPFBCEMIG_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EFMPFBCEMIG);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RogueGameInfo);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueGetInfo);
      }
      if (eMNKJIDHHID_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EMNKJIDHHID);
      }
      if (info_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Info);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (rogueGetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGetInfo);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (eMNKJIDHHID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EMNKJIDHHID);
      }
      if (eFMPFBCEMIG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFMPFBCEMIG);
      }
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQueryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rogueGetInfo_ != null) {
        if (rogueGetInfo_ == null) {
          RogueGetInfo = new global::EggLink.DanhengServer.Proto.GamePlayInfo();
        }
        RogueGetInfo.MergeFrom(other.RogueGetInfo);
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.eMNKJIDHHID_ != null) {
        if (eMNKJIDHHID_ == null) {
          EMNKJIDHHID = new global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo();
        }
        EMNKJIDHHID.MergeFrom(other.EMNKJIDHHID);
      }
      if (other.eFMPFBCEMIG_ != null) {
        if (eFMPFBCEMIG_ == null) {
          EFMPFBCEMIG = new global::EggLink.DanhengServer.Proto.JMKFGINOAHK();
        }
        EFMPFBCEMIG.MergeFrom(other.EFMPFBCEMIG);
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
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
          case 26: {
            if (eFMPFBCEMIG_ == null) {
              EFMPFBCEMIG = new global::EggLink.DanhengServer.Proto.JMKFGINOAHK();
            }
            input.ReadMessage(EFMPFBCEMIG);
            break;
          }
          case 58: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 66: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.GamePlayInfo();
            }
            input.ReadMessage(RogueGetInfo);
            break;
          }
          case 74: {
            if (eMNKJIDHHID_ == null) {
              EMNKJIDHHID = new global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo();
            }
            input.ReadMessage(EMNKJIDHHID);
            break;
          }
          case 82: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
            }
            input.ReadMessage(Info);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
          case 26: {
            if (eFMPFBCEMIG_ == null) {
              EFMPFBCEMIG = new global::EggLink.DanhengServer.Proto.JMKFGINOAHK();
            }
            input.ReadMessage(EFMPFBCEMIG);
            break;
          }
          case 58: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 66: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.GamePlayInfo();
            }
            input.ReadMessage(RogueGetInfo);
            break;
          }
          case 74: {
            if (eMNKJIDHHID_ == null) {
              EMNKJIDHHID = new global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo();
            }
            input.ReadMessage(EMNKJIDHHID);
            break;
          }
          case 82: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
            }
            input.ReadMessage(Info);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
