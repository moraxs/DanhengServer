// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueDiceData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueDiceData.proto</summary>
  public static partial class ChessRogueDiceDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueDiceData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueDiceDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlRGljZURhdGEucHJvdG8aGENoZXNzUm9ndWVEaWNlVHlw",
            "ZS5wcm90bxoUQ2hlc3NSb2d1ZURpY2UucHJvdG8aFk1vZmlNb2RpZmllckxp",
            "c3QucHJvdG8aGkNoZXNzUm9ndWVEaWNlU3RhdHVzLnByb3RvIuQDChJDaGVz",
            "c1JvZ3VlRGljZURhdGESEwoLY3VyX3N1cmZhY2UYCSABKA0SFAoLQkNITU5N",
            "QkVMTEYYugMgAygNEiIKCGN1cl9kaWNlGIkMIAEoCzIPLkNoZXNzUm9ndWVE",
            "aWNlEhMKC0dLQU9DUEJLTk1MGAIgASgNEhQKC0VOS0JPTENQS0ZCGK4NIAEo",
            "CBIUCgtMRkFKRE9BUERDRRjvBSABKAUSEQoJYnJhbmNoX2lkGA0gASgNEhQK",
            "DHJlcm9sbF9jb3VudBgLIAEoDRITCgtQSFBHTkZHRFBMQxgHIAEoCBITCgtj",
            "aGVhdF9jb3VudBgIIAEoDRImCgtGRkxNTkFKT0RQRhgKIAEoCzIRLk1vZmlN",
            "b2RpZmllckxpc3QSLQoRYWRkX2RpY2VfbW9kaWZpZXIYxwMgASgLMhEuTW9m",
            "aU1vZGlmaWVyTGlzdBIWCg5kaWNlX2JyYW5jaF9pZBgMIAEoDRImCglkaWNl",
            "X3R5cGUYBiABKA4yEy5DaGVzc1JvZ3VlRGljZVR5cGUSKgoLZGljZV9zdGF0",
            "dXMYBSABKA4yFS5DaGVzc1JvZ3VlRGljZVN0YXR1cxITCgtLTk5KSkNCT05I",
            "ThgEIAEoDRITCgtPR0xKQ0VJRE5OQhgBIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueDiceReflection.Descriptor, global::EggLink.DanhengServer.Proto.MofiModifierListReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueDiceStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueDiceData), global::EggLink.DanhengServer.Proto.ChessRogueDiceData.Parser, new[]{ "CurSurface", "BCHMNMBELLF", "CurDice", "GKAOCPBKNML", "ENKBOLCPKFB", "LFAJDOAPDCE", "BranchId", "RerollCount", "PHPGNFGDPLC", "CheatCount", "FFLMNAJODPF", "AddDiceModifier", "DiceBranchId", "DiceType", "DiceStatus", "KNNJJCBONHN", "OGLJCEIDNNB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueDiceData : pb::IMessage<ChessRogueDiceData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueDiceData> _parser = new pb::MessageParser<ChessRogueDiceData>(() => new ChessRogueDiceData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueDiceData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueDiceDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDiceData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDiceData(ChessRogueDiceData other) : this() {
      curSurface_ = other.curSurface_;
      bCHMNMBELLF_ = other.bCHMNMBELLF_.Clone();
      curDice_ = other.curDice_ != null ? other.curDice_.Clone() : null;
      gKAOCPBKNML_ = other.gKAOCPBKNML_;
      eNKBOLCPKFB_ = other.eNKBOLCPKFB_;
      lFAJDOAPDCE_ = other.lFAJDOAPDCE_;
      branchId_ = other.branchId_;
      rerollCount_ = other.rerollCount_;
      pHPGNFGDPLC_ = other.pHPGNFGDPLC_;
      cheatCount_ = other.cheatCount_;
      fFLMNAJODPF_ = other.fFLMNAJODPF_ != null ? other.fFLMNAJODPF_.Clone() : null;
      addDiceModifier_ = other.addDiceModifier_ != null ? other.addDiceModifier_.Clone() : null;
      diceBranchId_ = other.diceBranchId_;
      diceType_ = other.diceType_;
      diceStatus_ = other.diceStatus_;
      kNNJJCBONHN_ = other.kNNJJCBONHN_;
      oGLJCEIDNNB_ = other.oGLJCEIDNNB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDiceData Clone() {
      return new ChessRogueDiceData(this);
    }

    /// <summary>Field number for the "cur_surface" field.</summary>
    public const int CurSurfaceFieldNumber = 9;
    private uint curSurface_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSurface {
      get { return curSurface_; }
      set {
        curSurface_ = value;
      }
    }

    /// <summary>Field number for the "BCHMNMBELLF" field.</summary>
    public const int BCHMNMBELLFFieldNumber = 442;
    private static readonly pb::FieldCodec<uint> _repeated_bCHMNMBELLF_codec
        = pb::FieldCodec.ForUInt32(3538);
    private readonly pbc::RepeatedField<uint> bCHMNMBELLF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BCHMNMBELLF {
      get { return bCHMNMBELLF_; }
    }

    /// <summary>Field number for the "cur_dice" field.</summary>
    public const int CurDiceFieldNumber = 1545;
    private global::EggLink.DanhengServer.Proto.ChessRogueDice curDice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDice CurDice {
      get { return curDice_; }
      set {
        curDice_ = value;
      }
    }

    /// <summary>Field number for the "GKAOCPBKNML" field.</summary>
    public const int GKAOCPBKNMLFieldNumber = 2;
    private uint gKAOCPBKNML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GKAOCPBKNML {
      get { return gKAOCPBKNML_; }
      set {
        gKAOCPBKNML_ = value;
      }
    }

    /// <summary>Field number for the "ENKBOLCPKFB" field.</summary>
    public const int ENKBOLCPKFBFieldNumber = 1710;
    private bool eNKBOLCPKFB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ENKBOLCPKFB {
      get { return eNKBOLCPKFB_; }
      set {
        eNKBOLCPKFB_ = value;
      }
    }

    /// <summary>Field number for the "LFAJDOAPDCE" field.</summary>
    public const int LFAJDOAPDCEFieldNumber = 751;
    private int lFAJDOAPDCE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LFAJDOAPDCE {
      get { return lFAJDOAPDCE_; }
      set {
        lFAJDOAPDCE_ = value;
      }
    }

    /// <summary>Field number for the "branch_id" field.</summary>
    public const int BranchIdFieldNumber = 13;
    private uint branchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BranchId {
      get { return branchId_; }
      set {
        branchId_ = value;
      }
    }

    /// <summary>Field number for the "reroll_count" field.</summary>
    public const int RerollCountFieldNumber = 11;
    private uint rerollCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RerollCount {
      get { return rerollCount_; }
      set {
        rerollCount_ = value;
      }
    }

    /// <summary>Field number for the "PHPGNFGDPLC" field.</summary>
    public const int PHPGNFGDPLCFieldNumber = 7;
    private bool pHPGNFGDPLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PHPGNFGDPLC {
      get { return pHPGNFGDPLC_; }
      set {
        pHPGNFGDPLC_ = value;
      }
    }

    /// <summary>Field number for the "cheat_count" field.</summary>
    public const int CheatCountFieldNumber = 8;
    private uint cheatCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CheatCount {
      get { return cheatCount_; }
      set {
        cheatCount_ = value;
      }
    }

    /// <summary>Field number for the "FFLMNAJODPF" field.</summary>
    public const int FFLMNAJODPFFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.MofiModifierList fFLMNAJODPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MofiModifierList FFLMNAJODPF {
      get { return fFLMNAJODPF_; }
      set {
        fFLMNAJODPF_ = value;
      }
    }

    /// <summary>Field number for the "add_dice_modifier" field.</summary>
    public const int AddDiceModifierFieldNumber = 455;
    private global::EggLink.DanhengServer.Proto.MofiModifierList addDiceModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MofiModifierList AddDiceModifier {
      get { return addDiceModifier_; }
      set {
        addDiceModifier_ = value;
      }
    }

    /// <summary>Field number for the "dice_branch_id" field.</summary>
    public const int DiceBranchIdFieldNumber = 12;
    private uint diceBranchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiceBranchId {
      get { return diceBranchId_; }
      set {
        diceBranchId_ = value;
      }
    }

    /// <summary>Field number for the "dice_type" field.</summary>
    public const int DiceTypeFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceType diceType_ = global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceType DiceType {
      get { return diceType_; }
      set {
        diceType_ = value;
      }
    }

    /// <summary>Field number for the "dice_status" field.</summary>
    public const int DiceStatusFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus diceStatus_ = global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus DiceStatus {
      get { return diceStatus_; }
      set {
        diceStatus_ = value;
      }
    }

    /// <summary>Field number for the "KNNJJCBONHN" field.</summary>
    public const int KNNJJCBONHNFieldNumber = 4;
    private uint kNNJJCBONHN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KNNJJCBONHN {
      get { return kNNJJCBONHN_; }
      set {
        kNNJJCBONHN_ = value;
      }
    }

    /// <summary>Field number for the "OGLJCEIDNNB" field.</summary>
    public const int OGLJCEIDNNBFieldNumber = 1;
    private uint oGLJCEIDNNB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGLJCEIDNNB {
      get { return oGLJCEIDNNB_; }
      set {
        oGLJCEIDNNB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueDiceData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueDiceData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurSurface != other.CurSurface) return false;
      if(!bCHMNMBELLF_.Equals(other.bCHMNMBELLF_)) return false;
      if (!object.Equals(CurDice, other.CurDice)) return false;
      if (GKAOCPBKNML != other.GKAOCPBKNML) return false;
      if (ENKBOLCPKFB != other.ENKBOLCPKFB) return false;
      if (LFAJDOAPDCE != other.LFAJDOAPDCE) return false;
      if (BranchId != other.BranchId) return false;
      if (RerollCount != other.RerollCount) return false;
      if (PHPGNFGDPLC != other.PHPGNFGDPLC) return false;
      if (CheatCount != other.CheatCount) return false;
      if (!object.Equals(FFLMNAJODPF, other.FFLMNAJODPF)) return false;
      if (!object.Equals(AddDiceModifier, other.AddDiceModifier)) return false;
      if (DiceBranchId != other.DiceBranchId) return false;
      if (DiceType != other.DiceType) return false;
      if (DiceStatus != other.DiceStatus) return false;
      if (KNNJJCBONHN != other.KNNJJCBONHN) return false;
      if (OGLJCEIDNNB != other.OGLJCEIDNNB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurSurface != 0) hash ^= CurSurface.GetHashCode();
      hash ^= bCHMNMBELLF_.GetHashCode();
      if (curDice_ != null) hash ^= CurDice.GetHashCode();
      if (GKAOCPBKNML != 0) hash ^= GKAOCPBKNML.GetHashCode();
      if (ENKBOLCPKFB != false) hash ^= ENKBOLCPKFB.GetHashCode();
      if (LFAJDOAPDCE != 0) hash ^= LFAJDOAPDCE.GetHashCode();
      if (BranchId != 0) hash ^= BranchId.GetHashCode();
      if (RerollCount != 0) hash ^= RerollCount.GetHashCode();
      if (PHPGNFGDPLC != false) hash ^= PHPGNFGDPLC.GetHashCode();
      if (CheatCount != 0) hash ^= CheatCount.GetHashCode();
      if (fFLMNAJODPF_ != null) hash ^= FFLMNAJODPF.GetHashCode();
      if (addDiceModifier_ != null) hash ^= AddDiceModifier.GetHashCode();
      if (DiceBranchId != 0) hash ^= DiceBranchId.GetHashCode();
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) hash ^= DiceType.GetHashCode();
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) hash ^= DiceStatus.GetHashCode();
      if (KNNJJCBONHN != 0) hash ^= KNNJJCBONHN.GetHashCode();
      if (OGLJCEIDNNB != 0) hash ^= OGLJCEIDNNB.GetHashCode();
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
      if (OGLJCEIDNNB != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OGLJCEIDNNB);
      }
      if (GKAOCPBKNML != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GKAOCPBKNML);
      }
      if (KNNJJCBONHN != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KNNJJCBONHN);
      }
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DiceStatus);
      }
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        output.WriteRawTag(48);
        output.WriteEnum((int) DiceType);
      }
      if (PHPGNFGDPLC != false) {
        output.WriteRawTag(56);
        output.WriteBool(PHPGNFGDPLC);
      }
      if (CheatCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CheatCount);
      }
      if (CurSurface != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurSurface);
      }
      if (fFLMNAJODPF_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(FFLMNAJODPF);
      }
      if (RerollCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RerollCount);
      }
      if (DiceBranchId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DiceBranchId);
      }
      if (BranchId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BranchId);
      }
      bCHMNMBELLF_.WriteTo(output, _repeated_bCHMNMBELLF_codec);
      if (addDiceModifier_ != null) {
        output.WriteRawTag(186, 28);
        output.WriteMessage(AddDiceModifier);
      }
      if (LFAJDOAPDCE != 0) {
        output.WriteRawTag(248, 46);
        output.WriteInt32(LFAJDOAPDCE);
      }
      if (curDice_ != null) {
        output.WriteRawTag(202, 96);
        output.WriteMessage(CurDice);
      }
      if (ENKBOLCPKFB != false) {
        output.WriteRawTag(240, 106);
        output.WriteBool(ENKBOLCPKFB);
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
      if (OGLJCEIDNNB != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OGLJCEIDNNB);
      }
      if (GKAOCPBKNML != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GKAOCPBKNML);
      }
      if (KNNJJCBONHN != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KNNJJCBONHN);
      }
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DiceStatus);
      }
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        output.WriteRawTag(48);
        output.WriteEnum((int) DiceType);
      }
      if (PHPGNFGDPLC != false) {
        output.WriteRawTag(56);
        output.WriteBool(PHPGNFGDPLC);
      }
      if (CheatCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CheatCount);
      }
      if (CurSurface != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurSurface);
      }
      if (fFLMNAJODPF_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(FFLMNAJODPF);
      }
      if (RerollCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RerollCount);
      }
      if (DiceBranchId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DiceBranchId);
      }
      if (BranchId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BranchId);
      }
      bCHMNMBELLF_.WriteTo(ref output, _repeated_bCHMNMBELLF_codec);
      if (addDiceModifier_ != null) {
        output.WriteRawTag(186, 28);
        output.WriteMessage(AddDiceModifier);
      }
      if (LFAJDOAPDCE != 0) {
        output.WriteRawTag(248, 46);
        output.WriteInt32(LFAJDOAPDCE);
      }
      if (curDice_ != null) {
        output.WriteRawTag(202, 96);
        output.WriteMessage(CurDice);
      }
      if (ENKBOLCPKFB != false) {
        output.WriteRawTag(240, 106);
        output.WriteBool(ENKBOLCPKFB);
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
      if (CurSurface != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSurface);
      }
      size += bCHMNMBELLF_.CalculateSize(_repeated_bCHMNMBELLF_codec);
      if (curDice_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CurDice);
      }
      if (GKAOCPBKNML != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GKAOCPBKNML);
      }
      if (ENKBOLCPKFB != false) {
        size += 2 + 1;
      }
      if (LFAJDOAPDCE != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(LFAJDOAPDCE);
      }
      if (BranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BranchId);
      }
      if (RerollCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RerollCount);
      }
      if (PHPGNFGDPLC != false) {
        size += 1 + 1;
      }
      if (CheatCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CheatCount);
      }
      if (fFLMNAJODPF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FFLMNAJODPF);
      }
      if (addDiceModifier_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(AddDiceModifier);
      }
      if (DiceBranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiceBranchId);
      }
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DiceType);
      }
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DiceStatus);
      }
      if (KNNJJCBONHN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KNNJJCBONHN);
      }
      if (OGLJCEIDNNB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGLJCEIDNNB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueDiceData other) {
      if (other == null) {
        return;
      }
      if (other.CurSurface != 0) {
        CurSurface = other.CurSurface;
      }
      bCHMNMBELLF_.Add(other.bCHMNMBELLF_);
      if (other.curDice_ != null) {
        if (curDice_ == null) {
          CurDice = new global::EggLink.DanhengServer.Proto.ChessRogueDice();
        }
        CurDice.MergeFrom(other.CurDice);
      }
      if (other.GKAOCPBKNML != 0) {
        GKAOCPBKNML = other.GKAOCPBKNML;
      }
      if (other.ENKBOLCPKFB != false) {
        ENKBOLCPKFB = other.ENKBOLCPKFB;
      }
      if (other.LFAJDOAPDCE != 0) {
        LFAJDOAPDCE = other.LFAJDOAPDCE;
      }
      if (other.BranchId != 0) {
        BranchId = other.BranchId;
      }
      if (other.RerollCount != 0) {
        RerollCount = other.RerollCount;
      }
      if (other.PHPGNFGDPLC != false) {
        PHPGNFGDPLC = other.PHPGNFGDPLC;
      }
      if (other.CheatCount != 0) {
        CheatCount = other.CheatCount;
      }
      if (other.fFLMNAJODPF_ != null) {
        if (fFLMNAJODPF_ == null) {
          FFLMNAJODPF = new global::EggLink.DanhengServer.Proto.MofiModifierList();
        }
        FFLMNAJODPF.MergeFrom(other.FFLMNAJODPF);
      }
      if (other.addDiceModifier_ != null) {
        if (addDiceModifier_ == null) {
          AddDiceModifier = new global::EggLink.DanhengServer.Proto.MofiModifierList();
        }
        AddDiceModifier.MergeFrom(other.AddDiceModifier);
      }
      if (other.DiceBranchId != 0) {
        DiceBranchId = other.DiceBranchId;
      }
      if (other.DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        DiceType = other.DiceType;
      }
      if (other.DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        DiceStatus = other.DiceStatus;
      }
      if (other.KNNJJCBONHN != 0) {
        KNNJJCBONHN = other.KNNJJCBONHN;
      }
      if (other.OGLJCEIDNNB != 0) {
        OGLJCEIDNNB = other.OGLJCEIDNNB;
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
          case 8: {
            OGLJCEIDNNB = input.ReadUInt32();
            break;
          }
          case 16: {
            GKAOCPBKNML = input.ReadUInt32();
            break;
          }
          case 32: {
            KNNJJCBONHN = input.ReadUInt32();
            break;
          }
          case 40: {
            DiceStatus = (global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus) input.ReadEnum();
            break;
          }
          case 48: {
            DiceType = (global::EggLink.DanhengServer.Proto.ChessRogueDiceType) input.ReadEnum();
            break;
          }
          case 56: {
            PHPGNFGDPLC = input.ReadBool();
            break;
          }
          case 64: {
            CheatCount = input.ReadUInt32();
            break;
          }
          case 72: {
            CurSurface = input.ReadUInt32();
            break;
          }
          case 82: {
            if (fFLMNAJODPF_ == null) {
              FFLMNAJODPF = new global::EggLink.DanhengServer.Proto.MofiModifierList();
            }
            input.ReadMessage(FFLMNAJODPF);
            break;
          }
          case 88: {
            RerollCount = input.ReadUInt32();
            break;
          }
          case 96: {
            DiceBranchId = input.ReadUInt32();
            break;
          }
          case 104: {
            BranchId = input.ReadUInt32();
            break;
          }
          case 3538:
          case 3536: {
            bCHMNMBELLF_.AddEntriesFrom(input, _repeated_bCHMNMBELLF_codec);
            break;
          }
          case 3642: {
            if (addDiceModifier_ == null) {
              AddDiceModifier = new global::EggLink.DanhengServer.Proto.MofiModifierList();
            }
            input.ReadMessage(AddDiceModifier);
            break;
          }
          case 6008: {
            LFAJDOAPDCE = input.ReadInt32();
            break;
          }
          case 12362: {
            if (curDice_ == null) {
              CurDice = new global::EggLink.DanhengServer.Proto.ChessRogueDice();
            }
            input.ReadMessage(CurDice);
            break;
          }
          case 13680: {
            ENKBOLCPKFB = input.ReadBool();
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
          case 8: {
            OGLJCEIDNNB = input.ReadUInt32();
            break;
          }
          case 16: {
            GKAOCPBKNML = input.ReadUInt32();
            break;
          }
          case 32: {
            KNNJJCBONHN = input.ReadUInt32();
            break;
          }
          case 40: {
            DiceStatus = (global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus) input.ReadEnum();
            break;
          }
          case 48: {
            DiceType = (global::EggLink.DanhengServer.Proto.ChessRogueDiceType) input.ReadEnum();
            break;
          }
          case 56: {
            PHPGNFGDPLC = input.ReadBool();
            break;
          }
          case 64: {
            CheatCount = input.ReadUInt32();
            break;
          }
          case 72: {
            CurSurface = input.ReadUInt32();
            break;
          }
          case 82: {
            if (fFLMNAJODPF_ == null) {
              FFLMNAJODPF = new global::EggLink.DanhengServer.Proto.MofiModifierList();
            }
            input.ReadMessage(FFLMNAJODPF);
            break;
          }
          case 88: {
            RerollCount = input.ReadUInt32();
            break;
          }
          case 96: {
            DiceBranchId = input.ReadUInt32();
            break;
          }
          case 104: {
            BranchId = input.ReadUInt32();
            break;
          }
          case 3538:
          case 3536: {
            bCHMNMBELLF_.AddEntriesFrom(ref input, _repeated_bCHMNMBELLF_codec);
            break;
          }
          case 3642: {
            if (addDiceModifier_ == null) {
              AddDiceModifier = new global::EggLink.DanhengServer.Proto.MofiModifierList();
            }
            input.ReadMessage(AddDiceModifier);
            break;
          }
          case 6008: {
            LFAJDOAPDCE = input.ReadInt32();
            break;
          }
          case 12362: {
            if (curDice_ == null) {
              CurDice = new global::EggLink.DanhengServer.Proto.ChessRogueDice();
            }
            input.ReadMessage(CurDice);
            break;
          }
          case 13680: {
            ENKBOLCPKFB = input.ReadBool();
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
