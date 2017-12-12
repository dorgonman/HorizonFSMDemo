// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class HorizonFSMDemoTarget : TargetRules
{
	public HorizonFSMDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "HorizonFSMDemo" } );
	}
}
