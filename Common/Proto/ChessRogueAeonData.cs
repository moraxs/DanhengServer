// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueAeonData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueAeonData.proto</summary>
  public static partial class ChessRogueAeonDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueAeonData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueAeonDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlQWVvbkRhdGEucHJvdG8aE0NoZXNzQWVvbkluZm8ucHJv",
            "dG8aFk1vZmlNb2RpZmllckxpc3QucHJvdG8irwEKEkNoZXNzUm9ndWVBZW9u",
            "RGF0YRInCg9jaGVzc19hZW9uX2luZm8YDSABKAsyDi5DaGVzc0Flb25JbmZv",
            "Eh0KFXVubG9ja2VkX2Flb25faWRfbGlzdBgJIAMoDRInCgxhZGRfbW9kaWZp",
            "ZXIYByABKAsyES5Nb2ZpTW9kaWZpZXJMaXN0EhMKC2N1cl9hZW9uX2lkGAUg",
            "ASgNEhMKC0VOT0NLQUFEREJKGAsgASgFQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MofiModifierListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueAeonData), global::EggLink.DanhengServer.Proto.ChessRogueAeonData.Parser, new[]{ "ChessAeonInfo", "UnlockedAeonIdList", "AddModifier", "CurAeonId", "ENOCKAADDBJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueAeonData : pb::IMessage<ChessRogueAeonData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueAeonData> _parser = new pb::MessageParser<ChessRogueAeonData>(() => new ChessRogueAeonData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueAeonData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueAeonDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonData(ChessRogueAeonData other) : this() {
      chessAeonInfo_ = other.chessAeonInfo_ != null ? other.chessAeonInfo_.Clone() : null;
      unlockedAeonIdList_ = other.unlockedAeonIdList_.Clone();
      addModifier_ = other.addModifier_ != null ? other.addModifier_.Clone() : null;
      curAeonId_ = other.curAeonId_;
      eNOCKAADDBJ_ = other.eNOCKAADDBJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonData Clone() {
      return new ChessRogueAeonData(this);
    }

    /// <summary>Field number for the "chess_aeon_info" field.</summary>
    public const int ChessAeonInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ChessAeonInfo chessAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessAeonInfo ChessAeonInfo {
      get { return chessAeonInfo_; }
      set {
        chessAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "unlocked_aeon_id_list" field.</summary>
    public const int UnlockedAeonIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedAeonIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> unlockedAeonIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedAeonIdList {
      get { return unlockedAeonIdList_; }
    }

    /// <summary>Field number for the "add_modifier" field.</summary>
    public const int AddModifierFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.MofiModifierList addModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MofiModifierList AddModifier {
      get { return addModifier_; }
      set {
        addModifier_ = value;
      }
    }

    /// <summary>Field number for the "cur_aeon_id" field.</summary>
    public const int CurAeonIdFieldNumber = 5;
    private uint curAeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurAeonId {
      get { return curAeonId_; }
      set {
        curAeonId_ = value;
      }
    }

    /// <summary>Field number for the "ENOCKAADDBJ" field.</summary>
    public const int ENOCKAADDBJFieldNumber = 11;
    private int eNOCKAADDBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ENOCKAADDBJ {
      get { return eNOCKAADDBJ_; }
      set {
        eNOCKAADDBJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueAeonData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueAeonData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ChessAeonInfo, other.ChessAeonInfo)) return false;
      if(!unlockedAeonIdList_.Equals(other.unlockedAeonIdList_)) return false;
      if (!object.Equals(AddModifier, other.AddModifier)) return false;
      if (CurAeonId != other.CurAeonId) return false;
      if (ENOCKAADDBJ != other.ENOCKAADDBJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (chessAeonInfo_ != null) hash ^= ChessAeonInfo.GetHashCode();
      hash ^= unlockedAeonIdList_.GetHashCode();
      if (addModifier_ != null) hash ^= AddModifier.GetHashCode();
      if (CurAeonId != 0) hash ^= CurAeonId.GetHashCode();
      if (ENOCKAADDBJ != 0) hash ^= ENOCKAADDBJ.GetHashCode();
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
      if (CurAeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurAeonId);
      }
      if (addModifier_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AddModifier);
      }
      unlockedAeonIdList_.WriteTo(output, _repeated_unlockedAeonIdList_codec);
      if (ENOCKAADDBJ != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(ENOCKAADDBJ);
      }
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ChessAeonInfo);
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
      if (CurAeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurAeonId);
      }
      if (addModifier_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AddModifier);
      }
      unlockedAeonIdList_.WriteTo(ref output, _repeated_unlockedAeonIdList_codec);
      if (ENOCKAADDBJ != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(ENOCKAADDBJ);
      }
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ChessAeonInfo);
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
      if (chessAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessAeonInfo);
      }
      size += unlockedAeonIdList_.CalculateSize(_repeated_unlockedAeonIdList_codec);
      if (addModifier_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AddModifier);
      }
      if (CurAeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurAeonId);
      }
      if (ENOCKAADDBJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ENOCKAADDBJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueAeonData other) {
      if (other == null) {
        return;
      }
      if (other.chessAeonInfo_ != null) {
        if (chessAeonInfo_ == null) {
          ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessAeonInfo();
        }
        ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
      }
      unlockedAeonIdList_.Add(other.unlockedAeonIdList_);
      if (other.addModifier_ != null) {
        if (addModifier_ == null) {
          AddModifier = new global::EggLink.DanhengServer.Proto.MofiModifierList();
        }
        AddModifier.MergeFrom(other.AddModifier);
      }
      if (other.CurAeonId != 0) {
        CurAeonId = other.CurAeonId;
      }
      if (other.ENOCKAADDBJ != 0) {
        ENOCKAADDBJ = other.ENOCKAADDBJ;
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
          case 40: {
            CurAeonId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (addModifier_ == null) {
              AddModifier = new global::EggLink.DanhengServer.Proto.MofiModifierList();
            }
            input.ReadMessage(AddModifier);
            break;
          }
          case 74:
          case 72: {
            unlockedAeonIdList_.AddEntriesFrom(input, _repeated_unlockedAeonIdList_codec);
            break;
          }
          case 88: {
            ENOCKAADDBJ = input.ReadInt32();
            break;
          }
          case 106: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
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
          case 40: {
            CurAeonId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (addModifier_ == null) {
              AddModifier = new global::EggLink.DanhengServer.Proto.MofiModifierList();
            }
            input.ReadMessage(AddModifier);
            break;
          }
          case 74:
          case 72: {
            unlockedAeonIdList_.AddEntriesFrom(ref input, _repeated_unlockedAeonIdList_codec);
            break;
          }
          case 88: {
            ENOCKAADDBJ = input.ReadInt32();
            break;
          }
          case 106: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
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
