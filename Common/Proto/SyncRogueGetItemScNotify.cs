// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncRogueGetItemScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncRogueGetItemScNotify.proto</summary>
  public static partial class SyncRogueGetItemScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncRogueGetItemScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncRogueGetItemScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TeW5jUm9ndWVHZXRJdGVtU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy",
            "b3RvIlwKGFN5bmNSb2d1ZUdldEl0ZW1TY05vdGlmeRIgCg1nZXRfaXRlbV9s",
            "aXN0GAYgASgLMgkuSXRlbUxpc3QSHgoLRU1FRUJCQU9ESUIYCiABKAsyCS5J",
            "dGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncRogueGetItemScNotify), global::EggLink.DanhengServer.Proto.SyncRogueGetItemScNotify.Parser, new[]{ "GetItemList", "EMEEBBAODIB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncRogueGetItemScNotify : pb::IMessage<SyncRogueGetItemScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncRogueGetItemScNotify> _parser = new pb::MessageParser<SyncRogueGetItemScNotify>(() => new SyncRogueGetItemScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncRogueGetItemScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncRogueGetItemScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueGetItemScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueGetItemScNotify(SyncRogueGetItemScNotify other) : this() {
      getItemList_ = other.getItemList_ != null ? other.getItemList_.Clone() : null;
      eMEEBBAODIB_ = other.eMEEBBAODIB_ != null ? other.eMEEBBAODIB_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueGetItemScNotify Clone() {
      return new SyncRogueGetItemScNotify(this);
    }

    /// <summary>Field number for the "get_item_list" field.</summary>
    public const int GetItemListFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ItemList getItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList GetItemList {
      get { return getItemList_; }
      set {
        getItemList_ = value;
      }
    }

    /// <summary>Field number for the "EMEEBBAODIB" field.</summary>
    public const int EMEEBBAODIBFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemList eMEEBBAODIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList EMEEBBAODIB {
      get { return eMEEBBAODIB_; }
      set {
        eMEEBBAODIB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncRogueGetItemScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncRogueGetItemScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GetItemList, other.GetItemList)) return false;
      if (!object.Equals(EMEEBBAODIB, other.EMEEBBAODIB)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (getItemList_ != null) hash ^= GetItemList.GetHashCode();
      if (eMEEBBAODIB_ != null) hash ^= EMEEBBAODIB.GetHashCode();
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
      if (getItemList_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GetItemList);
      }
      if (eMEEBBAODIB_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(EMEEBBAODIB);
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
      if (getItemList_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GetItemList);
      }
      if (eMEEBBAODIB_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(EMEEBBAODIB);
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
      if (getItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GetItemList);
      }
      if (eMEEBBAODIB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EMEEBBAODIB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncRogueGetItemScNotify other) {
      if (other == null) {
        return;
      }
      if (other.getItemList_ != null) {
        if (getItemList_ == null) {
          GetItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        GetItemList.MergeFrom(other.GetItemList);
      }
      if (other.eMEEBBAODIB_ != null) {
        if (eMEEBBAODIB_ == null) {
          EMEEBBAODIB = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        EMEEBBAODIB.MergeFrom(other.EMEEBBAODIB);
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
          case 50: {
            if (getItemList_ == null) {
              GetItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(GetItemList);
            break;
          }
          case 82: {
            if (eMEEBBAODIB_ == null) {
              EMEEBBAODIB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(EMEEBBAODIB);
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
          case 50: {
            if (getItemList_ == null) {
              GetItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(GetItemList);
            break;
          }
          case 82: {
            if (eMEEBBAODIB_ == null) {
              EMEEBBAODIB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(EMEEBBAODIB);
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