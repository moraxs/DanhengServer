// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Product.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Product.proto</summary>
  public static partial class ProductReflection {

    #region Descriptor
    /// <summary>File descriptor for Product.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1Qcm9kdWN0LnByb3RvGhVQcm9kdWN0R2lmdFR5cGUucHJvdG8ilwEKB1By",
            "b2R1Y3QSEwoLTUdLR0xNQk9BQUMYDSABKA0SIwoJZ2lmdF90eXBlGAsgASgO",
            "MhAuUHJvZHVjdEdpZnRUeXBlEhMKC05HT0tCQUhCR0NIGAYgASgIEhMKC0ZE",
            "QkVIRUtFTkhJGA4gASgNEhMKC0ZNRk5GRE9HSURDGAkgASgJEhMKC0RFSkxH",
            "TExPRUpNGA8gASgJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ProductGiftTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Product), global::EggLink.DanhengServer.Proto.Product.Parser, new[]{ "MGKGLMBOAAC", "GiftType", "NGOKBAHBGCH", "FDBEHEKENHI", "FMFNFDOGIDC", "DEJLGLLOEJM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Product : pb::IMessage<Product>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Product> _parser = new pb::MessageParser<Product>(() => new Product());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Product> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ProductReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product(Product other) : this() {
      mGKGLMBOAAC_ = other.mGKGLMBOAAC_;
      giftType_ = other.giftType_;
      nGOKBAHBGCH_ = other.nGOKBAHBGCH_;
      fDBEHEKENHI_ = other.fDBEHEKENHI_;
      fMFNFDOGIDC_ = other.fMFNFDOGIDC_;
      dEJLGLLOEJM_ = other.dEJLGLLOEJM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product Clone() {
      return new Product(this);
    }

    /// <summary>Field number for the "MGKGLMBOAAC" field.</summary>
    public const int MGKGLMBOAACFieldNumber = 13;
    private uint mGKGLMBOAAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MGKGLMBOAAC {
      get { return mGKGLMBOAAC_; }
      set {
        mGKGLMBOAAC_ = value;
      }
    }

    /// <summary>Field number for the "gift_type" field.</summary>
    public const int GiftTypeFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ProductGiftType giftType_ = global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ProductGiftType GiftType {
      get { return giftType_; }
      set {
        giftType_ = value;
      }
    }

    /// <summary>Field number for the "NGOKBAHBGCH" field.</summary>
    public const int NGOKBAHBGCHFieldNumber = 6;
    private bool nGOKBAHBGCH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NGOKBAHBGCH {
      get { return nGOKBAHBGCH_; }
      set {
        nGOKBAHBGCH_ = value;
      }
    }

    /// <summary>Field number for the "FDBEHEKENHI" field.</summary>
    public const int FDBEHEKENHIFieldNumber = 14;
    private uint fDBEHEKENHI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FDBEHEKENHI {
      get { return fDBEHEKENHI_; }
      set {
        fDBEHEKENHI_ = value;
      }
    }

    /// <summary>Field number for the "FMFNFDOGIDC" field.</summary>
    public const int FMFNFDOGIDCFieldNumber = 9;
    private string fMFNFDOGIDC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FMFNFDOGIDC {
      get { return fMFNFDOGIDC_; }
      set {
        fMFNFDOGIDC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DEJLGLLOEJM" field.</summary>
    public const int DEJLGLLOEJMFieldNumber = 15;
    private string dEJLGLLOEJM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DEJLGLLOEJM {
      get { return dEJLGLLOEJM_; }
      set {
        dEJLGLLOEJM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Product);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Product other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MGKGLMBOAAC != other.MGKGLMBOAAC) return false;
      if (GiftType != other.GiftType) return false;
      if (NGOKBAHBGCH != other.NGOKBAHBGCH) return false;
      if (FDBEHEKENHI != other.FDBEHEKENHI) return false;
      if (FMFNFDOGIDC != other.FMFNFDOGIDC) return false;
      if (DEJLGLLOEJM != other.DEJLGLLOEJM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MGKGLMBOAAC != 0) hash ^= MGKGLMBOAAC.GetHashCode();
      if (GiftType != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) hash ^= GiftType.GetHashCode();
      if (NGOKBAHBGCH != false) hash ^= NGOKBAHBGCH.GetHashCode();
      if (FDBEHEKENHI != 0) hash ^= FDBEHEKENHI.GetHashCode();
      if (FMFNFDOGIDC.Length != 0) hash ^= FMFNFDOGIDC.GetHashCode();
      if (DEJLGLLOEJM.Length != 0) hash ^= DEJLGLLOEJM.GetHashCode();
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
      if (NGOKBAHBGCH != false) {
        output.WriteRawTag(48);
        output.WriteBool(NGOKBAHBGCH);
      }
      if (FMFNFDOGIDC.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(FMFNFDOGIDC);
      }
      if (GiftType != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) GiftType);
      }
      if (MGKGLMBOAAC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MGKGLMBOAAC);
      }
      if (FDBEHEKENHI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FDBEHEKENHI);
      }
      if (DEJLGLLOEJM.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(DEJLGLLOEJM);
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
      if (NGOKBAHBGCH != false) {
        output.WriteRawTag(48);
        output.WriteBool(NGOKBAHBGCH);
      }
      if (FMFNFDOGIDC.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(FMFNFDOGIDC);
      }
      if (GiftType != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) GiftType);
      }
      if (MGKGLMBOAAC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MGKGLMBOAAC);
      }
      if (FDBEHEKENHI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FDBEHEKENHI);
      }
      if (DEJLGLLOEJM.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(DEJLGLLOEJM);
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
      if (MGKGLMBOAAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MGKGLMBOAAC);
      }
      if (GiftType != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GiftType);
      }
      if (NGOKBAHBGCH != false) {
        size += 1 + 1;
      }
      if (FDBEHEKENHI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FDBEHEKENHI);
      }
      if (FMFNFDOGIDC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FMFNFDOGIDC);
      }
      if (DEJLGLLOEJM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DEJLGLLOEJM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Product other) {
      if (other == null) {
        return;
      }
      if (other.MGKGLMBOAAC != 0) {
        MGKGLMBOAAC = other.MGKGLMBOAAC;
      }
      if (other.GiftType != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        GiftType = other.GiftType;
      }
      if (other.NGOKBAHBGCH != false) {
        NGOKBAHBGCH = other.NGOKBAHBGCH;
      }
      if (other.FDBEHEKENHI != 0) {
        FDBEHEKENHI = other.FDBEHEKENHI;
      }
      if (other.FMFNFDOGIDC.Length != 0) {
        FMFNFDOGIDC = other.FMFNFDOGIDC;
      }
      if (other.DEJLGLLOEJM.Length != 0) {
        DEJLGLLOEJM = other.DEJLGLLOEJM;
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
          case 48: {
            NGOKBAHBGCH = input.ReadBool();
            break;
          }
          case 74: {
            FMFNFDOGIDC = input.ReadString();
            break;
          }
          case 88: {
            GiftType = (global::EggLink.DanhengServer.Proto.ProductGiftType) input.ReadEnum();
            break;
          }
          case 104: {
            MGKGLMBOAAC = input.ReadUInt32();
            break;
          }
          case 112: {
            FDBEHEKENHI = input.ReadUInt32();
            break;
          }
          case 122: {
            DEJLGLLOEJM = input.ReadString();
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
          case 48: {
            NGOKBAHBGCH = input.ReadBool();
            break;
          }
          case 74: {
            FMFNFDOGIDC = input.ReadString();
            break;
          }
          case 88: {
            GiftType = (global::EggLink.DanhengServer.Proto.ProductGiftType) input.ReadEnum();
            break;
          }
          case 104: {
            MGKGLMBOAAC = input.ReadUInt32();
            break;
          }
          case 112: {
            FDBEHEKENHI = input.ReadUInt32();
            break;
          }
          case 122: {
            DEJLGLLOEJM = input.ReadString();
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
