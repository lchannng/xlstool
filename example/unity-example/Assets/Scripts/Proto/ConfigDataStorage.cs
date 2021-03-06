// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ConfigDataStorage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MyGame {

  /// <summary>Holder for reflection information generated from ConfigDataStorage.proto</summary>
  public static partial class ConfigDataStorageReflection {

    #region Descriptor
    /// <summary>File descriptor for ConfigDataStorage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigDataStorageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDb25maWdEYXRhU3RvcmFnZS5wcm90bxIGTXlHYW1lGgtHb29kcy5wcm90",
            "bxoLU2tpbGwucHJvdG8iWwoRQ29uZmlnRGF0YVN0b3JhZ2USIgoLR29vZHNf",
            "aXRlbXMYASADKAsyDS5NeUdhbWUuR29vZHMSIgoLU2tpbGxfaXRlbXMYAiAD",
            "KAsyDS5NeUdhbWUuU2tpbGxiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MyGame.GoodsReflection.Descriptor, global::MyGame.SkillReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MyGame.ConfigDataStorage), global::MyGame.ConfigDataStorage.Parser, new[]{ "GoodsItems", "SkillItems" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ConfigDataStorage : pb::IMessage<ConfigDataStorage> {
    private static readonly pb::MessageParser<ConfigDataStorage> _parser = new pb::MessageParser<ConfigDataStorage>(() => new ConfigDataStorage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConfigDataStorage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MyGame.ConfigDataStorageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigDataStorage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigDataStorage(ConfigDataStorage other) : this() {
      goodsItems_ = other.goodsItems_.Clone();
      skillItems_ = other.skillItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigDataStorage Clone() {
      return new ConfigDataStorage(this);
    }

    /// <summary>Field number for the "Goods_items" field.</summary>
    public const int GoodsItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MyGame.Goods> _repeated_goodsItems_codec
        = pb::FieldCodec.ForMessage(10, global::MyGame.Goods.Parser);
    private readonly pbc::RepeatedField<global::MyGame.Goods> goodsItems_ = new pbc::RepeatedField<global::MyGame.Goods>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::MyGame.Goods> GoodsItems {
      get { return goodsItems_; }
    }

    /// <summary>Field number for the "Skill_items" field.</summary>
    public const int SkillItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::MyGame.Skill> _repeated_skillItems_codec
        = pb::FieldCodec.ForMessage(18, global::MyGame.Skill.Parser);
    private readonly pbc::RepeatedField<global::MyGame.Skill> skillItems_ = new pbc::RepeatedField<global::MyGame.Skill>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::MyGame.Skill> SkillItems {
      get { return skillItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConfigDataStorage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConfigDataStorage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!goodsItems_.Equals(other.goodsItems_)) return false;
      if(!skillItems_.Equals(other.skillItems_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= goodsItems_.GetHashCode();
      hash ^= skillItems_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      goodsItems_.WriteTo(output, _repeated_goodsItems_codec);
      skillItems_.WriteTo(output, _repeated_skillItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += goodsItems_.CalculateSize(_repeated_goodsItems_codec);
      size += skillItems_.CalculateSize(_repeated_skillItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConfigDataStorage other) {
      if (other == null) {
        return;
      }
      goodsItems_.Add(other.goodsItems_);
      skillItems_.Add(other.skillItems_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            goodsItems_.AddEntriesFrom(input, _repeated_goodsItems_codec);
            break;
          }
          case 18: {
            skillItems_.AddEntriesFrom(input, _repeated_skillItems_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
