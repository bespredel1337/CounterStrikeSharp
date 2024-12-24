// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CSmokeGrenadeProjectile : CBaseCSGrenadeProjectile
{
    public CSmokeGrenadeProjectile (IntPtr pointer) : base(pointer) {}

	// m_nSmokeEffectTickBegin
	[SchemaMember("CSmokeGrenadeProjectile", "m_nSmokeEffectTickBegin")]
	public ref Int32 SmokeEffectTickBegin => ref Schema.GetRef<Int32>(this.Handle, "CSmokeGrenadeProjectile", "m_nSmokeEffectTickBegin");

	// m_bDidSmokeEffect
	[SchemaMember("CSmokeGrenadeProjectile", "m_bDidSmokeEffect")]
	public ref bool DidSmokeEffect => ref Schema.GetRef<bool>(this.Handle, "CSmokeGrenadeProjectile", "m_bDidSmokeEffect");

	// m_nRandomSeed
	[SchemaMember("CSmokeGrenadeProjectile", "m_nRandomSeed")]
	public ref Int32 RandomSeed => ref Schema.GetRef<Int32>(this.Handle, "CSmokeGrenadeProjectile", "m_nRandomSeed");

	// m_vSmokeColor
	[SchemaMember("CSmokeGrenadeProjectile", "m_vSmokeColor")]
	public Vector SmokeColor => Schema.GetDeclaredClass<Vector>(this.Handle, "CSmokeGrenadeProjectile", "m_vSmokeColor");

	// m_vSmokeDetonationPos
	[SchemaMember("CSmokeGrenadeProjectile", "m_vSmokeDetonationPos")]
	public Vector SmokeDetonationPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CSmokeGrenadeProjectile", "m_vSmokeDetonationPos");

	// m_VoxelFrameData
	[SchemaMember("CSmokeGrenadeProjectile", "m_VoxelFrameData")]
	public NetworkedVector<byte> VoxelFrameData => Schema.GetDeclaredClass<NetworkedVector<byte>>(this.Handle, "CSmokeGrenadeProjectile", "m_VoxelFrameData");

	// m_nVoxelFrameDataSize
	[SchemaMember("CSmokeGrenadeProjectile", "m_nVoxelFrameDataSize")]
	public ref Int32 VoxelFrameDataSize => ref Schema.GetRef<Int32>(this.Handle, "CSmokeGrenadeProjectile", "m_nVoxelFrameDataSize");

	// m_nVoxelUpdate
	[SchemaMember("CSmokeGrenadeProjectile", "m_nVoxelUpdate")]
	public ref Int32 VoxelUpdate => ref Schema.GetRef<Int32>(this.Handle, "CSmokeGrenadeProjectile", "m_nVoxelUpdate");

	// m_flLastBounce
	[SchemaMember("CSmokeGrenadeProjectile", "m_flLastBounce")]
	public ref float LastBounce => ref Schema.GetRef<float>(this.Handle, "CSmokeGrenadeProjectile", "m_flLastBounce");

	// m_fllastSimulationTime
	[SchemaMember("CSmokeGrenadeProjectile", "m_fllastSimulationTime")]
	public ref float FllastSimulationTime => ref Schema.GetRef<float>(this.Handle, "CSmokeGrenadeProjectile", "m_fllastSimulationTime");

	// m_bExplodeFromInferno
	[SchemaMember("CSmokeGrenadeProjectile", "m_bExplodeFromInferno")]
	public ref bool ExplodeFromInferno => ref Schema.GetRef<bool>(this.Handle, "CSmokeGrenadeProjectile", "m_bExplodeFromInferno");

}
