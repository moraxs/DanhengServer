// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectChessRogueNousSubStoryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SelectChessRogueNousSubStoryScRsp.proto</summary>
  public static partial class SelectChessRogueNousSubStoryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SelectChessRogueNousSubStoryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SelectChessRogueNousSubStoryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZWxlY3RDaGVzc1JvZ3VlTm91c1N1YlN0b3J5U2NSc3AucHJvdG8ieQoh",
            "U2VsZWN0Q2hlc3NSb2d1ZU5vdXNTdWJTdG9yeVNjUnNwEg8KB3JldGNvZGUY",
            "BCABKA0SGQoRZGlhbG9ndWVfZXZlbnRfaWQYAiABKA0SEwoLT0dBRE9ES0dM",
            "TkwYCyABKA0SEwoLR0tBSU9HTkNETkUYCiABKA1CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryScRsp), global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryScRsp.Parser, new[]{ "Retcode", "DialogueEventId", "OGADODKGLNL", "GKAIOGNCDNE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SelectChessRogueNousSubStoryScRsp : pb::IMessage<SelectChessRogueNousSubStoryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SelectChessRogueNousSubStoryScRsp> _parser = new pb::MessageParser<SelectChessRogueNousSubStoryScRsp>(() => new SelectChessRogueNousSubStoryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SelectChessRogueNousSubStoryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryScRsp(SelectChessRogueNousSubStoryScRsp other) : this() {
      retcode_ = other.retcode_;
      dialogueEventId_ = other.dialogueEventId_;
      oGADODKGLNL_ = other.oGADODKGLNL_;
      gKAIOGNCDNE_ = other.gKAIOGNCDNE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryScRsp Clone() {
      return new SelectChessRogueNousSubStoryScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "dialogue_event_id" field.</summary>
    public const int DialogueEventIdFieldNumber = 2;
    private uint dialogueEventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DialogueEventId {
      get { return dialogueEventId_; }
      set {
        dialogueEventId_ = value;
      }
    }

    /// <summary>Field number for the "OGADODKGLNL" field.</summary>
    public const int OGADODKGLNLFieldNumber = 11;
    private uint oGADODKGLNL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGADODKGLNL {
      get { return oGADODKGLNL_; }
      set {
        oGADODKGLNL_ = value;
      }
    }

    /// <summary>Field number for the "GKAIOGNCDNE" field.</summary>
    public const int GKAIOGNCDNEFieldNumber = 10;
    private uint gKAIOGNCDNE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GKAIOGNCDNE {
      get { return gKAIOGNCDNE_; }
      set {
        gKAIOGNCDNE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SelectChessRogueNousSubStoryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SelectChessRogueNousSubStoryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (DialogueEventId != other.DialogueEventId) return false;
      if (OGADODKGLNL != other.OGADODKGLNL) return false;
      if (GKAIOGNCDNE != other.GKAIOGNCDNE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (DialogueEventId != 0) hash ^= DialogueEventId.GetHashCode();
      if (OGADODKGLNL != 0) hash ^= OGADODKGLNL.GetHashCode();
      if (GKAIOGNCDNE != 0) hash ^= GKAIOGNCDNE.GetHashCode();
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
      if (DialogueEventId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DialogueEventId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (GKAIOGNCDNE != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GKAIOGNCDNE);
      }
      if (OGADODKGLNL != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OGADODKGLNL);
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
      if (DialogueEventId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DialogueEventId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (GKAIOGNCDNE != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GKAIOGNCDNE);
      }
      if (OGADODKGLNL != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OGADODKGLNL);
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
      if (DialogueEventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DialogueEventId);
      }
      if (OGADODKGLNL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGADODKGLNL);
      }
      if (GKAIOGNCDNE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GKAIOGNCDNE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SelectChessRogueNousSubStoryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.DialogueEventId != 0) {
        DialogueEventId = other.DialogueEventId;
      }
      if (other.OGADODKGLNL != 0) {
        OGADODKGLNL = other.OGADODKGLNL;
      }
      if (other.GKAIOGNCDNE != 0) {
        GKAIOGNCDNE = other.GKAIOGNCDNE;
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
          case 16: {
            DialogueEventId = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            GKAIOGNCDNE = input.ReadUInt32();
            break;
          }
          case 88: {
            OGADODKGLNL = input.ReadUInt32();
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
          case 16: {
            DialogueEventId = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            GKAIOGNCDNE = input.ReadUInt32();
            break;
          }
          case 88: {
            OGADODKGLNL = input.ReadUInt32();
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
