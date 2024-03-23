// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueGetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueGetInfo.proto</summary>
  public static partial class RogueGetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueGetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueGetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSb2d1ZUdldEluZm8ucHJvdG8aFVJvZ3VlU2Vhc29uSW5mby5wcm90bxoa",
            "Um9ndWVTY29yZVJld2FyZEluZm8ucHJvdG8aE1JvZ3VlQWVvbkluZm8ucHJv",
            "dG8aE1JvZ3VlQXJlYUxpc3QucHJvdG8aE1JvZ3VlSXRlbUluZm8ucHJvdG8i",
            "9gEKDFJvZ3VlR2V0SW5mbxI2Chdyb2d1ZV9zY29yZV9yZXdhcmRfaW5mbxgP",
            "IAEoCzIVLlJvZ3VlU2NvcmVSZXdhcmRJbmZvEicKD3JvZ3VlX2Flb25faW5m",
            "bxgBIAEoCzIOLlJvZ3VlQWVvbkluZm8SKwoRcm9ndWVfc2Vhc29uX2luZm8Y",
            "CyABKAsyEC5Sb2d1ZVNlYXNvbkluZm8SLwoXcm9ndWVfdmlydHVhbF9pdGVt",
            "X2luZm8YAiABKAsyDi5Sb2d1ZUl0ZW1JbmZvEicKD3JvZ3VlX2FyZWFfaW5m",
            "bxgOIAEoCzIOLlJvZ3VlQXJlYUxpc3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueSeasonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueScoreRewardInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueAreaListReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueItemInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueGetInfo), global::EggLink.DanhengServer.Proto.RogueGetInfo.Parser, new[]{ "RogueScoreRewardInfo", "RogueAeonInfo", "RogueSeasonInfo", "RogueVirtualItemInfo", "RogueAreaInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueGetInfo : pb::IMessage<RogueGetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueGetInfo> _parser = new pb::MessageParser<RogueGetInfo>(() => new RogueGetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueGetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueGetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGetInfo(RogueGetInfo other) : this() {
      rogueScoreRewardInfo_ = other.rogueScoreRewardInfo_ != null ? other.rogueScoreRewardInfo_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      rogueSeasonInfo_ = other.rogueSeasonInfo_ != null ? other.rogueSeasonInfo_.Clone() : null;
      rogueVirtualItemInfo_ = other.rogueVirtualItemInfo_ != null ? other.rogueVirtualItemInfo_.Clone() : null;
      rogueAreaInfo_ = other.rogueAreaInfo_ != null ? other.rogueAreaInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGetInfo Clone() {
      return new RogueGetInfo(this);
    }

    /// <summary>Field number for the "rogue_score_reward_info" field.</summary>
    public const int RogueScoreRewardInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo rogueScoreRewardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo RogueScoreRewardInfo {
      get { return rogueScoreRewardInfo_; }
      set {
        rogueScoreRewardInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RogueAeonInfo rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueAeonInfo RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_season_info" field.</summary>
    public const int RogueSeasonInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueSeasonInfo rogueSeasonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueSeasonInfo RogueSeasonInfo {
      get { return rogueSeasonInfo_; }
      set {
        rogueSeasonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_virtual_item_info" field.</summary>
    public const int RogueVirtualItemInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueItemInfo rogueVirtualItemInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueItemInfo RogueVirtualItemInfo {
      get { return rogueVirtualItemInfo_; }
      set {
        rogueVirtualItemInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_area_info" field.</summary>
    public const int RogueAreaInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RogueAreaList rogueAreaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueAreaList RogueAreaInfo {
      get { return rogueAreaInfo_; }
      set {
        rogueAreaInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueGetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueGetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueScoreRewardInfo, other.RogueScoreRewardInfo)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(RogueSeasonInfo, other.RogueSeasonInfo)) return false;
      if (!object.Equals(RogueVirtualItemInfo, other.RogueVirtualItemInfo)) return false;
      if (!object.Equals(RogueAreaInfo, other.RogueAreaInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueScoreRewardInfo_ != null) hash ^= RogueScoreRewardInfo.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (rogueSeasonInfo_ != null) hash ^= RogueSeasonInfo.GetHashCode();
      if (rogueVirtualItemInfo_ != null) hash ^= RogueVirtualItemInfo.GetHashCode();
      if (rogueAreaInfo_ != null) hash ^= RogueAreaInfo.GetHashCode();
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
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      if (rogueSeasonInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueSeasonInfo);
      }
      if (rogueAreaInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueAreaInfo);
      }
      if (rogueScoreRewardInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueScoreRewardInfo);
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
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      if (rogueSeasonInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueSeasonInfo);
      }
      if (rogueAreaInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueAreaInfo);
      }
      if (rogueScoreRewardInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueScoreRewardInfo);
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
      if (rogueScoreRewardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueScoreRewardInfo);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (rogueSeasonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueSeasonInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueVirtualItemInfo);
      }
      if (rogueAreaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAreaInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueGetInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueScoreRewardInfo_ != null) {
        if (rogueScoreRewardInfo_ == null) {
          RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.RogueAeonInfo();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.rogueSeasonInfo_ != null) {
        if (rogueSeasonInfo_ == null) {
          RogueSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueSeasonInfo();
        }
        RogueSeasonInfo.MergeFrom(other.RogueSeasonInfo);
      }
      if (other.rogueVirtualItemInfo_ != null) {
        if (rogueVirtualItemInfo_ == null) {
          RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.RogueItemInfo();
        }
        RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
      }
      if (other.rogueAreaInfo_ != null) {
        if (rogueAreaInfo_ == null) {
          RogueAreaInfo = new global::EggLink.DanhengServer.Proto.RogueAreaList();
        }
        RogueAreaInfo.MergeFrom(other.RogueAreaInfo);
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
          case 10: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.RogueAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 18: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.RogueItemInfo();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 90: {
            if (rogueSeasonInfo_ == null) {
              RogueSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueSeasonInfo();
            }
            input.ReadMessage(RogueSeasonInfo);
            break;
          }
          case 114: {
            if (rogueAreaInfo_ == null) {
              RogueAreaInfo = new global::EggLink.DanhengServer.Proto.RogueAreaList();
            }
            input.ReadMessage(RogueAreaInfo);
            break;
          }
          case 122: {
            if (rogueScoreRewardInfo_ == null) {
              RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(RogueScoreRewardInfo);
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
          case 10: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.RogueAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 18: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.RogueItemInfo();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 90: {
            if (rogueSeasonInfo_ == null) {
              RogueSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueSeasonInfo();
            }
            input.ReadMessage(RogueSeasonInfo);
            break;
          }
          case 114: {
            if (rogueAreaInfo_ == null) {
              RogueAreaInfo = new global::EggLink.DanhengServer.Proto.RogueAreaList();
            }
            input.ReadMessage(RogueAreaInfo);
            break;
          }
          case 122: {
            if (rogueScoreRewardInfo_ == null) {
              RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(RogueScoreRewardInfo);
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
