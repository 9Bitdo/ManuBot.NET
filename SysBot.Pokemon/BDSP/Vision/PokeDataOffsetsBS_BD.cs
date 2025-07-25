using System.Collections.Generic;

namespace SysBot.Pokemon;

public class PokeDataOffsetsBS_BD : BasePokeDataOffsetsBS
{
    public override IReadOnlyList<long> BoxStartPokemonPointer         { get; } = [0x4C64DC0, 0xB8, 0x10, 0xA0, 0x20, 0x20, 0x20];

    public override IReadOnlyList<long> LinkTradePartnerPokemonPointer { get; } = [0x4C603B0, 0xB8, 0x8, 0x20];
    public override IReadOnlyList<long> LinkTradePartnerNamePointer    { get; } = [0x4C658D0, 0xB8, 0x30, 0x110, 0x28, 0x90, 0x20, 0x0];
    public override IReadOnlyList<long> LinkTradePartnerInfoPointer { get; } = [0x4C658D0, 0xB8, 0x30, 0x110, 0x28, 0x90, 0x14];
    public override IReadOnlyList<long> LinkTradePartnerIDPointer      { get; } = [0x4C658D0, 0xB8, 0x30, 0x110, 0x28, 0x90, 0x10];
    public override IReadOnlyList<long> LinkTradePartnerParamPointer   { get; } = [0x4C658D0, 0xB8, 0x30, 0x110, 0x28, 0x90];
    public override IReadOnlyList<long> LinkTradePartnerNIDPointer     { get; } = [0x4FFE810, 0x70, 0x168, 0x40]; // todo for multi-user Union Room; limited penalties available.

    public override IReadOnlyList<long> SceneIDPointer                 { get; } = [0x4C59B50, 0xB8, 0x18];

    // Union Work - Detects states in the Union Room
    public override IReadOnlyList<long> UnionWorkIsGamingPointer       { get; } = [0x4C59C98, 0xB8, 0x3C]; // 1 when loaded into Union Room, 0 otherwise
    public override IReadOnlyList<long> UnionWorkIsTalkingPointer      { get; } = [0x4C59C98, 0xB8, 0x85];  // 1 when talking to another player or in box, 0 otherwise
    public override IReadOnlyList<long> UnionWorkPenaltyPointer        { get; } = [0x4C59C98, 0xB8, 0x90]; // 0 when no penalty, float value otherwise.

    public override IReadOnlyList<long> MyStatusTrainerPointer         { get; } = [0x4C64DC0, 0xB8, 0x10, 0xE0, 0x0];
    public override IReadOnlyList<long> MyStatusTIDPointer             { get; } = [0x4C64DC0, 0xB8, 0x10, 0xE8];
    public override IReadOnlyList<long> ConfigTextSpeedPointer         { get; } = [0x4C64DC0, 0xB8, 0x10, 0xA8];
    public override IReadOnlyList<long> ConfigLanguagePointer          { get; } = [0x4C64DC0, 0xB8, 0x10, 0xAC];
}
